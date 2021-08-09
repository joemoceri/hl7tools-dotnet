using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentNCK
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NCK"; } }

        public string SegmentId { get { return @"NCK"; } }
        
        public string LongName { get { return @"System clock"; } }
        
        public string Description { get { return @"The NCK segment is used to allow the various applications on the network to synchronize their system clocks (system date and time)."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_14",

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
                            Id = @"NCK.1",
                            Type = @"Field",
                            Position = @"NCK.1",
                            Name = @"System Date/Time",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an HL7 time stamp. It is strongly recommended that seconds be included. If the message contains an NST or NSC segment, the NCK segment is optional. If the NCK segment is present, this field is required. If present in the NMQ message, or the unsolicited NMD message, it contains the system date/time of the sending system. If present in the NMR response message, it contains the responding system's date/time.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NCK.1.1",
                            Type = @"Component",
                            Position = @"NCK.1.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NCK.1.2",
                            Type = @"Component",
                            Position = @"NCK.1.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V24SegmentNCK(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field systemDateTime;

public HL7V24Field SystemDateTime
{
    get
    {
        if (systemDateTime != null)
        {
            return systemDateTime;
        }

        systemDateTime = new HL7V24Field
        {
            field = message[@"NCK"][1],
            Id = @"NCK.1",
            Type = @"Field",
            Position = @"NCK.1",
            Name = @"System Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains an HL7 time stamp. It is strongly recommended that seconds be included. If the message contains an NST or NSC segment, the NCK segment is optional. If the NCK segment is present, this field is required. If present in the NMQ message, or the unsolicited NMD message, it contains the system date/time of the sending system. If present in the NMR response message, it contains the responding system's date/time.",
            Sample = @"",
        };

        // check for repetitions
        if (systemDateTime.field.FieldRepetitions != null && systemDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(systemDateTime.Id));
            systemDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(systemDateTime, fieldData);
        }

        return systemDateTime;
    } 
}
    }
}
