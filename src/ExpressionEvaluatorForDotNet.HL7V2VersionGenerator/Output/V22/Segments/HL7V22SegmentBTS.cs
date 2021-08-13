using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentBTS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"BTS"; } }

        public string SegmentId { get { return @"BTS"; } }
        
        public string LongName { get { return @"Batch Trailer"; } }
        
        public string Description { get { return @"The BTS segment defines the end of a batch. "; } }
        
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

        public HL7V22SegmentBTS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _batchMessageCount;

public HL7V22Field BatchMessageCount
{
    get
    {
        if (_batchMessageCount != null)
        {
            return _batchMessageCount;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"count of the individual messages contained within the batch",
            Sample = @"",
            Fields = null
        }

        _batchMessageCount = new HL7V22Field
        {
            field = message[@"BTS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchMessageCount.field.FieldRepetitions != null && _batchMessageCount.field.FieldRepetitions.Count > 0)
        {
            _batchMessageCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchMessageCount, fieldData);
        }

        return _batchMessageCount;
    } 
}

internal HL7V22Field _batchComment;

public HL7V22Field BatchComment
{
    get
    {
        if (_batchComment != null)
        {
            return _batchComment;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"comment field that is not further defined in the HL7 protocol",
            Sample = @"",
            Fields = null
        }

        _batchComment = new HL7V22Field
        {
            field = message[@"BTS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchComment.field.FieldRepetitions != null && _batchComment.field.FieldRepetitions.Count > 0)
        {
            _batchComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchComment, fieldData);
        }

        return _batchComment;
    } 
}

internal HL7V22Field _batchTotals;

public HL7V22Field BatchTotals
{
    get
    {
        if (_batchTotals != null)
        {
            return _batchTotals;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"BTS.3",
            Type = @"Field",
            Position = @"BTS.3",
            Name = @"Batch Totals",
            Length = 100,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_BATCH_TOTAL",
            DataTypeName = @"Cm For Batch Totals",
            TableId = null,
            TableName = null,
            Description = @"as many types of totals as needed for the batch may be carried by this field as separate  components.  Each component is an NM data type",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"BTS.3.1",
                            Type = @"Component",
                            Position = @"BTS.3.1",
                            Name = @"Batch Total 1",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BTS.3.2",
                            Type = @"Component",
                            Position = @"BTS.3.2",
                            Name = @"Batch Total 2",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BTS.3.3",
                            Type = @"Component",
                            Position = @"BTS.3.3",
                            Name = @"...",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _batchTotals = new HL7V22Field
        {
            field = message[@"BTS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_batchTotals.field.FieldRepetitions != null && _batchTotals.field.FieldRepetitions.Count > 0)
        {
            _batchTotals.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_batchTotals, fieldData);
        }

        return _batchTotals;
    } 
}
    }
}
