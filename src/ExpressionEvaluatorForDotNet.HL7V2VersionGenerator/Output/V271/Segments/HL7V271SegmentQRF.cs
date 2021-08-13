using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentQRF
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QRF"; } }

        public string SegmentId { get { return @"QRF"; } }
        
        public string LongName { get { return @"Withdrawn"; } }
        
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

        public HL7V271SegmentQRF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field _qRF1;

public HL7V271Field QRF1
{
    get
    {
        if (_qRF1 != null)
        {
            return _qRF1;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"QRF.1",
            Type = @"Field",
            Position = @"QRF.1",
            Name = @"QRF.1",
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

        _qRF1 = new HL7V271Field
        {
            field = message[@"QRF"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_qRF1.field.FieldRepetitions != null && _qRF1.field.FieldRepetitions.Count > 0)
        {
            _qRF1.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_qRF1, fieldData);
        }

        return _qRF1;
    } 
}
    }
}
