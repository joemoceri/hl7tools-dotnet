using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0429
    {
        public string Id { get { return @"0429"; } }

        public string TableId { get { return @"0429"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Production class Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Value = @"BR",
                            Description = @"Breeding/genetic stock",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DA",
                            Description = @"Dairy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DR",
                            Description = @"Draft",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DU",
                            Description = @"Dual Purpose",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LY",
                            Description = @"Layer, Includes Multiplier flocks",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MT",
                            Description = @"Meat",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NA",
                            Description = @"Not Applicable",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OT",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PL",
                            Description = @"Pleasure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RA",
                            Description = @"Racing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SH",
                            Description = @"Show",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Unknown",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
