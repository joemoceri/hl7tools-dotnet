using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0175
    {
        public string Id { get { return @"0175"; } }

        public string TableId { get { return @"0175"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Master file identifier code"; } }

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
                            Value = @"CDM",
                            Description = @"Charge description master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CLN",
                            Description = @"Clinic master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CMA",
                            Description = @"Clinical study with phases and scheduled master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CMB",
                            Description = @"Clinical study without phases but with scheduled master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INV",
                            Description = @"Inventory master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LOC",
                            Description = @"Location master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMA",
                            Description = @"Numerical observation master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMB",
                            Description = @"Categorical observation master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMC",
                            Description = @"Observation batteries master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMD",
                            Description = @"Calculated observations master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OME",
                            Description = @"Other Observation/Service Item master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRA",
                            Description = @"Practitioner master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STF",
                            Description = @"Staff master file",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
