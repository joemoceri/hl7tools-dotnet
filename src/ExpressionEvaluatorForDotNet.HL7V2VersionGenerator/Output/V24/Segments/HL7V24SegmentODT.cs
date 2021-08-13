using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentODT
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ODT"; } }

        public string SegmentId { get { return @"ODT"; } }
        
        public string LongName { get { return @"Diet Tray Instructions"; } }
        
        public string Description { get { return @"This segment addresses tray instructions. These are independent of diet codes, supplements, and preferences and therefore get separate order numbers."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V24SegmentODT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _trayType;

public HL7V24Field TrayType
{
    get
    {
        if (_trayType != null)
        {
            return _trayType;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"ODT.1",
            Type = @"Field",
            Position = @"ODT.1",
            Name = @"Tray Type",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0160",
            TableName = @"Tray type",
            Description = @"This field defines the type of dietary tray. Refer to HL7 Table 0160 - Tray type for valid entries.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ODT.1.1",
                            Type = @"Component",
                            Position = @"ODT.1.1",
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
                            Id = @"ODT.1.2",
                            Type = @"Component",
                            Position = @"ODT.1.2",
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
                            Id = @"ODT.1.3",
                            Type = @"Component",
                            Position = @"ODT.1.3",
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
                            Id = @"ODT.1.4",
                            Type = @"Component",
                            Position = @"ODT.1.4",
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
                            Id = @"ODT.1.5",
                            Type = @"Component",
                            Position = @"ODT.1.5",
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
                            Id = @"ODT.1.6",
                            Type = @"Component",
                            Position = @"ODT.1.6",
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
                        },
                        }
        }

        _trayType = new HL7V24Field
        {
            field = message[@"ODT"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_trayType.field.FieldRepetitions != null && _trayType.field.FieldRepetitions.Count > 0)
        {
            _trayType.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_trayType, fieldData);
        }

        return _trayType;
    } 
}

internal HL7V24Field _servicePeriod;

public HL7V24Field ServicePeriod
{
    get
    {
        if (_servicePeriod != null)
        {
            return _servicePeriod;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"ODT.2",
            Type = @"Field",
            Position = @"ODT.2",
            Name = @"Service Period",
            Length = 250,
            Usage = @"O",
            Rpt = @"10",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"When blank, the modifier applies to all service periods. This field allows you to designate one or more of the feeding periods during a day by combining the codes as needed. It can also combine with quantity/timing to give such information as which service period the order belongs with. This field is identical in meaning with ODS-2-service period. See Section 4.8.1.2, ODS-2 Service period (CE) 00270, for further details.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ODT.2.1",
                            Type = @"Component",
                            Position = @"ODT.2.1",
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
                            Id = @"ODT.2.2",
                            Type = @"Component",
                            Position = @"ODT.2.2",
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
                            Id = @"ODT.2.3",
                            Type = @"Component",
                            Position = @"ODT.2.3",
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
                            Id = @"ODT.2.4",
                            Type = @"Component",
                            Position = @"ODT.2.4",
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
                            Id = @"ODT.2.5",
                            Type = @"Component",
                            Position = @"ODT.2.5",
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
                            Id = @"ODT.2.6",
                            Type = @"Component",
                            Position = @"ODT.2.6",
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
                        },
                        }
        }

        _servicePeriod = new HL7V24Field
        {
            field = message[@"ODT"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_servicePeriod.field.FieldRepetitions != null && _servicePeriod.field.FieldRepetitions.Count > 0)
        {
            _servicePeriod.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_servicePeriod, fieldData);
        }

        return _servicePeriod;
    } 
}

internal HL7V24Field _textInstruction;

public HL7V24Field TextInstruction
{
    get
    {
        if (_textInstruction != null)
        {
            return _textInstruction;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"ODT.3",
            Type = @"Field",
            Position = @"ODT.3",
            Name = @"Text Instruction",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field defines instructions associated with the tray. Example:",
            Sample = @"",
            Fields = null
        }

        _textInstruction = new HL7V24Field
        {
            field = message[@"ODT"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_textInstruction.field.FieldRepetitions != null && _textInstruction.field.FieldRepetitions.Count > 0)
        {
            _textInstruction.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_textInstruction, fieldData);
        }

        return _textInstruction;
    } 
}
    }
}
