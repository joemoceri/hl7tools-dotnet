using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0119
    {
        public string Id { get { return @"0119"; } }

        public string TableId { get { return @"0119"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Order control codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
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
                            Value = @"AF",
                            Description = @"Order/service refill request approval",
                            Comment = @"Placer Applications. AF is a response to RF where the placer authorizing a refill or quantity of refills."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CA",
                            Description = @"Cancel order/service request",
                            Comment = @"Placer Applications. A cancellation is a request by the placer for the filler not to do a previously ordered service. Confirmation of the cancellation request is provided by the filler, e.g., a message with an ORC-1-order control value of CR. Typical responses include, but are not limited to, CR - Cancelled as requested, UC - Unable to Cancel."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CH",
                            Description = @"Child order/service",
                            Comment = @"Placer or Filler Applications. Used in conjunction with the PA - Parent order control code. Refer to PA order control code for discussion."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CN",
                            Description = @"Combined result",
                            Comment = @"Filler Applications. The combined result code provides a mechanism to transmit results that are associated with two or more orders. This situation occurs commonly in radiology reports when the radiologist dictates a single report for two or more exams represented as two or more orders. For example, knee and hand films for a rheumatoid arthritis patient might generate a single dictation on the part of the radiologist. When such results are reported the CN code replaces the RE code in all but the last ORC, and the results follow the last ORC and its OBR. An example follows of a single report following three ORCs: MSH|...<cr>PID|...<cr>ORC|CN|...<cr> OBR|1|A4461XA^HIS|81641^RAD|73666^Bilateral Feet|...<cr> ORC|CN|...<cr> OBR|2|A4461XB^HIS|81642^RAD|73642^Bilateral Hand PA|...<cr> ORC|RE|...<cr> OBR|3|A4461XC^HIS|81643^RAD|73916^Bilateral Knees|...<cr> OBX|1|CE|73916&IMP|1|Radiologist's Impression|...<cr> OBX|2|CE|73642&IMP|1|Radiologist's Impression|...<cr> OBX|3|FT|73642&GDT|1|Description|...<cr>"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CR",
                            Description = @"Canceled as requested",
                            Comment = @"Filler Applications. A response by the filler application that a request to cancel (CA by the placer application) was performed successfully."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DC",
                            Description = @"Discontinue order/service request",
                            Comment = @"Placer Applications. A request by the placer application for the filler application to discontinue a previously requested service. The differentiation between discontinue and cancel is that discontinue effects the order/service and all future occurrences, cancel refers to just the present action. Typical responses include, but are not limited to, CR - Cancelled as requested, UC - Unable to Cancel."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DE",
                            Description = @"Data errors",
                            Comment = @"Placer or Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DF",
                            Description = @"Order/service refill request denied",
                            Comment = @"Placer Applications. In response to a Filler application requesting refill authorization (RF), DF indicates that the placer does not authorize refills for the order. ORC-16 Order Control Code reason may be used to indicate the reason for the request denial. Some suggested values include: AA           Patient unknown to the providerAB           Patient never under provider careAC           Patient no longer under provider careAD           Patient has requested refill too soon AE           Medication never prescribed for the patient AF           Patient should contact provider firstAG           Refill not appropriate Note that these values originate from the NCPDP SCRIPT Response Segment Code List Qualifiers. Materials Reproduced with the consent of ©National Council for Prescription Drug Programs, Inc. 1988, 1992, 2002 NCPDP."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DR",
                            Description = @"Discontinued as requested",
                            Comment = @"Filler Applications. The filler, in response to a request to discontinue (DC from the placer application), has discontinued the order/service."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FU",
                            Description = @"Order/service refilled, unsolicited",
                            Comment = @"Filler Applications. FU notifies the placer that the filler issued a refill for the order at the patient's request."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HD",
                            Description = @"Hold order request",
                            Comment = @"Placer Applications. Typical responses include, but are not limited to, CR - Cancelled as requested, UC - Unable to Cancel."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HR",
                            Description = @"On hold as requested",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LI",
                            Description = @"Link order/service to patient care problem or goal",
                            Comment = @"Placer or Filler Applications. Refer to Chapter 12 Patient Care for complete discussion."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MC",
                            Description = @"Miscellaneous Charge - not associated with an order",
                            Comment = @"applies to DFT^P03^DFT_P03 and DFT^P11^DFT_P11"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NA",
                            Description = @"Number assigned",
                            Comment = @"Placer Applications. There are three circumstances that involve requesting an order number (ORC-2-placer order number or ORC-3-filler order number): (1) When the filler application needs to request an ORC-3-filler order number from a centralized application (e.g., HIS). SN - The send order number code provides a mechanism for the filler to request an ORC-3-filler order number from some centralized application (called ""other"" in the table below), such as a central HIS, by sending an ORM message containing an ORC-1-order control value of SN. This ORC has a null ORC-3-filler order number and an ORC-2-placer order number created by the filler application when the filler originates the order. The order (SN type) message can be acknowledged by either one of two methods: a) By an order application acknowledgement message containing an ORC-1-order control value of OK. Then an unsolicited order message can be sent at a future time, containing an ORC with ORC-1-order control value of NA to provide the actual number assigned. b) By an order acknowledgement message containing an ORC-1-order control value of NA as described below. NA - The number assigned code allows the ""other"" application to notify the filler application of the newly-assigned filler order number. ORC-1-order control contains value of NA, ORC-2-placer order number (from the ORC with the SN value), and the newly-assigned filler order number. CodeFromORC-2-Placer Order NumberORC-3-Filler Order NumberSNfiller applicationplacer order number^filler application IDNullNAother applicationplacer order number^filler application IDfiller order number^filler application ID Note: Both the placer order number and the filler order number have the filler's application ID (2) When the filler application needs to request an ORC-2-placer order number from some other application (e.g., Order Entry). SN - The send order number code provides a mechanism for the filler application to request an ORC-2-placer order number from another application (called ""other"" in the table below) by sending an order message containing an ORC-1-order control value of SN. This ORC has a null ORC-2-placer order number and an ORC-3-filler order number created by the filler application when the filler originates the order. The order (SN type) message can be acknowledged by two methods: a) By an order application acknowledgement message containing an ORC-1-order control value of OK. Then an unsolicited order message can be sent at a future time, containing an ORC-1-order control value of NA to provide the actual number assigned.   b) By an order acknowledgement message containing an ORC-1-order control value of NA as described below. NA - The number assigned code allows the ""other"" application to notify the filler application of the newly-assigned ORC-2-placer order number. The ORC contains an ORC-1-order control value of NA, the newly-assigned ORC-2-placer order number, and the ORC-3-filler order number (from the ORC with the SN value). CodeFromORC-2-Placer Order NumberORC-3-Filler Order NumberSNfiller applicationnullfiller order number^filler application IDNAother applicationplacer order number^placer application IDfiller order number^filler application ID Note: The new ORC-2-placer order number has the placer's application ID (3) When an application (not the filler application) wants to assign an ORC-3-filler order number for a new order. NW - When the application creating an order (not the filler application) wants to assign a filler order number for a new order. or RO - (RO following an RP). In this case, the ""other"" application completes ORC-3-filler order number, using the filler application ID as the second component of the filler order number. CodeFromORC-2-Placer Order NumberORC-3-Filler Order NumberNW or ROOther application to filler applicationplacer order number^placer application IDfiller order number^filler application ID"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NW",
                            Description = @"New order/service",
                            Comment = @"Placer Applications.See comments for NA - Number Assigned."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OC",
                            Description = @"Order/service canceled",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OD",
                            Description = @"Order/service discontinued",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OE",
                            Description = @"Order/service released",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OF",
                            Description = @"Order/service refilled as requested",
                            Comment = @"Filler Applications. OF directly responds to the placer system's request for a refill."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OH",
                            Description = @"Order/service held",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OK",
                            Description = @"Order/service accepted & OK",
                            Comment = @"Filler Applications.See comments for NA - Number Assigned."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OP",
                            Description = @"Notification of order for outside dispense",
                            Comment = @"Placer Applications. These order control codes are used to communicate an order between systems where the order is intended for informational purposes. For example, an order that will be performed by a vendor outside the enterprise of communicating systems. The communicating systems may need to maintain information relative to the order for clinical continuity, but no actions to perform the ordered service are intended. OP represents an informational version of NW, PY represents the informational-only version of RO. NW and RO table notes also apply to OP and PY, respectively."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OR",
                            Description = @"Released as requested",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Parent order/service",
                            Comment = @"Filler Applications. The parent (PA) and child (CH) order control codes allow the spawning of ""child"" orders from a ""parent"" order without changing the parent (original order). One or more ORC segments with an ORC-1-order control value of PA are followed by one or more ORC segments with an ORC-1-order control value of CH. Whether OBR segments must be present is determined by the value of ORC-6-response flag. For example, suppose that a microbiology culture produced two organisms and corresponding susceptibility reports. Then the sequence of segments would be as follows: (see figure 4-4) The assignment of placer order numbers in the parent-child paradigm depends on whether the placer or filler creates the child order and in the latter case, on whether the placer supports the SN/NA transaction. If the placer creates the child orders it will assign their placer order numbers according to its usual procedures. If the filler creates the child orders there are two possibilities: each child will inherit the placer order number of its parent, or the filler will use the SN/NA transaction to request that the placer assign a placer order number. In either case, the filler application creates the filler order numbers of the children according to its usual procedures. Whenever a child order is transmitted in a message the ORC segment's ORC-8-parent is valued with the parent's filler order number (if originating from the filler) and with the parent's placer order number (if originating from the filler or if originating from the placer). The parent-child mechanism can be used to ""expand"" a parent order (e.g., an order for three EKGs on successive mornings)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PR",
                            Description = @"Previous Results with new order/service",
                            Comment = @"Placer Applications. PR indicates that this ORC is part of an ORU structure containing previous observation, which is embedded in the order. At least two main use cases require that the complete results of the previous observations be transmitted with the order. ·              Diagnostic laboratories referring tests to another lab for either confirmation of results (HIV, etc.) or due to not being equipped to do the tests (genetic testing, etc.). ·              Diagnostic laboratories sending test results to Knowledge Bases for the automated generation of diagnostic comments for inclusion into the lab report."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PY",
                            Description = @"Notification of replacement order for outside dispense",
                            Comment = @"Placer Applications. See comments for OP - Notification of order for outside dispense."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"Observations/Performed Service to follow",
                            Comment = @"Placer or Filler Applications. The observations-to-follow code is used to transmit patient-specific information with an order. An order detail segment (e.g., OBR) can be followed by one or more observation segments (OBX). Any observation that can be transmitted in an ORU message can be transmitted with this mechanism. When results are transmitted with an order, the results should immediately follow the order or orders that they support. The following example shows the sequence of segments for three Pharmacy orders. It illustrates the use of the RE code: SegmentOrder ControlCommentMSHPIDORCNWFirst new orderRXOFirst order segmentORCNW2nd new orderRXO2nd order segment[ORCREPatient-specific observation, optional in V 2.2 OBR]Observation OBR, optional in V 2.2OBXAn observation segmentOBXAnother observation segmentOBXAnother observation segmentOBXAnother observation segmentORCNW3rd orderRXO3rd order segment In this version of HL7, results can be transmitted with an order as one or more OBX segments without the necessity of including the ORC and OBR segments. Observations can be transmitted in an ORU message without using an ORC. There are times when it is necessary to transmit information not included in the OBR segments of the ORU message. In this case, it is recommended that the ORC be included in the ORU message. The order control value of RE is required only in ORM messages to indicate that an order is followed by observation results (OBX). The RE code is not necessary in the ORU message because it is expected that the OBR segments can be followed by observation results (OBX)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RF",
                            Description = @"Refill order/service request",
                            Comment = @"Placer or Filler Applications. RF accommodates requests by either the filler or the placer. The filler may be requesting refill authorization from the placer. A placer system may be requesting a refill to be done by the filler system. Typical responses include, but are not limited to: For a Filler request AF - Order/service refill request approval, DF - Order/service refill request denied; for a Placer request RE - Observations/Performed Service to follow, UF - Unable to refill."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RL",
                            Description = @"Release previous hold",
                            Comment = @"Placer Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RO",
                            Description = @"Replacement order",
                            Comment = @"Placer or Filler Applications. A replacement is the substitution of one or more orders for one or more previously ordered services. The replaced orders are treated as though they were canceled. If and when an ordered service can be replaced are local site-specific determinations. Use the parent/child order control codes if the site specifies that the original order must remain intact. Do not use the replacement codes under this circumstance. For each order to be replaced, use an ORC-1-order control value of RP (request for a replacement going to a filler) or RU (an unsolicited replacement created by the filler) used by the filler to notify the placer and/or other systems). By local agreement, the ORC segment (with RP or RU) may be followed by its original order detail segment. The ORC segments (with RP or RU) must be followed by an ORC segment with an ORC-1-order control value of RO (indicating the replacement order). By local agreement, the ORC with the RO value may be followed by an order detail segment. For example, suppose that an ancillary application were replacing two OBR orders with three different orders. The sequence of segments would be as follows: SegOrder ControlCommentORCRU1st replaced ORCOBR1st replaced order's detail segmentORCRU2nd replaced ORCOBR2nd replaced order's detail segmentORCRO1st replacement ORCOBR1st replacement order's detail segmentORCRO2nd replacement ORCOBR2nd replacement order's detail segmentORCRO3rd replacement ORCOBR3rd replacement order's detail segment Whether the OBR segments must be present is determined by the value of ORC-6-response flag. The described replacement method will handle all possible cases of replacement: one-into-one, many-into-one, one-into-many, and many-into-many. If the placer sent this request to the filler with two RPs, and this was a response back from the filler to the placer, the two RUs (replaced unsolicited) would be two RQs (replaced as requested). (see figure 4-3) SegOrder ControlCommentORCRQ1st replaced ORCOBR1st replaced order's detail segmentORCRQ2nd replaced ORCOBR2nd replaced order's detail segmentORCRO1st replacement ORCOBR1st replacement order's detail segmentORCRO2nd replacement ORCOBR2nd replacement order's detail segmentORCRO3rd replacement ORCOBR3rd replacement order's detail segment The replacement order code is sent by the filler application to another application indicating the exact replacement ordered service. It is used with the RP and RU order control codes as described above. The rules for the order numbers in ORC segments with an order control value of RO are determined by the replacement type (RP or RU). In the case of the RU type (i.e., unsolicited replacement by the filler), the filler order number is generated as usual by the filler application. The placer order number is identical to the placer order number of the first transmitted ORC with an order control value of RU. In the case of the RP type (i.e., a replacement request from another application to the filler), the placer order number is generated by the placer application using the procedure for new orders. The filler order number is generated by the filler application using the procedure identical for new orders. If a replacement sequence is used in an ORU message (i.e., during results reporting), the following are the recommended segments to be used for the replacement orders: ORC with an order control value of RO. Any OBR segments (can be replaced by any order detail segments). Optionally followed by observation result segments (OBX) NTE segments can appear after the OBR (or any order detail segment) or after an OBX segment as in a regular ORU message."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Order/service replace request",
                            Comment = @"Placer Applications. A replacement is the substitution of one or more orders for one or more previously ordered services. See comment 1 on RO - Replacement Order for further discussion. The order replace request code permits the order filler to replace one or more new orders with one or more new orders, at the request of the placer application. The rules for the order numbers in ORC segments with an order control value of RO are determined by the replacement type (RP or RU). In the case of the RU type (i.e., unsolicited replacement by the filler), the filler order number is generated as usual by the filler application. The placer order number is identical to the placer order number of the first transmitted ORC with an order control value of RU. In the case of the RP type (i.e., a replacement request from another application to the filler), the placer order number is generated by the placer application using the procedure for new orders. The filler order number is generated by the filler application using the procedure identical for new orders. If a replacement sequence is used in an ORU message (i.e., during results reporting), the following are the recommended segments to be used for the replacement orders: a) ORC with an order control value of RO b) Any OBR segments (can be replaced by any order detail segments) c) Optionally followed by observation result segments (OBX) d) NTE segments can appear after the OBR (or any order detail segment) or after an OBX segment as in a regular ORU message"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQ",
                            Description = @"Replaced as requested",
                            Comment = @"Filler Applications. A replacement is the substitution of one or more orders for one or more previously ordered services. See comment 1 on RO - Replacement Order for further discussion. The order replace request code permits the order filler to replace one or more new orders with one or more new orders, at the request of the placer application. The replacement order code is sent by the filler application to another application indicating the exact replacement ordered service. It is used with the RP and RU order control codes as described above. The rules for the order numbers in ORC segments with an order control value of RO are determined by the replacement type (RP or RU). In the case of the RU type (i.e., unsolicited replacement by the filler), the filler order number is generated as usual by the filler application. The placer order number is identical to the placer order number of the first transmitted ORC with an order control value of RU. In the case of the RP type (i.e., a replacement request from another application to the filler), the placer order number is generated by the placer application using the procedure for new orders. The filler order number is generated by the filler application using the procedure identical for new orders. If a replacement sequence is used in an ORU message (i.e., during results reporting), the following are the recommended segments to be used for the replacement orders: a) ORC with an order control value of RO b) Any OBR segments (can be replaced by any order detail segments) c) Optionally followed by observation result segments (OBX) d) NTE segments can appear after the OBR (or any order detail segment) or after an OBX segment as in a regular ORU message"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RR",
                            Description = @"Request received",
                            Comment = @"Placer or Filler Applications. Left in for backward compatibility. In the current version it is equivalent to an accept acknowledgment. The request-received code indicates that an order message has been received and will be processed later. The order has not yet undergone the processing that would permit a more exact response."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RU",
                            Description = @"Replaced unsolicited",
                            Comment = @"Filler Applications. A replacement is the substitution of one or more orders for one or more previously ordered services. See comment 1 on RO - Replacement Order for further discussion. The unsolicited replacement code permits the filler application to notify another application without being requested from the placer application. The rules for the order numbers in ORC segments with an order control value of RO are determined by the replacement type (RP or RU). In the case of the RU type (i.e., unsolicited replacement by the filler), the filler order number is generated as usual by the filler application. The placer order number is identical to the placer order number of the first transmitted ORC with an order control value of RU. In the case of the RP type (i.e., a replacement request from another application to the filler), the placer order number is generated by the placer application using the procedure for new orders. The filler order number is generated by the filler application using the procedure identical for new orders. If a replacement sequence is used in an ORU message (i.e., during results reporting), the following are the recommended segments to be used for the replacement orders: a) ORC with an order control value of RO b) Any OBR segments (can be replaced by any order detail segments) c) Optionally followed by observation result segments (OBX) d) NTE segments can appear after the OBR (or any order detail segment) or after an OBX segment as in a regular ORU message"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SC",
                            Description = @"Status changed",
                            Comment = @"Placer or Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SN",
                            Description = @"Send order/service number",
                            Comment = @"Placer Applications.See comments for NA - Number Assigned."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SR",
                            Description = @"Response to send order/service status request",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SS",
                            Description = @"Send order/service status request",
                            Comment = @"Placer Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UA",
                            Description = @"Unable to accept order/service",
                            Comment = @"Filler Applications. An unable-to-accept code is used when a new order cannot be accepted by the filler. Possible reasons include requesting a prescription for a drug which the patient is allergic to or for an order which requires certain equipment resources which are not available such that the order cannot be filled. Note that this is different from the communication level acceptance as defined within the MSA segment."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UC",
                            Description = @"Unable to cancel",
                            Comment = @"Filler Applications. An unable-to-cancel code is used when the ordered service is at a point that it cannot be canceled by the filler or when local rules prevent cancellation by the filler. The use of this code is dependent on the value of ORC-6-response flag."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UD",
                            Description = @"Unable to discontinue",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UF",
                            Description = @"Unable to refill",
                            Comment = @"Filler Applications. Negative response to RF Refill order/service request, indicating that the receiving application was not able to complete the refill request."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UH",
                            Description = @"Unable to put on hold",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UM",
                            Description = @"Unable to replace",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UN",
                            Description = @"Unlink order/service from patient care problem or goal",
                            Comment = @"Placer or Filler Applications. Refer to Chapter 12 Patient Care for complete discussion."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UR",
                            Description = @"Unable to release",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UX",
                            Description = @"Unable to change",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XO",
                            Description = @"Change order/service request",
                            Comment = @"Placer Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XR",
                            Description = @"Changed as requested",
                            Comment = @"Filler Applications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XX",
                            Description = @"Order/service changed, unsol.",
                            Comment = @"Filler Applications."
                        },
                    };
            } 
        }
    }
}
