using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentIN3
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"IN3"; } }

        public string SegmentId { get { return @"IN3"; } }
        
        public string LongName { get { return @"Insurance Additional Info-certification"; } }
        
        public string Description { get { return @"The IN3 segment contains additional insurance information for certifying the need for patient care.  Fields used by this segment are defined by HICFA or other regulatory agencies"; } }
        
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
                            Id = @"IN3.1",
                            Type = @"Field",
                            Position = @"IN3.1",
                            Name = @"Set Id - Insurance Certification",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = @"sequence number which uniquely identifies this segment for the purpose of adding, changing, or deleting a certification segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2",
                            Type = @"Field",
                            Position = @"IN3.2",
                            Name = @"Certification Number",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"assigned by the certification agency",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3",
                            Type = @"Field",
                            Position = @"IN3.3",
                            Name = @"Certified By",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"party that approved the certification",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.1",
                            Type = @"Component",
                            Position = @"IN3.3.1",
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
                            Id = @"IN3.3.2",
                            Type = @"Component",
                            Position = @"IN3.3.2",
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
                            Id = @"IN3.3.3",
                            Type = @"Component",
                            Position = @"IN3.3.3",
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
                            Id = @"IN3.3.4",
                            Type = @"Component",
                            Position = @"IN3.3.4",
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
                            Id = @"IN3.3.5",
                            Type = @"Component",
                            Position = @"IN3.3.5",
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
                            Id = @"IN3.3.6",
                            Type = @"Component",
                            Position = @"IN3.3.6",
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
                            Id = @"IN3.3.7",
                            Type = @"Component",
                            Position = @"IN3.3.7",
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
                            Id = @"IN3.3.8",
                            Type = @"Component",
                            Position = @"IN3.3.8",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.4",
                            Type = @"Field",
                            Position = @"IN3.4",
                            Name = @"Certification Required",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = @"identifies whether certification is required.  Refer to table 0136 - Y/N indicator for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.5",
                            Type = @"Field",
                            Position = @"IN3.5",
                            Name = @"Penalty",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_PEN",
                            DataTypeName = @"Penalty",
                            TableId = null,
                            TableName = null,
                            Description = @"the penalty, in dollars or a percentage, that will be assessed if the pre-certification is not performed.  Refer to user-defined table 0148 - penalty type for suggested entries",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.5.1",
                            Type = @"Component",
                            Position = @"IN3.5.1",
                            Name = @"Penalty Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0148",
                            TableName = @"PENALTY TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.5.2",
                            Type = @"Component",
                            Position = @"IN3.5.2",
                            Name = @"Penalty Amount",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.6",
                            Type = @"Field",
                            Position = @"IN3.6",
                            Name = @"Certification Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"date and time stamp when insurance was certified to exist for the patient",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.6.1",
                            Type = @"Component",
                            Position = @"IN3.6.1",
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
                            Id = @"IN3.6.2",
                            Type = @"Component",
                            Position = @"IN3.6.2",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.7",
                            Type = @"Field",
                            Position = @"IN3.7",
                            Name = @"Certification Modify Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"date/time that the certification was modified",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.7.1",
                            Type = @"Component",
                            Position = @"IN3.7.1",
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
                            Id = @"IN3.7.2",
                            Type = @"Component",
                            Position = @"IN3.7.2",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8",
                            Type = @"Field",
                            Position = @"IN3.8",
                            Name = @"Operator",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"party that is responsible for sending this certification information",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.1",
                            Type = @"Component",
                            Position = @"IN3.8.1",
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
                            Id = @"IN3.8.2",
                            Type = @"Component",
                            Position = @"IN3.8.2",
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
                            Id = @"IN3.8.3",
                            Type = @"Component",
                            Position = @"IN3.8.3",
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
                            Id = @"IN3.8.4",
                            Type = @"Component",
                            Position = @"IN3.8.4",
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
                            Id = @"IN3.8.5",
                            Type = @"Component",
                            Position = @"IN3.8.5",
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
                            Id = @"IN3.8.6",
                            Type = @"Component",
                            Position = @"IN3.8.6",
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
                            Id = @"IN3.8.7",
                            Type = @"Component",
                            Position = @"IN3.8.7",
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
                            Id = @"IN3.8.8",
                            Type = @"Component",
                            Position = @"IN3.8.8",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.9",
                            Type = @"Field",
                            Position = @"IN3.9",
                            Name = @"Certification Begin Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"date that this certification begins",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.10",
                            Type = @"Field",
                            Position = @"IN3.10",
                            Name = @"Certification End Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"date that this certification ends",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.11",
                            Type = @"Field",
                            Position = @"IN3.11",
                            Name = @"Days",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_DTN",
                            DataTypeName = @"Day Type And Number",
                            TableId = null,
                            TableName = null,
                            Description = @"number of days for which this certification is valid.  This field will apply to denied, pending, or approved days.  Refer to user-defined table 0149 - day type for suggested entries",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.11.1",
                            Type = @"Component",
                            Position = @"IN3.11.1",
                            Name = @"Day Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0149",
                            TableName = @"DAY TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.11.2",
                            Type = @"Component",
                            Position = @"IN3.11.2",
                            Name = @"Number Of Days",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.12",
                            Type = @"Field",
                            Position = @"IN3.12",
                            Name = @"Non-concur Code / Description",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"non-concur code and description for a denied request",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.12.1",
                            Type = @"Component",
                            Position = @"IN3.12.1",
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
                            Id = @"IN3.12.2",
                            Type = @"Component",
                            Position = @"IN3.12.2",
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
                            Id = @"IN3.12.3",
                            Type = @"Component",
                            Position = @"IN3.12.3",
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
                            Id = @"IN3.12.4",
                            Type = @"Component",
                            Position = @"IN3.12.4",
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
                            Id = @"IN3.12.5",
                            Type = @"Component",
                            Position = @"IN3.12.5",
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
                            Id = @"IN3.12.6",
                            Type = @"Component",
                            Position = @"IN3.12.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.13",
                            Type = @"Field",
                            Position = @"IN3.13",
                            Name = @"Non-concur Effective Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"effective date of the non-concurrence classification",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.13.1",
                            Type = @"Component",
                            Position = @"IN3.13.1",
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
                            Id = @"IN3.13.2",
                            Type = @"Component",
                            Position = @"IN3.13.2",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14",
                            Type = @"Field",
                            Position = @"IN3.14",
                            Name = @"Physician Reviewer",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"physician who works with and reviews cases that are pending physician review for the certification agency",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.1",
                            Type = @"Component",
                            Position = @"IN3.14.1",
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
                            Id = @"IN3.14.2",
                            Type = @"Component",
                            Position = @"IN3.14.2",
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
                            Id = @"IN3.14.3",
                            Type = @"Component",
                            Position = @"IN3.14.3",
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
                            Id = @"IN3.14.4",
                            Type = @"Component",
                            Position = @"IN3.14.4",
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
                            Id = @"IN3.14.5",
                            Type = @"Component",
                            Position = @"IN3.14.5",
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
                            Id = @"IN3.14.6",
                            Type = @"Component",
                            Position = @"IN3.14.6",
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
                            Id = @"IN3.14.7",
                            Type = @"Component",
                            Position = @"IN3.14.7",
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
                            Id = @"IN3.14.8",
                            Type = @"Component",
                            Position = @"IN3.14.8",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.15",
                            Type = @"Field",
                            Position = @"IN3.15",
                            Name = @"Certification Contact",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"name of the party contacted at the certification agency who granted the certification and communicated the certification number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.16",
                            Type = @"Field",
                            Position = @"IN3.16",
                            Name = @"Certification Contact Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"phone number of the certification contact",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.17",
                            Type = @"Field",
                            Position = @"IN3.17",
                            Name = @"Appeal Reason",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"reason an appeal was made on a non-concur for certification",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.17.1",
                            Type = @"Component",
                            Position = @"IN3.17.1",
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
                            Id = @"IN3.17.2",
                            Type = @"Component",
                            Position = @"IN3.17.2",
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
                            Id = @"IN3.17.3",
                            Type = @"Component",
                            Position = @"IN3.17.3",
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
                            Id = @"IN3.17.4",
                            Type = @"Component",
                            Position = @"IN3.17.4",
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
                            Id = @"IN3.17.5",
                            Type = @"Component",
                            Position = @"IN3.17.5",
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
                            Id = @"IN3.17.6",
                            Type = @"Component",
                            Position = @"IN3.17.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.18",
                            Type = @"Field",
                            Position = @"IN3.18",
                            Name = @"Certification Agency",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"certification agency",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.18.1",
                            Type = @"Component",
                            Position = @"IN3.18.1",
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
                            Id = @"IN3.18.2",
                            Type = @"Component",
                            Position = @"IN3.18.2",
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
                            Id = @"IN3.18.3",
                            Type = @"Component",
                            Position = @"IN3.18.3",
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
                            Id = @"IN3.18.4",
                            Type = @"Component",
                            Position = @"IN3.18.4",
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
                            Id = @"IN3.18.5",
                            Type = @"Component",
                            Position = @"IN3.18.5",
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
                            Id = @"IN3.18.6",
                            Type = @"Component",
                            Position = @"IN3.18.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.19",
                            Type = @"Field",
                            Position = @"IN3.19",
                            Name = @"Certification Agency Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"phone number of the Certification agency",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20",
                            Type = @"Field",
                            Position = @"IN3.20",
                            Name = @"Pre-certification Required / Window",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_PCF",
                            DataTypeName = @"Pre-certification Required",
                            TableId = null,
                            TableName = null,
                            Description = @"identifies whether pre-certification is required for particular patient types and the time window for obtaining the certification.  Refer to user-defined table 0150 - pre-certification patient type for suggested values.  Valid values for the pre-certification required component are found in table 0136 - Y/N indicator.  The pre-certification window is the amount of time needed to be certified from arrival at the institution.  Its format follows the time stamp (TS) data type rules",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.1",
                            Type = @"Component",
                            Position = @"IN3.20.1",
                            Name = @"Pre-certification Patient Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0150",
                            TableName = @"PRECERTIFICATION PATIENT TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.2",
                            Type = @"Component",
                            Position = @"IN3.20.2",
                            Name = @"Pre-certication Required",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.3",
                            Type = @"Component",
                            Position = @"IN3.20.3",
                            Name = @"Pre-certification Window",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.3.1",
                            Type = @"SubComponent",
                            Position = @"IN3.20.3.1",
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
                            Id = @"IN3.20.3.2",
                            Type = @"SubComponent",
                            Position = @"IN3.20.3.2",
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
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.21",
                            Type = @"Field",
                            Position = @"IN3.21",
                            Name = @"Case Manager",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"entity who/which is handling this particular patient's case (e.g., UR nurse, or a specific facility location).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.22",
                            Type = @"Field",
                            Position = @"IN3.22",
                            Name = @"Second Opinion Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"date that the second opinion was obtained",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.23",
                            Type = @"Field",
                            Position = @"IN3.23",
                            Name = @"Second Opinion Status",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0151",
                            TableName = @"SECOND OPINION STATUS",
                            Description = @"Code that represents the status of the second opinion.  Refer to user-defined table 0151 - second opinion status for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.24",
                            Type = @"Field",
                            Position = @"IN3.24",
                            Name = @"Second Opinion Documentation Received",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0152",
                            TableName = @"SECOND OPINION DOCUMENTATION RECEIVED",
                            Description = @"if accompanying documentation has been received by the provider.  Refer to table 0152 - second opinion documentation received",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25",
                            Type = @"Field",
                            Position = @"IN3.25",
                            Name = @"Second Opinion Practitioner",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"ID and name of the physician who provided the second opinion",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.1",
                            Type = @"Component",
                            Position = @"IN3.25.1",
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
                            Id = @"IN3.25.2",
                            Type = @"Component",
                            Position = @"IN3.25.2",
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
                            Id = @"IN3.25.3",
                            Type = @"Component",
                            Position = @"IN3.25.3",
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
                            Id = @"IN3.25.4",
                            Type = @"Component",
                            Position = @"IN3.25.4",
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
                            Id = @"IN3.25.5",
                            Type = @"Component",
                            Position = @"IN3.25.5",
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
                            Id = @"IN3.25.6",
                            Type = @"Component",
                            Position = @"IN3.25.6",
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
                            Id = @"IN3.25.7",
                            Type = @"Component",
                            Position = @"IN3.25.7",
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
                            Id = @"IN3.25.8",
                            Type = @"Component",
                            Position = @"IN3.25.8",
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
                        },
                        
                        },
                        };
            }
        }

        public HL7V22SegmentIN3(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field setIdInsuranceCertification;

public HL7V22Field SetIdInsuranceCertification
{
    get
    {
        if (setIdInsuranceCertification != null)
        {
            return setIdInsuranceCertification;
        }

        setIdInsuranceCertification = new HL7V22Field
        {
            field = message[@"IN3"][1],
            Id = @"IN3.1",
            Type = @"Field",
            Position = @"IN3.1",
            Name = @"Set Id - Insurance Certification",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"sequence number which uniquely identifies this segment for the purpose of adding, changing, or deleting a certification segment",
            Sample = @"",
        };

        

        

        

        return setIdInsuranceCertification;
    } 
}
internal HL7V22Field certificationNumber;

public HL7V22Field CertificationNumber
{
    get
    {
        if (certificationNumber != null)
        {
            return certificationNumber;
        }

        certificationNumber = new HL7V22Field
        {
            field = message[@"IN3"][2],
            Id = @"IN3.2",
            Type = @"Field",
            Position = @"IN3.2",
            Name = @"Certification Number",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"assigned by the certification agency",
            Sample = @"",
        };

        

        

        

        return certificationNumber;
    } 
}
internal HL7V22Field certifiedBy;

public HL7V22Field CertifiedBy
{
    get
    {
        if (certifiedBy != null)
        {
            return certifiedBy;
        }

        certifiedBy = new HL7V22Field
        {
            field = message[@"IN3"][3],
            Id = @"IN3.3",
            Type = @"Field",
            Position = @"IN3.3",
            Name = @"Certified By",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"party that approved the certification",
            Sample = @"",
        };

        

        

        

        return certifiedBy;
    } 
}
internal HL7V22Field certificationRequired;

public HL7V22Field CertificationRequired
{
    get
    {
        if (certificationRequired != null)
        {
            return certificationRequired;
        }

        certificationRequired = new HL7V22Field
        {
            field = message[@"IN3"][4],
            Id = @"IN3.4",
            Type = @"Field",
            Position = @"IN3.4",
            Name = @"Certification Required",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"identifies whether certification is required.  Refer to table 0136 - Y/N indicator for valid values",
            Sample = @"",
        };

        

        

        

        return certificationRequired;
    } 
}
internal HL7V22Field penalty;

public HL7V22Field Penalty
{
    get
    {
        if (penalty != null)
        {
            return penalty;
        }

        penalty = new HL7V22Field
        {
            field = message[@"IN3"][5],
            Id = @"IN3.5",
            Type = @"Field",
            Position = @"IN3.5",
            Name = @"Penalty",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_PEN",
            DataTypeName = @"Penalty",
            TableId = null,
            TableName = null,
            Description = @"the penalty, in dollars or a percentage, that will be assessed if the pre-certification is not performed.  Refer to user-defined table 0148 - penalty type for suggested entries",
            Sample = @"",
        };

        

        

        

        return penalty;
    } 
}
internal HL7V22Field certificationDateTime;

public HL7V22Field CertificationDateTime
{
    get
    {
        if (certificationDateTime != null)
        {
            return certificationDateTime;
        }

        certificationDateTime = new HL7V22Field
        {
            field = message[@"IN3"][6],
            Id = @"IN3.6",
            Type = @"Field",
            Position = @"IN3.6",
            Name = @"Certification Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date and time stamp when insurance was certified to exist for the patient",
            Sample = @"",
        };

        

        

        

        return certificationDateTime;
    } 
}
internal HL7V22Field certificationModifyDateTime;

public HL7V22Field CertificationModifyDateTime
{
    get
    {
        if (certificationModifyDateTime != null)
        {
            return certificationModifyDateTime;
        }

        certificationModifyDateTime = new HL7V22Field
        {
            field = message[@"IN3"][7],
            Id = @"IN3.7",
            Type = @"Field",
            Position = @"IN3.7",
            Name = @"Certification Modify Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time that the certification was modified",
            Sample = @"",
        };

        

        

        

        return certificationModifyDateTime;
    } 
}
internal HL7V22Field operator;

public HL7V22Field Operator
{
    get
    {
        if (operator != null)
        {
            return operator;
        }

        operator = new HL7V22Field
        {
            field = message[@"IN3"][8],
            Id = @"IN3.8",
            Type = @"Field",
            Position = @"IN3.8",
            Name = @"Operator",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"party that is responsible for sending this certification information",
            Sample = @"",
        };

        

        

        

        return operator;
    } 
}
internal HL7V22Field certificationBeginDate;

public HL7V22Field CertificationBeginDate
{
    get
    {
        if (certificationBeginDate != null)
        {
            return certificationBeginDate;
        }

        certificationBeginDate = new HL7V22Field
        {
            field = message[@"IN3"][9],
            Id = @"IN3.9",
            Type = @"Field",
            Position = @"IN3.9",
            Name = @"Certification Begin Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date that this certification begins",
            Sample = @"",
        };

        

        

        

        return certificationBeginDate;
    } 
}
internal HL7V22Field certificationEndDate;

public HL7V22Field CertificationEndDate
{
    get
    {
        if (certificationEndDate != null)
        {
            return certificationEndDate;
        }

        certificationEndDate = new HL7V22Field
        {
            field = message[@"IN3"][10],
            Id = @"IN3.10",
            Type = @"Field",
            Position = @"IN3.10",
            Name = @"Certification End Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date that this certification ends",
            Sample = @"",
        };

        

        

        

        return certificationEndDate;
    } 
}
internal HL7V22Field days;

public HL7V22Field Days
{
    get
    {
        if (days != null)
        {
            return days;
        }

        days = new HL7V22Field
        {
            field = message[@"IN3"][11],
            Id = @"IN3.11",
            Type = @"Field",
            Position = @"IN3.11",
            Name = @"Days",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_DTN",
            DataTypeName = @"Day Type And Number",
            TableId = null,
            TableName = null,
            Description = @"number of days for which this certification is valid.  This field will apply to denied, pending, or approved days.  Refer to user-defined table 0149 - day type for suggested entries",
            Sample = @"",
        };

        

        

        

        return days;
    } 
}
internal HL7V22Field nonconcurCodeDescription;

public HL7V22Field NonconcurCodeDescription
{
    get
    {
        if (nonconcurCodeDescription != null)
        {
            return nonconcurCodeDescription;
        }

        nonconcurCodeDescription = new HL7V22Field
        {
            field = message[@"IN3"][12],
            Id = @"IN3.12",
            Type = @"Field",
            Position = @"IN3.12",
            Name = @"Non-concur Code / Description",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"non-concur code and description for a denied request",
            Sample = @"",
        };

        

        

        

        return nonconcurCodeDescription;
    } 
}
internal HL7V22Field nonconcurEffectiveDateTime;

public HL7V22Field NonconcurEffectiveDateTime
{
    get
    {
        if (nonconcurEffectiveDateTime != null)
        {
            return nonconcurEffectiveDateTime;
        }

        nonconcurEffectiveDateTime = new HL7V22Field
        {
            field = message[@"IN3"][13],
            Id = @"IN3.13",
            Type = @"Field",
            Position = @"IN3.13",
            Name = @"Non-concur Effective Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"effective date of the non-concurrence classification",
            Sample = @"",
        };

        

        

        

        return nonconcurEffectiveDateTime;
    } 
}
internal HL7V22Field physicianReviewer;

public HL7V22Field PhysicianReviewer
{
    get
    {
        if (physicianReviewer != null)
        {
            return physicianReviewer;
        }

        physicianReviewer = new HL7V22Field
        {
            field = message[@"IN3"][14],
            Id = @"IN3.14",
            Type = @"Field",
            Position = @"IN3.14",
            Name = @"Physician Reviewer",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"physician who works with and reviews cases that are pending physician review for the certification agency",
            Sample = @"",
        };

        

        

        

        return physicianReviewer;
    } 
}
internal HL7V22Field certificationContact;

public HL7V22Field CertificationContact
{
    get
    {
        if (certificationContact != null)
        {
            return certificationContact;
        }

        certificationContact = new HL7V22Field
        {
            field = message[@"IN3"][15],
            Id = @"IN3.15",
            Type = @"Field",
            Position = @"IN3.15",
            Name = @"Certification Contact",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"name of the party contacted at the certification agency who granted the certification and communicated the certification number",
            Sample = @"",
        };

        

        

        

        return certificationContact;
    } 
}
internal HL7V22Field certificationContactPhoneNumber;

public HL7V22Field CertificationContactPhoneNumber
{
    get
    {
        if (certificationContactPhoneNumber != null)
        {
            return certificationContactPhoneNumber;
        }

        certificationContactPhoneNumber = new HL7V22Field
        {
            field = message[@"IN3"][16],
            Id = @"IN3.16",
            Type = @"Field",
            Position = @"IN3.16",
            Name = @"Certification Contact Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"phone number of the certification contact",
            Sample = @"",
        };

        

        

        

        return certificationContactPhoneNumber;
    } 
}
internal HL7V22Field appealReason;

public HL7V22Field AppealReason
{
    get
    {
        if (appealReason != null)
        {
            return appealReason;
        }

        appealReason = new HL7V22Field
        {
            field = message[@"IN3"][17],
            Id = @"IN3.17",
            Type = @"Field",
            Position = @"IN3.17",
            Name = @"Appeal Reason",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"reason an appeal was made on a non-concur for certification",
            Sample = @"",
        };

        

        

        

        return appealReason;
    } 
}
internal HL7V22Field certificationAgency;

public HL7V22Field CertificationAgency
{
    get
    {
        if (certificationAgency != null)
        {
            return certificationAgency;
        }

        certificationAgency = new HL7V22Field
        {
            field = message[@"IN3"][18],
            Id = @"IN3.18",
            Type = @"Field",
            Position = @"IN3.18",
            Name = @"Certification Agency",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"certification agency",
            Sample = @"",
        };

        

        

        

        return certificationAgency;
    } 
}
internal HL7V22Field certificationAgencyPhoneNumber;

public HL7V22Field CertificationAgencyPhoneNumber
{
    get
    {
        if (certificationAgencyPhoneNumber != null)
        {
            return certificationAgencyPhoneNumber;
        }

        certificationAgencyPhoneNumber = new HL7V22Field
        {
            field = message[@"IN3"][19],
            Id = @"IN3.19",
            Type = @"Field",
            Position = @"IN3.19",
            Name = @"Certification Agency Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"phone number of the Certification agency",
            Sample = @"",
        };

        

        

        

        return certificationAgencyPhoneNumber;
    } 
}
internal HL7V22Field precertificationRequiredWindow;

public HL7V22Field PrecertificationRequiredWindow
{
    get
    {
        if (precertificationRequiredWindow != null)
        {
            return precertificationRequiredWindow;
        }

        precertificationRequiredWindow = new HL7V22Field
        {
            field = message[@"IN3"][20],
            Id = @"IN3.20",
            Type = @"Field",
            Position = @"IN3.20",
            Name = @"Pre-certification Required / Window",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_PCF",
            DataTypeName = @"Pre-certification Required",
            TableId = null,
            TableName = null,
            Description = @"identifies whether pre-certification is required for particular patient types and the time window for obtaining the certification.  Refer to user-defined table 0150 - pre-certification patient type for suggested values.  Valid values for the pre-certification required component are found in table 0136 - Y/N indicator.  The pre-certification window is the amount of time needed to be certified from arrival at the institution.  Its format follows the time stamp (TS) data type rules",
            Sample = @"",
        };

        

        

        

        return precertificationRequiredWindow;
    } 
}
internal HL7V22Field caseManager;

public HL7V22Field CaseManager
{
    get
    {
        if (caseManager != null)
        {
            return caseManager;
        }

        caseManager = new HL7V22Field
        {
            field = message[@"IN3"][21],
            Id = @"IN3.21",
            Type = @"Field",
            Position = @"IN3.21",
            Name = @"Case Manager",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"entity who/which is handling this particular patient's case (e.g., UR nurse, or a specific facility location).",
            Sample = @"",
        };

        

        

        

        return caseManager;
    } 
}
internal HL7V22Field secondOpinionDate;

public HL7V22Field SecondOpinionDate
{
    get
    {
        if (secondOpinionDate != null)
        {
            return secondOpinionDate;
        }

        secondOpinionDate = new HL7V22Field
        {
            field = message[@"IN3"][22],
            Id = @"IN3.22",
            Type = @"Field",
            Position = @"IN3.22",
            Name = @"Second Opinion Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date that the second opinion was obtained",
            Sample = @"",
        };

        

        

        

        return secondOpinionDate;
    } 
}
internal HL7V22Field secondOpinionStatus;

public HL7V22Field SecondOpinionStatus
{
    get
    {
        if (secondOpinionStatus != null)
        {
            return secondOpinionStatus;
        }

        secondOpinionStatus = new HL7V22Field
        {
            field = message[@"IN3"][23],
            Id = @"IN3.23",
            Type = @"Field",
            Position = @"IN3.23",
            Name = @"Second Opinion Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0151",
            TableName = @"SECOND OPINION STATUS",
            Description = @"Code that represents the status of the second opinion.  Refer to user-defined table 0151 - second opinion status for suggested values",
            Sample = @"",
        };

        

        

        

        return secondOpinionStatus;
    } 
}
internal HL7V22Field secondOpinionDocumentationReceived;

public HL7V22Field SecondOpinionDocumentationReceived
{
    get
    {
        if (secondOpinionDocumentationReceived != null)
        {
            return secondOpinionDocumentationReceived;
        }

        secondOpinionDocumentationReceived = new HL7V22Field
        {
            field = message[@"IN3"][24],
            Id = @"IN3.24",
            Type = @"Field",
            Position = @"IN3.24",
            Name = @"Second Opinion Documentation Received",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0152",
            TableName = @"SECOND OPINION DOCUMENTATION RECEIVED",
            Description = @"if accompanying documentation has been received by the provider.  Refer to table 0152 - second opinion documentation received",
            Sample = @"",
        };

        

        

        

        return secondOpinionDocumentationReceived;
    } 
}
internal HL7V22Field secondOpinionPractitioner;

public HL7V22Field SecondOpinionPractitioner
{
    get
    {
        if (secondOpinionPractitioner != null)
        {
            return secondOpinionPractitioner;
        }

        secondOpinionPractitioner = new HL7V22Field
        {
            field = message[@"IN3"][25],
            Id = @"IN3.25",
            Type = @"Field",
            Position = @"IN3.25",
            Name = @"Second Opinion Practitioner",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"ID and name of the physician who provided the second opinion",
            Sample = @"",
        };

        

        

        

        return secondOpinionPractitioner;
    } 
}

    }
}
