using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentPV1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"PV1"; } }

        public string SegmentId { get { return @"PV1"; } }
        
        public string LongName { get { return @"Patient Visit"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.1",
                            Type = @"Field",
                            Position = @"PV1.1",
                            Name = @"Set Id - Patient Visit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Set Id",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.2",
                            Type = @"Field",
                            Position = @"PV1.2",
                            Name = @"Patient Class",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0004",
                            TableName = @"PATIENT CLASS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.3",
                            Type = @"Field",
                            Position = @"PV1.3",
                            Name = @"Assigned Patient Location",
                            Length = 12,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0079",
                            TableName = @"LOCATION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.4",
                            Type = @"Field",
                            Position = @"PV1.4",
                            Name = @"Admission Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0007",
                            TableName = @"ADMISSION TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.5",
                            Type = @"Field",
                            Position = @"PV1.5",
                            Name = @"Pre-admit Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.6",
                            Type = @"Field",
                            Position = @"PV1.6",
                            Name = @"Prior Patient Location",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0079",
                            TableName = @"LOCATION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.7",
                            Type = @"Field",
                            Position = @"PV1.7",
                            Name = @"Attending Doctor",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = @"0010",
                            TableName = @"PHYSICIAN ID",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.8",
                            Type = @"Field",
                            Position = @"PV1.8",
                            Name = @"Referring Doctor",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = @"0010",
                            TableName = @"PHYSICIAN ID",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.9",
                            Type = @"Field",
                            Position = @"PV1.9",
                            Name = @"Consulting Doctor",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = @"0010",
                            TableName = @"PHYSICIAN ID",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.10",
                            Type = @"Field",
                            Position = @"PV1.10",
                            Name = @"Hospital Service",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0069",
                            TableName = @"HOSPITAL SERVICE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.11",
                            Type = @"Field",
                            Position = @"PV1.11",
                            Name = @"Temporary Location",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0079",
                            TableName = @"LOCATION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.12",
                            Type = @"Field",
                            Position = @"PV1.12",
                            Name = @"Pre-admit Test Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0087",
                            TableName = @"PRE-ADMIT TESTING",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.13",
                            Type = @"Field",
                            Position = @"PV1.13",
                            Name = @"Re-admission Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0092",
                            TableName = @"RE-ADMISSION INDICATOR",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.14",
                            Type = @"Field",
                            Position = @"PV1.14",
                            Name = @"Admit Source",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0023",
                            TableName = @"ADMIT SOURCE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.15",
                            Type = @"Field",
                            Position = @"PV1.15",
                            Name = @"Ambulatory Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0009",
                            TableName = @"AMBULATORY STATUS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.16",
                            Type = @"Field",
                            Position = @"PV1.16",
                            Name = @"Vip Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0099",
                            TableName = @"VIP INDICATOR",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.17",
                            Type = @"Field",
                            Position = @"PV1.17",
                            Name = @"Admitting Doctor",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = @"0010",
                            TableName = @"PHYSICIAN ID",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.18",
                            Type = @"Field",
                            Position = @"PV1.18",
                            Name = @"Patient Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0018",
                            TableName = @"PATIENT TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.19",
                            Type = @"Field",
                            Position = @"PV1.19",
                            Name = @"Visit Number",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.20",
                            Type = @"Field",
                            Position = @"PV1.20",
                            Name = @"Financial Class",
                            Length = 11,
                            Usage = @"O",
                            Rpt = @"4",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0064",
                            TableName = @"FINANCIAL CLASS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.21",
                            Type = @"Field",
                            Position = @"PV1.21",
                            Name = @"Charge Price Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0032",
                            TableName = @"CHARGE/PRICE INDICATOR",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.22",
                            Type = @"Field",
                            Position = @"PV1.22",
                            Name = @"Courtesy Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0045",
                            TableName = @"COURTESY CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.23",
                            Type = @"Field",
                            Position = @"PV1.23",
                            Name = @"Credit Rating",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0046",
                            TableName = @"CREDIT RATING",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.24",
                            Type = @"Field",
                            Position = @"PV1.24",
                            Name = @"Contract Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0044",
                            TableName = @"CONTRACT CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.25",
                            Type = @"Field",
                            Position = @"PV1.25",
                            Name = @"Contract Effective Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.26",
                            Type = @"Field",
                            Position = @"PV1.26",
                            Name = @"Contract Amount",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.27",
                            Type = @"Field",
                            Position = @"PV1.27",
                            Name = @"Contract Period",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.28",
                            Type = @"Field",
                            Position = @"PV1.28",
                            Name = @"Interest Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0073",
                            TableName = @"INTEREST RATE CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.29",
                            Type = @"Field",
                            Position = @"PV1.29",
                            Name = @"Transfer To Bad Debt Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0110",
                            TableName = @"TRANSFER TO BAD DEBT CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.30",
                            Type = @"Field",
                            Position = @"PV1.30",
                            Name = @"Transfer To Bad Debt Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.31",
                            Type = @"Field",
                            Position = @"PV1.31",
                            Name = @"Bad Debt Agency Code",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0021",
                            TableName = @"BAD DEBT AGENCY CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.32",
                            Type = @"Field",
                            Position = @"PV1.32",
                            Name = @"Bad Debt Transfer Amount",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.33",
                            Type = @"Field",
                            Position = @"PV1.33",
                            Name = @"Bad Debt Recovery Amount",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.34",
                            Type = @"Field",
                            Position = @"PV1.34",
                            Name = @"Delete Account Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0111",
                            TableName = @"DELETE ACCOUNT CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.35",
                            Type = @"Field",
                            Position = @"PV1.35",
                            Name = @"Delete Account Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.36",
                            Type = @"Field",
                            Position = @"PV1.36",
                            Name = @"Discharge Disposition",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0112",
                            TableName = @"DISCHARGED DISPOSITION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.37",
                            Type = @"Field",
                            Position = @"PV1.37",
                            Name = @"Discharged To Location",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0113",
                            TableName = @"DISCHARGED TO LOCATION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.38",
                            Type = @"Field",
                            Position = @"PV1.38",
                            Name = @"Diet Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0114",
                            TableName = @"DIET TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.39",
                            Type = @"Field",
                            Position = @"PV1.39",
                            Name = @"Servicing Facility",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0115",
                            TableName = @"SERVICING FACILITY",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.40",
                            Type = @"Field",
                            Position = @"PV1.40",
                            Name = @"Bed Status",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0116",
                            TableName = @"BED STATUS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.41",
                            Type = @"Field",
                            Position = @"PV1.41",
                            Name = @"Account Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0117",
                            TableName = @"ACCOUNT STATUS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.42",
                            Type = @"Field",
                            Position = @"PV1.42",
                            Name = @"Pending Location",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0079",
                            TableName = @"LOCATION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.43",
                            Type = @"Field",
                            Position = @"PV1.43",
                            Name = @"Prior Temporary Location",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0079",
                            TableName = @"LOCATION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.44",
                            Type = @"Field",
                            Position = @"PV1.44",
                            Name = @"Admit Date/Time",
                            Length = 19,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.45",
                            Type = @"Field",
                            Position = @"PV1.45",
                            Name = @"Discharge Date/Time",
                            Length = 19,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.46",
                            Type = @"Field",
                            Position = @"PV1.46",
                            Name = @"Current Patient Balance",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.47",
                            Type = @"Field",
                            Position = @"PV1.47",
                            Name = @"Total Charges",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.48",
                            Type = @"Field",
                            Position = @"PV1.48",
                            Name = @"Total Adjustments",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.49",
                            Type = @"Field",
                            Position = @"PV1.49",
                            Name = @"Total Payments",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentPV1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field setIdPatientVisit;

public HL7V21Field SetIdPatientVisit
{
    get
    {
        if (setIdPatientVisit != null)
        {
            return setIdPatientVisit;
        }

        setIdPatientVisit = new HL7V21Field
        {
            field = message[@"PV1"][1],
            Id = @"PV1.1",
            Type = @"Field",
            Position = @"PV1.1",
            Name = @"Set Id - Patient Visit",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return setIdPatientVisit;
    } 
}
internal HL7V21Field patientClass;

public HL7V21Field PatientClass
{
    get
    {
        if (patientClass != null)
        {
            return patientClass;
        }

        patientClass = new HL7V21Field
        {
            field = message[@"PV1"][2],
            Id = @"PV1.2",
            Type = @"Field",
            Position = @"PV1.2",
            Name = @"Patient Class",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0004",
            TableName = @"PATIENT CLASS",
            Description = null,
            Sample = @"",
        };

        

        

        

        return patientClass;
    } 
}
internal HL7V21Field assignedPatientLocation;

public HL7V21Field AssignedPatientLocation
{
    get
    {
        if (assignedPatientLocation != null)
        {
            return assignedPatientLocation;
        }

        assignedPatientLocation = new HL7V21Field
        {
            field = message[@"PV1"][3],
            Id = @"PV1.3",
            Type = @"Field",
            Position = @"PV1.3",
            Name = @"Assigned Patient Location",
            Length = 12,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
        };

        

        

        

        return assignedPatientLocation;
    } 
}
internal HL7V21Field admissionType;

public HL7V21Field AdmissionType
{
    get
    {
        if (admissionType != null)
        {
            return admissionType;
        }

        admissionType = new HL7V21Field
        {
            field = message[@"PV1"][4],
            Id = @"PV1.4",
            Type = @"Field",
            Position = @"PV1.4",
            Name = @"Admission Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0007",
            TableName = @"ADMISSION TYPE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return admissionType;
    } 
}
internal HL7V21Field preadmitNumber;

public HL7V21Field PreadmitNumber
{
    get
    {
        if (preadmitNumber != null)
        {
            return preadmitNumber;
        }

        preadmitNumber = new HL7V21Field
        {
            field = message[@"PV1"][5],
            Id = @"PV1.5",
            Type = @"Field",
            Position = @"PV1.5",
            Name = @"Pre-admit Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return preadmitNumber;
    } 
}
internal HL7V21Field priorPatientLocation;

public HL7V21Field PriorPatientLocation
{
    get
    {
        if (priorPatientLocation != null)
        {
            return priorPatientLocation;
        }

        priorPatientLocation = new HL7V21Field
        {
            field = message[@"PV1"][6],
            Id = @"PV1.6",
            Type = @"Field",
            Position = @"PV1.6",
            Name = @"Prior Patient Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
        };

        

        

        

        return priorPatientLocation;
    } 
}
internal HL7V21Field attendingDoctor;

public HL7V21Field AttendingDoctor
{
    get
    {
        if (attendingDoctor != null)
        {
            return attendingDoctor;
        }

        attendingDoctor = new HL7V21Field
        {
            field = message[@"PV1"][7],
            Id = @"PV1.7",
            Type = @"Field",
            Position = @"PV1.7",
            Name = @"Attending Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
        };

        

        

        

        return attendingDoctor;
    } 
}
internal HL7V21Field referringDoctor;

public HL7V21Field ReferringDoctor
{
    get
    {
        if (referringDoctor != null)
        {
            return referringDoctor;
        }

        referringDoctor = new HL7V21Field
        {
            field = message[@"PV1"][8],
            Id = @"PV1.8",
            Type = @"Field",
            Position = @"PV1.8",
            Name = @"Referring Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
        };

        

        

        

        return referringDoctor;
    } 
}
internal HL7V21Field consultingDoctor;

public HL7V21Field ConsultingDoctor
{
    get
    {
        if (consultingDoctor != null)
        {
            return consultingDoctor;
        }

        consultingDoctor = new HL7V21Field
        {
            field = message[@"PV1"][9],
            Id = @"PV1.9",
            Type = @"Field",
            Position = @"PV1.9",
            Name = @"Consulting Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
        };

        

        

        

        return consultingDoctor;
    } 
}
internal HL7V21Field hospitalService;

public HL7V21Field HospitalService
{
    get
    {
        if (hospitalService != null)
        {
            return hospitalService;
        }

        hospitalService = new HL7V21Field
        {
            field = message[@"PV1"][10],
            Id = @"PV1.10",
            Type = @"Field",
            Position = @"PV1.10",
            Name = @"Hospital Service",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0069",
            TableName = @"HOSPITAL SERVICE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return hospitalService;
    } 
}
internal HL7V21Field temporaryLocation;

public HL7V21Field TemporaryLocation
{
    get
    {
        if (temporaryLocation != null)
        {
            return temporaryLocation;
        }

        temporaryLocation = new HL7V21Field
        {
            field = message[@"PV1"][11],
            Id = @"PV1.11",
            Type = @"Field",
            Position = @"PV1.11",
            Name = @"Temporary Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
        };

        

        

        

        return temporaryLocation;
    } 
}
internal HL7V21Field preadmitTestIndicator;

public HL7V21Field PreadmitTestIndicator
{
    get
    {
        if (preadmitTestIndicator != null)
        {
            return preadmitTestIndicator;
        }

        preadmitTestIndicator = new HL7V21Field
        {
            field = message[@"PV1"][12],
            Id = @"PV1.12",
            Type = @"Field",
            Position = @"PV1.12",
            Name = @"Pre-admit Test Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0087",
            TableName = @"PRE-ADMIT TESTING",
            Description = null,
            Sample = @"",
        };

        

        

        

        return preadmitTestIndicator;
    } 
}
internal HL7V21Field readmissionIndicator;

public HL7V21Field ReadmissionIndicator
{
    get
    {
        if (readmissionIndicator != null)
        {
            return readmissionIndicator;
        }

        readmissionIndicator = new HL7V21Field
        {
            field = message[@"PV1"][13],
            Id = @"PV1.13",
            Type = @"Field",
            Position = @"PV1.13",
            Name = @"Re-admission Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0092",
            TableName = @"RE-ADMISSION INDICATOR",
            Description = null,
            Sample = @"",
        };

        

        

        

        return readmissionIndicator;
    } 
}
internal HL7V21Field admitSource;

public HL7V21Field AdmitSource
{
    get
    {
        if (admitSource != null)
        {
            return admitSource;
        }

        admitSource = new HL7V21Field
        {
            field = message[@"PV1"][14],
            Id = @"PV1.14",
            Type = @"Field",
            Position = @"PV1.14",
            Name = @"Admit Source",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0023",
            TableName = @"ADMIT SOURCE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return admitSource;
    } 
}
internal HL7V21Field ambulatoryStatus;

public HL7V21Field AmbulatoryStatus
{
    get
    {
        if (ambulatoryStatus != null)
        {
            return ambulatoryStatus;
        }

        ambulatoryStatus = new HL7V21Field
        {
            field = message[@"PV1"][15],
            Id = @"PV1.15",
            Type = @"Field",
            Position = @"PV1.15",
            Name = @"Ambulatory Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0009",
            TableName = @"AMBULATORY STATUS",
            Description = null,
            Sample = @"",
        };

        

        

        

        return ambulatoryStatus;
    } 
}
internal HL7V21Field vipIndicator;

public HL7V21Field VipIndicator
{
    get
    {
        if (vipIndicator != null)
        {
            return vipIndicator;
        }

        vipIndicator = new HL7V21Field
        {
            field = message[@"PV1"][16],
            Id = @"PV1.16",
            Type = @"Field",
            Position = @"PV1.16",
            Name = @"Vip Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0099",
            TableName = @"VIP INDICATOR",
            Description = null,
            Sample = @"",
        };

        

        

        

        return vipIndicator;
    } 
}
internal HL7V21Field admittingDoctor;

public HL7V21Field AdmittingDoctor
{
    get
    {
        if (admittingDoctor != null)
        {
            return admittingDoctor;
        }

        admittingDoctor = new HL7V21Field
        {
            field = message[@"PV1"][17],
            Id = @"PV1.17",
            Type = @"Field",
            Position = @"PV1.17",
            Name = @"Admitting Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
        };

        

        

        

        return admittingDoctor;
    } 
}
internal HL7V21Field patientType;

public HL7V21Field PatientType
{
    get
    {
        if (patientType != null)
        {
            return patientType;
        }

        patientType = new HL7V21Field
        {
            field = message[@"PV1"][18],
            Id = @"PV1.18",
            Type = @"Field",
            Position = @"PV1.18",
            Name = @"Patient Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0018",
            TableName = @"PATIENT TYPE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return patientType;
    } 
}
internal HL7V21Field visitNumber;

public HL7V21Field VisitNumber
{
    get
    {
        if (visitNumber != null)
        {
            return visitNumber;
        }

        visitNumber = new HL7V21Field
        {
            field = message[@"PV1"][19],
            Id = @"PV1.19",
            Type = @"Field",
            Position = @"PV1.19",
            Name = @"Visit Number",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return visitNumber;
    } 
}
internal HL7V21Field financialClass;

public HL7V21Field FinancialClass
{
    get
    {
        if (financialClass != null)
        {
            return financialClass;
        }

        financialClass = new HL7V21Field
        {
            field = message[@"PV1"][20],
            Id = @"PV1.20",
            Type = @"Field",
            Position = @"PV1.20",
            Name = @"Financial Class",
            Length = 11,
            Usage = @"O",
            Rpt = @"4",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0064",
            TableName = @"FINANCIAL CLASS",
            Description = null,
            Sample = @"",
        };

        

        

        

        return financialClass;
    } 
}
internal HL7V21Field chargePriceIndicator;

public HL7V21Field ChargePriceIndicator
{
    get
    {
        if (chargePriceIndicator != null)
        {
            return chargePriceIndicator;
        }

        chargePriceIndicator = new HL7V21Field
        {
            field = message[@"PV1"][21],
            Id = @"PV1.21",
            Type = @"Field",
            Position = @"PV1.21",
            Name = @"Charge Price Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0032",
            TableName = @"CHARGE/PRICE INDICATOR",
            Description = null,
            Sample = @"",
        };

        

        

        

        return chargePriceIndicator;
    } 
}
internal HL7V21Field courtesyCode;

public HL7V21Field CourtesyCode
{
    get
    {
        if (courtesyCode != null)
        {
            return courtesyCode;
        }

        courtesyCode = new HL7V21Field
        {
            field = message[@"PV1"][22],
            Id = @"PV1.22",
            Type = @"Field",
            Position = @"PV1.22",
            Name = @"Courtesy Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0045",
            TableName = @"COURTESY CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return courtesyCode;
    } 
}
internal HL7V21Field creditRating;

public HL7V21Field CreditRating
{
    get
    {
        if (creditRating != null)
        {
            return creditRating;
        }

        creditRating = new HL7V21Field
        {
            field = message[@"PV1"][23],
            Id = @"PV1.23",
            Type = @"Field",
            Position = @"PV1.23",
            Name = @"Credit Rating",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0046",
            TableName = @"CREDIT RATING",
            Description = null,
            Sample = @"",
        };

        

        

        

        return creditRating;
    } 
}
internal HL7V21Field contractCode;

public HL7V21Field ContractCode
{
    get
    {
        if (contractCode != null)
        {
            return contractCode;
        }

        contractCode = new HL7V21Field
        {
            field = message[@"PV1"][24],
            Id = @"PV1.24",
            Type = @"Field",
            Position = @"PV1.24",
            Name = @"Contract Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0044",
            TableName = @"CONTRACT CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return contractCode;
    } 
}
internal HL7V21Field contractEffectiveDate;

public HL7V21Field ContractEffectiveDate
{
    get
    {
        if (contractEffectiveDate != null)
        {
            return contractEffectiveDate;
        }

        contractEffectiveDate = new HL7V21Field
        {
            field = message[@"PV1"][25],
            Id = @"PV1.25",
            Type = @"Field",
            Position = @"PV1.25",
            Name = @"Contract Effective Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return contractEffectiveDate;
    } 
}
internal HL7V21Field contractAmount;

public HL7V21Field ContractAmount
{
    get
    {
        if (contractAmount != null)
        {
            return contractAmount;
        }

        contractAmount = new HL7V21Field
        {
            field = message[@"PV1"][26],
            Id = @"PV1.26",
            Type = @"Field",
            Position = @"PV1.26",
            Name = @"Contract Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return contractAmount;
    } 
}
internal HL7V21Field contractPeriod;

public HL7V21Field ContractPeriod
{
    get
    {
        if (contractPeriod != null)
        {
            return contractPeriod;
        }

        contractPeriod = new HL7V21Field
        {
            field = message[@"PV1"][27],
            Id = @"PV1.27",
            Type = @"Field",
            Position = @"PV1.27",
            Name = @"Contract Period",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return contractPeriod;
    } 
}
internal HL7V21Field interestCode;

public HL7V21Field InterestCode
{
    get
    {
        if (interestCode != null)
        {
            return interestCode;
        }

        interestCode = new HL7V21Field
        {
            field = message[@"PV1"][28],
            Id = @"PV1.28",
            Type = @"Field",
            Position = @"PV1.28",
            Name = @"Interest Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0073",
            TableName = @"INTEREST RATE CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return interestCode;
    } 
}
internal HL7V21Field transferToBadDebtCode;

public HL7V21Field TransferToBadDebtCode
{
    get
    {
        if (transferToBadDebtCode != null)
        {
            return transferToBadDebtCode;
        }

        transferToBadDebtCode = new HL7V21Field
        {
            field = message[@"PV1"][29],
            Id = @"PV1.29",
            Type = @"Field",
            Position = @"PV1.29",
            Name = @"Transfer To Bad Debt Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0110",
            TableName = @"TRANSFER TO BAD DEBT CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return transferToBadDebtCode;
    } 
}
internal HL7V21Field transferToBadDebtDate;

public HL7V21Field TransferToBadDebtDate
{
    get
    {
        if (transferToBadDebtDate != null)
        {
            return transferToBadDebtDate;
        }

        transferToBadDebtDate = new HL7V21Field
        {
            field = message[@"PV1"][30],
            Id = @"PV1.30",
            Type = @"Field",
            Position = @"PV1.30",
            Name = @"Transfer To Bad Debt Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return transferToBadDebtDate;
    } 
}
internal HL7V21Field badDebtAgencyCode;

public HL7V21Field BadDebtAgencyCode
{
    get
    {
        if (badDebtAgencyCode != null)
        {
            return badDebtAgencyCode;
        }

        badDebtAgencyCode = new HL7V21Field
        {
            field = message[@"PV1"][31],
            Id = @"PV1.31",
            Type = @"Field",
            Position = @"PV1.31",
            Name = @"Bad Debt Agency Code",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0021",
            TableName = @"BAD DEBT AGENCY CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return badDebtAgencyCode;
    } 
}
internal HL7V21Field badDebtTransferAmount;

public HL7V21Field BadDebtTransferAmount
{
    get
    {
        if (badDebtTransferAmount != null)
        {
            return badDebtTransferAmount;
        }

        badDebtTransferAmount = new HL7V21Field
        {
            field = message[@"PV1"][32],
            Id = @"PV1.32",
            Type = @"Field",
            Position = @"PV1.32",
            Name = @"Bad Debt Transfer Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return badDebtTransferAmount;
    } 
}
internal HL7V21Field badDebtRecoveryAmount;

public HL7V21Field BadDebtRecoveryAmount
{
    get
    {
        if (badDebtRecoveryAmount != null)
        {
            return badDebtRecoveryAmount;
        }

        badDebtRecoveryAmount = new HL7V21Field
        {
            field = message[@"PV1"][33],
            Id = @"PV1.33",
            Type = @"Field",
            Position = @"PV1.33",
            Name = @"Bad Debt Recovery Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return badDebtRecoveryAmount;
    } 
}
internal HL7V21Field deleteAccountIndicator;

public HL7V21Field DeleteAccountIndicator
{
    get
    {
        if (deleteAccountIndicator != null)
        {
            return deleteAccountIndicator;
        }

        deleteAccountIndicator = new HL7V21Field
        {
            field = message[@"PV1"][34],
            Id = @"PV1.34",
            Type = @"Field",
            Position = @"PV1.34",
            Name = @"Delete Account Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0111",
            TableName = @"DELETE ACCOUNT CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return deleteAccountIndicator;
    } 
}
internal HL7V21Field deleteAccountDate;

public HL7V21Field DeleteAccountDate
{
    get
    {
        if (deleteAccountDate != null)
        {
            return deleteAccountDate;
        }

        deleteAccountDate = new HL7V21Field
        {
            field = message[@"PV1"][35],
            Id = @"PV1.35",
            Type = @"Field",
            Position = @"PV1.35",
            Name = @"Delete Account Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return deleteAccountDate;
    } 
}
internal HL7V21Field dischargeDisposition;

public HL7V21Field DischargeDisposition
{
    get
    {
        if (dischargeDisposition != null)
        {
            return dischargeDisposition;
        }

        dischargeDisposition = new HL7V21Field
        {
            field = message[@"PV1"][36],
            Id = @"PV1.36",
            Type = @"Field",
            Position = @"PV1.36",
            Name = @"Discharge Disposition",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0112",
            TableName = @"DISCHARGED DISPOSITION",
            Description = null,
            Sample = @"",
        };

        

        

        

        return dischargeDisposition;
    } 
}
internal HL7V21Field dischargedToLocation;

public HL7V21Field DischargedToLocation
{
    get
    {
        if (dischargedToLocation != null)
        {
            return dischargedToLocation;
        }

        dischargedToLocation = new HL7V21Field
        {
            field = message[@"PV1"][37],
            Id = @"PV1.37",
            Type = @"Field",
            Position = @"PV1.37",
            Name = @"Discharged To Location",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0113",
            TableName = @"DISCHARGED TO LOCATION",
            Description = null,
            Sample = @"",
        };

        

        

        

        return dischargedToLocation;
    } 
}
internal HL7V21Field dietType;

public HL7V21Field DietType
{
    get
    {
        if (dietType != null)
        {
            return dietType;
        }

        dietType = new HL7V21Field
        {
            field = message[@"PV1"][38],
            Id = @"PV1.38",
            Type = @"Field",
            Position = @"PV1.38",
            Name = @"Diet Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0114",
            TableName = @"DIET TYPE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return dietType;
    } 
}
internal HL7V21Field servicingFacility;

public HL7V21Field ServicingFacility
{
    get
    {
        if (servicingFacility != null)
        {
            return servicingFacility;
        }

        servicingFacility = new HL7V21Field
        {
            field = message[@"PV1"][39],
            Id = @"PV1.39",
            Type = @"Field",
            Position = @"PV1.39",
            Name = @"Servicing Facility",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0115",
            TableName = @"SERVICING FACILITY",
            Description = null,
            Sample = @"",
        };

        

        

        

        return servicingFacility;
    } 
}
internal HL7V21Field bedStatus;

public HL7V21Field BedStatus
{
    get
    {
        if (bedStatus != null)
        {
            return bedStatus;
        }

        bedStatus = new HL7V21Field
        {
            field = message[@"PV1"][40],
            Id = @"PV1.40",
            Type = @"Field",
            Position = @"PV1.40",
            Name = @"Bed Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0116",
            TableName = @"BED STATUS",
            Description = null,
            Sample = @"",
        };

        

        

        

        return bedStatus;
    } 
}
internal HL7V21Field accountStatus;

public HL7V21Field AccountStatus
{
    get
    {
        if (accountStatus != null)
        {
            return accountStatus;
        }

        accountStatus = new HL7V21Field
        {
            field = message[@"PV1"][41],
            Id = @"PV1.41",
            Type = @"Field",
            Position = @"PV1.41",
            Name = @"Account Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0117",
            TableName = @"ACCOUNT STATUS",
            Description = null,
            Sample = @"",
        };

        

        

        

        return accountStatus;
    } 
}
internal HL7V21Field pendingLocation;

public HL7V21Field PendingLocation
{
    get
    {
        if (pendingLocation != null)
        {
            return pendingLocation;
        }

        pendingLocation = new HL7V21Field
        {
            field = message[@"PV1"][42],
            Id = @"PV1.42",
            Type = @"Field",
            Position = @"PV1.42",
            Name = @"Pending Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
        };

        

        

        

        return pendingLocation;
    } 
}
internal HL7V21Field priorTemporaryLocation;

public HL7V21Field PriorTemporaryLocation
{
    get
    {
        if (priorTemporaryLocation != null)
        {
            return priorTemporaryLocation;
        }

        priorTemporaryLocation = new HL7V21Field
        {
            field = message[@"PV1"][43],
            Id = @"PV1.43",
            Type = @"Field",
            Position = @"PV1.43",
            Name = @"Prior Temporary Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
        };

        

        

        

        return priorTemporaryLocation;
    } 
}
internal HL7V21Field admitDateTime;

public HL7V21Field AdmitDateTime
{
    get
    {
        if (admitDateTime != null)
        {
            return admitDateTime;
        }

        admitDateTime = new HL7V21Field
        {
            field = message[@"PV1"][44],
            Id = @"PV1.44",
            Type = @"Field",
            Position = @"PV1.44",
            Name = @"Admit Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return admitDateTime;
    } 
}
internal HL7V21Field dischargeDateTime;

public HL7V21Field DischargeDateTime
{
    get
    {
        if (dischargeDateTime != null)
        {
            return dischargeDateTime;
        }

        dischargeDateTime = new HL7V21Field
        {
            field = message[@"PV1"][45],
            Id = @"PV1.45",
            Type = @"Field",
            Position = @"PV1.45",
            Name = @"Discharge Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return dischargeDateTime;
    } 
}
internal HL7V21Field currentPatientBalance;

public HL7V21Field CurrentPatientBalance
{
    get
    {
        if (currentPatientBalance != null)
        {
            return currentPatientBalance;
        }

        currentPatientBalance = new HL7V21Field
        {
            field = message[@"PV1"][46],
            Id = @"PV1.46",
            Type = @"Field",
            Position = @"PV1.46",
            Name = @"Current Patient Balance",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return currentPatientBalance;
    } 
}
internal HL7V21Field totalCharges;

public HL7V21Field TotalCharges
{
    get
    {
        if (totalCharges != null)
        {
            return totalCharges;
        }

        totalCharges = new HL7V21Field
        {
            field = message[@"PV1"][47],
            Id = @"PV1.47",
            Type = @"Field",
            Position = @"PV1.47",
            Name = @"Total Charges",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return totalCharges;
    } 
}
internal HL7V21Field totalAdjustments;

public HL7V21Field TotalAdjustments
{
    get
    {
        if (totalAdjustments != null)
        {
            return totalAdjustments;
        }

        totalAdjustments = new HL7V21Field
        {
            field = message[@"PV1"][48],
            Id = @"PV1.48",
            Type = @"Field",
            Position = @"PV1.48",
            Name = @"Total Adjustments",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return totalAdjustments;
    } 
}
internal HL7V21Field totalPayments;

public HL7V21Field TotalPayments
{
    get
    {
        if (totalPayments != null)
        {
            return totalPayments;
        }

        totalPayments = new HL7V21Field
        {
            field = message[@"PV1"][49],
            Id = @"PV1.49",
            Type = @"Field",
            Position = @"PV1.49",
            Name = @"Total Payments",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return totalPayments;
    } 
}

    }
}
