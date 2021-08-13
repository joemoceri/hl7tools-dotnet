using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentFHS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"FHS"; } }

        public string SegmentId { get { return @"FHS"; } }
        
        public string LongName { get { return @"File Header"; } }
        
        public string Description { get { return @"The FHS segment is used to head a file (group of batches) as defined in Section 2.9.3. "; } }
        
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

        public HL7V22SegmentFHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _fileFieldSeparator;

public HL7V22Field FileFieldSeparator
{
    get
    {
        if (_fileFieldSeparator != null)
        {
            return _fileFieldSeparator;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.1",
            Type = @"Field",
            Position = @"FHS.1",
            Name = @"File Field Separator",
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

        _fileFieldSeparator = new HL7V22Field
        {
            field = message[@"FHS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileFieldSeparator.field.FieldRepetitions != null && _fileFieldSeparator.field.FieldRepetitions.Count > 0)
        {
            _fileFieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fileFieldSeparator, fieldData);
        }

        return _fileFieldSeparator;
    } 
}

internal HL7V22Field _fileEncodingCharacters;

public HL7V22Field FileEncodingCharacters
{
    get
    {
        if (_fileEncodingCharacters != null)
        {
            return _fileEncodingCharacters;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.2",
            Type = @"Field",
            Position = @"FHS.2",
            Name = @"File Encoding Characters",
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

        _fileEncodingCharacters = new HL7V22Field
        {
            field = message[@"FHS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileEncodingCharacters.field.FieldRepetitions != null && _fileEncodingCharacters.field.FieldRepetitions.Count > 0)
        {
            _fileEncodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fileEncodingCharacters, fieldData);
        }

        return _fileEncodingCharacters;
    } 
}

internal HL7V22Field _fileSendingApplication;

public HL7V22Field FileSendingApplication
{
    get
    {
        if (_fileSendingApplication != null)
        {
            return _fileSendingApplication;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.3",
            Type = @"Field",
            Position = @"FHS.3",
            Name = @"File Sending Application",
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

        _fileSendingApplication = new HL7V22Field
        {
            field = message[@"FHS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileSendingApplication.field.FieldRepetitions != null && _fileSendingApplication.field.FieldRepetitions.Count > 0)
        {
            _fileSendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fileSendingApplication, fieldData);
        }

        return _fileSendingApplication;
    } 
}

internal HL7V22Field _fileSendingFacility;

public HL7V22Field FileSendingFacility
{
    get
    {
        if (_fileSendingFacility != null)
        {
            return _fileSendingFacility;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.4",
            Type = @"Field",
            Position = @"FHS.4",
            Name = @"File Sending Facility",
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

        _fileSendingFacility = new HL7V22Field
        {
            field = message[@"FHS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileSendingFacility.field.FieldRepetitions != null && _fileSendingFacility.field.FieldRepetitions.Count > 0)
        {
            _fileSendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fileSendingFacility, fieldData);
        }

        return _fileSendingFacility;
    } 
}

internal HL7V22Field _fileReceivingApplication;

public HL7V22Field FileReceivingApplication
{
    get
    {
        if (_fileReceivingApplication != null)
        {
            return _fileReceivingApplication;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.5",
            Type = @"Field",
            Position = @"FHS.5",
            Name = @"File Receiving Application",
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

        _fileReceivingApplication = new HL7V22Field
        {
            field = message[@"FHS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileReceivingApplication.field.FieldRepetitions != null && _fileReceivingApplication.field.FieldRepetitions.Count > 0)
        {
            _fileReceivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fileReceivingApplication, fieldData);
        }

        return _fileReceivingApplication;
    } 
}

internal HL7V22Field _fileReceivingFacility;

public HL7V22Field FileReceivingFacility
{
    get
    {
        if (_fileReceivingFacility != null)
        {
            return _fileReceivingFacility;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.6",
            Type = @"Field",
            Position = @"FHS.6",
            Name = @"File Receiving Facility",
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

        _fileReceivingFacility = new HL7V22Field
        {
            field = message[@"FHS"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileReceivingFacility.field.FieldRepetitions != null && _fileReceivingFacility.field.FieldRepetitions.Count > 0)
        {
            _fileReceivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fileReceivingFacility, fieldData);
        }

        return _fileReceivingFacility;
    } 
}

internal HL7V22Field _fileCreationDateTime;

public HL7V22Field FileCreationDateTime
{
    get
    {
        if (_fileCreationDateTime != null)
        {
            return _fileCreationDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.7",
            Type = @"Field",
            Position = @"FHS.7",
            Name = @"File Creation Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FHS.7.1",
                            Type = @"Component",
                            Position = @"FHS.7.1",
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
                            Id = @"FHS.7.2",
                            Type = @"Component",
                            Position = @"FHS.7.2",
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

        _fileCreationDateTime = new HL7V22Field
        {
            field = message[@"FHS"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileCreationDateTime.field.FieldRepetitions != null && _fileCreationDateTime.field.FieldRepetitions.Count > 0)
        {
            _fileCreationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fileCreationDateTime, fieldData);
        }

        return _fileCreationDateTime;
    } 
}

internal HL7V22Field _fileSecurity;

public HL7V22Field FileSecurity
{
    get
    {
        if (_fileSecurity != null)
        {
            return _fileSecurity;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.8",
            Type = @"Field",
            Position = @"FHS.8",
            Name = @"File Security",
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

        _fileSecurity = new HL7V22Field
        {
            field = message[@"FHS"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileSecurity.field.FieldRepetitions != null && _fileSecurity.field.FieldRepetitions.Count > 0)
        {
            _fileSecurity.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fileSecurity, fieldData);
        }

        return _fileSecurity;
    } 
}

internal HL7V22Field _fileNameId;

public HL7V22Field FileNameId
{
    get
    {
        if (_fileNameId != null)
        {
            return _fileNameId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.9",
            Type = @"Field",
            Position = @"FHS.9",
            Name = @"File Name / Id",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"can be used by the application processing file.  Its use is not further specified",
            Sample = @"",
            Fields = null
        }

        _fileNameId = new HL7V22Field
        {
            field = message[@"FHS"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileNameId.field.FieldRepetitions != null && _fileNameId.field.FieldRepetitions.Count > 0)
        {
            _fileNameId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fileNameId, fieldData);
        }

        return _fileNameId;
    } 
}

internal HL7V22Field _fileHeaderComment;

public HL7V22Field FileHeaderComment
{
    get
    {
        if (_fileHeaderComment != null)
        {
            return _fileHeaderComment;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.10",
            Type = @"Field",
            Position = @"FHS.10",
            Name = @"File Header Comment",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"free text field, the use of which is not further specified",
            Sample = @"",
            Fields = null
        }

        _fileHeaderComment = new HL7V22Field
        {
            field = message[@"FHS"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileHeaderComment.field.FieldRepetitions != null && _fileHeaderComment.field.FieldRepetitions.Count > 0)
        {
            _fileHeaderComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fileHeaderComment, fieldData);
        }

        return _fileHeaderComment;
    } 
}

internal HL7V22Field _fileControlId;

public HL7V22Field FileControlId
{
    get
    {
        if (_fileControlId != null)
        {
            return _fileControlId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.11",
            Type = @"Field",
            Position = @"FHS.11",
            Name = @"File Control Id",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"used to identify a particular file uniquely.  It can be echoed back in FHS-12-reference file control ID",
            Sample = @"",
            Fields = null
        }

        _fileControlId = new HL7V22Field
        {
            field = message[@"FHS"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileControlId.field.FieldRepetitions != null && _fileControlId.field.FieldRepetitions.Count > 0)
        {
            _fileControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fileControlId, fieldData);
        }

        return _fileControlId;
    } 
}

internal HL7V22Field _referenceFileControlId;

public HL7V22Field ReferenceFileControlId
{
    get
    {
        if (_referenceFileControlId != null)
        {
            return _referenceFileControlId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FHS.12",
            Type = @"Field",
            Position = @"FHS.12",
            Name = @"Reference File Control Id",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"value of FHS-11-file control ID when this file was originally transmitted.  Not present if this file is being transmitted for the first time",
            Sample = @"",
            Fields = null
        }

        _referenceFileControlId = new HL7V22Field
        {
            field = message[@"FHS"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referenceFileControlId.field.FieldRepetitions != null && _referenceFileControlId.field.FieldRepetitions.Count > 0)
        {
            _referenceFileControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_referenceFileControlId, fieldData);
        }

        return _referenceFileControlId;
    } 
}
    }
}
