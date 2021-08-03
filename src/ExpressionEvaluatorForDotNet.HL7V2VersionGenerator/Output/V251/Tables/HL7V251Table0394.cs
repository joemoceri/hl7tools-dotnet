using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0394
    {
        public string Id { get { return @"0394"; } }

        public string TableId { get { return @"0394"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Response modality"; } }

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
                            Value = @"B",
                            Description = @"Batch",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Real Time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Bolus (a series of responses sent at the same time without use of batch formatting)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
