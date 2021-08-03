using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0871
    {
        public string Id { get { return @"0871"; } }

        public string TableId { get { return @"0871"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Supply Risk Codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",
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
                            Value = @"COR",
                            Description = @"Corrosive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXP",
                            Description = @"Explosive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FLA",
                            Description = @"Flammable",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INJ",
                            Description = @"Injury Hazard",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RAD",
                            Description = @"Radioactive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TOX",
                            Description = @"Toxic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNK",
                            Description = @"Unknown",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
