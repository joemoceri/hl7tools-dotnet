using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentRXA
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"RXA"; } }

        public string SegmentId { get { return @"RXA"; } }
        
        public string LongName { get { return @"Pharmacy/treatment administration segment"; } }
        
        public string Description { get { return @"The ORC must have the filler order number and the order control code RE. As a site-specific variant, the RXO and associated RXCs and/or the RXE (and associated RXCs) may be present if the receiving application needs any of their data. The RXA carries the administration data."; } }
        
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
                            Id = @"RXA.1",
                            Type = @"Field",
                            Position = @"RXA.1",
                            Name = @"Give Sub-ID Counter",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Use this field if matching this RXA segment to its corresponding RXG segment. If the two applications are not matching RXG and RXA segments, this field's value is zero (0).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.2",
                            Type = @"Field",
                            Position = @"RXA.2",
                            Name = @"Administration Sub-ID Counter",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field starts with 1 the first time that medication is administered for this order. Increments by one with each additional administration of medication.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.3",
                            Type = @"Field",
                            Position = @"RXA.3",
                            Name = @"Date/Time Start of Administration",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"If the order is for a continuous administration (such as an IV), and the rate is changed at a certain time after the start, an RAS message can be issued to record the change. For such an RAS message, this field records the time the rate was changed to the new value recorded in the RXA-12-administered per (time unit) of the same message.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.3.1",
                            Type = @"Component",
                            Position = @"RXA.3.1",
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
                            Id = @"RXA.4",
                            Type = @"Field",
                            Position = @"RXA.4",
                            Name = @"Date/Time End of Administration",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"If null, the date/time of RXA-3-date/time start of administration is assumed.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.4.1",
                            Type = @"Component",
                            Position = @"RXA.4.1",
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
                            Id = @"RXA.5",
                            Type = @"Field",
                            Position = @"RXA.5",
                            Name = @"Administered Code",
                            Length = 100,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0292",
                            TableName = @"Vaccines administered",
                            Description = @"This field contains the identifier of the medical substance administered. It is equivalent to OBR-4-universal service ID in function. If the substance administered is a vaccine, CVX codes may be used to code this field (see HL7 table 0292 - Vaccines administered).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.5.1",
                            Type = @"Component",
                            Position = @"RXA.5.1",
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
                            Id = @"RXA.5.2",
                            Type = @"Component",
                            Position = @"RXA.5.2",
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
                            Id = @"RXA.5.3",
                            Type = @"Component",
                            Position = @"RXA.5.3",
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
                            Id = @"RXA.5.4",
                            Type = @"Component",
                            Position = @"RXA.5.4",
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
                            Id = @"RXA.5.5",
                            Type = @"Component",
                            Position = @"RXA.5.5",
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
                            Id = @"RXA.5.6",
                            Type = @"Component",
                            Position = @"RXA.5.6",
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
                            Id = @"RXA.6",
                            Type = @"Field",
                            Position = @"RXA.6",
                            Name = @"Administered Amount",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the amount administered.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.7",
                            Type = @"Field",
                            Position = @"RXA.7",
                            Name = @"Administered Units",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is conditional because it is required if the administered amount code does not imply units. This field must be in simple units that reflect the actual quantity of the substance administered. It does not include compound units.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.7.1",
                            Type = @"Component",
                            Position = @"RXA.7.1",
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
                            Id = @"RXA.7.2",
                            Type = @"Component",
                            Position = @"RXA.7.2",
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
                            Id = @"RXA.7.3",
                            Type = @"Component",
                            Position = @"RXA.7.3",
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
                            Id = @"RXA.7.4",
                            Type = @"Component",
                            Position = @"RXA.7.4",
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
                            Id = @"RXA.7.5",
                            Type = @"Component",
                            Position = @"RXA.7.5",
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
                            Id = @"RXA.7.6",
                            Type = @"Component",
                            Position = @"RXA.7.6",
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
                            Id = @"RXA.8",
                            Type = @"Field",
                            Position = @"RXA.8",
                            Name = @"Administered Dosage Form",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"The dosage form indicates the manner in which the medication is aggregated for dispensing, e.g., tablets, capsules, suppositories. In some cases, this information is implied by the dispense/give code in RXA-5-administered code. Use this field when the administered code does not specify the dosage form.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.8.1",
                            Type = @"Component",
                            Position = @"RXA.8.1",
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
                            Id = @"RXA.8.2",
                            Type = @"Component",
                            Position = @"RXA.8.2",
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
                            Id = @"RXA.8.3",
                            Type = @"Component",
                            Position = @"RXA.8.3",
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
                            Id = @"RXA.8.4",
                            Type = @"Component",
                            Position = @"RXA.8.4",
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
                            Id = @"RXA.8.5",
                            Type = @"Component",
                            Position = @"RXA.8.5",
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
                            Id = @"RXA.8.6",
                            Type = @"Component",
                            Position = @"RXA.8.6",
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
                            Id = @"RXA.9",
                            Type = @"Field",
                            Position = @"RXA.9",
                            Name = @"Administration Notes",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains notes from the provider administering the medication. If coded, requires a user-defined table. If free text (describing a custom IV, mixture, or salve, for example) place a null in the first component and the text in the second, e.g., |^this is a free text administration note| .",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.9.1",
                            Type = @"Component",
                            Position = @"RXA.9.1",
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
                            Id = @"RXA.9.2",
                            Type = @"Component",
                            Position = @"RXA.9.2",
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
                            Id = @"RXA.9.3",
                            Type = @"Component",
                            Position = @"RXA.9.3",
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
                            Id = @"RXA.9.4",
                            Type = @"Component",
                            Position = @"RXA.9.4",
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
                            Id = @"RXA.9.5",
                            Type = @"Component",
                            Position = @"RXA.9.5",
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
                            Id = @"RXA.9.6",
                            Type = @"Component",
                            Position = @"RXA.9.6",
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
                            Id = @"RXA.10",
                            Type = @"Field",
                            Position = @"RXA.10",
                            Name = @"Administering Provider",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name For Persons",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the provider ID of the person administering the pharmaceutical.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.1",
                            Type = @"Component",
                            Position = @"RXA.10.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This string refers to the coded ID according to a user-defined table, defined by the 9th component. If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.2",
                            Type = @"Component",
                            Position = @"RXA.10.2",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.2.1",
                            Type = @"SubComponent",
                            Position = @"RXA.10.2.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.2.2",
                            Type = @"SubComponent",
                            Position = @"RXA.10.2.2",
                            Name = @"Last Name Prefix",
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
                            Id = @"RXA.10.3",
                            Type = @"Component",
                            Position = @"RXA.10.3",
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
                            Id = @"RXA.10.4",
                            Type = @"Component",
                            Position = @"RXA.10.4",
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
                            Id = @"RXA.10.5",
                            Type = @"Component",
                            Position = @"RXA.10.5",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.6",
                            Type = @"Component",
                            Position = @"RXA.10.6",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.7",
                            Type = @"Component",
                            Position = @"RXA.10.7",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.8",
                            Type = @"Component",
                            Position = @"RXA.10.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.9",
                            Type = @"Component",
                            Position = @"RXA.10.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.9.1",
                            Type = @"SubComponent",
                            Position = @"RXA.10.9.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.9.2",
                            Type = @"SubComponent",
                            Position = @"RXA.10.9.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.9.3",
                            Type = @"SubComponent",
                            Position = @"RXA.10.9.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.10",
                            Type = @"Component",
                            Position = @"RXA.10.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.51, XPN - extended person name).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.11",
                            Type = @"Component",
                            Position = @"RXA.10.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.12",
                            Type = @"Component",
                            Position = @"RXA.10.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.13",
                            Type = @"Component",
                            Position = @"RXA.10.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.14",
                            Type = @"Component",
                            Position = @"RXA.10.14",
                            Name = @"Assigning Facility",
                            Length = 0,
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
                            Id = @"RXA.10.14.1",
                            Type = @"SubComponent",
                            Position = @"RXA.10.14.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.14.2",
                            Type = @"SubComponent",
                            Position = @"RXA.10.14.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.14.3",
                            Type = @"SubComponent",
                            Position = @"RXA.10.14.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.15",
                            Type = @"Component",
                            Position = @"RXA.10.15",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11",
                            Type = @"Field",
                            Position = @"RXA.11",
                            Name = @"Administered-at Location",
                            Length = 200,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"LA2",
                            DataTypeName = @"Location With Address Information (variant 2)",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the inpatient or outpatient location at which the drug or treatment was administered (if applicable). The default (null) value is the current census location for the patient. Site-specific table. The first eight components have the same form as the first eight components of PV1-3-assigned patient location. The final eight components replace the ninth component of PV1-3-assigned patient location and represent the full address specification.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.1",
                            Type = @"Component",
                            Position = @"RXA.11.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.2",
                            Type = @"Component",
                            Position = @"RXA.11.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.3",
                            Type = @"Component",
                            Position = @"RXA.11.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.4",
                            Type = @"Component",
                            Position = @"RXA.11.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.4.1",
                            Type = @"SubComponent",
                            Position = @"RXA.11.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.4.2",
                            Type = @"SubComponent",
                            Position = @"RXA.11.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.4.3",
                            Type = @"SubComponent",
                            Position = @"RXA.11.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.5",
                            Type = @"Component",
                            Position = @"RXA.11.5",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.6",
                            Type = @"Component",
                            Position = @"RXA.11.6",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.7",
                            Type = @"Component",
                            Position = @"RXA.11.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.8",
                            Type = @"Component",
                            Position = @"RXA.11.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.9",
                            Type = @"Component",
                            Position = @"RXA.11.9",
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
                            Id = @"RXA.11.10",
                            Type = @"Component",
                            Position = @"RXA.11.10",
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
                            Id = @"RXA.11.11",
                            Type = @"Component",
                            Position = @"RXA.11.11",
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
                            Id = @"RXA.11.12",
                            Type = @"Component",
                            Position = @"RXA.11.12",
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
                            Id = @"RXA.11.13",
                            Type = @"Component",
                            Position = @"RXA.11.13",
                            Name = @"Zip Or Postal Code",
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
                            Id = @"RXA.11.14",
                            Type = @"Component",
                            Position = @"RXA.11.14",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.15",
                            Type = @"Component",
                            Position = @"RXA.11.15",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.16",
                            Type = @"Component",
                            Position = @"RXA.11.16",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.12",
                            Type = @"Field",
                            Position = @"RXA.12",
                            Name = @"Administered Per",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the rate at which this medication was administered as calculated by using RXA-6-administered amount and RXA-7-administered units. This field is conditional because it is required when a treatment is administered continuously at a prescribed rate, e.g., certain IV solutions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.13",
                            Type = @"Field",
                            Position = @"RXA.13",
                            Name = @"Administered Strength",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Use when RXA-5-administered code does not specify the strength. This is the numeric part of the strength, used in combination with RXA-14-administered strength units.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.14",
                            Type = @"Field",
                            Position = @"RXA.14",
                            Name = @"Administered Strength Units",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"Use when RXA-5-administered code does not specify the strength. This is the unit of the strength, used in combination with RXA-13-administered strength.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.14.1",
                            Type = @"Component",
                            Position = @"RXA.14.1",
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
                            Id = @"RXA.14.2",
                            Type = @"Component",
                            Position = @"RXA.14.2",
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
                            Id = @"RXA.14.3",
                            Type = @"Component",
                            Position = @"RXA.14.3",
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
                            Id = @"RXA.14.4",
                            Type = @"Component",
                            Position = @"RXA.14.4",
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
                            Id = @"RXA.14.5",
                            Type = @"Component",
                            Position = @"RXA.14.5",
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
                            Id = @"RXA.14.6",
                            Type = @"Component",
                            Position = @"RXA.14.6",
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
                            Id = @"RXA.15",
                            Type = @"Field",
                            Position = @"RXA.15",
                            Name = @"Substance Lot Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the lot number of the medical substance administered.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.16",
                            Type = @"Field",
                            Position = @"RXA.16",
                            Name = @"Substance Expiration Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the expiration date of the medical substance administered.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.16.1",
                            Type = @"Component",
                            Position = @"RXA.16.1",
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
                            Id = @"RXA.17",
                            Type = @"Field",
                            Position = @"RXA.17",
                            Name = @"Substance Manufacturer Name",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0227",
                            TableName = @"Manufacturers of vaccines",
                            Description = @"This field contains the manufacturer of the medical substance administered.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.17.1",
                            Type = @"Component",
                            Position = @"RXA.17.1",
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
                            Id = @"RXA.17.2",
                            Type = @"Component",
                            Position = @"RXA.17.2",
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
                            Id = @"RXA.17.3",
                            Type = @"Component",
                            Position = @"RXA.17.3",
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
                            Id = @"RXA.17.4",
                            Type = @"Component",
                            Position = @"RXA.17.4",
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
                            Id = @"RXA.17.5",
                            Type = @"Component",
                            Position = @"RXA.17.5",
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
                            Id = @"RXA.17.6",
                            Type = @"Component",
                            Position = @"RXA.17.6",
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
                            Id = @"RXA.18",
                            Type = @"Field",
                            Position = @"RXA.18",
                            Name = @"Substance Refusal Reason",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the reason the patient refused the medical substance. Any entry in the field indicates that the patient did not take the substance.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.18.1",
                            Type = @"Component",
                            Position = @"RXA.18.1",
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
                            Id = @"RXA.18.2",
                            Type = @"Component",
                            Position = @"RXA.18.2",
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
                            Id = @"RXA.18.3",
                            Type = @"Component",
                            Position = @"RXA.18.3",
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
                            Id = @"RXA.18.4",
                            Type = @"Component",
                            Position = @"RXA.18.4",
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
                            Id = @"RXA.18.5",
                            Type = @"Component",
                            Position = @"RXA.18.5",
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
                            Id = @"RXA.18.6",
                            Type = @"Component",
                            Position = @"RXA.18.6",
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
                            Id = @"RXA.19",
                            Type = @"Field",
                            Position = @"RXA.19",
                            Name = @"Indication",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identifier of the condition or problem for which the drug/treatment was prescribed. May repeat if multiple indications are relevant.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.19.1",
                            Type = @"Component",
                            Position = @"RXA.19.1",
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
                            Id = @"RXA.19.2",
                            Type = @"Component",
                            Position = @"RXA.19.2",
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
                            Id = @"RXA.19.3",
                            Type = @"Component",
                            Position = @"RXA.19.3",
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
                            Id = @"RXA.19.4",
                            Type = @"Component",
                            Position = @"RXA.19.4",
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
                            Id = @"RXA.19.5",
                            Type = @"Component",
                            Position = @"RXA.19.5",
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
                            Id = @"RXA.19.6",
                            Type = @"Component",
                            Position = @"RXA.19.6",
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
                            Id = @"RXA.20",
                            Type = @"Field",
                            Position = @"RXA.20",
                            Name = @"Completion Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0322",
                            TableName = @"Completion status",
                            Description = @"Status of treatment administration event. Refer to HL7 table 0322 - Completion status for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.21",
                            Type = @"Field",
                            Position = @"RXA.21",
                            Name = @"Action Code-RXA",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0323",
                            TableName = @"Action Code",
                            Description = @"Status of record. The information in this field enables the use of the RXA in the vaccine messages (see Section 4.13, 'RXA SEGMENT USAGE IN VACCINE MESSAGES'), where a method of correcting vaccination information transmitted with incorrect patient identifying information is needed. Refer to HL7 table 0323 - Action code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.22",
                            Type = @"Field",
                            Position = @"RXA.22",
                            Name = @"System Entry Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"Date/time the administration information was entered into the source system. This field is used to detect instances where treatment administration information is inadvertently entered multiple times by providing a unique identification field. Under usual circumstances, this field would be provided automatically by the computer system rather than being entered by a person.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RXA.22.1",
                            Type = @"Component",
                            Position = @"RXA.22.1",
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

        public HL7V231SegmentRXA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field giveSubIDCounter;

public HL7V231Field GiveSubIDCounter
{
    get
    {
        if (giveSubIDCounter != null)
        {
            return giveSubIDCounter;
        }

        giveSubIDCounter = new HL7V231Field
        {
            field = message[@"RXA"][1],
            Id = @"RXA.1",
            Type = @"Field",
            Position = @"RXA.1",
            Name = @"Give Sub-ID Counter",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Use this field if matching this RXA segment to its corresponding RXG segment. If the two applications are not matching RXG and RXA segments, this field's value is zero (0).",
            Sample = @"",
        };

        

        

        

        return giveSubIDCounter;
    } 
}
internal HL7V231Field administrationSubIDCounter;

public HL7V231Field AdministrationSubIDCounter
{
    get
    {
        if (administrationSubIDCounter != null)
        {
            return administrationSubIDCounter;
        }

        administrationSubIDCounter = new HL7V231Field
        {
            field = message[@"RXA"][2],
            Id = @"RXA.2",
            Type = @"Field",
            Position = @"RXA.2",
            Name = @"Administration Sub-ID Counter",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field starts with 1 the first time that medication is administered for this order. Increments by one with each additional administration of medication.",
            Sample = @"",
        };

        

        

        

        return administrationSubIDCounter;
    } 
}
internal HL7V231Field dateTimeStartofAdministration;

public HL7V231Field DateTimeStartofAdministration
{
    get
    {
        if (dateTimeStartofAdministration != null)
        {
            return dateTimeStartofAdministration;
        }

        dateTimeStartofAdministration = new HL7V231Field
        {
            field = message[@"RXA"][3],
            Id = @"RXA.3",
            Type = @"Field",
            Position = @"RXA.3",
            Name = @"Date/Time Start of Administration",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If the order is for a continuous administration (such as an IV), and the rate is changed at a certain time after the start, an RAS message can be issued to record the change. For such an RAS message, this field records the time the rate was changed to the new value recorded in the RXA-12-administered per (time unit) of the same message.",
            Sample = @"",
        };

        

        

        

        return dateTimeStartofAdministration;
    } 
}
internal HL7V231Field dateTimeEndofAdministration;

public HL7V231Field DateTimeEndofAdministration
{
    get
    {
        if (dateTimeEndofAdministration != null)
        {
            return dateTimeEndofAdministration;
        }

        dateTimeEndofAdministration = new HL7V231Field
        {
            field = message[@"RXA"][4],
            Id = @"RXA.4",
            Type = @"Field",
            Position = @"RXA.4",
            Name = @"Date/Time End of Administration",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If null, the date/time of RXA-3-date/time start of administration is assumed.",
            Sample = @"",
        };

        

        

        

        return dateTimeEndofAdministration;
    } 
}
internal HL7V231Field administeredCode;

public HL7V231Field AdministeredCode
{
    get
    {
        if (administeredCode != null)
        {
            return administeredCode;
        }

        administeredCode = new HL7V231Field
        {
            field = message[@"RXA"][5],
            Id = @"RXA.5",
            Type = @"Field",
            Position = @"RXA.5",
            Name = @"Administered Code",
            Length = 100,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0292",
            TableName = @"Vaccines administered",
            Description = @"This field contains the identifier of the medical substance administered. It is equivalent to OBR-4-universal service ID in function. If the substance administered is a vaccine, CVX codes may be used to code this field (see HL7 table 0292 - Vaccines administered).",
            Sample = @"",
        };

        

        

        

        return administeredCode;
    } 
}
internal HL7V231Field administeredAmount;

public HL7V231Field AdministeredAmount
{
    get
    {
        if (administeredAmount != null)
        {
            return administeredAmount;
        }

        administeredAmount = new HL7V231Field
        {
            field = message[@"RXA"][6],
            Id = @"RXA.6",
            Type = @"Field",
            Position = @"RXA.6",
            Name = @"Administered Amount",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount administered.",
            Sample = @"",
        };

        

        

        

        return administeredAmount;
    } 
}
internal HL7V231Field administeredUnits;

public HL7V231Field AdministeredUnits
{
    get
    {
        if (administeredUnits != null)
        {
            return administeredUnits;
        }

        administeredUnits = new HL7V231Field
        {
            field = message[@"RXA"][7],
            Id = @"RXA.7",
            Type = @"Field",
            Position = @"RXA.7",
            Name = @"Administered Units",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is conditional because it is required if the administered amount code does not imply units. This field must be in simple units that reflect the actual quantity of the substance administered. It does not include compound units.",
            Sample = @"",
        };

        

        

        

        return administeredUnits;
    } 
}
internal HL7V231Field administeredDosageForm;

public HL7V231Field AdministeredDosageForm
{
    get
    {
        if (administeredDosageForm != null)
        {
            return administeredDosageForm;
        }

        administeredDosageForm = new HL7V231Field
        {
            field = message[@"RXA"][8],
            Id = @"RXA.8",
            Type = @"Field",
            Position = @"RXA.8",
            Name = @"Administered Dosage Form",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"The dosage form indicates the manner in which the medication is aggregated for dispensing, e.g., tablets, capsules, suppositories. In some cases, this information is implied by the dispense/give code in RXA-5-administered code. Use this field when the administered code does not specify the dosage form.",
            Sample = @"",
        };

        

        

        

        return administeredDosageForm;
    } 
}
internal HL7V231Field administrationNotes;

public HL7V231Field AdministrationNotes
{
    get
    {
        if (administrationNotes != null)
        {
            return administrationNotes;
        }

        administrationNotes = new HL7V231Field
        {
            field = message[@"RXA"][9],
            Id = @"RXA.9",
            Type = @"Field",
            Position = @"RXA.9",
            Name = @"Administration Notes",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains notes from the provider administering the medication. If coded, requires a user-defined table. If free text (describing a custom IV, mixture, or salve, for example) place a null in the first component and the text in the second, e.g., |^this is a free text administration note| .",
            Sample = @"",
        };

        

        

        

        return administrationNotes;
    } 
}
internal HL7V231Field administeringProvider;

public HL7V231Field AdministeringProvider
{
    get
    {
        if (administeringProvider != null)
        {
            return administeringProvider;
        }

        administeringProvider = new HL7V231Field
        {
            field = message[@"RXA"][10],
            Id = @"RXA.10",
            Type = @"Field",
            Position = @"RXA.10",
            Name = @"Administering Provider",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field contains the provider ID of the person administering the pharmaceutical.",
            Sample = @"",
        };

        

        

        

        return administeringProvider;
    } 
}
internal HL7V231Field administeredatLocation;

public HL7V231Field AdministeredatLocation
{
    get
    {
        if (administeredatLocation != null)
        {
            return administeredatLocation;
        }

        administeredatLocation = new HL7V231Field
        {
            field = message[@"RXA"][11],
            Id = @"RXA.11",
            Type = @"Field",
            Position = @"RXA.11",
            Name = @"Administered-at Location",
            Length = 200,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"LA2",
            DataTypeName = @"Location With Address Information (variant 2)",
            TableId = null,
            TableName = null,
            Description = @"The first component contains the inpatient or outpatient location at which the drug or treatment was administered (if applicable). The default (null) value is the current census location for the patient. Site-specific table. The first eight components have the same form as the first eight components of PV1-3-assigned patient location. The final eight components replace the ninth component of PV1-3-assigned patient location and represent the full address specification.",
            Sample = @"",
        };

        

        

        

        return administeredatLocation;
    } 
}
internal HL7V231Field administeredPer;

public HL7V231Field AdministeredPer
{
    get
    {
        if (administeredPer != null)
        {
            return administeredPer;
        }

        administeredPer = new HL7V231Field
        {
            field = message[@"RXA"][12],
            Id = @"RXA.12",
            Type = @"Field",
            Position = @"RXA.12",
            Name = @"Administered Per",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the rate at which this medication was administered as calculated by using RXA-6-administered amount and RXA-7-administered units. This field is conditional because it is required when a treatment is administered continuously at a prescribed rate, e.g., certain IV solutions.",
            Sample = @"",
        };

        

        

        

        return administeredPer;
    } 
}
internal HL7V231Field administeredStrength;

public HL7V231Field AdministeredStrength
{
    get
    {
        if (administeredStrength != null)
        {
            return administeredStrength;
        }

        administeredStrength = new HL7V231Field
        {
            field = message[@"RXA"][13],
            Id = @"RXA.13",
            Type = @"Field",
            Position = @"RXA.13",
            Name = @"Administered Strength",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Use when RXA-5-administered code does not specify the strength. This is the numeric part of the strength, used in combination with RXA-14-administered strength units.",
            Sample = @"",
        };

        

        

        

        return administeredStrength;
    } 
}
internal HL7V231Field administeredStrengthUnits;

public HL7V231Field AdministeredStrengthUnits
{
    get
    {
        if (administeredStrengthUnits != null)
        {
            return administeredStrengthUnits;
        }

        administeredStrengthUnits = new HL7V231Field
        {
            field = message[@"RXA"][14],
            Id = @"RXA.14",
            Type = @"Field",
            Position = @"RXA.14",
            Name = @"Administered Strength Units",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"Use when RXA-5-administered code does not specify the strength. This is the unit of the strength, used in combination with RXA-13-administered strength.",
            Sample = @"",
        };

        

        

        

        return administeredStrengthUnits;
    } 
}
internal HL7V231Field substanceLotNumber;

public HL7V231Field SubstanceLotNumber
{
    get
    {
        if (substanceLotNumber != null)
        {
            return substanceLotNumber;
        }

        substanceLotNumber = new HL7V231Field
        {
            field = message[@"RXA"][15],
            Id = @"RXA.15",
            Type = @"Field",
            Position = @"RXA.15",
            Name = @"Substance Lot Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the lot number of the medical substance administered.",
            Sample = @"",
        };

        

        

        

        return substanceLotNumber;
    } 
}
internal HL7V231Field substanceExpirationDate;

public HL7V231Field SubstanceExpirationDate
{
    get
    {
        if (substanceExpirationDate != null)
        {
            return substanceExpirationDate;
        }

        substanceExpirationDate = new HL7V231Field
        {
            field = message[@"RXA"][16],
            Id = @"RXA.16",
            Type = @"Field",
            Position = @"RXA.16",
            Name = @"Substance Expiration Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date of the medical substance administered.",
            Sample = @"",
        };

        

        

        

        return substanceExpirationDate;
    } 
}
internal HL7V231Field substanceManufacturerName;

public HL7V231Field SubstanceManufacturerName
{
    get
    {
        if (substanceManufacturerName != null)
        {
            return substanceManufacturerName;
        }

        substanceManufacturerName = new HL7V231Field
        {
            field = message[@"RXA"][17],
            Id = @"RXA.17",
            Type = @"Field",
            Position = @"RXA.17",
            Name = @"Substance Manufacturer Name",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0227",
            TableName = @"Manufacturers of vaccines",
            Description = @"This field contains the manufacturer of the medical substance administered.",
            Sample = @"",
        };

        

        

        

        return substanceManufacturerName;
    } 
}
internal HL7V231Field substanceRefusalReason;

public HL7V231Field SubstanceRefusalReason
{
    get
    {
        if (substanceRefusalReason != null)
        {
            return substanceRefusalReason;
        }

        substanceRefusalReason = new HL7V231Field
        {
            field = message[@"RXA"][18],
            Id = @"RXA.18",
            Type = @"Field",
            Position = @"RXA.18",
            Name = @"Substance Refusal Reason",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the reason the patient refused the medical substance. Any entry in the field indicates that the patient did not take the substance.",
            Sample = @"",
        };

        

        

        

        return substanceRefusalReason;
    } 
}
internal HL7V231Field indication;

public HL7V231Field Indication
{
    get
    {
        if (indication != null)
        {
            return indication;
        }

        indication = new HL7V231Field
        {
            field = message[@"RXA"][19],
            Id = @"RXA.19",
            Type = @"Field",
            Position = @"RXA.19",
            Name = @"Indication",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier of the condition or problem for which the drug/treatment was prescribed. May repeat if multiple indications are relevant.",
            Sample = @"",
        };

        

        

        

        return indication;
    } 
}
internal HL7V231Field completionStatus;

public HL7V231Field CompletionStatus
{
    get
    {
        if (completionStatus != null)
        {
            return completionStatus;
        }

        completionStatus = new HL7V231Field
        {
            field = message[@"RXA"][20],
            Id = @"RXA.20",
            Type = @"Field",
            Position = @"RXA.20",
            Name = @"Completion Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0322",
            TableName = @"Completion status",
            Description = @"Status of treatment administration event. Refer to HL7 table 0322 - Completion status for valid values.",
            Sample = @"",
        };

        

        

        

        return completionStatus;
    } 
}
internal HL7V231Field actionCodeRXA;

public HL7V231Field ActionCodeRXA
{
    get
    {
        if (actionCodeRXA != null)
        {
            return actionCodeRXA;
        }

        actionCodeRXA = new HL7V231Field
        {
            field = message[@"RXA"][21],
            Id = @"RXA.21",
            Type = @"Field",
            Position = @"RXA.21",
            Name = @"Action Code-RXA",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0323",
            TableName = @"Action Code",
            Description = @"Status of record. The information in this field enables the use of the RXA in the vaccine messages (see Section 4.13, 'RXA SEGMENT USAGE IN VACCINE MESSAGES'), where a method of correcting vaccination information transmitted with incorrect patient identifying information is needed. Refer to HL7 table 0323 - Action code for valid values.",
            Sample = @"",
        };

        

        

        

        return actionCodeRXA;
    } 
}
internal HL7V231Field systemEntryDateTime;

public HL7V231Field SystemEntryDateTime
{
    get
    {
        if (systemEntryDateTime != null)
        {
            return systemEntryDateTime;
        }

        systemEntryDateTime = new HL7V231Field
        {
            field = message[@"RXA"][22],
            Id = @"RXA.22",
            Type = @"Field",
            Position = @"RXA.22",
            Name = @"System Entry Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"Date/time the administration information was entered into the source system. This field is used to detect instances where treatment administration information is inadvertently entered multiple times by providing a unique identification field. Under usual circumstances, this field would be provided automatically by the computer system rather than being entered by a person.",
            Sample = @"",
        };

        

        

        

        return systemEntryDateTime;
    } 
}

    }
}
