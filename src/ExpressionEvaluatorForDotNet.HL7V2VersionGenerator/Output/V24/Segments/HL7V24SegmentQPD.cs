using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentQPD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QPD"; } }

        public string SegmentId { get { return @"QPD"; } }
        
        public string LongName { get { return @"Query Parameter Definition"; } }
        
        public string Description { get { return @""; } }
        
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

        public HL7V24SegmentQPD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _messageQueryName;

public HL7V24Field MessageQueryName
{
    get
    {
        if (_messageQueryName != null)
        {
            return _messageQueryName;
        }

        var fieldData = new HL7V24FieldData
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
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"QPD.1.1",
                            Type = @"Component",
                            Position = @"QPD.1.1",
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
                            Id = @"QPD.1.2",
                            Type = @"Component",
                            Position = @"QPD.1.2",
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
                            Id = @"QPD.1.3",
                            Type = @"Component",
                            Position = @"QPD.1.3",
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
                            Id = @"QPD.1.4",
                            Type = @"Component",
                            Position = @"QPD.1.4",
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
                            Id = @"QPD.1.5",
                            Type = @"Component",
                            Position = @"QPD.1.5",
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
                            Id = @"QPD.1.6",
                            Type = @"Component",
                            Position = @"QPD.1.6",
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
                        }
        }

        _messageQueryName = new HL7V24Field
        {
            field = message[@"QPD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageQueryName.field.FieldRepetitions != null && _messageQueryName.field.FieldRepetitions.Count > 0)
        {
            _messageQueryName.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_messageQueryName, fieldData);
        }

        return _messageQueryName;
    } 
}

internal HL7V24Field _queryTag;

public HL7V24Field QueryTag
{
    get
    {
        if (_queryTag != null)
        {
            return _queryTag;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QPD.2",
            Type = @"Field",
            Position = @"QPD.2",
            Name = @"Query Tag",
            Length = 32,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _queryTag = new HL7V24Field
        {
            field = message[@"QPD"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryTag.field.FieldRepetitions != null && _queryTag.field.FieldRepetitions.Count > 0)
        {
            _queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_queryTag, fieldData);
        }

        return _queryTag;
    } 
}

internal HL7V24Field _userParameters;

public HL7V24Field UserParameters
{
    get
    {
        if (_userParameters != null)
        {
            return _userParameters;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QPD.3",
            Type = @"Field",
            Position = @"QPD.3",
            Name = @"User Parameters",
            Length = 256,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _userParameters = new HL7V24Field
        {
            field = message[@"QPD"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_userParameters.field.FieldRepetitions != null && _userParameters.field.FieldRepetitions.Count > 0)
        {
            _userParameters.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_userParameters, fieldData);
        }

        return _userParameters;
    } 
}
    }
}
