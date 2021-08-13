using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0178
    {
        public string Id { get { return @"0178"; } }

        public string TableId { get { return @"0178"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"File level event code"; } }

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
                            Value = @"REP",
                            Description = @"Replace current version of this master file with the version contained in this message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPD",
                            Description = @"Change file records as defined in the record-level event codes for each record that follows",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
