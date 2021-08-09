using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentBTS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"BTS"; } }

        public string SegmentId { get { return @"BTS"; } }
        
        public string LongName { get { return @"Batch Trailer Segment"; } }
        
        public string Description { get { return @"The BTS segment defines the end of a batch."; } }
        
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
                            Id = @"BTS.1",
                            Type = @"Field",
                            Position = @"BTS.1",
                            Name = @"Batch Message Count",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the count of the individual messages contained within the batch",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BTS.2",
                            Type = @"Field",
                            Position = @"BTS.2",
                            Name = @"Batch Comment",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a comment field that is not further defined in the HL7 pr",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BTS.3",
                            Type = @"Field",
                            Position = @"BTS.3",
                            Name = @"Batch Totals",
                            Length = 100,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"We encourage new users of this field to use the HL7 Version 2.3 data type of NM and to define it as “repeating.” This field contains the batch total.  If more than a single batch total exists, this field may be repeated.   

This field may be defined as a CM data type for backward compatibility with HL7 Versions 2.2 and 2.1 with each total being carried as a separate component.  Each component in this case is an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentBTS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field batchMessageCount;

public HL7V23Field BatchMessageCount
{
    get
    {
        if (batchMessageCount != null)
        {
            return batchMessageCount;
        }

        batchMessageCount = new HL7V23Field
        {
            field = message[@"BTS"][1],
            Id = @"BTS.1",
            Type = @"Field",
            Position = @"BTS.1",
            Name = @"Batch Message Count",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the count of the individual messages contained within the batch",
            Sample = @"",
        };

        // check for repetitions
        if (batchMessageCount.field.FieldRepetitions != null && batchMessageCount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchMessageCount.Id));
            batchMessageCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(batchMessageCount, fieldData);
        }

        return batchMessageCount;
    } 
}

internal HL7V23Field batchComment;

public HL7V23Field BatchComment
{
    get
    {
        if (batchComment != null)
        {
            return batchComment;
        }

        batchComment = new HL7V23Field
        {
            field = message[@"BTS"][2],
            Id = @"BTS.2",
            Type = @"Field",
            Position = @"BTS.2",
            Name = @"Batch Comment",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is a comment field that is not further defined in the HL7 pr",
            Sample = @"",
        };

        // check for repetitions
        if (batchComment.field.FieldRepetitions != null && batchComment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchComment.Id));
            batchComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(batchComment, fieldData);
        }

        return batchComment;
    } 
}

internal HL7V23Field batchTotals;

public HL7V23Field BatchTotals
{
    get
    {
        if (batchTotals != null)
        {
            return batchTotals;
        }

        batchTotals = new HL7V23Field
        {
            field = message[@"BTS"][3],
            Id = @"BTS.3",
            Type = @"Field",
            Position = @"BTS.3",
            Name = @"Batch Totals",
            Length = 100,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"We encourage new users of this field to use the HL7 Version 2.3 data type of NM and to define it as “repeating.” This field contains the batch total.  If more than a single batch total exists, this field may be repeated.   

This field may be defined as a CM data type for backward compatibility with HL7 Versions 2.2 and 2.1 with each total being carried as a separate component.  Each component in this case is an NM data type",
            Sample = @"",
        };

        // check for repetitions
        if (batchTotals.field.FieldRepetitions != null && batchTotals.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchTotals.Id));
            batchTotals.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(batchTotals, fieldData);
        }

        return batchTotals;
    } 
}
    }
}
