using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0426
    {
        public string Id { get { return @"0426"; } }

        public string TableId { get { return @"0426"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Blood Product Code"; } }

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
                            Value = @"CRYO",
                            Description = @"Cryoprecipitated AHF",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CRYOP",
                            Description = @"Pooled Cryoprecipitate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FFP",
                            Description = @"Fresh Frozen Plasma",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FFPTH",
                            Description = @"Fresh Frozen Plasma - Thawed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC",
                            Description = @"Packed Cells",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCA",
                            Description = @"Autologous Packed Cells",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCNEO",
                            Description = @"Packed Cells - Neonatal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCW",
                            Description = @"Washed Packed Cells",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLT",
                            Description = @"Platelet Concentrate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLTNEO",
                            Description = @"Reduced Volume Platelets",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLTP",
                            Description = @"Pooled Platelets",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLTPH",
                            Description = @"Platelet Pheresis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLTPHLR",
                            Description = @"Leukoreduced Platelet Pheresis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RWB",
                            Description = @"Reconstituted Whole Blood",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WBA",
                            Description = @"Autologous Whole Blood",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
