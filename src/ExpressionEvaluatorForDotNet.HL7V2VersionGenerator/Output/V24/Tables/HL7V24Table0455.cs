using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0455
    {
        public string Id { get { return @"0455"; } }

        public string TableId { get { return @"0455"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Type of bill code"; } }

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
                            Value = @"131",
                            Description = @"Hospital - Outpatient - Admit thru Discharge Claim",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"141",
                            Description = @"Hospital - Other - Admit thru Discharge Claim",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
