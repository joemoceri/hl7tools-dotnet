using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentNPU
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NPU"; } }

        public string SegmentId { get { return @"NPU"; } }
        
        public string LongName { get { return @"Non-patient Update"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentNPU(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _bedLocation;

public HL7V21Field BedLocation
{
    get
    {
        if (_bedLocation != null)
        {
            return _bedLocation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NPU.1",
            Type = @"Field",
            Position = @"NPU.1",
            Name = @"Bed Location",
            Length = 12,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _bedLocation = new HL7V21Field
        {
            field = message[@"NPU"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bedLocation.field.FieldRepetitions != null && _bedLocation.field.FieldRepetitions.Count > 0)
        {
            _bedLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_bedLocation, fieldData);
        }

        return _bedLocation;
    } 
}

internal HL7V21Field _bedStatus;

public HL7V21Field BedStatus
{
    get
    {
        if (_bedStatus != null)
        {
            return _bedStatus;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NPU.2",
            Type = @"Field",
            Position = @"NPU.2",
            Name = @"Bed Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0116",
            TableName = @"BED STATUS",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _bedStatus = new HL7V21Field
        {
            field = message[@"NPU"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bedStatus.field.FieldRepetitions != null && _bedStatus.field.FieldRepetitions.Count > 0)
        {
            _bedStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_bedStatus, fieldData);
        }

        return _bedStatus;
    } 
}
    }
}
