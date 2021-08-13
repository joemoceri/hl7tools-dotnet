using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0119
    {
        public string Id { get { return @"0119"; } }

        public string TableId { get { return @"0119"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Order Control Codes"; } }

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
                            Value = @"AF",
                            Description = @"Order/service refill request approval",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CA",
                            Description = @"Cancel order/service request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CH",
                            Description = @"Child order/service",
                            Comment = null
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
                            Description = @"Discontinue order/service request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DE",
                            Description = @"Data errors",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DF",
                            Description = @"Order/service refill request denied",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DR",
                            Description = @"Discontinued as requested",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FU",
                            Description = @"Order/service refilled, unsolicited",
                            Comment = null
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
                            Description = @"Link order/service to patient care problem or goal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MC",
                            Description = @"Miscellaneous Charge - not associated with an order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NA",
                            Description = @"Number assigned",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NW",
                            Description = @"New order/service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OC",
                            Description = @"Order/service canceled",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OD",
                            Description = @"Order/service discontinued",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OE",
                            Description = @"Order/service released",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OF",
                            Description = @"Order/service refilled as requested",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OH",
                            Description = @"Order/service held",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OK",
                            Description = @"Order/service accepted & OK",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OP",
                            Description = @"Notification of order for outside dispense",
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
                            Description = @"Parent order/service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PR",
                            Description = @"Previous Results with new order/service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PY",
                            Description = @"Notification of replacement order for outside dispense",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"Observations/Performed Service to follow",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RF",
                            Description = @"Refill order/service request",
                            Comment = null
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
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Order/service replace request",
                            Comment = null
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
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RU",
                            Description = @"Replaced unsolicited",
                            Comment = null
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
                            Description = @"Send order/service number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SR",
                            Description = @"Response to send order/service status request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SS",
                            Description = @"Send order/service status request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UA",
                            Description = @"Unable to accept order/service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UC",
                            Description = @"Unable to cancel",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UD",
                            Description = @"Unable to discontinue",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UF",
                            Description = @"Unable to refill",
                            Comment = null
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
                            Description = @"Unlink order/service from patient care problem or goal",
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
                            Description = @"Change order/service request",
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
                            Description = @"Order/service changed, unsol.",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
