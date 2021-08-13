using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentFT1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"FT1"; } }

        public string SegmentId { get { return @"FT1"; } }
        
        public string LongName { get { return @"Financial Transaction"; } }
        
        public string Description { get { return @"The FT1 segment contains detail data necessary to post charges, payments, adjustments, etc. to patient accounting records."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V22SegmentFT1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdFinancialTransaction;

public HL7V22Field SetIdFinancialTransaction
{
    get
    {
        if (_setIdFinancialTransaction != null)
        {
            return _setIdFinancialTransaction;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.1",
            Type = @"Field",
            Position = @"FT1.1",
            Name = @"Set Id - Financial Transaction",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction",
            Sample = @"",
            Fields = null
        }

        _setIdFinancialTransaction = new HL7V22Field
        {
            field = message[@"FT1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdFinancialTransaction.field.FieldRepetitions != null && _setIdFinancialTransaction.field.FieldRepetitions.Count > 0)
        {
            _setIdFinancialTransaction.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdFinancialTransaction, fieldData);
        }

        return _setIdFinancialTransaction;
    } 
}

internal HL7V22Field _transactionId;

public HL7V22Field TransactionId
{
    get
    {
        if (_transactionId != null)
        {
            return _transactionId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.2",
            Type = @"Field",
            Position = @"FT1.2",
            Name = @"Transaction Id",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"number assigned by the sending system for control purposes.  The number can be returned by the receiving to identify errors",
            Sample = @"",
            Fields = null
        }

        _transactionId = new HL7V22Field
        {
            field = message[@"FT1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionId.field.FieldRepetitions != null && _transactionId.field.FieldRepetitions.Count > 0)
        {
            _transactionId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transactionId, fieldData);
        }

        return _transactionId;
    } 
}

internal HL7V22Field _transactionBatchId;

public HL7V22Field TransactionBatchId
{
    get
    {
        if (_transactionBatchId != null)
        {
            return _transactionBatchId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.3",
            Type = @"Field",
            Position = @"FT1.3",
            Name = @"Transaction Batch Id",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"uniquely identifies the batch in which this transaction belongs",
            Sample = @"",
            Fields = null
        }

        _transactionBatchId = new HL7V22Field
        {
            field = message[@"FT1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionBatchId.field.FieldRepetitions != null && _transactionBatchId.field.FieldRepetitions.Count > 0)
        {
            _transactionBatchId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transactionBatchId, fieldData);
        }

        return _transactionBatchId;
    } 
}

internal HL7V22Field _transactionDate;

public HL7V22Field TransactionDate
{
    get
    {
        if (_transactionDate != null)
        {
            return _transactionDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.4",
            Type = @"Field",
            Position = @"FT1.4",
            Name = @"Transaction Date",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"uniquely identifies the batch in which this transaction belongs",
            Sample = @"",
            Fields = null
        }

        _transactionDate = new HL7V22Field
        {
            field = message[@"FT1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionDate.field.FieldRepetitions != null && _transactionDate.field.FieldRepetitions.Count > 0)
        {
            _transactionDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transactionDate, fieldData);
        }

        return _transactionDate;
    } 
}

internal HL7V22Field _transactionPostingDate;

public HL7V22Field TransactionPostingDate
{
    get
    {
        if (_transactionPostingDate != null)
        {
            return _transactionPostingDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.5",
            Type = @"Field",
            Position = @"FT1.5",
            Name = @"Transaction Posting Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date the transaction was sent to the financial system for posting",
            Sample = @"",
            Fields = null
        }

        _transactionPostingDate = new HL7V22Field
        {
            field = message[@"FT1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionPostingDate.field.FieldRepetitions != null && _transactionPostingDate.field.FieldRepetitions.Count > 0)
        {
            _transactionPostingDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transactionPostingDate, fieldData);
        }

        return _transactionPostingDate;
    } 
}

internal HL7V22Field _transactionType;

public HL7V22Field TransactionType
{
    get
    {
        if (_transactionType != null)
        {
            return _transactionType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.6",
            Type = @"Field",
            Position = @"FT1.6",
            Name = @"Transaction Type",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0017",
            TableName = @"TRANSACTION TYPE",
            Description = @"code that identifies the type of transaction. e.g., charge, credit, payment, etc. Refer to user-defined table 0017 - transaction type",
            Sample = @"",
            Fields = null
        }

        _transactionType = new HL7V22Field
        {
            field = message[@"FT1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionType.field.FieldRepetitions != null && _transactionType.field.FieldRepetitions.Count > 0)
        {
            _transactionType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transactionType, fieldData);
        }

        return _transactionType;
    } 
}

internal HL7V22Field _transactionCode;

public HL7V22Field TransactionCode
{
    get
    {
        if (_transactionCode != null)
        {
            return _transactionCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.7",
            Type = @"Field",
            Position = @"FT1.7",
            Name = @"Transaction Code",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0132",
            TableName = @"TRANSACTION CODE",
            Description = @"code assigned by the institution for the purpose of uniquely identifying the transaction. For example, this field would be used to uniquely identify a procedure, item, or test for charging purposes.  Refer to user-defined table 0132 - transaction code.  See Chapter 7 for discussion on the univeral service ID",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.7.1",
                            Type = @"Component",
                            Position = @"FT1.7.1",
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
                            Id = @"FT1.7.2",
                            Type = @"Component",
                            Position = @"FT1.7.2",
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
                            Id = @"FT1.7.3",
                            Type = @"Component",
                            Position = @"FT1.7.3",
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
                            Id = @"FT1.7.4",
                            Type = @"Component",
                            Position = @"FT1.7.4",
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
                            Id = @"FT1.7.5",
                            Type = @"Component",
                            Position = @"FT1.7.5",
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
                            Id = @"FT1.7.6",
                            Type = @"Component",
                            Position = @"FT1.7.6",
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

        _transactionCode = new HL7V22Field
        {
            field = message[@"FT1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionCode.field.FieldRepetitions != null && _transactionCode.field.FieldRepetitions.Count > 0)
        {
            _transactionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transactionCode, fieldData);
        }

        return _transactionCode;
    } 
}

internal HL7V22Field _transactionDescription;

public HL7V22Field TransactionDescription
{
    get
    {
        if (_transactionDescription != null)
        {
            return _transactionDescription;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.8",
            Type = @"Field",
            Position = @"FT1.8",
            Name = @"Transaction Description",
            Length = 40,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"description of the transaction associated with the code entered in FT1-7-transaction code.  This field is no longer needed as it is now part of FT1-7-transaction code.  It has been kept for backwards compatibility",
            Sample = @"",
            Fields = null
        }

        _transactionDescription = new HL7V22Field
        {
            field = message[@"FT1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionDescription.field.FieldRepetitions != null && _transactionDescription.field.FieldRepetitions.Count > 0)
        {
            _transactionDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transactionDescription, fieldData);
        }

        return _transactionDescription;
    } 
}

internal HL7V22Field _transactionDescriptionAlternate;

public HL7V22Field TransactionDescriptionAlternate
{
    get
    {
        if (_transactionDescriptionAlternate != null)
        {
            return _transactionDescriptionAlternate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.9",
            Type = @"Field",
            Position = @"FT1.9",
            Name = @"Transaction Description - Alternate",
            Length = 40,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"alternate financial transaction description to be used on a site specific basis.  This field is no longer needed as it is now part of FT1-7-transaction code.  It has been kept for backwards compatibility",
            Sample = @"",
            Fields = null
        }

        _transactionDescriptionAlternate = new HL7V22Field
        {
            field = message[@"FT1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionDescriptionAlternate.field.FieldRepetitions != null && _transactionDescriptionAlternate.field.FieldRepetitions.Count > 0)
        {
            _transactionDescriptionAlternate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transactionDescriptionAlternate, fieldData);
        }

        return _transactionDescriptionAlternate;
    } 
}

internal HL7V22Field _transactionQuantity;

public HL7V22Field TransactionQuantity
{
    get
    {
        if (_transactionQuantity != null)
        {
            return _transactionQuantity;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.10",
            Type = @"Field",
            Position = @"FT1.10",
            Name = @"Transaction Quantity",
            Length = 4,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"quantity of items associated with this transaction.  This field is no longer needed as it is now part of FT1-7-transaction code.  It has been kept for backwards compatibility.",
            Sample = @"",
            Fields = null
        }

        _transactionQuantity = new HL7V22Field
        {
            field = message[@"FT1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionQuantity.field.FieldRepetitions != null && _transactionQuantity.field.FieldRepetitions.Count > 0)
        {
            _transactionQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transactionQuantity, fieldData);
        }

        return _transactionQuantity;
    } 
}

internal HL7V22Field _transactionAmountExtended;

public HL7V22Field TransactionAmountExtended
{
    get
    {
        if (_transactionAmountExtended != null)
        {
            return _transactionAmountExtended;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.11",
            Type = @"Field",
            Position = @"FT1.11",
            Name = @"Transaction Amount - Extended",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount of transaction.  This field may be blank if the transaction is automatically priced.  Total price for multiple items",
            Sample = @"",
            Fields = null
        }

        _transactionAmountExtended = new HL7V22Field
        {
            field = message[@"FT1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionAmountExtended.field.FieldRepetitions != null && _transactionAmountExtended.field.FieldRepetitions.Count > 0)
        {
            _transactionAmountExtended.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transactionAmountExtended, fieldData);
        }

        return _transactionAmountExtended;
    } 
}

internal HL7V22Field _transactionAmountUnit;

public HL7V22Field TransactionAmountUnit
{
    get
    {
        if (_transactionAmountUnit != null)
        {
            return _transactionAmountUnit;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.12",
            Type = @"Field",
            Position = @"FT1.12",
            Name = @"Transaction Amount - Unit",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"unit price of transaction.  Price of a single item",
            Sample = @"",
            Fields = null
        }

        _transactionAmountUnit = new HL7V22Field
        {
            field = message[@"FT1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionAmountUnit.field.FieldRepetitions != null && _transactionAmountUnit.field.FieldRepetitions.Count > 0)
        {
            _transactionAmountUnit.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transactionAmountUnit, fieldData);
        }

        return _transactionAmountUnit;
    } 
}

internal HL7V22Field _departmentCode;

public HL7V22Field DepartmentCode
{
    get
    {
        if (_departmentCode != null)
        {
            return _departmentCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.13",
            Type = @"Field",
            Position = @"FT1.13",
            Name = @"Department Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0049",
            TableName = @"DEPARTMENT CODE",
            Description = @"department code which controls the transaction code described above.  Refer to user-defined table 0049 - department code",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.13.1",
                            Type = @"Component",
                            Position = @"FT1.13.1",
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
                            Id = @"FT1.13.2",
                            Type = @"Component",
                            Position = @"FT1.13.2",
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
                            Id = @"FT1.13.3",
                            Type = @"Component",
                            Position = @"FT1.13.3",
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
                            Id = @"FT1.13.4",
                            Type = @"Component",
                            Position = @"FT1.13.4",
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
                            Id = @"FT1.13.5",
                            Type = @"Component",
                            Position = @"FT1.13.5",
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
                            Id = @"FT1.13.6",
                            Type = @"Component",
                            Position = @"FT1.13.6",
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

        _departmentCode = new HL7V22Field
        {
            field = message[@"FT1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_departmentCode.field.FieldRepetitions != null && _departmentCode.field.FieldRepetitions.Count > 0)
        {
            _departmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_departmentCode, fieldData);
        }

        return _departmentCode;
    } 
}

internal HL7V22Field _insurancePlanId;

public HL7V22Field InsurancePlanId
{
    get
    {
        if (_insurancePlanId != null)
        {
            return _insurancePlanId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.14",
            Type = @"Field",
            Position = @"FT1.14",
            Name = @"Insurance Plan Id",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0072",
            TableName = @"INS. PLAN ID",
            Description = @"ID of the primary insurance plan this transaction should be associated with.  Refer to user-defined table 0072 - insurance plan ID",
            Sample = @"",
            Fields = null
        }

        _insurancePlanId = new HL7V22Field
        {
            field = message[@"FT1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insurancePlanId.field.FieldRepetitions != null && _insurancePlanId.field.FieldRepetitions.Count > 0)
        {
            _insurancePlanId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insurancePlanId, fieldData);
        }

        return _insurancePlanId;
    } 
}

internal HL7V22Field _insuranceAmount;

public HL7V22Field InsuranceAmount
{
    get
    {
        if (_insuranceAmount != null)
        {
            return _insuranceAmount;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.15",
            Type = @"Field",
            Position = @"FT1.15",
            Name = @"Insurance Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount to be posted to the insurance plan referenced above",
            Sample = @"",
            Fields = null
        }

        _insuranceAmount = new HL7V22Field
        {
            field = message[@"FT1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceAmount.field.FieldRepetitions != null && _insuranceAmount.field.FieldRepetitions.Count > 0)
        {
            _insuranceAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuranceAmount, fieldData);
        }

        return _insuranceAmount;
    } 
}

internal HL7V22Field _assignedPatientLocation;

public HL7V22Field AssignedPatientLocation
{
    get
    {
        if (_assignedPatientLocation != null)
        {
            return _assignedPatientLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.16",
            Type = @"Field",
            Position = @"FT1.16",
            Name = @"Assigned Patient Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_INTERNAL_LOCATION",
            DataTypeName = @"Cm For Location Information In Hospital",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = @"current patient location.  Refer to user-defined table 0079-location",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.16.1",
                            Type = @"Component",
                            Position = @"FT1.16.1",
                            Name = @"Nurse Unit (station)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.2",
                            Type = @"Component",
                            Position = @"FT1.16.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.3",
                            Type = @"Component",
                            Position = @"FT1.16.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.4",
                            Type = @"Component",
                            Position = @"FT1.16.4",
                            Name = @"Facility Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.5",
                            Type = @"Component",
                            Position = @"FT1.16.5",
                            Name = @"Bed Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _assignedPatientLocation = new HL7V22Field
        {
            field = message[@"FT1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_assignedPatientLocation.field.FieldRepetitions != null && _assignedPatientLocation.field.FieldRepetitions.Count > 0)
        {
            _assignedPatientLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_assignedPatientLocation, fieldData);
        }

        return _assignedPatientLocation;
    } 
}

internal HL7V22Field _feeSchedule;

public HL7V22Field FeeSchedule
{
    get
    {
        if (_feeSchedule != null)
        {
            return _feeSchedule;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.17",
            Type = @"Field",
            Position = @"FT1.17",
            Name = @"Fee Schedule",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0024",
            TableName = @"FEE SCHEDULE",
            Description = @"code used to select the appropriate fee schedule to be used for this transaction posting. Refer to userdefined table 0024 - fee schedule",
            Sample = @"",
            Fields = null
        }

        _feeSchedule = new HL7V22Field
        {
            field = message[@"FT1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_feeSchedule.field.FieldRepetitions != null && _feeSchedule.field.FieldRepetitions.Count > 0)
        {
            _feeSchedule.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_feeSchedule, fieldData);
        }

        return _feeSchedule;
    } 
}

internal HL7V22Field _patientType;

public HL7V22Field PatientType
{
    get
    {
        if (_patientType != null)
        {
            return _patientType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.18",
            Type = @"Field",
            Position = @"FT1.18",
            Name = @"Patient Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0018",
            TableName = @"PATIENT TYPE",
            Description = @"type code assigned to the patient for this visit.  Refer to user-defined table 0018 - patient type",
            Sample = @"",
            Fields = null
        }

        _patientType = new HL7V22Field
        {
            field = message[@"FT1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientType.field.FieldRepetitions != null && _patientType.field.FieldRepetitions.Count > 0)
        {
            _patientType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_patientType, fieldData);
        }

        return _patientType;
    } 
}

internal HL7V22Field _diagnosisCode;

public HL7V22Field DiagnosisCode
{
    get
    {
        if (_diagnosisCode != null)
        {
            return _diagnosisCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.19",
            Type = @"Field",
            Position = @"FT1.19",
            Name = @"Diagnosis Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0051",
            TableName = @"DIAGNOSIS CODE",
            Description = @" ICD9-CM is assumed for all diagnosis codes.  This diagnosis code is the most current diagnosis code assigned to the patient.  ICD10 can also be used.  Refer to user-defined table 0051 - diagnosis code",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.19.1",
                            Type = @"Component",
                            Position = @"FT1.19.1",
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
                            Id = @"FT1.19.2",
                            Type = @"Component",
                            Position = @"FT1.19.2",
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
                            Id = @"FT1.19.3",
                            Type = @"Component",
                            Position = @"FT1.19.3",
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
                            Id = @"FT1.19.4",
                            Type = @"Component",
                            Position = @"FT1.19.4",
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
                            Id = @"FT1.19.5",
                            Type = @"Component",
                            Position = @"FT1.19.5",
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
                            Id = @"FT1.19.6",
                            Type = @"Component",
                            Position = @"FT1.19.6",
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

        _diagnosisCode = new HL7V22Field
        {
            field = message[@"FT1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisCode.field.FieldRepetitions != null && _diagnosisCode.field.FieldRepetitions.Count > 0)
        {
            _diagnosisCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_diagnosisCode, fieldData);
        }

        return _diagnosisCode;
    } 
}

internal HL7V22Field _performedByCode;

public HL7V22Field PerformedByCode
{
    get
    {
        if (_performedByCode != null)
        {
            return _performedByCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.20",
            Type = @"Field",
            Position = @"FT1.20",
            Name = @"Performed By Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = @"0084",
            TableName = @"PERFORMED BY CODE",
            Description = @"composite number/name of the person/group which performed the test/procedure/transaction, etc. Refer to user defined table 0084 - performed by table",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.20.1",
                            Type = @"Component",
                            Position = @"FT1.20.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.2",
                            Type = @"Component",
                            Position = @"FT1.20.2",
                            Name = @"Familiy Name",
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
                            Id = @"FT1.20.3",
                            Type = @"Component",
                            Position = @"FT1.20.3",
                            Name = @"Given Name",
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
                            Id = @"FT1.20.4",
                            Type = @"Component",
                            Position = @"FT1.20.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"FT1.20.5",
                            Type = @"Component",
                            Position = @"FT1.20.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"FT1.20.6",
                            Type = @"Component",
                            Position = @"FT1.20.6",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"FT1.20.7",
                            Type = @"Component",
                            Position = @"FT1.20.7",
                            Name = @"Degree (e.g. Md)",
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
                            Id = @"FT1.20.8",
                            Type = @"Component",
                            Position = @"FT1.20.8",
                            Name = @"Source Table Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _performedByCode = new HL7V22Field
        {
            field = message[@"FT1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_performedByCode.field.FieldRepetitions != null && _performedByCode.field.FieldRepetitions.Count > 0)
        {
            _performedByCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_performedByCode, fieldData);
        }

        return _performedByCode;
    } 
}

internal HL7V22Field _orderedByCode;

public HL7V22Field OrderedByCode
{
    get
    {
        if (_orderedByCode != null)
        {
            return _orderedByCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.21",
            Type = @"Field",
            Position = @"FT1.21",
            Name = @"Ordered By Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"composite number/name of person/group which ordered the test/procedure/transaction, etc",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.21.1",
                            Type = @"Component",
                            Position = @"FT1.21.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.2",
                            Type = @"Component",
                            Position = @"FT1.21.2",
                            Name = @"Familiy Name",
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
                            Id = @"FT1.21.3",
                            Type = @"Component",
                            Position = @"FT1.21.3",
                            Name = @"Given Name",
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
                            Id = @"FT1.21.4",
                            Type = @"Component",
                            Position = @"FT1.21.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"FT1.21.5",
                            Type = @"Component",
                            Position = @"FT1.21.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"FT1.21.6",
                            Type = @"Component",
                            Position = @"FT1.21.6",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"FT1.21.7",
                            Type = @"Component",
                            Position = @"FT1.21.7",
                            Name = @"Degree (e.g. Md)",
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
                            Id = @"FT1.21.8",
                            Type = @"Component",
                            Position = @"FT1.21.8",
                            Name = @"Source Table Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _orderedByCode = new HL7V22Field
        {
            field = message[@"FT1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderedByCode.field.FieldRepetitions != null && _orderedByCode.field.FieldRepetitions.Count > 0)
        {
            _orderedByCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_orderedByCode, fieldData);
        }

        return _orderedByCode;
    } 
}

internal HL7V22Field _unitCost;

public HL7V22Field UnitCost
{
    get
    {
        if (_unitCost != null)
        {
            return _unitCost;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.22",
            Type = @"Field",
            Position = @"FT1.22",
            Name = @"Unit Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"unit price of transaction.  The cost of a single item",
            Sample = @"",
            Fields = null
        }

        _unitCost = new HL7V22Field
        {
            field = message[@"FT1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_unitCost.field.FieldRepetitions != null && _unitCost.field.FieldRepetitions.Count > 0)
        {
            _unitCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_unitCost, fieldData);
        }

        return _unitCost;
    } 
}

internal HL7V22Field _fillerOrderNumber;

public HL7V22Field FillerOrderNumber
{
    get
    {
        if (_fillerOrderNumber != null)
        {
            return _fillerOrderNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"FT1.23",
            Type = @"Field",
            Position = @"FT1.23",
            Name = @"Filler Order Number",
            Length = 75,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CM_FILLER",
            DataTypeName = @"Number Of Processing Power Point",
            TableId = null,
            TableName = null,
            Description = @"used when the billing system is requesting observational reporting justification for a charge.  This is the number used by a filler to uniquely identify a result. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.23.1",
                            Type = @"Component",
                            Position = @"FT1.23.1",
                            Name = @"Unique Filler Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Its first component is a string of up to 15 characters that identifies an order detail segment (e.g., OBR). It is assigned by the order filler (receiving) application. This string must uniquely identify the order (as specified in the order detail segment) from other orders in a particular filling application (e.g., clinical laboratory).  This uniqueness must persist over time. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.23.2",
                            Type = @"Component",
                            Position = @"FT1.23.2",
                            Name = @"Filler Application Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the filler application ID.  The filler application ID is a string of up to six characters that uniquely defines the application from other applications on the network.  The second component of the filler order number always identifies the actual filler of an order. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fillerOrderNumber = new HL7V22Field
        {
            field = message[@"FT1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerOrderNumber.field.FieldRepetitions != null && _fillerOrderNumber.field.FieldRepetitions.Count > 0)
        {
            _fillerOrderNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fillerOrderNumber, fieldData);
        }

        return _fillerOrderNumber;
    } 
}
    }
}
