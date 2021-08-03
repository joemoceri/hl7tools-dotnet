using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0284
    {
        public string Id { get { return @"0284"; } }

        public string TableId { get { return @"0284"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Referral Category"; } }

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
                            Value = @"A",
                            Description = @"Ambulatory",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E",
                            Description = @"Emergency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Inpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Outpatient",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
