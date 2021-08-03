using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0008
    {
        public string Id { get { return @"0008"; } }

        public string TableId { get { return @"0008"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"ACKNOWLEDGMENT CODE"; } }

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
                            Description = @"Application accept (original mode) / Application acknowledgement: accept (enhanced mode)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AE",
                            Description = @"Application error (original mode) / Application acknowledgement: error (enhanced mode)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AR",
                            Description = @"Application reject (original mode) / Application acknowledgement: reject (enhanced mode)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CA",
                            Description = @"Enhanced mode:  Application acknowledgement:  Commit Accept",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CE",
                            Description = @"Enhanced mode:  Application acknowledgement:  Commit Error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CR",
                            Description = @"Enhanced mode:  Application acknowledgement:  Commit Reject",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
