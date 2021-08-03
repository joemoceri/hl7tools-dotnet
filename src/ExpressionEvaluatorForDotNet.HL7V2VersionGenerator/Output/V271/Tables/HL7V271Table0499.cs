using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0499
    {
        public string Id { get { return @"0499"; } }

        public string TableId { get { return @"0499"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Consent Bypass Reason"; } }

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
                            Value = @"E",
                            Description = @"Emergency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PJ",
                            Description = @"Professional Judgment",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
