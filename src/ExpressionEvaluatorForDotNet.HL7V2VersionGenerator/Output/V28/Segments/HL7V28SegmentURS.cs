using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentURS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"URS"; } }

        public string SegmentId { get { return @"URS"; } }
        
        public string LongName { get { return @"Results/Update Selection Criteria"; } }
        
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

        public HL7V28SegmentURS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field _uRS1;

public HL7V28Field URS1
{
    get
    {
        if (_uRS1 != null)
        {
            return _uRS1;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"URS.1",
            Type = @"Field",
            Position = @"URS.1",
            Name = @"URS.1",
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

        _uRS1 = new HL7V28Field
        {
            field = message[@"URS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uRS1.field.FieldRepetitions != null && _uRS1.field.FieldRepetitions.Count > 0)
        {
            _uRS1.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_uRS1, fieldData);
        }

        return _uRS1;
    } 
}
    }
}
