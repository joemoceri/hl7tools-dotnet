using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentRFI
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RFI"; } }

        public string SegmentId { get { return @"RFI"; } }
        
        public string LongName { get { return @"Request for Information"; } }
        
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

        public HL7V26SegmentRFI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _requestDate;

public HL7V26Field RequestDate
{
    get
    {
        if (_requestDate != null)
        {
            return _requestDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RFI.1",
            Type = @"Field",
            Position = @"RFI.1",
            Name = @"Request Date",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _requestDate = new HL7V26Field
        {
            field = message[@"RFI"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestDate.field.FieldRepetitions != null && _requestDate.field.FieldRepetitions.Count > 0)
        {
            _requestDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_requestDate, fieldData);
        }

        return _requestDate;
    } 
}

internal HL7V26Field _responseDueDate;

public HL7V26Field ResponseDueDate
{
    get
    {
        if (_responseDueDate != null)
        {
            return _responseDueDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RFI.2",
            Type = @"Field",
            Position = @"RFI.2",
            Name = @"Response Due Date",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"The latest date by which the additional information is to be returned to requestor.",
            Sample = @"",
            Fields = null
        }

        _responseDueDate = new HL7V26Field
        {
            field = message[@"RFI"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_responseDueDate.field.FieldRepetitions != null && _responseDueDate.field.FieldRepetitions.Count > 0)
        {
            _responseDueDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_responseDueDate, fieldData);
        }

        return _responseDueDate;
    } 
}

internal HL7V26Field _patientConsent;

public HL7V26Field PatientConsent
{
    get
    {
        if (_patientConsent != null)
        {
            return _patientConsent;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RFI.3",
            Type = @"Field",
            Position = @"RFI.3",
            Name = @"Patient Consent",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Code indicating if the Payer has obtained patient consent for release of information (1) - Optional. Refer to HL7-Table 0136 - Yes/No-Indicator for suggested values.",
            Sample = @"",
            Fields = null
        }

        _patientConsent = new HL7V26Field
        {
            field = message[@"RFI"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientConsent.field.FieldRepetitions != null && _patientConsent.field.FieldRepetitions.Count > 0)
        {
            _patientConsent.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_patientConsent, fieldData);
        }

        return _patientConsent;
    } 
}

internal HL7V26Field _dateAdditionalInformationwassubmitted;

public HL7V26Field DateAdditionalInformationwassubmitted
{
    get
    {
        if (_dateAdditionalInformationwassubmitted != null)
        {
            return _dateAdditionalInformationwassubmitted;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RFI.4",
            Type = @"Field",
            Position = @"RFI.4",
            Name = @"Date Additional Information was submitted",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"The date on which the information was assembled for transmission to the Payer. Not necessarily the same as the message date.",
            Sample = @"",
            Fields = null
        }

        _dateAdditionalInformationwassubmitted = new HL7V26Field
        {
            field = message[@"RFI"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateAdditionalInformationwassubmitted.field.FieldRepetitions != null && _dateAdditionalInformationwassubmitted.field.FieldRepetitions.Count > 0)
        {
            _dateAdditionalInformationwassubmitted.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_dateAdditionalInformationwassubmitted, fieldData);
        }

        return _dateAdditionalInformationwassubmitted;
    } 
}
    }
}
