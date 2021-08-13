using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentHxx
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"Hxx"; } }

        public string SegmentId { get { return @"Hxx"; } }
        
        public string LongName { get { return @"Any Hl7 Segment"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V271SegmentHxx(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field _hxx1;

public HL7V271Field Hxx1
{
    get
    {
        if (_hxx1 != null)
        {
            return _hxx1;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"HXX.1",
            Type = @"Field",
            Position = @"HXX.1",
            Name = @"Hxx.1",
            Length = 0,
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

        _hxx1 = new HL7V271Field
        {
            field = message[@"Hxx"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_hxx1.field.FieldRepetitions != null && _hxx1.field.FieldRepetitions.Count > 0)
        {
            _hxx1.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_hxx1, fieldData);
        }

        return _hxx1;
    } 
}
    }
}
