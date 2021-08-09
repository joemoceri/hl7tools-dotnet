using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentBHS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"BHS"; } }

        public string SegmentId { get { return @"BHS"; } }
        
        public string LongName { get { return @"Batch Header Segment"; } }
        
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
                            Description = @"This field contains the separator between the segment ID and the first real field, BHS-2-batch encoding characters. As such it serves as the separator and defines the character to be used as a separator for the rest of the message. Recommended value is |,(ASCII 124). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.2",
                            Type = @"Field",
                            Position = @"BHS.2",
                            Name = @"Batch Encoding Characters",
                            Length = 3,
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
                            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Length = 199,
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
                        },}
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
                            Description = @"This field contains the address of one of several occurrences of the same application within the sending system. Absent other considerations, the Medicare Provider ID might be used with an appropriate sub-identifier in the second component. Entirely site-defined. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Length = 199,
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
                        },}
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
                            Description = @"This field uniquely identifies the receiving applications among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Length = 199,
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.6",
                            Type = @"Field",
                            Position = @"BHS.6",
                            Name = @"Batch Receiving Facility ",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations. See comments BHS-4-batch sending facility. Entirely site-defined. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Length = 199,
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.7",
                            Type = @"Field",
                            Position = @"BHS.7",
                            Name = @"Batch Creation Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the sending system created the message. If the time zone is specified, it will be used throughout the message as the default time zone. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"BHS.7.1",
                            Type = @"Component",
                            Position = @"BHS.7.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.7.2",
                            Type = @"Component",
                            Position = @"BHS.7.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision.

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
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

Note: the text regarding ""extra components"" has been retained for backward compatibility, but it is not currently an accepted format for the ST data type",
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
                            Description = @"This field is a comment field that is not further defined in the HL7 protocol. ",
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
                            Description = @"This field is used to uniquely identify a particular batch. It can be echoed back in BHS-12reference batch control ID if an answering batch is needed.  ",
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
                            Description = @"This field contains the value of BHS-11-batch control ID when this batch was originally transmitted. Not present if this batch is being sent for the first time. See definition for BHS-11-batch control ID. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V25SegmentBHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field batchFieldSeparator;

public HL7V25Field BatchFieldSeparator
{
    get
    {
        if (batchFieldSeparator != null)
        {
            return batchFieldSeparator;
        }

        batchFieldSeparator = new HL7V25Field
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
            Description = @"This field contains the separator between the segment ID and the first real field, BHS-2-batch encoding characters. As such it serves as the separator and defines the character to be used as a separator for the rest of the message. Recommended value is |,(ASCII 124). ",
            Sample = @"",
        };

        // check for repetitions
        if (batchFieldSeparator.field.FieldRepetitions != null && batchFieldSeparator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchFieldSeparator.Id));
            batchFieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(batchFieldSeparator, fieldData);
        }

        return batchFieldSeparator;
    } 
}

internal HL7V25Field batchEncodingCharacters;

public HL7V25Field BatchEncodingCharacters
{
    get
    {
        if (batchEncodingCharacters != null)
        {
            return batchEncodingCharacters;
        }

        batchEncodingCharacters = new HL7V25Field
        {
            field = message[@"BHS"][2],
            Id = @"BHS.2",
            Type = @"Field",
            Position = @"BHS.2",
            Name = @"Batch Encoding Characters",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the four characters in the following order: the component separator, repetition separator, escape characters, and subcomponent separator. Recommended values are ^~\& (ASCII 94, 126, 92, and 38, respectively).",
            Sample = @"",
        };

        // check for repetitions
        if (batchEncodingCharacters.field.FieldRepetitions != null && batchEncodingCharacters.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchEncodingCharacters.Id));
            batchEncodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(batchEncodingCharacters, fieldData);
        }

        return batchEncodingCharacters;
    } 
}

internal HL7V25Field batchSendingApplication;

public HL7V25Field BatchSendingApplication
{
    get
    {
        if (batchSendingApplication != null)
        {
            return batchSendingApplication;
        }

        batchSendingApplication = new HL7V25Field
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
            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined. ",
            Sample = @"",
        };

        // check for repetitions
        if (batchSendingApplication.field.FieldRepetitions != null && batchSendingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchSendingApplication.Id));
            batchSendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(batchSendingApplication, fieldData);
        }

        return batchSendingApplication;
    } 
}

internal HL7V25Field batchSendingFacility;

public HL7V25Field BatchSendingFacility
{
    get
    {
        if (batchSendingFacility != null)
        {
            return batchSendingFacility;
        }

        batchSendingFacility = new HL7V25Field
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
            Description = @"This field contains the address of one of several occurrences of the same application within the sending system. Absent other considerations, the Medicare Provider ID might be used with an appropriate sub-identifier in the second component. Entirely site-defined. ",
            Sample = @"",
        };

        // check for repetitions
        if (batchSendingFacility.field.FieldRepetitions != null && batchSendingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchSendingFacility.Id));
            batchSendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(batchSendingFacility, fieldData);
        }

        return batchSendingFacility;
    } 
}

internal HL7V25Field batchReceivingApplication;

public HL7V25Field BatchReceivingApplication
{
    get
    {
        if (batchReceivingApplication != null)
        {
            return batchReceivingApplication;
        }

        batchReceivingApplication = new HL7V25Field
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
            Description = @"This field uniquely identifies the receiving applications among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined. ",
            Sample = @"",
        };

        // check for repetitions
        if (batchReceivingApplication.field.FieldRepetitions != null && batchReceivingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchReceivingApplication.Id));
            batchReceivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(batchReceivingApplication, fieldData);
        }

        return batchReceivingApplication;
    } 
}

internal HL7V25Field batchReceivingFacility;

public HL7V25Field BatchReceivingFacility
{
    get
    {
        if (batchReceivingFacility != null)
        {
            return batchReceivingFacility;
        }

        batchReceivingFacility = new HL7V25Field
        {
            field = message[@"BHS"][6],
            Id = @"BHS.6",
            Type = @"Field",
            Position = @"BHS.6",
            Name = @"Batch Receiving Facility ",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations. See comments BHS-4-batch sending facility. Entirely site-defined. ",
            Sample = @"",
        };

        // check for repetitions
        if (batchReceivingFacility.field.FieldRepetitions != null && batchReceivingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchReceivingFacility.Id));
            batchReceivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(batchReceivingFacility, fieldData);
        }

        return batchReceivingFacility;
    } 
}

internal HL7V25Field batchCreationDateTime;

public HL7V25Field BatchCreationDateTime
{
    get
    {
        if (batchCreationDateTime != null)
        {
            return batchCreationDateTime;
        }

        batchCreationDateTime = new HL7V25Field
        {
            field = message[@"BHS"][7],
            Id = @"BHS.7",
            Type = @"Field",
            Position = @"BHS.7",
            Name = @"Batch Creation Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the sending system created the message. If the time zone is specified, it will be used throughout the message as the default time zone. ",
            Sample = @"",
        };

        // check for repetitions
        if (batchCreationDateTime.field.FieldRepetitions != null && batchCreationDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchCreationDateTime.Id));
            batchCreationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(batchCreationDateTime, fieldData);
        }

        return batchCreationDateTime;
    } 
}

internal HL7V25Field batchSecurity;

public HL7V25Field BatchSecurity
{
    get
    {
        if (batchSecurity != null)
        {
            return batchSecurity;
        }

        batchSecurity = new HL7V25Field
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

        // check for repetitions
        if (batchSecurity.field.FieldRepetitions != null && batchSecurity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchSecurity.Id));
            batchSecurity.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(batchSecurity, fieldData);
        }

        return batchSecurity;
    } 
}

internal HL7V25Field batchNameIDType;

public HL7V25Field BatchNameIDType
{
    get
    {
        if (batchNameIDType != null)
        {
            return batchNameIDType;
        }

        batchNameIDType = new HL7V25Field
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

Note: the text regarding ""extra components"" has been retained for backward compatibility, but it is not currently an accepted format for the ST data type",
            Sample = @"",
        };

        // check for repetitions
        if (batchNameIDType.field.FieldRepetitions != null && batchNameIDType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchNameIDType.Id));
            batchNameIDType.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(batchNameIDType, fieldData);
        }

        return batchNameIDType;
    } 
}

internal HL7V25Field batchComment;

public HL7V25Field BatchComment
{
    get
    {
        if (batchComment != null)
        {
            return batchComment;
        }

        batchComment = new HL7V25Field
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
            Description = @"This field is a comment field that is not further defined in the HL7 protocol. ",
            Sample = @"",
        };

        // check for repetitions
        if (batchComment.field.FieldRepetitions != null && batchComment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchComment.Id));
            batchComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(batchComment, fieldData);
        }

        return batchComment;
    } 
}

internal HL7V25Field batchControlID;

public HL7V25Field BatchControlID
{
    get
    {
        if (batchControlID != null)
        {
            return batchControlID;
        }

        batchControlID = new HL7V25Field
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
            Description = @"This field is used to uniquely identify a particular batch. It can be echoed back in BHS-12reference batch control ID if an answering batch is needed.  ",
            Sample = @"",
        };

        // check for repetitions
        if (batchControlID.field.FieldRepetitions != null && batchControlID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchControlID.Id));
            batchControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(batchControlID, fieldData);
        }

        return batchControlID;
    } 
}

internal HL7V25Field referenceBatchControlID;

public HL7V25Field ReferenceBatchControlID
{
    get
    {
        if (referenceBatchControlID != null)
        {
            return referenceBatchControlID;
        }

        referenceBatchControlID = new HL7V25Field
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
            Description = @"This field contains the value of BHS-11-batch control ID when this batch was originally transmitted. Not present if this batch is being sent for the first time. See definition for BHS-11-batch control ID. ",
            Sample = @"",
        };

        // check for repetitions
        if (referenceBatchControlID.field.FieldRepetitions != null && referenceBatchControlID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referenceBatchControlID.Id));
            referenceBatchControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(referenceBatchControlID, fieldData);
        }

        return referenceBatchControlID;
    } 
}
    }
}
