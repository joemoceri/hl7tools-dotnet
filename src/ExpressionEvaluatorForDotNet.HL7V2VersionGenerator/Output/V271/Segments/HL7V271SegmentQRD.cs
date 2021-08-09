using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentQRD
    {
        public HL7V2Message message { get; init; }

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

        internal HL7V271Field qRD1;

public HL7V271Field QRD1
{
    get
    {
        if (qRD1 != null)
        {
            return qRD1;
        }

        qRD1 = new HL7V271Field
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

        // check for repetitions
        if (qRD1.field.FieldRepetitions != null && qRD1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(qRD1.Id));
            qRD1.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(qRD1, fieldData);
        }

        return qRD1;
    } 
}
    }
}
