using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0734
    {
        public string Id { get { return @"0734"; } }

        public string TableId { get { return @"0734"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Grouper Status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Value = @"0",
                            Description = @"Normal grouping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Invalid or missing primary diagnosis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Diagnosis is not allowed to be primary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Data does not fulfill DRG criteria",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Invalid age, admission date, date of birth or discharge date",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5",
                            Description = @"Invalid gender",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"6",
                            Description = @"Invalid discharge status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"7",
                            Description = @"Invalid weight ad admission",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8",
                            Description = @"Invalid length of stay",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"9",
                            Description = @"Invalid field ""same day""",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
