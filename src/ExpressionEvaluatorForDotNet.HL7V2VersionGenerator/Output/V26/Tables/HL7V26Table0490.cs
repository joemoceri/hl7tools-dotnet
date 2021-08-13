using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0490
    {
        public string Id { get { return @"0490"; } }

        public string TableId { get { return @"0490"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Specimen Reject Reason"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

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
                            Value = @"EX",
                            Description = @"Expired",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QS",
                            Description = @"Quantity not sufficient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RA",
                            Description = @"Missing patient ID number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RB",
                            Description = @"Broken container",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RC",
                            Description = @"Clotting",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RD",
                            Description = @"Missing collection date",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"Missing patient name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RH",
                            Description = @"Hemolysis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RI",
                            Description = @"Identification problem",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RM",
                            Description = @"Labeling",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RN",
                            Description = @"Contamination",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Missing phlebotomist ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RR",
                            Description = @"Improper storage",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RS",
                            Description = @"Name misspelling",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
