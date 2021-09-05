using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0003
    {
        public string Id { get { return @"0003"; } }

        public string TableId { get { return @"0003"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Event type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
"CH_12",

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
                            Value = @"022",
                            Description = @"ORL - General laboratory order response message to any OML",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A01",
                            Description = @"ADT/ACK - Admit/visit notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A02",
                            Description = @"ADT/ACK - Transfer a patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A03",
                            Description = @"ADT/ACK -  Discharge/end visit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A04",
                            Description = @"ADT/ACK -  Register a patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A05",
                            Description = @"ADT/ACK -  Pre-admit a patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A06",
                            Description = @"ADT/ACK -  Change an outpatient to an inpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A07",
                            Description = @"ADT/ACK -  Change an inpatient to an outpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A08",
                            Description = @"ADT/ACK -  Update patient information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A09",
                            Description = @"ADT/ACK -  Patient departing - tracking",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A10",
                            Description = @"ADT/ACK -  Patient arriving - tracking",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A11",
                            Description = @"ADT/ACK -  Cancel admit/visit notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A12",
                            Description = @"ADT/ACK -  Cancel transfer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A13",
                            Description = @"ADT/ACK -  Cancel discharge/end visit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A14",
                            Description = @"ADT/ACK -  Pending admit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A15",
                            Description = @"ADT/ACK -  Pending transfer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A16",
                            Description = @"ADT/ACK -  Pending discharge",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A17",
                            Description = @"ADT/ACK -  Swap patients",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A18",
                            Description = @"ADT/ACK -  Merge patient information (for backward compatibility only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A19",
                            Description = @"QRY/ADR -  Patient query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A20",
                            Description = @"ADT/ACK -  Bed status update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A21",
                            Description = @"ADT/ACK -  Patient goes on a “leave of absence”",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A22",
                            Description = @"ADT/ACK -  Patient returns from a “leave of absence”",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A23",
                            Description = @"ADT/ACK -  Delete a patient record",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A24",
                            Description = @"ADT/ACK -  Link patient information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A25",
                            Description = @"ADT/ACK -  Cancel pending discharge",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A26",
                            Description = @"ADT/ACK -  Cancel pending transfer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A27",
                            Description = @"ADT/ACK -  Cancel pending admit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A28",
                            Description = @"ADT/ACK -  Add person information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A29",
                            Description = @"ADT/ACK -  Delete person information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A30",
                            Description = @"ADT/ACK -  Merge person information (for backward compatibility only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A31",
                            Description = @"ADT/ACK -  Update person information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A32",
                            Description = @"ADT/ACK -  Cancel patient arriving - tracking",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A33",
                            Description = @"ADT/ACK -  Cancel patient departing - tracking",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A34",
                            Description = @"ADT/ACK -  Merge patient information - patient ID only (for backward compatibility only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A35",
                            Description = @"ADT/ACK -  Merge patient information - account number only (for backward compatibility only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A36",
                            Description = @"ADT/ACK -  Merge patient information - patient ID and account number (for backward compatibility only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A37",
                            Description = @"ADT/ACK -  Unlink patient information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A38",
                            Description = @"ADT/ACK - Cancel pre-admit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A39",
                            Description = @"ADT/ACK - Merge person - patient ID (for backward compatibility only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A40",
                            Description = @"ADT/ACK - Merge patient - patient identifier list",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A41",
                            Description = @"ADT/ACK - Merge account - patient account number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A42",
                            Description = @"ADT/ACK - Merge visit - visit number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A43",
                            Description = @"ADT/ACK - Move patient information - patient identifier list",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A44",
                            Description = @"ADT/ACK - Move account information - patient account number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A45",
                            Description = @"ADT/ACK - Move visit information - visit number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A46",
                            Description = @"ADT/ACK - Change patient ID (for backward compatibility only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A47",
                            Description = @"ADT/ACK - Change patient identifier list",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A48",
                            Description = @"ADT/ACK - Change alternate patient ID (for backward compatibility only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A49",
                            Description = @"ADT/ACK - Change patient account number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A50",
                            Description = @"ADT/ACK - Change visit number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A51",
                            Description = @"ADT/ACK - Change alternate visit ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C01",
                            Description = @"CRM - Register a patient on a clinical trial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C02",
                            Description = @"CRM - Cancel a patient registration on clinical trial (for clerical mistakes only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C03",
                            Description = @"CRM - Correct/update registration information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C04",
                            Description = @"CRM - Patient has gone off a clinical trial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C05",
                            Description = @"CRM - Patient enters phase of clinical trial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C06",
                            Description = @"CRM - Cancel patient entering a phase (clerical mistake)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C07",
                            Description = @"CRM - Correct/update phase information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C08",
                            Description = @"CRM - Patient has gone off phase of clinical trial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C09",
                            Description = @"CSU - Automated time intervals for reporting, like monthly",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C10",
                            Description = @"CSU - Patient completes the clinical trial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C11",
                            Description = @"CSU - Patient completes a phase of the clinical trial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C12",
                            Description = @"CSU - Update/correction of patient order/result information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNQ",
                            Description = @"QRY/EQQ/VQQ/RQQ - Cancel query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I01",
                            Description = @"RQI/RPI - Request for insurance information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I02",
                            Description = @"RQI/RPL - Request/receipt of patient selection display list",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I03",
                            Description = @"RQI/RPR - Request/receipt of patient selection list",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I04",
                            Description = @"RQD/RPI - Request for patient demographic data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I05",
                            Description = @"RQC/RCI - Request for patient clinical information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I06",
                            Description = @"RQC/RCL - Request/receipt of clinical data listing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I07",
                            Description = @"PIN/ACK - Unsolicited insurance information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I08",
                            Description = @"RQA/RPA - Request for treatment authorization information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I09",
                            Description = @"RQA/RPA - Request for modification to an authorization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I10",
                            Description = @"RQA/RPA - Request for resubmission of an authorization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I11",
                            Description = @"RQA/RPA - Request for cancellation of an authorization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I12",
                            Description = @"REF/RRI -  Patient referral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I13",
                            Description = @"REF/RRI - Modify patient referral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I14",
                            Description = @"REF/RRI - Cancel patient referral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I15",
                            Description = @"REF/RRI - Request patient referral status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M01",
                            Description = @"MFN/MFK - Master file not otherwise specified ( for backward compatibility only )",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M02",
                            Description = @"MFN/MFK - Master file - staff practitioner",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M03",
                            Description = @"MFN/MFK - Master file - test/observation ( for backward compatibility only )",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M04",
                            Description = @"MFN/MFK - Master files charge description",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M05",
                            Description = @"MFN/MFK - Patient location master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M06",
                            Description = @"MFN/MFK - Clinical study with phases and schedules master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M07",
                            Description = @"MFN/MFK - Clinical study without phases but with schedules master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M08",
                            Description = @"MFN/MFK - Test/observation (numeric) master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M09",
                            Description = @"MFN/MFK - Test/observation (categorical) master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M10",
                            Description = @"MFN/MFK - Test /observation batteries master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M11",
                            Description = @"MFN/MFK - Test/calculated observations master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O01",
                            Description = @"ORM - Order message (also RDE, RDS, RGV, RAS)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O02",
                            Description = @"ORR - Order response (also RRE, RRD, RRG, RRA)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P01",
                            Description = @"BAR/ACK - Add patient accounts",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P02",
                            Description = @"BAR/ACK - Purge patient accounts",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P03",
                            Description = @"DFT/ACK - Post detail financial transaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P04",
                            Description = @"QRY/DSP - Generate bill and A/R statements",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P05",
                            Description = @"BAR/ACK - Update account",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P06",
                            Description = @"BAR/ACK - End account",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q01",
                            Description = @"QRY/DSR - Query sent for immediate response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q02",
                            Description = @"QRY/QCK - Query sent for deferred response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q03",
                            Description = @"DSR/ACK - Deferred response to a query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q04",
                            Description = @"EQQ - Embedded query language query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q05",
                            Description = @"UDM/ACK - Unsolicited display update message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q06",
                            Description = @"OSQ/OSR - Query for order status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R01",
                            Description = @"ORU/ACK - Unsolicited transmission of an observation message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R02",
                            Description = @"QRY - Query for results of observation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R03",
                            Description = @"QRY/DSR Display-oriented results, query/unsol. update (for backward compatibility only) (Replaced by Q05)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R04",
                            Description = @"ORF - Response to query; transmission of requested observation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R05",
                            Description = @"QRY/DSR - query for display results",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R06",
                            Description = @"UDM - unsolicited update/display results",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RAR",
                            Description = @"RAR - Pharmacy administration information query response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RER",
                            Description = @"RER-Pharmacy encoded order information query response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ROR",
                            Description = @"ROR - Pharmacy prescription order query response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S01",
                            Description = @"SRM/SRR - Request new appointment booking",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S02",
                            Description = @"SRM/SRR - Request appointment rescheduling",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S03",
                            Description = @"SRM/SRR - Request appointment modification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S04",
                            Description = @"SRM/SRR - Request appointment cancellation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S05",
                            Description = @"SRM/SRR - Request appointment discontinuation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S06",
                            Description = @"SRM/SRR - Request appointment deletion",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S07",
                            Description = @"SRM/SRR - Request addition of service/resource on appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S08",
                            Description = @"SRM/SRR - Request modification of service/resource on appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S09",
                            Description = @"SRM/SRR - Request cancellation of service/resource on appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S10",
                            Description = @"SRM/SRR - Request discontinuation of service/resource on appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S11",
                            Description = @"SRM/SRR - Request deletion of service/resource on appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S12",
                            Description = @"SIU/ACK - Notification of new appointment booking",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S13",
                            Description = @"SIU/ACK - Notification of appointment rescheduling",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S14",
                            Description = @"SIU/ACK - Notification of appointment modification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S15",
                            Description = @"SIU/ACK - Notification of appointment cancellation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S16",
                            Description = @"SIU/ACK - Notification of appointment discontinuation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S17",
                            Description = @"SIU/ACK - Notification of appointment deletion",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S18",
                            Description = @"SIU/ACK - Notification of addition of service/resource on appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S19",
                            Description = @"SIU/ACK - Notification of modification of service/resource on appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S20",
                            Description = @"SIU/ACK - Notification of cancellation of service/resource on appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S21",
                            Description = @"SIU/ACK - Notification of discontinuation of service/resource on appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S22",
                            Description = @"SIU/ACK - Notification of deletion of service/resource on appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S23",
                            Description = @"SIU/ACK - Notification of blocked schedule time slot(s)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S24",
                            Description = @"SIU/ACK - Notification of opened (“unblocked”) schedule time slot(s)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S25",
                            Description = @"SQM/SQR - Schedule query message and response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S26",
                            Description = @"SIU/ACK Notification that patient did not show up for schedule appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T01",
                            Description = @"MDM/ACK - Original document notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T02",
                            Description = @"MDM/ACK - Original document notification and content",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T03",
                            Description = @"MDM/ACK - Document status change notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T04",
                            Description = @"MDM/ACK - Document status change notification and content",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T05",
                            Description = @"MDM/ACK - Document addendum notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T06",
                            Description = @"MDM/ACK - Document addendum notification and content",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T07",
                            Description = @"MDM/ACK - Document edit notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T09",
                            Description = @"MDM/ACK - Document cancel notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V01",
                            Description = @"VXQ - Query for vaccination record",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V02",
                            Description = @"VXX - Response to vaccination query returning multiple PID matches",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V03",
                            Description = @"VXR - Vaccination record response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V04",
                            Description = @"VXU - Unsolicited vaccination record update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Varies",
                            Description = @"MFQ/MFR - Master files query (use event same as asking for e.g., M05 - location)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W01",
                            Description = @"ORU - Waveform result, unsolicited transmission of requested information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W02",
                            Description = @"QRF - Waveform result, response to query",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
