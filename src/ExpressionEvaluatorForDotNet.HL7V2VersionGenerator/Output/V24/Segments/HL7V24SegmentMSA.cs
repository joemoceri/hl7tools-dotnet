using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentMSA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSA"; } }

        public string SegmentId { get { return @"MSA"; } }
        
        public string LongName { get { return @"Message Acknowledgment"; } }
        
        public string Description { get { return @"The MSA segment contains information sent while acknowledging another message."; } }
        
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0008",
                            TableName = @"Acknowledgment code",
                            Description = @"This field contains an acknowledgment code, see message processing rules. Refer to HL7 Table 0008 - Acknowledgment code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSA.2",
                            Type = @"Field",
                            Position = @"MSA.2",
                            Name = @"Message Control ID",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the message control ID of the message sent by the sending system. It allows the sending system to associate this response with the message for which it is intended.",
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
                            Description = @"This optional field further describes an error condition. This text may be printed in error logs or presented to an end user.",
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
                            Description = @"This optional numeric field is used in the sequence number protocol.",
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
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0102",
                            TableName = @"Delayed acknowledgment type",
                            Description = @"This field has been retained for backward compatibility.  This field is used only as described above, in Section 2.13.2, Application (level 7) processing rules, deferred processing two phase reply (original acknowledgment mode only). Otherwise this field is not used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSA.6",
                            Type = @"Field",
                            Position = @"MSA.6",
                            Name = @"Error Condition",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0357",
                            TableName = @"Message error condition codes",
                            Description = @"This field allows the acknowledging system to use a user-defined error code to further specify AR or AE type acknowledgments. This field is a generalized replacement for MSA-3-text message.",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V24SegmentMSA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field acknowledgementCode;

public HL7V24Field AcknowledgementCode
{
    get
    {
        if (acknowledgementCode != null)
        {
            return acknowledgementCode;
        }

        acknowledgementCode = new HL7V24Field
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
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0008",
            TableName = @"Acknowledgment code",
            Description = @"This field contains an acknowledgment code, see message processing rules. Refer to HL7 Table 0008 - Acknowledgment code for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (acknowledgementCode.field.FieldRepetitions != null && acknowledgementCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(acknowledgementCode.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < acknowledgementCode.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = acknowledgementCode.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < acknowledgementCode.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = acknowledgementCode.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < acknowledgementCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = acknowledgementCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            acknowledgementCode.fieldRepetitions = fieldRepetitions;
        }

        return acknowledgementCode;
    } 
}

internal HL7V24Field messageControlID;

public HL7V24Field MessageControlID
{
    get
    {
        if (messageControlID != null)
        {
            return messageControlID;
        }

        messageControlID = new HL7V24Field
        {
            field = message[@"MSA"][2],
            Id = @"MSA.2",
            Type = @"Field",
            Position = @"MSA.2",
            Name = @"Message Control ID",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the message control ID of the message sent by the sending system. It allows the sending system to associate this response with the message for which it is intended.",
            Sample = @"",
        };

        // check for repetitions
        if (messageControlID.field.FieldRepetitions != null && messageControlID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageControlID.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < messageControlID.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = messageControlID.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < messageControlID.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = messageControlID.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < messageControlID.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = messageControlID.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            messageControlID.fieldRepetitions = fieldRepetitions;
        }

        return messageControlID;
    } 
}

internal HL7V24Field textMessage;

public HL7V24Field TextMessage
{
    get
    {
        if (textMessage != null)
        {
            return textMessage;
        }

        textMessage = new HL7V24Field
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
            Description = @"This optional field further describes an error condition. This text may be printed in error logs or presented to an end user.",
            Sample = @"",
        };

        // check for repetitions
        if (textMessage.field.FieldRepetitions != null && textMessage.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(textMessage.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < textMessage.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = textMessage.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < textMessage.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = textMessage.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < textMessage.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = textMessage.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            textMessage.fieldRepetitions = fieldRepetitions;
        }

        return textMessage;
    } 
}

internal HL7V24Field expectedSequenceNumber;

public HL7V24Field ExpectedSequenceNumber
{
    get
    {
        if (expectedSequenceNumber != null)
        {
            return expectedSequenceNumber;
        }

        expectedSequenceNumber = new HL7V24Field
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
            Description = @"This optional numeric field is used in the sequence number protocol.",
            Sample = @"",
        };

        // check for repetitions
        if (expectedSequenceNumber.field.FieldRepetitions != null && expectedSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(expectedSequenceNumber.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < expectedSequenceNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = expectedSequenceNumber.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < expectedSequenceNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = expectedSequenceNumber.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < expectedSequenceNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = expectedSequenceNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            expectedSequenceNumber.fieldRepetitions = fieldRepetitions;
        }

        return expectedSequenceNumber;
    } 
}

internal HL7V24Field delayedAcknowledgmentType;

public HL7V24Field DelayedAcknowledgmentType
{
    get
    {
        if (delayedAcknowledgmentType != null)
        {
            return delayedAcknowledgmentType;
        }

        delayedAcknowledgmentType = new HL7V24Field
        {
            field = message[@"MSA"][5],
            Id = @"MSA.5",
            Type = @"Field",
            Position = @"MSA.5",
            Name = @"Delayed Acknowledgment Type",
            Length = 1,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0102",
            TableName = @"Delayed acknowledgment type",
            Description = @"This field has been retained for backward compatibility.  This field is used only as described above, in Section 2.13.2, Application (level 7) processing rules, deferred processing two phase reply (original acknowledgment mode only). Otherwise this field is not used.",
            Sample = @"",
        };

        // check for repetitions
        if (delayedAcknowledgmentType.field.FieldRepetitions != null && delayedAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(delayedAcknowledgmentType.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < delayedAcknowledgmentType.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = delayedAcknowledgmentType.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < delayedAcknowledgmentType.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = delayedAcknowledgmentType.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < delayedAcknowledgmentType.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = delayedAcknowledgmentType.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            delayedAcknowledgmentType.fieldRepetitions = fieldRepetitions;
        }

        return delayedAcknowledgmentType;
    } 
}

internal HL7V24Field errorCondition;

public HL7V24Field ErrorCondition
{
    get
    {
        if (errorCondition != null)
        {
            return errorCondition;
        }

        errorCondition = new HL7V24Field
        {
            field = message[@"MSA"][6],
            Id = @"MSA.6",
            Type = @"Field",
            Position = @"MSA.6",
            Name = @"Error Condition",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0357",
            TableName = @"Message error condition codes",
            Description = @"This field allows the acknowledging system to use a user-defined error code to further specify AR or AE type acknowledgments. This field is a generalized replacement for MSA-3-text message.",
            Sample = @"",
        };

        // check for repetitions
        if (errorCondition.field.FieldRepetitions != null && errorCondition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(errorCondition.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < errorCondition.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = errorCondition.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < errorCondition.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = errorCondition.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < errorCondition.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = errorCondition.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            errorCondition.fieldRepetitions = fieldRepetitions;
        }

        return errorCondition;
    } 
}
    }
}
