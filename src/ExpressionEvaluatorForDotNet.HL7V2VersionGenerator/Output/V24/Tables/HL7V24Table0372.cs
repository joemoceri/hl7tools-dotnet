using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0372
    {
        public string Id { get { return @"0372"; } }

        public string TableId { get { return @"0372"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Specimen component"; } }

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
                            Value = @"BLD",
                            Description = @"Whole blood, homogeneous",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BSEP",
                            Description = @"Whole blood, separated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLAS",
                            Description = @"Plasma,  NOS(not otherwise specified)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPP",
                            Description = @"Platelet poor plasma",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRP",
                            Description = @"Platelet rich plasma",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SED",
                            Description = @"Sediment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SER",
                            Description = @"Serum,  NOS(not otherwise specified)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUP",
                            Description = @"Supernatant",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
