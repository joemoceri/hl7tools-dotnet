using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0177
    {
        public string Id { get { return @"0177"; } }

        public string TableId { get { return @"0177"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Confidentiality code"; } }

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
                            Value = @"AID",
                            Description = @"AIDS patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EMP",
                            Description = @"Employee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ETH",
                            Description = @"Alcohol/drug treatment patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HIV",
                            Description = @"HIV(+) patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PSY",
                            Description = @"Psychiatric patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Restricted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Usual control",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UWM",
                            Description = @"Unwed mother",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Very restricted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VIP",
                            Description = @"Very important person or celebrity",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
