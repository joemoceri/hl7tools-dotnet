using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentPR1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PR1"; } }

        public string SegmentId { get { return @"PR1"; } }
        
        public string LongName { get { return @"Procedures"; } }
        
        public string Description { get { return @"The PR1 segment contains information relative to various types of procedures that can be performed on a patient. The PR1 segment can be used to send procedure information, for example: Surgical, Nuclear Medicine, X-ray with contrast, etc. The PR1 segment is used to send multiple procedures, for example, for medical records encoding or for billing systems."; } }
        
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

        public HL7V26SegmentPR1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _setIDPR1;

public HL7V26Field SetIDPR1
{
    get
    {
        if (_setIDPR1 != null)
        {
            return _setIDPR1;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.1",
            Type = @"Field",
            Position = @"PR1.1",
            Name = @"Set ID - PR1",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc.",
            Sample = @"",
            Fields = null
        }

        _setIDPR1 = new HL7V26Field
        {
            field = message[@"PR1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDPR1.field.FieldRepetitions != null && _setIDPR1.field.FieldRepetitions.Count > 0)
        {
            _setIDPR1.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_setIDPR1, fieldData);
        }

        return _setIDPR1;
    } 
}

internal HL7V26Field _procedureCodingMethod;

public HL7V26Field ProcedureCodingMethod
{
    get
    {
        if (_procedureCodingMethod != null)
        {
            return _procedureCodingMethod;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.2",
            Type = @"Field",
            Position = @"PR1.2",
            Name = @"Procedure Coding Method",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"PR1-2 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
            Sample = @"",
            Fields = null
        }

        _procedureCodingMethod = new HL7V26Field
        {
            field = message[@"PR1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCodingMethod.field.FieldRepetitions != null && _procedureCodingMethod.field.FieldRepetitions.Count > 0)
        {
            _procedureCodingMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedureCodingMethod, fieldData);
        }

        return _procedureCodingMethod;
    } 
}

internal HL7V26Field _procedureCode;

public HL7V26Field ProcedureCode
{
    get
    {
        if (_procedureCode != null)
        {
            return _procedureCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.3",
            Type = @"Field",
            Position = @"PR1.3",
            Name = @"Procedure Code",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0088",
            TableName = @"Procedure Code",
            Description = @"This field contains a unique identifier assigned to the procedure. Refer to Externally-defined Table 0088 - Procedure Code for suggested values. This field is a CNE data type for compatibility with clinical and ancillary systems.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.3.1",
                            Type = @"Component",
                            Position = @"PR1.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.2",
                            Type = @"Component",
                            Position = @"PR1.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.3",
                            Type = @"Component",
                            Position = @"PR1.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.4",
                            Type = @"Component",
                            Position = @"PR1.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.5",
                            Type = @"Component",
                            Position = @"PR1.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.6",
                            Type = @"Component",
                            Position = @"PR1.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.7",
                            Type = @"Component",
                            Position = @"PR1.3.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.8",
                            Type = @"Component",
                            Position = @"PR1.3.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.9",
                            Type = @"Component",
                            Position = @"PR1.3.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _procedureCode = new HL7V26Field
        {
            field = message[@"PR1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCode.field.FieldRepetitions != null && _procedureCode.field.FieldRepetitions.Count > 0)
        {
            _procedureCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedureCode, fieldData);
        }

        return _procedureCode;
    } 
}

internal HL7V26Field _procedureDescription;

public HL7V26Field ProcedureDescription
{
    get
    {
        if (_procedureDescription != null)
        {
            return _procedureDescription;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.4",
            Type = @"Field",
            Position = @"PR1.4",
            Name = @"Procedure Description",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"PR1-4 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
            Sample = @"",
            Fields = null
        }

        _procedureDescription = new HL7V26Field
        {
            field = message[@"PR1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureDescription.field.FieldRepetitions != null && _procedureDescription.field.FieldRepetitions.Count > 0)
        {
            _procedureDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedureDescription, fieldData);
        }

        return _procedureDescription;
    } 
}

internal HL7V26Field _procedureDateTime;

public HL7V26Field ProcedureDateTime
{
    get
    {
        if (_procedureDateTime != null)
        {
            return _procedureDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.5",
            Type = @"Field",
            Position = @"PR1.5",
            Name = @"Procedure Date/Time",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the procedure was performed.",
            Sample = @"",
            Fields = null
        }

        _procedureDateTime = new HL7V26Field
        {
            field = message[@"PR1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureDateTime.field.FieldRepetitions != null && _procedureDateTime.field.FieldRepetitions.Count > 0)
        {
            _procedureDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedureDateTime, fieldData);
        }

        return _procedureDateTime;
    } 
}

internal HL7V26Field _procedureFunctionalType;

public HL7V26Field ProcedureFunctionalType
{
    get
    {
        if (_procedureFunctionalType != null)
        {
            return _procedureFunctionalType;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.6",
            Type = @"Field",
            Position = @"PR1.6",
            Name = @"Procedure Functional Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0230",
            TableName = @"Procedure Functional Type",
            Description = @"This field contains the optional code that further defines the type of procedure. Refer to User-defined Table 0230 - Procedure Functional Type for suggested values.",
            Sample = @"",
            Fields = null
        }

        _procedureFunctionalType = new HL7V26Field
        {
            field = message[@"PR1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureFunctionalType.field.FieldRepetitions != null && _procedureFunctionalType.field.FieldRepetitions.Count > 0)
        {
            _procedureFunctionalType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedureFunctionalType, fieldData);
        }

        return _procedureFunctionalType;
    } 
}

internal HL7V26Field _procedureMinutes;

public HL7V26Field ProcedureMinutes
{
    get
    {
        if (_procedureMinutes != null)
        {
            return _procedureMinutes;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"This field indicates the length of time in whole minutes that the procedure took to complete.",
            Sample = @"",
            Fields = null
        }

        _procedureMinutes = new HL7V26Field
        {
            field = message[@"PR1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureMinutes.field.FieldRepetitions != null && _procedureMinutes.field.FieldRepetitions.Count > 0)
        {
            _procedureMinutes.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedureMinutes, fieldData);
        }

        return _procedureMinutes;
    } 
}

internal HL7V26Field _anesthesiologist;

public HL7V26Field Anesthesiologist
{
    get
    {
        if (_anesthesiologist != null)
        {
            return _anesthesiologist;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.8",
            Type = @"Field",
            Position = @"PR1.8",
            Name = @"Anesthesiologist",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"PR1-8 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
            Sample = @"",
            Fields = null
        }

        _anesthesiologist = new HL7V26Field
        {
            field = message[@"PR1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiologist.field.FieldRepetitions != null && _anesthesiologist.field.FieldRepetitions.Count > 0)
        {
            _anesthesiologist.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_anesthesiologist, fieldData);
        }

        return _anesthesiologist;
    } 
}

internal HL7V26Field _anesthesiaCode;

public HL7V26Field AnesthesiaCode
{
    get
    {
        if (_anesthesiaCode != null)
        {
            return _anesthesiaCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.9",
            Type = @"Field",
            Position = @"PR1.9",
            Name = @"Anesthesia Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0019",
            TableName = @"Anesthesia Code",
            Description = @"This field contains a unique identifier of the anesthesia used during the procedure. Refer to User-defined Table 0019 - Anesthesia Code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _anesthesiaCode = new HL7V26Field
        {
            field = message[@"PR1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiaCode.field.FieldRepetitions != null && _anesthesiaCode.field.FieldRepetitions.Count > 0)
        {
            _anesthesiaCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_anesthesiaCode, fieldData);
        }

        return _anesthesiaCode;
    } 
}

internal HL7V26Field _anesthesiaMinutes;

public HL7V26Field AnesthesiaMinutes
{
    get
    {
        if (_anesthesiaMinutes != null)
        {
            return _anesthesiaMinutes;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"This field contains the length of time in minutes that the anesthesia was administered.",
            Sample = @"",
            Fields = null
        }

        _anesthesiaMinutes = new HL7V26Field
        {
            field = message[@"PR1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiaMinutes.field.FieldRepetitions != null && _anesthesiaMinutes.field.FieldRepetitions.Count > 0)
        {
            _anesthesiaMinutes.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_anesthesiaMinutes, fieldData);
        }

        return _anesthesiaMinutes;
    } 
}

internal HL7V26Field _surgeon;

public HL7V26Field Surgeon
{
    get
    {
        if (_surgeon != null)
        {
            return _surgeon;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.11",
            Type = @"Field",
            Position = @"PR1.11",
            Name = @"Surgeon",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"PR1-11 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
            Sample = @"",
            Fields = null
        }

        _surgeon = new HL7V26Field
        {
            field = message[@"PR1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_surgeon.field.FieldRepetitions != null && _surgeon.field.FieldRepetitions.Count > 0)
        {
            _surgeon.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_surgeon, fieldData);
        }

        return _surgeon;
    } 
}

internal HL7V26Field _procedurePractitioner;

public HL7V26Field ProcedurePractitioner
{
    get
    {
        if (_procedurePractitioner != null)
        {
            return _procedurePractitioner;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.12",
            Type = @"Field",
            Position = @"PR1.12",
            Name = @"Procedure Practitioner",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"PR1-12 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
            Sample = @"",
            Fields = null
        }

        _procedurePractitioner = new HL7V26Field
        {
            field = message[@"PR1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedurePractitioner.field.FieldRepetitions != null && _procedurePractitioner.field.FieldRepetitions.Count > 0)
        {
            _procedurePractitioner.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedurePractitioner, fieldData);
        }

        return _procedurePractitioner;
    } 
}

internal HL7V26Field _consentCode;

public HL7V26Field ConsentCode
{
    get
    {
        if (_consentCode != null)
        {
            return _consentCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.13",
            Type = @"Field",
            Position = @"PR1.13",
            Name = @"Consent Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0059",
            TableName = @"Consent Code",
            Description = @"This field contains the type of consent that was obtained for permission to treat the patient. Refer to User-defined Table 0059 - Consent Code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.13.1",
                            Type = @"Component",
                            Position = @"PR1.13.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.2",
                            Type = @"Component",
                            Position = @"PR1.13.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.3",
                            Type = @"Component",
                            Position = @"PR1.13.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.4",
                            Type = @"Component",
                            Position = @"PR1.13.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.5",
                            Type = @"Component",
                            Position = @"PR1.13.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.6",
                            Type = @"Component",
                            Position = @"PR1.13.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.7",
                            Type = @"Component",
                            Position = @"PR1.13.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.8",
                            Type = @"Component",
                            Position = @"PR1.13.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.9",
                            Type = @"Component",
                            Position = @"PR1.13.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _consentCode = new HL7V26Field
        {
            field = message[@"PR1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_consentCode.field.FieldRepetitions != null && _consentCode.field.FieldRepetitions.Count > 0)
        {
            _consentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_consentCode, fieldData);
        }

        return _consentCode;
    } 
}

internal HL7V26Field _procedurePriority;

public HL7V26Field ProcedurePriority
{
    get
    {
        if (_procedurePriority != null)
        {
            return _procedurePriority;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.14",
            Type = @"Field",
            Position = @"PR1.14",
            Name = @"Procedure Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0418",
            TableName = @"Procedure Priority",
            Description = @"This field contains a number that identifies the significance or priority of the procedure code. Refer to HL7 Table 0418 - Procedure Priority for valid values.",
            Sample = @"",
            Fields = null
        }

        _procedurePriority = new HL7V26Field
        {
            field = message[@"PR1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedurePriority.field.FieldRepetitions != null && _procedurePriority.field.FieldRepetitions.Count > 0)
        {
            _procedurePriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedurePriority, fieldData);
        }

        return _procedurePriority;
    } 
}

internal HL7V26Field _associatedDiagnosisCode;

public HL7V26Field AssociatedDiagnosisCode
{
    get
    {
        if (_associatedDiagnosisCode != null)
        {
            return _associatedDiagnosisCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.15",
            Type = @"Field",
            Position = @"PR1.15",
            Name = @"Associated Diagnosis Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0051",
            TableName = @"Diagnosis Code",
            Description = @"This field contains the diagnosis that is the primary reason this procedure was performed, e.g., in the US, Medicare wants to know for which diagnosis this procedure is submitted for inclusion on CMS 1500 form. Refer to User-defined Table 0051 - Diagnosis Code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.15.1",
                            Type = @"Component",
                            Position = @"PR1.15.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.2",
                            Type = @"Component",
                            Position = @"PR1.15.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.3",
                            Type = @"Component",
                            Position = @"PR1.15.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.4",
                            Type = @"Component",
                            Position = @"PR1.15.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.5",
                            Type = @"Component",
                            Position = @"PR1.15.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.6",
                            Type = @"Component",
                            Position = @"PR1.15.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.7",
                            Type = @"Component",
                            Position = @"PR1.15.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.8",
                            Type = @"Component",
                            Position = @"PR1.15.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.9",
                            Type = @"Component",
                            Position = @"PR1.15.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _associatedDiagnosisCode = new HL7V26Field
        {
            field = message[@"PR1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_associatedDiagnosisCode.field.FieldRepetitions != null && _associatedDiagnosisCode.field.FieldRepetitions.Count > 0)
        {
            _associatedDiagnosisCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_associatedDiagnosisCode, fieldData);
        }

        return _associatedDiagnosisCode;
    } 
}

internal HL7V26Field _procedureCodeModifier;

public HL7V26Field ProcedureCodeModifier
{
    get
    {
        if (_procedureCodeModifier != null)
        {
            return _procedureCodeModifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.16",
            Type = @"Field",
            Position = @"PR1.16",
            Name = @"Procedure Code Modifier",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0340",
            TableName = @"Procedure Code Modifier",
            Description = @"This field contains the procedure code modifier to the procedure code reported in field 3, when applicable. Procedure code modifiers are defined by regulatory agencies such as CMS and the AMA. Multiple modifiers may be reported. Refer to Externally-defined Table 0340 - Procedure Code Modifier for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.16.1",
                            Type = @"Component",
                            Position = @"PR1.16.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.2",
                            Type = @"Component",
                            Position = @"PR1.16.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.3",
                            Type = @"Component",
                            Position = @"PR1.16.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.4",
                            Type = @"Component",
                            Position = @"PR1.16.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.5",
                            Type = @"Component",
                            Position = @"PR1.16.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.6",
                            Type = @"Component",
                            Position = @"PR1.16.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.7",
                            Type = @"Component",
                            Position = @"PR1.16.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.8",
                            Type = @"Component",
                            Position = @"PR1.16.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.9",
                            Type = @"Component",
                            Position = @"PR1.16.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _procedureCodeModifier = new HL7V26Field
        {
            field = message[@"PR1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCodeModifier.field.FieldRepetitions != null && _procedureCodeModifier.field.FieldRepetitions.Count > 0)
        {
            _procedureCodeModifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedureCodeModifier, fieldData);
        }

        return _procedureCodeModifier;
    } 
}

internal HL7V26Field _procedureDRGType;

public HL7V26Field ProcedureDRGType
{
    get
    {
        if (_procedureDRGType != null)
        {
            return _procedureDRGType;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.17",
            Type = @"Field",
            Position = @"PR1.17",
            Name = @"Procedure DRG Type",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0416",
            TableName = @"Procedure DRG Type",
            Description = @"This field indicates a procedures priority ranking relative to its DRG. Refer to User-defined Table 0416 - Procedure DRG Type for suggested values.",
            Sample = @"",
            Fields = null
        }

        _procedureDRGType = new HL7V26Field
        {
            field = message[@"PR1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureDRGType.field.FieldRepetitions != null && _procedureDRGType.field.FieldRepetitions.Count > 0)
        {
            _procedureDRGType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedureDRGType, fieldData);
        }

        return _procedureDRGType;
    } 
}

internal HL7V26Field _tissueTypeCode;

public HL7V26Field TissueTypeCode
{
    get
    {
        if (_tissueTypeCode != null)
        {
            return _tissueTypeCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.18",
            Type = @"Field",
            Position = @"PR1.18",
            Name = @"Tissue Type Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0417",
            TableName = @"Tissue Type Code",
            Description = @"Code representing type of tissue removed from a patient during this procedure. Refer to User-defined Table 0417 - Tissue Type Code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.18.1",
                            Type = @"Component",
                            Position = @"PR1.18.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.2",
                            Type = @"Component",
                            Position = @"PR1.18.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.3",
                            Type = @"Component",
                            Position = @"PR1.18.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.4",
                            Type = @"Component",
                            Position = @"PR1.18.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.5",
                            Type = @"Component",
                            Position = @"PR1.18.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.6",
                            Type = @"Component",
                            Position = @"PR1.18.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.7",
                            Type = @"Component",
                            Position = @"PR1.18.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.8",
                            Type = @"Component",
                            Position = @"PR1.18.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.9",
                            Type = @"Component",
                            Position = @"PR1.18.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _tissueTypeCode = new HL7V26Field
        {
            field = message[@"PR1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_tissueTypeCode.field.FieldRepetitions != null && _tissueTypeCode.field.FieldRepetitions.Count > 0)
        {
            _tissueTypeCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_tissueTypeCode, fieldData);
        }

        return _tissueTypeCode;
    } 
}

internal HL7V26Field _procedureIdentifier;

public HL7V26Field ProcedureIdentifier
{
    get
    {
        if (_procedureIdentifier != null)
        {
            return _procedureIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.19",
            Type = @"Field",
            Position = @"PR1.19",
            Name = @"Procedure Identifier",
            Length = 427,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains a value that uniquely identifies a single procedure for an encounter. It is unique across all segments and messages for an encounter.  This field is required in all implementations employing Update Diagnosis/Procedures (P12) messages.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.19.1",
                            Type = @"Component",
                            Position = @"PR1.19.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.19.2",
                            Type = @"Component",
                            Position = @"PR1.19.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.19.3",
                            Type = @"Component",
                            Position = @"PR1.19.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"PR1.19.4",
                            Type = @"Component",
                            Position = @"PR1.19.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _procedureIdentifier = new HL7V26Field
        {
            field = message[@"PR1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureIdentifier.field.FieldRepetitions != null && _procedureIdentifier.field.FieldRepetitions.Count > 0)
        {
            _procedureIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedureIdentifier, fieldData);
        }

        return _procedureIdentifier;
    } 
}

internal HL7V26Field _procedureActionCode;

public HL7V26Field ProcedureActionCode
{
    get
    {
        if (_procedureActionCode != null)
        {
            return _procedureActionCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.20",
            Type = @"Field",
            Position = @"PR1.20",
            Name = @"Procedure Action Code",
            Length = 1,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0206",
            TableName = @"Segment action code",
            Description = @"This field defines the action to be taken for this procedure. Refer to HL7 Table 0206 - Segment Action Code in Chapter 2 for valid values.  This field is required for the Update Diagnosis/Procedures (P12) message.  In all other events it is optional.",
            Sample = @"",
            Fields = null
        }

        _procedureActionCode = new HL7V26Field
        {
            field = message[@"PR1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureActionCode.field.FieldRepetitions != null && _procedureActionCode.field.FieldRepetitions.Count > 0)
        {
            _procedureActionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_procedureActionCode, fieldData);
        }

        return _procedureActionCode;
    } 
}

internal HL7V26Field _dRGProcedureDeterminationStatus;

public HL7V26Field DRGProcedureDeterminationStatus
{
    get
    {
        if (_dRGProcedureDeterminationStatus != null)
        {
            return _dRGProcedureDeterminationStatus;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.21",
            Type = @"Field",
            Position = @"PR1.21",
            Name = @"DRG Procedure Determination Status",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0761",
            TableName = @"DRG Procedure Determination Status",
            Description = @"This field contains the status of the use of this particular procedure for the DRG determination. Refer to User-defined Table 0761 - DRG Procedure Determination Status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _dRGProcedureDeterminationStatus = new HL7V26Field
        {
            field = message[@"PR1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGProcedureDeterminationStatus.field.FieldRepetitions != null && _dRGProcedureDeterminationStatus.field.FieldRepetitions.Count > 0)
        {
            _dRGProcedureDeterminationStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_dRGProcedureDeterminationStatus, fieldData);
        }

        return _dRGProcedureDeterminationStatus;
    } 
}

internal HL7V26Field _dRGProcedureRelevance;

public HL7V26Field DRGProcedureRelevance
{
    get
    {
        if (_dRGProcedureRelevance != null)
        {
            return _dRGProcedureRelevance;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PR1.22",
            Type = @"Field",
            Position = @"PR1.22",
            Name = @"DRG Procedure Relevance",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0763",
            TableName = @"DRG Procedure Relevance",
            Description = @"This field contains the relevance of this particular procedure for the DRG determination. Refer toUser-defined Table 0763 - DRG Procedure Relevance for suggested values.",
            Sample = @"",
            Fields = null
        }

        _dRGProcedureRelevance = new HL7V26Field
        {
            field = message[@"PR1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGProcedureRelevance.field.FieldRepetitions != null && _dRGProcedureRelevance.field.FieldRepetitions.Count > 0)
        {
            _dRGProcedureRelevance.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_dRGProcedureRelevance, fieldData);
        }

        return _dRGProcedureRelevance;
    } 
}
    }
}
