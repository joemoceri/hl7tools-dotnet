using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0440
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
                            Value = @"AD",
                            Description = @"Address",
                            Comment = @"415"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AUI",
                            Description = @"Authorization information",
                            Comment = @"239"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CCD",
                            Description = @"Charge code and date",
                            Comment = @"28"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CCP",
                            Description = @"Channel calibration parameters",
                            Comment = @"20"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CD",
                            Description = @"Channel definition",
                            Comment = @"581"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CE",
                            Description = @"Coded element",
                            Comment = @"483"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CF",
                            Description = @"Coded element with formatted values",
                            Comment = @"65536"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CK",
                            Description = @"Composite ID with check digit",
                            Comment = null
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
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNE",
                            Description = @"Coded with no exceptions",
                            Comment = @"705"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNS",
                            Description = @"Composite ID number and name simplified",
                            Comment = @"406"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CP",
                            Description = @"Composite price",
                            Comment = @"543"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CQ",
                            Description = @"Composite quantity with units",
                            Comment = @"500"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CSU",
                            Description = @"Channel sensitivity",
                            Comment = @"490"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CWE",
                            Description = @"Coded with exceptions",
                            Comment = @"705"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CX",
                            Description = @"Extended composite ID with check digit",
                            Comment = @"1913"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DDI",
                            Description = @"Daily deductible information",
                            Comment = @"25"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DIN",
                            Description = @"Date and institution name",
                            Comment = @"510"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DLD",
                            Description = @"Discharge to location and date",
                            Comment = @"47"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DLN",
                            Description = @"Driver’s license number",
                            Comment = @"66"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DLT",
                            Description = @"Delta",
                            Comment = @"45"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DR",
                            Description = @"Date/time range",
                            Comment = @"53"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DT",
                            Description = @"Date",
                            Comment = @"8"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DTM",
                            Description = @"Date/time",
                            Comment = @"24"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DTN",
                            Description = @"Day type and number",
                            Comment = @"6"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ED",
                            Description = @"Encapsulated data",
                            Comment = @"65536"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EI",
                            Description = @"Entity identifier",
                            Comment = @"427"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EIP",
                            Description = @"Entity identifier pair",
                            Comment = @"855"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ERL",
                            Description = @"Error location",
                            Comment = @"18"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FC",
                            Description = @"Financial class",
                            Comment = @"47"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FN",
                            Description = @"Family name",
                            Comment = @"194"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FT",
                            Description = @"Formatted text",
                            Comment = @"65536"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GTS",
                            Description = @"General timing specification",
                            Comment = @"199"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HD",
                            Description = @"Hierarchic designator",
                            Comment = @"227"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICD",
                            Description = @"Insurance certification definition",
                            Comment = @"40"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ID",
                            Description = @"Coded values for HL7 tables",
                            Comment = @"Variable"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IS",
                            Description = @"Coded value for user-defined tables",
                            Comment = @"20"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JCC",
                            Description = @"Job code/class",
                            Comment = @"292"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LA1",
                            Description = @"Location with address variation 1",
                            Comment = @"415"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LA2",
                            Description = @"Location with address variation 2",
                            Comment = @"790"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LD",
                            Description = @"Error location and description",
                            Comment = @"493"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MA",
                            Description = @"Multiplexed array",
                            Comment = @"65536"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MO",
                            Description = @"Money",
                            Comment = @"20"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MOC",
                            Description = @"Money and charge code",
                            Comment = @"504"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MOP",
                            Description = @"Money or percentage",
                            Comment = @"23"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MSG",
                            Description = @"Message type",
                            Comment = @"15"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NA",
                            Description = @"Numeric array",
                            Comment = @"65536"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NDL",
                            Description = @"Name with location and date",
                            Comment = @"835"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NM",
                            Description = @"Numeric",
                            Comment = @"16"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NR",
                            Description = @"Numeric range",
                            Comment = @"33"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OCD",
                            Description = @"Occurrence code and date",
                            Comment = @"714"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OSD",
                            Description = @"Order sequence definition",
                            Comment = @"110"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OSP",
                            Description = @"Occurrence span code and date",
                            Comment = @"723"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PIP",
                            Description = @"Practitioner institutional privileges",
                            Comment = @"1413"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PL",
                            Description = @"Person location",
                            Comment = @"1230"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLN",
                            Description = @"Practitioner license or other ID number",
                            Comment = @"101"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PN",
                            Description = @"Person name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPN",
                            Description = @"Performing person time stamp",
                            Comment = @"2993"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRL",
                            Description = @"Parent result link",
                            Comment = @"755"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"Processing type",
                            Comment = @"3"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PTA",
                            Description = @"Policy type and amount",
                            Comment = @"56"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QIP",
                            Description = @"Query input parameter list",
                            Comment = @"212"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QSC",
                            Description = @"Query selection criteria",
                            Comment = @"219"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RCD",
                            Description = @"Row column definition",
                            Comment = @"19"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RFR",
                            Description = @"Reference range",
                            Comment = @"352"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RI",
                            Description = @"Repeat interval",
                            Comment = @"206"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RMC",
                            Description = @"Room coverage",
                            Comment = @"82"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Reference pointer",
                            Comment = @"273"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RPT",
                            Description = @"Repeat pattern",
                            Comment = @"984"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SAD",
                            Description = @"Street Address",
                            Comment = @"184"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCV",
                            Description = @"Scheduling class value pair",
                            Comment = @"41"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SI",
                            Description = @"Sequence ID",
                            Comment = @"4"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SN",
                            Description = @"Structured numeric",
                            Comment = @"36"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPD",
                            Description = @"Specialty description",
                            Comment = @"112"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPS",
                            Description = @"Specimen source",
                            Comment = @"4436"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SRT",
                            Description = @"Sort order",
                            Comment = @"15"
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
                            Comment = @"16"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TN",
                            Description = @"Telephone number",
                            Comment = @"199"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TQ",
                            Description = @"Timing/quantity",
                            Comment = @"1209"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TS",
                            Description = @"Time stamp",
                            Comment = @"26"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TX",
                            Description = @"Text data",
                            Comment = @"65536"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UVC",
                            Description = @"UB value code and amount",
                            Comment = @"41"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VH",
                            Description = @"Visiting hours",
                            Comment = @"41"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VID",
                            Description = @"Version identifier",
                            Comment = @"973"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VR",
                            Description = @"Value range",
                            Comment = @"13"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WVI",
                            Description = @"Channel Identifier",
                            Comment = @"22"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WVS",
                            Description = @"Waveform source",
                            Comment = @"17"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XAD",
                            Description = @"Extended address",
                            Comment = @"631"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XCN",
                            Description = @"Extended composite ID number and name",
                            Comment = @"3002"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XON",
                            Description = @"Extended composite name and ID number for organizations",
                            Comment = @"567"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XPN",
                            Description = @"Extended person name",
                            Comment = @"1103"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XTN",
                            Description = @"Extended telecommunications number",
                            Comment = @"850"
                        },
                    };
            } 
        }
    }
}
