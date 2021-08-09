using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentDSC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DSC"; } }

        public string SegmentId { get { return @"DSC"; } }
        
        public string LongName { get { return @"Continuation Pointer"; } }
        
        public string Description { get { return @"The DSC segment is used in the continuation protocol."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

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
                            Id = @"DSC.1",
                            Type = @"Field",
                            Position = @"DSC.1",
                            Name = @"Continuation Pointer",
                            Length = 180,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the continuation pointer. In an initial query, this field is not present. If the responder returns a value of null or not present, then there is no more data to fulfill any future continuation requests. Note that continuation protocols work with both display- and record-oriented messages.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DSC.2",
                            Type = @"Field",
                            Position = @"DSC.2",
                            Name = @"Continuation Style",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0398",
                            TableName = @"Continuation style code",
                            Description = @"Indicates whether this is a fragmented message, or if it is part of an interactive continuation message.

Refer to HL7 Table 0398 – Continuation Style Code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V251SegmentDSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field continuationPointer;

public HL7V251Field ContinuationPointer
{
    get
    {
        if (continuationPointer != null)
        {
            return continuationPointer;
        }

        continuationPointer = new HL7V251Field
        {
            field = message[@"DSC"][1],
            Id = @"DSC.1",
            Type = @"Field",
            Position = @"DSC.1",
            Name = @"Continuation Pointer",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the continuation pointer. In an initial query, this field is not present. If the responder returns a value of null or not present, then there is no more data to fulfill any future continuation requests. Note that continuation protocols work with both display- and record-oriented messages.",
            Sample = @"",
        };

        // check for repetitions
        if (continuationPointer.field.FieldRepetitions != null && continuationPointer.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(continuationPointer.Id));
            continuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(continuationPointer, fieldData);
        }

        return continuationPointer;
    } 
}

internal HL7V251Field continuationStyle;

public HL7V251Field ContinuationStyle
{
    get
    {
        if (continuationStyle != null)
        {
            return continuationStyle;
        }

        continuationStyle = new HL7V251Field
        {
            field = message[@"DSC"][2],
            Id = @"DSC.2",
            Type = @"Field",
            Position = @"DSC.2",
            Name = @"Continuation Style",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0398",
            TableName = @"Continuation style code",
            Description = @"Indicates whether this is a fragmented message, or if it is part of an interactive continuation message.

Refer to HL7 Table 0398 – Continuation Style Code for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (continuationStyle.field.FieldRepetitions != null && continuationStyle.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(continuationStyle.Id));
            continuationStyle.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(continuationStyle, fieldData);
        }

        return continuationStyle;
    } 
}
    }
}
