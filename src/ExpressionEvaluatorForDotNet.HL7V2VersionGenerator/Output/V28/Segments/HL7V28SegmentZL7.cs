using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentZL7
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ZL7"; } }

        public string SegmentId { get { return @"ZL7"; } }
        
        public string LongName { get { return @"(proposed Example Only)"; } }
        
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
                            Id = @"ZL7.1",
                            Type = @"Field",
                            Position = @"ZL7.1",
                            Name = @"ZL7.1",
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

        public HL7V28SegmentZL7(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field zL7.1;

public HL7V28Field ZL7.1
{
    get
    {
        if (zL7.1 != null)
        {
            return zL7.1;
        }

        zL7.1 = new HL7V28Field
        {
            field = message[@"ZL7"][1],
            Id = @"ZL7.1",
            Type = @"Field",
            Position = @"ZL7.1",
            Name = @"ZL7.1",
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

        

        

        

        return zL7.1;
    } 
}

    }
}
