using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentQPD
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

        public HL7V26SegmentQPD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _messageQueryName;

public HL7V26Field MessageQueryName
{
    get
    {
        if (_messageQueryName != null)
        {
            return _messageQueryName;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"QPD.1",
            Type = @"Field",
            Position = @"QPD.1",
            Name = @"Message Query Name",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0471",
            TableName = @"Query name",
            Description = @"This field contains the name of the query. These names are assigned by the function-specific chapters of this specification. It is one to one with the Query Profile for this query name, and it is in fact an identifier for that Query Profile. Site-specific query names begin with the letter ""Z."" Refer to User defined table 0471 - Query name for suggested values.",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QPD.1.7",
                            Type = @"Component",
                            Position = @"QPD.1.7",
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
                            Id = @"QPD.1.8",
                            Type = @"Component",
                            Position = @"QPD.1.8",
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
                            Id = @"QPD.1.9",
                            Type = @"Component",
                            Position = @"QPD.1.9",
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
                        },
                        }
        }

        _messageQueryName = new HL7V26Field
        {
            field = message[@"QPD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageQueryName.field.FieldRepetitions != null && _messageQueryName.field.FieldRepetitions.Count > 0)
        {
            _messageQueryName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_messageQueryName, fieldData);
        }

        return _messageQueryName;
    } 
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

        _queryTag = new HL7V26Field
        {
            field = message[@"QPD"][2],
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

internal HL7V26Field _userParametersinsuccessivefields;

public HL7V26Field UserParametersinsuccessivefields
{
    get
    {
        if (_userParametersinsuccessivefields != null)
        {
            return _userParametersinsuccessivefields;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"These successive parameter fields hold the values that the Client passes to the Server.

The client data is presented as a sequence of HL7 fields. Beginning at QPD-3-User parameters, the remaining fields of the QPD segment carry user parameter data.  Each QPD user parameter field corresponds to one parameter defined in the Query Profile, where each name, type, optionality, and repetition of each parameter has been specified. While these parameters are understood to be usually ""anded"" together, the user must inspect the required Query Profile to properly understand each. Except in the QSC variant, the parameter names do not need to be stated in the query; they are understood to be positional based on the Query Profile.",
            Sample = @"",
            Fields = null
        }

        _userParametersinsuccessivefields = new HL7V26Field
        {
            field = message[@"QPD"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_userParametersinsuccessivefields.field.FieldRepetitions != null && _userParametersinsuccessivefields.field.FieldRepetitions.Count > 0)
        {
            _userParametersinsuccessivefields.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_userParametersinsuccessivefields, fieldData);
        }

        return _userParametersinsuccessivefields;
    } 
}
    }
}
