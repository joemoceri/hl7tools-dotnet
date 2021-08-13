using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentURD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"URD"; } }

        public string SegmentId { get { return @"URD"; } }
        
        public string LongName { get { return @"Results/update Definition"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentURD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _rUDateTime;

public HL7V21Field RUDateTime
{
    get
    {
        if (_rUDateTime != null)
        {
            return _rUDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URD.1",
            Type = @"Field",
            Position = @"URD.1",
            Name = @"R/U Date/Time",
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

        _rUDateTime = new HL7V21Field
        {
            field = message[@"URD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUDateTime.field.FieldRepetitions != null && _rUDateTime.field.FieldRepetitions.Count > 0)
        {
            _rUDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rUDateTime, fieldData);
        }

        return _rUDateTime;
    } 
}

internal HL7V21Field _reportPriority;

public HL7V21Field ReportPriority
{
    get
    {
        if (_reportPriority != null)
        {
            return _reportPriority;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URD.2",
            Type = @"Field",
            Position = @"URD.2",
            Name = @"Report Priority",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0109",
            TableName = @"REPORT PRIORITY",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _reportPriority = new HL7V21Field
        {
            field = message[@"URD"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportPriority.field.FieldRepetitions != null && _reportPriority.field.FieldRepetitions.Count > 0)
        {
            _reportPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_reportPriority, fieldData);
        }

        return _reportPriority;
    } 
}

internal HL7V21Field _rUWhoSubjectDefinition;

public HL7V21Field RUWhoSubjectDefinition
{
    get
    {
        if (_rUWhoSubjectDefinition != null)
        {
            return _rUWhoSubjectDefinition;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URD.3",
            Type = @"Field",
            Position = @"URD.3",
            Name = @"R/U Who Subject Definition",
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

        _rUWhoSubjectDefinition = new HL7V21Field
        {
            field = message[@"URD"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhoSubjectDefinition.field.FieldRepetitions != null && _rUWhoSubjectDefinition.field.FieldRepetitions.Count > 0)
        {
            _rUWhoSubjectDefinition.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rUWhoSubjectDefinition, fieldData);
        }

        return _rUWhoSubjectDefinition;
    } 
}

internal HL7V21Field _rUWhatSubjectDefinition;

public HL7V21Field RUWhatSubjectDefinition
{
    get
    {
        if (_rUWhatSubjectDefinition != null)
        {
            return _rUWhatSubjectDefinition;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URD.4",
            Type = @"Field",
            Position = @"URD.4",
            Name = @"R/U What Subject Definition",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0048",
            TableName = @"WHAT SUBJECT FILTER",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _rUWhatSubjectDefinition = new HL7V21Field
        {
            field = message[@"URD"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhatSubjectDefinition.field.FieldRepetitions != null && _rUWhatSubjectDefinition.field.FieldRepetitions.Count > 0)
        {
            _rUWhatSubjectDefinition.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rUWhatSubjectDefinition, fieldData);
        }

        return _rUWhatSubjectDefinition;
    } 
}

internal HL7V21Field _rUWhatDepartmentCode;

public HL7V21Field RUWhatDepartmentCode
{
    get
    {
        if (_rUWhatDepartmentCode != null)
        {
            return _rUWhatDepartmentCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URD.5",
            Type = @"Field",
            Position = @"URD.5",
            Name = @"R/U What Department Code",
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

        _rUWhatDepartmentCode = new HL7V21Field
        {
            field = message[@"URD"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhatDepartmentCode.field.FieldRepetitions != null && _rUWhatDepartmentCode.field.FieldRepetitions.Count > 0)
        {
            _rUWhatDepartmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rUWhatDepartmentCode, fieldData);
        }

        return _rUWhatDepartmentCode;
    } 
}

internal HL7V21Field _rUDisplayPrintLocations;

public HL7V21Field RUDisplayPrintLocations
{
    get
    {
        if (_rUDisplayPrintLocations != null)
        {
            return _rUDisplayPrintLocations;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URD.6",
            Type = @"Field",
            Position = @"URD.6",
            Name = @"R/U Display/Print Locations",
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

        _rUDisplayPrintLocations = new HL7V21Field
        {
            field = message[@"URD"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUDisplayPrintLocations.field.FieldRepetitions != null && _rUDisplayPrintLocations.field.FieldRepetitions.Count > 0)
        {
            _rUDisplayPrintLocations.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rUDisplayPrintLocations, fieldData);
        }

        return _rUDisplayPrintLocations;
    } 
}

internal HL7V21Field _rUResultsLevel;

public HL7V21Field RUResultsLevel
{
    get
    {
        if (_rUResultsLevel != null)
        {
            return _rUResultsLevel;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"URD.7",
            Type = @"Field",
            Position = @"URD.7",
            Name = @"R/U Results Level",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0108",
            TableName = @"QUERY RESULTS LEVEL",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _rUResultsLevel = new HL7V21Field
        {
            field = message[@"URD"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUResultsLevel.field.FieldRepetitions != null && _rUResultsLevel.field.FieldRepetitions.Count > 0)
        {
            _rUResultsLevel.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rUResultsLevel, fieldData);
        }

        return _rUResultsLevel;
    } 
}
    }
}
