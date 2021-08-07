using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentOM1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"OM1"; } }

        public string SegmentId { get { return @"OM1"; } }
        
        public string LongName { get { return @"General - Fields That Apply To Most Observations"; } }
        
        public string Description { get { return @"The OM1 segment contains attributes that apply to the definition of most observations.  This segment also contains the field attributes that specify what additional segments might also be defined for this observation"; } }
        
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
                            Id = @"OM1.1",
                            Type = @"Field",
                            Position = @"OM1.1",
                            Name = @"Segment Type Id",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the string OM1 - identifies a record as a general observation definition segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.2",
                            Type = @"Field",
                            Position = @"OM1.2",
                            Name = @"Sequence Number - Test/ Observation Master File",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"the first OM1 segment in a message is described as 1, the second as 2, and so on",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.3",
                            Type = @"Field",
                            Position = @"OM1.3",
                            Name = @"Producer's Test / Observation Id",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"the producer's usual or preferred identification of the test or observation.   Only three components should be included: <ID code>^<service text name/description>^<source list of code>.  All components should be non-null.  The source list may be any of those included in ASTM Tables 3 and 5, or a local code",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.3.1",
                            Type = @"Component",
                            Position = @"OM1.3.1",
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
                            Id = @"OM1.3.2",
                            Type = @"Component",
                            Position = @"OM1.3.2",
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
                            Id = @"OM1.3.3",
                            Type = @"Component",
                            Position = @"OM1.3.3",
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
                            Id = @"OM1.3.4",
                            Type = @"Component",
                            Position = @"OM1.3.4",
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
                            Id = @"OM1.3.5",
                            Type = @"Component",
                            Position = @"OM1.3.5",
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
                            Id = @"OM1.3.6",
                            Type = @"Component",
                            Position = @"OM1.3.6",
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
                            Id = @"OM1.4",
                            Type = @"Field",
                            Position = @"OM1.4",
                            Name = @"Permitted Data Types",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0125",
                            TableName = @"VALUE TYPE",
                            Description = @"the allowed data type(s) for this observation. The codes are the same as those listed OBX (a given observation may, under different circumstances, take on different data types). Indeed, under limited circumstances, an observation can consist of one or more fragments of different data types. When an observation may have more than one data type, e.g., coded (CE) and numeric (NM) the allowable data types should be separated by repeat delimiters.  Refer to table 0125 - value type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.5",
                            Type = @"Field",
                            Position = @"OM1.5",
                            Name = @"Specimen Required",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = @"a flag indicating whether or not at least one specimen is required for the test/observation.  Refer to table 0136 - Y/N indicator ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.6",
                            Type = @"Field",
                            Position = @"OM1.6",
                            Name = @"Producer Id",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"uniquely identifies the service producing the observation described in this segment.  Three components should be included:  an identifying code, the name of the producer, and the identity of the coding system (e.g., 323-5678^Acme Special Lab^MC).  The identity of the coding system will usually be MC (Medicare provider number or HIBCC site codes) in the United States.  Each country may want to specify its preferred coding system and define a coding system ID to identify it",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.6.1",
                            Type = @"Component",
                            Position = @"OM1.6.1",
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
                            Id = @"OM1.6.2",
                            Type = @"Component",
                            Position = @"OM1.6.2",
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
                            Id = @"OM1.6.3",
                            Type = @"Component",
                            Position = @"OM1.6.3",
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
                            Id = @"OM1.6.4",
                            Type = @"Component",
                            Position = @"OM1.6.4",
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
                            Id = @"OM1.6.5",
                            Type = @"Component",
                            Position = @"OM1.6.5",
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
                            Id = @"OM1.6.6",
                            Type = @"Component",
                            Position = @"OM1.6.6",
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
                            Id = @"OM1.7",
                            Type = @"Field",
                            Position = @"OM1.7",
                            Name = @"Observation Description",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @" a text description of this observation",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.8",
                            Type = @"Field",
                            Position = @"OM1.8",
                            Name = @"Other Test / Observation Ids For The Observation",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"lists all alias codes/identifiers for this observation.  If more than one alias code needs to be specified, multiple three-component, CE-format entries (<code 1>^<name 1>^<code system 1>) may be given, separated by repeat delimiters.  An observation may have as many names/codes as are applicable (e.g., ICD9, ACR-NEMA, SNOMED, and READ).  We encourage the inclusion of as many different codes as may apply to assist cross-system mapping of terminology.  All components of each triplet should be nonnull (that is, names and coding system IDs within the CE data type are required in addition to codes).  The source list may be any of those included in ASTM Tables 3 and 5. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.8.1",
                            Type = @"Component",
                            Position = @"OM1.8.1",
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
                            Id = @"OM1.8.2",
                            Type = @"Component",
                            Position = @"OM1.8.2",
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
                            Id = @"OM1.8.3",
                            Type = @"Component",
                            Position = @"OM1.8.3",
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
                            Id = @"OM1.8.4",
                            Type = @"Component",
                            Position = @"OM1.8.4",
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
                            Id = @"OM1.8.5",
                            Type = @"Component",
                            Position = @"OM1.8.5",
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
                            Id = @"OM1.8.6",
                            Type = @"Component",
                            Position = @"OM1.8.6",
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
                            Id = @"OM1.9",
                            Type = @"Field",
                            Position = @"OM1.9",
                            Name = @"Other Names",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"include any text aliases, or synonyms for the name in the context of the ordering service.  These are alternative names, not associated with a particular coding system, by which the battery, test, or observation (e.g., measurement, test, diagnostic study, treatment) is known to users of the system.  Multiple names in this list are separated by repeat delimiters",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.10",
                            Type = @"Field",
                            Position = @"OM1.10",
                            Name = @"Preferred Report Name For The Observation",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the preferred name for reporting the observation or battery.  The name can contain up to 30 characters (including blanks).  It is the preferred name for columnar reports that require a maximum name size",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.11",
                            Type = @"Field",
                            Position = @"OM1.11",
                            Name = @"Preferred Short Name Or Mnemonic For Observation",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"a name that can be used in space-limited reports (e.g., specimen labels) to identify the observation for the convenience of human readers.  The name can contain up to eight characters",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.12",
                            Type = @"Field",
                            Position = @"OM1.12",
                            Name = @"Preferred Long Name For The Observation",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the fully specified name for the observation or battery.  It may include the full (unabbreviated) multipleword names and contain up to 200 characters. It should be as scientifically precise as possible",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.13",
                            Type = @"Field",
                            Position = @"OM1.13",
                            Name = @"Orderability",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = @"whether or not a test/observation is an orderable code.   Refer to table 0136 - Y/N indicator ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.14",
                            Type = @"Field",
                            Position = @"OM1.14",
                            Name = @"Identity Of Instrument Used To Perform This Study",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"when applicable, specifies the instrument or device that is used to generate this observation or battery.  Examples are the automated instrument in the laboratory, the imaging device and model number in radiology, and the automatic blood pressure machine on the ward.  The instrument is specified as a coded entry in anticipation that these identifiers could be specified as codes.  Initially, we expect that most of the information about devices will be transmitted as text in the second component of the CE identifier.  If more than one kind of instrument is used, all of them can be listed, separated by repeat delimiters",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.14.1",
                            Type = @"Component",
                            Position = @"OM1.14.1",
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
                            Id = @"OM1.14.2",
                            Type = @"Component",
                            Position = @"OM1.14.2",
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
                            Id = @"OM1.14.3",
                            Type = @"Component",
                            Position = @"OM1.14.3",
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
                            Id = @"OM1.14.4",
                            Type = @"Component",
                            Position = @"OM1.14.4",
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
                            Id = @"OM1.14.5",
                            Type = @"Component",
                            Position = @"OM1.14.5",
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
                            Id = @"OM1.14.6",
                            Type = @"Component",
                            Position = @"OM1.14.6",
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
                            Id = @"OM1.15",
                            Type = @"Field",
                            Position = @"OM1.15",
                            Name = @"Coded Representation Of Method",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"method(s) used to produce the observation should be recorded in a computer-understandable (coded) form here.  This field should report the same method(s) reported in narrative in the following field.  More than one method may be listed, but only if they produce results that are clinically indistinguishable.  Multiple methods must be separated by repeat delimiters",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.15.1",
                            Type = @"Component",
                            Position = @"OM1.15.1",
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
                            Id = @"OM1.15.2",
                            Type = @"Component",
                            Position = @"OM1.15.2",
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
                            Id = @"OM1.15.3",
                            Type = @"Component",
                            Position = @"OM1.15.3",
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
                            Id = @"OM1.15.4",
                            Type = @"Component",
                            Position = @"OM1.15.4",
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
                            Id = @"OM1.15.5",
                            Type = @"Component",
                            Position = @"OM1.15.5",
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
                            Id = @"OM1.15.6",
                            Type = @"Component",
                            Position = @"OM1.15.6",
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
                            Id = @"OM1.16",
                            Type = @"Field",
                            Position = @"OM1.16",
                            Name = @"Portable",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = @"whether or not a portable device may be used for the test/observation.  Refer to table 0136 - Y/N indicator",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17",
                            Type = @"Field",
                            Position = @"OM1.17",
                            Name = @"Observation Producing Department / Section",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"permits the sorting of observation orders and values by the providing service's department/section.  It provides ""source oriented"" reporting when required.  The codes for this field should be taken from ASTM Table 15 (Diagnostic Service Codes).  Free text may be used instead of these codes, but in that case, they should be recorded as the second ""component"" of the field to distinguish them from the standard codes.  Multiple codes in this field are separated by repeat delimiters",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.18",
                            Type = @"Field",
                            Position = @"OM1.18",
                            Name = @"Telephone Number Of Section",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"the telphone number for calling responsible parties in this section to ask results or advice about the use of this test",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.19",
                            Type = @"Field",
                            Position = @"OM1.19",
                            Name = @"Nature Of Test / Observation",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0174",
                            TableName = @"NATURE OF TEST/OBSERVATION",
                            Description = @"whether the definition entry identifies a test battery, an entire functional procedure or study, a single test value (observation), multiple test batteries or functional procedures as an orderable unit (profile), or a single test value (observation) calculated from other independent observations",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.20",
                            Type = @"Field",
                            Position = @"OM1.20",
                            Name = @"Report Subheader",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"an optional string that defines the preferred header under which this observation should be listed on a standard display.  For example, if the test is hemoglobin, this string might be ""Complete blood count.""  It is represented as a coded data type so that a battery can be a header.  Only the description part of the string may be included in case the subheader does not have an associated code.  When a series of observations is displayed according to the sort order given below, the subheader that groups those observations is presented whenever the subheader changes",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.20.1",
                            Type = @"Component",
                            Position = @"OM1.20.1",
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
                            Id = @"OM1.20.2",
                            Type = @"Component",
                            Position = @"OM1.20.2",
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
                            Id = @"OM1.20.3",
                            Type = @"Component",
                            Position = @"OM1.20.3",
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
                            Id = @"OM1.20.4",
                            Type = @"Component",
                            Position = @"OM1.20.4",
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
                            Id = @"OM1.20.5",
                            Type = @"Component",
                            Position = @"OM1.20.5",
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
                            Id = @"OM1.20.6",
                            Type = @"Component",
                            Position = @"OM1.20.6",
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
                            Id = @"OM1.21",
                            Type = @"Field",
                            Position = @"OM1.21",
                            Name = @"Report Display Order",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"an optional string that defines the sort order in which this observation is presented in a standard report or display that contains many observations",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.22",
                            Type = @"Field",
                            Position = @"OM1.22",
                            Name = @"Date / Time Stamp For Any Change In Definition For Obs",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"the date and time that the last of any field change was made and in the host's record corresponding to the OM1 segment",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.22.1",
                            Type = @"Component",
                            Position = @"OM1.22.1",
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
                            Id = @"OM1.22.2",
                            Type = @"Component",
                            Position = @"OM1.22.2",
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
                            Id = @"OM1.23",
                            Type = @"Field",
                            Position = @"OM1.23",
                            Name = @"Effective Date / Time Of Change",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"the date and time of the last change in the test procedure that would make previous results incompatible with new results, e.g., the last time that normal reference range or units changed for a numeric test/observation",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.23.1",
                            Type = @"Component",
                            Position = @"OM1.23.1",
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
                            Id = @"OM1.23.2",
                            Type = @"Component",
                            Position = @"OM1.23.2",
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
                            Id = @"OM1.24",
                            Type = @"Field",
                            Position = @"OM1.24",
                            Name = @"Typical Turn-around Time",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"typical processing time for single test/observation.  This field indicates the time from the delivery of a specimen or transport of a patient to a diagnostic service and the completion of the study.  It includes the usual waiting time.  The units are measured in minutes.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.25",
                            Type = @"Field",
                            Position = @"OM1.25",
                            Name = @"Processing Time",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"usual length of time (in minutes) between the start of a test process and its completion",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.26",
                            Type = @"Field",
                            Position = @"OM1.26",
                            Name = @"Processing Priority",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0168",
                            TableName = @"PROCESSING PRIORITY",
                            Description = @"specifies one or more available priorities for performing the observation or test.  This is the priority that can be placed in OBR-28-quantity/timing.  For tests that require a specimen, this field may contain two components in the format <specimen priority>^<processing priority>.  The first component in this case indicates the priority with which the specimen will be collected and is the priority that is specified in an OBR segment when ordering the observation.  The second component indicates the corresponding priority with which the producer service will process the specimen, produce the observation, and return results, when this differs from collection priority",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.27",
                            Type = @"Field",
                            Position = @"OM1.27",
                            Name = @"Reporting Priority",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0169",
                            TableName = @"REPORTIN PRIORITY",
                            Description = @"the available priorities reporting the test results when the user is asked to specify the reporting priority independent of the processing priority",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28",
                            Type = @"Field",
                            Position = @"OM1.28",
                            Name = @"Outside Site(s) Where Observation May Be Performed",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"if an outside service or services produce the observation, this field contains the identification(s) of the outside service(s).  The format of this CE field uses the producer ID (as defined in OM1-6-producer ID) and the name of the service separated by component delimiters.  An example is 39221^ACME lab^MC.  If multiple services are used, they should be separated by repeat delimiter(s). ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.1",
                            Type = @"Component",
                            Position = @"OM1.28.1",
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
                            Id = @"OM1.28.2",
                            Type = @"Component",
                            Position = @"OM1.28.2",
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
                            Id = @"OM1.28.3",
                            Type = @"Component",
                            Position = @"OM1.28.3",
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
                            Id = @"OM1.28.4",
                            Type = @"Component",
                            Position = @"OM1.28.4",
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
                            Id = @"OM1.28.5",
                            Type = @"Component",
                            Position = @"OM1.28.5",
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
                            Id = @"OM1.28.6",
                            Type = @"Component",
                            Position = @"OM1.28.6",
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
                            Id = @"OM1.29",
                            Type = @"Field",
                            Position = @"OM1.29",
                            Name = @"Address Of Outside Site(s)",
                            Length = 1000,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = @" record in this field the address of the outside services listed in OM1-28-outside site(s) where observation may be performed.  If multiple services are recorded in that field, their addresses should be separated by repeat delimiters, and the addresses should appear in the same order in which the services appear in the preceding field",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.1",
                            Type = @"Component",
                            Position = @"OM1.29.1",
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
                            Id = @"OM1.29.2",
                            Type = @"Component",
                            Position = @"OM1.29.2",
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
                            Id = @"OM1.29.3",
                            Type = @"Component",
                            Position = @"OM1.29.3",
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
                            Id = @"OM1.29.4",
                            Type = @"Component",
                            Position = @"OM1.29.4",
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
                            Id = @"OM1.29.5",
                            Type = @"Component",
                            Position = @"OM1.29.5",
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
                            Id = @"OM1.29.6",
                            Type = @"Component",
                            Position = @"OM1.29.6",
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
                            Id = @"OM1.29.7",
                            Type = @"Component",
                            Position = @"OM1.29.7",
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
                            Id = @"OM1.29.8",
                            Type = @"Component",
                            Position = @"OM1.29.8",
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
                            Id = @"OM1.30",
                            Type = @"Field",
                            Position = @"OM1.30",
                            Name = @"Phone Number Of Outside Site",
                            Length = 400,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"the telephone number of the outside site",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.31",
                            Type = @"Field",
                            Position = @"OM1.31",
                            Name = @"Confidentiality Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0177",
                            TableName = @"CONFIDENTIALITY CODE",
                            Description = @"the degree to which special confidentiality protection should be applied to the observation.  For example, a tighter control may be applied to an HIV titer than to a CBC.  Refer to user-defined table 0177 - confidentiality code for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.32",
                            Type = @"Field",
                            Position = @"OM1.32",
                            Name = @"Observations Required To Interpret The Observation",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"list of variables that the diagnostic service needs to interpret the results of an ordered study.  The observations specified here should be sent to the diagnostic service as OBX segments along with the order (OBR) segment",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.32.1",
                            Type = @"Component",
                            Position = @"OM1.32.1",
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
                            Id = @"OM1.32.2",
                            Type = @"Component",
                            Position = @"OM1.32.2",
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
                            Id = @"OM1.32.3",
                            Type = @"Component",
                            Position = @"OM1.32.3",
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
                            Id = @"OM1.32.4",
                            Type = @"Component",
                            Position = @"OM1.32.4",
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
                            Id = @"OM1.32.5",
                            Type = @"Component",
                            Position = @"OM1.32.5",
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
                            Id = @"OM1.32.6",
                            Type = @"Component",
                            Position = @"OM1.32.6",
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
                            Id = @"OM1.33",
                            Type = @"Field",
                            Position = @"OM1.33",
                            Name = @"Interpretation Of Observations",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"clinical information about interpreting test results.  Examples are the conditions (drugs) that may cause false abnormals, and the information about the sensitivity and specificity of the test for diagnoses",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.34",
                            Type = @"Field",
                            Position = @"OM1.34",
                            Name = @"Contraindications To Observations",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"list diagnosis or problem for which the test is a contraindication or of possible danger (e.g., pacemaker, pregnancy, diabetes).  For example, if the test identified in OM1 was an intravenous pyelogram, this field would include warnings about the use of contrast media in diabetes. The contraindication diagnoses should be separated by repeat delimiters",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.34.1",
                            Type = @"Component",
                            Position = @"OM1.34.1",
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
                            Id = @"OM1.34.2",
                            Type = @"Component",
                            Position = @"OM1.34.2",
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
                            Id = @"OM1.34.3",
                            Type = @"Component",
                            Position = @"OM1.34.3",
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
                            Id = @"OM1.34.4",
                            Type = @"Component",
                            Position = @"OM1.34.4",
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
                            Id = @"OM1.34.5",
                            Type = @"Component",
                            Position = @"OM1.34.5",
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
                            Id = @"OM1.34.6",
                            Type = @"Component",
                            Position = @"OM1.34.6",
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
                            Id = @"OM1.35",
                            Type = @"Field",
                            Position = @"OM1.35",
                            Name = @"Reflex Tests / Observations",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"includes the test names as type CE (i.e., <code>^<text name>^<coding system>) that may be ordered automatically by the diagnostic service, depending on the results obtained from the ordered battery.  A screening CBC might trigger a reticulocyte count if the Hgb is less than 12.  Multiple reflex tests are separated by repeat delimiters",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.35.1",
                            Type = @"Component",
                            Position = @"OM1.35.1",
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
                            Id = @"OM1.35.2",
                            Type = @"Component",
                            Position = @"OM1.35.2",
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
                            Id = @"OM1.35.3",
                            Type = @"Component",
                            Position = @"OM1.35.3",
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
                            Id = @"OM1.35.4",
                            Type = @"Component",
                            Position = @"OM1.35.4",
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
                            Id = @"OM1.35.5",
                            Type = @"Component",
                            Position = @"OM1.35.5",
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
                            Id = @"OM1.35.6",
                            Type = @"Component",
                            Position = @"OM1.35.6",
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
                            Id = @"OM1.36",
                            Type = @"Field",
                            Position = @"OM1.36",
                            Name = @"Rules That Trigger Reflex Testing",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the rules that trigger the reflex tests listed above.  If multiple reflex tests are listed in OM1-35-reflex tests/observations separated by repeat delimiters, a set of corresponding rules will be included in this section.  The first rule will apply to the first test, the second to the second test, and so on",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.37",
                            Type = @"Field",
                            Position = @"OM1.37",
                            Name = @"Fixed Canned Message",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"codes and a fixed text message that is always associated with an abbreviation.  The field may include multiple messages separated by repeat delimiters",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.37.1",
                            Type = @"Component",
                            Position = @"OM1.37.1",
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
                            Id = @"OM1.37.2",
                            Type = @"Component",
                            Position = @"OM1.37.2",
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
                            Id = @"OM1.37.3",
                            Type = @"Component",
                            Position = @"OM1.37.3",
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
                            Id = @"OM1.37.4",
                            Type = @"Component",
                            Position = @"OM1.37.4",
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
                            Id = @"OM1.37.5",
                            Type = @"Component",
                            Position = @"OM1.37.5",
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
                            Id = @"OM1.37.6",
                            Type = @"Component",
                            Position = @"OM1.37.6",
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
                            Id = @"OM1.38",
                            Type = @"Field",
                            Position = @"OM1.38",
                            Name = @"Patient Preparation",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"for tests or observations that require special patient preparation, diet, or medications, record them here.  For GI contrast studies, this field would contain the pretest diet, e.g., low residue for two days, NPO before study, and the preferred purgatives.  Each separate med, diet, or preparation should be delimited by a repeat delimiter.  Separate each requirement by a repeat delimiter.  Example for a sigmoidectomy: clear liquid diet full day before procedure~take 8 oz mag citrate 6pm day before procedure~take 2 ducat tabs (5m) at 4pm day before procedure~NPO past midnight",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.39",
                            Type = @"Field",
                            Position = @"OM1.39",
                            Name = @"Procedure Medication",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"treatments that may be needed as part of the procedure.  Examples are radioactive iodine for a thyroid screen, and methacholine for a methacholine spirometry challenge.  This field should be identified as a CE data type",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.39.1",
                            Type = @"Component",
                            Position = @"OM1.39.1",
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
                            Id = @"OM1.39.2",
                            Type = @"Component",
                            Position = @"OM1.39.2",
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
                            Id = @"OM1.39.3",
                            Type = @"Component",
                            Position = @"OM1.39.3",
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
                            Id = @"OM1.39.4",
                            Type = @"Component",
                            Position = @"OM1.39.4",
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
                            Id = @"OM1.39.5",
                            Type = @"Component",
                            Position = @"OM1.39.5",
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
                            Id = @"OM1.39.6",
                            Type = @"Component",
                            Position = @"OM1.39.6",
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
                            Id = @"OM1.40",
                            Type = @"Field",
                            Position = @"OM1.40",
                            Name = @"Factors That May Affect The Observation",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"text description of the foods, diagnoses, drugs, or other conditions that may influence the interpretation of the observation. Information about the direction of the effect, and any recommendation about altering the diet, conditions, or drug before initiating the test observation",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.41",
                            Type = @"Field",
                            Position = @"OM1.41",
                            Name = @"Test / Observation Performance Schedule",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"for diagnostic studies/tests that are performed only at certain times during the course of a work day or work week, this field indicates the maximum interval between successive test performances (the test may actually be performed more frequently).  The format given in ASTM Table 17, Codes for Service Intervals, should be used.  If necessary, multiple codes may be given, separated by repeat delimiters.  The use of multiple codes indicates that the test is performed at multiple concurrent intervals.  For example, Q6H indicates that the test is performed at least once every 6 hours around the clock.  Q1J indicates that the test is performed at least every week on Mondays.  QAM~QPM indicates that the test is performed at least once every morning and every evening.  Q1J~Q3J~Q5J indicates that the test is performed at least every week on Mondays, Wednesdays, and Fridays.  C indicates that the test is performed continuously, 7 days per week. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.42",
                            Type = @"Field",
                            Position = @"OM1.42",
                            Name = @"Description Of Test Methods",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"text description of the methods used to perform the text and generate the observations.  Bibliographic citations may be included",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentOM1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field segmentTypeId;

public HL7V22Field SegmentTypeId
{
    get
    {
        if (segmentTypeId != null)
        {
            return segmentTypeId;
        }

        segmentTypeId = new HL7V22Field
        {
            field = message[@"OM1"][1],
            Id = @"OM1.1",
            Type = @"Field",
            Position = @"OM1.1",
            Name = @"Segment Type Id",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"the string OM1 - identifies a record as a general observation definition segment",
            Sample = @"",
        };

        

        

        

        return segmentTypeId;
    } 
}
internal HL7V22Field sequenceNumberTestObservationMasterFile;

public HL7V22Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (sequenceNumberTestObservationMasterFile != null)
        {
            return sequenceNumberTestObservationMasterFile;
        }

        sequenceNumberTestObservationMasterFile = new HL7V22Field
        {
            field = message[@"OM1"][2],
            Id = @"OM1.2",
            Type = @"Field",
            Position = @"OM1.2",
            Name = @"Sequence Number - Test/ Observation Master File",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"the first OM1 segment in a message is described as 1, the second as 2, and so on",
            Sample = @"",
        };

        

        

        

        return sequenceNumberTestObservationMasterFile;
    } 
}
internal HL7V22Field producer'sTestObservationId;

public HL7V22Field Producer'sTestObservationId
{
    get
    {
        if (producer'sTestObservationId != null)
        {
            return producer'sTestObservationId;
        }

        producer'sTestObservationId = new HL7V22Field
        {
            field = message[@"OM1"][3],
            Id = @"OM1.3",
            Type = @"Field",
            Position = @"OM1.3",
            Name = @"Producer's Test / Observation Id",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"the producer's usual or preferred identification of the test or observation.   Only three components should be included: <ID code>^<service text name/description>^<source list of code>.  All components should be non-null.  The source list may be any of those included in ASTM Tables 3 and 5, or a local code",
            Sample = @"",
        };

        

        

        

        return producer'sTestObservationId;
    } 
}
internal HL7V22Field permittedDataTypes;

public HL7V22Field PermittedDataTypes
{
    get
    {
        if (permittedDataTypes != null)
        {
            return permittedDataTypes;
        }

        permittedDataTypes = new HL7V22Field
        {
            field = message[@"OM1"][4],
            Id = @"OM1.4",
            Type = @"Field",
            Position = @"OM1.4",
            Name = @"Permitted Data Types",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0125",
            TableName = @"VALUE TYPE",
            Description = @"the allowed data type(s) for this observation. The codes are the same as those listed OBX (a given observation may, under different circumstances, take on different data types). Indeed, under limited circumstances, an observation can consist of one or more fragments of different data types. When an observation may have more than one data type, e.g., coded (CE) and numeric (NM) the allowable data types should be separated by repeat delimiters.  Refer to table 0125 - value type for valid values",
            Sample = @"",
        };

        

        

        

        return permittedDataTypes;
    } 
}
internal HL7V22Field specimenRequired;

public HL7V22Field SpecimenRequired
{
    get
    {
        if (specimenRequired != null)
        {
            return specimenRequired;
        }

        specimenRequired = new HL7V22Field
        {
            field = message[@"OM1"][5],
            Id = @"OM1.5",
            Type = @"Field",
            Position = @"OM1.5",
            Name = @"Specimen Required",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"a flag indicating whether or not at least one specimen is required for the test/observation.  Refer to table 0136 - Y/N indicator ",
            Sample = @"",
        };

        

        

        

        return specimenRequired;
    } 
}
internal HL7V22Field producerId;

public HL7V22Field ProducerId
{
    get
    {
        if (producerId != null)
        {
            return producerId;
        }

        producerId = new HL7V22Field
        {
            field = message[@"OM1"][6],
            Id = @"OM1.6",
            Type = @"Field",
            Position = @"OM1.6",
            Name = @"Producer Id",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"uniquely identifies the service producing the observation described in this segment.  Three components should be included:  an identifying code, the name of the producer, and the identity of the coding system (e.g., 323-5678^Acme Special Lab^MC).  The identity of the coding system will usually be MC (Medicare provider number or HIBCC site codes) in the United States.  Each country may want to specify its preferred coding system and define a coding system ID to identify it",
            Sample = @"",
        };

        

        

        

        return producerId;
    } 
}
internal HL7V22Field observationDescription;

public HL7V22Field ObservationDescription
{
    get
    {
        if (observationDescription != null)
        {
            return observationDescription;
        }

        observationDescription = new HL7V22Field
        {
            field = message[@"OM1"][7],
            Id = @"OM1.7",
            Type = @"Field",
            Position = @"OM1.7",
            Name = @"Observation Description",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @" a text description of this observation",
            Sample = @"",
        };

        

        

        

        return observationDescription;
    } 
}
internal HL7V22Field otherTestObservationIdsForTheObservation;

public HL7V22Field OtherTestObservationIdsForTheObservation
{
    get
    {
        if (otherTestObservationIdsForTheObservation != null)
        {
            return otherTestObservationIdsForTheObservation;
        }

        otherTestObservationIdsForTheObservation = new HL7V22Field
        {
            field = message[@"OM1"][8],
            Id = @"OM1.8",
            Type = @"Field",
            Position = @"OM1.8",
            Name = @"Other Test / Observation Ids For The Observation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"lists all alias codes/identifiers for this observation.  If more than one alias code needs to be specified, multiple three-component, CE-format entries (<code 1>^<name 1>^<code system 1>) may be given, separated by repeat delimiters.  An observation may have as many names/codes as are applicable (e.g., ICD9, ACR-NEMA, SNOMED, and READ).  We encourage the inclusion of as many different codes as may apply to assist cross-system mapping of terminology.  All components of each triplet should be nonnull (that is, names and coding system IDs within the CE data type are required in addition to codes).  The source list may be any of those included in ASTM Tables 3 and 5. ",
            Sample = @"",
        };

        

        

        

        return otherTestObservationIdsForTheObservation;
    } 
}
internal HL7V22Field otherNames;

public HL7V22Field OtherNames
{
    get
    {
        if (otherNames != null)
        {
            return otherNames;
        }

        otherNames = new HL7V22Field
        {
            field = message[@"OM1"][9],
            Id = @"OM1.9",
            Type = @"Field",
            Position = @"OM1.9",
            Name = @"Other Names",
            Length = 200,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"include any text aliases, or synonyms for the name in the context of the ordering service.  These are alternative names, not associated with a particular coding system, by which the battery, test, or observation (e.g., measurement, test, diagnostic study, treatment) is known to users of the system.  Multiple names in this list are separated by repeat delimiters",
            Sample = @"",
        };

        

        

        

        return otherNames;
    } 
}
internal HL7V22Field preferredReportNameForTheObservation;

public HL7V22Field PreferredReportNameForTheObservation
{
    get
    {
        if (preferredReportNameForTheObservation != null)
        {
            return preferredReportNameForTheObservation;
        }

        preferredReportNameForTheObservation = new HL7V22Field
        {
            field = message[@"OM1"][10],
            Id = @"OM1.10",
            Type = @"Field",
            Position = @"OM1.10",
            Name = @"Preferred Report Name For The Observation",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"the preferred name for reporting the observation or battery.  The name can contain up to 30 characters (including blanks).  It is the preferred name for columnar reports that require a maximum name size",
            Sample = @"",
        };

        

        

        

        return preferredReportNameForTheObservation;
    } 
}
internal HL7V22Field preferredShortNameOrMnemonicForObservation;

public HL7V22Field PreferredShortNameOrMnemonicForObservation
{
    get
    {
        if (preferredShortNameOrMnemonicForObservation != null)
        {
            return preferredShortNameOrMnemonicForObservation;
        }

        preferredShortNameOrMnemonicForObservation = new HL7V22Field
        {
            field = message[@"OM1"][11],
            Id = @"OM1.11",
            Type = @"Field",
            Position = @"OM1.11",
            Name = @"Preferred Short Name Or Mnemonic For Observation",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"a name that can be used in space-limited reports (e.g., specimen labels) to identify the observation for the convenience of human readers.  The name can contain up to eight characters",
            Sample = @"",
        };

        

        

        

        return preferredShortNameOrMnemonicForObservation;
    } 
}
internal HL7V22Field preferredLongNameForTheObservation;

public HL7V22Field PreferredLongNameForTheObservation
{
    get
    {
        if (preferredLongNameForTheObservation != null)
        {
            return preferredLongNameForTheObservation;
        }

        preferredLongNameForTheObservation = new HL7V22Field
        {
            field = message[@"OM1"][12],
            Id = @"OM1.12",
            Type = @"Field",
            Position = @"OM1.12",
            Name = @"Preferred Long Name For The Observation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"the fully specified name for the observation or battery.  It may include the full (unabbreviated) multipleword names and contain up to 200 characters. It should be as scientifically precise as possible",
            Sample = @"",
        };

        

        

        

        return preferredLongNameForTheObservation;
    } 
}
internal HL7V22Field orderability;

public HL7V22Field Orderability
{
    get
    {
        if (orderability != null)
        {
            return orderability;
        }

        orderability = new HL7V22Field
        {
            field = message[@"OM1"][13],
            Id = @"OM1.13",
            Type = @"Field",
            Position = @"OM1.13",
            Name = @"Orderability",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"whether or not a test/observation is an orderable code.   Refer to table 0136 - Y/N indicator ",
            Sample = @"",
        };

        

        

        

        return orderability;
    } 
}
internal HL7V22Field identityOfInstrumentUsedToPerformThisStudy;

public HL7V22Field IdentityOfInstrumentUsedToPerformThisStudy
{
    get
    {
        if (identityOfInstrumentUsedToPerformThisStudy != null)
        {
            return identityOfInstrumentUsedToPerformThisStudy;
        }

        identityOfInstrumentUsedToPerformThisStudy = new HL7V22Field
        {
            field = message[@"OM1"][14],
            Id = @"OM1.14",
            Type = @"Field",
            Position = @"OM1.14",
            Name = @"Identity Of Instrument Used To Perform This Study",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"when applicable, specifies the instrument or device that is used to generate this observation or battery.  Examples are the automated instrument in the laboratory, the imaging device and model number in radiology, and the automatic blood pressure machine on the ward.  The instrument is specified as a coded entry in anticipation that these identifiers could be specified as codes.  Initially, we expect that most of the information about devices will be transmitted as text in the second component of the CE identifier.  If more than one kind of instrument is used, all of them can be listed, separated by repeat delimiters",
            Sample = @"",
        };

        

        

        

        return identityOfInstrumentUsedToPerformThisStudy;
    } 
}
internal HL7V22Field codedRepresentationOfMethod;

public HL7V22Field CodedRepresentationOfMethod
{
    get
    {
        if (codedRepresentationOfMethod != null)
        {
            return codedRepresentationOfMethod;
        }

        codedRepresentationOfMethod = new HL7V22Field
        {
            field = message[@"OM1"][15],
            Id = @"OM1.15",
            Type = @"Field",
            Position = @"OM1.15",
            Name = @"Coded Representation Of Method",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"method(s) used to produce the observation should be recorded in a computer-understandable (coded) form here.  This field should report the same method(s) reported in narrative in the following field.  More than one method may be listed, but only if they produce results that are clinically indistinguishable.  Multiple methods must be separated by repeat delimiters",
            Sample = @"",
        };

        

        

        

        return codedRepresentationOfMethod;
    } 
}
internal HL7V22Field portable;

public HL7V22Field Portable
{
    get
    {
        if (portable != null)
        {
            return portable;
        }

        portable = new HL7V22Field
        {
            field = message[@"OM1"][16],
            Id = @"OM1.16",
            Type = @"Field",
            Position = @"OM1.16",
            Name = @"Portable",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"whether or not a portable device may be used for the test/observation.  Refer to table 0136 - Y/N indicator",
            Sample = @"",
        };

        

        

        

        return portable;
    } 
}
internal HL7V22Field observationProducingDepartmentSection;

public HL7V22Field ObservationProducingDepartmentSection
{
    get
    {
        if (observationProducingDepartmentSection != null)
        {
            return observationProducingDepartmentSection;
        }

        observationProducingDepartmentSection = new HL7V22Field
        {
            field = message[@"OM1"][17],
            Id = @"OM1.17",
            Type = @"Field",
            Position = @"OM1.17",
            Name = @"Observation Producing Department / Section",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"permits the sorting of observation orders and values by the providing service's department/section.  It provides ""source oriented"" reporting when required.  The codes for this field should be taken from ASTM Table 15 (Diagnostic Service Codes).  Free text may be used instead of these codes, but in that case, they should be recorded as the second ""component"" of the field to distinguish them from the standard codes.  Multiple codes in this field are separated by repeat delimiters",
            Sample = @"",
        };

        

        

        

        return observationProducingDepartmentSection;
    } 
}
internal HL7V22Field telephoneNumberOfSection;

public HL7V22Field TelephoneNumberOfSection
{
    get
    {
        if (telephoneNumberOfSection != null)
        {
            return telephoneNumberOfSection;
        }

        telephoneNumberOfSection = new HL7V22Field
        {
            field = message[@"OM1"][18],
            Id = @"OM1.18",
            Type = @"Field",
            Position = @"OM1.18",
            Name = @"Telephone Number Of Section",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"the telphone number for calling responsible parties in this section to ask results or advice about the use of this test",
            Sample = @"",
        };

        

        

        

        return telephoneNumberOfSection;
    } 
}
internal HL7V22Field natureOfTestObservation;

public HL7V22Field NatureOfTestObservation
{
    get
    {
        if (natureOfTestObservation != null)
        {
            return natureOfTestObservation;
        }

        natureOfTestObservation = new HL7V22Field
        {
            field = message[@"OM1"][19],
            Id = @"OM1.19",
            Type = @"Field",
            Position = @"OM1.19",
            Name = @"Nature Of Test / Observation",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0174",
            TableName = @"NATURE OF TEST/OBSERVATION",
            Description = @"whether the definition entry identifies a test battery, an entire functional procedure or study, a single test value (observation), multiple test batteries or functional procedures as an orderable unit (profile), or a single test value (observation) calculated from other independent observations",
            Sample = @"",
        };

        

        

        

        return natureOfTestObservation;
    } 
}
internal HL7V22Field reportSubheader;

public HL7V22Field ReportSubheader
{
    get
    {
        if (reportSubheader != null)
        {
            return reportSubheader;
        }

        reportSubheader = new HL7V22Field
        {
            field = message[@"OM1"][20],
            Id = @"OM1.20",
            Type = @"Field",
            Position = @"OM1.20",
            Name = @"Report Subheader",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"an optional string that defines the preferred header under which this observation should be listed on a standard display.  For example, if the test is hemoglobin, this string might be ""Complete blood count.""  It is represented as a coded data type so that a battery can be a header.  Only the description part of the string may be included in case the subheader does not have an associated code.  When a series of observations is displayed according to the sort order given below, the subheader that groups those observations is presented whenever the subheader changes",
            Sample = @"",
        };

        

        

        

        return reportSubheader;
    } 
}
internal HL7V22Field reportDisplayOrder;

public HL7V22Field ReportDisplayOrder
{
    get
    {
        if (reportDisplayOrder != null)
        {
            return reportDisplayOrder;
        }

        reportDisplayOrder = new HL7V22Field
        {
            field = message[@"OM1"][21],
            Id = @"OM1.21",
            Type = @"Field",
            Position = @"OM1.21",
            Name = @"Report Display Order",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"an optional string that defines the sort order in which this observation is presented in a standard report or display that contains many observations",
            Sample = @"",
        };

        

        

        

        return reportDisplayOrder;
    } 
}
internal HL7V22Field dateTimeStampForAnyChangeInDefinitionForObs;

public HL7V22Field DateTimeStampForAnyChangeInDefinitionForObs
{
    get
    {
        if (dateTimeStampForAnyChangeInDefinitionForObs != null)
        {
            return dateTimeStampForAnyChangeInDefinitionForObs;
        }

        dateTimeStampForAnyChangeInDefinitionForObs = new HL7V22Field
        {
            field = message[@"OM1"][22],
            Id = @"OM1.22",
            Type = @"Field",
            Position = @"OM1.22",
            Name = @"Date / Time Stamp For Any Change In Definition For Obs",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"the date and time that the last of any field change was made and in the host's record corresponding to the OM1 segment",
            Sample = @"",
        };

        

        

        

        return dateTimeStampForAnyChangeInDefinitionForObs;
    } 
}
internal HL7V22Field effectiveDateTimeOfChange;

public HL7V22Field EffectiveDateTimeOfChange
{
    get
    {
        if (effectiveDateTimeOfChange != null)
        {
            return effectiveDateTimeOfChange;
        }

        effectiveDateTimeOfChange = new HL7V22Field
        {
            field = message[@"OM1"][23],
            Id = @"OM1.23",
            Type = @"Field",
            Position = @"OM1.23",
            Name = @"Effective Date / Time Of Change",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"the date and time of the last change in the test procedure that would make previous results incompatible with new results, e.g., the last time that normal reference range or units changed for a numeric test/observation",
            Sample = @"",
        };

        

        

        

        return effectiveDateTimeOfChange;
    } 
}
internal HL7V22Field typicalTurnaroundTime;

public HL7V22Field TypicalTurnaroundTime
{
    get
    {
        if (typicalTurnaroundTime != null)
        {
            return typicalTurnaroundTime;
        }

        typicalTurnaroundTime = new HL7V22Field
        {
            field = message[@"OM1"][24],
            Id = @"OM1.24",
            Type = @"Field",
            Position = @"OM1.24",
            Name = @"Typical Turn-around Time",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"typical processing time for single test/observation.  This field indicates the time from the delivery of a specimen or transport of a patient to a diagnostic service and the completion of the study.  It includes the usual waiting time.  The units are measured in minutes.",
            Sample = @"",
        };

        

        

        

        return typicalTurnaroundTime;
    } 
}
internal HL7V22Field processingTime;

public HL7V22Field ProcessingTime
{
    get
    {
        if (processingTime != null)
        {
            return processingTime;
        }

        processingTime = new HL7V22Field
        {
            field = message[@"OM1"][25],
            Id = @"OM1.25",
            Type = @"Field",
            Position = @"OM1.25",
            Name = @"Processing Time",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"usual length of time (in minutes) between the start of a test process and its completion",
            Sample = @"",
        };

        

        

        

        return processingTime;
    } 
}
internal HL7V22Field processingPriority;

public HL7V22Field ProcessingPriority
{
    get
    {
        if (processingPriority != null)
        {
            return processingPriority;
        }

        processingPriority = new HL7V22Field
        {
            field = message[@"OM1"][26],
            Id = @"OM1.26",
            Type = @"Field",
            Position = @"OM1.26",
            Name = @"Processing Priority",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0168",
            TableName = @"PROCESSING PRIORITY",
            Description = @"specifies one or more available priorities for performing the observation or test.  This is the priority that can be placed in OBR-28-quantity/timing.  For tests that require a specimen, this field may contain two components in the format <specimen priority>^<processing priority>.  The first component in this case indicates the priority with which the specimen will be collected and is the priority that is specified in an OBR segment when ordering the observation.  The second component indicates the corresponding priority with which the producer service will process the specimen, produce the observation, and return results, when this differs from collection priority",
            Sample = @"",
        };

        

        

        

        return processingPriority;
    } 
}
internal HL7V22Field reportingPriority;

public HL7V22Field ReportingPriority
{
    get
    {
        if (reportingPriority != null)
        {
            return reportingPriority;
        }

        reportingPriority = new HL7V22Field
        {
            field = message[@"OM1"][27],
            Id = @"OM1.27",
            Type = @"Field",
            Position = @"OM1.27",
            Name = @"Reporting Priority",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0169",
            TableName = @"REPORTIN PRIORITY",
            Description = @"the available priorities reporting the test results when the user is asked to specify the reporting priority independent of the processing priority",
            Sample = @"",
        };

        

        

        

        return reportingPriority;
    } 
}
internal HL7V22Field outsideSite(s)WhereObservationMayBePerformed;

public HL7V22Field OutsideSite(s)WhereObservationMayBePerformed
{
    get
    {
        if (outsideSite(s)WhereObservationMayBePerformed != null)
        {
            return outsideSite(s)WhereObservationMayBePerformed;
        }

        outsideSite(s)WhereObservationMayBePerformed = new HL7V22Field
        {
            field = message[@"OM1"][28],
            Id = @"OM1.28",
            Type = @"Field",
            Position = @"OM1.28",
            Name = @"Outside Site(s) Where Observation May Be Performed",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"if an outside service or services produce the observation, this field contains the identification(s) of the outside service(s).  The format of this CE field uses the producer ID (as defined in OM1-6-producer ID) and the name of the service separated by component delimiters.  An example is 39221^ACME lab^MC.  If multiple services are used, they should be separated by repeat delimiter(s). ",
            Sample = @"",
        };

        

        

        

        return outsideSite(s)WhereObservationMayBePerformed;
    } 
}
internal HL7V22Field addressOfOutsideSite(s);

public HL7V22Field AddressOfOutsideSite(s)
{
    get
    {
        if (addressOfOutsideSite(s) != null)
        {
            return addressOfOutsideSite(s);
        }

        addressOfOutsideSite(s) = new HL7V22Field
        {
            field = message[@"OM1"][29],
            Id = @"OM1.29",
            Type = @"Field",
            Position = @"OM1.29",
            Name = @"Address Of Outside Site(s)",
            Length = 1000,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @" record in this field the address of the outside services listed in OM1-28-outside site(s) where observation may be performed.  If multiple services are recorded in that field, their addresses should be separated by repeat delimiters, and the addresses should appear in the same order in which the services appear in the preceding field",
            Sample = @"",
        };

        

        

        

        return addressOfOutsideSite(s);
    } 
}
internal HL7V22Field phoneNumberOfOutsideSite;

public HL7V22Field PhoneNumberOfOutsideSite
{
    get
    {
        if (phoneNumberOfOutsideSite != null)
        {
            return phoneNumberOfOutsideSite;
        }

        phoneNumberOfOutsideSite = new HL7V22Field
        {
            field = message[@"OM1"][30],
            Id = @"OM1.30",
            Type = @"Field",
            Position = @"OM1.30",
            Name = @"Phone Number Of Outside Site",
            Length = 400,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"the telephone number of the outside site",
            Sample = @"",
        };

        

        

        

        return phoneNumberOfOutsideSite;
    } 
}
internal HL7V22Field confidentialityCode;

public HL7V22Field ConfidentialityCode
{
    get
    {
        if (confidentialityCode != null)
        {
            return confidentialityCode;
        }

        confidentialityCode = new HL7V22Field
        {
            field = message[@"OM1"][31],
            Id = @"OM1.31",
            Type = @"Field",
            Position = @"OM1.31",
            Name = @"Confidentiality Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0177",
            TableName = @"CONFIDENTIALITY CODE",
            Description = @"the degree to which special confidentiality protection should be applied to the observation.  For example, a tighter control may be applied to an HIV titer than to a CBC.  Refer to user-defined table 0177 - confidentiality code for suggested values",
            Sample = @"",
        };

        

        

        

        return confidentialityCode;
    } 
}
internal HL7V22Field observationsRequiredToInterpretTheObservation;

public HL7V22Field ObservationsRequiredToInterpretTheObservation
{
    get
    {
        if (observationsRequiredToInterpretTheObservation != null)
        {
            return observationsRequiredToInterpretTheObservation;
        }

        observationsRequiredToInterpretTheObservation = new HL7V22Field
        {
            field = message[@"OM1"][32],
            Id = @"OM1.32",
            Type = @"Field",
            Position = @"OM1.32",
            Name = @"Observations Required To Interpret The Observation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"list of variables that the diagnostic service needs to interpret the results of an ordered study.  The observations specified here should be sent to the diagnostic service as OBX segments along with the order (OBR) segment",
            Sample = @"",
        };

        

        

        

        return observationsRequiredToInterpretTheObservation;
    } 
}
internal HL7V22Field interpretationOfObservations;

public HL7V22Field InterpretationOfObservations
{
    get
    {
        if (interpretationOfObservations != null)
        {
            return interpretationOfObservations;
        }

        interpretationOfObservations = new HL7V22Field
        {
            field = message[@"OM1"][33],
            Id = @"OM1.33",
            Type = @"Field",
            Position = @"OM1.33",
            Name = @"Interpretation Of Observations",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"clinical information about interpreting test results.  Examples are the conditions (drugs) that may cause false abnormals, and the information about the sensitivity and specificity of the test for diagnoses",
            Sample = @"",
        };

        

        

        

        return interpretationOfObservations;
    } 
}
internal HL7V22Field contraindicationsToObservations;

public HL7V22Field ContraindicationsToObservations
{
    get
    {
        if (contraindicationsToObservations != null)
        {
            return contraindicationsToObservations;
        }

        contraindicationsToObservations = new HL7V22Field
        {
            field = message[@"OM1"][34],
            Id = @"OM1.34",
            Type = @"Field",
            Position = @"OM1.34",
            Name = @"Contraindications To Observations",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"list diagnosis or problem for which the test is a contraindication or of possible danger (e.g., pacemaker, pregnancy, diabetes).  For example, if the test identified in OM1 was an intravenous pyelogram, this field would include warnings about the use of contrast media in diabetes. The contraindication diagnoses should be separated by repeat delimiters",
            Sample = @"",
        };

        

        

        

        return contraindicationsToObservations;
    } 
}
internal HL7V22Field reflexTestsObservations;

public HL7V22Field ReflexTestsObservations
{
    get
    {
        if (reflexTestsObservations != null)
        {
            return reflexTestsObservations;
        }

        reflexTestsObservations = new HL7V22Field
        {
            field = message[@"OM1"][35],
            Id = @"OM1.35",
            Type = @"Field",
            Position = @"OM1.35",
            Name = @"Reflex Tests / Observations",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"includes the test names as type CE (i.e., <code>^<text name>^<coding system>) that may be ordered automatically by the diagnostic service, depending on the results obtained from the ordered battery.  A screening CBC might trigger a reticulocyte count if the Hgb is less than 12.  Multiple reflex tests are separated by repeat delimiters",
            Sample = @"",
        };

        

        

        

        return reflexTestsObservations;
    } 
}
internal HL7V22Field rulesThatTriggerReflexTesting;

public HL7V22Field RulesThatTriggerReflexTesting
{
    get
    {
        if (rulesThatTriggerReflexTesting != null)
        {
            return rulesThatTriggerReflexTesting;
        }

        rulesThatTriggerReflexTesting = new HL7V22Field
        {
            field = message[@"OM1"][36],
            Id = @"OM1.36",
            Type = @"Field",
            Position = @"OM1.36",
            Name = @"Rules That Trigger Reflex Testing",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"the rules that trigger the reflex tests listed above.  If multiple reflex tests are listed in OM1-35-reflex tests/observations separated by repeat delimiters, a set of corresponding rules will be included in this section.  The first rule will apply to the first test, the second to the second test, and so on",
            Sample = @"",
        };

        

        

        

        return rulesThatTriggerReflexTesting;
    } 
}
internal HL7V22Field fixedCannedMessage;

public HL7V22Field FixedCannedMessage
{
    get
    {
        if (fixedCannedMessage != null)
        {
            return fixedCannedMessage;
        }

        fixedCannedMessage = new HL7V22Field
        {
            field = message[@"OM1"][37],
            Id = @"OM1.37",
            Type = @"Field",
            Position = @"OM1.37",
            Name = @"Fixed Canned Message",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"codes and a fixed text message that is always associated with an abbreviation.  The field may include multiple messages separated by repeat delimiters",
            Sample = @"",
        };

        

        

        

        return fixedCannedMessage;
    } 
}
internal HL7V22Field patientPreparation;

public HL7V22Field PatientPreparation
{
    get
    {
        if (patientPreparation != null)
        {
            return patientPreparation;
        }

        patientPreparation = new HL7V22Field
        {
            field = message[@"OM1"][38],
            Id = @"OM1.38",
            Type = @"Field",
            Position = @"OM1.38",
            Name = @"Patient Preparation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"for tests or observations that require special patient preparation, diet, or medications, record them here.  For GI contrast studies, this field would contain the pretest diet, e.g., low residue for two days, NPO before study, and the preferred purgatives.  Each separate med, diet, or preparation should be delimited by a repeat delimiter.  Separate each requirement by a repeat delimiter.  Example for a sigmoidectomy: clear liquid diet full day before procedure~take 8 oz mag citrate 6pm day before procedure~take 2 ducat tabs (5m) at 4pm day before procedure~NPO past midnight",
            Sample = @"",
        };

        

        

        

        return patientPreparation;
    } 
}
internal HL7V22Field procedureMedication;

public HL7V22Field ProcedureMedication
{
    get
    {
        if (procedureMedication != null)
        {
            return procedureMedication;
        }

        procedureMedication = new HL7V22Field
        {
            field = message[@"OM1"][39],
            Id = @"OM1.39",
            Type = @"Field",
            Position = @"OM1.39",
            Name = @"Procedure Medication",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"treatments that may be needed as part of the procedure.  Examples are radioactive iodine for a thyroid screen, and methacholine for a methacholine spirometry challenge.  This field should be identified as a CE data type",
            Sample = @"",
        };

        

        

        

        return procedureMedication;
    } 
}
internal HL7V22Field factorsThatMayAffectTheObservation;

public HL7V22Field FactorsThatMayAffectTheObservation
{
    get
    {
        if (factorsThatMayAffectTheObservation != null)
        {
            return factorsThatMayAffectTheObservation;
        }

        factorsThatMayAffectTheObservation = new HL7V22Field
        {
            field = message[@"OM1"][40],
            Id = @"OM1.40",
            Type = @"Field",
            Position = @"OM1.40",
            Name = @"Factors That May Affect The Observation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"text description of the foods, diagnoses, drugs, or other conditions that may influence the interpretation of the observation. Information about the direction of the effect, and any recommendation about altering the diet, conditions, or drug before initiating the test observation",
            Sample = @"",
        };

        

        

        

        return factorsThatMayAffectTheObservation;
    } 
}
internal HL7V22Field testObservationPerformanceSchedule;

public HL7V22Field TestObservationPerformanceSchedule
{
    get
    {
        if (testObservationPerformanceSchedule != null)
        {
            return testObservationPerformanceSchedule;
        }

        testObservationPerformanceSchedule = new HL7V22Field
        {
            field = message[@"OM1"][41],
            Id = @"OM1.41",
            Type = @"Field",
            Position = @"OM1.41",
            Name = @"Test / Observation Performance Schedule",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"for diagnostic studies/tests that are performed only at certain times during the course of a work day or work week, this field indicates the maximum interval between successive test performances (the test may actually be performed more frequently).  The format given in ASTM Table 17, Codes for Service Intervals, should be used.  If necessary, multiple codes may be given, separated by repeat delimiters.  The use of multiple codes indicates that the test is performed at multiple concurrent intervals.  For example, Q6H indicates that the test is performed at least once every 6 hours around the clock.  Q1J indicates that the test is performed at least every week on Mondays.  QAM~QPM indicates that the test is performed at least once every morning and every evening.  Q1J~Q3J~Q5J indicates that the test is performed at least every week on Mondays, Wednesdays, and Fridays.  C indicates that the test is performed continuously, 7 days per week. ",
            Sample = @"",
        };

        

        

        

        return testObservationPerformanceSchedule;
    } 
}
internal HL7V22Field descriptionOfTestMethods;

public HL7V22Field DescriptionOfTestMethods
{
    get
    {
        if (descriptionOfTestMethods != null)
        {
            return descriptionOfTestMethods;
        }

        descriptionOfTestMethods = new HL7V22Field
        {
            field = message[@"OM1"][42],
            Id = @"OM1.42",
            Type = @"Field",
            Position = @"OM1.42",
            Name = @"Description Of Test Methods",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"text description of the methods used to perform the text and generate the observations.  Bibliographic citations may be included",
            Sample = @"",
        };

        

        

        

        return descriptionOfTestMethods;
    } 
}

    }
}
