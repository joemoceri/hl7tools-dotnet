using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0324
    {
        public string Id { get { return @"0324"; } }

        public string TableId { get { return @"0324"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Location characteristic ID"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Value = @"GEN",
                            Description = @"Gender of patient(s)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IMP",
                            Description = @"Implant: can be used for radiation implant patients",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INF",
                            Description = @"Infectious disease: this location can be used for isolation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LCR",
                            Description = @"Level of care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LIC",
                            Description = @"Licensed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OVR",
                            Description = @"Overflow",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRL",
                            Description = @"Privacy level: indicating the level of private versus non-private room",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SET",
                            Description = @"Bed is set up",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SHA",
                            Description = @"Shadow: a temporary holding location that does not physically exist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SMK",
                            Description = @"Smoking",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STF",
                            Description = @"Bed is staffed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TEA",
                            Description = @"Teaching location",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
