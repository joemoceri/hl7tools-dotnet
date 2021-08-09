using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentPID
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PID"; } }

        public string SegmentId { get { return @"PID"; } }
        
        public string LongName { get { return @"Patient Identification"; } }
        
        public string Description { get { return @"The PID segment is used by all applications as the primary means of communicating patient identification information.  This segment contains permanent patient identifying, and demographic information that, for the most part, is not likely to change frequently"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
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
                            Id = @"PID.1",
                            Type = @"Field",
                            Position = @"PID.1",
                            Name = @"Set Id - Patient Id",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = @"for those messages that permit segments to repeat, the Set ID field is used to identify the repetitions.  For example, the swap and query transactions allow for multiple PID segments would have Set ID values of 1, 2, then 3, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.2",
                            Type = @"Field",
                            Position = @"PID.2",
                            Name = @"Patient Id (external Id)",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"if the patient is from another institution, outside office, etc., the identifier used by that institution can be shown here.  This may be a number which multiple disparate corporations or facilities share.  Refer to table 0061 - check digit scheme in Chapter 2",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PID.2.1",
                            Type = @"Component",
                            Position = @"PID.2.1",
                            Name = @"ID Number",
                            Length = 0,
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
                            Id = @"PID.2.2",
                            Type = @"Component",
                            Position = @"PID.2.2",
                            Name = @"Check Digit",
                            Length = 0,
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
                            Id = @"PID.2.3",
                            Type = @"Component",
                            Position = @"PID.2.3",
                            Name = @"Code Identifying the Check Digit Scheme Employed ",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = @"The check digit scheme codes are defined in table 0061 - check digit scheme. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.2.4",
                            Type = @"Component",
                            Position = @"PID.2.4",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility ID is a unique name (up to six characters in length) of the system that stores the data.  It is an ST data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning facility ID's are unique across a given HL7 implementation.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.3",
                            Type = @"Field",
                            Position = @"PID.3",
                            Name = @"Patient Id (internal Id)",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"CM_PAT_ID",
                            DataTypeName = @"Patient Id",
                            TableId = null,
                            TableName = null,
                            Description = @" primary ID used by the facility to uniquely identify a patient at the time of admit, (e.g., medical record number, billing number, etc).  Refer to table 0061-check digit scheme",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PID.3.1",
                            Type = @"Component",
                            Position = @"PID.3.1",
                            Name = @"Patient Id",
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
                            Id = @"PID.3.2",
                            Type = @"Component",
                            Position = @"PID.3.2",
                            Name = @"Check Digit",
                            Length = 0,
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
                            Id = @"PID.3.3",
                            Type = @"Component",
                            Position = @"PID.3.3",
                            Name = @"Check Digit Scheme",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.3.4",
                            Type = @"Component",
                            Position = @"PID.3.4",
                            Name = @"Facility Id",
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
                            Id = @"PID.3.5",
                            Type = @"Component",
                            Position = @"PID.3.5",
                            Name = @"Type",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.4",
                            Type = @"Field",
                            Position = @"PID.4",
                            Name = @"Alternate Patient Id",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"third number may be required to identify a patient.  Possible contents include a visit number, a visit date, or Social Security Number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.5",
                            Type = @"Field",
                            Position = @"PID.5",
                            Name = @"Patient Name",
                            Length = 48,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"name is standard format described in Chapter 2. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PID.5.1",
                            Type = @"Component",
                            Position = @"PID.5.1",
                            Name = @"Familiy Name",
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
                            Id = @"PID.5.2",
                            Type = @"Component",
                            Position = @"PID.5.2",
                            Name = @"Given Name",
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
                            Id = @"PID.5.3",
                            Type = @"Component",
                            Position = @"PID.5.3",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"PID.5.4",
                            Type = @"Component",
                            Position = @"PID.5.4",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"PID.5.5",
                            Type = @"Component",
                            Position = @"PID.5.5",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"PID.5.6",
                            Type = @"Component",
                            Position = @"PID.5.6",
                            Name = @"Degree (e.g. Md)",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.6",
                            Type = @"Field",
                            Position = @"PID.6",
                            Name = @"Mother's Maiden Name",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"family name under which the mother was born (i.e., before marriage.)  Used to disambiguate patients with the same last name",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.7",
                            Type = @"Field",
                            Position = @"PID.7",
                            Name = @"Date Of Birth",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"patient's date of birth",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PID.7.1",
                            Type = @"Component",
                            Position = @"PID.7.1",
                            Name = @"Time Of An Event",
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
                            Id = @"PID.7.2",
                            Type = @"Component",
                            Position = @"PID.7.2",
                            Name = @"Degree Of Precision",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.8",
                            Type = @"Field",
                            Position = @"PID.8",
                            Name = @"Sex",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0001",
                            TableName = @"SEX",
                            Description = @"patient's sex.  Refer to table 0001 - sex for valid codes.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.9",
                            Type = @"Field",
                            Position = @"PID.9",
                            Name = @"Patient Alias",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"name(s) by which the patient has been known at some time",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PID.9.1",
                            Type = @"Component",
                            Position = @"PID.9.1",
                            Name = @"Familiy Name",
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
                            Id = @"PID.9.2",
                            Type = @"Component",
                            Position = @"PID.9.2",
                            Name = @"Given Name",
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
                            Id = @"PID.9.3",
                            Type = @"Component",
                            Position = @"PID.9.3",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"PID.9.4",
                            Type = @"Component",
                            Position = @"PID.9.4",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"PID.9.5",
                            Type = @"Component",
                            Position = @"PID.9.5",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"PID.9.6",
                            Type = @"Component",
                            Position = @"PID.9.6",
                            Name = @"Degree (e.g. Md)",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.10",
                            Type = @"Field",
                            Position = @"PID.10",
                            Name = @"Race",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0005",
                            TableName = @"RACE",
                            Description = @"ERISA also has a published list of ethnic classifications which may be used by local agreement at a site.  Refer to user-defined table 0005 - race",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.11",
                            Type = @"Field",
                            Position = @"PID.11",
                            Name = @"Patient Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = @"mailing address of the patient",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PID.11.1",
                            Type = @"Component",
                            Position = @"PID.11.1",
                            Name = @"Street Address",
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
                            Id = @"PID.11.2",
                            Type = @"Component",
                            Position = @"PID.11.2",
                            Name = @"Other Designation",
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
                            Id = @"PID.11.3",
                            Type = @"Component",
                            Position = @"PID.11.3",
                            Name = @"City",
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
                            Id = @"PID.11.4",
                            Type = @"Component",
                            Position = @"PID.11.4",
                            Name = @"State Or Province",
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
                            Id = @"PID.11.5",
                            Type = @"Component",
                            Position = @"PID.11.5",
                            Name = @"Zip Or Postal Code",
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
                            Id = @"PID.11.6",
                            Type = @"Component",
                            Position = @"PID.11.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.11.7",
                            Type = @"Component",
                            Position = @"PID.11.7",
                            Name = @"Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0190",
                            TableName = @"ADDRESS TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.11.8",
                            Type = @"Component",
                            Position = @"PID.11.8",
                            Name = @"Other Geographic Designation",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.12",
                            Type = @"Field",
                            Position = @"PID.12",
                            Name = @"County Code",
                            Length = 4,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"patient's county code.  This field was left in for backwards compatibility.  County can now be supported in the other geographic designation component of the AD data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.13",
                            Type = @"Field",
                            Position = @"PID.13",
                            Name = @"Phone Number - Home",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"up to three repetitions are permitted.  The first is considered the primary number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.14",
                            Type = @"Field",
                            Position = @"PID.14",
                            Name = @"Phone Number - Business",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"up to three repetitions are permitted.  The first is considered the primary one",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.15",
                            Type = @"Field",
                            Position = @"PID.15",
                            Name = @"Language - Patient",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the patient's primary language",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.16",
                            Type = @"Field",
                            Position = @"PID.16",
                            Name = @"Marital Status",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0002",
                            TableName = @"MARITAL STATUS",
                            Description = @"patient's marital status.  Refer to user-defined table 0002 - marital status for suggested entries",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.17",
                            Type = @"Field",
                            Position = @"PID.17",
                            Name = @"Religion",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0006",
                            TableName = @"RELIGION",
                            Description = @"patient's religion.  Refer to user-defined table 0006 - religion",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.18",
                            Type = @"Field",
                            Position = @"PID.18",
                            Name = @"Patient Account Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"number assigned by accounting to which all charges, payments, etc. are recorded.  It is used to identify the patient's account.  Refer to table 0061 - check digit scheme in Chapter 2. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PID.18.1",
                            Type = @"Component",
                            Position = @"PID.18.1",
                            Name = @"ID Number",
                            Length = 0,
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
                            Id = @"PID.18.2",
                            Type = @"Component",
                            Position = @"PID.18.2",
                            Name = @"Check Digit",
                            Length = 0,
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
                            Id = @"PID.18.3",
                            Type = @"Component",
                            Position = @"PID.18.3",
                            Name = @"Code Identifying the Check Digit Scheme Employed ",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = @"The check digit scheme codes are defined in table 0061 - check digit scheme. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.18.4",
                            Type = @"Component",
                            Position = @"PID.18.4",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility ID is a unique name (up to six characters in length) of the system that stores the data.  It is an ST data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning facility ID's are unique across a given HL7 implementation.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.19",
                            Type = @"Field",
                            Position = @"PID.19",
                            Name = @"Social Security Number - Patient",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"patient's social security number.  This number may also be an RR retirement number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.20",
                            Type = @"Field",
                            Position = @"PID.20",
                            Name = @"Driver's License Number - Patient",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_LICENSE_NO",
                            DataTypeName = @"Cm For Driving License",
                            TableId = null,
                            TableName = null,
                            Description = @"patient's drivers license number.  Some sites may use this as a unique number that identifies the patient.  Default of the second component is the state in which the patient is being registered",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PID.20.1",
                            Type = @"Component",
                            Position = @"PID.20.1",
                            Name = @"License Number",
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
                            Id = @"PID.20.2",
                            Type = @"Component",
                            Position = @"PID.20.2",
                            Name = @"Issuing State,province,country",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.21",
                            Type = @"Field",
                            Position = @"PID.21",
                            Name = @"Mother's Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @" used as a link field for newborns, for example.  Typically a patient ID or account number may be used.  Refer to HL7 table 0061 - check digit scheme as defined in Chapter 2. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PID.21.1",
                            Type = @"Component",
                            Position = @"PID.21.1",
                            Name = @"ID Number",
                            Length = 0,
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
                            Id = @"PID.21.2",
                            Type = @"Component",
                            Position = @"PID.21.2",
                            Name = @"Check Digit",
                            Length = 0,
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
                            Id = @"PID.21.3",
                            Type = @"Component",
                            Position = @"PID.21.3",
                            Name = @"Code Identifying the Check Digit Scheme Employed ",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = @"The check digit scheme codes are defined in table 0061 - check digit scheme. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.21.4",
                            Type = @"Component",
                            Position = @"PID.21.4",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility ID is a unique name (up to six characters in length) of the system that stores the data.  It is an ST data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning facility ID's are unique across a given HL7 implementation.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.22",
                            Type = @"Field",
                            Position = @"PID.22",
                            Name = @"Ethnic Group",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0189",
                            TableName = @"ETHNIC GROUP",
                            Description = @"further defines patient ancestry.  Refer to user-defined table 0189 - ethnic group for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.23",
                            Type = @"Field",
                            Position = @"PID.23",
                            Name = @"Birth Place",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"indicates the location of the patient's birth",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.24",
                            Type = @"Field",
                            Position = @"PID.24",
                            Name = @"Multiple Birth Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = @"indicates if the patient was part of a multiple birth.  Refer to HL7 table 0136 - Y/N indicator as described in Chapter 2. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.25",
                            Type = @"Field",
                            Position = @"PID.25",
                            Name = @"Birth Order",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"if a patient was part of a multiple birth, a value (number) indicating the patient's birth order",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.26",
                            Type = @"Field",
                            Position = @"PID.26",
                            Name = @"Citizenship",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0171",
                            TableName = @"COUNTRY CODE",
                            Description = @"indicates the patient's country of citizenship.  Refer to user-defined table 0171 - country code for suggested values or to ISO 3166",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.27",
                            Type = @"Field",
                            Position = @"PID.27",
                            Name = @"Veterans Military Status",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0172",
                            TableName = @"VETERANS MILITARY STATUS",
                            Description = @"indicates the military status assigned to a veteran.  Refer to user-defined table 0172 - veterans military status for suggested codes",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PID.27.1",
                            Type = @"Component",
                            Position = @"PID.27.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.27.2",
                            Type = @"Component",
                            Position = @"PID.27.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.27.3",
                            Type = @"Component",
                            Position = @"PID.27.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.27.4",
                            Type = @"Component",
                            Position = @"PID.27.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.27.5",
                            Type = @"Component",
                            Position = @"PID.27.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.27.6",
                            Type = @"Component",
                            Position = @"PID.27.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V22SegmentPID(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field setIdPatientId;

public HL7V22Field SetIdPatientId
{
    get
    {
        if (setIdPatientId != null)
        {
            return setIdPatientId;
        }

        setIdPatientId = new HL7V22Field
        {
            field = message[@"PID"][1],
            Id = @"PID.1",
            Type = @"Field",
            Position = @"PID.1",
            Name = @"Set Id - Patient Id",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"for those messages that permit segments to repeat, the Set ID field is used to identify the repetitions.  For example, the swap and query transactions allow for multiple PID segments would have Set ID values of 1, 2, then 3, etc",
            Sample = @"",
        };

        // check for repetitions
        if (setIdPatientId.field.FieldRepetitions != null && setIdPatientId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdPatientId.Id));
            setIdPatientId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(setIdPatientId, fieldData);
        }

        return setIdPatientId;
    } 
}

internal HL7V22Field patientIdexternalId;

public HL7V22Field PatientIdexternalId
{
    get
    {
        if (patientIdexternalId != null)
        {
            return patientIdexternalId;
        }

        patientIdexternalId = new HL7V22Field
        {
            field = message[@"PID"][2],
            Id = @"PID.2",
            Type = @"Field",
            Position = @"PID.2",
            Name = @"Patient Id (external Id)",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"if the patient is from another institution, outside office, etc., the identifier used by that institution can be shown here.  This may be a number which multiple disparate corporations or facilities share.  Refer to table 0061 - check digit scheme in Chapter 2",
            Sample = @"",
        };

        // check for repetitions
        if (patientIdexternalId.field.FieldRepetitions != null && patientIdexternalId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientIdexternalId.Id));
            patientIdexternalId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(patientIdexternalId, fieldData);
        }

        return patientIdexternalId;
    } 
}

internal HL7V22Field patientIdinternalId;

public HL7V22Field PatientIdinternalId
{
    get
    {
        if (patientIdinternalId != null)
        {
            return patientIdinternalId;
        }

        patientIdinternalId = new HL7V22Field
        {
            field = message[@"PID"][3],
            Id = @"PID.3",
            Type = @"Field",
            Position = @"PID.3",
            Name = @"Patient Id (internal Id)",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CM_PAT_ID",
            DataTypeName = @"Patient Id",
            TableId = null,
            TableName = null,
            Description = @" primary ID used by the facility to uniquely identify a patient at the time of admit, (e.g., medical record number, billing number, etc).  Refer to table 0061-check digit scheme",
            Sample = @"",
        };

        // check for repetitions
        if (patientIdinternalId.field.FieldRepetitions != null && patientIdinternalId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientIdinternalId.Id));
            patientIdinternalId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(patientIdinternalId, fieldData);
        }

        return patientIdinternalId;
    } 
}

internal HL7V22Field alternatePatientId;

public HL7V22Field AlternatePatientId
{
    get
    {
        if (alternatePatientId != null)
        {
            return alternatePatientId;
        }

        alternatePatientId = new HL7V22Field
        {
            field = message[@"PID"][4],
            Id = @"PID.4",
            Type = @"Field",
            Position = @"PID.4",
            Name = @"Alternate Patient Id",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"third number may be required to identify a patient.  Possible contents include a visit number, a visit date, or Social Security Number",
            Sample = @"",
        };

        // check for repetitions
        if (alternatePatientId.field.FieldRepetitions != null && alternatePatientId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(alternatePatientId.Id));
            alternatePatientId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(alternatePatientId, fieldData);
        }

        return alternatePatientId;
    } 
}

internal HL7V22Field patientName;

public HL7V22Field PatientName
{
    get
    {
        if (patientName != null)
        {
            return patientName;
        }

        patientName = new HL7V22Field
        {
            field = message[@"PID"][5],
            Id = @"PID.5",
            Type = @"Field",
            Position = @"PID.5",
            Name = @"Patient Name",
            Length = 48,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name is standard format described in Chapter 2. ",
            Sample = @"",
        };

        // check for repetitions
        if (patientName.field.FieldRepetitions != null && patientName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientName.Id));
            patientName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(patientName, fieldData);
        }

        return patientName;
    } 
}

internal HL7V22Field mothersMaidenName;

public HL7V22Field MothersMaidenName
{
    get
    {
        if (mothersMaidenName != null)
        {
            return mothersMaidenName;
        }

        mothersMaidenName = new HL7V22Field
        {
            field = message[@"PID"][6],
            Id = @"PID.6",
            Type = @"Field",
            Position = @"PID.6",
            Name = @"Mother's Maiden Name",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"family name under which the mother was born (i.e., before marriage.)  Used to disambiguate patients with the same last name",
            Sample = @"",
        };

        // check for repetitions
        if (mothersMaidenName.field.FieldRepetitions != null && mothersMaidenName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(mothersMaidenName.Id));
            mothersMaidenName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(mothersMaidenName, fieldData);
        }

        return mothersMaidenName;
    } 
}

internal HL7V22Field dateOfBirth;

public HL7V22Field DateOfBirth
{
    get
    {
        if (dateOfBirth != null)
        {
            return dateOfBirth;
        }

        dateOfBirth = new HL7V22Field
        {
            field = message[@"PID"][7],
            Id = @"PID.7",
            Type = @"Field",
            Position = @"PID.7",
            Name = @"Date Of Birth",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"patient's date of birth",
            Sample = @"",
        };

        // check for repetitions
        if (dateOfBirth.field.FieldRepetitions != null && dateOfBirth.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateOfBirth.Id));
            dateOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dateOfBirth, fieldData);
        }

        return dateOfBirth;
    } 
}

internal HL7V22Field sex;

public HL7V22Field Sex
{
    get
    {
        if (sex != null)
        {
            return sex;
        }

        sex = new HL7V22Field
        {
            field = message[@"PID"][8],
            Id = @"PID.8",
            Type = @"Field",
            Position = @"PID.8",
            Name = @"Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0001",
            TableName = @"SEX",
            Description = @"patient's sex.  Refer to table 0001 - sex for valid codes.",
            Sample = @"",
        };

        // check for repetitions
        if (sex.field.FieldRepetitions != null && sex.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sex.Id));
            sex.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(sex, fieldData);
        }

        return sex;
    } 
}

internal HL7V22Field patientAlias;

public HL7V22Field PatientAlias
{
    get
    {
        if (patientAlias != null)
        {
            return patientAlias;
        }

        patientAlias = new HL7V22Field
        {
            field = message[@"PID"][9],
            Id = @"PID.9",
            Type = @"Field",
            Position = @"PID.9",
            Name = @"Patient Alias",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name(s) by which the patient has been known at some time",
            Sample = @"",
        };

        // check for repetitions
        if (patientAlias.field.FieldRepetitions != null && patientAlias.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientAlias.Id));
            patientAlias.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(patientAlias, fieldData);
        }

        return patientAlias;
    } 
}

internal HL7V22Field race;

public HL7V22Field Race
{
    get
    {
        if (race != null)
        {
            return race;
        }

        race = new HL7V22Field
        {
            field = message[@"PID"][10],
            Id = @"PID.10",
            Type = @"Field",
            Position = @"PID.10",
            Name = @"Race",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0005",
            TableName = @"RACE",
            Description = @"ERISA also has a published list of ethnic classifications which may be used by local agreement at a site.  Refer to user-defined table 0005 - race",
            Sample = @"",
        };

        // check for repetitions
        if (race.field.FieldRepetitions != null && race.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(race.Id));
            race.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(race, fieldData);
        }

        return race;
    } 
}

internal HL7V22Field patientAddress;

public HL7V22Field PatientAddress
{
    get
    {
        if (patientAddress != null)
        {
            return patientAddress;
        }

        patientAddress = new HL7V22Field
        {
            field = message[@"PID"][11],
            Id = @"PID.11",
            Type = @"Field",
            Position = @"PID.11",
            Name = @"Patient Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @"mailing address of the patient",
            Sample = @"",
        };

        // check for repetitions
        if (patientAddress.field.FieldRepetitions != null && patientAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientAddress.Id));
            patientAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(patientAddress, fieldData);
        }

        return patientAddress;
    } 
}

internal HL7V22Field countyCode;

public HL7V22Field CountyCode
{
    get
    {
        if (countyCode != null)
        {
            return countyCode;
        }

        countyCode = new HL7V22Field
        {
            field = message[@"PID"][12],
            Id = @"PID.12",
            Type = @"Field",
            Position = @"PID.12",
            Name = @"County Code",
            Length = 4,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"patient's county code.  This field was left in for backwards compatibility.  County can now be supported in the other geographic designation component of the AD data type",
            Sample = @"",
        };

        // check for repetitions
        if (countyCode.field.FieldRepetitions != null && countyCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(countyCode.Id));
            countyCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(countyCode, fieldData);
        }

        return countyCode;
    } 
}

internal HL7V22Field phoneNumberHome;

public HL7V22Field PhoneNumberHome
{
    get
    {
        if (phoneNumberHome != null)
        {
            return phoneNumberHome;
        }

        phoneNumberHome = new HL7V22Field
        {
            field = message[@"PID"][13],
            Id = @"PID.13",
            Type = @"Field",
            Position = @"PID.13",
            Name = @"Phone Number - Home",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"up to three repetitions are permitted.  The first is considered the primary number",
            Sample = @"",
        };

        // check for repetitions
        if (phoneNumberHome.field.FieldRepetitions != null && phoneNumberHome.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(phoneNumberHome.Id));
            phoneNumberHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(phoneNumberHome, fieldData);
        }

        return phoneNumberHome;
    } 
}

internal HL7V22Field phoneNumberBusiness;

public HL7V22Field PhoneNumberBusiness
{
    get
    {
        if (phoneNumberBusiness != null)
        {
            return phoneNumberBusiness;
        }

        phoneNumberBusiness = new HL7V22Field
        {
            field = message[@"PID"][14],
            Id = @"PID.14",
            Type = @"Field",
            Position = @"PID.14",
            Name = @"Phone Number - Business",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"up to three repetitions are permitted.  The first is considered the primary one",
            Sample = @"",
        };

        // check for repetitions
        if (phoneNumberBusiness.field.FieldRepetitions != null && phoneNumberBusiness.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(phoneNumberBusiness.Id));
            phoneNumberBusiness.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(phoneNumberBusiness, fieldData);
        }

        return phoneNumberBusiness;
    } 
}

internal HL7V22Field languagePatient;

public HL7V22Field LanguagePatient
{
    get
    {
        if (languagePatient != null)
        {
            return languagePatient;
        }

        languagePatient = new HL7V22Field
        {
            field = message[@"PID"][15],
            Id = @"PID.15",
            Type = @"Field",
            Position = @"PID.15",
            Name = @"Language - Patient",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"the patient's primary language",
            Sample = @"",
        };

        // check for repetitions
        if (languagePatient.field.FieldRepetitions != null && languagePatient.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(languagePatient.Id));
            languagePatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(languagePatient, fieldData);
        }

        return languagePatient;
    } 
}

internal HL7V22Field maritalStatus;

public HL7V22Field MaritalStatus
{
    get
    {
        if (maritalStatus != null)
        {
            return maritalStatus;
        }

        maritalStatus = new HL7V22Field
        {
            field = message[@"PID"][16],
            Id = @"PID.16",
            Type = @"Field",
            Position = @"PID.16",
            Name = @"Marital Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0002",
            TableName = @"MARITAL STATUS",
            Description = @"patient's marital status.  Refer to user-defined table 0002 - marital status for suggested entries",
            Sample = @"",
        };

        // check for repetitions
        if (maritalStatus.field.FieldRepetitions != null && maritalStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(maritalStatus.Id));
            maritalStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(maritalStatus, fieldData);
        }

        return maritalStatus;
    } 
}

internal HL7V22Field religion;

public HL7V22Field Religion
{
    get
    {
        if (religion != null)
        {
            return religion;
        }

        religion = new HL7V22Field
        {
            field = message[@"PID"][17],
            Id = @"PID.17",
            Type = @"Field",
            Position = @"PID.17",
            Name = @"Religion",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0006",
            TableName = @"RELIGION",
            Description = @"patient's religion.  Refer to user-defined table 0006 - religion",
            Sample = @"",
        };

        // check for repetitions
        if (religion.field.FieldRepetitions != null && religion.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(religion.Id));
            religion.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(religion, fieldData);
        }

        return religion;
    } 
}

internal HL7V22Field patientAccountNumber;

public HL7V22Field PatientAccountNumber
{
    get
    {
        if (patientAccountNumber != null)
        {
            return patientAccountNumber;
        }

        patientAccountNumber = new HL7V22Field
        {
            field = message[@"PID"][18],
            Id = @"PID.18",
            Type = @"Field",
            Position = @"PID.18",
            Name = @"Patient Account Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"number assigned by accounting to which all charges, payments, etc. are recorded.  It is used to identify the patient's account.  Refer to table 0061 - check digit scheme in Chapter 2. ",
            Sample = @"",
        };

        // check for repetitions
        if (patientAccountNumber.field.FieldRepetitions != null && patientAccountNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientAccountNumber.Id));
            patientAccountNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(patientAccountNumber, fieldData);
        }

        return patientAccountNumber;
    } 
}

internal HL7V22Field socialSecurityNumberPatient;

public HL7V22Field SocialSecurityNumberPatient
{
    get
    {
        if (socialSecurityNumberPatient != null)
        {
            return socialSecurityNumberPatient;
        }

        socialSecurityNumberPatient = new HL7V22Field
        {
            field = message[@"PID"][19],
            Id = @"PID.19",
            Type = @"Field",
            Position = @"PID.19",
            Name = @"Social Security Number - Patient",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"patient's social security number.  This number may also be an RR retirement number",
            Sample = @"",
        };

        // check for repetitions
        if (socialSecurityNumberPatient.field.FieldRepetitions != null && socialSecurityNumberPatient.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(socialSecurityNumberPatient.Id));
            socialSecurityNumberPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(socialSecurityNumberPatient, fieldData);
        }

        return socialSecurityNumberPatient;
    } 
}

internal HL7V22Field driversLicenseNumberPatient;

public HL7V22Field DriversLicenseNumberPatient
{
    get
    {
        if (driversLicenseNumberPatient != null)
        {
            return driversLicenseNumberPatient;
        }

        driversLicenseNumberPatient = new HL7V22Field
        {
            field = message[@"PID"][20],
            Id = @"PID.20",
            Type = @"Field",
            Position = @"PID.20",
            Name = @"Driver's License Number - Patient",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_LICENSE_NO",
            DataTypeName = @"Cm For Driving License",
            TableId = null,
            TableName = null,
            Description = @"patient's drivers license number.  Some sites may use this as a unique number that identifies the patient.  Default of the second component is the state in which the patient is being registered",
            Sample = @"",
        };

        // check for repetitions
        if (driversLicenseNumberPatient.field.FieldRepetitions != null && driversLicenseNumberPatient.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(driversLicenseNumberPatient.Id));
            driversLicenseNumberPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(driversLicenseNumberPatient, fieldData);
        }

        return driversLicenseNumberPatient;
    } 
}

internal HL7V22Field mothersIdentifier;

public HL7V22Field MothersIdentifier
{
    get
    {
        if (mothersIdentifier != null)
        {
            return mothersIdentifier;
        }

        mothersIdentifier = new HL7V22Field
        {
            field = message[@"PID"][21],
            Id = @"PID.21",
            Type = @"Field",
            Position = @"PID.21",
            Name = @"Mother's Identifier",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = @" used as a link field for newborns, for example.  Typically a patient ID or account number may be used.  Refer to HL7 table 0061 - check digit scheme as defined in Chapter 2. ",
            Sample = @"",
        };

        // check for repetitions
        if (mothersIdentifier.field.FieldRepetitions != null && mothersIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(mothersIdentifier.Id));
            mothersIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(mothersIdentifier, fieldData);
        }

        return mothersIdentifier;
    } 
}

internal HL7V22Field ethnicGroup;

public HL7V22Field EthnicGroup
{
    get
    {
        if (ethnicGroup != null)
        {
            return ethnicGroup;
        }

        ethnicGroup = new HL7V22Field
        {
            field = message[@"PID"][22],
            Id = @"PID.22",
            Type = @"Field",
            Position = @"PID.22",
            Name = @"Ethnic Group",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0189",
            TableName = @"ETHNIC GROUP",
            Description = @"further defines patient ancestry.  Refer to user-defined table 0189 - ethnic group for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (ethnicGroup.field.FieldRepetitions != null && ethnicGroup.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ethnicGroup.Id));
            ethnicGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(ethnicGroup, fieldData);
        }

        return ethnicGroup;
    } 
}

internal HL7V22Field birthPlace;

public HL7V22Field BirthPlace
{
    get
    {
        if (birthPlace != null)
        {
            return birthPlace;
        }

        birthPlace = new HL7V22Field
        {
            field = message[@"PID"][23],
            Id = @"PID.23",
            Type = @"Field",
            Position = @"PID.23",
            Name = @"Birth Place",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"indicates the location of the patient's birth",
            Sample = @"",
        };

        // check for repetitions
        if (birthPlace.field.FieldRepetitions != null && birthPlace.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(birthPlace.Id));
            birthPlace.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(birthPlace, fieldData);
        }

        return birthPlace;
    } 
}

internal HL7V22Field multipleBirthIndicator;

public HL7V22Field MultipleBirthIndicator
{
    get
    {
        if (multipleBirthIndicator != null)
        {
            return multipleBirthIndicator;
        }

        multipleBirthIndicator = new HL7V22Field
        {
            field = message[@"PID"][24],
            Id = @"PID.24",
            Type = @"Field",
            Position = @"PID.24",
            Name = @"Multiple Birth Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"indicates if the patient was part of a multiple birth.  Refer to HL7 table 0136 - Y/N indicator as described in Chapter 2. ",
            Sample = @"",
        };

        // check for repetitions
        if (multipleBirthIndicator.field.FieldRepetitions != null && multipleBirthIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(multipleBirthIndicator.Id));
            multipleBirthIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(multipleBirthIndicator, fieldData);
        }

        return multipleBirthIndicator;
    } 
}

internal HL7V22Field birthOrder;

public HL7V22Field BirthOrder
{
    get
    {
        if (birthOrder != null)
        {
            return birthOrder;
        }

        birthOrder = new HL7V22Field
        {
            field = message[@"PID"][25],
            Id = @"PID.25",
            Type = @"Field",
            Position = @"PID.25",
            Name = @"Birth Order",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"if a patient was part of a multiple birth, a value (number) indicating the patient's birth order",
            Sample = @"",
        };

        // check for repetitions
        if (birthOrder.field.FieldRepetitions != null && birthOrder.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(birthOrder.Id));
            birthOrder.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(birthOrder, fieldData);
        }

        return birthOrder;
    } 
}

internal HL7V22Field citizenship;

public HL7V22Field Citizenship
{
    get
    {
        if (citizenship != null)
        {
            return citizenship;
        }

        citizenship = new HL7V22Field
        {
            field = message[@"PID"][26],
            Id = @"PID.26",
            Type = @"Field",
            Position = @"PID.26",
            Name = @"Citizenship",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0171",
            TableName = @"COUNTRY CODE",
            Description = @"indicates the patient's country of citizenship.  Refer to user-defined table 0171 - country code for suggested values or to ISO 3166",
            Sample = @"",
        };

        // check for repetitions
        if (citizenship.field.FieldRepetitions != null && citizenship.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(citizenship.Id));
            citizenship.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(citizenship, fieldData);
        }

        return citizenship;
    } 
}

internal HL7V22Field veteransMilitaryStatus;

public HL7V22Field VeteransMilitaryStatus
{
    get
    {
        if (veteransMilitaryStatus != null)
        {
            return veteransMilitaryStatus;
        }

        veteransMilitaryStatus = new HL7V22Field
        {
            field = message[@"PID"][27],
            Id = @"PID.27",
            Type = @"Field",
            Position = @"PID.27",
            Name = @"Veterans Military Status",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0172",
            TableName = @"VETERANS MILITARY STATUS",
            Description = @"indicates the military status assigned to a veteran.  Refer to user-defined table 0172 - veterans military status for suggested codes",
            Sample = @"",
        };

        // check for repetitions
        if (veteransMilitaryStatus.field.FieldRepetitions != null && veteransMilitaryStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(veteransMilitaryStatus.Id));
            veteransMilitaryStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(veteransMilitaryStatus, fieldData);
        }

        return veteransMilitaryStatus;
    } 
}
    }
}
