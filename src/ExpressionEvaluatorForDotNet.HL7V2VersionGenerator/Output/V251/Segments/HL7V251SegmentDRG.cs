using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentDRG
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DRG"; } }

        public string SegmentId { get { return @"DRG"; } }
        
        public string LongName { get { return @"Diagnosis Related Group"; } }
        
        public string Description { get { return @"The DRG segment contains diagnoses-related grouping information of various types. The DRG segment is used to send the DRG information, for example, for billing and medical records encoding."; } }
        
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

        public HL7V251SegmentDRG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _diagnosticRelatedGroup;

public HL7V251Field DiagnosticRelatedGroup
{
    get
    {
        if (_diagnosticRelatedGroup != null)
        {
            return _diagnosticRelatedGroup;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"DRG.1",
            Type = @"Field",
            Position = @"DRG.1",
            Name = @"Diagnostic Related Group",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0055",
            TableName = @"Diagnosis related group",
            Description = @"This field contains the DRG for the transaction. Interim DRGs could be determined for an encounter. Refer to User-defined Table 0055 - Diagnosis Related G roup for suggested values. For the name of coding system component, send the grouper version and type.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.1.1",
                            Type = @"Component",
                            Position = @"DRG.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.1.2",
                            Type = @"Component",
                            Position = @"DRG.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.1.3",
                            Type = @"Component",
                            Position = @"DRG.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.1.4",
                            Type = @"Component",
                            Position = @"DRG.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.1.5",
                            Type = @"Component",
                            Position = @"DRG.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.1.6",
                            Type = @"Component",
                            Position = @"DRG.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _diagnosticRelatedGroup = new HL7V251Field
        {
            field = message[@"DRG"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosticRelatedGroup.field.FieldRepetitions != null && _diagnosticRelatedGroup.field.FieldRepetitions.Count > 0)
        {
            _diagnosticRelatedGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_diagnosticRelatedGroup, fieldData);
        }

        return _diagnosticRelatedGroup;
    } 
}

internal HL7V251Field _dRGAssignedDateTime;

public HL7V251Field DRGAssignedDateTime
{
    get
    {
        if (_dRGAssignedDateTime != null)
        {
            return _dRGAssignedDateTime;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"DRG.2",
            Type = @"Field",
            Position = @"DRG.2",
            Name = @"DRG Assigned Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time stamp to indicate the date and time that the DRG was assigned.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.2.1",
                            Type = @"Component",
                            Position = @"DRG.2.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.2.2",
                            Type = @"Component",
                            Position = @"DRG.2.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dRGAssignedDateTime = new HL7V251Field
        {
            field = message[@"DRG"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGAssignedDateTime.field.FieldRepetitions != null && _dRGAssignedDateTime.field.FieldRepetitions.Count > 0)
        {
            _dRGAssignedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_dRGAssignedDateTime, fieldData);
        }

        return _dRGAssignedDateTime;
    } 
}

internal HL7V251Field _dRGApprovalIndicator;

public HL7V251Field DRGApprovalIndicator
{
    get
    {
        if (_dRGApprovalIndicator != null)
        {
            return _dRGApprovalIndicator;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"DRG.3",
            Type = @"Field",
            Position = @"DRG.3",
            Name = @"DRG Approval Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the DRG has been approved by a reviewing entity. Refer to HL7 table 0136 - Yes/no Indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _dRGApprovalIndicator = new HL7V251Field
        {
            field = message[@"DRG"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGApprovalIndicator.field.FieldRepetitions != null && _dRGApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            _dRGApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_dRGApprovalIndicator, fieldData);
        }

        return _dRGApprovalIndicator;
    } 
}

internal HL7V251Field _dRGGrouperReviewCode;

public HL7V251Field DRGGrouperReviewCode
{
    get
    {
        if (_dRGGrouperReviewCode != null)
        {
            return _dRGGrouperReviewCode;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"DRG.4",
            Type = @"Field",
            Position = @"DRG.4",
            Name = @"DRG Grouper Review Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0056",
            TableName = @"DRG grouper review code",
            Description = @"This code indicates that the grouper results have been reviewed and approved. Refer to User-defined Table 0056 - DRG Grouper Review Code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _dRGGrouperReviewCode = new HL7V251Field
        {
            field = message[@"DRG"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGGrouperReviewCode.field.FieldRepetitions != null && _dRGGrouperReviewCode.field.FieldRepetitions.Count > 0)
        {
            _dRGGrouperReviewCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_dRGGrouperReviewCode, fieldData);
        }

        return _dRGGrouperReviewCode;
    } 
}

internal HL7V251Field _outlierType;

public HL7V251Field OutlierType
{
    get
    {
        if (_outlierType != null)
        {
            return _outlierType;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"DRG.5",
            Type = @"Field",
            Position = @"DRG.5",
            Name = @"Outlier Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0083",
            TableName = @"Outlier Type",
            Description = @"Refers to the type of outlier (i.e. period of care beyond DRG-standard stay in facility) that has been paid. Refer to User-defined Table 0083 - Outlier Type for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.5.1",
                            Type = @"Component",
                            Position = @"DRG.5.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.5.2",
                            Type = @"Component",
                            Position = @"DRG.5.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.5.3",
                            Type = @"Component",
                            Position = @"DRG.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.5.4",
                            Type = @"Component",
                            Position = @"DRG.5.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.5.5",
                            Type = @"Component",
                            Position = @"DRG.5.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.5.6",
                            Type = @"Component",
                            Position = @"DRG.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _outlierType = new HL7V251Field
        {
            field = message[@"DRG"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierType.field.FieldRepetitions != null && _outlierType.field.FieldRepetitions.Count > 0)
        {
            _outlierType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_outlierType, fieldData);
        }

        return _outlierType;
    } 
}

internal HL7V251Field _outlierDays;

public HL7V251Field OutlierDays
{
    get
    {
        if (_outlierDays != null)
        {
            return _outlierDays;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"DRG.6",
            Type = @"Field",
            Position = @"DRG.6",
            Name = @"Outlier Days",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of days that have been approved as an outlier payment.",
            Sample = @"",
            Fields = null
        }

        _outlierDays = new HL7V251Field
        {
            field = message[@"DRG"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierDays.field.FieldRepetitions != null && _outlierDays.field.FieldRepetitions.Count > 0)
        {
            _outlierDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_outlierDays, fieldData);
        }

        return _outlierDays;
    } 
}

internal HL7V251Field _outlierCost;

public HL7V251Field OutlierCost
{
    get
    {
        if (_outlierCost != null)
        {
            return _outlierCost;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"DRG.7",
            Type = @"Field",
            Position = @"DRG.7",
            Name = @"Outlier Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount of money that has been approved for an outlier payment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.7.1",
                            Type = @"Component",
                            Position = @"DRG.7.1",
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
                            Id = @"DRG.7.1.1",
                            Type = @"SubComponent",
                            Position = @"DRG.7.1.1",
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
                            Id = @"DRG.7.1.2",
                            Type = @"SubComponent",
                            Position = @"DRG.7.1.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.7.2",
                            Type = @"Component",
                            Position = @"DRG.7.2",
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
                            Id = @"DRG.7.3",
                            Type = @"Component",
                            Position = @"DRG.7.3",
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
                            Id = @"DRG.7.4",
                            Type = @"Component",
                            Position = @"DRG.7.4",
                            Name = @"To Value",
                            Length = 16,
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
                            Id = @"DRG.7.5",
                            Type = @"Component",
                            Position = @"DRG.7.5",
                            Name = @"Range Units",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity (see for example, the tables in Section 7.1.4, ""Coding schemes""). This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and <to value> are present.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DRG.7.5.1",
                            Type = @"SubComponent",
                            Position = @"DRG.7.5.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.7.5.2",
                            Type = @"SubComponent",
                            Position = @"DRG.7.5.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.7.5.3",
                            Type = @"SubComponent",
                            Position = @"DRG.7.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.7.5.4",
                            Type = @"SubComponent",
                            Position = @"DRG.7.5.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.7.5.5",
                            Type = @"SubComponent",
                            Position = @"DRG.7.5.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.7.5.6",
                            Type = @"SubComponent",
                            Position = @"DRG.7.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.7.6",
                            Type = @"Component",
                            Position = @"DRG.7.6",
                            Name = @"Range Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refer to HL7 Table 0298 - CP range type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _outlierCost = new HL7V251Field
        {
            field = message[@"DRG"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierCost.field.FieldRepetitions != null && _outlierCost.field.FieldRepetitions.Count > 0)
        {
            _outlierCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_outlierCost, fieldData);
        }

        return _outlierCost;
    } 
}

internal HL7V251Field _dRGPayor;

public HL7V251Field DRGPayor
{
    get
    {
        if (_dRGPayor != null)
        {
            return _dRGPayor;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"DRG.8",
            Type = @"Field",
            Position = @"DRG.8",
            Name = @"DRG Payor",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0229",
            TableName = @"DRG Payor",
            Description = @"This field indicates the associated DRG Payor. Refer to User-defined Table 0229 - DRG Payor for suggested values.",
            Sample = @"",
            Fields = null
        }

        _dRGPayor = new HL7V251Field
        {
            field = message[@"DRG"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGPayor.field.FieldRepetitions != null && _dRGPayor.field.FieldRepetitions.Count > 0)
        {
            _dRGPayor.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_dRGPayor, fieldData);
        }

        return _dRGPayor;
    } 
}

internal HL7V251Field _outlierReimbursement;

public HL7V251Field OutlierReimbursement
{
    get
    {
        if (_outlierReimbursement != null)
        {
            return _outlierReimbursement;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"DRG.9",
            Type = @"Field",
            Position = @"DRG.9",
            Name = @"Outlier Reimbursement",
            Length = 9,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"Where applicable, the outlier reimbursement amount indicates the part of the total reimbursement designated for reimbursement of outlier conditions (day or cost).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.9.1",
                            Type = @"Component",
                            Position = @"DRG.9.1",
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
                            Id = @"DRG.9.1.1",
                            Type = @"SubComponent",
                            Position = @"DRG.9.1.1",
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
                            Id = @"DRG.9.1.2",
                            Type = @"SubComponent",
                            Position = @"DRG.9.1.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.9.2",
                            Type = @"Component",
                            Position = @"DRG.9.2",
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
                            Id = @"DRG.9.3",
                            Type = @"Component",
                            Position = @"DRG.9.3",
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
                            Id = @"DRG.9.4",
                            Type = @"Component",
                            Position = @"DRG.9.4",
                            Name = @"To Value",
                            Length = 16,
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
                            Id = @"DRG.9.5",
                            Type = @"Component",
                            Position = @"DRG.9.5",
                            Name = @"Range Units",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity (see for example, the tables in Section 7.1.4, ""Coding schemes""). This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and <to value> are present.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DRG.9.5.1",
                            Type = @"SubComponent",
                            Position = @"DRG.9.5.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.9.5.2",
                            Type = @"SubComponent",
                            Position = @"DRG.9.5.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.9.5.3",
                            Type = @"SubComponent",
                            Position = @"DRG.9.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.9.5.4",
                            Type = @"SubComponent",
                            Position = @"DRG.9.5.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.9.5.5",
                            Type = @"SubComponent",
                            Position = @"DRG.9.5.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.9.5.6",
                            Type = @"SubComponent",
                            Position = @"DRG.9.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.9.6",
                            Type = @"Component",
                            Position = @"DRG.9.6",
                            Name = @"Range Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refer to HL7 Table 0298 - CP range type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _outlierReimbursement = new HL7V251Field
        {
            field = message[@"DRG"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierReimbursement.field.FieldRepetitions != null && _outlierReimbursement.field.FieldRepetitions.Count > 0)
        {
            _outlierReimbursement.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_outlierReimbursement, fieldData);
        }

        return _outlierReimbursement;
    } 
}

internal HL7V251Field _confidentialIndicator;

public HL7V251Field ConfidentialIndicator
{
    get
    {
        if (_confidentialIndicator != null)
        {
            return _confidentialIndicator;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"DRG.10",
            Type = @"Field",
            Position = @"DRG.10",
            Name = @"Confidential Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the DRG contains a confidential diagnosis. Refer to HL7 table 0136 - Yes/no Indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _confidentialIndicator = new HL7V251Field
        {
            field = message[@"DRG"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_confidentialIndicator.field.FieldRepetitions != null && _confidentialIndicator.field.FieldRepetitions.Count > 0)
        {
            _confidentialIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_confidentialIndicator, fieldData);
        }

        return _confidentialIndicator;
    } 
}

internal HL7V251Field _dRGTransferType;

public HL7V251Field DRGTransferType
{
    get
    {
        if (_dRGTransferType != null)
        {
            return _dRGTransferType;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"DRG.11",
            Type = @"Field",
            Position = @"DRG.11",
            Name = @"DRG Transfer Type",
            Length = 21,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0415",
            TableName = @"DRG Transfer Type",
            Description = @"This field indicates the type of hospital receiving a transfer patient, which affects how a facility is reimbursed under diagnosis related group (DRGs), for example, exempt or non-exempt. Refer to User-defined Table 0415 - DRG Transfer Type for suggested values.",
            Sample = @"",
            Fields = null
        }

        _dRGTransferType = new HL7V251Field
        {
            field = message[@"DRG"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGTransferType.field.FieldRepetitions != null && _dRGTransferType.field.FieldRepetitions.Count > 0)
        {
            _dRGTransferType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_dRGTransferType, fieldData);
        }

        return _dRGTransferType;
    } 
}
    }
}
