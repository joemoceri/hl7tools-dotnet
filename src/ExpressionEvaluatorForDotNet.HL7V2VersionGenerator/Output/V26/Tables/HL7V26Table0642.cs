using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0642
    {
        public string Id { get { return @"0642"; } }

        public string TableId { get { return @"0642"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Reorder Theory Codes"; } }

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
                            Value = @"D",
                            Description = @"DOP/DOQ",
                            Comment = @"Corresponds to the theory that calculates the appropriate order point and recommends the quantity to order based on system parameters and historical trends.  DOP stands for Dynamic Order Point, and DOQ stands for Dynamic Order Quantity."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"MIN/MAX",
                            Comment = @"Corresponds to theory - the quantity recommended is the Order Quantity, less the On Hand Quantity, and less the On Order Quantity.  The Order Amount is the desired Maximum On Hand Quantity."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Override",
                            Comment = @"The quantity recommended is the Order Quantity, less the On Order Quantity.  The Order Amount is the amount to order when the On Hand reaches the Order Point."
                        },
                    };
            } 
        }
    }
}
