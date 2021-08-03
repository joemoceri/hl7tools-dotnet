using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0511
    {
        public string Id { get { return @"0511"; } }

        public string TableId { get { return @"0511"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"BP Observation Status Codes Interpretation"; } }

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
                            Value = @"C",
                            Description = @"Record coming over is a correction and thus replaces a final status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Deletes the BPX record",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Final status; Can only be changed with a corrected status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Order detail description only (no status)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Preliminary status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W",
                            Description = @"Post original as wrong, e.g., transmitted for wrong patient",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
