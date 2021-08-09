using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentURD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"URD"; } }

        public string SegmentId { get { return @"URD"; } }
        
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
                            Id = @"URD.1",
                            Type = @"Field",
                            Position = @"URD.1",
                            Name = @"URD.1",
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

        public HL7V271SegmentURD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field uRD1;

public HL7V271Field URD1
{
    get
    {
        if (uRD1 != null)
        {
            return uRD1;
        }

        uRD1 = new HL7V271Field
        {
            field = message[@"URD"][1],
            Id = @"URD.1",
            Type = @"Field",
            Position = @"URD.1",
            Name = @"URD.1",
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
        if (uRD1.field.FieldRepetitions != null && uRD1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uRD1.Id));
            uRD1.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(uRD1, fieldData);
        }

        return uRD1;
    } 
}
    }
}
