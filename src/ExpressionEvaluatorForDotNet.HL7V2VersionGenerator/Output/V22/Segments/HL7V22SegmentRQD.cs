using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentRQD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RQD"; } }

        public string SegmentId { get { return @"RQD"; } }
        
        public string LongName { get { return @"Requisition Detail"; } }
        
        public string Description { get { return @"RQD contains the detail for each requisitioned item."; } }
        
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

        public HL7V22SegmentRQD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _requisitionLineNumber;

public HL7V22Field RequisitionLineNumber
{
    get
    {
        if (_requisitionLineNumber != null)
        {
            return _requisitionLineNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQD.1",
            Type = @"Field",
            Position = @"RQD.1",
            Name = @"Requisition Line Number",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"number that identifies this line in the requisition",
            Sample = @"",
            Fields = null
        }

        _requisitionLineNumber = new HL7V22Field
        {
            field = message[@"RQD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requisitionLineNumber.field.FieldRepetitions != null && _requisitionLineNumber.field.FieldRepetitions.Count > 0)
        {
            _requisitionLineNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requisitionLineNumber, fieldData);
        }

        return _requisitionLineNumber;
    } 
}

internal HL7V22Field _itemCodeInternal;

public HL7V22Field ItemCodeInternal
{
    get
    {
        if (_itemCodeInternal != null)
        {
            return _itemCodeInternal;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQD.2",
            Type = @"Field",
            Position = @"RQD.2",
            Name = @"Item Code - Internal",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"identifier and description that uniquely identify the item on the application sending the requisition",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RQD.2.1",
                            Type = @"Component",
                            Position = @"RQD.2.1",
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
                            Id = @"RQD.2.2",
                            Type = @"Component",
                            Position = @"RQD.2.2",
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
                            Id = @"RQD.2.3",
                            Type = @"Component",
                            Position = @"RQD.2.3",
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
                            Id = @"RQD.2.4",
                            Type = @"Component",
                            Position = @"RQD.2.4",
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
                            Id = @"RQD.2.5",
                            Type = @"Component",
                            Position = @"RQD.2.5",
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
                            Id = @"RQD.2.6",
                            Type = @"Component",
                            Position = @"RQD.2.6",
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
                        },
                        }
        }

        _itemCodeInternal = new HL7V22Field
        {
            field = message[@"RQD"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_itemCodeInternal.field.FieldRepetitions != null && _itemCodeInternal.field.FieldRepetitions.Count > 0)
        {
            _itemCodeInternal.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_itemCodeInternal, fieldData);
        }

        return _itemCodeInternal;
    } 
}

internal HL7V22Field _itemCodeExternal;

public HL7V22Field ItemCodeExternal
{
    get
    {
        if (_itemCodeExternal != null)
        {
            return _itemCodeExternal;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQD.3",
            Type = @"Field",
            Position = @"RQD.3",
            Name = @"Item Code - External",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"identifier and description that uniquely identify the item on the application receiving the requisition",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RQD.3.1",
                            Type = @"Component",
                            Position = @"RQD.3.1",
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
                            Id = @"RQD.3.2",
                            Type = @"Component",
                            Position = @"RQD.3.2",
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
                            Id = @"RQD.3.3",
                            Type = @"Component",
                            Position = @"RQD.3.3",
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
                            Id = @"RQD.3.4",
                            Type = @"Component",
                            Position = @"RQD.3.4",
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
                            Id = @"RQD.3.5",
                            Type = @"Component",
                            Position = @"RQD.3.5",
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
                            Id = @"RQD.3.6",
                            Type = @"Component",
                            Position = @"RQD.3.6",
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
                        },
                        }
        }

        _itemCodeExternal = new HL7V22Field
        {
            field = message[@"RQD"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_itemCodeExternal.field.FieldRepetitions != null && _itemCodeExternal.field.FieldRepetitions.Count > 0)
        {
            _itemCodeExternal.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_itemCodeExternal, fieldData);
        }

        return _itemCodeExternal;
    } 
}

internal HL7V22Field _hospitalItemCode;

public HL7V22Field HospitalItemCode
{
    get
    {
        if (_hospitalItemCode != null)
        {
            return _hospitalItemCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQD.4",
            Type = @"Field",
            Position = @"RQD.4",
            Name = @"Hospital Item Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"identifier and description that uniquely identify the item on all applications in the hospital.  The identifier is usually controlled by the hospital Financial application in the Charge Description Master file",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RQD.4.1",
                            Type = @"Component",
                            Position = @"RQD.4.1",
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
                            Id = @"RQD.4.2",
                            Type = @"Component",
                            Position = @"RQD.4.2",
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
                            Id = @"RQD.4.3",
                            Type = @"Component",
                            Position = @"RQD.4.3",
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
                            Id = @"RQD.4.4",
                            Type = @"Component",
                            Position = @"RQD.4.4",
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
                            Id = @"RQD.4.5",
                            Type = @"Component",
                            Position = @"RQD.4.5",
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
                            Id = @"RQD.4.6",
                            Type = @"Component",
                            Position = @"RQD.4.6",
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
                        },
                        }
        }

        _hospitalItemCode = new HL7V22Field
        {
            field = message[@"RQD"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_hospitalItemCode.field.FieldRepetitions != null && _hospitalItemCode.field.FieldRepetitions.Count > 0)
        {
            _hospitalItemCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_hospitalItemCode, fieldData);
        }

        return _hospitalItemCode;
    } 
}

internal HL7V22Field _requisitionQuantity;

public HL7V22Field RequisitionQuantity
{
    get
    {
        if (_requisitionQuantity != null)
        {
            return _requisitionQuantity;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQD.5",
            Type = @"Field",
            Position = @"RQD.5",
            Name = @"Requisition Quantity",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"quantity requisitioned for this item",
            Sample = @"",
            Fields = null
        }

        _requisitionQuantity = new HL7V22Field
        {
            field = message[@"RQD"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requisitionQuantity.field.FieldRepetitions != null && _requisitionQuantity.field.FieldRepetitions.Count > 0)
        {
            _requisitionQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requisitionQuantity, fieldData);
        }

        return _requisitionQuantity;
    } 
}

internal HL7V22Field _requisitionUnitOfMeasure;

public HL7V22Field RequisitionUnitOfMeasure
{
    get
    {
        if (_requisitionUnitOfMeasure != null)
        {
            return _requisitionUnitOfMeasure;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQD.6",
            Type = @"Field",
            Position = @"RQD.6",
            Name = @"Requisition Unit Of Measure",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"unit of measure for this item",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RQD.6.1",
                            Type = @"Component",
                            Position = @"RQD.6.1",
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
                            Id = @"RQD.6.2",
                            Type = @"Component",
                            Position = @"RQD.6.2",
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
                            Id = @"RQD.6.3",
                            Type = @"Component",
                            Position = @"RQD.6.3",
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
                            Id = @"RQD.6.4",
                            Type = @"Component",
                            Position = @"RQD.6.4",
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
                            Id = @"RQD.6.5",
                            Type = @"Component",
                            Position = @"RQD.6.5",
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
                            Id = @"RQD.6.6",
                            Type = @"Component",
                            Position = @"RQD.6.6",
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
                        },
                        }
        }

        _requisitionUnitOfMeasure = new HL7V22Field
        {
            field = message[@"RQD"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requisitionUnitOfMeasure.field.FieldRepetitions != null && _requisitionUnitOfMeasure.field.FieldRepetitions.Count > 0)
        {
            _requisitionUnitOfMeasure.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requisitionUnitOfMeasure, fieldData);
        }

        return _requisitionUnitOfMeasure;
    } 
}

internal HL7V22Field _departmentCostCenter;

public HL7V22Field DepartmentCostCenter
{
    get
    {
        if (_departmentCostCenter != null)
        {
            return _departmentCostCenter;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQD.7",
            Type = @"Field",
            Position = @"RQD.7",
            Name = @"Department Cost Center",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"accounting code that identifies this department in order to charge for this item",
            Sample = @"",
            Fields = null
        }

        _departmentCostCenter = new HL7V22Field
        {
            field = message[@"RQD"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_departmentCostCenter.field.FieldRepetitions != null && _departmentCostCenter.field.FieldRepetitions.Count > 0)
        {
            _departmentCostCenter.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_departmentCostCenter, fieldData);
        }

        return _departmentCostCenter;
    } 
}

internal HL7V22Field _itemNaturalAccountCode;

public HL7V22Field ItemNaturalAccountCode
{
    get
    {
        if (_itemNaturalAccountCode != null)
        {
            return _itemNaturalAccountCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQD.8",
            Type = @"Field",
            Position = @"RQD.8",
            Name = @"Item Natural Account Code",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"accounting code that identifies this item in order to charge for this item",
            Sample = @"",
            Fields = null
        }

        _itemNaturalAccountCode = new HL7V22Field
        {
            field = message[@"RQD"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_itemNaturalAccountCode.field.FieldRepetitions != null && _itemNaturalAccountCode.field.FieldRepetitions.Count > 0)
        {
            _itemNaturalAccountCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_itemNaturalAccountCode, fieldData);
        }

        return _itemNaturalAccountCode;
    } 
}

internal HL7V22Field _delivertoId;

public HL7V22Field DelivertoId
{
    get
    {
        if (_delivertoId != null)
        {
            return _delivertoId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQD.9",
            Type = @"Field",
            Position = @"RQD.9",
            Name = @"Deliver-to Id",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"unique identifier and descriptive name of the department/location where the item should be delivered",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RQD.9.1",
                            Type = @"Component",
                            Position = @"RQD.9.1",
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
                            Id = @"RQD.9.2",
                            Type = @"Component",
                            Position = @"RQD.9.2",
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
                            Id = @"RQD.9.3",
                            Type = @"Component",
                            Position = @"RQD.9.3",
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
                            Id = @"RQD.9.4",
                            Type = @"Component",
                            Position = @"RQD.9.4",
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
                            Id = @"RQD.9.5",
                            Type = @"Component",
                            Position = @"RQD.9.5",
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
                            Id = @"RQD.9.6",
                            Type = @"Component",
                            Position = @"RQD.9.6",
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
                        },
                        }
        }

        _delivertoId = new HL7V22Field
        {
            field = message[@"RQD"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delivertoId.field.FieldRepetitions != null && _delivertoId.field.FieldRepetitions.Count > 0)
        {
            _delivertoId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_delivertoId, fieldData);
        }

        return _delivertoId;
    } 
}

internal HL7V22Field _dateNeeded;

public HL7V22Field DateNeeded
{
    get
    {
        if (_dateNeeded != null)
        {
            return _dateNeeded;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQD.10",
            Type = @"Field",
            Position = @"RQD.10",
            Name = @"Date Needed",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date this item is required",
            Sample = @"",
            Fields = null
        }

        _dateNeeded = new HL7V22Field
        {
            field = message[@"RQD"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateNeeded.field.FieldRepetitions != null && _dateNeeded.field.FieldRepetitions.Count > 0)
        {
            _dateNeeded.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dateNeeded, fieldData);
        }

        return _dateNeeded;
    } 
}
    }
}
