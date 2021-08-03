using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0371
    {
        public string Id { get { return @"0371"; } }

        public string TableId { get { return @"0371"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Additive"; } }

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
                            Value = @"BOR",
                            Description = @"Borate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C32",
                            Description = @"3.2%  Citrate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C38",
                            Description = @"3.8% Citrate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EDTK",
                            Description = @"Potassium/K EDTA",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EDTN",
                            Description = @"Sodium/Na EDTA",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HCL6",
                            Description = @"6N HCL",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HEPL",
                            Description = @"Lithium/Li  Heparin",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HEPN",
                            Description = @"Sodium/Na  Heparin",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
