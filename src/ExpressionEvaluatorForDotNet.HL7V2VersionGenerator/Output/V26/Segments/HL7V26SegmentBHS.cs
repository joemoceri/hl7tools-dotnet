using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentBHS
    {
        public HL7V2Message message { get; init; }

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

        public HL7V26SegmentBHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _batchFieldSeparator;

public HL7V26Field BatchFieldSeparator
{
    get
    {
        if (_batchFieldSeparator != null)
        {
            return _batchFieldSeparator;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _batchFieldSeparator = new HL7V26Field
        {
            field = message[@"BHS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchFieldSeparator.field.FieldRepetitions != null && _batchFieldSeparator.field.FieldRepetitions.Count > 0)
        {
            _batchFieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchFieldSeparator, fieldData);
        }

        return _batchFieldSeparator;
    } 
}

internal HL7V26Field _batchEncodingCharacters;

public HL7V26Field BatchEncodingCharacters
{
    get
    {
        if (_batchEncodingCharacters != null)
        {
            return _batchEncodingCharacters;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _batchEncodingCharacters = new HL7V26Field
        {
            field = message[@"BHS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchEncodingCharacters.field.FieldRepetitions != null && _batchEncodingCharacters.field.FieldRepetitions.Count > 0)
        {
            _batchEncodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchEncodingCharacters, fieldData);
        }

        return _batchEncodingCharacters;
    } 
}

internal HL7V26Field _batchSendingApplication;

public HL7V26Field BatchSendingApplication
{
    get
    {
        if (_batchSendingApplication != null)
        {
            return _batchSendingApplication;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = new[]
                        {
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
                        }
        }

        _batchSendingApplication = new HL7V26Field
        {
            field = message[@"BHS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchSendingApplication.field.FieldRepetitions != null && _batchSendingApplication.field.FieldRepetitions.Count > 0)
        {
            _batchSendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchSendingApplication, fieldData);
        }

        return _batchSendingApplication;
    } 
}

internal HL7V26Field _batchSendingFacility;

public HL7V26Field BatchSendingFacility
{
    get
    {
        if (_batchSendingFacility != null)
        {
            return _batchSendingFacility;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = new[]
                        {
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
                        }
        }

        _batchSendingFacility = new HL7V26Field
        {
            field = message[@"BHS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchSendingFacility.field.FieldRepetitions != null && _batchSendingFacility.field.FieldRepetitions.Count > 0)
        {
            _batchSendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchSendingFacility, fieldData);
        }

        return _batchSendingFacility;
    } 
}

internal HL7V26Field _batchReceivingApplication;

public HL7V26Field BatchReceivingApplication
{
    get
    {
        if (_batchReceivingApplication != null)
        {
            return _batchReceivingApplication;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = new[]
                        {
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
                        }
        }

        _batchReceivingApplication = new HL7V26Field
        {
            field = message[@"BHS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchReceivingApplication.field.FieldRepetitions != null && _batchReceivingApplication.field.FieldRepetitions.Count > 0)
        {
            _batchReceivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchReceivingApplication, fieldData);
        }

        return _batchReceivingApplication;
    } 
}

internal HL7V26Field _batchReceivingFacility;

public HL7V26Field BatchReceivingFacility
{
    get
    {
        if (_batchReceivingFacility != null)
        {
            return _batchReceivingFacility;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = new[]
                        {
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
                        }
        }

        _batchReceivingFacility = new HL7V26Field
        {
            field = message[@"BHS"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchReceivingFacility.field.FieldRepetitions != null && _batchReceivingFacility.field.FieldRepetitions.Count > 0)
        {
            _batchReceivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchReceivingFacility, fieldData);
        }

        return _batchReceivingFacility;
    } 
}

internal HL7V26Field _batchCreationDateTime;

public HL7V26Field BatchCreationDateTime
{
    get
    {
        if (_batchCreationDateTime != null)
        {
            return _batchCreationDateTime;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _batchCreationDateTime = new HL7V26Field
        {
            field = message[@"BHS"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchCreationDateTime.field.FieldRepetitions != null && _batchCreationDateTime.field.FieldRepetitions.Count > 0)
        {
            _batchCreationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchCreationDateTime, fieldData);
        }

        return _batchCreationDateTime;
    } 
}

internal HL7V26Field _batchSecurity;

public HL7V26Field BatchSecurity
{
    get
    {
        if (_batchSecurity != null)
        {
            return _batchSecurity;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _batchSecurity = new HL7V26Field
        {
            field = message[@"BHS"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchSecurity.field.FieldRepetitions != null && _batchSecurity.field.FieldRepetitions.Count > 0)
        {
            _batchSecurity.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchSecurity, fieldData);
        }

        return _batchSecurity;
    } 
}

internal HL7V26Field _batchNameIDType;

public HL7V26Field BatchNameIDType
{
    get
    {
        if (_batchNameIDType != null)
        {
            return _batchNameIDType;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _batchNameIDType = new HL7V26Field
        {
            field = message[@"BHS"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchNameIDType.field.FieldRepetitions != null && _batchNameIDType.field.FieldRepetitions.Count > 0)
        {
            _batchNameIDType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchNameIDType, fieldData);
        }

        return _batchNameIDType;
    } 
}

internal HL7V26Field _batchComment;

public HL7V26Field BatchComment
{
    get
    {
        if (_batchComment != null)
        {
            return _batchComment;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _batchComment = new HL7V26Field
        {
            field = message[@"BHS"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchComment.field.FieldRepetitions != null && _batchComment.field.FieldRepetitions.Count > 0)
        {
            _batchComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchComment, fieldData);
        }

        return _batchComment;
    } 
}

internal HL7V26Field _batchControlID;

public HL7V26Field BatchControlID
{
    get
    {
        if (_batchControlID != null)
        {
            return _batchControlID;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _batchControlID = new HL7V26Field
        {
            field = message[@"BHS"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchControlID.field.FieldRepetitions != null && _batchControlID.field.FieldRepetitions.Count > 0)
        {
            _batchControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchControlID, fieldData);
        }

        return _batchControlID;
    } 
}

internal HL7V26Field _referenceBatchControlID;

public HL7V26Field ReferenceBatchControlID
{
    get
    {
        if (_referenceBatchControlID != null)
        {
            return _referenceBatchControlID;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _referenceBatchControlID = new HL7V26Field
        {
            field = message[@"BHS"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referenceBatchControlID.field.FieldRepetitions != null && _referenceBatchControlID.field.FieldRepetitions.Count > 0)
        {
            _referenceBatchControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_referenceBatchControlID, fieldData);
        }

        return _referenceBatchControlID;
    } 
}

internal HL7V26Field _batchSendingNetworkAddress;

public HL7V26Field BatchSendingNetworkAddress
{
    get
    {
        if (_batchSendingNetworkAddress != null)
        {
            return _batchSendingNetworkAddress;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = new[]
                        {
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
                        }
        }

        _batchSendingNetworkAddress = new HL7V26Field
        {
            field = message[@"BHS"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchSendingNetworkAddress.field.FieldRepetitions != null && _batchSendingNetworkAddress.field.FieldRepetitions.Count > 0)
        {
            _batchSendingNetworkAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchSendingNetworkAddress, fieldData);
        }

        return _batchSendingNetworkAddress;
    } 
}

internal HL7V26Field _batchReceivingNetworkAddress;

public HL7V26Field BatchReceivingNetworkAddress
{
    get
    {
        if (_batchReceivingNetworkAddress != null)
        {
            return _batchReceivingNetworkAddress;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = new[]
                        {
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
                        }
        }

        _batchReceivingNetworkAddress = new HL7V26Field
        {
            field = message[@"BHS"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchReceivingNetworkAddress.field.FieldRepetitions != null && _batchReceivingNetworkAddress.field.FieldRepetitions.Count > 0)
        {
            _batchReceivingNetworkAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_batchReceivingNetworkAddress, fieldData);
        }

        return _batchReceivingNetworkAddress;
    } 
}
    }
}
