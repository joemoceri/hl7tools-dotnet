using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentCDM
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CDM"; } }

        public string SegmentId { get { return @"CDM"; } }
        
        public string LongName { get { return @"Charge Description Master"; } }
        
        public string Description { get { return @"The CDM segment contains the fields for identifying anything which is charged to patient accounts, including procedures, services, supplies.  It is intended to be used to maintain a list of valid chargeable utilization items.  Its purpose is to keep billing codes synchronized between HIS, Patient Accounting, and other departmental systems.  It is not intended to completely support materials management, inventory, or complex pricing structures for which additional complex fields would be required.  Given an identifying charge code, the associated fields in the charge description master file will provide basic pricing and billing data.  All the additional information necessary for patient accounting systems to do billing and claims is not intended to be included in this segment; those should be part of insurance or billing profile tables.

The Technical Steward for the CDM segment is PAFM."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V24SegmentCDM(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _primaryKeyValueCDM;

public HL7V24Field PrimaryKeyValueCDM
{
    get
    {
        if (_primaryKeyValueCDM != null)
        {
            return _primaryKeyValueCDM;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.1",
            Type = @"Field",
            Position = @"CDM.1",
            Name = @"Primary Key Value - CDM",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0132",
            TableName = @"Transaction code",
            Description = @"This field contains the code assigned by the institution for the purpose of uniquely identifying the thing that can be charged. The key field of the entry. For example, this field would be used to uniquely identify a procedure, item, or test for charging purposes. Probably the same set of values as used in FT1-7- Transaction code in financial messages. Must match MFE-4 - Primary key value - MFE . Refer to User-defined Table 0132 - Transaction for suggested values. See Chapter 7 for discussion of the universal service ID.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CDM.1.1",
                            Type = @"Component",
                            Position = @"CDM.1.1",
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
                            Id = @"CDM.1.2",
                            Type = @"Component",
                            Position = @"CDM.1.2",
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
                            Id = @"CDM.1.3",
                            Type = @"Component",
                            Position = @"CDM.1.3",
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
                            Id = @"CDM.1.4",
                            Type = @"Component",
                            Position = @"CDM.1.4",
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
                            Id = @"CDM.1.5",
                            Type = @"Component",
                            Position = @"CDM.1.5",
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
                            Id = @"CDM.1.6",
                            Type = @"Component",
                            Position = @"CDM.1.6",
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

        _primaryKeyValueCDM = new HL7V24Field
        {
            field = message[@"CDM"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryKeyValueCDM.field.FieldRepetitions != null && _primaryKeyValueCDM.field.FieldRepetitions.Count > 0)
        {
            _primaryKeyValueCDM.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_primaryKeyValueCDM, fieldData);
        }

        return _primaryKeyValueCDM;
    } 
}

internal HL7V24Field _chargeCodeAlias;

public HL7V24Field ChargeCodeAlias
{
    get
    {
        if (_chargeCodeAlias != null)
        {
            return _chargeCodeAlias;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.2",
            Type = @"Field",
            Position = @"CDM.2",
            Name = @"Charge Code Alias",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an alternative charge code. For example, points to another charge description master entry in cases where one code supersedes or overrides another code. Repeating field allows for different codes used by different systems which should be handled as if they were the same; for example, the general ledger code may differ from the billing code. Or, in a multi-facility environment which does facility-specific pricing, there may be more than one of these master file entries for one charge description, each with a different facility.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CDM.2.1",
                            Type = @"Component",
                            Position = @"CDM.2.1",
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
                            Id = @"CDM.2.2",
                            Type = @"Component",
                            Position = @"CDM.2.2",
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
                            Id = @"CDM.2.3",
                            Type = @"Component",
                            Position = @"CDM.2.3",
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
                            Id = @"CDM.2.4",
                            Type = @"Component",
                            Position = @"CDM.2.4",
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
                            Id = @"CDM.2.5",
                            Type = @"Component",
                            Position = @"CDM.2.5",
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
                            Id = @"CDM.2.6",
                            Type = @"Component",
                            Position = @"CDM.2.6",
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

        _chargeCodeAlias = new HL7V24Field
        {
            field = message[@"CDM"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_chargeCodeAlias.field.FieldRepetitions != null && _chargeCodeAlias.field.FieldRepetitions.Count > 0)
        {
            _chargeCodeAlias.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_chargeCodeAlias, fieldData);
        }

        return _chargeCodeAlias;
    } 
}

internal HL7V24Field _chargeDescriptionShort;

public HL7V24Field ChargeDescriptionShort
{
    get
    {
        if (_chargeDescriptionShort != null)
        {
            return _chargeDescriptionShort;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.3",
            Type = @"Field",
            Position = @"CDM.3",
            Name = @"Charge Description Short",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the text abbreviations or code that is associated with this CDM entry.",
            Sample = @"",
            Fields = null
        }

        _chargeDescriptionShort = new HL7V24Field
        {
            field = message[@"CDM"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_chargeDescriptionShort.field.FieldRepetitions != null && _chargeDescriptionShort.field.FieldRepetitions.Count > 0)
        {
            _chargeDescriptionShort.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_chargeDescriptionShort, fieldData);
        }

        return _chargeDescriptionShort;
    } 
}

internal HL7V24Field _chargeDescriptionLong;

public HL7V24Field ChargeDescriptionLong
{
    get
    {
        if (_chargeDescriptionLong != null)
        {
            return _chargeDescriptionLong;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.4",
            Type = @"Field",
            Position = @"CDM.4",
            Name = @"Charge Description Long",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the full text description of this CDM entry.",
            Sample = @"",
            Fields = null
        }

        _chargeDescriptionLong = new HL7V24Field
        {
            field = message[@"CDM"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_chargeDescriptionLong.field.FieldRepetitions != null && _chargeDescriptionLong.field.FieldRepetitions.Count > 0)
        {
            _chargeDescriptionLong.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_chargeDescriptionLong, fieldData);
        }

        return _chargeDescriptionLong;
    } 
}

internal HL7V24Field _descriptionOverrideIndicator;

public HL7V24Field DescriptionOverrideIndicator
{
    get
    {
        if (_descriptionOverrideIndicator != null)
        {
            return _descriptionOverrideIndicator;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.5",
            Type = @"Field",
            Position = @"CDM.5",
            Name = @"Description Override Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0268",
            TableName = @"Override",
            Description = @"This field indicates whether this CDM entrys description can be overridden. Refer to User-defined Table 0268 - Override for suggested values.",
            Sample = @"",
            Fields = null
        }

        _descriptionOverrideIndicator = new HL7V24Field
        {
            field = message[@"CDM"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_descriptionOverrideIndicator.field.FieldRepetitions != null && _descriptionOverrideIndicator.field.FieldRepetitions.Count > 0)
        {
            _descriptionOverrideIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_descriptionOverrideIndicator, fieldData);
        }

        return _descriptionOverrideIndicator;
    } 
}

internal HL7V24Field _explodingCharges;

public HL7V24Field ExplodingCharges
{
    get
    {
        if (_explodingCharges != null)
        {
            return _explodingCharges;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.6",
            Type = @"Field",
            Position = @"CDM.6",
            Name = @"Exploding Charges",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the repeating occurrences for a list of other CDM entry charge codes identifying the other charges which should be generated from this CDM entry. If non-null, posting a charge to this CDM entry should result in posting the charges identified here. These are sometimes called ""linked items.""",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CDM.6.1",
                            Type = @"Component",
                            Position = @"CDM.6.1",
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
                            Id = @"CDM.6.2",
                            Type = @"Component",
                            Position = @"CDM.6.2",
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
                            Id = @"CDM.6.3",
                            Type = @"Component",
                            Position = @"CDM.6.3",
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
                            Id = @"CDM.6.4",
                            Type = @"Component",
                            Position = @"CDM.6.4",
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
                            Id = @"CDM.6.5",
                            Type = @"Component",
                            Position = @"CDM.6.5",
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
                            Id = @"CDM.6.6",
                            Type = @"Component",
                            Position = @"CDM.6.6",
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

        _explodingCharges = new HL7V24Field
        {
            field = message[@"CDM"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_explodingCharges.field.FieldRepetitions != null && _explodingCharges.field.FieldRepetitions.Count > 0)
        {
            _explodingCharges.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_explodingCharges, fieldData);
        }

        return _explodingCharges;
    } 
}

internal HL7V24Field _procedureCode;

public HL7V24Field ProcedureCode
{
    get
    {
        if (_procedureCode != null)
        {
            return _procedureCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.7",
            Type = @"Field",
            Position = @"CDM.7",
            Name = @"Procedure Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0088",
            TableName = @"Procedure code",
            Description = @"This field contains the procedure code for procedure, if any, associated with this charge description. Repeating field allows for different procedure coding systems such as CPT4, ASTM, ICD9. Coded entry made up of code plus coding schema. Refer to User defined Table 0088 - Procedure code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CDM.7.1",
                            Type = @"Component",
                            Position = @"CDM.7.1",
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
                            Id = @"CDM.7.2",
                            Type = @"Component",
                            Position = @"CDM.7.2",
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
                            Id = @"CDM.7.3",
                            Type = @"Component",
                            Position = @"CDM.7.3",
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
                            Id = @"CDM.7.4",
                            Type = @"Component",
                            Position = @"CDM.7.4",
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
                            Id = @"CDM.7.5",
                            Type = @"Component",
                            Position = @"CDM.7.5",
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
                            Id = @"CDM.7.6",
                            Type = @"Component",
                            Position = @"CDM.7.6",
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

        _procedureCode = new HL7V24Field
        {
            field = message[@"CDM"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCode.field.FieldRepetitions != null && _procedureCode.field.FieldRepetitions.Count > 0)
        {
            _procedureCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_procedureCode, fieldData);
        }

        return _procedureCode;
    } 
}

internal HL7V24Field _activeInactiveFlag;

public HL7V24Field ActiveInactiveFlag
{
    get
    {
        if (_activeInactiveFlag != null)
        {
            return _activeInactiveFlag;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.8",
            Type = @"Field",
            Position = @"CDM.8",
            Name = @"Active/Inactive Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0183",
            TableName = @"Active/inactive",
            Description = @"This field indicates whether this is a usable CDM entry. Refer toHL7 table 0183 - Active/inactive for valid values.",
            Sample = @"",
            Fields = null
        }

        _activeInactiveFlag = new HL7V24Field
        {
            field = message[@"CDM"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_activeInactiveFlag.field.FieldRepetitions != null && _activeInactiveFlag.field.FieldRepetitions.Count > 0)
        {
            _activeInactiveFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_activeInactiveFlag, fieldData);
        }

        return _activeInactiveFlag;
    } 
}

internal HL7V24Field _inventoryNumber;

public HL7V24Field InventoryNumber
{
    get
    {
        if (_inventoryNumber != null)
        {
            return _inventoryNumber;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.9",
            Type = @"Field",
            Position = @"CDM.9",
            Name = @"Inventory Number",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0463",
            TableName = @"Inventory number",
            Description = @"This optional field contains an identifying stock number, if any, which might be used, for example, as a cross reference for materials management. Refer to User-defined Table 0463 - Inventory number for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CDM.9.1",
                            Type = @"Component",
                            Position = @"CDM.9.1",
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
                            Id = @"CDM.9.2",
                            Type = @"Component",
                            Position = @"CDM.9.2",
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
                            Id = @"CDM.9.3",
                            Type = @"Component",
                            Position = @"CDM.9.3",
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
                            Id = @"CDM.9.4",
                            Type = @"Component",
                            Position = @"CDM.9.4",
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
                            Id = @"CDM.9.5",
                            Type = @"Component",
                            Position = @"CDM.9.5",
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
                            Id = @"CDM.9.6",
                            Type = @"Component",
                            Position = @"CDM.9.6",
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

        _inventoryNumber = new HL7V24Field
        {
            field = message[@"CDM"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryNumber.field.FieldRepetitions != null && _inventoryNumber.field.FieldRepetitions.Count > 0)
        {
            _inventoryNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_inventoryNumber, fieldData);
        }

        return _inventoryNumber;
    } 
}

internal HL7V24Field _resourceLoad;

public HL7V24Field ResourceLoad
{
    get
    {
        if (_resourceLoad != null)
        {
            return _resourceLoad;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.10",
            Type = @"Field",
            Position = @"CDM.10",
            Name = @"Resource Load",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the Relative Value Unit (RVU) minutes and ATS, a factor related to CPT4 coding and to pricing structure for physical billing.",
            Sample = @"",
            Fields = null
        }

        _resourceLoad = new HL7V24Field
        {
            field = message[@"CDM"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resourceLoad.field.FieldRepetitions != null && _resourceLoad.field.FieldRepetitions.Count > 0)
        {
            _resourceLoad.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_resourceLoad, fieldData);
        }

        return _resourceLoad;
    } 
}

internal HL7V24Field _contractNumber;

public HL7V24Field ContractNumber
{
    get
    {
        if (_contractNumber != null)
        {
            return _contractNumber;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.11",
            Type = @"Field",
            Position = @"CDM.11",
            Name = @"Contract Number",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CK",
            DataTypeName = @"Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains any contract number pertaining to this chargeable item. For example, supplier contract or service contract.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CDM.11.1",
                            Type = @"Component",
                            Position = @"CDM.11.1",
                            Name = @"Id Number",
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
                            Id = @"CDM.11.2",
                            Type = @"Component",
                            Position = @"CDM.11.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.11.3",
                            Type = @"Component",
                            Position = @"CDM.11.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 Table 0061 - Check digit scheme.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.11.4",
                            Type = @"Component",
                            Position = @"CDM.11.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined Table 0363 - Assigning authorit y is used as the HL7 identifier for the user-defined table of values for the first sub-component, namespace ID.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CDM.11.4.1",
                            Type = @"SubComponent",
                            Position = @"CDM.11.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.11.4.2",
                            Type = @"SubComponent",
                            Position = @"CDM.11.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.11.4.3",
                            Type = @"SubComponent",
                            Position = @"CDM.11.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _contractNumber = new HL7V24Field
        {
            field = message[@"CDM"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contractNumber.field.FieldRepetitions != null && _contractNumber.field.FieldRepetitions.Count > 0)
        {
            _contractNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_contractNumber, fieldData);
        }

        return _contractNumber;
    } 
}

internal HL7V24Field _contractOrganization;

public HL7V24Field ContractOrganization
{
    get
    {
        if (_contractOrganization != null)
        {
            return _contractOrganization;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.12",
            Type = @"Field",
            Position = @"CDM.12",
            Name = @"Contract Organization",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the organization with whom there is a contractual arrangement for providing the service or material used for this chargeable item.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CDM.12.1",
                            Type = @"Component",
                            Position = @"CDM.12.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.12.2",
                            Type = @"Component",
                            Position = @"CDM.12.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational name type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.12.3",
                            Type = @"Component",
                            Position = @"CDM.12.3",
                            Name = @"Id Number",
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
                            Id = @"CDM.12.4",
                            Type = @"Component",
                            Position = @"CDM.12.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.12.5",
                            Type = @"Component",
                            Position = @"CDM.12.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 Table 0061 - Check digit scheme.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.12.6",
                            Type = @"Component",
                            Position = @"CDM.12.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CDM.12.6.1",
                            Type = @"SubComponent",
                            Position = @"CDM.12.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.12.6.2",
                            Type = @"SubComponent",
                            Position = @"CDM.12.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.12.6.3",
                            Type = @"SubComponent",
                            Position = @"CDM.12.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.12.7",
                            Type = @"Component",
                            Position = @"CDM.12.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to HL7 Table 0203 - Identifier typefor suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.12.8",
                            Type = @"Component",
                            Position = @"CDM.12.8",
                            Name = @"Assigning Facility Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CDM.12.8.1",
                            Type = @"SubComponent",
                            Position = @"CDM.12.8.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.12.8.2",
                            Type = @"SubComponent",
                            Position = @"CDM.12.8.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.12.8.3",
                            Type = @"SubComponent",
                            Position = @"CDM.12.8.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CDM.12.9",
                            Type = @"Component",
                            Position = @"CDM.12.9",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _contractOrganization = new HL7V24Field
        {
            field = message[@"CDM"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contractOrganization.field.FieldRepetitions != null && _contractOrganization.field.FieldRepetitions.Count > 0)
        {
            _contractOrganization.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_contractOrganization, fieldData);
        }

        return _contractOrganization;
    } 
}

internal HL7V24Field _roomFeeIndicator;

public HL7V24Field RoomFeeIndicator
{
    get
    {
        if (_roomFeeIndicator != null)
        {
            return _roomFeeIndicator;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CDM.13",
            Type = @"Field",
            Position = @"CDM.13",
            Name = @"Room Fee Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains a room fee indicator. Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _roomFeeIndicator = new HL7V24Field
        {
            field = message[@"CDM"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_roomFeeIndicator.field.FieldRepetitions != null && _roomFeeIndicator.field.FieldRepetitions.Count > 0)
        {
            _roomFeeIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_roomFeeIndicator, fieldData);
        }

        return _roomFeeIndicator;
    } 
}
    }
}
