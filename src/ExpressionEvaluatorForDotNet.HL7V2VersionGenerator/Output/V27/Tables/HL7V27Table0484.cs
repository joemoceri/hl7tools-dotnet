using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0484
    {
        public string Id { get { return @"0484"; } }

        public string TableId { get { return @"0484"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Dispense Type"; } }

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
                            Value = @"B",
                            Description = @"Trial Quantity Balance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Compassionate Fill",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"New/Renew - Full Fill",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"New/Renew - Part Fill",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q",
                            Description = @"Refill - Part Fill",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Refill - Full Fill",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Manufacturer Sample",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Trial Quantity",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Z",
                            Description = @"Non-Prescription Fill",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
