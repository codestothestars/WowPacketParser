using WowPacketParser.Misc;

namespace WowPacketParser.Store.Objects.UpdateFields
{
    public interface IUnitData
    {
        uint Entry { get; }
        int DisplayID { get; }
        uint[] NpcFlags { get; }
        WowGuid SummonedBy { get; }
        WowGuid CreatedBy { get; }
        WowGuid Target { get; }
        byte ClassId { get; }
        byte RaceId { get; }
        byte Sex { get; }
        long Health { get; }
        int[] Power { get; }
        int[] MaxPower { get; }
        long MaxHealth { get; }
        int Level { get; }
        int ContentTuningID { get; }
        int ScalingLevelMin { get; }
        int ScalingLevelMax { get; }
        int ScalingLevelDelta { get; }
        int FactionTemplate { get; }
        long CurHealth { get; }
        uint HealthPercent { get; }
        int CurMana { get; }
        int MaxMana { get; }
        IVisibleItem[] VirtualItems { get; }
        uint Flags { get; }
        uint Flags2 { get; }
        uint Flags3 { get; }
        uint[] AttackRoundBaseTime { get; }
        uint RangedAttackRoundBaseTime { get; }
        float BoundingRadius { get; }
        float CombatReach { get; }
        int MountDisplayID { get; }
        byte StandState { get; }
        byte PetTalentPoints { get; }
        byte VisFlags { get; }
        byte AnimTier { get; }
        int CreatedBySpell { get; }
        int EmoteState { get; }
        byte SheatheState { get; }
        byte PvpFlags { get; }
        byte PetFlags { get; }
        byte ShapeshiftForm { get; }
        float HoverHeight { get; }
        int InteractSpellID { get; }

        // Player Fields

        int PlayerAccount { get; }
        int PlayerExperience { get; }
        int PlayerMoney { get; }
        uint PlayerBytes1 { get; }
        uint PlayerBytes2 { get; }
        int PlayerFlags { get; }
    }
}
