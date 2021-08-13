using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentMFA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MFA"; } }

        public string SegmentId { get { return @"MFA"; } }
        
        public string LongName { get { return @"Master file acknowledgement segment"; } }
        
        public string Description { get { return @"The MFA segment contains the following fields as defined in Figure 8-3 - MFA attributes."; } }
        
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

        public HL7V23SegmentMFA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _recordLevelEventCode;

public HL7V23Field RecordLevelEventCode
{
    get
    {
        if (_recordLevelEventCode != null)
        {
            return _recordLevelEventCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MFA.1",
            Type = @"Field",
            Position = @"MFA.1",
            Name = @"Record-Level Event Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0180",
            TableName = @"Record Level Event Code ",
            Description = @"This field defines record-level event for the master file record identified by the MFI segment and the primary key in this segment. Refer to HL7 table 0180 - Record level event code for valid values.",
            Sample = @"",
            Fields = null
        }

        _recordLevelEventCode = new HL7V23Field
        {
            field = message[@"MFA"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recordLevelEventCode.field.FieldRepetitions != null && _recordLevelEventCode.field.FieldRepetitions.Count > 0)
        {
            _recordLevelEventCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_recordLevelEventCode, fieldData);
        }

        return _recordLevelEventCode;
    } 
}

internal HL7V23Field _mFNControlID;

public HL7V23Field MFNControlID
{
    get
    {
        if (_mFNControlID != null)
        {
            return _mFNControlID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MFA.2",
            Type = @"Field",
            Position = @"MFA.2",
            Name = @"MFN Control ID",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number or other identifier that uniquely identifies this change to this record from the point of view of the originating system. This field uniquely identifies the particular record (identified by the MFE segment) being acknowledged by this MFA segment. When returned to the originating system via the MFA segment, this field allows the target system to precisely identify which change to this record is being acknowledged. It is only required if MFI-6-response level code requires responses at the record level (any value other than NE).",
            Sample = @"",
            Fields = null
        }

        _mFNControlID = new HL7V23Field
        {
            field = message[@"MFA"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mFNControlID.field.FieldRepetitions != null && _mFNControlID.field.FieldRepetitions.Count > 0)
        {
            _mFNControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_mFNControlID, fieldData);
        }

        return _mFNControlID;
    } 
}

internal HL7V23Field _eventCompletionDateTime;

public HL7V23Field EventCompletionDateTime
{
    get
    {
        if (_eventCompletionDateTime != null)
        {
            return _eventCompletionDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MFA.3",
            Type = @"Field",
            Position = @"MFA.3",
            Name = @"Event Completion Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field may be required or optional depending on the site specifications for the given master file, master file event, and receiving facility.",
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
                        }
        }

        _eventCompletionDateTime = new HL7V23Field
        {
            field = message[@"MFA"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventCompletionDateTime.field.FieldRepetitions != null && _eventCompletionDateTime.field.FieldRepetitions.Count > 0)
        {
            _eventCompletionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventCompletionDateTime, fieldData);
        }

        return _eventCompletionDateTime;
    } 
}

internal HL7V23Field _errorReturnCodeandorText;

public HL7V23Field ErrorReturnCodeandorText
{
    get
    {
        if (_errorReturnCodeandorText != null)
        {
            return _errorReturnCodeandorText;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MFA.4",
            Type = @"Field",
            Position = @"MFA.4",
            Name = @"Error Return Code and/or Text",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0181",
            TableName = @"MFN record-level error return",
            Description = @"This field contains the status of the requested update. Site-defined table, specific to each master file being updated via this transaction.",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _errorReturnCodeandorText = new HL7V23Field
        {
            field = message[@"MFA"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_errorReturnCodeandorText.field.FieldRepetitions != null && _errorReturnCodeandorText.field.FieldRepetitions.Count > 0)
        {
            _errorReturnCodeandorText.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_errorReturnCodeandorText, fieldData);
        }

        return _errorReturnCodeandorText;
    } 
}

internal HL7V23Field _primaryKeyValue;

public HL7V23Field PrimaryKeyValue
{
    get
    {
        if (_primaryKeyValue != null)
        {
            return _primaryKeyValue;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field uniquely identifies the record of the master file (identified in the MFI segment) to be changed (as defined by the record-level event code). The first component of this CE data field carries an optional subcomponent, the application ID, that uniquely identifies the application responsible for creating the primary key value. The application ID subcomponent can be used to guarantee uniqueness of the primary key across multiple applications.

The repetition of the primary key permits the identification of an individual component of a complex record as the object of the record-level event code. This feature allows the Master Files protocol to be used for modifications of single components of complex records.",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _primaryKeyValue = new HL7V23Field
        {
            field = message[@"MFA"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryKeyValue.field.FieldRepetitions != null && _primaryKeyValue.field.FieldRepetitions.Count > 0)
        {
            _primaryKeyValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_primaryKeyValue, fieldData);
        }

        return _primaryKeyValue;
    } 
}
    }
}
