using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentMSA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSA"; } }

        public string SegmentId { get { return @"MSA"; } }
        
        public string LongName { get { return @"Message Acknowledgment"; } }
        
        public string Description { get { return @"The MSA segment contains information sent while acknowledging another message"; } }
        
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
                            Name = @"Acknowledgement Code",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0008",
                            TableName = @"ACKNOWLEDGMENT CODE",
                            Description = @"see message processing rules",
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
                            Description = @"message control ID of the message sent by the sending system.  It allows the sending system to associate this response with the message for which it is intended",
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
                            Description = @"optional text field that further describes an error condition.  This text may be printed in error logs or presented to an end user",
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
                            Description = @"optional numeric field used in the sequence number protocol",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSA.5",
                            Type = @"Field",
                            Position = @"MSA.5",
                            Name = @"Delayed Acknowledgement Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0102",
                            TableName = @"DELAYED ACKNOWLEDGMENT TYPE",
                            Description = @"used only as described above, in Section 2.5.2.  Otherwise this field is not used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSA.6",
                            Type = @"Field",
                            Position = @"MSA.6",
                            Name = @"Error Condition",
                            Length = 100,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"CE field allowing the acknowledging system to use a user-defined error code to further specify AR or AE type acknowledgements.  This field is a generalized replacement for MSA-3-text message",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSA.6.1",
                            Type = @"Component",
                            Position = @"MSA.6.1",
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
                            Id = @"MSA.6.2",
                            Type = @"Component",
                            Position = @"MSA.6.2",
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
                            Id = @"MSA.6.3",
                            Type = @"Component",
                            Position = @"MSA.6.3",
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
                            Id = @"MSA.6.4",
                            Type = @"Component",
                            Position = @"MSA.6.4",
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
                            Id = @"MSA.6.5",
                            Type = @"Component",
                            Position = @"MSA.6.5",
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
                            Id = @"MSA.6.6",
                            Type = @"Component",
                            Position = @"MSA.6.6",
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
                        },}
                        },
                        };
            }
        }

        public HL7V22SegmentMSA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field acknowledgementCode;

public HL7V22Field AcknowledgementCode
{
    get
    {
        if (acknowledgementCode != null)
        {
            return acknowledgementCode;
        }

        acknowledgementCode = new HL7V22Field
        {
            field = message[@"MSA"][1],
            Id = @"MSA.1",
            Type = @"Field",
            Position = @"MSA.1",
            Name = @"Acknowledgement Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0008",
            TableName = @"ACKNOWLEDGMENT CODE",
            Description = @"see message processing rules",
            Sample = @"",
        };

        // check for repetitions
        if (acknowledgementCode.field.FieldRepetitions != null && acknowledgementCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(acknowledgementCode.Id));
            acknowledgementCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(acknowledgementCode, fieldData);
        }

        return acknowledgementCode;
    } 
}

internal HL7V22Field messageControlId;

public HL7V22Field MessageControlId
{
    get
    {
        if (messageControlId != null)
        {
            return messageControlId;
        }

        messageControlId = new HL7V22Field
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
            Description = @"message control ID of the message sent by the sending system.  It allows the sending system to associate this response with the message for which it is intended",
            Sample = @"",
        };

        // check for repetitions
        if (messageControlId.field.FieldRepetitions != null && messageControlId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageControlId.Id));
            messageControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(messageControlId, fieldData);
        }

        return messageControlId;
    } 
}

internal HL7V22Field textMessage;

public HL7V22Field TextMessage
{
    get
    {
        if (textMessage != null)
        {
            return textMessage;
        }

        textMessage = new HL7V22Field
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
            Description = @"optional text field that further describes an error condition.  This text may be printed in error logs or presented to an end user",
            Sample = @"",
        };

        // check for repetitions
        if (textMessage.field.FieldRepetitions != null && textMessage.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(textMessage.Id));
            textMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(textMessage, fieldData);
        }

        return textMessage;
    } 
}

internal HL7V22Field expectedSequenceNumber;

public HL7V22Field ExpectedSequenceNumber
{
    get
    {
        if (expectedSequenceNumber != null)
        {
            return expectedSequenceNumber;
        }

        expectedSequenceNumber = new HL7V22Field
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
            Description = @"optional numeric field used in the sequence number protocol",
            Sample = @"",
        };

        // check for repetitions
        if (expectedSequenceNumber.field.FieldRepetitions != null && expectedSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(expectedSequenceNumber.Id));
            expectedSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(expectedSequenceNumber, fieldData);
        }

        return expectedSequenceNumber;
    } 
}

internal HL7V22Field delayedAcknowledgementType;

public HL7V22Field DelayedAcknowledgementType
{
    get
    {
        if (delayedAcknowledgementType != null)
        {
            return delayedAcknowledgementType;
        }

        delayedAcknowledgementType = new HL7V22Field
        {
            field = message[@"MSA"][5],
            Id = @"MSA.5",
            Type = @"Field",
            Position = @"MSA.5",
            Name = @"Delayed Acknowledgement Type",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0102",
            TableName = @"DELAYED ACKNOWLEDGMENT TYPE",
            Description = @"used only as described above, in Section 2.5.2.  Otherwise this field is not used",
            Sample = @"",
        };

        // check for repetitions
        if (delayedAcknowledgementType.field.FieldRepetitions != null && delayedAcknowledgementType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(delayedAcknowledgementType.Id));
            delayedAcknowledgementType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(delayedAcknowledgementType, fieldData);
        }

        return delayedAcknowledgementType;
    } 
}

internal HL7V22Field errorCondition;

public HL7V22Field ErrorCondition
{
    get
    {
        if (errorCondition != null)
        {
            return errorCondition;
        }

        errorCondition = new HL7V22Field
        {
            field = message[@"MSA"][6],
            Id = @"MSA.6",
            Type = @"Field",
            Position = @"MSA.6",
            Name = @"Error Condition",
            Length = 100,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"CE field allowing the acknowledging system to use a user-defined error code to further specify AR or AE type acknowledgements.  This field is a generalized replacement for MSA-3-text message",
            Sample = @"",
        };

        // check for repetitions
        if (errorCondition.field.FieldRepetitions != null && errorCondition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(errorCondition.Id));
            errorCondition.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(errorCondition, fieldData);
        }

        return errorCondition;
    } 
}
    }
}
