using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0076
    {
        public string Id { get { return @"0076"; } }

        public string TableId { get { return @"0076"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"MESSAGE TYPE"; } }

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
                            Value = @"ACK",
                            Description = @"General acknowledgement message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ADR",
                            Description = @"ADT response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ADT",
                            Description = @"ADT message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ARD",
                            Description = @"Ancillary report (display)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BAR",
                            Description = @"Add / change billing account",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DFT",
                            Description = @"Detail financial transaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DSR",
                            Description = @"Display response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCF",
                            Description = @"Delayed acknowledgement",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFD",
                            Description = @"Master files delayed application acknowledgement",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFK",
                            Description = @"Master file application acknowledgement",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFN",
                            Description = @"Master files notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFR",
                            Description = @"Master files response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NMD",
                            Description = @"Network management data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NMQ",
                            Description = @"Network management query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NMR",
                            Description = @"Network management response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORF",
                            Description = @"Observational result (record response)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORM",
                            Description = @"Order message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORR",
                            Description = @"Order acknowledgement message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORU",
                            Description = @"Observational result (unsolicited)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OSQ",
                            Description = @"Order status query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QRY",
                            Description = @"Query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RAR",
                            Description = @"Pharmacy administration information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RAS",
                            Description = @"Pharmacy administration message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RDE",
                            Description = @"Pharmacy encoded order message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RDR",
                            Description = @"Pharmacy dispense information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RDS",
                            Description = @"Pharmacy dispense message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RER",
                            Description = @"Pharmacy encoded order information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RGR",
                            Description = @"Pharmacy dose information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RGV",
                            Description = @"Pharmacy give message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ROR",
                            Description = @"Pharmacy prescription order response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRA",
                            Description = @"Pharmacy administration acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRD",
                            Description = @"Pharmacy dispense acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRE",
                            Description = @"Pharmacy encoded order acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRG",
                            Description = @"Pharmacy give acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UDM",
                            Description = @"Unsolicited display message",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
