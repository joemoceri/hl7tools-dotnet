using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentQRF
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QRF"; } }

        public string SegmentId { get { return @"QRF"; } }
        
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
                            Id = @"QRF.1",
                            Type = @"Field",
                            Position = @"QRF.1",
                            Name = @"QRF.1",
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

        public HL7V28SegmentQRF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field qRF1;

public HL7V28Field QRF1
{
    get
    {
        if (qRF1 != null)
        {
            return qRF1;
        }

        qRF1 = new HL7V28Field
        {
            field = message[@"QRF"][1],
            Id = @"QRF.1",
            Type = @"Field",
            Position = @"QRF.1",
            Name = @"QRF.1",
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

        // check for repetitions
        if (qRF1.field.FieldRepetitions != null && qRF1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(qRF1.Id));
            qRF1.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(qRF1, fieldData);
        }

        return qRF1;
    } 
}
    }
}
