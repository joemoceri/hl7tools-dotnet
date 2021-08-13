using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentDSP
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DSP"; } }

        public string SegmentId { get { return @"DSP"; } }
        
        public string LongName { get { return @"Display Data"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentDSP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdDisplayData;

public HL7V21Field SetIdDisplayData
{
    get
    {
        if (_setIdDisplayData != null)
        {
            return _setIdDisplayData;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"DSP.1",
            Type = @"Field",
            Position = @"DSP.1",
            Name = @"Set Id - Display Data",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _setIdDisplayData = new HL7V21Field
        {
            field = message[@"DSP"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdDisplayData.field.FieldRepetitions != null && _setIdDisplayData.field.FieldRepetitions.Count > 0)
        {
            _setIdDisplayData.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdDisplayData, fieldData);
        }

        return _setIdDisplayData;
    } 
}

internal HL7V21Field _displayLevel;

public HL7V21Field DisplayLevel
{
    get
    {
        if (_displayLevel != null)
        {
            return _displayLevel;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"DSP.2",
            Type = @"Field",
            Position = @"DSP.2",
            Name = @"Display Level",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _displayLevel = new HL7V21Field
        {
            field = message[@"DSP"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_displayLevel.field.FieldRepetitions != null && _displayLevel.field.FieldRepetitions.Count > 0)
        {
            _displayLevel.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_displayLevel, fieldData);
        }

        return _displayLevel;
    } 
}

internal HL7V21Field _dataLine;

public HL7V21Field DataLine
{
    get
    {
        if (_dataLine != null)
        {
            return _dataLine;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"DSP.3",
            Type = @"Field",
            Position = @"DSP.3",
            Name = @"Data Line",
            Length = 300,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _dataLine = new HL7V21Field
        {
            field = message[@"DSP"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dataLine.field.FieldRepetitions != null && _dataLine.field.FieldRepetitions.Count > 0)
        {
            _dataLine.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dataLine, fieldData);
        }

        return _dataLine;
    } 
}

internal HL7V21Field _logicalBreakPoint;

public HL7V21Field LogicalBreakPoint
{
    get
    {
        if (_logicalBreakPoint != null)
        {
            return _logicalBreakPoint;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"DSP.4",
            Type = @"Field",
            Position = @"DSP.4",
            Name = @"Logical Break Point",
            Length = 2,
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

        _logicalBreakPoint = new HL7V21Field
        {
            field = message[@"DSP"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_logicalBreakPoint.field.FieldRepetitions != null && _logicalBreakPoint.field.FieldRepetitions.Count > 0)
        {
            _logicalBreakPoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_logicalBreakPoint, fieldData);
        }

        return _logicalBreakPoint;
    } 
}

internal HL7V21Field _resultId;

public HL7V21Field ResultId
{
    get
    {
        if (_resultId != null)
        {
            return _resultId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"DSP.5",
            Type = @"Field",
            Position = @"DSP.5",
            Name = @"Result Id",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _resultId = new HL7V21Field
        {
            field = message[@"DSP"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resultId.field.FieldRepetitions != null && _resultId.field.FieldRepetitions.Count > 0)
        {
            _resultId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_resultId, fieldData);
        }

        return _resultId;
    } 
}
    }
}
