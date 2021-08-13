using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0440
    {
        public string Id { get { return @"0440"; } }

        public string TableId { get { return @"0440"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Data types"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

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
                            Value = @"CD",
                            Description = @"Channel definition",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CE",
                            Description = @"Coded element",
                            Comment = @"250"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CF",
                            Description = @"Coded element with formatted values",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CK",
                            Description = @"Composite ID with check digit",
                            Comment = @"250"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CM",
                            Description = @"Composite",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CN",
                            Description = @"Composite ID number and name",
                            Comment = @"250"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNE",
                            Description = @"Coded with no exceptions",
                            Comment = @"250"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CP",
                            Description = @"Composite price",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CQ",
                            Description = @"Composite quantity with units",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CWE",
                            Description = @"Coded with exceptions",
                            Comment = @"250"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CX",
                            Description = @"Extended composite ID with check digit",
                            Comment = @"250"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DLN",
                            Description = @"Driver’s license number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DR",
                            Description = @"Date/time range",
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
                            Description = @"Encapsulated data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EI",
                            Description = @"Entity identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FC",
                            Description = @"Financial class",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FN",
                            Description = @"Family name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FT",
                            Description = @"Formatted text",
                            Comment = @"65536"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HD",
                            Description = @"Hierarchic designator",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ID",
                            Description = @"Coded values for HL7 tables",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IS",
                            Description = @"Coded value for user-defined tables",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JCC",
                            Description = @"Job code/class",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MA",
                            Description = @"Multiplexed array",
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
                            Value = @"NA",
                            Description = @"Numeric array",
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
                            Value = @"PL",
                            Description = @"Person location",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PN",
                            Description = @"Person name",
                            Comment = @"48"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPN",
                            Description = @"Performing person time stamp",
                            Comment = @"250"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"Processing type",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QIP",
                            Description = @"Query input parameter list",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QSC",
                            Description = @"Query selection criteria",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RCD",
                            Description = @"Row column definition",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RI",
                            Description = @"Repeat interval",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Reference pointer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SAD",
                            Description = @"Street Address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCV",
                            Description = @"Scheduling class value pair",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SI",
                            Description = @"Sequence ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SN",
                            Description = @"Structured numeric",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SRT",
                            Description = @"Sort order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ST",
                            Description = @"String",
                            Comment = @"199"
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
                            Description = @"Telephone number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TQ",
                            Description = @"Timing/quantity",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TS",
                            Description = @"Time stamp",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TX",
                            Description = @"Text data",
                            Comment = @"65536"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VH",
                            Description = @"Visiting hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VID",
                            Description = @"Version identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XAD",
                            Description = @"Extended address",
                            Comment = @"250"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XCN",
                            Description = @"Extended composite ID number and name",
                            Comment = @"250"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XON",
                            Description = @"Extended composite name and ID number for organizations",
                            Comment = @"250"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XPN",
                            Description = @"Extended person name",
                            Comment = @"250"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XTN",
                            Description = @"Extended telecommunications number",
                            Comment = @"250"
                        },
                        
                    };
            } 
        }
    }
}
