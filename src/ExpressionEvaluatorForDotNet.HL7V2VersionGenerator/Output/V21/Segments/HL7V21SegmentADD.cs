using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentADD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ADD"; } }

        public string SegmentId { get { return @"ADD"; } }
        
        public string LongName { get { return @"Addendum"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentADD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _addendumContinuationPointer;

public HL7V21Field AddendumContinuationPointer
{
    get
    {
        if (_addendumContinuationPointer != null)
        {
            return _addendumContinuationPointer;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ADD.1",
            Type = @"Field",
            Position = @"ADD.1",
            Name = @"Addendum Continuation Pointer",
            Length = 60,
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

        _addendumContinuationPointer = new HL7V21Field
        {
            field = message[@"ADD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_addendumContinuationPointer.field.FieldRepetitions != null && _addendumContinuationPointer.field.FieldRepetitions.Count > 0)
        {
            _addendumContinuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_addendumContinuationPointer, fieldData);
        }

        return _addendumContinuationPointer;
    } 
}
    }
}
