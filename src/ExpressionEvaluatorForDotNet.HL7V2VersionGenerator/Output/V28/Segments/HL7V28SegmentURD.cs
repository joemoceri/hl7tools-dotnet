using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentURD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"URD"; } }

        public string SegmentId { get { return @"URD"; } }
        
        public string LongName { get { return @"Results/Update Definition"; } }
        
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

        public HL7V28SegmentURD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field _uRD1;

public HL7V28Field URD1
{
    get
    {
        if (_uRD1 != null)
        {
            return _uRD1;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"URD.1",
            Type = @"Field",
            Position = @"URD.1",
            Name = @"URD.1",
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

        _uRD1 = new HL7V28Field
        {
            field = message[@"URD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uRD1.field.FieldRepetitions != null && _uRD1.field.FieldRepetitions.Count > 0)
        {
            _uRD1.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_uRD1, fieldData);
        }

        return _uRD1;
    } 
}
    }
}
