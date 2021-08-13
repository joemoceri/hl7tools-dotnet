using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0508
    {
        public string Id { get { return @"0508"; } }

        public string TableId { get { return @"0508"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Blood Product Processing Requirements"; } }

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
                            Value = @"AU",
                            Description = @"Autologous Unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CM",
                            Description = @"CMV Negative",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CS",
                            Description = @"CMV Safe",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DI",
                            Description = @"Directed Unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FR",
                            Description = @"Fresh unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HB",
                            Description = @"Hemoglobin S Negative",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HL",
                            Description = @"HLA Matched",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IG",
                            Description = @"IgA Deficient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IR",
                            Description = @"Irradiated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LR",
                            Description = @"Leukoreduced",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WA",
                            Description = @"Washed",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
