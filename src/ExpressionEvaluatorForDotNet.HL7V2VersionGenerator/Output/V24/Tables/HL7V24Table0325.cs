using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0325
    {
        public string Id { get { return @"0325"; } }

        public string TableId { get { return @"0325"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Location relationship ID"; } }

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
                            Value = @"ALI",
                            Description = @"Location Alias(es)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DTY",
                            Description = @"Nearest  dietary location",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LAB",
                            Description = @"Nearest  lab",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LB2",
                            Description = @"Second nearest lab",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PAR",
                            Description = @"Parent location",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RX",
                            Description = @"Nearest  pharmacy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RX2",
                            Description = @"Second nearest pharmacy",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
