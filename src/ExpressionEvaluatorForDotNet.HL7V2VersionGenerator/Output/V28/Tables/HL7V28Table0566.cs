using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0566
    {
        public string Id { get { return @"0566"; } }

        public string TableId { get { return @"0566"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Blood Unit Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
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
                            Value = @"GRN",
                            Description = @"Granulocytes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LYM",
                            Description = @"Lymphocytes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLS",
                            Description = @"Plasma",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLT",
                            Description = @"Platelets",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PSC",
                            Description = @"Peripheral Stem Cells",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RBC",
                            Description = @"Red Blood Cells",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WBL",
                            Description = @"Whole Blood",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
