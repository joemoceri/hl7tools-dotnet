using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0205
    {
        public string Id { get { return @"0205"; } }

        public string TableId { get { return @"0205"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Price type"; } }

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
                            Value = @"AP",
                            Description = @"administrative price or handling fee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DC",
                            Description = @"direct unit cost",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IC",
                            Description = @"indirect unit cost",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PF",
                            Description = @"professional fee for performing provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TF",
                            Description = @"technology fee for use of equipment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TP",
                            Description = @"total price",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UP",
                            Description = @"unit price, may be based on length of procedure or service",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
