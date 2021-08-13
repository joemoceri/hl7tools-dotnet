using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentFT1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"FT1"; } }

        public string SegmentId { get { return @"FT1"; } }
        
        public string LongName { get { return @"Financial transaction"; } }
        
        public string Description { get { return @"The FT1 segment contains the detail data necessary to post charges, payments, adjustments, etc. to patient accounting records."; } }
        
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

        public HL7V23SegmentFT1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDFinancialTransaction;

public HL7V23Field SetIDFinancialTransaction
{
    get
    {
        if (_setIDFinancialTransaction != null)
        {
            return _setIDFinancialTransaction;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.1",
            Type = @"Field",
            Position = @"FT1.1",
            Name = @"Set ID - Financial Transaction",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc.",
            Sample = @"",
            Fields = null
        }

        _setIDFinancialTransaction = new HL7V23Field
        {
            field = message[@"FT1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDFinancialTransaction.field.FieldRepetitions != null && _setIDFinancialTransaction.field.FieldRepetitions.Count > 0)
        {
            _setIDFinancialTransaction.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDFinancialTransaction, fieldData);
        }

        return _setIDFinancialTransaction;
    } 
}

internal HL7V23Field _transactionID;

public HL7V23Field TransactionID
{
    get
    {
        if (_transactionID != null)
        {
            return _transactionID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.2",
            Type = @"Field",
            Position = @"FT1.2",
            Name = @"Transaction ID",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number assigned by the sending system for control purposes.  The number can be returned by the receiving system to identify errors. ",
            Sample = @"",
            Fields = null
        }

        _transactionID = new HL7V23Field
        {
            field = message[@"FT1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionID.field.FieldRepetitions != null && _transactionID.field.FieldRepetitions.Count > 0)
        {
            _transactionID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transactionID, fieldData);
        }

        return _transactionID;
    } 
}

internal HL7V23Field _transactionBatchID;

public HL7V23Field TransactionBatchID
{
    get
    {
        if (_transactionBatchID != null)
        {
            return _transactionBatchID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.3",
            Type = @"Field",
            Position = @"FT1.3",
            Name = @"Transaction Batch ID",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the batch in which this transaction belongs.",
            Sample = @"",
            Fields = null
        }

        _transactionBatchID = new HL7V23Field
        {
            field = message[@"FT1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionBatchID.field.FieldRepetitions != null && _transactionBatchID.field.FieldRepetitions.Count > 0)
        {
            _transactionBatchID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transactionBatchID, fieldData);
        }

        return _transactionBatchID;
    } 
}

internal HL7V23Field _transactionDate;

public HL7V23Field TransactionDate
{
    get
    {
        if (_transactionDate != null)
        {
            return _transactionDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.4",
            Type = @"Field",
            Position = @"FT1.4",
            Name = @"Transaction Date",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date of the transaction.  For example, this field would be used to identify the date a procedure, item, or test was conducted or used.  It may be defaulted to today’s date.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.4.1",
                            Type = @"Component",
                            Position = @"FT1.4.1",
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
                        }
        }

        _transactionDate = new HL7V23Field
        {
            field = message[@"FT1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionDate.field.FieldRepetitions != null && _transactionDate.field.FieldRepetitions.Count > 0)
        {
            _transactionDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transactionDate, fieldData);
        }

        return _transactionDate;
    } 
}

internal HL7V23Field _transactionPostingDate;

public HL7V23Field TransactionPostingDate
{
    get
    {
        if (_transactionPostingDate != null)
        {
            return _transactionPostingDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.5",
            Type = @"Field",
            Position = @"FT1.5",
            Name = @"Transaction Posting Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date of the transaction that was sent to the financial system for posting.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.5.1",
                            Type = @"Component",
                            Position = @"FT1.5.1",
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
                        }
        }

        _transactionPostingDate = new HL7V23Field
        {
            field = message[@"FT1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionPostingDate.field.FieldRepetitions != null && _transactionPostingDate.field.FieldRepetitions.Count > 0)
        {
            _transactionPostingDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transactionPostingDate, fieldData);
        }

        return _transactionPostingDate;
    } 
}

internal HL7V23Field _transactionType;

public HL7V23Field TransactionType
{
    get
    {
        if (_transactionType != null)
        {
            return _transactionType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.6",
            Type = @"Field",
            Position = @"FT1.6",
            Name = @"Transaction Type",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0017",
            TableName = @"Transaction type",
            Description = @"This field contains the code that identifies the type of transaction.",
            Sample = @"",
            Fields = null
        }

        _transactionType = new HL7V23Field
        {
            field = message[@"FT1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionType.field.FieldRepetitions != null && _transactionType.field.FieldRepetitions.Count > 0)
        {
            _transactionType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transactionType, fieldData);
        }

        return _transactionType;
    } 
}

internal HL7V23Field _transactionCode;

public HL7V23Field TransactionCode
{
    get
    {
        if (_transactionCode != null)
        {
            return _transactionCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.7",
            Type = @"Field",
            Position = @"FT1.7",
            Name = @"Transaction Code",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0132",
            TableName = @"Transaction code",
            Description = @"This field contains the code assigned by the institution for the purpose of uniquely identifying the transaction.  For example, this field would be used to uniquely identify a procedure, supply item, or test for charging purposes.  Refer to user-defined table 0132 - Transaction code for suggested values.  See Chapter 7 for a discussion of the universal service ID. ",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _transactionCode = new HL7V23Field
        {
            field = message[@"FT1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionCode.field.FieldRepetitions != null && _transactionCode.field.FieldRepetitions.Count > 0)
        {
            _transactionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transactionCode, fieldData);
        }

        return _transactionCode;
    } 
}

internal HL7V23Field _transactionDescription;

public HL7V23Field TransactionDescription
{
    get
    {
        if (_transactionDescription != null)
        {
            return _transactionDescription;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field has been retained for backward compatibility only.   As of Version 2.3, FT1-7transaction code contains a component for the transaction description.  When used for backward compatibility, FT1-8-transaction description contains a description of the transaction associated with the code entered in FT1-7-transaction code ",
            Sample = @"",
            Fields = null
        }

        _transactionDescription = new HL7V23Field
        {
            field = message[@"FT1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionDescription.field.FieldRepetitions != null && _transactionDescription.field.FieldRepetitions.Count > 0)
        {
            _transactionDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transactionDescription, fieldData);
        }

        return _transactionDescription;
    } 
}

internal HL7V23Field _transactionDescriptionalternate;

public HL7V23Field TransactionDescriptionalternate
{
    get
    {
        if (_transactionDescriptionalternate != null)
        {
            return _transactionDescriptionalternate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.9",
            Type = @"Field",
            Position = @"FT1.9",
            Name = @"Transaction Description - alternate",
            Length = 40,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  As of Version 2.3, FT1-7transaction code contains a component for the alternate transaction description.  When used for backward compatibility, FT1-9-transaction description-alt contains an alternate description of the transaction associated with the code entered in FT1-7-transaction code.",
            Sample = @"",
            Fields = null
        }

        _transactionDescriptionalternate = new HL7V23Field
        {
            field = message[@"FT1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionDescriptionalternate.field.FieldRepetitions != null && _transactionDescriptionalternate.field.FieldRepetitions.Count > 0)
        {
            _transactionDescriptionalternate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transactionDescriptionalternate, fieldData);
        }

        return _transactionDescriptionalternate;
    } 
}

internal HL7V23Field _transactionQuantity;

public HL7V23Field TransactionQuantity
{
    get
    {
        if (_transactionQuantity != null)
        {
            return _transactionQuantity;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.10",
            Type = @"Field",
            Position = @"FT1.10",
            Name = @"Transaction Quantity",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity of items associated with this transaction",
            Sample = @"",
            Fields = null
        }

        _transactionQuantity = new HL7V23Field
        {
            field = message[@"FT1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionQuantity.field.FieldRepetitions != null && _transactionQuantity.field.FieldRepetitions.Count > 0)
        {
            _transactionQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transactionQuantity, fieldData);
        }

        return _transactionQuantity;
    } 
}

internal HL7V23Field _transactionAmountExtended;

public HL7V23Field TransactionAmountExtended
{
    get
    {
        if (_transactionAmountExtended != null)
        {
            return _transactionAmountExtended;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.11",
            Type = @"Field",
            Position = @"FT1.11",
            Name = @"Transaction Amount - Extended",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount of a transaction.  It may be left blank if the transaction is automatically priced.  Total price for multiple items",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.11.1",
                            Type = @"Component",
                            Position = @"FT1.11.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.11.1.1",
                            Type = @"SubComponent",
                            Position = @"FT1.11.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11.1.2",
                            Type = @"SubComponent",
                            Position = @"FT1.11.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed.  The values for the denomination component are those specified in ISO-4217.  If the denomination is not specified, MSH-17country code is used to determine the default. 

Example: 
|99.50^USD| 
where USD is the ISO 4217 code for the U.S. American dollar. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11.2",
                            Type = @"Component",
                            Position = @"FT1.11.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID.  Refer to HL7 table 0205 - Price type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11.3",
                            Type = @"Component",
                            Position = @"FT1.11.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is an NM data type; together they specify the “range.”  The range can be defined as either time or quantity.  For example, the range can indicate that the first 10 minutes of the procedure has one price.  Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11.4",
                            Type = @"Component",
                            Position = @"FT1.11.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See From value",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11.5",
                            Type = @"Component",
                            Position = @"FT1.11.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (e.g., count); it is required if <from value> and  <to value> are present",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.11.5.1",
                            Type = @"SubComponent",
                            Position = @"FT1.11.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11.5.2",
                            Type = @"SubComponent",
                            Position = @"FT1.11.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11.5.3",
                            Type = @"SubComponent",
                            Position = @"FT1.11.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11.5.4",
                            Type = @"SubComponent",
                            Position = @"FT1.11.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11.5.5",
                            Type = @"SubComponent",
                            Position = @"FT1.11.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11.5.6",
                            Type = @"SubComponent",
                            Position = @"FT1.11.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11.6",
                            Type = @"Component",
                            Position = @"FT1.11.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _transactionAmountExtended = new HL7V23Field
        {
            field = message[@"FT1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionAmountExtended.field.FieldRepetitions != null && _transactionAmountExtended.field.FieldRepetitions.Count > 0)
        {
            _transactionAmountExtended.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transactionAmountExtended, fieldData);
        }

        return _transactionAmountExtended;
    } 
}

internal HL7V23Field _transactionAmountUnit;

public HL7V23Field TransactionAmountUnit
{
    get
    {
        if (_transactionAmountUnit != null)
        {
            return _transactionAmountUnit;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.12",
            Type = @"Field",
            Position = @"FT1.12",
            Name = @"Transaction Amount - Unit",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unit price of a transaction.  Price of a single item",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.12.1",
                            Type = @"Component",
                            Position = @"FT1.12.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.12.1.1",
                            Type = @"SubComponent",
                            Position = @"FT1.12.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12.1.2",
                            Type = @"SubComponent",
                            Position = @"FT1.12.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed.  The values for the denomination component are those specified in ISO-4217.  If the denomination is not specified, MSH-17country code is used to determine the default. 

Example: 
|99.50^USD| 
where USD is the ISO 4217 code for the U.S. American dollar. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12.2",
                            Type = @"Component",
                            Position = @"FT1.12.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID.  Refer to HL7 table 0205 - Price type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12.3",
                            Type = @"Component",
                            Position = @"FT1.12.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is an NM data type; together they specify the “range.”  The range can be defined as either time or quantity.  For example, the range can indicate that the first 10 minutes of the procedure has one price.  Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12.4",
                            Type = @"Component",
                            Position = @"FT1.12.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See From value",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12.5",
                            Type = @"Component",
                            Position = @"FT1.12.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (e.g., count); it is required if <from value> and  <to value> are present",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.12.5.1",
                            Type = @"SubComponent",
                            Position = @"FT1.12.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12.5.2",
                            Type = @"SubComponent",
                            Position = @"FT1.12.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12.5.3",
                            Type = @"SubComponent",
                            Position = @"FT1.12.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12.5.4",
                            Type = @"SubComponent",
                            Position = @"FT1.12.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12.5.5",
                            Type = @"SubComponent",
                            Position = @"FT1.12.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12.5.6",
                            Type = @"SubComponent",
                            Position = @"FT1.12.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12.6",
                            Type = @"Component",
                            Position = @"FT1.12.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _transactionAmountUnit = new HL7V23Field
        {
            field = message[@"FT1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionAmountUnit.field.FieldRepetitions != null && _transactionAmountUnit.field.FieldRepetitions.Count > 0)
        {
            _transactionAmountUnit.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transactionAmountUnit, fieldData);
        }

        return _transactionAmountUnit;
    } 
}

internal HL7V23Field _departmentCode;

public HL7V23Field DepartmentCode
{
    get
    {
        if (_departmentCode != null)
        {
            return _departmentCode;
        }

        var fieldData = new HL7V23FieldData
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
            TableName = @"Department code",
            Description = @"This field contains the department code that controls the transaction code described above.  Refer to user-defined table 0049 - Department code for suggested values",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _departmentCode = new HL7V23Field
        {
            field = message[@"FT1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_departmentCode.field.FieldRepetitions != null && _departmentCode.field.FieldRepetitions.Count > 0)
        {
            _departmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_departmentCode, fieldData);
        }

        return _departmentCode;
    } 
}

internal HL7V23Field _insurancePlanID;

public HL7V23Field InsurancePlanID
{
    get
    {
        if (_insurancePlanID != null)
        {
            return _insurancePlanID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.14",
            Type = @"Field",
            Position = @"FT1.14",
            Name = @"Insurance Plan ID",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0072",
            TableName = @"Insurance plan ID",
            Description = @"This field contains the identifier of the primary insurance plan with which this transaction should be associated.  Refer to user-defined table 0072 - Insurance plan ID for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.14.1",
                            Type = @"Component",
                            Position = @"FT1.14.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.14.2",
                            Type = @"Component",
                            Position = @"FT1.14.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.14.3",
                            Type = @"Component",
                            Position = @"FT1.14.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.14.4",
                            Type = @"Component",
                            Position = @"FT1.14.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.14.5",
                            Type = @"Component",
                            Position = @"FT1.14.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.14.6",
                            Type = @"Component",
                            Position = @"FT1.14.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _insurancePlanID = new HL7V23Field
        {
            field = message[@"FT1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insurancePlanID.field.FieldRepetitions != null && _insurancePlanID.field.FieldRepetitions.Count > 0)
        {
            _insurancePlanID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insurancePlanID, fieldData);
        }

        return _insurancePlanID;
    } 
}

internal HL7V23Field _insuranceAmount;

public HL7V23Field InsuranceAmount
{
    get
    {
        if (_insuranceAmount != null)
        {
            return _insuranceAmount;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.15",
            Type = @"Field",
            Position = @"FT1.15",
            Name = @"Insurance Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount to be posted to the insurance plan referenced above",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.15.1",
                            Type = @"Component",
                            Position = @"FT1.15.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.15.1.1",
                            Type = @"SubComponent",
                            Position = @"FT1.15.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15.1.2",
                            Type = @"SubComponent",
                            Position = @"FT1.15.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed.  The values for the denomination component are those specified in ISO-4217.  If the denomination is not specified, MSH-17country code is used to determine the default. 

Example: 
|99.50^USD| 
where USD is the ISO 4217 code for the U.S. American dollar. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15.2",
                            Type = @"Component",
                            Position = @"FT1.15.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID.  Refer to HL7 table 0205 - Price type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15.3",
                            Type = @"Component",
                            Position = @"FT1.15.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is an NM data type; together they specify the “range.”  The range can be defined as either time or quantity.  For example, the range can indicate that the first 10 minutes of the procedure has one price.  Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15.4",
                            Type = @"Component",
                            Position = @"FT1.15.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See From value",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15.5",
                            Type = @"Component",
                            Position = @"FT1.15.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (e.g., count); it is required if <from value> and  <to value> are present",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.15.5.1",
                            Type = @"SubComponent",
                            Position = @"FT1.15.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15.5.2",
                            Type = @"SubComponent",
                            Position = @"FT1.15.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15.5.3",
                            Type = @"SubComponent",
                            Position = @"FT1.15.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15.5.4",
                            Type = @"SubComponent",
                            Position = @"FT1.15.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15.5.5",
                            Type = @"SubComponent",
                            Position = @"FT1.15.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15.5.6",
                            Type = @"SubComponent",
                            Position = @"FT1.15.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15.6",
                            Type = @"Component",
                            Position = @"FT1.15.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _insuranceAmount = new HL7V23Field
        {
            field = message[@"FT1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceAmount.field.FieldRepetitions != null && _insuranceAmount.field.FieldRepetitions.Count > 0)
        {
            _insuranceAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuranceAmount, fieldData);
        }

        return _insuranceAmount;
    } 
}

internal HL7V23Field _assignedPatientLocation;

public HL7V23Field AssignedPatientLocation
{
    get
    {
        if (_assignedPatientLocation != null)
        {
            return _assignedPatientLocation;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.16",
            Type = @"Field",
            Position = @"FT1.16",
            Name = @"Assigned Patient Location",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains the current patient location.  This can be the location of the patient when the charge item was ordered or when the charged service was rendered.  For the current assigned patient location, use PV1-3-assigned patient location",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.16.1",
                            Type = @"Component",
                            Position = @"FT1.16.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = @"Conditional on person location type (e.g., nursing unit or department or clinic).  After floor, most general patient location designation.  Refer to user-defined table 0302 - Point of care for suggested values.",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = @"Patient room.  After nursing unit, most general person location designation.  Refer to user-defined table 0303 - Room for suggested values",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = @"Patient bed.  After room, most general person location designation.  Refer to user-defined table 0304 - Bed for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.4",
                            Type = @"Component",
                            Position = @"FT1.16.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Most general person location designation. (See Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.16.4.1",
                            Type = @"SubComponent",
                            Position = @"FT1.16.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.4.2",
                            Type = @"SubComponent",
                            Position = @"FT1.16.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.4.3",
                            Type = @"SubComponent",
                            Position = @"FT1.16.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.5",
                            Type = @"Component",
                            Position = @"FT1.16.5",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = @"Location (e.g., Bed) status.  Refer to user-defined table 0306 - Location status for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.6",
                            Type = @"Component",
                            Position = @"FT1.16.6",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = @"Usually includes values such as nursing unit, department, clinic, SNF, physician’s office.  Refer to userdefined table 0305 - Person location type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.7",
                            Type = @"Component",
                            Position = @"FT1.16.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = @"After facility, most general person location designation.  Refer to user-defined table 0307 - Building for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.8",
                            Type = @"Component",
                            Position = @"FT1.16.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = @"After building, most general person location designation.  Refer to user-defined table 0308 - Floor for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16.9",
                            Type = @"Component",
                            Position = @"FT1.16.9",
                            Name = @"Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A free text description of the location",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _assignedPatientLocation = new HL7V23Field
        {
            field = message[@"FT1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_assignedPatientLocation.field.FieldRepetitions != null && _assignedPatientLocation.field.FieldRepetitions.Count > 0)
        {
            _assignedPatientLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_assignedPatientLocation, fieldData);
        }

        return _assignedPatientLocation;
    } 
}

internal HL7V23Field _feeSchedule;

public HL7V23Field FeeSchedule
{
    get
    {
        if (_feeSchedule != null)
        {
            return _feeSchedule;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.17",
            Type = @"Field",
            Position = @"FT1.17",
            Name = @"Fee Schedule",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0024",
            TableName = @"Fee schedule",
            Description = @"This field contains the code used to select the appropriate fee schedule to be used for this transaction posting.  Refer to user-defined table 0024 - Fee schedule for suggested values.",
            Sample = @"",
            Fields = null
        }

        _feeSchedule = new HL7V23Field
        {
            field = message[@"FT1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_feeSchedule.field.FieldRepetitions != null && _feeSchedule.field.FieldRepetitions.Count > 0)
        {
            _feeSchedule.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_feeSchedule, fieldData);
        }

        return _feeSchedule;
    } 
}

internal HL7V23Field _patientType;

public HL7V23Field PatientType
{
    get
    {
        if (_patientType != null)
        {
            return _patientType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.18",
            Type = @"Field",
            Position = @"FT1.18",
            Name = @"Patient Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0018",
            TableName = @"Patient type",
            Description = @"This field contains the type code assigned to the patient for this episode of care (visit or stay).  Refer to user-defined table 0018 - Patient type for suggested values.  This is for use when the patient type for billing purposes is different than the visit patient type in PV1-18-patient type.",
            Sample = @"",
            Fields = null
        }

        _patientType = new HL7V23Field
        {
            field = message[@"FT1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientType.field.FieldRepetitions != null && _patientType.field.FieldRepetitions.Count > 0)
        {
            _patientType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientType, fieldData);
        }

        return _patientType;
    } 
}

internal HL7V23Field _diagnosisCode;

public HL7V23Field DiagnosisCode
{
    get
    {
        if (_diagnosisCode != null)
        {
            return _diagnosisCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.19",
            Type = @"Field",
            Position = @"FT1.19",
            Name = @"Diagnosis Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0051",
            TableName = @"Diagnosis code",
            Description = @"This field contains the primary diagnosis code for billing purposes.  ICD9-CM is assumed for all diagnosis codes.  This is the most current diagnosis code that has been assigned to the patient.  ICD10 can also be used.  Refer to user-defined table 0051 - Diagnosis code for suggested values.",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _diagnosisCode = new HL7V23Field
        {
            field = message[@"FT1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisCode.field.FieldRepetitions != null && _diagnosisCode.field.FieldRepetitions.Count > 0)
        {
            _diagnosisCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_diagnosisCode, fieldData);
        }

        return _diagnosisCode;
    } 
}

internal HL7V23Field _performedByCode;

public HL7V23Field PerformedByCode
{
    get
    {
        if (_performedByCode != null)
        {
            return _performedByCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.20",
            Type = @"Field",
            Position = @"FT1.20",
            Name = @"Performed By Code",
            Length = 120,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = @"0084",
            TableName = @"Performed by",
            Description = @"This field contains the composite number/name of the person/group that performed the test/procedure/transaction, etc.  This is the service provider.  Refer to user-defined table 0084 - Performed by for suggested values.  Multiple names and identifiers for the same practitioner may be sent in this field, not multiple practitioners.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.20.1",
                            Type = @"Component",
                            Position = @"FT1.20.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.2",
                            Type = @"Component",
                            Position = @"FT1.20.2",
                            Name = @"Family Name",
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
                            TableId = @"FirstName",
                            TableName = @"First Name",
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
                            Name = @"Suffix",
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
                            Name = @"Prefix",
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
                            Name = @"Degree",
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
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.9",
                            Type = @"Component",
                            Position = @"FT1.20.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.20.9.1",
                            Type = @"SubComponent",
                            Position = @"FT1.20.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.9.2",
                            Type = @"SubComponent",
                            Position = @"FT1.20.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.9.3",
                            Type = @"SubComponent",
                            Position = @"FT1.20.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.10",
                            Type = @"Component",
                            Position = @"FT1.20.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.11",
                            Type = @"Component",
                            Position = @"FT1.20.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.12",
                            Type = @"Component",
                            Position = @"FT1.20.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.13",
                            Type = @"Component",
                            Position = @"FT1.20.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.14",
                            Type = @"Component",
                            Position = @"FT1.20.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.20.14.1",
                            Type = @"SubComponent",
                            Position = @"FT1.20.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.14.2",
                            Type = @"SubComponent",
                            Position = @"FT1.20.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.20.14.3",
                            Type = @"SubComponent",
                            Position = @"FT1.20.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _performedByCode = new HL7V23Field
        {
            field = message[@"FT1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_performedByCode.field.FieldRepetitions != null && _performedByCode.field.FieldRepetitions.Count > 0)
        {
            _performedByCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_performedByCode, fieldData);
        }

        return _performedByCode;
    } 
}

internal HL7V23Field _orderedByCode;

public HL7V23Field OrderedByCode
{
    get
    {
        if (_orderedByCode != null)
        {
            return _orderedByCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.21",
            Type = @"Field",
            Position = @"FT1.21",
            Name = @"Ordered By Code",
            Length = 120,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the composite number/name of the person/group that ordered the test/ procedure/transaction, etc.  Multiple names and identifiers for the same practitioner may be sent in this field, not multiple practitioners.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.21.1",
                            Type = @"Component",
                            Position = @"FT1.21.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.2",
                            Type = @"Component",
                            Position = @"FT1.21.2",
                            Name = @"Family Name",
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
                            TableId = @"FirstName",
                            TableName = @"First Name",
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
                            Name = @"Suffix",
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
                            Name = @"Prefix",
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
                            Name = @"Degree",
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
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.9",
                            Type = @"Component",
                            Position = @"FT1.21.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.21.9.1",
                            Type = @"SubComponent",
                            Position = @"FT1.21.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.9.2",
                            Type = @"SubComponent",
                            Position = @"FT1.21.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.9.3",
                            Type = @"SubComponent",
                            Position = @"FT1.21.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.10",
                            Type = @"Component",
                            Position = @"FT1.21.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.11",
                            Type = @"Component",
                            Position = @"FT1.21.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.12",
                            Type = @"Component",
                            Position = @"FT1.21.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.13",
                            Type = @"Component",
                            Position = @"FT1.21.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.14",
                            Type = @"Component",
                            Position = @"FT1.21.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.21.14.1",
                            Type = @"SubComponent",
                            Position = @"FT1.21.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.14.2",
                            Type = @"SubComponent",
                            Position = @"FT1.21.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.21.14.3",
                            Type = @"SubComponent",
                            Position = @"FT1.21.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _orderedByCode = new HL7V23Field
        {
            field = message[@"FT1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderedByCode.field.FieldRepetitions != null && _orderedByCode.field.FieldRepetitions.Count > 0)
        {
            _orderedByCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_orderedByCode, fieldData);
        }

        return _orderedByCode;
    } 
}

internal HL7V23Field _unitCost;

public HL7V23Field UnitCost
{
    get
    {
        if (_unitCost != null)
        {
            return _unitCost;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.22",
            Type = @"Field",
            Position = @"FT1.22",
            Name = @"Unit Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unit cost of transaction.  The cost of a single item",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.22.1",
                            Type = @"Component",
                            Position = @"FT1.22.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.22.1.1",
                            Type = @"SubComponent",
                            Position = @"FT1.22.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.22.1.2",
                            Type = @"SubComponent",
                            Position = @"FT1.22.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed.  The values for the denomination component are those specified in ISO-4217.  If the denomination is not specified, MSH-17country code is used to determine the default. 

Example: 
|99.50^USD| 
where USD is the ISO 4217 code for the U.S. American dollar. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.22.2",
                            Type = @"Component",
                            Position = @"FT1.22.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID.  Refer to HL7 table 0205 - Price type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.22.3",
                            Type = @"Component",
                            Position = @"FT1.22.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is an NM data type; together they specify the “range.”  The range can be defined as either time or quantity.  For example, the range can indicate that the first 10 minutes of the procedure has one price.  Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.22.4",
                            Type = @"Component",
                            Position = @"FT1.22.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See From value",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.22.5",
                            Type = @"Component",
                            Position = @"FT1.22.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (e.g., count); it is required if <from value> and  <to value> are present",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.22.5.1",
                            Type = @"SubComponent",
                            Position = @"FT1.22.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.22.5.2",
                            Type = @"SubComponent",
                            Position = @"FT1.22.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.22.5.3",
                            Type = @"SubComponent",
                            Position = @"FT1.22.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.22.5.4",
                            Type = @"SubComponent",
                            Position = @"FT1.22.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.22.5.5",
                            Type = @"SubComponent",
                            Position = @"FT1.22.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.22.5.6",
                            Type = @"SubComponent",
                            Position = @"FT1.22.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.22.6",
                            Type = @"Component",
                            Position = @"FT1.22.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _unitCost = new HL7V23Field
        {
            field = message[@"FT1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_unitCost.field.FieldRepetitions != null && _unitCost.field.FieldRepetitions.Count > 0)
        {
            _unitCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_unitCost, fieldData);
        }

        return _unitCost;
    } 
}

internal HL7V23Field _fillerOrderNumber;

public HL7V23Field FillerOrderNumber
{
    get
    {
        if (_fillerOrderNumber != null)
        {
            return _fillerOrderNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.23",
            Type = @"Field",
            Position = @"FT1.23",
            Name = @"Filler Order Number",
            Length = 22,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field is used when the billing system is requesting observational reporting justification for a charge.  This is the number used by a filler to uniquely identify a result.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.23.1",
                            Type = @"Component",
                            Position = @"FT1.23.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.23.2",
                            Type = @"Component",
                            Position = @"FT1.23.2",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.23.3",
                            Type = @"Component",
                            Position = @"FT1.23.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.23.4",
                            Type = @"Component",
                            Position = @"FT1.23.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fillerOrderNumber = new HL7V23Field
        {
            field = message[@"FT1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerOrderNumber.field.FieldRepetitions != null && _fillerOrderNumber.field.FieldRepetitions.Count > 0)
        {
            _fillerOrderNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_fillerOrderNumber, fieldData);
        }

        return _fillerOrderNumber;
    } 
}

internal HL7V23Field _enteredByCode;

public HL7V23Field EnteredByCode
{
    get
    {
        if (_enteredByCode != null)
        {
            return _enteredByCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.24",
            Type = @"Field",
            Position = @"FT1.24",
            Name = @"Entered By Code",
            Length = 120,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the composite number/name of the person who entered the insurance information. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.24.1",
                            Type = @"Component",
                            Position = @"FT1.24.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.2",
                            Type = @"Component",
                            Position = @"FT1.24.2",
                            Name = @"Family Name",
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
                            Id = @"FT1.24.3",
                            Type = @"Component",
                            Position = @"FT1.24.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.4",
                            Type = @"Component",
                            Position = @"FT1.24.4",
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
                            Id = @"FT1.24.5",
                            Type = @"Component",
                            Position = @"FT1.24.5",
                            Name = @"Suffix",
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
                            Id = @"FT1.24.6",
                            Type = @"Component",
                            Position = @"FT1.24.6",
                            Name = @"Prefix",
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
                            Id = @"FT1.24.7",
                            Type = @"Component",
                            Position = @"FT1.24.7",
                            Name = @"Degree",
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
                            Id = @"FT1.24.8",
                            Type = @"Component",
                            Position = @"FT1.24.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.9",
                            Type = @"Component",
                            Position = @"FT1.24.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.24.9.1",
                            Type = @"SubComponent",
                            Position = @"FT1.24.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.9.2",
                            Type = @"SubComponent",
                            Position = @"FT1.24.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.9.3",
                            Type = @"SubComponent",
                            Position = @"FT1.24.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.10",
                            Type = @"Component",
                            Position = @"FT1.24.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.11",
                            Type = @"Component",
                            Position = @"FT1.24.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.12",
                            Type = @"Component",
                            Position = @"FT1.24.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.13",
                            Type = @"Component",
                            Position = @"FT1.24.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.14",
                            Type = @"Component",
                            Position = @"FT1.24.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.24.14.1",
                            Type = @"SubComponent",
                            Position = @"FT1.24.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.14.2",
                            Type = @"SubComponent",
                            Position = @"FT1.24.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.24.14.3",
                            Type = @"SubComponent",
                            Position = @"FT1.24.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _enteredByCode = new HL7V23Field
        {
            field = message[@"FT1"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_enteredByCode.field.FieldRepetitions != null && _enteredByCode.field.FieldRepetitions.Count > 0)
        {
            _enteredByCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_enteredByCode, fieldData);
        }

        return _enteredByCode;
    } 
}

internal HL7V23Field _procedureCode;

public HL7V23Field ProcedureCode
{
    get
    {
        if (_procedureCode != null)
        {
            return _procedureCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"FT1.25",
            Type = @"Field",
            Position = @"FT1.25",
            Name = @"Procedure Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0088",
            TableName = @"Procedure code",
            Description = @"This field contains a unique identifier assigned to the procedure, if any, associated with the charge.  Refer to user-defined table 0088 - Procedure code for suggested values.  This field is a CE data type for compatibility with clinical and ancillary systems.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FT1.25.1",
                            Type = @"Component",
                            Position = @"FT1.25.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.25.2",
                            Type = @"Component",
                            Position = @"FT1.25.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.25.3",
                            Type = @"Component",
                            Position = @"FT1.25.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.25.4",
                            Type = @"Component",
                            Position = @"FT1.25.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.25.5",
                            Type = @"Component",
                            Position = @"FT1.25.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.25.6",
                            Type = @"Component",
                            Position = @"FT1.25.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _procedureCode = new HL7V23Field
        {
            field = message[@"FT1"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCode.field.FieldRepetitions != null && _procedureCode.field.FieldRepetitions.Count > 0)
        {
            _procedureCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_procedureCode, fieldData);
        }

        return _procedureCode;
    } 
}
    }
}
