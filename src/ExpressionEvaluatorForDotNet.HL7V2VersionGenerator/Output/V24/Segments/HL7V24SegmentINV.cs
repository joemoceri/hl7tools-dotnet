using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentINV
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"INV"; } }

        public string SegmentId { get { return @"INV"; } }
        
        public string LongName { get { return @"Inventory Detail"; } }
        
        public string Description { get { return @"The inventory detail segment is the data necessary to track the inventory of substances (e.g. reagent, tips, waste) on equipment."; } }
        
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
                            Id = @"INV.1",
                            Type = @"Field",
                            Position = @"INV.1",
                            Name = @"Substance Identifier",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0451",
                            TableName = @"Substance identifier",
                            Description = @"Unique identifier for the substance that is in inventory.  This is a manufacturer-specific identifier",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.1.1",
                            Type = @"Component",
                            Position = @"INV.1.1",
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
                            Id = @"INV.1.2",
                            Type = @"Component",
                            Position = @"INV.1.2",
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
                            Id = @"INV.1.3",
                            Type = @"Component",
                            Position = @"INV.1.3",
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
                            Id = @"INV.1.4",
                            Type = @"Component",
                            Position = @"INV.1.4",
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
                            Id = @"INV.1.5",
                            Type = @"Component",
                            Position = @"INV.1.5",
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
                            Id = @"INV.1.6",
                            Type = @"Component",
                            Position = @"INV.1.6",
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
                            Id = @"INV.2",
                            Type = @"Field",
                            Position = @"INV.2",
                            Name = @"Substance Status",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0383",
                            TableName = @"Substance status",
                            Description = @"The status of the inventoried item.  The status indicates the current status of the substance. Refer to HL7 Table 0383 – Substance status for suggested values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.2.1",
                            Type = @"Component",
                            Position = @"INV.2.1",
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
                            Id = @"INV.2.2",
                            Type = @"Component",
                            Position = @"INV.2.2",
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
                            Id = @"INV.2.3",
                            Type = @"Component",
                            Position = @"INV.2.3",
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
                            Id = @"INV.2.4",
                            Type = @"Component",
                            Position = @"INV.2.4",
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
                            Id = @"INV.2.5",
                            Type = @"Component",
                            Position = @"INV.2.5",
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
                            Id = @"INV.2.6",
                            Type = @"Component",
                            Position = @"INV.2.6",
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
                            Id = @"INV.3",
                            Type = @"Field",
                            Position = @"INV.3",
                            Name = @"Substance Type",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0384",
                            TableName = @"Substance type",
                            Description = @"The type of substance.  Refer to HL7 Table 0384 – Substance type for suggested values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.3.1",
                            Type = @"Component",
                            Position = @"INV.3.1",
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
                            Id = @"INV.3.2",
                            Type = @"Component",
                            Position = @"INV.3.2",
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
                            Id = @"INV.3.3",
                            Type = @"Component",
                            Position = @"INV.3.3",
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
                            Id = @"INV.3.4",
                            Type = @"Component",
                            Position = @"INV.3.4",
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
                            Id = @"INV.3.5",
                            Type = @"Component",
                            Position = @"INV.3.5",
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
                            Id = @"INV.3.6",
                            Type = @"Component",
                            Position = @"INV.3.6",
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
                            Id = @"INV.4",
                            Type = @"Field",
                            Position = @"INV.4",
                            Name = @"Inventory Container Identifier",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the inventory container, e.g., unique identifier of a specific package instance of a specific substance. This is a manufacturer-specific identifier",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.4.1",
                            Type = @"Component",
                            Position = @"INV.4.1",
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
                            Id = @"INV.4.2",
                            Type = @"Component",
                            Position = @"INV.4.2",
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
                            Id = @"INV.4.3",
                            Type = @"Component",
                            Position = @"INV.4.3",
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
                            Id = @"INV.4.4",
                            Type = @"Component",
                            Position = @"INV.4.4",
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
                            Id = @"INV.4.5",
                            Type = @"Component",
                            Position = @"INV.4.5",
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
                            Id = @"INV.4.6",
                            Type = @"Component",
                            Position = @"INV.4.6",
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
                            Id = @"INV.5",
                            Type = @"Field",
                            Position = @"INV.5",
                            Name = @"Container Carrier Identifier",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the carrier used to transport the substance containers, (e.g., a removable rotor with reagent bottles).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.5.1",
                            Type = @"Component",
                            Position = @"INV.5.1",
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
                            Id = @"INV.5.2",
                            Type = @"Component",
                            Position = @"INV.5.2",
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
                            Id = @"INV.5.3",
                            Type = @"Component",
                            Position = @"INV.5.3",
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
                            Id = @"INV.5.4",
                            Type = @"Component",
                            Position = @"INV.5.4",
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
                            Id = @"INV.5.5",
                            Type = @"Component",
                            Position = @"INV.5.5",
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
                            Id = @"INV.5.6",
                            Type = @"Component",
                            Position = @"INV.5.6",
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
                            Id = @"INV.6",
                            Type = @"Field",
                            Position = @"INV.6",
                            Name = @"Position on Carrier",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the position (e.g., index) on the carrier.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.6.1",
                            Type = @"Component",
                            Position = @"INV.6.1",
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
                            Id = @"INV.6.2",
                            Type = @"Component",
                            Position = @"INV.6.2",
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
                            Id = @"INV.6.3",
                            Type = @"Component",
                            Position = @"INV.6.3",
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
                            Id = @"INV.6.4",
                            Type = @"Component",
                            Position = @"INV.6.4",
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
                            Id = @"INV.6.5",
                            Type = @"Component",
                            Position = @"INV.6.5",
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
                            Id = @"INV.6.6",
                            Type = @"Component",
                            Position = @"INV.6.6",
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
                            Id = @"INV.7",
                            Type = @"Field",
                            Position = @"INV.7",
                            Name = @"Initial Quantity",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the initial quantity of the substance in inventory",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.8",
                            Type = @"Field",
                            Position = @"INV.8",
                            Name = @"Current Quantity",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the current quantity, i.e., initial quantity minus what has been actually used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.9",
                            Type = @"Field",
                            Position = @"INV.9",
                            Name = @"Available Quantity",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the available quantity of substance.   This is the current quantity minus any planned consumption (e.g., tests that are planned).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.10",
                            Type = @"Field",
                            Position = @"INV.10",
                            Name = @"Consumption Quantity",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the consumption that is used each time the equipment uses this substance",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.11",
                            Type = @"Field",
                            Position = @"INV.11",
                            Name = @"Quantity Units",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the units of measure of the available quantity.  If the units are ISO+ units, they should be recorded as single case abbreviations.  If the units are ANS+ or L (local), the units and the source code table must be recorded, except that in this case, component delimiters should be replaced by subcomponent delimiters.  For example, “l” indicates liters, whereas pt&&ANS+ indicates pints (ANSI units). The default unit is milliliters (ml), which should be assumed if no units are reported",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.11.1",
                            Type = @"Component",
                            Position = @"INV.11.1",
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
                            Id = @"INV.11.2",
                            Type = @"Component",
                            Position = @"INV.11.2",
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
                            Id = @"INV.11.3",
                            Type = @"Component",
                            Position = @"INV.11.3",
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
                            Id = @"INV.11.4",
                            Type = @"Component",
                            Position = @"INV.11.4",
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
                            Id = @"INV.11.5",
                            Type = @"Component",
                            Position = @"INV.11.5",
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
                            Id = @"INV.11.6",
                            Type = @"Component",
                            Position = @"INV.11.6",
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
                            Id = @"INV.12",
                            Type = @"Field",
                            Position = @"INV.12",
                            Name = @"Expiration Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the expiration date/time of the substance",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.12.1",
                            Type = @"Component",
                            Position = @"INV.12.1",
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
                            Id = @"INV.12.2",
                            Type = @"Component",
                            Position = @"INV.12.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.13",
                            Type = @"Field",
                            Position = @"INV.13",
                            Name = @"First Used Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the time and date when the substance was first used. This date and time can be necessary to determine the stability of the substance",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.13.1",
                            Type = @"Component",
                            Position = @"INV.13.1",
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
                            Id = @"INV.13.2",
                            Type = @"Component",
                            Position = @"INV.13.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14",
                            Type = @"Field",
                            Position = @"INV.14",
                            Name = @"On Board Stability Duration",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TQ",
                            DataTypeName = @"Timing Quantity",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the time duration that the substance is stable",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.14.1",
                            Type = @"Component",
                            Position = @"INV.14.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the quantity of the service that should be provided at each service interval. For example, if two blood cultures are to be obtained every 4 hours, the quantity would be 2.  If three units of blood are to be typed and cross-matched, the quantity would be 3.  The default value is 1.  When units are required, they can be added, specified by a subcomponent delimiter.

Note: The component delimiter in this CQ is demoted to a subcomponent delimiter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.14.1.1",
                            Type = @"SubComponent",
                            Position = @"INV.14.1.1",
                            Name = @"Quantity",
                            Length = 0,
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
                            Id = @"INV.14.1.2",
                            Type = @"SubComponent",
                            Position = @"INV.14.1.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the observation is measured in the default units, the units need not be transmitted. If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component. If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7. If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7. But in these cases the component separator should be replaced by the subcomponent delimiter",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.2",
                            Type = @"Component",
                            Position = @"INV.14.2",
                            Name = @"Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"RI",
                            DataTypeName = @"Repeat Interval",
                            TableId = null,
                            TableName = null,
                            Description = @"This field determines the interval between repeated services.

The default is one time only, the first subcomponent is the repeat pattern, and the second subcomponent is the explicit time at which pattern is to be executed.

Note: The component delimiter in this CQ is demoted to a subcomponent delimiter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.14.2.1",
                            Type = @"SubComponent",
                            Position = @"INV.14.2.1",
                            Name = @"Repeat Pattern",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The repeating frequency with which the treatment is to be administered.  It is similar to the frequency and SIG code tables used in order entry systems. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.2.2",
                            Type = @"SubComponent",
                            Position = @"INV.14.2.2",
                            Name = @"Explicit Time Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field explicitly lists the actual times referenced by the code in the first subcomponent, in the following format: HHMM,HHMM,HHMM,.…  This second subcomponent will be used to clarify the first subcomponent in cases where the actual administration times vary within an institution.  If the time of the order spans more than a single day, this new subcomponent is only practical if the same times of administration occur for each day of the order.  If the actual start time of the order (as given by the fourth subcomponent of the quantity/timing field) is after the first explicit time, the first administration is taken to be the first explicit time after the start time.  In the case where the patient moves to a location having a different set of explicit times, the existing order may be updated with a new quantity/timing field showing the changed explicit times.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.3",
                            Type = @"Component",
                            Position = @"INV.14.3",
                            Name = @"Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates how long the service should continue after it is started.  The default is INDEF (do indefinitely). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.4",
                            Type = @"Component",
                            Position = @"INV.14.4",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be specified by the orderer, in which case it indicates the earliest date/time at which the services should be started.  In many cases, however, the start date/time will be implied or will be defined by other fields in the order record (e.g., urgency - STAT).  In such a case, this field will be empty.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.14.4.1",
                            Type = @"SubComponent",
                            Position = @"INV.14.4.1",
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
                            Id = @"INV.14.4.2",
                            Type = @"SubComponent",
                            Position = @"INV.14.4.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.5",
                            Type = @"Component",
                            Position = @"INV.14.5",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"When filled in by the requester of the service, this field should contain the latest date/time that the service should be performed.  If it has not been performed by the specified time, it should not be performed at all.  The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.14.5.1",
                            Type = @"SubComponent",
                            Position = @"INV.14.5.1",
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
                            Id = @"INV.14.5.2",
                            Type = @"SubComponent",
                            Position = @"INV.14.5.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.6",
                            Type = @"Component",
                            Position = @"INV.14.6",
                            Name = @"Priority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @" This field describes the urgency of the request.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.7",
                            Type = @"Component",
                            Position = @"INV.14.7",
                            Name = @"Condition",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a free text field that describes the conditions under which the drug is to be given.  For example, PRN pain, or to keep blood pressure below 110.  The presence of text in this field should be taken to mean that human review is needed to determine the how and/or when this drug should be given.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.8",
                            Type = @"Component",
                            Position = @"INV.14.8",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a full text version of the instruction (optional).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.9",
                            Type = @"Component",
                            Position = @"INV.14.9",
                            Name = @"Conjunction Component",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0472",
                            TableName = @"TQ Conjunction ID",
                            Description = @"This non-null component indicates that a second timing specification is to follow using the repeat delimiter.  This field can take three values as shown in HL7 table 0472 - TQ Conjunction ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.10",
                            Type = @"Component",
                            Position = @"INV.14.10",
                            Name = @"Order Sequencing",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"OSD",
                            DataTypeName = @"Order Sequence",
                            TableId = null,
                            TableName = null,
                            Description = @"There are many situations, such as the creation of an order for a group of intravenous (IV) solutions, where the sequence of the individual intravenous solutions (each a service in itself) needs to be specified, e.g., hyperalimentation with multi-vitamins in every third bottle.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.14.10.1",
                            Type = @"SubComponent",
                            Position = @"INV.14.10.1",
                            Name = @"Sequence/results Flag",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"OSD1",
                            TableName = @"Sequence condition",
                            Description = @"S for sequence conditions; C for cyclical; R is reserved for possible future use. The C will be used for indicating a repeating cycle of orders; for example, individual intravenous solutions used in a cyclical sequence (a.k.a. “Alternating IVs”).  This value would be compatible with linking separate orders or with having all cyclical order components in a single order.  Likewise, the value would be compatible with either Parent-Child messages or a single order message to communicate the orders’ sequencing ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.10.2",
                            Type = @"SubComponent",
                            Position = @"INV.14.10.2",
                            Name = @"Placer Order Number: Entity Identifier",
                            Length = 0,
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
                            Id = @"INV.14.10.3",
                            Type = @"SubComponent",
                            Position = @"INV.14.10.3",
                            Name = @"Placer Order Number: Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.10.4",
                            Type = @"SubComponent",
                            Position = @"INV.14.10.4",
                            Name = @"Filler Order Number: Entity Identifier",
                            Length = 0,
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
                            Id = @"INV.14.10.5",
                            Type = @"SubComponent",
                            Position = @"INV.14.10.5",
                            Name = @"Filler Order Number: Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.10.6",
                            Type = @"SubComponent",
                            Position = @"INV.14.10.6",
                            Name = @"Sequence Condition Value",
                            Length = 0,
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
                            Id = @"INV.14.10.7",
                            Type = @"SubComponent",
                            Position = @"INV.14.10.7",
                            Name = @"Maximum Number Of Repeats",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum number of repeats to be used only on cyclic groups.  The total number of repeats is constrained by the end date/time of the last repeat or the end date/time of the parent, whichever is first.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.10.8",
                            Type = @"SubComponent",
                            Position = @"INV.14.10.8",
                            Name = @"Placer Order Number: Universal ID",
                            Length = 0,
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
                            Id = @"INV.14.10.9",
                            Type = @"SubComponent",
                            Position = @"INV.14.10.9",
                            Name = @"Placer Order Number; Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.10.10",
                            Type = @"SubComponent",
                            Position = @"INV.14.10.10",
                            Name = @"Filler Order Number: Universal ID",
                            Length = 0,
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
                            Id = @"INV.14.10.11",
                            Type = @"SubComponent",
                            Position = @"INV.14.10.11",
                            Name = @"Filler Order Number: Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.14.11",
                            Type = @"Component",
                            Position = @"INV.14.11",
                            Name = @"Occurrence Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the duration for a single performance of a service, e.g., whirlpool twenty minutes three times per day for three days. It is optional within TQ and does not repeat.

Note: The component delimiter in this CQ is demoted to a subcomponent delimiter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.14.11.1",
                            Type = @"SubComponent",
                            Position = @"INV.14.11.1",
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
                            Id = @"INV.14.11.2",
                            Type = @"SubComponent",
                            Position = @"INV.14.11.2",
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
                            Id = @"INV.14.11.3",
                            Type = @"SubComponent",
                            Position = @"INV.14.11.3",
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
                            Id = @"INV.14.11.4",
                            Type = @"SubComponent",
                            Position = @"INV.14.11.4",
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
                            Id = @"INV.14.11.5",
                            Type = @"SubComponent",
                            Position = @"INV.14.11.5",
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
                            Id = @"INV.14.11.6",
                            Type = @"SubComponent",
                            Position = @"INV.14.11.6",
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
                            Id = @"INV.14.12",
                            Type = @"Component",
                            Position = @"INV.14.12",
                            Name = @"Total Occurences",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the total number of occurrences of a service that should result from this order.  It is optional within TQ and does not repeat.  If both the end date/time and the total occurrences are valued and the occurrences would extend beyond the end date/time, then the end date/time takes precedence.  Otherwise the number of occurrences takes precedence.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.15",
                            Type = @"Field",
                            Position = @"INV.15",
                            Name = @"Test/Fluid Identifier",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the list of tests and body fluid that apply to this substance.  This is a repeating field. An empty field means that this substance is not test specific, i.e., it applies to all tests.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.15.1",
                            Type = @"Component",
                            Position = @"INV.15.1",
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
                            Id = @"INV.15.2",
                            Type = @"Component",
                            Position = @"INV.15.2",
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
                            Id = @"INV.15.3",
                            Type = @"Component",
                            Position = @"INV.15.3",
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
                            Id = @"INV.15.4",
                            Type = @"Component",
                            Position = @"INV.15.4",
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
                            Id = @"INV.15.5",
                            Type = @"Component",
                            Position = @"INV.15.5",
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
                            Id = @"INV.15.6",
                            Type = @"Component",
                            Position = @"INV.15.6",
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
                            Id = @"INV.16",
                            Type = @"Field",
                            Position = @"INV.16",
                            Name = @"Manufacturer Lot Number",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the lot number assigned by the manufacturer during production of the substance",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"INV.17",
                            Type = @"Field",
                            Position = @"INV.17",
                            Name = @"Manufacturer Identifier",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0385",
                            TableName = @"Manufacturer identifier",
                            Description = @"This field identifies the manufacturer of this substance. Refer to User-defined Table 0385 – Manufacturer identifier for suggested values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.17.1",
                            Type = @"Component",
                            Position = @"INV.17.1",
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
                            Id = @"INV.17.2",
                            Type = @"Component",
                            Position = @"INV.17.2",
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
                            Id = @"INV.17.3",
                            Type = @"Component",
                            Position = @"INV.17.3",
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
                            Id = @"INV.17.4",
                            Type = @"Component",
                            Position = @"INV.17.4",
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
                            Id = @"INV.17.5",
                            Type = @"Component",
                            Position = @"INV.17.5",
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
                            Id = @"INV.17.6",
                            Type = @"Component",
                            Position = @"INV.17.6",
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
                            Id = @"INV.18",
                            Type = @"Field",
                            Position = @"INV.18",
                            Name = @"Supplier Identifier",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0386",
                            TableName = @"Supplier identifier",
                            Description = @"This field identifies the supplier of this substance. Refer to User-defined Table 0386 – Supplier identifier for suggested values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"INV.18.1",
                            Type = @"Component",
                            Position = @"INV.18.1",
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
                            Id = @"INV.18.2",
                            Type = @"Component",
                            Position = @"INV.18.2",
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
                            Id = @"INV.18.3",
                            Type = @"Component",
                            Position = @"INV.18.3",
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
                            Id = @"INV.18.4",
                            Type = @"Component",
                            Position = @"INV.18.4",
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
                            Id = @"INV.18.5",
                            Type = @"Component",
                            Position = @"INV.18.5",
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
                            Id = @"INV.18.6",
                            Type = @"Component",
                            Position = @"INV.18.6",
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

        public HL7V24SegmentINV(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field substanceIdentifier;

public HL7V24Field SubstanceIdentifier
{
    get
    {
        if (substanceIdentifier != null)
        {
            return substanceIdentifier;
        }

        substanceIdentifier = new HL7V24Field
        {
            field = message[@"INV"][1],
            Id = @"INV.1",
            Type = @"Field",
            Position = @"INV.1",
            Name = @"Substance Identifier",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0451",
            TableName = @"Substance identifier",
            Description = @"Unique identifier for the substance that is in inventory.  This is a manufacturer-specific identifier",
            Sample = @"",
        };

        // check for repetitions
        if (substanceIdentifier.field.FieldRepetitions != null && substanceIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(substanceIdentifier.Id));
            substanceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(substanceIdentifier, fieldData);
        }

        return substanceIdentifier;
    } 
}

internal HL7V24Field substanceStatus;

public HL7V24Field SubstanceStatus
{
    get
    {
        if (substanceStatus != null)
        {
            return substanceStatus;
        }

        substanceStatus = new HL7V24Field
        {
            field = message[@"INV"][2],
            Id = @"INV.2",
            Type = @"Field",
            Position = @"INV.2",
            Name = @"Substance Status",
            Length = 250,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0383",
            TableName = @"Substance status",
            Description = @"The status of the inventoried item.  The status indicates the current status of the substance. Refer to HL7 Table 0383 – Substance status for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (substanceStatus.field.FieldRepetitions != null && substanceStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(substanceStatus.Id));
            substanceStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(substanceStatus, fieldData);
        }

        return substanceStatus;
    } 
}

internal HL7V24Field substanceType;

public HL7V24Field SubstanceType
{
    get
    {
        if (substanceType != null)
        {
            return substanceType;
        }

        substanceType = new HL7V24Field
        {
            field = message[@"INV"][3],
            Id = @"INV.3",
            Type = @"Field",
            Position = @"INV.3",
            Name = @"Substance Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0384",
            TableName = @"Substance type",
            Description = @"The type of substance.  Refer to HL7 Table 0384 – Substance type for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (substanceType.field.FieldRepetitions != null && substanceType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(substanceType.Id));
            substanceType.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(substanceType, fieldData);
        }

        return substanceType;
    } 
}

internal HL7V24Field inventoryContainerIdentifier;

public HL7V24Field InventoryContainerIdentifier
{
    get
    {
        if (inventoryContainerIdentifier != null)
        {
            return inventoryContainerIdentifier;
        }

        inventoryContainerIdentifier = new HL7V24Field
        {
            field = message[@"INV"][4],
            Id = @"INV.4",
            Type = @"Field",
            Position = @"INV.4",
            Name = @"Inventory Container Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"Identifies the inventory container, e.g., unique identifier of a specific package instance of a specific substance. This is a manufacturer-specific identifier",
            Sample = @"",
        };

        // check for repetitions
        if (inventoryContainerIdentifier.field.FieldRepetitions != null && inventoryContainerIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryContainerIdentifier.Id));
            inventoryContainerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(inventoryContainerIdentifier, fieldData);
        }

        return inventoryContainerIdentifier;
    } 
}

internal HL7V24Field containerCarrierIdentifier;

public HL7V24Field ContainerCarrierIdentifier
{
    get
    {
        if (containerCarrierIdentifier != null)
        {
            return containerCarrierIdentifier;
        }

        containerCarrierIdentifier = new HL7V24Field
        {
            field = message[@"INV"][5],
            Id = @"INV.5",
            Type = @"Field",
            Position = @"INV.5",
            Name = @"Container Carrier Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This is the carrier used to transport the substance containers, (e.g., a removable rotor with reagent bottles).",
            Sample = @"",
        };

        // check for repetitions
        if (containerCarrierIdentifier.field.FieldRepetitions != null && containerCarrierIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(containerCarrierIdentifier.Id));
            containerCarrierIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(containerCarrierIdentifier, fieldData);
        }

        return containerCarrierIdentifier;
    } 
}

internal HL7V24Field positiononCarrier;

public HL7V24Field PositiononCarrier
{
    get
    {
        if (positiononCarrier != null)
        {
            return positiononCarrier;
        }

        positiononCarrier = new HL7V24Field
        {
            field = message[@"INV"][6],
            Id = @"INV.6",
            Type = @"Field",
            Position = @"INV.6",
            Name = @"Position on Carrier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"Identifies the position (e.g., index) on the carrier.",
            Sample = @"",
        };

        // check for repetitions
        if (positiononCarrier.field.FieldRepetitions != null && positiononCarrier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(positiononCarrier.Id));
            positiononCarrier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(positiononCarrier, fieldData);
        }

        return positiononCarrier;
    } 
}

internal HL7V24Field initialQuantity;

public HL7V24Field InitialQuantity
{
    get
    {
        if (initialQuantity != null)
        {
            return initialQuantity;
        }

        initialQuantity = new HL7V24Field
        {
            field = message[@"INV"][7],
            Id = @"INV.7",
            Type = @"Field",
            Position = @"INV.7",
            Name = @"Initial Quantity",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the initial quantity of the substance in inventory",
            Sample = @"",
        };

        // check for repetitions
        if (initialQuantity.field.FieldRepetitions != null && initialQuantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(initialQuantity.Id));
            initialQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(initialQuantity, fieldData);
        }

        return initialQuantity;
    } 
}

internal HL7V24Field currentQuantity;

public HL7V24Field CurrentQuantity
{
    get
    {
        if (currentQuantity != null)
        {
            return currentQuantity;
        }

        currentQuantity = new HL7V24Field
        {
            field = message[@"INV"][8],
            Id = @"INV.8",
            Type = @"Field",
            Position = @"INV.8",
            Name = @"Current Quantity",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the current quantity, i.e., initial quantity minus what has been actually used",
            Sample = @"",
        };

        // check for repetitions
        if (currentQuantity.field.FieldRepetitions != null && currentQuantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(currentQuantity.Id));
            currentQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(currentQuantity, fieldData);
        }

        return currentQuantity;
    } 
}

internal HL7V24Field availableQuantity;

public HL7V24Field AvailableQuantity
{
    get
    {
        if (availableQuantity != null)
        {
            return availableQuantity;
        }

        availableQuantity = new HL7V24Field
        {
            field = message[@"INV"][9],
            Id = @"INV.9",
            Type = @"Field",
            Position = @"INV.9",
            Name = @"Available Quantity",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the available quantity of substance.   This is the current quantity minus any planned consumption (e.g., tests that are planned).",
            Sample = @"",
        };

        // check for repetitions
        if (availableQuantity.field.FieldRepetitions != null && availableQuantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(availableQuantity.Id));
            availableQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(availableQuantity, fieldData);
        }

        return availableQuantity;
    } 
}

internal HL7V24Field consumptionQuantity;

public HL7V24Field ConsumptionQuantity
{
    get
    {
        if (consumptionQuantity != null)
        {
            return consumptionQuantity;
        }

        consumptionQuantity = new HL7V24Field
        {
            field = message[@"INV"][10],
            Id = @"INV.10",
            Type = @"Field",
            Position = @"INV.10",
            Name = @"Consumption Quantity",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the consumption that is used each time the equipment uses this substance",
            Sample = @"",
        };

        // check for repetitions
        if (consumptionQuantity.field.FieldRepetitions != null && consumptionQuantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(consumptionQuantity.Id));
            consumptionQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(consumptionQuantity, fieldData);
        }

        return consumptionQuantity;
    } 
}

internal HL7V24Field quantityUnits;

public HL7V24Field QuantityUnits
{
    get
    {
        if (quantityUnits != null)
        {
            return quantityUnits;
        }

        quantityUnits = new HL7V24Field
        {
            field = message[@"INV"][11],
            Id = @"INV.11",
            Type = @"Field",
            Position = @"INV.11",
            Name = @"Quantity Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the units of measure of the available quantity.  If the units are ISO+ units, they should be recorded as single case abbreviations.  If the units are ANS+ or L (local), the units and the source code table must be recorded, except that in this case, component delimiters should be replaced by subcomponent delimiters.  For example, “l” indicates liters, whereas pt&&ANS+ indicates pints (ANSI units). The default unit is milliliters (ml), which should be assumed if no units are reported",
            Sample = @"",
        };

        // check for repetitions
        if (quantityUnits.field.FieldRepetitions != null && quantityUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityUnits.Id));
            quantityUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(quantityUnits, fieldData);
        }

        return quantityUnits;
    } 
}

internal HL7V24Field expirationDateTime;

public HL7V24Field ExpirationDateTime
{
    get
    {
        if (expirationDateTime != null)
        {
            return expirationDateTime;
        }

        expirationDateTime = new HL7V24Field
        {
            field = message[@"INV"][12],
            Id = @"INV.12",
            Type = @"Field",
            Position = @"INV.12",
            Name = @"Expiration Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the expiration date/time of the substance",
            Sample = @"",
        };

        // check for repetitions
        if (expirationDateTime.field.FieldRepetitions != null && expirationDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(expirationDateTime.Id));
            expirationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(expirationDateTime, fieldData);
        }

        return expirationDateTime;
    } 
}

internal HL7V24Field firstUsedDateTime;

public HL7V24Field FirstUsedDateTime
{
    get
    {
        if (firstUsedDateTime != null)
        {
            return firstUsedDateTime;
        }

        firstUsedDateTime = new HL7V24Field
        {
            field = message[@"INV"][13],
            Id = @"INV.13",
            Type = @"Field",
            Position = @"INV.13",
            Name = @"First Used Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the time and date when the substance was first used. This date and time can be necessary to determine the stability of the substance",
            Sample = @"",
        };

        // check for repetitions
        if (firstUsedDateTime.field.FieldRepetitions != null && firstUsedDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(firstUsedDateTime.Id));
            firstUsedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(firstUsedDateTime, fieldData);
        }

        return firstUsedDateTime;
    } 
}

internal HL7V24Field onBoardStabilityDuration;

public HL7V24Field OnBoardStabilityDuration
{
    get
    {
        if (onBoardStabilityDuration != null)
        {
            return onBoardStabilityDuration;
        }

        onBoardStabilityDuration = new HL7V24Field
        {
            field = message[@"INV"][14],
            Id = @"INV.14",
            Type = @"Field",
            Position = @"INV.14",
            Name = @"On Board Stability Duration",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TQ",
            DataTypeName = @"Timing Quantity",
            TableId = null,
            TableName = null,
            Description = @"This field is the time duration that the substance is stable",
            Sample = @"",
        };

        // check for repetitions
        if (onBoardStabilityDuration.field.FieldRepetitions != null && onBoardStabilityDuration.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(onBoardStabilityDuration.Id));
            onBoardStabilityDuration.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(onBoardStabilityDuration, fieldData);
        }

        return onBoardStabilityDuration;
    } 
}

internal HL7V24Field testFluidIdentifier;

public HL7V24Field TestFluidIdentifier
{
    get
    {
        if (testFluidIdentifier != null)
        {
            return testFluidIdentifier;
        }

        testFluidIdentifier = new HL7V24Field
        {
            field = message[@"INV"][15],
            Id = @"INV.15",
            Type = @"Field",
            Position = @"INV.15",
            Name = @"Test/Fluid Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the list of tests and body fluid that apply to this substance.  This is a repeating field. An empty field means that this substance is not test specific, i.e., it applies to all tests.",
            Sample = @"",
        };

        // check for repetitions
        if (testFluidIdentifier.field.FieldRepetitions != null && testFluidIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(testFluidIdentifier.Id));
            testFluidIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(testFluidIdentifier, fieldData);
        }

        return testFluidIdentifier;
    } 
}

internal HL7V24Field manufacturerLotNumber;

public HL7V24Field ManufacturerLotNumber
{
    get
    {
        if (manufacturerLotNumber != null)
        {
            return manufacturerLotNumber;
        }

        manufacturerLotNumber = new HL7V24Field
        {
            field = message[@"INV"][16],
            Id = @"INV.16",
            Type = @"Field",
            Position = @"INV.16",
            Name = @"Manufacturer Lot Number",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the lot number assigned by the manufacturer during production of the substance",
            Sample = @"",
        };

        // check for repetitions
        if (manufacturerLotNumber.field.FieldRepetitions != null && manufacturerLotNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(manufacturerLotNumber.Id));
            manufacturerLotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(manufacturerLotNumber, fieldData);
        }

        return manufacturerLotNumber;
    } 
}

internal HL7V24Field manufacturerIdentifier;

public HL7V24Field ManufacturerIdentifier
{
    get
    {
        if (manufacturerIdentifier != null)
        {
            return manufacturerIdentifier;
        }

        manufacturerIdentifier = new HL7V24Field
        {
            field = message[@"INV"][17],
            Id = @"INV.17",
            Type = @"Field",
            Position = @"INV.17",
            Name = @"Manufacturer Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0385",
            TableName = @"Manufacturer identifier",
            Description = @"This field identifies the manufacturer of this substance. Refer to User-defined Table 0385 – Manufacturer identifier for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (manufacturerIdentifier.field.FieldRepetitions != null && manufacturerIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(manufacturerIdentifier.Id));
            manufacturerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(manufacturerIdentifier, fieldData);
        }

        return manufacturerIdentifier;
    } 
}

internal HL7V24Field supplierIdentifier;

public HL7V24Field SupplierIdentifier
{
    get
    {
        if (supplierIdentifier != null)
        {
            return supplierIdentifier;
        }

        supplierIdentifier = new HL7V24Field
        {
            field = message[@"INV"][18],
            Id = @"INV.18",
            Type = @"Field",
            Position = @"INV.18",
            Name = @"Supplier Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0386",
            TableName = @"Supplier identifier",
            Description = @"This field identifies the supplier of this substance. Refer to User-defined Table 0386 – Supplier identifier for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (supplierIdentifier.field.FieldRepetitions != null && supplierIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(supplierIdentifier.Id));
            supplierIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(supplierIdentifier, fieldData);
        }

        return supplierIdentifier;
    } 
}
    }
}
