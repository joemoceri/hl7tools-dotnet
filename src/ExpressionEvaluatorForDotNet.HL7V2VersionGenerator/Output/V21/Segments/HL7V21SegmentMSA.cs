using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentMSA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSA"; } }

        public string SegmentId { get { return @"MSA"; } }
        
        public string LongName { get { return @"Message Acknowledgment"; } }
        
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
                            Id = @"MSA.1",
                            Type = @"Field",
                            Position = @"MSA.1",
                            Name = @"Acknowledgment Code",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0008",
                            TableName = @"ACKNOWLEDGMENT CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSA.2",
                            Type = @"Field",
                            Position = @"MSA.2",
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
                            Id = @"MSA.3",
                            Type = @"Field",
                            Position = @"MSA.3",
                            Name = @"Text Message",
                            Length = 80,
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
                            Id = @"MSA.4",
                            Type = @"Field",
                            Position = @"MSA.4",
                            Name = @"Expected Sequence Number",
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
                            Id = @"MSA.5",
                            Type = @"Field",
                            Position = @"MSA.5",
                            Name = @"Delayed Acknowledgment Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0102",
                            TableName = @"DELAYED ACKNOWLEDGMENT TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentMSA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field acknowledgmentCode;

public HL7V21Field AcknowledgmentCode
{
    get
    {
        if (acknowledgmentCode != null)
        {
            return acknowledgmentCode;
        }

        acknowledgmentCode = new HL7V21Field
        {
            field = message[@"MSA"][1],
            Id = @"MSA.1",
            Type = @"Field",
            Position = @"MSA.1",
            Name = @"Acknowledgment Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0008",
            TableName = @"ACKNOWLEDGMENT CODE",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (acknowledgmentCode.field.FieldRepetitions != null && acknowledgmentCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(acknowledgmentCode.Id));
            acknowledgmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(acknowledgmentCode, fieldData);
        }

        return acknowledgmentCode;
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
            field = message[@"MSA"][2],
            Id = @"MSA.2",
            Type = @"Field",
            Position = @"MSA.2",
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

internal HL7V21Field textMessage;

public HL7V21Field TextMessage
{
    get
    {
        if (textMessage != null)
        {
            return textMessage;
        }

        textMessage = new HL7V21Field
        {
            field = message[@"MSA"][3],
            Id = @"MSA.3",
            Type = @"Field",
            Position = @"MSA.3",
            Name = @"Text Message",
            Length = 80,
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
        if (textMessage.field.FieldRepetitions != null && textMessage.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(textMessage.Id));
            textMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(textMessage, fieldData);
        }

        return textMessage;
    } 
}

internal HL7V21Field expectedSequenceNumber;

public HL7V21Field ExpectedSequenceNumber
{
    get
    {
        if (expectedSequenceNumber != null)
        {
            return expectedSequenceNumber;
        }

        expectedSequenceNumber = new HL7V21Field
        {
            field = message[@"MSA"][4],
            Id = @"MSA.4",
            Type = @"Field",
            Position = @"MSA.4",
            Name = @"Expected Sequence Number",
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
        if (expectedSequenceNumber.field.FieldRepetitions != null && expectedSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(expectedSequenceNumber.Id));
            expectedSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(expectedSequenceNumber, fieldData);
        }

        return expectedSequenceNumber;
    } 
}

internal HL7V21Field delayedAcknowledgmentType;

public HL7V21Field DelayedAcknowledgmentType
{
    get
    {
        if (delayedAcknowledgmentType != null)
        {
            return delayedAcknowledgmentType;
        }

        delayedAcknowledgmentType = new HL7V21Field
        {
            field = message[@"MSA"][5],
            Id = @"MSA.5",
            Type = @"Field",
            Position = @"MSA.5",
            Name = @"Delayed Acknowledgment Type",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0102",
            TableName = @"DELAYED ACKNOWLEDGMENT TYPE",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (delayedAcknowledgmentType.field.FieldRepetitions != null && delayedAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(delayedAcknowledgmentType.Id));
            delayedAcknowledgmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(delayedAcknowledgmentType, fieldData);
        }

        return delayedAcknowledgmentType;
    } 
}
    }
}
