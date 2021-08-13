using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0119
    {
        public string Id { get { return @"0119"; } }

        public string TableId { get { return @"0119"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"ORDER CONTROL"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Description = @"Number assigned            T",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NW",
                            Description = @"New order                  T",
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
                            Value = @"SN",
                            Description = @"Send filler number            F         I",
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
