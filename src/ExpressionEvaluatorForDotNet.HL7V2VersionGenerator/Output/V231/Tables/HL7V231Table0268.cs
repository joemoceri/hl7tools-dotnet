using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0268
    {
        public string Id { get { return @"0268"; } }

        public string TableId { get { return @"0268"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Override"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Value = @"A",
                            Description = @"Override allowed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Override required",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"X",
                            Description = @"Override not allowed",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
