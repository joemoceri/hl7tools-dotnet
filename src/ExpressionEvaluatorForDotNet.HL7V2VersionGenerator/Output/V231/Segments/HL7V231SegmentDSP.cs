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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V231SegmentDSP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field setIDDSP;

public HL7V231Field SetIDDSP
{
    get
    {
        if (setIDDSP != null)
        {
            return setIDDSP;
        }

        setIDDSP = new HL7V231Field
        {
            field = message[@"DSP"][1],
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
        };

        // check for repetitions
        if (setIDDSP.field.FieldRepetitions != null && setIDDSP.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDDSP.Id));
            setIDDSP.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(setIDDSP, fieldData);
        }

        return setIDDSP;
    } 
}

internal HL7V231Field displayLevel;

public HL7V231Field DisplayLevel
{
    get
    {
        if (displayLevel != null)
        {
            return displayLevel;
        }

        displayLevel = new HL7V231Field
        {
            field = message[@"DSP"][2],
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
        };

        // check for repetitions
        if (displayLevel.field.FieldRepetitions != null && displayLevel.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(displayLevel.Id));
            displayLevel.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(displayLevel, fieldData);
        }

        return displayLevel;
    } 
}

internal HL7V231Field dataLine;

public HL7V231Field DataLine
{
    get
    {
        if (dataLine != null)
        {
            return dataLine;
        }

        dataLine = new HL7V231Field
        {
            field = message[@"DSP"][3],
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
        };

        // check for repetitions
        if (dataLine.field.FieldRepetitions != null && dataLine.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dataLine.Id));
            dataLine.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(dataLine, fieldData);
        }

        return dataLine;
    } 
}

internal HL7V231Field logicalBreakPoint;

public HL7V231Field LogicalBreakPoint
{
    get
    {
        if (logicalBreakPoint != null)
        {
            return logicalBreakPoint;
        }

        logicalBreakPoint = new HL7V231Field
        {
            field = message[@"DSP"][4],
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
        };

        // check for repetitions
        if (logicalBreakPoint.field.FieldRepetitions != null && logicalBreakPoint.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(logicalBreakPoint.Id));
            logicalBreakPoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(logicalBreakPoint, fieldData);
        }

        return logicalBreakPoint;
    } 
}

internal HL7V231Field resultID;

public HL7V231Field ResultID
{
    get
    {
        if (resultID != null)
        {
            return resultID;
        }

        resultID = new HL7V231Field
        {
            field = message[@"DSP"][5],
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
        };

        // check for repetitions
        if (resultID.field.FieldRepetitions != null && resultID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(resultID.Id));
            resultID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(resultID, fieldData);
        }

        return resultID;
    } 
}
    }
}
