using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0076
    {
        public string Id { get { return @"0076"; } }

        public string TableId { get { return @"0076"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Message type"; } }

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
                            Description = @"General acknowledgment message",
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
                            Description = @"Ancillary RPT (display)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BAR",
                            Description = @"Add/change billing account",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNQ",
                            Description = @"Cancel query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CSU",
                            Description = @"Unsolicited clinical study data",
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
                            Value = @"EDR",
                            Description = @"Enhanced display response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EQQ",
                            Description = @"Embedded query language query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ERP",
                            Description = @"Event replay response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ERQ",
                            Description = @"Event replay query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCF",
                            Description = @"Delayed acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MDM",
                            Description = @"Documentation message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFD",
                            Description = @"Master files delayed application acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFK",
                            Description = @"Master files application acknowledgment",
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
                            Value = @"MFQ",
                            Description = @"Master files query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFR",
                            Description = @"Master files query response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORF",
                            Description = @"Observation result/record response",
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
                            Description = @"Order acknowledgment message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORU",
                            Description = @"Observation result/unsolicited",
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
                            Value = @"OSR",
                            Description = @"Order status response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PEX",
                            Description = @"Product experience",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PGL",
                            Description = @"Patient goal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PGQ",
                            Description = @"Patient goal query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PGR",
                            Description = @"Patient goal response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PIN",
                            Description = @"Patient Insurance Information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PIN",
                            Description = @"Patient information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPP",
                            Description = @"Patient pathway (problem-oriented)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPR",
                            Description = @"Patient problem",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPR",
                            Description = @"Patient problem",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPT",
                            Description = @"Patient pathway (goal oriented)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPV",
                            Description = @"Patient goal response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRQ",
                            Description = @"Patient care problem query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRR",
                            Description = @"Patient problem response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PTQ",
                            Description = @"Patient pathway (problem-oriented) query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PTR",
                            Description = @"Patient pathway (problem-oriented) response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PTU",
                            Description = @"Patient pathway (goal-oriented) query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PTV",
                            Description = @"Patient pathway (goal-oriented) response",
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
                            Value = @"RCI",
                            Description = @"Return clinical information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RCL",
                            Description = @"Return clinical list",
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
                            Value = @"REF",
                            Description = @"Patient referral",
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
                            Value = @"ROC",
                            Description = @"Request clinical information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ROD",
                            Description = @"Request patient demographics",
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
                            Value = @"RPA",
                            Description = @"Return patient authorization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RPI",
                            Description = @"Return patient information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RPL",
                            Description = @"Return patient display list",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RPR",
                            Description = @"Return patient list",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQA",
                            Description = @"Request patient authorization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQI",
                            Description = @"Request patient information",
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
                            Value = @"RRI",
                            Description = @"Return patient referral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SIU",
                            Description = @"Schedule information unsolicited",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPQ",
                            Description = @"Stored procedure request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SQM",
                            Description = @"Schedule query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SQR",
                            Description = @"Schedule query response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SRM",
                            Description = @"Study registration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SRM",
                            Description = @"Schedule request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SRR",
                            Description = @"Scheduled request response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TBR",
                            Description = @"Tabular response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UDM",
                            Description = @"Unsolicited display message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VQQ",
                            Description = @"Virtual table query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VXQ",
                            Description = @"Query for vaccination record",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VXR",
                            Description = @"Vaccination query record response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VXU",
                            Description = @"Unsolicited vaccination record update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VXX",
                            Description = @"Vaccination query response with multiple PID matches",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
