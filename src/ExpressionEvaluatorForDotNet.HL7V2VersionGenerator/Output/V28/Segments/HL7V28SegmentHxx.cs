using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentHxx
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"Hxx"; } }

        public string SegmentId { get { return @"Hxx"; } }
        
        public string LongName { get { return @"Any Hl7 Segment"; } }
        
        public string Description { get { return @""; } }
        
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
                            Id = @"HXX.1",
                            Type = @"Field",
                            Position = @"HXX.1",
                            Name = @"Hxx.1",
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
                        };
            }
        }

        public HL7V28SegmentHxx(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field hxx.1;

public HL7V28Field Hxx.1
{
    get
    {
        if (hxx.1 != null)
        {
            return hxx.1;
        }

        hxx.1 = new HL7V28Field
        {
            field = message[@"Hxx"][1],
            Id = @"HXX.1",
            Type = @"Field",
            Position = @"HXX.1",
            Name = @"Hxx.1",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return hxx.1;
    } 
}

    }
}
