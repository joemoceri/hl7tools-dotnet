using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0180
    {
        public string Id { get { return @"0180"; } }

        public string TableId { get { return @"0180"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"RECORD LEVEL EVENT CODE"; } }

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
                            Value = @"MAC",
                            Description = @"Reactivate deactivated record",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MAD",
                            Description = @"Add record to master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MDC",
                            Description = @"Deactivate - discontinue using record in master file, but do not delete from database",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MDL",
                            Description = @"Delete record from master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MUP",
                            Description = @"Update record for master file",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
