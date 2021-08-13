using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentPR1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PR1"; } }

        public string SegmentId { get { return @"PR1"; } }
        
        public string LongName { get { return @"Procedures"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentPR1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdProcedure;

public HL7V21Field SetIdProcedure
{
    get
    {
        if (_setIdProcedure != null)
        {
            return _setIdProcedure;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.1",
            Type = @"Field",
            Position = @"PR1.1",
            Name = @"Set Id - Procedure",
            Length = 4,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _setIdProcedure = new HL7V21Field
        {
            field = message[@"PR1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdProcedure.field.FieldRepetitions != null && _setIdProcedure.field.FieldRepetitions.Count > 0)
        {
            _setIdProcedure.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdProcedure, fieldData);
        }

        return _setIdProcedure;
    } 
}

internal HL7V21Field _procedureCodingMethod;

public HL7V21Field ProcedureCodingMethod
{
    get
    {
        if (_procedureCodingMethod != null)
        {
            return _procedureCodingMethod;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.2",
            Type = @"Field",
            Position = @"PR1.2",
            Name = @"Procedure Coding Method.",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0089",
            TableName = @"PROCEDURE CODING METHOD",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _procedureCodingMethod = new HL7V21Field
        {
            field = message[@"PR1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCodingMethod.field.FieldRepetitions != null && _procedureCodingMethod.field.FieldRepetitions.Count > 0)
        {
            _procedureCodingMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_procedureCodingMethod, fieldData);
        }

        return _procedureCodingMethod;
    } 
}

internal HL7V21Field _procedureCode;

public HL7V21Field ProcedureCode
{
    get
    {
        if (_procedureCode != null)
        {
            return _procedureCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.3",
            Type = @"Field",
            Position = @"PR1.3",
            Name = @"Procedure Code",
            Length = 10,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0088",
            TableName = @"PROCEDURE CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _procedureCode = new HL7V21Field
        {
            field = message[@"PR1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCode.field.FieldRepetitions != null && _procedureCode.field.FieldRepetitions.Count > 0)
        {
            _procedureCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_procedureCode, fieldData);
        }

        return _procedureCode;
    } 
}

internal HL7V21Field _procedureDescription;

public HL7V21Field ProcedureDescription
{
    get
    {
        if (_procedureDescription != null)
        {
            return _procedureDescription;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.4",
            Type = @"Field",
            Position = @"PR1.4",
            Name = @"Procedure Description",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _procedureDescription = new HL7V21Field
        {
            field = message[@"PR1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureDescription.field.FieldRepetitions != null && _procedureDescription.field.FieldRepetitions.Count > 0)
        {
            _procedureDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_procedureDescription, fieldData);
        }

        return _procedureDescription;
    } 
}

internal HL7V21Field _procedureDateTime;

public HL7V21Field ProcedureDateTime
{
    get
    {
        if (_procedureDateTime != null)
        {
            return _procedureDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.5",
            Type = @"Field",
            Position = @"PR1.5",
            Name = @"Procedure Date/Time",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _procedureDateTime = new HL7V21Field
        {
            field = message[@"PR1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureDateTime.field.FieldRepetitions != null && _procedureDateTime.field.FieldRepetitions.Count > 0)
        {
            _procedureDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_procedureDateTime, fieldData);
        }

        return _procedureDateTime;
    } 
}

internal HL7V21Field _procedureType;

public HL7V21Field ProcedureType
{
    get
    {
        if (_procedureType != null)
        {
            return _procedureType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.6",
            Type = @"Field",
            Position = @"PR1.6",
            Name = @"Procedure Type",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0090",
            TableName = @"PROCEDURE TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _procedureType = new HL7V21Field
        {
            field = message[@"PR1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureType.field.FieldRepetitions != null && _procedureType.field.FieldRepetitions.Count > 0)
        {
            _procedureType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_procedureType, fieldData);
        }

        return _procedureType;
    } 
}

internal HL7V21Field _procedureMinutes;

public HL7V21Field ProcedureMinutes
{
    get
    {
        if (_procedureMinutes != null)
        {
            return _procedureMinutes;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.7",
            Type = @"Field",
            Position = @"PR1.7",
            Name = @"Procedure Minutes",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _procedureMinutes = new HL7V21Field
        {
            field = message[@"PR1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureMinutes.field.FieldRepetitions != null && _procedureMinutes.field.FieldRepetitions.Count > 0)
        {
            _procedureMinutes.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_procedureMinutes, fieldData);
        }

        return _procedureMinutes;
    } 
}

internal HL7V21Field _anesthesiologist;

public HL7V21Field Anesthesiologist
{
    get
    {
        if (_anesthesiologist != null)
        {
            return _anesthesiologist;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.8",
            Type = @"Field",
            Position = @"PR1.8",
            Name = @"Anesthesiologist",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _anesthesiologist = new HL7V21Field
        {
            field = message[@"PR1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiologist.field.FieldRepetitions != null && _anesthesiologist.field.FieldRepetitions.Count > 0)
        {
            _anesthesiologist.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_anesthesiologist, fieldData);
        }

        return _anesthesiologist;
    } 
}

internal HL7V21Field _anesthesiaCode;

public HL7V21Field AnesthesiaCode
{
    get
    {
        if (_anesthesiaCode != null)
        {
            return _anesthesiaCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.9",
            Type = @"Field",
            Position = @"PR1.9",
            Name = @"Anesthesia Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0019",
            TableName = @"ANESTHESIA CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _anesthesiaCode = new HL7V21Field
        {
            field = message[@"PR1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiaCode.field.FieldRepetitions != null && _anesthesiaCode.field.FieldRepetitions.Count > 0)
        {
            _anesthesiaCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_anesthesiaCode, fieldData);
        }

        return _anesthesiaCode;
    } 
}

internal HL7V21Field _anesthesiaMinutes;

public HL7V21Field AnesthesiaMinutes
{
    get
    {
        if (_anesthesiaMinutes != null)
        {
            return _anesthesiaMinutes;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.10",
            Type = @"Field",
            Position = @"PR1.10",
            Name = @"Anesthesia Minutes",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _anesthesiaMinutes = new HL7V21Field
        {
            field = message[@"PR1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiaMinutes.field.FieldRepetitions != null && _anesthesiaMinutes.field.FieldRepetitions.Count > 0)
        {
            _anesthesiaMinutes.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_anesthesiaMinutes, fieldData);
        }

        return _anesthesiaMinutes;
    } 
}

internal HL7V21Field _surgeon;

public HL7V21Field Surgeon
{
    get
    {
        if (_surgeon != null)
        {
            return _surgeon;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.11",
            Type = @"Field",
            Position = @"PR1.11",
            Name = @"Surgeon",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _surgeon = new HL7V21Field
        {
            field = message[@"PR1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_surgeon.field.FieldRepetitions != null && _surgeon.field.FieldRepetitions.Count > 0)
        {
            _surgeon.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_surgeon, fieldData);
        }

        return _surgeon;
    } 
}

internal HL7V21Field _residentCode;

public HL7V21Field ResidentCode
{
    get
    {
        if (_residentCode != null)
        {
            return _residentCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.12",
            Type = @"Field",
            Position = @"PR1.12",
            Name = @"Resident Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _residentCode = new HL7V21Field
        {
            field = message[@"PR1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_residentCode.field.FieldRepetitions != null && _residentCode.field.FieldRepetitions.Count > 0)
        {
            _residentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_residentCode, fieldData);
        }

        return _residentCode;
    } 
}

internal HL7V21Field _consentCode;

public HL7V21Field ConsentCode
{
    get
    {
        if (_consentCode != null)
        {
            return _consentCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PR1.13",
            Type = @"Field",
            Position = @"PR1.13",
            Name = @"Consent Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0059",
            TableName = @"CONSENT CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _consentCode = new HL7V21Field
        {
            field = message[@"PR1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_consentCode.field.FieldRepetitions != null && _consentCode.field.FieldRepetitions.Count > 0)
        {
            _consentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_consentCode, fieldData);
        }

        return _consentCode;
    } 
}
    }
}
