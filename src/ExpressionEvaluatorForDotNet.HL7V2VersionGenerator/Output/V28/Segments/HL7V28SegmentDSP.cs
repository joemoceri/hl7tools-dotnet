using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentDSP
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DSP"; } }

        public string SegmentId { get { return @"DSP"; } }
        
        public string LongName { get { return @"Display Data"; } }
        
        public string Description { get { return @"The DSP segment is used to contain data that has been preformatted by the sender for display.  The semantic content of the data is lost; the data is simply treated as lines of text. "; } }
        
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

        public HL7V28SegmentDSP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field _setIdDsp;

public HL7V28Field SetIdDsp
{
    get
    {
        if (_setIdDsp != null)
        {
            return _setIdDsp;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"DSP.1",
            Type = @"Field",
            Position = @"DSP.1",
            Name = @"Set Id - Dsp",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"This field is used optionally to number multiple display segments",
            Sample = @"",
            Fields = null
        }

        _setIdDsp = new HL7V28Field
        {
            field = message[@"DSP"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdDsp.field.FieldRepetitions != null && _setIdDsp.field.FieldRepetitions.Count > 0)
        {
            _setIdDsp.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_setIdDsp, fieldData);
        }

        return _setIdDsp;
    } 
}

internal HL7V28Field _displayLevel;

public HL7V28Field DisplayLevel
{
    get
    {
        if (_displayLevel != null)
        {
            return _displayLevel;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"DSP.2",
            Type = @"Field",
            Position = @"DSP.2",
            Name = @"Display Level",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"This field contains numbering to define groups of fields as assigned by the individual sites or applications.",
            Sample = @"",
            Fields = null
        }

        _displayLevel = new HL7V28Field
        {
            field = message[@"DSP"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_displayLevel.field.FieldRepetitions != null && _displayLevel.field.FieldRepetitions.Count > 0)
        {
            _displayLevel.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_displayLevel, fieldData);
        }

        return _displayLevel;
    } 
}

internal HL7V28Field _dataLine;

public HL7V28Field DataLine
{
    get
    {
        if (_dataLine != null)
        {
            return _dataLine;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"DSP.3",
            Type = @"Field",
            Position = @"DSP.3",
            Name = @"Data Line",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains an actual line as it should be displayed.  As described for the TX data type, highlighting and other special display characteristics may be included.",
            Sample = @"",
            Fields = null
        }

        _dataLine = new HL7V28Field
        {
            field = message[@"DSP"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dataLine.field.FieldRepetitions != null && _dataLine.field.FieldRepetitions.Count > 0)
        {
            _dataLine.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_dataLine, fieldData);
        }

        return _dataLine;
    } 
}

internal HL7V28Field _logicalBreakPoint;

public HL7V28Field LogicalBreakPoint
{
    get
    {
        if (_logicalBreakPoint != null)
        {
            return _logicalBreakPoint;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"DSP.4",
            Type = @"Field",
            Position = @"DSP.4",
            Name = @"Logical Break Point",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is non-null if this line is the last line of a logical break point in the response as defined by the responding system.

Often the lines of display text will fall into logical groups that differ from the physical size of a screen or printer page.  For example, a complete battery or an entire radiology report might be thought of as comprising a logical group, though it might have as few as six or as many as 120 lines.  Knowledge of the logical break points in the display data can be useful to the application system that is displaying or printing data.  For this reason, DSP-4-Logical break point is used.  The sending application (the one that formats the data) places the logical break points where appropriate.  If there is a particular ancillary result ID associated with the data delineated by DSP-4-Logical break point, the value of this ID also can be returned in DSP-5-Result ID.  Then if the user selects the area of the display delineated by DSP-4-Logical break point, the displaying system can query for the associated DSP-5-Result ID.",
            Sample = @"",
            Fields = null
        }

        _logicalBreakPoint = new HL7V28Field
        {
            field = message[@"DSP"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_logicalBreakPoint.field.FieldRepetitions != null && _logicalBreakPoint.field.FieldRepetitions.Count > 0)
        {
            _logicalBreakPoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_logicalBreakPoint, fieldData);
        }

        return _logicalBreakPoint;
    } 
}

internal HL7V28Field _resultId;

public HL7V28Field ResultId
{
    get
    {
        if (_resultId != null)
        {
            return _resultId;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"DSP.5",
            Type = @"Field",
            Position = @"DSP.5",
            Name = @"Result Id",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"When the user selects a result ID (defined by DSP-4-Logical break point) from the screen display corresponding to a record in which DSP-5-Result ID is non-null, the application can initiate a second query (a separate session) to the ancillary with the QRD-10-What department data code filled in with this non-null value (e.g., the ancillary accession number or its equivalent).  The ancillary response will contain the report referenced by this result ID (e.g., accession number).  The ancillary should correlate the result ID with DSP-4-Logical break point as follows: If more than one line of text is sent per result, DSP-5-Result ID should be only non-null for a DSP segment that contains a non-null DSP-4-Logical break point.  This field may be broken into components by local agreement.  A common example might be to include placer order number, filler order number, and universal service identifier.  Whenever such fields are used as components of the result ID, their components will be sent as subcomponents.",
            Sample = @"",
            Fields = null
        }

        _resultId = new HL7V28Field
        {
            field = message[@"DSP"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resultId.field.FieldRepetitions != null && _resultId.field.FieldRepetitions.Count > 0)
        {
            _resultId.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_resultId, fieldData);
        }

        return _resultId;
    } 
}
    }
}
