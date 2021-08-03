using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0562
    {
        public string Id { get { return @"0562"; } }

        public string TableId { get { return @"0562"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Processing Consideration Codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",
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
                            Value = @"DFADJ",
                            Description = @"Deferred Adjudication Processing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EFORM",
                            Description = @"Electronic form to follow",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FAX",
                            Description = @"Fax to follow",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PAPER",
                            Description = @"Paper documentation to follow",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PYRDELAY",
                            Description = @"Delayed by a Previous Payer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RTADJ",
                            Description = @"Real Time Adjudication Processing",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
