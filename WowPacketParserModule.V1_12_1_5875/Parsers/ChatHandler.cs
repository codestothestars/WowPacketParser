using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using WowPacketParser.Enums;
using WowPacketParser.Enums.Version;
using WowPacketParser.Misc;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;


namespace WowPacketParser.Parsing.Parsers
{
    public static class ChatHandler
    {
                public static ChatMessageType ConvertBetaMessageType(ChatMessageTypeBeta type)
        {
            switch (type)
            {
                case ChatMessageTypeBeta.System:
                    return ChatMessageType.System;
                case ChatMessageTypeBeta.Say:
                    return ChatMessageType.Say;
                case ChatMessageTypeBeta.Party:
                    return ChatMessageType.Party;
                case ChatMessageTypeBeta.Guild:
                    return ChatMessageType.Guild;
                case ChatMessageTypeBeta.Officer:
                    return ChatMessageType.Officer;
                case ChatMessageTypeBeta.Yell:
                    return ChatMessageType.Yell;
                case ChatMessageTypeBeta.Whisper:
                    return ChatMessageType.Whisper;
                case ChatMessageTypeBeta.WhisperInform:
                    return ChatMessageType.WhisperInform;
                case ChatMessageTypeBeta.Emote:
                    return ChatMessageType.Emote;
                case ChatMessageTypeBeta.TextEmote:
                    return ChatMessageType.TextEmote;
                case ChatMessageTypeBeta.MonsterSay:
                    return ChatMessageType.MonsterSay;
                case ChatMessageTypeBeta.MonsterYell:
                    return ChatMessageType.MonsterYell;
                case ChatMessageTypeBeta.MonsterEmote:
                    return ChatMessageType.MonsterEmote;
                case ChatMessageTypeBeta.Channel:
                    return ChatMessageType.Channel;
                case ChatMessageTypeBeta.ChannelJoin:
                    return ChatMessageType.ChannelJoin;
                case ChatMessageTypeBeta.ChannelLeave:
                    return ChatMessageType.ChannelLeave;
                case ChatMessageTypeBeta.ChannelList:
                    return ChatMessageType.ChannelList;
                case ChatMessageTypeBeta.ChannelNotice:
                    return ChatMessageType.ChannelNotice;
                case ChatMessageTypeBeta.ChannelNoticeUser:
                    return ChatMessageType.ChannelNoticeUser;
                case ChatMessageTypeBeta.Afk:
                    return ChatMessageType.Afk;
                case ChatMessageTypeBeta.Dnd:
                    return ChatMessageType.Dnd;
                case ChatMessageTypeBeta.Ignored:
                    return ChatMessageType.Ignored;
                case ChatMessageTypeBeta.Skill:
                    return ChatMessageType.Skill;
                case ChatMessageTypeBeta.Loot:
                    return ChatMessageType.Loot;

            }
            return ChatMessageType.System;
        }

        public static ChatMessageType ConvertVanillaMessageType(ChatMessageTypeVanilla type)
        {
            switch (type)
            {
                case ChatMessageTypeVanilla.System:
                    return ChatMessageType.System;
                case ChatMessageTypeVanilla.Say:
                    return ChatMessageType.Say;
                case ChatMessageTypeVanilla.Party:
                    return ChatMessageType.Party;
                case ChatMessageTypeVanilla.Raid:
                    return ChatMessageType.Raid;
                case ChatMessageTypeVanilla.Guild:
                    return ChatMessageType.Guild;
                case ChatMessageTypeVanilla.Officer:
                    return ChatMessageType.Officer;
                case ChatMessageTypeVanilla.Yell:
                    return ChatMessageType.Yell;
                case ChatMessageTypeVanilla.Whisper:
                    return ChatMessageType.Whisper;
                case ChatMessageTypeVanilla.WhisperInform:
                    return ChatMessageType.WhisperInform;
                case ChatMessageTypeVanilla.Emote:
                    return ChatMessageType.Emote;
                case ChatMessageTypeVanilla.TextEmote:
                    return ChatMessageType.TextEmote;
                case ChatMessageTypeVanilla.MonsterSay:
                    return ChatMessageType.MonsterSay;
                case ChatMessageTypeVanilla.MonsterYell:
                    return ChatMessageType.MonsterYell;
                case ChatMessageTypeVanilla.MonsterEmote:
                    return ChatMessageType.MonsterEmote;
                case ChatMessageTypeVanilla.Channel:
                    return ChatMessageType.Channel;
                case ChatMessageTypeVanilla.ChannelJoin:
                    return ChatMessageType.ChannelJoin;
                case ChatMessageTypeVanilla.ChannelLeave:
                    return ChatMessageType.ChannelLeave;
                case ChatMessageTypeVanilla.ChannelList:
                    return ChatMessageType.ChannelList;
                case ChatMessageTypeVanilla.ChannelNotice:
                    return ChatMessageType.ChannelNotice;
                case ChatMessageTypeVanilla.ChannelNoticeUser:
                    return ChatMessageType.ChannelNoticeUser;
                case ChatMessageTypeVanilla.Afk:
                    return ChatMessageType.Afk;
                case ChatMessageTypeVanilla.Dnd:
                    return ChatMessageType.Dnd;
                case ChatMessageTypeVanilla.Ignored:
                    return ChatMessageType.Ignored;
                case ChatMessageTypeVanilla.Skill:
                    return ChatMessageType.Skill;
                case ChatMessageTypeVanilla.Loot:
                    return ChatMessageType.Loot;
                case ChatMessageTypeVanilla.MonsterWhisper:
                    return ChatMessageType.MonsterWhisper;
                case ChatMessageTypeVanilla.MonsterParty:
                    return ChatMessageType.MonsterParty;
                case ChatMessageTypeVanilla.BattlegroundNeutral:
                    return ChatMessageType.BattlegroundNeutral;
                case ChatMessageTypeVanilla.BattlegroundAlliance:
                    return ChatMessageType.BattlegroundAlliance;
                case ChatMessageTypeVanilla.BattlegroundHorde:
                    return ChatMessageType.BattlegroundHorde;
                case ChatMessageTypeVanilla.RaidLeader:
                    return ChatMessageType.RaidLeader;
                case ChatMessageTypeVanilla.RaidWarning:
                    return ChatMessageType.RaidWarning;
                case ChatMessageTypeVanilla.RaidBossEmote:
                    return ChatMessageType.RaidBossEmote;
                case ChatMessageTypeVanilla.RaidBossWhisper:
                    return ChatMessageType.RaidBossWhisper;
                case ChatMessageTypeVanilla.Battleground:
                    return ChatMessageType.Battleground;
                case ChatMessageTypeVanilla.BattlegroundLeader:
                    return ChatMessageType.BattlegroundLeader;

            }
            return ChatMessageType.System;
        }

        [Parser(Opcode.SMSG_CHAT)]
        [Parser(Opcode.SMSG_GM_MESSAGECHAT)]
        public static void HandleServerChatMessage(Packet packet)
        {
            var text = new ChatPacketData();
            text.SenderGUID = WowGuid64.Empty;
            if (ClientVersion.AddedInVersion(ClientVersionBuild.V0_10_0_3892))
            {
                ChatMessageTypeVanilla chatType = packet.ReadByteE<ChatMessageTypeVanilla>("Type");
                text.TypeNormalized = ConvertVanillaMessageType(chatType);
                text.TypeOriginal = (uint)chatType;
            }
            else
            {
                ChatMessageTypeBeta chatType = packet.ReadByteE<ChatMessageTypeBeta>("Type");
                text.TypeNormalized = ConvertBetaMessageType(chatType);
                text.TypeOriginal = (uint)chatType;
            }
            text.Language = packet.ReadInt32E<Language>("Language");

            switch (text.TypeNormalized)
            {
                case ChatMessageType.MonsterWhisper:
                //case CHAT_MSG_RAID_BOSS_WHISPER:
                case ChatMessageType.RaidBossEmote:
                case ChatMessageType.MonsterEmote:
                    packet.ReadUInt32("Sender Name Length");
                    text.SenderName = packet.ReadCString("Sender Name");
                    text.ReceiverGUID = packet.ReadGuid("Target Guid");
                    break;
                case ChatMessageType.Say:
                case ChatMessageType.Party:
                case ChatMessageType.Yell:
                    text.SenderGUID = packet.ReadGuid("Sender Guid");
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V0_10_0_3892))
                        packet.ReadGuid("Sender Guid");
                    break;
                case ChatMessageType.MonsterSay:
                case ChatMessageType.MonsterYell:
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V0_10_0_3892))
                        text.SenderGUID = packet.ReadGuid("Sender Guid");
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V0_10_0_3892))
                        packet.ReadUInt32("Sender Name Length");
                    text.SenderName = packet.ReadCString("Sender Name");
                    text.ReceiverGUID = packet.ReadGuid("Target Guid");
                    break;

                case ChatMessageType.Channel:
                    text.ChannelName = packet.ReadCString("Channel Name");
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V1_6_0_4470))
                        packet.ReadUInt32("Player Rank");
                    text.SenderGUID = packet.ReadGuid("Sender Guid");
                    break;

                default:
                    text.SenderGUID = packet.ReadGuid("Sender Guid");
                    break;
            }

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V0_10_0_3892))
                packet.ReadInt32("Text Length");
            text.Text = packet.ReadCString("Text");
            packet.ReadByteE<ChatTag>("Chat Tag");

            Storage.StoreText(text, packet);
        }

        [Parser(Opcode.CMSG_MESSAGECHAT)]
        public static void HandleClientChatMessage(Packet packet)
        {
            ChatMessageType typeNormalized;
            if (ClientVersion.AddedInVersion(ClientVersionBuild.V0_10_0_3892))
            {
                ChatMessageTypeVanilla chatType = packet.ReadInt32E<ChatMessageTypeVanilla>("Type");
                typeNormalized = ConvertVanillaMessageType(chatType);
            }
            else
            {
                ChatMessageTypeBeta chatType = packet.ReadInt32E<ChatMessageTypeBeta>("Type");
                typeNormalized = ConvertBetaMessageType(chatType);
            }
            packet.ReadInt32E<Language>("Language");

            switch (typeNormalized)
            {
                case ChatMessageType.Whisper:
                {
                    packet.ReadCString("Recipient");
                    break;
                }
                case ChatMessageType.Channel:
                {
                    packet.ReadCString("Channel");
                    break;
                }
            }

            packet.ReadCString("Message");
        }
    }
}
