using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentMSH
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSH"; } }

        public string SegmentId { get { return @"MSH"; } }
        
        public string LongName { get { return @"Message Header"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.1",
                            Type = @"Field",
                            Position = @"MSH.1",
                            Name = @"Field Separator",
                            Length = 1,
                            Usage = @"R",
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
                            Id = @"MSH.2",
                            Type = @"Field",
                            Position = @"MSH.2",
                            Name = @"Encoding Characters",
                            Length = 4,
                            Usage = @"R",
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
                            Id = @"MSH.3",
                            Type = @"Field",
                            Position = @"MSH.3",
                            Name = @"Sending Application",
                            Length = 15,
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
                            Id = @"MSH.4",
                            Type = @"Field",
                            Position = @"MSH.4",
                            Name = @"Sending Facility",
                            Length = 20,
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
                            Id = @"MSH.5",
                            Type = @"Field",
                            Position = @"MSH.5",
                            Name = @"Receiving Application",
                            Length = 15,
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
                            Id = @"MSH.6",
                            Type = @"Field",
                            Position = @"MSH.6",
                            Name = @"Receiving Facility",
                            Length = 30,
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
                            Id = @"MSH.7",
                            Type = @"Field",
                            Position = @"MSH.7",
                            Name = @"Date/Time Of Message",
                            Length = 19,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.8",
                            Type = @"Field",
                            Position = @"MSH.8",
                            Name = @"Security",
                            Length = 40,
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
                            Id = @"MSH.9",
                            Type = @"Field",
                            Position = @"MSH.9",
                            Name = @"Message Type",
                            Length = 7,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0076",
                            TableName = @"MESSAGE TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.10",
                            Type = @"Field",
                            Position = @"MSH.10",
                            Name = @"Message Control Id",
                            Length = 20,
                            Usage = @"R",
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
                            Id = @"MSH.11",
                            Type = @"Field",
                            Position = @"MSH.11",
                            Name = @"Processing Id",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0103",
                            TableName = @"PROCESSING ID",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12",
                            Type = @"Field",
                            Position = @"MSH.12",
                            Name = @"Version Id",
                            Length = 8,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = @"0104",
                            TableName = @"VERSION CONTROL TABLE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.13",
                            Type = @"Field",
                            Position = @"MSH.13",
                            Name = @"Sequence Number",
                            Length = 15,
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
                            Id = @"MSH.14",
                            Type = @"Field",
                            Position = @"MSH.14",
                            Name = @"Continuation Pointer",
                            Length = 180,
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
                        };
            }
        }

        public HL7V21SegmentMSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field fieldSeparator;

public HL7V21Field FieldSeparator
{
    get
    {
        if (fieldSeparator != null)
        {
            return fieldSeparator;
        }

        fieldSeparator = new HL7V21Field
        {
            field = message[@"MSH"][1],
            Id = @"MSH.1",
            Type = @"Field",
            Position = @"MSH.1",
            Name = @"Field Separator",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (fieldSeparator.field.FieldRepetitions != null && fieldSeparator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fieldSeparator.Id));
            fieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(fieldSeparator, fieldData);
        }

        return fieldSeparator;
    } 
}

internal HL7V21Field encodingCharacters;

public HL7V21Field EncodingCharacters
{
    get
    {
        if (encodingCharacters != null)
        {
            return encodingCharacters;
        }

        encodingCharacters = new HL7V21Field
        {
            field = message[@"MSH"][2],
            Id = @"MSH.2",
            Type = @"Field",
            Position = @"MSH.2",
            Name = @"Encoding Characters",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (encodingCharacters.field.FieldRepetitions != null && encodingCharacters.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(encodingCharacters.Id));
            encodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(encodingCharacters, fieldData);
        }

        return encodingCharacters;
    } 
}

internal HL7V21Field sendingApplication;

public HL7V21Field SendingApplication
{
    get
    {
        if (sendingApplication != null)
        {
            return sendingApplication;
        }

        sendingApplication = new HL7V21Field
        {
            field = message[@"MSH"][3],
            Id = @"MSH.3",
            Type = @"Field",
            Position = @"MSH.3",
            Name = @"Sending Application",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (sendingApplication.field.FieldRepetitions != null && sendingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sendingApplication.Id));
            sendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(sendingApplication, fieldData);
        }

        return sendingApplication;
    } 
}

internal HL7V21Field sendingFacility;

public HL7V21Field SendingFacility
{
    get
    {
        if (sendingFacility != null)
        {
            return sendingFacility;
        }

        sendingFacility = new HL7V21Field
        {
            field = message[@"MSH"][4],
            Id = @"MSH.4",
            Type = @"Field",
            Position = @"MSH.4",
            Name = @"Sending Facility",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (sendingFacility.field.FieldRepetitions != null && sendingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sendingFacility.Id));
            sendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(sendingFacility, fieldData);
        }

        return sendingFacility;
    } 
}

internal HL7V21Field receivingApplication;

public HL7V21Field ReceivingApplication
{
    get
    {
        if (receivingApplication != null)
        {
            return receivingApplication;
        }

        receivingApplication = new HL7V21Field
        {
            field = message[@"MSH"][5],
            Id = @"MSH.5",
            Type = @"Field",
            Position = @"MSH.5",
            Name = @"Receiving Application",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (receivingApplication.field.FieldRepetitions != null && receivingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(receivingApplication.Id));
            receivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(receivingApplication, fieldData);
        }

        return receivingApplication;
    } 
}

internal HL7V21Field receivingFacility;

public HL7V21Field ReceivingFacility
{
    get
    {
        if (receivingFacility != null)
        {
            return receivingFacility;
        }

        receivingFacility = new HL7V21Field
        {
            field = message[@"MSH"][6],
            Id = @"MSH.6",
            Type = @"Field",
            Position = @"MSH.6",
            Name = @"Receiving Facility",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (receivingFacility.field.FieldRepetitions != null && receivingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(receivingFacility.Id));
            receivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(receivingFacility, fieldData);
        }

        return receivingFacility;
    } 
}

internal HL7V21Field dateTimeOfMessage;

public HL7V21Field DateTimeOfMessage
{
    get
    {
        if (dateTimeOfMessage != null)
        {
            return dateTimeOfMessage;
        }

        dateTimeOfMessage = new HL7V21Field
        {
            field = message[@"MSH"][7],
            Id = @"MSH.7",
            Type = @"Field",
            Position = @"MSH.7",
            Name = @"Date/Time Of Message",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (dateTimeOfMessage.field.FieldRepetitions != null && dateTimeOfMessage.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateTimeOfMessage.Id));
            dateTimeOfMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(dateTimeOfMessage, fieldData);
        }

        return dateTimeOfMessage;
    } 
}

internal HL7V21Field security;

public HL7V21Field Security
{
    get
    {
        if (security != null)
        {
            return security;
        }

        security = new HL7V21Field
        {
            field = message[@"MSH"][8],
            Id = @"MSH.8",
            Type = @"Field",
            Position = @"MSH.8",
            Name = @"Security",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (security.field.FieldRepetitions != null && security.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(security.Id));
            security.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(security, fieldData);
        }

        return security;
    } 
}

internal HL7V21Field messageType;

public HL7V21Field MessageType
{
    get
    {
        if (messageType != null)
        {
            return messageType;
        }

        messageType = new HL7V21Field
        {
            field = message[@"MSH"][9],
            Id = @"MSH.9",
            Type = @"Field",
            Position = @"MSH.9",
            Name = @"Message Type",
            Length = 7,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0076",
            TableName = @"MESSAGE TYPE",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (messageType.field.FieldRepetitions != null && messageType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageType.Id));
            messageType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(messageType, fieldData);
        }

        return messageType;
    } 
}

internal HL7V21Field messageControlId;

public HL7V21Field MessageControlId
{
    get
    {
        if (messageControlId != null)
        {
            return messageControlId;
        }

        messageControlId = new HL7V21Field
        {
            field = message[@"MSH"][10],
            Id = @"MSH.10",
            Type = @"Field",
            Position = @"MSH.10",
            Name = @"Message Control Id",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (messageControlId.field.FieldRepetitions != null && messageControlId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageControlId.Id));
            messageControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(messageControlId, fieldData);
        }

        return messageControlId;
    } 
}

internal HL7V21Field processingId;

public HL7V21Field ProcessingId
{
    get
    {
        if (processingId != null)
        {
            return processingId;
        }

        processingId = new HL7V21Field
        {
            field = message[@"MSH"][11],
            Id = @"MSH.11",
            Type = @"Field",
            Position = @"MSH.11",
            Name = @"Processing Id",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0103",
            TableName = @"PROCESSING ID",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (processingId.field.FieldRepetitions != null && processingId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(processingId.Id));
            processingId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(processingId, fieldData);
        }

        return processingId;
    } 
}

internal HL7V21Field versionId;

public HL7V21Field VersionId
{
    get
    {
        if (versionId != null)
        {
            return versionId;
        }

        versionId = new HL7V21Field
        {
            field = message[@"MSH"][12],
            Id = @"MSH.12",
            Type = @"Field",
            Position = @"MSH.12",
            Name = @"Version Id",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = @"0104",
            TableName = @"VERSION CONTROL TABLE",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (versionId.field.FieldRepetitions != null && versionId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(versionId.Id));
            versionId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(versionId, fieldData);
        }

        return versionId;
    } 
}

internal HL7V21Field sequenceNumber;

public HL7V21Field SequenceNumber
{
    get
    {
        if (sequenceNumber != null)
        {
            return sequenceNumber;
        }

        sequenceNumber = new HL7V21Field
        {
            field = message[@"MSH"][13],
            Id = @"MSH.13",
            Type = @"Field",
            Position = @"MSH.13",
            Name = @"Sequence Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (sequenceNumber.field.FieldRepetitions != null && sequenceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceNumber.Id));
            sequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(sequenceNumber, fieldData);
        }

        return sequenceNumber;
    } 
}

internal HL7V21Field continuationPointer;

public HL7V21Field ContinuationPointer
{
    get
    {
        if (continuationPointer != null)
        {
            return continuationPointer;
        }

        continuationPointer = new HL7V21Field
        {
            field = message[@"MSH"][14],
            Id = @"MSH.14",
            Type = @"Field",
            Position = @"MSH.14",
            Name = @"Continuation Pointer",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (continuationPointer.field.FieldRepetitions != null && continuationPointer.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(continuationPointer.Id));
            continuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(continuationPointer, fieldData);
        }

        return continuationPointer;
    } 
}
    }
}
