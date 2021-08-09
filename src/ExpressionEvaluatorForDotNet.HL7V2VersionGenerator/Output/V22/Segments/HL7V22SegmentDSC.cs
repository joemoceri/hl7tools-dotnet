using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentDSC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DSC"; } }

        public string SegmentId { get { return @"DSC"; } }
        
        public string LongName { get { return @"Continuation Pointer"; } }
        
        public string Description { get { return @"The DSC segment is used in the continuation protocol."; } }
        
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
                            Id = @"DSC.1",
                            Type = @"Field",
                            Position = @"DSC.1",
                            Name = @"Continuation Pointer",
                            Length = 180,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"see description of Continuation Fields in Section 2.8.4.  In an initial query, this field is null.  If the responder returns a value of null or not present, then there is no more data to fulfill any future continuation requests.  For use with continuations of unsolicited messages, see sections 2.7.2 and 2.9.2.  Note that continuation protocols work with both display and record-oriented messages",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentDSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field continuationPointer;

public HL7V22Field ContinuationPointer
{
    get
    {
        if (continuationPointer != null)
        {
            return continuationPointer;
        }

        continuationPointer = new HL7V22Field
        {
            field = message[@"DSC"][1],
            Id = @"DSC.1",
            Type = @"Field",
            Position = @"DSC.1",
            Name = @"Continuation Pointer",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"see description of Continuation Fields in Section 2.8.4.  In an initial query, this field is null.  If the responder returns a value of null or not present, then there is no more data to fulfill any future continuation requests.  For use with continuations of unsolicited messages, see sections 2.7.2 and 2.9.2.  Note that continuation protocols work with both display and record-oriented messages",
            Sample = @"",
        };

        // check for repetitions
        if (continuationPointer.field.FieldRepetitions != null && continuationPointer.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(continuationPointer.Id));
            continuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(continuationPointer, fieldData);
        }

        return continuationPointer;
    } 
}
    }
}
