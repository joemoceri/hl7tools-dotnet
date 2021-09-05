using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0436
    {
        public string Id { get { return @"0436"; } }

        public string TableId { get { return @"0436"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Sensitivity to Causative Agent Code"; } }

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
                            Value = @"AD",
                            Description = @"Adverse Reaction (Not otherwise classified)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AL",
                            Description = @"Allergy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CT",
                            Description = @"Contraindication",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IN",
                            Description = @"Intolerance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SE",
                            Description = @"Side Effect",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
