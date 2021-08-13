using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentDSC
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

        public HL7V22SegmentDSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _continuationPointer;

public HL7V22Field ContinuationPointer
{
    get
    {
        if (_continuationPointer != null)
        {
            return _continuationPointer;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"see description of Continuation Fields in Section 2.8.4.  In an initial query, this field is null.  If the responder returns a value of null or not present, then there is no more data to fulfill any future continuation requests.  For use with continuations of unsolicited messages, see sections 2.7.2 and 2.9.2.  Note that continuation protocols work with both display and record-oriented messages",
            Sample = @"",
            Fields = null
        }

        _continuationPointer = new HL7V22Field
        {
            field = message[@"DSC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_continuationPointer.field.FieldRepetitions != null && _continuationPointer.field.FieldRepetitions.Count > 0)
        {
            _continuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_continuationPointer, fieldData);
        }

        return _continuationPointer;
    } 
}
    }
}
