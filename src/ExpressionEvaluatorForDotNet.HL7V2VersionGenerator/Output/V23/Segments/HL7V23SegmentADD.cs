using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentADD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ADD"; } }

        public string SegmentId { get { return @"ADD"; } }
        
        public string LongName { get { return @"Addendum"; } }
        
        public string Description { get { return @"The ADD segment is used to define the continuation of the prior segment in a continuation message.  See Section 2.23.2, “Continuation messages and segments,” for details. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

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
                            Id = @"ADD.1",
                            Type = @"Field",
                            Position = @"ADD.1",
                            Name = @"Addendum Continuation Pointer",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to define the continuation of the prior segment in a continuation message.  See text for details.  When the ADD is sent after the segment being continued, it contains no fields.  It is only a marker that the previous segment is being continued in a subsequent message.  Thus fields 1-N are not present.  The sequence designation, 1-N, means the remainder of the fields in the segment being continued.  These remainder of the segment being continued fields are present only when the ADD is sent with a continuation message. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentADD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field addendumContinuationPointer;

public HL7V23Field AddendumContinuationPointer
{
    get
    {
        if (addendumContinuationPointer != null)
        {
            return addendumContinuationPointer;
        }

        addendumContinuationPointer = new HL7V23Field
        {
            field = message[@"ADD"][1],
            Id = @"ADD.1",
            Type = @"Field",
            Position = @"ADD.1",
            Name = @"Addendum Continuation Pointer",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to define the continuation of the prior segment in a continuation message.  See text for details.  When the ADD is sent after the segment being continued, it contains no fields.  It is only a marker that the previous segment is being continued in a subsequent message.  Thus fields 1-N are not present.  The sequence designation, 1-N, means the remainder of the fields in the segment being continued.  These remainder of the segment being continued fields are present only when the ADD is sent with a continuation message. ",
            Sample = @"",
        };

        // check for repetitions
        if (addendumContinuationPointer.field.FieldRepetitions != null && addendumContinuationPointer.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(addendumContinuationPointer.Id));
            addendumContinuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(addendumContinuationPointer, fieldData);
        }

        return addendumContinuationPointer;
    } 
}
    }
}
