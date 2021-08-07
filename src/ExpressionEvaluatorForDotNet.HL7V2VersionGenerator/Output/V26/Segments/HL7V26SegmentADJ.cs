using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentADJ
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ADJ"; } }

        public string SegmentId { get { return @"ADJ"; } }
        
        public string LongName { get { return @"Adjustment"; } }
        
        public string Description { get { return @"This segment describes Provider and/or Payer adjustments to a Product/Service Line Item or Response Summary. These include surcharges such as tax, dispensing fees and mark ups."; } }
        
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
                            Id = @"ADJ.1",
                            Type = @"Field",
                            Position = @"ADJ.1",
                            Name = @"Provider Adjustment Number",
                            Length = 73,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Unique Adjustment Number assigned by the Provider Application.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.1.1",
                            Type = @"Component",
                            Position = @"ADJ.1.1",
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
                            Id = @"ADJ.1.2",
                            Type = @"Component",
                            Position = @"ADJ.1.2",
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
                            Id = @"ADJ.1.3",
                            Type = @"Component",
                            Position = @"ADJ.1.3",
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
                            Id = @"ADJ.1.4",
                            Type = @"Component",
                            Position = @"ADJ.1.4",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.2",
                            Type = @"Field",
                            Position = @"ADJ.2",
                            Name = @"Payer Adjustment Number",
                            Length = 73,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Unique Adjustment Number assigned by the Payer Application.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.2.1",
                            Type = @"Component",
                            Position = @"ADJ.2.1",
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
                            Id = @"ADJ.2.2",
                            Type = @"Component",
                            Position = @"ADJ.2.2",
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
                            Id = @"ADJ.2.3",
                            Type = @"Component",
                            Position = @"ADJ.2.3",
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
                            Id = @"ADJ.2.4",
                            Type = @"Component",
                            Position = @"ADJ.2.4",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.3",
                            Type = @"Field",
                            Position = @"ADJ.3",
                            Name = @"Adjustment Sequence Number",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"Unique sequence number for this adjustment - starts with 1, then 2, etc., for each unique adjustment for the Product/Service Line Item.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.4",
                            Type = @"Field",
                            Position = @"ADJ.4",
                            Name = @"Adjustment Category",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0564",
                            TableName = @"Adjustment Category Code",
                            Description = @"Indicates the category of adjustment and is used to assist in determining which table is used for Adjustment Reason. Refer to User-defined Table 0564 - Adjustment Category Code for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.5",
                            Type = @"Field",
                            Position = @"ADJ.5",
                            Name = @"Adjustment Amount",
                            Length = 254,
                            Usage = @"O",
                            Rpt = @"5",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"Adjustment amount, such as taxes, deductibles, previously paid amount.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.5.1",
                            Type = @"Component",
                            Position = @"ADJ.5.1",
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
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.5.1.1",
                            Type = @"SubComponent",
                            Position = @"ADJ.5.1.1",
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
                            Id = @"ADJ.5.1.2",
                            Type = @"SubComponent",
                            Position = @"ADJ.5.1.2",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.5.2",
                            Type = @"Component",
                            Position = @"ADJ.5.2",
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
                            Id = @"ADJ.5.3",
                            Type = @"Component",
                            Position = @"ADJ.5.3",
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
                            Id = @"ADJ.5.4",
                            Type = @"Component",
                            Position = @"ADJ.5.4",
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
                            Id = @"ADJ.5.5",
                            Type = @"Component",
                            Position = @"ADJ.5.5",
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
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.5.5.1",
                            Type = @"SubComponent",
                            Position = @"ADJ.5.5.1",
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
                            Id = @"ADJ.5.5.2",
                            Type = @"SubComponent",
                            Position = @"ADJ.5.5.2",
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
                            Id = @"ADJ.5.5.3",
                            Type = @"SubComponent",
                            Position = @"ADJ.5.5.3",
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
                            Id = @"ADJ.5.5.4",
                            Type = @"SubComponent",
                            Position = @"ADJ.5.5.4",
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
                            Id = @"ADJ.5.5.5",
                            Type = @"SubComponent",
                            Position = @"ADJ.5.5.5",
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
                            Id = @"ADJ.5.5.6",
                            Type = @"SubComponent",
                            Position = @"ADJ.5.5.6",
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
                            Id = @"ADJ.5.5.7",
                            Type = @"SubComponent",
                            Position = @"ADJ.5.5.7",
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
                            Id = @"ADJ.5.5.8",
                            Type = @"SubComponent",
                            Position = @"ADJ.5.5.8",
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
                            Id = @"ADJ.5.5.9",
                            Type = @"SubComponent",
                            Position = @"ADJ.5.5.9",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.5.6",
                            Type = @"Component",
                            Position = @"ADJ.5.6",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.6",
                            Type = @"Field",
                            Position = @"ADJ.6",
                            Name = @"Adjustment Quantity",
                            Length = 222,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"Adjustment quantity.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.6.1",
                            Type = @"Component",
                            Position = @"ADJ.6.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.6.2",
                            Type = @"Component",
                            Position = @"ADJ.6.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.6.2.1",
                            Type = @"SubComponent",
                            Position = @"ADJ.6.2.1",
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
                            Id = @"ADJ.6.2.2",
                            Type = @"SubComponent",
                            Position = @"ADJ.6.2.2",
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
                            Id = @"ADJ.6.2.3",
                            Type = @"SubComponent",
                            Position = @"ADJ.6.2.3",
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
                            Id = @"ADJ.6.2.4",
                            Type = @"SubComponent",
                            Position = @"ADJ.6.2.4",
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
                            Id = @"ADJ.6.2.5",
                            Type = @"SubComponent",
                            Position = @"ADJ.6.2.5",
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
                            Id = @"ADJ.6.2.6",
                            Type = @"SubComponent",
                            Position = @"ADJ.6.2.6",
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
                            Id = @"ADJ.6.2.7",
                            Type = @"SubComponent",
                            Position = @"ADJ.6.2.7",
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
                            Id = @"ADJ.6.2.8",
                            Type = @"SubComponent",
                            Position = @"ADJ.6.2.8",
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
                            Id = @"ADJ.6.2.9",
                            Type = @"SubComponent",
                            Position = @"ADJ.6.2.9",
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
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.7",
                            Type = @"Field",
                            Position = @"ADJ.7",
                            Name = @"Adjustment Reason PA",
                            Length = 211,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0565",
                            TableName = @"Provider Adjustment Reason Code",
                            Description = @"Reason for this adjustment. Codes used to explain a Provider adjustment to a Product/Service Group or Product/Service Line Item by a Provider. Refer to User-defined table 0565 - Provider Adjustment Reason Code for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.7.1",
                            Type = @"Component",
                            Position = @"ADJ.7.1",
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
                            Id = @"ADJ.7.2",
                            Type = @"Component",
                            Position = @"ADJ.7.2",
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
                            Id = @"ADJ.7.3",
                            Type = @"Component",
                            Position = @"ADJ.7.3",
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
                            Id = @"ADJ.7.4",
                            Type = @"Component",
                            Position = @"ADJ.7.4",
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
                            Id = @"ADJ.7.5",
                            Type = @"Component",
                            Position = @"ADJ.7.5",
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
                            Id = @"ADJ.7.6",
                            Type = @"Component",
                            Position = @"ADJ.7.6",
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
                            Id = @"ADJ.7.7",
                            Type = @"Component",
                            Position = @"ADJ.7.7",
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
                            Id = @"ADJ.7.8",
                            Type = @"Component",
                            Position = @"ADJ.7.8",
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
                            Id = @"ADJ.7.9",
                            Type = @"Component",
                            Position = @"ADJ.7.9",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.8",
                            Type = @"Field",
                            Position = @"ADJ.8",
                            Name = @"Adjustment Description",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Description of adjustment, such as client instructions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.9",
                            Type = @"Field",
                            Position = @"ADJ.9",
                            Name = @"Original Value",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Original value of data item noted in this adjustment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.10",
                            Type = @"Field",
                            Position = @"ADJ.10",
                            Name = @"Substitute Value",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Substituted value of data item noted in this adjustment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.11",
                            Type = @"Field",
                            Position = @"ADJ.11",
                            Name = @"Adjustment Action",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0569",
                            TableName = @"Adjustment Action",
                            Description = @"Action requested of party that receives this adjustment. Refer to User-defined Table 0569 - Adjustment Action for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.12",
                            Type = @"Field",
                            Position = @"ADJ.12",
                            Name = @"Provider Adjustment Number Cross Reference",
                            Length = 73,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Unique Provider Adjustment Number assigned by the Provider Application that is referenced by this Payer Adjustment.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.12.1",
                            Type = @"Component",
                            Position = @"ADJ.12.1",
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
                            Id = @"ADJ.12.2",
                            Type = @"Component",
                            Position = @"ADJ.12.2",
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
                            Id = @"ADJ.12.3",
                            Type = @"Component",
                            Position = @"ADJ.12.3",
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
                            Id = @"ADJ.12.4",
                            Type = @"Component",
                            Position = @"ADJ.12.4",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.13",
                            Type = @"Field",
                            Position = @"ADJ.13",
                            Name = @"Provider Product/Service Line Item Number Cross Reference",
                            Length = 73,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Unique Provider Product/Service Line Item Number assigned by the Provider Application that is referenced by this Payer Adjustment; used for groups with multiple line items that need to be singled out by a Payer Adjustment.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.13.1",
                            Type = @"Component",
                            Position = @"ADJ.13.1",
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
                            Id = @"ADJ.13.2",
                            Type = @"Component",
                            Position = @"ADJ.13.2",
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
                            Id = @"ADJ.13.3",
                            Type = @"Component",
                            Position = @"ADJ.13.3",
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
                            Id = @"ADJ.13.4",
                            Type = @"Component",
                            Position = @"ADJ.13.4",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.14",
                            Type = @"Field",
                            Position = @"ADJ.14",
                            Name = @"Adjustment Date",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"Date/Time adjustment was made. May also be synonymous with Adjudication Date.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15",
                            Type = @"Field",
                            Position = @"ADJ.15",
                            Name = @"Responsible Organization",
                            Length = 183,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"Business organization that is responsible for the adjustment (e.g., Payer organization); can be used for a Payment/Remittance Advice for 1 Payee from multiple Payers.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.1",
                            Type = @"Component",
                            Position = @"ADJ.15.1",
                            Name = @"Organization Name",
                            Length = 50,
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
                            Id = @"ADJ.15.2",
                            Type = @"Component",
                            Position = @"ADJ.15.2",
                            Name = @"Organization Name Type Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.3",
                            Type = @"Component",
                            Position = @"ADJ.15.3",
                            Name = @"Id Number",
                            Length = 4,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component has been retained for backward compatibility only as of v 2.5. It is recommended to use component 10 Organization identifier that accommodates alphanumeric identifiers.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.4",
                            Type = @"Component",
                            Position = @"ADJ.15.4",
                            Name = @"Identifier Check Digit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the digit, or digits, exclusive of the identifier in XON.1, usually calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.5",
                            Type = @"Component",
                            Position = @"ADJ.15.5",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.6",
                            Type = @"Component",
                            Position = @"ADJ.15.6",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.6.1",
                            Type = @"SubComponent",
                            Position = @"ADJ.15.6.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.6.2",
                            Type = @"SubComponent",
                            Position = @"ADJ.15.6.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Id = @"ADJ.15.6.3",
                            Type = @"SubComponent",
                            Position = @"ADJ.15.6.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.7",
                            Type = @"Component",
                            Position = @"ADJ.15.7",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the ""Assigning authority"" component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.8",
                            Type = @"Component",
                            Position = @"ADJ.15.8",
                            Name = @"Assigning Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.8.1",
                            Type = @"SubComponent",
                            Position = @"ADJ.15.8.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.8.2",
                            Type = @"SubComponent",
                            Position = @"ADJ.15.8.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Id = @"ADJ.15.8.3",
                            Type = @"SubComponent",
                            Position = @"ADJ.15.8.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.9",
                            Type = @"Component",
                            Position = @"ADJ.15.9",
                            Name = @"Name Representation Code",
                            Length = 1,
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"ADJ.15.10",
                            Type = @"Component",
                            Position = @"ADJ.15.10",
                            Name = @"Organization Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V26SegmentADJ(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field providerAdjustmentNumber;

public HL7V26Field ProviderAdjustmentNumber
{
    get
    {
        if (providerAdjustmentNumber != null)
        {
            return providerAdjustmentNumber;
        }

        providerAdjustmentNumber = new HL7V26Field
        {
            field = message[@"ADJ"][1],
            Id = @"ADJ.1",
            Type = @"Field",
            Position = @"ADJ.1",
            Name = @"Provider Adjustment Number",
            Length = 73,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Unique Adjustment Number assigned by the Provider Application.",
            Sample = @"",
        };

        

        

        

        return providerAdjustmentNumber;
    } 
}
internal HL7V26Field payerAdjustmentNumber;

public HL7V26Field PayerAdjustmentNumber
{
    get
    {
        if (payerAdjustmentNumber != null)
        {
            return payerAdjustmentNumber;
        }

        payerAdjustmentNumber = new HL7V26Field
        {
            field = message[@"ADJ"][2],
            Id = @"ADJ.2",
            Type = @"Field",
            Position = @"ADJ.2",
            Name = @"Payer Adjustment Number",
            Length = 73,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Unique Adjustment Number assigned by the Payer Application.",
            Sample = @"",
        };

        

        

        

        return payerAdjustmentNumber;
    } 
}
internal HL7V26Field adjustmentSequenceNumber;

public HL7V26Field AdjustmentSequenceNumber
{
    get
    {
        if (adjustmentSequenceNumber != null)
        {
            return adjustmentSequenceNumber;
        }

        adjustmentSequenceNumber = new HL7V26Field
        {
            field = message[@"ADJ"][3],
            Id = @"ADJ.3",
            Type = @"Field",
            Position = @"ADJ.3",
            Name = @"Adjustment Sequence Number",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"Unique sequence number for this adjustment - starts with 1, then 2, etc., for each unique adjustment for the Product/Service Line Item.",
            Sample = @"",
        };

        

        

        

        return adjustmentSequenceNumber;
    } 
}
internal HL7V26Field adjustmentCategory;

public HL7V26Field AdjustmentCategory
{
    get
    {
        if (adjustmentCategory != null)
        {
            return adjustmentCategory;
        }

        adjustmentCategory = new HL7V26Field
        {
            field = message[@"ADJ"][4],
            Id = @"ADJ.4",
            Type = @"Field",
            Position = @"ADJ.4",
            Name = @"Adjustment Category",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0564",
            TableName = @"Adjustment Category Code",
            Description = @"Indicates the category of adjustment and is used to assist in determining which table is used for Adjustment Reason. Refer to User-defined Table 0564 - Adjustment Category Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return adjustmentCategory;
    } 
}
internal HL7V26Field adjustmentAmount;

public HL7V26Field AdjustmentAmount
{
    get
    {
        if (adjustmentAmount != null)
        {
            return adjustmentAmount;
        }

        adjustmentAmount = new HL7V26Field
        {
            field = message[@"ADJ"][5],
            Id = @"ADJ.5",
            Type = @"Field",
            Position = @"ADJ.5",
            Name = @"Adjustment Amount",
            Length = 254,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"Adjustment amount, such as taxes, deductibles, previously paid amount.",
            Sample = @"",
        };

        

        

        

        return adjustmentAmount;
    } 
}
internal HL7V26Field adjustmentQuantity;

public HL7V26Field AdjustmentQuantity
{
    get
    {
        if (adjustmentQuantity != null)
        {
            return adjustmentQuantity;
        }

        adjustmentQuantity = new HL7V26Field
        {
            field = message[@"ADJ"][6],
            Id = @"ADJ.6",
            Type = @"Field",
            Position = @"ADJ.6",
            Name = @"Adjustment Quantity",
            Length = 222,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"Adjustment quantity.",
            Sample = @"",
        };

        

        

        

        return adjustmentQuantity;
    } 
}
internal HL7V26Field adjustmentReasonPA;

public HL7V26Field AdjustmentReasonPA
{
    get
    {
        if (adjustmentReasonPA != null)
        {
            return adjustmentReasonPA;
        }

        adjustmentReasonPA = new HL7V26Field
        {
            field = message[@"ADJ"][7],
            Id = @"ADJ.7",
            Type = @"Field",
            Position = @"ADJ.7",
            Name = @"Adjustment Reason PA",
            Length = 211,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0565",
            TableName = @"Provider Adjustment Reason Code",
            Description = @"Reason for this adjustment. Codes used to explain a Provider adjustment to a Product/Service Group or Product/Service Line Item by a Provider. Refer to User-defined table 0565 - Provider Adjustment Reason Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return adjustmentReasonPA;
    } 
}
internal HL7V26Field adjustmentDescription;

public HL7V26Field AdjustmentDescription
{
    get
    {
        if (adjustmentDescription != null)
        {
            return adjustmentDescription;
        }

        adjustmentDescription = new HL7V26Field
        {
            field = message[@"ADJ"][8],
            Id = @"ADJ.8",
            Type = @"Field",
            Position = @"ADJ.8",
            Name = @"Adjustment Description",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Description of adjustment, such as client instructions.",
            Sample = @"",
        };

        

        

        

        return adjustmentDescription;
    } 
}
internal HL7V26Field originalValue;

public HL7V26Field OriginalValue
{
    get
    {
        if (originalValue != null)
        {
            return originalValue;
        }

        originalValue = new HL7V26Field
        {
            field = message[@"ADJ"][9],
            Id = @"ADJ.9",
            Type = @"Field",
            Position = @"ADJ.9",
            Name = @"Original Value",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Original value of data item noted in this adjustment.",
            Sample = @"",
        };

        

        

        

        return originalValue;
    } 
}
internal HL7V26Field substituteValue;

public HL7V26Field SubstituteValue
{
    get
    {
        if (substituteValue != null)
        {
            return substituteValue;
        }

        substituteValue = new HL7V26Field
        {
            field = message[@"ADJ"][10],
            Id = @"ADJ.10",
            Type = @"Field",
            Position = @"ADJ.10",
            Name = @"Substitute Value",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Substituted value of data item noted in this adjustment.",
            Sample = @"",
        };

        

        

        

        return substituteValue;
    } 
}
internal HL7V26Field adjustmentAction;

public HL7V26Field AdjustmentAction
{
    get
    {
        if (adjustmentAction != null)
        {
            return adjustmentAction;
        }

        adjustmentAction = new HL7V26Field
        {
            field = message[@"ADJ"][11],
            Id = @"ADJ.11",
            Type = @"Field",
            Position = @"ADJ.11",
            Name = @"Adjustment Action",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0569",
            TableName = @"Adjustment Action",
            Description = @"Action requested of party that receives this adjustment. Refer to User-defined Table 0569 - Adjustment Action for suggested values.",
            Sample = @"",
        };

        

        

        

        return adjustmentAction;
    } 
}
internal HL7V26Field providerAdjustmentNumberCrossReference;

public HL7V26Field ProviderAdjustmentNumberCrossReference
{
    get
    {
        if (providerAdjustmentNumberCrossReference != null)
        {
            return providerAdjustmentNumberCrossReference;
        }

        providerAdjustmentNumberCrossReference = new HL7V26Field
        {
            field = message[@"ADJ"][12],
            Id = @"ADJ.12",
            Type = @"Field",
            Position = @"ADJ.12",
            Name = @"Provider Adjustment Number Cross Reference",
            Length = 73,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Unique Provider Adjustment Number assigned by the Provider Application that is referenced by this Payer Adjustment.",
            Sample = @"",
        };

        

        

        

        return providerAdjustmentNumberCrossReference;
    } 
}
internal HL7V26Field providerProductServiceLineItemNumberCrossReference;

public HL7V26Field ProviderProductServiceLineItemNumberCrossReference
{
    get
    {
        if (providerProductServiceLineItemNumberCrossReference != null)
        {
            return providerProductServiceLineItemNumberCrossReference;
        }

        providerProductServiceLineItemNumberCrossReference = new HL7V26Field
        {
            field = message[@"ADJ"][13],
            Id = @"ADJ.13",
            Type = @"Field",
            Position = @"ADJ.13",
            Name = @"Provider Product/Service Line Item Number Cross Reference",
            Length = 73,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Unique Provider Product/Service Line Item Number assigned by the Provider Application that is referenced by this Payer Adjustment; used for groups with multiple line items that need to be singled out by a Payer Adjustment.",
            Sample = @"",
        };

        

        

        

        return providerProductServiceLineItemNumberCrossReference;
    } 
}
internal HL7V26Field adjustmentDate;

public HL7V26Field AdjustmentDate
{
    get
    {
        if (adjustmentDate != null)
        {
            return adjustmentDate;
        }

        adjustmentDate = new HL7V26Field
        {
            field = message[@"ADJ"][14],
            Id = @"ADJ.14",
            Type = @"Field",
            Position = @"ADJ.14",
            Name = @"Adjustment Date",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"Date/Time adjustment was made. May also be synonymous with Adjudication Date.",
            Sample = @"",
        };

        

        

        

        return adjustmentDate;
    } 
}
internal HL7V26Field responsibleOrganization;

public HL7V26Field ResponsibleOrganization
{
    get
    {
        if (responsibleOrganization != null)
        {
            return responsibleOrganization;
        }

        responsibleOrganization = new HL7V26Field
        {
            field = message[@"ADJ"][15],
            Id = @"ADJ.15",
            Type = @"Field",
            Position = @"ADJ.15",
            Name = @"Responsible Organization",
            Length = 183,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
            TableId = null,
            TableName = null,
            Description = @"Business organization that is responsible for the adjustment (e.g., Payer organization); can be used for a Payment/Remittance Advice for 1 Payee from multiple Payers.",
            Sample = @"",
        };

        

        

        

        return responsibleOrganization;
    } 
}

    }
}
