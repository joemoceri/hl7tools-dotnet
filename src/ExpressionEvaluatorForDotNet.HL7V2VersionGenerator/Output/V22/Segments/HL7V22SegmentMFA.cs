using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentMFA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MFA"; } }

        public string SegmentId { get { return @"MFA"; } }
        
        public string LongName { get { return @"Master File Acknowledgement"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V22SegmentMFA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _recordlevelEventCode;

public HL7V22Field RecordlevelEventCode
{
    get
    {
        if (_recordlevelEventCode != null)
        {
            return _recordlevelEventCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MFA.1",
            Type = @"Field",
            Position = @"MFA.1",
            Name = @"Record-level Event Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0180",
            TableName = @"RECORD LEVEL EVENT CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _recordlevelEventCode = new HL7V22Field
        {
            field = message[@"MFA"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recordlevelEventCode.field.FieldRepetitions != null && _recordlevelEventCode.field.FieldRepetitions.Count > 0)
        {
            _recordlevelEventCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_recordlevelEventCode, fieldData);
        }

        return _recordlevelEventCode;
    } 
}

internal HL7V22Field _mfnControlId;

public HL7V22Field MfnControlId
{
    get
    {
        if (_mfnControlId != null)
        {
            return _mfnControlId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MFA.2",
            Type = @"Field",
            Position = @"MFA.2",
            Name = @"Mfn Control Id",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _mfnControlId = new HL7V22Field
        {
            field = message[@"MFA"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mfnControlId.field.FieldRepetitions != null && _mfnControlId.field.FieldRepetitions.Count > 0)
        {
            _mfnControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_mfnControlId, fieldData);
        }

        return _mfnControlId;
    } 
}

internal HL7V22Field _eventCompletionDateTime;

public HL7V22Field EventCompletionDateTime
{
    get
    {
        if (_eventCompletionDateTime != null)
        {
            return _eventCompletionDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MFA.3",
            Type = @"Field",
            Position = @"MFA.3",
            Name = @"Event Completion Date / Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MFA.3.1",
                            Type = @"Component",
                            Position = @"MFA.3.1",
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
                            Id = @"MFA.3.2",
                            Type = @"Component",
                            Position = @"MFA.3.2",
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
                        },
                        }
        }

        _eventCompletionDateTime = new HL7V22Field
        {
            field = message[@"MFA"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventCompletionDateTime.field.FieldRepetitions != null && _eventCompletionDateTime.field.FieldRepetitions.Count > 0)
        {
            _eventCompletionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_eventCompletionDateTime, fieldData);
        }

        return _eventCompletionDateTime;
    } 
}

internal HL7V22Field _errorReturnCodeAndOrText;

public HL7V22Field ErrorReturnCodeAndOrText
{
    get
    {
        if (_errorReturnCodeAndOrText != null)
        {
            return _errorReturnCodeAndOrText;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MFA.4",
            Type = @"Field",
            Position = @"MFA.4",
            Name = @"Error Return Code And/Or Text",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0181",
            TableName = @"MFN RECORD-LEVEL ERROR RETURN",
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MFA.4.1",
                            Type = @"Component",
                            Position = @"MFA.4.1",
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
                            Id = @"MFA.4.2",
                            Type = @"Component",
                            Position = @"MFA.4.2",
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
                            Id = @"MFA.4.3",
                            Type = @"Component",
                            Position = @"MFA.4.3",
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
                            Id = @"MFA.4.4",
                            Type = @"Component",
                            Position = @"MFA.4.4",
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
                            Id = @"MFA.4.5",
                            Type = @"Component",
                            Position = @"MFA.4.5",
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
                            Id = @"MFA.4.6",
                            Type = @"Component",
                            Position = @"MFA.4.6",
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
                        },
                        }
        }

        _errorReturnCodeAndOrText = new HL7V22Field
        {
            field = message[@"MFA"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_errorReturnCodeAndOrText.field.FieldRepetitions != null && _errorReturnCodeAndOrText.field.FieldRepetitions.Count > 0)
        {
            _errorReturnCodeAndOrText.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_errorReturnCodeAndOrText, fieldData);
        }

        return _errorReturnCodeAndOrText;
    } 
}

internal HL7V22Field _primaryKeyValue;

public HL7V22Field PrimaryKeyValue
{
    get
    {
        if (_primaryKeyValue != null)
        {
            return _primaryKeyValue;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MFA.5",
            Type = @"Field",
            Position = @"MFA.5",
            Name = @"Primary Key Value",
            Length = 60,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MFA.5.1",
                            Type = @"Component",
                            Position = @"MFA.5.1",
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
                            Id = @"MFA.5.2",
                            Type = @"Component",
                            Position = @"MFA.5.2",
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
                            Id = @"MFA.5.3",
                            Type = @"Component",
                            Position = @"MFA.5.3",
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
                            Id = @"MFA.5.4",
                            Type = @"Component",
                            Position = @"MFA.5.4",
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
                            Id = @"MFA.5.5",
                            Type = @"Component",
                            Position = @"MFA.5.5",
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
                            Id = @"MFA.5.6",
                            Type = @"Component",
                            Position = @"MFA.5.6",
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
                        },
                        }
        }

        _primaryKeyValue = new HL7V22Field
        {
            field = message[@"MFA"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryKeyValue.field.FieldRepetitions != null && _primaryKeyValue.field.FieldRepetitions.Count > 0)
        {
            _primaryKeyValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_primaryKeyValue, fieldData);
        }

        return _primaryKeyValue;
    } 
}
    }
}
