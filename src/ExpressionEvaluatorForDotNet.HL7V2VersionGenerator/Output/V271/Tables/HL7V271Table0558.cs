using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0558
    {
        public string Id { get { return @"0558"; } }

        public string TableId { get { return @"0558"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Payee Relationship to Invoice"; } }

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
                            Value = @"FM",
                            Description = @"Family Member",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GT",
                            Description = @"Guarantor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"Patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SB",
                            Description = @"Subscriber",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
