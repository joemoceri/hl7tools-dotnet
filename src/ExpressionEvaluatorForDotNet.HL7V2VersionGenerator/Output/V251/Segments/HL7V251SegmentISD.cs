using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentISD
    {
        public readonly HL7V2Message message;

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
                            Description = @"This field specifies the type of interaction. If the interaction is performed as the result of a previous command, then the interaction type as specified in User-defined Table 0368 - Remote control command should be used.",
                            Sample = @"",
                            FieldDatas = 
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
                            Description = @"This field transfers the state of the interaction. If the interaction is performed as the result of a previous command, then the interaction state should be one of the Command Responses (Refer to User-defined Table 0387 - Command response ). If the interaction is not performed as a result of a command (e.g., periodically time triggered automatic maintenance) then this state is interaction specific, and should refer to either the LECIS state transitions for interactions or a user or equipment specific table.",
                            Sample = @"",
                            FieldDatas = 
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
                        
                        },
                        };
            }
        }

        public HL7V251SegmentISD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field referenceInteractionNumber(uniqueidentifier);

public HL7V251Field ReferenceInteractionNumber(uniqueidentifier)
{
    get
    {
        if (referenceInteractionNumber(uniqueidentifier) != null)
        {
            return referenceInteractionNumber(uniqueidentifier);
        }

        referenceInteractionNumber(uniqueidentifier) = new HL7V251Field
        {
            field = message[@"ISD"][1],
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
        };

        

        

        

        return referenceInteractionNumber(uniqueidentifier);
    } 
}
internal HL7V251Field interactionTypeIdentifier;

public HL7V251Field InteractionTypeIdentifier
{
    get
    {
        if (interactionTypeIdentifier != null)
        {
            return interactionTypeIdentifier;
        }

        interactionTypeIdentifier = new HL7V251Field
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
            Description = @"This field specifies the type of interaction. If the interaction is performed as the result of a previous command, then the interaction type as specified in User-defined Table 0368 - Remote control command should be used.",
            Sample = @"",
        };

        

        

        

        return interactionTypeIdentifier;
    } 
}
internal HL7V251Field interactionActiveState;

public HL7V251Field InteractionActiveState
{
    get
    {
        if (interactionActiveState != null)
        {
            return interactionActiveState;
        }

        interactionActiveState = new HL7V251Field
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
            Description = @"This field transfers the state of the interaction. If the interaction is performed as the result of a previous command, then the interaction state should be one of the Command Responses (Refer to User-defined Table 0387 - Command response ). If the interaction is not performed as a result of a command (e.g., periodically time triggered automatic maintenance) then this state is interaction specific, and should refer to either the LECIS state transitions for interactions or a user or equipment specific table.",
            Sample = @"",
        };

        

        

        

        return interactionActiveState;
    } 
}

    }
}
