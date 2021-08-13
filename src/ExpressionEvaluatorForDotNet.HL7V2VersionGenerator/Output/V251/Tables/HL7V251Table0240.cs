using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0240
    {
        public string Id { get { return @"0240"; } }

        public string TableId { get { return @"0240"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Event Consequence"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

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
                            Value = @"C",
                            Description = @"Congenital anomaly/birth defect",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Death",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"H",
                            Description = @"Caused hospitalized",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Incapacity which is significant, persistent or permanent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"J",
                            Description = @"Disability which is significant, persistent or permanent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Life threatening",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Prolonged hospitalization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Required intervention to prevent permanent impairment/damage",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
