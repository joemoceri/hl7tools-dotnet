using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentRXD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RXD"; } }

        public string SegmentId { get { return @"RXD"; } }
        
        public string LongName { get { return @"Pharmacy Dispense"; } }
        
        public string Description { get { return @""; } }
        
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
                            Id = @"RXD.1",
                            Type = @"Field",
                            Position = @"RXD.1",
                            Name = @"Dispense Sub-id Counter",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Starts with 1 the first time that medication is dispensed for this order.  Increments by one with each additional issuance of medication",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXD.2",
                            Type = @"Field",
                            Position = @"RXD.2",
                            Name = @"Dispense / Give Code",
                            Length = 100,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifier of the medical substance ordered to be given to the patient; it is equivalent to OBR-4-universal service ID code.  See the RXE segment for a complete definition of the RXE-2-give code. 

Note:The contents of RXD-2-dispense/give code should be identical to the comparable field in the RXE (RXE-2-give code).  The RDS message refers ONLY to the dispensing of the drug by the Pharmacy. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXD.2.1",
                            Type = @"Component",
                            Position = @"RXD.2.1",
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
                            Id = @"RXD.2.2",
                            Type = @"Component",
                            Position = @"RXD.2.2",
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
                            Id = @"RXD.2.3",
                            Type = @"Component",
                            Position = @"RXD.2.3",
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
                            Id = @"RXD.2.4",
                            Type = @"Component",
                            Position = @"RXD.2.4",
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
                            Id = @"RXD.2.5",
                            Type = @"Component",
                            Position = @"RXD.2.5",
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
                            Id = @"RXD.2.6",
                            Type = @"Component",
                            Position = @"RXD.2.6",
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
                            Id = @"RXD.3",
                            Type = @"Field",
                            Position = @"RXD.3",
                            Name = @"Date / Time Dispensed",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"when the pharmaceutical is dispensed from the Pharmacy.  Use the time-stamp format",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXD.3.1",
                            Type = @"Component",
                            Position = @"RXD.3.1",
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
                            Id = @"RXD.3.2",
                            Type = @"Component",
                            Position = @"RXD.3.2",
                            Name = @"Degree Of Precision",
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
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXD.4",
                            Type = @"Field",
                            Position = @"RXD.4",
                            Name = @"Actual Dispense Amount",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"amount dispensed",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXD.5",
                            Type = @"Field",
                            Position = @"RXD.5",
                            Name = @"Actual Dispense Units",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"units dispensed.  Site-defined table.  As with Give units, if the units are part of the actual dispense code this field is optional, but if present, it overrides units implied by the actual dispense code.  This must be in simple units that reflect the actual quantity of the substance dispensed.  It does not include compound units",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXD.5.1",
                            Type = @"Component",
                            Position = @"RXD.5.1",
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
                            Id = @"RXD.5.2",
                            Type = @"Component",
                            Position = @"RXD.5.2",
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
                            Id = @"RXD.5.3",
                            Type = @"Component",
                            Position = @"RXD.5.3",
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
                            Id = @"RXD.5.4",
                            Type = @"Component",
                            Position = @"RXD.5.4",
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
                            Id = @"RXD.5.5",
                            Type = @"Component",
                            Position = @"RXD.5.5",
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
                            Id = @"RXD.5.6",
                            Type = @"Component",
                            Position = @"RXD.5.6",
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
                            Id = @"RXD.6",
                            Type = @"Field",
                            Position = @"RXD.6",
                            Name = @"Actual Dosage Form",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"use this field when the give code and the dispense code do not specify the dosage form",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXD.6.1",
                            Type = @"Component",
                            Position = @"RXD.6.1",
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
                            Id = @"RXD.6.2",
                            Type = @"Component",
                            Position = @"RXD.6.2",
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
                            Id = @"RXD.6.3",
                            Type = @"Component",
                            Position = @"RXD.6.3",
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
                            Id = @"RXD.6.4",
                            Type = @"Component",
                            Position = @"RXD.6.4",
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
                            Id = @"RXD.6.5",
                            Type = @"Component",
                            Position = @"RXD.6.5",
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
                            Id = @"RXD.6.6",
                            Type = @"Component",
                            Position = @"RXD.6.6",
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
                            Id = @"RXD.7",
                            Type = @"Field",
                            Position = @"RXD.7",
                            Name = @"Prescription Number",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"equivalent in uniqueness to the Pharmacy filler order number.  At some sites, this may be the Pharmacy (internal) sequential form.  At other sites, this may be an external form",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXD.8",
                            Type = @"Field",
                            Position = @"RXD.8",
                            Name = @"Number Of Refills Remaining",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"outpatient only. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXD.9",
                            Type = @"Field",
                            Position = @"RXD.9",
                            Name = @"Dispense Notes",
                            Length = 200,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"free text notes to the person dispensing the medication (may include the ordering provider's original notes, as well as any notes from the formulary or the pharmacy).  This may contain free text describing a custom IV, mixture, or salve",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXD.10",
                            Type = @"Field",
                            Position = @"RXD.10",
                            Name = @"Dispensing Provider",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"provider ID of the person dispensing the pharmaceutical",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXD.10.1",
                            Type = @"Component",
                            Position = @"RXD.10.1",
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
                            Id = @"RXD.10.2",
                            Type = @"Component",
                            Position = @"RXD.10.2",
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
                            Id = @"RXD.10.3",
                            Type = @"Component",
                            Position = @"RXD.10.3",
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
                            Id = @"RXD.10.4",
                            Type = @"Component",
                            Position = @"RXD.10.4",
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
                            Id = @"RXD.10.5",
                            Type = @"Component",
                            Position = @"RXD.10.5",
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
                            Id = @"RXD.10.6",
                            Type = @"Component",
                            Position = @"RXD.10.6",
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
                            Id = @"RXD.10.7",
                            Type = @"Component",
                            Position = @"RXD.10.7",
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
                            Id = @"RXD.10.8",
                            Type = @"Component",
                            Position = @"RXD.10.8",
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
                            Id = @"RXD.11",
                            Type = @"Field",
                            Position = @"RXD.11",
                            Name = @"Substitution Status",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0167",
                            TableName = @"SUBSTITUTION STATUS",
                            Description = @"refer to table 0167 - substitution status for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXD.12",
                            Type = @"Field",
                            Position = @"RXD.12",
                            Name = @"Total Daily Dose",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"total daily dose being dispensed as expressed in terms of the actual dispense units. 
 
Note:The next two fields are equivalent to the corresponding fields of the RXE segment.  They are included (optionally) in the RXD so that it may ""stand alone"" as a dispense result instruction segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXD.13",
                            Type = @"Field",
                            Position = @"RXD.13",
                            Name = @"Dispense-to location",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CM_LA1",
                            DataTypeName = @"Location With Address Information",
                            TableId = null,
                            TableName = null,
                            Description = @"the first component contains the inpatient or outpatient location where the drug was dispensed (if applicable).  The default (null) value is the current census location for the patient.  Site specific table.  This component has the same form as PV1-3-assigned patient location",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXD.13.1",
                            Type = @"Component",
                            Position = @"RXD.13.1",
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
                            Id = @"RXD.13.1.1",
                            Type = @"SubComponent",
                            Position = @"RXD.13.1.1",
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
                            Id = @"RXD.13.1.2",
                            Type = @"SubComponent",
                            Position = @"RXD.13.1.2",
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
                            Id = @"RXD.13.1.3",
                            Type = @"SubComponent",
                            Position = @"RXD.13.1.3",
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
                            Id = @"RXD.13.1.4",
                            Type = @"SubComponent",
                            Position = @"RXD.13.1.4",
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
                            Id = @"RXD.13.1.5",
                            Type = @"SubComponent",
                            Position = @"RXD.13.1.5",
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
                            Id = @"RXD.13.2",
                            Type = @"Component",
                            Position = @"RXD.13.2",
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
                            Id = @"RXD.13.2.1",
                            Type = @"SubComponent",
                            Position = @"RXD.13.2.1",
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
                            Id = @"RXD.13.2.2",
                            Type = @"SubComponent",
                            Position = @"RXD.13.2.2",
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
                            Id = @"RXD.13.2.3",
                            Type = @"SubComponent",
                            Position = @"RXD.13.2.3",
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
                            Id = @"RXD.13.2.4",
                            Type = @"SubComponent",
                            Position = @"RXD.13.2.4",
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
                            Id = @"RXD.13.2.5",
                            Type = @"SubComponent",
                            Position = @"RXD.13.2.5",
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
                            Id = @"RXD.13.2.6",
                            Type = @"SubComponent",
                            Position = @"RXD.13.2.6",
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
                            Id = @"RXD.13.2.7",
                            Type = @"SubComponent",
                            Position = @"RXD.13.2.7",
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
                            Id = @"RXD.13.2.8",
                            Type = @"SubComponent",
                            Position = @"RXD.13.2.8",
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
                            Id = @"RXD.14",
                            Type = @"Field",
                            Position = @"RXD.14",
                            Name = @"Needs Human Review",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = @"refer to table 0136 - Y/N indicator for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXD.15",
                            Type = @"Field",
                            Position = @"RXD.15",
                            Name = @"Pharmacy Special Dispensing Instructions",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"pharmacy-generated special instructions to the provider dispensing/administering the order",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXD.15.1",
                            Type = @"Component",
                            Position = @"RXD.15.1",
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
                            Id = @"RXD.15.2",
                            Type = @"Component",
                            Position = @"RXD.15.2",
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
                            Id = @"RXD.15.3",
                            Type = @"Component",
                            Position = @"RXD.15.3",
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
                            Id = @"RXD.15.4",
                            Type = @"Component",
                            Position = @"RXD.15.4",
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
                            Id = @"RXD.15.5",
                            Type = @"Component",
                            Position = @"RXD.15.5",
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
                            Id = @"RXD.15.6",
                            Type = @"Component",
                            Position = @"RXD.15.6",
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
                        };
            }
        }

        public HL7V22SegmentRXD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field dispenseSubidCounter;

public HL7V22Field DispenseSubidCounter
{
    get
    {
        if (dispenseSubidCounter != null)
        {
            return dispenseSubidCounter;
        }

        dispenseSubidCounter = new HL7V22Field
        {
            field = message[@"RXD"][1],
            Id = @"RXD.1",
            Type = @"Field",
            Position = @"RXD.1",
            Name = @"Dispense Sub-id Counter",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Starts with 1 the first time that medication is dispensed for this order.  Increments by one with each additional issuance of medication",
            Sample = @"",
        };

        // check for repetitions
        if (dispenseSubidCounter.field.FieldRepetitions != null && dispenseSubidCounter.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dispenseSubidCounter.Id));
            dispenseSubidCounter.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dispenseSubidCounter, fieldData);
        }

        return dispenseSubidCounter;
    } 
}

internal HL7V22Field dispenseGiveCode;

public HL7V22Field DispenseGiveCode
{
    get
    {
        if (dispenseGiveCode != null)
        {
            return dispenseGiveCode;
        }

        dispenseGiveCode = new HL7V22Field
        {
            field = message[@"RXD"][2],
            Id = @"RXD.2",
            Type = @"Field",
            Position = @"RXD.2",
            Name = @"Dispense / Give Code",
            Length = 100,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"Identifier of the medical substance ordered to be given to the patient; it is equivalent to OBR-4-universal service ID code.  See the RXE segment for a complete definition of the RXE-2-give code. 

Note:The contents of RXD-2-dispense/give code should be identical to the comparable field in the RXE (RXE-2-give code).  The RDS message refers ONLY to the dispensing of the drug by the Pharmacy. ",
            Sample = @"",
        };

        // check for repetitions
        if (dispenseGiveCode.field.FieldRepetitions != null && dispenseGiveCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dispenseGiveCode.Id));
            dispenseGiveCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dispenseGiveCode, fieldData);
        }

        return dispenseGiveCode;
    } 
}

internal HL7V22Field dateTimeDispensed;

public HL7V22Field DateTimeDispensed
{
    get
    {
        if (dateTimeDispensed != null)
        {
            return dateTimeDispensed;
        }

        dateTimeDispensed = new HL7V22Field
        {
            field = message[@"RXD"][3],
            Id = @"RXD.3",
            Type = @"Field",
            Position = @"RXD.3",
            Name = @"Date / Time Dispensed",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"when the pharmaceutical is dispensed from the Pharmacy.  Use the time-stamp format",
            Sample = @"",
        };

        // check for repetitions
        if (dateTimeDispensed.field.FieldRepetitions != null && dateTimeDispensed.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateTimeDispensed.Id));
            dateTimeDispensed.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dateTimeDispensed, fieldData);
        }

        return dateTimeDispensed;
    } 
}

internal HL7V22Field actualDispenseAmount;

public HL7V22Field ActualDispenseAmount
{
    get
    {
        if (actualDispenseAmount != null)
        {
            return actualDispenseAmount;
        }

        actualDispenseAmount = new HL7V22Field
        {
            field = message[@"RXD"][4],
            Id = @"RXD.4",
            Type = @"Field",
            Position = @"RXD.4",
            Name = @"Actual Dispense Amount",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount dispensed",
            Sample = @"",
        };

        // check for repetitions
        if (actualDispenseAmount.field.FieldRepetitions != null && actualDispenseAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(actualDispenseAmount.Id));
            actualDispenseAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(actualDispenseAmount, fieldData);
        }

        return actualDispenseAmount;
    } 
}

internal HL7V22Field actualDispenseUnits;

public HL7V22Field ActualDispenseUnits
{
    get
    {
        if (actualDispenseUnits != null)
        {
            return actualDispenseUnits;
        }

        actualDispenseUnits = new HL7V22Field
        {
            field = message[@"RXD"][5],
            Id = @"RXD.5",
            Type = @"Field",
            Position = @"RXD.5",
            Name = @"Actual Dispense Units",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"units dispensed.  Site-defined table.  As with Give units, if the units are part of the actual dispense code this field is optional, but if present, it overrides units implied by the actual dispense code.  This must be in simple units that reflect the actual quantity of the substance dispensed.  It does not include compound units",
            Sample = @"",
        };

        // check for repetitions
        if (actualDispenseUnits.field.FieldRepetitions != null && actualDispenseUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(actualDispenseUnits.Id));
            actualDispenseUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(actualDispenseUnits, fieldData);
        }

        return actualDispenseUnits;
    } 
}

internal HL7V22Field actualDosageForm;

public HL7V22Field ActualDosageForm
{
    get
    {
        if (actualDosageForm != null)
        {
            return actualDosageForm;
        }

        actualDosageForm = new HL7V22Field
        {
            field = message[@"RXD"][6],
            Id = @"RXD.6",
            Type = @"Field",
            Position = @"RXD.6",
            Name = @"Actual Dosage Form",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"use this field when the give code and the dispense code do not specify the dosage form",
            Sample = @"",
        };

        // check for repetitions
        if (actualDosageForm.field.FieldRepetitions != null && actualDosageForm.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(actualDosageForm.Id));
            actualDosageForm.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(actualDosageForm, fieldData);
        }

        return actualDosageForm;
    } 
}

internal HL7V22Field prescriptionNumber;

public HL7V22Field PrescriptionNumber
{
    get
    {
        if (prescriptionNumber != null)
        {
            return prescriptionNumber;
        }

        prescriptionNumber = new HL7V22Field
        {
            field = message[@"RXD"][7],
            Id = @"RXD.7",
            Type = @"Field",
            Position = @"RXD.7",
            Name = @"Prescription Number",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"equivalent in uniqueness to the Pharmacy filler order number.  At some sites, this may be the Pharmacy (internal) sequential form.  At other sites, this may be an external form",
            Sample = @"",
        };

        // check for repetitions
        if (prescriptionNumber.field.FieldRepetitions != null && prescriptionNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(prescriptionNumber.Id));
            prescriptionNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(prescriptionNumber, fieldData);
        }

        return prescriptionNumber;
    } 
}

internal HL7V22Field numberOfRefillsRemaining;

public HL7V22Field NumberOfRefillsRemaining
{
    get
    {
        if (numberOfRefillsRemaining != null)
        {
            return numberOfRefillsRemaining;
        }

        numberOfRefillsRemaining = new HL7V22Field
        {
            field = message[@"RXD"][8],
            Id = @"RXD.8",
            Type = @"Field",
            Position = @"RXD.8",
            Name = @"Number Of Refills Remaining",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"outpatient only. ",
            Sample = @"",
        };

        // check for repetitions
        if (numberOfRefillsRemaining.field.FieldRepetitions != null && numberOfRefillsRemaining.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberOfRefillsRemaining.Id));
            numberOfRefillsRemaining.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(numberOfRefillsRemaining, fieldData);
        }

        return numberOfRefillsRemaining;
    } 
}

internal HL7V22Field dispenseNotes;

public HL7V22Field DispenseNotes
{
    get
    {
        if (dispenseNotes != null)
        {
            return dispenseNotes;
        }

        dispenseNotes = new HL7V22Field
        {
            field = message[@"RXD"][9],
            Id = @"RXD.9",
            Type = @"Field",
            Position = @"RXD.9",
            Name = @"Dispense Notes",
            Length = 200,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"free text notes to the person dispensing the medication (may include the ordering provider's original notes, as well as any notes from the formulary or the pharmacy).  This may contain free text describing a custom IV, mixture, or salve",
            Sample = @"",
        };

        // check for repetitions
        if (dispenseNotes.field.FieldRepetitions != null && dispenseNotes.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dispenseNotes.Id));
            dispenseNotes.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dispenseNotes, fieldData);
        }

        return dispenseNotes;
    } 
}

internal HL7V22Field dispensingProvider;

public HL7V22Field DispensingProvider
{
    get
    {
        if (dispensingProvider != null)
        {
            return dispensingProvider;
        }

        dispensingProvider = new HL7V22Field
        {
            field = message[@"RXD"][10],
            Id = @"RXD.10",
            Type = @"Field",
            Position = @"RXD.10",
            Name = @"Dispensing Provider",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"provider ID of the person dispensing the pharmaceutical",
            Sample = @"",
        };

        // check for repetitions
        if (dispensingProvider.field.FieldRepetitions != null && dispensingProvider.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dispensingProvider.Id));
            dispensingProvider.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dispensingProvider, fieldData);
        }

        return dispensingProvider;
    } 
}

internal HL7V22Field substitutionStatus;

public HL7V22Field SubstitutionStatus
{
    get
    {
        if (substitutionStatus != null)
        {
            return substitutionStatus;
        }

        substitutionStatus = new HL7V22Field
        {
            field = message[@"RXD"][11],
            Id = @"RXD.11",
            Type = @"Field",
            Position = @"RXD.11",
            Name = @"Substitution Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0167",
            TableName = @"SUBSTITUTION STATUS",
            Description = @"refer to table 0167 - substitution status for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (substitutionStatus.field.FieldRepetitions != null && substitutionStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(substitutionStatus.Id));
            substitutionStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(substitutionStatus, fieldData);
        }

        return substitutionStatus;
    } 
}

internal HL7V22Field totalDailyDose;

public HL7V22Field TotalDailyDose
{
    get
    {
        if (totalDailyDose != null)
        {
            return totalDailyDose;
        }

        totalDailyDose = new HL7V22Field
        {
            field = message[@"RXD"][12],
            Id = @"RXD.12",
            Type = @"Field",
            Position = @"RXD.12",
            Name = @"Total Daily Dose",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"total daily dose being dispensed as expressed in terms of the actual dispense units. 
 
Note:The next two fields are equivalent to the corresponding fields of the RXE segment.  They are included (optionally) in the RXD so that it may ""stand alone"" as a dispense result instruction segment",
            Sample = @"",
        };

        // check for repetitions
        if (totalDailyDose.field.FieldRepetitions != null && totalDailyDose.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(totalDailyDose.Id));
            totalDailyDose.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(totalDailyDose, fieldData);
        }

        return totalDailyDose;
    } 
}

internal HL7V22Field dispensetolocation;

public HL7V22Field Dispensetolocation
{
    get
    {
        if (dispensetolocation != null)
        {
            return dispensetolocation;
        }

        dispensetolocation = new HL7V22Field
        {
            field = message[@"RXD"][13],
            Id = @"RXD.13",
            Type = @"Field",
            Position = @"RXD.13",
            Name = @"Dispense-to location",
            Length = 12,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CM_LA1",
            DataTypeName = @"Location With Address Information",
            TableId = null,
            TableName = null,
            Description = @"the first component contains the inpatient or outpatient location where the drug was dispensed (if applicable).  The default (null) value is the current census location for the patient.  Site specific table.  This component has the same form as PV1-3-assigned patient location",
            Sample = @"",
        };

        // check for repetitions
        if (dispensetolocation.field.FieldRepetitions != null && dispensetolocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dispensetolocation.Id));
            dispensetolocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dispensetolocation, fieldData);
        }

        return dispensetolocation;
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
            field = message[@"RXD"][14],
            Id = @"RXD.14",
            Type = @"Field",
            Position = @"RXD.14",
            Name = @"Needs Human Review",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"refer to table 0136 - Y/N indicator for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (needsHumanReview.field.FieldRepetitions != null && needsHumanReview.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(needsHumanReview.Id));
            needsHumanReview.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(needsHumanReview, fieldData);
        }

        return needsHumanReview;
    } 
}

internal HL7V22Field pharmacySpecialDispensingInstructions;

public HL7V22Field PharmacySpecialDispensingInstructions
{
    get
    {
        if (pharmacySpecialDispensingInstructions != null)
        {
            return pharmacySpecialDispensingInstructions;
        }

        pharmacySpecialDispensingInstructions = new HL7V22Field
        {
            field = message[@"RXD"][15],
            Id = @"RXD.15",
            Type = @"Field",
            Position = @"RXD.15",
            Name = @"Pharmacy Special Dispensing Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"pharmacy-generated special instructions to the provider dispensing/administering the order",
            Sample = @"",
        };

        // check for repetitions
        if (pharmacySpecialDispensingInstructions.field.FieldRepetitions != null && pharmacySpecialDispensingInstructions.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pharmacySpecialDispensingInstructions.Id));
            pharmacySpecialDispensingInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(pharmacySpecialDispensingInstructions, fieldData);
        }

        return pharmacySpecialDispensingInstructions;
    } 
}
    }
}
