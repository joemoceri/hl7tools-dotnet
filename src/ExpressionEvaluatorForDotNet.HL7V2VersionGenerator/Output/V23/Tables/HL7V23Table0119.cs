using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V223Table0119
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
                            Description = @"Order refill request approval",
                            Comment = @"AF is a response back from the placer authorizing a refill or quantity of refills"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CA",
                            Description = @"Cancel order request",
                            Comment = @"A cancellation is a request not to do a previously ordered service.  Confirmation of the cancellation request is provided by the filler, e.g., a message with an ORC-1-order control value of CR"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CH",
                            Description = @"Child order",
                            Comment = @"The parent (PA) and child (CH) order control codes allow the spawning of “child” orders from a “parent” order without changing the parent (original order). "
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CN",
                            Description = @"Combined result",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CR",
                            Description = @"Canceled as requested",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DC",
                            Description = @"Discontinue order request",
                            Comment = @"A discontinue request code is used to stop an ongoing ordered service.  It is not the same as a cancellation request, which is used in an attempt to prevent an order from happening"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DE",
                            Description = @"Data Errors",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DF",
                            Description = @"Order refill request denied",
                            Comment = @"DF indicates that the placer will not authorize refills for the order. The order control code reason may be used to indicate the reason for the request denial. "
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FU",
                            Description = @"Order refilled or unsolicited",
                            Comment = @"FU notifies the placer that the filler issued a refill for the order at the patient’s request. "
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HD",
                            Description = @"Hold order request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HR",
                            Description = @"On hold as requested",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LI",
                            Description = @"Link order to patient care message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NA",
                            Description = @"Number assigned",
                            Comment = @"The number assigned code allows the “other” application to notify the filler application of the newly-assigned filler order number.  ORC-1-order control contains value of NA, ORC-2-placer order number (from the ORC with the SN value), and the newly-assigned filler order number"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NW",
                            Description = @"New Order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OC",
                            Description = @"Order canceled",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OD",
                            Description = @"Order discontinued",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OE",
                            Description = @"Order released",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OF",
                            Description = @"Order refilled as requested",
                            Comment = @"OF directly responds to the placer system’s request for a refill "
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OH",
                            Description = @"Order held",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OK",
                            Description = @"Order accepted and OK",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OR",
                            Description = @"Released as requested",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Parent order",
                            Comment = @"The parent (PA) and child (CH) order control codes allow the spawning of “child” orders from a “parent” order without changing the parent (original order). "
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"Observations to follow",
                            Comment = @"The observations-to-follow code is used to transmit patient-specific information with an order.  An order detail segment (e.g., OBR) can be followed by one or more observation segments (OBX).  Any observation that can be transmitted in an ORU message can be transmitted with this mechanism.  When results are transmitted with an order, the results should immediately follow the order or orders that they support"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RF",
                            Description = @"Refill order request",
                            Comment = @"RF accommodates requests by both the filler or the placer.  The filler may be requesting refill authorization from the placer. A placer system may be requesting a refill to be done by the filler system"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RL",
                            Description = @"Release previous hold",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RO",
                            Description = @"Replacement order",
                            Comment = @"The replacement order code is sent by the filler application to another application indicating the exact replacement ordered service.  It is used with the RP and RU order control codes as described above"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Order replace request",
                            Comment = @"The order replace request code permits the order filler to replace one or more new orders with one or more new orders, at the request of the placer application"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQ",
                            Description = @"Replaced as requested",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RR",
                            Description = @"Request received",
                            Comment = @"Left in for backward compatibility.  In the current version it is equivalent to an accept acknowledgment.  The request-received code indicates that an order message has been received and will be processed later.  The order has not yet undergone the processing that would permit a more exact response"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RU",
                            Description = @"Replaced unsolicited",
                            Comment = @"The unsolicited replacement code permits the filler application to notify another application without being requested from the placer application"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SC",
                            Description = @"Status changed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SN",
                            Description = @"Send order number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SR",
                            Description = @"Response to send order status request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SS",
                            Description = @"Send order status request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UA",
                            Description = @"Unable to accept order",
                            Comment = @"An unable-to-accept code is used when a new order cannot be accepted by the filler.  Possible reasons include requesting a prescription for a drug which the patient is allergic to or for an order which requires certain equipment resources which are not available such that the order cannot be filled.  Note that this is different from the communication level acceptance as defined within the MSA segment"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UC",
                            Description = @"Unable to cancel",
                            Comment = @"An unable-to-cancel code is used when the ordered service is at a point that it cannot be canceled by the filler or when local rules prevent cancellation by the filler.  The use of this code is dependent on the value of ORC-6-response flag"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UF",
                            Description = @"Unable to refill",
                            Comment = @"UF indicates an application level denial by the filler system to an authorized refill request"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UH",
                            Description = @"Unable to put on hold",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UM",
                            Description = @"Unable to replace",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UN",
                            Description = @"Unlink order from patient care message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UR",
                            Description = @"Unable to release",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UX",
                            Description = @"Unable to change",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XO",
                            Description = @"Change order request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XR",
                            Description = @"Changed as requested",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XX",
                            Description = @"Order changed or unsolicited",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
