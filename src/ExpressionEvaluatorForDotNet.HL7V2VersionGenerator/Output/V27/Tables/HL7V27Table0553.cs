using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0553
    {
        public string Id { get { return @"0553"; } }

        public string TableId { get { return @"0553"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Invoice Control Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",
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
                            Value = @"AA",
                            Description = @"Authorization request for inpatient admission",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AI",
                            Description = @"Combined Authorization and Adjudication request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CA",
                            Description = @"Cancel Authorization request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CG",
                            Description = @"Cancel Invoice Product/Service Group",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CL",
                            Description = @"Cancel Invoice Product/Service Line Item",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CN",
                            Description = @"Cancel Invoice",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CP",
                            Description = @"Copy of Invoice",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CQ",
                            Description = @"Coverage Register Query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EA",
                            Description = @"Authorization request for inpatient stay extension",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OA",
                            Description = @"Original Authorization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OR",
                            Description = @"Original Invoice",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Pre-Authorization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PD",
                            Description = @"Pre-Determination Invoice",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RA",
                            Description = @"Re-Assessment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RC",
                            Description = @"Referral Pre-Authorization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RU",
                            Description = @"Referral authorization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SA",
                            Description = @"Special Authorization",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
