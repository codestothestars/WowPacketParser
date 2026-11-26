using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WoWPacketParser.Proto;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;

namespace WowPacketParserModule.V8_0_1_27101.Parsers
{
    public static class ChatHandler
    {
        public static void ReadChatAddonMessageParams(Packet packet, params object[] indexes)
        {
            packet.ResetBitReader();
            var prefixLen = packet.ReadBits(5);
            uint textLen = 0;
            if (ClientVersion.AddedInVersion(ClientVersionBuild.V8_1_0_28724) && ClientVersion.RemovedInVersion(ClientVersionBuild.V8_1_5_29683))
                textLen = packet.ReadBits(9);
            else
                textLen = packet.ReadBits(8);
            packet.ReadBit("IsLogged", indexes);

            packet.ReadInt32("Type", indexes);
            packet.ReadWoWString("Prefix", prefixLen, indexes);
            packet.ReadWoWString("Text", textLen, indexes);
        }

        [Parser(Opcode.SMSG_CHAT)]
        public static void HandleServerChatMessage(Packet packet)
        {
            PacketChat chatPacket = packet.Holder.Chat = new PacketChat();
            var text = new CreatureTextTemplate
            {
                Type = (ChatMessageType)packet.ReadByteE<ChatMessageTypeNew>("SlashCmd"),
                Language = packet.ReadUInt32E<Language>("Language"),
                SenderGUID = packet.ReadPackedGuid128("SenderGUID")
            };

            packet.ReadPackedGuid128("SenderGuildGUID");
            packet.ReadPackedGuid128("WowAccountGUID");
            text.ReceiverGUID = packet.ReadPackedGuid128("TargetGUID");
            packet.ReadUInt32("TargetVirtualAddress");
            packet.ReadUInt32("SenderVirtualAddress");
            packet.ReadPackedGuid128("PartyGUID");
            packet.ReadInt32("AchievementID");
            packet.ReadSingle("DisplayTime");

            var senderNameLen = packet.ReadBits(11);
            var receiverNameLen = packet.ReadBits(11);
            var prefixLen = packet.ReadBits(5);
            uint channelLen = 0;
            if (ClientVersion.AddedInVersion(ClientVersionBuild.V8_1_0_28724))
                channelLen = packet.ReadBits(8);
            else
                channelLen = packet.ReadBits(7);
            var textLen = packet.ReadBits(12);
            var flags = packet.ReadBits("ChatFlags", 11);

            packet.ReadBit("HideChatLog");
            packet.ReadBit("FakeSenderName");
            bool unk801bit = packet.ReadBit("Unk801_Bit");

            text.SenderName = packet.ReadWoWString("Sender Name", senderNameLen);
            text.ReceiverName = packet.ReadWoWString("Receiver Name", receiverNameLen);
            packet.ReadWoWString("Addon Message Prefix", prefixLen);
            packet.ReadWoWString("Channel Name", channelLen);

            chatPacket.Text = text.Text = packet.ReadWoWString("Text", textLen);
            chatPacket.Sender = text.SenderGUID.ToUniversalGuid();
            chatPacket.Target = text.ReceiverGUID.ToUniversalGuid();
            chatPacket.Language = (int) text.Language;
            chatPacket.Type = (int) text.Type;
            chatPacket.Flags = flags;

            if (unk801bit)
                packet.ReadUInt32("Unk801");

            uint entry = 0;
            if (text.SenderGUID.GetObjectType() == ObjectType.Unit)
                entry = text.SenderGUID.GetEntry();
            else if (text.ReceiverGUID.GetObjectType() == ObjectType.Unit)
                entry = text.ReceiverGUID.GetEntry();

            if (entry != 0)
            {
                text.Time = packet.Time;
                Storage.CreatureTextTemplates.Add(entry, text, packet.TimeSpan);
                CreatureText textEntry = new CreatureText();
                textEntry.Entry = entry;
                textEntry.Text = text.Text;
                textEntry.UnixTimeMs = (ulong)Utilities.GetUnixTimeMsFromDateTime(packet.Time);
                textEntry.SenderGUID = text.SenderGUID;
                if (Storage.Objects.ContainsKey(text.SenderGUID))
                {
                    var obj = Storage.Objects[text.SenderGUID].Item1 as Unit;
                    textEntry.HealthPercent = obj.UnitData.HealthPercent;
                }
                Storage.CreatureTexts.Add(textEntry);
            }
            else if (text.SenderGUID.IsEmpty() && (text.ReceiverGUID == null || text.ReceiverGUID.IsEmpty()) &&
                    (text.Type == ChatMessageType.BattlegroundNeutral))
            {
                var worldText = new WorldText
                {
                    UnixTimeMs = (ulong)Utilities.GetUnixTimeMsFromDateTime(packet.Time),
                    Type = text.Type,
                    Language = text.Language,
                    Text = text.Text
                };
                Storage.WorldTexts.Add(worldText);
            }
        }

        [Parser(Opcode.CMSG_CHAT_ADDON_MESSAGE)]
        public static void HandleAddonMessage(Packet packet)
        {
            ReadChatAddonMessageParams(packet);
        }

        [Parser(Opcode.CMSG_CHAT_ADDON_MESSAGE_TARGETED)]
        public static void HandleChatAddonMessageTargeted(Packet packet)
        {
            var targetLen = packet.ReadBits(9);
            ReadChatAddonMessageParams(packet, "Params");
            if (ClientVersion.AddedInVersion(ClientVersionBuild.V9_1_0_39185))
                packet.ReadPackedGuid128("ChannelGUID");
            packet.ReadWoWString("Target", targetLen);
        }
    }
}
