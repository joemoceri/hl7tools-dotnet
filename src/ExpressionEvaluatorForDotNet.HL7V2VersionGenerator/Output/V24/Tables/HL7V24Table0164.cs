using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0164
    {
        public string Id { get { return @"0164"; } }

        public string TableId { get { return @"0164"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Administration device"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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
                            Value = @"AP",
                            Description = @"Applicator",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BT",
                            Description = @"Buretrol",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HL",
                            Description = @"Heparin Lock",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IPPB",
                            Description = @"IPPB",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IVP",
                            Description = @"IV Pump",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IVS",
                            Description = @"IV Soluset",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MI",
                            Description = @"Metered Inhaler",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NEB",
                            Description = @"Nebulizer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCA",
                            Description = @"PCA Pump",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
