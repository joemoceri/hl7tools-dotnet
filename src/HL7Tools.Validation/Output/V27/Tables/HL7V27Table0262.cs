using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0262
    {
        public string Id { get { return @"0262"; } }

        public string TableId { get { return @"0262"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Privacy Level"; } }

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
                            Value = @"F",
                            Description = @"Isolation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"J",
                            Description = @"Private room - medically justified",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Private room",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q",
                            Description = @"Private room - due to overflow",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Semi-private room",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W",
                            Description = @"Ward",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
