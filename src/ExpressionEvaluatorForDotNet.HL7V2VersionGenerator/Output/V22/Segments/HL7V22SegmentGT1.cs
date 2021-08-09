using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentGT1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"GT1"; } }

        public string SegmentId { get { return @"GT1"; } }
        
        public string LongName { get { return @"Guarantor"; } }
        
        public string Description { get { return @"The GT1 segment contains guarantor (e.g., person with financial responsibility for payment of a patient account) data for patient and insurance billing applications"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Id = @"GT1.1",
                            Type = @"Field",
                            Position = @"GT1.1",
                            Name = @"Set Id - Guarantor",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = @"number that uniquely identifies the transaction for the purpose of adding, changing, or deleting a transaction",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.2",
                            Type = @"Field",
                            Position = @"GT1.2",
                            Name = @"Guarantor Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"COMP_ID_DIGIT",
                            DataTypeName = @"Composite Id W/chk Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"unique number assigned to the guarantor",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.3",
                            Type = @"Field",
                            Position = @"GT1.3",
                            Name = @"Guarantor Name",
                            Length = 48,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"name of the guarantor",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.3.1",
                            Type = @"Component",
                            Position = @"GT1.3.1",
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
                            Id = @"GT1.3.2",
                            Type = @"Component",
                            Position = @"GT1.3.2",
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
                            Id = @"GT1.3.3",
                            Type = @"Component",
                            Position = @"GT1.3.3",
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
                            Id = @"GT1.3.4",
                            Type = @"Component",
                            Position = @"GT1.3.4",
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
                            Id = @"GT1.3.5",
                            Type = @"Component",
                            Position = @"GT1.3.5",
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
                            Id = @"GT1.3.6",
                            Type = @"Component",
                            Position = @"GT1.3.6",
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
                            Id = @"GT1.4",
                            Type = @"Field",
                            Position = @"GT1.4",
                            Name = @"Guarantor Spouse Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"name of the guarantor's spouse",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.4.1",
                            Type = @"Component",
                            Position = @"GT1.4.1",
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
                            Id = @"GT1.4.2",
                            Type = @"Component",
                            Position = @"GT1.4.2",
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
                            Id = @"GT1.4.3",
                            Type = @"Component",
                            Position = @"GT1.4.3",
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
                            Id = @"GT1.4.4",
                            Type = @"Component",
                            Position = @"GT1.4.4",
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
                            Id = @"GT1.4.5",
                            Type = @"Component",
                            Position = @"GT1.4.5",
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
                            Id = @"GT1.4.6",
                            Type = @"Component",
                            Position = @"GT1.4.6",
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
                            Id = @"GT1.5",
                            Type = @"Field",
                            Position = @"GT1.5",
                            Name = @"Guarantor Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = @"guarantor's address",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.5.1",
                            Type = @"Component",
                            Position = @"GT1.5.1",
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
                            Id = @"GT1.5.2",
                            Type = @"Component",
                            Position = @"GT1.5.2",
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
                            Id = @"GT1.5.3",
                            Type = @"Component",
                            Position = @"GT1.5.3",
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
                            Id = @"GT1.5.4",
                            Type = @"Component",
                            Position = @"GT1.5.4",
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
                            Id = @"GT1.5.5",
                            Type = @"Component",
                            Position = @"GT1.5.5",
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
                            Id = @"GT1.5.6",
                            Type = @"Component",
                            Position = @"GT1.5.6",
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
                            Id = @"GT1.5.7",
                            Type = @"Component",
                            Position = @"GT1.5.7",
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
                            Id = @"GT1.5.8",
                            Type = @"Component",
                            Position = @"GT1.5.8",
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
                            Id = @"GT1.6",
                            Type = @"Field",
                            Position = @"GT1.6",
                            Name = @"Guarantor Phone Number - Home",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"guarantor's home phone number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.7",
                            Type = @"Field",
                            Position = @"GT1.7",
                            Name = @"Guarantor Phone Number - Business",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"guarantor's business phone number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.8",
                            Type = @"Field",
                            Position = @"GT1.8",
                            Name = @"Guarantor Date Of Birth",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"guarantor's date of birth",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.9",
                            Type = @"Field",
                            Position = @"GT1.9",
                            Name = @"Guarantor Sex",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0001",
                            TableName = @"SEX",
                            Description = @"refer to table 0001 - sex for valid entries",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.10",
                            Type = @"Field",
                            Position = @"GT1.10",
                            Name = @"Guarantor Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0068",
                            TableName = @"GUARANTOR TYPE",
                            Description = @"type of guarantor, e.g., individual, institution, etc.  Refer to user-defined table 0068 - guarantor type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.11",
                            Type = @"Field",
                            Position = @"GT1.11",
                            Name = @"Guarantor Relationship",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0063",
                            TableName = @"RELATIONSHIP",
                            Description = @"relationship of the guarantor with the patient, e.g., parent, child, etc.  Refer to user-defined table 0063 - guarantor relationship",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.12",
                            Type = @"Field",
                            Position = @"GT1.12",
                            Name = @"Guarantor Social Security Number",
                            Length = 11,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"guarantor's social security number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.13",
                            Type = @"Field",
                            Position = @"GT1.13",
                            Name = @"Guarantor Date - Begin",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"date the guarantor becomes responsible for the patient's account",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.14",
                            Type = @"Field",
                            Position = @"GT1.14",
                            Name = @"Guarantor Date - End",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"date the guarantor stops being responsible for the patient's account",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.15",
                            Type = @"Field",
                            Position = @"GT1.15",
                            Name = @"Guarantor Priority",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"used to determine the order in which the guarantors will be responsible for the patient's account",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.16",
                            Type = @"Field",
                            Position = @"GT1.16",
                            Name = @"Guarantor Employer Name",
                            Length = 45,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"name of the guarantor's employer",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17",
                            Type = @"Field",
                            Position = @"GT1.17",
                            Name = @"Guarantor Employer Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = @" guarantor's employer's address",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.17.1",
                            Type = @"Component",
                            Position = @"GT1.17.1",
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
                            Id = @"GT1.17.2",
                            Type = @"Component",
                            Position = @"GT1.17.2",
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
                            Id = @"GT1.17.3",
                            Type = @"Component",
                            Position = @"GT1.17.3",
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
                            Id = @"GT1.17.4",
                            Type = @"Component",
                            Position = @"GT1.17.4",
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
                            Id = @"GT1.17.5",
                            Type = @"Component",
                            Position = @"GT1.17.5",
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
                            Id = @"GT1.17.6",
                            Type = @"Component",
                            Position = @"GT1.17.6",
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
                            Id = @"GT1.17.7",
                            Type = @"Component",
                            Position = @"GT1.17.7",
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
                            Id = @"GT1.17.8",
                            Type = @"Component",
                            Position = @"GT1.17.8",
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
                            Id = @"GT1.18",
                            Type = @"Field",
                            Position = @"GT1.18",
                            Name = @"Guarantor Employ Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"guarantor's employer phone number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.19",
                            Type = @"Field",
                            Position = @"GT1.19",
                            Name = @"Guarantor Employee Id Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"guarantor's employee number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.20",
                            Type = @"Field",
                            Position = @"GT1.20",
                            Name = @"Guarantor Employment Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0066",
                            TableName = @"EMPLOYMENT STATUS",
                            Description = @"code that indicates the guarantor's employment status. e.g., Full Time, Part Time, Self Employed, etc.  Refer to user-defined table 0066 - employment status",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21",
                            Type = @"Field",
                            Position = @"GT1.21",
                            Name = @"Guarantor Organization",
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
                        };
            }
        }

        public HL7V22SegmentGT1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field setIdGuarantor;

public HL7V22Field SetIdGuarantor
{
    get
    {
        if (setIdGuarantor != null)
        {
            return setIdGuarantor;
        }

        setIdGuarantor = new HL7V22Field
        {
            field = message[@"GT1"][1],
            Id = @"GT1.1",
            Type = @"Field",
            Position = @"GT1.1",
            Name = @"Set Id - Guarantor",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"number that uniquely identifies the transaction for the purpose of adding, changing, or deleting a transaction",
            Sample = @"",
        };

        // check for repetitions
        if (setIdGuarantor.field.FieldRepetitions != null && setIdGuarantor.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdGuarantor.Id));
            setIdGuarantor.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(setIdGuarantor, fieldData);
        }

        return setIdGuarantor;
    } 
}

internal HL7V22Field guarantorNumber;

public HL7V22Field GuarantorNumber
{
    get
    {
        if (guarantorNumber != null)
        {
            return guarantorNumber;
        }

        guarantorNumber = new HL7V22Field
        {
            field = message[@"GT1"][2],
            Id = @"GT1.2",
            Type = @"Field",
            Position = @"GT1.2",
            Name = @"Guarantor Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"COMP_ID_DIGIT",
            DataTypeName = @"Composite Id W/chk Digit",
            TableId = null,
            TableName = null,
            Description = @"unique number assigned to the guarantor",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorNumber.field.FieldRepetitions != null && guarantorNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorNumber.Id));
            guarantorNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorNumber, fieldData);
        }

        return guarantorNumber;
    } 
}

internal HL7V22Field guarantorName;

public HL7V22Field GuarantorName
{
    get
    {
        if (guarantorName != null)
        {
            return guarantorName;
        }

        guarantorName = new HL7V22Field
        {
            field = message[@"GT1"][3],
            Id = @"GT1.3",
            Type = @"Field",
            Position = @"GT1.3",
            Name = @"Guarantor Name",
            Length = 48,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name of the guarantor",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorName.field.FieldRepetitions != null && guarantorName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorName.Id));
            guarantorName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorName, fieldData);
        }

        return guarantorName;
    } 
}

internal HL7V22Field guarantorSpouseName;

public HL7V22Field GuarantorSpouseName
{
    get
    {
        if (guarantorSpouseName != null)
        {
            return guarantorSpouseName;
        }

        guarantorSpouseName = new HL7V22Field
        {
            field = message[@"GT1"][4],
            Id = @"GT1.4",
            Type = @"Field",
            Position = @"GT1.4",
            Name = @"Guarantor Spouse Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name of the guarantor's spouse",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorSpouseName.field.FieldRepetitions != null && guarantorSpouseName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorSpouseName.Id));
            guarantorSpouseName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorSpouseName, fieldData);
        }

        return guarantorSpouseName;
    } 
}

internal HL7V22Field guarantorAddress;

public HL7V22Field GuarantorAddress
{
    get
    {
        if (guarantorAddress != null)
        {
            return guarantorAddress;
        }

        guarantorAddress = new HL7V22Field
        {
            field = message[@"GT1"][5],
            Id = @"GT1.5",
            Type = @"Field",
            Position = @"GT1.5",
            Name = @"Guarantor Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @"guarantor's address",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorAddress.field.FieldRepetitions != null && guarantorAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorAddress.Id));
            guarantorAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorAddress, fieldData);
        }

        return guarantorAddress;
    } 
}

internal HL7V22Field guarantorPhoneNumberHome;

public HL7V22Field GuarantorPhoneNumberHome
{
    get
    {
        if (guarantorPhoneNumberHome != null)
        {
            return guarantorPhoneNumberHome;
        }

        guarantorPhoneNumberHome = new HL7V22Field
        {
            field = message[@"GT1"][6],
            Id = @"GT1.6",
            Type = @"Field",
            Position = @"GT1.6",
            Name = @"Guarantor Phone Number - Home",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"guarantor's home phone number",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorPhoneNumberHome.field.FieldRepetitions != null && guarantorPhoneNumberHome.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorPhoneNumberHome.Id));
            guarantorPhoneNumberHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorPhoneNumberHome, fieldData);
        }

        return guarantorPhoneNumberHome;
    } 
}

internal HL7V22Field guarantorPhoneNumberBusiness;

public HL7V22Field GuarantorPhoneNumberBusiness
{
    get
    {
        if (guarantorPhoneNumberBusiness != null)
        {
            return guarantorPhoneNumberBusiness;
        }

        guarantorPhoneNumberBusiness = new HL7V22Field
        {
            field = message[@"GT1"][7],
            Id = @"GT1.7",
            Type = @"Field",
            Position = @"GT1.7",
            Name = @"Guarantor Phone Number - Business",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"guarantor's business phone number",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorPhoneNumberBusiness.field.FieldRepetitions != null && guarantorPhoneNumberBusiness.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorPhoneNumberBusiness.Id));
            guarantorPhoneNumberBusiness.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorPhoneNumberBusiness, fieldData);
        }

        return guarantorPhoneNumberBusiness;
    } 
}

internal HL7V22Field guarantorDateOfBirth;

public HL7V22Field GuarantorDateOfBirth
{
    get
    {
        if (guarantorDateOfBirth != null)
        {
            return guarantorDateOfBirth;
        }

        guarantorDateOfBirth = new HL7V22Field
        {
            field = message[@"GT1"][8],
            Id = @"GT1.8",
            Type = @"Field",
            Position = @"GT1.8",
            Name = @"Guarantor Date Of Birth",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"guarantor's date of birth",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorDateOfBirth.field.FieldRepetitions != null && guarantorDateOfBirth.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorDateOfBirth.Id));
            guarantorDateOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorDateOfBirth, fieldData);
        }

        return guarantorDateOfBirth;
    } 
}

internal HL7V22Field guarantorSex;

public HL7V22Field GuarantorSex
{
    get
    {
        if (guarantorSex != null)
        {
            return guarantorSex;
        }

        guarantorSex = new HL7V22Field
        {
            field = message[@"GT1"][9],
            Id = @"GT1.9",
            Type = @"Field",
            Position = @"GT1.9",
            Name = @"Guarantor Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0001",
            TableName = @"SEX",
            Description = @"refer to table 0001 - sex for valid entries",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorSex.field.FieldRepetitions != null && guarantorSex.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorSex.Id));
            guarantorSex.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorSex, fieldData);
        }

        return guarantorSex;
    } 
}

internal HL7V22Field guarantorType;

public HL7V22Field GuarantorType
{
    get
    {
        if (guarantorType != null)
        {
            return guarantorType;
        }

        guarantorType = new HL7V22Field
        {
            field = message[@"GT1"][10],
            Id = @"GT1.10",
            Type = @"Field",
            Position = @"GT1.10",
            Name = @"Guarantor Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0068",
            TableName = @"GUARANTOR TYPE",
            Description = @"type of guarantor, e.g., individual, institution, etc.  Refer to user-defined table 0068 - guarantor type",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorType.field.FieldRepetitions != null && guarantorType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorType.Id));
            guarantorType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorType, fieldData);
        }

        return guarantorType;
    } 
}

internal HL7V22Field guarantorRelationship;

public HL7V22Field GuarantorRelationship
{
    get
    {
        if (guarantorRelationship != null)
        {
            return guarantorRelationship;
        }

        guarantorRelationship = new HL7V22Field
        {
            field = message[@"GT1"][11],
            Id = @"GT1.11",
            Type = @"Field",
            Position = @"GT1.11",
            Name = @"Guarantor Relationship",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0063",
            TableName = @"RELATIONSHIP",
            Description = @"relationship of the guarantor with the patient, e.g., parent, child, etc.  Refer to user-defined table 0063 - guarantor relationship",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorRelationship.field.FieldRepetitions != null && guarantorRelationship.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorRelationship.Id));
            guarantorRelationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorRelationship, fieldData);
        }

        return guarantorRelationship;
    } 
}

internal HL7V22Field guarantorSocialSecurityNumber;

public HL7V22Field GuarantorSocialSecurityNumber
{
    get
    {
        if (guarantorSocialSecurityNumber != null)
        {
            return guarantorSocialSecurityNumber;
        }

        guarantorSocialSecurityNumber = new HL7V22Field
        {
            field = message[@"GT1"][12],
            Id = @"GT1.12",
            Type = @"Field",
            Position = @"GT1.12",
            Name = @"Guarantor Social Security Number",
            Length = 11,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"guarantor's social security number",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorSocialSecurityNumber.field.FieldRepetitions != null && guarantorSocialSecurityNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorSocialSecurityNumber.Id));
            guarantorSocialSecurityNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorSocialSecurityNumber, fieldData);
        }

        return guarantorSocialSecurityNumber;
    } 
}

internal HL7V22Field guarantorDateBegin;

public HL7V22Field GuarantorDateBegin
{
    get
    {
        if (guarantorDateBegin != null)
        {
            return guarantorDateBegin;
        }

        guarantorDateBegin = new HL7V22Field
        {
            field = message[@"GT1"][13],
            Id = @"GT1.13",
            Type = @"Field",
            Position = @"GT1.13",
            Name = @"Guarantor Date - Begin",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date the guarantor becomes responsible for the patient's account",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorDateBegin.field.FieldRepetitions != null && guarantorDateBegin.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorDateBegin.Id));
            guarantorDateBegin.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorDateBegin, fieldData);
        }

        return guarantorDateBegin;
    } 
}

internal HL7V22Field guarantorDateEnd;

public HL7V22Field GuarantorDateEnd
{
    get
    {
        if (guarantorDateEnd != null)
        {
            return guarantorDateEnd;
        }

        guarantorDateEnd = new HL7V22Field
        {
            field = message[@"GT1"][14],
            Id = @"GT1.14",
            Type = @"Field",
            Position = @"GT1.14",
            Name = @"Guarantor Date - End",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date the guarantor stops being responsible for the patient's account",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorDateEnd.field.FieldRepetitions != null && guarantorDateEnd.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorDateEnd.Id));
            guarantorDateEnd.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorDateEnd, fieldData);
        }

        return guarantorDateEnd;
    } 
}

internal HL7V22Field guarantorPriority;

public HL7V22Field GuarantorPriority
{
    get
    {
        if (guarantorPriority != null)
        {
            return guarantorPriority;
        }

        guarantorPriority = new HL7V22Field
        {
            field = message[@"GT1"][15],
            Id = @"GT1.15",
            Type = @"Field",
            Position = @"GT1.15",
            Name = @"Guarantor Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"used to determine the order in which the guarantors will be responsible for the patient's account",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorPriority.field.FieldRepetitions != null && guarantorPriority.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorPriority.Id));
            guarantorPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorPriority, fieldData);
        }

        return guarantorPriority;
    } 
}

internal HL7V22Field guarantorEmployerName;

public HL7V22Field GuarantorEmployerName
{
    get
    {
        if (guarantorEmployerName != null)
        {
            return guarantorEmployerName;
        }

        guarantorEmployerName = new HL7V22Field
        {
            field = message[@"GT1"][16],
            Id = @"GT1.16",
            Type = @"Field",
            Position = @"GT1.16",
            Name = @"Guarantor Employer Name",
            Length = 45,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"name of the guarantor's employer",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorEmployerName.field.FieldRepetitions != null && guarantorEmployerName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorEmployerName.Id));
            guarantorEmployerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorEmployerName, fieldData);
        }

        return guarantorEmployerName;
    } 
}

internal HL7V22Field guarantorEmployerAddress;

public HL7V22Field GuarantorEmployerAddress
{
    get
    {
        if (guarantorEmployerAddress != null)
        {
            return guarantorEmployerAddress;
        }

        guarantorEmployerAddress = new HL7V22Field
        {
            field = message[@"GT1"][17],
            Id = @"GT1.17",
            Type = @"Field",
            Position = @"GT1.17",
            Name = @"Guarantor Employer Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @" guarantor's employer's address",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorEmployerAddress.field.FieldRepetitions != null && guarantorEmployerAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorEmployerAddress.Id));
            guarantorEmployerAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorEmployerAddress, fieldData);
        }

        return guarantorEmployerAddress;
    } 
}

internal HL7V22Field guarantorEmployPhoneNumber;

public HL7V22Field GuarantorEmployPhoneNumber
{
    get
    {
        if (guarantorEmployPhoneNumber != null)
        {
            return guarantorEmployPhoneNumber;
        }

        guarantorEmployPhoneNumber = new HL7V22Field
        {
            field = message[@"GT1"][18],
            Id = @"GT1.18",
            Type = @"Field",
            Position = @"GT1.18",
            Name = @"Guarantor Employ Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"guarantor's employer phone number",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorEmployPhoneNumber.field.FieldRepetitions != null && guarantorEmployPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorEmployPhoneNumber.Id));
            guarantorEmployPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorEmployPhoneNumber, fieldData);
        }

        return guarantorEmployPhoneNumber;
    } 
}

internal HL7V22Field guarantorEmployeeIdNumber;

public HL7V22Field GuarantorEmployeeIdNumber
{
    get
    {
        if (guarantorEmployeeIdNumber != null)
        {
            return guarantorEmployeeIdNumber;
        }

        guarantorEmployeeIdNumber = new HL7V22Field
        {
            field = message[@"GT1"][19],
            Id = @"GT1.19",
            Type = @"Field",
            Position = @"GT1.19",
            Name = @"Guarantor Employee Id Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"guarantor's employee number",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorEmployeeIdNumber.field.FieldRepetitions != null && guarantorEmployeeIdNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorEmployeeIdNumber.Id));
            guarantorEmployeeIdNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorEmployeeIdNumber, fieldData);
        }

        return guarantorEmployeeIdNumber;
    } 
}

internal HL7V22Field guarantorEmploymentStatus;

public HL7V22Field GuarantorEmploymentStatus
{
    get
    {
        if (guarantorEmploymentStatus != null)
        {
            return guarantorEmploymentStatus;
        }

        guarantorEmploymentStatus = new HL7V22Field
        {
            field = message[@"GT1"][20],
            Id = @"GT1.20",
            Type = @"Field",
            Position = @"GT1.20",
            Name = @"Guarantor Employment Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0066",
            TableName = @"EMPLOYMENT STATUS",
            Description = @"code that indicates the guarantor's employment status. e.g., Full Time, Part Time, Self Employed, etc.  Refer to user-defined table 0066 - employment status",
            Sample = @"",
        };

        // check for repetitions
        if (guarantorEmploymentStatus.field.FieldRepetitions != null && guarantorEmploymentStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorEmploymentStatus.Id));
            guarantorEmploymentStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorEmploymentStatus, fieldData);
        }

        return guarantorEmploymentStatus;
    } 
}

internal HL7V22Field guarantorOrganization;

public HL7V22Field GuarantorOrganization
{
    get
    {
        if (guarantorOrganization != null)
        {
            return guarantorOrganization;
        }

        guarantorOrganization = new HL7V22Field
        {
            field = message[@"GT1"][21],
            Id = @"GT1.21",
            Type = @"Field",
            Position = @"GT1.21",
            Name = @"Guarantor Organization",
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

        // check for repetitions
        if (guarantorOrganization.field.FieldRepetitions != null && guarantorOrganization.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorOrganization.Id));
            guarantorOrganization.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(guarantorOrganization, fieldData);
        }

        return guarantorOrganization;
    } 
}
    }
}
