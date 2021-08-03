using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0642
    {
        public string Id { get { return @"0642"; } }

        public string TableId { get { return @"0642"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Reorder Theory Codes"; } }

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
                            Value = @"D",
                            Description = @"DOP/DOQ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"MIN/MAX",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Override",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
