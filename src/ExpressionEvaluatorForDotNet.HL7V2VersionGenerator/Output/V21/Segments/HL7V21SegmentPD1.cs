using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentPD1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PD1"; } }

        public string SegmentId { get { return @"PD1"; } }
        
        public string LongName { get { return @"Patient Demographics"; } }
        
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
                            Id = @"PD1.1",
                            Type = @"Field",
                            Position = @"PD1.1",
                            Name = @"PD1.1",
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

        public HL7V21SegmentPD1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field pD11;

public HL7V21Field PD11
{
    get
    {
        if (pD11 != null)
        {
            return pD11;
        }

        pD11 = new HL7V21Field
        {
            field = message[@"PD1"][1],
            Id = @"PD1.1",
            Type = @"Field",
            Position = @"PD1.1",
            Name = @"PD1.1",
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
        if (pD11.field.FieldRepetitions != null && pD11.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pD11.Id));
            pD11.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(pD11, fieldData);
        }

        return pD11;
    } 
}
    }
}
