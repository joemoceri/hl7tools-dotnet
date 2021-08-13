using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentMFE
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MFE"; } }

        public string SegmentId { get { return @"MFE"; } }
        
        public string LongName { get { return @"Master file entry segment"; } }
        
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

        public HL7V23SegmentMFE(HL7V2Message message)
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
            Id = @"MFE.1",
            Type = @"Field",
            Position = @"MFE.1",
            Name = @"Record-Level Event Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0180",
            TableName = @"Record Level Event Code ",
            Description = @"This field defines the record-level event for the master file record identified by the MFI segment and the primary key field in this segment.   Refer to HL7 table 0180 - Record level event code for valid values. ",
            Sample = @"",
            Fields = null
        }

        _recordLevelEventCode = new HL7V23Field
        {
            field = message[@"MFE"][1],
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
            Id = @"MFE.2",
            Type = @"Field",
            Position = @"MFE.2",
            Name = @"MFN Control ID",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"A number or other identifier that uniquely identifies this change to this record from the point of view of the originating system.  When returned to the originating system via the MFA segment, this field allows the target system to precisely identify which change to this record is being acknowledged.  It is only required if the MFI response level code requires responses at the record level (any value other than NE). 

Note:  Note that this segment does not contain a Set ID field. The MFE-2-MFN control ID implements a more general concept than the Set ID. It takes the place of the SET ID in the MFE segment. ",
            Sample = @"",
            Fields = null
        }

        _mFNControlID = new HL7V23Field
        {
            field = message[@"MFE"][2],
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

internal HL7V23Field _effectiveDateTime;

public HL7V23Field EffectiveDateTime
{
    get
    {
        if (_effectiveDateTime != null)
        {
            return _effectiveDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MFE.3",
            Type = @"Field",
            Position = @"MFE.3",
            Name = @"Effective Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"An optional effective date/time can be included for the record-level action specified.  It is the date/time the originating system expects that the event is to have been completed on the receiving system.  If this field is not present, the effective date/time should default to the current date/time (when the message is received).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MFE.3.1",
                            Type = @"Component",
                            Position = @"MFE.3.1",
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

        _effectiveDateTime = new HL7V23Field
        {
            field = message[@"MFE"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_effectiveDateTime.field.FieldRepetitions != null && _effectiveDateTime.field.FieldRepetitions.Count > 0)
        {
            _effectiveDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_effectiveDateTime, fieldData);
        }

        return _effectiveDateTime;
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
            Id = @"MFE.4",
            Type = @"Field",
            Position = @"MFE.4",
            Name = @"Primary Key Value",
            Length = 200,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = @" This field uniquely identifies the record of the master file (identified in the  MFI segment) to be changed (as defined by the record-level event code).  This field may be either a CE or PL data type.  The PL data type is used only on Location master transactions.  When the CE data type is used, the first component of this CE data field carries an optional subcomponent, the application ID, that uniquely identifies the application responsible for creating the primary key value.  The application ID subcomponent can be used to guarantee uniqueness of the primary key across multiple applications.  

The repetition of the primary key permits the identification of an individual component of a complex record as the object of the record-level event code.  This feature allows the Master Files protocol to be used for modifications of single components of complex records",
            Sample = @"",
            Fields = null
        }

        _primaryKeyValue = new HL7V23Field
        {
            field = message[@"MFE"][4],
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
