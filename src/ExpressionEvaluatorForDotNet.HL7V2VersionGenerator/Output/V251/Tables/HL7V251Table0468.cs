using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2251Table0468
    {
        public string Id { get { return @"0468"; } }

        public string TableId { get { return @"0468"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Payment Adjustment Code"; } }

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
                            Value = @"1",
                            Description = @"No payment adjustment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Designated current drug or biological payment adjustment applies to APC (status indicator G)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Designated new device payment adjustment applies to APC (status indicator H)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Designated new drug or new biological payment adjustment applies to APC (status indicator J)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5",
                            Description = @"Deductible not applicable (specific list of HCPCS codes)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
