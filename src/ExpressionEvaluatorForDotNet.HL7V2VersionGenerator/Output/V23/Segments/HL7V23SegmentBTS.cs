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

        public HL7V23SegmentBTS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _batchMessageCount;

public HL7V23Field BatchMessageCount
{
    get
    {
        if (_batchMessageCount != null)
        {
            return _batchMessageCount;
        }

        var fieldData = new HL7V23FieldData
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
            Fields = null
        }

        _batchMessageCount = new HL7V23Field
        {
            field = message[@"BTS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchMessageCount.field.FieldRepetitions != null && _batchMessageCount.field.FieldRepetitions.Count > 0)
        {
            _batchMessageCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_batchMessageCount, fieldData);
        }

        return _batchMessageCount;
    } 
}

internal HL7V23Field _batchComment;

public HL7V23Field BatchComment
{
    get
    {
        if (_batchComment != null)
        {
            return _batchComment;
        }

        var fieldData = new HL7V23FieldData
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
            Fields = null
        }

        _batchComment = new HL7V23Field
        {
            field = message[@"BTS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchComment.field.FieldRepetitions != null && _batchComment.field.FieldRepetitions.Count > 0)
        {
            _batchComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_batchComment, fieldData);
        }

        return _batchComment;
    } 
}

internal HL7V23Field _batchTotals;

public HL7V23Field BatchTotals
{
    get
    {
        if (_batchTotals != null)
        {
            return _batchTotals;
        }

        var fieldData = new HL7V23FieldData
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
            Fields = null
        }

        _batchTotals = new HL7V23Field
        {
            field = message[@"BTS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchTotals.field.FieldRepetitions != null && _batchTotals.field.FieldRepetitions.Count > 0)
        {
            _batchTotals.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_batchTotals, fieldData);
        }

        return _batchTotals;
    } 
}
    }
}
