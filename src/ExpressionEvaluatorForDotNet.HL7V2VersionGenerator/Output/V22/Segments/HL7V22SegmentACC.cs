using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentACC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ACC"; } }

        public string SegmentId { get { return @"ACC"; } }
        
        public string LongName { get { return @"Accident"; } }
        
        public string Description { get { return @"The ACC segment contains patient information relative to an accidentin which the patient has been involved. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V22SegmentACC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _accidentDateTime;

public HL7V22Field AccidentDateTime
{
    get
    {
        if (_accidentDateTime != null)
        {
            return _accidentDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"ACC.1",
            Type = @"Field",
            Position = @"ACC.1",
            Name = @"Accident Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time of the accident",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ACC.1.1",
                            Type = @"Component",
                            Position = @"ACC.1.1",
                            Name = @"Time Of An Event",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"ACC.1.2",
                            Type = @"Component",
                            Position = @"ACC.1.2",
                            Name = @"Degree Of Precision",
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
                        }
        }

        _accidentDateTime = new HL7V22Field
        {
            field = message[@"ACC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accidentDateTime.field.FieldRepetitions != null && _accidentDateTime.field.FieldRepetitions.Count > 0)
        {
            _accidentDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_accidentDateTime, fieldData);
        }

        return _accidentDateTime;
    } 
}

internal HL7V22Field _accidentCode;

public HL7V22Field AccidentCode
{
    get
    {
        if (_accidentCode != null)
        {
            return _accidentCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"ACC.2",
            Type = @"Field",
            Position = @"ACC.2",
            Name = @"Accident Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0050",
            TableName = @"ACCIDENT CODE",
            Description = @"type of accident.  Refer to user-defined table 0050 - accident code",
            Sample = @"",
            Fields = null
        }

        _accidentCode = new HL7V22Field
        {
            field = message[@"ACC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accidentCode.field.FieldRepetitions != null && _accidentCode.field.FieldRepetitions.Count > 0)
        {
            _accidentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_accidentCode, fieldData);
        }

        return _accidentCode;
    } 
}

internal HL7V22Field _accidentLocation;

public HL7V22Field AccidentLocation
{
    get
    {
        if (_accidentLocation != null)
        {
            return _accidentLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"ACC.3",
            Type = @"Field",
            Position = @"ACC.3",
            Name = @"Accident Location",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"location of the accident",
            Sample = @"",
            Fields = null
        }

        _accidentLocation = new HL7V22Field
        {
            field = message[@"ACC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accidentLocation.field.FieldRepetitions != null && _accidentLocation.field.FieldRepetitions.Count > 0)
        {
            _accidentLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_accidentLocation, fieldData);
        }

        return _accidentLocation;
    } 
}
    }
}
