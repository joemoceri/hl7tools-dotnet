using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0483
    {
        public string Id { get { return @"0483"; } }

        public string TableId { get { return @"0483"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Authorization Mode"; } }

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
                            Value = @"EL",
                            Description = @"Electronic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EM",
                            Description = @"E-mail",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FX",
                            Description = @"Fax",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IP",
                            Description = @"In Person",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MA",
                            Description = @"Mail",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Paper",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PH",
                            Description = @"Phone",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"Reflexive (Automated system)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VC",
                            Description = @"Video-conference",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VO",
                            Description = @"Voice",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
