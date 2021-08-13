using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentQPD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QPD"; } }

        public string SegmentId { get { return @"QPD"; } }
        
        public string LongName { get { return @"Query Parameter Definition"; } }
        
        public string Description { get { return @"The QPD segment defines the parameters of the query."; } }
        
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

        public HL7V25SegmentQPD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _messageQueryName;

public HL7V25Field MessageQueryName
{
    get
    {
        if (_messageQueryName != null)
        {
            return _messageQueryName;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"QPD.1",
            Type = @"Field",
            Position = @"QPD.1",
            Name = @"Message Query Name",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0471",
            TableName = @"Query name",
            Description = @"This field contains the name of the query. These names are assigned by the function-specific chapters of this specification. It is one to one with the conformance statement for this query name, and it is in fact an identifier for that conformance statement. Site-specific query names begin with the letter Z. Refer to User defined table 0471 - Query name for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"QPD.1.1",
                            Type = @"Component",
                            Position = @"QPD.1.1",
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
                            Id = @"QPD.1.2",
                            Type = @"Component",
                            Position = @"QPD.1.2",
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
                            Id = @"QPD.1.3",
                            Type = @"Component",
                            Position = @"QPD.1.3",
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
                            Id = @"QPD.1.4",
                            Type = @"Component",
                            Position = @"QPD.1.4",
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
                            Id = @"QPD.1.5",
                            Type = @"Component",
                            Position = @"QPD.1.5",
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
                            Id = @"QPD.1.6",
                            Type = @"Component",
                            Position = @"QPD.1.6",
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
                        },
                        }
        }

        _messageQueryName = new HL7V25Field
        {
            field = message[@"QPD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageQueryName.field.FieldRepetitions != null && _messageQueryName.field.FieldRepetitions.Count > 0)
        {
            _messageQueryName.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_messageQueryName, fieldData);
        }

        return _messageQueryName;
    } 
}

internal HL7V25Field _queryTag;

public HL7V25Field QueryTag
{
    get
    {
        if (_queryTag != null)
        {
            return _queryTag;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"QPD.2",
            Type = @"Field",
            Position = @"QPD.2",
            Name = @"Query Tag",
            Length = 32,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query. If this field is valued, the responding system is required to echo it back as the first field in the query acknowledgement segment (QAK).",
            Sample = @"",
            Fields = null
        }

        _queryTag = new HL7V25Field
        {
            field = message[@"QPD"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryTag.field.FieldRepetitions != null && _queryTag.field.FieldRepetitions.Count > 0)
        {
            _queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_queryTag, fieldData);
        }

        return _queryTag;
    } 
}

internal HL7V25Field _userParametersinsuccessivefields;

public HL7V25Field UserParametersinsuccessivefields
{
    get
    {
        if (_userParametersinsuccessivefields != null)
        {
            return _userParametersinsuccessivefields;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"QPD.3",
            Type = @"Field",
            Position = @"QPD.3",
            Name = @"User Parameters (in successive fields)",
            Length = 256,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = @"These successive parameter fields hold the values that the Client passes to the Server.",
            Sample = @"",
            Fields = null
        }

        _userParametersinsuccessivefields = new HL7V25Field
        {
            field = message[@"QPD"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_userParametersinsuccessivefields.field.FieldRepetitions != null && _userParametersinsuccessivefields.field.FieldRepetitions.Count > 0)
        {
            _userParametersinsuccessivefields.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_userParametersinsuccessivefields, fieldData);
        }

        return _userParametersinsuccessivefields;
    } 
}
    }
}
