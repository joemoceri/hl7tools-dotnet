using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0160
    {
        public string Id { get { return @"0160"; } }

        public string TableId { get { return @"0160"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Tray type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
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
                            Value = @"EARLY",
                            Description = @"Early tray",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GUEST",
                            Description = @"Guest tray",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LATE",
                            Description = @"Late tray",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MSG",
                            Description = @"Tray message only",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NO",
                            Description = @"No tray",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
