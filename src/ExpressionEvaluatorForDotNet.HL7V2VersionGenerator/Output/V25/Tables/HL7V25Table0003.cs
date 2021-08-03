using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0003
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
                            Value = @"A52",
                            Description = @"ADT/ACK - Cancel leave of absence for a patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A53",
                            Description = @"ADT/ACK - Cancel patient returns from a leave of absence",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A54",
                            Description = @"ADT/ACK - Change attending doctor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A55",
                            Description = @"ADT/ACK - Cancel change attending doctor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A60",
                            Description = @"ADT/ACK - Update allergy information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A61",
                            Description = @"ADT/ACK - Change consulting doctor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A62",
                            Description = @"ADT/ACK - Cancel change consulting doctor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B01",
                            Description = @"PMU/ACK - Add personnel record",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B02",
                            Description = @"PMU/ACK - Update personnel record",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B03",
                            Description = @"PMU/ACK - Delete personnel re cord",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B04",
                            Description = @"PMU/ACK - Active practicing person",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B05",
                            Description = @"PMU/ACK - Deactivate practicing person",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B06",
                            Description = @"PMU/ACK - Terminate practicing person",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B07",
                            Description = @"PMU/ACK - Grant Certificate/Permission",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B08",
                            Description = @"PMU/ACK - Revoke Certificate/Permission",
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
                            Description = @"Cancel Query",
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
                            Description = @"REF/RRI - Patient referral",
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
                            Value = @"J01",
                            Description = @"QCN/ACK - Cancel query/acknowledge message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"J02",
                            Description = @"QSX/ACK - Cancel subscription/acknowledge message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"K11",
                            Description = @"RSP - Segment pattern response in response to QBP^Q11",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"K13",
                            Description = @"RTB - Tabular response in response to QBP^Q13",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"K15",
                            Description = @"RDY - Display response in response to QBP^Q15",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"K21",
                            Description = @"RSP - Get person demographics response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"K22",
                            Description = @"RSP - Find candidates response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"K23",
                            Description = @"RSP - Get corresponding identifiers response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"K24",
                            Description = @"RSP - Allocate identifiers response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"K25",
                            Description = @"RSP - Personnel Information by Segment Response",
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
                            Value = @"M12",
                            Description = @"MFN/MFK - Master file notification message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M13",
                            Description = @"MFN/MFK - Master file notification - general",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M14",
                            Description = @"MFN/MFK - Master file notification - site defined",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M15",
                            Description = @"MFN/MFK - Inventory item master file notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N01",
                            Description = @"NMQ/NMR - Application management query message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N02",
                            Description = @"NMD/ACK - Application management data message (unsolicited)",
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
                            Value = @"O03",
                            Description = @"OMD - Diet order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O04",
                            Description = @"ORD - Diet order acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O05",
                            Description = @"OMS - Stock requisition order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O06",
                            Description = @"ORS - Stock requisition acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O07",
                            Description = @"OMN - Non-stock requisition order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O08",
                            Description = @"ORN - Non-stock requisition acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O09",
                            Description = @"OMP - Pharmacy/treatment order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O10",
                            Description = @"ORP - Pharmacy/treatment order acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O11",
                            Description = @"RDE - Pharmacy/treatment encoded order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O12",
                            Description = @"RRE - Pharmacy/treatment encoded order acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O13",
                            Description = @"RDS - Pharmacy/treatment dispense",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O14",
                            Description = @"RRD - Pharmacy/treatment dispense acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O15",
                            Description = @"RGV - Pharmacy/treatment give",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O16",
                            Description = @"RRG - Pharmacy/treatment give acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O17",
                            Description = @"RAS - Pharmacy/treatment administration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O18",
                            Description = @"RRA - Pharmacy/treatment administration acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O19",
                            Description = @"OMG - General clinical order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O20",
                            Description = @"ORG/ORL - General clinical order response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O21",
                            Description = @"OML - Laboratory order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O22",
                            Description = @"ORL - General laboratory order response message to any OML",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O23",
                            Description = @"OMI - Imaging order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O24",
                            Description = @"ORI - Imaging order response message to any OMI",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O25",
                            Description = @"RDE - Pharmacy/treatment refill authorization request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O26",
                            Description = @"RRE - Pharmacy/Treatment Refill Authorization Acknowledgement",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O27",
                            Description = @"OMB - Blood product order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O28",
                            Description = @"ORB - Blood product order acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O29",
                            Description = @"BPS - Blood product dispense status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O30",
                            Description = @"BRP - Blood product dispense status acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O31",
                            Description = @"BTS - Blood product transfusion/disposition",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O32",
                            Description = @"BRT - Blood product transfusion/disposition acknowledgment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O33",
                            Description = @"OML - Laboratory order for multiple orders related to a single specimen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O34",
                            Description = @"ORL - Laboratory order response message to a multiple order related to single specimen OML",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O35",
                            Description = @"OML - Laboratory order for multiple orders related to a single container of a specimen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O36",
                            Description = @"ORL - Laboratory order response message to a single container of a specimen OML",
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
                            Value = @"P07",
                            Description = @"PEX - Unsolicited initial individual product experience report",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P08",
                            Description = @"PEX - Unsolicited update individual product experience report",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P09",
                            Description = @"SUR - Summary product experience report",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P10",
                            Description = @"BAR/ACK -Transmit Ambulatory Payment  Classification(APC)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P11",
                            Description = @"DFT/ACK - Post Detail Financial Transactions - New",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P12",
                            Description = @"BAR/ACK - Update Diagnosis/Procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC1",
                            Description = @"PPR - PC/ problem add",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC2",
                            Description = @"PPR - PC/ problem update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC3",
                            Description = @"PPR - PC/ problem delete",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC4",
                            Description = @"QRY - PC/ problem query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC5",
                            Description = @"PRR - PC/ problem response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC6",
                            Description = @"PGL - PC/ goal add",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC7",
                            Description = @"PGL - PC/ goal update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC8",
                            Description = @"PGL - PC/ goal delete",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC9",
                            Description = @"QRY - PC/ goal query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCA",
                            Description = @"PPV - PC/ goal response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCB",
                            Description = @"PPP - PC/ pathway (problem-oriented) add",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCC",
                            Description = @"PPP - PC/ pathway (problem-oriented) update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCD",
                            Description = @"PPP - PC/ pathway (problem-oriented) delete",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCE",
                            Description = @"QRY - PC/ pathway (problem-oriented) query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCF",
                            Description = @"PTR - PC/ pathway (problem-oriented) query response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCG",
                            Description = @"PPG - PC/ pathway (goal-oriented) add",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCH",
                            Description = @"PPG - PC/ pathway (goal-oriented) update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCJ",
                            Description = @"PPG - PC/ pathway (goal-oriented) delete",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCK",
                            Description = @"QRY - PC/ pathway (goal-oriented) query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCL",
                            Description = @"PPT - PC/ pathway (goal-oriented) query response",
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
                            Value = @"Q07",
                            Description = @"VQQ - Virtual table query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q08",
                            Description = @"SPQ - Stored procedure request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q09",
                            Description = @"RQQ - event replay query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q11",
                            Description = @"QBP - Query by parameter requesting an RSP segment pattern response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q13",
                            Description = @"QBP - Query by parameter requesting an  RTB - tabular response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q15",
                            Description = @"QBP - Query by parameter requesting an RDY display response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q16",
                            Description = @"QSB - Create subscription",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q17",
                            Description = @"QVR - Query for previous events",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q21",
                            Description = @"QBP - Get person demographics",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q22",
                            Description = @"QBP - Find candidates",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q23",
                            Description = @"QBP - Get corresponding identifiers",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q24",
                            Description = @"QBP - Allocate identifiers",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q25",
                            Description = @"QBP - Personnel Information by Segment Query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q26",
                            Description = @"ROR - Pharmacy/treatment order response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q27",
                            Description = @"RAR - Pharmacy/treatment administration information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q28",
                            Description = @"RDR - Pharmacy/treatment dispense information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q29",
                            Description = @"RER - Pharmacy/treatment encoded order information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q30",
                            Description = @"RGR - Pharmacy/treatment dose information",
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
                            Value = @"R07",
                            Description = @"EDR - Enhanced Display Response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R08",
                            Description = @"TBR - Tabular Data Response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R09",
                            Description = @"ERP - Event Replay Response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R21",
                            Description = @"OUL - Unsolicited laboratory observation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R22",
                            Description = @"OUL - Unsolicited Specimen Oriented Observation Message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R23",
                            Description = @"OUL - Unsolicited Specimen Container Oriented Observation Message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R24",
                            Description = @"OUL - Unsolicited Order Oriented Observation Message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R30",
                            Description = @"ORU - Unsolicited Point-Of-Care Observation Message Without Existing Order - Place An Order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R31",
                            Description = @"ORU - Unsolicited New Point-Of-Care Observation Message - Search For An Order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R32",
                            Description = @"ORU - Unsolicited Pre-Ordered Point-Of-Care Observation",
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
                            Value = @"T08",
                            Description = @"MDM/ACK - Document edit notification and content",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T09",
                            Description = @"MDM/ACK - Document replacement notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T10",
                            Description = @"MDM/ACK - Document replacement notification and content",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T11",
                            Description = @"MDM/ACK - Document cancel notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T12",
                            Description = @"QRY/DOC - Document query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U01",
                            Description = @"ESU/ACK - Automated equipment status update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U02",
                            Description = @"ESR/ACK - Automated equipment status request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U03",
                            Description = @"SSU/ACK - Specimen status update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U04",
                            Description = @"SSR/ACK - specimen status request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U05",
                            Description = @"INU/ACK  - Automated equipment inventory update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U06",
                            Description = @"INR/ACK - Automated equipment inventory request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U07",
                            Description = @"EAC/ACK - Automated equipment command",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U08",
                            Description = @"EAR/ACK - Automated equipment response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U09",
                            Description = @"EAN/ACK - Automated equipment notification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U10",
                            Description = @"TCU/ACK - Automated equipment test code settings update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U11",
                            Description = @"TCR/ACK - Automated equipment test code settings request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U12",
                            Description = @"LSU/ACK - Automated equipment log/service update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U13",
                            Description = @"LSR/ACK - Automated equipment log/service request",
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
