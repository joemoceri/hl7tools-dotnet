using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentISD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ISD"; } }

        public string SegmentId { get { return @"ISD"; } }
        
        public string LongName { get { return @"Interaction Status Detail"; } }
        
        public string Description { get { return @"The interaction detail segment contains information about the status of specific interaction (e.g., processing) on the specific equipment."; } }
        
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

        public HL7V25SegmentISD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _referenceInteractionNumberuniqueidentifier;

public HL7V25Field ReferenceInteractionNumberuniqueidentifier
{
    get
    {
        if (_referenceInteractionNumberuniqueidentifier != null)
        {
            return _referenceInteractionNumberuniqueidentifier;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"ISD.1",
            Type = @"Field",
            Position = @"ISD.1",
            Name = @"Reference Interaction Number (unique identifier)",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This number uniquely identifies the interaction. If the interaction is performed as the result of a previous command, then the Reference Command Number should be used. (See ECD-1 Reference Command Number(NM) 01390)",
            Sample = @"",
            Fields = null
        }

        _referenceInteractionNumberuniqueidentifier = new HL7V25Field
        {
            field = message[@"ISD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referenceInteractionNumberuniqueidentifier.field.FieldRepetitions != null && _referenceInteractionNumberuniqueidentifier.field.FieldRepetitions.Count > 0)
        {
            _referenceInteractionNumberuniqueidentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_referenceInteractionNumberuniqueidentifier, fieldData);
        }

        return _referenceInteractionNumberuniqueidentifier;
    } 
}

internal HL7V25Field _interactionTypeIdentifier;

public HL7V25Field InteractionTypeIdentifier
{
    get
    {
        if (_interactionTypeIdentifier != null)
        {
            return _interactionTypeIdentifier;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field specifies the type of interaction. If the interaction is performed as the result of a previous command, then the interaction type as specified in User-defined Table 0368 - Remote control command should be used.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ISD.2.1",
                            Type = @"Component",
                            Position = @"ISD.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.2.2",
                            Type = @"Component",
                            Position = @"ISD.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.2.3",
                            Type = @"Component",
                            Position = @"ISD.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.2.4",
                            Type = @"Component",
                            Position = @"ISD.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.2.5",
                            Type = @"Component",
                            Position = @"ISD.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.2.6",
                            Type = @"Component",
                            Position = @"ISD.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _interactionTypeIdentifier = new HL7V25Field
        {
            field = message[@"ISD"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_interactionTypeIdentifier.field.FieldRepetitions != null && _interactionTypeIdentifier.field.FieldRepetitions.Count > 0)
        {
            _interactionTypeIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_interactionTypeIdentifier, fieldData);
        }

        return _interactionTypeIdentifier;
    } 
}

internal HL7V25Field _interactionActiveState;

public HL7V25Field InteractionActiveState
{
    get
    {
        if (_interactionActiveState != null)
        {
            return _interactionActiveState;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field transfers the state of the interaction. If the interaction is performed as the result of a previous command, then the interaction state should be one of the Command Responses (Refer to User-defined Table 0387 - Command response ). If the interaction is not performed as a result of a command (e.g., periodically time triggered automatic maintenance) then this state is interaction specific, and should refer to either the LECIS state transitions for interactions or a user or equipment specific table.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ISD.3.1",
                            Type = @"Component",
                            Position = @"ISD.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.3.2",
                            Type = @"Component",
                            Position = @"ISD.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.3.3",
                            Type = @"Component",
                            Position = @"ISD.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.3.4",
                            Type = @"Component",
                            Position = @"ISD.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.3.5",
                            Type = @"Component",
                            Position = @"ISD.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ISD.3.6",
                            Type = @"Component",
                            Position = @"ISD.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _interactionActiveState = new HL7V25Field
        {
            field = message[@"ISD"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_interactionActiveState.field.FieldRepetitions != null && _interactionActiveState.field.FieldRepetitions.Count > 0)
        {
            _interactionActiveState.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_interactionActiveState, fieldData);
        }

        return _interactionActiveState;
    } 
}
    }
}
