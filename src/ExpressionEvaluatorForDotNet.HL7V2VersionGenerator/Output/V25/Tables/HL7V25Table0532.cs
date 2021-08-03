using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0532
    {
        public string Id { get { return @"0532"; } }

        public string TableId { get { return @"0532"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Expanded yes/no indicator"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
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
                            Value = @"ASKU",
                            Description = @"asked but unknown",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"No",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NA",
                            Description = @"not applicable",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NASK",
                            Description = @"not asked",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAV",
                            Description = @"temporarily unavailable",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NI",
                            Description = @"No Information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NP",
                            Description = @"not present",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNK",
                            Description = @"unknown",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Y",
                            Description = @"Yes",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
