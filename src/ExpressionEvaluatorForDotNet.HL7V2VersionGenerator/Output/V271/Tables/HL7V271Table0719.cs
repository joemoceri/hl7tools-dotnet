using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0719
    {
        public string Id { get { return @"0719"; } }

        public string TableId { get { return @"0719"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Access Restriction Reason Code"; } }

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
                            Value = @"DIA",
                            Description = @"Diagnosis-related",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EMP",
                            Description = @"Employee of this organization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORG",
                            Description = @"Organizational policy or requirement",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PAT",
                            Description = @"Patient Request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PHY",
                            Description = @"Physician Request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REG",
                            Description = @"Regulatory requirement",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VIP",
                            Description = @"Very important person or celebrity",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
