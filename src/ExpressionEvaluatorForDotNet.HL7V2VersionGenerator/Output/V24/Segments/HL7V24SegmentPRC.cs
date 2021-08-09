using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentPRC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PRC"; } }

        public string SegmentId { get { return @"PRC"; } }
        
        public string LongName { get { return @"Pricing"; } }
        
        public string Description { get { return @"The PRC segment contains the pricing information for the preceding CDM segment’s chargeable item.  It contains the fields which, for the same chargeable item, might vary depending upon facility or department or patient type.  The preceding CDM segment contains the fields which, for one chargeable item, remain the same across facilities, departments, and patient types. 

The Technical Steward for the PRC segment is PAFM."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRC.1",
                            Type = @"Field",
                            Position = @"PRC.1",
                            Name = @"Primary Key Value - PRC",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0132",
                            TableName = @"Transaction code",
                            Description = @"This field contains the code assigned by the institution for the purpose of uniquely identifying the thing that can be charged. The key field of the entry. For example, this field would be used to uniquely identify a procedure, item, or test for charging purposes. Probably the same set of values as used in FT1-7 - Transaction code in financial messages. Must match MFE-4 - Primary key - MFE andCDM-1 - Primary key - CDM. Refer to User-defined Table 0132 - Transaction code for suggested values. See Chapter 7 for discussion of the universal service ID.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.1.1",
                            Type = @"Component",
                            Position = @"PRC.1.1",
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
                            Id = @"PRC.1.2",
                            Type = @"Component",
                            Position = @"PRC.1.2",
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
                            Id = @"PRC.1.3",
                            Type = @"Component",
                            Position = @"PRC.1.3",
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
                            Id = @"PRC.1.4",
                            Type = @"Component",
                            Position = @"PRC.1.4",
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
                            Id = @"PRC.1.5",
                            Type = @"Component",
                            Position = @"PRC.1.5",
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
                            Id = @"PRC.1.6",
                            Type = @"Component",
                            Position = @"PRC.1.6",
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
                            Id = @"PRC.2",
                            Type = @"Field",
                            Position = @"PRC.2",
                            Name = @"Facility ID - PRC",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0464",
                            TableName = @"Facility ID",
                            Description = @"This field contains the facility of the institution for which this price (for the preceding CDM entry) is valid. For use when needing multi-facility pricing. If null, assume all facilities. In a multi-facility environment, the facility associated with this chargeable item may not be the same as the sending or receiving facility identified in the MSH segment. Use only when the price is not the same for all facilities, that is, a null value indicates that this pricing is valid for all facilities.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.2.1",
                            Type = @"Component",
                            Position = @"PRC.2.1",
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
                            Id = @"PRC.2.2",
                            Type = @"Component",
                            Position = @"PRC.2.2",
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
                            Id = @"PRC.2.3",
                            Type = @"Component",
                            Position = @"PRC.2.3",
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
                            Id = @"PRC.2.4",
                            Type = @"Component",
                            Position = @"PRC.2.4",
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
                            Id = @"PRC.2.5",
                            Type = @"Component",
                            Position = @"PRC.2.5",
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
                            Id = @"PRC.2.6",
                            Type = @"Component",
                            Position = @"PRC.2.6",
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
                            Id = @"PRC.3",
                            Type = @"Field",
                            Position = @"PRC.3",
                            Name = @"Department",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0184",
                            TableName = @"Department",
                            Description = @"This field contains the department of the facility which accrues revenue/cost for this type of charge. When pricing is different for different departments within the same facility, this will indicate for which department the following pricing information is valid. Use only when the price is not the same for all departments, that is, a null value indicates that this pricing is valid for all departments.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.3.1",
                            Type = @"Component",
                            Position = @"PRC.3.1",
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
                            Id = @"PRC.3.2",
                            Type = @"Component",
                            Position = @"PRC.3.2",
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
                            Id = @"PRC.3.3",
                            Type = @"Component",
                            Position = @"PRC.3.3",
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
                            Id = @"PRC.3.4",
                            Type = @"Component",
                            Position = @"PRC.3.4",
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
                            Id = @"PRC.3.5",
                            Type = @"Component",
                            Position = @"PRC.3.5",
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
                            Id = @"PRC.3.6",
                            Type = @"Component",
                            Position = @"PRC.3.6",
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
                            Id = @"PRC.4",
                            Type = @"Field",
                            Position = @"PRC.4",
                            Name = @"Valid Patient Classes",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0004",
                            TableName = @"Patient class",
                            Description = @"This field contains the patient types for which this charge description is valid. For example, Inpatient, Outpatient, Series, Clinic, ER, Ambulatory, Observation, etc. These values should be the same set of values as those used for PV1-3 - Patient class, which is site defined. Use only when the price is not valid for all patient types, that is, a null value indicates that this pricing is valid for all patient classes. Refer to User-defined Table 0004 - Patient class for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.5",
                            Type = @"Field",
                            Position = @"PRC.5",
                            Name = @"Price",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the price to be charged for service, item, or procedure. If CDM price will always be overridden when charges are posted, then this field is optional. Otherwise, price would be a required field. The formula or calculation that is to be used to get total price from these price components is left to implementation negotiations agreed upon by the participating institutions. See Chapter 2, Section 2.8.8, ""CP - composite price,"" for a description of the use of the composite price (CP) data type.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.5.1",
                            Type = @"Component",
                            Position = @"PRC.5.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.9.26, MO - money) is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.5.1.1",
                            Type = @"SubComponent",
                            Position = @"PRC.5.1.1",
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
                            Id = @"PRC.5.1.2",
                            Type = @"SubComponent",
                            Position = @"PRC.5.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. 

Example:
|99.50^USD|

where USD is the ISO 4217 code for the U.S. American dollar.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.5.2",
                            Type = @"Component",
                            Position = @"PRC.5.2",
                            Name = @"Price Type",
                            Length = 0,
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
                            Id = @"PRC.5.3",
                            Type = @"Component",
                            Position = @"PRC.5.3",
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
                            Id = @"PRC.5.4",
                            Type = @"Component",
                            Position = @"PRC.5.4",
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
                            Id = @"PRC.5.5",
                            Type = @"Component",
                            Position = @"PRC.5.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and  <to value> are present.

Subcomponents of range units: <identifier (ST)> & <text (ST)> & <name of coding system (IS)> & <alternate identifier (ST)> & <alternate text (ST)> & <name of alternate coding system (IS)>",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.5.5.1",
                            Type = @"SubComponent",
                            Position = @"PRC.5.5.1",
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
                            Id = @"PRC.5.5.2",
                            Type = @"SubComponent",
                            Position = @"PRC.5.5.2",
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
                            Id = @"PRC.5.5.3",
                            Type = @"SubComponent",
                            Position = @"PRC.5.5.3",
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
                            Id = @"PRC.5.5.4",
                            Type = @"SubComponent",
                            Position = @"PRC.5.5.4",
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
                            Id = @"PRC.5.5.5",
                            Type = @"SubComponent",
                            Position = @"PRC.5.5.5",
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
                            Id = @"PRC.5.5.6",
                            Type = @"SubComponent",
                            Position = @"PRC.5.5.6",
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
                            Id = @"PRC.5.6",
                            Type = @"Component",
                            Position = @"PRC.5.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 Table 0298 - CP range type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.6",
                            Type = @"Field",
                            Position = @"PRC.6",
                            Name = @"Formula",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the mathematical formula to apply to PRC-5 - Price in order to compute total price. The syntax of this formula must conform to Arden Syntax rules.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.7",
                            Type = @"Field",
                            Position = @"PRC.7",
                            Name = @"Minimum Quantity",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the minimum number of identical charges allowed on one patient account for this CDM entry.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.8",
                            Type = @"Field",
                            Position = @"PRC.8",
                            Name = @"Maximum Quantity",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the maximum number of identical charges allowed on one patient account for this CDM entry.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.9",
                            Type = @"Field",
                            Position = @"PRC.9",
                            Name = @"Minimum Price",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the minimum total price (after computation of components of price) that can be charged for this item.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.9.1",
                            Type = @"Component",
                            Position = @"PRC.9.1",
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
                            Id = @"PRC.9.2",
                            Type = @"Component",
                            Position = @"PRC.9.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. 

Example:
|99.50^USD|

where USD is the ISO 4217 code for the U.S. American dollar.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.10",
                            Type = @"Field",
                            Position = @"PRC.10",
                            Name = @"Maximum Price",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the maximum total price (after computation of components of price) that can be charged for this item.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.10.1",
                            Type = @"Component",
                            Position = @"PRC.10.1",
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
                            Id = @"PRC.10.2",
                            Type = @"Component",
                            Position = @"PRC.10.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. 

Example:
|99.50^USD|

where USD is the ISO 4217 code for the U.S. American dollar.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.11",
                            Type = @"Field",
                            Position = @"PRC.11",
                            Name = @"Effective Start Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time when this CDM entry becomes effective.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.11.1",
                            Type = @"Component",
                            Position = @"PRC.11.1",
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
                            Id = @"PRC.11.2",
                            Type = @"Component",
                            Position = @"PRC.11.2",
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
                            Id = @"PRC.12",
                            Type = @"Field",
                            Position = @"PRC.12",
                            Name = @"Effective End Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time when this CDM entry is no longer effective.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.12.1",
                            Type = @"Component",
                            Position = @"PRC.12.1",
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
                            Id = @"PRC.12.2",
                            Type = @"Component",
                            Position = @"PRC.12.2",
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
                            Id = @"PRC.13",
                            Type = @"Field",
                            Position = @"PRC.13",
                            Name = @"Price Override Flag",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0268",
                            TableName = @"Override",
                            Description = @"This field indicates whether this CDM entrys price can be overridden. Refer to User-defined Table 0268 - Override for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.14",
                            Type = @"Field",
                            Position = @"PRC.14",
                            Name = @"Billing Category",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0293",
                            TableName = @"Billing category",
                            Description = @"This field contains the billing category codes for any classification systems needed, for example, general ledger codes and UB92 categories. Repeating field with coded entry made up of category code plus category system. Refer to User-defined Table 0293 - Billing category for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.14.1",
                            Type = @"Component",
                            Position = @"PRC.14.1",
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
                            Id = @"PRC.14.2",
                            Type = @"Component",
                            Position = @"PRC.14.2",
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
                            Id = @"PRC.14.3",
                            Type = @"Component",
                            Position = @"PRC.14.3",
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
                            Id = @"PRC.14.4",
                            Type = @"Component",
                            Position = @"PRC.14.4",
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
                            Id = @"PRC.14.5",
                            Type = @"Component",
                            Position = @"PRC.14.5",
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
                            Id = @"PRC.14.6",
                            Type = @"Component",
                            Position = @"PRC.14.6",
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
                            Id = @"PRC.15",
                            Type = @"Field",
                            Position = @"PRC.15",
                            Name = @"Chargeable Flag",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field contains a chargeable indicator. Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.16",
                            Type = @"Field",
                            Position = @"PRC.16",
                            Name = @"Active/Inactive Flag",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0183",
                            TableName = @"Active/inactive",
                            Description = @"This indicates whether this is a usable CDM entry. Refer to HL7 Table 0183 - Active/inactive for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.17",
                            Type = @"Field",
                            Position = @"PRC.17",
                            Name = @"Cost",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the institutions calculation of how much it costs to provide this item, that is, what the institution had to pay for the material plus any specified payment expenditure, effort or loss due to performing or providing the chargeable item.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRC.17.1",
                            Type = @"Component",
                            Position = @"PRC.17.1",
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
                            Id = @"PRC.17.2",
                            Type = @"Component",
                            Position = @"PRC.17.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. 

Example:
|99.50^USD|

where USD is the ISO 4217 code for the U.S. American dollar.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRC.18",
                            Type = @"Field",
                            Position = @"PRC.18",
                            Name = @"Charge On Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0269",
                            TableName = @"Charge on indicator",
                            Description = @"This field contains the user-defined table of values which indicates when a charge for services or procedures should be accrued. Refer to User-defined Table 0269 - Charge on indicator for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentPRC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field primaryKeyValuePRC;

public HL7V24Field PrimaryKeyValuePRC
{
    get
    {
        if (primaryKeyValuePRC != null)
        {
            return primaryKeyValuePRC;
        }

        primaryKeyValuePRC = new HL7V24Field
        {
            field = message[@"PRC"][1],
            Id = @"PRC.1",
            Type = @"Field",
            Position = @"PRC.1",
            Name = @"Primary Key Value - PRC",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0132",
            TableName = @"Transaction code",
            Description = @"This field contains the code assigned by the institution for the purpose of uniquely identifying the thing that can be charged. The key field of the entry. For example, this field would be used to uniquely identify a procedure, item, or test for charging purposes. Probably the same set of values as used in FT1-7 - Transaction code in financial messages. Must match MFE-4 - Primary key - MFE andCDM-1 - Primary key - CDM. Refer to User-defined Table 0132 - Transaction code for suggested values. See Chapter 7 for discussion of the universal service ID.",
            Sample = @"",
        };

        // check for repetitions
        if (primaryKeyValuePRC.field.FieldRepetitions != null && primaryKeyValuePRC.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryKeyValuePRC.Id));
            primaryKeyValuePRC.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(primaryKeyValuePRC, fieldData);
        }

        return primaryKeyValuePRC;
    } 
}

internal HL7V24Field facilityIDPRC;

public HL7V24Field FacilityIDPRC
{
    get
    {
        if (facilityIDPRC != null)
        {
            return facilityIDPRC;
        }

        facilityIDPRC = new HL7V24Field
        {
            field = message[@"PRC"][2],
            Id = @"PRC.2",
            Type = @"Field",
            Position = @"PRC.2",
            Name = @"Facility ID - PRC",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0464",
            TableName = @"Facility ID",
            Description = @"This field contains the facility of the institution for which this price (for the preceding CDM entry) is valid. For use when needing multi-facility pricing. If null, assume all facilities. In a multi-facility environment, the facility associated with this chargeable item may not be the same as the sending or receiving facility identified in the MSH segment. Use only when the price is not the same for all facilities, that is, a null value indicates that this pricing is valid for all facilities.",
            Sample = @"",
        };

        // check for repetitions
        if (facilityIDPRC.field.FieldRepetitions != null && facilityIDPRC.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(facilityIDPRC.Id));
            facilityIDPRC.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(facilityIDPRC, fieldData);
        }

        return facilityIDPRC;
    } 
}

internal HL7V24Field department;

public HL7V24Field Department
{
    get
    {
        if (department != null)
        {
            return department;
        }

        department = new HL7V24Field
        {
            field = message[@"PRC"][3],
            Id = @"PRC.3",
            Type = @"Field",
            Position = @"PRC.3",
            Name = @"Department",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0184",
            TableName = @"Department",
            Description = @"This field contains the department of the facility which accrues revenue/cost for this type of charge. When pricing is different for different departments within the same facility, this will indicate for which department the following pricing information is valid. Use only when the price is not the same for all departments, that is, a null value indicates that this pricing is valid for all departments.",
            Sample = @"",
        };

        // check for repetitions
        if (department.field.FieldRepetitions != null && department.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(department.Id));
            department.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(department, fieldData);
        }

        return department;
    } 
}

internal HL7V24Field validPatientClasses;

public HL7V24Field ValidPatientClasses
{
    get
    {
        if (validPatientClasses != null)
        {
            return validPatientClasses;
        }

        validPatientClasses = new HL7V24Field
        {
            field = message[@"PRC"][4],
            Id = @"PRC.4",
            Type = @"Field",
            Position = @"PRC.4",
            Name = @"Valid Patient Classes",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0004",
            TableName = @"Patient class",
            Description = @"This field contains the patient types for which this charge description is valid. For example, Inpatient, Outpatient, Series, Clinic, ER, Ambulatory, Observation, etc. These values should be the same set of values as those used for PV1-3 - Patient class, which is site defined. Use only when the price is not valid for all patient types, that is, a null value indicates that this pricing is valid for all patient classes. Refer to User-defined Table 0004 - Patient class for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (validPatientClasses.field.FieldRepetitions != null && validPatientClasses.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(validPatientClasses.Id));
            validPatientClasses.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(validPatientClasses, fieldData);
        }

        return validPatientClasses;
    } 
}

internal HL7V24Field price;

public HL7V24Field Price
{
    get
    {
        if (price != null)
        {
            return price;
        }

        price = new HL7V24Field
        {
            field = message[@"PRC"][5],
            Id = @"PRC.5",
            Type = @"Field",
            Position = @"PRC.5",
            Name = @"Price",
            Length = 12,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the price to be charged for service, item, or procedure. If CDM price will always be overridden when charges are posted, then this field is optional. Otherwise, price would be a required field. The formula or calculation that is to be used to get total price from these price components is left to implementation negotiations agreed upon by the participating institutions. See Chapter 2, Section 2.8.8, ""CP - composite price,"" for a description of the use of the composite price (CP) data type.",
            Sample = @"",
        };

        // check for repetitions
        if (price.field.FieldRepetitions != null && price.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(price.Id));
            price.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(price, fieldData);
        }

        return price;
    } 
}

internal HL7V24Field formula;

public HL7V24Field Formula
{
    get
    {
        if (formula != null)
        {
            return formula;
        }

        formula = new HL7V24Field
        {
            field = message[@"PRC"][6],
            Id = @"PRC.6",
            Type = @"Field",
            Position = @"PRC.6",
            Name = @"Formula",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the mathematical formula to apply to PRC-5 - Price in order to compute total price. The syntax of this formula must conform to Arden Syntax rules.",
            Sample = @"",
        };

        // check for repetitions
        if (formula.field.FieldRepetitions != null && formula.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(formula.Id));
            formula.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(formula, fieldData);
        }

        return formula;
    } 
}

internal HL7V24Field minimumQuantity;

public HL7V24Field MinimumQuantity
{
    get
    {
        if (minimumQuantity != null)
        {
            return minimumQuantity;
        }

        minimumQuantity = new HL7V24Field
        {
            field = message[@"PRC"][7],
            Id = @"PRC.7",
            Type = @"Field",
            Position = @"PRC.7",
            Name = @"Minimum Quantity",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the minimum number of identical charges allowed on one patient account for this CDM entry.",
            Sample = @"",
        };

        // check for repetitions
        if (minimumQuantity.field.FieldRepetitions != null && minimumQuantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(minimumQuantity.Id));
            minimumQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(minimumQuantity, fieldData);
        }

        return minimumQuantity;
    } 
}

internal HL7V24Field maximumQuantity;

public HL7V24Field MaximumQuantity
{
    get
    {
        if (maximumQuantity != null)
        {
            return maximumQuantity;
        }

        maximumQuantity = new HL7V24Field
        {
            field = message[@"PRC"][8],
            Id = @"PRC.8",
            Type = @"Field",
            Position = @"PRC.8",
            Name = @"Maximum Quantity",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the maximum number of identical charges allowed on one patient account for this CDM entry.",
            Sample = @"",
        };

        // check for repetitions
        if (maximumQuantity.field.FieldRepetitions != null && maximumQuantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(maximumQuantity.Id));
            maximumQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(maximumQuantity, fieldData);
        }

        return maximumQuantity;
    } 
}

internal HL7V24Field minimumPrice;

public HL7V24Field MinimumPrice
{
    get
    {
        if (minimumPrice != null)
        {
            return minimumPrice;
        }

        minimumPrice = new HL7V24Field
        {
            field = message[@"PRC"][9],
            Id = @"PRC.9",
            Type = @"Field",
            Position = @"PRC.9",
            Name = @"Minimum Price",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"MO",
            DataTypeName = @"Money",
            TableId = null,
            TableName = null,
            Description = @"This field contains the minimum total price (after computation of components of price) that can be charged for this item.",
            Sample = @"",
        };

        // check for repetitions
        if (minimumPrice.field.FieldRepetitions != null && minimumPrice.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(minimumPrice.Id));
            minimumPrice.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(minimumPrice, fieldData);
        }

        return minimumPrice;
    } 
}

internal HL7V24Field maximumPrice;

public HL7V24Field MaximumPrice
{
    get
    {
        if (maximumPrice != null)
        {
            return maximumPrice;
        }

        maximumPrice = new HL7V24Field
        {
            field = message[@"PRC"][10],
            Id = @"PRC.10",
            Type = @"Field",
            Position = @"PRC.10",
            Name = @"Maximum Price",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"MO",
            DataTypeName = @"Money",
            TableId = null,
            TableName = null,
            Description = @"This field contains the maximum total price (after computation of components of price) that can be charged for this item.",
            Sample = @"",
        };

        // check for repetitions
        if (maximumPrice.field.FieldRepetitions != null && maximumPrice.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(maximumPrice.Id));
            maximumPrice.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(maximumPrice, fieldData);
        }

        return maximumPrice;
    } 
}

internal HL7V24Field effectiveStartDate;

public HL7V24Field EffectiveStartDate
{
    get
    {
        if (effectiveStartDate != null)
        {
            return effectiveStartDate;
        }

        effectiveStartDate = new HL7V24Field
        {
            field = message[@"PRC"][11],
            Id = @"PRC.11",
            Type = @"Field",
            Position = @"PRC.11",
            Name = @"Effective Start Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time when this CDM entry becomes effective.",
            Sample = @"",
        };

        // check for repetitions
        if (effectiveStartDate.field.FieldRepetitions != null && effectiveStartDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(effectiveStartDate.Id));
            effectiveStartDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(effectiveStartDate, fieldData);
        }

        return effectiveStartDate;
    } 
}

internal HL7V24Field effectiveEndDate;

public HL7V24Field EffectiveEndDate
{
    get
    {
        if (effectiveEndDate != null)
        {
            return effectiveEndDate;
        }

        effectiveEndDate = new HL7V24Field
        {
            field = message[@"PRC"][12],
            Id = @"PRC.12",
            Type = @"Field",
            Position = @"PRC.12",
            Name = @"Effective End Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time when this CDM entry is no longer effective.",
            Sample = @"",
        };

        // check for repetitions
        if (effectiveEndDate.field.FieldRepetitions != null && effectiveEndDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(effectiveEndDate.Id));
            effectiveEndDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(effectiveEndDate, fieldData);
        }

        return effectiveEndDate;
    } 
}

internal HL7V24Field priceOverrideFlag;

public HL7V24Field PriceOverrideFlag
{
    get
    {
        if (priceOverrideFlag != null)
        {
            return priceOverrideFlag;
        }

        priceOverrideFlag = new HL7V24Field
        {
            field = message[@"PRC"][13],
            Id = @"PRC.13",
            Type = @"Field",
            Position = @"PRC.13",
            Name = @"Price Override Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0268",
            TableName = @"Override",
            Description = @"This field indicates whether this CDM entrys price can be overridden. Refer to User-defined Table 0268 - Override for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (priceOverrideFlag.field.FieldRepetitions != null && priceOverrideFlag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(priceOverrideFlag.Id));
            priceOverrideFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(priceOverrideFlag, fieldData);
        }

        return priceOverrideFlag;
    } 
}

internal HL7V24Field billingCategory;

public HL7V24Field BillingCategory
{
    get
    {
        if (billingCategory != null)
        {
            return billingCategory;
        }

        billingCategory = new HL7V24Field
        {
            field = message[@"PRC"][14],
            Id = @"PRC.14",
            Type = @"Field",
            Position = @"PRC.14",
            Name = @"Billing Category",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0293",
            TableName = @"Billing category",
            Description = @"This field contains the billing category codes for any classification systems needed, for example, general ledger codes and UB92 categories. Repeating field with coded entry made up of category code plus category system. Refer to User-defined Table 0293 - Billing category for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (billingCategory.field.FieldRepetitions != null && billingCategory.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(billingCategory.Id));
            billingCategory.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(billingCategory, fieldData);
        }

        return billingCategory;
    } 
}

internal HL7V24Field chargeableFlag;

public HL7V24Field ChargeableFlag
{
    get
    {
        if (chargeableFlag != null)
        {
            return chargeableFlag;
        }

        chargeableFlag = new HL7V24Field
        {
            field = message[@"PRC"][15],
            Id = @"PRC.15",
            Type = @"Field",
            Position = @"PRC.15",
            Name = @"Chargeable Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains a chargeable indicator. Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (chargeableFlag.field.FieldRepetitions != null && chargeableFlag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(chargeableFlag.Id));
            chargeableFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(chargeableFlag, fieldData);
        }

        return chargeableFlag;
    } 
}

internal HL7V24Field activeInactiveFlag;

public HL7V24Field ActiveInactiveFlag
{
    get
    {
        if (activeInactiveFlag != null)
        {
            return activeInactiveFlag;
        }

        activeInactiveFlag = new HL7V24Field
        {
            field = message[@"PRC"][16],
            Id = @"PRC.16",
            Type = @"Field",
            Position = @"PRC.16",
            Name = @"Active/Inactive Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0183",
            TableName = @"Active/inactive",
            Description = @"This indicates whether this is a usable CDM entry. Refer to HL7 Table 0183 - Active/inactive for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (activeInactiveFlag.field.FieldRepetitions != null && activeInactiveFlag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(activeInactiveFlag.Id));
            activeInactiveFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(activeInactiveFlag, fieldData);
        }

        return activeInactiveFlag;
    } 
}

internal HL7V24Field cost;

public HL7V24Field Cost
{
    get
    {
        if (cost != null)
        {
            return cost;
        }

        cost = new HL7V24Field
        {
            field = message[@"PRC"][17],
            Id = @"PRC.17",
            Type = @"Field",
            Position = @"PRC.17",
            Name = @"Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"MO",
            DataTypeName = @"Money",
            TableId = null,
            TableName = null,
            Description = @"This field contains the institutions calculation of how much it costs to provide this item, that is, what the institution had to pay for the material plus any specified payment expenditure, effort or loss due to performing or providing the chargeable item.",
            Sample = @"",
        };

        // check for repetitions
        if (cost.field.FieldRepetitions != null && cost.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(cost.Id));
            cost.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(cost, fieldData);
        }

        return cost;
    } 
}

internal HL7V24Field chargeOnIndicator;

public HL7V24Field ChargeOnIndicator
{
    get
    {
        if (chargeOnIndicator != null)
        {
            return chargeOnIndicator;
        }

        chargeOnIndicator = new HL7V24Field
        {
            field = message[@"PRC"][18],
            Id = @"PRC.18",
            Type = @"Field",
            Position = @"PRC.18",
            Name = @"Charge On Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0269",
            TableName = @"Charge on indicator",
            Description = @"This field contains the user-defined table of values which indicates when a charge for services or procedures should be accrued. Refer to User-defined Table 0269 - Charge on indicator for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (chargeOnIndicator.field.FieldRepetitions != null && chargeOnIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(chargeOnIndicator.Id));
            chargeOnIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(chargeOnIndicator, fieldData);
        }

        return chargeOnIndicator;
    } 
}
    }
}
