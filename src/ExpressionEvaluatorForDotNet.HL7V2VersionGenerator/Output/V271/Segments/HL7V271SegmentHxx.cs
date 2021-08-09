using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentHxx
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"Hxx"; } }

        public string SegmentId { get { return @"Hxx"; } }
        
        public string LongName { get { return @"Any Hl7 Segment"; } }
        
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
                            Id = @"HXX.1",
                            Type = @"Field",
                            Position = @"HXX.1",
                            Name = @"Hxx.1",
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

        public HL7V271SegmentHxx(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field hxx1;

public HL7V271Field Hxx1
{
    get
    {
        if (hxx1 != null)
        {
            return hxx1;
        }

        hxx1 = new HL7V271Field
        {
            field = message[@"Hxx"][1],
            Id = @"HXX.1",
            Type = @"Field",
            Position = @"HXX.1",
            Name = @"Hxx.1",
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
        if (hxx1.field.FieldRepetitions != null && hxx1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(hxx1.Id));
            hxx1.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(hxx1, fieldData);
        }

        return hxx1;
    } 
}
    }
}
