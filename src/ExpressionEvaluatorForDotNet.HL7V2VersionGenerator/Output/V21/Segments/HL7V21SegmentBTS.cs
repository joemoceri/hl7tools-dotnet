using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentBTS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"BTS"; } }

        public string SegmentId { get { return @"BTS"; } }
        
        public string LongName { get { return @"Batch Trailer"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentBTS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _batchMessageCount;

public HL7V21Field BatchMessageCount
{
    get
    {
        if (_batchMessageCount != null)
        {
            return _batchMessageCount;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _batchMessageCount = new HL7V21Field
        {
            field = message[@"BTS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchMessageCount.field.FieldRepetitions != null && _batchMessageCount.field.FieldRepetitions.Count > 0)
        {
            _batchMessageCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_batchMessageCount, fieldData);
        }

        return _batchMessageCount;
    } 
}

internal HL7V21Field _batchComment;

public HL7V21Field BatchComment
{
    get
    {
        if (_batchComment != null)
        {
            return _batchComment;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _batchComment = new HL7V21Field
        {
            field = message[@"BTS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchComment.field.FieldRepetitions != null && _batchComment.field.FieldRepetitions.Count > 0)
        {
            _batchComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_batchComment, fieldData);
        }

        return _batchComment;
    } 
}

internal HL7V21Field _batchTotals;

public HL7V21Field BatchTotals
{
    get
    {
        if (_batchTotals != null)
        {
            return _batchTotals;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"BTS.3",
            Type = @"Field",
            Position = @"BTS.3",
            Name = @"Batch Totals",
            Length = 100,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _batchTotals = new HL7V21Field
        {
            field = message[@"BTS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchTotals.field.FieldRepetitions != null && _batchTotals.field.FieldRepetitions.Count > 0)
        {
            _batchTotals.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_batchTotals, fieldData);
        }

        return _batchTotals;
    } 
}
    }
}
