using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0560
    {
        public string Id { get { return @"0560"; } }

        public string TableId { get { return @"0560"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Quantity Units"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",
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
                            Value = @"DY",
                            Description = @"Days",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FL",
                            Description = @"Units",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HS",
                            Description = @"Hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MN",
                            Description = @"Month",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"YY",
                            Description = @"Years",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
