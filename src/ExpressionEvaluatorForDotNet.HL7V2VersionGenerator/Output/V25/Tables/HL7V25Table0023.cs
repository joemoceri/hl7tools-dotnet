using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0023
    {
        public string Id { get { return @"0023"; } }

        public string TableId { get { return @"0023"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Admit Source"; } }

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
                            Value = @"1",
                            Description = @"Physician referral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Clinic referral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"HMO referral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Transfer from a hospital",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5",
                            Description = @"Transfer from a skilled nursing facility",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"6",
                            Description = @"Transfer from another health care facility",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"7",
                            Description = @"Emergency room",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8",
                            Description = @"Court/law enforcement",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"9",
                            Description = @"Information not available",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
