using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0373
    {
        public string Id { get { return @"0373"; } }

        public string TableId { get { return @"0373"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Treatment"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",
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
                            Value = @"ACID",
                            Description = @"Acidification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ALK",
                            Description = @"Alkalization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEFB",
                            Description = @"Defibrination",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FILT",
                            Description = @"Filtration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LDLP",
                            Description = @"LDL Precipitation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NEUT",
                            Description = @"Neutralization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RECA",
                            Description = @"Recalification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UFIL",
                            Description = @"Ultrafiltration",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
