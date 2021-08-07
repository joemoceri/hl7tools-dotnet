using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentADD
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ADD"; } }

        public string SegmentId { get { return @"ADD"; } }
        
        public string LongName { get { return @"Addendum"; } }
        
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
                            Id = @"ADD.1",
                            Type = @"Field",
                            Position = @"ADD.1",
                            Name = @"Addendum Continuation Pointer",
                            Length = 60,
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
                        };
            }
        }

        public HL7V21SegmentADD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field addendumContinuationPointer;

public HL7V21Field AddendumContinuationPointer
{
    get
    {
        if (addendumContinuationPointer != null)
        {
            return addendumContinuationPointer;
        }

        addendumContinuationPointer = new HL7V21Field
        {
            field = message[@"ADD"][1],
            Id = @"ADD.1",
            Type = @"Field",
            Position = @"ADD.1",
            Name = @"Addendum Continuation Pointer",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return addendumContinuationPointer;
    } 
}

    }
}
