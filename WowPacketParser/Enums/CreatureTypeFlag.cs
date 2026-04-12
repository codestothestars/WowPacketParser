using System;

namespace WowPacketParser.Enums
{
    [Flags]
    public enum CreatureStaticFlag1 : uint
    {
        None                          = 0x00000000,
        Mountable                     = 0x00000001, // Not used by core.
        NoXP                          = 0x00000002, // No experience will be gained from killing the creature.
        NoLoot                        = 0x00000004, // Not used by core.
        Unkillable                    = 0x00000008, // Invincibility threshold set to 1 HP.
        Tameable                      = 0x00000010, // Can be tamed by hunters.
        ImmuneToPC                    = 0x00000020, // Applies UNIT_FLAG_IMMUNE_TO_PLAYER on spawn.
        ImmuneToNPC                   = 0x00000040, // Applies UNIT_FLAG_IMMUNE_TO_NPC on spawn.
        CanWieldLoot                  = 0x00000080, // Will generate loot on spawn and equip any weapons.
        Sessile                       = 0x00000100, // Cannot move.
        Uninteractible                = 0x00000200, // Applies UNIT_FLAG_NOT_SELECTABLE on spawn.
        NoAutomaticRegen              = 0x00000400, // Will not regen health and mana.
        DespawnInstantly              = 0x00000800, // Despawn corpse instantly on death.
        CorpseRaid                    = 0x00001000, // Does not check distance or damage origin upon death for loot and xp eligibility.
        CreatorLoot                   = 0x00002000, // Can be looted by the player who created it.
        NoDefense                     = 0x00004000, // Defense skill is 0.
        NoSpellDefense                = 0x00008000, // Cannot resist spells.
        RaidBossMob                   = 0x00010000, // Not used by core.
        CombatPing                    = 0x00020000, // Send mini map ping packet upon entering combat.
        Aquatic                       = 0x00040000, // Inhabit Type = INHABIT_WATER ; Original Comment: "aka Water Only"
        Amphibious                    = 0x00080000, // Inhabit Type = INHABIT_GROUND | INHABIT_WATER
        NoMelee                       = 0x00100000, // Does not auto attack ; Original Comment: "Flee"
        VisibleToGhosts               = 0x00200000, // Spirit Healers.
        PvPEnabling                   = 0x00400000, // Flagged for PvP, makes it possible to target creature with beneficial spells as well.
        DoNotPlayWoundAnim            = 0x00800000, // Will not play EMOTE_ONESHOT_WOUNDCRITICAL.
        NoFactionTooltip              = 0x01000000, // Not used by core.
        IgnoreCombat                  = 0x02000000, // React State = Passive
        OnlyAttackPvPEnabling         = 0x04000000, // No proximity aggro for players who are not PvP flagged.
        CallsGuards                   = 0x08000000, // Summons a guard if an opposite faction player gets near or attacks.
        CanSwim                       = 0x10000000, // Applies UNIT_FLAG_USE_SWIM_ANIMATION on spawn.
        Floating                      = 0x20000000, // Applies MOVEFLAG_FIXED_Z on spawn ; Original Comment: "Don't use"
        MoreAudible                   = 0x40000000, // Original Comment: "Caution, Expensive"
        LargeAOI                      = 0x80000000  // Increases visibility distance to 200 yards ; Original Comment: "Caution, Expensive"
    }

    [Flags]
    public enum CreatureTypeFlag : uint
    {
        None                          = 0x00000000,
        Tameable                      = 0x00000001,
        VisibleToGhosts               = 0x00000002,
        BossMob                       = 0x00000004,
        DoNotPlayWoundAnim            = 0x00000008,
        NoFactionTooltip              = 0x00000010,
        MoreAudible                   = 0x00000020, // sound related
        SpellAttackable               = 0x00000040,
        InteractWhileDead             = 0x00000080,
        SkinWithHerbalism             = 0x00000100,
        SkinWithMining                = 0x00000200,
        NoDeathMessage                = 0x00000400,
        AllowMountedCombat            = 0x00000800,
        CanAssist                     = 0x00001000,
        NoPetBar                      = 0x00002000,
        MaskUID                       = 0x00004000,
        SkinWithEngineering           = 0x00008000,
        TameableExotic                = 0x00010000,
        UseModelCollisionSize         = 0x00020000,
        AllowInteractionWhileInCombat = 0x00040000,
        CollideWithMissiles           = 0x00080000,
        NoNamePlate                   = 0x00100000,
        DoNotPlayMountedAnimations    = 0x00200000,
        LinkAll                       = 0x00400000,
        InteractOnlyWithCreator       = 0x00800000,
        DoNotPlayUnitEventSounds      = 0x01000000,
        HasNoShadowBlob               = 0x02000000,
        TreatAsRaidUnit               = 0x04000000,
        ForceGossip                   = 0x08000000,
        DoNotSheathe                  = 0x10000000,
        DoNotTargetOnInteraction      = 0x20000000,
        DoNotRenderObjectName         = 0x40000000,
        QuestBoss                     = 0x80000000 // not verified
    }
}
