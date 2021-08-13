using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27SegmentRFI
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RFI"; } }

        public string SegmentId { get { return @"RFI"; } }
        
        public string LongName { get { return @"Request For Information"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",

                    };
            }
        }

        public HL7V27SegmentRFI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V27Field _requestDate;

public HL7V27Field RequestDate
{
    get
    {
        if (_requestDate != null)
        {
            return _requestDate;
        }

        var fieldData = new HL7V27FieldData
        {
            Id = @"RFI.1",
            Type = @"Field",
            Position = @"RFI.1",
            Name = @"Request Date",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _requestDate = new HL7V27Field
        {
            field = message[@"RFI"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestDate.field.FieldRepetitions != null && _requestDate.field.FieldRepetitions.Count > 0)
        {
            _requestDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(_requestDate, fieldData);
        }

        return _requestDate;
    } 
}

internal HL7V27Field _responseDueDate;

public HL7V27Field ResponseDueDate
{
    get
    {
        if (_responseDueDate != null)
        {
            return _responseDueDate;
        }

        var fieldData = new HL7V27FieldData
        {
            Id = @"RFI.2",
            Type = @"Field",
            Position = @"RFI.2",
            Name = @"Response Due Date",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"The latest date by which the additional information is to be returned to requestor.",
            Sample = @"",
            Fields = null
        }

        _responseDueDate = new HL7V27Field
        {
            field = message[@"RFI"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_responseDueDate.field.FieldRepetitions != null && _responseDueDate.field.FieldRepetitions.Count > 0)
        {
            _responseDueDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(_responseDueDate, fieldData);
        }

        return _responseDueDate;
    } 
}

internal HL7V27Field _patientConsent;

public HL7V27Field PatientConsent
{
    get
    {
        if (_patientConsent != null)
        {
            return _patientConsent;
        }

        var fieldData = new HL7V27FieldData
        {
            Id = @"RFI.3",
            Type = @"Field",
            Position = @"RFI.3",
            Name = @"Patient Consent",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0136",
            TableName = @"Yes/no Indicator",
            Description = @"Code indicating if the Payer has obtained patient consent for release of information (1) – Optional.  Refer to HL7 Table 0136 – Yes/No Indicator for suggested values.",
            Sample = @"",
            Fields = null
        }

        _patientConsent = new HL7V27Field
        {
            field = message[@"RFI"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientConsent.field.FieldRepetitions != null && _patientConsent.field.FieldRepetitions.Count > 0)
        {
            _patientConsent.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(_patientConsent, fieldData);
        }

        return _patientConsent;
    } 
}

internal HL7V27Field _dateAdditionalInformationWasSubmitted;

public HL7V27Field DateAdditionalInformationWasSubmitted
{
    get
    {
        if (_dateAdditionalInformationWasSubmitted != null)
        {
            return _dateAdditionalInformationWasSubmitted;
        }

        var fieldData = new HL7V27FieldData
        {
            Id = @"RFI.4",
            Type = @"Field",
            Position = @"RFI.4",
            Name = @"Date Additional Information Was Submitted",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"The date on which the information was assembled for transmission to the Payer.  Not necessarily the same as the message date.",
            Sample = @"",
            Fields = null
        }

        _dateAdditionalInformationWasSubmitted = new HL7V27Field
        {
            field = message[@"RFI"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateAdditionalInformationWasSubmitted.field.FieldRepetitions != null && _dateAdditionalInformationWasSubmitted.field.FieldRepetitions.Count > 0)
        {
            _dateAdditionalInformationWasSubmitted.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(_dateAdditionalInformationWasSubmitted, fieldData);
        }

        return _dateAdditionalInformationWasSubmitted;
    } 
}
    }
}
