using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0739
    {
        public string Id { get { return @"0739"; } }

        public string TableId { get { return @"0739"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Status Patient"; } }

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
                            Value = @"1",
                            Description = @"Normal length of stay",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Short length of stay",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Long length of stay",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
