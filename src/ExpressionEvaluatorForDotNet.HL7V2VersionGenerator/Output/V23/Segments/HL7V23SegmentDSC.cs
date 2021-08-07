using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentDSC
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"DSC"; } }

        public string SegmentId { get { return @"DSC"; } }
        
        public string LongName { get { return @"Continuation pointer segment"; } }
        
        public string Description { get { return @"The DSC segment is used in the continuation protocol"; } }
        
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
                            Description = @"This field contains the continuation pointer.  See the description of Continuation Fields in Section 2.15.4, “Interactive continuation or cancellation of response messages: original mode (display and record-oriented) and enhanced mode (display, tabular, and event replay).”  In an initial query, this field is not present.  If the responder returns a value of null or not present, then there is no more data to fulfill any future continuation requests.  For use with continuations of unsolicited messages, see Sections 2.14.2, “UDM/ACK - unsolicited display update message (event Q05),” and 2.23.2 “Continuation messages and segments.”  Note that continuation protocols work with both display- and record-oriented messages",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentDSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field continuationPointer;

public HL7V23Field ContinuationPointer
{
    get
    {
        if (continuationPointer != null)
        {
            return continuationPointer;
        }

        continuationPointer = new HL7V23Field
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
            Description = @"This field contains the continuation pointer.  See the description of Continuation Fields in Section 2.15.4, “Interactive continuation or cancellation of response messages: original mode (display and record-oriented) and enhanced mode (display, tabular, and event replay).”  In an initial query, this field is not present.  If the responder returns a value of null or not present, then there is no more data to fulfill any future continuation requests.  For use with continuations of unsolicited messages, see Sections 2.14.2, “UDM/ACK - unsolicited display update message (event Q05),” and 2.23.2 “Continuation messages and segments.”  Note that continuation protocols work with both display- and record-oriented messages",
            Sample = @"",
        };

        

        

        

        return continuationPointer;
    } 
}

    }
}
