using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("npc_text_old")]
    public class NpcText : IDataModel
    {
        public uint?[][] EmoteDelays;
        public EmoteType?[][] Emotes;

        public void ConvertToDBStruct()
        {
            EmoteDelay00 = EmoteDelays[0][0];
            EmoteDelay01 = EmoteDelays[0][1];
            EmoteDelay02 = EmoteDelays[0][2];
            EmoteDelay10 = EmoteDelays[1][0];
            EmoteDelay11 = EmoteDelays[1][1];
            EmoteDelay12 = EmoteDelays[1][2];
            EmoteDelay20 = EmoteDelays[2][0];
            EmoteDelay21 = EmoteDelays[2][1];
            EmoteDelay22 = EmoteDelays[2][2];
            EmoteDelay30 = EmoteDelays[3][0];
            EmoteDelay31 = EmoteDelays[3][1];
            EmoteDelay32 = EmoteDelays[3][2];
            EmoteDelay40 = EmoteDelays[4][0];
            EmoteDelay41 = EmoteDelays[4][1];
            EmoteDelay42 = EmoteDelays[4][2];
            EmoteDelay50 = EmoteDelays[5][0];
            EmoteDelay51 = EmoteDelays[5][1];
            EmoteDelay52 = EmoteDelays[5][2];
            EmoteDelay60 = EmoteDelays[6][0];
            EmoteDelay61 = EmoteDelays[6][1];
            EmoteDelay62 = EmoteDelays[6][2];
            EmoteDelay70 = EmoteDelays[7][0];
            EmoteDelay71 = EmoteDelays[7][1];
            EmoteDelay72 = EmoteDelays[7][2];

            Emote00 = Emotes[0][0];
            Emote01 = Emotes[0][1];
            Emote02 = Emotes[0][2];
            Emote10 = Emotes[1][0];
            Emote11 = Emotes[1][1];
            Emote12 = Emotes[1][2];
            Emote20 = Emotes[2][0];
            Emote21 = Emotes[2][1];
            Emote22 = Emotes[2][2];
            Emote30 = Emotes[3][0];
            Emote31 = Emotes[3][1];
            Emote32 = Emotes[3][2];
            Emote40 = Emotes[4][0];
            Emote41 = Emotes[4][1];
            Emote42 = Emotes[4][2];
            Emote50 = Emotes[5][0];
            Emote51 = Emotes[5][1];
            Emote52 = Emotes[5][2];
            Emote60 = Emotes[6][0];
            Emote61 = Emotes[6][1];
            Emote62 = Emotes[6][2];
            Emote70 = Emotes[7][0];
            Emote71 = Emotes[7][1];
            Emote72 = Emotes[7][2];
        }

        [DBFieldName("entry", true)]
        public uint? ID;

        [DBFieldName("sniff_build")]
        public int? SniffBuild = ClientVersion.BuildInt;

        [DBFieldName("male_text", TargetedDbExpansion.Zero, TargetedDbExpansion.Cataclysm, 8, StartAtZero = false)]
        public string[] Texts0;

        [DBFieldName("female_text", TargetedDbExpansion.Zero, TargetedDbExpansion.Cataclysm, 8, StartAtZero = false)]
        public string[] Texts1;

        [DBFieldName("language_id", TargetedDbExpansion.Zero, TargetedDbExpansion.Cataclysm, 8, StartAtZero = false)]
        public Language?[] Languages;

        [DBFieldName("probability", TargetedDbExpansion.Zero, TargetedDbExpansion.Cataclysm, 8, StartAtZero = false)]
        public float?[] Probabilities;

        [DBFieldName("emote_delay1_0")]
        public uint? EmoteDelay00;

        [DBFieldName("emote_delay1_1")]
        public uint? EmoteDelay01;

        [DBFieldName("emote_delay1_2")]
        public uint? EmoteDelay02;

        [DBFieldName("emote1_0")]
        public EmoteType? Emote00;

        [DBFieldName("emote1_1")]
        public EmoteType? Emote01;

        [DBFieldName("emote1_2")]
        public EmoteType? Emote02;

        [DBFieldName("emote_delay2_0")]
        public uint? EmoteDelay10;

        [DBFieldName("emote_delay2_1")]
        public uint? EmoteDelay11;

        [DBFieldName("emote_delay2_2")]
        public uint? EmoteDelay12;

        [DBFieldName("emote2_0")]
        public EmoteType? Emote10;

        [DBFieldName("emote2_1")]
        public EmoteType? Emote11;

        [DBFieldName("emote2_2")]
        public EmoteType? Emote12;

        [DBFieldName("emote_delay3_0")]
        public uint? EmoteDelay20;

        [DBFieldName("emote_delay3_1")]
        public uint? EmoteDelay21;

        [DBFieldName("emote_delay3_2")]
        public uint? EmoteDelay22;

        [DBFieldName("emote3_0")]
        public EmoteType? Emote20;

        [DBFieldName("emote3_1")]
        public EmoteType? Emote21;

        [DBFieldName("emote3_2")]
        public EmoteType? Emote22;

        [DBFieldName("emote_delay4_0")]
        public uint? EmoteDelay30;

        [DBFieldName("emote_delay4_1")]
        public uint? EmoteDelay31;

        [DBFieldName("emote_delay4_2")]
        public uint? EmoteDelay32;

        [DBFieldName("emote4_0")]
        public EmoteType? Emote30;

        [DBFieldName("emote4_1")]
        public EmoteType? Emote31;

        [DBFieldName("emote4_2")]
        public EmoteType? Emote32;

        [DBFieldName("emote_delay5_0")]
        public uint? EmoteDelay40;

        [DBFieldName("emote_delay5_1")]
        public uint? EmoteDelay41;

        [DBFieldName("emote_delay5_2")]
        public uint? EmoteDelay42;

        [DBFieldName("emote5_0")]
        public EmoteType? Emote40;

        [DBFieldName("emote5_1")]
        public EmoteType? Emote41;

        [DBFieldName("emote5_2")]
        public EmoteType? Emote42;

        [DBFieldName("emote_delay6_0")]
        public uint? EmoteDelay50;

        [DBFieldName("emote_delay6_1")]
        public uint? EmoteDelay51;

        [DBFieldName("emote_delay6_2")]
        public uint? EmoteDelay52;

        [DBFieldName("emote6_0")]
        public EmoteType? Emote50;

        [DBFieldName("emote6_1")]
        public EmoteType? Emote51;

        [DBFieldName("emote6_2")]
        public EmoteType? Emote52;

        [DBFieldName("emote_delay7_0")]
        public uint? EmoteDelay60;

        [DBFieldName("emote_delay7_1")]
        public uint? EmoteDelay61;

        [DBFieldName("emote_delay7_2")]
        public uint? EmoteDelay62;

        [DBFieldName("emote7_0")]
        public EmoteType? Emote60;

        [DBFieldName("emote7_1")]
        public EmoteType? Emote61;

        [DBFieldName("emote7_2")]
        public EmoteType? Emote62;

        [DBFieldName("emote_delay8_0")]
        public uint? EmoteDelay70;

        [DBFieldName("emote_delay8_1")]
        public uint? EmoteDelay71;

        [DBFieldName("emote_delay8_2")]
        public uint? EmoteDelay72;

        [DBFieldName("emote8_0")]
        public EmoteType? Emote70;

        [DBFieldName("emote8_1")]
        public EmoteType? Emote71;

        [DBFieldName("emote8_2")]
        public EmoteType? Emote72;
    }

    [DBTableName("npc_text", TargetedDbType.WPP | TargetedDbType.TRINITY | TargetedDbType.VMANGOS)]
    [DBTableName("npc_text_broadcast_text", TargetedDbType.CMANGOS)]
    public class NpcTextMop : IDataModel
    {
        public float[] Probabilities;

        public uint[] BroadcastTextId;

        public void ConvertToDBStruct()
        {
            // Seriously...

            Prob0 = Probabilities[0];
            Prob1 = Probabilities[1];
            Prob2 = Probabilities[2];
            Prob3 = Probabilities[3];
            Prob4 = Probabilities[4];
            Prob5 = Probabilities[5];
            Prob6 = Probabilities[6];
            Prob7 = Probabilities[7];

            BroadcastTextId0 = BroadcastTextId[0];
            BroadcastTextId1 = BroadcastTextId[1];
            BroadcastTextId2 = BroadcastTextId[2];
            BroadcastTextId3 = BroadcastTextId[3];
            BroadcastTextId4 = BroadcastTextId[4];
            BroadcastTextId5 = BroadcastTextId[5];
            BroadcastTextId6 = BroadcastTextId[6];
            BroadcastTextId7 = BroadcastTextId[7];
        }

        [DBFieldName("entry", true, DbType = (TargetedDbType.WPP))]
        [DBFieldName("ID", true, DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("Id", true, DbType = (TargetedDbType.CMANGOS))]
        public uint? ID;

        [DBFieldName("sniff_build", true, DbType = (TargetedDbType.WPP))]
        [DBFieldName("VerifiedBuild", false, DbType = (TargetedDbType.TRINITY))]
        public int? VerifiedBuild = ClientVersion.BuildInt;

        [DBFieldName("probability1", DbType = (TargetedDbType.WPP))]
        [DBFieldName("Probability0", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("Prob0", DbType = (TargetedDbType.CMANGOS))]
        public float? Prob0;

        [DBFieldName("probability2", DbType = (TargetedDbType.WPP))]
        [DBFieldName("Probability1", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("Prob1", DbType = (TargetedDbType.CMANGOS))]
        public float? Prob1;

        [DBFieldName("probability3", DbType = (TargetedDbType.WPP))]
        [DBFieldName("Probability2", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("Prob2", DbType = (TargetedDbType.CMANGOS))]
        public float? Prob2;

        [DBFieldName("probability4", DbType = (TargetedDbType.WPP))]
        [DBFieldName("Probability3", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("Prob3", DbType = (TargetedDbType.CMANGOS))]
        public float? Prob3;

        [DBFieldName("probability5", DbType = (TargetedDbType.WPP))]
        [DBFieldName("Probability4", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("Prob4", DbType = (TargetedDbType.CMANGOS))]
        public float? Prob4;

        [DBFieldName("probability6", DbType = (TargetedDbType.WPP))]
        [DBFieldName("Probability5", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("Prob5", DbType = (TargetedDbType.CMANGOS))]
        public float? Prob5;

        [DBFieldName("probability7", DbType = (TargetedDbType.WPP))]
        [DBFieldName("Probability6", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("Prob6", DbType = (TargetedDbType.CMANGOS))]
        public float? Prob6;

        [DBFieldName("probability8", DbType = (TargetedDbType.WPP))]
        [DBFieldName("Probability7", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("Prob7", DbType = (TargetedDbType.CMANGOS))]
        public float? Prob7;

        [DBFieldName("broadcast_text_id1", DbType = (TargetedDbType.WPP))]
        [DBFieldName("BroadcastTextID0", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("BroadcastTextId0", DbType = (TargetedDbType.CMANGOS))]
        public uint? BroadcastTextId0;

        [DBFieldName("broadcast_text_id2", DbType = (TargetedDbType.WPP))]
        [DBFieldName("BroadcastTextID1", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("BroadcastTextId1", DbType = (TargetedDbType.CMANGOS))]
        public uint? BroadcastTextId1;

        [DBFieldName("broadcast_text_id3", DbType = (TargetedDbType.WPP))]
        [DBFieldName("BroadcastTextID2", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("BroadcastTextId2", DbType = (TargetedDbType.CMANGOS))]
        public uint? BroadcastTextId2;

        [DBFieldName("broadcast_text_id4", DbType = (TargetedDbType.WPP))]
        [DBFieldName("BroadcastTextID3", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("BroadcastTextId3", DbType = (TargetedDbType.CMANGOS))]
        public uint? BroadcastTextId3;

        [DBFieldName("broadcast_text_id5", DbType = (TargetedDbType.WPP))]
        [DBFieldName("BroadcastTextID4", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("BroadcastTextId4", DbType = (TargetedDbType.CMANGOS))]
        public uint? BroadcastTextId4;

        [DBFieldName("broadcast_text_id6", DbType = (TargetedDbType.WPP))]
        [DBFieldName("BroadcastTextID5", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("BroadcastTextId5", DbType = (TargetedDbType.CMANGOS))]
        public uint? BroadcastTextId5;

        [DBFieldName("broadcast_text_id7", DbType = (TargetedDbType.WPP))]
        [DBFieldName("BroadcastTextID6", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("BroadcastTextId6", DbType = (TargetedDbType.CMANGOS))]
        public uint? BroadcastTextId6;

        [DBFieldName("broadcast_text_id8", DbType = (TargetedDbType.WPP))]
        [DBFieldName("BroadcastTextID7", DbType = (TargetedDbType.TRINITY | TargetedDbType.VMANGOS))]
        [DBFieldName("BroadcastTextId7", DbType = (TargetedDbType.CMANGOS))]
        public uint? BroadcastTextId7;
    }
}
