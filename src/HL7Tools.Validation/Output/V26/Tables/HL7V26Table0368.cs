using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0368
    {
        public string Id { get { return @"0368"; } }

        public string TableId { get { return @"0368"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Remote control command"; } }

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
                            Value = @"AB",
                            Description = @"Abort",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CL",
                            Description = @"Clear",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CN",
                            Description = @"Clear Notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DI",
                            Description = @"Disable Sending Events",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EN",
                            Description = @"Enable Sending Events",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ES",
                            Description = @"Emergency -stop",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EX",
                            Description = @"Execute (command specified in field Parameters (ST) 01394)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IN",
                            Description = @"Initialize/Initiate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LC",
                            Description = @"Local Control Request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LK",
                            Description = @"Lock",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LO",
                            Description = @"Load",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Pause",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RC",
                            Description = @"Remote Control Request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"Resume",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SA",
                            Description = @"Sampling",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SU",
                            Description = @"Setup",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TT",
                            Description = @"Transport To",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UC",
                            Description = @"Unlock",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UN",
                            Description = @"Unload",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
