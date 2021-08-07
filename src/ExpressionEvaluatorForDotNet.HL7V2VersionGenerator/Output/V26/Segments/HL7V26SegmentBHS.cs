using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentBHS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"BHS"; } }

        public string SegmentId { get { return @"BHS"; } }
        
        public string LongName { get { return @"Batch Header"; } }
        
        public string Description { get { return @"The BHS segment defines the start of a batch."; } }
        
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
                            Id = @"BHS.1",
                            Type = @"Field",
                            Position = @"BHS.1",
                            Name = @"Batch Field Separator",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the separator between the segment ID and the first real field, BHS-2-batch encoding characters. As such it serves as the separator and defines the character to be used as a separator for the rest of the message. Recommended value is | (ASCII 124).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.2",
                            Type = @"Field",
                            Position = @"BHS.2",
                            Name = @"Batch Encoding Characters",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the four characters in the following order: the component separator, repetition separator, escape characters, and subcomponent separator. Recommended values are ^~\& (ASCII 94, 126, 92, and 38, respectively).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.3",
                            Type = @"Field",
                            Position = @"BHS.3",
                            Name = @"Batch Sending Application",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"BHS.3.1",
                            Type = @"Component",
                            Position = @"BHS.3.1",
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
                            Id = @"BHS.3.2",
                            Type = @"Component",
                            Position = @"BHS.3.2",
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
                            Id = @"BHS.3.3",
                            Type = @"Component",
                            Position = @"BHS.3.3",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.4",
                            Type = @"Field",
                            Position = @"BHS.4",
                            Name = @"Batch Sending Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the address of one of several occurrences of the same application within the sending system. Absent other considerations, the Medicare Provider ID might be used with an appropriate sub-identifier in the second component. Entirely site-defined.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"BHS.4.1",
                            Type = @"Component",
                            Position = @"BHS.4.1",
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
                            Id = @"BHS.4.2",
                            Type = @"Component",
                            Position = @"BHS.4.2",
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
                            Id = @"BHS.4.3",
                            Type = @"Component",
                            Position = @"BHS.4.3",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.5",
                            Type = @"Field",
                            Position = @"BHS.5",
                            Name = @"Batch Receiving Application",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This field uniquely identifies the receiving applications among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"BHS.5.1",
                            Type = @"Component",
                            Position = @"BHS.5.1",
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
                            Id = @"BHS.5.2",
                            Type = @"Component",
                            Position = @"BHS.5.2",
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
                            Id = @"BHS.5.3",
                            Type = @"Component",
                            Position = @"BHS.5.3",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.6",
                            Type = @"Field",
                            Position = @"BHS.6",
                            Name = @"Batch Receiving Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations. See comments BHS-4-batch sending facility. Entirely site-defined.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"BHS.6.1",
                            Type = @"Component",
                            Position = @"BHS.6.1",
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
                            Id = @"BHS.6.2",
                            Type = @"Component",
                            Position = @"BHS.6.2",
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
                            Id = @"BHS.6.3",
                            Type = @"Component",
                            Position = @"BHS.6.3",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.7",
                            Type = @"Field",
                            Position = @"BHS.7",
                            Name = @"Batch Creation Date/Time",
                            Length = 24,
                            Usage = @"O",
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
                            Id = @"BHS.8",
                            Type = @"Field",
                            Position = @"BHS.8",
                            Name = @"Batch Security",
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
                            Id = @"BHS.9",
                            Type = @"Field",
                            Position = @"BHS.9",
                            Name = @"Batch Name/ID/Type",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field can be used by the application processing the batch. It can have extra components if needed. 

Note: the text regarding ""extra components"" has been retained for backward compatibility, but it is not currently an accepted format for the ST data type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.10",
                            Type = @"Field",
                            Position = @"BHS.10",
                            Name = @"Batch Comment",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a comment field that is not further defined in the HL7 protocol.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.11",
                            Type = @"Field",
                            Position = @"BHS.11",
                            Name = @"Batch Control ID",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to uniquely identify a particular batch. It can be echoed back in BHS-12-reference batch control ID if an answering batch is needed. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.12",
                            Type = @"Field",
                            Position = @"BHS.12",
                            Name = @"Reference Batch Control ID",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the value of BHS-11-batch control ID when this batch was originally transmitted. Not present if this batch is being sent for the first time. See definition for BHS-11-batch control ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.13",
                            Type = @"Field",
                            Position = @"BHS.13",
                            Name = @"Batch Sending Network Address",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifier of the network location the message was transmitted from.  Identified by an OID or text string (e.g., URI). The reader is referred to the ""Report from the Joint W3C/IETF URI Planning Interest Group: Uniform Resource Identifiers (URIs), URLs, and Uniform Resource Names (URNs): Clarifications and Recommendations"". 

As with the Sending/Receiving Responsible Organization, the Sending Network Address provides a more detailed picture of the source of the message.  This information is lower than the application layer, but is often useful/necessary for routing and identification purposes. This field should only be populated when the underlying communication protocol does not support identification of sending network locations. 

The specific values and usage must be site negotiated.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"BHS.13.1",
                            Type = @"Component",
                            Position = @"BHS.13.1",
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
                            Id = @"BHS.13.2",
                            Type = @"Component",
                            Position = @"BHS.13.2",
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
                            Id = @"BHS.13.3",
                            Type = @"Component",
                            Position = @"BHS.13.3",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.14",
                            Type = @"Field",
                            Position = @"BHS.14",
                            Name = @"Batch Receiving Network Address",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifier of the network location the message was transmitted to.  Identified by an OID or text string. (e.g., URL).

This is analogous with the Sending Network Address, however in the receiving role.

This field should only be populated when the underlying communication protocol does not support identification receiving network locations.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"BHS.14.1",
                            Type = @"Component",
                            Position = @"BHS.14.1",
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
                            Id = @"BHS.14.2",
                            Type = @"Component",
                            Position = @"BHS.14.2",
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
                            Id = @"BHS.14.3",
                            Type = @"Component",
                            Position = @"BHS.14.3",
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
                        },
                        
                        },
                        };
            }
        }

        public HL7V26SegmentBHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field batchFieldSeparator;

public HL7V26Field BatchFieldSeparator
{
    get
    {
        if (batchFieldSeparator != null)
        {
            return batchFieldSeparator;
        }

        batchFieldSeparator = new HL7V26Field
        {
            field = message[@"BHS"][1],
            Id = @"BHS.1",
            Type = @"Field",
            Position = @"BHS.1",
            Name = @"Batch Field Separator",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the separator between the segment ID and the first real field, BHS-2-batch encoding characters. As such it serves as the separator and defines the character to be used as a separator for the rest of the message. Recommended value is | (ASCII 124).",
            Sample = @"",
        };

        

        

        

        return batchFieldSeparator;
    } 
}
internal HL7V26Field batchEncodingCharacters;

public HL7V26Field BatchEncodingCharacters
{
    get
    {
        if (batchEncodingCharacters != null)
        {
            return batchEncodingCharacters;
        }

        batchEncodingCharacters = new HL7V26Field
        {
            field = message[@"BHS"][2],
            Id = @"BHS.2",
            Type = @"Field",
            Position = @"BHS.2",
            Name = @"Batch Encoding Characters",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the four characters in the following order: the component separator, repetition separator, escape characters, and subcomponent separator. Recommended values are ^~\& (ASCII 94, 126, 92, and 38, respectively).",
            Sample = @"",
        };

        

        

        

        return batchEncodingCharacters;
    } 
}
internal HL7V26Field batchSendingApplication;

public HL7V26Field BatchSendingApplication
{
    get
    {
        if (batchSendingApplication != null)
        {
            return batchSendingApplication;
        }

        batchSendingApplication = new HL7V26Field
        {
            field = message[@"BHS"][3],
            Id = @"BHS.3",
            Type = @"Field",
            Position = @"BHS.3",
            Name = @"Batch Sending Application",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined.",
            Sample = @"",
        };

        

        

        

        return batchSendingApplication;
    } 
}
internal HL7V26Field batchSendingFacility;

public HL7V26Field BatchSendingFacility
{
    get
    {
        if (batchSendingFacility != null)
        {
            return batchSendingFacility;
        }

        batchSendingFacility = new HL7V26Field
        {
            field = message[@"BHS"][4],
            Id = @"BHS.4",
            Type = @"Field",
            Position = @"BHS.4",
            Name = @"Batch Sending Facility",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of one of several occurrences of the same application within the sending system. Absent other considerations, the Medicare Provider ID might be used with an appropriate sub-identifier in the second component. Entirely site-defined.",
            Sample = @"",
        };

        

        

        

        return batchSendingFacility;
    } 
}
internal HL7V26Field batchReceivingApplication;

public HL7V26Field BatchReceivingApplication
{
    get
    {
        if (batchReceivingApplication != null)
        {
            return batchReceivingApplication;
        }

        batchReceivingApplication = new HL7V26Field
        {
            field = message[@"BHS"][5],
            Id = @"BHS.5",
            Type = @"Field",
            Position = @"BHS.5",
            Name = @"Batch Receiving Application",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the receiving applications among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined.",
            Sample = @"",
        };

        

        

        

        return batchReceivingApplication;
    } 
}
internal HL7V26Field batchReceivingFacility;

public HL7V26Field BatchReceivingFacility
{
    get
    {
        if (batchReceivingFacility != null)
        {
            return batchReceivingFacility;
        }

        batchReceivingFacility = new HL7V26Field
        {
            field = message[@"BHS"][6],
            Id = @"BHS.6",
            Type = @"Field",
            Position = @"BHS.6",
            Name = @"Batch Receiving Facility",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations. See comments BHS-4-batch sending facility. Entirely site-defined.",
            Sample = @"",
        };

        

        

        

        return batchReceivingFacility;
    } 
}
internal HL7V26Field batchCreationDateTime;

public HL7V26Field BatchCreationDateTime
{
    get
    {
        if (batchCreationDateTime != null)
        {
            return batchCreationDateTime;
        }

        batchCreationDateTime = new HL7V26Field
        {
            field = message[@"BHS"][7],
            Id = @"BHS.7",
            Type = @"Field",
            Position = @"BHS.7",
            Name = @"Batch Creation Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the sending system created the message. If the time zone is specified, it will be used throughout the message as the default time zone.",
            Sample = @"",
        };

        

        

        

        return batchCreationDateTime;
    } 
}
internal HL7V26Field batchSecurity;

public HL7V26Field BatchSecurity
{
    get
    {
        if (batchSecurity != null)
        {
            return batchSecurity;
        }

        batchSecurity = new HL7V26Field
        {
            field = message[@"BHS"][8],
            Id = @"BHS.8",
            Type = @"Field",
            Position = @"BHS.8",
            Name = @"Batch Security",
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

        

        

        

        return batchSecurity;
    } 
}
internal HL7V26Field batchNameIDType;

public HL7V26Field BatchNameIDType
{
    get
    {
        if (batchNameIDType != null)
        {
            return batchNameIDType;
        }

        batchNameIDType = new HL7V26Field
        {
            field = message[@"BHS"][9],
            Id = @"BHS.9",
            Type = @"Field",
            Position = @"BHS.9",
            Name = @"Batch Name/ID/Type",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field can be used by the application processing the batch. It can have extra components if needed. 

Note: the text regarding ""extra components"" has been retained for backward compatibility, but it is not currently an accepted format for the ST data type.",
            Sample = @"",
        };

        

        

        

        return batchNameIDType;
    } 
}
internal HL7V26Field batchComment;

public HL7V26Field BatchComment
{
    get
    {
        if (batchComment != null)
        {
            return batchComment;
        }

        batchComment = new HL7V26Field
        {
            field = message[@"BHS"][10],
            Id = @"BHS.10",
            Type = @"Field",
            Position = @"BHS.10",
            Name = @"Batch Comment",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is a comment field that is not further defined in the HL7 protocol.",
            Sample = @"",
        };

        

        

        

        return batchComment;
    } 
}
internal HL7V26Field batchControlID;

public HL7V26Field BatchControlID
{
    get
    {
        if (batchControlID != null)
        {
            return batchControlID;
        }

        batchControlID = new HL7V26Field
        {
            field = message[@"BHS"][11],
            Id = @"BHS.11",
            Type = @"Field",
            Position = @"BHS.11",
            Name = @"Batch Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to uniquely identify a particular batch. It can be echoed back in BHS-12-reference batch control ID if an answering batch is needed. ",
            Sample = @"",
        };

        

        

        

        return batchControlID;
    } 
}
internal HL7V26Field referenceBatchControlID;

public HL7V26Field ReferenceBatchControlID
{
    get
    {
        if (referenceBatchControlID != null)
        {
            return referenceBatchControlID;
        }

        referenceBatchControlID = new HL7V26Field
        {
            field = message[@"BHS"][12],
            Id = @"BHS.12",
            Type = @"Field",
            Position = @"BHS.12",
            Name = @"Reference Batch Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the value of BHS-11-batch control ID when this batch was originally transmitted. Not present if this batch is being sent for the first time. See definition for BHS-11-batch control ID.",
            Sample = @"",
        };

        

        

        

        return referenceBatchControlID;
    } 
}
internal HL7V26Field batchSendingNetworkAddress;

public HL7V26Field BatchSendingNetworkAddress
{
    get
    {
        if (batchSendingNetworkAddress != null)
        {
            return batchSendingNetworkAddress;
        }

        batchSendingNetworkAddress = new HL7V26Field
        {
            field = message[@"BHS"][13],
            Id = @"BHS.13",
            Type = @"Field",
            Position = @"BHS.13",
            Name = @"Batch Sending Network Address",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"Identifier of the network location the message was transmitted from.  Identified by an OID or text string (e.g., URI). The reader is referred to the ""Report from the Joint W3C/IETF URI Planning Interest Group: Uniform Resource Identifiers (URIs), URLs, and Uniform Resource Names (URNs): Clarifications and Recommendations"". 

As with the Sending/Receiving Responsible Organization, the Sending Network Address provides a more detailed picture of the source of the message.  This information is lower than the application layer, but is often useful/necessary for routing and identification purposes. This field should only be populated when the underlying communication protocol does not support identification of sending network locations. 

The specific values and usage must be site negotiated.",
            Sample = @"",
        };

        

        

        

        return batchSendingNetworkAddress;
    } 
}
internal HL7V26Field batchReceivingNetworkAddress;

public HL7V26Field BatchReceivingNetworkAddress
{
    get
    {
        if (batchReceivingNetworkAddress != null)
        {
            return batchReceivingNetworkAddress;
        }

        batchReceivingNetworkAddress = new HL7V26Field
        {
            field = message[@"BHS"][14],
            Id = @"BHS.14",
            Type = @"Field",
            Position = @"BHS.14",
            Name = @"Batch Receiving Network Address",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"Identifier of the network location the message was transmitted to.  Identified by an OID or text string. (e.g., URL).

This is analogous with the Sending Network Address, however in the receiving role.

This field should only be populated when the underlying communication protocol does not support identification receiving network locations.",
            Sample = @"",
        };

        

        

        

        return batchReceivingNetworkAddress;
    } 
}

    }
}
