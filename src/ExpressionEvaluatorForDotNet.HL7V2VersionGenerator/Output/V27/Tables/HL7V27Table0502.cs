using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0502
    {
        public string Id { get { return @"0502"; } }

        public string TableId { get { return @"0502"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Non-Subject Consenter Reason"; } }

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
                            Value = @"LM",
                            Description = @"Legally mandated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MIN",
                            Description = @"Subject is a minor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NC",
                            Description = @"Subject is not competent to consent",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
