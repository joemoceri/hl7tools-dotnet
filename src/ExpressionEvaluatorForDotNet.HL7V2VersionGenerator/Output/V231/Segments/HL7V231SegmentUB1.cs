using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentUB1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB1"; } }

        public string SegmentId { get { return @"UB1"; } }
        
        public string LongName { get { return @"UB82 data segment"; } }
        
        public string Description { get { return @"The UB1 segment contains the data necessary to complete UB82 bills. Only UB82 fields that do not exist in other HL7 defined segments appear in this segment. Patient Name and Date of Birth are required for UB82 billing; however, they are included in the PID segment and therefore do not appear here. The UB codes listed as examples are not an exhaustive or current list. Refer to a UB specification for additional information."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Id = @"UB1.1",
                            Type = @"Field",
                            Position = @"UB1.1",
                            Name = @"Set ID - UB1",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.2",
                            Type = @"Field",
                            Position = @"UB1.2",
                            Name = @"Blood Deductible",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has been retained for backward compatibility only. Use IN2-21-blood deductible instead of this field, as the blood deductible can be associated with the specific insurance plan via that segment. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.3",
                            Type = @"Field",
                            Position = @"UB1.3",
                            Name = @"Blood Furnished-Pints Of",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the amount of blood furnished to the patient for this visit. The (40) indicates the corresponding UB82 field number. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.4",
                            Type = @"Field",
                            Position = @"UB1.4",
                            Name = @"Blood Replaced-Pints",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains UB82 Field 41. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.5",
                            Type = @"Field",
                            Position = @"UB1.5",
                            Name = @"Blood Not Replaced-Pints",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the blood not replaced, as measured in pints. UB82 Field 42. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.6",
                            Type = @"Field",
                            Position = @"UB1.6",
                            Name = @"Co-Insurance Days",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains UB82 Field 25. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.7",
                            Type = @"Field",
                            Position = @"UB1.7",
                            Name = @"Condition Code",
                            Length = 14,
                            Usage = @"O",
                            Rpt = @"5",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0043",
                            TableName = @"Condition code",
                            Description = @"The code in this field repeats five times. UB82 Fields (35), (36), (37), (38), and (39). Refer to user-definedtable 0043 - Condition code in UB2-3 for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.8",
                            Type = @"Field",
                            Position = @"UB1.8",
                            Name = @"Covered Days -",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains UB82 Field 23. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.9",
                            Type = @"Field",
                            Position = @"UB1.9",
                            Name = @"Non Covered Days -",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains UB82 Field 24. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10",
                            Type = @"Field",
                            Position = @"UB1.10",
                            Name = @"Value Amount & Code",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"8",
                            DataType = @"UVC",
                            DataTypeName = @"Value Code And Amount",
                            TableId = null,
                            TableName = null,
                            Description = @"The pair in this field can repeat up to eight times (46A, 47A, 48A, 49A, 46B, 47B, 48B, and 49B). Refer to user-definedtable 0153 - Value code in UB2-6 for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB1.10.1",
                            Type = @"Component",
                            Position = @"UB1.10.1",
                            Name = @"Value Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0153",
                            TableName = @"Value code",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.2",
                            Type = @"Component",
                            Position = @"UB1.10.2",
                            Name = @"Value Amount",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.11",
                            Type = @"Field",
                            Position = @"UB1.11",
                            Name = @"Number Of Grace Days",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains UB82 Field 90. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12",
                            Type = @"Field",
                            Position = @"UB1.12",
                            Name = @"Special Program Indicator",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0348",
                            TableName = @"Special program indicator",
                            Description = @"This field contains the special program indicator. UB82 Field 44. This field is defined by HCFA or other regulatory agencies. Refer to user-defined table 0348 - Special program indicator for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB1.12.1",
                            Type = @"Component",
                            Position = @"UB1.12.1",
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
                            Id = @"UB1.12.2",
                            Type = @"Component",
                            Position = @"UB1.12.2",
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
                            Id = @"UB1.12.3",
                            Type = @"Component",
                            Position = @"UB1.12.3",
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
                            Id = @"UB1.12.4",
                            Type = @"Component",
                            Position = @"UB1.12.4",
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
                            Id = @"UB1.12.5",
                            Type = @"Component",
                            Position = @"UB1.12.5",
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
                            Id = @"UB1.12.6",
                            Type = @"Component",
                            Position = @"UB1.12.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13",
                            Type = @"Field",
                            Position = @"UB1.13",
                            Name = @"PSRO/UR Approval Indicator",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0349",
                            TableName = @"PSRO/UR approval indicator",
                            Description = @"This field contains the PSRO/UR approval indicator. UB82 field 87. This field is defined by HCFA or other regulatory agencies. Refer to user-defined table 0349 - PSRO/UR approval indicator for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB1.13.1",
                            Type = @"Component",
                            Position = @"UB1.13.1",
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
                            Id = @"UB1.13.2",
                            Type = @"Component",
                            Position = @"UB1.13.2",
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
                            Id = @"UB1.13.3",
                            Type = @"Component",
                            Position = @"UB1.13.3",
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
                            Id = @"UB1.13.4",
                            Type = @"Component",
                            Position = @"UB1.13.4",
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
                            Id = @"UB1.13.5",
                            Type = @"Component",
                            Position = @"UB1.13.5",
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
                            Id = @"UB1.13.6",
                            Type = @"Component",
                            Position = @"UB1.13.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.14",
                            Type = @"Field",
                            Position = @"UB1.14",
                            Name = @"PSRO/UR Approved Stay-Fm",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the PSRO/UR approved stay date (from). UB82 Field 88. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.15",
                            Type = @"Field",
                            Position = @"UB1.15",
                            Name = @"PSRO/UR Approved Stay-To",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the PSRO/UR approved stay date (to). UB82 Field 89. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16",
                            Type = @"Field",
                            Position = @"UB1.16",
                            Name = @"Occurrence",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"5",
                            DataType = @"OCD",
                            DataTypeName = @"Occurence",
                            TableId = null,
                            TableName = null,
                            Description = @"The set of values in this field can repeat up to five times. UB82 Fields 28-32. This field is defined by HCFA or other regulatory agencies. User-defined table 0350 - Occurrencecode (see UB2-7) is used as the HL7 identifier for the user-defined table of values for this field. Refer to a UB specification for additional information.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB1.16.1",
                            Type = @"Component",
                            Position = @"UB1.16.1",
                            Name = @"Occurrence Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0350",
                            TableName = @"Occurrence code",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.2",
                            Type = @"Component",
                            Position = @"UB1.16.2",
                            Name = @"Occurrence Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17",
                            Type = @"Field",
                            Position = @"UB1.17",
                            Name = @"Occurrence Span",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0351",
                            TableName = @"Occurrence span",
                            Description = @"UB82 Field 33. This field is defined by HCFA or other regulatory agencies. Refer to user-defined table 0351- Occurrence span in UB2-8 for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB1.17.1",
                            Type = @"Component",
                            Position = @"UB1.17.1",
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
                            Id = @"UB1.17.2",
                            Type = @"Component",
                            Position = @"UB1.17.2",
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
                            Id = @"UB1.17.3",
                            Type = @"Component",
                            Position = @"UB1.17.3",
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
                            Id = @"UB1.17.4",
                            Type = @"Component",
                            Position = @"UB1.17.4",
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
                            Id = @"UB1.17.5",
                            Type = @"Component",
                            Position = @"UB1.17.5",
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
                            Id = @"UB1.17.6",
                            Type = @"Component",
                            Position = @"UB1.17.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.18",
                            Type = @"Field",
                            Position = @"UB1.18",
                            Name = @"Occur Span Start Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the occurrence span start date. UB82 Field 33. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.19",
                            Type = @"Field",
                            Position = @"UB1.19",
                            Name = @"Occur Span End Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the occurrence span end date. UB82 Field 33. This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.20",
                            Type = @"Field",
                            Position = @"UB1.20",
                            Name = @"UB-82 Locator 2",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined by UB-82 HCFA specification.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.21",
                            Type = @"Field",
                            Position = @"UB1.21",
                            Name = @"UB-82 Locator 9",
                            Length = 7,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined by UB-82 HCFA specification.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.22",
                            Type = @"Field",
                            Position = @"UB1.22",
                            Name = @"UB-82 Locator 27",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined by UB-82 HCFA specification.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.23",
                            Type = @"Field",
                            Position = @"UB1.23",
                            Name = @"UB-82 Locator 45",
                            Length = 17,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined by UB-82 HCFA specification.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V231SegmentUB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field setIDUB1;

public HL7V231Field SetIDUB1
{
    get
    {
        if (setIDUB1 != null)
        {
            return setIDUB1;
        }

        setIDUB1 = new HL7V231Field
        {
            field = message[@"UB1"][1],
            Id = @"UB1.1",
            Type = @"Field",
            Position = @"UB1.1",
            Name = @"Set ID - UB1",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc.",
            Sample = @"",
        };

        // check for repetitions
        if (setIDUB1.field.FieldRepetitions != null && setIDUB1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDUB1.Id));
            setIDUB1.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(setIDUB1, fieldData);
        }

        return setIDUB1;
    } 
}

internal HL7V231Field bloodDeductible;

public HL7V231Field BloodDeductible
{
    get
    {
        if (bloodDeductible != null)
        {
            return bloodDeductible;
        }

        bloodDeductible = new HL7V231Field
        {
            field = message[@"UB1"][2],
            Id = @"UB1.2",
            Type = @"Field",
            Position = @"UB1.2",
            Name = @"Blood Deductible",
            Length = 1,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only. Use IN2-21-blood deductible instead of this field, as the blood deductible can be associated with the specific insurance plan via that segment. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (bloodDeductible.field.FieldRepetitions != null && bloodDeductible.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(bloodDeductible.Id));
            bloodDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(bloodDeductible, fieldData);
        }

        return bloodDeductible;
    } 
}

internal HL7V231Field bloodFurnishedPintsOf;

public HL7V231Field BloodFurnishedPintsOf
{
    get
    {
        if (bloodFurnishedPintsOf != null)
        {
            return bloodFurnishedPintsOf;
        }

        bloodFurnishedPintsOf = new HL7V231Field
        {
            field = message[@"UB1"][3],
            Id = @"UB1.3",
            Type = @"Field",
            Position = @"UB1.3",
            Name = @"Blood Furnished-Pints Of",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the amount of blood furnished to the patient for this visit. The (40) indicates the corresponding UB82 field number. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (bloodFurnishedPintsOf.field.FieldRepetitions != null && bloodFurnishedPintsOf.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(bloodFurnishedPintsOf.Id));
            bloodFurnishedPintsOf.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(bloodFurnishedPintsOf, fieldData);
        }

        return bloodFurnishedPintsOf;
    } 
}

internal HL7V231Field bloodReplacedPints;

public HL7V231Field BloodReplacedPints
{
    get
    {
        if (bloodReplacedPints != null)
        {
            return bloodReplacedPints;
        }

        bloodReplacedPints = new HL7V231Field
        {
            field = message[@"UB1"][4],
            Id = @"UB1.4",
            Type = @"Field",
            Position = @"UB1.4",
            Name = @"Blood Replaced-Pints",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 41. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (bloodReplacedPints.field.FieldRepetitions != null && bloodReplacedPints.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(bloodReplacedPints.Id));
            bloodReplacedPints.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(bloodReplacedPints, fieldData);
        }

        return bloodReplacedPints;
    } 
}

internal HL7V231Field bloodNotReplacedPints;

public HL7V231Field BloodNotReplacedPints
{
    get
    {
        if (bloodNotReplacedPints != null)
        {
            return bloodNotReplacedPints;
        }

        bloodNotReplacedPints = new HL7V231Field
        {
            field = message[@"UB1"][5],
            Id = @"UB1.5",
            Type = @"Field",
            Position = @"UB1.5",
            Name = @"Blood Not Replaced-Pints",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the blood not replaced, as measured in pints. UB82 Field 42. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (bloodNotReplacedPints.field.FieldRepetitions != null && bloodNotReplacedPints.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(bloodNotReplacedPints.Id));
            bloodNotReplacedPints.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(bloodNotReplacedPints, fieldData);
        }

        return bloodNotReplacedPints;
    } 
}

internal HL7V231Field coInsuranceDays;

public HL7V231Field CoInsuranceDays
{
    get
    {
        if (coInsuranceDays != null)
        {
            return coInsuranceDays;
        }

        coInsuranceDays = new HL7V231Field
        {
            field = message[@"UB1"][6],
            Id = @"UB1.6",
            Type = @"Field",
            Position = @"UB1.6",
            Name = @"Co-Insurance Days",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 25. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (coInsuranceDays.field.FieldRepetitions != null && coInsuranceDays.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(coInsuranceDays.Id));
            coInsuranceDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(coInsuranceDays, fieldData);
        }

        return coInsuranceDays;
    } 
}

internal HL7V231Field conditionCode;

public HL7V231Field ConditionCode
{
    get
    {
        if (conditionCode != null)
        {
            return conditionCode;
        }

        conditionCode = new HL7V231Field
        {
            field = message[@"UB1"][7],
            Id = @"UB1.7",
            Type = @"Field",
            Position = @"UB1.7",
            Name = @"Condition Code",
            Length = 14,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0043",
            TableName = @"Condition code",
            Description = @"The code in this field repeats five times. UB82 Fields (35), (36), (37), (38), and (39). Refer to user-definedtable 0043 - Condition code in UB2-3 for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (conditionCode.field.FieldRepetitions != null && conditionCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(conditionCode.Id));
            conditionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(conditionCode, fieldData);
        }

        return conditionCode;
    } 
}

internal HL7V231Field coveredDays;

public HL7V231Field CoveredDays
{
    get
    {
        if (coveredDays != null)
        {
            return coveredDays;
        }

        coveredDays = new HL7V231Field
        {
            field = message[@"UB1"][8],
            Id = @"UB1.8",
            Type = @"Field",
            Position = @"UB1.8",
            Name = @"Covered Days -",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 23. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (coveredDays.field.FieldRepetitions != null && coveredDays.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(coveredDays.Id));
            coveredDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(coveredDays, fieldData);
        }

        return coveredDays;
    } 
}

internal HL7V231Field nonCoveredDays;

public HL7V231Field NonCoveredDays
{
    get
    {
        if (nonCoveredDays != null)
        {
            return nonCoveredDays;
        }

        nonCoveredDays = new HL7V231Field
        {
            field = message[@"UB1"][9],
            Id = @"UB1.9",
            Type = @"Field",
            Position = @"UB1.9",
            Name = @"Non Covered Days -",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 24. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (nonCoveredDays.field.FieldRepetitions != null && nonCoveredDays.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nonCoveredDays.Id));
            nonCoveredDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(nonCoveredDays, fieldData);
        }

        return nonCoveredDays;
    } 
}

internal HL7V231Field valueAmountAndCode;

public HL7V231Field ValueAmountAndCode
{
    get
    {
        if (valueAmountAndCode != null)
        {
            return valueAmountAndCode;
        }

        valueAmountAndCode = new HL7V231Field
        {
            field = message[@"UB1"][10],
            Id = @"UB1.10",
            Type = @"Field",
            Position = @"UB1.10",
            Name = @"Value Amount & Code",
            Length = 12,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"UVC",
            DataTypeName = @"Value Code And Amount",
            TableId = null,
            TableName = null,
            Description = @"The pair in this field can repeat up to eight times (46A, 47A, 48A, 49A, 46B, 47B, 48B, and 49B). Refer to user-definedtable 0153 - Value code in UB2-6 for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (valueAmountAndCode.field.FieldRepetitions != null && valueAmountAndCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(valueAmountAndCode.Id));
            valueAmountAndCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(valueAmountAndCode, fieldData);
        }

        return valueAmountAndCode;
    } 
}

internal HL7V231Field numberOfGraceDays;

public HL7V231Field NumberOfGraceDays
{
    get
    {
        if (numberOfGraceDays != null)
        {
            return numberOfGraceDays;
        }

        numberOfGraceDays = new HL7V231Field
        {
            field = message[@"UB1"][11],
            Id = @"UB1.11",
            Type = @"Field",
            Position = @"UB1.11",
            Name = @"Number Of Grace Days",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 90. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (numberOfGraceDays.field.FieldRepetitions != null && numberOfGraceDays.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberOfGraceDays.Id));
            numberOfGraceDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(numberOfGraceDays, fieldData);
        }

        return numberOfGraceDays;
    } 
}

internal HL7V231Field specialProgramIndicator;

public HL7V231Field SpecialProgramIndicator
{
    get
    {
        if (specialProgramIndicator != null)
        {
            return specialProgramIndicator;
        }

        specialProgramIndicator = new HL7V231Field
        {
            field = message[@"UB1"][12],
            Id = @"UB1.12",
            Type = @"Field",
            Position = @"UB1.12",
            Name = @"Special Program Indicator",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0348",
            TableName = @"Special program indicator",
            Description = @"This field contains the special program indicator. UB82 Field 44. This field is defined by HCFA or other regulatory agencies. Refer to user-defined table 0348 - Special program indicator for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information",
            Sample = @"",
        };

        // check for repetitions
        if (specialProgramIndicator.field.FieldRepetitions != null && specialProgramIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specialProgramIndicator.Id));
            specialProgramIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(specialProgramIndicator, fieldData);
        }

        return specialProgramIndicator;
    } 
}

internal HL7V231Field pSROURApprovalIndicator;

public HL7V231Field PSROURApprovalIndicator
{
    get
    {
        if (pSROURApprovalIndicator != null)
        {
            return pSROURApprovalIndicator;
        }

        pSROURApprovalIndicator = new HL7V231Field
        {
            field = message[@"UB1"][13],
            Id = @"UB1.13",
            Type = @"Field",
            Position = @"UB1.13",
            Name = @"PSRO/UR Approval Indicator",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0349",
            TableName = @"PSRO/UR approval indicator",
            Description = @"This field contains the PSRO/UR approval indicator. UB82 field 87. This field is defined by HCFA or other regulatory agencies. Refer to user-defined table 0349 - PSRO/UR approval indicator for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.",
            Sample = @"",
        };

        // check for repetitions
        if (pSROURApprovalIndicator.field.FieldRepetitions != null && pSROURApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pSROURApprovalIndicator.Id));
            pSROURApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(pSROURApprovalIndicator, fieldData);
        }

        return pSROURApprovalIndicator;
    } 
}

internal HL7V231Field pSROURApprovedStayFm;

public HL7V231Field PSROURApprovedStayFm
{
    get
    {
        if (pSROURApprovedStayFm != null)
        {
            return pSROURApprovedStayFm;
        }

        pSROURApprovedStayFm = new HL7V231Field
        {
            field = message[@"UB1"][14],
            Id = @"UB1.14",
            Type = @"Field",
            Position = @"UB1.14",
            Name = @"PSRO/UR Approved Stay-Fm",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the PSRO/UR approved stay date (from). UB82 Field 88. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (pSROURApprovedStayFm.field.FieldRepetitions != null && pSROURApprovedStayFm.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pSROURApprovedStayFm.Id));
            pSROURApprovedStayFm.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(pSROURApprovedStayFm, fieldData);
        }

        return pSROURApprovedStayFm;
    } 
}

internal HL7V231Field pSROURApprovedStayTo;

public HL7V231Field PSROURApprovedStayTo
{
    get
    {
        if (pSROURApprovedStayTo != null)
        {
            return pSROURApprovedStayTo;
        }

        pSROURApprovedStayTo = new HL7V231Field
        {
            field = message[@"UB1"][15],
            Id = @"UB1.15",
            Type = @"Field",
            Position = @"UB1.15",
            Name = @"PSRO/UR Approved Stay-To",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the PSRO/UR approved stay date (to). UB82 Field 89. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (pSROURApprovedStayTo.field.FieldRepetitions != null && pSROURApprovedStayTo.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pSROURApprovedStayTo.Id));
            pSROURApprovedStayTo.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(pSROURApprovedStayTo, fieldData);
        }

        return pSROURApprovedStayTo;
    } 
}

internal HL7V231Field occurrence;

public HL7V231Field Occurrence
{
    get
    {
        if (occurrence != null)
        {
            return occurrence;
        }

        occurrence = new HL7V231Field
        {
            field = message[@"UB1"][16],
            Id = @"UB1.16",
            Type = @"Field",
            Position = @"UB1.16",
            Name = @"Occurrence",
            Length = 20,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"OCD",
            DataTypeName = @"Occurence",
            TableId = null,
            TableName = null,
            Description = @"The set of values in this field can repeat up to five times. UB82 Fields 28-32. This field is defined by HCFA or other regulatory agencies. User-defined table 0350 - Occurrencecode (see UB2-7) is used as the HL7 identifier for the user-defined table of values for this field. Refer to a UB specification for additional information.",
            Sample = @"",
        };

        // check for repetitions
        if (occurrence.field.FieldRepetitions != null && occurrence.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(occurrence.Id));
            occurrence.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(occurrence, fieldData);
        }

        return occurrence;
    } 
}

internal HL7V231Field occurrenceSpan;

public HL7V231Field OccurrenceSpan
{
    get
    {
        if (occurrenceSpan != null)
        {
            return occurrenceSpan;
        }

        occurrenceSpan = new HL7V231Field
        {
            field = message[@"UB1"][17],
            Id = @"UB1.17",
            Type = @"Field",
            Position = @"UB1.17",
            Name = @"Occurrence Span",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0351",
            TableName = @"Occurrence span",
            Description = @"UB82 Field 33. This field is defined by HCFA or other regulatory agencies. Refer to user-defined table 0351- Occurrence span in UB2-8 for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.",
            Sample = @"",
        };

        // check for repetitions
        if (occurrenceSpan.field.FieldRepetitions != null && occurrenceSpan.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(occurrenceSpan.Id));
            occurrenceSpan.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(occurrenceSpan, fieldData);
        }

        return occurrenceSpan;
    } 
}

internal HL7V231Field occurSpanStartDate;

public HL7V231Field OccurSpanStartDate
{
    get
    {
        if (occurSpanStartDate != null)
        {
            return occurSpanStartDate;
        }

        occurSpanStartDate = new HL7V231Field
        {
            field = message[@"UB1"][18],
            Id = @"UB1.18",
            Type = @"Field",
            Position = @"UB1.18",
            Name = @"Occur Span Start Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the occurrence span start date. UB82 Field 33. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (occurSpanStartDate.field.FieldRepetitions != null && occurSpanStartDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(occurSpanStartDate.Id));
            occurSpanStartDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(occurSpanStartDate, fieldData);
        }

        return occurSpanStartDate;
    } 
}

internal HL7V231Field occurSpanEndDate;

public HL7V231Field OccurSpanEndDate
{
    get
    {
        if (occurSpanEndDate != null)
        {
            return occurSpanEndDate;
        }

        occurSpanEndDate = new HL7V231Field
        {
            field = message[@"UB1"][19],
            Id = @"UB1.19",
            Type = @"Field",
            Position = @"UB1.19",
            Name = @"Occur Span End Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the occurrence span end date. UB82 Field 33. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (occurSpanEndDate.field.FieldRepetitions != null && occurSpanEndDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(occurSpanEndDate.Id));
            occurSpanEndDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(occurSpanEndDate, fieldData);
        }

        return occurSpanEndDate;
    } 
}

internal HL7V231Field uB82Locator2;

public HL7V231Field UB82Locator2
{
    get
    {
        if (uB82Locator2 != null)
        {
            return uB82Locator2;
        }

        uB82Locator2 = new HL7V231Field
        {
            field = message[@"UB1"][20],
            Id = @"UB1.20",
            Type = @"Field",
            Position = @"UB1.20",
            Name = @"UB-82 Locator 2",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-82 HCFA specification.",
            Sample = @"",
        };

        // check for repetitions
        if (uB82Locator2.field.FieldRepetitions != null && uB82Locator2.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uB82Locator2.Id));
            uB82Locator2.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(uB82Locator2, fieldData);
        }

        return uB82Locator2;
    } 
}

internal HL7V231Field uB82Locator9;

public HL7V231Field UB82Locator9
{
    get
    {
        if (uB82Locator9 != null)
        {
            return uB82Locator9;
        }

        uB82Locator9 = new HL7V231Field
        {
            field = message[@"UB1"][21],
            Id = @"UB1.21",
            Type = @"Field",
            Position = @"UB1.21",
            Name = @"UB-82 Locator 9",
            Length = 7,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-82 HCFA specification.",
            Sample = @"",
        };

        // check for repetitions
        if (uB82Locator9.field.FieldRepetitions != null && uB82Locator9.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uB82Locator9.Id));
            uB82Locator9.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(uB82Locator9, fieldData);
        }

        return uB82Locator9;
    } 
}

internal HL7V231Field uB82Locator27;

public HL7V231Field UB82Locator27
{
    get
    {
        if (uB82Locator27 != null)
        {
            return uB82Locator27;
        }

        uB82Locator27 = new HL7V231Field
        {
            field = message[@"UB1"][22],
            Id = @"UB1.22",
            Type = @"Field",
            Position = @"UB1.22",
            Name = @"UB-82 Locator 27",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-82 HCFA specification.",
            Sample = @"",
        };

        // check for repetitions
        if (uB82Locator27.field.FieldRepetitions != null && uB82Locator27.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uB82Locator27.Id));
            uB82Locator27.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(uB82Locator27, fieldData);
        }

        return uB82Locator27;
    } 
}

internal HL7V231Field uB82Locator45;

public HL7V231Field UB82Locator45
{
    get
    {
        if (uB82Locator45 != null)
        {
            return uB82Locator45;
        }

        uB82Locator45 = new HL7V231Field
        {
            field = message[@"UB1"][23],
            Id = @"UB1.23",
            Type = @"Field",
            Position = @"UB1.23",
            Name = @"UB-82 Locator 45",
            Length = 17,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-82 HCFA specification.",
            Sample = @"",
        };

        // check for repetitions
        if (uB82Locator45.field.FieldRepetitions != null && uB82Locator45.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uB82Locator45.Id));
            uB82Locator45.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(uB82Locator45, fieldData);
        }

        return uB82Locator45;
    } 
}
    }
}
