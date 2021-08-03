using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0440
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
                            Value = @"Address",
                            Description = @"AD",
                            Comment = @"Address"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Authorization information",
                            Description = @"AUI",
                            Comment = @"Authorization information"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Channel calibration parameters",
                            Description = @"CCP",
                            Comment = @"Channel calibration parameters"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Channel definition",
                            Description = @"CD",
                            Comment = @"Channel definition"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Channel Identifier",
                            Description = @"WVI",
                            Comment = @"Channel Identifier"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Channel sensitivity",
                            Description = @"CSU",
                            Comment = @"Channel sensitivity"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Charge code and date",
                            Description = @"CCD",
                            Comment = @"Charge code and date"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Coded element",
                            Description = @"CE",
                            Comment = @"Coded element"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Coded element with formatted values",
                            Description = @"CF",
                            Comment = @"Coded element with formatted values"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Coded value for user-defined tables",
                            Description = @"IS",
                            Comment = @"Coded value for user-defined tables"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Coded values for HL7 tables",
                            Description = @"ID",
                            Comment = @"Coded values for HL7 tables"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Coded with exceptions",
                            Description = @"CWE",
                            Comment = @"Coded with exceptions"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Coded with no exceptions",
                            Description = @"CNE",
                            Comment = @"Coded with no exceptions"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Composite",
                            Description = @"CM",
                            Comment = @"Composite"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Composite ID number and name",
                            Description = @"CN",
                            Comment = @"Composite ID number and name"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Composite ID number and name simplified",
                            Description = @"CNS",
                            Comment = @"Composite ID number and name simplified"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Composite ID with check digit",
                            Description = @"CK",
                            Comment = @"Composite ID with check digit"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Composite price",
                            Description = @"CP",
                            Comment = @"Composite price"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Composite quantity with units",
                            Description = @"CQ",
                            Comment = @"Composite quantity with units"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Daily deductible information",
                            Description = @"DDI",
                            Comment = @"Daily deductible information"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Data Type Name",
                            Description = @"Data type",
                            Comment = @"Data Type Name"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Date",
                            Description = @"DT",
                            Comment = @"Date"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Date and institution name",
                            Description = @"DIN",
                            Comment = @"Date and institution name"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Date/time",
                            Description = @"DTM",
                            Comment = @"Date/time"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Date/time range",
                            Description = @"DR",
                            Comment = @"Date/time range"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Day type and number",
                            Description = @"DTN",
                            Comment = @"Day type and number"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Delta",
                            Description = @"DLT",
                            Comment = @"Delta"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Discharge to location and date",
                            Description = @"DLD",
                            Comment = @"Discharge to location and date"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Driver's license number",
                            Description = @"DLN",
                            Comment = @"Driver's license number"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Encapsulated data",
                            Description = @"ED",
                            Comment = @"Encapsulated data"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Entity identifier",
                            Description = @"EI",
                            Comment = @"Entity identifier"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Entity identifier pair",
                            Description = @"EIP",
                            Comment = @"Entity identifier pair"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Error location",
                            Description = @"ERL",
                            Comment = @"Error location"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Error location and description",
                            Description = @"LD",
                            Comment = @"Error location and description"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Extended address",
                            Description = @"XAD",
                            Comment = @"Extended address"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Extended composite ID number and name",
                            Description = @"XCN",
                            Comment = @"Extended composite ID number and name"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Extended composite ID with check digit",
                            Description = @"CX",
                            Comment = @"Extended composite ID with check digit"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Extended composite name and ID number for organizations",
                            Description = @"XON",
                            Comment = @"Extended composite name and ID number for organizations"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Extended person name",
                            Description = @"XPN",
                            Comment = @"Extended person name"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Extended telecommunications number",
                            Description = @"XTN",
                            Comment = @"Extended telecommunications number"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Family name",
                            Description = @"FN",
                            Comment = @"Family name"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Financial class",
                            Description = @"FC",
                            Comment = @"Financial class"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Formatted text",
                            Description = @"FT",
                            Comment = @"Formatted text"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"General timing specification",
                            Description = @"GTS",
                            Comment = @"General timing specification"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Hierarchic designator",
                            Description = @"HD",
                            Comment = @"Hierarchic designator"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Insurance certification definition",
                            Description = @"ICD",
                            Comment = @"Insurance certification definition"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Job code/class",
                            Description = @"JCC",
                            Comment = @"Job code/class"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Location with address variation 1",
                            Description = @"LA1",
                            Comment = @"Location with address variation 1"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Location with address variation 2",
                            Description = @"LA2",
                            Comment = @"Location with address variation 2"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Message type",
                            Description = @"MSG",
                            Comment = @"Message type"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Money",
                            Description = @"MO",
                            Comment = @"Money"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Money and charge code",
                            Description = @"MOC",
                            Comment = @"Money and charge code"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Money or percentage",
                            Description = @"MOP",
                            Comment = @"Money or percentage"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Multiplexed array",
                            Description = @"MA",
                            Comment = @"Multiplexed array"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Name with location and date",
                            Description = @"NDL",
                            Comment = @"Name with location and date"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Numeric",
                            Description = @"NM",
                            Comment = @"Numeric"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Numeric array",
                            Description = @"NA",
                            Comment = @"Numeric array"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Numeric range",
                            Description = @"NR",
                            Comment = @"Numeric range"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Occurrence code and date",
                            Description = @"OCD",
                            Comment = @"Occurrence code and date"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Occurrence span code and date",
                            Description = @"OSP",
                            Comment = @"Occurrence span code and date"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Order sequence definition",
                            Description = @"OSD",
                            Comment = @"Order sequence definition"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Parent result link",
                            Description = @"PRL",
                            Comment = @"Parent result link"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Performing person time stamp",
                            Description = @"PPN",
                            Comment = @"Performing person time stamp"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Person location",
                            Description = @"PL",
                            Comment = @"Person location"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Person name",
                            Description = @"PN",
                            Comment = @"Person name"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Policy type and amount",
                            Description = @"PTA",
                            Comment = @"Policy type and amount"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Practitioner institutional privileges",
                            Description = @"PIP",
                            Comment = @"Practitioner institutional privileges"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Practitioner license or other ID number",
                            Description = @"PLN",
                            Comment = @"Practitioner license or other ID number"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Processing type",
                            Description = @"PT",
                            Comment = @"Processing type"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Query input parameter list",
                            Description = @"QIP",
                            Comment = @"Query input parameter list"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Query selection criteria",
                            Description = @"QSC",
                            Comment = @"Query selection criteria"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Reference pointer",
                            Description = @"RP",
                            Comment = @"Reference pointer"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Reference range",
                            Description = @"RFR",
                            Comment = @"Reference range"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Repeat interval",
                            Description = @"RI",
                            Comment = @"Repeat interval"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Repeat pattern",
                            Description = @"RPT",
                            Comment = @"Repeat pattern"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Room coverage",
                            Description = @"RMC",
                            Comment = @"Room coverage"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Row column definition",
                            Description = @"RCD",
                            Comment = @"Row column definition"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Scheduling class value pair",
                            Description = @"SCV",
                            Comment = @"Scheduling class value pair"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Sequence ID",
                            Description = @"SI",
                            Comment = @"Sequence ID"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Sort order",
                            Description = @"SRT",
                            Comment = @"Sort order"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Specialty description",
                            Description = @"SPD",
                            Comment = @"Specialty description"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Specimen source",
                            Description = @"SPS",
                            Comment = @"Specimen source"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Street Address",
                            Description = @"SAD",
                            Comment = @"Street Address"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"String",
                            Description = @"ST",
                            Comment = @"String"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Structured numeric",
                            Description = @"SN",
                            Comment = @"Structured numeric"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Telephone number",
                            Description = @"TN",
                            Comment = @"Telephone number"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Text data",
                            Description = @"TX",
                            Comment = @"Text data"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Time",
                            Description = @"TM",
                            Comment = @"Time"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Time stamp",
                            Description = @"TS",
                            Comment = @"Time stamp"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Timing/quantity",
                            Description = @"TQ",
                            Comment = @"Timing/quantity"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UB value code and amount",
                            Description = @"UVC",
                            Comment = @"UB value code and amount"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Value range",
                            Description = @"VR",
                            Comment = @"Value range"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Version identifier",
                            Description = @"VID",
                            Comment = @"Version identifier"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Visiting hours",
                            Description = @"VH",
                            Comment = @"Visiting hours"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Waveform source",
                            Description = @"WVS",
                            Comment = @"Waveform source"
                        },
                    };
            } 
        }
    }
}
