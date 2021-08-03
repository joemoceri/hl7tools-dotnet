using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0359
    {
        public string Id { get { return @"0359"; } }

        public string TableId { get { return @"0359"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Diagnosis Priority"; } }

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
                            Value = @"0",
                            Description = @"Not included in diagnosis ranking",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"The primary diagnosis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2 …",
                            Description = @"For ranked secondary diagnoses",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
