using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0126
    {
        public string Id { get { return @"0126"; } }

        public string TableId { get { return @"0126"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Quantity limited request"; } }

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
                            Value = @"CH",
                            Description = @"Characters",
                            Comment = @"RSP/RTB/RDY"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LI",
                            Description = @"Lines",
                            Comment = @"RTB/RDY"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PG",
                            Description = @"Pages",
                            Comment = @"RDY"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RD",
                            Description = @"Records",
                            Comment = @"RSP/RTB/RDY"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ZO",
                            Description = @"Locally defined",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
