using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0119
    {
        public string Id { get { return @"0119"; } }

        public string TableId { get { return @"0119"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"ORDER CONTROL"; } }

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
                            Value = @"CA",
                            Description = @"Cancel order request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CH",
                            Description = @"Child order",
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
                            Description = @"Discontinue order request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DE",
                            Description = @"Data Errors",
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
                            Value = @"NA",
                            Description = @"Number assigned",
                            Comment = null
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
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"Observations to follow",
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
                            Description = @"Order replace request",
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
                            Description = @"Order changed, unsolicited",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
