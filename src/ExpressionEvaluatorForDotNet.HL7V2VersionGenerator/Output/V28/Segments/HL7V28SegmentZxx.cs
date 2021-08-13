using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentZxx
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"Zxx"; } }

        public string SegmentId { get { return @"Zxx"; } }
        
        public string LongName { get { return @"Any Z Segment"; } }
        
        public string Description { get { return @""; } }
        
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

        public HL7V28SegmentZxx(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field _zxx1;

public HL7V28Field Zxx1
{
    get
    {
        if (_zxx1 != null)
        {
            return _zxx1;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"ZXX.1",
            Type = @"Field",
            Position = @"ZXX.1",
            Name = @"Zxx.1",
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

        _zxx1 = new HL7V28Field
        {
            field = message[@"Zxx"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_zxx1.field.FieldRepetitions != null && _zxx1.field.FieldRepetitions.Count > 0)
        {
            _zxx1.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_zxx1, fieldData);
        }

        return _zxx1;
    } 
}
    }
}
