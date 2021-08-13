using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentMRG
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MRG"; } }

        public string SegmentId { get { return @"MRG"; } }
        
        public string LongName { get { return @"Merge Patient Information"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentMRG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _priorPatientIdInternal;

public HL7V21Field PriorPatientIdInternal
{
    get
    {
        if (_priorPatientIdInternal != null)
        {
            return _priorPatientIdInternal;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MRG.1",
            Type = @"Field",
            Position = @"MRG.1",
            Name = @"Prior Patient Id - Internal",
            Length = 16,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _priorPatientIdInternal = new HL7V21Field
        {
            field = message[@"MRG"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorPatientIdInternal.field.FieldRepetitions != null && _priorPatientIdInternal.field.FieldRepetitions.Count > 0)
        {
            _priorPatientIdInternal.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_priorPatientIdInternal, fieldData);
        }

        return _priorPatientIdInternal;
    } 
}

internal HL7V21Field _priorAlternatePatientId;

public HL7V21Field PriorAlternatePatientId
{
    get
    {
        if (_priorAlternatePatientId != null)
        {
            return _priorAlternatePatientId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MRG.2",
            Type = @"Field",
            Position = @"MRG.2",
            Name = @"Prior Alternate Patient Id",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _priorAlternatePatientId = new HL7V21Field
        {
            field = message[@"MRG"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorAlternatePatientId.field.FieldRepetitions != null && _priorAlternatePatientId.field.FieldRepetitions.Count > 0)
        {
            _priorAlternatePatientId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_priorAlternatePatientId, fieldData);
        }

        return _priorAlternatePatientId;
    } 
}

internal HL7V21Field _priorPatientAccountNumber;

public HL7V21Field PriorPatientAccountNumber
{
    get
    {
        if (_priorPatientAccountNumber != null)
        {
            return _priorPatientAccountNumber;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MRG.3",
            Type = @"Field",
            Position = @"MRG.3",
            Name = @"Prior Patient Account Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _priorPatientAccountNumber = new HL7V21Field
        {
            field = message[@"MRG"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorPatientAccountNumber.field.FieldRepetitions != null && _priorPatientAccountNumber.field.FieldRepetitions.Count > 0)
        {
            _priorPatientAccountNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_priorPatientAccountNumber, fieldData);
        }

        return _priorPatientAccountNumber;
    } 
}
    }
}
