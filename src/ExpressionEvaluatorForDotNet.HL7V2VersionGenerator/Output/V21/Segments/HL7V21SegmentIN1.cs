using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentIN1
    {
        public HL7V2Message message { get; init; }

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

        // check for repetitions
        if (setIdInsurance.field.FieldRepetitions != null && setIdInsurance.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdInsurance.Id));
            setIdInsurance.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(setIdInsurance, fieldData);
        }

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

        // check for repetitions
        if (insurancePlanId.field.FieldRepetitions != null && insurancePlanId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insurancePlanId.Id));
            insurancePlanId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insurancePlanId, fieldData);
        }

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

        // check for repetitions
        if (insuranceCompanyId.field.FieldRepetitions != null && insuranceCompanyId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuranceCompanyId.Id));
            insuranceCompanyId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuranceCompanyId, fieldData);
        }

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

        // check for repetitions
        if (insuranceCompanyName.field.FieldRepetitions != null && insuranceCompanyName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuranceCompanyName.Id));
            insuranceCompanyName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuranceCompanyName, fieldData);
        }

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

        // check for repetitions
        if (insuranceCompanyAddress.field.FieldRepetitions != null && insuranceCompanyAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuranceCompanyAddress.Id));
            insuranceCompanyAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuranceCompanyAddress, fieldData);
        }

        return insuranceCompanyAddress;
    } 
}

internal HL7V21Field insuranceCoContactPers;

public HL7V21Field InsuranceCoContactPers
{
    get
    {
        if (insuranceCoContactPers != null)
        {
            return insuranceCoContactPers;
        }

        insuranceCoContactPers = new HL7V21Field
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

        // check for repetitions
        if (insuranceCoContactPers.field.FieldRepetitions != null && insuranceCoContactPers.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuranceCoContactPers.Id));
            insuranceCoContactPers.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuranceCoContactPers, fieldData);
        }

        return insuranceCoContactPers;
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

        // check for repetitions
        if (insuranceCoPhoneNumber.field.FieldRepetitions != null && insuranceCoPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuranceCoPhoneNumber.Id));
            insuranceCoPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuranceCoPhoneNumber, fieldData);
        }

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

        // check for repetitions
        if (groupNumber.field.FieldRepetitions != null && groupNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(groupNumber.Id));
            groupNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(groupNumber, fieldData);
        }

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

        // check for repetitions
        if (groupName.field.FieldRepetitions != null && groupName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(groupName.Id));
            groupName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(groupName, fieldData);
        }

        return groupName;
    } 
}

internal HL7V21Field insuredsGroupEmpId;

public HL7V21Field InsuredsGroupEmpId
{
    get
    {
        if (insuredsGroupEmpId != null)
        {
            return insuredsGroupEmpId;
        }

        insuredsGroupEmpId = new HL7V21Field
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

        // check for repetitions
        if (insuredsGroupEmpId.field.FieldRepetitions != null && insuredsGroupEmpId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuredsGroupEmpId.Id));
            insuredsGroupEmpId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuredsGroupEmpId, fieldData);
        }

        return insuredsGroupEmpId;
    } 
}

internal HL7V21Field insuredsGroupEmpName;

public HL7V21Field InsuredsGroupEmpName
{
    get
    {
        if (insuredsGroupEmpName != null)
        {
            return insuredsGroupEmpName;
        }

        insuredsGroupEmpName = new HL7V21Field
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

        // check for repetitions
        if (insuredsGroupEmpName.field.FieldRepetitions != null && insuredsGroupEmpName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuredsGroupEmpName.Id));
            insuredsGroupEmpName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuredsGroupEmpName, fieldData);
        }

        return insuredsGroupEmpName;
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

        // check for repetitions
        if (planEffectiveDate.field.FieldRepetitions != null && planEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(planEffectiveDate.Id));
            planEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(planEffectiveDate, fieldData);
        }

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

        // check for repetitions
        if (planExpirationDate.field.FieldRepetitions != null && planExpirationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(planExpirationDate.Id));
            planExpirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(planExpirationDate, fieldData);
        }

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

        // check for repetitions
        if (authorizationInformation.field.FieldRepetitions != null && authorizationInformation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(authorizationInformation.Id));
            authorizationInformation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(authorizationInformation, fieldData);
        }

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

        // check for repetitions
        if (planType.field.FieldRepetitions != null && planType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(planType.Id));
            planType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(planType, fieldData);
        }

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

        // check for repetitions
        if (nameOfInsured.field.FieldRepetitions != null && nameOfInsured.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nameOfInsured.Id));
            nameOfInsured.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(nameOfInsured, fieldData);
        }

        return nameOfInsured;
    } 
}

internal HL7V21Field insuredsRelationshipToPatient;

public HL7V21Field InsuredsRelationshipToPatient
{
    get
    {
        if (insuredsRelationshipToPatient != null)
        {
            return insuredsRelationshipToPatient;
        }

        insuredsRelationshipToPatient = new HL7V21Field
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

        // check for repetitions
        if (insuredsRelationshipToPatient.field.FieldRepetitions != null && insuredsRelationshipToPatient.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuredsRelationshipToPatient.Id));
            insuredsRelationshipToPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuredsRelationshipToPatient, fieldData);
        }

        return insuredsRelationshipToPatient;
    } 
}

internal HL7V21Field insuredsDateOfBirth;

public HL7V21Field InsuredsDateOfBirth
{
    get
    {
        if (insuredsDateOfBirth != null)
        {
            return insuredsDateOfBirth;
        }

        insuredsDateOfBirth = new HL7V21Field
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

        // check for repetitions
        if (insuredsDateOfBirth.field.FieldRepetitions != null && insuredsDateOfBirth.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuredsDateOfBirth.Id));
            insuredsDateOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuredsDateOfBirth, fieldData);
        }

        return insuredsDateOfBirth;
    } 
}

internal HL7V21Field insuredsAddress;

public HL7V21Field InsuredsAddress
{
    get
    {
        if (insuredsAddress != null)
        {
            return insuredsAddress;
        }

        insuredsAddress = new HL7V21Field
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

        // check for repetitions
        if (insuredsAddress.field.FieldRepetitions != null && insuredsAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuredsAddress.Id));
            insuredsAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuredsAddress, fieldData);
        }

        return insuredsAddress;
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

        // check for repetitions
        if (assignmentOfBenefits.field.FieldRepetitions != null && assignmentOfBenefits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(assignmentOfBenefits.Id));
            assignmentOfBenefits.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(assignmentOfBenefits, fieldData);
        }

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

        // check for repetitions
        if (coordinationOfBenefits.field.FieldRepetitions != null && coordinationOfBenefits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(coordinationOfBenefits.Id));
            coordinationOfBenefits.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(coordinationOfBenefits, fieldData);
        }

        return coordinationOfBenefits;
    } 
}

internal HL7V21Field coordOfBenPriority;

public HL7V21Field CoordOfBenPriority
{
    get
    {
        if (coordOfBenPriority != null)
        {
            return coordOfBenPriority;
        }

        coordOfBenPriority = new HL7V21Field
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

        // check for repetitions
        if (coordOfBenPriority.field.FieldRepetitions != null && coordOfBenPriority.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(coordOfBenPriority.Id));
            coordOfBenPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(coordOfBenPriority, fieldData);
        }

        return coordOfBenPriority;
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

        // check for repetitions
        if (noticeOfAdmissionCode.field.FieldRepetitions != null && noticeOfAdmissionCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(noticeOfAdmissionCode.Id));
            noticeOfAdmissionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(noticeOfAdmissionCode, fieldData);
        }

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

        // check for repetitions
        if (noticeOfAdmissionDate.field.FieldRepetitions != null && noticeOfAdmissionDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(noticeOfAdmissionDate.Id));
            noticeOfAdmissionDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(noticeOfAdmissionDate, fieldData);
        }

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

        // check for repetitions
        if (rptOfEligibilityCode.field.FieldRepetitions != null && rptOfEligibilityCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rptOfEligibilityCode.Id));
            rptOfEligibilityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(rptOfEligibilityCode, fieldData);
        }

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

        // check for repetitions
        if (rptOfEligibilityDate.field.FieldRepetitions != null && rptOfEligibilityDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rptOfEligibilityDate.Id));
            rptOfEligibilityDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(rptOfEligibilityDate, fieldData);
        }

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

        // check for repetitions
        if (releaseInformationCode.field.FieldRepetitions != null && releaseInformationCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(releaseInformationCode.Id));
            releaseInformationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(releaseInformationCode, fieldData);
        }

        return releaseInformationCode;
    } 
}

internal HL7V21Field preadmitCertpac;

public HL7V21Field PreadmitCertpac
{
    get
    {
        if (preadmitCertpac != null)
        {
            return preadmitCertpac;
        }

        preadmitCertpac = new HL7V21Field
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

        // check for repetitions
        if (preadmitCertpac.field.FieldRepetitions != null && preadmitCertpac.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(preadmitCertpac.Id));
            preadmitCertpac.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(preadmitCertpac, fieldData);
        }

        return preadmitCertpac;
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

        // check for repetitions
        if (verificationDate.field.FieldRepetitions != null && verificationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(verificationDate.Id));
            verificationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(verificationDate, fieldData);
        }

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

        // check for repetitions
        if (verificationBy.field.FieldRepetitions != null && verificationBy.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(verificationBy.Id));
            verificationBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(verificationBy, fieldData);
        }

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

        // check for repetitions
        if (typeOfAgreementCode.field.FieldRepetitions != null && typeOfAgreementCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(typeOfAgreementCode.Id));
            typeOfAgreementCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(typeOfAgreementCode, fieldData);
        }

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

        // check for repetitions
        if (billingStatus.field.FieldRepetitions != null && billingStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(billingStatus.Id));
            billingStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(billingStatus, fieldData);
        }

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

        // check for repetitions
        if (lifetimeReserveDays.field.FieldRepetitions != null && lifetimeReserveDays.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(lifetimeReserveDays.Id));
            lifetimeReserveDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(lifetimeReserveDays, fieldData);
        }

        return lifetimeReserveDays;
    } 
}

internal HL7V21Field delayBeforeLRDay;

public HL7V21Field DelayBeforeLRDay
{
    get
    {
        if (delayBeforeLRDay != null)
        {
            return delayBeforeLRDay;
        }

        delayBeforeLRDay = new HL7V21Field
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

        // check for repetitions
        if (delayBeforeLRDay.field.FieldRepetitions != null && delayBeforeLRDay.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(delayBeforeLRDay.Id));
            delayBeforeLRDay.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(delayBeforeLRDay, fieldData);
        }

        return delayBeforeLRDay;
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

        // check for repetitions
        if (companyPlanCode.field.FieldRepetitions != null && companyPlanCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(companyPlanCode.Id));
            companyPlanCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(companyPlanCode, fieldData);
        }

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

        // check for repetitions
        if (policyNumber.field.FieldRepetitions != null && policyNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(policyNumber.Id));
            policyNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(policyNumber, fieldData);
        }

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

        // check for repetitions
        if (policyDeductible.field.FieldRepetitions != null && policyDeductible.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(policyDeductible.Id));
            policyDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(policyDeductible, fieldData);
        }

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

        // check for repetitions
        if (policyLimitAmount.field.FieldRepetitions != null && policyLimitAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(policyLimitAmount.Id));
            policyLimitAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(policyLimitAmount, fieldData);
        }

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

        // check for repetitions
        if (policyLimitDays.field.FieldRepetitions != null && policyLimitDays.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(policyLimitDays.Id));
            policyLimitDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(policyLimitDays, fieldData);
        }

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

        // check for repetitions
        if (roomRateSemiprivate.field.FieldRepetitions != null && roomRateSemiprivate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(roomRateSemiprivate.Id));
            roomRateSemiprivate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(roomRateSemiprivate, fieldData);
        }

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

        // check for repetitions
        if (roomRatePrivate.field.FieldRepetitions != null && roomRatePrivate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(roomRatePrivate.Id));
            roomRatePrivate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(roomRatePrivate, fieldData);
        }

        return roomRatePrivate;
    } 
}

internal HL7V21Field insuredsEmploymentStatus;

public HL7V21Field InsuredsEmploymentStatus
{
    get
    {
        if (insuredsEmploymentStatus != null)
        {
            return insuredsEmploymentStatus;
        }

        insuredsEmploymentStatus = new HL7V21Field
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

        // check for repetitions
        if (insuredsEmploymentStatus.field.FieldRepetitions != null && insuredsEmploymentStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuredsEmploymentStatus.Id));
            insuredsEmploymentStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuredsEmploymentStatus, fieldData);
        }

        return insuredsEmploymentStatus;
    } 
}

internal HL7V21Field insuredsSex;

public HL7V21Field InsuredsSex
{
    get
    {
        if (insuredsSex != null)
        {
            return insuredsSex;
        }

        insuredsSex = new HL7V21Field
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

        // check for repetitions
        if (insuredsSex.field.FieldRepetitions != null && insuredsSex.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuredsSex.Id));
            insuredsSex.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuredsSex, fieldData);
        }

        return insuredsSex;
    } 
}

internal HL7V21Field insuredsEmployerAddress;

public HL7V21Field InsuredsEmployerAddress
{
    get
    {
        if (insuredsEmployerAddress != null)
        {
            return insuredsEmployerAddress;
        }

        insuredsEmployerAddress = new HL7V21Field
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

        // check for repetitions
        if (insuredsEmployerAddress.field.FieldRepetitions != null && insuredsEmployerAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuredsEmployerAddress.Id));
            insuredsEmployerAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(insuredsEmployerAddress, fieldData);
        }

        return insuredsEmployerAddress;
    } 
}
    }
}
