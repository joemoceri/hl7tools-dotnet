using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0933
    {
        public string Id { get { return @"0933"; } }

        public string TableId { get { return @"0933"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Intended Procedure Type"; } }

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
                            Value = @"2RC",
                            Description = @"Double Red Cells",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GRN",
                            Description = @"Granulocytes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HEM",
                            Description = @"Hemachromatosis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HPC",
                            Description = @"Hematopoietic Progenitor Cells",
                            Comment = @"Stem Cells and other cells classified as Hematopoietic"
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
                            Value = @"PNP",
                            Description = @"Platelets and Plasma",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PNR",
                            Description = @"Platelets and Red Cells",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPR",
                            Description = @"Platelets, Plasma, and Red Cells",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THA",
                            Description = @"Therapeutic Apheresis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THW",
                            Description = @"Therapeutic Whole Blood",
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
