using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentZxx
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"Zxx"; } }

        public string SegmentId { get { return @"Zxx"; } }
        
        public string LongName { get { return @"Any Z Segment"; } }
        
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
                            Id = @"ZXX.1",
                            Type = @"Field",
                            Position = @"ZXX.1",
                            Name = @"Zxx.1",
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

        public HL7V22SegmentZxx(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field zxx.1;

public HL7V22Field Zxx.1
{
    get
    {
        if (zxx.1 != null)
        {
            return zxx.1;
        }

        zxx.1 = new HL7V22Field
        {
            field = message[@"Zxx"][1],
            Id = @"ZXX.1",
            Type = @"Field",
            Position = @"ZXX.1",
            Name = @"Zxx.1",
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

        

        

        

        return zxx.1;
    } 
}

    }
}
