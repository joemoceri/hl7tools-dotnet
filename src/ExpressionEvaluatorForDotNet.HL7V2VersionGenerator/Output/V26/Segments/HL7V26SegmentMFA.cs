using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentMFA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MFA"; } }

        public string SegmentId { get { return @"MFA"; } }
        
        public string LongName { get { return @"Master File Acknowledgment"; } }
        
        public string Description { get { return @"The Technical Steward for the MFA segment is Infrastructure and Messaging."; } }
        
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

        public HL7V26SegmentMFA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _recordLevelEventCode;

public HL7V26Field RecordLevelEventCode
{
    get
    {
        if (_recordLevelEventCode != null)
        {
            return _recordLevelEventCode;
        }

        var fieldData = new HL7V26FieldData
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
            TableName = @"Record-level event code",
            Description = @"This field defines record-level event for the master file record identified by the MFI segment and the primary key in this segment. Refer to HL7 table 0180 - Record level event code for valid values.

Note: If the MFI-3 - File-level event code is ""REP"" (replace file), then each MFA segment must have an MFA-1 - Record-level event code of ""MAD"" (add record to master file).",
            Sample = @"",
            Fields = null
        }

        _recordLevelEventCode = new HL7V26Field
        {
            field = message[@"MFA"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recordLevelEventCode.field.FieldRepetitions != null && _recordLevelEventCode.field.FieldRepetitions.Count > 0)
        {
            _recordLevelEventCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_recordLevelEventCode, fieldData);
        }

        return _recordLevelEventCode;
    } 
}

internal HL7V26Field _mFNControlID;

public HL7V26Field MFNControlID
{
    get
    {
        if (_mFNControlID != null)
        {
            return _mFNControlID;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"This field contains a number or other identifier that uniquely identifies this change to this record from the point of view of the originating system. This field uniquely identifies the particular record (identified by the MFE segment) being acknowledged by this MFA segment. When returned to the originating system via the MFA segment, this field allows the target system to precisely identify which change to this record is being acknowledged. It is only required if MFI-6 - Response Level Code requires responses at the record level (any value other than NE).",
            Sample = @"",
            Fields = null
        }

        _mFNControlID = new HL7V26Field
        {
            field = message[@"MFA"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mFNControlID.field.FieldRepetitions != null && _mFNControlID.field.FieldRepetitions.Count > 0)
        {
            _mFNControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_mFNControlID, fieldData);
        }

        return _mFNControlID;
    } 
}

internal HL7V26Field _eventCompletionDateTime;

public HL7V26Field EventCompletionDateTime
{
    get
    {
        if (_eventCompletionDateTime != null)
        {
            return _eventCompletionDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"MFA.3",
            Type = @"Field",
            Position = @"MFA.3",
            Name = @"Event Completion Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field may be required or optional depending on the site specifications for the given master file, master file event, and receiving facility.",
            Sample = @"",
            Fields = null
        }

        _eventCompletionDateTime = new HL7V26Field
        {
            field = message[@"MFA"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventCompletionDateTime.field.FieldRepetitions != null && _eventCompletionDateTime.field.FieldRepetitions.Count > 0)
        {
            _eventCompletionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_eventCompletionDateTime, fieldData);
        }

        return _eventCompletionDateTime;
    } 
}

internal HL7V26Field _mFNRecordLevelErrorReturn;

public HL7V26Field MFNRecordLevelErrorReturn
{
    get
    {
        if (_mFNRecordLevelErrorReturn != null)
        {
            return _mFNRecordLevelErrorReturn;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"MFA.4",
            Type = @"Field",
            Position = @"MFA.4",
            Name = @"MFN Record Level Error Return",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
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
                            Id = @"MFA.4.2",
                            Type = @"Component",
                            Position = @"MFA.4.2",
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
                            Id = @"MFA.4.3",
                            Type = @"Component",
                            Position = @"MFA.4.3",
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
                            Id = @"MFA.4.4",
                            Type = @"Component",
                            Position = @"MFA.4.4",
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
                            Id = @"MFA.4.5",
                            Type = @"Component",
                            Position = @"MFA.4.5",
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
                            Id = @"MFA.4.6",
                            Type = @"Component",
                            Position = @"MFA.4.6",
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
                            Id = @"MFA.4.7",
                            Type = @"Component",
                            Position = @"MFA.4.7",
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
                            Id = @"MFA.4.8",
                            Type = @"Component",
                            Position = @"MFA.4.8",
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
                            Id = @"MFA.4.9",
                            Type = @"Component",
                            Position = @"MFA.4.9",
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

        _mFNRecordLevelErrorReturn = new HL7V26Field
        {
            field = message[@"MFA"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mFNRecordLevelErrorReturn.field.FieldRepetitions != null && _mFNRecordLevelErrorReturn.field.FieldRepetitions.Count > 0)
        {
            _mFNRecordLevelErrorReturn.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_mFNRecordLevelErrorReturn, fieldData);
        }

        return _mFNRecordLevelErrorReturn;
    } 
}

internal HL7V26Field _primaryKeyValueMFA;

public HL7V26Field PrimaryKeyValueMFA
{
    get
    {
        if (_primaryKeyValueMFA != null)
        {
            return _primaryKeyValueMFA;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"MFA.5",
            Type = @"Field",
            Position = @"MFA.5",
            Name = @"Primary Key Value - MFA",
            Length = 250,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the record of the master file (identified in the MFI segment) for which the update status is being acknowledged (as defined by the field MFN-4 - Record Level Error Return ). The data type of this field is defined by the value of MFA-6 - Value Type - MFA, and may take on the format of any of the HL7 data types defined in HL7 table 0355 - Primary Key Value Type . The PL data type is used only on location master transactions.",
            Sample = @"",
            Fields = null
        }

        _primaryKeyValueMFA = new HL7V26Field
        {
            field = message[@"MFA"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryKeyValueMFA.field.FieldRepetitions != null && _primaryKeyValueMFA.field.FieldRepetitions.Count > 0)
        {
            _primaryKeyValueMFA.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_primaryKeyValueMFA, fieldData);
        }

        return _primaryKeyValueMFA;
    } 
}

internal HL7V26Field _primaryKeyValueTypeMFA;

public HL7V26Field PrimaryKeyValueTypeMFA
{
    get
    {
        if (_primaryKeyValueTypeMFA != null)
        {
            return _primaryKeyValueTypeMFA;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"MFA.6",
            Type = @"Field",
            Position = @"MFA.6",
            Name = @"Primary Key Value Type - MFA",
            Length = 3,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0355",
            TableName = @"Primary key value type",
            Description = @"This field contains the HL7 data type of MFA-5 - Primary Key Value - MFA. The valid HL7 data types are listed in HL7 table 0355 - Primary key value type .",
            Sample = @"",
            Fields = null
        }

        _primaryKeyValueTypeMFA = new HL7V26Field
        {
            field = message[@"MFA"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryKeyValueTypeMFA.field.FieldRepetitions != null && _primaryKeyValueTypeMFA.field.FieldRepetitions.Count > 0)
        {
            _primaryKeyValueTypeMFA.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_primaryKeyValueTypeMFA, fieldData);
        }

        return _primaryKeyValueTypeMFA;
    } 
}
    }
}
