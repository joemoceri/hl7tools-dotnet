using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentOBR
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"OBR"; } }

        public string SegmentId { get { return @"OBR"; } }
        
        public string LongName { get { return @"Observation Request"; } }
        
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
                            Id = @"OBR.1",
                            Type = @"Field",
                            Position = @"OBR.1",
                            Name = @"Set Id - Observation Request",
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
                            Id = @"OBR.2",
                            Type = @"Field",
                            Position = @"OBR.2",
                            Name = @"Placer Order #",
                            Length = 75,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.3",
                            Type = @"Field",
                            Position = @"OBR.3",
                            Name = @"Filler Order #",
                            Length = 75,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.4",
                            Type = @"Field",
                            Position = @"OBR.4",
                            Name = @"Universal Service Ident.",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OBR.4.1",
                            Type = @"Component",
                            Position = @"OBR.4.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.4.2",
                            Type = @"Component",
                            Position = @"OBR.4.2",
                            Name = @"Text",
                            Length = 0,
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
                            Id = @"OBR.4.3",
                            Type = @"Component",
                            Position = @"OBR.4.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
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
                            Id = @"OBR.4.4",
                            Type = @"Component",
                            Position = @"OBR.4.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
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
                            Id = @"OBR.4.5",
                            Type = @"Component",
                            Position = @"OBR.4.5",
                            Name = @"Alternate Text",
                            Length = 0,
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
                            Id = @"OBR.4.6",
                            Type = @"Component",
                            Position = @"OBR.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.5",
                            Type = @"Field",
                            Position = @"OBR.5",
                            Name = @"Priority",
                            Length = 2,
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
                            Id = @"OBR.6",
                            Type = @"Field",
                            Position = @"OBR.6",
                            Name = @"Requested Date-time",
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
                            Id = @"OBR.7",
                            Type = @"Field",
                            Position = @"OBR.7",
                            Name = @"Observation Date/Time",
                            Length = 19,
                            Usage = @"R",
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
                            Id = @"OBR.8",
                            Type = @"Field",
                            Position = @"OBR.8",
                            Name = @"Observation End Date/Time",
                            Length = 19,
                            Usage = @"R",
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
                            Id = @"OBR.9",
                            Type = @"Field",
                            Position = @"OBR.9",
                            Name = @"Collection Volume",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = @"0036",
                            TableName = @"UNITS OF MEASURE - ISO528,1977",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.10",
                            Type = @"Field",
                            Position = @"OBR.10",
                            Name = @"Collector Identifier",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.11",
                            Type = @"Field",
                            Position = @"OBR.11",
                            Name = @"Specimen Action Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0065",
                            TableName = @"ACTION CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.12",
                            Type = @"Field",
                            Position = @"OBR.12",
                            Name = @"Danger Code",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = @"0047",
                            TableName = @"DANGER CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.13",
                            Type = @"Field",
                            Position = @"OBR.13",
                            Name = @"Relevant Clinical Info.",
                            Length = 300,
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
                            Id = @"OBR.14",
                            Type = @"Field",
                            Position = @"OBR.14",
                            Name = @"Specimen Received Date/Time",
                            Length = 19,
                            Usage = @"R",
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
                            Id = @"OBR.15",
                            Type = @"Field",
                            Position = @"OBR.15",
                            Name = @"Specimen Source",
                            Length = 300,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = @"0070",
                            TableName = @"SOURCE OF SPECIMEN",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.16",
                            Type = @"Field",
                            Position = @"OBR.16",
                            Name = @"Ordering Provider",
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
                            Id = @"OBR.17",
                            Type = @"Field",
                            Position = @"OBR.17",
                            Name = @"Order Call-back Phone Num",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.18",
                            Type = @"Field",
                            Position = @"OBR.18",
                            Name = @"Placers Field #1",
                            Length = 60,
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
                            Id = @"OBR.19",
                            Type = @"Field",
                            Position = @"OBR.19",
                            Name = @"Placers Field #2",
                            Length = 60,
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
                            Id = @"OBR.20",
                            Type = @"Field",
                            Position = @"OBR.20",
                            Name = @"Fillers Field #1",
                            Length = 60,
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
                            Id = @"OBR.21",
                            Type = @"Field",
                            Position = @"OBR.21",
                            Name = @"Fillers Field #2",
                            Length = 60,
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
                            Id = @"OBR.22",
                            Type = @"Field",
                            Position = @"OBR.22",
                            Name = @"Results Rpt/Status Chng - Date/T",
                            Length = 19,
                            Usage = @"R",
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
                            Id = @"OBR.23",
                            Type = @"Field",
                            Position = @"OBR.23",
                            Name = @"Charge To Practice",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.24",
                            Type = @"Field",
                            Position = @"OBR.24",
                            Name = @"Diagnostic Serv Sect Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0074",
                            TableName = @"DIAGNOSTIC SERVICE SECTION ID",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.25",
                            Type = @"Field",
                            Position = @"OBR.25",
                            Name = @"Result Status",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0123",
                            TableName = @"RESULT STATUS - OBR",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.26",
                            Type = @"Field",
                            Position = @"OBR.26",
                            Name = @"Linked Results",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OBR.26.1",
                            Type = @"Component",
                            Position = @"OBR.26.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.26.2",
                            Type = @"Component",
                            Position = @"OBR.26.2",
                            Name = @"Text",
                            Length = 0,
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
                            Id = @"OBR.26.3",
                            Type = @"Component",
                            Position = @"OBR.26.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
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
                            Id = @"OBR.26.4",
                            Type = @"Component",
                            Position = @"OBR.26.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
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
                            Id = @"OBR.26.5",
                            Type = @"Component",
                            Position = @"OBR.26.5",
                            Name = @"Alternate Text",
                            Length = 0,
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
                            Id = @"OBR.26.6",
                            Type = @"Component",
                            Position = @"OBR.26.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27",
                            Type = @"Field",
                            Position = @"OBR.27",
                            Name = @"Quantity/Timing",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.28",
                            Type = @"Field",
                            Position = @"OBR.28",
                            Name = @"Result Copies To",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"5",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.29",
                            Type = @"Field",
                            Position = @"OBR.29",
                            Name = @"Parent Accession #",
                            Length = 150,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.30",
                            Type = @"Field",
                            Position = @"OBR.30",
                            Name = @"Transportation Mode",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0124",
                            TableName = @"TRANSPORTATION MODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.31",
                            Type = @"Field",
                            Position = @"OBR.31",
                            Name = @"Reason For Study",
                            Length = 300,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OBR.31.1",
                            Type = @"Component",
                            Position = @"OBR.31.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.31.2",
                            Type = @"Component",
                            Position = @"OBR.31.2",
                            Name = @"Text",
                            Length = 0,
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
                            Id = @"OBR.31.3",
                            Type = @"Component",
                            Position = @"OBR.31.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
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
                            Id = @"OBR.31.4",
                            Type = @"Component",
                            Position = @"OBR.31.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
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
                            Id = @"OBR.31.5",
                            Type = @"Component",
                            Position = @"OBR.31.5",
                            Name = @"Alternate Text",
                            Length = 0,
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
                            Id = @"OBR.31.6",
                            Type = @"Component",
                            Position = @"OBR.31.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32",
                            Type = @"Field",
                            Position = @"OBR.32",
                            Name = @"Principal Result Interpreter",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33",
                            Type = @"Field",
                            Position = @"OBR.33",
                            Name = @"Assistant Result Interpreter",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34",
                            Type = @"Field",
                            Position = @"OBR.34",
                            Name = @"Technician",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35",
                            Type = @"Field",
                            Position = @"OBR.35",
                            Name = @"Transcriptionist",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.36",
                            Type = @"Field",
                            Position = @"OBR.36",
                            Name = @"Scheduled - Date/Time",
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
                        };
            }
        }

        public HL7V21SegmentOBR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field setIdObservationRequest;

public HL7V21Field SetIdObservationRequest
{
    get
    {
        if (setIdObservationRequest != null)
        {
            return setIdObservationRequest;
        }

        setIdObservationRequest = new HL7V21Field
        {
            field = message[@"OBR"][1],
            Id = @"OBR.1",
            Type = @"Field",
            Position = @"OBR.1",
            Name = @"Set Id - Observation Request",
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

        

        

        

        return setIdObservationRequest;
    } 
}
internal HL7V21Field placerOrder#;

public HL7V21Field PlacerOrder#
{
    get
    {
        if (placerOrder# != null)
        {
            return placerOrder#;
        }

        placerOrder# = new HL7V21Field
        {
            field = message[@"OBR"][2],
            Id = @"OBR.2",
            Type = @"Field",
            Position = @"OBR.2",
            Name = @"Placer Order #",
            Length = 75,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return placerOrder#;
    } 
}
internal HL7V21Field fillerOrder#;

public HL7V21Field FillerOrder#
{
    get
    {
        if (fillerOrder# != null)
        {
            return fillerOrder#;
        }

        fillerOrder# = new HL7V21Field
        {
            field = message[@"OBR"][3],
            Id = @"OBR.3",
            Type = @"Field",
            Position = @"OBR.3",
            Name = @"Filler Order #",
            Length = 75,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return fillerOrder#;
    } 
}
internal HL7V21Field universalServiceIdent.;

public HL7V21Field UniversalServiceIdent.
{
    get
    {
        if (universalServiceIdent. != null)
        {
            return universalServiceIdent.;
        }

        universalServiceIdent. = new HL7V21Field
        {
            field = message[@"OBR"][4],
            Id = @"OBR.4",
            Type = @"Field",
            Position = @"OBR.4",
            Name = @"Universal Service Ident.",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return universalServiceIdent.;
    } 
}
internal HL7V21Field priority;

public HL7V21Field Priority
{
    get
    {
        if (priority != null)
        {
            return priority;
        }

        priority = new HL7V21Field
        {
            field = message[@"OBR"][5],
            Id = @"OBR.5",
            Type = @"Field",
            Position = @"OBR.5",
            Name = @"Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return priority;
    } 
}
internal HL7V21Field requestedDatetime;

public HL7V21Field RequestedDatetime
{
    get
    {
        if (requestedDatetime != null)
        {
            return requestedDatetime;
        }

        requestedDatetime = new HL7V21Field
        {
            field = message[@"OBR"][6],
            Id = @"OBR.6",
            Type = @"Field",
            Position = @"OBR.6",
            Name = @"Requested Date-time",
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

        

        

        

        return requestedDatetime;
    } 
}
internal HL7V21Field observationDateTime;

public HL7V21Field ObservationDateTime
{
    get
    {
        if (observationDateTime != null)
        {
            return observationDateTime;
        }

        observationDateTime = new HL7V21Field
        {
            field = message[@"OBR"][7],
            Id = @"OBR.7",
            Type = @"Field",
            Position = @"OBR.7",
            Name = @"Observation Date/Time",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return observationDateTime;
    } 
}
internal HL7V21Field observationEndDateTime;

public HL7V21Field ObservationEndDateTime
{
    get
    {
        if (observationEndDateTime != null)
        {
            return observationEndDateTime;
        }

        observationEndDateTime = new HL7V21Field
        {
            field = message[@"OBR"][8],
            Id = @"OBR.8",
            Type = @"Field",
            Position = @"OBR.8",
            Name = @"Observation End Date/Time",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return observationEndDateTime;
    } 
}
internal HL7V21Field collectionVolume;

public HL7V21Field CollectionVolume
{
    get
    {
        if (collectionVolume != null)
        {
            return collectionVolume;
        }

        collectionVolume = new HL7V21Field
        {
            field = message[@"OBR"][9],
            Id = @"OBR.9",
            Type = @"Field",
            Position = @"OBR.9",
            Name = @"Collection Volume",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = @"0036",
            TableName = @"UNITS OF MEASURE - ISO528,1977",
            Description = null,
            Sample = @"",
        };

        

        

        

        return collectionVolume;
    } 
}
internal HL7V21Field collectorIdentifier;

public HL7V21Field CollectorIdentifier
{
    get
    {
        if (collectorIdentifier != null)
        {
            return collectorIdentifier;
        }

        collectorIdentifier = new HL7V21Field
        {
            field = message[@"OBR"][10],
            Id = @"OBR.10",
            Type = @"Field",
            Position = @"OBR.10",
            Name = @"Collector Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return collectorIdentifier;
    } 
}
internal HL7V21Field specimenActionCode;

public HL7V21Field SpecimenActionCode
{
    get
    {
        if (specimenActionCode != null)
        {
            return specimenActionCode;
        }

        specimenActionCode = new HL7V21Field
        {
            field = message[@"OBR"][11],
            Id = @"OBR.11",
            Type = @"Field",
            Position = @"OBR.11",
            Name = @"Specimen Action Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0065",
            TableName = @"ACTION CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return specimenActionCode;
    } 
}
internal HL7V21Field dangerCode;

public HL7V21Field DangerCode
{
    get
    {
        if (dangerCode != null)
        {
            return dangerCode;
        }

        dangerCode = new HL7V21Field
        {
            field = message[@"OBR"][12],
            Id = @"OBR.12",
            Type = @"Field",
            Position = @"OBR.12",
            Name = @"Danger Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = @"0047",
            TableName = @"DANGER CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return dangerCode;
    } 
}
internal HL7V21Field relevantClinicalInfo.;

public HL7V21Field RelevantClinicalInfo.
{
    get
    {
        if (relevantClinicalInfo. != null)
        {
            return relevantClinicalInfo.;
        }

        relevantClinicalInfo. = new HL7V21Field
        {
            field = message[@"OBR"][13],
            Id = @"OBR.13",
            Type = @"Field",
            Position = @"OBR.13",
            Name = @"Relevant Clinical Info.",
            Length = 300,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return relevantClinicalInfo.;
    } 
}
internal HL7V21Field specimenReceivedDateTime;

public HL7V21Field SpecimenReceivedDateTime
{
    get
    {
        if (specimenReceivedDateTime != null)
        {
            return specimenReceivedDateTime;
        }

        specimenReceivedDateTime = new HL7V21Field
        {
            field = message[@"OBR"][14],
            Id = @"OBR.14",
            Type = @"Field",
            Position = @"OBR.14",
            Name = @"Specimen Received Date/Time",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return specimenReceivedDateTime;
    } 
}
internal HL7V21Field specimenSource;

public HL7V21Field SpecimenSource
{
    get
    {
        if (specimenSource != null)
        {
            return specimenSource;
        }

        specimenSource = new HL7V21Field
        {
            field = message[@"OBR"][15],
            Id = @"OBR.15",
            Type = @"Field",
            Position = @"OBR.15",
            Name = @"Specimen Source",
            Length = 300,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = @"0070",
            TableName = @"SOURCE OF SPECIMEN",
            Description = null,
            Sample = @"",
        };

        

        

        

        return specimenSource;
    } 
}
internal HL7V21Field orderingProvider;

public HL7V21Field OrderingProvider
{
    get
    {
        if (orderingProvider != null)
        {
            return orderingProvider;
        }

        orderingProvider = new HL7V21Field
        {
            field = message[@"OBR"][16],
            Id = @"OBR.16",
            Type = @"Field",
            Position = @"OBR.16",
            Name = @"Ordering Provider",
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

        

        

        

        return orderingProvider;
    } 
}
internal HL7V21Field orderCallbackPhoneNum;

public HL7V21Field OrderCallbackPhoneNum
{
    get
    {
        if (orderCallbackPhoneNum != null)
        {
            return orderCallbackPhoneNum;
        }

        orderCallbackPhoneNum = new HL7V21Field
        {
            field = message[@"OBR"][17],
            Id = @"OBR.17",
            Type = @"Field",
            Position = @"OBR.17",
            Name = @"Order Call-back Phone Num",
            Length = 40,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return orderCallbackPhoneNum;
    } 
}
internal HL7V21Field placersField#1;

public HL7V21Field PlacersField#1
{
    get
    {
        if (placersField#1 != null)
        {
            return placersField#1;
        }

        placersField#1 = new HL7V21Field
        {
            field = message[@"OBR"][18],
            Id = @"OBR.18",
            Type = @"Field",
            Position = @"OBR.18",
            Name = @"Placers Field #1",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return placersField#1;
    } 
}
internal HL7V21Field placersField#2;

public HL7V21Field PlacersField#2
{
    get
    {
        if (placersField#2 != null)
        {
            return placersField#2;
        }

        placersField#2 = new HL7V21Field
        {
            field = message[@"OBR"][19],
            Id = @"OBR.19",
            Type = @"Field",
            Position = @"OBR.19",
            Name = @"Placers Field #2",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return placersField#2;
    } 
}
internal HL7V21Field fillersField#1;

public HL7V21Field FillersField#1
{
    get
    {
        if (fillersField#1 != null)
        {
            return fillersField#1;
        }

        fillersField#1 = new HL7V21Field
        {
            field = message[@"OBR"][20],
            Id = @"OBR.20",
            Type = @"Field",
            Position = @"OBR.20",
            Name = @"Fillers Field #1",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return fillersField#1;
    } 
}
internal HL7V21Field fillersField#2;

public HL7V21Field FillersField#2
{
    get
    {
        if (fillersField#2 != null)
        {
            return fillersField#2;
        }

        fillersField#2 = new HL7V21Field
        {
            field = message[@"OBR"][21],
            Id = @"OBR.21",
            Type = @"Field",
            Position = @"OBR.21",
            Name = @"Fillers Field #2",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return fillersField#2;
    } 
}
internal HL7V21Field resultsRptStatusChngDateT;

public HL7V21Field ResultsRptStatusChngDateT
{
    get
    {
        if (resultsRptStatusChngDateT != null)
        {
            return resultsRptStatusChngDateT;
        }

        resultsRptStatusChngDateT = new HL7V21Field
        {
            field = message[@"OBR"][22],
            Id = @"OBR.22",
            Type = @"Field",
            Position = @"OBR.22",
            Name = @"Results Rpt/Status Chng - Date/T",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return resultsRptStatusChngDateT;
    } 
}
internal HL7V21Field chargeToPractice;

public HL7V21Field ChargeToPractice
{
    get
    {
        if (chargeToPractice != null)
        {
            return chargeToPractice;
        }

        chargeToPractice = new HL7V21Field
        {
            field = message[@"OBR"][23],
            Id = @"OBR.23",
            Type = @"Field",
            Position = @"OBR.23",
            Name = @"Charge To Practice",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return chargeToPractice;
    } 
}
internal HL7V21Field diagnosticServSectId;

public HL7V21Field DiagnosticServSectId
{
    get
    {
        if (diagnosticServSectId != null)
        {
            return diagnosticServSectId;
        }

        diagnosticServSectId = new HL7V21Field
        {
            field = message[@"OBR"][24],
            Id = @"OBR.24",
            Type = @"Field",
            Position = @"OBR.24",
            Name = @"Diagnostic Serv Sect Id",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0074",
            TableName = @"DIAGNOSTIC SERVICE SECTION ID",
            Description = null,
            Sample = @"",
        };

        

        

        

        return diagnosticServSectId;
    } 
}
internal HL7V21Field resultStatus;

public HL7V21Field ResultStatus
{
    get
    {
        if (resultStatus != null)
        {
            return resultStatus;
        }

        resultStatus = new HL7V21Field
        {
            field = message[@"OBR"][25],
            Id = @"OBR.25",
            Type = @"Field",
            Position = @"OBR.25",
            Name = @"Result Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0123",
            TableName = @"RESULT STATUS - OBR",
            Description = null,
            Sample = @"",
        };

        

        

        

        return resultStatus;
    } 
}
internal HL7V21Field linkedResults;

public HL7V21Field LinkedResults
{
    get
    {
        if (linkedResults != null)
        {
            return linkedResults;
        }

        linkedResults = new HL7V21Field
        {
            field = message[@"OBR"][26],
            Id = @"OBR.26",
            Type = @"Field",
            Position = @"OBR.26",
            Name = @"Linked Results",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return linkedResults;
    } 
}
internal HL7V21Field quantityTiming;

public HL7V21Field QuantityTiming
{
    get
    {
        if (quantityTiming != null)
        {
            return quantityTiming;
        }

        quantityTiming = new HL7V21Field
        {
            field = message[@"OBR"][27],
            Id = @"OBR.27",
            Type = @"Field",
            Position = @"OBR.27",
            Name = @"Quantity/Timing",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return quantityTiming;
    } 
}
internal HL7V21Field resultCopiesTo;

public HL7V21Field ResultCopiesTo
{
    get
    {
        if (resultCopiesTo != null)
        {
            return resultCopiesTo;
        }

        resultCopiesTo = new HL7V21Field
        {
            field = message[@"OBR"][28],
            Id = @"OBR.28",
            Type = @"Field",
            Position = @"OBR.28",
            Name = @"Result Copies To",
            Length = 80,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return resultCopiesTo;
    } 
}
internal HL7V21Field parentAccession#;

public HL7V21Field ParentAccession#
{
    get
    {
        if (parentAccession# != null)
        {
            return parentAccession#;
        }

        parentAccession# = new HL7V21Field
        {
            field = message[@"OBR"][29],
            Id = @"OBR.29",
            Type = @"Field",
            Position = @"OBR.29",
            Name = @"Parent Accession #",
            Length = 150,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return parentAccession#;
    } 
}
internal HL7V21Field transportationMode;

public HL7V21Field TransportationMode
{
    get
    {
        if (transportationMode != null)
        {
            return transportationMode;
        }

        transportationMode = new HL7V21Field
        {
            field = message[@"OBR"][30],
            Id = @"OBR.30",
            Type = @"Field",
            Position = @"OBR.30",
            Name = @"Transportation Mode",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0124",
            TableName = @"TRANSPORTATION MODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return transportationMode;
    } 
}
internal HL7V21Field reasonForStudy;

public HL7V21Field ReasonForStudy
{
    get
    {
        if (reasonForStudy != null)
        {
            return reasonForStudy;
        }

        reasonForStudy = new HL7V21Field
        {
            field = message[@"OBR"][31],
            Id = @"OBR.31",
            Type = @"Field",
            Position = @"OBR.31",
            Name = @"Reason For Study",
            Length = 300,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return reasonForStudy;
    } 
}
internal HL7V21Field principalResultInterpreter;

public HL7V21Field PrincipalResultInterpreter
{
    get
    {
        if (principalResultInterpreter != null)
        {
            return principalResultInterpreter;
        }

        principalResultInterpreter = new HL7V21Field
        {
            field = message[@"OBR"][32],
            Id = @"OBR.32",
            Type = @"Field",
            Position = @"OBR.32",
            Name = @"Principal Result Interpreter",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return principalResultInterpreter;
    } 
}
internal HL7V21Field assistantResultInterpreter;

public HL7V21Field AssistantResultInterpreter
{
    get
    {
        if (assistantResultInterpreter != null)
        {
            return assistantResultInterpreter;
        }

        assistantResultInterpreter = new HL7V21Field
        {
            field = message[@"OBR"][33],
            Id = @"OBR.33",
            Type = @"Field",
            Position = @"OBR.33",
            Name = @"Assistant Result Interpreter",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return assistantResultInterpreter;
    } 
}
internal HL7V21Field technician;

public HL7V21Field Technician
{
    get
    {
        if (technician != null)
        {
            return technician;
        }

        technician = new HL7V21Field
        {
            field = message[@"OBR"][34],
            Id = @"OBR.34",
            Type = @"Field",
            Position = @"OBR.34",
            Name = @"Technician",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return technician;
    } 
}
internal HL7V21Field transcriptionist;

public HL7V21Field Transcriptionist
{
    get
    {
        if (transcriptionist != null)
        {
            return transcriptionist;
        }

        transcriptionist = new HL7V21Field
        {
            field = message[@"OBR"][35],
            Id = @"OBR.35",
            Type = @"Field",
            Position = @"OBR.35",
            Name = @"Transcriptionist",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return transcriptionist;
    } 
}
internal HL7V21Field scheduledDateTime;

public HL7V21Field ScheduledDateTime
{
    get
    {
        if (scheduledDateTime != null)
        {
            return scheduledDateTime;
        }

        scheduledDateTime = new HL7V21Field
        {
            field = message[@"OBR"][36],
            Id = @"OBR.36",
            Type = @"Field",
            Position = @"OBR.36",
            Name = @"Scheduled - Date/Time",
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

        

        

        

        return scheduledDateTime;
    } 
}

    }
}
