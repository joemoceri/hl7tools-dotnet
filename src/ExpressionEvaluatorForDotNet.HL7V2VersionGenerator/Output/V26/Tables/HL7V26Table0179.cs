using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0179
    {
        public string Id { get { return @"0179"; } }

        public string TableId { get { return @"0179"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Response level"; } }

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
                            Value = @"AL",
                            Description = @"Always.  All MFA segments (whether denoting errors or not) must be returned via the application-level acknowledgment message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ER",
                            Description = @"Error/Reject conditions only.  Only MFA segments denoting errors must be returned via the application-level acknowledgment for this message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NE",
                            Description = @"Never.  No application-level response needed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SU",
                            Description = @"Success.  Only MFA segments denoting success must be returned via the application-level acknowledgment for this message",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
