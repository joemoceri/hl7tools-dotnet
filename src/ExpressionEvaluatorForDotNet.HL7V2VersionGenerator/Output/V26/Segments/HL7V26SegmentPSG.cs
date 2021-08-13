using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentPSG
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PSG"; } }

        public string SegmentId { get { return @"PSG"; } }
        
        public string LongName { get { return @"Product/Service Group"; } }
        
        public string Description { get { return @"The Product/Service Group segment is used to form a logical grouping of Product/Service Line Items, Patients and Response Summaries for a particular Invoice. For example, a Product/Service Group can be used to group all Product/Service Line Items that must be adjudicated as a group in order to be paid."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",

                    };
            }
        }

        public HL7V26SegmentPSG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _providerProductServiceGroupNumber;

public HL7V26Field ProviderProductServiceGroupNumber
{
    get
    {
        if (_providerProductServiceGroupNumber != null)
        {
            return _providerProductServiceGroupNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSG.1",
            Type = @"Field",
            Position = @"PSG.1",
            Name = @"Provider Product/Service Group Number",
            Length = 73,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Unique Product/Service Group Number assigned by the Provider Application.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PSG.1.1",
                            Type = @"Component",
                            Position = @"PSG.1.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.1.2",
                            Type = @"Component",
                            Position = @"PSG.1.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.1.3",
                            Type = @"Component",
                            Position = @"PSG.1.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"PSG.1.4",
                            Type = @"Component",
                            Position = @"PSG.1.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _providerProductServiceGroupNumber = new HL7V26Field
        {
            field = message[@"PSG"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_providerProductServiceGroupNumber.field.FieldRepetitions != null && _providerProductServiceGroupNumber.field.FieldRepetitions.Count > 0)
        {
            _providerProductServiceGroupNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_providerProductServiceGroupNumber, fieldData);
        }

        return _providerProductServiceGroupNumber;
    } 
}

internal HL7V26Field _payerProductServiceGroupNumber;

public HL7V26Field PayerProductServiceGroupNumber
{
    get
    {
        if (_payerProductServiceGroupNumber != null)
        {
            return _payerProductServiceGroupNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSG.2",
            Type = @"Field",
            Position = @"PSG.2",
            Name = @"Payer Product/Service Group Number",
            Length = 73,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Unique Product/Service Group Number assigned by the Payer Application",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PSG.2.1",
                            Type = @"Component",
                            Position = @"PSG.2.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.2.2",
                            Type = @"Component",
                            Position = @"PSG.2.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.2.3",
                            Type = @"Component",
                            Position = @"PSG.2.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"PSG.2.4",
                            Type = @"Component",
                            Position = @"PSG.2.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _payerProductServiceGroupNumber = new HL7V26Field
        {
            field = message[@"PSG"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_payerProductServiceGroupNumber.field.FieldRepetitions != null && _payerProductServiceGroupNumber.field.FieldRepetitions.Count > 0)
        {
            _payerProductServiceGroupNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_payerProductServiceGroupNumber, fieldData);
        }

        return _payerProductServiceGroupNumber;
    } 
}

internal HL7V26Field _productServiceGroupSequenceNumber;

public HL7V26Field ProductServiceGroupSequenceNumber
{
    get
    {
        if (_productServiceGroupSequenceNumber != null)
        {
            return _productServiceGroupSequenceNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSG.3",
            Type = @"Field",
            Position = @"PSG.3",
            Name = @"Product/Service Group Sequence Number",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"Unique sequence number for the Product/Service Group (3) - starts with 1, then 2, etc. for each unique Product/Service Group in this Invoice.",
            Sample = @"",
            Fields = null
        }

        _productServiceGroupSequenceNumber = new HL7V26Field
        {
            field = message[@"PSG"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productServiceGroupSequenceNumber.field.FieldRepetitions != null && _productServiceGroupSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _productServiceGroupSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_productServiceGroupSequenceNumber, fieldData);
        }

        return _productServiceGroupSequenceNumber;
    } 
}

internal HL7V26Field _adjudicateasGroup;

public HL7V26Field AdjudicateasGroup
{
    get
    {
        if (_adjudicateasGroup != null)
        {
            return _adjudicateasGroup;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSG.4",
            Type = @"Field",
            Position = @"PSG.4",
            Name = @"Adjudicate as Group",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Adjudicate all Product/Service Line Items together as a group (IPRs will be reported against the Product/Service Group). Refer to HL7-Table0136 - Yes/No-Indicator for suggested values.",
            Sample = @"",
            Fields = null
        }

        _adjudicateasGroup = new HL7V26Field
        {
            field = message[@"PSG"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_adjudicateasGroup.field.FieldRepetitions != null && _adjudicateasGroup.field.FieldRepetitions.Count > 0)
        {
            _adjudicateasGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_adjudicateasGroup, fieldData);
        }

        return _adjudicateasGroup;
    } 
}

internal HL7V26Field _productServiceGroupBilledAmount;

public HL7V26Field ProductServiceGroupBilledAmount
{
    get
    {
        if (_productServiceGroupBilledAmount != null)
        {
            return _productServiceGroupBilledAmount;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSG.5",
            Type = @"Field",
            Position = @"PSG.5",
            Name = @"Product/Service Group Billed Amount",
            Length = 254,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"Sum of all Product/Service Billed Amounts for all Product/Service Line Items for this Product/Service Group.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PSG.5.1",
                            Type = @"Component",
                            Position = @"PSG.5.1",
                            Name = @"Price",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.A.41, ""MO - money"") is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSG.5.1.1",
                            Type = @"SubComponent",
                            Position = @"PSG.5.1.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.1.2",
                            Type = @"SubComponent",
                            Position = @"PSG.5.1.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, ""MSH-17-country code"", in section 2.14.9.17, is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.2",
                            Type = @"Component",
                            Position = @"PSG.5.2",
                            Name = @"Price Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.3",
                            Type = @"Component",
                            Position = @"PSG.5.3",
                            Name = @"From Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the ""range"". The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.4",
                            Type = @"Component",
                            Position = @"PSG.5.4",
                            Name = @"To Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value>.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.5",
                            Type = @"Component",
                            Position = @"PSG.5.5",
                            Name = @"Range Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CWE, defined by the standard table of units for either time or quantity (see for example, the tables in Section 7.1.4, ""Coding schemes""). This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and <to value> are present.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSG.5.5.1",
                            Type = @"SubComponent",
                            Position = @"PSG.5.5.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.5.2",
                            Type = @"SubComponent",
                            Position = @"PSG.5.5.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.5.3",
                            Type = @"SubComponent",
                            Position = @"PSG.5.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.5.4",
                            Type = @"SubComponent",
                            Position = @"PSG.5.5.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.5.5",
                            Type = @"SubComponent",
                            Position = @"PSG.5.5.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.5.6",
                            Type = @"SubComponent",
                            Position = @"PSG.5.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.5.7",
                            Type = @"SubComponent",
                            Position = @"PSG.5.5.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.5.8",
                            Type = @"SubComponent",
                            Position = @"PSG.5.5.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.5.9",
                            Type = @"SubComponent",
                            Position = @"PSG.5.5.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSG.5.6",
                            Type = @"Component",
                            Position = @"PSG.5.6",
                            Name = @"Range Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _productServiceGroupBilledAmount = new HL7V26Field
        {
            field = message[@"PSG"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productServiceGroupBilledAmount.field.FieldRepetitions != null && _productServiceGroupBilledAmount.field.FieldRepetitions.Count > 0)
        {
            _productServiceGroupBilledAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_productServiceGroupBilledAmount, fieldData);
        }

        return _productServiceGroupBilledAmount;
    } 
}

internal HL7V26Field _productServiceGroupDescription;

public HL7V26Field ProductServiceGroupDescription
{
    get
    {
        if (_productServiceGroupDescription != null)
        {
            return _productServiceGroupDescription;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSG.6",
            Type = @"Field",
            Position = @"PSG.6",
            Name = @"Product/Service Group Description",
            Length = 254,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Product/Service Group description or heading",
            Sample = @"",
            Fields = null
        }

        _productServiceGroupDescription = new HL7V26Field
        {
            field = message[@"PSG"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productServiceGroupDescription.field.FieldRepetitions != null && _productServiceGroupDescription.field.FieldRepetitions.Count > 0)
        {
            _productServiceGroupDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_productServiceGroupDescription, fieldData);
        }

        return _productServiceGroupDescription;
    } 
}
    }
}
