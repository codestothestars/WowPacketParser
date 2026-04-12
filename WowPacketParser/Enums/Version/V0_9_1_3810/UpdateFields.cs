namespace WowPacketParser.Enums.Version.V0_9_1_3810
{
    // ReSharper disable InconsistentNaming
    // 0.9.1
    public enum ObjectField
    {
        OBJECT_FIELD_GUID = 0x0,                                                      // 0x000 - Size: 2 - Type: GUID - Flags: PUBLIC
        OBJECT_FIELD_TYPE = 0x2,                                                      // 0x002 - Size: 1 - Type: INT - Flags: PUBLIC
        OBJECT_FIELD_ENTRY = 0x3,                                                     // 0x003 - Size: 1 - Type: INT - Flags: PUBLIC
        OBJECT_FIELD_SCALE_X = 0x4,                                                   // 0x004 - Size: 1 - Type: FLOAT - Flags: PUBLIC
        OBJECT_FIELD_PADDING = 0x5,                                                   // 0x005 - Size: 1 - Type: INT - Flags: PUBLIC
        OBJECT_END = 0x6                                                              
    }

    public enum ItemField
    {
        ITEM_FIELD_OWNER = ObjectField.OBJECT_END + 0x0,                            // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
        ITEM_FIELD_CONTAINED = ObjectField.OBJECT_END + 0x2,                        // 0x008 - Size: 2 - Type: GUID - Flags: PUBLIC
        ITEM_FIELD_CREATOR = ObjectField.OBJECT_END + 0x4,                          // 0x00A - Size: 2 - Type: GUID - Flags: PUBLIC
        ITEM_FIELD_GIFTCREATOR = ObjectField.OBJECT_END + 0x6,                      // 0x00C - Size: 2 - Type: GUID - Flags: PUBLIC
        ITEM_FIELD_STACK_COUNT = ObjectField.OBJECT_END + 0x8,                      // 0x00E - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
        ITEM_FIELD_DURATION = ObjectField.OBJECT_END + 0x9,                         // 0x00F - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
        ITEM_FIELD_SPELL_CHARGES = ObjectField.OBJECT_END + 0xA,                    // 0x010 - Size: 5 - Type: INT - Flags: OWNER_ONLY + UNK2
        ITEM_FIELD_FLAGS = ObjectField.OBJECT_END + 0xF,                            // 0x015 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
        ITEM_FIELD_ENCHANTMENT = ObjectField.OBJECT_END + 0x10,                     // 0x016 - Size: 21 - Type: INT - Flags: PUBLIC
        ITEM_FIELD_PROPERTY_SEED = ObjectField.OBJECT_END + 0x25,                   // 0x02B - Size: 1 - Type: INT - Flags: PUBLIC
        ITEM_FIELD_RANDOM_PROPERTIES_ID = ObjectField.OBJECT_END + 0x26,            // 0x02C - Size: 1 - Type: INT - Flags: PUBLIC
        ITEM_FIELD_ITEM_TEXT_ID = ObjectField.OBJECT_END + 0x27,                    // 0x02D - Size: 1 - Type: INT - Flags: OWNER_ONLY
        ITEM_END = ObjectField.OBJECT_END + 0x28                                    // 0x02E
    }

    public enum ContainerField
    {
        CONTAINER_FIELD_NUM_SLOTS = ItemField.ITEM_END + 0x0,                       // 0x028 - Size: 1 - Type: INT - Flags: PUBLIC
        CONTAINER_ALIGN_PAD = ItemField.ITEM_END + 0x1,                             // 0x029 - Size: 1 - Type: BYTES - Flags: NONE
        CONTAINER_FIELD_SLOT_1 = ItemField.ITEM_END + 0x2,                          // 0x02A - Size: 40 - Type: GUID - Flags: PUBLIC
        CONTAINER_END = ItemField.ITEM_END + 0x2A                                   // 0x052
    }

    public enum UnitField
    {
        UNIT_FIELD_CHARM = ObjectField.OBJECT_END + 0x0,                            // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
        UNIT_FIELD_SUMMON = ObjectField.OBJECT_END + 0x2,                           // 0x008 - Size: 2 - Type: GUID - Flags: PUBLIC
        UNIT_FIELD_CHARMEDBY = ObjectField.OBJECT_END + 0x4,                        // 0x00A - Size: 2 - Type: GUID - Flags: PUBLIC
        UNIT_FIELD_SUMMONEDBY = ObjectField.OBJECT_END + 0x6,                       // 0x00C - Size: 2 - Type: GUID - Flags: PUBLIC
        UNIT_FIELD_CREATEDBY = ObjectField.OBJECT_END + 0x8,                        // 0x00E - Size: 2 - Type: GUID - Flags: PUBLIC
        UNIT_FIELD_TARGET = ObjectField.OBJECT_END + 0xA,                           // 0x010 - Size: 2 - Type: GUID - Flags: PUBLIC
        UNIT_FIELD_CHANNEL_OBJECT = ObjectField.OBJECT_END + 0xC,                   // 0x012 - Size: 2 - Type: GUID - Flags: PUBLIC
        UNIT_FIELD_HEALTH = ObjectField.OBJECT_END + 0xE,                           // 0x014 - Size: 1 - Type: INT - Flags: DYNAMIC
        UNIT_FIELD_POWER1 = ObjectField.OBJECT_END + 0xF,                           // 0x015 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_POWER2 = ObjectField.OBJECT_END + 0x10,                          // 0x016 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_POWER3 = ObjectField.OBJECT_END + 0x11,                          // 0x017 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_POWER4 = ObjectField.OBJECT_END + 0x12,                          // 0x018 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_POWER5 = ObjectField.OBJECT_END + 0x13,                          // 0x019 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_MAXHEALTH = ObjectField.OBJECT_END + 0x14,                       // 0x01A - Size: 1 - Type: INT - Flags: DYNAMIC
        UNIT_FIELD_MAXPOWER1 = ObjectField.OBJECT_END + 0x15,                       // 0x01B - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_MAXPOWER2 = ObjectField.OBJECT_END + 0x16,                       // 0x01C - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_MAXPOWER3 = ObjectField.OBJECT_END + 0x17,                       // 0x01D - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_MAXPOWER4 = ObjectField.OBJECT_END + 0x18,                       // 0x01E - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_MAXPOWER5 = ObjectField.OBJECT_END + 0x19,                       // 0x01F - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_LEVEL = ObjectField.OBJECT_END + 0x1A,                           // 0x020 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_FACTIONTEMPLATE = ObjectField.OBJECT_END + 0x1B,                 // 0x021 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_BYTES_0 = ObjectField.OBJECT_END + 0x1C,                         // 0x022 - Size: 1 - Type: BYTES - Flags: PUBLIC
        UNIT_VIRTUAL_ITEM_SLOT_DISPLAY = ObjectField.OBJECT_END + 0x1D,             // 0x023 - Size: 3 - Type: INT - Flags: PUBLIC
        UNIT_VIRTUAL_ITEM_INFO = ObjectField.OBJECT_END + 0x20,                     // 0x026 - Size: 6 - Type: BYTES - Flags: PUBLIC
        UNIT_FIELD_FLAGS = ObjectField.OBJECT_END + 0x26,                           // 0x02C - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_AURA = ObjectField.OBJECT_END + 0x27,                            // 0x02D - Size: 56 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_AURALEVELS = ObjectField.OBJECT_END + 0x5F,                      // 0x065 - Size: 10 - Type: BYTES - Flags: PUBLIC
        UNIT_FIELD_AURAAPPLICATIONS = ObjectField.OBJECT_END + 0x69,                // 0x06F - Size: 10 - Type: BYTES - Flags: PUBLIC
        UNIT_FIELD_AURAFLAGS = ObjectField.OBJECT_END + 0x73,                       // 0x079 - Size: 7 - Type: BYTES - Flags: PUBLIC
        UNIT_FIELD_AURASTATE = ObjectField.OBJECT_END + 0x7A,                       // 0x080 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_BASEATTACKTIME = ObjectField.OBJECT_END + 0x7B,                  // 0x081 - Size: 2 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_BOUNDINGRADIUS = ObjectField.OBJECT_END + 0x7D,                  // 0x083 - Size: 1 - Type: FLOAT - Flags: PUBLIC
        UNIT_FIELD_COMBATREACH = ObjectField.OBJECT_END + 0x7E,                     // 0x084 - Size: 1 - Type: FLOAT - Flags: PUBLIC
        UNIT_FIELD_WEAPONREACH = ObjectField.OBJECT_END + 0x7F,                     // 0x085 - Size: 1 - Type: FLOAT - Flags: PUBLIC
        UNIT_FIELD_DISPLAYID = ObjectField.OBJECT_END + 0x80,                       // 0x086 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_MOUNTDISPLAYID = ObjectField.OBJECT_END + 0x81,                  // 0x087 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_MINDAMAGE = ObjectField.OBJECT_END + 0x82,                       // 0x088 - Size: 1 - Type: FLOAT - Flags: PRIVATE + OWNER_ONLY + UNK3
        UNIT_FIELD_MAXDAMAGE = ObjectField.OBJECT_END + 0x83,                       // 0x089 - Size: 1 - Type: FLOAT - Flags: PRIVATE + OWNER_ONLY + UNK3
        UNIT_FIELD_BYTES_1 = ObjectField.OBJECT_END + 0x84,                         // 0x08A - Size: 1 - Type: BYTES - Flags: PUBLIC
        UNIT_FIELD_PETNUMBER = ObjectField.OBJECT_END + 0x85,                       // 0x08B - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_PET_NAME_TIMESTAMP = ObjectField.OBJECT_END + 0x86,              // 0x08C - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_FIELD_PETEXPERIENCE = ObjectField.OBJECT_END + 0x87,                   // 0x08D - Size: 1 - Type: INT - Flags: OWNER_ONLY
        UNIT_FIELD_PETNEXTLEVELEXP = ObjectField.OBJECT_END + 0x88,                 // 0x08E - Size: 1 - Type: INT - Flags: OWNER_ONLY
        UNIT_DYNAMIC_FLAGS = ObjectField.OBJECT_END + 0x89,                         // 0x08F - Size: 1 - Type: INT - Flags: DYNAMIC
        UNIT_CHANNEL_SPELL = ObjectField.OBJECT_END + 0x8A,                         // 0x090 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_MOD_CAST_SPEED = ObjectField.OBJECT_END + 0x8B,                        // 0x091 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_CREATED_BY_SPELL = ObjectField.OBJECT_END + 0x8C,                      // 0x092 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_NPC_FLAGS = ObjectField.OBJECT_END + 0x8D,                             // 0x093 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_NPC_EMOTESTATE = ObjectField.OBJECT_END + 0x8E,                        // 0x094 - Size: 1 - Type: INT - Flags: PUBLIC
        UNIT_TRAINING_POINTS = ObjectField.OBJECT_END + 0x8F,                       // 0x095 - Size: 1 - Type: TWO_SHORT - Flags: OWNER_ONLY
        UNIT_FIELD_STAT0 = ObjectField.OBJECT_END + 0x90,                           // 0x096 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
        UNIT_FIELD_STAT1 = ObjectField.OBJECT_END + 0x91,                           // 0x097 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
        UNIT_FIELD_STAT2 = ObjectField.OBJECT_END + 0x92,                           // 0x098 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
        UNIT_FIELD_STAT3 = ObjectField.OBJECT_END + 0x93,                           // 0x099 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
        UNIT_FIELD_STAT4 = ObjectField.OBJECT_END + 0x94,                           // 0x09A - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
        UNIT_FIELD_RESISTANCES = ObjectField.OBJECT_END + 0x95,                     // 0x09B - Size: 7 - Type: INT - Flags: PRIVATE + OWNER_ONLY + UNK3
        UNIT_FIELD_ATTACKPOWER = ObjectField.OBJECT_END + 0x9C,                     // 0x0A2 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
        UNIT_FIELD_BASE_MANA = ObjectField.OBJECT_END + 0x9D,                       // 0x0A3 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
        UNIT_END = ObjectField.OBJECT_END + 0x9E                                    // 0x0A4
    }

    public enum PlayerField
    {
        PLAYER_SELECTION = UnitField.UNIT_END + 0x0,                                // 0x09E - Size: 2 - Type: GUID - Flags: PUBLIC
        PLAYER_DUEL_ARBITER = UnitField.UNIT_END + 0x2,                             // 0x0A0 - Size: 2 - Type: GUID - Flags: PUBLIC
        PLAYER_GUILDID = UnitField.UNIT_END + 0x4,                                  // 0x0A2 - Size: 1 - Type: INT - Flags: PUBLIC
        PLAYER_GUILDRANK = UnitField.UNIT_END + 0x5,                                // 0x0A3 - Size: 1 - Type: INT - Flags: PUBLIC
        PLAYER_BYTES = UnitField.UNIT_END + 0x6,                                    // 0x0A4 - Size: 1 - Type: BYTES - Flags: PUBLIC
        PLAYER_BYTES_2 = UnitField.UNIT_END + 0x7,                                  // 0x0A5 - Size: 1 - Type: BYTES - Flags: PUBLIC
        PLAYER_BYTES_3 = UnitField.UNIT_END + 0x8,                                  // 0x0A6 - Size: 1 - Type: BYTES - Flags: PUBLIC
        PLAYER_DUEL_TEAM = UnitField.UNIT_END + 0x9,                                // 0x0A7 - Size: 1 - Type: INT - Flags: PUBLIC
        PLAYER_GUILD_TIMESTAMP = UnitField.UNIT_END + 0xA,                          // 0x0A8 - Size: 1 - Type: INT - Flags: PUBLIC
        PLAYER_FIELD_PAD_0 = UnitField.UNIT_END + 0xB,                              // 0x0A9 - Size: 1 - Type: INT - Flags: NONE
        PLAYER_FIELD_INV_SLOT_HEAD = UnitField.UNIT_END + 0xC,                      // 0x0AA - Size: 46 - Type: GUID - Flags: PUBLIC
        PLAYER_FIELD_PACK_SLOT_1 = UnitField.UNIT_END + 0x3A,                       // 0x0D8 - Size: 32 - Type: GUID - Flags: PRIVATE
        PLAYER_FIELD_BANK_SLOT_1 = UnitField.UNIT_END + 0x5A,                       // 0x0F8 - Size: 48 - Type: GUID - Flags: PRIVATE
        PLAYER_FIELD_BANKBAG_SLOT_1 = UnitField.UNIT_END + 0x8A,                    // 0x128 - Size: 12 - Type: GUID - Flags: PRIVATE
        PLAYER_FARSIGHT = UnitField.UNIT_END + 0x96,                                // 0x134 - Size: 2 - Type: GUID - Flags: PRIVATE
        PLAYER__FIELD_COMBO_TARGET = UnitField.UNIT_END + 0x98,                     // 0x136 - Size: 2 - Type: GUID - Flags: PRIVATE
        PLAYER_XP = UnitField.UNIT_END + 0x9A,                                      // 0x138 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_NEXT_LEVEL_XP = UnitField.UNIT_END + 0x9B,                           // 0x139 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_SKILL_INFO_1_1 = UnitField.UNIT_END + 0x9C,                          // 0x13A - Size: 384 - Type: TWO_SHORT - Flags: PRIVATE
        PLAYER_QUEST_LOG_1_1 = UnitField.UNIT_END + 0x21C,                          // 0x2BA - Size: 60 - Type: INT - Flags: PRIVATE
        PLAYER_CHARACTER_POINTS1 = UnitField.UNIT_END + 0x258,                      // 0x2F6 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_CHARACTER_POINTS2 = UnitField.UNIT_END + 0x259,                      // 0x2F7 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_TRACK_CREATURES = UnitField.UNIT_END + 0x25A,                        // 0x2F8 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_TRACK_RESOURCES = UnitField.UNIT_END + 0x25B,                        // 0x2F9 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_CHAT_FILTERS = UnitField.UNIT_END + 0x25C,                           // 0x2FA - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_BLOCK_PERCENTAGE = UnitField.UNIT_END + 0x25D,                       // 0x2FB - Size: 1 - Type: FLOAT - Flags: PRIVATE
        PLAYER_DODGE_PERCENTAGE = UnitField.UNIT_END + 0x25E,                       // 0x2FC - Size: 1 - Type: FLOAT - Flags: PRIVATE
        PLAYER_PARRY_PERCENTAGE = UnitField.UNIT_END + 0x25F,                       // 0x2FD - Size: 1 - Type: FLOAT - Flags: PRIVATE
        PLAYER_CRIT_PERCENTAGE = UnitField.UNIT_END + 0x260,                        // 0x2FE - Size: 1 - Type: FLOAT - Flags: PRIVATE
        PLAYER_EXPLORED_ZONES_1 = UnitField.UNIT_END + 0x261,                       // 0x2FF - Size: 32 - Type: BYTES - Flags: PRIVATE
        PLAYER_REST_STATE_EXPERIENCE = UnitField.UNIT_END + 0x281,                  // 0x31F - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_COINAGE = UnitField.UNIT_END + 0x282,                          // 0x320 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_POSSTAT0 = UnitField.UNIT_END + 0x283,                         // 0x321 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_POSSTAT1 = UnitField.UNIT_END + 0x284,                         // 0x322 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_POSSTAT2 = UnitField.UNIT_END + 0x285,                         // 0x323 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_POSSTAT3 = UnitField.UNIT_END + 0x286,                         // 0x324 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_POSSTAT4 = UnitField.UNIT_END + 0x287,                         // 0x325 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_NEGSTAT0 = UnitField.UNIT_END + 0x288,                         // 0x326 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_NEGSTAT1 = UnitField.UNIT_END + 0x289,                         // 0x327 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_NEGSTAT2 = UnitField.UNIT_END + 0x28A,                         // 0x328 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_NEGSTAT3 = UnitField.UNIT_END + 0x28B,                         // 0x329 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_NEGSTAT4 = UnitField.UNIT_END + 0x28C,                         // 0x32A - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_RESISTANCEBUFFMODSPOSITIVE = UnitField.UNIT_END + 0x28D,       // 0x32B - Size: 7 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_RESISTANCEBUFFMODSNEGATIVE = UnitField.UNIT_END + 0x294,       // 0x332 - Size: 7 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS = UnitField.UNIT_END + 0x29B,              // 0x339 - Size: 7 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG = UnitField.UNIT_END + 0x2A2,              // 0x340 - Size: 7 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT = UnitField.UNIT_END + 0x2A9,              // 0x347 - Size: 7 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_BYTES = UnitField.UNIT_END + 0x2B0,                            // 0x34E - Size: 1 - Type: BYTES - Flags: PRIVATE
        PLAYER_FIELD_ATTACKPOWERMODPOS = UnitField.UNIT_END + 0x2B1,                // 0x34F - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_FIELD_ATTACKPOWERMODNEG = UnitField.UNIT_END + 0x2B2,                // 0x350 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_AMMO_ID = UnitField.UNIT_END + 0x2B3,                                // 0x351 - Size: 1 - Type: INT - Flags: PRIVATE
        PLAYER_END = UnitField.UNIT_END + 0x2B4                                     // 0x352
    }

    public enum GameObjectField
    {
        GAMEOBJECT_DISPLAYID = ObjectField.OBJECT_END + 0x0,                        // 0x006 - Size: 1 - Type: INT - Flags: PUBLIC
        GAMEOBJECT_FLAGS = ObjectField.OBJECT_END + 0x1,                            // 0x007 - Size: 1 - Type: INT - Flags: PUBLIC
        GAMEOBJECT_ROTATION = ObjectField.OBJECT_END + 0x2,                         // 0x008 - Size: 4 - Type: FLOAT - Flags: PUBLIC
        GAMEOBJECT_STATE = ObjectField.OBJECT_END + 0x6,                            // 0x00C - Size: 1 - Type: INT - Flags: PUBLIC
        GAMEOBJECT_TIMESTAMP = ObjectField.OBJECT_END + 0x7,                        // 0x00D - Size: 1 - Type: INT - Flags: PUBLIC
        GAMEOBJECT_POS_X = ObjectField.OBJECT_END + 0x8,                            // 0x00E - Size: 1 - Type: FLOAT - Flags: PUBLIC
        GAMEOBJECT_POS_Y = ObjectField.OBJECT_END + 0x9,                            // 0x00F - Size: 1 - Type: FLOAT - Flags: PUBLIC
        GAMEOBJECT_POS_Z = ObjectField.OBJECT_END + 0xA,                            // 0x010 - Size: 1 - Type: FLOAT - Flags: PUBLIC
        GAMEOBJECT_FACING = ObjectField.OBJECT_END + 0xB,                           // 0x011 - Size: 1 - Type: FLOAT - Flags: PUBLIC
        GAMEOBJECT_DYN_FLAGS = ObjectField.OBJECT_END + 0xC,                        // 0x012 - Size: 1 - Type: INT - Flags: DYNAMIC
        GAMEOBJECT_FACTION = ObjectField.OBJECT_END + 0xD,                          // 0x013 - Size: 1 - Type: INT - Flags: PUBLIC
        GAMEOBJECT_TYPE_ID = ObjectField.OBJECT_END + 0xE,                          // 0x014 - Size: 1 - Type: INT - Flags: PUBLIC
        GAMEOBJECT_LEVEL = ObjectField.OBJECT_END + 0xF,                            // 0x015 - Size: 1 - Type: INT - Flags: PUBLIC
        GAMEOBJECT_END = ObjectField.OBJECT_END + 0x10                              // 0x016
    }

    public enum DynamicObjectField
    {
        DYNAMICOBJECT_CASTER = ObjectField.OBJECT_END + 0x0,                        // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
        DYNAMICOBJECT_BYTES = ObjectField.OBJECT_END + 0x2,                         // 0x008 - Size: 1 - Type: BYTES - Flags: PUBLIC
        DYNAMICOBJECT_SPELLID = ObjectField.OBJECT_END + 0x3,                       // 0x009 - Size: 1 - Type: INT - Flags: PUBLIC
        DYNAMICOBJECT_RADIUS = ObjectField.OBJECT_END + 0x4,                        // 0x00A - Size: 1 - Type: FLOAT - Flags: PUBLIC
        DYNAMICOBJECT_POS_X = ObjectField.OBJECT_END + 0x5,                         // 0x00B - Size: 1 - Type: FLOAT - Flags: PUBLIC
        DYNAMICOBJECT_POS_Y = ObjectField.OBJECT_END + 0x6,                         // 0x00C - Size: 1 - Type: FLOAT - Flags: PUBLIC
        DYNAMICOBJECT_POS_Z = ObjectField.OBJECT_END + 0x7,                         // 0x00D - Size: 1 - Type: FLOAT - Flags: PUBLIC
        DYNAMICOBJECT_FACING = ObjectField.OBJECT_END + 0x8,                        // 0x00E - Size: 1 - Type: FLOAT - Flags: PUBLIC
        DYNAMICOBJECT_PAD = ObjectField.OBJECT_END + 0x9,                           // 0x00F - Size: 1 - Type: BYTES - Flags: PUBLIC
        DYNAMICOBJECT_END = ObjectField.OBJECT_END + 0xA                            // 0x010
    }

    public enum CorpseField
    {
        CORPSE_FIELD_OWNER = ObjectField.OBJECT_END + 0x0,                          // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
        CORPSE_FIELD_FACING = ObjectField.OBJECT_END + 0x2,                         // 0x008 - Size: 1 - Type: FLOAT - Flags: PUBLIC
        CORPSE_FIELD_POS_X = ObjectField.OBJECT_END + 0x3,                          // 0x009 - Size: 1 - Type: FLOAT - Flags: PUBLIC
        CORPSE_FIELD_POS_Y = ObjectField.OBJECT_END + 0x4,                          // 0x00A - Size: 1 - Type: FLOAT - Flags: PUBLIC
        CORPSE_FIELD_POS_Z = ObjectField.OBJECT_END + 0x5,                          // 0x00B - Size: 1 - Type: FLOAT - Flags: PUBLIC
        CORPSE_FIELD_DISPLAY_ID = ObjectField.OBJECT_END + 0x6,                     // 0x00C - Size: 1 - Type: INT - Flags: PUBLIC
        CORPSE_FIELD_ITEM = ObjectField.OBJECT_END + 0x7,                           // 0x00D - Size: 19 - Type: INT - Flags: PUBLIC
        CORPSE_FIELD_BYTES_1 = ObjectField.OBJECT_END + 0x1A,                       // 0x020 - Size: 1 - Type: BYTES - Flags: PUBLIC
        CORPSE_FIELD_BYTES_2 = ObjectField.OBJECT_END + 0x1B,                       // 0x021 - Size: 1 - Type: BYTES - Flags: PUBLIC
        CORPSE_FIELD_GUILD = ObjectField.OBJECT_END + 0x1C,                         // 0x022 - Size: 1 - Type: INT - Flags: PUBLIC
        CORPSE_FIELD_FLAGS = ObjectField.OBJECT_END + 0x1D,                         // 0x023 - Size: 1 - Type: INT - Flags: PUBLIC
        CORPSE_END = ObjectField.OBJECT_END + 0x1E                                  // 0x024
    }
}
