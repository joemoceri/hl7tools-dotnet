using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentNCK
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NCK"; } }

        public string SegmentId { get { return @"NCK"; } }
        
        public string LongName { get { return @"System Clock"; } }
        
        public string Description { get { return @"The NCK segment is used to allow the various applications on the network to synchronize their system clocks (system date and time).

Usage Notes: If this message is to be used to automatically reset/correct system clocks, it is recommended that the system or administrative personnel initiating the NMQ with the NCK segment have the authority to correct the clock (system date and time) for the other systems on the network.  This is important in order to avoid the obvious confusion of multiple systems attempting to resynchronize each other's clocks.

If this message is used only to gather information on the various systems' clocks, it is still important for an administrative procedure to be worked out to avoid conflicts when resetting clocks."; } }
        
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

        public HL7V271SegmentNCK(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field _systemDateTime;

public HL7V271Field SystemDateTime
{
    get
    {
        if (_systemDateTime != null)
        {
            return _systemDateTime;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"NCK.1",
            Type = @"Field",
            Position = @"NCK.1",
            Name = @"System Date/Time",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"This field contains an HL7 time stamp.  It is strongly recommended that seconds be included.  If the message contains an NST or NSC segment, the NCK segment is optional.  If the NCK segment is present, this field is required.  If present in the NMQ message, or the unsolicited NMD message, it contains the system date/time of the sending system.  If present in the NMR response message, it contains the responding system's date/time. ",
            Sample = @"",
            Fields = null
        }

        _systemDateTime = new HL7V271Field
        {
            field = message[@"NCK"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_systemDateTime.field.FieldRepetitions != null && _systemDateTime.field.FieldRepetitions.Count > 0)
        {
            _systemDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_systemDateTime, fieldData);
        }

        return _systemDateTime;
    } 
}
    }
}
