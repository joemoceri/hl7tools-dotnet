using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0157
    {
        public string Id { get { return @"0157"; } }

        public string TableId { get { return @"0157"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"WHICH DATE/TIME STATUS QUALIFIER"; } }

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
                            Value = @"ANY",
                            Description = @"Any status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CFN",
                            Description = @"Current final value (whether final or corrected)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COR",
                            Description = @"Corrected only (no final with corrections)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FIN",
                            Description = @"Final only (no corrections)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRE",
                            Description = @"Preliminary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REP",
                            Description = @"Report completion date / time",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
