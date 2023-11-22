using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using WowPacketParser.Enums;
using WowPacketParser.Misc;

static class CSVStorage
{
    public class SpellTemplate
    {
        public uint School;
        public uint Dispel;
        public uint Mechanic;
        public uint Attributes;
        public uint AttributesEx;
        public uint AttributesEx2;
        public uint AttributesEx3;

        public bool HasAttribute(SpellAtribute attr)
        {
            return Attributes.HasAnyFlag(attr);
        }
        public bool HasAttribute(SpellAtributeEx attr)
        {
            return AttributesEx.HasAnyFlag(attr);
        }
        public bool HasAttribute(SpellAtributeEx2 attr)
        {
            return AttributesEx2.HasAnyFlag(attr);
        }
        public bool HasAttribute(SpellAtributeEx3 attr)
        {
            return AttributesEx3.HasAnyFlag(attr);
        }
    }

    public static Dictionary<uint, SpellTemplate> SpellTemplateStore = new Dictionary<uint, SpellTemplate>();

    public static Stream LoadCSVFile(string name)
    {
        // Determine path
        var assembly = Assembly.GetExecutingAssembly();
        string resourcePath = "WowPacketParser.CSV.Data." + name + ".csv";
        Stream stream = assembly.GetManifestResourceStream(resourcePath);
        return stream;
    }

    public static SpellTemplate GetSpellTemplate(uint entry)
    {
        SpellTemplate data;
        if (SpellTemplateStore.TryGetValue(entry, out data))
            return data;
        return null;
    }

    public static void LoadSpellAttributes(Stream stream)
    {
        using (TextFieldParser csvParser = new TextFieldParser(stream))
        {
            csvParser.CommentTokens = new string[] { "#" };
            csvParser.SetDelimiters(new string[] { "," });
            csvParser.HasFieldsEnclosedInQuotes = false;

            // Skip the row with the column names
            csvParser.ReadLine();

            uint counter = 0;
            while (!csvParser.EndOfData)
            {
                counter++;

                // Read current line fields, pointer moves to the next line.
                string[] fields = csvParser.ReadFields();

                uint spellId = UInt32.Parse(fields[0]);
                uint attributes = UInt32.Parse(fields[1]);

                if (SpellTemplateStore.ContainsKey(spellId))
                    SpellTemplateStore[spellId].Attributes = attributes;
                else
                {
                    SpellTemplate spell = new SpellTemplate();
                    spell.Attributes = attributes;
                    SpellTemplateStore.Add(spellId, spell);
                }
            }
        }
        stream.Close();
    }

    public static void LoadSpellAttributesEx(Stream stream)
    {
        using (TextFieldParser csvParser = new TextFieldParser(stream))
        {
            csvParser.CommentTokens = new string[] { "#" };
            csvParser.SetDelimiters(new string[] { "," });
            csvParser.HasFieldsEnclosedInQuotes = false;

            // Skip the row with the column names
            csvParser.ReadLine();

            uint counter = 0;
            while (!csvParser.EndOfData)
            {
                counter++;

                // Read current line fields, pointer moves to the next line.
                string[] fields = csvParser.ReadFields();

                uint spellId = UInt32.Parse(fields[0]);
                uint attributesEx = UInt32.Parse(fields[1]);

                if (SpellTemplateStore.ContainsKey(spellId))
                    SpellTemplateStore[spellId].AttributesEx = attributesEx;
                else
                {
                    SpellTemplate spell = new SpellTemplate();
                    spell.AttributesEx = attributesEx;
                    SpellTemplateStore.Add(spellId, spell);
                }
            }
        }
        stream.Close();
    }

    public static void LoadSpellAttributesEx2(Stream stream)
    {
        using (TextFieldParser csvParser = new TextFieldParser(stream))
        {
            csvParser.CommentTokens = new string[] { "#" };
            csvParser.SetDelimiters(new string[] { "," });
            csvParser.HasFieldsEnclosedInQuotes = false;

            // Skip the row with the column names
            csvParser.ReadLine();

            uint counter = 0;
            while (!csvParser.EndOfData)
            {
                counter++;

                // Read current line fields, pointer moves to the next line.
                string[] fields = csvParser.ReadFields();

                uint spellId = UInt32.Parse(fields[0]);
                uint attributesEx2 = UInt32.Parse(fields[1]);

                if (SpellTemplateStore.ContainsKey(spellId))
                    SpellTemplateStore[spellId].AttributesEx2 = attributesEx2;
                else
                {
                    SpellTemplate spell = new SpellTemplate();
                    spell.AttributesEx2 = attributesEx2;
                    SpellTemplateStore.Add(spellId, spell);
                }
            }
        }
        stream.Close();
    }

    public static void LoadSpellAttributesEx3(Stream stream)
    {
        using (TextFieldParser csvParser = new TextFieldParser(stream))
        {
            csvParser.CommentTokens = new string[] { "#" };
            csvParser.SetDelimiters(new string[] { "," });
            csvParser.HasFieldsEnclosedInQuotes = false;

            // Skip the row with the column names
            csvParser.ReadLine();

            uint counter = 0;
            while (!csvParser.EndOfData)
            {
                counter++;

                // Read current line fields, pointer moves to the next line.
                string[] fields = csvParser.ReadFields();

                uint spellId = UInt32.Parse(fields[0]);
                uint attributesEx3 = UInt32.Parse(fields[1]);

                if (SpellTemplateStore.ContainsKey(spellId))
                    SpellTemplateStore[spellId].AttributesEx3 = attributesEx3;
                else
                {
                    SpellTemplate spell = new SpellTemplate();
                    spell.AttributesEx3 = attributesEx3;
                    SpellTemplateStore.Add(spellId, spell);
                }
            }
        }
        stream.Close();
    }

    public static void LoadSpellDispel(Stream stream)
    {
        using (TextFieldParser csvParser = new TextFieldParser(stream))
        {
            csvParser.CommentTokens = new string[] { "#" };
            csvParser.SetDelimiters(new string[] { "," });
            csvParser.HasFieldsEnclosedInQuotes = false;

            // Skip the row with the column names
            csvParser.ReadLine();

            uint counter = 0;
            while (!csvParser.EndOfData)
            {
                counter++;

                // Read current line fields, pointer moves to the next line.
                string[] fields = csvParser.ReadFields();

                uint spellId = UInt32.Parse(fields[0]);
                uint dispel = UInt32.Parse(fields[1]);

                if (SpellTemplateStore.ContainsKey(spellId))
                    SpellTemplateStore[spellId].Dispel = dispel;
                else
                {
                    SpellTemplate spell = new SpellTemplate();
                    spell.Dispel = dispel;
                    SpellTemplateStore.Add(spellId, spell);
                }
            }
        }
        stream.Close();
    }

    public static void LoadSpellMechanic(Stream stream)
    {
        using (TextFieldParser csvParser = new TextFieldParser(stream))
        {
            csvParser.CommentTokens = new string[] { "#" };
            csvParser.SetDelimiters(new string[] { "," });
            csvParser.HasFieldsEnclosedInQuotes = false;

            // Skip the row with the column names
            csvParser.ReadLine();

            uint counter = 0;
            while (!csvParser.EndOfData)
            {
                counter++;

                // Read current line fields, pointer moves to the next line.
                string[] fields = csvParser.ReadFields();

                uint spellId = UInt32.Parse(fields[0]);
                uint mechanic = UInt32.Parse(fields[1]);

                if (SpellTemplateStore.ContainsKey(spellId))
                    SpellTemplateStore[spellId].Mechanic = mechanic;
                else
                {
                    SpellTemplate spell = new SpellTemplate();
                    spell.Mechanic = mechanic;
                    SpellTemplateStore.Add(spellId, spell);
                }
            }
        }
        stream.Close();
    }

    public static void LoadSpellSchool(Stream stream)
    {
        using (TextFieldParser csvParser = new TextFieldParser(stream))
        {
            csvParser.CommentTokens = new string[] { "#" };
            csvParser.SetDelimiters(new string[] { "," });
            csvParser.HasFieldsEnclosedInQuotes = false;

            // Skip the row with the column names
            csvParser.ReadLine();

            uint counter = 0;
            while (!csvParser.EndOfData)
            {
                counter++;

                // Read current line fields, pointer moves to the next line.
                string[] fields = csvParser.ReadFields();

                uint spellId = UInt32.Parse(fields[0]);
                uint school = UInt32.Parse(fields[1]);

                if (SpellTemplateStore.ContainsKey(spellId))
                    SpellTemplateStore[spellId].School = school;
                else
                {
                    SpellTemplate spell = new SpellTemplate();
                    spell.School = school;
                    SpellTemplateStore.Add(spellId, spell);
                }
            }
        }
        stream.Close();
    }

    public static void LoadAll()
    {
        // first clear
        SpellTemplateStore.Clear();

        // then load
        LoadSpellAttributes(LoadCSVFile("V1_12_1_5875.SpellAttributes"));
        LoadSpellAttributesEx(LoadCSVFile("V1_12_1_5875.SpellAttributesEx"));
        LoadSpellAttributesEx2(LoadCSVFile("V1_12_1_5875.SpellAttributesEx2"));
        LoadSpellAttributesEx3(LoadCSVFile("V1_12_1_5875.SpellAttributesEx3"));
        LoadSpellDispel(LoadCSVFile("V1_12_1_5875.SpellDispel"));
        LoadSpellMechanic(LoadCSVFile("V1_12_1_5875.SpellMechanic"));
        LoadSpellSchool(LoadCSVFile("V1_12_1_5875.SpellSchool"));
    }
}