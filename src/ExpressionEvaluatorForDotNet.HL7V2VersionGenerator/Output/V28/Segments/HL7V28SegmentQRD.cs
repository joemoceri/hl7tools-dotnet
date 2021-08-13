using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentQRD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QRD"; } }

        public string SegmentId { get { return @"QRD"; } }
        
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

        public HL7V28SegmentQRD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field _qRD1;

public HL7V28Field QRD1
{
    get
    {
        if (_qRD1 != null)
        {
            return _qRD1;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"QRD.1",
            Type = @"Field",
            Position = @"QRD.1",
            Name = @"QRD.1",
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

        _qRD1 = new HL7V28Field
        {
            field = message[@"QRD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_qRD1.field.FieldRepetitions != null && _qRD1.field.FieldRepetitions.Count > 0)
        {
            _qRD1.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_qRD1, fieldData);
        }

        return _qRD1;
    } 
}
    }
}
