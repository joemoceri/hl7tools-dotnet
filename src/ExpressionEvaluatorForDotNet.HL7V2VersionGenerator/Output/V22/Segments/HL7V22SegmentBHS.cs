using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentBHS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"BHS"; } }

        public string SegmentId { get { return @"BHS"; } }
        
        public string LongName { get { return @"Batch Header"; } }
        
        public string Description { get { return @"The BHS segment defines the start of a batch"; } }
        
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

        public HL7V22SegmentBHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _batchFieldSeparator;

public HL7V22Field BatchFieldSeparator
{
    get
    {
        if (_batchFieldSeparator != null)
        {
            return _batchFieldSeparator;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
            Fields = null
        }

        _batchFieldSeparator = new HL7V22Field
        {
            field = message[@"BHS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchFieldSeparator.field.FieldRepetitions != null && _batchFieldSeparator.field.FieldRepetitions.Count > 0)
        {
            _batchFieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchFieldSeparator, fieldData);
        }

        return _batchFieldSeparator;
    } 
}

internal HL7V22Field _batchEncodingCharacters;

public HL7V22Field BatchEncodingCharacters
{
    get
    {
        if (_batchEncodingCharacters != null)
        {
            return _batchEncodingCharacters;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"BHS.2",
            Type = @"Field",
            Position = @"BHS.2",
            Name = @"Batch Encoding Characters",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
            Fields = null
        }

        _batchEncodingCharacters = new HL7V22Field
        {
            field = message[@"BHS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchEncodingCharacters.field.FieldRepetitions != null && _batchEncodingCharacters.field.FieldRepetitions.Count > 0)
        {
            _batchEncodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchEncodingCharacters, fieldData);
        }

        return _batchEncodingCharacters;
    } 
}

internal HL7V22Field _batchSendingApplication;

public HL7V22Field BatchSendingApplication
{
    get
    {
        if (_batchSendingApplication != null)
        {
            return _batchSendingApplication;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
            Fields = null
        }

        _batchSendingApplication = new HL7V22Field
        {
            field = message[@"BHS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchSendingApplication.field.FieldRepetitions != null && _batchSendingApplication.field.FieldRepetitions.Count > 0)
        {
            _batchSendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchSendingApplication, fieldData);
        }

        return _batchSendingApplication;
    } 
}

internal HL7V22Field _batchSendingFacility;

public HL7V22Field BatchSendingFacility
{
    get
    {
        if (_batchSendingFacility != null)
        {
            return _batchSendingFacility;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
            Fields = null
        }

        _batchSendingFacility = new HL7V22Field
        {
            field = message[@"BHS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchSendingFacility.field.FieldRepetitions != null && _batchSendingFacility.field.FieldRepetitions.Count > 0)
        {
            _batchSendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchSendingFacility, fieldData);
        }

        return _batchSendingFacility;
    } 
}

internal HL7V22Field _batchReceivingApplication;

public HL7V22Field BatchReceivingApplication
{
    get
    {
        if (_batchReceivingApplication != null)
        {
            return _batchReceivingApplication;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"BHS.5",
            Type = @"Field",
            Position = @"BHS.5",
            Name = @"Batch Receiving Application",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
            Fields = null
        }

        _batchReceivingApplication = new HL7V22Field
        {
            field = message[@"BHS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchReceivingApplication.field.FieldRepetitions != null && _batchReceivingApplication.field.FieldRepetitions.Count > 0)
        {
            _batchReceivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchReceivingApplication, fieldData);
        }

        return _batchReceivingApplication;
    } 
}

internal HL7V22Field _batchReceivingFacility;

public HL7V22Field BatchReceivingFacility
{
    get
    {
        if (_batchReceivingFacility != null)
        {
            return _batchReceivingFacility;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"BHS.6",
            Type = @"Field",
            Position = @"BHS.6",
            Name = @"Batch Receiving Facility",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
            Fields = null
        }

        _batchReceivingFacility = new HL7V22Field
        {
            field = message[@"BHS"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchReceivingFacility.field.FieldRepetitions != null && _batchReceivingFacility.field.FieldRepetitions.Count > 0)
        {
            _batchReceivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchReceivingFacility, fieldData);
        }

        return _batchReceivingFacility;
    } 
}

internal HL7V22Field _batchCreationDateTime;

public HL7V22Field BatchCreationDateTime
{
    get
    {
        if (_batchCreationDateTime != null)
        {
            return _batchCreationDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"BHS.7",
            Type = @"Field",
            Position = @"BHS.7",
            Name = @"Batch Creation Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
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

        _batchCreationDateTime = new HL7V22Field
        {
            field = message[@"BHS"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchCreationDateTime.field.FieldRepetitions != null && _batchCreationDateTime.field.FieldRepetitions.Count > 0)
        {
            _batchCreationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchCreationDateTime, fieldData);
        }

        return _batchCreationDateTime;
    } 
}

internal HL7V22Field _batchSecurity;

public HL7V22Field BatchSecurity
{
    get
    {
        if (_batchSecurity != null)
        {
            return _batchSecurity;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
            Fields = null
        }

        _batchSecurity = new HL7V22Field
        {
            field = message[@"BHS"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchSecurity.field.FieldRepetitions != null && _batchSecurity.field.FieldRepetitions.Count > 0)
        {
            _batchSecurity.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchSecurity, fieldData);
        }

        return _batchSecurity;
    } 
}

internal HL7V22Field _batchNameIdType;

public HL7V22Field BatchNameIdType
{
    get
    {
        if (_batchNameIdType != null)
        {
            return _batchNameIdType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"BHS.9",
            Type = @"Field",
            Position = @"BHS.9",
            Name = @"Batch Name / Id / Type",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"can be used by the application processing the batch.  It can have extra components if needed",
            Sample = @"",
            Fields = null
        }

        _batchNameIdType = new HL7V22Field
        {
            field = message[@"BHS"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchNameIdType.field.FieldRepetitions != null && _batchNameIdType.field.FieldRepetitions.Count > 0)
        {
            _batchNameIdType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchNameIdType, fieldData);
        }

        return _batchNameIdType;
    } 
}

internal HL7V22Field _batchComment;

public HL7V22Field BatchComment
{
    get
    {
        if (_batchComment != null)
        {
            return _batchComment;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"comment field that is not further defined in the HL7 protocol",
            Sample = @"",
            Fields = null
        }

        _batchComment = new HL7V22Field
        {
            field = message[@"BHS"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchComment.field.FieldRepetitions != null && _batchComment.field.FieldRepetitions.Count > 0)
        {
            _batchComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchComment, fieldData);
        }

        return _batchComment;
    } 
}

internal HL7V22Field _batchControlId;

public HL7V22Field BatchControlId
{
    get
    {
        if (_batchControlId != null)
        {
            return _batchControlId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"BHS.11",
            Type = @"Field",
            Position = @"BHS.11",
            Name = @"Batch Control Id",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"used to uniquely identify a particular batch.  It can be echoed back in BHS-12-reference batch control ID if an answering batch is needed",
            Sample = @"",
            Fields = null
        }

        _batchControlId = new HL7V22Field
        {
            field = message[@"BHS"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchControlId.field.FieldRepetitions != null && _batchControlId.field.FieldRepetitions.Count > 0)
        {
            _batchControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchControlId, fieldData);
        }

        return _batchControlId;
    } 
}

internal HL7V22Field _referenceBatchControlId;

public HL7V22Field ReferenceBatchControlId
{
    get
    {
        if (_referenceBatchControlId != null)
        {
            return _referenceBatchControlId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"BHS.12",
            Type = @"Field",
            Position = @"BHS.12",
            Name = @"Reference Batch Control Id",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"value of BHS-11-batch control ID when this batch was originally transmitted.  Not present if this batch is being sent for the first time.  See definition for BHS-11-batch control ID",
            Sample = @"",
            Fields = null
        }

        _referenceBatchControlId = new HL7V22Field
        {
            field = message[@"BHS"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referenceBatchControlId.field.FieldRepetitions != null && _referenceBatchControlId.field.FieldRepetitions.Count > 0)
        {
            _referenceBatchControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_referenceBatchControlId, fieldData);
        }

        return _referenceBatchControlId;
    } 
}
    }
}
