using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentERR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ERR"; } }

        public string SegmentId { get { return @"ERR"; } }
        
        public string LongName { get { return @"Error"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentERR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _errorCodeAndLocation;

public HL7V21Field ErrorCodeAndLocation
{
    get
    {
        if (_errorCodeAndLocation != null)
        {
            return _errorCodeAndLocation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ERR.1",
            Type = @"Field",
            Position = @"ERR.1",
            Name = @"Error Code And Location",
            Length = 80,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0060",
            TableName = @"ERROR CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _errorCodeAndLocation = new HL7V21Field
        {
            field = message[@"ERR"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_errorCodeAndLocation.field.FieldRepetitions != null && _errorCodeAndLocation.field.FieldRepetitions.Count > 0)
        {
            _errorCodeAndLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_errorCodeAndLocation, fieldData);
        }

        return _errorCodeAndLocation;
    } 
}
    }
}
