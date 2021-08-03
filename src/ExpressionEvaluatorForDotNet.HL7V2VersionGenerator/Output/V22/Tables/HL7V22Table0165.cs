using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0165
    {
        public string Id { get { return @"0165"; } }

        public string TableId { get { return @"0165"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"ADMINISTRATION METHOD"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"CH",
                            Description = @"Chew",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DI",
                            Description = @"Dissolve",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DU",
                            Description = @"Dust",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IF",
                            Description = @"Inflitrate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IR",
                            Description = @"Irrigate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IS",
                            Description = @"Insert",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IVP",
                            Description = @"IV Push",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IVPB",
                            Description = @"IV Piggyback",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NB",
                            Description = @"Nebulized",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PF",
                            Description = @"Perfuse",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"Pain",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SH",
                            Description = @"Shampoo",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SO",
                            Description = @"Soak",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WA",
                            Description = @"Wash",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WI",
                            Description = @"Wipe",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
