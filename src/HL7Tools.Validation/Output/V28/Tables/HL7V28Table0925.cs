using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0925
    {
        public string Id { get { return @"0925"; } }

        public string TableId { get { return @"0925"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Phlebotomy Issue"; } }

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
                            Value = @"ACN",
                            Description = @"Air Contamination",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CLT",
                            Description = @"Clotted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COL",
                            Description = @"Collapse",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DAK",
                            Description = @"Defective Apheresis Kit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DBG",
                            Description = @"Defective Bag",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DMT",
                            Description = @"Defective Instrument",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DND",
                            Description = @"Defective Needle",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INF",
                            Description = @"Infiltration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IPF",
                            Description = @"Instrument Power Failure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MIS",
                            Description = @"Missed / in tissue",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAD",
                            Description = @"Needle adjustment",
                            Comment = @"(this may not end a procedure, if successful will impact component production)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PFL",
                            Description = @"Poor flow",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VSM",
                            Description = @"Vein Spasm",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
