using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentMSH
    {
        public HL7V2Message message { get; init; }

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
                            Description = @"This field contains the separator between the segment ID and the first real field, MSH-2-encoding characters . As such it serves as the separator and defines the character to be used as a separator for the rest of the message. Recommended value is | (ASCII 124).",
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
                            Description = @"This field contains two to four characters in the following order: the component separator, repetition separator, escape character, and subcomponent separator. Best practice is to always include all four characters. Recommended values are ^~\& (ASCII 94, 126, 92, and 38, respectively). See Section 2.5.4, ""Message delimiters'.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3",
                            Type = @"Field",
                            Position = @"MSH.3",
                            Name = @"Sending Application",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0361",
                            TableName = @"Application",
                            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined. User-defined Table 0361- Application is used as the user-defined table of values for the first component.

Note:By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.3.1",
                            Type = @"Component",
                            Position = @"MSH.3.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3.2",
                            Type = @"Component",
                            Position = @"MSH.3.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4",
                            Type = @"Field",
                            Position = @"MSH.4",
                            Name = @"Sending Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0362",
                            TableName = @"Facility",
                            Description = @"This field further describes the sending application, MSH-3-sending application. With the promotion of this field to an HD data type, the usage has been broadened to include not just the sending facility but other organizational entities such as a) the organizational entity responsible for sending application; b) the responsible unit; c) a product or vendor's identifier, etc. Entirely site-defined. User-defined Table 0362 - Facility  is used as the HL7 identifier for the user-defined table of values for the first component.

Note:By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.4.1",
                            Type = @"Component",
                            Position = @"MSH.4.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4.2",
                            Type = @"Component",
                            Position = @"MSH.4.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5",
                            Type = @"Field",
                            Position = @"MSH.5",
                            Name = @"Receiving Application",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0361",
                            TableName = @"Application",
                            Description = @"This field uniquely identifies the receiving application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined User-defined Table 0361- Application is used as the HL7 identifier for the user-defined table of values for the first component.

Note:By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.5.1",
                            Type = @"Component",
                            Position = @"MSH.5.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5.2",
                            Type = @"Component",
                            Position = @"MSH.5.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6",
                            Type = @"Field",
                            Position = @"MSH.6",
                            Name = @"Receiving Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0362",
                            TableName = @"Facility",
                            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations. User-defined Table 0362 - Facility is used as the HL7 identifier for the user-defined table of values for the first component. Entirely site-defined.

Note:By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.6.1",
                            Type = @"Component",
                            Position = @"MSH.6.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6.2",
                            Type = @"Component",
                            Position = @"MSH.6.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.7",
                            Type = @"Field",
                            Position = @"MSH.7",
                            Name = @"Date/Time Of Message",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the sending system created the message. If the time zone is specified, it will be used throughout the message as the default time zone.",
                            Sample = @"",
                            FieldDatas = null
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
                            Description = @"This field contains the message type, trigger event, and the message structure ID for the message.

Refer to HL7 Table 0076 - Message type for valid values for the message type code. This table contains values such as ACK, ADT, ORM, ORU etc.

Refer to HL7 Table 0003 - Event type for valid values for the trigger event. This table contains values like A01, O01, R01 etc. 

Refer to HL7 Table 0354 - Message structure for valid values for the message structure. This table contains values such as ADT_A01, ORU_R01, SIU_S12, etc.

The receiving system uses this field to recognize the data segments, and possibly, the application to which to route this message. For certain queries, which may have more than a single response event type, the second component may, in the response message, vary to indicate the response event type. See the discussion of the display query variants in chapter 5.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.9.1",
                            Type = @"Component",
                            Position = @"MSH.9.1",
                            Name = @"Message Code",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0076",
                            TableName = @"Message type",
                            Description = @"Specifies the message type code. Refer to HL7 Table 0076- Message Type in section 2.16.1 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.9.2",
                            Type = @"Component",
                            Position = @"MSH.9.2",
                            Name = @"Trigger Event",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0003",
                            TableName = @"Event type",
                            Description = @"Specifies the trigger event code. Refer to HL7 Table 0003- Event Type in section 2.16.2 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.9.3",
                            Type = @"Component",
                            Position = @"MSH.9.3",
                            Name = @"Message Structure",
                            Length = 7,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0354",
                            TableName = @"Message structure",
                            Description = @"Specifies the abstract message structure code. Refer to HL7 Table 0354 - Message Structure in section 2.17.3 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.10",
                            Type = @"Field",
                            Position = @"MSH.10",
                            Name = @"Message Control ID",
                            Length = 199,
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
                            Description = @"This field is used to decide whether to process the message as defined in HL7 Application (level 7) Processing rules.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.11.1",
                            Type = @"Component",
                            Position = @"MSH.11.1",
                            Name = @"Processing Id",
                            Length = 1,
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
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0207",
                            TableName = @"Processing mode",
                            Description = @"A value that defines whether the message is part of an archival process or an initial load. Refer to HL7 Table 0207 - Processing mode for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
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
                            Description = @"This field is matched by the receiving system to its own version to be sure the message will be interpreted correctly. Beginning with Version 2.3.1, it has two additional ""internationalization"" components, for use by HL7 international affiliates. The <internationalization code> is CE data type (using the ISO country codes where appropriate) which represents the HL7 affiliate. The <internal version ID> is used if the HL7 Affiliate has more than a single 'local' version associated with a single US version. The <international version ID> has a CE data type, since the table values vary for each HL7 Affiliate.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.12.1",
                            Type = @"Component",
                            Position = @"MSH.12.1",
                            Name = @"Version Id",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0104",
                            TableName = @"Version ID",
                            Description = @"Used to identify the HL7 version. Refer to HL7 Table 0104 - Version ID in section 2.15.9.12 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2",
                            Type = @"Component",
                            Position = @"MSH.12.2",
                            Name = @"Internationalization Code",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0339",
                            TableName = @"Advanced Beneficiary Notice Code",
                            Description = @"Used to identify the international affiliate country code. The values to be used are those of ISO 3166 -1:1977. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.1",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.2",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.3",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.4",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.5",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.6",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.7",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.8",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.9",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3",
                            Type = @"Component",
                            Position = @"MSH.12.3",
                            Name = @"International Version Id",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field component identifies international affiliates version; it is especially important when the international affiliate has more than a single local version associated with a single US version.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.1",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.2",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.3",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.4",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.5",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.6",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.7",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.8",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.9",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
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
                            Description = @"This field is used to define continuations in application-specific ways.

Only the sender of a fragmented message values this field.",
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
                            Description = @"This field identifies the conditions under which accept acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode. Refer to HL7 Table 0155 - Accept/application acknowledgment conditions for valid values.

Note: If MSH-15-accept acknowledgment type and MSH-16-application acknowledgment type are omitted (or are both null), the original acknowledgment mode rules are used.",
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
                            Description = @"This field contains the conditions under which application acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode. Refer to HL7 Table 0155 - Accept/application acknowledgment conditions for valid values.

Note: If MSH-15-accept acknowledgment type and MSH-16-application acknowledgment type are omitted (or are both null), the original acknowledgment mode rules are used.",
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
                            TableName = @"Country Code",
                            Description = @"This field contains the country of origin for the message. It will be used primarily to specify default elements, such as currency denominations. The values to be used are those of ISO 3166,.[4]. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.

Refer to External Table 0399 - Country Code for the 3-character codes as defined by ISO 3166-1.",
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
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the principal language of the message. Codes come from ISO 639.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.19.1",
                            Type = @"Component",
                            Position = @"MSH.19.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.19.2",
                            Type = @"Component",
                            Position = @"MSH.19.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.19.3",
                            Type = @"Component",
                            Position = @"MSH.19.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.19.4",
                            Type = @"Component",
                            Position = @"MSH.19.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.19.5",
                            Type = @"Component",
                            Position = @"MSH.19.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.19.6",
                            Type = @"Component",
                            Position = @"MSH.19.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.19.7",
                            Type = @"Component",
                            Position = @"MSH.19.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.19.8",
                            Type = @"Component",
                            Position = @"MSH.19.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.19.9",
                            Type = @"Component",
                            Position = @"MSH.19.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
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
                            Description = @"When any alternative character sets are used (as specified in the second or later iterations of MSH-18 character sets), and if any special handling scheme is needed, this component is to specify the scheme used, according to HL7 Table 0356- Alternate character set handling scheme as defined below:",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.21",
                            Type = @"Field",
                            Position = @"MSH.21",
                            Name = @"Message Profile Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Sites may use this field to assert adherence to, or reference, a message profile. Message profiles contain detailed explanations of grammar, syntax, and usage for a particular message or set of messages. See section 2B, ""Conformance Using Message Profiles"".",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.21.1",
                            Type = @"Component",
                            Position = @"MSH.21.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.21.2",
                            Type = @"Component",
                            Position = @"MSH.21.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.21.3",
                            Type = @"Component",
                            Position = @"MSH.21.3",
                            Name = @"Universal Id",
                            Length = 199,
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
                            Id = @"MSH.21.4",
                            Type = @"Component",
                            Position = @"MSH.21.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22",
                            Type = @"Field",
                            Position = @"MSH.22",
                            Name = @"Sending Responsible Organization",
                            Length = 567,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"Business organization that originated and is accountable for the content of the message.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.22.1",
                            Type = @"Component",
                            Position = @"MSH.22.1",
                            Name = @"Organization Name",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22.2",
                            Type = @"Component",
                            Position = @"MSH.22.2",
                            Name = @"Organization Name Type Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22.3",
                            Type = @"Component",
                            Position = @"MSH.22.3",
                            Name = @"Id Number",
                            Length = 4,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component has been retained for backward compatibility only as of v 2.5. It is recommended to use component 10 Organization identifier that accommodates alphanumeric identifiers.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22.4",
                            Type = @"Component",
                            Position = @"MSH.22.4",
                            Name = @"Identifier Check Digit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the digit, or digits, exclusive of the identifier in XON.1, usually calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22.5",
                            Type = @"Component",
                            Position = @"MSH.22.5",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22.6",
                            Type = @"Component",
                            Position = @"MSH.22.6",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.22.6.1",
                            Type = @"SubComponent",
                            Position = @"MSH.22.6.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22.6.2",
                            Type = @"SubComponent",
                            Position = @"MSH.22.6.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Id = @"MSH.22.6.3",
                            Type = @"SubComponent",
                            Position = @"MSH.22.6.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22.7",
                            Type = @"Component",
                            Position = @"MSH.22.7",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the ""Assigning authority"" component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22.8",
                            Type = @"Component",
                            Position = @"MSH.22.8",
                            Name = @"Assigning Facility",
                            Length = 227,
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
                            Id = @"MSH.22.8.1",
                            Type = @"SubComponent",
                            Position = @"MSH.22.8.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22.8.2",
                            Type = @"SubComponent",
                            Position = @"MSH.22.8.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Id = @"MSH.22.8.3",
                            Type = @"SubComponent",
                            Position = @"MSH.22.8.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22.9",
                            Type = @"Component",
                            Position = @"MSH.22.9",
                            Name = @"Name Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.22.10",
                            Type = @"Component",
                            Position = @"MSH.22.10",
                            Name = @"Organization Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23",
                            Type = @"Field",
                            Position = @"MSH.23",
                            Name = @"Receiving Responsible Organization",
                            Length = 567,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"Business organization that is the intended receiver of the message and is accountable for acting on the data conveyed by the transaction.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.23.1",
                            Type = @"Component",
                            Position = @"MSH.23.1",
                            Name = @"Organization Name",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23.2",
                            Type = @"Component",
                            Position = @"MSH.23.2",
                            Name = @"Organization Name Type Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23.3",
                            Type = @"Component",
                            Position = @"MSH.23.3",
                            Name = @"Id Number",
                            Length = 4,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component has been retained for backward compatibility only as of v 2.5. It is recommended to use component 10 Organization identifier that accommodates alphanumeric identifiers.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23.4",
                            Type = @"Component",
                            Position = @"MSH.23.4",
                            Name = @"Identifier Check Digit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the digit, or digits, exclusive of the identifier in XON.1, usually calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23.5",
                            Type = @"Component",
                            Position = @"MSH.23.5",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23.6",
                            Type = @"Component",
                            Position = @"MSH.23.6",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.23.6.1",
                            Type = @"SubComponent",
                            Position = @"MSH.23.6.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23.6.2",
                            Type = @"SubComponent",
                            Position = @"MSH.23.6.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Id = @"MSH.23.6.3",
                            Type = @"SubComponent",
                            Position = @"MSH.23.6.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23.7",
                            Type = @"Component",
                            Position = @"MSH.23.7",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the ""Assigning authority"" component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23.8",
                            Type = @"Component",
                            Position = @"MSH.23.8",
                            Name = @"Assigning Facility",
                            Length = 227,
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
                            Id = @"MSH.23.8.1",
                            Type = @"SubComponent",
                            Position = @"MSH.23.8.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23.8.2",
                            Type = @"SubComponent",
                            Position = @"MSH.23.8.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Id = @"MSH.23.8.3",
                            Type = @"SubComponent",
                            Position = @"MSH.23.8.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23.9",
                            Type = @"Component",
                            Position = @"MSH.23.9",
                            Name = @"Name Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.23.10",
                            Type = @"Component",
                            Position = @"MSH.23.10",
                            Name = @"Organization Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.24",
                            Type = @"Field",
                            Position = @"MSH.24",
                            Name = @"Sending Network Address",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifier of the network location the message was transmitted from. Identified by an OID or text string (e.g., URI). The reader is referred to the ""Report from the Joint W3C/IETF URI Planning Interest Group: Uniform Resource Identifiers (URIs), URLs, and Uniform Resource Names (URNs): Clarifications and Recommendations"".[6]",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.24.1",
                            Type = @"Component",
                            Position = @"MSH.24.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.24.2",
                            Type = @"Component",
                            Position = @"MSH.24.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Id = @"MSH.24.3",
                            Type = @"Component",
                            Position = @"MSH.24.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.25",
                            Type = @"Field",
                            Position = @"MSH.25",
                            Name = @"Receiving Network Address",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifier of the network location the message was transmitted to. Identified by an OID or text string (e.g., URL).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.25.1",
                            Type = @"Component",
                            Position = @"MSH.25.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.25.2",
                            Type = @"Component",
                            Position = @"MSH.25.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
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
                            Id = @"MSH.25.3",
                            Type = @"Component",
                            Position = @"MSH.25.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V26SegmentMSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field fieldSeparator;

public HL7V26Field FieldSeparator
{
    get
    {
        if (fieldSeparator != null)
        {
            return fieldSeparator;
        }

        fieldSeparator = new HL7V26Field
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
            Description = @"This field contains the separator between the segment ID and the first real field, MSH-2-encoding characters . As such it serves as the separator and defines the character to be used as a separator for the rest of the message. Recommended value is | (ASCII 124).",
            Sample = @"",
        };

        // check for repetitions
        if (fieldSeparator.field.FieldRepetitions != null && fieldSeparator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fieldSeparator.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < fieldSeparator.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = fieldSeparator.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fieldSeparator.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = fieldSeparator.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < fieldSeparator.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = fieldSeparator.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fieldSeparator.fieldRepetitions = fieldRepetitions;
        }

        return fieldSeparator;
    } 
}

internal HL7V26Field encodingCharacters;

public HL7V26Field EncodingCharacters
{
    get
    {
        if (encodingCharacters != null)
        {
            return encodingCharacters;
        }

        encodingCharacters = new HL7V26Field
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
            Description = @"This field contains two to four characters in the following order: the component separator, repetition separator, escape character, and subcomponent separator. Best practice is to always include all four characters. Recommended values are ^~\& (ASCII 94, 126, 92, and 38, respectively). See Section 2.5.4, ""Message delimiters'.",
            Sample = @"",
        };

        // check for repetitions
        if (encodingCharacters.field.FieldRepetitions != null && encodingCharacters.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(encodingCharacters.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < encodingCharacters.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = encodingCharacters.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < encodingCharacters.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = encodingCharacters.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < encodingCharacters.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = encodingCharacters.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            encodingCharacters.fieldRepetitions = fieldRepetitions;
        }

        return encodingCharacters;
    } 
}

internal HL7V26Field sendingApplication;

public HL7V26Field SendingApplication
{
    get
    {
        if (sendingApplication != null)
        {
            return sendingApplication;
        }

        sendingApplication = new HL7V26Field
        {
            field = message[@"MSH"][3],
            Id = @"MSH.3",
            Type = @"Field",
            Position = @"MSH.3",
            Name = @"Sending Application",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0361",
            TableName = @"Application",
            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined. User-defined Table 0361- Application is used as the user-defined table of values for the first component.

Note:By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component.",
            Sample = @"",
        };

        // check for repetitions
        if (sendingApplication.field.FieldRepetitions != null && sendingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sendingApplication.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < sendingApplication.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = sendingApplication.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < sendingApplication.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = sendingApplication.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < sendingApplication.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = sendingApplication.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            sendingApplication.fieldRepetitions = fieldRepetitions;
        }

        return sendingApplication;
    } 
}

internal HL7V26Field sendingFacility;

public HL7V26Field SendingFacility
{
    get
    {
        if (sendingFacility != null)
        {
            return sendingFacility;
        }

        sendingFacility = new HL7V26Field
        {
            field = message[@"MSH"][4],
            Id = @"MSH.4",
            Type = @"Field",
            Position = @"MSH.4",
            Name = @"Sending Facility",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0362",
            TableName = @"Facility",
            Description = @"This field further describes the sending application, MSH-3-sending application. With the promotion of this field to an HD data type, the usage has been broadened to include not just the sending facility but other organizational entities such as a) the organizational entity responsible for sending application; b) the responsible unit; c) a product or vendor's identifier, etc. Entirely site-defined. User-defined Table 0362 - Facility  is used as the HL7 identifier for the user-defined table of values for the first component.

Note:By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component.",
            Sample = @"",
        };

        // check for repetitions
        if (sendingFacility.field.FieldRepetitions != null && sendingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sendingFacility.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < sendingFacility.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = sendingFacility.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < sendingFacility.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = sendingFacility.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < sendingFacility.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = sendingFacility.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            sendingFacility.fieldRepetitions = fieldRepetitions;
        }

        return sendingFacility;
    } 
}

internal HL7V26Field receivingApplication;

public HL7V26Field ReceivingApplication
{
    get
    {
        if (receivingApplication != null)
        {
            return receivingApplication;
        }

        receivingApplication = new HL7V26Field
        {
            field = message[@"MSH"][5],
            Id = @"MSH.5",
            Type = @"Field",
            Position = @"MSH.5",
            Name = @"Receiving Application",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0361",
            TableName = @"Application",
            Description = @"This field uniquely identifies the receiving application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined User-defined Table 0361- Application is used as the HL7 identifier for the user-defined table of values for the first component.

Note:By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component.",
            Sample = @"",
        };

        // check for repetitions
        if (receivingApplication.field.FieldRepetitions != null && receivingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(receivingApplication.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < receivingApplication.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = receivingApplication.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < receivingApplication.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = receivingApplication.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < receivingApplication.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = receivingApplication.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            receivingApplication.fieldRepetitions = fieldRepetitions;
        }

        return receivingApplication;
    } 
}

internal HL7V26Field receivingFacility;

public HL7V26Field ReceivingFacility
{
    get
    {
        if (receivingFacility != null)
        {
            return receivingFacility;
        }

        receivingFacility = new HL7V26Field
        {
            field = message[@"MSH"][6],
            Id = @"MSH.6",
            Type = @"Field",
            Position = @"MSH.6",
            Name = @"Receiving Facility",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0362",
            TableName = @"Facility",
            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations. User-defined Table 0362 - Facility is used as the HL7 identifier for the user-defined table of values for the first component. Entirely site-defined.

Note:By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component.",
            Sample = @"",
        };

        // check for repetitions
        if (receivingFacility.field.FieldRepetitions != null && receivingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(receivingFacility.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < receivingFacility.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = receivingFacility.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < receivingFacility.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = receivingFacility.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < receivingFacility.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = receivingFacility.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            receivingFacility.fieldRepetitions = fieldRepetitions;
        }

        return receivingFacility;
    } 
}

internal HL7V26Field dateTimeOfMessage;

public HL7V26Field DateTimeOfMessage
{
    get
    {
        if (dateTimeOfMessage != null)
        {
            return dateTimeOfMessage;
        }

        dateTimeOfMessage = new HL7V26Field
        {
            field = message[@"MSH"][7],
            Id = @"MSH.7",
            Type = @"Field",
            Position = @"MSH.7",
            Name = @"Date/Time Of Message",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the sending system created the message. If the time zone is specified, it will be used throughout the message as the default time zone.",
            Sample = @"",
        };

        // check for repetitions
        if (dateTimeOfMessage.field.FieldRepetitions != null && dateTimeOfMessage.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateTimeOfMessage.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < dateTimeOfMessage.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = dateTimeOfMessage.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < dateTimeOfMessage.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = dateTimeOfMessage.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < dateTimeOfMessage.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = dateTimeOfMessage.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            dateTimeOfMessage.fieldRepetitions = fieldRepetitions;
        }

        return dateTimeOfMessage;
    } 
}

internal HL7V26Field security;

public HL7V26Field Security
{
    get
    {
        if (security != null)
        {
            return security;
        }

        security = new HL7V26Field
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

        // check for repetitions
        if (security.field.FieldRepetitions != null && security.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(security.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < security.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = security.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < security.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = security.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < security.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = security.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            security.fieldRepetitions = fieldRepetitions;
        }

        return security;
    } 
}

internal HL7V26Field messageType;

public HL7V26Field MessageType
{
    get
    {
        if (messageType != null)
        {
            return messageType;
        }

        messageType = new HL7V26Field
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
            Description = @"This field contains the message type, trigger event, and the message structure ID for the message.

Refer to HL7 Table 0076 - Message type for valid values for the message type code. This table contains values such as ACK, ADT, ORM, ORU etc.

Refer to HL7 Table 0003 - Event type for valid values for the trigger event. This table contains values like A01, O01, R01 etc. 

Refer to HL7 Table 0354 - Message structure for valid values for the message structure. This table contains values such as ADT_A01, ORU_R01, SIU_S12, etc.

The receiving system uses this field to recognize the data segments, and possibly, the application to which to route this message. For certain queries, which may have more than a single response event type, the second component may, in the response message, vary to indicate the response event type. See the discussion of the display query variants in chapter 5.",
            Sample = @"",
        };

        // check for repetitions
        if (messageType.field.FieldRepetitions != null && messageType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageType.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < messageType.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = messageType.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < messageType.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = messageType.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < messageType.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = messageType.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            messageType.fieldRepetitions = fieldRepetitions;
        }

        return messageType;
    } 
}

internal HL7V26Field messageControlID;

public HL7V26Field MessageControlID
{
    get
    {
        if (messageControlID != null)
        {
            return messageControlID;
        }

        messageControlID = new HL7V26Field
        {
            field = message[@"MSH"][10],
            Id = @"MSH.10",
            Type = @"Field",
            Position = @"MSH.10",
            Name = @"Message Control ID",
            Length = 199,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number or other identifier that uniquely identifies the message. The receiving system echoes this ID back to the sending system in the Message acknowledgment segment (MSA).",
            Sample = @"",
        };

        // check for repetitions
        if (messageControlID.field.FieldRepetitions != null && messageControlID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageControlID.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < messageControlID.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = messageControlID.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < messageControlID.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = messageControlID.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < messageControlID.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = messageControlID.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            messageControlID.fieldRepetitions = fieldRepetitions;
        }

        return messageControlID;
    } 
}

internal HL7V26Field processingID;

public HL7V26Field ProcessingID
{
    get
    {
        if (processingID != null)
        {
            return processingID;
        }

        processingID = new HL7V26Field
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
            Description = @"This field is used to decide whether to process the message as defined in HL7 Application (level 7) Processing rules.",
            Sample = @"",
        };

        // check for repetitions
        if (processingID.field.FieldRepetitions != null && processingID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(processingID.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < processingID.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = processingID.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < processingID.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = processingID.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < processingID.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = processingID.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            processingID.fieldRepetitions = fieldRepetitions;
        }

        return processingID;
    } 
}

internal HL7V26Field versionID;

public HL7V26Field VersionID
{
    get
    {
        if (versionID != null)
        {
            return versionID;
        }

        versionID = new HL7V26Field
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
            Description = @"This field is matched by the receiving system to its own version to be sure the message will be interpreted correctly. Beginning with Version 2.3.1, it has two additional ""internationalization"" components, for use by HL7 international affiliates. The <internationalization code> is CE data type (using the ISO country codes where appropriate) which represents the HL7 affiliate. The <internal version ID> is used if the HL7 Affiliate has more than a single 'local' version associated with a single US version. The <international version ID> has a CE data type, since the table values vary for each HL7 Affiliate.",
            Sample = @"",
        };

        // check for repetitions
        if (versionID.field.FieldRepetitions != null && versionID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(versionID.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < versionID.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = versionID.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < versionID.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = versionID.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < versionID.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = versionID.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            versionID.fieldRepetitions = fieldRepetitions;
        }

        return versionID;
    } 
}

internal HL7V26Field sequenceNumber;

public HL7V26Field SequenceNumber
{
    get
    {
        if (sequenceNumber != null)
        {
            return sequenceNumber;
        }

        sequenceNumber = new HL7V26Field
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

        // check for repetitions
        if (sequenceNumber.field.FieldRepetitions != null && sequenceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceNumber.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < sequenceNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = sequenceNumber.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < sequenceNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = sequenceNumber.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < sequenceNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = sequenceNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            sequenceNumber.fieldRepetitions = fieldRepetitions;
        }

        return sequenceNumber;
    } 
}

internal HL7V26Field continuationPointer;

public HL7V26Field ContinuationPointer
{
    get
    {
        if (continuationPointer != null)
        {
            return continuationPointer;
        }

        continuationPointer = new HL7V26Field
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
            Description = @"This field is used to define continuations in application-specific ways.

Only the sender of a fragmented message values this field.",
            Sample = @"",
        };

        // check for repetitions
        if (continuationPointer.field.FieldRepetitions != null && continuationPointer.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(continuationPointer.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < continuationPointer.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = continuationPointer.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < continuationPointer.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = continuationPointer.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < continuationPointer.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = continuationPointer.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            continuationPointer.fieldRepetitions = fieldRepetitions;
        }

        return continuationPointer;
    } 
}

internal HL7V26Field acceptAcknowledgmentType;

public HL7V26Field AcceptAcknowledgmentType
{
    get
    {
        if (acceptAcknowledgmentType != null)
        {
            return acceptAcknowledgmentType;
        }

        acceptAcknowledgmentType = new HL7V26Field
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
            Description = @"This field identifies the conditions under which accept acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode. Refer to HL7 Table 0155 - Accept/application acknowledgment conditions for valid values.

Note: If MSH-15-accept acknowledgment type and MSH-16-application acknowledgment type are omitted (or are both null), the original acknowledgment mode rules are used.",
            Sample = @"",
        };

        // check for repetitions
        if (acceptAcknowledgmentType.field.FieldRepetitions != null && acceptAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(acceptAcknowledgmentType.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < acceptAcknowledgmentType.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = acceptAcknowledgmentType.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < acceptAcknowledgmentType.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = acceptAcknowledgmentType.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < acceptAcknowledgmentType.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = acceptAcknowledgmentType.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            acceptAcknowledgmentType.fieldRepetitions = fieldRepetitions;
        }

        return acceptAcknowledgmentType;
    } 
}

internal HL7V26Field applicationAcknowledgmentType;

public HL7V26Field ApplicationAcknowledgmentType
{
    get
    {
        if (applicationAcknowledgmentType != null)
        {
            return applicationAcknowledgmentType;
        }

        applicationAcknowledgmentType = new HL7V26Field
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
            Description = @"This field contains the conditions under which application acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode. Refer to HL7 Table 0155 - Accept/application acknowledgment conditions for valid values.

Note: If MSH-15-accept acknowledgment type and MSH-16-application acknowledgment type are omitted (or are both null), the original acknowledgment mode rules are used.",
            Sample = @"",
        };

        // check for repetitions
        if (applicationAcknowledgmentType.field.FieldRepetitions != null && applicationAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(applicationAcknowledgmentType.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < applicationAcknowledgmentType.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = applicationAcknowledgmentType.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < applicationAcknowledgmentType.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = applicationAcknowledgmentType.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < applicationAcknowledgmentType.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = applicationAcknowledgmentType.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            applicationAcknowledgmentType.fieldRepetitions = fieldRepetitions;
        }

        return applicationAcknowledgmentType;
    } 
}

internal HL7V26Field countryCode;

public HL7V26Field CountryCode
{
    get
    {
        if (countryCode != null)
        {
            return countryCode;
        }

        countryCode = new HL7V26Field
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
            TableName = @"Country Code",
            Description = @"This field contains the country of origin for the message. It will be used primarily to specify default elements, such as currency denominations. The values to be used are those of ISO 3166,.[4]. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.

Refer to External Table 0399 - Country Code for the 3-character codes as defined by ISO 3166-1.",
            Sample = @"",
        };

        // check for repetitions
        if (countryCode.field.FieldRepetitions != null && countryCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(countryCode.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < countryCode.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = countryCode.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < countryCode.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = countryCode.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < countryCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = countryCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            countryCode.fieldRepetitions = fieldRepetitions;
        }

        return countryCode;
    } 
}

internal HL7V26Field characterSet;

public HL7V26Field CharacterSet
{
    get
    {
        if (characterSet != null)
        {
            return characterSet;
        }

        characterSet = new HL7V26Field
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

        // check for repetitions
        if (characterSet.field.FieldRepetitions != null && characterSet.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(characterSet.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < characterSet.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = characterSet.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < characterSet.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = characterSet.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < characterSet.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = characterSet.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            characterSet.fieldRepetitions = fieldRepetitions;
        }

        return characterSet;
    } 
}

internal HL7V26Field principalLanguageOfMessage;

public HL7V26Field PrincipalLanguageOfMessage
{
    get
    {
        if (principalLanguageOfMessage != null)
        {
            return principalLanguageOfMessage;
        }

        principalLanguageOfMessage = new HL7V26Field
        {
            field = message[@"MSH"][19],
            Id = @"MSH.19",
            Type = @"Field",
            Position = @"MSH.19",
            Name = @"Principal Language Of Message",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the principal language of the message. Codes come from ISO 639.",
            Sample = @"",
        };

        // check for repetitions
        if (principalLanguageOfMessage.field.FieldRepetitions != null && principalLanguageOfMessage.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(principalLanguageOfMessage.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < principalLanguageOfMessage.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = principalLanguageOfMessage.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < principalLanguageOfMessage.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = principalLanguageOfMessage.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < principalLanguageOfMessage.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = principalLanguageOfMessage.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            principalLanguageOfMessage.fieldRepetitions = fieldRepetitions;
        }

        return principalLanguageOfMessage;
    } 
}

internal HL7V26Field alternateCharacterSetHandlingScheme;

public HL7V26Field AlternateCharacterSetHandlingScheme
{
    get
    {
        if (alternateCharacterSetHandlingScheme != null)
        {
            return alternateCharacterSetHandlingScheme;
        }

        alternateCharacterSetHandlingScheme = new HL7V26Field
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
            Description = @"When any alternative character sets are used (as specified in the second or later iterations of MSH-18 character sets), and if any special handling scheme is needed, this component is to specify the scheme used, according to HL7 Table 0356- Alternate character set handling scheme as defined below:",
            Sample = @"",
        };

        // check for repetitions
        if (alternateCharacterSetHandlingScheme.field.FieldRepetitions != null && alternateCharacterSetHandlingScheme.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(alternateCharacterSetHandlingScheme.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < alternateCharacterSetHandlingScheme.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = alternateCharacterSetHandlingScheme.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < alternateCharacterSetHandlingScheme.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = alternateCharacterSetHandlingScheme.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < alternateCharacterSetHandlingScheme.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = alternateCharacterSetHandlingScheme.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            alternateCharacterSetHandlingScheme.fieldRepetitions = fieldRepetitions;
        }

        return alternateCharacterSetHandlingScheme;
    } 
}

internal HL7V26Field messageProfileIdentifier;

public HL7V26Field MessageProfileIdentifier
{
    get
    {
        if (messageProfileIdentifier != null)
        {
            return messageProfileIdentifier;
        }

        messageProfileIdentifier = new HL7V26Field
        {
            field = message[@"MSH"][21],
            Id = @"MSH.21",
            Type = @"Field",
            Position = @"MSH.21",
            Name = @"Message Profile Identifier",
            Length = 427,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Sites may use this field to assert adherence to, or reference, a message profile. Message profiles contain detailed explanations of grammar, syntax, and usage for a particular message or set of messages. See section 2B, ""Conformance Using Message Profiles"".",
            Sample = @"",
        };

        // check for repetitions
        if (messageProfileIdentifier.field.FieldRepetitions != null && messageProfileIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageProfileIdentifier.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < messageProfileIdentifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = messageProfileIdentifier.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < messageProfileIdentifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = messageProfileIdentifier.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < messageProfileIdentifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = messageProfileIdentifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            messageProfileIdentifier.fieldRepetitions = fieldRepetitions;
        }

        return messageProfileIdentifier;
    } 
}

internal HL7V26Field sendingResponsibleOrganization;

public HL7V26Field SendingResponsibleOrganization
{
    get
    {
        if (sendingResponsibleOrganization != null)
        {
            return sendingResponsibleOrganization;
        }

        sendingResponsibleOrganization = new HL7V26Field
        {
            field = message[@"MSH"][22],
            Id = @"MSH.22",
            Type = @"Field",
            Position = @"MSH.22",
            Name = @"Sending Responsible Organization",
            Length = 567,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
            TableId = null,
            TableName = null,
            Description = @"Business organization that originated and is accountable for the content of the message.",
            Sample = @"",
        };

        // check for repetitions
        if (sendingResponsibleOrganization.field.FieldRepetitions != null && sendingResponsibleOrganization.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sendingResponsibleOrganization.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < sendingResponsibleOrganization.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = sendingResponsibleOrganization.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < sendingResponsibleOrganization.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = sendingResponsibleOrganization.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < sendingResponsibleOrganization.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = sendingResponsibleOrganization.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            sendingResponsibleOrganization.fieldRepetitions = fieldRepetitions;
        }

        return sendingResponsibleOrganization;
    } 
}

internal HL7V26Field receivingResponsibleOrganization;

public HL7V26Field ReceivingResponsibleOrganization
{
    get
    {
        if (receivingResponsibleOrganization != null)
        {
            return receivingResponsibleOrganization;
        }

        receivingResponsibleOrganization = new HL7V26Field
        {
            field = message[@"MSH"][23],
            Id = @"MSH.23",
            Type = @"Field",
            Position = @"MSH.23",
            Name = @"Receiving Responsible Organization",
            Length = 567,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
            TableId = null,
            TableName = null,
            Description = @"Business organization that is the intended receiver of the message and is accountable for acting on the data conveyed by the transaction.",
            Sample = @"",
        };

        // check for repetitions
        if (receivingResponsibleOrganization.field.FieldRepetitions != null && receivingResponsibleOrganization.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(receivingResponsibleOrganization.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < receivingResponsibleOrganization.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = receivingResponsibleOrganization.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < receivingResponsibleOrganization.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = receivingResponsibleOrganization.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < receivingResponsibleOrganization.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = receivingResponsibleOrganization.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            receivingResponsibleOrganization.fieldRepetitions = fieldRepetitions;
        }

        return receivingResponsibleOrganization;
    } 
}

internal HL7V26Field sendingNetworkAddress;

public HL7V26Field SendingNetworkAddress
{
    get
    {
        if (sendingNetworkAddress != null)
        {
            return sendingNetworkAddress;
        }

        sendingNetworkAddress = new HL7V26Field
        {
            field = message[@"MSH"][24],
            Id = @"MSH.24",
            Type = @"Field",
            Position = @"MSH.24",
            Name = @"Sending Network Address",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"Identifier of the network location the message was transmitted from. Identified by an OID or text string (e.g., URI). The reader is referred to the ""Report from the Joint W3C/IETF URI Planning Interest Group: Uniform Resource Identifiers (URIs), URLs, and Uniform Resource Names (URNs): Clarifications and Recommendations"".[6]",
            Sample = @"",
        };

        // check for repetitions
        if (sendingNetworkAddress.field.FieldRepetitions != null && sendingNetworkAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sendingNetworkAddress.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < sendingNetworkAddress.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = sendingNetworkAddress.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < sendingNetworkAddress.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = sendingNetworkAddress.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < sendingNetworkAddress.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = sendingNetworkAddress.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            sendingNetworkAddress.fieldRepetitions = fieldRepetitions;
        }

        return sendingNetworkAddress;
    } 
}

internal HL7V26Field receivingNetworkAddress;

public HL7V26Field ReceivingNetworkAddress
{
    get
    {
        if (receivingNetworkAddress != null)
        {
            return receivingNetworkAddress;
        }

        receivingNetworkAddress = new HL7V26Field
        {
            field = message[@"MSH"][25],
            Id = @"MSH.25",
            Type = @"Field",
            Position = @"MSH.25",
            Name = @"Receiving Network Address",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"Identifier of the network location the message was transmitted to. Identified by an OID or text string (e.g., URL).",
            Sample = @"",
        };

        // check for repetitions
        if (receivingNetworkAddress.field.FieldRepetitions != null && receivingNetworkAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(receivingNetworkAddress.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < receivingNetworkAddress.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = receivingNetworkAddress.field.FieldRepetitions[i],
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
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < receivingNetworkAddress.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = receivingNetworkAddress.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < receivingNetworkAddress.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = receivingNetworkAddress.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            receivingNetworkAddress.fieldRepetitions = fieldRepetitions;
        }

        return receivingNetworkAddress;
    } 
}
    }
}
