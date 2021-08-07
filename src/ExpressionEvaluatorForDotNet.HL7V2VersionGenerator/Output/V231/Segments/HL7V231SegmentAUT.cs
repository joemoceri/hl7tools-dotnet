using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentAUT
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"AUT"; } }

        public string SegmentId { get { return @"AUT"; } }
        
        public string LongName { get { return @"Authorization Information"; } }
        
        public string Description { get { return @"This segment represents an authorization or a pre-authorization for a referred procedure or requested service by the payor covering the patient's health care."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",
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
                            Id = @"AUT.1",
                            Type = @"Field",
                            Position = @"AUT.1",
                            Name = @"Authorizing Payor, Plan ID",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0072",
                            TableName = @"Insurance plan ID",
                            Description = @"This field contains the ID of the coverage plan authorizing treatment. Values should be entries in a locally-defined table of plan codes. User defined table 0072- Insurance Plan ID is used as the HL7 identifier for the user-defined table of values for this field. .",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AUT.1.1",
                            Type = @"Component",
                            Position = @"AUT.1.1",
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
                            Id = @"AUT.1.2",
                            Type = @"Component",
                            Position = @"AUT.1.2",
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
                            Id = @"AUT.1.3",
                            Type = @"Component",
                            Position = @"AUT.1.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.1.4",
                            Type = @"Component",
                            Position = @"AUT.1.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.1.5",
                            Type = @"Component",
                            Position = @"AUT.1.5",
                            Name = @"Alternate Text",
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
                            Id = @"AUT.1.6",
                            Type = @"Component",
                            Position = @"AUT.1.6",
                            Name = @"Name Of Alternate Coding System",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.2",
                            Type = @"Field",
                            Position = @"AUT.2",
                            Name = @"Authorizing Payor, Company ID",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0285",
                            TableName = @"Insurance company ID codes",
                            Description = @"This field contains the ID of the insurance company or other entity that administers the authorizing coverage plan. Values may be entries in a locally-defined table of payor codes. User defined Table 0285 - Insurance company ID codes, is used as the HL7 identifier for the user-defined table of values for this field.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AUT.2.1",
                            Type = @"Component",
                            Position = @"AUT.2.1",
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
                            Id = @"AUT.2.2",
                            Type = @"Component",
                            Position = @"AUT.2.2",
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
                            Id = @"AUT.2.3",
                            Type = @"Component",
                            Position = @"AUT.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.2.4",
                            Type = @"Component",
                            Position = @"AUT.2.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.2.5",
                            Type = @"Component",
                            Position = @"AUT.2.5",
                            Name = @"Alternate Text",
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
                            Id = @"AUT.2.6",
                            Type = @"Component",
                            Position = @"AUT.2.6",
                            Name = @"Name Of Alternate Coding System",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.3",
                            Type = @"Field",
                            Position = @"AUT.3",
                            Name = @"Authorizing Payor, Company Name",
                            Length = 45,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the insurance company or other entity that administers the authorizing coverage plan.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.4",
                            Type = @"Field",
                            Position = @"AUT.4",
                            Name = @"Authorization Effective Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the effective date of the authorization.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AUT.4.1",
                            Type = @"Component",
                            Position = @"AUT.4.1",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.5",
                            Type = @"Field",
                            Position = @"AUT.5",
                            Name = @"Authorization Expiration Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the expiration date after which the authorization to treat will no longer be in effect from the perspective of the coverage plan.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AUT.5.1",
                            Type = @"Component",
                            Position = @"AUT.5.1",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.6",
                            Type = @"Field",
                            Position = @"AUT.6",
                            Name = @"Authorization Identifier",
                            Length = 30,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the coverage application's permanent identifier assigned to track the authorization and all related billing documents. This field is conditionally required. It is not required when authorization information is being requested. However, it is required when this segment is contained in a message which is responding to a request and contains the authorization information. This is a composite field.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AUT.6.1",
                            Type = @"Component",
                            Position = @"AUT.6.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.6.2",
                            Type = @"Component",
                            Position = @"AUT.6.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.6.3",
                            Type = @"Component",
                            Position = @"AUT.6.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.6.4",
                            Type = @"Component",
                            Position = @"AUT.6.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7",
                            Type = @"Field",
                            Position = @"AUT.7",
                            Name = @"Reimbursement Limit",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the dollar limit for reimbursement specified by the coverage plan for the authorized treatment.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.1",
                            Type = @"Component",
                            Position = @"AUT.7.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"Subcomponents of price: <quantity> & <denomination>",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.1.1",
                            Type = @"SubComponent",
                            Position = @"AUT.7.1.1",
                            Name = @"Quantity",
                            Length = 0,
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
                            Id = @"AUT.7.1.2",
                            Type = @"SubComponent",
                            Position = @"AUT.7.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. Example:",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.2",
                            Type = @"Component",
                            Position = @"AUT.7.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.3",
                            Type = @"Component",
                            Position = @"AUT.7.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the range. The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.4",
                            Type = @"Component",
                            Position = @"AUT.7.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value> above.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.5",
                            Type = @"Component",
                            Position = @"AUT.7.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"Subcomponents of range units: <identifier (ID)> & <text (ST)> & <name of coding system (ST)> & <alternate identifier (ID)> & <alternate text (ST)> & <name of alternate coding system (ST)>",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.5.1",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.1",
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
                            Id = @"AUT.7.5.2",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.2",
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
                            Id = @"AUT.7.5.3",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.5.4",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.5.5",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.5",
                            Name = @"Alternate Text",
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
                            Id = @"AUT.7.5.6",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.6",
                            Name = @"Name Of Alternate Coding System",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.6",
                            Type = @"Component",
                            Position = @"AUT.7.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.8",
                            Type = @"Field",
                            Position = @"AUT.8",
                            Name = @"Requested Number of Treatments",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the requested number of times that the treatment may be administered to the patient without obtaining additional authorization.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.9",
                            Type = @"Field",
                            Position = @"AUT.9",
                            Name = @"Authorized Number of Treatments",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of times that the authorized treatment may be administered to the patient without obtaining additional authorization.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.10",
                            Type = @"Field",
                            Position = @"AUT.10",
                            Name = @"Process Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date that the authorization originated with the authorizing party.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AUT.10.1",
                            Type = @"Component",
                            Position = @"AUT.10.1",
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
                        
                        },
                        };
            }
        }

        public HL7V231SegmentAUT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field authorizingPayor,PlanID;

public HL7V231Field AuthorizingPayor,PlanID
{
    get
    {
        if (authorizingPayor,PlanID != null)
        {
            return authorizingPayor,PlanID;
        }

        authorizingPayor,PlanID = new HL7V231Field
        {
            field = message[@"AUT"][1],
            Id = @"AUT.1",
            Type = @"Field",
            Position = @"AUT.1",
            Name = @"Authorizing Payor, Plan ID",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0072",
            TableName = @"Insurance plan ID",
            Description = @"This field contains the ID of the coverage plan authorizing treatment. Values should be entries in a locally-defined table of plan codes. User defined table 0072- Insurance Plan ID is used as the HL7 identifier for the user-defined table of values for this field. .",
            Sample = @"",
        };

        

        

        

        return authorizingPayor,PlanID;
    } 
}
internal HL7V231Field authorizingPayor,CompanyID;

public HL7V231Field AuthorizingPayor,CompanyID
{
    get
    {
        if (authorizingPayor,CompanyID != null)
        {
            return authorizingPayor,CompanyID;
        }

        authorizingPayor,CompanyID = new HL7V231Field
        {
            field = message[@"AUT"][2],
            Id = @"AUT.2",
            Type = @"Field",
            Position = @"AUT.2",
            Name = @"Authorizing Payor, Company ID",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0285",
            TableName = @"Insurance company ID codes",
            Description = @"This field contains the ID of the insurance company or other entity that administers the authorizing coverage plan. Values may be entries in a locally-defined table of payor codes. User defined Table 0285 - Insurance company ID codes, is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
        };

        

        

        

        return authorizingPayor,CompanyID;
    } 
}
internal HL7V231Field authorizingPayor,CompanyName;

public HL7V231Field AuthorizingPayor,CompanyName
{
    get
    {
        if (authorizingPayor,CompanyName != null)
        {
            return authorizingPayor,CompanyName;
        }

        authorizingPayor,CompanyName = new HL7V231Field
        {
            field = message[@"AUT"][3],
            Id = @"AUT.3",
            Type = @"Field",
            Position = @"AUT.3",
            Name = @"Authorizing Payor, Company Name",
            Length = 45,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the insurance company or other entity that administers the authorizing coverage plan.",
            Sample = @"",
        };

        

        

        

        return authorizingPayor,CompanyName;
    } 
}
internal HL7V231Field authorizationEffectiveDate;

public HL7V231Field AuthorizationEffectiveDate
{
    get
    {
        if (authorizationEffectiveDate != null)
        {
            return authorizationEffectiveDate;
        }

        authorizationEffectiveDate = new HL7V231Field
        {
            field = message[@"AUT"][4],
            Id = @"AUT.4",
            Type = @"Field",
            Position = @"AUT.4",
            Name = @"Authorization Effective Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the effective date of the authorization.",
            Sample = @"",
        };

        

        

        

        return authorizationEffectiveDate;
    } 
}
internal HL7V231Field authorizationExpirationDate;

public HL7V231Field AuthorizationExpirationDate
{
    get
    {
        if (authorizationExpirationDate != null)
        {
            return authorizationExpirationDate;
        }

        authorizationExpirationDate = new HL7V231Field
        {
            field = message[@"AUT"][5],
            Id = @"AUT.5",
            Type = @"Field",
            Position = @"AUT.5",
            Name = @"Authorization Expiration Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date after which the authorization to treat will no longer be in effect from the perspective of the coverage plan.",
            Sample = @"",
        };

        

        

        

        return authorizationExpirationDate;
    } 
}
internal HL7V231Field authorizationIdentifier;

public HL7V231Field AuthorizationIdentifier
{
    get
    {
        if (authorizationIdentifier != null)
        {
            return authorizationIdentifier;
        }

        authorizationIdentifier = new HL7V231Field
        {
            field = message[@"AUT"][6],
            Id = @"AUT.6",
            Type = @"Field",
            Position = @"AUT.6",
            Name = @"Authorization Identifier",
            Length = 30,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the coverage application's permanent identifier assigned to track the authorization and all related billing documents. This field is conditionally required. It is not required when authorization information is being requested. However, it is required when this segment is contained in a message which is responding to a request and contains the authorization information. This is a composite field.",
            Sample = @"",
        };

        

        

        

        return authorizationIdentifier;
    } 
}
internal HL7V231Field reimbursementLimit;

public HL7V231Field ReimbursementLimit
{
    get
    {
        if (reimbursementLimit != null)
        {
            return reimbursementLimit;
        }

        reimbursementLimit = new HL7V231Field
        {
            field = message[@"AUT"][7],
            Id = @"AUT.7",
            Type = @"Field",
            Position = @"AUT.7",
            Name = @"Reimbursement Limit",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the dollar limit for reimbursement specified by the coverage plan for the authorized treatment.",
            Sample = @"",
        };

        

        

        

        return reimbursementLimit;
    } 
}
internal HL7V231Field requestedNumberofTreatments;

public HL7V231Field RequestedNumberofTreatments
{
    get
    {
        if (requestedNumberofTreatments != null)
        {
            return requestedNumberofTreatments;
        }

        requestedNumberofTreatments = new HL7V231Field
        {
            field = message[@"AUT"][8],
            Id = @"AUT.8",
            Type = @"Field",
            Position = @"AUT.8",
            Name = @"Requested Number of Treatments",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the requested number of times that the treatment may be administered to the patient without obtaining additional authorization.",
            Sample = @"",
        };

        

        

        

        return requestedNumberofTreatments;
    } 
}
internal HL7V231Field authorizedNumberofTreatments;

public HL7V231Field AuthorizedNumberofTreatments
{
    get
    {
        if (authorizedNumberofTreatments != null)
        {
            return authorizedNumberofTreatments;
        }

        authorizedNumberofTreatments = new HL7V231Field
        {
            field = message[@"AUT"][9],
            Id = @"AUT.9",
            Type = @"Field",
            Position = @"AUT.9",
            Name = @"Authorized Number of Treatments",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of times that the authorized treatment may be administered to the patient without obtaining additional authorization.",
            Sample = @"",
        };

        

        

        

        return authorizedNumberofTreatments;
    } 
}
internal HL7V231Field processDate;

public HL7V231Field ProcessDate
{
    get
    {
        if (processDate != null)
        {
            return processDate;
        }

        processDate = new HL7V231Field
        {
            field = message[@"AUT"][10],
            Id = @"AUT.10",
            Type = @"Field",
            Position = @"AUT.10",
            Name = @"Process Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the authorization originated with the authorizing party.",
            Sample = @"",
        };

        

        

        

        return processDate;
    } 
}

    }
}
