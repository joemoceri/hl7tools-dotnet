using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentERR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ERR"; } }

        public string SegmentId { get { return @"ERR"; } }
        
        public string LongName { get { return @"Error"; } }
        
        public string Description { get { return @"The ERR segment is used to add error comments to acknowledgment messages."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V251SegmentERR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _errorCodeandLocation;

public HL7V251Field ErrorCodeandLocation
{
    get
    {
        if (_errorCodeandLocation != null)
        {
            return _errorCodeandLocation;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.1",
            Type = @"Field",
            Position = @"ERR.1",
            Name = @"Error Code and Location",
            Length = 493,
            Usage = @"B",
            Rpt = @"*",
            DataType = @"ELD",
            DataTypeName = @"Error Location and Description",
            TableId = null,
            TableName = null,
            Description = @"This field identifies an erroneous segment in another message. Retained for backward compatibility only as of v 2.5; refer to ERR-2 and ERR-3 instead.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERR.1.1",
                            Type = @"Component",
                            Position = @"ERR.1.1",
                            Name = @"Segment Id",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The segment containing the error in another message",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.2",
                            Type = @"Component",
                            Position = @"ERR.1.2",
                            Name = @"Segment Sequence",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the specific occurrence if the segment specified in component 1 occurs more than once in the message.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.3",
                            Type = @"Component",
                            Position = @"ERR.1.3",
                            Name = @"Field Position",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Ordinal position of the data field within the segment. For systems that do not use the HL7 Encoding Rules, the data item number may be used for the third component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4",
                            Type = @"Component",
                            Position = @"ERR.1.4",
                            Name = @"Code Identifying Error",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0357",
                            TableName = @"Message error condition codes",
                            Description = @"A code that describes the nature of the error. Refer to HL7 Table 0357 - Message error condition codes for valid values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.1",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.1",
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
                            Id = @"ERR.1.4.2",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.2",
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
                            Id = @"ERR.1.4.3",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.3",
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
                            Id = @"ERR.1.4.4",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.4",
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
                            Id = @"ERR.1.4.5",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.5",
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
                            Id = @"ERR.1.4.6",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.6",
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
                        }
        }

        _errorCodeandLocation = new HL7V251Field
        {
            field = message[@"ERR"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_errorCodeandLocation.field.FieldRepetitions != null && _errorCodeandLocation.field.FieldRepetitions.Count > 0)
        {
            _errorCodeandLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_errorCodeandLocation, fieldData);
        }

        return _errorCodeandLocation;
    } 
}

internal HL7V251Field _errorLocation;

public HL7V251Field ErrorLocation
{
    get
    {
        if (_errorLocation != null)
        {
            return _errorLocation;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.2",
            Type = @"Field",
            Position = @"ERR.2",
            Name = @"Error Location",
            Length = 18,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ERL",
            DataTypeName = @"Error Location",
            TableId = null,
            TableName = null,
            Description = @"Identifies the location in a message related to the identified error, warning or message. If multiple repetitions are present, the error results from the values in a combination of places.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERR.2.1",
                            Type = @"Component",
                            Position = @"ERR.2.1",
                            Name = @"Segment Id",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the 3-letter name for the segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.2.2",
                            Type = @"Component",
                            Position = @"ERR.2.2",
                            Name = @"Segment Sequence",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the segment occurrence within the message.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.2.3",
                            Type = @"Component",
                            Position = @"ERR.2.3",
                            Name = @"Field Position",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the number of the field within the segment. The first field is assigned a number of 1. Field number should not be specified when referring to the entire segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.2.4",
                            Type = @"Component",
                            Position = @"ERR.2.4",
                            Name = @"Field Repetition",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the repetition number of the field. The first repetition is counted as 1. If a Field Position is specified, but Field Repetition is not, Field Repetition should be assumed to be 1. If Field Position is not specified, Field Repetition should not be specified.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.2.5",
                            Type = @"Component",
                            Position = @"ERR.2.5",
                            Name = @"Component Number",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the number of the component within the field. The first component is assigned a number of 1. Component number should not be specified when referring to the entire field.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.2.6",
                            Type = @"Component",
                            Position = @"ERR.2.6",
                            Name = @"Sub-component Number",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the number of the sub-component within the component. The first sub-component is assigned a number of 1. Sub-component number should not be specified when referring to the entire component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _errorLocation = new HL7V251Field
        {
            field = message[@"ERR"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_errorLocation.field.FieldRepetitions != null && _errorLocation.field.FieldRepetitions.Count > 0)
        {
            _errorLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_errorLocation, fieldData);
        }

        return _errorLocation;
    } 
}

internal HL7V251Field _hL7ErrorCode;

public HL7V251Field HL7ErrorCode
{
    get
    {
        if (_hL7ErrorCode != null)
        {
            return _hL7ErrorCode;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.3",
            Type = @"Field",
            Position = @"ERR.3",
            Name = @"HL7 Error Code",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0357",
            TableName = @"Message error condition codes",
            Description = @"Identifies the HL7 (communications) error code. Refer to HL7 Table 0357 - Message Error Condition Codes for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERR.3.1",
                            Type = @"Component",
                            Position = @"ERR.3.1",
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
                            Id = @"ERR.3.2",
                            Type = @"Component",
                            Position = @"ERR.3.2",
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
                            Id = @"ERR.3.3",
                            Type = @"Component",
                            Position = @"ERR.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.3.4",
                            Type = @"Component",
                            Position = @"ERR.3.4",
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
                            Id = @"ERR.3.5",
                            Type = @"Component",
                            Position = @"ERR.3.5",
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
                            Id = @"ERR.3.6",
                            Type = @"Component",
                            Position = @"ERR.3.6",
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
                            Id = @"ERR.3.7",
                            Type = @"Component",
                            Position = @"ERR.3.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.3.8",
                            Type = @"Component",
                            Position = @"ERR.3.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.3.9",
                            Type = @"Component",
                            Position = @"ERR.3.9",
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

        _hL7ErrorCode = new HL7V251Field
        {
            field = message[@"ERR"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_hL7ErrorCode.field.FieldRepetitions != null && _hL7ErrorCode.field.FieldRepetitions.Count > 0)
        {
            _hL7ErrorCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_hL7ErrorCode, fieldData);
        }

        return _hL7ErrorCode;
    } 
}

internal HL7V251Field _severity;

public HL7V251Field Severity
{
    get
    {
        if (_severity != null)
        {
            return _severity;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.4",
            Type = @"Field",
            Position = @"ERR.4",
            Name = @"Severity",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0516",
            TableName = @"Error severity",
            Description = @"Identifies the severity of an application error. Knowing if something is Error, Warning or Information is intrinsic to how an application handles the content. Refer to HL7 Table 0516 - Error severity for valid values. If ERR-3 has a value of ""0"", ERR-4 will have a value of ""I"".",
            Sample = @"",
            Fields = null
        }

        _severity = new HL7V251Field
        {
            field = message[@"ERR"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_severity.field.FieldRepetitions != null && _severity.field.FieldRepetitions.Count > 0)
        {
            _severity.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_severity, fieldData);
        }

        return _severity;
    } 
}

internal HL7V251Field _applicationErrorCode;

public HL7V251Field ApplicationErrorCode
{
    get
    {
        if (_applicationErrorCode != null)
        {
            return _applicationErrorCode;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.5",
            Type = @"Field",
            Position = @"ERR.5",
            Name = @"Application Error Code",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0533",
            TableName = @"Application error code",
            Description = @"Application specific code identifying the specific error that occurred. Refer to User-Defined Table 0533 - Application Error Code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERR.5.1",
                            Type = @"Component",
                            Position = @"ERR.5.1",
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
                            Id = @"ERR.5.2",
                            Type = @"Component",
                            Position = @"ERR.5.2",
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
                            Id = @"ERR.5.3",
                            Type = @"Component",
                            Position = @"ERR.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.5.4",
                            Type = @"Component",
                            Position = @"ERR.5.4",
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
                            Id = @"ERR.5.5",
                            Type = @"Component",
                            Position = @"ERR.5.5",
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
                            Id = @"ERR.5.6",
                            Type = @"Component",
                            Position = @"ERR.5.6",
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
                            Id = @"ERR.5.7",
                            Type = @"Component",
                            Position = @"ERR.5.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.5.8",
                            Type = @"Component",
                            Position = @"ERR.5.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.5.9",
                            Type = @"Component",
                            Position = @"ERR.5.9",
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

        _applicationErrorCode = new HL7V251Field
        {
            field = message[@"ERR"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_applicationErrorCode.field.FieldRepetitions != null && _applicationErrorCode.field.FieldRepetitions.Count > 0)
        {
            _applicationErrorCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_applicationErrorCode, fieldData);
        }

        return _applicationErrorCode;
    } 
}

internal HL7V251Field _applicationErrorParameter;

public HL7V251Field ApplicationErrorParameter
{
    get
    {
        if (_applicationErrorParameter != null)
        {
            return _applicationErrorParameter;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.6",
            Type = @"Field",
            Position = @"ERR.6",
            Name = @"Application Error Parameter",
            Length = 80,
            Usage = @"O",
            Rpt = @"10",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Additional information to be used, together with the Application Error Code, to understand a particular error condition/warning/etc. This field can repeat to allow for up to 10 parameters.",
            Sample = @"",
            Fields = null
        }

        _applicationErrorParameter = new HL7V251Field
        {
            field = message[@"ERR"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_applicationErrorParameter.field.FieldRepetitions != null && _applicationErrorParameter.field.FieldRepetitions.Count > 0)
        {
            _applicationErrorParameter.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_applicationErrorParameter, fieldData);
        }

        return _applicationErrorParameter;
    } 
}

internal HL7V251Field _diagnosticInformation;

public HL7V251Field DiagnosticInformation
{
    get
    {
        if (_diagnosticInformation != null)
        {
            return _diagnosticInformation;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.7",
            Type = @"Field",
            Position = @"ERR.7",
            Name = @"Diagnostic Information",
            Length = 2048,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"Information that may be used by help desk or other support personnel to diagnose a problem.",
            Sample = @"",
            Fields = null
        }

        _diagnosticInformation = new HL7V251Field
        {
            field = message[@"ERR"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosticInformation.field.FieldRepetitions != null && _diagnosticInformation.field.FieldRepetitions.Count > 0)
        {
            _diagnosticInformation.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_diagnosticInformation, fieldData);
        }

        return _diagnosticInformation;
    } 
}

internal HL7V251Field _userMessage;

public HL7V251Field UserMessage
{
    get
    {
        if (_userMessage != null)
        {
            return _userMessage;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.8",
            Type = @"Field",
            Position = @"ERR.8",
            Name = @"User Message",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"The text message to be displayed to the application user.",
            Sample = @"",
            Fields = null
        }

        _userMessage = new HL7V251Field
        {
            field = message[@"ERR"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_userMessage.field.FieldRepetitions != null && _userMessage.field.FieldRepetitions.Count > 0)
        {
            _userMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_userMessage, fieldData);
        }

        return _userMessage;
    } 
}

internal HL7V251Field _informPersonIndicator;

public HL7V251Field InformPersonIndicator
{
    get
    {
        if (_informPersonIndicator != null)
        {
            return _informPersonIndicator;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.9",
            Type = @"Field",
            Position = @"ERR.9",
            Name = @"Inform Person Indicator",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0517",
            TableName = @"Inform person code",
            Description = @"A code to indicate who (if anyone) should be informed of the error. This field may also be used to indicate that a particular person should NOT be informed of the error (e.g. Do not inform patient). Refer to User-defined table 0517- Inform Person Code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _informPersonIndicator = new HL7V251Field
        {
            field = message[@"ERR"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_informPersonIndicator.field.FieldRepetitions != null && _informPersonIndicator.field.FieldRepetitions.Count > 0)
        {
            _informPersonIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_informPersonIndicator, fieldData);
        }

        return _informPersonIndicator;
    } 
}

internal HL7V251Field _overrideType;

public HL7V251Field OverrideType
{
    get
    {
        if (_overrideType != null)
        {
            return _overrideType;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.10",
            Type = @"Field",
            Position = @"ERR.10",
            Name = @"Override Type",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0518",
            TableName = @"Override type",
            Description = @"Identifies what type of override can be used to override the specific error identified. Refer to User-defined table 0518 Override Type for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERR.10.1",
                            Type = @"Component",
                            Position = @"ERR.10.1",
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
                            Id = @"ERR.10.2",
                            Type = @"Component",
                            Position = @"ERR.10.2",
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
                            Id = @"ERR.10.3",
                            Type = @"Component",
                            Position = @"ERR.10.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.10.4",
                            Type = @"Component",
                            Position = @"ERR.10.4",
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
                            Id = @"ERR.10.5",
                            Type = @"Component",
                            Position = @"ERR.10.5",
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
                            Id = @"ERR.10.6",
                            Type = @"Component",
                            Position = @"ERR.10.6",
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
                            Id = @"ERR.10.7",
                            Type = @"Component",
                            Position = @"ERR.10.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.10.8",
                            Type = @"Component",
                            Position = @"ERR.10.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.10.9",
                            Type = @"Component",
                            Position = @"ERR.10.9",
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

        _overrideType = new HL7V251Field
        {
            field = message[@"ERR"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_overrideType.field.FieldRepetitions != null && _overrideType.field.FieldRepetitions.Count > 0)
        {
            _overrideType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_overrideType, fieldData);
        }

        return _overrideType;
    } 
}

internal HL7V251Field _overrideReasonCode;

public HL7V251Field OverrideReasonCode
{
    get
    {
        if (_overrideReasonCode != null)
        {
            return _overrideReasonCode;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.11",
            Type = @"Field",
            Position = @"ERR.11",
            Name = @"Override Reason Code",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0519",
            TableName = @"Override reason",
            Description = @"Provides a list of potential override codes that can be used to override enforcement of the application rule that generated the error. Refer to User-defined table 0519 - Override Reason for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERR.11.1",
                            Type = @"Component",
                            Position = @"ERR.11.1",
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
                            Id = @"ERR.11.2",
                            Type = @"Component",
                            Position = @"ERR.11.2",
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
                            Id = @"ERR.11.3",
                            Type = @"Component",
                            Position = @"ERR.11.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.11.4",
                            Type = @"Component",
                            Position = @"ERR.11.4",
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
                            Id = @"ERR.11.5",
                            Type = @"Component",
                            Position = @"ERR.11.5",
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
                            Id = @"ERR.11.6",
                            Type = @"Component",
                            Position = @"ERR.11.6",
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
                            Id = @"ERR.11.7",
                            Type = @"Component",
                            Position = @"ERR.11.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.11.8",
                            Type = @"Component",
                            Position = @"ERR.11.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.11.9",
                            Type = @"Component",
                            Position = @"ERR.11.9",
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

        _overrideReasonCode = new HL7V251Field
        {
            field = message[@"ERR"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_overrideReasonCode.field.FieldRepetitions != null && _overrideReasonCode.field.FieldRepetitions.Count > 0)
        {
            _overrideReasonCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_overrideReasonCode, fieldData);
        }

        return _overrideReasonCode;
    } 
}

internal HL7V251Field _helpDeskContactPoint;

public HL7V251Field HelpDeskContactPoint
{
    get
    {
        if (_helpDeskContactPoint != null)
        {
            return _helpDeskContactPoint;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"ERR.12",
            Type = @"Field",
            Position = @"ERR.12",
            Name = @"Help Desk Contact Point",
            Length = 652,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"Lists phone, e-mail, fax, and other relevant numbers for helpdesk support related to the specified error.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERR.12.1",
                            Type = @"Component",
                            Position = @"ERR.12.1",
                            Name = @"Telephone Number",
                            Length = 199,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"This component has been retained for backward compatibility only as of version 2.3. 

Specifies the telephone number in a predetermined format that includes an optional extension, beeper number and comment.

Format: [NNN] [(999)]999-9999 [X99999] [B99999] [C any text] ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.12.2",
                            Type = @"Component",
                            Position = @"ERR.12.2",
                            Name = @"Telecommunication Use Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 Table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.12.3",
                            Type = @"Component",
                            Position = @"ERR.12.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 Table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.12.4",
                            Type = @"Component",
                            Position = @"ERR.12.4",
                            Name = @"Email Address",
                            Length = 199,
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
                            Id = @"ERR.12.5",
                            Type = @"Component",
                            Position = @"ERR.12.5",
                            Name = @"Country Code",
                            Length = 3,
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
                            Id = @"ERR.12.6",
                            Type = @"Component",
                            Position = @"ERR.12.6",
                            Name = @"Area/City Code",
                            Length = 5,
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
                            Id = @"ERR.12.7",
                            Type = @"Component",
                            Position = @"ERR.12.7",
                            Name = @"Local Number",
                            Length = 9,
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
                            Id = @"ERR.12.8",
                            Type = @"Component",
                            Position = @"ERR.12.8",
                            Name = @"Extension",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains comments with respect to the telephone number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.12.9",
                            Type = @"Component",
                            Position = @"ERR.12.9",
                            Name = @"Any Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The characters established within a companys internal telephone system network used as a prefix to the Extension component for internal dialing. Note that the use of Extension Prefix requires that the Extension component be valued and that digits, as well as special characters (e.g., *, #) may be used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.12.10",
                            Type = @"Component",
                            Position = @"ERR.12.10",
                            Name = @"Extension Prefix",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The characters established within a companys internal telephone system used in place of the (external) telephone number to facilitate calling because its length is shorter than that of the telephone number. Note that digits, as well as special characters (e.g., *, #) may be used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.12.11",
                            Type = @"Component",
                            Position = @"ERR.12.11",
                            Name = @"Speed Dial Code",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An expression of the telephone number as an unparsible string.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.12.12",
                            Type = @"Component",
                            Position = @"ERR.12.12",
                            Name = @"Unformatted Telephone Number",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @" An expression of the telephone number as an unparsible string

Example: |^^^^^^^^^^^1-800-Dentist| ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _helpDeskContactPoint = new HL7V251Field
        {
            field = message[@"ERR"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_helpDeskContactPoint.field.FieldRepetitions != null && _helpDeskContactPoint.field.FieldRepetitions.Count > 0)
        {
            _helpDeskContactPoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_helpDeskContactPoint, fieldData);
        }

        return _helpDeskContactPoint;
    } 
}
    }
}
