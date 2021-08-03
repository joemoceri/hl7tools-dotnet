using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0391
    {
        public string Id { get { return @"0391"; } }

        public string TableId { get { return @"0391"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Segment group"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
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
                            Value = @"etc",
                            Description = null,
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OBRG",
                            Description = @"OBR group",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORCG",
                            Description = @"ORC group",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PIDG",
                            Description = @"PID group",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RXAG",
                            Description = @"RXA group",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RXDG",
                            Description = @"RXD group",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RXEG",
                            Description = @"RXE group",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RXOG",
                            Description = @"RXO group",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
