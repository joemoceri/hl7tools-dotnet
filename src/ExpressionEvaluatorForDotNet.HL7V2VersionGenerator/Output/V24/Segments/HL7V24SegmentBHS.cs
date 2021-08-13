using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentBHS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"BHS"; } }

        public string SegmentId { get { return @"BHS"; } }
        
        public string LongName { get { return @"Batch Header Segment"; } }
        
        public string Description { get { return @"The BHS segment defines the start of a batch."; } }
        
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

        public HL7V24SegmentBHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _batchFieldSeparator;

public HL7V24Field BatchFieldSeparator
{
    get
    {
        if (_batchFieldSeparator != null)
        {
            return _batchFieldSeparator;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.1",
            Type = @"Field",
            Position = @"BHS.1",
            Name = @"Batch Field Separator",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the separator between the segment ID and the first real field, BHS-2-batch encoding characters.  As such it serves as the separator and defines the character to be used as a separator for the rest of the message.  Recommended value is |,(ASCII 124).",
            Sample = @"",
            Fields = null
        }

        _batchFieldSeparator = new HL7V24Field
        {
            field = message[@"BHS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchFieldSeparator.field.FieldRepetitions != null && _batchFieldSeparator.field.FieldRepetitions.Count > 0)
        {
            _batchFieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_batchFieldSeparator, fieldData);
        }

        return _batchFieldSeparator;
    } 
}

internal HL7V24Field _batchEncodingCharacters;

public HL7V24Field BatchEncodingCharacters
{
    get
    {
        if (_batchEncodingCharacters != null)
        {
            return _batchEncodingCharacters;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.2",
            Type = @"Field",
            Position = @"BHS.2",
            Name = @"Batch Encoding Characters",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the four characters in the following order: the component separator, repetition separator, escape characters, and subcomponent separator.  Recommended values are ^~\& (ASCII 94, 126, 92, and 38, respectively)",
            Sample = @"",
            Fields = null
        }

        _batchEncodingCharacters = new HL7V24Field
        {
            field = message[@"BHS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchEncodingCharacters.field.FieldRepetitions != null && _batchEncodingCharacters.field.FieldRepetitions.Count > 0)
        {
            _batchEncodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_batchEncodingCharacters, fieldData);
        }

        return _batchEncodingCharacters;
    } 
}

internal HL7V24Field _batchSendingApplication;

public HL7V24Field BatchSendingApplication
{
    get
    {
        if (_batchSendingApplication != null)
        {
            return _batchSendingApplication;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.3",
            Type = @"Field",
            Position = @"BHS.3",
            Name = @"Batch Sending Application",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise.  The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise.  Entirely site-defined.",
            Sample = @"",
            Fields = null
        }

        _batchSendingApplication = new HL7V24Field
        {
            field = message[@"BHS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchSendingApplication.field.FieldRepetitions != null && _batchSendingApplication.field.FieldRepetitions.Count > 0)
        {
            _batchSendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_batchSendingApplication, fieldData);
        }

        return _batchSendingApplication;
    } 
}

internal HL7V24Field _batchSendingFacility;

public HL7V24Field BatchSendingFacility
{
    get
    {
        if (_batchSendingFacility != null)
        {
            return _batchSendingFacility;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.4",
            Type = @"Field",
            Position = @"BHS.4",
            Name = @"Batch Sending Facility",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of one of several occurrences of the same application within the sending system.  Absent other considerations, the Medicare Provider ID might be used with an appropriate sub-identifier in the second component.  Entirely user-defined",
            Sample = @"",
            Fields = null
        }

        _batchSendingFacility = new HL7V24Field
        {
            field = message[@"BHS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchSendingFacility.field.FieldRepetitions != null && _batchSendingFacility.field.FieldRepetitions.Count > 0)
        {
            _batchSendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_batchSendingFacility, fieldData);
        }

        return _batchSendingFacility;
    } 
}

internal HL7V24Field _batchReceivingApplication;

public HL7V24Field BatchReceivingApplication
{
    get
    {
        if (_batchReceivingApplication != null)
        {
            return _batchReceivingApplication;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.5",
            Type = @"Field",
            Position = @"BHS.5",
            Name = @"Batch Receiving Application",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the receiving applications among all other applications within the network enterprise.  The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise.  Entirely site-defined",
            Sample = @"",
            Fields = null
        }

        _batchReceivingApplication = new HL7V24Field
        {
            field = message[@"BHS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchReceivingApplication.field.FieldRepetitions != null && _batchReceivingApplication.field.FieldRepetitions.Count > 0)
        {
            _batchReceivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_batchReceivingApplication, fieldData);
        }

        return _batchReceivingApplication;
    } 
}

internal HL7V24Field _batchReceivingFacility;

public HL7V24Field BatchReceivingFacility
{
    get
    {
        if (_batchReceivingFacility != null)
        {
            return _batchReceivingFacility;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.6",
            Type = @"Field",
            Position = @"BHS.6",
            Name = @"Batch Receiving Facility",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations.  See comments BSH-4-batch sending facility.  Entirely site-defined",
            Sample = @"",
            Fields = null
        }

        _batchReceivingFacility = new HL7V24Field
        {
            field = message[@"BHS"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchReceivingFacility.field.FieldRepetitions != null && _batchReceivingFacility.field.FieldRepetitions.Count > 0)
        {
            _batchReceivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_batchReceivingFacility, fieldData);
        }

        return _batchReceivingFacility;
    } 
}

internal HL7V24Field _batchCreationDateTime;

public HL7V24Field BatchCreationDateTime
{
    get
    {
        if (_batchCreationDateTime != null)
        {
            return _batchCreationDateTime;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.7",
            Type = @"Field",
            Position = @"BHS.7",
            Name = @"Batch Creation Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This  field contains the date/time that the sending system created the message.  If the time zone is specified, it will be used throughout the message as the default time zone. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"BHS.7.1",
                            Type = @"Component",
                            Position = @"BHS.7.1",
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
                            Id = @"BHS.7.2",
                            Type = @"Component",
                            Position = @"BHS.7.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _batchCreationDateTime = new HL7V24Field
        {
            field = message[@"BHS"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchCreationDateTime.field.FieldRepetitions != null && _batchCreationDateTime.field.FieldRepetitions.Count > 0)
        {
            _batchCreationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_batchCreationDateTime, fieldData);
        }

        return _batchCreationDateTime;
    } 
}

internal HL7V24Field _batchSecurity;

public HL7V24Field BatchSecurity
{
    get
    {
        if (_batchSecurity != null)
        {
            return _batchSecurity;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.8",
            Type = @"Field",
            Position = @"BHS.8",
            Name = @"Batch Security",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"In some applications of HL7, this field is used to implement security features.  Its use is not yet further specified",
            Sample = @"",
            Fields = null
        }

        _batchSecurity = new HL7V24Field
        {
            field = message[@"BHS"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchSecurity.field.FieldRepetitions != null && _batchSecurity.field.FieldRepetitions.Count > 0)
        {
            _batchSecurity.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_batchSecurity, fieldData);
        }

        return _batchSecurity;
    } 
}

internal HL7V24Field _batchNameIDType;

public HL7V24Field BatchNameIDType
{
    get
    {
        if (_batchNameIDType != null)
        {
            return _batchNameIDType;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.9",
            Type = @"Field",
            Position = @"BHS.9",
            Name = @"Batch Name/ID/Type",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field can be used by the application processing the batch.  It can have extra components if needed.",
            Sample = @"",
            Fields = null
        }

        _batchNameIDType = new HL7V24Field
        {
            field = message[@"BHS"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchNameIDType.field.FieldRepetitions != null && _batchNameIDType.field.FieldRepetitions.Count > 0)
        {
            _batchNameIDType.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_batchNameIDType, fieldData);
        }

        return _batchNameIDType;
    } 
}

internal HL7V24Field _batchComment;

public HL7V24Field BatchComment
{
    get
    {
        if (_batchComment != null)
        {
            return _batchComment;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.10",
            Type = @"Field",
            Position = @"BHS.10",
            Name = @"Batch Comment",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is a comment field that is not further defined in the HL7 protocol",
            Sample = @"",
            Fields = null
        }

        _batchComment = new HL7V24Field
        {
            field = message[@"BHS"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchComment.field.FieldRepetitions != null && _batchComment.field.FieldRepetitions.Count > 0)
        {
            _batchComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_batchComment, fieldData);
        }

        return _batchComment;
    } 
}

internal HL7V24Field _batchControlID;

public HL7V24Field BatchControlID
{
    get
    {
        if (_batchControlID != null)
        {
            return _batchControlID;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.11",
            Type = @"Field",
            Position = @"BHS.11",
            Name = @"Batch Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to uniquely identify a particular batch.  It can be echoed back in BHS-12reference batch control ID if an answering batch is needed",
            Sample = @"",
            Fields = null
        }

        _batchControlID = new HL7V24Field
        {
            field = message[@"BHS"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchControlID.field.FieldRepetitions != null && _batchControlID.field.FieldRepetitions.Count > 0)
        {
            _batchControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_batchControlID, fieldData);
        }

        return _batchControlID;
    } 
}

internal HL7V24Field _referenceBatchControlID;

public HL7V24Field ReferenceBatchControlID
{
    get
    {
        if (_referenceBatchControlID != null)
        {
            return _referenceBatchControlID;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"BHS.12",
            Type = @"Field",
            Position = @"BHS.12",
            Name = @"Reference Batch Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the value of BHS-11-batch control ID when this batch was originally transmitted.  Not present if this batch is being sent for the first time.  See definition for BHS-11-batch control ID",
            Sample = @"",
            Fields = null
        }

        _referenceBatchControlID = new HL7V24Field
        {
            field = message[@"BHS"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referenceBatchControlID.field.FieldRepetitions != null && _referenceBatchControlID.field.FieldRepetitions.Count > 0)
        {
            _referenceBatchControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_referenceBatchControlID, fieldData);
        }

        return _referenceBatchControlID;
    } 
}
    }
}
