using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentERQ
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ERQ"; } }

        public string SegmentId { get { return @"ERQ"; } }
        
        public string LongName { get { return @"Event Replay Query Segment"; } }
        
        public string Description { get { return @"The ERQ segment is used to issue queries where the desired response is formatted as an event replay response message.  This enables the querying application to request detailed event data from an application that supports this feature, such that it may no longer be necessary for it to capture and store all event information at the time of the original trigger event. "; } }
        
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
                            Id = @"ERQ.1",
                            Type = @"Field",
                            Position = @"ERQ.1",
                            Name = @"Query tag",
                            Length = 32,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2-message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2- message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERQ.2",
                            Type = @"Field",
                            Position = @"ERQ.2",
                            Name = @"Event identifier",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the HL7 event identifier corresponding to the original trigger event.  Its contents dictate the format of the response message.  Hence, a value of “A04” in this field indicates a request for the data associated with the “register a patient” trigger event.  The ERP response message returns the contents of the “register a patient” message defined in Chapter 3.  If more than one match is found, the ERP returns repeating groups of the segments defined by the “A04” message",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ERQ.2.1",
                            Type = @"Component",
                            Position = @"ERQ.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
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
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERQ.3",
                            Type = @"Field",
                            Position = @"ERQ.3",
                            Name = @"Input parameter list",
                            Length = 256,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"QIP",
                            DataTypeName = @"Query Input Parameter List",
                            TableId = null,
                            TableName = null,
                            Description = @" This field contains the list of parameter names and values to be passed to the responding system, in the form “<field name> ^ <value1 & value2 & value3 ...>.”  A single valued parameter contains only a single subcomponent in the second component: thus no subcomponent delimiters are needed (e.g., <field name> ^ <value>).  A simple list of values (i.e., a one-dimensional array) may be passed instead of a single value by separating each value with the subcomponent delimiter: “<field name> ^ <value1&value2 &...>”  Refer to Section 2.24.16.4, “EQL query statement  (ST)   00710,” for field naming conventions. 
For example, , a value of “@00122^123-45-6789” could be combined with the A04 event identifier to request patient registration data for the patient with the social security number 123-45-6789. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ERQ.3.1",
                            Type = @"Component",
                            Position = @"ERQ.3.1",
                            Name = @"Field Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the field name.

Field naming conventions:
Fields are designated by the “@” symbol concatenated with the HL7 item number for the field.  If the field is divided into components, the designation may be suffixed with “.nn,” to identify a particular component (a suffix of “.3” indicates the third component of the field); otherwise, the whole field is assumed.  If the field is further divided into subcomponents, the designation is suffixed with “.nn.mm,” which identifies the component and subcomponent requested by relative position.

Site-specific fields may be used, provided that they begin with the letter “Z.” In this case, site-specific item numbers must be defined that do not conflict with existing HL7 item numbers.

Values for this field are defined in the function-specific chapters of this specification. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERQ.3.2",
                            Type = @"Component",
                            Position = @"ERQ.3.2",
                            Name = @"Value1&value2&value3",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the field value or values in the form “value1& value2 & value3 …”

A single valued parameter contains only a single subcomponent in the second component:  thus no subcomponent delimiters are needed (e.g., <field name> ^ <value>).  A simple list of values (i.e., a one-dimensional array) may be passed instead of a single value by separating each value with the subcomponent delimiter: ,”<field name> ^ <value1 & value2 &…>” ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V23SegmentERQ(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field querytag;

public HL7V23Field Querytag
{
    get
    {
        if (querytag != null)
        {
            return querytag;
        }

        querytag = new HL7V23Field
        {
            field = message[@"ERQ"][1],
            Id = @"ERQ.1",
            Type = @"Field",
            Position = @"ERQ.1",
            Name = @"Query tag",
            Length = 32,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2-message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2- message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole",
            Sample = @"",
        };

        // check for repetitions
        if (querytag.field.FieldRepetitions != null && querytag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(querytag.Id));
            querytag.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(querytag, fieldData);
        }

        return querytag;
    } 
}

internal HL7V23Field eventidentifier;

public HL7V23Field Eventidentifier
{
    get
    {
        if (eventidentifier != null)
        {
            return eventidentifier;
        }

        eventidentifier = new HL7V23Field
        {
            field = message[@"ERQ"][2],
            Id = @"ERQ.2",
            Type = @"Field",
            Position = @"ERQ.2",
            Name = @"Event identifier",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the HL7 event identifier corresponding to the original trigger event.  Its contents dictate the format of the response message.  Hence, a value of “A04” in this field indicates a request for the data associated with the “register a patient” trigger event.  The ERP response message returns the contents of the “register a patient” message defined in Chapter 3.  If more than one match is found, the ERP returns repeating groups of the segments defined by the “A04” message",
            Sample = @"",
        };

        // check for repetitions
        if (eventidentifier.field.FieldRepetitions != null && eventidentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventidentifier.Id));
            eventidentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(eventidentifier, fieldData);
        }

        return eventidentifier;
    } 
}

internal HL7V23Field inputparameterlist;

public HL7V23Field Inputparameterlist
{
    get
    {
        if (inputparameterlist != null)
        {
            return inputparameterlist;
        }

        inputparameterlist = new HL7V23Field
        {
            field = message[@"ERQ"][3],
            Id = @"ERQ.3",
            Type = @"Field",
            Position = @"ERQ.3",
            Name = @"Input parameter list",
            Length = 256,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"QIP",
            DataTypeName = @"Query Input Parameter List",
            TableId = null,
            TableName = null,
            Description = @" This field contains the list of parameter names and values to be passed to the responding system, in the form “<field name> ^ <value1 & value2 & value3 ...>.”  A single valued parameter contains only a single subcomponent in the second component: thus no subcomponent delimiters are needed (e.g., <field name> ^ <value>).  A simple list of values (i.e., a one-dimensional array) may be passed instead of a single value by separating each value with the subcomponent delimiter: “<field name> ^ <value1&value2 &...>”  Refer to Section 2.24.16.4, “EQL query statement  (ST)   00710,” for field naming conventions. 
For example, , a value of “@00122^123-45-6789” could be combined with the A04 event identifier to request patient registration data for the patient with the social security number 123-45-6789. ",
            Sample = @"",
        };

        // check for repetitions
        if (inputparameterlist.field.FieldRepetitions != null && inputparameterlist.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inputparameterlist.Id));
            inputparameterlist.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(inputparameterlist, fieldData);
        }

        return inputparameterlist;
    } 
}
    }
}
