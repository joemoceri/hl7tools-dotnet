using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentISD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ISD"; } }

        public string SegmentId { get { return @"ISD"; } }
        
        public string LongName { get { return @"Interaction Status Detail"; } }
        
        public string Description { get { return @"The interaction detail segment contains information about the status of specific interaction (e.g., processing  see section Glossary) on the specific equipment."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

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
                            Id = @"ISD.1",
                            Type = @"Field",
                            Position = @"ISD.1",
                            Name = @"Reference Interaction Number",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This number uniquely identifies the interaction. If the interaction is performed as the result of a previous command, then the Reference Command Number should be used. (See 13.4.5.1 ECD-1  Reference command number (NM)  01390)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.2",
                            Type = @"Field",
                            Position = @"ISD.2",
                            Name = @"Interaction Type Identifier",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0368",
                            TableName = @"Remote control command",
                            Description = @"This field specifies the type of interaction.  If the interaction is performed as the result of a previous command, then the interaction type as specified in User-defined  Table 0368 - Remote control command should be used.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ISD.2.1",
                            Type = @"Component",
                            Position = @"ISD.2.1",
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
                            Id = @"ISD.2.2",
                            Type = @"Component",
                            Position = @"ISD.2.2",
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
                            Id = @"ISD.2.3",
                            Type = @"Component",
                            Position = @"ISD.2.3",
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
                            Id = @"ISD.2.4",
                            Type = @"Component",
                            Position = @"ISD.2.4",
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
                            Id = @"ISD.2.5",
                            Type = @"Component",
                            Position = @"ISD.2.5",
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
                            Id = @"ISD.2.6",
                            Type = @"Component",
                            Position = @"ISD.2.6",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.3",
                            Type = @"Field",
                            Position = @"ISD.3",
                            Name = @"Interaction Active State",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0387",
                            TableName = @"Command response",
                            Description = @"This field transfers the state of the interaction. If the interaction is performed as the result of a previous command, then the interaction state should be one of the Command Responses (Refer to Userdefined Table 0387 – Command response). If the interaction is not performed as a result of a command (e.g., periodically time triggered automatic maintenance) then this state is interaction specific, and should refer to either the LECIS state transitions for interactions or a user or equipment specific table.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ISD.3.1",
                            Type = @"Component",
                            Position = @"ISD.3.1",
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
                            Id = @"ISD.3.2",
                            Type = @"Component",
                            Position = @"ISD.3.2",
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
                            Id = @"ISD.3.3",
                            Type = @"Component",
                            Position = @"ISD.3.3",
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
                            Id = @"ISD.3.4",
                            Type = @"Component",
                            Position = @"ISD.3.4",
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
                            Id = @"ISD.3.5",
                            Type = @"Component",
                            Position = @"ISD.3.5",
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
                            Id = @"ISD.3.6",
                            Type = @"Component",
                            Position = @"ISD.3.6",
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

        public HL7V24SegmentISD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field referenceInteractionNumber;

public HL7V24Field ReferenceInteractionNumber
{
    get
    {
        if (referenceInteractionNumber != null)
        {
            return referenceInteractionNumber;
        }

        referenceInteractionNumber = new HL7V24Field
        {
            field = message[@"ISD"][1],
            Id = @"ISD.1",
            Type = @"Field",
            Position = @"ISD.1",
            Name = @"Reference Interaction Number",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This number uniquely identifies the interaction. If the interaction is performed as the result of a previous command, then the Reference Command Number should be used. (See 13.4.5.1 ECD-1  Reference command number (NM)  01390)",
            Sample = @"",
        };

        // check for repetitions
        if (referenceInteractionNumber.field.FieldRepetitions != null && referenceInteractionNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referenceInteractionNumber.Id));
            referenceInteractionNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(referenceInteractionNumber, fieldData);
        }

        return referenceInteractionNumber;
    } 
}

internal HL7V24Field interactionTypeIdentifier;

public HL7V24Field InteractionTypeIdentifier
{
    get
    {
        if (interactionTypeIdentifier != null)
        {
            return interactionTypeIdentifier;
        }

        interactionTypeIdentifier = new HL7V24Field
        {
            field = message[@"ISD"][2],
            Id = @"ISD.2",
            Type = @"Field",
            Position = @"ISD.2",
            Name = @"Interaction Type Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0368",
            TableName = @"Remote control command",
            Description = @"This field specifies the type of interaction.  If the interaction is performed as the result of a previous command, then the interaction type as specified in User-defined  Table 0368 - Remote control command should be used.",
            Sample = @"",
        };

        // check for repetitions
        if (interactionTypeIdentifier.field.FieldRepetitions != null && interactionTypeIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(interactionTypeIdentifier.Id));
            interactionTypeIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(interactionTypeIdentifier, fieldData);
        }

        return interactionTypeIdentifier;
    } 
}

internal HL7V24Field interactionActiveState;

public HL7V24Field InteractionActiveState
{
    get
    {
        if (interactionActiveState != null)
        {
            return interactionActiveState;
        }

        interactionActiveState = new HL7V24Field
        {
            field = message[@"ISD"][3],
            Id = @"ISD.3",
            Type = @"Field",
            Position = @"ISD.3",
            Name = @"Interaction Active State",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0387",
            TableName = @"Command response",
            Description = @"This field transfers the state of the interaction. If the interaction is performed as the result of a previous command, then the interaction state should be one of the Command Responses (Refer to Userdefined Table 0387 – Command response). If the interaction is not performed as a result of a command (e.g., periodically time triggered automatic maintenance) then this state is interaction specific, and should refer to either the LECIS state transitions for interactions or a user or equipment specific table.",
            Sample = @"",
        };

        // check for repetitions
        if (interactionActiveState.field.FieldRepetitions != null && interactionActiveState.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(interactionActiveState.Id));
            interactionActiveState.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(interactionActiveState, fieldData);
        }

        return interactionActiveState;
    } 
}
    }
}
