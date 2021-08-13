using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentERQ
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ERQ"; } }

        public string SegmentId { get { return @"ERQ"; } }
        
        public string LongName { get { return @"Event replay query"; } }
        
        public string Description { get { return @"The ERQ segment is used to issue queries where the desired response is formatted as an event replay response message.  This enables the querying application to request detailed event data from an application that supports this feature, such that it may no longer be necessary for it to capture and store all event information at the time of the original trigger event. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V26SegmentERQ(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _queryTag;

public HL7V26Field QueryTag
{
    get
    {
        if (_queryTag != null)
        {
            return _queryTag;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ERQ.1",
            Type = @"Field",
            Position = @"ERQ.1",
            Name = @"Query Tag",
            Length = 32,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2Message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole. ",
            Sample = @"",
            Fields = null
        }

        _queryTag = new HL7V26Field
        {
            field = message[@"ERQ"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryTag.field.FieldRepetitions != null && _queryTag.field.FieldRepetitions.Count > 0)
        {
            _queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_queryTag, fieldData);
        }

        return _queryTag;
    } 
}

internal HL7V26Field _eventIdentifier;

public HL7V26Field EventIdentifier
{
    get
    {
        if (_eventIdentifier != null)
        {
            return _eventIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ERQ.2",
            Type = @"Field",
            Position = @"ERQ.2",
            Name = @"Event Identifier",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the HL7 event identifier corresponding to the original trigger event.  Its contents dictate the format of the response message.  Hence, a value of “A04” in this field indicates a request for the data associated with the “register a patient” trigger event.  The ERP response message returns the contents of the “register a patient” message defined in Chapter 3.  If more than one match is found, the ERP returns repeating groups of the segments defined by the “A04” message",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERQ.2.1",
                            Type = @"Component",
                            Position = @"ERQ.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"ERQ.2.2",
                            Type = @"Component",
                            Position = @"ERQ.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"ERQ.2.3",
                            Type = @"Component",
                            Position = @"ERQ.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERQ.2.4",
                            Type = @"Component",
                            Position = @"ERQ.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"ERQ.2.5",
                            Type = @"Component",
                            Position = @"ERQ.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"ERQ.2.6",
                            Type = @"Component",
                            Position = @"ERQ.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _eventIdentifier = new HL7V26Field
        {
            field = message[@"ERQ"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventIdentifier.field.FieldRepetitions != null && _eventIdentifier.field.FieldRepetitions.Count > 0)
        {
            _eventIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_eventIdentifier, fieldData);
        }

        return _eventIdentifier;
    } 
}

internal HL7V26Field _inputParameterList;

public HL7V26Field InputParameterList
{
    get
    {
        if (_inputParameterList != null)
        {
            return _inputParameterList;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ERQ.3",
            Type = @"Field",
            Position = @"ERQ.3",
            Name = @"Input Parameter List",
            Length = 256,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"QIP",
            DataTypeName = @"Query Input Parameter List",
            TableId = null,
            TableName = null,
            Description = @"This field contains the list of parameter names and values to be passed to the responding system, in the form “<segment field name> ^ <value1 & value2 & value3 ...>.”  A single valued parameter contains only a single subcomponent in the second component: thus no subcomponent delimiters are needed (e.g., <segment field name> ^ <value>).  A simple list of values (i.e., a onedimensional array) may be passed instead of a single value by separating each value with the subcomponent delimiter: “<segment field name> ^ <value1&value2 &...>.”  Refer to Section 5.10.5.1.5, “EQL-4   EQL Query Statement   (ST)   00710,” for segment field name definition conventions. For example, a value of “@PID.19^123-45-6789” could be combined with the A04 event identifier to request patient registration data for the patient with the social security number 123-45-6789.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERQ.3.1",
                            Type = @"Component",
                            Position = @"ERQ.3.1",
                            Name = @"Segment Field Name",
                            Length = 12,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the segment field name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERQ.3.2",
                            Type = @"Component",
                            Position = @"ERQ.3.2",
                            Name = @"Values",
                            Length = 199,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the field value or values in the form ""value1& value2 & value3...""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _inputParameterList = new HL7V26Field
        {
            field = message[@"ERQ"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inputParameterList.field.FieldRepetitions != null && _inputParameterList.field.FieldRepetitions.Count > 0)
        {
            _inputParameterList.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_inputParameterList, fieldData);
        }

        return _inputParameterList;
    } 
}
    }
}
