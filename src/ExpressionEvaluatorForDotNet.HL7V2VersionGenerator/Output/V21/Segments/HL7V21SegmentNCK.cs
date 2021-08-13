using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentNCK
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NCK"; } }

        public string SegmentId { get { return @"NCK"; } }
        
        public string LongName { get { return @"System Clock"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentNCK(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _systemDateTime;

public HL7V21Field SystemDateTime
{
    get
    {
        if (_systemDateTime != null)
        {
            return _systemDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NCK.1",
            Type = @"Field",
            Position = @"NCK.1",
            Name = @"System Date/Time",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _systemDateTime = new HL7V21Field
        {
            field = message[@"NCK"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_systemDateTime.field.FieldRepetitions != null && _systemDateTime.field.FieldRepetitions.Count > 0)
        {
            _systemDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_systemDateTime, fieldData);
        }

        return _systemDateTime;
    } 
}
    }
}
