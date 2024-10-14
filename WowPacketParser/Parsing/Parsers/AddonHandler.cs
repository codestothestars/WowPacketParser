using WowPacketParser.Enums;
using WowPacketParser.Misc;

namespace WowPacketParser.Parsing.Parsers
{
    public static class AddonHandler
    {
        private static int _addonCount = -1;

        public static void ReadClientAddonsList(Packet packet)
        {
            var decompCount = packet.ReadInt32();
            if (decompCount == 0)
                return;

            var newPacket = packet.Inflate(decompCount, false);

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_0_8_9464))
            {
                var count = newPacket.ReadInt32("Addons Count");
                _addonCount = count;

                for (var i = 0; i < count; i++)
                {
                    newPacket.ReadCString("Name", i);
                    newPacket.ReadBool("Uses public key", i);
                    newPacket.ReadInt32("Public key CRC", i);
                    newPacket.ReadInt32("URL file CRC", i);
                }

                newPacket.ReadTime("Time");
            }
            else
            {
                if (ClientVersion.RemovedInVersion(1, 11, 0))
                {
                    newPacket.ReadSByte("Unknown1");
                    newPacket.ReadUInt32("Unknown2");
                }

                int count = 0;

                while (newPacket.Position != newPacket.Length)
                {
                    newPacket.ReadCString("Name");
                    newPacket.ReadBool("Uses public key");
                    newPacket.ReadInt32("Public key CRC");
                    newPacket.ReadInt32("URL file CRC");

                    count++;
                }

                _addonCount = count;
            }

            newPacket.ClosePacket(false);
        }

        [Parser(Opcode.SMSG_ADDON_INFO, ClientVersionBuild.Zero, ClientVersionBuild.V1_11_0_5344)]
        public static void HandleServerAddonsListVanilla(Packet packet)
        {
            // This packet requires _addonCount from CMSG_AUTH_SESSION to be parsed.
            if (_addonCount == -1)
            {
                packet.AddValue("Error", "CMSG_AUTH_SESSION was not received - cannot successfully parse this packet.");
                packet.ReadToEnd();
                return;
            }

            if (packet.ReadBool("InfoProvided", "WowDev"))
            {
                if (packet.ReadBool("KeyProvided", "WowDev"))
                    packet.ReadBytes("KeyData", 256, "WowDev");
            }

            for (var i = 0; i < _addonCount; i++)
            {
                packet.ReadByteE<SecureAddonStatus>("Status", i);
                if (packet.ReadBool("InfoProvided", i))
                {
                    if (packet.ReadBool("KeyProvided", i))
                        packet.ReadBytes("KeyData", 256);

                    packet.ReadInt32("Revision", i);
                }
                if (packet.ReadBool("UrlProvided", i))
                    packet.ReadCString("Url", i);
            }
        }

        [Parser(Opcode.SMSG_ADDON_INFO)]
        public static void HandleServerAddonsList(Packet packet)
        {
            // This packet requires _addonCount from CMSG_AUTH_SESSION to be parsed.
            if (_addonCount == -1)
            {
                packet.AddValue("Error", "CMSG_AUTH_SESSION was not received - cannot successfully parse this packet.");
                packet.ReadToEnd();
                return;
            }

            for (var i = 0; i < _addonCount; i++)
            {
                packet.ReadByteE<SecureAddonStatus>("Status", i);
                if (packet.ReadBool("InfoProvided", i))
                {
                    if (packet.ReadBool("KeyProvided", i))
                        packet.ReadBytes("KeyData", 256);

                    packet.ReadInt32("Revision", i);
                }

                if (packet.ReadBool("UrlProvided", i))
                    packet.ReadCString("Url", i);
            }

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_0_8_9464))
            {
                var bannedCount = packet.ReadInt32("Banned Addons Count");

                for (var i = 0; i < bannedCount; i++)
                {
                    packet.ReadInt32("ID", i);
                    packet.ReadBytes("Name MD5", 16);
                    packet.ReadBytes("Version MD5", 16);
                    packet.ReadTime("Time", i);

                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_3_3a_11723))
                        packet.ReadInt32("Is banned", i);
                }
            }
        }

        // Changed on 4.3.0, bitshifted
        [Parser(Opcode.CMSG_ADDON_REGISTERED_PREFIXES, ClientVersionBuild.V4_1_0_13914, ClientVersionBuild.V4_3_0_15005)]
        public static void HandleAddonPrefixes(Packet packet)
        {
            var count = packet.ReadUInt32("Count");
            for (var i = 0; i < count; ++i)
                packet.ReadCString("Addon", i);
        }

        [Parser(Opcode.CMSG_ADDON_REGISTERED_PREFIXES, ClientVersionBuild.V4_3_0_15005)]
        public static void HandleAddonPrefixes434(Packet packet)
        {
            var count = packet.ReadBits("Count", 25);
            var lengths = new int[count];
            for (var i = 0; i < count; ++i)
                lengths[i] = (int)packet.ReadBits(5);

            for (var i = 0; i < count; ++i)
                packet.ReadWoWString("Addon", lengths[i], i);
        }

        [Parser(Opcode.CMSG_CHAT_UNREGISTER_ALL_ADDON_PREFIXES)]
        public static void HandleAddonNull(Packet packet)
        {
        }
    }
}
