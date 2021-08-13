using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentOM6
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM6"; } }

        public string SegmentId { get { return @"OM6"; } }
        
        public string LongName { get { return @"Observations That Are Calculated From Other Obersvations"; } }
        
        public string Description { get { return @"This segment contains information about quantities that are derived from one or more other quantities or direct observations by mathematical or logical means"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V22SegmentOM6(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _segmentTypeId;

public HL7V22Field SegmentTypeId
{
    get
    {
        if (_segmentTypeId != null)
        {
            return _segmentTypeId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM6.1",
            Type = @"Field",
            Position = @"OM6.1",
            Name = @"Segment Type Id",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"the string OM6 - identifies a record as an observation that is derived or calculated from one or more other observations",
            Sample = @"",
            Fields = null
        }

        _segmentTypeId = new HL7V22Field
        {
            field = message[@"OM6"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_segmentTypeId.field.FieldRepetitions != null && _segmentTypeId.field.FieldRepetitions.Count > 0)
        {
            _segmentTypeId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_segmentTypeId, fieldData);
        }

        return _segmentTypeId;
    } 
}

internal HL7V22Field _sequenceNumberTestObservationMasterFile;

public HL7V22Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (_sequenceNumberTestObservationMasterFile != null)
        {
            return _sequenceNumberTestObservationMasterFile;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM6.2",
            Type = @"Field",
            Position = @"OM6.2",
            Name = @"Sequence Number - Test/ Observation Master File",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"the same value as the sequence number of the associated OM1 segment",
            Sample = @"",
            Fields = null
        }

        _sequenceNumberTestObservationMasterFile = new HL7V22Field
        {
            field = message[@"OM6"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumberTestObservationMasterFile.field.FieldRepetitions != null && _sequenceNumberTestObservationMasterFile.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumberTestObservationMasterFile.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_sequenceNumberTestObservationMasterFile, fieldData);
        }

        return _sequenceNumberTestObservationMasterFile;
    } 
}

internal HL7V22Field _derivationRule;

public HL7V22Field DerivationRule
{
    get
    {
        if (_derivationRule != null)
        {
            return _derivationRule;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM6.3",
            Type = @"Field",
            Position = @"OM6.3",
            Name = @"Derivation Rule",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"in the case of patient variables that are derived from one or more other patient variables (e.g., creatinine clearance, ideal weight, maximum daily temperature, average glucose, framingham risk), this field contains the rules for deriving the value of this variable (i.e., nature code C, as given in OM1-19-nature of test/observation).  These can be described in terms of humanly understandable formulas or descriptions",
            Sample = @"",
            Fields = null
        }

        _derivationRule = new HL7V22Field
        {
            field = message[@"OM6"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_derivationRule.field.FieldRepetitions != null && _derivationRule.field.FieldRepetitions.Count > 0)
        {
            _derivationRule.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_derivationRule, fieldData);
        }

        return _derivationRule;
    } 
}
    }
}
