using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentOM6
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM6"; } }

        public string SegmentId { get { return @"OM6"; } }
        
        public string LongName { get { return @"Observations That Are Calculated From Other Observations"; } }
        
        public string Description { get { return @"This segment contains the information about quantities that are derived from one or more other quantities or direct observations by mathematical or logical means."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V28SegmentOM6(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field _sequenceNumberTestObservationMasterFile;

public HL7V28Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (_sequenceNumberTestObservationMasterFile != null)
        {
            return _sequenceNumberTestObservationMasterFile;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"OM6.1",
            Type = @"Field",
            Position = @"OM6.1",
            Name = @"Sequence Number - Test/Observation Master File",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the same value as the sequence number of the associated OM1 segment.",
            Sample = @"",
            Fields = null
        }

        _sequenceNumberTestObservationMasterFile = new HL7V28Field
        {
            field = message[@"OM6"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumberTestObservationMasterFile.field.FieldRepetitions != null && _sequenceNumberTestObservationMasterFile.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumberTestObservationMasterFile.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_sequenceNumberTestObservationMasterFile, fieldData);
        }

        return _sequenceNumberTestObservationMasterFile;
    } 
}

internal HL7V28Field _derivationRule;

public HL7V28Field DerivationRule
{
    get
    {
        if (_derivationRule != null)
        {
            return _derivationRule;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"OM6.2",
            Type = @"Field",
            Position = @"OM6.2",
            Name = @"Derivation Rule",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the observations whose categorical responses are taken from a specified table of codes (e.g., CWE data types).  Record the preferred coding system for this observation (e.g., ICD9, SNOMED III).  Take the codes from ASTM Table 3 or 5, or specify a local code.",
            Sample = @"",
            Fields = null
        }

        _derivationRule = new HL7V28Field
        {
            field = message[@"OM6"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_derivationRule.field.FieldRepetitions != null && _derivationRule.field.FieldRepetitions.Count > 0)
        {
            _derivationRule.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_derivationRule, fieldData);
        }

        return _derivationRule;
    } 
}
    }
}
