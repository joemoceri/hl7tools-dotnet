using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0376
    {
        public string Id { get { return @"0376"; } }

        public string TableId { get { return @"0376"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Special handling considerations"; } }

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
                            Value = @"C37",
                            Description = @"Critical maintain at 37C (e.g., cryoglobulin specimen)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAMB",
                            Description = @"Critical ambient temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CATM",
                            Description = @"Critical do not expose to atmosphere - Do not uncap",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CFRZ",
                            Description = @"Critical Frozen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CREF",
                            Description = @"Critical refrigerated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRTL",
                            Description = @"Protect from light",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
