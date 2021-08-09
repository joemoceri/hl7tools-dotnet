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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentNPU(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field bedLocation;

public HL7V21Field BedLocation
{
    get
    {
        if (bedLocation != null)
        {
            return bedLocation;
        }

        bedLocation = new HL7V21Field
        {
            field = message[@"NPU"][1],
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
        };

        // check for repetitions
        if (bedLocation.field.FieldRepetitions != null && bedLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(bedLocation.Id));
            bedLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(bedLocation, fieldData);
        }

        return bedLocation;
    } 
}

internal HL7V21Field bedStatus;

public HL7V21Field BedStatus
{
    get
    {
        if (bedStatus != null)
        {
            return bedStatus;
        }

        bedStatus = new HL7V21Field
        {
            field = message[@"NPU"][2],
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
        };

        // check for repetitions
        if (bedStatus.field.FieldRepetitions != null && bedStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(bedStatus.Id));
            bedStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(bedStatus, fieldData);
        }

        return bedStatus;
    } 
}
    }
}
