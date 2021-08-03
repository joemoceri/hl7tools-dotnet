using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0076
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
                            Comment = @"2"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ADR",
                            Description = @"ADT response",
                            Comment = @"3"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ADT",
                            Description = @"ADT message",
                            Comment = @"3"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BAR",
                            Description = @"Add/change billing account",
                            Comment = @"6"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BPS",
                            Description = @"Blood product dispense status message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BRP",
                            Description = @"Blood product dispense status acknowledgement message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BRT",
                            Description = @"Blood product transfusion/disposition acknowledgement message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BTS",
                            Description = @"Blood product transfusion/disposition message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CRM",
                            Description = @"Clinical study registration message",
                            Comment = @"7"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CSU",
                            Description = @"Unsolicited study data message",
                            Comment = @"7"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DFT",
                            Description = @"Detail financial transactions",
                            Comment = @"6"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DOC",
                            Description = @"Document response",
                            Comment = @"9"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DSR",
                            Description = @"Display response",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EAC",
                            Description = @"Automated equipment command message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EAN",
                            Description = @"Automated equipment notification message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EAR",
                            Description = @"Automated equipment response message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EDR",
                            Description = @"Enhanced display response",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EQQ",
                            Description = @"Embedded query language query",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ERP",
                            Description = @"Event replay response",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ESR",
                            Description = @"Automated equipment status update acknowledgment message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ESU",
                            Description = @"Automated equipment status update message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INR",
                            Description = @"Automated equipment inventory request message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INU",
                            Description = @"Automated equipment inventory update message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LSR",
                            Description = @"Automated equipment log/service request message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LSU",
                            Description = @"Automated equipment log/service update message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCF",
                            Description = @"Delayed Acknowledgment (Retained for backward compatibility only)",
                            Comment = @"2"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MDM",
                            Description = @"Medical document management",
                            Comment = @"9"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFD",
                            Description = @"Master files delayed application acknowledgment",
                            Comment = @"8"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFK",
                            Description = @"Master files application acknowledgment",
                            Comment = @"8"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFN",
                            Description = @"Master files notification",
                            Comment = @"8"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFQ",
                            Description = @"Master files query",
                            Comment = @"8"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFR",
                            Description = @"Master files response",
                            Comment = @"8"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NMD",
                            Description = @"Application management data message",
                            Comment = @"14"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NMQ",
                            Description = @"Application management query message",
                            Comment = @"14"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NMR",
                            Description = @"Application management response message",
                            Comment = @"14"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMB",
                            Description = @"Blood product order message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMD",
                            Description = @"Dietary order",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMG",
                            Description = @"General clinical order message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMI",
                            Description = @"Imaging order",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OML",
                            Description = @"Laboratory order message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMN",
                            Description = @"Non-stock requisition order message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMP",
                            Description = @"Pharmacy/treatment order message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMS",
                            Description = @"Stock requisition order message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORB",
                            Description = @"Blood product order acknowledgement message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORD",
                            Description = @"Dietary order acknowledgment message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORF",
                            Description = @"Query for results of observation",
                            Comment = @"7"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORG",
                            Description = @"General clinical order acknowledgment message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORI",
                            Description = @"Imaging order acknowledgement message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORL",
                            Description = @"Laboratory acknowledgment message (unsolicited)",
                            Comment = @"7"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORM",
                            Description = @"Pharmacy/treatment order message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORN",
                            Description = @"Non-stock requisition - General order acknowledgment message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORP",
                            Description = @"Pharmacy/treatment order acknowledgment message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORR",
                            Description = @"General order response message response to any ORM",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORS",
                            Description = @"Stock requisition - Order acknowledgment message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORU",
                            Description = @"Unsolicited transmission of an observation message",
                            Comment = @"7"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OSQ",
                            Description = @"Query response for order status",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OSR",
                            Description = @"Query response for order status",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OUL",
                            Description = @"Unsolicited laboratory observation message",
                            Comment = @"7"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PEX",
                            Description = @"Product experience message",
                            Comment = @"7"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PGL",
                            Description = @"Patient goal message",
                            Comment = @"12"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PIN",
                            Description = @"Patient insurance information",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PMU",
                            Description = @"Add personnel record",
                            Comment = @"15"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPG",
                            Description = @"Patient pathway message (goal-oriented)",
                            Comment = @"12"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPP",
                            Description = @"Patient pathway message (problem-oriented)",
                            Comment = @"12"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPR",
                            Description = @"Patient problem message",
                            Comment = @"12"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPT",
                            Description = @"Patient pathway goal-oriented response",
                            Comment = @"12"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPV",
                            Description = @"Patient goal response",
                            Comment = @"12"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRR",
                            Description = @"Patient problem response",
                            Comment = @"12"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PTR",
                            Description = @"Patient pathway problem-oriented response",
                            Comment = @"12"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QBP",
                            Description = @"Query by parameter",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QCK",
                            Description = @"Deferred query",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QCN",
                            Description = @"Cancel query",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QRY",
                            Description = @"Query, original mode",
                            Comment = @"3"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QSB",
                            Description = @"Create subscription",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QSX",
                            Description = @"Cancel subscription/acknowledge message",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QVR",
                            Description = @"Query for previous events",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RAR",
                            Description = @"Pharmacy/treatment administration information",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RAS",
                            Description = @"Pharmacy/treatment administration message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RCI",
                            Description = @"Return clinical information",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RCL",
                            Description = @"Return clinical list",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RDE",
                            Description = @"Pharmacy/treatment encoded order message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RDR",
                            Description = @"Pharmacy/treatment dispense information",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RDS",
                            Description = @"Pharmacy/treatment dispense message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RDY",
                            Description = @"Display based response",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REF",
                            Description = @"Patient referral",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RER",
                            Description = @"Pharmacy/treatment encoded order information",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RGR",
                            Description = @"Pharmacy/treatment dose information",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RGV",
                            Description = @"Pharmacy/treatment give message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ROR",
                            Description = @"Pharmacy/treatment order response",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RPA",
                            Description = @"Return patient authorization",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RPI",
                            Description = @"Return patient information",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RPL",
                            Description = @"Return patient display list",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RPR",
                            Description = @"Return patient list",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQA",
                            Description = @"Request patient authorization",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQC",
                            Description = @"Request clinical information",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQI",
                            Description = @"Request patient information",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQP",
                            Description = @"Request patient demographics",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQQ",
                            Description = @"Event replay query",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRA",
                            Description = @"Pharmacy/treatment administration acknowledgment message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRD",
                            Description = @"Pharmacy/treatment dispense acknowledgment message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRE",
                            Description = @"Pharmacy/treatment encoded order acknowledgment message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRG",
                            Description = @"Pharmacy/treatment give acknowledgment message",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRI",
                            Description = @"Return referral information",
                            Comment = @"11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RSP",
                            Description = @"Segment pattern response",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RTB",
                            Description = @"Tabular response",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SIU",
                            Description = @"Schedule information unsolicited",
                            Comment = @"10"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPQ",
                            Description = @"Stored procedure request",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SQM",
                            Description = @"Schedule query message",
                            Comment = @"10"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SQR",
                            Description = @"Schedule query response",
                            Comment = @"10"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SRM",
                            Description = @"Schedule request message",
                            Comment = @"10"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SRR",
                            Description = @"Scheduled request response",
                            Comment = @"10"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SSR",
                            Description = @"Specimen status request message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SSU",
                            Description = @"Specimen status update message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUR",
                            Description = @"Summary product experience report",
                            Comment = @"7"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TBR",
                            Description = @"Tabular data response",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TCR",
                            Description = @"Automated equipment test code settings request message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TCU",
                            Description = @"Automated equipment test code settings update message",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UDM",
                            Description = @"Unsolicited display update message",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VQQ",
                            Description = @"Virtual table query",
                            Comment = @"5"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VXQ",
                            Description = @"Query for vaccination record",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VXR",
                            Description = @"Vaccination record response",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VXU",
                            Description = @"Unsolicited vaccination record update",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VXX",
                            Description = @"Response for vaccination query with multiple PID matches",
                            Comment = @"4"
                        },
                    };
            } 
        }
    }
}
