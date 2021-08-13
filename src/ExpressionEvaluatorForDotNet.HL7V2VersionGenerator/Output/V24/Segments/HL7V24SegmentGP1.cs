using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentGP1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"GP1"; } }

        public string SegmentId { get { return @"GP1"; } }
        
        public string LongName { get { return @"Grouping/Reimbursement - Visit"; } }
        
        public string Description { get { return @"These fields are used in grouping and reimbursement for HCFA APCs. Please refer to the Outpatient Prospective Payment System Final Rule (OPPS Final Rule) issued by HCFA.

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

        public HL7V24SegmentGP1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _typeofBillCode;

public HL7V24Field TypeofBillCode
{
    get
    {
        if (_typeofBillCode != null)
        {
            return _typeofBillCode;
        }

        var fieldData = new HL7V24FieldData
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
            TableName = @"Type of bill code",
            Description = @"This field is the same as UB92 Form Locator 4 “Type of Bill”.  Refer to User-defined Table 0455 - Type of bill code for suggested values.  The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.  This field is defined by HCFA or other regulatory agencies.  It is a code indicating the specific type of bill with digit 1 showing type of facility, digit 2 showing bill classification, and digit 3 showing frequency",
            Sample = @"",
            Fields = null
        }

        _typeofBillCode = new HL7V24Field
        {
            field = message[@"GP1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_typeofBillCode.field.FieldRepetitions != null && _typeofBillCode.field.FieldRepetitions.Count > 0)
        {
            _typeofBillCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_typeofBillCode, fieldData);
        }

        return _typeofBillCode;
    } 
}

internal HL7V24Field _revenueCode;

public HL7V24Field RevenueCode
{
    get
    {
        if (_revenueCode != null)
        {
            return _revenueCode;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field is the same as UB92 Form Locator 42 “Revenue Code”.  Refer to User-defined Table 0456 - Revenue code for suggested values.  This field identifies revenue codes that are not linked to a HCPCS/CPT code.  It is used for claiming for non-medical services such as telephone, TV or cafeteria charges, etc.  There can be many per visit or claim.  This field is defined by HCFA or other regulatory agencies.

There can also be a revenue code linked to a HCPCS/CPT code.  These are found in GP2-1 - Revenue code. Refer to UB92 specifications.",
            Sample = @"",
            Fields = null
        }

        _revenueCode = new HL7V24Field
        {
            field = message[@"GP1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_revenueCode.field.FieldRepetitions != null && _revenueCode.field.FieldRepetitions.Count > 0)
        {
            _revenueCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_revenueCode, fieldData);
        }

        return _revenueCode;
    } 
}

internal HL7V24Field _overallClaimDispositionCode;

public HL7V24Field OverallClaimDispositionCode
{
    get
    {
        if (_overallClaimDispositionCode != null)
        {
            return _overallClaimDispositionCode;
        }

        var fieldData = new HL7V24FieldData
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
            TableName = @"Overall claim disposition code",
            Description = @"This field identifies the final status of the claim.  The codes listed as examples are not an exhaustive or current list, refer to OPPS Final Rule.  Refer to User-defined Table 0457 - Overall claim disposition code for suggested values.  This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _overallClaimDispositionCode = new HL7V24Field
        {
            field = message[@"GP1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_overallClaimDispositionCode.field.FieldRepetitions != null && _overallClaimDispositionCode.field.FieldRepetitions.Count > 0)
        {
            _overallClaimDispositionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_overallClaimDispositionCode, fieldData);
        }

        return _overallClaimDispositionCode;
    } 
}

internal HL7V24Field _oCEEditsperVisitCode;

public HL7V24Field OCEEditsperVisitCode
{
    get
    {
        if (_oCEEditsperVisitCode != null)
        {
            return _oCEEditsperVisitCode;
        }

        var fieldData = new HL7V24FieldData
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
            TableName = @"OCE edit code",
            Description = @"This field contains the edits that result from processing the HCPCS/CPT procedures for a record after evaluating all the codes, revenue codes, and modifiers.  The codes listed as examples are not an exhaustive or current list, refer to OPPS Final Rule.  OCE edits also exist at the pre-procedure level.  Refer to User-defined Table 0458 - OCE edit code for suggested values.  This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _oCEEditsperVisitCode = new HL7V24Field
        {
            field = message[@"GP1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_oCEEditsperVisitCode.field.FieldRepetitions != null && _oCEEditsperVisitCode.field.FieldRepetitions.Count > 0)
        {
            _oCEEditsperVisitCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_oCEEditsperVisitCode, fieldData);
        }

        return _oCEEditsperVisitCode;
    } 
}

internal HL7V24Field _outlierCost;

public HL7V24Field OutlierCost
{
    get
    {
        if (_outlierCost != null)
        {
            return _outlierCost;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field contains the amount that exceeds the outlier limitation as defined by APC regulations.  This field is analogous to DRG-7 - Outlier cost however the definition in this field note supersedes the DRG-7 definition",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GP1.5.1",
                            Type = @"Component",
                            Position = @"GP1.5.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.9.26, MO - money) is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GP1.5.1.1",
                            Type = @"SubComponent",
                            Position = @"GP1.5.1.1",
                            Name = @"Quantity",
                            Length = 0,
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
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. 

Example:
|99.50^USD|

where USD is the ISO 4217 code for the U.S. American dollar.",
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
                            Length = 0,
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
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the range. The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.4",
                            Type = @"Component",
                            Position = @"GP1.5.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value> above.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5",
                            Type = @"Component",
                            Position = @"GP1.5.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and  <to value> are present.

Subcomponents of range units: <identifier (ST)> & <text (ST)> & <name of coding system (IS)> & <alternate identifier (ST)> & <alternate text (ST)> & <name of alternate coding system (IS)>",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.1",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.2",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.3",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.4",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.5",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP1.5.5.6",
                            Type = @"SubComponent",
                            Position = @"GP1.5.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
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
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 Table 0298 - CP range type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _outlierCost = new HL7V24Field
        {
            field = message[@"GP1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierCost.field.FieldRepetitions != null && _outlierCost.field.FieldRepetitions.Count > 0)
        {
            _outlierCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_outlierCost, fieldData);
        }

        return _outlierCost;
    } 
}
    }
}
