using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0119
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
                            Description = @"ORR^O02",
                            Comment = @"Order/service refill request approval"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CA",
                            Description = @"ORM^O01",
                            Comment = @"Cancel order/service request"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CH",
                            Description = @"ORM^O01",
                            Comment = @"Child order/service"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CN",
                            Description = @"ORU^R01",
                            Comment = @"Combined result"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CR",
                            Description = @"ORR^O02",
                            Comment = @"Canceled as requested"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DC",
                            Description = @"ORM^O01",
                            Comment = @"Discontinue order/service request"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DE",
                            Description = @"ORM^O01",
                            Comment = @"Data errors"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DE",
                            Description = @"ORS^O06",
                            Comment = @"Data errors"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DF",
                            Description = @"ORR^O02",
                            Comment = @"Order/service refill request denied"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DR",
                            Description = @"ORR^O02",
                            Comment = @"Discontinued as requested"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FU",
                            Description = @"ORM^O01",
                            Comment = @"""Order/service refilled, unsolicited"""
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HD",
                            Description = @"ORM^O01",
                            Comment = @"Hold order request"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HR",
                            Description = @"ORR^O02",
                            Comment = @"On hold as requested"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HR",
                            Description = @"ORD^O04",
                            Comment = @"On hold as requested"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LI",
                            Description = @"ORM^O01",
                            Comment = @"Link order/service to patient care problem or goal"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LI",
                            Description = @"OMP^O09",
                            Comment = @"Link order/service to patient care problem or goal"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NA",
                            Description = @"ORR^O02",
                            Comment = @"Number assigned"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NW",
                            Description = @"ORM^O01",
                            Comment = @"New order/service"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OC",
                            Description = @"ORM^O01",
                            Comment = @"Order/service canceled"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OD",
                            Description = @"ORM^O01",
                            Comment = @"Order/service discontinued"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OE",
                            Description = @"ORM^O01",
                            Comment = @"Order/service released"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OF",
                            Description = @"ORR^O02",
                            Comment = @"Order/service refilled as requested"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OH",
                            Description = @"ORM^O01",
                            Comment = @"Order/service held"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OK",
                            Description = @"ORR^O02",
                            Comment = @"Order/service accepted & OK"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OR",
                            Description = @"ORR^O02",
                            Comment = @"Released as requested"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"ORM^O01",
                            Comment = @"Parent order/service"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PR",
                            Description = @"ORM^O01",
                            Comment = @"Previous Results with new order/service"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"ORM^O01",
                            Comment = @"Observations/Performed Service to follow"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RF",
                            Description = @"ORM^O01",
                            Comment = @"Refill order/service request"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RL",
                            Description = @"ORM^O01",
                            Comment = @"Release previous hold"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RO",
                            Description = @"ORM^O01",
                            Comment = @"Replacement order"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"ORM^O01",
                            Comment = @"Order/service replace request"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQ",
                            Description = @"ORR^O02",
                            Comment = @"Replaced as requested"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RR",
                            Description = @"ORR^O02",
                            Comment = @"Request received"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RU",
                            Description = @"ORM^O01",
                            Comment = @"Replaced unsolicited"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SC",
                            Description = @"ORM^O01",
                            Comment = @"Status changed"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SN",
                            Description = @"ORM^O01",
                            Comment = @"Send order/service number"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SR",
                            Description = @"ORR^O02",
                            Comment = @"Response to send order/service status request"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SS",
                            Description = @"ORM^O01",
                            Comment = @"Send order/service status request"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UA",
                            Description = @"ORR^O02",
                            Comment = @"Unable to accept order/service"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UA",
                            Description = @"RRG^O16",
                            Comment = @"Unable to accept order/service"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UC",
                            Description = @"ORR^O02",
                            Comment = @"Unable to cancel"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UC",
                            Description = @"ORD^O04",
                            Comment = @"Unable to cancel"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UD",
                            Description = @"ORR^O02",
                            Comment = @"Unable to discontinue"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UD",
                            Description = @"ORD^O04",
                            Comment = @"Unable to discontinue"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UF",
                            Description = @"ORR^O02",
                            Comment = @"Unable to refill"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UH",
                            Description = @"ORR^O02",
                            Comment = @"Unable to put on hold"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UM",
                            Description = @"ORR^O02",
                            Comment = @"Unable to replace"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UM",
                            Description = @"ORG^O20",
                            Comment = @"Unable to replace"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UN",
                            Description = @"ORM^O01",
                            Comment = @"Unlink order/service from patient care problem or goal"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UR",
                            Description = @"ORR^O02",
                            Comment = @"Unable to release"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UR",
                            Description = @"ORD^O04",
                            Comment = @"Unable to release"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UX",
                            Description = @"ORR^O02",
                            Comment = @"Unable to change"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XO",
                            Description = @"ORM^O01",
                            Comment = @"Change order/service request"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XO",
                            Description = @"OMP^O09",
                            Comment = @"Change order/service request"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XR",
                            Description = @"ORR^O02",
                            Comment = @"Changed as requested"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XX",
                            Description = @"ORM^O01",
                            Comment = @"""Order/service changed, unsol."""
                        },
                    };
            } 
        }
    }
}
