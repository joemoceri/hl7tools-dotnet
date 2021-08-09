using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentERQ
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ERQ"; } }

        public string SegmentId { get { return @"ERQ"; } }
        
        public string LongName { get { return @"Event replay query"; } }
        
        public string Description { get { return @"This segment is not carried forward to the recommended queries for v 2.4."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2Message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field contains the HL7 event identifier corresponding to the original trigger event.  Its contents dictate the format of the response message.  Hence, a value of “A04” in this field indicates a request for the data associated with the “register a patient” trigger event.  The ERP response message returns the contents of the “register a patient” message.  If more than one match is found, the ERP returns repeating groups of the segments defined by the “A04” message. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ERQ.2.1",
                            Type = @"Component",
                            Position = @"ERQ.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERQ.2.2",
                            Type = @"Component",
                            Position = @"ERQ.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERQ.2.3",
                            Type = @"Component",
                            Position = @"ERQ.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERQ.2.4",
                            Type = @"Component",
                            Position = @"ERQ.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERQ.2.5",
                            Type = @"Component",
                            Position = @"ERQ.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERQ.2.6",
                            Type = @"Component",
                            Position = @"ERQ.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field contains the list of parameter names and values to be passed to the responding system, in the form “<segment field name> ^ <value1 & value2 & value3 ...>.”  A single valued parameter contains only a single subcomponent in the second component: thus no subcomponent delimiters are needed (e.g., <segment field name> ^ <value>).  A simple list of values (i.e., a onedimensional array) may be passed instead of a single value by separating each value with the subcomponent delimiter: “<segment field name> ^ <value1&value2 &...>.”",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"This component contains the field value or values in the form ""value1& value2 & value3""",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V25SegmentERQ(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field queryTag;

public HL7V25Field QueryTag
{
    get
    {
        if (queryTag != null)
        {
            return queryTag;
        }

        queryTag = new HL7V25Field
        {
            field = message[@"ERQ"][1],
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
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2Message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole.",
            Sample = @"",
        };

        // check for repetitions
        if (queryTag.field.FieldRepetitions != null && queryTag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(queryTag.Id));
            queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(queryTag, fieldData);
        }

        return queryTag;
    } 
}

internal HL7V25Field eventIdentifier;

public HL7V25Field EventIdentifier
{
    get
    {
        if (eventIdentifier != null)
        {
            return eventIdentifier;
        }

        eventIdentifier = new HL7V25Field
        {
            field = message[@"ERQ"][2],
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
            Description = @"This field contains the HL7 event identifier corresponding to the original trigger event.  Its contents dictate the format of the response message.  Hence, a value of “A04” in this field indicates a request for the data associated with the “register a patient” trigger event.  The ERP response message returns the contents of the “register a patient” message.  If more than one match is found, the ERP returns repeating groups of the segments defined by the “A04” message. ",
            Sample = @"",
        };

        // check for repetitions
        if (eventIdentifier.field.FieldRepetitions != null && eventIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventIdentifier.Id));
            eventIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(eventIdentifier, fieldData);
        }

        return eventIdentifier;
    } 
}

internal HL7V25Field inputParameterList;

public HL7V25Field InputParameterList
{
    get
    {
        if (inputParameterList != null)
        {
            return inputParameterList;
        }

        inputParameterList = new HL7V25Field
        {
            field = message[@"ERQ"][3],
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
            Description = @"This field contains the list of parameter names and values to be passed to the responding system, in the form “<segment field name> ^ <value1 & value2 & value3 ...>.”  A single valued parameter contains only a single subcomponent in the second component: thus no subcomponent delimiters are needed (e.g., <segment field name> ^ <value>).  A simple list of values (i.e., a onedimensional array) may be passed instead of a single value by separating each value with the subcomponent delimiter: “<segment field name> ^ <value1&value2 &...>.”",
            Sample = @"",
        };

        // check for repetitions
        if (inputParameterList.field.FieldRepetitions != null && inputParameterList.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inputParameterList.Id));
            inputParameterList.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(inputParameterList, fieldData);
        }

        return inputParameterList;
    } 
}
    }
}
