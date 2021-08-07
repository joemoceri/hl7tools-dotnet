using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentQRD
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"QRD"; } }

        public string SegmentId { get { return @"QRD"; } }
        
        public string LongName { get { return @"Withdrawn"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
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
                            Id = @"QRD.1",
                            Type = @"Field",
                            Position = @"QRD.1",
                            Name = @"QRD.1",
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

        public HL7V271SegmentQRD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field qRD.1;

public HL7V271Field QRD.1
{
    get
    {
        if (qRD.1 != null)
        {
            return qRD.1;
        }

        qRD.1 = new HL7V271Field
        {
            field = message[@"QRD"][1],
            Id = @"QRD.1",
            Type = @"Field",
            Position = @"QRD.1",
            Name = @"QRD.1",
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

        

        

        

        return qRD.1;
    } 
}

    }
}
