using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0742
    {
        public string Id { get { return @"0742"; } }

        public string TableId { get { return @"0742"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"DRG Status Financial Calculation"; } }

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
                            Value = @"00",
                            Description = @"Effective weight calculated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"01",
                            Description = @"Hospital specific contract",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"03",
                            Description = @"Eeffective weight for transfer/referral calculated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"04",
                            Description = @"Referral from other hospital based on a cooperation (no DRG reimbursement)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"05",
                            Description = @"Invalid length of stay",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"10",
                            Description = @"No information/entry in cost data for this DRG",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"11",
                            Description = @"No relative weight found for department (type)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
