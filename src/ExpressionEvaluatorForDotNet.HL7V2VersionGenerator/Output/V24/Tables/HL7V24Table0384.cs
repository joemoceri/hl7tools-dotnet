using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0384
    {
        public string Id { get { return @"0384"; } }

        public string TableId { get { return @"0384"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Substance type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",
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
                            Value = @"CO",
                            Description = @"Control",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DI",
                            Description = @"Diluent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LI",
                            Description = @"Measurable Liquid Item",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LW",
                            Description = @"Liquid Waste",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MR",
                            Description = @"Multiple Test Reagent (consumption cannot be tied to orders for single test)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OT",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"Pretreatment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PW",
                            Description = @"Purified Water",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RC",
                            Description = @"Reagent Calibrator",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SC",
                            Description = @"Countable Solid Item (e.g., Tip, etc.)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SR",
                            Description = @"Single Test Reagent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SW",
                            Description = @"Solid Waste",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
