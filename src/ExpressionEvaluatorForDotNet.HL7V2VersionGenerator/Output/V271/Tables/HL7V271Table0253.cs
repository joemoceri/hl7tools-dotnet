using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0253
    {
        public string Id { get { return @"0253"; } }

        public string TableId { get { return @"0253"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Indirect Exposure Mechanism"; } }

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
                            Value = @"B",
                            Description = @"Breast milk",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Father",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Transplacental",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"X",
                            Description = @"Blood product",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
