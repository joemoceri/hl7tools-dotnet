using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentGP1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"GP1"; } }

        public string SegmentId { get { return @"GP1"; } }
        
        public string LongName { get { return @"Grouping/Reimbursement - Visit"; } }
        
        public string Description { get { return @"These fields are used in grouping and reimbursement for CMS APCs. Please refer to the ""Outpatient Prospective Payment System Final Rule"" (""OPPS Final Rule"") issued by CMS.

The GP1 segment is specific to the US and may not be implemented in non-US systems."; } }
        
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
                            Id = @"GP1.1",
                            Type = @"Field",
                            Position = @"GP1.1",
                            Name = @"Type of Bill Code",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0455",
                            TableName = @"Type of Bill Code",
                            Description = @"This field is the same as UB92 Form Locator 4 ""Type of Bill"". Refer to User-defined Table 0455 - Type of Bill Code for suggested values. Refer to a UB specification for additional information. This field is defined by CMS or other regulatory agencies. It is a code indicating the specific type of bill with digit 1 showing type of facility, digit 2 showing bill classification, and digit 3 showing frequency.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.2",
                            Type = @"Field",
                            Position = @"GP1.2",
                            Name = @"Revenue Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0456",
                            TableName = @"Revenue code",
                            Description = @"This field is the same as UB92 Form Locator 42 ""Revenue Code"". Refer to User-defined Table 0456 - Revenue Code for suggested values. This field identifies revenue codes that are not linked to a HCPCS/CPT code. It is used for claiming for non-medical services such as telephone, TV or cafeteria charges, etc. There can be many per visit or claim. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.3",
                            Type = @"Field",
                            Position = @"GP1.3",
                            Name = @"Overall Claim Disposition Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0457",
                            TableName = @"Overall Claim Disposition Code",
                            Description = @"This field identifies the final status of the claim. The codes listed as examples are not an exhaustive or current list, refer to OPPS Final Rule. Refer to User-defined Table 0457 - Overall Claim Disposition Code for suggested values. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.4",
                            Type = @"Field",
                            Position = @"GP1.4",
                            Name = @"OCE Edits per Visit Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0458",
                            TableName = @"OCE Edit Code",
                            Description = @"This field contains the edits that result from processing the HCPCS/CPT procedures for a record after evaluating all the codes, revenue codes, and modifiers. The codes listed as examples are not an exhaustive or current list, refer to OPPS Final Rule. OCE (Outpatient Code Editor) edits also exist at the pre-procedure level. Refer to User-defined Table 0458 - OCE Edit Code for suggested values. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5",
                            Type = @"Field",
                            Position = @"GP1.5",
                            Name = @"Outlier Cost",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the amount that exceeds the outlier limitation as defined by APC regulations. This field is analogous to DRG-7 - Outlier Cost ; however, the definition in this field note supersedes the DRG-7 definition.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GP1.5.1",
                            Type = @"Component",
                            Position = @"GP1.5.1",
                            Name = @"Price",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.A.41, ""MO - money"") is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GP1.5.1.1",
                            Type = @"SubComponent",
                            Position = @"GP1.5.1.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.1.2",
                            Type = @"SubComponent",
                            Position = @"GP1.5.1.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, ""MSH-17-country code"", in section 2.14.9.17, is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.2",
                            Type = @"Component",
                            Position = @"GP1.5.2",
                            Name = @"Price Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.3",
                            Type = @"Component",
                            Position = @"GP1.5.3",
                            Name = @"From Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the ""range"". The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.4",
                            Type = @"Component",
                            Position = @"GP1.5.4",
                            Name = @"To Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value>.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5",
                            Type = @"Component",
                            Position = @"GP1.5.5",
                            Name = @"Range Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CWE, defined by the standard table of units for either time or quantity (see for example, the tables in Section 7.1.4, ""Coding schemes""). This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and <to value> are present.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.1",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.2",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.3",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.4",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.5",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.6",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.7",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.8",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.9",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.6",
                            Type = @"Component",
                            Position = @"GP1.5.6",
                            Name = @"Range Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V26SegmentGP1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field typeofBillCode;

public HL7V26Field TypeofBillCode
{
    get
    {
        if (typeofBillCode != null)
        {
            return typeofBillCode;
        }

        typeofBillCode = new HL7V26Field
        {
            field = message[@"GP1"][1],
            Id = @"GP1.1",
            Type = @"Field",
            Position = @"GP1.1",
            Name = @"Type of Bill Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0455",
            TableName = @"Type of Bill Code",
            Description = @"This field is the same as UB92 Form Locator 4 ""Type of Bill"". Refer to User-defined Table 0455 - Type of Bill Code for suggested values. Refer to a UB specification for additional information. This field is defined by CMS or other regulatory agencies. It is a code indicating the specific type of bill with digit 1 showing type of facility, digit 2 showing bill classification, and digit 3 showing frequency.",
            Sample = @"",
        };

        // check for repetitions
        if (typeofBillCode.field.FieldRepetitions != null && typeofBillCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(typeofBillCode.Id));
            typeofBillCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(typeofBillCode, fieldData);
        }

        return typeofBillCode;
    } 
}

internal HL7V26Field revenueCode;

public HL7V26Field RevenueCode
{
    get
    {
        if (revenueCode != null)
        {
            return revenueCode;
        }

        revenueCode = new HL7V26Field
        {
            field = message[@"GP1"][2],
            Id = @"GP1.2",
            Type = @"Field",
            Position = @"GP1.2",
            Name = @"Revenue Code",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0456",
            TableName = @"Revenue code",
            Description = @"This field is the same as UB92 Form Locator 42 ""Revenue Code"". Refer to User-defined Table 0456 - Revenue Code for suggested values. This field identifies revenue codes that are not linked to a HCPCS/CPT code. It is used for claiming for non-medical services such as telephone, TV or cafeteria charges, etc. There can be many per visit or claim. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (revenueCode.field.FieldRepetitions != null && revenueCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(revenueCode.Id));
            revenueCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(revenueCode, fieldData);
        }

        return revenueCode;
    } 
}

internal HL7V26Field overallClaimDispositionCode;

public HL7V26Field OverallClaimDispositionCode
{
    get
    {
        if (overallClaimDispositionCode != null)
        {
            return overallClaimDispositionCode;
        }

        overallClaimDispositionCode = new HL7V26Field
        {
            field = message[@"GP1"][3],
            Id = @"GP1.3",
            Type = @"Field",
            Position = @"GP1.3",
            Name = @"Overall Claim Disposition Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0457",
            TableName = @"Overall Claim Disposition Code",
            Description = @"This field identifies the final status of the claim. The codes listed as examples are not an exhaustive or current list, refer to OPPS Final Rule. Refer to User-defined Table 0457 - Overall Claim Disposition Code for suggested values. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (overallClaimDispositionCode.field.FieldRepetitions != null && overallClaimDispositionCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(overallClaimDispositionCode.Id));
            overallClaimDispositionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(overallClaimDispositionCode, fieldData);
        }

        return overallClaimDispositionCode;
    } 
}

internal HL7V26Field oCEEditsperVisitCode;

public HL7V26Field OCEEditsperVisitCode
{
    get
    {
        if (oCEEditsperVisitCode != null)
        {
            return oCEEditsperVisitCode;
        }

        oCEEditsperVisitCode = new HL7V26Field
        {
            field = message[@"GP1"][4],
            Id = @"GP1.4",
            Type = @"Field",
            Position = @"GP1.4",
            Name = @"OCE Edits per Visit Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0458",
            TableName = @"OCE Edit Code",
            Description = @"This field contains the edits that result from processing the HCPCS/CPT procedures for a record after evaluating all the codes, revenue codes, and modifiers. The codes listed as examples are not an exhaustive or current list, refer to OPPS Final Rule. OCE (Outpatient Code Editor) edits also exist at the pre-procedure level. Refer to User-defined Table 0458 - OCE Edit Code for suggested values. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (oCEEditsperVisitCode.field.FieldRepetitions != null && oCEEditsperVisitCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(oCEEditsperVisitCode.Id));
            oCEEditsperVisitCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(oCEEditsperVisitCode, fieldData);
        }

        return oCEEditsperVisitCode;
    } 
}

internal HL7V26Field outlierCost;

public HL7V26Field OutlierCost
{
    get
    {
        if (outlierCost != null)
        {
            return outlierCost;
        }

        outlierCost = new HL7V26Field
        {
            field = message[@"GP1"][5],
            Id = @"GP1.5",
            Type = @"Field",
            Position = @"GP1.5",
            Name = @"Outlier Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount that exceeds the outlier limitation as defined by APC regulations. This field is analogous to DRG-7 - Outlier Cost ; however, the definition in this field note supersedes the DRG-7 definition.",
            Sample = @"",
        };

        // check for repetitions
        if (outlierCost.field.FieldRepetitions != null && outlierCost.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(outlierCost.Id));
            outlierCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(outlierCost, fieldData);
        }

        return outlierCost;
    } 
}
    }
}
