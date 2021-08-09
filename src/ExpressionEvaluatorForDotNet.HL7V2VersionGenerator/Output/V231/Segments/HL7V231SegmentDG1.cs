using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentDG1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DG1"; } }

        public string SegmentId { get { return @"DG1"; } }
        
        public string LongName { get { return @"Diagnosis segment"; } }
        
        public string Description { get { return @"The DG1 segment contains patient diagnosis information of various types, for example, admitting, primary, etc. The DG1 segment is used to send multiple diagnoses (for example, for medical records encoding). It is also used when the FT1-19-diagnosiscode-FT1 does not provide sufficient information for a billing system. This diagnosis coding should be distinguished from the clinical problem segment used by caregivers to manage the patient (see Chapter 12, Patient Care). Coding methodologies are also defined."; } }
        
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
                            Id = @"DG1.1",
                            Type = @"Field",
                            Position = @"DG1.1",
                            Name = @"Set ID - DG1",
                            Length = 4,
                            Usage = @"R",
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
                            Id = @"DG1.2",
                            Type = @"Field",
                            Position = @"DG1.2",
                            Name = @"Diagnosis Coding Method",
                            Length = 2,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0053",
                            TableName = @"Diagnosis Coding Method",
                            Description = @"This field has been retained for backward compatibility only.  Use the components of DG1-3-diagnosis code-DG1 instead of this field. When used for backward compatibility, ICD9 is the recommended coding methodology. Refer to HL7 table 0053 - Diagnosis coding method for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.3",
                            Type = @"Field",
                            Position = @"DG1.3",
                            Name = @"Diagnosis Code - DG1",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0051",
                            TableName = @"Diagnosis code",
                            Description = @"Use this field instead of DG1-2-diagnosis coding method and DG1-4-diagnosis description. (Those two fields have been retained for backward compatibility only.) DG1-3-diagnosis code DG1 contains the diagnosis code assigned to this diagnosis. User-defined table 0051- Diagnosis code is used as the HL7 identifier for the user-defined table of values for this field . This field is a CE data type for compatibility with clinical and ancillary systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.3.1",
                            Type = @"Component",
                            Position = @"DG1.3.1",
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
                            Id = @"DG1.3.2",
                            Type = @"Component",
                            Position = @"DG1.3.2",
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
                            Id = @"DG1.3.3",
                            Type = @"Component",
                            Position = @"DG1.3.3",
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
                            Id = @"DG1.3.4",
                            Type = @"Component",
                            Position = @"DG1.3.4",
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
                            Id = @"DG1.3.5",
                            Type = @"Component",
                            Position = @"DG1.3.5",
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
                            Id = @"DG1.3.6",
                            Type = @"Component",
                            Position = @"DG1.3.6",
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
                            Id = @"DG1.4",
                            Type = @"Field",
                            Position = @"DG1.4",
                            Name = @"Diagnosis Description",
                            Length = 40,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has been retained for backward compatibility only. Use the components of DG1-3-diagnosis code-DG1 field instead of this field. When used for backward compatibility, DG1-4-diagnosis description contains a description that best describes the diagnosis.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.5",
                            Type = @"Field",
                            Position = @"DG1.5",
                            Name = @"Diagnosis Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the diagnosis was determined.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.5.1",
                            Type = @"Component",
                            Position = @"DG1.5.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.6",
                            Type = @"Field",
                            Position = @"DG1.6",
                            Name = @"Diagnosis Type",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0052",
                            TableName = @"Diagnosis type",
                            Description = @"This field contains a code that identifies the type of diagnosis being sent. Refer to user-defined table 0052 - Diagnosis type . This field should no longer be used to indicate 'DRG' because the DRG fields have moved to the new DRG segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.7",
                            Type = @"Field",
                            Position = @"DG1.7",
                            Name = @"Major Diagnostic Category",
                            Length = 60,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0118",
                            TableName = @"Major diagnostic category",
                            Description = @"This field has been retained for backward compatibility only. This field should only be used in a master file transaction. User-defined table 0118 - Major diagnostic category is used as the HL7 identifier for the user-defined table of values for this field .",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.7.1",
                            Type = @"Component",
                            Position = @"DG1.7.1",
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
                            Id = @"DG1.7.2",
                            Type = @"Component",
                            Position = @"DG1.7.2",
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
                            Id = @"DG1.7.3",
                            Type = @"Component",
                            Position = @"DG1.7.3",
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
                            Id = @"DG1.7.4",
                            Type = @"Component",
                            Position = @"DG1.7.4",
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
                            Id = @"DG1.7.5",
                            Type = @"Component",
                            Position = @"DG1.7.5",
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
                            Id = @"DG1.7.6",
                            Type = @"Component",
                            Position = @"DG1.7.6",
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
                            Id = @"DG1.8",
                            Type = @"Field",
                            Position = @"DG1.8",
                            Name = @"Diagnostic Related Group",
                            Length = 60,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0055",
                            TableName = @"Diagnosis related group",
                            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. It contains the DRG for the transaction. Interim DRG's could be determined for an encounter. User-defined table 0055 - DRG code is used as the HL7 Identifier for the user-defined table of values for this field .",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.8.1",
                            Type = @"Component",
                            Position = @"DG1.8.1",
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
                            Id = @"DG1.8.2",
                            Type = @"Component",
                            Position = @"DG1.8.2",
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
                            Id = @"DG1.8.3",
                            Type = @"Component",
                            Position = @"DG1.8.3",
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
                            Id = @"DG1.8.4",
                            Type = @"Component",
                            Position = @"DG1.8.4",
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
                            Id = @"DG1.8.5",
                            Type = @"Component",
                            Position = @"DG1.8.5",
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
                            Id = @"DG1.8.6",
                            Type = @"Component",
                            Position = @"DG1.8.6",
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
                            Id = @"DG1.9",
                            Type = @"Field",
                            Position = @"DG1.9",
                            Name = @"DRG Approval Indicator",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. This field indicates if the DRG has been approved by a reviewing entity. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.10",
                            Type = @"Field",
                            Position = @"DG1.10",
                            Name = @"DRG Grouper Review Code",
                            Length = 2,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0056",
                            TableName = @"DRG grouper review code",
                            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. User-defined table 0056 - DRG grouper review code is used as the HL7 identifier for the user-defined table of values for this field . This code indicates that the grouper results have been reviewed and approved.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.11",
                            Type = @"Field",
                            Position = @"DG1.11",
                            Name = @"Outlier Type",
                            Length = 60,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0083",
                            TableName = @"Outlier type",
                            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. When used for backward compatibility, this field contains the type of outlier that has been paid. Refer to user-defined table 0083 - Outlier type for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.11.1",
                            Type = @"Component",
                            Position = @"DG1.11.1",
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
                            Id = @"DG1.11.2",
                            Type = @"Component",
                            Position = @"DG1.11.2",
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
                            Id = @"DG1.11.3",
                            Type = @"Component",
                            Position = @"DG1.11.3",
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
                            Id = @"DG1.11.4",
                            Type = @"Component",
                            Position = @"DG1.11.4",
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
                            Id = @"DG1.11.5",
                            Type = @"Component",
                            Position = @"DG1.11.5",
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
                            Id = @"DG1.11.6",
                            Type = @"Component",
                            Position = @"DG1.11.6",
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
                            Id = @"DG1.12",
                            Type = @"Field",
                            Position = @"DG1.12",
                            Name = @"Outlier Days",
                            Length = 3,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. When used for backward compatibility, this field contains the number of days that have been approved for an outlier payment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13",
                            Type = @"Field",
                            Position = @"DG1.13",
                            Name = @"Outlier Cost",
                            Length = 12,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. When used for backward compatibility, this field contains the amount of money that has been approved for an outlier payment.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.13.1",
                            Type = @"Component",
                            Position = @"DG1.13.1",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.13.1.1",
                            Type = @"SubComponent",
                            Position = @"DG1.13.1.1",
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
                            Id = @"DG1.13.1.2",
                            Type = @"SubComponent",
                            Position = @"DG1.13.1.2",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.2",
                            Type = @"Component",
                            Position = @"DG1.13.2",
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
                            Id = @"DG1.13.3",
                            Type = @"Component",
                            Position = @"DG1.13.3",
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
                            Id = @"DG1.13.4",
                            Type = @"Component",
                            Position = @"DG1.13.4",
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
                            Id = @"DG1.13.5",
                            Type = @"Component",
                            Position = @"DG1.13.5",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.13.5.1",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.1",
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
                            Id = @"DG1.13.5.2",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.2",
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
                            Id = @"DG1.13.5.3",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.3",
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
                            Id = @"DG1.13.5.4",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.4",
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
                            Id = @"DG1.13.5.5",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.5",
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
                            Id = @"DG1.13.5.6",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.6",
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
                            Id = @"DG1.13.6",
                            Type = @"Component",
                            Position = @"DG1.13.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.14",
                            Type = @"Field",
                            Position = @"DG1.14",
                            Name = @"Grouper Version And Type",
                            Length = 4,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment; refer to the field definition 6.4.3.0. When used for backward compatibility, this field contains the grouper version and type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.15",
                            Type = @"Field",
                            Position = @"DG1.15",
                            Name = @"Diagnosis Priority",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0359",
                            TableName = @"Diagnosis priority",
                            Description = @"This field contains the number that identifies the significance or priority of the diagnosis code. Refer to HL7 table 0359 - Diagnosis priority for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16",
                            Type = @"Field",
                            Position = @"DG1.16",
                            Name = @"Diagnosing Clinician",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name For Persons",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the individual responsible for generating the diagnosis information. Multiple names and identifiers for the same person may be sent in this field, not multiple diagnosing clinicians. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components for this field are described in Chapter 2.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.16.1",
                            Type = @"Component",
                            Position = @"DG1.16.1",
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
                            Id = @"DG1.16.2",
                            Type = @"Component",
                            Position = @"DG1.16.2",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.16.2.1",
                            Type = @"SubComponent",
                            Position = @"DG1.16.2.1",
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
                            Id = @"DG1.16.2.2",
                            Type = @"SubComponent",
                            Position = @"DG1.16.2.2",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.3",
                            Type = @"Component",
                            Position = @"DG1.16.3",
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
                            Id = @"DG1.16.4",
                            Type = @"Component",
                            Position = @"DG1.16.4",
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
                            Id = @"DG1.16.5",
                            Type = @"Component",
                            Position = @"DG1.16.5",
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
                            Id = @"DG1.16.6",
                            Type = @"Component",
                            Position = @"DG1.16.6",
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
                            Id = @"DG1.16.7",
                            Type = @"Component",
                            Position = @"DG1.16.7",
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
                            Id = @"DG1.16.8",
                            Type = @"Component",
                            Position = @"DG1.16.8",
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
                            Id = @"DG1.16.9",
                            Type = @"Component",
                            Position = @"DG1.16.9",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.16.9.1",
                            Type = @"SubComponent",
                            Position = @"DG1.16.9.1",
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
                            Id = @"DG1.16.9.2",
                            Type = @"SubComponent",
                            Position = @"DG1.16.9.2",
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
                            Id = @"DG1.16.9.3",
                            Type = @"SubComponent",
                            Position = @"DG1.16.9.3",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.10",
                            Type = @"Component",
                            Position = @"DG1.16.10",
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
                            Id = @"DG1.16.11",
                            Type = @"Component",
                            Position = @"DG1.16.11",
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
                            Id = @"DG1.16.12",
                            Type = @"Component",
                            Position = @"DG1.16.12",
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
                            Id = @"DG1.16.13",
                            Type = @"Component",
                            Position = @"DG1.16.13",
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
                            Id = @"DG1.16.14",
                            Type = @"Component",
                            Position = @"DG1.16.14",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.16.14.1",
                            Type = @"SubComponent",
                            Position = @"DG1.16.14.1",
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
                            Id = @"DG1.16.14.2",
                            Type = @"SubComponent",
                            Position = @"DG1.16.14.2",
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
                            Id = @"DG1.16.14.3",
                            Type = @"SubComponent",
                            Position = @"DG1.16.14.3",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.15",
                            Type = @"Component",
                            Position = @"DG1.16.15",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.17",
                            Type = @"Field",
                            Position = @"DG1.17",
                            Name = @"Diagnosis Classification",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0228",
                            TableName = @"Diagnosis classification",
                            Description = @"This field indicates if the patient information is for a diagnosis or a non-diagnosis code. Refer to user-defined table 0228 - Diagnosis classification for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.18",
                            Type = @"Field",
                            Position = @"DG1.18",
                            Name = @"Confidential Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether the diagnosis is confidential. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.19",
                            Type = @"Field",
                            Position = @"DG1.19",
                            Name = @"Attestation Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the time stamp that indicates the date and time that the attestation was signed.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.19.1",
                            Type = @"Component",
                            Position = @"DG1.19.1",
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
                        },}
                        },
                        };
            }
        }

        public HL7V231SegmentDG1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field setIDDG1;

public HL7V231Field SetIDDG1
{
    get
    {
        if (setIDDG1 != null)
        {
            return setIDDG1;
        }

        setIDDG1 = new HL7V231Field
        {
            field = message[@"DG1"][1],
            Id = @"DG1.1",
            Type = @"Field",
            Position = @"DG1.1",
            Name = @"Set ID - DG1",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc.",
            Sample = @"",
        };

        // check for repetitions
        if (setIDDG1.field.FieldRepetitions != null && setIDDG1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDDG1.Id));
            setIDDG1.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(setIDDG1, fieldData);
        }

        return setIDDG1;
    } 
}

internal HL7V231Field diagnosisCodingMethod;

public HL7V231Field DiagnosisCodingMethod
{
    get
    {
        if (diagnosisCodingMethod != null)
        {
            return diagnosisCodingMethod;
        }

        diagnosisCodingMethod = new HL7V231Field
        {
            field = message[@"DG1"][2],
            Id = @"DG1.2",
            Type = @"Field",
            Position = @"DG1.2",
            Name = @"Diagnosis Coding Method",
            Length = 2,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0053",
            TableName = @"Diagnosis Coding Method",
            Description = @"This field has been retained for backward compatibility only.  Use the components of DG1-3-diagnosis code-DG1 instead of this field. When used for backward compatibility, ICD9 is the recommended coding methodology. Refer to HL7 table 0053 - Diagnosis coding method for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (diagnosisCodingMethod.field.FieldRepetitions != null && diagnosisCodingMethod.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisCodingMethod.Id));
            diagnosisCodingMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(diagnosisCodingMethod, fieldData);
        }

        return diagnosisCodingMethod;
    } 
}

internal HL7V231Field diagnosisCodeDG1;

public HL7V231Field DiagnosisCodeDG1
{
    get
    {
        if (diagnosisCodeDG1 != null)
        {
            return diagnosisCodeDG1;
        }

        diagnosisCodeDG1 = new HL7V231Field
        {
            field = message[@"DG1"][3],
            Id = @"DG1.3",
            Type = @"Field",
            Position = @"DG1.3",
            Name = @"Diagnosis Code - DG1",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0051",
            TableName = @"Diagnosis code",
            Description = @"Use this field instead of DG1-2-diagnosis coding method and DG1-4-diagnosis description. (Those two fields have been retained for backward compatibility only.) DG1-3-diagnosis code DG1 contains the diagnosis code assigned to this diagnosis. User-defined table 0051- Diagnosis code is used as the HL7 identifier for the user-defined table of values for this field . This field is a CE data type for compatibility with clinical and ancillary systems.",
            Sample = @"",
        };

        // check for repetitions
        if (diagnosisCodeDG1.field.FieldRepetitions != null && diagnosisCodeDG1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisCodeDG1.Id));
            diagnosisCodeDG1.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(diagnosisCodeDG1, fieldData);
        }

        return diagnosisCodeDG1;
    } 
}

internal HL7V231Field diagnosisDescription;

public HL7V231Field DiagnosisDescription
{
    get
    {
        if (diagnosisDescription != null)
        {
            return diagnosisDescription;
        }

        diagnosisDescription = new HL7V231Field
        {
            field = message[@"DG1"][4],
            Id = @"DG1.4",
            Type = @"Field",
            Position = @"DG1.4",
            Name = @"Diagnosis Description",
            Length = 40,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only. Use the components of DG1-3-diagnosis code-DG1 field instead of this field. When used for backward compatibility, DG1-4-diagnosis description contains a description that best describes the diagnosis.",
            Sample = @"",
        };

        // check for repetitions
        if (diagnosisDescription.field.FieldRepetitions != null && diagnosisDescription.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisDescription.Id));
            diagnosisDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(diagnosisDescription, fieldData);
        }

        return diagnosisDescription;
    } 
}

internal HL7V231Field diagnosisDateTime;

public HL7V231Field DiagnosisDateTime
{
    get
    {
        if (diagnosisDateTime != null)
        {
            return diagnosisDateTime;
        }

        diagnosisDateTime = new HL7V231Field
        {
            field = message[@"DG1"][5],
            Id = @"DG1.5",
            Type = @"Field",
            Position = @"DG1.5",
            Name = @"Diagnosis Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the diagnosis was determined.",
            Sample = @"",
        };

        // check for repetitions
        if (diagnosisDateTime.field.FieldRepetitions != null && diagnosisDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisDateTime.Id));
            diagnosisDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(diagnosisDateTime, fieldData);
        }

        return diagnosisDateTime;
    } 
}

internal HL7V231Field diagnosisType;

public HL7V231Field DiagnosisType
{
    get
    {
        if (diagnosisType != null)
        {
            return diagnosisType;
        }

        diagnosisType = new HL7V231Field
        {
            field = message[@"DG1"][6],
            Id = @"DG1.6",
            Type = @"Field",
            Position = @"DG1.6",
            Name = @"Diagnosis Type",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0052",
            TableName = @"Diagnosis type",
            Description = @"This field contains a code that identifies the type of diagnosis being sent. Refer to user-defined table 0052 - Diagnosis type . This field should no longer be used to indicate 'DRG' because the DRG fields have moved to the new DRG segment.",
            Sample = @"",
        };

        // check for repetitions
        if (diagnosisType.field.FieldRepetitions != null && diagnosisType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisType.Id));
            diagnosisType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(diagnosisType, fieldData);
        }

        return diagnosisType;
    } 
}

internal HL7V231Field majorDiagnosticCategory;

public HL7V231Field MajorDiagnosticCategory
{
    get
    {
        if (majorDiagnosticCategory != null)
        {
            return majorDiagnosticCategory;
        }

        majorDiagnosticCategory = new HL7V231Field
        {
            field = message[@"DG1"][7],
            Id = @"DG1.7",
            Type = @"Field",
            Position = @"DG1.7",
            Name = @"Major Diagnostic Category",
            Length = 60,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0118",
            TableName = @"Major diagnostic category",
            Description = @"This field has been retained for backward compatibility only. This field should only be used in a master file transaction. User-defined table 0118 - Major diagnostic category is used as the HL7 identifier for the user-defined table of values for this field .",
            Sample = @"",
        };

        // check for repetitions
        if (majorDiagnosticCategory.field.FieldRepetitions != null && majorDiagnosticCategory.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(majorDiagnosticCategory.Id));
            majorDiagnosticCategory.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(majorDiagnosticCategory, fieldData);
        }

        return majorDiagnosticCategory;
    } 
}

internal HL7V231Field diagnosticRelatedGroup;

public HL7V231Field DiagnosticRelatedGroup
{
    get
    {
        if (diagnosticRelatedGroup != null)
        {
            return diagnosticRelatedGroup;
        }

        diagnosticRelatedGroup = new HL7V231Field
        {
            field = message[@"DG1"][8],
            Id = @"DG1.8",
            Type = @"Field",
            Position = @"DG1.8",
            Name = @"Diagnostic Related Group",
            Length = 60,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0055",
            TableName = @"Diagnosis related group",
            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. It contains the DRG for the transaction. Interim DRG's could be determined for an encounter. User-defined table 0055 - DRG code is used as the HL7 Identifier for the user-defined table of values for this field .",
            Sample = @"",
        };

        // check for repetitions
        if (diagnosticRelatedGroup.field.FieldRepetitions != null && diagnosticRelatedGroup.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosticRelatedGroup.Id));
            diagnosticRelatedGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(diagnosticRelatedGroup, fieldData);
        }

        return diagnosticRelatedGroup;
    } 
}

internal HL7V231Field dRGApprovalIndicator;

public HL7V231Field DRGApprovalIndicator
{
    get
    {
        if (dRGApprovalIndicator != null)
        {
            return dRGApprovalIndicator;
        }

        dRGApprovalIndicator = new HL7V231Field
        {
            field = message[@"DG1"][9],
            Id = @"DG1.9",
            Type = @"Field",
            Position = @"DG1.9",
            Name = @"DRG Approval Indicator",
            Length = 1,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. This field indicates if the DRG has been approved by a reviewing entity. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (dRGApprovalIndicator.field.FieldRepetitions != null && dRGApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dRGApprovalIndicator.Id));
            dRGApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(dRGApprovalIndicator, fieldData);
        }

        return dRGApprovalIndicator;
    } 
}

internal HL7V231Field dRGGrouperReviewCode;

public HL7V231Field DRGGrouperReviewCode
{
    get
    {
        if (dRGGrouperReviewCode != null)
        {
            return dRGGrouperReviewCode;
        }

        dRGGrouperReviewCode = new HL7V231Field
        {
            field = message[@"DG1"][10],
            Id = @"DG1.10",
            Type = @"Field",
            Position = @"DG1.10",
            Name = @"DRG Grouper Review Code",
            Length = 2,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0056",
            TableName = @"DRG grouper review code",
            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. User-defined table 0056 - DRG grouper review code is used as the HL7 identifier for the user-defined table of values for this field . This code indicates that the grouper results have been reviewed and approved.",
            Sample = @"",
        };

        // check for repetitions
        if (dRGGrouperReviewCode.field.FieldRepetitions != null && dRGGrouperReviewCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dRGGrouperReviewCode.Id));
            dRGGrouperReviewCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(dRGGrouperReviewCode, fieldData);
        }

        return dRGGrouperReviewCode;
    } 
}

internal HL7V231Field outlierType;

public HL7V231Field OutlierType
{
    get
    {
        if (outlierType != null)
        {
            return outlierType;
        }

        outlierType = new HL7V231Field
        {
            field = message[@"DG1"][11],
            Id = @"DG1.11",
            Type = @"Field",
            Position = @"DG1.11",
            Name = @"Outlier Type",
            Length = 60,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0083",
            TableName = @"Outlier type",
            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. When used for backward compatibility, this field contains the type of outlier that has been paid. Refer to user-defined table 0083 - Outlier type for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (outlierType.field.FieldRepetitions != null && outlierType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(outlierType.Id));
            outlierType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(outlierType, fieldData);
        }

        return outlierType;
    } 
}

internal HL7V231Field outlierDays;

public HL7V231Field OutlierDays
{
    get
    {
        if (outlierDays != null)
        {
            return outlierDays;
        }

        outlierDays = new HL7V231Field
        {
            field = message[@"DG1"][12],
            Id = @"DG1.12",
            Type = @"Field",
            Position = @"DG1.12",
            Name = @"Outlier Days",
            Length = 3,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. When used for backward compatibility, this field contains the number of days that have been approved for an outlier payment.",
            Sample = @"",
        };

        // check for repetitions
        if (outlierDays.field.FieldRepetitions != null && outlierDays.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(outlierDays.Id));
            outlierDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(outlierDays, fieldData);
        }

        return outlierDays;
    } 
}

internal HL7V231Field outlierCost;

public HL7V231Field OutlierCost
{
    get
    {
        if (outlierCost != null)
        {
            return outlierCost;
        }

        outlierCost = new HL7V231Field
        {
            field = message[@"DG1"][13],
            Id = @"DG1.13",
            Type = @"Field",
            Position = @"DG1.13",
            Name = @"Outlier Cost",
            Length = 12,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment. When used for backward compatibility, this field contains the amount of money that has been approved for an outlier payment.",
            Sample = @"",
        };

        // check for repetitions
        if (outlierCost.field.FieldRepetitions != null && outlierCost.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(outlierCost.Id));
            outlierCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(outlierCost, fieldData);
        }

        return outlierCost;
    } 
}

internal HL7V231Field grouperVersionAndType;

public HL7V231Field GrouperVersionAndType
{
    get
    {
        if (grouperVersionAndType != null)
        {
            return grouperVersionAndType;
        }

        grouperVersionAndType = new HL7V231Field
        {
            field = message[@"DG1"][14],
            Id = @"DG1.14",
            Type = @"Field",
            Position = @"DG1.14",
            Name = @"Grouper Version And Type",
            Length = 4,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only. This field has moved to the new DRG segment; refer to the field definition 6.4.3.0. When used for backward compatibility, this field contains the grouper version and type.",
            Sample = @"",
        };

        // check for repetitions
        if (grouperVersionAndType.field.FieldRepetitions != null && grouperVersionAndType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(grouperVersionAndType.Id));
            grouperVersionAndType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(grouperVersionAndType, fieldData);
        }

        return grouperVersionAndType;
    } 
}

internal HL7V231Field diagnosisPriority;

public HL7V231Field DiagnosisPriority
{
    get
    {
        if (diagnosisPriority != null)
        {
            return diagnosisPriority;
        }

        diagnosisPriority = new HL7V231Field
        {
            field = message[@"DG1"][15],
            Id = @"DG1.15",
            Type = @"Field",
            Position = @"DG1.15",
            Name = @"Diagnosis Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0359",
            TableName = @"Diagnosis priority",
            Description = @"This field contains the number that identifies the significance or priority of the diagnosis code. Refer to HL7 table 0359 - Diagnosis priority for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (diagnosisPriority.field.FieldRepetitions != null && diagnosisPriority.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisPriority.Id));
            diagnosisPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(diagnosisPriority, fieldData);
        }

        return diagnosisPriority;
    } 
}

internal HL7V231Field diagnosingClinician;

public HL7V231Field DiagnosingClinician
{
    get
    {
        if (diagnosingClinician != null)
        {
            return diagnosingClinician;
        }

        diagnosingClinician = new HL7V231Field
        {
            field = message[@"DG1"][16],
            Id = @"DG1.16",
            Type = @"Field",
            Position = @"DG1.16",
            Name = @"Diagnosing Clinician",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field contains the individual responsible for generating the diagnosis information. Multiple names and identifiers for the same person may be sent in this field, not multiple diagnosing clinicians. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components for this field are described in Chapter 2.",
            Sample = @"",
        };

        // check for repetitions
        if (diagnosingClinician.field.FieldRepetitions != null && diagnosingClinician.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosingClinician.Id));
            diagnosingClinician.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(diagnosingClinician, fieldData);
        }

        return diagnosingClinician;
    } 
}

internal HL7V231Field diagnosisClassification;

public HL7V231Field DiagnosisClassification
{
    get
    {
        if (diagnosisClassification != null)
        {
            return diagnosisClassification;
        }

        diagnosisClassification = new HL7V231Field
        {
            field = message[@"DG1"][17],
            Id = @"DG1.17",
            Type = @"Field",
            Position = @"DG1.17",
            Name = @"Diagnosis Classification",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0228",
            TableName = @"Diagnosis classification",
            Description = @"This field indicates if the patient information is for a diagnosis or a non-diagnosis code. Refer to user-defined table 0228 - Diagnosis classification for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (diagnosisClassification.field.FieldRepetitions != null && diagnosisClassification.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisClassification.Id));
            diagnosisClassification.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(diagnosisClassification, fieldData);
        }

        return diagnosisClassification;
    } 
}

internal HL7V231Field confidentialIndicator;

public HL7V231Field ConfidentialIndicator
{
    get
    {
        if (confidentialIndicator != null)
        {
            return confidentialIndicator;
        }

        confidentialIndicator = new HL7V231Field
        {
            field = message[@"DG1"][18],
            Id = @"DG1.18",
            Type = @"Field",
            Position = @"DG1.18",
            Name = @"Confidential Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether the diagnosis is confidential. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (confidentialIndicator.field.FieldRepetitions != null && confidentialIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(confidentialIndicator.Id));
            confidentialIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(confidentialIndicator, fieldData);
        }

        return confidentialIndicator;
    } 
}

internal HL7V231Field attestationDateTime;

public HL7V231Field AttestationDateTime
{
    get
    {
        if (attestationDateTime != null)
        {
            return attestationDateTime;
        }

        attestationDateTime = new HL7V231Field
        {
            field = message[@"DG1"][19],
            Id = @"DG1.19",
            Type = @"Field",
            Position = @"DG1.19",
            Name = @"Attestation Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time stamp that indicates the date and time that the attestation was signed.",
            Sample = @"",
        };

        // check for repetitions
        if (attestationDateTime.field.FieldRepetitions != null && attestationDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(attestationDateTime.Id));
            attestationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(attestationDateTime, fieldData);
        }

        return attestationDateTime;
    } 
}
    }
}
