using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0190
    {
        public string Id { get { return @"0190"; } }

        public string TableId { get { return @"0190"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Address Type"; } }

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
                            Value = @"B",
                            Description = @"Firm/Business",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BA",
                            Description = @"Bad address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BDL",
                            Description = @"Birth delivery location  (address where birth occurred)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BI",
                            Description = @"Billing Address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BR",
                            Description = @"Residence at birth (home address at time of birth)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Current Or Temporary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Country Of Origin",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"H",
                            Description = @"Home",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Legal Address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Mailing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Birth (nee)  (birth address, not otherwise specified)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Office/Business",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Permanent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RH",
                            Description = @"Registry home. Refers to the information system, typically managed by a public health agency, that stores patient information such as immunization histories or cancer data, regardless of where the patient obtains services.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Service Location",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SH",
                            Description = @"Shipping Address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TM",
                            Description = @"Tube Address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Vacation",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
