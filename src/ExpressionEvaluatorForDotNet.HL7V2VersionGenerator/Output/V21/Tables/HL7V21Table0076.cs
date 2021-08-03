using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0076
    {
        public string Id { get { return @"0076"; } }

        public string TableId { get { return @"0076"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"MESSAGE TYPE"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"ACK",
                            Description = @"General Acknowledgment       CNT       II",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ARD",
                            Description = @"Ancillary RPT (display)      ANR       VII",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BAR",
                            Description = @"Add/change billing account   BLN       VI",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DSR",
                            Description = @"Display response             QRY       V",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCF",
                            Description = @"Delayed acknowledgment       CNT       II",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORF",
                            Description = @"Observ. Result/record resp.  ANR       VII",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORM",
                            Description = @"Order                        ORD       IV",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORR",
                            Description = @"Order response message       ORD       IV",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORU",
                            Description = @"Observ. result/unsolicited   ANR       VII",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OSQ",
                            Description = @"Order status query           ORD       IV",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UDM",
                            Description = @"Unsolicited display          QRY       V",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
