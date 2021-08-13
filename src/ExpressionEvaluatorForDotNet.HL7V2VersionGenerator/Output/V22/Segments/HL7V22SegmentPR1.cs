using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentPR1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PR1"; } }

        public string SegmentId { get { return @"PR1"; } }
        
        public string LongName { get { return @"Procedures"; } }
        
        public string Description { get { return @"The PR1 segment contains information relative to various types of procedures that can be performed on a patient.  For example: Surgical, Nuclear Medicine, X-Ray with contrast, etc"; } }
        
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

        public HL7V22SegmentPR1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdProcedure;

public HL7V22Field SetIdProcedure
{
    get
    {
        if (_setIdProcedure != null)
        {
            return _setIdProcedure;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PR1.1",
            Type = @"Field",
            Position = @"PR1.1",
            Name = @"Set Id - Procedure",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"unique number that is used to identify a transaction for the purpose of adding, changing or deleting entries. ",
            Sample = @"",
            Fields = null
        }

        _setIdProcedure = new HL7V22Field
        {
            field = message[@"PR1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdProcedure.field.FieldRepetitions != null && _setIdProcedure.field.FieldRepetitions.Count > 0)
        {
            _setIdProcedure.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdProcedure, fieldData);
        }

        return _setIdProcedure;
    } 
}

internal HL7V22Field _procedureCodingMethod;

public HL7V22Field ProcedureCodingMethod
{
    get
    {
        if (_procedureCodingMethod != null)
        {
            return _procedureCodingMethod;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PR1.2",
            Type = @"Field",
            Position = @"PR1.2",
            Name = @"Procedure Coding Method",
            Length = 2,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0089",
            TableName = @"PROCEDURE CODING METHOD",
            Description = @"methodology used to assign a code to the procedure (CPT4 for example).  If more than one coding method is needed for a single procedure,  this field and associated PR1-3-procedure code and PR1-4procedure description may repeat.  In this instance, the three fields (PR1-2 through 4) are directly associated with one another.  Refer to user-defined table 0089 - procedure coding method for suggested values",
            Sample = @"",
            Fields = null
        }

        _procedureCodingMethod = new HL7V22Field
        {
            field = message[@"PR1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCodingMethod.field.FieldRepetitions != null && _procedureCodingMethod.field.FieldRepetitions.Count > 0)
        {
            _procedureCodingMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_procedureCodingMethod, fieldData);
        }

        return _procedureCodingMethod;
    } 
}

internal HL7V22Field _procedureCode;

public HL7V22Field ProcedureCode
{
    get
    {
        if (_procedureCode != null)
        {
            return _procedureCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PR1.3",
            Type = @"Field",
            Position = @"PR1.3",
            Name = @"Procedure Code",
            Length = 10,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0088",
            TableName = @"PROCEDURE CODE",
            Description = @"unique identifier assigned to the procedure.  Refer to user-defined table 0088 - procedure code for suggested values",
            Sample = @"",
            Fields = null
        }

        _procedureCode = new HL7V22Field
        {
            field = message[@"PR1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCode.field.FieldRepetitions != null && _procedureCode.field.FieldRepetitions.Count > 0)
        {
            _procedureCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_procedureCode, fieldData);
        }

        return _procedureCode;
    } 
}

internal HL7V22Field _procedureDescription;

public HL7V22Field ProcedureDescription
{
    get
    {
        if (_procedureDescription != null)
        {
            return _procedureDescription;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PR1.4",
            Type = @"Field",
            Position = @"PR1.4",
            Name = @"Procedure Description",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"text description that describes the procedure",
            Sample = @"",
            Fields = null
        }

        _procedureDescription = new HL7V22Field
        {
            field = message[@"PR1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureDescription.field.FieldRepetitions != null && _procedureDescription.field.FieldRepetitions.Count > 0)
        {
            _procedureDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_procedureDescription, fieldData);
        }

        return _procedureDescription;
    } 
}

internal HL7V22Field _procedureDateTime;

public HL7V22Field ProcedureDateTime
{
    get
    {
        if (_procedureDateTime != null)
        {
            return _procedureDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PR1.5",
            Type = @"Field",
            Position = @"PR1.5",
            Name = @"Procedure Date / Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time the procedure was performed",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.5.1",
                            Type = @"Component",
                            Position = @"PR1.5.1",
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
                            Id = @"PR1.5.2",
                            Type = @"Component",
                            Position = @"PR1.5.2",
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

        _procedureDateTime = new HL7V22Field
        {
            field = message[@"PR1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureDateTime.field.FieldRepetitions != null && _procedureDateTime.field.FieldRepetitions.Count > 0)
        {
            _procedureDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_procedureDateTime, fieldData);
        }

        return _procedureDateTime;
    } 
}

internal HL7V22Field _procedureType;

public HL7V22Field ProcedureType
{
    get
    {
        if (_procedureType != null)
        {
            return _procedureType;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"optional code that further defines the type of procedure.  Refer to user-defined table 0090 - procedure type for suggested values",
            Sample = @"",
            Fields = null
        }

        _procedureType = new HL7V22Field
        {
            field = message[@"PR1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureType.field.FieldRepetitions != null && _procedureType.field.FieldRepetitions.Count > 0)
        {
            _procedureType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_procedureType, fieldData);
        }

        return _procedureType;
    } 
}

internal HL7V22Field _procedureMinutes;

public HL7V22Field ProcedureMinutes
{
    get
    {
        if (_procedureMinutes != null)
        {
            return _procedureMinutes;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"length of time in whole minutes that the procedure took to complete",
            Sample = @"",
            Fields = null
        }

        _procedureMinutes = new HL7V22Field
        {
            field = message[@"PR1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureMinutes.field.FieldRepetitions != null && _procedureMinutes.field.FieldRepetitions.Count > 0)
        {
            _procedureMinutes.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_procedureMinutes, fieldData);
        }

        return _procedureMinutes;
    } 
}

internal HL7V22Field _anesthesiologist;

public HL7V22Field Anesthesiologist
{
    get
    {
        if (_anesthesiologist != null)
        {
            return _anesthesiologist;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PR1.8",
            Type = @"Field",
            Position = @"PR1.8",
            Name = @"Anesthesiologist",
            Length = 60,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = @"Anesthesiologist who administered the anesthesia.  It is recommended that PR1-12-procedure MD be used instead of this field.  This field remains only for backward compatibility.  Refer to user-defined table 0010 - physician ID. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.8.1",
                            Type = @"Component",
                            Position = @"PR1.8.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.2",
                            Type = @"Component",
                            Position = @"PR1.8.2",
                            Name = @"Familiy Name",
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
                            Id = @"PR1.8.3",
                            Type = @"Component",
                            Position = @"PR1.8.3",
                            Name = @"Given Name",
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
                            Id = @"PR1.8.4",
                            Type = @"Component",
                            Position = @"PR1.8.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"PR1.8.5",
                            Type = @"Component",
                            Position = @"PR1.8.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"PR1.8.6",
                            Type = @"Component",
                            Position = @"PR1.8.6",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"PR1.8.7",
                            Type = @"Component",
                            Position = @"PR1.8.7",
                            Name = @"Degree (e.g. Md)",
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
                            Id = @"PR1.8.8",
                            Type = @"Component",
                            Position = @"PR1.8.8",
                            Name = @"Source Table Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _anesthesiologist = new HL7V22Field
        {
            field = message[@"PR1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiologist.field.FieldRepetitions != null && _anesthesiologist.field.FieldRepetitions.Count > 0)
        {
            _anesthesiologist.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_anesthesiologist, fieldData);
        }

        return _anesthesiologist;
    } 
}

internal HL7V22Field _anesthesiaCode;

public HL7V22Field AnesthesiaCode
{
    get
    {
        if (_anesthesiaCode != null)
        {
            return _anesthesiaCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PR1.9",
            Type = @"Field",
            Position = @"PR1.9",
            Name = @"Anesthesia Code",
            Length = 2,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0019",
            TableName = @"ANESTHESIA CODE",
            Description = @"uniquely identifies the anesthesia used during the procedure.  It is recommended that PR1-12-procedure MD be used instead of this field.  This field remains only for backward compatibility",
            Sample = @"",
            Fields = null
        }

        _anesthesiaCode = new HL7V22Field
        {
            field = message[@"PR1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiaCode.field.FieldRepetitions != null && _anesthesiaCode.field.FieldRepetitions.Count > 0)
        {
            _anesthesiaCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_anesthesiaCode, fieldData);
        }

        return _anesthesiaCode;
    } 
}

internal HL7V22Field _anesthesiaMinutes;

public HL7V22Field AnesthesiaMinutes
{
    get
    {
        if (_anesthesiaMinutes != null)
        {
            return _anesthesiaMinutes;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"length of time in minutes that the anesthesia was administered",
            Sample = @"",
            Fields = null
        }

        _anesthesiaMinutes = new HL7V22Field
        {
            field = message[@"PR1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiaMinutes.field.FieldRepetitions != null && _anesthesiaMinutes.field.FieldRepetitions.Count > 0)
        {
            _anesthesiaMinutes.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_anesthesiaMinutes, fieldData);
        }

        return _anesthesiaMinutes;
    } 
}

internal HL7V22Field _surgeon;

public HL7V22Field Surgeon
{
    get
    {
        if (_surgeon != null)
        {
            return _surgeon;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PR1.11",
            Type = @"Field",
            Position = @"PR1.11",
            Name = @"Surgeon",
            Length = 60,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = @"surgeon who performed the procedure. It is recommended that PR1-12-procedure MD be used instead of this field.  This field remains only for backward compatibility.  Refer to user-defined table 0010 - physician ID",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.11.1",
                            Type = @"Component",
                            Position = @"PR1.11.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.2",
                            Type = @"Component",
                            Position = @"PR1.11.2",
                            Name = @"Familiy Name",
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
                            Id = @"PR1.11.3",
                            Type = @"Component",
                            Position = @"PR1.11.3",
                            Name = @"Given Name",
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
                            Id = @"PR1.11.4",
                            Type = @"Component",
                            Position = @"PR1.11.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"PR1.11.5",
                            Type = @"Component",
                            Position = @"PR1.11.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"PR1.11.6",
                            Type = @"Component",
                            Position = @"PR1.11.6",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"PR1.11.7",
                            Type = @"Component",
                            Position = @"PR1.11.7",
                            Name = @"Degree (e.g. Md)",
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
                            Id = @"PR1.11.8",
                            Type = @"Component",
                            Position = @"PR1.11.8",
                            Name = @"Source Table Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _surgeon = new HL7V22Field
        {
            field = message[@"PR1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_surgeon.field.FieldRepetitions != null && _surgeon.field.FieldRepetitions.Count > 0)
        {
            _surgeon.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_surgeon, fieldData);
        }

        return _surgeon;
    } 
}

internal HL7V22Field _procedurePractitioner;

public HL7V22Field ProcedurePractitioner
{
    get
    {
        if (_procedurePractitioner != null)
        {
            return _procedurePractitioner;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PR1.12",
            Type = @"Field",
            Position = @"PR1.12",
            Name = @"Procedure Practitioner",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_PRACTITIONER",
            DataTypeName = @"Action Carried Out By",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = @"different types of practitioners associated with this procedure.  The ID and name components follow the standard rules defined for a composite name (CN) field.  If the procedure type component is unvalued, it is assumed that the physician identified is a resident.  Refer to user-defined table 0010 - physician ID.  Refer to user-defined table 0133 - procedure practitioner type for suggested entries. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.12.1",
                            Type = @"Component",
                            Position = @"PR1.12.1",
                            Name = @"Procedure Practitioner  Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.12.1.1",
                            Type = @"SubComponent",
                            Position = @"PR1.12.1.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.1.2",
                            Type = @"SubComponent",
                            Position = @"PR1.12.1.2",
                            Name = @"Familiy Name",
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
                            Id = @"PR1.12.1.3",
                            Type = @"SubComponent",
                            Position = @"PR1.12.1.3",
                            Name = @"Given Name",
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
                            Id = @"PR1.12.1.4",
                            Type = @"SubComponent",
                            Position = @"PR1.12.1.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"PR1.12.1.5",
                            Type = @"SubComponent",
                            Position = @"PR1.12.1.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"PR1.12.1.6",
                            Type = @"SubComponent",
                            Position = @"PR1.12.1.6",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"PR1.12.1.7",
                            Type = @"SubComponent",
                            Position = @"PR1.12.1.7",
                            Name = @"Degree (e.g. Md)",
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
                            Id = @"PR1.12.1.8",
                            Type = @"SubComponent",
                            Position = @"PR1.12.1.8",
                            Name = @"Source Table Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.2",
                            Type = @"Component",
                            Position = @"PR1.12.2",
                            Name = @"Procedure Practitioner Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _procedurePractitioner = new HL7V22Field
        {
            field = message[@"PR1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedurePractitioner.field.FieldRepetitions != null && _procedurePractitioner.field.FieldRepetitions.Count > 0)
        {
            _procedurePractitioner.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_procedurePractitioner, fieldData);
        }

        return _procedurePractitioner;
    } 
}

internal HL7V22Field _consentCode;

public HL7V22Field ConsentCode
{
    get
    {
        if (_consentCode != null)
        {
            return _consentCode;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"type of consent that was obtained for permission to treat the patient.  Refer to user-defined table 0059 - consent code",
            Sample = @"",
            Fields = null
        }

        _consentCode = new HL7V22Field
        {
            field = message[@"PR1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_consentCode.field.FieldRepetitions != null && _consentCode.field.FieldRepetitions.Count > 0)
        {
            _consentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_consentCode, fieldData);
        }

        return _consentCode;
    } 
}

internal HL7V22Field _procedurePriority;

public HL7V22Field ProcedurePriority
{
    get
    {
        if (_procedurePriority != null)
        {
            return _procedurePriority;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PR1.14",
            Type = @"Field",
            Position = @"PR1.14",
            Name = @"Procedure Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"number which identifies the significance or priority of the procedure code",
            Sample = @"",
            Fields = null
        }

        _procedurePriority = new HL7V22Field
        {
            field = message[@"PR1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedurePriority.field.FieldRepetitions != null && _procedurePriority.field.FieldRepetitions.Count > 0)
        {
            _procedurePriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_procedurePriority, fieldData);
        }

        return _procedurePriority;
    } 
}
    }
}
