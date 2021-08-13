using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentPD1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PD1"; } }

        public string SegmentId { get { return @"PD1"; } }
        
        public string LongName { get { return @"Patient Demographics"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentPD1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _pD11;

public HL7V21Field PD11
{
    get
    {
        if (_pD11 != null)
        {
            return _pD11;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PD1.1",
            Type = @"Field",
            Position = @"PD1.1",
            Name = @"PD1.1",
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

        _pD11 = new HL7V21Field
        {
            field = message[@"PD1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pD11.field.FieldRepetitions != null && _pD11.field.FieldRepetitions.Count > 0)
        {
            _pD11.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_pD11, fieldData);
        }

        return _pD11;
    } 
}
    }
}
