using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2251Table0125
    {
        public string Id { get { return @"0125"; } }

        public string TableId { get { return @"0125"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Value type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
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
                            Value = @"AD",
                            Description = @"Address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CE",
                            Description = @"Coded Entry",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CF",
                            Description = @"Coded Element With Formatted Values",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CK",
                            Description = @"Composite ID With Check Digit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CN",
                            Description = @"Composite ID And Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CP",
                            Description = @"Composite Price",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CX",
                            Description = @"Extended Composite ID With Check Digit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DT",
                            Description = @"Date",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ED",
                            Description = @"Encapsulated Data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FT",
                            Description = @"Formatted Text (Display)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MO",
                            Description = @"Money",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NM",
                            Description = @"Numeric",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PN",
                            Description = @"Person Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Reference Pointer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SN",
                            Description = @"Structured Numeric",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ST",
                            Description = @"String Data.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TM",
                            Description = @"Time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TN",
                            Description = @"Telephone Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TS",
                            Description = @"Time Stamp (Date & Time)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TX",
                            Description = @"Text Data (Display)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XAD",
                            Description = @"Extended Address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XCN",
                            Description = @"Extended Composite Name And Number For Persons",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XON",
                            Description = @"Extended Composite Name And Number For Organizations",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XPN",
                            Description = @"Extended Person Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XTN",
                            Description = @"Extended Telecommunications Number",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
