using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0757
    {
        public string Id { get { return @"0757"; } }

        public string TableId { get { return @"0757"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Status Respiration Minutes"; } }

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
                            Value = @"0",
                            Description = @"Respiration minutes not used for grouping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Listed respiration minutes used for grouping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"OPS code value used for grouping",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
