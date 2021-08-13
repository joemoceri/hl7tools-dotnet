using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentPR1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PR1"; } }

        public string SegmentId { get { return @"PR1"; } }
        
        public string LongName { get { return @"Procedures"; } }
        
        public string Description { get { return @"The PR1 segment contains information relative to various types of procedures that can be performed on a patient.  The PR1 segment can be used to send procedure information, for example: Surgical, Nuclear Medicine, X-ray with contrast, etc.   The PR1 segment is used to send multiple procedures, for example, for medical records encoding or for billing systems."; } }
        
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

        public HL7V23SegmentPR1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDProcedure;

public HL7V23Field SetIDProcedure
{
    get
    {
        if (_setIDProcedure != null)
        {
            return _setIDProcedure;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PR1.1",
            Type = @"Field",
            Position = @"PR1.1",
            Name = @"Set ID - Procedure",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc",
            Sample = @"",
            Fields = null
        }

        _setIDProcedure = new HL7V23Field
        {
            field = message[@"PR1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDProcedure.field.FieldRepetitions != null && _setIDProcedure.field.FieldRepetitions.Count > 0)
        {
            _setIDProcedure.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDProcedure, fieldData);
        }

        return _setIDProcedure;
    } 
}

internal HL7V23Field _procedureCodingMethod;

public HL7V23Field ProcedureCodingMethod
{
    get
    {
        if (_procedureCodingMethod != null)
        {
            return _procedureCodingMethod;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PR1.2",
            Type = @"Field",
            Position = @"PR1.2",
            Name = @"Procedure Coding Method",
            Length = 2,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0089",
            TableName = @"Procedure Coding Method",
            Description = @"This field  has been retained for backward compatibility only.  Use the components of PR1-3procedure code instead of this field.

When used for backward compatibility, PR1-2-procedure coding method contains the methodology used to assign a code to the procedure (CPT4, for example).  If more than one coding method is needed for a single procedure, this field and the associated values in  PR1-3-procedure code and PR1-4-procedure description may repeat.  In this instance, the three fields (PR1-2 through 4) are directly associated with one another.  Refer to user-defined table 0089 - Procedure coding method for suggested values.",
            Sample = @"",
            Fields = null
        }

        _procedureCodingMethod = new HL7V23Field
        {
            field = message[@"PR1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCodingMethod.field.FieldRepetitions != null && _procedureCodingMethod.field.FieldRepetitions.Count > 0)
        {
            _procedureCodingMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_procedureCodingMethod, fieldData);
        }

        return _procedureCodingMethod;
    } 
}

internal HL7V23Field _procedureCode;

public HL7V23Field ProcedureCode
{
    get
    {
        if (_procedureCode != null)
        {
            return _procedureCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PR1.3",
            Type = @"Field",
            Position = @"PR1.3",
            Name = @"Procedure Code",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0088",
            TableName = @"Procedure code",
            Description = @"Use this field instead of  PR1-2-procedure coding method and  PR1-4-procedure description.  Those two fields have been retained for backward compatibility only.  This field contains a unique identifier assigned to the procedure.  Refer to user-defined table 0088 - Procedure code for suggested values.  This field is a CE data type for compatibility with clinical and ancillary systems.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.3.1",
                            Type = @"Component",
                            Position = @"PR1.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.2",
                            Type = @"Component",
                            Position = @"PR1.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.3",
                            Type = @"Component",
                            Position = @"PR1.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.4",
                            Type = @"Component",
                            Position = @"PR1.3.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.5",
                            Type = @"Component",
                            Position = @"PR1.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.6",
                            Type = @"Component",
                            Position = @"PR1.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _procedureCode = new HL7V23Field
        {
            field = message[@"PR1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCode.field.FieldRepetitions != null && _procedureCode.field.FieldRepetitions.Count > 0)
        {
            _procedureCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_procedureCode, fieldData);
        }

        return _procedureCode;
    } 
}

internal HL7V23Field _procedureDescription;

public HL7V23Field ProcedureDescription
{
    get
    {
        if (_procedureDescription != null)
        {
            return _procedureDescription;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PR1.4",
            Type = @"Field",
            Position = @"PR1.4",
            Name = @"Procedure Description",
            Length = 40,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field  has been retained for backward compatibility only.  Use the components of PR1-3procedure code instead of this field.   The field contains a text description that describes the procedure.",
            Sample = @"",
            Fields = null
        }

        _procedureDescription = new HL7V23Field
        {
            field = message[@"PR1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureDescription.field.FieldRepetitions != null && _procedureDescription.field.FieldRepetitions.Count > 0)
        {
            _procedureDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_procedureDescription, fieldData);
        }

        return _procedureDescription;
    } 
}

internal HL7V23Field _procedureDateTime;

public HL7V23Field ProcedureDateTime
{
    get
    {
        if (_procedureDateTime != null)
        {
            return _procedureDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PR1.5",
            Type = @"Field",
            Position = @"PR1.5",
            Name = @"Procedure Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the procedure was performed.",
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
                        }
        }

        _procedureDateTime = new HL7V23Field
        {
            field = message[@"PR1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureDateTime.field.FieldRepetitions != null && _procedureDateTime.field.FieldRepetitions.Count > 0)
        {
            _procedureDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_procedureDateTime, fieldData);
        }

        return _procedureDateTime;
    } 
}

internal HL7V23Field _procedureType;

public HL7V23Field ProcedureType
{
    get
    {
        if (_procedureType != null)
        {
            return _procedureType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PR1.6",
            Type = @"Field",
            Position = @"PR1.6",
            Name = @"Procedure Type",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0230",
            TableName = @"Procedure functional type",
            Description = @"This field contains the optional code that further defines the type of procedure.  Refer to userdefined table 0230 - Procedure functional type for suggested values.",
            Sample = @"",
            Fields = null
        }

        _procedureType = new HL7V23Field
        {
            field = message[@"PR1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureType.field.FieldRepetitions != null && _procedureType.field.FieldRepetitions.Count > 0)
        {
            _procedureType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_procedureType, fieldData);
        }

        return _procedureType;
    } 
}

internal HL7V23Field _procedureMinutes;

public HL7V23Field ProcedureMinutes
{
    get
    {
        if (_procedureMinutes != null)
        {
            return _procedureMinutes;
        }

        var fieldData = new HL7V23FieldData
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

        _procedureMinutes = new HL7V23Field
        {
            field = message[@"PR1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureMinutes.field.FieldRepetitions != null && _procedureMinutes.field.FieldRepetitions.Count > 0)
        {
            _procedureMinutes.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_procedureMinutes, fieldData);
        }

        return _procedureMinutes;
    } 
}

internal HL7V23Field _anesthesiologist;

public HL7V23Field Anesthesiologist
{
    get
    {
        if (_anesthesiologist != null)
        {
            return _anesthesiologist;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PR1.8",
            Type = @"Field",
            Position = @"PR1.8",
            Name = @"Anesthesiologist",
            Length = 120,
            Usage = @"B",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = @"0010",
            TableName = @"Physician ID",
            Description = @"HL7 has introduced the ROL segment to report a wide range of practitioner roles related to a single procedure.  This segment is described in Chapter 12.  When using trigger events introduced in HL7 Version 2.3, it is recommended that the ROL segment be used to report all practitioner roles related to the procedure. 

However, in order to maintain backward compatibility, the practitioner roles existing in HL7 Version 2.2 (PR18-anesthesiologist, PR1-11-surgeon, and PR1-12-procedure practitioner) should also be populated in the PR1 segment as per the HL7 2.2 specifications.  You may additionally report the practitioner information in the ROL segment (See Chapter 12, Section 12.3.3, “ROL - role segment”). 

When this field is used for backward compatibility, the XCN data type applies.  It contains the anesthesiologist who administered the anesthesia.  Use values in  user-defined table 0010 - Physician ID for first component.  Multiple names and identifiers for the same person should be sent in this field, not multiple anesthesiologists.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.8.1",
                            Type = @"Component",
                            Position = @"PR1.8.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.2",
                            Type = @"Component",
                            Position = @"PR1.8.2",
                            Name = @"Family Name",
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
                            TableId = @"FirstName",
                            TableName = @"First Name",
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
                            Name = @"Suffix",
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
                            Name = @"Prefix",
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
                            Name = @"Degree",
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
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.9",
                            Type = @"Component",
                            Position = @"PR1.8.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.8.9.1",
                            Type = @"SubComponent",
                            Position = @"PR1.8.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.9.2",
                            Type = @"SubComponent",
                            Position = @"PR1.8.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.9.3",
                            Type = @"SubComponent",
                            Position = @"PR1.8.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.10",
                            Type = @"Component",
                            Position = @"PR1.8.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.11",
                            Type = @"Component",
                            Position = @"PR1.8.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.12",
                            Type = @"Component",
                            Position = @"PR1.8.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.13",
                            Type = @"Component",
                            Position = @"PR1.8.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.14",
                            Type = @"Component",
                            Position = @"PR1.8.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.8.14.1",
                            Type = @"SubComponent",
                            Position = @"PR1.8.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.14.2",
                            Type = @"SubComponent",
                            Position = @"PR1.8.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8.14.3",
                            Type = @"SubComponent",
                            Position = @"PR1.8.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _anesthesiologist = new HL7V23Field
        {
            field = message[@"PR1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiologist.field.FieldRepetitions != null && _anesthesiologist.field.FieldRepetitions.Count > 0)
        {
            _anesthesiologist.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_anesthesiologist, fieldData);
        }

        return _anesthesiologist;
    } 
}

internal HL7V23Field _anesthesiaCode;

public HL7V23Field AnesthesiaCode
{
    get
    {
        if (_anesthesiaCode != null)
        {
            return _anesthesiaCode;
        }

        var fieldData = new HL7V23FieldData
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
            TableName = @"Anesthesia code",
            Description = @"This field contains a unique identifier of the anesthesia used during the procedure.  Refer to user-defined table 0019 - Anesthesia code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _anesthesiaCode = new HL7V23Field
        {
            field = message[@"PR1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiaCode.field.FieldRepetitions != null && _anesthesiaCode.field.FieldRepetitions.Count > 0)
        {
            _anesthesiaCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_anesthesiaCode, fieldData);
        }

        return _anesthesiaCode;
    } 
}

internal HL7V23Field _anesthesiaMinutes;

public HL7V23Field AnesthesiaMinutes
{
    get
    {
        if (_anesthesiaMinutes != null)
        {
            return _anesthesiaMinutes;
        }

        var fieldData = new HL7V23FieldData
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

        _anesthesiaMinutes = new HL7V23Field
        {
            field = message[@"PR1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anesthesiaMinutes.field.FieldRepetitions != null && _anesthesiaMinutes.field.FieldRepetitions.Count > 0)
        {
            _anesthesiaMinutes.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_anesthesiaMinutes, fieldData);
        }

        return _anesthesiaMinutes;
    } 
}

internal HL7V23Field _surgeon;

public HL7V23Field Surgeon
{
    get
    {
        if (_surgeon != null)
        {
            return _surgeon;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PR1.11",
            Type = @"Field",
            Position = @"PR1.11",
            Name = @"Surgeon",
            Length = 120,
            Usage = @"B",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = @"0010",
            TableName = @"Physician ID",
            Description = @"HL7 has introduced the ROL segment to report a wide range of practitioner roles related to a single procedure.  This segment is described in Chapter 12.  When using trigger events introduced in HL7 Version 2.3, it is recommended that the ROL segment be used to report all practitioner roles related to the procedure. 

However, in order to maintain backward compatibility, the practitioner roles existing in HL7 Version 2.2 (PR18-anesthesiologist, PR1-11-surgeon, and PR1-12-procedure practitioner) should also be populated in the PR1 segment as per the HL7 2.2 specifications.  You may additionally report the practitioner information in the ROL segment (See Chapter 12, Section 12.3.3, “ROL - role segment”). 

When this field is being used for backward compatibility, the XCN data type applies.  It contains the surgeon who performed the procedure.  Use the values in user-defined table 0010 - Physician ID for the first component.  Multiple names and identifiers for the same person should be sent in this field, not multiple surgeons.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.11.1",
                            Type = @"Component",
                            Position = @"PR1.11.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.2",
                            Type = @"Component",
                            Position = @"PR1.11.2",
                            Name = @"Family Name",
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
                            TableId = @"FirstName",
                            TableName = @"First Name",
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
                            Name = @"Suffix",
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
                            Name = @"Prefix",
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
                            Name = @"Degree",
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
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.9",
                            Type = @"Component",
                            Position = @"PR1.11.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.11.9.1",
                            Type = @"SubComponent",
                            Position = @"PR1.11.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.9.2",
                            Type = @"SubComponent",
                            Position = @"PR1.11.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.9.3",
                            Type = @"SubComponent",
                            Position = @"PR1.11.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.10",
                            Type = @"Component",
                            Position = @"PR1.11.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.11",
                            Type = @"Component",
                            Position = @"PR1.11.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.12",
                            Type = @"Component",
                            Position = @"PR1.11.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.13",
                            Type = @"Component",
                            Position = @"PR1.11.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.14",
                            Type = @"Component",
                            Position = @"PR1.11.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.11.14.1",
                            Type = @"SubComponent",
                            Position = @"PR1.11.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.14.2",
                            Type = @"SubComponent",
                            Position = @"PR1.11.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11.14.3",
                            Type = @"SubComponent",
                            Position = @"PR1.11.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _surgeon = new HL7V23Field
        {
            field = message[@"PR1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_surgeon.field.FieldRepetitions != null && _surgeon.field.FieldRepetitions.Count > 0)
        {
            _surgeon.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_surgeon, fieldData);
        }

        return _surgeon;
    } 
}

internal HL7V23Field _procedurePractitioner;

public HL7V23Field ProcedurePractitioner
{
    get
    {
        if (_procedurePractitioner != null)
        {
            return _procedurePractitioner;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PR1.12",
            Type = @"Field",
            Position = @"PR1.12",
            Name = @"Procedure Practitioner",
            Length = 230,
            Usage = @"B",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = @"0010",
            TableName = @"Physician ID",
            Description = @"HL7 has introduced the ROL segment to report a wide range of practitioner roles related to a single procedure.  This segment is described in Chapter 12.  When using trigger events introduced in HL7 Version 2.3, it is recommended that the ROL segment be used to report all practitioner roles related to the procedure. 

However, in order to maintain backward compatibility, the practitioner roles existing in HL7 Version 2.2 (PR18-anesthesiologist, PR1-11-surgeon, and PR1-12-procedure practitioner) should also be populated in the PR1 segment as per the HL7 2.2 specifications.  You may additionally report the practitioner information in the ROL segment (See Chapter 12, Section 12.3.3, “ROL - role segment”). 

This field contains the different types of practitioners associated with this procedure.  The ID and name components follow the standard rules defined for a composite name (XCN) field.  The last component, identifier type code, indicates which type of procedure practitioner is shown.  When the identifier type component is unvalued, it is assumed that the practitioner identified is a resident.  Use values in userdefined table 0010 - Physician ID for the first component.  Refer to user-defined table 0133 - Procedure practitioner identifier code type for suggested values for the identifier type code component",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.12.1",
                            Type = @"Component",
                            Position = @"PR1.12.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.2",
                            Type = @"Component",
                            Position = @"PR1.12.2",
                            Name = @"Family Name",
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
                            Id = @"PR1.12.3",
                            Type = @"Component",
                            Position = @"PR1.12.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.4",
                            Type = @"Component",
                            Position = @"PR1.12.4",
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
                            Id = @"PR1.12.5",
                            Type = @"Component",
                            Position = @"PR1.12.5",
                            Name = @"Suffix",
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
                            Id = @"PR1.12.6",
                            Type = @"Component",
                            Position = @"PR1.12.6",
                            Name = @"Prefix",
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
                            Id = @"PR1.12.7",
                            Type = @"Component",
                            Position = @"PR1.12.7",
                            Name = @"Degree",
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
                            Id = @"PR1.12.8",
                            Type = @"Component",
                            Position = @"PR1.12.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.9",
                            Type = @"Component",
                            Position = @"PR1.12.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.12.9.1",
                            Type = @"SubComponent",
                            Position = @"PR1.12.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.9.2",
                            Type = @"SubComponent",
                            Position = @"PR1.12.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.9.3",
                            Type = @"SubComponent",
                            Position = @"PR1.12.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.10",
                            Type = @"Component",
                            Position = @"PR1.12.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.11",
                            Type = @"Component",
                            Position = @"PR1.12.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.12",
                            Type = @"Component",
                            Position = @"PR1.12.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.13",
                            Type = @"Component",
                            Position = @"PR1.12.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.14",
                            Type = @"Component",
                            Position = @"PR1.12.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.12.14.1",
                            Type = @"SubComponent",
                            Position = @"PR1.12.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.14.2",
                            Type = @"SubComponent",
                            Position = @"PR1.12.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12.14.3",
                            Type = @"SubComponent",
                            Position = @"PR1.12.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _procedurePractitioner = new HL7V23Field
        {
            field = message[@"PR1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedurePractitioner.field.FieldRepetitions != null && _procedurePractitioner.field.FieldRepetitions.Count > 0)
        {
            _procedurePractitioner.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_procedurePractitioner, fieldData);
        }

        return _procedurePractitioner;
    } 
}

internal HL7V23Field _consentCode;

public HL7V23Field ConsentCode
{
    get
    {
        if (_consentCode != null)
        {
            return _consentCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PR1.13",
            Type = @"Field",
            Position = @"PR1.13",
            Name = @"Consent Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0059",
            TableName = @"Consent code",
            Description = @"This field contains the type of consent that was obtained for permission to treat the patient.  Refer to user-defined table 0059 - Consent code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.13.1",
                            Type = @"Component",
                            Position = @"PR1.13.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.2",
                            Type = @"Component",
                            Position = @"PR1.13.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.3",
                            Type = @"Component",
                            Position = @"PR1.13.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.4",
                            Type = @"Component",
                            Position = @"PR1.13.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.5",
                            Type = @"Component",
                            Position = @"PR1.13.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.6",
                            Type = @"Component",
                            Position = @"PR1.13.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _consentCode = new HL7V23Field
        {
            field = message[@"PR1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_consentCode.field.FieldRepetitions != null && _consentCode.field.FieldRepetitions.Count > 0)
        {
            _consentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_consentCode, fieldData);
        }

        return _consentCode;
    } 
}

internal HL7V23Field _procedurePriority;

public HL7V23Field ProcedurePriority
{
    get
    {
        if (_procedurePriority != null)
        {
            return _procedurePriority;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains a number that identifies the significance or priority of the procedure code.

0:  the admitting procedure
1:  the primary procedure
2 and higher: for ranked secondary procedures",
            Sample = @"",
            Fields = null
        }

        _procedurePriority = new HL7V23Field
        {
            field = message[@"PR1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedurePriority.field.FieldRepetitions != null && _procedurePriority.field.FieldRepetitions.Count > 0)
        {
            _procedurePriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_procedurePriority, fieldData);
        }

        return _procedurePriority;
    } 
}

internal HL7V23Field _associatedDiagnosisCode;

public HL7V23Field AssociatedDiagnosisCode
{
    get
    {
        if (_associatedDiagnosisCode != null)
        {
            return _associatedDiagnosisCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PR1.15",
            Type = @"Field",
            Position = @"PR1.15",
            Name = @"Associated Diagnosis Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the diagnosis which is the primary reason this procedure was performed, e.g., Medicare wants to know for which diagnosis this procedure is submitted for inclusion on  HCFA 1500 form.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PR1.15.1",
                            Type = @"Component",
                            Position = @"PR1.15.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.2",
                            Type = @"Component",
                            Position = @"PR1.15.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.3",
                            Type = @"Component",
                            Position = @"PR1.15.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.4",
                            Type = @"Component",
                            Position = @"PR1.15.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.5",
                            Type = @"Component",
                            Position = @"PR1.15.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.6",
                            Type = @"Component",
                            Position = @"PR1.15.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _associatedDiagnosisCode = new HL7V23Field
        {
            field = message[@"PR1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_associatedDiagnosisCode.field.FieldRepetitions != null && _associatedDiagnosisCode.field.FieldRepetitions.Count > 0)
        {
            _associatedDiagnosisCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_associatedDiagnosisCode, fieldData);
        }

        return _associatedDiagnosisCode;
    } 
}
    }
}
