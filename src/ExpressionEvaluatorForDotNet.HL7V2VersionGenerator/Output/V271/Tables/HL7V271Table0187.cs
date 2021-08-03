using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0187
    {
        public string Id { get { return @"0187"; } }

        public string TableId { get { return @"0187"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Provider Billing"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",
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
                            Value = @"I",
                            Description = @"Institution bills for provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Provider does own billing",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
