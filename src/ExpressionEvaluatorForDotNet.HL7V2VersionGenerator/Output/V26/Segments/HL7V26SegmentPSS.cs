using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentPSS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PSS"; } }

        public string SegmentId { get { return @"PSS"; } }
        
        public string LongName { get { return @"Product/Service Section"; } }
        
        public string Description { get { return @"The Product/Service Section segment is used to form a logical grouping of Product/Service Group segments, Patients and Response Summaries for a particular Invoice."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PSS.1",
                            Type = @"Field",
                            Position = @"PSS.1",
                            Name = @"Provider Product/Service Section Number",
                            Length = 73,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Unique Product/Service Section Number assigned by the Provider Application.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSS.1.1",
                            Type = @"Component",
                            Position = @"PSS.1.1",
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
                            Id = @"PSS.1.2",
                            Type = @"Component",
                            Position = @"PSS.1.2",
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
                            Id = @"PSS.1.3",
                            Type = @"Component",
                            Position = @"PSS.1.3",
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
                            Id = @"PSS.1.4",
                            Type = @"Component",
                            Position = @"PSS.1.4",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSS.2",
                            Type = @"Field",
                            Position = @"PSS.2",
                            Name = @"Payer Product/Service Section Number",
                            Length = 73,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Unique Product/Service Section Number assigned by the Payer Application.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSS.2.1",
                            Type = @"Component",
                            Position = @"PSS.2.1",
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
                            Id = @"PSS.2.2",
                            Type = @"Component",
                            Position = @"PSS.2.2",
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
                            Id = @"PSS.2.3",
                            Type = @"Component",
                            Position = @"PSS.2.3",
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
                            Id = @"PSS.2.4",
                            Type = @"Component",
                            Position = @"PSS.2.4",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSS.3",
                            Type = @"Field",
                            Position = @"PSS.3",
                            Name = @"Product/Service Section Sequence Number",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"Unique sequence number for the Product/Service Section (3) - starts with 1, then 2, etc. for each unique Product/Service Section in this Invoice.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSS.4",
                            Type = @"Field",
                            Position = @"PSS.4",
                            Name = @"Billed Amount",
                            Length = 254,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"Sum of all Product/Service Billed Amounts for all Product/Service Line Items for this Product/Service Section.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSS.4.1",
                            Type = @"Component",
                            Position = @"PSS.4.1",
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
                            Id = @"PSS.4.1.1",
                            Type = @"SubComponent",
                            Position = @"PSS.4.1.1",
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
                            Id = @"PSS.4.1.2",
                            Type = @"SubComponent",
                            Position = @"PSS.4.1.2",
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
                            Id = @"PSS.4.2",
                            Type = @"Component",
                            Position = @"PSS.4.2",
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
                            Id = @"PSS.4.3",
                            Type = @"Component",
                            Position = @"PSS.4.3",
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
                            Id = @"PSS.4.4",
                            Type = @"Component",
                            Position = @"PSS.4.4",
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
                            Id = @"PSS.4.5",
                            Type = @"Component",
                            Position = @"PSS.4.5",
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
                            Id = @"PSS.4.5.1",
                            Type = @"SubComponent",
                            Position = @"PSS.4.5.1",
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
                            Id = @"PSS.4.5.2",
                            Type = @"SubComponent",
                            Position = @"PSS.4.5.2",
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
                            Id = @"PSS.4.5.3",
                            Type = @"SubComponent",
                            Position = @"PSS.4.5.3",
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
                            Id = @"PSS.4.5.4",
                            Type = @"SubComponent",
                            Position = @"PSS.4.5.4",
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
                            Id = @"PSS.4.5.5",
                            Type = @"SubComponent",
                            Position = @"PSS.4.5.5",
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
                            Id = @"PSS.4.5.6",
                            Type = @"SubComponent",
                            Position = @"PSS.4.5.6",
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
                            Id = @"PSS.4.5.7",
                            Type = @"SubComponent",
                            Position = @"PSS.4.5.7",
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
                            Id = @"PSS.4.5.8",
                            Type = @"SubComponent",
                            Position = @"PSS.4.5.8",
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
                            Id = @"PSS.4.5.9",
                            Type = @"SubComponent",
                            Position = @"PSS.4.5.9",
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
                            Id = @"PSS.4.6",
                            Type = @"Component",
                            Position = @"PSS.4.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSS.5",
                            Type = @"Field",
                            Position = @"PSS.5",
                            Name = @"Section Description or Heading",
                            Length = 254,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Section description or heading.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentPSS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field providerProductServiceSectionNumber;

public HL7V26Field ProviderProductServiceSectionNumber
{
    get
    {
        if (providerProductServiceSectionNumber != null)
        {
            return providerProductServiceSectionNumber;
        }

        providerProductServiceSectionNumber = new HL7V26Field
        {
            field = message[@"PSS"][1],
            Id = @"PSS.1",
            Type = @"Field",
            Position = @"PSS.1",
            Name = @"Provider Product/Service Section Number",
            Length = 73,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Unique Product/Service Section Number assigned by the Provider Application.",
            Sample = @"",
        };

        // check for repetitions
        if (providerProductServiceSectionNumber.field.FieldRepetitions != null && providerProductServiceSectionNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(providerProductServiceSectionNumber.Id));
            providerProductServiceSectionNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(providerProductServiceSectionNumber, fieldData);
        }

        return providerProductServiceSectionNumber;
    } 
}

internal HL7V26Field payerProductServiceSectionNumber;

public HL7V26Field PayerProductServiceSectionNumber
{
    get
    {
        if (payerProductServiceSectionNumber != null)
        {
            return payerProductServiceSectionNumber;
        }

        payerProductServiceSectionNumber = new HL7V26Field
        {
            field = message[@"PSS"][2],
            Id = @"PSS.2",
            Type = @"Field",
            Position = @"PSS.2",
            Name = @"Payer Product/Service Section Number",
            Length = 73,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Unique Product/Service Section Number assigned by the Payer Application.",
            Sample = @"",
        };

        // check for repetitions
        if (payerProductServiceSectionNumber.field.FieldRepetitions != null && payerProductServiceSectionNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(payerProductServiceSectionNumber.Id));
            payerProductServiceSectionNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(payerProductServiceSectionNumber, fieldData);
        }

        return payerProductServiceSectionNumber;
    } 
}

internal HL7V26Field productServiceSectionSequenceNumber;

public HL7V26Field ProductServiceSectionSequenceNumber
{
    get
    {
        if (productServiceSectionSequenceNumber != null)
        {
            return productServiceSectionSequenceNumber;
        }

        productServiceSectionSequenceNumber = new HL7V26Field
        {
            field = message[@"PSS"][3],
            Id = @"PSS.3",
            Type = @"Field",
            Position = @"PSS.3",
            Name = @"Product/Service Section Sequence Number",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"Unique sequence number for the Product/Service Section (3) - starts with 1, then 2, etc. for each unique Product/Service Section in this Invoice.",
            Sample = @"",
        };

        // check for repetitions
        if (productServiceSectionSequenceNumber.field.FieldRepetitions != null && productServiceSectionSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productServiceSectionSequenceNumber.Id));
            productServiceSectionSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(productServiceSectionSequenceNumber, fieldData);
        }

        return productServiceSectionSequenceNumber;
    } 
}

internal HL7V26Field billedAmount;

public HL7V26Field BilledAmount
{
    get
    {
        if (billedAmount != null)
        {
            return billedAmount;
        }

        billedAmount = new HL7V26Field
        {
            field = message[@"PSS"][4],
            Id = @"PSS.4",
            Type = @"Field",
            Position = @"PSS.4",
            Name = @"Billed Amount",
            Length = 254,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"Sum of all Product/Service Billed Amounts for all Product/Service Line Items for this Product/Service Section.",
            Sample = @"",
        };

        // check for repetitions
        if (billedAmount.field.FieldRepetitions != null && billedAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(billedAmount.Id));
            billedAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(billedAmount, fieldData);
        }

        return billedAmount;
    } 
}

internal HL7V26Field sectionDescriptionorHeading;

public HL7V26Field SectionDescriptionorHeading
{
    get
    {
        if (sectionDescriptionorHeading != null)
        {
            return sectionDescriptionorHeading;
        }

        sectionDescriptionorHeading = new HL7V26Field
        {
            field = message[@"PSS"][5],
            Id = @"PSS.5",
            Type = @"Field",
            Position = @"PSS.5",
            Name = @"Section Description or Heading",
            Length = 254,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Section description or heading.",
            Sample = @"",
        };

        // check for repetitions
        if (sectionDescriptionorHeading.field.FieldRepetitions != null && sectionDescriptionorHeading.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sectionDescriptionorHeading.Id));
            sectionDescriptionorHeading.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(sectionDescriptionorHeading, fieldData);
        }

        return sectionDescriptionorHeading;
    } 
}
    }
}
