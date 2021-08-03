using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V223Table0168
    {
        public string Id { get { return @"0168"; } }

        public string TableId { get { return @"0168"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Processing priority"; } }

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
                            Value = @"A",
                            Description = @"As soon as possible (a priority lower than stat)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B",
                            Description = @"Do at bedside or portable (may be used with other codes)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Measure continuously (e.g., arterial line blood pressure)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Preoperative (to be done prior to surgery)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Routine",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Stat (do immediately)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Timing critical (do as near as possible to requested time)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
