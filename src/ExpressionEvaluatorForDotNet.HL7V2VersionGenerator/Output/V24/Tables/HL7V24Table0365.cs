using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0365
    {
        public string Id { get { return @"0365"; } }

        public string TableId { get { return @"0365"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Equipment state"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",
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
                            Value = @"CL",
                            Description = @"Clearing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CO",
                            Description = @"Configuring",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ES",
                            Description = @"E-stopped",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ID",
                            Description = @"Idle",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IN",
                            Description = @"Initializing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OP",
                            Description = @"Normal Operation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Pausing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PD",
                            Description = @"Paused",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PU",
                            Description = @"Powered Up",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
