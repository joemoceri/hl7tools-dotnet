using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0009
    {
        public string Id { get { return @"0009"; } }

        public string TableId { get { return @"0009"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Ambulatory Status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Value = @"A0",
                            Description = @"No functional limitations",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A1",
                            Description = @"Ambulates with assistive device",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A2",
                            Description = @"Wheelchair/stretcher bound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A3",
                            Description = @"Comatose; non-responsive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A4",
                            Description = @"Disoriented",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A5",
                            Description = @"Vision impaired",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A6",
                            Description = @"Hearing impaired",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A7",
                            Description = @"Speech impaired",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A8",
                            Description = @"Non-English speaking",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A9",
                            Description = @"Functional level unknown",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B1",
                            Description = @"Oxygen therapy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B2",
                            Description = @"Special equipment (tubes, IVs, catheters)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B3",
                            Description = @"Amputee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B4",
                            Description = @"Mastectomy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B5",
                            Description = @"Paraplegic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B6",
                            Description = @"Pregnant",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
