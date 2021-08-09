using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentZxx
    {
        public HL7V2Message message { get; init; }

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

        internal HL7V22Field zxx1;

public HL7V22Field Zxx1
{
    get
    {
        if (zxx1 != null)
        {
            return zxx1;
        }

        zxx1 = new HL7V22Field
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

        // check for repetitions
        if (zxx1.field.FieldRepetitions != null && zxx1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(zxx1.Id));
            zxx1.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(zxx1, fieldData);
        }

        return zxx1;
    } 
}
    }
}
