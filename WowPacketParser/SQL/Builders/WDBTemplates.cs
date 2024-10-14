using System.Collections.Generic;
using System.Linq;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;

namespace WowPacketParser.SQL.Builders
{
    [BuilderClass]
    public static class WDBTemplates
    {
        [BuilderMethod(false)]
        public static string QuestTemplate()
        {
            if (!Settings.SqlTables.quest_template)
                return string.Empty;

            if (Storage.QuestTemplates.IsEmpty())
                return string.Empty;

            if (Settings.TargetedDbType == TargetedDbType.WPP)
                return SQLUtil.Insert(Storage.QuestTemplates, false, true);

            var templatesDb = SQLDatabase.Get(Storage.QuestTemplates);

            return SQLUtil.Compare(Storage.QuestTemplates, templatesDb, StoreNameType.Quest);
        }

        [BuilderMethod(false)]
        public static string QuestObjective()
        {
            if (!Settings.SqlTables.quest_template)
                return string.Empty;

            if (Settings.TargetedDbExpansion == TargetedDbExpansion.WrathOfTheLichKing ||
                Settings.TargetedDbExpansion == TargetedDbExpansion.Cataclysm)
                return string.Empty;

            if (Storage.QuestObjectives.IsEmpty())
                return string.Empty;

            if (Settings.TargetedDbType == TargetedDbType.WPP)
                return SQLUtil.Insert(Storage.QuestObjectives, false, true);

            var templatesDb = SQLDatabase.Get(Storage.QuestObjectives);

            return SQLUtil.Compare(Storage.QuestObjectives, templatesDb, StoreNameType.None);
        }

        [BuilderMethod(true)]
        public static string QuestVisualEffect()
        {
            if (!Settings.SqlTables.quest_template)
                return string.Empty;

            if (Settings.TargetedDbExpansion == TargetedDbExpansion.WrathOfTheLichKing ||
                Settings.TargetedDbExpansion == TargetedDbExpansion.Cataclysm)
                return string.Empty;

            if (Storage.QuestVisualEffects.IsEmpty())
                return string.Empty;

            var templateDb = SQLDatabase.Get(Storage.QuestVisualEffects);

            return SQLUtil.Compare(Storage.QuestVisualEffects, templateDb, StoreNameType.None);
        }

        [BuilderMethod(true)]
        public static string QuestRewardDisplaySpell()
        {
            if (!Settings.SqlTables.quest_template)
                return string.Empty;

            if (Settings.TargetedDbExpansion != TargetedDbExpansion.Shadowlands)
                return string.Empty;

            if (Storage.QuestRewardDisplaySpells.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.QuestRewardDisplaySpells);

            return SQLUtil.Compare(Storage.QuestRewardDisplaySpells, templatesDb, StoreNameType.None);
        }

        [BuilderMethod(false)]
        public static string CreatureTemplate()
        {
            if (!Settings.SqlTables.creature_template_wdb)
                return string.Empty;

            if (!Storage.CreatureTemplates.IsEmpty())
            {
                foreach (var creatureTemplate in Storage.CreatureTemplates)
                {
                    if (creatureTemplate.Item1.FemaleName == null)
                        creatureTemplate.Item1.FemaleName = string.Empty;
                }

                var templatesDb = SQLDatabase.Get(Storage.CreatureTemplates);
                return SQLUtil.Compare(Storage.CreatureTemplates, templatesDb, StoreNameType.Unit);
            }

            return string.Empty;
        }

        [BuilderMethod(true)]
        public static string CreatureTemplateModel()
        {
            if (!Settings.SqlTables.creature_template)
                return string.Empty;

            if (Storage.CreatureTemplateModels.IsEmpty())
                return string.Empty;

            //if (Settings.TargetedDbExpansion < TargetedDbExpansion.BattleForAzeroth)
            //    return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.CreatureTemplateModels);

            return SQLUtil.Compare(Storage.CreatureTemplateModels, templatesDb, StoreNameType.Unit);
        }

        [BuilderMethod(false)]
        public static string CreatureTemplateQuestItem()
        {
            if (!Settings.SqlTables.creature_template_wdb)
                return string.Empty;

            if (Storage.CreatureTemplateQuestItems.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.CreatureTemplateQuestItems);

            return SQLUtil.Compare(Storage.CreatureTemplateQuestItems, templatesDb, StoreNameType.Unit);
        }

        [BuilderMethod(false, Gameobjects = true)]
        public static string GameObjectTemplate(Dictionary<WowGuid, GameObject> gameobjects)
        {
            if (!Settings.SqlTables.gameobject_template)
                return string.Empty;

            if (Storage.GameObjectTemplates.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.GameObjectTemplates);

            foreach (var goT in Storage.GameObjectTemplates)
            {
                GameObject go = gameobjects.FirstOrDefault(p => p.Key.GetEntry() == goT.Item1.Entry.GetValueOrDefault()).Value;
                if (go != null)
                {
                    if (goT.Item1.Size == null) // only true for 1.x to 4.x. WDB field since 5.x
                        goT.Item1.Size = go.ObjectData.Scale;
                }
            }

            return SQLUtil.Compare(Storage.GameObjectTemplates, templatesDb, StoreNameType.GameObject);
        }

        [BuilderMethod(false)]
        public static string GameObjectTemplateQuestItem()
        {
            if (!Settings.SqlTables.gameobject_template)
                return string.Empty;

            if (Storage.GameObjectTemplateQuestItems.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.GameObjectTemplateQuestItems);

            return SQLUtil.Compare(Storage.GameObjectTemplateQuestItems, templatesDb, StoreNameType.GameObject);
        }

        [BuilderMethod(false)]
        public static string ItemTemplate()
        {
            if (!Settings.SqlTables.item_template)
                return string.Empty;

            if (Settings.TargetedDbExpansion == TargetedDbExpansion.WarlordsOfDraenor)
                return string.Empty;

            if (Storage.ItemTemplates.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.ItemTemplates);

            return SQLUtil.Compare(Storage.ItemTemplates, templatesDb, StoreNameType.Item);
        }

        [BuilderMethod]
        public static string PlayerChoice()
        {
            if (!Settings.SqlTables.playerchoice)
                return string.Empty;

            if (Storage.PlayerChoices.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.PlayerChoices);

            return SQLUtil.Compare(Storage.PlayerChoices, templatesDb, StoreNameType.None);
        }

        [BuilderMethod]
        public static string PlayerChoiceResponse()
        {
            if (!Settings.SqlTables.playerchoice)
                return string.Empty;

            if (Storage.PlayerChoiceResponses.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.PlayerChoiceResponses);

            return SQLUtil.Compare(Storage.PlayerChoiceResponses, templatesDb, StoreNameType.None);
        }

        [BuilderMethod]
        public static string PlayerChoiceResponseReward()
        {
            if (!Settings.SqlTables.playerchoice)
                return string.Empty;

            if (Storage.PlayerChoiceResponseRewards.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.PlayerChoiceResponseRewards);

            return SQLUtil.Compare(Storage.PlayerChoiceResponseRewards, templatesDb, StoreNameType.None);
        }

        [BuilderMethod]
        public static string PlayerChoiceResponseRewardCurrency()
        {
            if (!Settings.SqlTables.playerchoice)
                return string.Empty;

            if (Storage.PlayerChoiceResponseRewardCurrencies.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.PlayerChoiceResponseRewardCurrencies);

            return SQLUtil.Compare(Storage.PlayerChoiceResponseRewardCurrencies, templatesDb, StoreNameType.None);
        }

        [BuilderMethod]
        public static string PlayerChoiceResponseRewardFaction()
        {
            if (!Settings.SqlTables.playerchoice)
                return string.Empty;

            if (Storage.PlayerChoiceResponseRewardFactions.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.PlayerChoiceResponseRewardFactions);

            return SQLUtil.Compare(Storage.PlayerChoiceResponseRewardFactions, templatesDb, StoreNameType.None);
        }

        [BuilderMethod]
        public static string PlayerChoiceResponseRewardItem()
        {
            if (!Settings.SqlTables.playerchoice)
                return string.Empty;

            if (Storage.PlayerChoiceResponseRewardItems.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.PlayerChoiceResponseRewardItems);

            return SQLUtil.Compare(Storage.PlayerChoiceResponseRewardItems, templatesDb, StoreNameType.None);
        }

        [BuilderMethod(false)]
        public static string PageText()
        {
            if (!Settings.SqlTables.page_text)
                return string.Empty;

            if (Storage.PageTexts.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.PageTexts);

            return SQLUtil.Compare(Storage.PageTexts, templatesDb, StoreNameType.PageText);
        }

        [BuilderMethod(false)]
        public static string NpcText()
        {
            if (!Settings.SqlTables.npc_text)
                return string.Empty;

            if (!Storage.NpcTexts.IsEmpty() && ClientVersion.RemovedInVersion(ClientType.MistsOfPandaria) &&
                (Settings.TargetedDbExpansion >= TargetedDbExpansion.Zero ||
                Settings.TargetedDbExpansion <= TargetedDbExpansion.Cataclysm))
            {
                foreach (var npcText in Storage.NpcTexts)
                    npcText.Item1.ConvertToDBStruct();

                return SQLUtil.Insert(Storage.NpcTexts);
            }

            if (!Storage.NpcTextsMop.IsEmpty() && ClientVersion.AddedInVersion(ClientType.MistsOfPandaria) &&
                (Settings.TargetedDbExpansion >= TargetedDbExpansion.WarlordsOfDraenor ||
                Settings.TargetedDbExpansion == TargetedDbExpansion.Classic ||
                Settings.TargetedDbExpansion == TargetedDbExpansion.BurningCrusadeClassic ||
                Settings.TargetedDbExpansion == TargetedDbExpansion.WrathOfTheLichKingClassic))
            {
                foreach (var npcText in Storage.NpcTextsMop)
                    npcText.Item1.ConvertToDBStruct();

                var templatesDb = SQLDatabase.Get(Storage.NpcTextsMop);

                return SQLUtil.Compare(Storage.NpcTextsMop, templatesDb, StoreNameType.NpcText);
            }

            return string.Empty;
        }

        [BuilderMethod(true)]
        public static string ScenarioPOI()
        {
            if (!Settings.SqlTables.scenario_poi)
                return string.Empty;

            if (Storage.ScenarioPOIs.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.ScenarioPOIs);

            return SQLUtil.Compare(Storage.ScenarioPOIs, templatesDb, StoreNameType.None);
        }

        [BuilderMethod(true)]
        public static string ScenarioPOIPoint()
        {
            if (!Settings.SqlTables.scenario_poi)
                return string.Empty;

            if (Storage.ScenarioPOIPoints.IsEmpty())
                return string.Empty;

            var templatesDb = SQLDatabase.Get(Storage.ScenarioPOIPoints);

            return SQLUtil.Compare(Storage.ScenarioPOIPoints, templatesDb, StoreNameType.None);
        }
    }
}
