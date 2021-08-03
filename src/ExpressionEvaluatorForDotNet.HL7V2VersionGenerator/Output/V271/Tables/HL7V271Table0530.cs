using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0530
    {
        public string Id { get { return @"0530"; } }

        public string TableId { get { return @"0530"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Organization, Agency, Department"; } }

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
                            Value = @"AE",
                            Description = @"American Express",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEA",
                            Description = @"Drug Enforcement Agency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DOD",
                            Description = @"Department of Defense",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MC",
                            Description = @"Master Card",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VA",
                            Description = @"Veterans Affairs",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VI",
                            Description = @"Visa",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
