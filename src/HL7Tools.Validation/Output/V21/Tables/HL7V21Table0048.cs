using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0048
    {
        public string Id { get { return @"0048"; } }

        public string TableId { get { return @"0048"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"WHAT SUBJECT FILTER"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"ADV",
                            Description = @"Advice/Diagnosis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANU",
                            Description = @"Nursing Unit Look up",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"APN",
                            Description = @"Patient name look up",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAN",
                            Description = @"Cancel. Used to cancel a query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEM",
                            Description = @"Demographics",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MRI",
                            Description = @"Most recent inpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MRO",
                            Description = @"Most recent outpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OTH",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRO",
                            Description = @"Procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RES",
                            Description = @"Result",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STA",
                            Description = @"Status",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
