using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentDSP
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DSP"; } }

        public string SegmentId { get { return @"DSP"; } }
        
        public string LongName { get { return @"Display data segment"; } }
        
        public string Description { get { return @"The DSP segment is used to contain data that has been preformatted by the sender for display. The semantic content of the data is lost; the data is simply treated as lines of text."; } }
        
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

        public HL7V231SegmentDSP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _setIDDSP;

public HL7V231Field SetIDDSP
{
    get
    {
        if (_setIDDSP != null)
        {
            return _setIDDSP;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"DSP.1",
            Type = @"Field",
            Position = @"DSP.1",
            Name = @"Set ID - DSP",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field is used optionally to number multiple display segments.",
            Sample = @"",
            Fields = null
        }

        _setIDDSP = new HL7V231Field
        {
            field = message[@"DSP"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDDSP.field.FieldRepetitions != null && _setIDDSP.field.FieldRepetitions.Count > 0)
        {
            _setIDDSP.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_setIDDSP, fieldData);
        }

        return _setIDDSP;
    } 
}

internal HL7V231Field _displayLevel;

public HL7V231Field DisplayLevel
{
    get
    {
        if (_displayLevel != null)
        {
            return _displayLevel;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"DSP.2",
            Type = @"Field",
            Position = @"DSP.2",
            Name = @"Display Level",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains numbering to define groups of fields as assigned by the individual sites or applications.",
            Sample = @"",
            Fields = null
        }

        _displayLevel = new HL7V231Field
        {
            field = message[@"DSP"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_displayLevel.field.FieldRepetitions != null && _displayLevel.field.FieldRepetitions.Count > 0)
        {
            _displayLevel.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_displayLevel, fieldData);
        }

        return _displayLevel;
    } 
}

internal HL7V231Field _dataLine;

public HL7V231Field DataLine
{
    get
    {
        if (_dataLine != null)
        {
            return _dataLine;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains an actual line as it should be displayed. As described for the TX data type, highlighting and other special display characteristics may be included.",
            Sample = @"",
            Fields = null
        }

        _dataLine = new HL7V231Field
        {
            field = message[@"DSP"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dataLine.field.FieldRepetitions != null && _dataLine.field.FieldRepetitions.Count > 0)
        {
            _dataLine.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dataLine, fieldData);
        }

        return _dataLine;
    } 
}

internal HL7V231Field _logicalBreakPoint;

public HL7V231Field LogicalBreakPoint
{
    get
    {
        if (_logicalBreakPoint != null)
        {
            return _logicalBreakPoint;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field is non-null if this line is the last line of a logical break point in the response as defined by the responding system. See Section 2.15.5, 'Logical display break points,' for the discussion of Logical display break points.",
            Sample = @"",
            Fields = null
        }

        _logicalBreakPoint = new HL7V231Field
        {
            field = message[@"DSP"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_logicalBreakPoint.field.FieldRepetitions != null && _logicalBreakPoint.field.FieldRepetitions.Count > 0)
        {
            _logicalBreakPoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_logicalBreakPoint, fieldData);
        }

        return _logicalBreakPoint;
    } 
}

internal HL7V231Field _resultID;

public HL7V231Field ResultID
{
    get
    {
        if (_resultID != null)
        {
            return _resultID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"DSP.5",
            Type = @"Field",
            Position = @"DSP.5",
            Name = @"Result ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"When the user selects a result ID (defined by DSP-4-logical break point) from the screen display corresponding to a record in which DSP-5-result ID is non-null, the application can initiate a second query (a separate session) to the ancillary with the QRD-10-what department data code filled in with this non-null value (e.g., the ancillary accession number or its equivalent). The ancillary response will contain the report referenced by this result ID (e.g., accession number). The ancillary should correlate the result ID with DSP-4-logical break point as follows: If more than one line of text is sent per result, DSP-5-result ID should be only non-null for a DSP segment that contains a non-null DSP-4-logical break point. This field may be broken into components by local agreement. A common example might be to include placer order number, filler order number, and universal service identifier. Whenever such fields are used as components of the result ID, their components will be sent as subcomponents.",
            Sample = @"",
            Fields = null
        }

        _resultID = new HL7V231Field
        {
            field = message[@"DSP"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resultID.field.FieldRepetitions != null && _resultID.field.FieldRepetitions.Count > 0)
        {
            _resultID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_resultID, fieldData);
        }

        return _resultID;
    } 
}
    }
}
