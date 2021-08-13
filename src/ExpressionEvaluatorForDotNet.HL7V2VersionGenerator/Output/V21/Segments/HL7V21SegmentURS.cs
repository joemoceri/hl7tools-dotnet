using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentURS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"URS"; } }

        public string SegmentId { get { return @"URS"; } }
        
        public string LongName { get { return @"Unsolicited Selection"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentURS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _rUWhereSubjectDefinition;

public HL7V21Field RUWhereSubjectDefinition
{
    get
    {
        if (_rUWhereSubjectDefinition != null)
        {
            return _rUWhereSubjectDefinition;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URS.1",
            Type = @"Field",
            Position = @"URS.1",
            Name = @"R/U Where Subject Definition",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _rUWhereSubjectDefinition = new HL7V21Field
        {
            field = message[@"URS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhereSubjectDefinition.field.FieldRepetitions != null && _rUWhereSubjectDefinition.field.FieldRepetitions.Count > 0)
        {
            _rUWhereSubjectDefinition.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rUWhereSubjectDefinition, fieldData);
        }

        return _rUWhereSubjectDefinition;
    } 
}

internal HL7V21Field _rUWhenDataStartDateTime;

public HL7V21Field RUWhenDataStartDateTime
{
    get
    {
        if (_rUWhenDataStartDateTime != null)
        {
            return _rUWhenDataStartDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URS.2",
            Type = @"Field",
            Position = @"URS.2",
            Name = @"R/U When Data Start Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _rUWhenDataStartDateTime = new HL7V21Field
        {
            field = message[@"URS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhenDataStartDateTime.field.FieldRepetitions != null && _rUWhenDataStartDateTime.field.FieldRepetitions.Count > 0)
        {
            _rUWhenDataStartDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rUWhenDataStartDateTime, fieldData);
        }

        return _rUWhenDataStartDateTime;
    } 
}

internal HL7V21Field _rUWhenDataEndDateTime;

public HL7V21Field RUWhenDataEndDateTime
{
    get
    {
        if (_rUWhenDataEndDateTime != null)
        {
            return _rUWhenDataEndDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URS.3",
            Type = @"Field",
            Position = @"URS.3",
            Name = @"R/U When Data End Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _rUWhenDataEndDateTime = new HL7V21Field
        {
            field = message[@"URS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhenDataEndDateTime.field.FieldRepetitions != null && _rUWhenDataEndDateTime.field.FieldRepetitions.Count > 0)
        {
            _rUWhenDataEndDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rUWhenDataEndDateTime, fieldData);
        }

        return _rUWhenDataEndDateTime;
    } 
}

internal HL7V21Field _rUWhatUserQualifier;

public HL7V21Field RUWhatUserQualifier
{
    get
    {
        if (_rUWhatUserQualifier != null)
        {
            return _rUWhatUserQualifier;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URS.4",
            Type = @"Field",
            Position = @"URS.4",
            Name = @"R/U What User Qualifier",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _rUWhatUserQualifier = new HL7V21Field
        {
            field = message[@"URS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhatUserQualifier.field.FieldRepetitions != null && _rUWhatUserQualifier.field.FieldRepetitions.Count > 0)
        {
            _rUWhatUserQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rUWhatUserQualifier, fieldData);
        }

        return _rUWhatUserQualifier;
    } 
}

internal HL7V21Field _rUOtherResultsSubjectDefini;

public HL7V21Field RUOtherResultsSubjectDefini
{
    get
    {
        if (_rUOtherResultsSubjectDefini != null)
        {
            return _rUOtherResultsSubjectDefini;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URS.5",
            Type = @"Field",
            Position = @"URS.5",
            Name = @"R/U Other Results Subject Defini",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _rUOtherResultsSubjectDefini = new HL7V21Field
        {
            field = message[@"URS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUOtherResultsSubjectDefini.field.FieldRepetitions != null && _rUOtherResultsSubjectDefini.field.FieldRepetitions.Count > 0)
        {
            _rUOtherResultsSubjectDefini.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rUOtherResultsSubjectDefini, fieldData);
        }

        return _rUOtherResultsSubjectDefini;
    } 
}
    }
}
