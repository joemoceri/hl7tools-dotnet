using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentNCK
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"NCK"; } }

        public string SegmentId { get { return @"NCK"; } }
        
        public string LongName { get { return @"System Clock"; } }
        
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
                            Id = @"NCK.1",
                            Type = @"Field",
                            Position = @"NCK.1",
                            Name = @"System Date/Time",
                            Length = 19,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentNCK(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field systemDateTime;

public HL7V21Field SystemDateTime
{
    get
    {
        if (systemDateTime != null)
        {
            return systemDateTime;
        }

        systemDateTime = new HL7V21Field
        {
            field = message[@"NCK"][1],
            Id = @"NCK.1",
            Type = @"Field",
            Position = @"NCK.1",
            Name = @"System Date/Time",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return systemDateTime;
    } 
}

    }
}
