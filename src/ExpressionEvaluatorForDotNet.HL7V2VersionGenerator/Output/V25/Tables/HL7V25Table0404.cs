using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0404
    {
        public string Id { get { return @"0404"; } }

        public string TableId { get { return @"0404"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Language Proficiency"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",
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
                            Description = @"Excellent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Good",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Fair",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Poor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5",
                            Description = @"Some (level unknown)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"6",
                            Description = @"None",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
