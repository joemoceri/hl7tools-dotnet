using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentSAC
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"SAC"; } }

        public string SegmentId { get { return @"SAC"; } }
        
        public string LongName { get { return @"Specimen and container detail"; } }
        
        public string Description { get { return @"The container detail segment is the data necessary to maintain the containers that are being used throughout the Laboratory Automation System."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",
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
                            Id = @"SAC.1",
                            Type = @"Field",
                            Position = @"SAC.1",
                            Name = @"External Accession Identifier",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the laboratory accession (see section Glossary). This identifier is assigned by the external laboratory information system.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.1.1",
                            Type = @"Component",
                            Position = @"SAC.1.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.9.21, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.1.2",
                            Type = @"Component",
                            Position = @"SAC.1.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.1.3",
                            Type = @"Component",
                            Position = @"SAC.1.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"<universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component).  Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.1.4",
                            Type = @"Component",
                            Position = @"SAC.1.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"This component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.2",
                            Type = @"Field",
                            Position = @"SAC.2",
                            Name = @"Accession Identifier",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the laboratory accession (see section Glossary). This identifier is assigned by the information system of the laboratory performing the tests",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.2.1",
                            Type = @"Component",
                            Position = @"SAC.2.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.9.21, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.2.2",
                            Type = @"Component",
                            Position = @"SAC.2.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.2.3",
                            Type = @"Component",
                            Position = @"SAC.2.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"<universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component).  Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.2.4",
                            Type = @"Component",
                            Position = @"SAC.2.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"This component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.3",
                            Type = @"Field",
                            Position = @"SAC.3",
                            Name = @"Container Identifier",
                            Length = 80,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the container. This field is the container’s unique identifier assigned by the corresponding equipment. A container may contain the primary (original) specimen or an aliquot (secondary sample) of that specimen. For primary sample this field contains Primary Container ID; for barcoded aliquot samples this field contains Aliquot Container ID; for non-bar-coded aliquot samples (e.g., microtiter plate) this field is empty",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.3.1",
                            Type = @"Component",
                            Position = @"SAC.3.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.9.21, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.3.2",
                            Type = @"Component",
                            Position = @"SAC.3.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.3.3",
                            Type = @"Component",
                            Position = @"SAC.3.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"<universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component).  Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.3.4",
                            Type = @"Component",
                            Position = @"SAC.3.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"This component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.4",
                            Type = @"Field",
                            Position = @"SAC.4",
                            Name = @"Primary",
                            Length = 80,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"If this field is filled in, it identifies the primary container from which this specimen came. For primary samples this field is empty; for aliquot samples this field should contain the identifier of primary container.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.4.1",
                            Type = @"Component",
                            Position = @"SAC.4.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.9.21, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.4.2",
                            Type = @"Component",
                            Position = @"SAC.4.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.4.3",
                            Type = @"Component",
                            Position = @"SAC.4.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"<universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component).  Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.4.4",
                            Type = @"Component",
                            Position = @"SAC.4.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"This component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.5",
                            Type = @"Field",
                            Position = @"SAC.5",
                            Name = @"Equipment Container Identifier",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the container in a particular device (e.g., one container in a carousel or rack of containers within an analyzer, analyzer specific bar code mapping, etc.).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.5.1",
                            Type = @"Component",
                            Position = @"SAC.5.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.9.21, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.5.2",
                            Type = @"Component",
                            Position = @"SAC.5.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.5.3",
                            Type = @"Component",
                            Position = @"SAC.5.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"<universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component).  Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.5.4",
                            Type = @"Component",
                            Position = @"SAC.5.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"This component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6",
                            Type = @"Field",
                            Position = @"SAC.6",
                            Name = @"Specimen Source",
                            Length = 300,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SPS",
                            DataTypeName = @"Specimen Source",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the site where the specimen should be obtained or where the service should be performed",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.1",
                            Type = @"Component",
                            Position = @"SAC.6.1",
                            Name = @"Specimen Source Name Or Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0070",
                            TableName = @"Specimen source codes",
                            Description = @"The first component contains the specimen source name or code (as a CE data type component).  (Even in the case of observations whose name implies the source, a source may be required, e.g., blood culture-heart blood.)  Refer to HL7 Table 0070 - Specimen source codes for valid entries.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.1.1",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.1",
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
                            Id = @"SAC.6.1.2",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.2",
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
                            Id = @"SAC.6.1.3",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.3",
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
                            Id = @"SAC.6.1.4",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.4",
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
                            Id = @"SAC.6.1.5",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.5",
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
                            Id = @"SAC.6.1.6",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.2",
                            Type = @"Component",
                            Position = @"SAC.6.2",
                            Name = @"Additives",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component should include free text additives to the specimen such as Heparin, EDTA, or Oxlate, when applicable.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.3",
                            Type = @"Component",
                            Position = @"SAC.6.3",
                            Name = @"Freetext",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The third is a free text component describing the method of collection when that information is a part of the order.  When the method of collection is logically an observation result, it should be included as a result segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.4",
                            Type = @"Component",
                            Position = @"SAC.6.4",
                            Name = @"Body Site",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0163",
                            TableName = @"Body site",
                            Description = @"The fourth component specifies the body site from which the specimen was obtained, and the fifth is the site modifier.  For example, the site could be antecubital fossa, and the site modifier “right.”  The components of the CE fields become subcomponents.  Refer to HL7 Table 0163 - Body site for valid entries.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.4.1",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.1",
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
                            Id = @"SAC.6.4.2",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.2",
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
                            Id = @"SAC.6.4.3",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.3",
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
                            Id = @"SAC.6.4.4",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.4",
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
                            Id = @"SAC.6.4.5",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.5",
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
                            Id = @"SAC.6.4.6",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.5",
                            Type = @"Component",
                            Position = @"SAC.6.5",
                            Name = @"Site Modifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"The fifth component indicates whether the specimen is frozen as part of the collection method.  Suggested values are F (Frozen); R (Refrigerated).  If the component is blank, the specimen is assumed to be at room temperature.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.5.1",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.1",
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
                            Id = @"SAC.6.5.2",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.2",
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
                            Id = @"SAC.6.5.3",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.3",
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
                            Id = @"SAC.6.5.4",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.4",
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
                            Id = @"SAC.6.5.5",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.5",
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
                            Id = @"SAC.6.5.6",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.6",
                            Type = @"Component",
                            Position = @"SAC.6.6",
                            Name = @"Collection Modifier Method Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.6.1",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.1",
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
                            Id = @"SAC.6.6.2",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.2",
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
                            Id = @"SAC.6.6.3",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.3",
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
                            Id = @"SAC.6.6.4",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.4",
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
                            Id = @"SAC.6.6.5",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.5",
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
                            Id = @"SAC.6.6.6",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.7",
                            Type = @"Component",
                            Position = @"SAC.6.7",
                            Name = @"Specimen Role",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0369",
                            TableName = @"Specimen role",
                            Description = @"The 7th component indicates the role of the sample.  Refer to User-defined Table 0369 – Specimen Role for suggested values.  Each of these values is normally identifiable by the systems and its components and can influence processing and data management related to the specimen.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.7.1",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.1",
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
                            Id = @"SAC.6.7.2",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.2",
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
                            Id = @"SAC.6.7.3",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.3",
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
                            Id = @"SAC.6.7.4",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.4",
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
                            Id = @"SAC.6.7.5",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.5",
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
                            Id = @"SAC.6.7.6",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.6",
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
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.7",
                            Type = @"Field",
                            Position = @"SAC.7",
                            Name = @"Registration Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the date/time that the container was last registered with the “automated system.”, e.g., reading of a container bar code by a device",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.7.1",
                            Type = @"Component",
                            Position = @"SAC.7.1",
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
                            Id = @"SAC.7.2",
                            Type = @"Component",
                            Position = @"SAC.7.2",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.8",
                            Type = @"Field",
                            Position = @"SAC.8",
                            Name = @"Container Status",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0370",
                            TableName = @"Container status",
                            Description = @"This field identifies the status of the unique container in which the specimen resides at the time that the transaction was initiated.  Refer to HL7 Table 0370 - Container status for valid values. The equipment specific container status should be sent as <alternate identifier> as needed",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.8.1",
                            Type = @"Component",
                            Position = @"SAC.8.1",
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
                            Id = @"SAC.8.2",
                            Type = @"Component",
                            Position = @"SAC.8.2",
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
                            Id = @"SAC.8.3",
                            Type = @"Component",
                            Position = @"SAC.8.3",
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
                            Id = @"SAC.8.4",
                            Type = @"Component",
                            Position = @"SAC.8.4",
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
                            Id = @"SAC.8.5",
                            Type = @"Component",
                            Position = @"SAC.8.5",
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
                            Id = @"SAC.8.6",
                            Type = @"Component",
                            Position = @"SAC.8.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.9",
                            Type = @"Field",
                            Position = @"SAC.9",
                            Name = @"Carrier Type",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0378",
                            TableName = @"Carrier type",
                            Description = @"This field identifies the type of the carrier (see section Glossary). Refer to User-defined Table 0378 – Carrier type for suggested values.   Because the geometry can be different, the carrier type should, if possible, express the number of positions in the carrier",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.9.1",
                            Type = @"Component",
                            Position = @"SAC.9.1",
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
                            Id = @"SAC.9.2",
                            Type = @"Component",
                            Position = @"SAC.9.2",
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
                            Id = @"SAC.9.3",
                            Type = @"Component",
                            Position = @"SAC.9.3",
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
                            Id = @"SAC.9.4",
                            Type = @"Component",
                            Position = @"SAC.9.4",
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
                            Id = @"SAC.9.5",
                            Type = @"Component",
                            Position = @"SAC.9.5",
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
                            Id = @"SAC.9.6",
                            Type = @"Component",
                            Position = @"SAC.9.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.10",
                            Type = @"Field",
                            Position = @"SAC.10",
                            Name = @"Carrier Identifier",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the carrier. It is the ID (e.g., number or bar code) of the carrier where the container (e.g., tube) is located",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.10.1",
                            Type = @"Component",
                            Position = @"SAC.10.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.9.21, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.10.2",
                            Type = @"Component",
                            Position = @"SAC.10.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.10.3",
                            Type = @"Component",
                            Position = @"SAC.10.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"<universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component).  Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.10.4",
                            Type = @"Component",
                            Position = @"SAC.10.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"This component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.11",
                            Type = @"Field",
                            Position = @"SAC.11",
                            Name = @"Position in Carrier",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NA",
                            DataTypeName = @"Numeric Array",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the position of the container in the carrier (e.g., 1…3…). The subcomponents allow, if necessary, to transfer multiple axis information, e.g., 2-dimensional carrier (X^Y).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.11.1",
                            Type = @"Component",
                            Position = @"SAC.11.1",
                            Name = @"Value1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.11.2",
                            Type = @"Component",
                            Position = @"SAC.11.2",
                            Name = @"Value2",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.11.3",
                            Type = @"Component",
                            Position = @"SAC.11.3",
                            Name = @"Value3",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.11.4",
                            Type = @"Component",
                            Position = @"SAC.11.4",
                            Name = @"Value4",
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
                            Id = @"SAC.12",
                            Type = @"Field",
                            Position = @"SAC.12",
                            Name = @"Tray Type - SAC",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0379",
                            TableName = @"Tray type",
                            Description = @"This field identifies the type of the tray (see section Glossary). Refer to User-defined Table 0379 – Tray type for suggested values.  Because the geometry can be different, the tray type should if possible express the number of positions in the tray",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.12.1",
                            Type = @"Component",
                            Position = @"SAC.12.1",
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
                            Id = @"SAC.12.2",
                            Type = @"Component",
                            Position = @"SAC.12.2",
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
                            Id = @"SAC.12.3",
                            Type = @"Component",
                            Position = @"SAC.12.3",
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
                            Id = @"SAC.12.4",
                            Type = @"Component",
                            Position = @"SAC.12.4",
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
                            Id = @"SAC.12.5",
                            Type = @"Component",
                            Position = @"SAC.12.5",
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
                            Id = @"SAC.12.6",
                            Type = @"Component",
                            Position = @"SAC.12.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.13",
                            Type = @"Field",
                            Position = @"SAC.13",
                            Name = @"Tray Identifier",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the tray identifier (e.g., a number of a tray or a bar code on the tray), where the container carrier is located",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.13.1",
                            Type = @"Component",
                            Position = @"SAC.13.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.9.21, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.13.2",
                            Type = @"Component",
                            Position = @"SAC.13.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.13.3",
                            Type = @"Component",
                            Position = @"SAC.13.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"<universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component).  Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.13.4",
                            Type = @"Component",
                            Position = @"SAC.13.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"This component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.14",
                            Type = @"Field",
                            Position = @"SAC.14",
                            Name = @"Position in Tray",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NA",
                            DataTypeName = @"Numeric Array",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the position of the carrier in the tray. The sub-components allow, if necessary, to transfer multiple axis information, e.g., 2-dimensional tray (X^Y).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.14.1",
                            Type = @"Component",
                            Position = @"SAC.14.1",
                            Name = @"Value1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.14.2",
                            Type = @"Component",
                            Position = @"SAC.14.2",
                            Name = @"Value2",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.14.3",
                            Type = @"Component",
                            Position = @"SAC.14.3",
                            Name = @"Value3",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.14.4",
                            Type = @"Component",
                            Position = @"SAC.14.4",
                            Name = @"Value4",
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
                            Id = @"SAC.15",
                            Type = @"Field",
                            Position = @"SAC.15",
                            Name = @"Location",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the physical location that the specimen was at the time that the transaction was initiated. The location description can vary with the LAS. For example, it can be an X,Y,Z coordinate in  a storage system; a refrigerator number and drawer number where the container-carrier-tray is located; or it can be the name of the institution and the laboratory which owns the container currently. The repeating of this field allows for hierarchical representation of location (lowest level first), e.g., shelf number, refrigerator storage id, lab name, institution name, etc",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.15.1",
                            Type = @"Component",
                            Position = @"SAC.15.1",
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
                            Id = @"SAC.15.2",
                            Type = @"Component",
                            Position = @"SAC.15.2",
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
                            Id = @"SAC.15.3",
                            Type = @"Component",
                            Position = @"SAC.15.3",
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
                            Id = @"SAC.15.4",
                            Type = @"Component",
                            Position = @"SAC.15.4",
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
                            Id = @"SAC.15.5",
                            Type = @"Component",
                            Position = @"SAC.15.5",
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
                            Id = @"SAC.15.6",
                            Type = @"Component",
                            Position = @"SAC.15.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.16",
                            Type = @"Field",
                            Position = @"SAC.16",
                            Name = @"Container Height",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the height of the container in units specified below",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.17",
                            Type = @"Field",
                            Position = @"SAC.17",
                            Name = @"Container Diameter",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the outside diameter of the container in units specified below",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.18",
                            Type = @"Field",
                            Position = @"SAC.18",
                            Name = @"Barrier Delta",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the distance from the Point of Reference to the separator material (barrier) within the container in units specified below. This distance may be provided by the LAS to the instrument and/or specimen processing/handling device to facilitate the insertion of a sampling probe into the specimen without touching the separator. Refer to Point Of Reference definition in section Glossary or in NCCLS standard AUTO5 Laboratory Automation: Electromechanical Interfaces",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.19",
                            Type = @"Field",
                            Position = @"SAC.19",
                            Name = @"Bottom Delta",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the distance from the Point of Reference to the outside bottom of the container in units specified below. Refer to Point Of Reference definition in section Glossary or in NCCLS standard AUTO5 Laboratory Automation: Electromechanical Interfaces",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.20",
                            Type = @"Field",
                            Position = @"SAC.20",
                            Name = @"Container Height/Diameter/Delta Units",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the unit identifier that is being used to describe the diameter, height and deltas of the container. If the units are ISO+ units, they should be recorded as single case abbreviations. If the units are ANS+ or L (local), the units and the source code table must be recorded, except that in this case, component delimiters should be replaced by subcomponent delimiters. The default unit is millimeters (mm), which should be assumed if no units are reported.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.20.1",
                            Type = @"Component",
                            Position = @"SAC.20.1",
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
                            Id = @"SAC.20.2",
                            Type = @"Component",
                            Position = @"SAC.20.2",
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
                            Id = @"SAC.20.3",
                            Type = @"Component",
                            Position = @"SAC.20.3",
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
                            Id = @"SAC.20.4",
                            Type = @"Component",
                            Position = @"SAC.20.4",
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
                            Id = @"SAC.20.5",
                            Type = @"Component",
                            Position = @"SAC.20.5",
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
                            Id = @"SAC.20.6",
                            Type = @"Component",
                            Position = @"SAC.20.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.21",
                            Type = @"Field",
                            Position = @"SAC.21",
                            Name = @"Container Volume",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the capacity of the container in the units specified below",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.22",
                            Type = @"Field",
                            Position = @"SAC.22",
                            Name = @"Available Volume",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the current volume available for use in the container in the units specified below.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.23",
                            Type = @"Field",
                            Position = @"SAC.23",
                            Name = @"Initial Specimen Volume",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the draw volume of the container in the units specified below",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.24",
                            Type = @"Field",
                            Position = @"SAC.24",
                            Name = @"Volume  Units",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the unit identifier that is being used to describe the volume of the container. If the units are ISO+ units, they should be recorded as single case abbreviations. The default unit is milliliters (ml), which should be assumed if no units are reported.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.24.1",
                            Type = @"Component",
                            Position = @"SAC.24.1",
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
                            Id = @"SAC.24.2",
                            Type = @"Component",
                            Position = @"SAC.24.2",
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
                            Id = @"SAC.24.3",
                            Type = @"Component",
                            Position = @"SAC.24.3",
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
                            Id = @"SAC.24.4",
                            Type = @"Component",
                            Position = @"SAC.24.4",
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
                            Id = @"SAC.24.5",
                            Type = @"Component",
                            Position = @"SAC.24.5",
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
                            Id = @"SAC.24.6",
                            Type = @"Component",
                            Position = @"SAC.24.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.25",
                            Type = @"Field",
                            Position = @"SAC.25",
                            Name = @"Separator Type",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0380",
                            TableName = @"Separator type",
                            Description = @"This field identifies the type of the separator that is being used (e.g., gel separator in the container – not to be confused with the communication separators).  Refer to User-defined Table 0380 – Separator type for suggested values.  It is recommended that the first table entry be “NO” meaning “No Separator”.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.25.1",
                            Type = @"Component",
                            Position = @"SAC.25.1",
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
                            Id = @"SAC.25.2",
                            Type = @"Component",
                            Position = @"SAC.25.2",
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
                            Id = @"SAC.25.3",
                            Type = @"Component",
                            Position = @"SAC.25.3",
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
                            Id = @"SAC.25.4",
                            Type = @"Component",
                            Position = @"SAC.25.4",
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
                            Id = @"SAC.25.5",
                            Type = @"Component",
                            Position = @"SAC.25.5",
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
                            Id = @"SAC.25.6",
                            Type = @"Component",
                            Position = @"SAC.25.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.26",
                            Type = @"Field",
                            Position = @"SAC.26",
                            Name = @"Cap Type",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0381",
                            TableName = @"Cap type",
                            Description = @"This field indicates the type of cap that is to be used with this container for decapping, piercing or other mechanisms.  Refer to User-defined Table 0381 – Cap type for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.26.1",
                            Type = @"Component",
                            Position = @"SAC.26.1",
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
                            Id = @"SAC.26.2",
                            Type = @"Component",
                            Position = @"SAC.26.2",
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
                            Id = @"SAC.26.3",
                            Type = @"Component",
                            Position = @"SAC.26.3",
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
                            Id = @"SAC.26.4",
                            Type = @"Component",
                            Position = @"SAC.26.4",
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
                            Id = @"SAC.26.5",
                            Type = @"Component",
                            Position = @"SAC.26.5",
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
                            Id = @"SAC.26.6",
                            Type = @"Component",
                            Position = @"SAC.26.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.27",
                            Type = @"Field",
                            Position = @"SAC.27",
                            Name = @"Additive",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0371",
                            TableName = @"Additive",
                            Description = @"This field identifies any additives introduced to the specimen before or at the time of collection. It is a repetitive field. Refer to HL7 Table 0371 – Additive for valid values.  The table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.27.1",
                            Type = @"Component",
                            Position = @"SAC.27.1",
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
                            Id = @"SAC.27.2",
                            Type = @"Component",
                            Position = @"SAC.27.2",
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
                            Id = @"SAC.27.3",
                            Type = @"Component",
                            Position = @"SAC.27.3",
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
                            Id = @"SAC.27.4",
                            Type = @"Component",
                            Position = @"SAC.27.4",
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
                            Id = @"SAC.27.5",
                            Type = @"Component",
                            Position = @"SAC.27.5",
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
                            Id = @"SAC.27.6",
                            Type = @"Component",
                            Position = @"SAC.27.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.28",
                            Type = @"Field",
                            Position = @"SAC.28",
                            Name = @"Specimen Component",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the specimen component, e.g., supernatant, sediment, etc. Refer to Userdefined Table 0372 – Specimen component for valid values.  This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.28.1",
                            Type = @"Component",
                            Position = @"SAC.28.1",
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
                            Id = @"SAC.28.2",
                            Type = @"Component",
                            Position = @"SAC.28.2",
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
                            Id = @"SAC.28.3",
                            Type = @"Component",
                            Position = @"SAC.28.3",
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
                            Id = @"SAC.28.4",
                            Type = @"Component",
                            Position = @"SAC.28.4",
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
                            Id = @"SAC.28.5",
                            Type = @"Component",
                            Position = @"SAC.28.5",
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
                            Id = @"SAC.28.6",
                            Type = @"Component",
                            Position = @"SAC.28.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.29",
                            Type = @"Field",
                            Position = @"SAC.29",
                            Name = @"Dilution Factor",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SN",
                            DataTypeName = @"Structured Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the factor of dilution already performed on the specimen. The equipment entity that changes the dilution is responsible for sending this information to other equipment. If the endogenous content of the test (analyte) in the diluent is required for the calculation of the test (analyte) concentration, then the test (analyte) specific values should be exchanged between the systems via Master Files or other means",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.29.1",
                            Type = @"Component",
                            Position = @"SAC.29.1",
                            Name = @"Comparator",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= > or < or >= or <= or = or <>",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.29.2",
                            Type = @"Component",
                            Position = @"SAC.29.2",
                            Name = @"Num1",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.29.3",
                            Type = @"Component",
                            Position = @"SAC.29.3",
                            Name = @"Separator/Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"- or + or / or . or :",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.29.4",
                            Type = @"Component",
                            Position = @"SAC.29.4",
                            Name = @"Num2",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.30",
                            Type = @"Field",
                            Position = @"SAC.30",
                            Name = @"Treatment",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0373",
                            TableName = @"Treatment",
                            Description = @"This field identifies the specimen collection treatment. Refer to User-defined Table 0373 – Treatment for valid values.  This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.30.1",
                            Type = @"Component",
                            Position = @"SAC.30.1",
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
                            Id = @"SAC.30.2",
                            Type = @"Component",
                            Position = @"SAC.30.2",
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
                            Id = @"SAC.30.3",
                            Type = @"Component",
                            Position = @"SAC.30.3",
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
                            Id = @"SAC.30.4",
                            Type = @"Component",
                            Position = @"SAC.30.4",
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
                            Id = @"SAC.30.5",
                            Type = @"Component",
                            Position = @"SAC.30.5",
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
                            Id = @"SAC.30.6",
                            Type = @"Component",
                            Position = @"SAC.30.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.31",
                            Type = @"Field",
                            Position = @"SAC.31",
                            Name = @"Temperature",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SN",
                            DataTypeName = @"Structured Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the specimen temperature in degrees Celsius [°C] at the time of the transaction specified in the EQU segment",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.31.1",
                            Type = @"Component",
                            Position = @"SAC.31.1",
                            Name = @"Comparator",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= > or < or >= or <= or = or <>",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.31.2",
                            Type = @"Component",
                            Position = @"SAC.31.2",
                            Name = @"Num1",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.31.3",
                            Type = @"Component",
                            Position = @"SAC.31.3",
                            Name = @"Separator/Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"- or + or / or . or :",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.31.4",
                            Type = @"Component",
                            Position = @"SAC.31.4",
                            Name = @"Num2",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.32",
                            Type = @"Field",
                            Position = @"SAC.32",
                            Name = @"Hemolysis Index",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the index identifier that is being used to describe the Hemolysis Index of the specimen",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.33",
                            Type = @"Field",
                            Position = @"SAC.33",
                            Name = @"Hemolysis Index Units",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the unit’s identifier that is being used to describe the Hemolysis Index of the specimen. It is recommended to use g/L. (The transmission of the index values is added here instead of the original use of the OBX segments, because the frequency of the transfer of the specimen details justifies use of more efficient mechanism.)",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.33.1",
                            Type = @"Component",
                            Position = @"SAC.33.1",
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
                            Id = @"SAC.33.2",
                            Type = @"Component",
                            Position = @"SAC.33.2",
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
                            Id = @"SAC.33.3",
                            Type = @"Component",
                            Position = @"SAC.33.3",
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
                            Id = @"SAC.33.4",
                            Type = @"Component",
                            Position = @"SAC.33.4",
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
                            Id = @"SAC.33.5",
                            Type = @"Component",
                            Position = @"SAC.33.5",
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
                            Id = @"SAC.33.6",
                            Type = @"Component",
                            Position = @"SAC.33.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.34",
                            Type = @"Field",
                            Position = @"SAC.34",
                            Name = @"Lipemia Index",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the index identifier that is being used to describe the Lipemia Index of the specimen. It is recommended to use the optical turbidity at 600 nm (in absorbance units).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.35",
                            Type = @"Field",
                            Position = @"SAC.35",
                            Name = @"Lipemia Index Units",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the unit’s identifier that is being used to describe the Lipemia Index of the specimen.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.35.1",
                            Type = @"Component",
                            Position = @"SAC.35.1",
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
                            Id = @"SAC.35.2",
                            Type = @"Component",
                            Position = @"SAC.35.2",
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
                            Id = @"SAC.35.3",
                            Type = @"Component",
                            Position = @"SAC.35.3",
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
                            Id = @"SAC.35.4",
                            Type = @"Component",
                            Position = @"SAC.35.4",
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
                            Id = @"SAC.35.5",
                            Type = @"Component",
                            Position = @"SAC.35.5",
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
                            Id = @"SAC.35.6",
                            Type = @"Component",
                            Position = @"SAC.35.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.36",
                            Type = @"Field",
                            Position = @"SAC.36",
                            Name = @"Icterus Index",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the index identifier that is being used to describe the Icterus Index of the specimen",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.37",
                            Type = @"Field",
                            Position = @"SAC.37",
                            Name = @"Icterus Index Units",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the unit’s identifier that is being used to describe the Icterus Index of the specimen. It is recommended to use mMol/L of bilirubin",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.37.1",
                            Type = @"Component",
                            Position = @"SAC.37.1",
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
                            Id = @"SAC.37.2",
                            Type = @"Component",
                            Position = @"SAC.37.2",
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
                            Id = @"SAC.37.3",
                            Type = @"Component",
                            Position = @"SAC.37.3",
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
                            Id = @"SAC.37.4",
                            Type = @"Component",
                            Position = @"SAC.37.4",
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
                            Id = @"SAC.37.5",
                            Type = @"Component",
                            Position = @"SAC.37.5",
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
                            Id = @"SAC.37.6",
                            Type = @"Component",
                            Position = @"SAC.37.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.38",
                            Type = @"Field",
                            Position = @"SAC.38",
                            Name = @"Fibrin Index",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the index identifier that is being used to describe the Fibrin Index of the specimen. In the case of only differentiating between Absent and Present, we recommend using 0 and 1 respectively and send the field Fibrin Index Units null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.39",
                            Type = @"Field",
                            Position = @"SAC.39",
                            Name = @"Fibrin Index Units",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the unit’s identifier that is being used to describe the Fibrin Index of the specimen",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.39.1",
                            Type = @"Component",
                            Position = @"SAC.39.1",
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
                            Id = @"SAC.39.2",
                            Type = @"Component",
                            Position = @"SAC.39.2",
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
                            Id = @"SAC.39.3",
                            Type = @"Component",
                            Position = @"SAC.39.3",
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
                            Id = @"SAC.39.4",
                            Type = @"Component",
                            Position = @"SAC.39.4",
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
                            Id = @"SAC.39.5",
                            Type = @"Component",
                            Position = @"SAC.39.5",
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
                            Id = @"SAC.39.6",
                            Type = @"Component",
                            Position = @"SAC.39.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.40",
                            Type = @"Field",
                            Position = @"SAC.40",
                            Name = @"System Induced Contaminants",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0374",
                            TableName = @"System induced contaminants",
                            Description = @"This field describes the specimen contaminant identifier that is associated with the specimen. Refer to User-defined Table 0374 – System induced contaminants for valid values.  This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.40.1",
                            Type = @"Component",
                            Position = @"SAC.40.1",
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
                            Id = @"SAC.40.2",
                            Type = @"Component",
                            Position = @"SAC.40.2",
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
                            Id = @"SAC.40.3",
                            Type = @"Component",
                            Position = @"SAC.40.3",
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
                            Id = @"SAC.40.4",
                            Type = @"Component",
                            Position = @"SAC.40.4",
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
                            Id = @"SAC.40.5",
                            Type = @"Component",
                            Position = @"SAC.40.5",
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
                            Id = @"SAC.40.6",
                            Type = @"Component",
                            Position = @"SAC.40.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.41",
                            Type = @"Field",
                            Position = @"SAC.41",
                            Name = @"Drug Interference",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0382",
                            TableName = @"Drug interference",
                            Description = @"This field describes the drug interference identifier that is associated with the specimen. Refer to User-defined Table 0382 – Drug interference for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.41.1",
                            Type = @"Component",
                            Position = @"SAC.41.1",
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
                            Id = @"SAC.41.2",
                            Type = @"Component",
                            Position = @"SAC.41.2",
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
                            Id = @"SAC.41.3",
                            Type = @"Component",
                            Position = @"SAC.41.3",
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
                            Id = @"SAC.41.4",
                            Type = @"Component",
                            Position = @"SAC.41.4",
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
                            Id = @"SAC.41.5",
                            Type = @"Component",
                            Position = @"SAC.41.5",
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
                            Id = @"SAC.41.6",
                            Type = @"Component",
                            Position = @"SAC.41.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.42",
                            Type = @"Field",
                            Position = @"SAC.42",
                            Name = @"Artificial Blood",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0375",
                            TableName = @"Artificial blood",
                            Description = @"This field describes the artificial blood identifier that is associated with the specimen. Refer to User-defined Table 0375 – Artificial blood for valid values.  This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.42.1",
                            Type = @"Component",
                            Position = @"SAC.42.1",
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
                            Id = @"SAC.42.2",
                            Type = @"Component",
                            Position = @"SAC.42.2",
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
                            Id = @"SAC.42.3",
                            Type = @"Component",
                            Position = @"SAC.42.3",
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
                            Id = @"SAC.42.4",
                            Type = @"Component",
                            Position = @"SAC.42.4",
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
                            Id = @"SAC.42.5",
                            Type = @"Component",
                            Position = @"SAC.42.5",
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
                            Id = @"SAC.42.6",
                            Type = @"Component",
                            Position = @"SAC.42.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.43",
                            Type = @"Field",
                            Position = @"SAC.43",
                            Name = @"Special Handling Considerations",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0376",
                            TableName = @"Special handling considerations",
                            Description = @"This field describes any special handling considerations that are associated with the specimen. (E.g. centrifugation). Refer to User-defined Table 0376 – Special handling considerations for valid values.  This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.43.1",
                            Type = @"Component",
                            Position = @"SAC.43.1",
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
                            Id = @"SAC.43.2",
                            Type = @"Component",
                            Position = @"SAC.43.2",
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
                            Id = @"SAC.43.3",
                            Type = @"Component",
                            Position = @"SAC.43.3",
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
                            Id = @"SAC.43.4",
                            Type = @"Component",
                            Position = @"SAC.43.4",
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
                            Id = @"SAC.43.5",
                            Type = @"Component",
                            Position = @"SAC.43.5",
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
                            Id = @"SAC.43.6",
                            Type = @"Component",
                            Position = @"SAC.43.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.44",
                            Type = @"Field",
                            Position = @"SAC.44",
                            Name = @"Other Environmental Factors",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0377",
                            TableName = @"Other environmental factors",
                            Description = @"This field describes other environmental factors that are associated with the specimen, e.g., atmospheric exposure. Refer to User-defined Table 0377 – Other environmental factors for valid values. This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SAC.44.1",
                            Type = @"Component",
                            Position = @"SAC.44.1",
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
                            Id = @"SAC.44.2",
                            Type = @"Component",
                            Position = @"SAC.44.2",
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
                            Id = @"SAC.44.3",
                            Type = @"Component",
                            Position = @"SAC.44.3",
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
                            Id = @"SAC.44.4",
                            Type = @"Component",
                            Position = @"SAC.44.4",
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
                            Id = @"SAC.44.5",
                            Type = @"Component",
                            Position = @"SAC.44.5",
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
                            Id = @"SAC.44.6",
                            Type = @"Component",
                            Position = @"SAC.44.6",
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
                        },
                        
                        },
                        };
            }
        }

        public HL7V24SegmentSAC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field externalAccessionIdentifier;

public HL7V24Field ExternalAccessionIdentifier
{
    get
    {
        if (externalAccessionIdentifier != null)
        {
            return externalAccessionIdentifier;
        }

        externalAccessionIdentifier = new HL7V24Field
        {
            field = message[@"SAC"][1],
            Id = @"SAC.1",
            Type = @"Field",
            Position = @"SAC.1",
            Name = @"External Accession Identifier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the laboratory accession (see section Glossary). This identifier is assigned by the external laboratory information system.",
            Sample = @"",
        };

        

        

        

        return externalAccessionIdentifier;
    } 
}
internal HL7V24Field accessionIdentifier;

public HL7V24Field AccessionIdentifier
{
    get
    {
        if (accessionIdentifier != null)
        {
            return accessionIdentifier;
        }

        accessionIdentifier = new HL7V24Field
        {
            field = message[@"SAC"][2],
            Id = @"SAC.2",
            Type = @"Field",
            Position = @"SAC.2",
            Name = @"Accession Identifier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the laboratory accession (see section Glossary). This identifier is assigned by the information system of the laboratory performing the tests",
            Sample = @"",
        };

        

        

        

        return accessionIdentifier;
    } 
}
internal HL7V24Field containerIdentifier;

public HL7V24Field ContainerIdentifier
{
    get
    {
        if (containerIdentifier != null)
        {
            return containerIdentifier;
        }

        containerIdentifier = new HL7V24Field
        {
            field = message[@"SAC"][3],
            Id = @"SAC.3",
            Type = @"Field",
            Position = @"SAC.3",
            Name = @"Container Identifier",
            Length = 80,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the container. This field is the container’s unique identifier assigned by the corresponding equipment. A container may contain the primary (original) specimen or an aliquot (secondary sample) of that specimen. For primary sample this field contains Primary Container ID; for barcoded aliquot samples this field contains Aliquot Container ID; for non-bar-coded aliquot samples (e.g., microtiter plate) this field is empty",
            Sample = @"",
        };

        

        

        

        return containerIdentifier;
    } 
}
internal HL7V24Field primary;

public HL7V24Field Primary
{
    get
    {
        if (primary != null)
        {
            return primary;
        }

        primary = new HL7V24Field
        {
            field = message[@"SAC"][4],
            Id = @"SAC.4",
            Type = @"Field",
            Position = @"SAC.4",
            Name = @"Primary",
            Length = 80,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"If this field is filled in, it identifies the primary container from which this specimen came. For primary samples this field is empty; for aliquot samples this field should contain the identifier of primary container.",
            Sample = @"",
        };

        

        

        

        return primary;
    } 
}
internal HL7V24Field equipmentContainerIdentifier;

public HL7V24Field EquipmentContainerIdentifier
{
    get
    {
        if (equipmentContainerIdentifier != null)
        {
            return equipmentContainerIdentifier;
        }

        equipmentContainerIdentifier = new HL7V24Field
        {
            field = message[@"SAC"][5],
            Id = @"SAC.5",
            Type = @"Field",
            Position = @"SAC.5",
            Name = @"Equipment Container Identifier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the container in a particular device (e.g., one container in a carousel or rack of containers within an analyzer, analyzer specific bar code mapping, etc.).",
            Sample = @"",
        };

        

        

        

        return equipmentContainerIdentifier;
    } 
}
internal HL7V24Field specimenSource;

public HL7V24Field SpecimenSource
{
    get
    {
        if (specimenSource != null)
        {
            return specimenSource;
        }

        specimenSource = new HL7V24Field
        {
            field = message[@"SAC"][6],
            Id = @"SAC.6",
            Type = @"Field",
            Position = @"SAC.6",
            Name = @"Specimen Source",
            Length = 300,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SPS",
            DataTypeName = @"Specimen Source",
            TableId = null,
            TableName = null,
            Description = @"This field is the site where the specimen should be obtained or where the service should be performed",
            Sample = @"",
        };

        

        

        

        return specimenSource;
    } 
}
internal HL7V24Field registrationDateTime;

public HL7V24Field RegistrationDateTime
{
    get
    {
        if (registrationDateTime != null)
        {
            return registrationDateTime;
        }

        registrationDateTime = new HL7V24Field
        {
            field = message[@"SAC"][7],
            Id = @"SAC.7",
            Type = @"Field",
            Position = @"SAC.7",
            Name = @"Registration Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time that the container was last registered with the “automated system.”, e.g., reading of a container bar code by a device",
            Sample = @"",
        };

        

        

        

        return registrationDateTime;
    } 
}
internal HL7V24Field containerStatus;

public HL7V24Field ContainerStatus
{
    get
    {
        if (containerStatus != null)
        {
            return containerStatus;
        }

        containerStatus = new HL7V24Field
        {
            field = message[@"SAC"][8],
            Id = @"SAC.8",
            Type = @"Field",
            Position = @"SAC.8",
            Name = @"Container Status",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0370",
            TableName = @"Container status",
            Description = @"This field identifies the status of the unique container in which the specimen resides at the time that the transaction was initiated.  Refer to HL7 Table 0370 - Container status for valid values. The equipment specific container status should be sent as <alternate identifier> as needed",
            Sample = @"",
        };

        

        

        

        return containerStatus;
    } 
}
internal HL7V24Field carrierType;

public HL7V24Field CarrierType
{
    get
    {
        if (carrierType != null)
        {
            return carrierType;
        }

        carrierType = new HL7V24Field
        {
            field = message[@"SAC"][9],
            Id = @"SAC.9",
            Type = @"Field",
            Position = @"SAC.9",
            Name = @"Carrier Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0378",
            TableName = @"Carrier type",
            Description = @"This field identifies the type of the carrier (see section Glossary). Refer to User-defined Table 0378 – Carrier type for suggested values.   Because the geometry can be different, the carrier type should, if possible, express the number of positions in the carrier",
            Sample = @"",
        };

        

        

        

        return carrierType;
    } 
}
internal HL7V24Field carrierIdentifier;

public HL7V24Field CarrierIdentifier
{
    get
    {
        if (carrierIdentifier != null)
        {
            return carrierIdentifier;
        }

        carrierIdentifier = new HL7V24Field
        {
            field = message[@"SAC"][10],
            Id = @"SAC.10",
            Type = @"Field",
            Position = @"SAC.10",
            Name = @"Carrier Identifier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the carrier. It is the ID (e.g., number or bar code) of the carrier where the container (e.g., tube) is located",
            Sample = @"",
        };

        

        

        

        return carrierIdentifier;
    } 
}
internal HL7V24Field positioninCarrier;

public HL7V24Field PositioninCarrier
{
    get
    {
        if (positioninCarrier != null)
        {
            return positioninCarrier;
        }

        positioninCarrier = new HL7V24Field
        {
            field = message[@"SAC"][11],
            Id = @"SAC.11",
            Type = @"Field",
            Position = @"SAC.11",
            Name = @"Position in Carrier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NA",
            DataTypeName = @"Numeric Array",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the position of the container in the carrier (e.g., 1…3…). The subcomponents allow, if necessary, to transfer multiple axis information, e.g., 2-dimensional carrier (X^Y).",
            Sample = @"",
        };

        

        

        

        return positioninCarrier;
    } 
}
internal HL7V24Field trayTypeSAC;

public HL7V24Field TrayTypeSAC
{
    get
    {
        if (trayTypeSAC != null)
        {
            return trayTypeSAC;
        }

        trayTypeSAC = new HL7V24Field
        {
            field = message[@"SAC"][12],
            Id = @"SAC.12",
            Type = @"Field",
            Position = @"SAC.12",
            Name = @"Tray Type - SAC",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0379",
            TableName = @"Tray type",
            Description = @"This field identifies the type of the tray (see section Glossary). Refer to User-defined Table 0379 – Tray type for suggested values.  Because the geometry can be different, the tray type should if possible express the number of positions in the tray",
            Sample = @"",
        };

        

        

        

        return trayTypeSAC;
    } 
}
internal HL7V24Field trayIdentifier;

public HL7V24Field TrayIdentifier
{
    get
    {
        if (trayIdentifier != null)
        {
            return trayIdentifier;
        }

        trayIdentifier = new HL7V24Field
        {
            field = message[@"SAC"][13],
            Id = @"SAC.13",
            Type = @"Field",
            Position = @"SAC.13",
            Name = @"Tray Identifier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the tray identifier (e.g., a number of a tray or a bar code on the tray), where the container carrier is located",
            Sample = @"",
        };

        

        

        

        return trayIdentifier;
    } 
}
internal HL7V24Field positioninTray;

public HL7V24Field PositioninTray
{
    get
    {
        if (positioninTray != null)
        {
            return positioninTray;
        }

        positioninTray = new HL7V24Field
        {
            field = message[@"SAC"][14],
            Id = @"SAC.14",
            Type = @"Field",
            Position = @"SAC.14",
            Name = @"Position in Tray",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NA",
            DataTypeName = @"Numeric Array",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the position of the carrier in the tray. The sub-components allow, if necessary, to transfer multiple axis information, e.g., 2-dimensional tray (X^Y).",
            Sample = @"",
        };

        

        

        

        return positioninTray;
    } 
}
internal HL7V24Field location;

public HL7V24Field Location
{
    get
    {
        if (location != null)
        {
            return location;
        }

        location = new HL7V24Field
        {
            field = message[@"SAC"][15],
            Id = @"SAC.15",
            Type = @"Field",
            Position = @"SAC.15",
            Name = @"Location",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the physical location that the specimen was at the time that the transaction was initiated. The location description can vary with the LAS. For example, it can be an X,Y,Z coordinate in  a storage system; a refrigerator number and drawer number where the container-carrier-tray is located; or it can be the name of the institution and the laboratory which owns the container currently. The repeating of this field allows for hierarchical representation of location (lowest level first), e.g., shelf number, refrigerator storage id, lab name, institution name, etc",
            Sample = @"",
        };

        

        

        

        return location;
    } 
}
internal HL7V24Field containerHeight;

public HL7V24Field ContainerHeight
{
    get
    {
        if (containerHeight != null)
        {
            return containerHeight;
        }

        containerHeight = new HL7V24Field
        {
            field = message[@"SAC"][16],
            Id = @"SAC.16",
            Type = @"Field",
            Position = @"SAC.16",
            Name = @"Container Height",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the height of the container in units specified below",
            Sample = @"",
        };

        

        

        

        return containerHeight;
    } 
}
internal HL7V24Field containerDiameter;

public HL7V24Field ContainerDiameter
{
    get
    {
        if (containerDiameter != null)
        {
            return containerDiameter;
        }

        containerDiameter = new HL7V24Field
        {
            field = message[@"SAC"][17],
            Id = @"SAC.17",
            Type = @"Field",
            Position = @"SAC.17",
            Name = @"Container Diameter",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the outside diameter of the container in units specified below",
            Sample = @"",
        };

        

        

        

        return containerDiameter;
    } 
}
internal HL7V24Field barrierDelta;

public HL7V24Field BarrierDelta
{
    get
    {
        if (barrierDelta != null)
        {
            return barrierDelta;
        }

        barrierDelta = new HL7V24Field
        {
            field = message[@"SAC"][18],
            Id = @"SAC.18",
            Type = @"Field",
            Position = @"SAC.18",
            Name = @"Barrier Delta",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the distance from the Point of Reference to the separator material (barrier) within the container in units specified below. This distance may be provided by the LAS to the instrument and/or specimen processing/handling device to facilitate the insertion of a sampling probe into the specimen without touching the separator. Refer to Point Of Reference definition in section Glossary or in NCCLS standard AUTO5 Laboratory Automation: Electromechanical Interfaces",
            Sample = @"",
        };

        

        

        

        return barrierDelta;
    } 
}
internal HL7V24Field bottomDelta;

public HL7V24Field BottomDelta
{
    get
    {
        if (bottomDelta != null)
        {
            return bottomDelta;
        }

        bottomDelta = new HL7V24Field
        {
            field = message[@"SAC"][19],
            Id = @"SAC.19",
            Type = @"Field",
            Position = @"SAC.19",
            Name = @"Bottom Delta",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the distance from the Point of Reference to the outside bottom of the container in units specified below. Refer to Point Of Reference definition in section Glossary or in NCCLS standard AUTO5 Laboratory Automation: Electromechanical Interfaces",
            Sample = @"",
        };

        

        

        

        return bottomDelta;
    } 
}
internal HL7V24Field containerHeightDiameterDeltaUnits;

public HL7V24Field ContainerHeightDiameterDeltaUnits
{
    get
    {
        if (containerHeightDiameterDeltaUnits != null)
        {
            return containerHeightDiameterDeltaUnits;
        }

        containerHeightDiameterDeltaUnits = new HL7V24Field
        {
            field = message[@"SAC"][20],
            Id = @"SAC.20",
            Type = @"Field",
            Position = @"SAC.20",
            Name = @"Container Height/Diameter/Delta Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit identifier that is being used to describe the diameter, height and deltas of the container. If the units are ISO+ units, they should be recorded as single case abbreviations. If the units are ANS+ or L (local), the units and the source code table must be recorded, except that in this case, component delimiters should be replaced by subcomponent delimiters. The default unit is millimeters (mm), which should be assumed if no units are reported.",
            Sample = @"",
        };

        

        

        

        return containerHeightDiameterDeltaUnits;
    } 
}
internal HL7V24Field containerVolume;

public HL7V24Field ContainerVolume
{
    get
    {
        if (containerVolume != null)
        {
            return containerVolume;
        }

        containerVolume = new HL7V24Field
        {
            field = message[@"SAC"][21],
            Id = @"SAC.21",
            Type = @"Field",
            Position = @"SAC.21",
            Name = @"Container Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the capacity of the container in the units specified below",
            Sample = @"",
        };

        

        

        

        return containerVolume;
    } 
}
internal HL7V24Field availableVolume;

public HL7V24Field AvailableVolume
{
    get
    {
        if (availableVolume != null)
        {
            return availableVolume;
        }

        availableVolume = new HL7V24Field
        {
            field = message[@"SAC"][22],
            Id = @"SAC.22",
            Type = @"Field",
            Position = @"SAC.22",
            Name = @"Available Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the current volume available for use in the container in the units specified below.",
            Sample = @"",
        };

        

        

        

        return availableVolume;
    } 
}
internal HL7V24Field initialSpecimenVolume;

public HL7V24Field InitialSpecimenVolume
{
    get
    {
        if (initialSpecimenVolume != null)
        {
            return initialSpecimenVolume;
        }

        initialSpecimenVolume = new HL7V24Field
        {
            field = message[@"SAC"][23],
            Id = @"SAC.23",
            Type = @"Field",
            Position = @"SAC.23",
            Name = @"Initial Specimen Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the draw volume of the container in the units specified below",
            Sample = @"",
        };

        

        

        

        return initialSpecimenVolume;
    } 
}
internal HL7V24Field volumeUnits;

public HL7V24Field VolumeUnits
{
    get
    {
        if (volumeUnits != null)
        {
            return volumeUnits;
        }

        volumeUnits = new HL7V24Field
        {
            field = message[@"SAC"][24],
            Id = @"SAC.24",
            Type = @"Field",
            Position = @"SAC.24",
            Name = @"Volume  Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit identifier that is being used to describe the volume of the container. If the units are ISO+ units, they should be recorded as single case abbreviations. The default unit is milliliters (ml), which should be assumed if no units are reported.",
            Sample = @"",
        };

        

        

        

        return volumeUnits;
    } 
}
internal HL7V24Field separatorType;

public HL7V24Field SeparatorType
{
    get
    {
        if (separatorType != null)
        {
            return separatorType;
        }

        separatorType = new HL7V24Field
        {
            field = message[@"SAC"][25],
            Id = @"SAC.25",
            Type = @"Field",
            Position = @"SAC.25",
            Name = @"Separator Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0380",
            TableName = @"Separator type",
            Description = @"This field identifies the type of the separator that is being used (e.g., gel separator in the container – not to be confused with the communication separators).  Refer to User-defined Table 0380 – Separator type for suggested values.  It is recommended that the first table entry be “NO” meaning “No Separator”.",
            Sample = @"",
        };

        

        

        

        return separatorType;
    } 
}
internal HL7V24Field capType;

public HL7V24Field CapType
{
    get
    {
        if (capType != null)
        {
            return capType;
        }

        capType = new HL7V24Field
        {
            field = message[@"SAC"][26],
            Id = @"SAC.26",
            Type = @"Field",
            Position = @"SAC.26",
            Name = @"Cap Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0381",
            TableName = @"Cap type",
            Description = @"This field indicates the type of cap that is to be used with this container for decapping, piercing or other mechanisms.  Refer to User-defined Table 0381 – Cap type for suggested values.",
            Sample = @"",
        };

        

        

        

        return capType;
    } 
}
internal HL7V24Field additive;

public HL7V24Field Additive
{
    get
    {
        if (additive != null)
        {
            return additive;
        }

        additive = new HL7V24Field
        {
            field = message[@"SAC"][27],
            Id = @"SAC.27",
            Type = @"Field",
            Position = @"SAC.27",
            Name = @"Additive",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0371",
            TableName = @"Additive",
            Description = @"This field identifies any additives introduced to the specimen before or at the time of collection. It is a repetitive field. Refer to HL7 Table 0371 – Additive for valid values.  The table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
            Sample = @"",
        };

        

        

        

        return additive;
    } 
}
internal HL7V24Field specimenComponent;

public HL7V24Field SpecimenComponent
{
    get
    {
        if (specimenComponent != null)
        {
            return specimenComponent;
        }

        specimenComponent = new HL7V24Field
        {
            field = message[@"SAC"][28],
            Id = @"SAC.28",
            Type = @"Field",
            Position = @"SAC.28",
            Name = @"Specimen Component",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the specimen component, e.g., supernatant, sediment, etc. Refer to Userdefined Table 0372 – Specimen component for valid values.  This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
            Sample = @"",
        };

        

        

        

        return specimenComponent;
    } 
}
internal HL7V24Field dilutionFactor;

public HL7V24Field DilutionFactor
{
    get
    {
        if (dilutionFactor != null)
        {
            return dilutionFactor;
        }

        dilutionFactor = new HL7V24Field
        {
            field = message[@"SAC"][29],
            Id = @"SAC.29",
            Type = @"Field",
            Position = @"SAC.29",
            Name = @"Dilution Factor",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the factor of dilution already performed on the specimen. The equipment entity that changes the dilution is responsible for sending this information to other equipment. If the endogenous content of the test (analyte) in the diluent is required for the calculation of the test (analyte) concentration, then the test (analyte) specific values should be exchanged between the systems via Master Files or other means",
            Sample = @"",
        };

        

        

        

        return dilutionFactor;
    } 
}
internal HL7V24Field treatment;

public HL7V24Field Treatment
{
    get
    {
        if (treatment != null)
        {
            return treatment;
        }

        treatment = new HL7V24Field
        {
            field = message[@"SAC"][30],
            Id = @"SAC.30",
            Type = @"Field",
            Position = @"SAC.30",
            Name = @"Treatment",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0373",
            TableName = @"Treatment",
            Description = @"This field identifies the specimen collection treatment. Refer to User-defined Table 0373 – Treatment for valid values.  This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
            Sample = @"",
        };

        

        

        

        return treatment;
    } 
}
internal HL7V24Field temperature;

public HL7V24Field Temperature
{
    get
    {
        if (temperature != null)
        {
            return temperature;
        }

        temperature = new HL7V24Field
        {
            field = message[@"SAC"][31],
            Id = @"SAC.31",
            Type = @"Field",
            Position = @"SAC.31",
            Name = @"Temperature",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the specimen temperature in degrees Celsius [°C] at the time of the transaction specified in the EQU segment",
            Sample = @"",
        };

        

        

        

        return temperature;
    } 
}
internal HL7V24Field hemolysisIndex;

public HL7V24Field HemolysisIndex
{
    get
    {
        if (hemolysisIndex != null)
        {
            return hemolysisIndex;
        }

        hemolysisIndex = new HL7V24Field
        {
            field = message[@"SAC"][32],
            Id = @"SAC.32",
            Type = @"Field",
            Position = @"SAC.32",
            Name = @"Hemolysis Index",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the index identifier that is being used to describe the Hemolysis Index of the specimen",
            Sample = @"",
        };

        

        

        

        return hemolysisIndex;
    } 
}
internal HL7V24Field hemolysisIndexUnits;

public HL7V24Field HemolysisIndexUnits
{
    get
    {
        if (hemolysisIndexUnits != null)
        {
            return hemolysisIndexUnits;
        }

        hemolysisIndexUnits = new HL7V24Field
        {
            field = message[@"SAC"][33],
            Id = @"SAC.33",
            Type = @"Field",
            Position = @"SAC.33",
            Name = @"Hemolysis Index Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit’s identifier that is being used to describe the Hemolysis Index of the specimen. It is recommended to use g/L. (The transmission of the index values is added here instead of the original use of the OBX segments, because the frequency of the transfer of the specimen details justifies use of more efficient mechanism.)",
            Sample = @"",
        };

        

        

        

        return hemolysisIndexUnits;
    } 
}
internal HL7V24Field lipemiaIndex;

public HL7V24Field LipemiaIndex
{
    get
    {
        if (lipemiaIndex != null)
        {
            return lipemiaIndex;
        }

        lipemiaIndex = new HL7V24Field
        {
            field = message[@"SAC"][34],
            Id = @"SAC.34",
            Type = @"Field",
            Position = @"SAC.34",
            Name = @"Lipemia Index",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the index identifier that is being used to describe the Lipemia Index of the specimen. It is recommended to use the optical turbidity at 600 nm (in absorbance units).",
            Sample = @"",
        };

        

        

        

        return lipemiaIndex;
    } 
}
internal HL7V24Field lipemiaIndexUnits;

public HL7V24Field LipemiaIndexUnits
{
    get
    {
        if (lipemiaIndexUnits != null)
        {
            return lipemiaIndexUnits;
        }

        lipemiaIndexUnits = new HL7V24Field
        {
            field = message[@"SAC"][35],
            Id = @"SAC.35",
            Type = @"Field",
            Position = @"SAC.35",
            Name = @"Lipemia Index Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit’s identifier that is being used to describe the Lipemia Index of the specimen.",
            Sample = @"",
        };

        

        

        

        return lipemiaIndexUnits;
    } 
}
internal HL7V24Field icterusIndex;

public HL7V24Field IcterusIndex
{
    get
    {
        if (icterusIndex != null)
        {
            return icterusIndex;
        }

        icterusIndex = new HL7V24Field
        {
            field = message[@"SAC"][36],
            Id = @"SAC.36",
            Type = @"Field",
            Position = @"SAC.36",
            Name = @"Icterus Index",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the index identifier that is being used to describe the Icterus Index of the specimen",
            Sample = @"",
        };

        

        

        

        return icterusIndex;
    } 
}
internal HL7V24Field icterusIndexUnits;

public HL7V24Field IcterusIndexUnits
{
    get
    {
        if (icterusIndexUnits != null)
        {
            return icterusIndexUnits;
        }

        icterusIndexUnits = new HL7V24Field
        {
            field = message[@"SAC"][37],
            Id = @"SAC.37",
            Type = @"Field",
            Position = @"SAC.37",
            Name = @"Icterus Index Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit’s identifier that is being used to describe the Icterus Index of the specimen. It is recommended to use mMol/L of bilirubin",
            Sample = @"",
        };

        

        

        

        return icterusIndexUnits;
    } 
}
internal HL7V24Field fibrinIndex;

public HL7V24Field FibrinIndex
{
    get
    {
        if (fibrinIndex != null)
        {
            return fibrinIndex;
        }

        fibrinIndex = new HL7V24Field
        {
            field = message[@"SAC"][38],
            Id = @"SAC.38",
            Type = @"Field",
            Position = @"SAC.38",
            Name = @"Fibrin Index",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the index identifier that is being used to describe the Fibrin Index of the specimen. In the case of only differentiating between Absent and Present, we recommend using 0 and 1 respectively and send the field Fibrin Index Units null",
            Sample = @"",
        };

        

        

        

        return fibrinIndex;
    } 
}
internal HL7V24Field fibrinIndexUnits;

public HL7V24Field FibrinIndexUnits
{
    get
    {
        if (fibrinIndexUnits != null)
        {
            return fibrinIndexUnits;
        }

        fibrinIndexUnits = new HL7V24Field
        {
            field = message[@"SAC"][39],
            Id = @"SAC.39",
            Type = @"Field",
            Position = @"SAC.39",
            Name = @"Fibrin Index Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit’s identifier that is being used to describe the Fibrin Index of the specimen",
            Sample = @"",
        };

        

        

        

        return fibrinIndexUnits;
    } 
}
internal HL7V24Field systemInducedContaminants;

public HL7V24Field SystemInducedContaminants
{
    get
    {
        if (systemInducedContaminants != null)
        {
            return systemInducedContaminants;
        }

        systemInducedContaminants = new HL7V24Field
        {
            field = message[@"SAC"][40],
            Id = @"SAC.40",
            Type = @"Field",
            Position = @"SAC.40",
            Name = @"System Induced Contaminants",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0374",
            TableName = @"System induced contaminants",
            Description = @"This field describes the specimen contaminant identifier that is associated with the specimen. Refer to User-defined Table 0374 – System induced contaminants for valid values.  This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
            Sample = @"",
        };

        

        

        

        return systemInducedContaminants;
    } 
}
internal HL7V24Field drugInterference;

public HL7V24Field DrugInterference
{
    get
    {
        if (drugInterference != null)
        {
            return drugInterference;
        }

        drugInterference = new HL7V24Field
        {
            field = message[@"SAC"][41],
            Id = @"SAC.41",
            Type = @"Field",
            Position = @"SAC.41",
            Name = @"Drug Interference",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0382",
            TableName = @"Drug interference",
            Description = @"This field describes the drug interference identifier that is associated with the specimen. Refer to User-defined Table 0382 – Drug interference for suggested values",
            Sample = @"",
        };

        

        

        

        return drugInterference;
    } 
}
internal HL7V24Field artificialBlood;

public HL7V24Field ArtificialBlood
{
    get
    {
        if (artificialBlood != null)
        {
            return artificialBlood;
        }

        artificialBlood = new HL7V24Field
        {
            field = message[@"SAC"][42],
            Id = @"SAC.42",
            Type = @"Field",
            Position = @"SAC.42",
            Name = @"Artificial Blood",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0375",
            TableName = @"Artificial blood",
            Description = @"This field describes the artificial blood identifier that is associated with the specimen. Refer to User-defined Table 0375 – Artificial blood for valid values.  This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
            Sample = @"",
        };

        

        

        

        return artificialBlood;
    } 
}
internal HL7V24Field specialHandlingConsiderations;

public HL7V24Field SpecialHandlingConsiderations
{
    get
    {
        if (specialHandlingConsiderations != null)
        {
            return specialHandlingConsiderations;
        }

        specialHandlingConsiderations = new HL7V24Field
        {
            field = message[@"SAC"][43],
            Id = @"SAC.43",
            Type = @"Field",
            Position = @"SAC.43",
            Name = @"Special Handling Considerations",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0376",
            TableName = @"Special handling considerations",
            Description = @"This field describes any special handling considerations that are associated with the specimen. (E.g. centrifugation). Refer to User-defined Table 0376 – Special handling considerations for valid values.  This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
            Sample = @"",
        };

        

        

        

        return specialHandlingConsiderations;
    } 
}
internal HL7V24Field otherEnvironmentalFactors;

public HL7V24Field OtherEnvironmentalFactors
{
    get
    {
        if (otherEnvironmentalFactors != null)
        {
            return otherEnvironmentalFactors;
        }

        otherEnvironmentalFactors = new HL7V24Field
        {
            field = message[@"SAC"][44],
            Id = @"SAC.44",
            Type = @"Field",
            Position = @"SAC.44",
            Name = @"Other Environmental Factors",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0377",
            TableName = @"Other environmental factors",
            Description = @"This field describes other environmental factors that are associated with the specimen, e.g., atmospheric exposure. Refer to User-defined Table 0377 – Other environmental factors for valid values. This table’s values are taken from NCCLS AUTO4. The value set can be extended with user specific values",
            Sample = @"",
        };

        

        

        

        return otherEnvironmentalFactors;
    } 
}

    }
}
