using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0493
    {
        public string Id { get { return @"0493"; } }

        public string TableId { get { return @"0493"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Specimen Condition"; } }

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
                            Value = @"AUT",
                            Description = @"Autolyzed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CLOT",
                            Description = @"Clotted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CON",
                            Description = @"Contaminated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COOL",
                            Description = @"Cool",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FROZ",
                            Description = @"Frozen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HEM",
                            Description = @"Hemolyzed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LIVE",
                            Description = @"Live",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ROOM",
                            Description = @"Room temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SNR",
                            Description = @"Sample not received",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
