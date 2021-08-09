using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentRXO
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RXO"; } }

        public string SegmentId { get { return @"RXO"; } }
        
        public string LongName { get { return @"Pharmacy Prescription Order"; } }
        
        public string Description { get { return @"This is the ""master"" pharmacy order segment.  It contains order data not specific to components or additives.  Unlike the OBR, it does not contain status fields or other data that are results-only.

It can be used for any type of pharmacy order, including inpatient (unit dose and compound unit dose), outpatient, IVs, and hyperalimentation IVs (nutritional IVs).  
 
In addition to the pharmaceutical information, this segment contains additional data such as provider and text comments."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.1",
                            Type = @"Field",
                            Position = @"RXO.1",
                            Name = @"Requested Give Code",
                            Length = 100,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"identifier of the medical substance ordered to be given to the patient; it is equivalent to OBR-4-universal service ID code in function.  The request-to-dispense fields, which define the type and amount of what is to be issued to the patient (see RXO-10 requested dispense code, RXO-11-requested dispense amount, and RXO-12-requested dispense units) do not necessarily correlate with the instructions of what amount is to be ""given"" or administered with each dose, and may or may not be specified with the order.  For example, the ""give"" part of the order may convey the field-representation of give 15 mg of librium every 6 hours, while the request to dispense part of the order may convey issue 30 tablets of 10 MG generic equivalent for this outpatient prescription.  When the give code does not include the dosage form, use RXO-5-requested dosage form.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.1.1",
                            Type = @"Component",
                            Position = @"RXO.1.1",
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
                            Id = @"RXO.1.2",
                            Type = @"Component",
                            Position = @"RXO.1.2",
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
                            Id = @"RXO.1.3",
                            Type = @"Component",
                            Position = @"RXO.1.3",
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
                            Id = @"RXO.1.4",
                            Type = @"Component",
                            Position = @"RXO.1.4",
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
                            Id = @"RXO.1.5",
                            Type = @"Component",
                            Position = @"RXO.1.5",
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
                            Id = @"RXO.1.6",
                            Type = @"Component",
                            Position = @"RXO.1.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.2",
                            Type = @"Field",
                            Position = @"RXO.2",
                            Name = @"Requested Give Amount - Minimum",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"ordered amount.  In a variable dose order, this is the minimum ordered amount.  In a nonvarying dose order, this is the exact amount of the order

Note:This field is not a duplication of the first component of the quantity/timing field, since in non-Pharmacy orders, that component can be used to specify multiples of an ordered amount. 
 
Another way to say this is that, for pharmacy orders, the quantity component of the quantity/timing field refers to what is to be given out at each service interval; thus, in terms of the RX order, that first component always defaults to 1.  Hence, in the actual execution of the order, the value of 1 in the first component of the quantity/timing field always refers to one administration of the amount specified in this field (the Requested Give Amount field). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.3",
                            Type = @"Field",
                            Position = @"RXO.3",
                            Name = @"Requested Give Amount - Maximum",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"in a variable dose order, this is the maximum ordered amount.  In a nonvarying dose order, this field is not used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.4",
                            Type = @"Field",
                            Position = @"RXO.4",
                            Name = @"Requested Give Units",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"units for the give amount.  
 
Note:These units can be a ""compound quantity""; i.e., the units may contain the word ""per.""  For example, micrograms per KG (micg/kg) is an acceptable value, which means that the units are micrograms per KG (of body weight).  See Chapter 7 for full definition of ISO+ units. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.4.1",
                            Type = @"Component",
                            Position = @"RXO.4.1",
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
                            Id = @"RXO.4.2",
                            Type = @"Component",
                            Position = @"RXO.4.2",
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
                            Id = @"RXO.4.3",
                            Type = @"Component",
                            Position = @"RXO.4.3",
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
                            Id = @"RXO.4.4",
                            Type = @"Component",
                            Position = @"RXO.4.4",
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
                            Id = @"RXO.4.5",
                            Type = @"Component",
                            Position = @"RXO.4.5",
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
                            Id = @"RXO.4.6",
                            Type = @"Component",
                            Position = @"RXO.4.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.5",
                            Type = @"Field",
                            Position = @"RXO.5",
                            Name = @"Requested Dosage Form",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"use when both RXO-1-requested give code and RXO-10-requested dispense code do not specify the drug form",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.5.1",
                            Type = @"Component",
                            Position = @"RXO.5.1",
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
                            Id = @"RXO.5.2",
                            Type = @"Component",
                            Position = @"RXO.5.2",
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
                            Id = @"RXO.5.3",
                            Type = @"Component",
                            Position = @"RXO.5.3",
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
                            Id = @"RXO.5.4",
                            Type = @"Component",
                            Position = @"RXO.5.4",
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
                            Id = @"RXO.5.5",
                            Type = @"Component",
                            Position = @"RXO.5.5",
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
                            Id = @"RXO.5.6",
                            Type = @"Component",
                            Position = @"RXO.5.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.6",
                            Type = @"Field",
                            Position = @"RXO.6",
                            Name = @"Provider's Pharmacy Instructions",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"ordering provider's instructions to the pharmacy as a free text field",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.6.1",
                            Type = @"Component",
                            Position = @"RXO.6.1",
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
                            Id = @"RXO.6.2",
                            Type = @"Component",
                            Position = @"RXO.6.2",
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
                            Id = @"RXO.6.3",
                            Type = @"Component",
                            Position = @"RXO.6.3",
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
                            Id = @"RXO.6.4",
                            Type = @"Component",
                            Position = @"RXO.6.4",
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
                            Id = @"RXO.6.5",
                            Type = @"Component",
                            Position = @"RXO.6.5",
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
                            Id = @"RXO.6.6",
                            Type = @"Component",
                            Position = @"RXO.6.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.7",
                            Type = @"Field",
                            Position = @"RXO.7",
                            Name = @"Provider's Administration Instructions",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"ordering provider's instructions to the patient or to the provider administering the drug as a free text field",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.7.1",
                            Type = @"Component",
                            Position = @"RXO.7.1",
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
                            Id = @"RXO.7.2",
                            Type = @"Component",
                            Position = @"RXO.7.2",
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
                            Id = @"RXO.7.3",
                            Type = @"Component",
                            Position = @"RXO.7.3",
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
                            Id = @"RXO.7.4",
                            Type = @"Component",
                            Position = @"RXO.7.4",
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
                            Id = @"RXO.7.5",
                            Type = @"Component",
                            Position = @"RXO.7.5",
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
                            Id = @"RXO.7.6",
                            Type = @"Component",
                            Position = @"RXO.7.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8",
                            Type = @"Field",
                            Position = @"RXO.8",
                            Name = @"Deliver-to Location",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CM_LA1",
                            DataTypeName = @"Location With Address Information",
                            TableId = null,
                            TableName = null,
                            Description = @"the first component contains the inpatient or outpatient location to which the pharmacy is to deliver the drug (if applicable).  The default (null) value is the current census location for the patient.  Site specific table.  This component has the same form as PV1-3-assigned patient location.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.8.1",
                            Type = @"Component",
                            Position = @"RXO.8.1",
                            Name = @"Dispense / Deliver To Location",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_INTERNAL_LOCATION",
                            DataTypeName = @"Cm For Location Information In Hospital",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.8.1.1",
                            Type = @"SubComponent",
                            Position = @"RXO.8.1.1",
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
                            Id = @"RXO.8.1.2",
                            Type = @"SubComponent",
                            Position = @"RXO.8.1.2",
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
                            Id = @"RXO.8.1.3",
                            Type = @"SubComponent",
                            Position = @"RXO.8.1.3",
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
                            Id = @"RXO.8.1.4",
                            Type = @"SubComponent",
                            Position = @"RXO.8.1.4",
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
                            Id = @"RXO.8.1.5",
                            Type = @"SubComponent",
                            Position = @"RXO.8.1.5",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.2",
                            Type = @"Component",
                            Position = @"RXO.8.2",
                            Name = @"Location",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component can be used to specify an address.  This could be used to fill mail orders to a patient or provider, or to account for home health care. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.8.2.1",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.1",
                            Name = @"Street Address",
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
                            Id = @"RXO.8.2.2",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.2",
                            Name = @"Other Designation",
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
                            Id = @"RXO.8.2.3",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.3",
                            Name = @"City",
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
                            Id = @"RXO.8.2.4",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.4",
                            Name = @"State Or Province",
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
                            Id = @"RXO.8.2.5",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.5",
                            Name = @"Zip Or Postal Code",
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
                            Id = @"RXO.8.2.6",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.2.7",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.7",
                            Name = @"Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0190",
                            TableName = @"ADDRESS TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.2.8",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.8",
                            Name = @"Other Geographic Designation",
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
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.9",
                            Type = @"Field",
                            Position = @"RXO.9",
                            Name = @"Allow Substitutions",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0161",
                            TableName = @"ALLOW SUBSTITUTION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.10",
                            Type = @"Field",
                            Position = @"RXO.10",
                            Name = @"Requested Dispense Code",
                            Length = 100,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"what is to be/was dispensed; it is equivalent to OBR-4-universal service ID in function.  It may be present in the order or not, depending on the application.  If not present, and values are given for RXO-11requested dispense amount and RXO-12-requested dispense units, the RXO-1-requested give code is assumed.  If the requested dispense code does not include the dosage form, use RXO-5-requested dosage form. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.10.1",
                            Type = @"Component",
                            Position = @"RXO.10.1",
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
                            Id = @"RXO.10.2",
                            Type = @"Component",
                            Position = @"RXO.10.2",
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
                            Id = @"RXO.10.3",
                            Type = @"Component",
                            Position = @"RXO.10.3",
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
                            Id = @"RXO.10.4",
                            Type = @"Component",
                            Position = @"RXO.10.4",
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
                            Id = @"RXO.10.5",
                            Type = @"Component",
                            Position = @"RXO.10.5",
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
                            Id = @"RXO.10.6",
                            Type = @"Component",
                            Position = @"RXO.10.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.11",
                            Type = @"Field",
                            Position = @"RXO.11",
                            Name = @"Requested Dispense Amount",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"amount to be dispensed",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.12",
                            Type = @"Field",
                            Position = @"RXO.12",
                            Name = @"Requested Dispense Units",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"units for the dispense amount.  This must be in simple units that reflect the actual quantity of the substance to be dispensed.  It does not include compound units",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.12.1",
                            Type = @"Component",
                            Position = @"RXO.12.1",
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
                            Id = @"RXO.12.2",
                            Type = @"Component",
                            Position = @"RXO.12.2",
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
                            Id = @"RXO.12.3",
                            Type = @"Component",
                            Position = @"RXO.12.3",
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
                            Id = @"RXO.12.4",
                            Type = @"Component",
                            Position = @"RXO.12.4",
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
                            Id = @"RXO.12.5",
                            Type = @"Component",
                            Position = @"RXO.12.5",
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
                            Id = @"RXO.12.6",
                            Type = @"Component",
                            Position = @"RXO.12.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.13",
                            Type = @"Field",
                            Position = @"RXO.13",
                            Name = @"Number Of Refills",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"outpatient only",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14",
                            Type = @"Field",
                            Position = @"RXO.14",
                            Name = @"Ordering Provider's Dea Number",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"if required by site.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.14.1",
                            Type = @"Component",
                            Position = @"RXO.14.1",
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
                            Id = @"RXO.14.2",
                            Type = @"Component",
                            Position = @"RXO.14.2",
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
                            Id = @"RXO.14.3",
                            Type = @"Component",
                            Position = @"RXO.14.3",
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
                            Id = @"RXO.14.4",
                            Type = @"Component",
                            Position = @"RXO.14.4",
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
                            Id = @"RXO.14.5",
                            Type = @"Component",
                            Position = @"RXO.14.5",
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
                            Id = @"RXO.14.6",
                            Type = @"Component",
                            Position = @"RXO.14.6",
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
                            Id = @"RXO.14.7",
                            Type = @"Component",
                            Position = @"RXO.14.7",
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
                            Id = @"RXO.14.8",
                            Type = @"Component",
                            Position = @"RXO.14.8",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15",
                            Type = @"Field",
                            Position = @"RXO.15",
                            Name = @"Pharmacist Verifier Id",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"provider ID of pharmacist verifier.  Use if required by the Pharmacy application or site on orders (or some subgroup of orders), in addition to ORC-11-verified by",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.15.1",
                            Type = @"Component",
                            Position = @"RXO.15.1",
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
                            Id = @"RXO.15.2",
                            Type = @"Component",
                            Position = @"RXO.15.2",
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
                            Id = @"RXO.15.3",
                            Type = @"Component",
                            Position = @"RXO.15.3",
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
                            Id = @"RXO.15.4",
                            Type = @"Component",
                            Position = @"RXO.15.4",
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
                            Id = @"RXO.15.5",
                            Type = @"Component",
                            Position = @"RXO.15.5",
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
                            Id = @"RXO.15.6",
                            Type = @"Component",
                            Position = @"RXO.15.6",
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
                            Id = @"RXO.15.7",
                            Type = @"Component",
                            Position = @"RXO.15.7",
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
                            Id = @"RXO.15.8",
                            Type = @"Component",
                            Position = @"RXO.15.8",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.16",
                            Type = @"Field",
                            Position = @"RXO.16",
                            Name = @"Needs Human Review",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = @"uses table 0136 - Y/N indicator.

A smart Order Entry application knows of a possible drug interaction on a certain order, but the provider issuing the order wants to override the condition.  In this case, the Pharmacy application receiving the order will want to have a staff pharmacist review the interaction and contact the ordering physician",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.17",
                            Type = @"Field",
                            Position = @"RXO.17",
                            Name = @"Requested Give Per (time Unit)",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"time unit to use to calculate the rate at which the pharmaceutical is to be administered",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentRXO(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field requestedGiveCode;

public HL7V22Field RequestedGiveCode
{
    get
    {
        if (requestedGiveCode != null)
        {
            return requestedGiveCode;
        }

        requestedGiveCode = new HL7V22Field
        {
            field = message[@"RXO"][1],
            Id = @"RXO.1",
            Type = @"Field",
            Position = @"RXO.1",
            Name = @"Requested Give Code",
            Length = 100,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"identifier of the medical substance ordered to be given to the patient; it is equivalent to OBR-4-universal service ID code in function.  The request-to-dispense fields, which define the type and amount of what is to be issued to the patient (see RXO-10 requested dispense code, RXO-11-requested dispense amount, and RXO-12-requested dispense units) do not necessarily correlate with the instructions of what amount is to be ""given"" or administered with each dose, and may or may not be specified with the order.  For example, the ""give"" part of the order may convey the field-representation of give 15 mg of librium every 6 hours, while the request to dispense part of the order may convey issue 30 tablets of 10 MG generic equivalent for this outpatient prescription.  When the give code does not include the dosage form, use RXO-5-requested dosage form.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveCode.field.FieldRepetitions != null && requestedGiveCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveCode.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < requestedGiveCode.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = requestedGiveCode.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < requestedGiveCode.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = requestedGiveCode.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < requestedGiveCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = requestedGiveCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            requestedGiveCode.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveCode;
    } 
}

internal HL7V22Field requestedGiveAmountMinimum;

public HL7V22Field RequestedGiveAmountMinimum
{
    get
    {
        if (requestedGiveAmountMinimum != null)
        {
            return requestedGiveAmountMinimum;
        }

        requestedGiveAmountMinimum = new HL7V22Field
        {
            field = message[@"RXO"][2],
            Id = @"RXO.2",
            Type = @"Field",
            Position = @"RXO.2",
            Name = @"Requested Give Amount - Minimum",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"ordered amount.  In a variable dose order, this is the minimum ordered amount.  In a nonvarying dose order, this is the exact amount of the order

Note:This field is not a duplication of the first component of the quantity/timing field, since in non-Pharmacy orders, that component can be used to specify multiples of an ordered amount. 
 
Another way to say this is that, for pharmacy orders, the quantity component of the quantity/timing field refers to what is to be given out at each service interval; thus, in terms of the RX order, that first component always defaults to 1.  Hence, in the actual execution of the order, the value of 1 in the first component of the quantity/timing field always refers to one administration of the amount specified in this field (the Requested Give Amount field). ",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveAmountMinimum.field.FieldRepetitions != null && requestedGiveAmountMinimum.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveAmountMinimum.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < requestedGiveAmountMinimum.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = requestedGiveAmountMinimum.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < requestedGiveAmountMinimum.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = requestedGiveAmountMinimum.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < requestedGiveAmountMinimum.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = requestedGiveAmountMinimum.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            requestedGiveAmountMinimum.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveAmountMinimum;
    } 
}

internal HL7V22Field requestedGiveAmountMaximum;

public HL7V22Field RequestedGiveAmountMaximum
{
    get
    {
        if (requestedGiveAmountMaximum != null)
        {
            return requestedGiveAmountMaximum;
        }

        requestedGiveAmountMaximum = new HL7V22Field
        {
            field = message[@"RXO"][3],
            Id = @"RXO.3",
            Type = @"Field",
            Position = @"RXO.3",
            Name = @"Requested Give Amount - Maximum",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"in a variable dose order, this is the maximum ordered amount.  In a nonvarying dose order, this field is not used",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveAmountMaximum.field.FieldRepetitions != null && requestedGiveAmountMaximum.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveAmountMaximum.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < requestedGiveAmountMaximum.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = requestedGiveAmountMaximum.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < requestedGiveAmountMaximum.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = requestedGiveAmountMaximum.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < requestedGiveAmountMaximum.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = requestedGiveAmountMaximum.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            requestedGiveAmountMaximum.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveAmountMaximum;
    } 
}

internal HL7V22Field requestedGiveUnits;

public HL7V22Field RequestedGiveUnits
{
    get
    {
        if (requestedGiveUnits != null)
        {
            return requestedGiveUnits;
        }

        requestedGiveUnits = new HL7V22Field
        {
            field = message[@"RXO"][4],
            Id = @"RXO.4",
            Type = @"Field",
            Position = @"RXO.4",
            Name = @"Requested Give Units",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"units for the give amount.  
 
Note:These units can be a ""compound quantity""; i.e., the units may contain the word ""per.""  For example, micrograms per KG (micg/kg) is an acceptable value, which means that the units are micrograms per KG (of body weight).  See Chapter 7 for full definition of ISO+ units. ",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveUnits.field.FieldRepetitions != null && requestedGiveUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveUnits.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < requestedGiveUnits.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = requestedGiveUnits.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < requestedGiveUnits.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = requestedGiveUnits.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < requestedGiveUnits.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = requestedGiveUnits.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            requestedGiveUnits.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveUnits;
    } 
}

internal HL7V22Field requestedDosageForm;

public HL7V22Field RequestedDosageForm
{
    get
    {
        if (requestedDosageForm != null)
        {
            return requestedDosageForm;
        }

        requestedDosageForm = new HL7V22Field
        {
            field = message[@"RXO"][5],
            Id = @"RXO.5",
            Type = @"Field",
            Position = @"RXO.5",
            Name = @"Requested Dosage Form",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"use when both RXO-1-requested give code and RXO-10-requested dispense code do not specify the drug form",
            Sample = @"",
        };

        // check for repetitions
        if (requestedDosageForm.field.FieldRepetitions != null && requestedDosageForm.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedDosageForm.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < requestedDosageForm.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = requestedDosageForm.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < requestedDosageForm.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = requestedDosageForm.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < requestedDosageForm.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = requestedDosageForm.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            requestedDosageForm.fieldRepetitions = fieldRepetitions;
        }

        return requestedDosageForm;
    } 
}

internal HL7V22Field providersPharmacyInstructions;

public HL7V22Field ProvidersPharmacyInstructions
{
    get
    {
        if (providersPharmacyInstructions != null)
        {
            return providersPharmacyInstructions;
        }

        providersPharmacyInstructions = new HL7V22Field
        {
            field = message[@"RXO"][6],
            Id = @"RXO.6",
            Type = @"Field",
            Position = @"RXO.6",
            Name = @"Provider's Pharmacy Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"ordering provider's instructions to the pharmacy as a free text field",
            Sample = @"",
        };

        // check for repetitions
        if (providersPharmacyInstructions.field.FieldRepetitions != null && providersPharmacyInstructions.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(providersPharmacyInstructions.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < providersPharmacyInstructions.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = providersPharmacyInstructions.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < providersPharmacyInstructions.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = providersPharmacyInstructions.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < providersPharmacyInstructions.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = providersPharmacyInstructions.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            providersPharmacyInstructions.fieldRepetitions = fieldRepetitions;
        }

        return providersPharmacyInstructions;
    } 
}

internal HL7V22Field providersAdministrationInstructions;

public HL7V22Field ProvidersAdministrationInstructions
{
    get
    {
        if (providersAdministrationInstructions != null)
        {
            return providersAdministrationInstructions;
        }

        providersAdministrationInstructions = new HL7V22Field
        {
            field = message[@"RXO"][7],
            Id = @"RXO.7",
            Type = @"Field",
            Position = @"RXO.7",
            Name = @"Provider's Administration Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"ordering provider's instructions to the patient or to the provider administering the drug as a free text field",
            Sample = @"",
        };

        // check for repetitions
        if (providersAdministrationInstructions.field.FieldRepetitions != null && providersAdministrationInstructions.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(providersAdministrationInstructions.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < providersAdministrationInstructions.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = providersAdministrationInstructions.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < providersAdministrationInstructions.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = providersAdministrationInstructions.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < providersAdministrationInstructions.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = providersAdministrationInstructions.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            providersAdministrationInstructions.fieldRepetitions = fieldRepetitions;
        }

        return providersAdministrationInstructions;
    } 
}

internal HL7V22Field delivertoLocation;

public HL7V22Field DelivertoLocation
{
    get
    {
        if (delivertoLocation != null)
        {
            return delivertoLocation;
        }

        delivertoLocation = new HL7V22Field
        {
            field = message[@"RXO"][8],
            Id = @"RXO.8",
            Type = @"Field",
            Position = @"RXO.8",
            Name = @"Deliver-to Location",
            Length = 12,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CM_LA1",
            DataTypeName = @"Location With Address Information",
            TableId = null,
            TableName = null,
            Description = @"the first component contains the inpatient or outpatient location to which the pharmacy is to deliver the drug (if applicable).  The default (null) value is the current census location for the patient.  Site specific table.  This component has the same form as PV1-3-assigned patient location.",
            Sample = @"",
        };

        // check for repetitions
        if (delivertoLocation.field.FieldRepetitions != null && delivertoLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(delivertoLocation.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < delivertoLocation.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = delivertoLocation.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < delivertoLocation.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = delivertoLocation.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < delivertoLocation.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = delivertoLocation.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            delivertoLocation.fieldRepetitions = fieldRepetitions;
        }

        return delivertoLocation;
    } 
}

internal HL7V22Field allowSubstitutions;

public HL7V22Field AllowSubstitutions
{
    get
    {
        if (allowSubstitutions != null)
        {
            return allowSubstitutions;
        }

        allowSubstitutions = new HL7V22Field
        {
            field = message[@"RXO"][9],
            Id = @"RXO.9",
            Type = @"Field",
            Position = @"RXO.9",
            Name = @"Allow Substitutions",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0161",
            TableName = @"ALLOW SUBSTITUTION",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (allowSubstitutions.field.FieldRepetitions != null && allowSubstitutions.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(allowSubstitutions.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < allowSubstitutions.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = allowSubstitutions.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < allowSubstitutions.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = allowSubstitutions.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < allowSubstitutions.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = allowSubstitutions.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            allowSubstitutions.fieldRepetitions = fieldRepetitions;
        }

        return allowSubstitutions;
    } 
}

internal HL7V22Field requestedDispenseCode;

public HL7V22Field RequestedDispenseCode
{
    get
    {
        if (requestedDispenseCode != null)
        {
            return requestedDispenseCode;
        }

        requestedDispenseCode = new HL7V22Field
        {
            field = message[@"RXO"][10],
            Id = @"RXO.10",
            Type = @"Field",
            Position = @"RXO.10",
            Name = @"Requested Dispense Code",
            Length = 100,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"what is to be/was dispensed; it is equivalent to OBR-4-universal service ID in function.  It may be present in the order or not, depending on the application.  If not present, and values are given for RXO-11requested dispense amount and RXO-12-requested dispense units, the RXO-1-requested give code is assumed.  If the requested dispense code does not include the dosage form, use RXO-5-requested dosage form. ",
            Sample = @"",
        };

        // check for repetitions
        if (requestedDispenseCode.field.FieldRepetitions != null && requestedDispenseCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedDispenseCode.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < requestedDispenseCode.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = requestedDispenseCode.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < requestedDispenseCode.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = requestedDispenseCode.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < requestedDispenseCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = requestedDispenseCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            requestedDispenseCode.fieldRepetitions = fieldRepetitions;
        }

        return requestedDispenseCode;
    } 
}

internal HL7V22Field requestedDispenseAmount;

public HL7V22Field RequestedDispenseAmount
{
    get
    {
        if (requestedDispenseAmount != null)
        {
            return requestedDispenseAmount;
        }

        requestedDispenseAmount = new HL7V22Field
        {
            field = message[@"RXO"][11],
            Id = @"RXO.11",
            Type = @"Field",
            Position = @"RXO.11",
            Name = @"Requested Dispense Amount",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount to be dispensed",
            Sample = @"",
        };

        // check for repetitions
        if (requestedDispenseAmount.field.FieldRepetitions != null && requestedDispenseAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedDispenseAmount.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < requestedDispenseAmount.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = requestedDispenseAmount.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < requestedDispenseAmount.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = requestedDispenseAmount.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < requestedDispenseAmount.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = requestedDispenseAmount.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            requestedDispenseAmount.fieldRepetitions = fieldRepetitions;
        }

        return requestedDispenseAmount;
    } 
}

internal HL7V22Field requestedDispenseUnits;

public HL7V22Field RequestedDispenseUnits
{
    get
    {
        if (requestedDispenseUnits != null)
        {
            return requestedDispenseUnits;
        }

        requestedDispenseUnits = new HL7V22Field
        {
            field = message[@"RXO"][12],
            Id = @"RXO.12",
            Type = @"Field",
            Position = @"RXO.12",
            Name = @"Requested Dispense Units",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"units for the dispense amount.  This must be in simple units that reflect the actual quantity of the substance to be dispensed.  It does not include compound units",
            Sample = @"",
        };

        // check for repetitions
        if (requestedDispenseUnits.field.FieldRepetitions != null && requestedDispenseUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedDispenseUnits.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < requestedDispenseUnits.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = requestedDispenseUnits.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < requestedDispenseUnits.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = requestedDispenseUnits.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < requestedDispenseUnits.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = requestedDispenseUnits.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            requestedDispenseUnits.fieldRepetitions = fieldRepetitions;
        }

        return requestedDispenseUnits;
    } 
}

internal HL7V22Field numberOfRefills;

public HL7V22Field NumberOfRefills
{
    get
    {
        if (numberOfRefills != null)
        {
            return numberOfRefills;
        }

        numberOfRefills = new HL7V22Field
        {
            field = message[@"RXO"][13],
            Id = @"RXO.13",
            Type = @"Field",
            Position = @"RXO.13",
            Name = @"Number Of Refills",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"outpatient only",
            Sample = @"",
        };

        // check for repetitions
        if (numberOfRefills.field.FieldRepetitions != null && numberOfRefills.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberOfRefills.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < numberOfRefills.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = numberOfRefills.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < numberOfRefills.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = numberOfRefills.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < numberOfRefills.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = numberOfRefills.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            numberOfRefills.fieldRepetitions = fieldRepetitions;
        }

        return numberOfRefills;
    } 
}

internal HL7V22Field orderingProvidersDeaNumber;

public HL7V22Field OrderingProvidersDeaNumber
{
    get
    {
        if (orderingProvidersDeaNumber != null)
        {
            return orderingProvidersDeaNumber;
        }

        orderingProvidersDeaNumber = new HL7V22Field
        {
            field = message[@"RXO"][14],
            Id = @"RXO.14",
            Type = @"Field",
            Position = @"RXO.14",
            Name = @"Ordering Provider's Dea Number",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"if required by site.",
            Sample = @"",
        };

        // check for repetitions
        if (orderingProvidersDeaNumber.field.FieldRepetitions != null && orderingProvidersDeaNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(orderingProvidersDeaNumber.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < orderingProvidersDeaNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = orderingProvidersDeaNumber.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < orderingProvidersDeaNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = orderingProvidersDeaNumber.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < orderingProvidersDeaNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = orderingProvidersDeaNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            orderingProvidersDeaNumber.fieldRepetitions = fieldRepetitions;
        }

        return orderingProvidersDeaNumber;
    } 
}

internal HL7V22Field pharmacistVerifierId;

public HL7V22Field PharmacistVerifierId
{
    get
    {
        if (pharmacistVerifierId != null)
        {
            return pharmacistVerifierId;
        }

        pharmacistVerifierId = new HL7V22Field
        {
            field = message[@"RXO"][15],
            Id = @"RXO.15",
            Type = @"Field",
            Position = @"RXO.15",
            Name = @"Pharmacist Verifier Id",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"provider ID of pharmacist verifier.  Use if required by the Pharmacy application or site on orders (or some subgroup of orders), in addition to ORC-11-verified by",
            Sample = @"",
        };

        // check for repetitions
        if (pharmacistVerifierId.field.FieldRepetitions != null && pharmacistVerifierId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pharmacistVerifierId.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < pharmacistVerifierId.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = pharmacistVerifierId.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < pharmacistVerifierId.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = pharmacistVerifierId.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < pharmacistVerifierId.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = pharmacistVerifierId.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            pharmacistVerifierId.fieldRepetitions = fieldRepetitions;
        }

        return pharmacistVerifierId;
    } 
}

internal HL7V22Field needsHumanReview;

public HL7V22Field NeedsHumanReview
{
    get
    {
        if (needsHumanReview != null)
        {
            return needsHumanReview;
        }

        needsHumanReview = new HL7V22Field
        {
            field = message[@"RXO"][16],
            Id = @"RXO.16",
            Type = @"Field",
            Position = @"RXO.16",
            Name = @"Needs Human Review",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"uses table 0136 - Y/N indicator.

A smart Order Entry application knows of a possible drug interaction on a certain order, but the provider issuing the order wants to override the condition.  In this case, the Pharmacy application receiving the order will want to have a staff pharmacist review the interaction and contact the ordering physician",
            Sample = @"",
        };

        // check for repetitions
        if (needsHumanReview.field.FieldRepetitions != null && needsHumanReview.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(needsHumanReview.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < needsHumanReview.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = needsHumanReview.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < needsHumanReview.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = needsHumanReview.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < needsHumanReview.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = needsHumanReview.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            needsHumanReview.fieldRepetitions = fieldRepetitions;
        }

        return needsHumanReview;
    } 
}

internal HL7V22Field requestedGivePertimeUnit;

public HL7V22Field RequestedGivePertimeUnit
{
    get
    {
        if (requestedGivePertimeUnit != null)
        {
            return requestedGivePertimeUnit;
        }

        requestedGivePertimeUnit = new HL7V22Field
        {
            field = message[@"RXO"][17],
            Id = @"RXO.17",
            Type = @"Field",
            Position = @"RXO.17",
            Name = @"Requested Give Per (time Unit)",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"time unit to use to calculate the rate at which the pharmaceutical is to be administered",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGivePertimeUnit.field.FieldRepetitions != null && requestedGivePertimeUnit.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGivePertimeUnit.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < requestedGivePertimeUnit.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = requestedGivePertimeUnit.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < requestedGivePertimeUnit.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = requestedGivePertimeUnit.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < requestedGivePertimeUnit.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = requestedGivePertimeUnit.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            requestedGivePertimeUnit.fieldRepetitions = fieldRepetitions;
        }

        return requestedGivePertimeUnit;
    } 
}
    }
}
