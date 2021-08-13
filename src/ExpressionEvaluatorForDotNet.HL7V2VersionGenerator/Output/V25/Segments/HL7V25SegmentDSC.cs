using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentDSC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DSC"; } }

        public string SegmentId { get { return @"DSC"; } }
        
        public string LongName { get { return @"Continuation Pointer"; } }
        
        public string Description { get { return @"The DSC segment is used in the continuation protocol."; } }
        
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

        public HL7V25SegmentDSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _continuationPointer;

public HL7V25Field ContinuationPointer
{
    get
    {
        if (_continuationPointer != null)
        {
            return _continuationPointer;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"DSC.1",
            Type = @"Field",
            Position = @"DSC.1",
            Name = @"Continuation Pointer",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the continuation pointer. In an initial query, this field is not present. If the responder returns a value of null or not present, then there is no more data to fulfill any future continuation requests. Note that continuation protocols work with both display- and record-oriented messages.",
            Sample = @"",
            Fields = null
        }

        _continuationPointer = new HL7V25Field
        {
            field = message[@"DSC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_continuationPointer.field.FieldRepetitions != null && _continuationPointer.field.FieldRepetitions.Count > 0)
        {
            _continuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_continuationPointer, fieldData);
        }

        return _continuationPointer;
    } 
}

internal HL7V25Field _continuationStyle;

public HL7V25Field ContinuationStyle
{
    get
    {
        if (_continuationStyle != null)
        {
            return _continuationStyle;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"DSC.2",
            Type = @"Field",
            Position = @"DSC.2",
            Name = @"Continuation Style",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0398",
            TableName = @"Continuation style code",
            Description = @"Indicates whether this is a fragmented message, or if it is part of an interactive continuation message.

Refer to HL7 Table 0398 – Continuation Style Code for valid values.",
            Sample = @"",
            Fields = null
        }

        _continuationStyle = new HL7V25Field
        {
            field = message[@"DSC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_continuationStyle.field.FieldRepetitions != null && _continuationStyle.field.FieldRepetitions.Count > 0)
        {
            _continuationStyle.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_continuationStyle, fieldData);
        }

        return _continuationStyle;
    } 
}
    }
}
