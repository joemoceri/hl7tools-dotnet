using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0498
    {
        public string Id { get { return @"0498"; } }

        public string TableId { get { return @"0498"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Consent Status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",
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
                            Description = @"Active - Consent has been granted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B",
                            Description = @"Bypassed (Consent not sought)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Limited - Consent has been granted with limitations",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Pending - Consent has not yet been sought",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Refused - Consent has been refused",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"X",
                            Description = @"Rescinded - Consent was initially granted, but was subsequently revoked or ended.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
