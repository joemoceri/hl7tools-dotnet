using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0008
    {
        public string Id { get { return @"0008"; } }

        public string TableId { get { return @"0008"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Acknowledgment code"; } }

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
                            Value = @"AA",
                            Description = @"Original mode: Application Accept - Enhanced mode: Application acknowledgment: Accept",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AE",
                            Description = @"Original mode: Application Error - Enhanced mode: Application acknowledgment: Error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AR",
                            Description = @"Original mode: Application Reject - Enhanced mode: Application acknowledgment: Reject",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CA",
                            Description = @"Enhanced mode: Accept acknowledgment: Commit Accept",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CE",
                            Description = @"Enhanced mode: Accept acknowledgment: Commit Error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CR",
                            Description = @"Enhanced mode: Accept acknowledgment: Commit Reject",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
