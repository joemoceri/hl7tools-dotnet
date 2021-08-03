using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0017
    {
        public string Id { get { return @"0017"; } }

        public string TableId { get { return @"0017"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Transaction type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Value = @"AJ",
                            Description = @"Adjustment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CD",
                            Description = @"Credit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CG",
                            Description = @"Charge",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PY",
                            Description = @"Payment",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
