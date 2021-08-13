using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentNCK
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NCK"; } }

        public string SegmentId { get { return @"NCK"; } }
        
        public string LongName { get { return @"System Clock"; } }
        
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

        public HL7V251SegmentNCK(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _systemDateTime;

public HL7V251Field SystemDateTime
{
    get
    {
        if (_systemDateTime != null)
        {
            return _systemDateTime;
        }

        var fieldData = new HL7V251FieldData
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
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NCK.1.1",
                            Type = @"Component",
                            Position = @"NCK.1.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NCK.1.2",
                            Type = @"Component",
                            Position = @"NCK.1.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _systemDateTime = new HL7V251Field
        {
            field = message[@"NCK"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_systemDateTime.field.FieldRepetitions != null && _systemDateTime.field.FieldRepetitions.Count > 0)
        {
            _systemDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_systemDateTime, fieldData);
        }

        return _systemDateTime;
    } 
}
    }
}
