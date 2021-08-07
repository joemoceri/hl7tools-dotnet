using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentERR
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ERR"; } }

        public string SegmentId { get { return @"ERR"; } }
        
        public string LongName { get { return @"Error"; } }
        
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
                            Id = @"ERR.1",
                            Type = @"Field",
                            Position = @"ERR.1",
                            Name = @"Error Code And Location",
                            Length = 80,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0060",
                            TableName = @"ERROR CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentERR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field errorCodeAndLocation;

public HL7V21Field ErrorCodeAndLocation
{
    get
    {
        if (errorCodeAndLocation != null)
        {
            return errorCodeAndLocation;
        }

        errorCodeAndLocation = new HL7V21Field
        {
            field = message[@"ERR"][1],
            Id = @"ERR.1",
            Type = @"Field",
            Position = @"ERR.1",
            Name = @"Error Code And Location",
            Length = 80,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0060",
            TableName = @"ERROR CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return errorCodeAndLocation;
    } 
}

    }
}
