using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0669
    {
        public string Id { get { return @"0669"; } }

        public string TableId { get { return @"0669"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Load Status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

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
                            Value = @"LCC",
                            Description = @"Load is Complete",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LCN",
                            Description = @"Load Canceled",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LCP",
                            Description = @"Load In Process",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LLD",
                            Description = @"Building a Load",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
