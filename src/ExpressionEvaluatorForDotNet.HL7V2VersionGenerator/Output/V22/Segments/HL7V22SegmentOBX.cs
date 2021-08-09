using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentOBX
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OBX"; } }

        public string SegmentId { get { return @"OBX"; } }
        
        public string LongName { get { return @"Observation Result"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

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
                            Id = @"OBX.1",
                            Type = @"Field",
                            Position = @"OBX.1",
                            Name = @"Set Id - Observational Simple",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.2",
                            Type = @"Field",
                            Position = @"OBX.2",
                            Name = @"Value Type",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0125",
                            TableName = @"VALUE TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.3",
                            Type = @"Field",
                            Position = @"OBX.3",
                            Name = @"Observation Identifier",
                            Length = 80,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBX.3.1",
                            Type = @"Component",
                            Position = @"OBX.3.1",
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
                            Id = @"OBX.3.2",
                            Type = @"Component",
                            Position = @"OBX.3.2",
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
                            Id = @"OBX.3.3",
                            Type = @"Component",
                            Position = @"OBX.3.3",
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
                            Id = @"OBX.3.4",
                            Type = @"Component",
                            Position = @"OBX.3.4",
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
                            Id = @"OBX.3.5",
                            Type = @"Component",
                            Position = @"OBX.3.5",
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
                            Id = @"OBX.3.6",
                            Type = @"Component",
                            Position = @"OBX.3.6",
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
                            Id = @"OBX.4",
                            Type = @"Field",
                            Position = @"OBX.4",
                            Name = @"Observation Sub-id",
                            Length = 20,
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
                            Id = @"OBX.5",
                            Type = @"Field",
                            Position = @"OBX.5",
                            Name = @"Observation Value",
                            Length = 65536,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"VARIES",
                            DataTypeName = @"Variable Datatype",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.6",
                            Type = @"Field",
                            Position = @"OBX.6",
                            Name = @"Units",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBX.6.1",
                            Type = @"Component",
                            Position = @"OBX.6.1",
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
                            Id = @"OBX.6.2",
                            Type = @"Component",
                            Position = @"OBX.6.2",
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
                            Id = @"OBX.6.3",
                            Type = @"Component",
                            Position = @"OBX.6.3",
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
                            Id = @"OBX.6.4",
                            Type = @"Component",
                            Position = @"OBX.6.4",
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
                            Id = @"OBX.6.5",
                            Type = @"Component",
                            Position = @"OBX.6.5",
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
                            Id = @"OBX.6.6",
                            Type = @"Component",
                            Position = @"OBX.6.6",
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
                            Id = @"OBX.7",
                            Type = @"Field",
                            Position = @"OBX.7",
                            Name = @"References Range",
                            Length = 60,
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
                            Id = @"OBX.8",
                            Type = @"Field",
                            Position = @"OBX.8",
                            Name = @"Abnormal Flags",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"5",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0078",
                            TableName = @"ABNORMAL FLAGS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.9",
                            Type = @"Field",
                            Position = @"OBX.9",
                            Name = @"Probability",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.10",
                            Type = @"Field",
                            Position = @"OBX.10",
                            Name = @"Nature Of Abnormal Test",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0080",
                            TableName = @"NATURE OF ABNORMAL TESTING",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.11",
                            Type = @"Field",
                            Position = @"OBX.11",
                            Name = @"Observation Result Status",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0085",
                            TableName = @"OBSERVATION RESULT STATUS CODES INTERPRETATION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.12",
                            Type = @"Field",
                            Position = @"OBX.12",
                            Name = @"Effective Date Last Observation Normal Values",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBX.12.1",
                            Type = @"Component",
                            Position = @"OBX.12.1",
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
                            Id = @"OBX.12.2",
                            Type = @"Component",
                            Position = @"OBX.12.2",
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
                            Id = @"OBX.13",
                            Type = @"Field",
                            Position = @"OBX.13",
                            Name = @"User Defined Access Checks",
                            Length = 20,
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
                            Id = @"OBX.14",
                            Type = @"Field",
                            Position = @"OBX.14",
                            Name = @"Date / Time Of The Observation",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBX.14.1",
                            Type = @"Component",
                            Position = @"OBX.14.1",
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
                            Id = @"OBX.14.2",
                            Type = @"Component",
                            Position = @"OBX.14.2",
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
                            Id = @"OBX.15",
                            Type = @"Field",
                            Position = @"OBX.15",
                            Name = @"Producer's Id",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBX.15.1",
                            Type = @"Component",
                            Position = @"OBX.15.1",
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
                            Id = @"OBX.15.2",
                            Type = @"Component",
                            Position = @"OBX.15.2",
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
                            Id = @"OBX.15.3",
                            Type = @"Component",
                            Position = @"OBX.15.3",
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
                            Id = @"OBX.15.4",
                            Type = @"Component",
                            Position = @"OBX.15.4",
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
                            Id = @"OBX.15.5",
                            Type = @"Component",
                            Position = @"OBX.15.5",
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
                            Id = @"OBX.15.6",
                            Type = @"Component",
                            Position = @"OBX.15.6",
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
                            Id = @"OBX.16",
                            Type = @"Field",
                            Position = @"OBX.16",
                            Name = @"Responsible Observer",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PHYSICIAN",
                            DataTypeName = @"Cn For Physicians",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBX.16.1",
                            Type = @"Component",
                            Position = @"OBX.16.1",
                            Name = @"Physician Id",
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
                            Id = @"OBX.16.2",
                            Type = @"Component",
                            Position = @"OBX.16.2",
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
                            Id = @"OBX.16.3",
                            Type = @"Component",
                            Position = @"OBX.16.3",
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
                            Id = @"OBX.16.4",
                            Type = @"Component",
                            Position = @"OBX.16.4",
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
                            Id = @"OBX.16.5",
                            Type = @"Component",
                            Position = @"OBX.16.5",
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
                            Id = @"OBX.16.6",
                            Type = @"Component",
                            Position = @"OBX.16.6",
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
                            Id = @"OBX.16.7",
                            Type = @"Component",
                            Position = @"OBX.16.7",
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
                            Id = @"OBX.16.8",
                            Type = @"Component",
                            Position = @"OBX.16.8",
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
                        };
            }
        }

        public HL7V22SegmentOBX(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field setIdObservationalSimple;

public HL7V22Field SetIdObservationalSimple
{
    get
    {
        if (setIdObservationalSimple != null)
        {
            return setIdObservationalSimple;
        }

        setIdObservationalSimple = new HL7V22Field
        {
            field = message[@"OBX"][1],
            Id = @"OBX.1",
            Type = @"Field",
            Position = @"OBX.1",
            Name = @"Set Id - Observational Simple",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (setIdObservationalSimple.field.FieldRepetitions != null && setIdObservationalSimple.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdObservationalSimple.Id));
            setIdObservationalSimple.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(setIdObservationalSimple, fieldData);
        }

        return setIdObservationalSimple;
    } 
}

internal HL7V22Field valueType;

public HL7V22Field ValueType
{
    get
    {
        if (valueType != null)
        {
            return valueType;
        }

        valueType = new HL7V22Field
        {
            field = message[@"OBX"][2],
            Id = @"OBX.2",
            Type = @"Field",
            Position = @"OBX.2",
            Name = @"Value Type",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0125",
            TableName = @"VALUE TYPE",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (valueType.field.FieldRepetitions != null && valueType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(valueType.Id));
            valueType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(valueType, fieldData);
        }

        return valueType;
    } 
}

internal HL7V22Field observationIdentifier;

public HL7V22Field ObservationIdentifier
{
    get
    {
        if (observationIdentifier != null)
        {
            return observationIdentifier;
        }

        observationIdentifier = new HL7V22Field
        {
            field = message[@"OBX"][3],
            Id = @"OBX.3",
            Type = @"Field",
            Position = @"OBX.3",
            Name = @"Observation Identifier",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (observationIdentifier.field.FieldRepetitions != null && observationIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(observationIdentifier.Id));
            observationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(observationIdentifier, fieldData);
        }

        return observationIdentifier;
    } 
}

internal HL7V22Field observationSubid;

public HL7V22Field ObservationSubid
{
    get
    {
        if (observationSubid != null)
        {
            return observationSubid;
        }

        observationSubid = new HL7V22Field
        {
            field = message[@"OBX"][4],
            Id = @"OBX.4",
            Type = @"Field",
            Position = @"OBX.4",
            Name = @"Observation Sub-id",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (observationSubid.field.FieldRepetitions != null && observationSubid.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(observationSubid.Id));
            observationSubid.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(observationSubid, fieldData);
        }

        return observationSubid;
    } 
}

internal HL7V22Field observationValue;

public HL7V22Field ObservationValue
{
    get
    {
        if (observationValue != null)
        {
            return observationValue;
        }

        observationValue = new HL7V22Field
        {
            field = message[@"OBX"][5],
            Id = @"OBX.5",
            Type = @"Field",
            Position = @"OBX.5",
            Name = @"Observation Value",
            Length = 65536,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (observationValue.field.FieldRepetitions != null && observationValue.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(observationValue.Id));
            observationValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(observationValue, fieldData);
        }

        return observationValue;
    } 
}

internal HL7V22Field units;

public HL7V22Field Units
{
    get
    {
        if (units != null)
        {
            return units;
        }

        units = new HL7V22Field
        {
            field = message[@"OBX"][6],
            Id = @"OBX.6",
            Type = @"Field",
            Position = @"OBX.6",
            Name = @"Units",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (units.field.FieldRepetitions != null && units.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(units.Id));
            units.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(units, fieldData);
        }

        return units;
    } 
}

internal HL7V22Field referencesRange;

public HL7V22Field ReferencesRange
{
    get
    {
        if (referencesRange != null)
        {
            return referencesRange;
        }

        referencesRange = new HL7V22Field
        {
            field = message[@"OBX"][7],
            Id = @"OBX.7",
            Type = @"Field",
            Position = @"OBX.7",
            Name = @"References Range",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (referencesRange.field.FieldRepetitions != null && referencesRange.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referencesRange.Id));
            referencesRange.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(referencesRange, fieldData);
        }

        return referencesRange;
    } 
}

internal HL7V22Field abnormalFlags;

public HL7V22Field AbnormalFlags
{
    get
    {
        if (abnormalFlags != null)
        {
            return abnormalFlags;
        }

        abnormalFlags = new HL7V22Field
        {
            field = message[@"OBX"][8],
            Id = @"OBX.8",
            Type = @"Field",
            Position = @"OBX.8",
            Name = @"Abnormal Flags",
            Length = 10,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0078",
            TableName = @"ABNORMAL FLAGS",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (abnormalFlags.field.FieldRepetitions != null && abnormalFlags.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(abnormalFlags.Id));
            abnormalFlags.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(abnormalFlags, fieldData);
        }

        return abnormalFlags;
    } 
}

internal HL7V22Field probability;

public HL7V22Field Probability
{
    get
    {
        if (probability != null)
        {
            return probability;
        }

        probability = new HL7V22Field
        {
            field = message[@"OBX"][9],
            Id = @"OBX.9",
            Type = @"Field",
            Position = @"OBX.9",
            Name = @"Probability",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (probability.field.FieldRepetitions != null && probability.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(probability.Id));
            probability.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(probability, fieldData);
        }

        return probability;
    } 
}

internal HL7V22Field natureOfAbnormalTest;

public HL7V22Field NatureOfAbnormalTest
{
    get
    {
        if (natureOfAbnormalTest != null)
        {
            return natureOfAbnormalTest;
        }

        natureOfAbnormalTest = new HL7V22Field
        {
            field = message[@"OBX"][10],
            Id = @"OBX.10",
            Type = @"Field",
            Position = @"OBX.10",
            Name = @"Nature Of Abnormal Test",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0080",
            TableName = @"NATURE OF ABNORMAL TESTING",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (natureOfAbnormalTest.field.FieldRepetitions != null && natureOfAbnormalTest.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(natureOfAbnormalTest.Id));
            natureOfAbnormalTest.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(natureOfAbnormalTest, fieldData);
        }

        return natureOfAbnormalTest;
    } 
}

internal HL7V22Field observationResultStatus;

public HL7V22Field ObservationResultStatus
{
    get
    {
        if (observationResultStatus != null)
        {
            return observationResultStatus;
        }

        observationResultStatus = new HL7V22Field
        {
            field = message[@"OBX"][11],
            Id = @"OBX.11",
            Type = @"Field",
            Position = @"OBX.11",
            Name = @"Observation Result Status",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0085",
            TableName = @"OBSERVATION RESULT STATUS CODES INTERPRETATION",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (observationResultStatus.field.FieldRepetitions != null && observationResultStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(observationResultStatus.Id));
            observationResultStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(observationResultStatus, fieldData);
        }

        return observationResultStatus;
    } 
}

internal HL7V22Field effectiveDateLastObservationNormalValues;

public HL7V22Field EffectiveDateLastObservationNormalValues
{
    get
    {
        if (effectiveDateLastObservationNormalValues != null)
        {
            return effectiveDateLastObservationNormalValues;
        }

        effectiveDateLastObservationNormalValues = new HL7V22Field
        {
            field = message[@"OBX"][12],
            Id = @"OBX.12",
            Type = @"Field",
            Position = @"OBX.12",
            Name = @"Effective Date Last Observation Normal Values",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (effectiveDateLastObservationNormalValues.field.FieldRepetitions != null && effectiveDateLastObservationNormalValues.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(effectiveDateLastObservationNormalValues.Id));
            effectiveDateLastObservationNormalValues.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(effectiveDateLastObservationNormalValues, fieldData);
        }

        return effectiveDateLastObservationNormalValues;
    } 
}

internal HL7V22Field userDefinedAccessChecks;

public HL7V22Field UserDefinedAccessChecks
{
    get
    {
        if (userDefinedAccessChecks != null)
        {
            return userDefinedAccessChecks;
        }

        userDefinedAccessChecks = new HL7V22Field
        {
            field = message[@"OBX"][13],
            Id = @"OBX.13",
            Type = @"Field",
            Position = @"OBX.13",
            Name = @"User Defined Access Checks",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (userDefinedAccessChecks.field.FieldRepetitions != null && userDefinedAccessChecks.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(userDefinedAccessChecks.Id));
            userDefinedAccessChecks.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(userDefinedAccessChecks, fieldData);
        }

        return userDefinedAccessChecks;
    } 
}

internal HL7V22Field dateTimeOfTheObservation;

public HL7V22Field DateTimeOfTheObservation
{
    get
    {
        if (dateTimeOfTheObservation != null)
        {
            return dateTimeOfTheObservation;
        }

        dateTimeOfTheObservation = new HL7V22Field
        {
            field = message[@"OBX"][14],
            Id = @"OBX.14",
            Type = @"Field",
            Position = @"OBX.14",
            Name = @"Date / Time Of The Observation",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (dateTimeOfTheObservation.field.FieldRepetitions != null && dateTimeOfTheObservation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateTimeOfTheObservation.Id));
            dateTimeOfTheObservation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dateTimeOfTheObservation, fieldData);
        }

        return dateTimeOfTheObservation;
    } 
}

internal HL7V22Field producersId;

public HL7V22Field ProducersId
{
    get
    {
        if (producersId != null)
        {
            return producersId;
        }

        producersId = new HL7V22Field
        {
            field = message[@"OBX"][15],
            Id = @"OBX.15",
            Type = @"Field",
            Position = @"OBX.15",
            Name = @"Producer's Id",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (producersId.field.FieldRepetitions != null && producersId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(producersId.Id));
            producersId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(producersId, fieldData);
        }

        return producersId;
    } 
}

internal HL7V22Field responsibleObserver;

public HL7V22Field ResponsibleObserver
{
    get
    {
        if (responsibleObserver != null)
        {
            return responsibleObserver;
        }

        responsibleObserver = new HL7V22Field
        {
            field = message[@"OBX"][16],
            Id = @"OBX.16",
            Type = @"Field",
            Position = @"OBX.16",
            Name = @"Responsible Observer",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PHYSICIAN",
            DataTypeName = @"Cn For Physicians",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (responsibleObserver.field.FieldRepetitions != null && responsibleObserver.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(responsibleObserver.Id));
            responsibleObserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(responsibleObserver, fieldData);
        }

        return responsibleObserver;
    } 
}
    }
}
