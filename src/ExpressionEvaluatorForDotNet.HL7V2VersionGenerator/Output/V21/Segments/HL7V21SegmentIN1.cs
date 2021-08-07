using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentIN1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"IN1"; } }

        public string SegmentId { get { return @"IN1"; } }
        
        public string LongName { get { return @"Insurance"; } }
        
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
                            Id = @"IN1.1",
                            Type = @"Field",
                            Position = @"IN1.1",
                            Name = @"Set Id - Insurance",
                            Length = 4,
                            Usage = @"R",
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
                            Id = @"IN1.2",
                            Type = @"Field",
                            Position = @"IN1.2",
                            Name = @"Insurance Plan Id",
                            Length = 8,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0072",
                            TableName = @"INS. PLAN ID",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3",
                            Type = @"Field",
                            Position = @"IN1.3",
                            Name = @"Insurance Company Id",
                            Length = 6,
                            Usage = @"R",
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
                            Id = @"IN1.4",
                            Type = @"Field",
                            Position = @"IN1.4",
                            Name = @"Insurance Company Name",
                            Length = 45,
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
                            Id = @"IN1.5",
                            Type = @"Field",
                            Position = @"IN1.5",
                            Name = @"Insurance Company Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6",
                            Type = @"Field",
                            Position = @"IN1.6",
                            Name = @"Insurance Co. Contact Pers",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.7",
                            Type = @"Field",
                            Position = @"IN1.7",
                            Name = @"Insurance Co Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
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
                            Id = @"IN1.8",
                            Type = @"Field",
                            Position = @"IN1.8",
                            Name = @"Group Number",
                            Length = 12,
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
                            Id = @"IN1.9",
                            Type = @"Field",
                            Position = @"IN1.9",
                            Name = @"Group Name",
                            Length = 35,
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
                            Id = @"IN1.10",
                            Type = @"Field",
                            Position = @"IN1.10",
                            Name = @"Insured's Group Emp. Id",
                            Length = 12,
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
                            Id = @"IN1.11",
                            Type = @"Field",
                            Position = @"IN1.11",
                            Name = @"Insured's Group Emp. Name",
                            Length = 45,
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
                            Id = @"IN1.12",
                            Type = @"Field",
                            Position = @"IN1.12",
                            Name = @"Plan Effective Date",
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
                            Id = @"IN1.13",
                            Type = @"Field",
                            Position = @"IN1.13",
                            Name = @"Plan Expiration Date",
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
                            Id = @"IN1.14",
                            Type = @"Field",
                            Position = @"IN1.14",
                            Name = @"Authorization Information",
                            Length = 55,
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
                            Id = @"IN1.15",
                            Type = @"Field",
                            Position = @"IN1.15",
                            Name = @"Plan Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0086",
                            TableName = @"INS. PLAN TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16",
                            Type = @"Field",
                            Position = @"IN1.16",
                            Name = @"Name Of Insured",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.17",
                            Type = @"Field",
                            Position = @"IN1.17",
                            Name = @"Insured's Relationship To Patient",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0063",
                            TableName = @"RELATIONSHIP",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.18",
                            Type = @"Field",
                            Position = @"IN1.18",
                            Name = @"Insured's Date Of Birth",
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
                            Id = @"IN1.19",
                            Type = @"Field",
                            Position = @"IN1.19",
                            Name = @"Insured's Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.20",
                            Type = @"Field",
                            Position = @"IN1.20",
                            Name = @"Assignment Of Benefits",
                            Length = 2,
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
                            Id = @"IN1.21",
                            Type = @"Field",
                            Position = @"IN1.21",
                            Name = @"Coordination Of Benefits",
                            Length = 2,
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
                            Id = @"IN1.22",
                            Type = @"Field",
                            Position = @"IN1.22",
                            Name = @"Coord Of Ben. Priority",
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
                            Id = @"IN1.23",
                            Type = @"Field",
                            Position = @"IN1.23",
                            Name = @"Notice Of Admission Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0081",
                            TableName = @"NOTICE OF ADMISSION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.24",
                            Type = @"Field",
                            Position = @"IN1.24",
                            Name = @"Notice Of Admission Date",
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
                            Id = @"IN1.25",
                            Type = @"Field",
                            Position = @"IN1.25",
                            Name = @"Rpt Of Eligibility Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0094",
                            TableName = @"REPORT OF ELIGIBILITY",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.26",
                            Type = @"Field",
                            Position = @"IN1.26",
                            Name = @"Rpt Of Eligibility Date",
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
                            Id = @"IN1.27",
                            Type = @"Field",
                            Position = @"IN1.27",
                            Name = @"Release Information Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0093",
                            TableName = @"RELEASE OF INFORMATION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.28",
                            Type = @"Field",
                            Position = @"IN1.28",
                            Name = @"Pre-admit Cert. (pac)",
                            Length = 15,
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
                            Id = @"IN1.29",
                            Type = @"Field",
                            Position = @"IN1.29",
                            Name = @"Verification Date",
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
                            Id = @"IN1.30",
                            Type = @"Field",
                            Position = @"IN1.30",
                            Name = @"Verification By",
                            Length = 60,
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
                            Id = @"IN1.31",
                            Type = @"Field",
                            Position = @"IN1.31",
                            Name = @"Type Of Agreement Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0098",
                            TableName = @"TYPE OF AGREEMENT CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.32",
                            Type = @"Field",
                            Position = @"IN1.32",
                            Name = @"Billing Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0022",
                            TableName = @"BILLING STATUS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.33",
                            Type = @"Field",
                            Position = @"IN1.33",
                            Name = @"Lifetime Reserve Days",
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
                            Id = @"IN1.34",
                            Type = @"Field",
                            Position = @"IN1.34",
                            Name = @"Delay Before L. R. Day",
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
                            Id = @"IN1.35",
                            Type = @"Field",
                            Position = @"IN1.35",
                            Name = @"Company Plan Code",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0042",
                            TableName = @"INS. COMPANY PLAN CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.36",
                            Type = @"Field",
                            Position = @"IN1.36",
                            Name = @"Policy Number",
                            Length = 15,
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
                            Id = @"IN1.37",
                            Type = @"Field",
                            Position = @"IN1.37",
                            Name = @"Policy Deductible",
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
                            Id = @"IN1.38",
                            Type = @"Field",
                            Position = @"IN1.38",
                            Name = @"Policy Limit - Amount",
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
                            Id = @"IN1.39",
                            Type = @"Field",
                            Position = @"IN1.39",
                            Name = @"Policy Limit - Days",
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
                            Id = @"IN1.40",
                            Type = @"Field",
                            Position = @"IN1.40",
                            Name = @"Room Rate - Semi-private",
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
                            Id = @"IN1.41",
                            Type = @"Field",
                            Position = @"IN1.41",
                            Name = @"Room Rate - Private",
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
                            Id = @"IN1.42",
                            Type = @"Field",
                            Position = @"IN1.42",
                            Name = @"Insured's Employment Status",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0066",
                            TableName = @"EMPLOYMENT STATUS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.43",
                            Type = @"Field",
                            Position = @"IN1.43",
                            Name = @"Insured's Sex",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0001",
                            TableName = @"SEX",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44",
                            Type = @"Field",
                            Position = @"IN1.44",
                            Name = @"Insured's Employer Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentIN1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field setIdInsurance;

public HL7V21Field SetIdInsurance
{
    get
    {
        if (setIdInsurance != null)
        {
            return setIdInsurance;
        }

        setIdInsurance = new HL7V21Field
        {
            field = message[@"IN1"][1],
            Id = @"IN1.1",
            Type = @"Field",
            Position = @"IN1.1",
            Name = @"Set Id - Insurance",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return setIdInsurance;
    } 
}
internal HL7V21Field insurancePlanId;

public HL7V21Field InsurancePlanId
{
    get
    {
        if (insurancePlanId != null)
        {
            return insurancePlanId;
        }

        insurancePlanId = new HL7V21Field
        {
            field = message[@"IN1"][2],
            Id = @"IN1.2",
            Type = @"Field",
            Position = @"IN1.2",
            Name = @"Insurance Plan Id",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0072",
            TableName = @"INS. PLAN ID",
            Description = null,
            Sample = @"",
        };

        

        

        

        return insurancePlanId;
    } 
}
internal HL7V21Field insuranceCompanyId;

public HL7V21Field InsuranceCompanyId
{
    get
    {
        if (insuranceCompanyId != null)
        {
            return insuranceCompanyId;
        }

        insuranceCompanyId = new HL7V21Field
        {
            field = message[@"IN1"][3],
            Id = @"IN1.3",
            Type = @"Field",
            Position = @"IN1.3",
            Name = @"Insurance Company Id",
            Length = 6,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return insuranceCompanyId;
    } 
}
internal HL7V21Field insuranceCompanyName;

public HL7V21Field InsuranceCompanyName
{
    get
    {
        if (insuranceCompanyName != null)
        {
            return insuranceCompanyName;
        }

        insuranceCompanyName = new HL7V21Field
        {
            field = message[@"IN1"][4],
            Id = @"IN1.4",
            Type = @"Field",
            Position = @"IN1.4",
            Name = @"Insurance Company Name",
            Length = 45,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return insuranceCompanyName;
    } 
}
internal HL7V21Field insuranceCompanyAddress;

public HL7V21Field InsuranceCompanyAddress
{
    get
    {
        if (insuranceCompanyAddress != null)
        {
            return insuranceCompanyAddress;
        }

        insuranceCompanyAddress = new HL7V21Field
        {
            field = message[@"IN1"][5],
            Id = @"IN1.5",
            Type = @"Field",
            Position = @"IN1.5",
            Name = @"Insurance Company Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return insuranceCompanyAddress;
    } 
}
internal HL7V21Field insuranceCo.ContactPers;

public HL7V21Field InsuranceCo.ContactPers
{
    get
    {
        if (insuranceCo.ContactPers != null)
        {
            return insuranceCo.ContactPers;
        }

        insuranceCo.ContactPers = new HL7V21Field
        {
            field = message[@"IN1"][6],
            Id = @"IN1.6",
            Type = @"Field",
            Position = @"IN1.6",
            Name = @"Insurance Co. Contact Pers",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return insuranceCo.ContactPers;
    } 
}
internal HL7V21Field insuranceCoPhoneNumber;

public HL7V21Field InsuranceCoPhoneNumber
{
    get
    {
        if (insuranceCoPhoneNumber != null)
        {
            return insuranceCoPhoneNumber;
        }

        insuranceCoPhoneNumber = new HL7V21Field
        {
            field = message[@"IN1"][7],
            Id = @"IN1.7",
            Type = @"Field",
            Position = @"IN1.7",
            Name = @"Insurance Co Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return insuranceCoPhoneNumber;
    } 
}
internal HL7V21Field groupNumber;

public HL7V21Field GroupNumber
{
    get
    {
        if (groupNumber != null)
        {
            return groupNumber;
        }

        groupNumber = new HL7V21Field
        {
            field = message[@"IN1"][8],
            Id = @"IN1.8",
            Type = @"Field",
            Position = @"IN1.8",
            Name = @"Group Number",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return groupNumber;
    } 
}
internal HL7V21Field groupName;

public HL7V21Field GroupName
{
    get
    {
        if (groupName != null)
        {
            return groupName;
        }

        groupName = new HL7V21Field
        {
            field = message[@"IN1"][9],
            Id = @"IN1.9",
            Type = @"Field",
            Position = @"IN1.9",
            Name = @"Group Name",
            Length = 35,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return groupName;
    } 
}
internal HL7V21Field insured'sGroupEmp.Id;

public HL7V21Field Insured'sGroupEmp.Id
{
    get
    {
        if (insured'sGroupEmp.Id != null)
        {
            return insured'sGroupEmp.Id;
        }

        insured'sGroupEmp.Id = new HL7V21Field
        {
            field = message[@"IN1"][10],
            Id = @"IN1.10",
            Type = @"Field",
            Position = @"IN1.10",
            Name = @"Insured's Group Emp. Id",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return insured'sGroupEmp.Id;
    } 
}
internal HL7V21Field insured'sGroupEmp.Name;

public HL7V21Field Insured'sGroupEmp.Name
{
    get
    {
        if (insured'sGroupEmp.Name != null)
        {
            return insured'sGroupEmp.Name;
        }

        insured'sGroupEmp.Name = new HL7V21Field
        {
            field = message[@"IN1"][11],
            Id = @"IN1.11",
            Type = @"Field",
            Position = @"IN1.11",
            Name = @"Insured's Group Emp. Name",
            Length = 45,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return insured'sGroupEmp.Name;
    } 
}
internal HL7V21Field planEffectiveDate;

public HL7V21Field PlanEffectiveDate
{
    get
    {
        if (planEffectiveDate != null)
        {
            return planEffectiveDate;
        }

        planEffectiveDate = new HL7V21Field
        {
            field = message[@"IN1"][12],
            Id = @"IN1.12",
            Type = @"Field",
            Position = @"IN1.12",
            Name = @"Plan Effective Date",
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

        

        

        

        return planEffectiveDate;
    } 
}
internal HL7V21Field planExpirationDate;

public HL7V21Field PlanExpirationDate
{
    get
    {
        if (planExpirationDate != null)
        {
            return planExpirationDate;
        }

        planExpirationDate = new HL7V21Field
        {
            field = message[@"IN1"][13],
            Id = @"IN1.13",
            Type = @"Field",
            Position = @"IN1.13",
            Name = @"Plan Expiration Date",
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

        

        

        

        return planExpirationDate;
    } 
}
internal HL7V21Field authorizationInformation;

public HL7V21Field AuthorizationInformation
{
    get
    {
        if (authorizationInformation != null)
        {
            return authorizationInformation;
        }

        authorizationInformation = new HL7V21Field
        {
            field = message[@"IN1"][14],
            Id = @"IN1.14",
            Type = @"Field",
            Position = @"IN1.14",
            Name = @"Authorization Information",
            Length = 55,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return authorizationInformation;
    } 
}
internal HL7V21Field planType;

public HL7V21Field PlanType
{
    get
    {
        if (planType != null)
        {
            return planType;
        }

        planType = new HL7V21Field
        {
            field = message[@"IN1"][15],
            Id = @"IN1.15",
            Type = @"Field",
            Position = @"IN1.15",
            Name = @"Plan Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0086",
            TableName = @"INS. PLAN TYPE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return planType;
    } 
}
internal HL7V21Field nameOfInsured;

public HL7V21Field NameOfInsured
{
    get
    {
        if (nameOfInsured != null)
        {
            return nameOfInsured;
        }

        nameOfInsured = new HL7V21Field
        {
            field = message[@"IN1"][16],
            Id = @"IN1.16",
            Type = @"Field",
            Position = @"IN1.16",
            Name = @"Name Of Insured",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return nameOfInsured;
    } 
}
internal HL7V21Field insured'sRelationshipToPatient;

public HL7V21Field Insured'sRelationshipToPatient
{
    get
    {
        if (insured'sRelationshipToPatient != null)
        {
            return insured'sRelationshipToPatient;
        }

        insured'sRelationshipToPatient = new HL7V21Field
        {
            field = message[@"IN1"][17],
            Id = @"IN1.17",
            Type = @"Field",
            Position = @"IN1.17",
            Name = @"Insured's Relationship To Patient",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0063",
            TableName = @"RELATIONSHIP",
            Description = null,
            Sample = @"",
        };

        

        

        

        return insured'sRelationshipToPatient;
    } 
}
internal HL7V21Field insured'sDateOfBirth;

public HL7V21Field Insured'sDateOfBirth
{
    get
    {
        if (insured'sDateOfBirth != null)
        {
            return insured'sDateOfBirth;
        }

        insured'sDateOfBirth = new HL7V21Field
        {
            field = message[@"IN1"][18],
            Id = @"IN1.18",
            Type = @"Field",
            Position = @"IN1.18",
            Name = @"Insured's Date Of Birth",
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

        

        

        

        return insured'sDateOfBirth;
    } 
}
internal HL7V21Field insured'sAddress;

public HL7V21Field Insured'sAddress
{
    get
    {
        if (insured'sAddress != null)
        {
            return insured'sAddress;
        }

        insured'sAddress = new HL7V21Field
        {
            field = message[@"IN1"][19],
            Id = @"IN1.19",
            Type = @"Field",
            Position = @"IN1.19",
            Name = @"Insured's Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return insured'sAddress;
    } 
}
internal HL7V21Field assignmentOfBenefits;

public HL7V21Field AssignmentOfBenefits
{
    get
    {
        if (assignmentOfBenefits != null)
        {
            return assignmentOfBenefits;
        }

        assignmentOfBenefits = new HL7V21Field
        {
            field = message[@"IN1"][20],
            Id = @"IN1.20",
            Type = @"Field",
            Position = @"IN1.20",
            Name = @"Assignment Of Benefits",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return assignmentOfBenefits;
    } 
}
internal HL7V21Field coordinationOfBenefits;

public HL7V21Field CoordinationOfBenefits
{
    get
    {
        if (coordinationOfBenefits != null)
        {
            return coordinationOfBenefits;
        }

        coordinationOfBenefits = new HL7V21Field
        {
            field = message[@"IN1"][21],
            Id = @"IN1.21",
            Type = @"Field",
            Position = @"IN1.21",
            Name = @"Coordination Of Benefits",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return coordinationOfBenefits;
    } 
}
internal HL7V21Field coordOfBen.Priority;

public HL7V21Field CoordOfBen.Priority
{
    get
    {
        if (coordOfBen.Priority != null)
        {
            return coordOfBen.Priority;
        }

        coordOfBen.Priority = new HL7V21Field
        {
            field = message[@"IN1"][22],
            Id = @"IN1.22",
            Type = @"Field",
            Position = @"IN1.22",
            Name = @"Coord Of Ben. Priority",
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

        

        

        

        return coordOfBen.Priority;
    } 
}
internal HL7V21Field noticeOfAdmissionCode;

public HL7V21Field NoticeOfAdmissionCode
{
    get
    {
        if (noticeOfAdmissionCode != null)
        {
            return noticeOfAdmissionCode;
        }

        noticeOfAdmissionCode = new HL7V21Field
        {
            field = message[@"IN1"][23],
            Id = @"IN1.23",
            Type = @"Field",
            Position = @"IN1.23",
            Name = @"Notice Of Admission Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0081",
            TableName = @"NOTICE OF ADMISSION",
            Description = null,
            Sample = @"",
        };

        

        

        

        return noticeOfAdmissionCode;
    } 
}
internal HL7V21Field noticeOfAdmissionDate;

public HL7V21Field NoticeOfAdmissionDate
{
    get
    {
        if (noticeOfAdmissionDate != null)
        {
            return noticeOfAdmissionDate;
        }

        noticeOfAdmissionDate = new HL7V21Field
        {
            field = message[@"IN1"][24],
            Id = @"IN1.24",
            Type = @"Field",
            Position = @"IN1.24",
            Name = @"Notice Of Admission Date",
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

        

        

        

        return noticeOfAdmissionDate;
    } 
}
internal HL7V21Field rptOfEligibilityCode;

public HL7V21Field RptOfEligibilityCode
{
    get
    {
        if (rptOfEligibilityCode != null)
        {
            return rptOfEligibilityCode;
        }

        rptOfEligibilityCode = new HL7V21Field
        {
            field = message[@"IN1"][25],
            Id = @"IN1.25",
            Type = @"Field",
            Position = @"IN1.25",
            Name = @"Rpt Of Eligibility Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0094",
            TableName = @"REPORT OF ELIGIBILITY",
            Description = null,
            Sample = @"",
        };

        

        

        

        return rptOfEligibilityCode;
    } 
}
internal HL7V21Field rptOfEligibilityDate;

public HL7V21Field RptOfEligibilityDate
{
    get
    {
        if (rptOfEligibilityDate != null)
        {
            return rptOfEligibilityDate;
        }

        rptOfEligibilityDate = new HL7V21Field
        {
            field = message[@"IN1"][26],
            Id = @"IN1.26",
            Type = @"Field",
            Position = @"IN1.26",
            Name = @"Rpt Of Eligibility Date",
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

        

        

        

        return rptOfEligibilityDate;
    } 
}
internal HL7V21Field releaseInformationCode;

public HL7V21Field ReleaseInformationCode
{
    get
    {
        if (releaseInformationCode != null)
        {
            return releaseInformationCode;
        }

        releaseInformationCode = new HL7V21Field
        {
            field = message[@"IN1"][27],
            Id = @"IN1.27",
            Type = @"Field",
            Position = @"IN1.27",
            Name = @"Release Information Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0093",
            TableName = @"RELEASE OF INFORMATION",
            Description = null,
            Sample = @"",
        };

        

        

        

        return releaseInformationCode;
    } 
}
internal HL7V21Field preadmitCert.(pac);

public HL7V21Field PreadmitCert.(pac)
{
    get
    {
        if (preadmitCert.(pac) != null)
        {
            return preadmitCert.(pac);
        }

        preadmitCert.(pac) = new HL7V21Field
        {
            field = message[@"IN1"][28],
            Id = @"IN1.28",
            Type = @"Field",
            Position = @"IN1.28",
            Name = @"Pre-admit Cert. (pac)",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return preadmitCert.(pac);
    } 
}
internal HL7V21Field verificationDate;

public HL7V21Field VerificationDate
{
    get
    {
        if (verificationDate != null)
        {
            return verificationDate;
        }

        verificationDate = new HL7V21Field
        {
            field = message[@"IN1"][29],
            Id = @"IN1.29",
            Type = @"Field",
            Position = @"IN1.29",
            Name = @"Verification Date",
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

        

        

        

        return verificationDate;
    } 
}
internal HL7V21Field verificationBy;

public HL7V21Field VerificationBy
{
    get
    {
        if (verificationBy != null)
        {
            return verificationBy;
        }

        verificationBy = new HL7V21Field
        {
            field = message[@"IN1"][30],
            Id = @"IN1.30",
            Type = @"Field",
            Position = @"IN1.30",
            Name = @"Verification By",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return verificationBy;
    } 
}
internal HL7V21Field typeOfAgreementCode;

public HL7V21Field TypeOfAgreementCode
{
    get
    {
        if (typeOfAgreementCode != null)
        {
            return typeOfAgreementCode;
        }

        typeOfAgreementCode = new HL7V21Field
        {
            field = message[@"IN1"][31],
            Id = @"IN1.31",
            Type = @"Field",
            Position = @"IN1.31",
            Name = @"Type Of Agreement Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0098",
            TableName = @"TYPE OF AGREEMENT CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return typeOfAgreementCode;
    } 
}
internal HL7V21Field billingStatus;

public HL7V21Field BillingStatus
{
    get
    {
        if (billingStatus != null)
        {
            return billingStatus;
        }

        billingStatus = new HL7V21Field
        {
            field = message[@"IN1"][32],
            Id = @"IN1.32",
            Type = @"Field",
            Position = @"IN1.32",
            Name = @"Billing Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0022",
            TableName = @"BILLING STATUS",
            Description = null,
            Sample = @"",
        };

        

        

        

        return billingStatus;
    } 
}
internal HL7V21Field lifetimeReserveDays;

public HL7V21Field LifetimeReserveDays
{
    get
    {
        if (lifetimeReserveDays != null)
        {
            return lifetimeReserveDays;
        }

        lifetimeReserveDays = new HL7V21Field
        {
            field = message[@"IN1"][33],
            Id = @"IN1.33",
            Type = @"Field",
            Position = @"IN1.33",
            Name = @"Lifetime Reserve Days",
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

        

        

        

        return lifetimeReserveDays;
    } 
}
internal HL7V21Field delayBeforeL.R.Day;

public HL7V21Field DelayBeforeL.R.Day
{
    get
    {
        if (delayBeforeL.R.Day != null)
        {
            return delayBeforeL.R.Day;
        }

        delayBeforeL.R.Day = new HL7V21Field
        {
            field = message[@"IN1"][34],
            Id = @"IN1.34",
            Type = @"Field",
            Position = @"IN1.34",
            Name = @"Delay Before L. R. Day",
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

        

        

        

        return delayBeforeL.R.Day;
    } 
}
internal HL7V21Field companyPlanCode;

public HL7V21Field CompanyPlanCode
{
    get
    {
        if (companyPlanCode != null)
        {
            return companyPlanCode;
        }

        companyPlanCode = new HL7V21Field
        {
            field = message[@"IN1"][35],
            Id = @"IN1.35",
            Type = @"Field",
            Position = @"IN1.35",
            Name = @"Company Plan Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0042",
            TableName = @"INS. COMPANY PLAN CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return companyPlanCode;
    } 
}
internal HL7V21Field policyNumber;

public HL7V21Field PolicyNumber
{
    get
    {
        if (policyNumber != null)
        {
            return policyNumber;
        }

        policyNumber = new HL7V21Field
        {
            field = message[@"IN1"][36],
            Id = @"IN1.36",
            Type = @"Field",
            Position = @"IN1.36",
            Name = @"Policy Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return policyNumber;
    } 
}
internal HL7V21Field policyDeductible;

public HL7V21Field PolicyDeductible
{
    get
    {
        if (policyDeductible != null)
        {
            return policyDeductible;
        }

        policyDeductible = new HL7V21Field
        {
            field = message[@"IN1"][37],
            Id = @"IN1.37",
            Type = @"Field",
            Position = @"IN1.37",
            Name = @"Policy Deductible",
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

        

        

        

        return policyDeductible;
    } 
}
internal HL7V21Field policyLimitAmount;

public HL7V21Field PolicyLimitAmount
{
    get
    {
        if (policyLimitAmount != null)
        {
            return policyLimitAmount;
        }

        policyLimitAmount = new HL7V21Field
        {
            field = message[@"IN1"][38],
            Id = @"IN1.38",
            Type = @"Field",
            Position = @"IN1.38",
            Name = @"Policy Limit - Amount",
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

        

        

        

        return policyLimitAmount;
    } 
}
internal HL7V21Field policyLimitDays;

public HL7V21Field PolicyLimitDays
{
    get
    {
        if (policyLimitDays != null)
        {
            return policyLimitDays;
        }

        policyLimitDays = new HL7V21Field
        {
            field = message[@"IN1"][39],
            Id = @"IN1.39",
            Type = @"Field",
            Position = @"IN1.39",
            Name = @"Policy Limit - Days",
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

        

        

        

        return policyLimitDays;
    } 
}
internal HL7V21Field roomRateSemiprivate;

public HL7V21Field RoomRateSemiprivate
{
    get
    {
        if (roomRateSemiprivate != null)
        {
            return roomRateSemiprivate;
        }

        roomRateSemiprivate = new HL7V21Field
        {
            field = message[@"IN1"][40],
            Id = @"IN1.40",
            Type = @"Field",
            Position = @"IN1.40",
            Name = @"Room Rate - Semi-private",
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

        

        

        

        return roomRateSemiprivate;
    } 
}
internal HL7V21Field roomRatePrivate;

public HL7V21Field RoomRatePrivate
{
    get
    {
        if (roomRatePrivate != null)
        {
            return roomRatePrivate;
        }

        roomRatePrivate = new HL7V21Field
        {
            field = message[@"IN1"][41],
            Id = @"IN1.41",
            Type = @"Field",
            Position = @"IN1.41",
            Name = @"Room Rate - Private",
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

        

        

        

        return roomRatePrivate;
    } 
}
internal HL7V21Field insured'sEmploymentStatus;

public HL7V21Field Insured'sEmploymentStatus
{
    get
    {
        if (insured'sEmploymentStatus != null)
        {
            return insured'sEmploymentStatus;
        }

        insured'sEmploymentStatus = new HL7V21Field
        {
            field = message[@"IN1"][42],
            Id = @"IN1.42",
            Type = @"Field",
            Position = @"IN1.42",
            Name = @"Insured's Employment Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0066",
            TableName = @"EMPLOYMENT STATUS",
            Description = null,
            Sample = @"",
        };

        

        

        

        return insured'sEmploymentStatus;
    } 
}
internal HL7V21Field insured'sSex;

public HL7V21Field Insured'sSex
{
    get
    {
        if (insured'sSex != null)
        {
            return insured'sSex;
        }

        insured'sSex = new HL7V21Field
        {
            field = message[@"IN1"][43],
            Id = @"IN1.43",
            Type = @"Field",
            Position = @"IN1.43",
            Name = @"Insured's Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0001",
            TableName = @"SEX",
            Description = null,
            Sample = @"",
        };

        

        

        

        return insured'sSex;
    } 
}
internal HL7V21Field insured'sEmployerAddress;

public HL7V21Field Insured'sEmployerAddress
{
    get
    {
        if (insured'sEmployerAddress != null)
        {
            return insured'sEmployerAddress;
        }

        insured'sEmployerAddress = new HL7V21Field
        {
            field = message[@"IN1"][44],
            Id = @"IN1.44",
            Type = @"Field",
            Position = @"IN1.44",
            Name = @"Insured's Employer Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return insured'sEmployerAddress;
    } 
}

    }
}
