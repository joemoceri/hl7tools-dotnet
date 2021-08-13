using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentDRG
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

        public HL7V26SegmentDRG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _diagnosticRelatedGroup;

public HL7V26Field DiagnosticRelatedGroup
{
    get
    {
        if (_diagnosticRelatedGroup != null)
        {
            return _diagnosticRelatedGroup;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.1",
            Type = @"Field",
            Position = @"DRG.1",
            Name = @"Diagnostic Related Group",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0055",
            TableName = @"Diagnosis Related Group",
            Description = @"This field contains the DRG for the transaction. Interim DRGs could be determined for an encounter. Refer to Externally-defined Table 0055 - Diagnosis Related G roup for suggested values.",
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
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
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
                            Description = @"Analogous to “Identifier” in component 1.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.1.7",
                            Type = @"Component",
                            Position = @"DRG.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.1.8",
                            Type = @"Component",
                            Position = @"DRG.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.1.9",
                            Type = @"Component",
                            Position = @"DRG.1.9",
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
                        },
                        }
        }

        _diagnosticRelatedGroup = new HL7V26Field
        {
            field = message[@"DRG"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosticRelatedGroup.field.FieldRepetitions != null && _diagnosticRelatedGroup.field.FieldRepetitions.Count > 0)
        {
            _diagnosticRelatedGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_diagnosticRelatedGroup, fieldData);
        }

        return _diagnosticRelatedGroup;
    } 
}

internal HL7V26Field _dRGAssignedDateTime;

public HL7V26Field DRGAssignedDateTime
{
    get
    {
        if (_dRGAssignedDateTime != null)
        {
            return _dRGAssignedDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.2",
            Type = @"Field",
            Position = @"DRG.2",
            Name = @"DRG Assigned Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time stamp to indicate the date and time that the DRG was assigned.",
            Sample = @"",
            Fields = null
        }

        _dRGAssignedDateTime = new HL7V26Field
        {
            field = message[@"DRG"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGAssignedDateTime.field.FieldRepetitions != null && _dRGAssignedDateTime.field.FieldRepetitions.Count > 0)
        {
            _dRGAssignedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_dRGAssignedDateTime, fieldData);
        }

        return _dRGAssignedDateTime;
    } 
}

internal HL7V26Field _dRGApprovalIndicator;

public HL7V26Field DRGApprovalIndicator
{
    get
    {
        if (_dRGApprovalIndicator != null)
        {
            return _dRGApprovalIndicator;
        }

        var fieldData = new HL7V26FieldData
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

        _dRGApprovalIndicator = new HL7V26Field
        {
            field = message[@"DRG"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGApprovalIndicator.field.FieldRepetitions != null && _dRGApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            _dRGApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_dRGApprovalIndicator, fieldData);
        }

        return _dRGApprovalIndicator;
    } 
}

internal HL7V26Field _dRGGrouperReviewCode;

public HL7V26Field DRGGrouperReviewCode
{
    get
    {
        if (_dRGGrouperReviewCode != null)
        {
            return _dRGGrouperReviewCode;
        }

        var fieldData = new HL7V26FieldData
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
            TableName = @"DRG Grouper Review Code",
            Description = @"This code indicates that the grouper results have been reviewed and approved. Refer to User-defined Table 0056 - DRG Grouper Review Code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _dRGGrouperReviewCode = new HL7V26Field
        {
            field = message[@"DRG"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGGrouperReviewCode.field.FieldRepetitions != null && _dRGGrouperReviewCode.field.FieldRepetitions.Count > 0)
        {
            _dRGGrouperReviewCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_dRGGrouperReviewCode, fieldData);
        }

        return _dRGGrouperReviewCode;
    } 
}

internal HL7V26Field _outlierType;

public HL7V26Field OutlierType
{
    get
    {
        if (_outlierType != null)
        {
            return _outlierType;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.5",
            Type = @"Field",
            Position = @"DRG.5",
            Name = @"Outlier Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0083",
            TableName = @"Outlier Type",
            Description = @"Refers to the type of outlier (i.e., period of care beyond DRG-standard stay in facility) that has been paid. Refer to User-defined Table 0083 - Outlier Type for suggested values.",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.5.7",
                            Type = @"Component",
                            Position = @"DRG.5.7",
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
                            Id = @"DRG.5.8",
                            Type = @"Component",
                            Position = @"DRG.5.8",
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
                            Id = @"DRG.5.9",
                            Type = @"Component",
                            Position = @"DRG.5.9",
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
                        },
                        }
        }

        _outlierType = new HL7V26Field
        {
            field = message[@"DRG"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierType.field.FieldRepetitions != null && _outlierType.field.FieldRepetitions.Count > 0)
        {
            _outlierType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_outlierType, fieldData);
        }

        return _outlierType;
    } 
}

internal HL7V26Field _outlierDays;

public HL7V26Field OutlierDays
{
    get
    {
        if (_outlierDays != null)
        {
            return _outlierDays;
        }

        var fieldData = new HL7V26FieldData
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

        _outlierDays = new HL7V26Field
        {
            field = message[@"DRG"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierDays.field.FieldRepetitions != null && _outlierDays.field.FieldRepetitions.Count > 0)
        {
            _outlierDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_outlierDays, fieldData);
        }

        return _outlierDays;
    } 
}

internal HL7V26Field _outlierCost;

public HL7V26Field OutlierCost
{
    get
    {
        if (_outlierCost != null)
        {
            return _outlierCost;
        }

        var fieldData = new HL7V26FieldData
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
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, ""MSH-17-country code"", in section 2.14.9.17, is used to determine the default.",
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
                            Description = @"See <from value>.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.7.5",
                            Type = @"Component",
                            Position = @"DRG.7.5",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.7.5.7",
                            Type = @"SubComponent",
                            Position = @"DRG.7.5.7",
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
                            Id = @"DRG.7.5.8",
                            Type = @"SubComponent",
                            Position = @"DRG.7.5.8",
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
                            Id = @"DRG.7.5.9",
                            Type = @"SubComponent",
                            Position = @"DRG.7.5.9",
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _outlierCost = new HL7V26Field
        {
            field = message[@"DRG"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierCost.field.FieldRepetitions != null && _outlierCost.field.FieldRepetitions.Count > 0)
        {
            _outlierCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_outlierCost, fieldData);
        }

        return _outlierCost;
    } 
}

internal HL7V26Field _dRGPayor;

public HL7V26Field DRGPayor
{
    get
    {
        if (_dRGPayor != null)
        {
            return _dRGPayor;
        }

        var fieldData = new HL7V26FieldData
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

        _dRGPayor = new HL7V26Field
        {
            field = message[@"DRG"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGPayor.field.FieldRepetitions != null && _dRGPayor.field.FieldRepetitions.Count > 0)
        {
            _dRGPayor.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_dRGPayor, fieldData);
        }

        return _dRGPayor;
    } 
}

internal HL7V26Field _outlierReimbursement;

public HL7V26Field OutlierReimbursement
{
    get
    {
        if (_outlierReimbursement != null)
        {
            return _outlierReimbursement;
        }

        var fieldData = new HL7V26FieldData
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
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, ""MSH-17-country code"", in section 2.14.9.17, is used to determine the default.",
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
                            Description = @"See <from value>.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.9.5",
                            Type = @"Component",
                            Position = @"DRG.9.5",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.9.5.7",
                            Type = @"SubComponent",
                            Position = @"DRG.9.5.7",
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
                            Id = @"DRG.9.5.8",
                            Type = @"SubComponent",
                            Position = @"DRG.9.5.8",
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
                            Id = @"DRG.9.5.9",
                            Type = @"SubComponent",
                            Position = @"DRG.9.5.9",
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _outlierReimbursement = new HL7V26Field
        {
            field = message[@"DRG"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierReimbursement.field.FieldRepetitions != null && _outlierReimbursement.field.FieldRepetitions.Count > 0)
        {
            _outlierReimbursement.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_outlierReimbursement, fieldData);
        }

        return _outlierReimbursement;
    } 
}

internal HL7V26Field _confidentialIndicator;

public HL7V26Field ConfidentialIndicator
{
    get
    {
        if (_confidentialIndicator != null)
        {
            return _confidentialIndicator;
        }

        var fieldData = new HL7V26FieldData
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

        _confidentialIndicator = new HL7V26Field
        {
            field = message[@"DRG"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_confidentialIndicator.field.FieldRepetitions != null && _confidentialIndicator.field.FieldRepetitions.Count > 0)
        {
            _confidentialIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_confidentialIndicator, fieldData);
        }

        return _confidentialIndicator;
    } 
}

internal HL7V26Field _dRGTransferType;

public HL7V26Field DRGTransferType
{
    get
    {
        if (_dRGTransferType != null)
        {
            return _dRGTransferType;
        }

        var fieldData = new HL7V26FieldData
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

        _dRGTransferType = new HL7V26Field
        {
            field = message[@"DRG"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGTransferType.field.FieldRepetitions != null && _dRGTransferType.field.FieldRepetitions.Count > 0)
        {
            _dRGTransferType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_dRGTransferType, fieldData);
        }

        return _dRGTransferType;
    } 
}

internal HL7V26Field _nameofCoder;

public HL7V26Field NameofCoder
{
    get
    {
        if (_nameofCoder != null)
        {
            return _nameofCoder;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.12",
            Type = @"Field",
            Position = @"DRG.12",
            Name = @"Name of Coder",
            Length = 1103,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field holds the name of the person (""coder"") who supervised or undertook the determination of the DRG code.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.12.1",
                            Type = @"Component",
                            Position = @"DRG.12.1",
                            Name = @"Family Name",
                            Length = 194,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.A.30, ""FN - family name"".",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DRG.12.1.1",
                            Type = @"SubComponent",
                            Position = @"DRG.12.1.1",
                            Name = @"Surname",
                            Length = 50,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = @"The atomic element of the person's family name. In most Western usage, this is the person's last name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.1.2",
                            Type = @"SubComponent",
                            Position = @"DRG.12.1.2",
                            Name = @"Own Surname Prefix",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the ""van"" in ""Ludwig van Beethoven"". Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.1.3",
                            Type = @"SubComponent",
                            Position = @"DRG.12.1.3",
                            Name = @"Own Surname",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.1.4",
                            Type = @"SubComponent",
                            Position = @"DRG.12.1.4",
                            Name = @"Surname Prefix From Partner/Spouse",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in ""Ludwig van Beethoven"". Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.1.5",
                            Type = @"SubComponent",
                            Position = @"DRG.12.1.5",
                            Name = @"Surname From Partner/Spouse",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.2",
                            Type = @"Component",
                            Position = @"DRG.12.2",
                            Name = @"Given Name",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = @"First name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.3",
                            Type = @"Component",
                            Position = @"DRG.12.3",
                            Name = @"Second And Further Given Names Or Initials Thereof",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Multiple middle names may be included by separating them with spaces.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.4",
                            Type = @"Component",
                            Position = @"DRG.12.4",
                            Name = @"Suffix",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.5",
                            Type = @"Component",
                            Position = @"DRG.12.5",
                            Name = @"Prefix",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.6",
                            Type = @"Component",
                            Position = @"DRG.12.6",
                            Name = @"Degree",
                            Length = 6,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree/license/certificate",
                            Description = @"Retained for backward compatibility only as of v 2.5. See Professional Suffix component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.7",
                            Type = @"Component",
                            Position = @"DRG.12.7",
                            Name = @"Name Type Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name Type",
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.8",
                            Type = @"Component",
                            Position = @"DRG.12.8",
                            Name = @"Name Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.9",
                            Type = @"Component",
                            Position = @"DRG.12.9",
                            Name = @"Name Context",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448 - Name context for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DRG.12.9.1",
                            Type = @"SubComponent",
                            Position = @"DRG.12.9.1",
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
                            Id = @"DRG.12.9.2",
                            Type = @"SubComponent",
                            Position = @"DRG.12.9.2",
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
                            Id = @"DRG.12.9.3",
                            Type = @"SubComponent",
                            Position = @"DRG.12.9.3",
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
                            Id = @"DRG.12.9.4",
                            Type = @"SubComponent",
                            Position = @"DRG.12.9.4",
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
                            Id = @"DRG.12.9.5",
                            Type = @"SubComponent",
                            Position = @"DRG.12.9.5",
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
                            Id = @"DRG.12.9.6",
                            Type = @"SubComponent",
                            Position = @"DRG.12.9.6",
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
                            Id = @"DRG.12.9.7",
                            Type = @"SubComponent",
                            Position = @"DRG.12.9.7",
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
                            Id = @"DRG.12.9.8",
                            Type = @"SubComponent",
                            Position = @"DRG.12.9.8",
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
                            Id = @"DRG.12.9.9",
                            Type = @"SubComponent",
                            Position = @"DRG.12.9.9",
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
                            Id = @"DRG.12.10",
                            Type = @"Component",
                            Position = @"DRG.12.10",
                            Name = @"Name Validity Range",
                            Length = 49,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/Time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component cannot be fully expressed. Identified as v 2.4 erratum. Retained for backward compatibility only as of v 2.5. Refer to 2.A.88.12, ""Effective Date"" and 2.A.88.13, ""Expiration Date"" components.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DRG.12.10.1",
                            Type = @"SubComponent",
                            Position = @"DRG.12.10.1",
                            Name = @"Range Start Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.10.2",
                            Type = @"SubComponent",
                            Position = @"DRG.12.10.2",
                            Name = @"Range End Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the DTM (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.11",
                            Type = @"Component",
                            Position = @"DRG.12.11",
                            Name = @"Name Assembly Order",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0444",
                            TableName = @"Name assembly order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 0444 - Name assembly order for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.12",
                            Type = @"Component",
                            Position = @"DRG.12.12",
                            Name = @"Effective Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The first date, if known, on which the person name is valid and active.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.13",
                            Type = @"Component",
                            Position = @"DRG.12.13",
                            Name = @"Expiration Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the person name is valid and active.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DRG.12.14",
                            Type = @"Component",
                            Position = @"DRG.12.14",
                            Name = @"Professional Suffix",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, Personnel Management.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _nameofCoder = new HL7V26Field
        {
            field = message[@"DRG"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nameofCoder.field.FieldRepetitions != null && _nameofCoder.field.FieldRepetitions.Count > 0)
        {
            _nameofCoder.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_nameofCoder, fieldData);
        }

        return _nameofCoder;
    } 
}

internal HL7V26Field _grouperStatus;

public HL7V26Field GrouperStatus
{
    get
    {
        if (_grouperStatus != null)
        {
            return _grouperStatus;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.13",
            Type = @"Field",
            Position = @"DRG.13",
            Name = @"Grouper Status",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0734",
            TableName = @"Grouper Status",
            Description = @"This field indicates the grouper status in general. Refer to Externally-defined Table 0734 - Grouper Status for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.13.1",
                            Type = @"Component",
                            Position = @"DRG.13.1",
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
                            Id = @"DRG.13.2",
                            Type = @"Component",
                            Position = @"DRG.13.2",
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
                            Id = @"DRG.13.3",
                            Type = @"Component",
                            Position = @"DRG.13.3",
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
                            Id = @"DRG.13.4",
                            Type = @"Component",
                            Position = @"DRG.13.4",
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
                            Id = @"DRG.13.5",
                            Type = @"Component",
                            Position = @"DRG.13.5",
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
                            Id = @"DRG.13.6",
                            Type = @"Component",
                            Position = @"DRG.13.6",
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
                            Id = @"DRG.13.7",
                            Type = @"Component",
                            Position = @"DRG.13.7",
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
                            Id = @"DRG.13.8",
                            Type = @"Component",
                            Position = @"DRG.13.8",
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
                            Id = @"DRG.13.9",
                            Type = @"Component",
                            Position = @"DRG.13.9",
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
                        },
                        }
        }

        _grouperStatus = new HL7V26Field
        {
            field = message[@"DRG"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_grouperStatus.field.FieldRepetitions != null && _grouperStatus.field.FieldRepetitions.Count > 0)
        {
            _grouperStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_grouperStatus, fieldData);
        }

        return _grouperStatus;
    } 
}

internal HL7V26Field _pCCLValueCode;

public HL7V26Field PCCLValueCode
{
    get
    {
        if (_pCCLValueCode != null)
        {
            return _pCCLValueCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.14",
            Type = @"Field",
            Position = @"DRG.14",
            Name = @"PCCL Value Code",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates the PCCL (Patient Clinical Complexity Level) value for the calculated DRG as a single value. This value is calculated based on all individual CCL values calculated so far in relation to the basic DRG. Refer to Externally-defined Table 0728 - CCL Value for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.14.1",
                            Type = @"Component",
                            Position = @"DRG.14.1",
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
                            Id = @"DRG.14.2",
                            Type = @"Component",
                            Position = @"DRG.14.2",
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
                            Id = @"DRG.14.3",
                            Type = @"Component",
                            Position = @"DRG.14.3",
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
                            Id = @"DRG.14.4",
                            Type = @"Component",
                            Position = @"DRG.14.4",
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
                            Id = @"DRG.14.5",
                            Type = @"Component",
                            Position = @"DRG.14.5",
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
                            Id = @"DRG.14.6",
                            Type = @"Component",
                            Position = @"DRG.14.6",
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
                            Id = @"DRG.14.7",
                            Type = @"Component",
                            Position = @"DRG.14.7",
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
                            Id = @"DRG.14.8",
                            Type = @"Component",
                            Position = @"DRG.14.8",
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
                            Id = @"DRG.14.9",
                            Type = @"Component",
                            Position = @"DRG.14.9",
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
                        },
                        }
        }

        _pCCLValueCode = new HL7V26Field
        {
            field = message[@"DRG"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pCCLValueCode.field.FieldRepetitions != null && _pCCLValueCode.field.FieldRepetitions.Count > 0)
        {
            _pCCLValueCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_pCCLValueCode, fieldData);
        }

        return _pCCLValueCode;
    } 
}

internal HL7V26Field _effectiveWeight;

public HL7V26Field EffectiveWeight
{
    get
    {
        if (_effectiveWeight != null)
        {
            return _effectiveWeight;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.15",
            Type = @"Field",
            Position = @"DRG.15",
            Name = @"Effective Weight",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the effective weight as calculated for this DRG. When exceeding the upper or lower trim point the effective weight is lower or higher.",
            Sample = @"",
            Fields = null
        }

        _effectiveWeight = new HL7V26Field
        {
            field = message[@"DRG"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_effectiveWeight.field.FieldRepetitions != null && _effectiveWeight.field.FieldRepetitions.Count > 0)
        {
            _effectiveWeight.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_effectiveWeight, fieldData);
        }

        return _effectiveWeight;
    } 
}

internal HL7V26Field _monetaryAmount;

public HL7V26Field MonetaryAmount
{
    get
    {
        if (_monetaryAmount != null)
        {
            return _monetaryAmount;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.16",
            Type = @"Field",
            Position = @"DRG.16",
            Name = @"Monetary Amount",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"MO",
            DataTypeName = @"Money",
            TableId = null,
            TableName = null,
            Description = @"This field contains the monetary amount as calculated for this DRG, i.e., the sum of money the insurance company will pay.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.16.1",
                            Type = @"Component",
                            Position = @"DRG.16.1",
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
                            Id = @"DRG.16.2",
                            Type = @"Component",
                            Position = @"DRG.16.2",
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
                        },
                        }
        }

        _monetaryAmount = new HL7V26Field
        {
            field = message[@"DRG"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_monetaryAmount.field.FieldRepetitions != null && _monetaryAmount.field.FieldRepetitions.Count > 0)
        {
            _monetaryAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_monetaryAmount, fieldData);
        }

        return _monetaryAmount;
    } 
}

internal HL7V26Field _statusPatient;

public HL7V26Field StatusPatient
{
    get
    {
        if (_statusPatient != null)
        {
            return _statusPatient;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.17",
            Type = @"Field",
            Position = @"DRG.17",
            Name = @"Status Patient",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0739",
            TableName = @"Status Patient",
            Description = @"This field contains the status of the patient concerning the financial aspects. It indicates whether the length of stay is normal or respectively shorter or longer than normal. Refer toUser-defined Table 0739 - DRG Status Patient for suggested values.",
            Sample = @"",
            Fields = null
        }

        _statusPatient = new HL7V26Field
        {
            field = message[@"DRG"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statusPatient.field.FieldRepetitions != null && _statusPatient.field.FieldRepetitions.Count > 0)
        {
            _statusPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statusPatient, fieldData);
        }

        return _statusPatient;
    } 
}

internal HL7V26Field _grouperSoftwareName;

public HL7V26Field GrouperSoftwareName
{
    get
    {
        if (_grouperSoftwareName != null)
        {
            return _grouperSoftwareName;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.18",
            Type = @"Field",
            Position = @"DRG.18",
            Name = @"Grouper Software Name",
            Length = 100,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the software used for grouping.",
            Sample = @"",
            Fields = null
        }

        _grouperSoftwareName = new HL7V26Field
        {
            field = message[@"DRG"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_grouperSoftwareName.field.FieldRepetitions != null && _grouperSoftwareName.field.FieldRepetitions.Count > 0)
        {
            _grouperSoftwareName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_grouperSoftwareName, fieldData);
        }

        return _grouperSoftwareName;
    } 
}

internal HL7V26Field _grouperSoftwareVersion;

public HL7V26Field GrouperSoftwareVersion
{
    get
    {
        if (_grouperSoftwareVersion != null)
        {
            return _grouperSoftwareVersion;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.19",
            Type = @"Field",
            Position = @"DRG.19",
            Name = @"Grouper Software Version",
            Length = 100,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the version information of the software used for grouping.",
            Sample = @"",
            Fields = null
        }

        _grouperSoftwareVersion = new HL7V26Field
        {
            field = message[@"DRG"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_grouperSoftwareVersion.field.FieldRepetitions != null && _grouperSoftwareVersion.field.FieldRepetitions.Count > 0)
        {
            _grouperSoftwareVersion.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_grouperSoftwareVersion, fieldData);
        }

        return _grouperSoftwareVersion;
    } 
}

internal HL7V26Field _statusFinancialCalculation;

public HL7V26Field StatusFinancialCalculation
{
    get
    {
        if (_statusFinancialCalculation != null)
        {
            return _statusFinancialCalculation;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.20",
            Type = @"Field",
            Position = @"DRG.20",
            Name = @"Status Financial Calculation",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0742",
            TableName = @"DRG Status Financial Calculation",
            Description = @"This field contains the status of the DRG calculation regarding the financial aspects. Refer to User-defined Table 0742 - DRG Status Financial Calculation for suggested values.",
            Sample = @"",
            Fields = null
        }

        _statusFinancialCalculation = new HL7V26Field
        {
            field = message[@"DRG"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statusFinancialCalculation.field.FieldRepetitions != null && _statusFinancialCalculation.field.FieldRepetitions.Count > 0)
        {
            _statusFinancialCalculation.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statusFinancialCalculation, fieldData);
        }

        return _statusFinancialCalculation;
    } 
}

internal HL7V26Field _relativeDiscountSurcharge;

public HL7V26Field RelativeDiscountSurcharge
{
    get
    {
        if (_relativeDiscountSurcharge != null)
        {
            return _relativeDiscountSurcharge;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.21",
            Type = @"Field",
            Position = @"DRG.21",
            Name = @"Relative Discount/Surcharge",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"MO",
            DataTypeName = @"Money",
            TableId = null,
            TableName = null,
            Description = @"There will be a discount/surcharge for the calculated price due to a very short stay, early referral or a very long stay. This field contains the discount or surcharge that is included in the final price.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.21.1",
                            Type = @"Component",
                            Position = @"DRG.21.1",
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
                            Id = @"DRG.21.2",
                            Type = @"Component",
                            Position = @"DRG.21.2",
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
                        },
                        }
        }

        _relativeDiscountSurcharge = new HL7V26Field
        {
            field = message[@"DRG"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relativeDiscountSurcharge.field.FieldRepetitions != null && _relativeDiscountSurcharge.field.FieldRepetitions.Count > 0)
        {
            _relativeDiscountSurcharge.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_relativeDiscountSurcharge, fieldData);
        }

        return _relativeDiscountSurcharge;
    } 
}

internal HL7V26Field _basicCharge;

public HL7V26Field BasicCharge
{
    get
    {
        if (_basicCharge != null)
        {
            return _basicCharge;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.22",
            Type = @"Field",
            Position = @"DRG.22",
            Name = @"Basic Charge",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"MO",
            DataTypeName = @"Money",
            TableId = null,
            TableName = null,
            Description = @"The basic charge is calculated as a multiplication of the relative weight with the base rate.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.22.1",
                            Type = @"Component",
                            Position = @"DRG.22.1",
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
                            Id = @"DRG.22.2",
                            Type = @"Component",
                            Position = @"DRG.22.2",
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
                        },
                        }
        }

        _basicCharge = new HL7V26Field
        {
            field = message[@"DRG"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_basicCharge.field.FieldRepetitions != null && _basicCharge.field.FieldRepetitions.Count > 0)
        {
            _basicCharge.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_basicCharge, fieldData);
        }

        return _basicCharge;
    } 
}

internal HL7V26Field _totalCharge;

public HL7V26Field TotalCharge
{
    get
    {
        if (_totalCharge != null)
        {
            return _totalCharge;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.23",
            Type = @"Field",
            Position = @"DRG.23",
            Name = @"Total Charge",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"MO",
            DataTypeName = @"Money",
            TableId = null,
            TableName = null,
            Description = @"This field contains the total charge including surcharges or discounts.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.23.1",
                            Type = @"Component",
                            Position = @"DRG.23.1",
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
                            Id = @"DRG.23.2",
                            Type = @"Component",
                            Position = @"DRG.23.2",
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
                        },
                        }
        }

        _totalCharge = new HL7V26Field
        {
            field = message[@"DRG"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_totalCharge.field.FieldRepetitions != null && _totalCharge.field.FieldRepetitions.Count > 0)
        {
            _totalCharge.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_totalCharge, fieldData);
        }

        return _totalCharge;
    } 
}

internal HL7V26Field _discountSurcharge;

public HL7V26Field DiscountSurcharge
{
    get
    {
        if (_discountSurcharge != null)
        {
            return _discountSurcharge;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.24",
            Type = @"Field",
            Position = @"DRG.24",
            Name = @"Discount/Surcharge",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"MO",
            DataTypeName = @"Money",
            TableId = null,
            TableName = null,
            Description = @"This field contains the discount/surcharge as determined for this DRG. The addition/reduction is indicated by DRG-17 - Status Patient.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DRG.24.1",
                            Type = @"Component",
                            Position = @"DRG.24.1",
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
                            Id = @"DRG.24.2",
                            Type = @"Component",
                            Position = @"DRG.24.2",
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
                        },
                        }
        }

        _discountSurcharge = new HL7V26Field
        {
            field = message[@"DRG"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_discountSurcharge.field.FieldRepetitions != null && _discountSurcharge.field.FieldRepetitions.Count > 0)
        {
            _discountSurcharge.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_discountSurcharge, fieldData);
        }

        return _discountSurcharge;
    } 
}

internal HL7V26Field _calculatedDays;

public HL7V26Field CalculatedDays
{
    get
    {
        if (_calculatedDays != null)
        {
            return _calculatedDays;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.25",
            Type = @"Field",
            Position = @"DRG.25",
            Name = @"Calculated Days",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of days, for which a surcharge/discount has been determined. The addition/reduction is indicated by DRG-17 - Status Patient.",
            Sample = @"",
            Fields = null
        }

        _calculatedDays = new HL7V26Field
        {
            field = message[@"DRG"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_calculatedDays.field.FieldRepetitions != null && _calculatedDays.field.FieldRepetitions.Count > 0)
        {
            _calculatedDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_calculatedDays, fieldData);
        }

        return _calculatedDays;
    } 
}

internal HL7V26Field _statusGender;

public HL7V26Field StatusGender
{
    get
    {
        if (_statusGender != null)
        {
            return _statusGender;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.26",
            Type = @"Field",
            Position = @"DRG.26",
            Name = @"Status Gender",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0749",
            TableName = @"DRG Grouping Status",
            Description = @"This field contains the status of the use of the gender information for DRG determination. Refer toUser-defined Table 0749 - DRG Grouping Status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _statusGender = new HL7V26Field
        {
            field = message[@"DRG"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statusGender.field.FieldRepetitions != null && _statusGender.field.FieldRepetitions.Count > 0)
        {
            _statusGender.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statusGender, fieldData);
        }

        return _statusGender;
    } 
}

internal HL7V26Field _statusAge;

public HL7V26Field StatusAge
{
    get
    {
        if (_statusAge != null)
        {
            return _statusAge;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.27",
            Type = @"Field",
            Position = @"DRG.27",
            Name = @"Status Age",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0749",
            TableName = @"DRG Grouping Status",
            Description = @"This field contains the status of the use of the age information for DRG determination. Refer toUser-defined Table 0749 - DRG Grouping Status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _statusAge = new HL7V26Field
        {
            field = message[@"DRG"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statusAge.field.FieldRepetitions != null && _statusAge.field.FieldRepetitions.Count > 0)
        {
            _statusAge.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statusAge, fieldData);
        }

        return _statusAge;
    } 
}

internal HL7V26Field _statusLengthofStay;

public HL7V26Field StatusLengthofStay
{
    get
    {
        if (_statusLengthofStay != null)
        {
            return _statusLengthofStay;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.28",
            Type = @"Field",
            Position = @"DRG.28",
            Name = @"Status Length of Stay",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0749",
            TableName = @"DRG Grouping Status",
            Description = @"This field contains the status of the DRG calculation for the length of stay information. Refer toUser-defined Table 0749 - DRG Grouping Status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _statusLengthofStay = new HL7V26Field
        {
            field = message[@"DRG"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statusLengthofStay.field.FieldRepetitions != null && _statusLengthofStay.field.FieldRepetitions.Count > 0)
        {
            _statusLengthofStay.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statusLengthofStay, fieldData);
        }

        return _statusLengthofStay;
    } 
}

internal HL7V26Field _statusSameDayFlag;

public HL7V26Field StatusSameDayFlag
{
    get
    {
        if (_statusSameDayFlag != null)
        {
            return _statusSameDayFlag;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.29",
            Type = @"Field",
            Position = @"DRG.29",
            Name = @"Status Same Day Flag",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0749",
            TableName = @"DRG Grouping Status",
            Description = @"This field contains the status of the use of the same day information for DRG determination. Refer toUser-defined Table 0749 - DRG Grouping Status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _statusSameDayFlag = new HL7V26Field
        {
            field = message[@"DRG"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statusSameDayFlag.field.FieldRepetitions != null && _statusSameDayFlag.field.FieldRepetitions.Count > 0)
        {
            _statusSameDayFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statusSameDayFlag, fieldData);
        }

        return _statusSameDayFlag;
    } 
}

internal HL7V26Field _statusSeparationMode;

public HL7V26Field StatusSeparationMode
{
    get
    {
        if (_statusSeparationMode != null)
        {
            return _statusSeparationMode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.30",
            Type = @"Field",
            Position = @"DRG.30",
            Name = @"Status Separation Mode",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0749",
            TableName = @"DRG Grouping Status",
            Description = @"This field contains the status of the use of the separation mode information for DRG determination. Refer to User-defined Table 0749 - DRG Grouping Status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _statusSeparationMode = new HL7V26Field
        {
            field = message[@"DRG"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statusSeparationMode.field.FieldRepetitions != null && _statusSeparationMode.field.FieldRepetitions.Count > 0)
        {
            _statusSeparationMode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statusSeparationMode, fieldData);
        }

        return _statusSeparationMode;
    } 
}

internal HL7V26Field _statusWeightatBirth;

public HL7V26Field StatusWeightatBirth
{
    get
    {
        if (_statusWeightatBirth != null)
        {
            return _statusWeightatBirth;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.31",
            Type = @"Field",
            Position = @"DRG.31",
            Name = @"Status Weight at Birth",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0755",
            TableName = @"Status Weight At Birth",
            Description = @"This field contains the status of the use of the weight at birth information for DRG determination. Refer toUser-defined Table 0755 - DRG Status Weight At Birth for suggested values.",
            Sample = @"",
            Fields = null
        }

        _statusWeightatBirth = new HL7V26Field
        {
            field = message[@"DRG"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statusWeightatBirth.field.FieldRepetitions != null && _statusWeightatBirth.field.FieldRepetitions.Count > 0)
        {
            _statusWeightatBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statusWeightatBirth, fieldData);
        }

        return _statusWeightatBirth;
    } 
}

internal HL7V26Field _statusRespirationMinutes;

public HL7V26Field StatusRespirationMinutes
{
    get
    {
        if (_statusRespirationMinutes != null)
        {
            return _statusRespirationMinutes;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.32",
            Type = @"Field",
            Position = @"DRG.32",
            Name = @"Status Respiration Minutes",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0757",
            TableName = @"Status Respiration Minutes",
            Description = @"This field contains the status of the use of the respiration minutes information for DRG determination. Refer to User-defined Table 0757 - DRG Status Respiration Minutes for suggested values.",
            Sample = @"",
            Fields = null
        }

        _statusRespirationMinutes = new HL7V26Field
        {
            field = message[@"DRG"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statusRespirationMinutes.field.FieldRepetitions != null && _statusRespirationMinutes.field.FieldRepetitions.Count > 0)
        {
            _statusRespirationMinutes.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statusRespirationMinutes, fieldData);
        }

        return _statusRespirationMinutes;
    } 
}

internal HL7V26Field _statusAdmission;

public HL7V26Field StatusAdmission
{
    get
    {
        if (_statusAdmission != null)
        {
            return _statusAdmission;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DRG.33",
            Type = @"Field",
            Position = @"DRG.33",
            Name = @"Status Admission",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0759",
            TableName = @"Status Admission",
            Description = @"This field contains the admission status for the DRG determination. Refer to User-defined Table 0759 - DRG Status Admission for suggested values.",
            Sample = @"",
            Fields = null
        }

        _statusAdmission = new HL7V26Field
        {
            field = message[@"DRG"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statusAdmission.field.FieldRepetitions != null && _statusAdmission.field.FieldRepetitions.Count > 0)
        {
            _statusAdmission.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statusAdmission, fieldData);
        }

        return _statusAdmission;
    } 
}
    }
}
