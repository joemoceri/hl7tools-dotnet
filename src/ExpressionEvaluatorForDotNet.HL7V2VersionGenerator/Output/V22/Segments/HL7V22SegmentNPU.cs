using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentNPU
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NPU"; } }

        public string SegmentId { get { return @"NPU"; } }
        
        public string LongName { get { return @"Bed Status Update"; } }
        
        public string Description { get { return @"The NPU segment allows the updating of census (bed status) data without sending patient specific data. For example: changing the status of a bed from housekeeping to unoccupied."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
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
                            DataType = @"CM_INTERNAL_LOCATION",
                            DataTypeName = @"Cm For Location Information In Hospital",
                            TableId = @"0079",
                            TableName = @"LOCATION",
                            Description = @"bed location is a valid bed location.  Refer to user-defined table 0079 - location",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NPU.1.1",
                            Type = @"Component",
                            Position = @"NPU.1.1",
                            Name = @"Nurse Unit (station)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.2",
                            Type = @"Component",
                            Position = @"NPU.1.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.3",
                            Type = @"Component",
                            Position = @"NPU.1.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.4",
                            Type = @"Component",
                            Position = @"NPU.1.4",
                            Name = @"Facility Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.5",
                            Type = @"Component",
                            Position = @"NPU.1.5",
                            Name = @"Bed Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
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
                            Description = @"refer to user-defined table 0116 - bed status for suggested entries",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentNPU(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field bedLocation;

public HL7V22Field BedLocation
{
    get
    {
        if (bedLocation != null)
        {
            return bedLocation;
        }

        bedLocation = new HL7V22Field
        {
            field = message[@"NPU"][1],
            Id = @"NPU.1",
            Type = @"Field",
            Position = @"NPU.1",
            Name = @"Bed Location",
            Length = 12,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CM_INTERNAL_LOCATION",
            DataTypeName = @"Cm For Location Information In Hospital",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = @"bed location is a valid bed location.  Refer to user-defined table 0079 - location",
            Sample = @"",
        };

        // check for repetitions
        if (bedLocation.field.FieldRepetitions != null && bedLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(bedLocation.Id));
            bedLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(bedLocation, fieldData);
        }

        return bedLocation;
    } 
}

internal HL7V22Field bedStatus;

public HL7V22Field BedStatus
{
    get
    {
        if (bedStatus != null)
        {
            return bedStatus;
        }

        bedStatus = new HL7V22Field
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
            Description = @"refer to user-defined table 0116 - bed status for suggested entries",
            Sample = @"",
        };

        // check for repetitions
        if (bedStatus.field.FieldRepetitions != null && bedStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(bedStatus.Id));
            bedStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(bedStatus, fieldData);
        }

        return bedStatus;
    } 
}
    }
}
