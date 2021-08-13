using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentIPR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IPR"; } }

        public string SegmentId { get { return @"IPR"; } }
        
        public string LongName { get { return @"Invoice Processing Results"; } }
        
        public string Description { get { return @"The Invoice Processing Results (IPR) segment provides summary information about an adjudicated Product/Service Group or Product/Service Line Item."; } }
        
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

        public HL7V26SegmentIPR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _iPRIdentifier;

public HL7V26Field IPRIdentifier
{
    get
    {
        if (_iPRIdentifier != null)
        {
            return _iPRIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IPR.1",
            Type = @"Field",
            Position = @"IPR.1",
            Name = @"IPR Identifier",
            Length = 73,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Unique IPR Number assigned by the Payer Application.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPR.1.1",
                            Type = @"Component",
                            Position = @"IPR.1.1",
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
                            Id = @"IPR.1.2",
                            Type = @"Component",
                            Position = @"IPR.1.2",
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
                            Id = @"IPR.1.3",
                            Type = @"Component",
                            Position = @"IPR.1.3",
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
                            Id = @"IPR.1.4",
                            Type = @"Component",
                            Position = @"IPR.1.4",
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

        _iPRIdentifier = new HL7V26Field
        {
            field = message[@"IPR"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_iPRIdentifier.field.FieldRepetitions != null && _iPRIdentifier.field.FieldRepetitions.Count > 0)
        {
            _iPRIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_iPRIdentifier, fieldData);
        }

        return _iPRIdentifier;
    } 
}

internal HL7V26Field _providerCrossReferenceIdentifier;

public HL7V26Field ProviderCrossReferenceIdentifier
{
    get
    {
        if (_providerCrossReferenceIdentifier != null)
        {
            return _providerCrossReferenceIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IPR.2",
            Type = @"Field",
            Position = @"IPR.2",
            Name = @"Provider Cross Reference Identifier",
            Length = 73,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Cross reference to Provider Product/Service Group Number or Provider Product/Service Line Item Number from original Invoice.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPR.2.1",
                            Type = @"Component",
                            Position = @"IPR.2.1",
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
                            Id = @"IPR.2.2",
                            Type = @"Component",
                            Position = @"IPR.2.2",
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
                            Id = @"IPR.2.3",
                            Type = @"Component",
                            Position = @"IPR.2.3",
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
                            Id = @"IPR.2.4",
                            Type = @"Component",
                            Position = @"IPR.2.4",
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

        _providerCrossReferenceIdentifier = new HL7V26Field
        {
            field = message[@"IPR"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_providerCrossReferenceIdentifier.field.FieldRepetitions != null && _providerCrossReferenceIdentifier.field.FieldRepetitions.Count > 0)
        {
            _providerCrossReferenceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_providerCrossReferenceIdentifier, fieldData);
        }

        return _providerCrossReferenceIdentifier;
    } 
}

internal HL7V26Field _payerCrossReferenceIdentifier;

public HL7V26Field PayerCrossReferenceIdentifier
{
    get
    {
        if (_payerCrossReferenceIdentifier != null)
        {
            return _payerCrossReferenceIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IPR.3",
            Type = @"Field",
            Position = @"IPR.3",
            Name = @"Payer Cross Reference Identifier",
            Length = 73,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Cross reference to Payer Product/Service Group Number or Payer Product/Service Line Item Number from original Invoice.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPR.3.1",
                            Type = @"Component",
                            Position = @"IPR.3.1",
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
                            Id = @"IPR.3.2",
                            Type = @"Component",
                            Position = @"IPR.3.2",
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
                            Id = @"IPR.3.3",
                            Type = @"Component",
                            Position = @"IPR.3.3",
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
                            Id = @"IPR.3.4",
                            Type = @"Component",
                            Position = @"IPR.3.4",
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

        _payerCrossReferenceIdentifier = new HL7V26Field
        {
            field = message[@"IPR"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_payerCrossReferenceIdentifier.field.FieldRepetitions != null && _payerCrossReferenceIdentifier.field.FieldRepetitions.Count > 0)
        {
            _payerCrossReferenceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_payerCrossReferenceIdentifier, fieldData);
        }

        return _payerCrossReferenceIdentifier;
    } 
}

internal HL7V26Field _iPRStatus;

public HL7V26Field IPRStatus
{
    get
    {
        if (_iPRStatus != null)
        {
            return _iPRStatus;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IPR.4",
            Type = @"Field",
            Position = @"IPR.4",
            Name = @"IPR Status",
            Length = 177,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0571",
            TableName = @"Invoice Processing Results Status",
            Description = @"Processing status for the Product/Service Group (if Adjudicate as Group = ""Y"") or Product/Service Line Item. Refer to User-defined Table 0571 - Invoice Processing Results Status for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPR.4.1",
                            Type = @"Component",
                            Position = @"IPR.4.1",
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
                            Id = @"IPR.4.2",
                            Type = @"Component",
                            Position = @"IPR.4.2",
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
                            Id = @"IPR.4.3",
                            Type = @"Component",
                            Position = @"IPR.4.3",
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
                            Id = @"IPR.4.4",
                            Type = @"Component",
                            Position = @"IPR.4.4",
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
                            Id = @"IPR.4.5",
                            Type = @"Component",
                            Position = @"IPR.4.5",
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
                            Id = @"IPR.4.6",
                            Type = @"Component",
                            Position = @"IPR.4.6",
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
                            Id = @"IPR.4.7",
                            Type = @"Component",
                            Position = @"IPR.4.7",
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
                            Id = @"IPR.4.8",
                            Type = @"Component",
                            Position = @"IPR.4.8",
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
                            Id = @"IPR.4.9",
                            Type = @"Component",
                            Position = @"IPR.4.9",
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
                        },
                        }
        }

        _iPRStatus = new HL7V26Field
        {
            field = message[@"IPR"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_iPRStatus.field.FieldRepetitions != null && _iPRStatus.field.FieldRepetitions.Count > 0)
        {
            _iPRStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_iPRStatus, fieldData);
        }

        return _iPRStatus;
    } 
}

internal HL7V26Field _iPRDateTime;

public HL7V26Field IPRDateTime
{
    get
    {
        if (_iPRDateTime != null)
        {
            return _iPRDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IPR.5",
            Type = @"Field",
            Position = @"IPR.5",
            Name = @"IPR Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"Date/Time IPR was created.",
            Sample = @"",
            Fields = null
        }

        _iPRDateTime = new HL7V26Field
        {
            field = message[@"IPR"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_iPRDateTime.field.FieldRepetitions != null && _iPRDateTime.field.FieldRepetitions.Count > 0)
        {
            _iPRDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_iPRDateTime, fieldData);
        }

        return _iPRDateTime;
    } 
}

internal HL7V26Field _adjudicatedPaidAmount;

public HL7V26Field AdjudicatedPaidAmount
{
    get
    {
        if (_adjudicatedPaidAmount != null)
        {
            return _adjudicatedPaidAmount;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IPR.6",
            Type = @"Field",
            Position = @"IPR.6",
            Name = @"Adjudicated/Paid Amount",
            Length = 254,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"Adjudicated Amount for the Product/Service Group or Product/Service Line Item, which could be 0 = sum of all Payer adjustments (Adjustment Amount on ADJ).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPR.6.1",
                            Type = @"Component",
                            Position = @"IPR.6.1",
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
                            Id = @"IPR.6.1.1",
                            Type = @"SubComponent",
                            Position = @"IPR.6.1.1",
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
                            Id = @"IPR.6.1.2",
                            Type = @"SubComponent",
                            Position = @"IPR.6.1.2",
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
                            Id = @"IPR.6.2",
                            Type = @"Component",
                            Position = @"IPR.6.2",
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
                            Id = @"IPR.6.3",
                            Type = @"Component",
                            Position = @"IPR.6.3",
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
                            Id = @"IPR.6.4",
                            Type = @"Component",
                            Position = @"IPR.6.4",
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
                            Id = @"IPR.6.5",
                            Type = @"Component",
                            Position = @"IPR.6.5",
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
                            Id = @"IPR.6.5.1",
                            Type = @"SubComponent",
                            Position = @"IPR.6.5.1",
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
                            Id = @"IPR.6.5.2",
                            Type = @"SubComponent",
                            Position = @"IPR.6.5.2",
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
                            Id = @"IPR.6.5.3",
                            Type = @"SubComponent",
                            Position = @"IPR.6.5.3",
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
                            Id = @"IPR.6.5.4",
                            Type = @"SubComponent",
                            Position = @"IPR.6.5.4",
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
                            Id = @"IPR.6.5.5",
                            Type = @"SubComponent",
                            Position = @"IPR.6.5.5",
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
                            Id = @"IPR.6.5.6",
                            Type = @"SubComponent",
                            Position = @"IPR.6.5.6",
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
                            Id = @"IPR.6.5.7",
                            Type = @"SubComponent",
                            Position = @"IPR.6.5.7",
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
                            Id = @"IPR.6.5.8",
                            Type = @"SubComponent",
                            Position = @"IPR.6.5.8",
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
                            Id = @"IPR.6.5.9",
                            Type = @"SubComponent",
                            Position = @"IPR.6.5.9",
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
                            Id = @"IPR.6.6",
                            Type = @"Component",
                            Position = @"IPR.6.6",
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

        _adjudicatedPaidAmount = new HL7V26Field
        {
            field = message[@"IPR"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_adjudicatedPaidAmount.field.FieldRepetitions != null && _adjudicatedPaidAmount.field.FieldRepetitions.Count > 0)
        {
            _adjudicatedPaidAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_adjudicatedPaidAmount, fieldData);
        }

        return _adjudicatedPaidAmount;
    } 
}

internal HL7V26Field _expectedPaymentDateTime;

public HL7V26Field ExpectedPaymentDateTime
{
    get
    {
        if (_expectedPaymentDateTime != null)
        {
            return _expectedPaymentDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IPR.7",
            Type = @"Field",
            Position = @"IPR.7",
            Name = @"Expected Payment Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"Date payment is expected for this IPR.",
            Sample = @"",
            Fields = null
        }

        _expectedPaymentDateTime = new HL7V26Field
        {
            field = message[@"IPR"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedPaymentDateTime.field.FieldRepetitions != null && _expectedPaymentDateTime.field.FieldRepetitions.Count > 0)
        {
            _expectedPaymentDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_expectedPaymentDateTime, fieldData);
        }

        return _expectedPaymentDateTime;
    } 
}

internal HL7V26Field _iPRChecksum;

public HL7V26Field IPRChecksum
{
    get
    {
        if (_iPRChecksum != null)
        {
            return _iPRChecksum;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IPR.8",
            Type = @"Field",
            Position = @"IPR.8",
            Name = @"IPR Checksum",
            Length = 10,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Conditional, if Status = ""Accepted"", then Required, else Not Permitted.

The field contains a checksum generated by the first Payer (referenced by Payer Organization in the IVC Segment) to ensure that the contents of IPR have not been altered before sending to subsequent Payers.",
            Sample = @"",
            Fields = null
        }

        _iPRChecksum = new HL7V26Field
        {
            field = message[@"IPR"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_iPRChecksum.field.FieldRepetitions != null && _iPRChecksum.field.FieldRepetitions.Count > 0)
        {
            _iPRChecksum.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_iPRChecksum, fieldData);
        }

        return _iPRChecksum;
    } 
}
    }
}
