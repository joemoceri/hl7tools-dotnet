using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0905
    {
        public string Id { get { return @"0905"; } }

        public string TableId { get { return @"0905"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Shipment Status"; } }

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
                            Value = @"INV",
                            Description = @"Inventoried",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ONH",
                            Description = @"On Hold",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRC",
                            Description = @"Processing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REJ",
                            Description = @"Rejected",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TRN",
                            Description = @"In Transit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TTL",
                            Description = @"Triaged to Lab",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
