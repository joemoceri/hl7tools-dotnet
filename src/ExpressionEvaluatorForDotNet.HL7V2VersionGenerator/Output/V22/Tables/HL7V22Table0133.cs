using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0133
    {
        public string Id { get { return @"0133"; } }

        public string TableId { get { return @"0133"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"PROCEDURE PRACTITIONER TYPE"; } }

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
                            Value = @"AN",
                            Description = @"Anesthesiologist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CM",
                            Description = @"Certified Nurse Midwife",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NP",
                            Description = @"Nurse Practitioner",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PR",
                            Description = @"Procedure MD (surgeon)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RD",
                            Description = @"Radiologist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RS",
                            Description = @"Resident",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
