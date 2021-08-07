using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentMSH
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"MSH"; } }

        public string SegmentId { get { return @"MSH"; } }
        
        public string LongName { get { return @"Message Header"; } }
        
        public string Description { get { return @"The MSH segment defines the intent, source, destination, and some specifics of the syntax of a message."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
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
                            Id = @"MSH.1",
                            Type = @"Field",
                            Position = @"MSH.1",
                            Name = @"Field Separator",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the separator between the segment ID and the first real field, MSH-2-encoding characters. As such it serves as the separator and defines the character to be used as a separator for the rest of the message. Recommended value is |, (ASCII 124).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.2",
                            Type = @"Field",
                            Position = @"MSH.2",
                            Name = @"Encoding Characters",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the four characters in the following order: the component separator, repetition separator, escape character, and subcomponent separator. Recommended values are ^~\& (ASCII 94, 126, 92, and 38, respectively). See Section 2.8, MESSAGE DELIMITERS.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3",
                            Type = @"Field",
                            Position = @"MSH.3",
                            Name = @"Sending Application",
                            Length = 180,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0361",
                            TableName = @"Sending/receiving application",
                            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined. User-defined Table 0361-Sending/receiving application is used as the user-defined table of values for the first component.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3.1",
                            Type = @"Component",
                            Position = @"MSH.3.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3.2",
                            Type = @"Component",
                            Position = @"MSH.3.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3.3",
                            Type = @"Component",
                            Position = @"MSH.3.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4",
                            Type = @"Field",
                            Position = @"MSH.4",
                            Name = @"Sending Facility",
                            Length = 180,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0362",
                            TableName = @"Sending/receiving facility",
                            Description = @"This field further describes the sending application, MSH-3-sending application. With the promotion of this field to an HD data type, the usage has been broadened to include not just the sending facility but other organizational entities such as a) the organizational entity responsible for sending application; b) the responsible unit; c) a product or vendors identifier, etc. Entirely site-defined. User-defined Table 0362 - Sending/receiving facility is used as the HL7 identifier for the user-defined table of values for the first component.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4.1",
                            Type = @"Component",
                            Position = @"MSH.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4.2",
                            Type = @"Component",
                            Position = @"MSH.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4.3",
                            Type = @"Component",
                            Position = @"MSH.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5",
                            Type = @"Field",
                            Position = @"MSH.5",
                            Name = @"Receiving Application",
                            Length = 180,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0361",
                            TableName = @"Sending/receiving application",
                            Description = @"This field uniquely identifies the receiving application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined . User-defined Table 0361-Sending/receiving application is used as the HL7 identifier for the user-defined table of values for the first component.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5.1",
                            Type = @"Component",
                            Position = @"MSH.5.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5.2",
                            Type = @"Component",
                            Position = @"MSH.5.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5.3",
                            Type = @"Component",
                            Position = @"MSH.5.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6",
                            Type = @"Field",
                            Position = @"MSH.6",
                            Name = @"Receiving Facility",
                            Length = 180,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0362",
                            TableName = @"Sending/receiving facility",
                            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations. User-defined Table 0362 - Sending/receiving facility is used as the HL7 identifier for the user-defined table of values for the first component. Entirely site-defined.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6.1",
                            Type = @"Component",
                            Position = @"MSH.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6.2",
                            Type = @"Component",
                            Position = @"MSH.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6.3",
                            Type = @"Component",
                            Position = @"MSH.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.7",
                            Type = @"Field",
                            Position = @"MSH.7",
                            Name = @"Date/Time Of Message",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the sending system created the message. If the time zone is specified, it will be used throughout the message as the default time zone.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MSH.7.1",
                            Type = @"Component",
                            Position = @"MSH.7.1",
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
                            Id = @"MSH.7.2",
                            Type = @"Component",
                            Position = @"MSH.7.2",
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
                            Id = @"MSH.8",
                            Type = @"Field",
                            Position = @"MSH.8",
                            Name = @"Security",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"In some applications of HL7, this field is used to implement security features. Its use is not yet further specified.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.9",
                            Type = @"Field",
                            Position = @"MSH.9",
                            Name = @"Message Type",
                            Length = 15,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MSG",
                            DataTypeName = @"Message Type",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the message type, trigger event, and the message structure ID for the message.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MSH.9.1",
                            Type = @"Component",
                            Position = @"MSH.9.1",
                            Name = @"Message Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0076",
                            TableName = @"Message type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.9.2",
                            Type = @"Component",
                            Position = @"MSH.9.2",
                            Name = @"Trigger Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0003",
                            TableName = @"Event type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.9.3",
                            Type = @"Component",
                            Position = @"MSH.9.3",
                            Name = @"Message Structure",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0354",
                            TableName = @"Message structure",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.10",
                            Type = @"Field",
                            Position = @"MSH.10",
                            Name = @"Message Control ID",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a number or other identifier that uniquely identifies the message. The receiving system echoes this ID back to the sending system in the Message acknowledgment segment (MSA).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.11",
                            Type = @"Field",
                            Position = @"MSH.11",
                            Name = @"Processing ID",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"PT",
                            DataTypeName = @"Processing Type",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to decide whether to process the message as defined in HL7 Application (level 7) Processing rules. The first component defines whether the message is part of a production, training, or debugging system (refer to HL7 Table 0103 - Processing ID for valid values). The second component defines whether the message is part of an archival process or an initial load (refer to HL7 Table 0207 - Processing modefor valid values). This allows different priorities to be given to different processing modes.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MSH.11.1",
                            Type = @"Component",
                            Position = @"MSH.11.1",
                            Name = @"Processing Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0103",
                            TableName = @"Processing ID",
                            Description = @"A value that defines whether the message is part of a production, training, or debugging system. Refer to HL7 Table 0103 - Processing ID for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.11.2",
                            Type = @"Component",
                            Position = @"MSH.11.2",
                            Name = @"Processing Mode",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0207",
                            TableName = @"Processing mode",
                            Description = @"A value that defines whether the message is part of an archival process or an initial load. Refer to HL7 Table 0207 - Processing mode for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12",
                            Type = @"Field",
                            Position = @"MSH.12",
                            Name = @"Version ID",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"VID",
                            DataTypeName = @"Version Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is matched by the receiving system to its own version to be sure the message will be interpreted correctly. Beginning with Version 2.3.1, it has two additional internationalization components, for use by HL7 international affiliates. The <internationalization code> is CE data type (using the ISO country codes where appropriate) which represents the HL7 affiliate. The <internal version ID> is used if the HL7 Affiliate has more than a single local version associated with a single US version. The <internal version ID> has a CE data type, since the table values vary for each HL7 Affiliate.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.1",
                            Type = @"Component",
                            Position = @"MSH.12.1",
                            Name = @"Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0104",
                            TableName = @"Version ID",
                            Description = @"Used to identify the HL7 version. Refer to HL7 Table 0104 - Version ID for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2",
                            Type = @"Component",
                            Position = @"MSH.12.2",
                            Name = @"Internationalization Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = @"Used to identify the international affiliate country code. The values to be used are those of ISO 3166 -1:1977. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.1",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.1",
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
                            Id = @"MSH.12.2.2",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.2",
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
                            Id = @"MSH.12.2.3",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.3",
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
                            Id = @"MSH.12.2.4",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.4",
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
                            Id = @"MSH.12.2.5",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.5",
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
                            Id = @"MSH.12.2.6",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.6",
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
                            Id = @"MSH.12.3",
                            Type = @"Component",
                            Position = @"MSH.12.3",
                            Name = @"International Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field component identifies international affiliates version; it is especially important when the international affiliate has more than a single local version associated with a single US version.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.1",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.1",
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
                            Id = @"MSH.12.3.2",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.2",
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
                            Id = @"MSH.12.3.3",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.3",
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
                            Id = @"MSH.12.3.4",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.4",
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
                            Id = @"MSH.12.3.5",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.5",
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
                            Id = @"MSH.12.3.6",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.6",
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
                            Id = @"MSH.13",
                            Type = @"Field",
                            Position = @"MSH.13",
                            Name = @"Sequence Number",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A non-null value in this field implies that the sequence number protocol is in use. This numeric field is incremented by one for each subsequent value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.14",
                            Type = @"Field",
                            Position = @"MSH.14",
                            Name = @"Continuation Pointer",
                            Length = 180,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to define continuations in application-specific ways.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.15",
                            Type = @"Field",
                            Position = @"MSH.15",
                            Name = @"Accept Acknowledgment Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0155",
                            TableName = @"Accept/application acknowledgment conditions",
                            Description = @"This field identifies the conditions under which accept acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode. Refer to HL7 Table 0155 - Accept/application acknowledgment conditions for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.16",
                            Type = @"Field",
                            Position = @"MSH.16",
                            Name = @"Application Acknowledgment Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0155",
                            TableName = @"Accept/application acknowledgment conditions",
                            Description = @"This field contains the conditions under which application acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.17",
                            Type = @"Field",
                            Position = @"MSH.17",
                            Name = @"Country Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = @"This field contains the country of origin for the message. It will be used primarily to specify default elements, such as currency denominations. The values to be used are those of ISO 3166, which are reprinted here upon written approval from ANSI.[2]. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.18",
                            Type = @"Field",
                            Position = @"MSH.18",
                            Name = @"Character Set",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0211",
                            TableName = @"Alternate character sets",
                            Description = @"This field contains the character set for the entire message. Refer to HL7 Table 0211 - Alternate character sets for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.19",
                            Type = @"Field",
                            Position = @"MSH.19",
                            Name = @"Principal Language Of Message",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the principal language of the message. Codes come from ISO 639.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MSH.19.1",
                            Type = @"Component",
                            Position = @"MSH.19.1",
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
                            Id = @"MSH.19.2",
                            Type = @"Component",
                            Position = @"MSH.19.2",
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
                            Id = @"MSH.19.3",
                            Type = @"Component",
                            Position = @"MSH.19.3",
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
                            Id = @"MSH.19.4",
                            Type = @"Component",
                            Position = @"MSH.19.4",
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
                            Id = @"MSH.19.5",
                            Type = @"Component",
                            Position = @"MSH.19.5",
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
                            Id = @"MSH.19.6",
                            Type = @"Component",
                            Position = @"MSH.19.6",
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
                            Id = @"MSH.20",
                            Type = @"Field",
                            Position = @"MSH.20",
                            Name = @"Alternate Character Set Handling Scheme",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0356",
                            TableName = @"Alternate character set handling scheme",
                            Description = @"When any alternative character sets are used (as specified in the second or later components of MSH-18 character sets ), and if any special handling scheme is needed, this component is to specify the scheme used, according to HL7 Table 0356- Alternate character set handling scheme as defined below:",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.21",
                            Type = @"Field",
                            Position = @"MSH.21",
                            Name = @"Conformance Statement ID",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0449",
                            TableName = @"Conformance statements",
                            Description = @"Sites may use this field to assert adherence to a Conformance Statement published by HL7 or by a site. Conformance Statements contain detailed explanations of grammar, syntax, and usage for a particular message or set of messages. Examples of the use of Conformance Statements appear in Chapter 5, ""Query.""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentMSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field fieldSeparator;

public HL7V24Field FieldSeparator
{
    get
    {
        if (fieldSeparator != null)
        {
            return fieldSeparator;
        }

        fieldSeparator = new HL7V24Field
        {
            field = message[@"MSH"][1],
            Id = @"MSH.1",
            Type = @"Field",
            Position = @"MSH.1",
            Name = @"Field Separator",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the separator between the segment ID and the first real field, MSH-2-encoding characters. As such it serves as the separator and defines the character to be used as a separator for the rest of the message. Recommended value is |, (ASCII 124).",
            Sample = @"",
        };

        

        

        

        return fieldSeparator;
    } 
}
internal HL7V24Field encodingCharacters;

public HL7V24Field EncodingCharacters
{
    get
    {
        if (encodingCharacters != null)
        {
            return encodingCharacters;
        }

        encodingCharacters = new HL7V24Field
        {
            field = message[@"MSH"][2],
            Id = @"MSH.2",
            Type = @"Field",
            Position = @"MSH.2",
            Name = @"Encoding Characters",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the four characters in the following order: the component separator, repetition separator, escape character, and subcomponent separator. Recommended values are ^~\& (ASCII 94, 126, 92, and 38, respectively). See Section 2.8, MESSAGE DELIMITERS.",
            Sample = @"",
        };

        

        

        

        return encodingCharacters;
    } 
}
internal HL7V24Field sendingApplication;

public HL7V24Field SendingApplication
{
    get
    {
        if (sendingApplication != null)
        {
            return sendingApplication;
        }

        sendingApplication = new HL7V24Field
        {
            field = message[@"MSH"][3],
            Id = @"MSH.3",
            Type = @"Field",
            Position = @"MSH.3",
            Name = @"Sending Application",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0361",
            TableName = @"Sending/receiving application",
            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined. User-defined Table 0361-Sending/receiving application is used as the user-defined table of values for the first component.",
            Sample = @"",
        };

        

        

        

        return sendingApplication;
    } 
}
internal HL7V24Field sendingFacility;

public HL7V24Field SendingFacility
{
    get
    {
        if (sendingFacility != null)
        {
            return sendingFacility;
        }

        sendingFacility = new HL7V24Field
        {
            field = message[@"MSH"][4],
            Id = @"MSH.4",
            Type = @"Field",
            Position = @"MSH.4",
            Name = @"Sending Facility",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0362",
            TableName = @"Sending/receiving facility",
            Description = @"This field further describes the sending application, MSH-3-sending application. With the promotion of this field to an HD data type, the usage has been broadened to include not just the sending facility but other organizational entities such as a) the organizational entity responsible for sending application; b) the responsible unit; c) a product or vendors identifier, etc. Entirely site-defined. User-defined Table 0362 - Sending/receiving facility is used as the HL7 identifier for the user-defined table of values for the first component.",
            Sample = @"",
        };

        

        

        

        return sendingFacility;
    } 
}
internal HL7V24Field receivingApplication;

public HL7V24Field ReceivingApplication
{
    get
    {
        if (receivingApplication != null)
        {
            return receivingApplication;
        }

        receivingApplication = new HL7V24Field
        {
            field = message[@"MSH"][5],
            Id = @"MSH.5",
            Type = @"Field",
            Position = @"MSH.5",
            Name = @"Receiving Application",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0361",
            TableName = @"Sending/receiving application",
            Description = @"This field uniquely identifies the receiving application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined . User-defined Table 0361-Sending/receiving application is used as the HL7 identifier for the user-defined table of values for the first component.",
            Sample = @"",
        };

        

        

        

        return receivingApplication;
    } 
}
internal HL7V24Field receivingFacility;

public HL7V24Field ReceivingFacility
{
    get
    {
        if (receivingFacility != null)
        {
            return receivingFacility;
        }

        receivingFacility = new HL7V24Field
        {
            field = message[@"MSH"][6],
            Id = @"MSH.6",
            Type = @"Field",
            Position = @"MSH.6",
            Name = @"Receiving Facility",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0362",
            TableName = @"Sending/receiving facility",
            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations. User-defined Table 0362 - Sending/receiving facility is used as the HL7 identifier for the user-defined table of values for the first component. Entirely site-defined.",
            Sample = @"",
        };

        

        

        

        return receivingFacility;
    } 
}
internal HL7V24Field dateTimeOfMessage;

public HL7V24Field DateTimeOfMessage
{
    get
    {
        if (dateTimeOfMessage != null)
        {
            return dateTimeOfMessage;
        }

        dateTimeOfMessage = new HL7V24Field
        {
            field = message[@"MSH"][7],
            Id = @"MSH.7",
            Type = @"Field",
            Position = @"MSH.7",
            Name = @"Date/Time Of Message",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the sending system created the message. If the time zone is specified, it will be used throughout the message as the default time zone.",
            Sample = @"",
        };

        

        

        

        return dateTimeOfMessage;
    } 
}
internal HL7V24Field security;

public HL7V24Field Security
{
    get
    {
        if (security != null)
        {
            return security;
        }

        security = new HL7V24Field
        {
            field = message[@"MSH"][8],
            Id = @"MSH.8",
            Type = @"Field",
            Position = @"MSH.8",
            Name = @"Security",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"In some applications of HL7, this field is used to implement security features. Its use is not yet further specified.",
            Sample = @"",
        };

        

        

        

        return security;
    } 
}
internal HL7V24Field messageType;

public HL7V24Field MessageType
{
    get
    {
        if (messageType != null)
        {
            return messageType;
        }

        messageType = new HL7V24Field
        {
            field = message[@"MSH"][9],
            Id = @"MSH.9",
            Type = @"Field",
            Position = @"MSH.9",
            Name = @"Message Type",
            Length = 15,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"MSG",
            DataTypeName = @"Message Type",
            TableId = null,
            TableName = null,
            Description = @"This field contains the message type, trigger event, and the message structure ID for the message.",
            Sample = @"",
        };

        

        

        

        return messageType;
    } 
}
internal HL7V24Field messageControlID;

public HL7V24Field MessageControlID
{
    get
    {
        if (messageControlID != null)
        {
            return messageControlID;
        }

        messageControlID = new HL7V24Field
        {
            field = message[@"MSH"][10],
            Id = @"MSH.10",
            Type = @"Field",
            Position = @"MSH.10",
            Name = @"Message Control ID",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number or other identifier that uniquely identifies the message. The receiving system echoes this ID back to the sending system in the Message acknowledgment segment (MSA).",
            Sample = @"",
        };

        

        

        

        return messageControlID;
    } 
}
internal HL7V24Field processingID;

public HL7V24Field ProcessingID
{
    get
    {
        if (processingID != null)
        {
            return processingID;
        }

        processingID = new HL7V24Field
        {
            field = message[@"MSH"][11],
            Id = @"MSH.11",
            Type = @"Field",
            Position = @"MSH.11",
            Name = @"Processing ID",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PT",
            DataTypeName = @"Processing Type",
            TableId = null,
            TableName = null,
            Description = @"This field is used to decide whether to process the message as defined in HL7 Application (level 7) Processing rules. The first component defines whether the message is part of a production, training, or debugging system (refer to HL7 Table 0103 - Processing ID for valid values). The second component defines whether the message is part of an archival process or an initial load (refer to HL7 Table 0207 - Processing modefor valid values). This allows different priorities to be given to different processing modes.",
            Sample = @"",
        };

        

        

        

        return processingID;
    } 
}
internal HL7V24Field versionID;

public HL7V24Field VersionID
{
    get
    {
        if (versionID != null)
        {
            return versionID;
        }

        versionID = new HL7V24Field
        {
            field = message[@"MSH"][12],
            Id = @"MSH.12",
            Type = @"Field",
            Position = @"MSH.12",
            Name = @"Version ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"VID",
            DataTypeName = @"Version Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field is matched by the receiving system to its own version to be sure the message will be interpreted correctly. Beginning with Version 2.3.1, it has two additional internationalization components, for use by HL7 international affiliates. The <internationalization code> is CE data type (using the ISO country codes where appropriate) which represents the HL7 affiliate. The <internal version ID> is used if the HL7 Affiliate has more than a single local version associated with a single US version. The <internal version ID> has a CE data type, since the table values vary for each HL7 Affiliate.",
            Sample = @"",
        };

        

        

        

        return versionID;
    } 
}
internal HL7V24Field sequenceNumber;

public HL7V24Field SequenceNumber
{
    get
    {
        if (sequenceNumber != null)
        {
            return sequenceNumber;
        }

        sequenceNumber = new HL7V24Field
        {
            field = message[@"MSH"][13],
            Id = @"MSH.13",
            Type = @"Field",
            Position = @"MSH.13",
            Name = @"Sequence Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"A non-null value in this field implies that the sequence number protocol is in use. This numeric field is incremented by one for each subsequent value.",
            Sample = @"",
        };

        

        

        

        return sequenceNumber;
    } 
}
internal HL7V24Field continuationPointer;

public HL7V24Field ContinuationPointer
{
    get
    {
        if (continuationPointer != null)
        {
            return continuationPointer;
        }

        continuationPointer = new HL7V24Field
        {
            field = message[@"MSH"][14],
            Id = @"MSH.14",
            Type = @"Field",
            Position = @"MSH.14",
            Name = @"Continuation Pointer",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to define continuations in application-specific ways.",
            Sample = @"",
        };

        

        

        

        return continuationPointer;
    } 
}
internal HL7V24Field acceptAcknowledgmentType;

public HL7V24Field AcceptAcknowledgmentType
{
    get
    {
        if (acceptAcknowledgmentType != null)
        {
            return acceptAcknowledgmentType;
        }

        acceptAcknowledgmentType = new HL7V24Field
        {
            field = message[@"MSH"][15],
            Id = @"MSH.15",
            Type = @"Field",
            Position = @"MSH.15",
            Name = @"Accept Acknowledgment Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0155",
            TableName = @"Accept/application acknowledgment conditions",
            Description = @"This field identifies the conditions under which accept acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode. Refer to HL7 Table 0155 - Accept/application acknowledgment conditions for valid values.",
            Sample = @"",
        };

        

        

        

        return acceptAcknowledgmentType;
    } 
}
internal HL7V24Field applicationAcknowledgmentType;

public HL7V24Field ApplicationAcknowledgmentType
{
    get
    {
        if (applicationAcknowledgmentType != null)
        {
            return applicationAcknowledgmentType;
        }

        applicationAcknowledgmentType = new HL7V24Field
        {
            field = message[@"MSH"][16],
            Id = @"MSH.16",
            Type = @"Field",
            Position = @"MSH.16",
            Name = @"Application Acknowledgment Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0155",
            TableName = @"Accept/application acknowledgment conditions",
            Description = @"This field contains the conditions under which application acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode.",
            Sample = @"",
        };

        

        

        

        return applicationAcknowledgmentType;
    } 
}
internal HL7V24Field countryCode;

public HL7V24Field CountryCode
{
    get
    {
        if (countryCode != null)
        {
            return countryCode;
        }

        countryCode = new HL7V24Field
        {
            field = message[@"MSH"][17],
            Id = @"MSH.17",
            Type = @"Field",
            Position = @"MSH.17",
            Name = @"Country Code",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0399",
            TableName = @"Country code",
            Description = @"This field contains the country of origin for the message. It will be used primarily to specify default elements, such as currency denominations. The values to be used are those of ISO 3166, which are reprinted here upon written approval from ANSI.[2]. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
            Sample = @"",
        };

        

        

        

        return countryCode;
    } 
}
internal HL7V24Field characterSet;

public HL7V24Field CharacterSet
{
    get
    {
        if (characterSet != null)
        {
            return characterSet;
        }

        characterSet = new HL7V24Field
        {
            field = message[@"MSH"][18],
            Id = @"MSH.18",
            Type = @"Field",
            Position = @"MSH.18",
            Name = @"Character Set",
            Length = 16,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0211",
            TableName = @"Alternate character sets",
            Description = @"This field contains the character set for the entire message. Refer to HL7 Table 0211 - Alternate character sets for valid values.",
            Sample = @"",
        };

        

        

        

        return characterSet;
    } 
}
internal HL7V24Field principalLanguageOfMessage;

public HL7V24Field PrincipalLanguageOfMessage
{
    get
    {
        if (principalLanguageOfMessage != null)
        {
            return principalLanguageOfMessage;
        }

        principalLanguageOfMessage = new HL7V24Field
        {
            field = message[@"MSH"][19],
            Id = @"MSH.19",
            Type = @"Field",
            Position = @"MSH.19",
            Name = @"Principal Language Of Message",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the principal language of the message. Codes come from ISO 639.",
            Sample = @"",
        };

        

        

        

        return principalLanguageOfMessage;
    } 
}
internal HL7V24Field alternateCharacterSetHandlingScheme;

public HL7V24Field AlternateCharacterSetHandlingScheme
{
    get
    {
        if (alternateCharacterSetHandlingScheme != null)
        {
            return alternateCharacterSetHandlingScheme;
        }

        alternateCharacterSetHandlingScheme = new HL7V24Field
        {
            field = message[@"MSH"][20],
            Id = @"MSH.20",
            Type = @"Field",
            Position = @"MSH.20",
            Name = @"Alternate Character Set Handling Scheme",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0356",
            TableName = @"Alternate character set handling scheme",
            Description = @"When any alternative character sets are used (as specified in the second or later components of MSH-18 character sets ), and if any special handling scheme is needed, this component is to specify the scheme used, according to HL7 Table 0356- Alternate character set handling scheme as defined below:",
            Sample = @"",
        };

        

        

        

        return alternateCharacterSetHandlingScheme;
    } 
}
internal HL7V24Field conformanceStatementID;

public HL7V24Field ConformanceStatementID
{
    get
    {
        if (conformanceStatementID != null)
        {
            return conformanceStatementID;
        }

        conformanceStatementID = new HL7V24Field
        {
            field = message[@"MSH"][21],
            Id = @"MSH.21",
            Type = @"Field",
            Position = @"MSH.21",
            Name = @"Conformance Statement ID",
            Length = 10,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0449",
            TableName = @"Conformance statements",
            Description = @"Sites may use this field to assert adherence to a Conformance Statement published by HL7 or by a site. Conformance Statements contain detailed explanations of grammar, syntax, and usage for a particular message or set of messages. Examples of the use of Conformance Statements appear in Chapter 5, ""Query.""",
            Sample = @"",
        };

        

        

        

        return conformanceStatementID;
    } 
}

    }
}
