using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0242
    {
        public string Id { get { return @"0242"; } }

        public string TableId { get { return @"0242"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Primary Observer's Qualification"; } }

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
                            Description = @"Health care consumer/patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"H",
                            Description = @"Other health professional",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Lawyer/attorney",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Mid-level professional (nurse, nurse practitioner, physician's assistant)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Other non-health professional",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Physician (osteopath, homeopath)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Pharmacist",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
