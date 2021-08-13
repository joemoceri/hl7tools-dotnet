using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentADD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ADD"; } }

        public string SegmentId { get { return @"ADD"; } }
        
        public string LongName { get { return @"Addendum"; } }
        
        public string Description { get { return @"The ADD segment is used to define the continuation of the prior segment in a continuation message."; } }
        
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

        public HL7V25SegmentADD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _addendumContinuationPointer;

public HL7V25Field AddendumContinuationPointer
{
    get
    {
        if (_addendumContinuationPointer != null)
        {
            return _addendumContinuationPointer;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"ADD.1",
            Type = @"Field",
            Position = @"ADD.1",
            Name = @"Addendum Continuation Pointer",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to define the continuation of the prior segment in a continuation message.  When the ADD is sent after the segment being continued, it contains no fields. It is only a marker that the previous segment is being continued in a subsequent message. Thus fields 1-N are not present. The sequence designation, 1-N, means the remainder of the fields in the segment being continued. These remainder of the segment being continued fields are present only when the ADD is sent with a continuation message.",
            Sample = @"",
            Fields = null
        }

        _addendumContinuationPointer = new HL7V25Field
        {
            field = message[@"ADD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_addendumContinuationPointer.field.FieldRepetitions != null && _addendumContinuationPointer.field.FieldRepetitions.Count > 0)
        {
            _addendumContinuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_addendumContinuationPointer, fieldData);
        }

        return _addendumContinuationPointer;
    } 
}
    }
}
