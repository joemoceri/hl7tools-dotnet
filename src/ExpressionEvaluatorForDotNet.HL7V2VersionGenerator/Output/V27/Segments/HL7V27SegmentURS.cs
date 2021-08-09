using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27SegmentURS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"URS"; } }

        public string SegmentId { get { return @"URS"; } }
        
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
                            Id = @"URS.1",
                            Type = @"Field",
                            Position = @"URS.1",
                            Name = @"URS.1",
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

        public HL7V27SegmentURS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V27Field uRS1;

public HL7V27Field URS1
{
    get
    {
        if (uRS1 != null)
        {
            return uRS1;
        }

        uRS1 = new HL7V27Field
        {
            field = message[@"URS"][1],
            Id = @"URS.1",
            Type = @"Field",
            Position = @"URS.1",
            Name = @"URS.1",
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
        if (uRS1.field.FieldRepetitions != null && uRS1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uRS1.Id));
            uRS1.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(uRS1, fieldData);
        }

        return uRS1;
    } 
}
    }
}
