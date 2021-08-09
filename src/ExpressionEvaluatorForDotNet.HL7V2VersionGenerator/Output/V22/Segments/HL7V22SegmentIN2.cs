using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentIN2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IN2"; } }

        public string SegmentId { get { return @"IN2"; } }
        
        public string LongName { get { return @"Insurance Additional Info"; } }
        
        public string Description { get { return @"The IN2 segment contains additional insurance policy coverage and benefit information necessary for proper billing and reimbursement.  Fields used by this segment are defined by HICFA or other regulatory agencies."; } }
        
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
                            Id = @"IN2.1",
                            Type = @"Field",
                            Position = @"IN2.1",
                            Name = @"Insured's Employee Id",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"employee ID of insured",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.2",
                            Type = @"Field",
                            Position = @"IN2.2",
                            Name = @"Insured's Social Security Number",
                            Length = 9,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"social security number of insured",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3",
                            Type = @"Field",
                            Position = @"IN2.3",
                            Name = @"Insured's Employer Name",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"name of insured's employer",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.3.1",
                            Type = @"Component",
                            Position = @"IN2.3.1",
                            Name = @"Id Number",
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
                            Id = @"IN2.3.2",
                            Type = @"Component",
                            Position = @"IN2.3.2",
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
                            Id = @"IN2.3.3",
                            Type = @"Component",
                            Position = @"IN2.3.3",
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
                            Id = @"IN2.3.4",
                            Type = @"Component",
                            Position = @"IN2.3.4",
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
                            Id = @"IN2.3.5",
                            Type = @"Component",
                            Position = @"IN2.3.5",
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
                            Id = @"IN2.3.6",
                            Type = @"Component",
                            Position = @"IN2.3.6",
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
                            Id = @"IN2.3.7",
                            Type = @"Component",
                            Position = @"IN2.3.7",
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
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.8",
                            Type = @"Component",
                            Position = @"IN2.3.8",
                            Name = @"Source Table Id",
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
                            Id = @"IN2.4",
                            Type = @"Field",
                            Position = @"IN2.4",
                            Name = @"Employer Information Data",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0139",
                            TableName = @"EMPLOYER INFORMATION DATA",
                            Description = @"required employer information data for UB82 form locator 71.  Refer to user-defined table 0139 - employer information data for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.5",
                            Type = @"Field",
                            Position = @"IN2.5",
                            Name = @"Mail Claim Party",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0137",
                            TableName = @"MAIL CLAIM PARTY",
                            Description = @"party to which the claim should be mailed",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.6",
                            Type = @"Field",
                            Position = @"IN2.6",
                            Name = @"Medicare Health Insurance Card Number",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"this field is defined by HCFA or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.7",
                            Type = @"Field",
                            Position = @"IN2.7",
                            Name = @"Medicaid Case Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"this field is defined by HCFA or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.7.1",
                            Type = @"Component",
                            Position = @"IN2.7.1",
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
                            Id = @"IN2.7.2",
                            Type = @"Component",
                            Position = @"IN2.7.2",
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
                            Id = @"IN2.7.3",
                            Type = @"Component",
                            Position = @"IN2.7.3",
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
                            Id = @"IN2.7.4",
                            Type = @"Component",
                            Position = @"IN2.7.4",
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
                            Id = @"IN2.7.5",
                            Type = @"Component",
                            Position = @"IN2.7.5",
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
                            Id = @"IN2.7.6",
                            Type = @"Component",
                            Position = @"IN2.7.6",
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
                            Id = @"IN2.8",
                            Type = @"Field",
                            Position = @"IN2.8",
                            Name = @"Medicaid Case Number",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"this field is defined by HCFA or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.9",
                            Type = @"Field",
                            Position = @"IN2.9",
                            Name = @"Champus Sponsor Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"this field is defined by HCFA or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.9.1",
                            Type = @"Component",
                            Position = @"IN2.9.1",
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
                            Id = @"IN2.9.2",
                            Type = @"Component",
                            Position = @"IN2.9.2",
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
                            Id = @"IN2.9.3",
                            Type = @"Component",
                            Position = @"IN2.9.3",
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
                            Id = @"IN2.9.4",
                            Type = @"Component",
                            Position = @"IN2.9.4",
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
                            Id = @"IN2.9.5",
                            Type = @"Component",
                            Position = @"IN2.9.5",
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
                            Id = @"IN2.9.6",
                            Type = @"Component",
                            Position = @"IN2.9.6",
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
                            Id = @"IN2.10",
                            Type = @"Field",
                            Position = @"IN2.10",
                            Name = @"Champus Id Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"this field is defined by HCFA or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.11",
                            Type = @"Field",
                            Position = @"IN2.11",
                            Name = @"Dependent Of Champus Recipient",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"defined by HCFA or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.12",
                            Type = @"Field",
                            Position = @"IN2.12",
                            Name = @"Champus Organization",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"defined by HCFA or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.13",
                            Type = @"Field",
                            Position = @"IN2.13",
                            Name = @"Champus Station",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"defined by HCFA or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.14",
                            Type = @"Field",
                            Position = @"IN2.14",
                            Name = @"Champus Service",
                            Length = 14,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0140",
                            TableName = @"CHAMPUS SERVICE",
                            Description = @"defined by HCFA or other regulatory agencies.  Refer to table 0140 - Champus service for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.15",
                            Type = @"Field",
                            Position = @"IN2.15",
                            Name = @"Champus Rank / Grade",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0141",
                            TableName = @"CHAMPUS RANK/GRADE",
                            Description = @"This user-defined field identifies the CHAMPUS military rank/grade of the insured.  Refer to table 0141 - Champus rank/grade for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.16",
                            Type = @"Field",
                            Position = @"IN2.16",
                            Name = @"Champus Status",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0142",
                            TableName = @"CHAMPUS STATE",
                            Description = @"defined by HCFA or other regulatory agencies.  Refer to table 0142 - Champus status for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.17",
                            Type = @"Field",
                            Position = @"IN2.17",
                            Name = @"Champus Retire Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"defined by HCFA or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.18",
                            Type = @"Field",
                            Position = @"IN2.18",
                            Name = @"Champus Non-availability Certification On File",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = @"refer to table 0136 - Y/N indicator",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.19",
                            Type = @"Field",
                            Position = @"IN2.19",
                            Name = @"Baby Coverage",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = @"refer to table 0136 - Y/N indicator",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.20",
                            Type = @"Field",
                            Position = @"IN2.20",
                            Name = @"Combine Baby Bill",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = @"refer to table 0136 - Y/N indicator",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.21",
                            Type = @"Field",
                            Position = @"IN2.21",
                            Name = @"Blood Deductible",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"it is recommended that this field be used instead of UB2-2-blood deductible as the blood deductible can be associated with the specific insurance plan via this field",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.22",
                            Type = @"Field",
                            Position = @"IN2.22",
                            Name = @"Special Coverage Approval Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"name of the individual that approves any special coverage",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.22.1",
                            Type = @"Component",
                            Position = @"IN2.22.1",
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
                            Id = @"IN2.22.2",
                            Type = @"Component",
                            Position = @"IN2.22.2",
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
                            Id = @"IN2.22.3",
                            Type = @"Component",
                            Position = @"IN2.22.3",
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
                            Id = @"IN2.22.4",
                            Type = @"Component",
                            Position = @"IN2.22.4",
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
                            Id = @"IN2.22.5",
                            Type = @"Component",
                            Position = @"IN2.22.5",
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
                            Id = @"IN2.22.6",
                            Type = @"Component",
                            Position = @"IN2.22.6",
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
                            Id = @"IN2.23",
                            Type = @"Field",
                            Position = @"IN2.23",
                            Name = @"Special Coverage Approval Title",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"title of the person that approves special coverage",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.24",
                            Type = @"Field",
                            Position = @"IN2.24",
                            Name = @"Non-covered Insurance Code",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0143",
                            TableName = @"NON-COVEREDINSURANCE CODE",
                            Description = @"code which describes why a service is not covered.  Refer to user-defined table 0143 - non-covered insurance code for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25",
                            Type = @"Field",
                            Position = @"IN2.25",
                            Name = @"Payor Id",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"required for NEIC processing, identifies the organization from which reimbursement is expected",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26",
                            Type = @"Field",
                            Position = @"IN2.26",
                            Name = @"Payor Subscriber Id",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"required for NEIC processing, identifies the specific office within the insurance carrier designated as responsible for the claim",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.27",
                            Type = @"Field",
                            Position = @"IN2.27",
                            Name = @"Eligibility Source",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0144",
                            TableName = @"ELIGIBILITY SOURCE",
                            Description = @"required for NEIC processing, identifies the source of information about the insured's eligibility for benefits.  Refer to user-defined table 0144 - eligibility source for suggested entries",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.28",
                            Type = @"Field",
                            Position = @"IN2.28",
                            Name = @"Room Coverage Type / Amount",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_RMC",
                            DataTypeName = @"Room Coverage",
                            TableId = null,
                            TableName = null,
                            Description = @"room type (e.g., private, semi-private) and amount (e.g., rate, percentage, differential) covered by the insurance.  It is recommended that this field be used instead of IN1-40-room rate - semi-private and IN141-room rate - private.  Refer to user-defined tables 0145 - room type and 0146 - amount type for suggested entries",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.28.1",
                            Type = @"Component",
                            Position = @"IN2.28.1",
                            Name = @"Room Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0145",
                            TableName = @"ROOM TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.28.2",
                            Type = @"Component",
                            Position = @"IN2.28.2",
                            Name = @"Amount Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0146",
                            TableName = @"AMOUNT TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.28.3",
                            Type = @"Component",
                            Position = @"IN2.28.3",
                            Name = @"Coverage Amount",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.29",
                            Type = @"Field",
                            Position = @"IN2.29",
                            Name = @"Policy Type / Amount",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_PTA",
                            DataTypeName = @"Policy Type",
                            TableId = null,
                            TableName = null,
                            Description = @"policy type (e.g., ancillary, major medical) and amount (e.g., amount, percentage, limit) covered by the insurance.  It is recommended that this field is used instead of IN1-38-policy limit - amount.  Refer to userdefined tables 0147 - policy type and 0193 - amount class for suggested entries",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.29.1",
                            Type = @"Component",
                            Position = @"IN2.29.1",
                            Name = @"Policy Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0147",
                            TableName = @"POLICY TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.29.2",
                            Type = @"Component",
                            Position = @"IN2.29.2",
                            Name = @"Amount Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0193",
                            TableName = @"AMOUNT CLASS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.29.3",
                            Type = @"Component",
                            Position = @"IN2.29.3",
                            Name = @"Amount",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.30",
                            Type = @"Field",
                            Position = @"IN2.30",
                            Name = @"Daily Deductible",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_DDI",
                            DataTypeName = @"Daily Deductible",
                            TableId = null,
                            TableName = null,
                            Description = @"number of days after which to begin the daily deductible, the amount of the deductible, and the number of days to apply the deductible",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.30.1",
                            Type = @"Component",
                            Position = @"IN2.30.1",
                            Name = @"Delay Days",
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
                            Id = @"IN2.30.2",
                            Type = @"Component",
                            Position = @"IN2.30.2",
                            Name = @"Amount",
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
                            Id = @"IN2.30.3",
                            Type = @"Component",
                            Position = @"IN2.30.3",
                            Name = @"Number Of Days",
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
                        },}
                        },
                        };
            }
        }

        public HL7V22SegmentIN2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field insuredsEmployeeId;

public HL7V22Field InsuredsEmployeeId
{
    get
    {
        if (insuredsEmployeeId != null)
        {
            return insuredsEmployeeId;
        }

        insuredsEmployeeId = new HL7V22Field
        {
            field = message[@"IN2"][1],
            Id = @"IN2.1",
            Type = @"Field",
            Position = @"IN2.1",
            Name = @"Insured's Employee Id",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"employee ID of insured",
            Sample = @"",
        };

        // check for repetitions
        if (insuredsEmployeeId.field.FieldRepetitions != null && insuredsEmployeeId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuredsEmployeeId.Id));
            insuredsEmployeeId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(insuredsEmployeeId, fieldData);
        }

        return insuredsEmployeeId;
    } 
}

internal HL7V22Field insuredsSocialSecurityNumber;

public HL7V22Field InsuredsSocialSecurityNumber
{
    get
    {
        if (insuredsSocialSecurityNumber != null)
        {
            return insuredsSocialSecurityNumber;
        }

        insuredsSocialSecurityNumber = new HL7V22Field
        {
            field = message[@"IN2"][2],
            Id = @"IN2.2",
            Type = @"Field",
            Position = @"IN2.2",
            Name = @"Insured's Social Security Number",
            Length = 9,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"social security number of insured",
            Sample = @"",
        };

        // check for repetitions
        if (insuredsSocialSecurityNumber.field.FieldRepetitions != null && insuredsSocialSecurityNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuredsSocialSecurityNumber.Id));
            insuredsSocialSecurityNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(insuredsSocialSecurityNumber, fieldData);
        }

        return insuredsSocialSecurityNumber;
    } 
}

internal HL7V22Field insuredsEmployerName;

public HL7V22Field InsuredsEmployerName
{
    get
    {
        if (insuredsEmployerName != null)
        {
            return insuredsEmployerName;
        }

        insuredsEmployerName = new HL7V22Field
        {
            field = message[@"IN2"][3],
            Id = @"IN2.3",
            Type = @"Field",
            Position = @"IN2.3",
            Name = @"Insured's Employer Name",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"name of insured's employer",
            Sample = @"",
        };

        // check for repetitions
        if (insuredsEmployerName.field.FieldRepetitions != null && insuredsEmployerName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuredsEmployerName.Id));
            insuredsEmployerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(insuredsEmployerName, fieldData);
        }

        return insuredsEmployerName;
    } 
}

internal HL7V22Field employerInformationData;

public HL7V22Field EmployerInformationData
{
    get
    {
        if (employerInformationData != null)
        {
            return employerInformationData;
        }

        employerInformationData = new HL7V22Field
        {
            field = message[@"IN2"][4],
            Id = @"IN2.4",
            Type = @"Field",
            Position = @"IN2.4",
            Name = @"Employer Information Data",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0139",
            TableName = @"EMPLOYER INFORMATION DATA",
            Description = @"required employer information data for UB82 form locator 71.  Refer to user-defined table 0139 - employer information data for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (employerInformationData.field.FieldRepetitions != null && employerInformationData.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(employerInformationData.Id));
            employerInformationData.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(employerInformationData, fieldData);
        }

        return employerInformationData;
    } 
}

internal HL7V22Field mailClaimParty;

public HL7V22Field MailClaimParty
{
    get
    {
        if (mailClaimParty != null)
        {
            return mailClaimParty;
        }

        mailClaimParty = new HL7V22Field
        {
            field = message[@"IN2"][5],
            Id = @"IN2.5",
            Type = @"Field",
            Position = @"IN2.5",
            Name = @"Mail Claim Party",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0137",
            TableName = @"MAIL CLAIM PARTY",
            Description = @"party to which the claim should be mailed",
            Sample = @"",
        };

        // check for repetitions
        if (mailClaimParty.field.FieldRepetitions != null && mailClaimParty.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(mailClaimParty.Id));
            mailClaimParty.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(mailClaimParty, fieldData);
        }

        return mailClaimParty;
    } 
}

internal HL7V22Field medicareHealthInsuranceCardNumber;

public HL7V22Field MedicareHealthInsuranceCardNumber
{
    get
    {
        if (medicareHealthInsuranceCardNumber != null)
        {
            return medicareHealthInsuranceCardNumber;
        }

        medicareHealthInsuranceCardNumber = new HL7V22Field
        {
            field = message[@"IN2"][6],
            Id = @"IN2.6",
            Type = @"Field",
            Position = @"IN2.6",
            Name = @"Medicare Health Insurance Card Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"this field is defined by HCFA or other regulatory agencies",
            Sample = @"",
        };

        // check for repetitions
        if (medicareHealthInsuranceCardNumber.field.FieldRepetitions != null && medicareHealthInsuranceCardNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(medicareHealthInsuranceCardNumber.Id));
            medicareHealthInsuranceCardNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(medicareHealthInsuranceCardNumber, fieldData);
        }

        return medicareHealthInsuranceCardNumber;
    } 
}

internal HL7V22Field medicaidCaseName;

public HL7V22Field MedicaidCaseName
{
    get
    {
        if (medicaidCaseName != null)
        {
            return medicaidCaseName;
        }

        medicaidCaseName = new HL7V22Field
        {
            field = message[@"IN2"][7],
            Id = @"IN2.7",
            Type = @"Field",
            Position = @"IN2.7",
            Name = @"Medicaid Case Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"this field is defined by HCFA or other regulatory agencies",
            Sample = @"",
        };

        // check for repetitions
        if (medicaidCaseName.field.FieldRepetitions != null && medicaidCaseName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(medicaidCaseName.Id));
            medicaidCaseName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(medicaidCaseName, fieldData);
        }

        return medicaidCaseName;
    } 
}

internal HL7V22Field medicaidCaseNumber;

public HL7V22Field MedicaidCaseNumber
{
    get
    {
        if (medicaidCaseNumber != null)
        {
            return medicaidCaseNumber;
        }

        medicaidCaseNumber = new HL7V22Field
        {
            field = message[@"IN2"][8],
            Id = @"IN2.8",
            Type = @"Field",
            Position = @"IN2.8",
            Name = @"Medicaid Case Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"this field is defined by HCFA or other regulatory agencies",
            Sample = @"",
        };

        // check for repetitions
        if (medicaidCaseNumber.field.FieldRepetitions != null && medicaidCaseNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(medicaidCaseNumber.Id));
            medicaidCaseNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(medicaidCaseNumber, fieldData);
        }

        return medicaidCaseNumber;
    } 
}

internal HL7V22Field champusSponsorName;

public HL7V22Field ChampusSponsorName
{
    get
    {
        if (champusSponsorName != null)
        {
            return champusSponsorName;
        }

        champusSponsorName = new HL7V22Field
        {
            field = message[@"IN2"][9],
            Id = @"IN2.9",
            Type = @"Field",
            Position = @"IN2.9",
            Name = @"Champus Sponsor Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"this field is defined by HCFA or other regulatory agencies",
            Sample = @"",
        };

        // check for repetitions
        if (champusSponsorName.field.FieldRepetitions != null && champusSponsorName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(champusSponsorName.Id));
            champusSponsorName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(champusSponsorName, fieldData);
        }

        return champusSponsorName;
    } 
}

internal HL7V22Field champusIdNumber;

public HL7V22Field ChampusIdNumber
{
    get
    {
        if (champusIdNumber != null)
        {
            return champusIdNumber;
        }

        champusIdNumber = new HL7V22Field
        {
            field = message[@"IN2"][10],
            Id = @"IN2.10",
            Type = @"Field",
            Position = @"IN2.10",
            Name = @"Champus Id Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"this field is defined by HCFA or other regulatory agencies",
            Sample = @"",
        };

        // check for repetitions
        if (champusIdNumber.field.FieldRepetitions != null && champusIdNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(champusIdNumber.Id));
            champusIdNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(champusIdNumber, fieldData);
        }

        return champusIdNumber;
    } 
}

internal HL7V22Field dependentOfChampusRecipient;

public HL7V22Field DependentOfChampusRecipient
{
    get
    {
        if (dependentOfChampusRecipient != null)
        {
            return dependentOfChampusRecipient;
        }

        dependentOfChampusRecipient = new HL7V22Field
        {
            field = message[@"IN2"][11],
            Id = @"IN2.11",
            Type = @"Field",
            Position = @"IN2.11",
            Name = @"Dependent Of Champus Recipient",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"defined by HCFA or other regulatory agencies",
            Sample = @"",
        };

        // check for repetitions
        if (dependentOfChampusRecipient.field.FieldRepetitions != null && dependentOfChampusRecipient.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dependentOfChampusRecipient.Id));
            dependentOfChampusRecipient.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dependentOfChampusRecipient, fieldData);
        }

        return dependentOfChampusRecipient;
    } 
}

internal HL7V22Field champusOrganization;

public HL7V22Field ChampusOrganization
{
    get
    {
        if (champusOrganization != null)
        {
            return champusOrganization;
        }

        champusOrganization = new HL7V22Field
        {
            field = message[@"IN2"][12],
            Id = @"IN2.12",
            Type = @"Field",
            Position = @"IN2.12",
            Name = @"Champus Organization",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by HCFA or other regulatory agencies",
            Sample = @"",
        };

        // check for repetitions
        if (champusOrganization.field.FieldRepetitions != null && champusOrganization.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(champusOrganization.Id));
            champusOrganization.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(champusOrganization, fieldData);
        }

        return champusOrganization;
    } 
}

internal HL7V22Field champusStation;

public HL7V22Field ChampusStation
{
    get
    {
        if (champusStation != null)
        {
            return champusStation;
        }

        champusStation = new HL7V22Field
        {
            field = message[@"IN2"][13],
            Id = @"IN2.13",
            Type = @"Field",
            Position = @"IN2.13",
            Name = @"Champus Station",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by HCFA or other regulatory agencies",
            Sample = @"",
        };

        // check for repetitions
        if (champusStation.field.FieldRepetitions != null && champusStation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(champusStation.Id));
            champusStation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(champusStation, fieldData);
        }

        return champusStation;
    } 
}

internal HL7V22Field champusService;

public HL7V22Field ChampusService
{
    get
    {
        if (champusService != null)
        {
            return champusService;
        }

        champusService = new HL7V22Field
        {
            field = message[@"IN2"][14],
            Id = @"IN2.14",
            Type = @"Field",
            Position = @"IN2.14",
            Name = @"Champus Service",
            Length = 14,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0140",
            TableName = @"CHAMPUS SERVICE",
            Description = @"defined by HCFA or other regulatory agencies.  Refer to table 0140 - Champus service for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (champusService.field.FieldRepetitions != null && champusService.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(champusService.Id));
            champusService.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(champusService, fieldData);
        }

        return champusService;
    } 
}

internal HL7V22Field champusRankGrade;

public HL7V22Field ChampusRankGrade
{
    get
    {
        if (champusRankGrade != null)
        {
            return champusRankGrade;
        }

        champusRankGrade = new HL7V22Field
        {
            field = message[@"IN2"][15],
            Id = @"IN2.15",
            Type = @"Field",
            Position = @"IN2.15",
            Name = @"Champus Rank / Grade",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0141",
            TableName = @"CHAMPUS RANK/GRADE",
            Description = @"This user-defined field identifies the CHAMPUS military rank/grade of the insured.  Refer to table 0141 - Champus rank/grade for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (champusRankGrade.field.FieldRepetitions != null && champusRankGrade.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(champusRankGrade.Id));
            champusRankGrade.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(champusRankGrade, fieldData);
        }

        return champusRankGrade;
    } 
}

internal HL7V22Field champusStatus;

public HL7V22Field ChampusStatus
{
    get
    {
        if (champusStatus != null)
        {
            return champusStatus;
        }

        champusStatus = new HL7V22Field
        {
            field = message[@"IN2"][16],
            Id = @"IN2.16",
            Type = @"Field",
            Position = @"IN2.16",
            Name = @"Champus Status",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0142",
            TableName = @"CHAMPUS STATE",
            Description = @"defined by HCFA or other regulatory agencies.  Refer to table 0142 - Champus status for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (champusStatus.field.FieldRepetitions != null && champusStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(champusStatus.Id));
            champusStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(champusStatus, fieldData);
        }

        return champusStatus;
    } 
}

internal HL7V22Field champusRetireDate;

public HL7V22Field ChampusRetireDate
{
    get
    {
        if (champusRetireDate != null)
        {
            return champusRetireDate;
        }

        champusRetireDate = new HL7V22Field
        {
            field = message[@"IN2"][17],
            Id = @"IN2.17",
            Type = @"Field",
            Position = @"IN2.17",
            Name = @"Champus Retire Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"defined by HCFA or other regulatory agencies",
            Sample = @"",
        };

        // check for repetitions
        if (champusRetireDate.field.FieldRepetitions != null && champusRetireDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(champusRetireDate.Id));
            champusRetireDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(champusRetireDate, fieldData);
        }

        return champusRetireDate;
    } 
}

internal HL7V22Field champusNonavailabilityCertificationOnFile;

public HL7V22Field ChampusNonavailabilityCertificationOnFile
{
    get
    {
        if (champusNonavailabilityCertificationOnFile != null)
        {
            return champusNonavailabilityCertificationOnFile;
        }

        champusNonavailabilityCertificationOnFile = new HL7V22Field
        {
            field = message[@"IN2"][18],
            Id = @"IN2.18",
            Type = @"Field",
            Position = @"IN2.18",
            Name = @"Champus Non-availability Certification On File",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"refer to table 0136 - Y/N indicator",
            Sample = @"",
        };

        // check for repetitions
        if (champusNonavailabilityCertificationOnFile.field.FieldRepetitions != null && champusNonavailabilityCertificationOnFile.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(champusNonavailabilityCertificationOnFile.Id));
            champusNonavailabilityCertificationOnFile.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(champusNonavailabilityCertificationOnFile, fieldData);
        }

        return champusNonavailabilityCertificationOnFile;
    } 
}

internal HL7V22Field babyCoverage;

public HL7V22Field BabyCoverage
{
    get
    {
        if (babyCoverage != null)
        {
            return babyCoverage;
        }

        babyCoverage = new HL7V22Field
        {
            field = message[@"IN2"][19],
            Id = @"IN2.19",
            Type = @"Field",
            Position = @"IN2.19",
            Name = @"Baby Coverage",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"refer to table 0136 - Y/N indicator",
            Sample = @"",
        };

        // check for repetitions
        if (babyCoverage.field.FieldRepetitions != null && babyCoverage.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(babyCoverage.Id));
            babyCoverage.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(babyCoverage, fieldData);
        }

        return babyCoverage;
    } 
}

internal HL7V22Field combineBabyBill;

public HL7V22Field CombineBabyBill
{
    get
    {
        if (combineBabyBill != null)
        {
            return combineBabyBill;
        }

        combineBabyBill = new HL7V22Field
        {
            field = message[@"IN2"][20],
            Id = @"IN2.20",
            Type = @"Field",
            Position = @"IN2.20",
            Name = @"Combine Baby Bill",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"refer to table 0136 - Y/N indicator",
            Sample = @"",
        };

        // check for repetitions
        if (combineBabyBill.field.FieldRepetitions != null && combineBabyBill.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(combineBabyBill.Id));
            combineBabyBill.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(combineBabyBill, fieldData);
        }

        return combineBabyBill;
    } 
}

internal HL7V22Field bloodDeductible;

public HL7V22Field BloodDeductible
{
    get
    {
        if (bloodDeductible != null)
        {
            return bloodDeductible;
        }

        bloodDeductible = new HL7V22Field
        {
            field = message[@"IN2"][21],
            Id = @"IN2.21",
            Type = @"Field",
            Position = @"IN2.21",
            Name = @"Blood Deductible",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"it is recommended that this field be used instead of UB2-2-blood deductible as the blood deductible can be associated with the specific insurance plan via this field",
            Sample = @"",
        };

        // check for repetitions
        if (bloodDeductible.field.FieldRepetitions != null && bloodDeductible.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(bloodDeductible.Id));
            bloodDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(bloodDeductible, fieldData);
        }

        return bloodDeductible;
    } 
}

internal HL7V22Field specialCoverageApprovalName;

public HL7V22Field SpecialCoverageApprovalName
{
    get
    {
        if (specialCoverageApprovalName != null)
        {
            return specialCoverageApprovalName;
        }

        specialCoverageApprovalName = new HL7V22Field
        {
            field = message[@"IN2"][22],
            Id = @"IN2.22",
            Type = @"Field",
            Position = @"IN2.22",
            Name = @"Special Coverage Approval Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name of the individual that approves any special coverage",
            Sample = @"",
        };

        // check for repetitions
        if (specialCoverageApprovalName.field.FieldRepetitions != null && specialCoverageApprovalName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specialCoverageApprovalName.Id));
            specialCoverageApprovalName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(specialCoverageApprovalName, fieldData);
        }

        return specialCoverageApprovalName;
    } 
}

internal HL7V22Field specialCoverageApprovalTitle;

public HL7V22Field SpecialCoverageApprovalTitle
{
    get
    {
        if (specialCoverageApprovalTitle != null)
        {
            return specialCoverageApprovalTitle;
        }

        specialCoverageApprovalTitle = new HL7V22Field
        {
            field = message[@"IN2"][23],
            Id = @"IN2.23",
            Type = @"Field",
            Position = @"IN2.23",
            Name = @"Special Coverage Approval Title",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"title of the person that approves special coverage",
            Sample = @"",
        };

        // check for repetitions
        if (specialCoverageApprovalTitle.field.FieldRepetitions != null && specialCoverageApprovalTitle.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specialCoverageApprovalTitle.Id));
            specialCoverageApprovalTitle.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(specialCoverageApprovalTitle, fieldData);
        }

        return specialCoverageApprovalTitle;
    } 
}

internal HL7V22Field noncoveredInsuranceCode;

public HL7V22Field NoncoveredInsuranceCode
{
    get
    {
        if (noncoveredInsuranceCode != null)
        {
            return noncoveredInsuranceCode;
        }

        noncoveredInsuranceCode = new HL7V22Field
        {
            field = message[@"IN2"][24],
            Id = @"IN2.24",
            Type = @"Field",
            Position = @"IN2.24",
            Name = @"Non-covered Insurance Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0143",
            TableName = @"NON-COVEREDINSURANCE CODE",
            Description = @"code which describes why a service is not covered.  Refer to user-defined table 0143 - non-covered insurance code for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (noncoveredInsuranceCode.field.FieldRepetitions != null && noncoveredInsuranceCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(noncoveredInsuranceCode.Id));
            noncoveredInsuranceCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(noncoveredInsuranceCode, fieldData);
        }

        return noncoveredInsuranceCode;
    } 
}

internal HL7V22Field payorId;

public HL7V22Field PayorId
{
    get
    {
        if (payorId != null)
        {
            return payorId;
        }

        payorId = new HL7V22Field
        {
            field = message[@"IN2"][25],
            Id = @"IN2.25",
            Type = @"Field",
            Position = @"IN2.25",
            Name = @"Payor Id",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"required for NEIC processing, identifies the organization from which reimbursement is expected",
            Sample = @"",
        };

        // check for repetitions
        if (payorId.field.FieldRepetitions != null && payorId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(payorId.Id));
            payorId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(payorId, fieldData);
        }

        return payorId;
    } 
}

internal HL7V22Field payorSubscriberId;

public HL7V22Field PayorSubscriberId
{
    get
    {
        if (payorSubscriberId != null)
        {
            return payorSubscriberId;
        }

        payorSubscriberId = new HL7V22Field
        {
            field = message[@"IN2"][26],
            Id = @"IN2.26",
            Type = @"Field",
            Position = @"IN2.26",
            Name = @"Payor Subscriber Id",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"required for NEIC processing, identifies the specific office within the insurance carrier designated as responsible for the claim",
            Sample = @"",
        };

        // check for repetitions
        if (payorSubscriberId.field.FieldRepetitions != null && payorSubscriberId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(payorSubscriberId.Id));
            payorSubscriberId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(payorSubscriberId, fieldData);
        }

        return payorSubscriberId;
    } 
}

internal HL7V22Field eligibilitySource;

public HL7V22Field EligibilitySource
{
    get
    {
        if (eligibilitySource != null)
        {
            return eligibilitySource;
        }

        eligibilitySource = new HL7V22Field
        {
            field = message[@"IN2"][27],
            Id = @"IN2.27",
            Type = @"Field",
            Position = @"IN2.27",
            Name = @"Eligibility Source",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0144",
            TableName = @"ELIGIBILITY SOURCE",
            Description = @"required for NEIC processing, identifies the source of information about the insured's eligibility for benefits.  Refer to user-defined table 0144 - eligibility source for suggested entries",
            Sample = @"",
        };

        // check for repetitions
        if (eligibilitySource.field.FieldRepetitions != null && eligibilitySource.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eligibilitySource.Id));
            eligibilitySource.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(eligibilitySource, fieldData);
        }

        return eligibilitySource;
    } 
}

internal HL7V22Field roomCoverageTypeAmount;

public HL7V22Field RoomCoverageTypeAmount
{
    get
    {
        if (roomCoverageTypeAmount != null)
        {
            return roomCoverageTypeAmount;
        }

        roomCoverageTypeAmount = new HL7V22Field
        {
            field = message[@"IN2"][28],
            Id = @"IN2.28",
            Type = @"Field",
            Position = @"IN2.28",
            Name = @"Room Coverage Type / Amount",
            Length = 25,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_RMC",
            DataTypeName = @"Room Coverage",
            TableId = null,
            TableName = null,
            Description = @"room type (e.g., private, semi-private) and amount (e.g., rate, percentage, differential) covered by the insurance.  It is recommended that this field be used instead of IN1-40-room rate - semi-private and IN141-room rate - private.  Refer to user-defined tables 0145 - room type and 0146 - amount type for suggested entries",
            Sample = @"",
        };

        // check for repetitions
        if (roomCoverageTypeAmount.field.FieldRepetitions != null && roomCoverageTypeAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(roomCoverageTypeAmount.Id));
            roomCoverageTypeAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(roomCoverageTypeAmount, fieldData);
        }

        return roomCoverageTypeAmount;
    } 
}

internal HL7V22Field policyTypeAmount;

public HL7V22Field PolicyTypeAmount
{
    get
    {
        if (policyTypeAmount != null)
        {
            return policyTypeAmount;
        }

        policyTypeAmount = new HL7V22Field
        {
            field = message[@"IN2"][29],
            Id = @"IN2.29",
            Type = @"Field",
            Position = @"IN2.29",
            Name = @"Policy Type / Amount",
            Length = 25,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_PTA",
            DataTypeName = @"Policy Type",
            TableId = null,
            TableName = null,
            Description = @"policy type (e.g., ancillary, major medical) and amount (e.g., amount, percentage, limit) covered by the insurance.  It is recommended that this field is used instead of IN1-38-policy limit - amount.  Refer to userdefined tables 0147 - policy type and 0193 - amount class for suggested entries",
            Sample = @"",
        };

        // check for repetitions
        if (policyTypeAmount.field.FieldRepetitions != null && policyTypeAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(policyTypeAmount.Id));
            policyTypeAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(policyTypeAmount, fieldData);
        }

        return policyTypeAmount;
    } 
}

internal HL7V22Field dailyDeductible;

public HL7V22Field DailyDeductible
{
    get
    {
        if (dailyDeductible != null)
        {
            return dailyDeductible;
        }

        dailyDeductible = new HL7V22Field
        {
            field = message[@"IN2"][30],
            Id = @"IN2.30",
            Type = @"Field",
            Position = @"IN2.30",
            Name = @"Daily Deductible",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_DDI",
            DataTypeName = @"Daily Deductible",
            TableId = null,
            TableName = null,
            Description = @"number of days after which to begin the daily deductible, the amount of the deductible, and the number of days to apply the deductible",
            Sample = @"",
        };

        // check for repetitions
        if (dailyDeductible.field.FieldRepetitions != null && dailyDeductible.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dailyDeductible.Id));
            dailyDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dailyDeductible, fieldData);
        }

        return dailyDeductible;
    } 
}
    }
}
