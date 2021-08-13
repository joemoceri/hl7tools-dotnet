using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0364
    {
        public string Id { get { return @"0364"; } }

        public string TableId { get { return @"0364"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Comment Type"; } }

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
                            Value = @"1R",
                            Description = @"Primary Reason",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2R",
                            Description = @"Secondary Reason",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AI",
                            Description = @"Ancillary Instructions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DR",
                            Description = @"Duplicate/Interaction Reason",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GI",
                            Description = @"General Instructions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GR",
                            Description = @"General Reason",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PI",
                            Description = @"Patient Instructions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"Remark",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
