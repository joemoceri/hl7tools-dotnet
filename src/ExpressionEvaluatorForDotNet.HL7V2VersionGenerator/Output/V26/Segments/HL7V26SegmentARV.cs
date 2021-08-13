using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentARV
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ARV"; } }

        public string SegmentId { get { return @"ARV"; } }
        
        public string LongName { get { return @"Access Restrictions"; } }
        
        public string Description { get { return @"The ARV segment is used to communicate the requested/required type of access restrictions from system to system, at both the person/patient and the encounter/visit level."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V26SegmentARV(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _setID;

public HL7V26Field SetID
{
    get
    {
        if (_setID != null)
        {
            return _setID;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ARV.1",
            Type = @"Field",
            Position = @"ARV.1",
            Name = @"Set ID",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this segment. For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc.",
            Sample = @"",
            Fields = null
        }

        _setID = new HL7V26Field
        {
            field = message[@"ARV"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setID.field.FieldRepetitions != null && _setID.field.FieldRepetitions.Count > 0)
        {
            _setID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_setID, fieldData);
        }

        return _setID;
    } 
}

internal HL7V26Field _accessRestrictionActionCode;

public HL7V26Field AccessRestrictionActionCode
{
    get
    {
        if (_accessRestrictionActionCode != null)
        {
            return _accessRestrictionActionCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ARV.2",
            Type = @"Field",
            Position = @"ARV.2",
            Name = @"Access Restriction Action Code",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0206",
            TableName = @"Segment action code",
            Description = @"This field contains a code defining the action to be taken for this segment. It allows access restriction information to be sent to delete or update previously sent access restrictions. Refer to HL7 Table 0206 - Segment Action Code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARV.2.1",
                            Type = @"Component",
                            Position = @"ARV.2.1",
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
                            Id = @"ARV.2.2",
                            Type = @"Component",
                            Position = @"ARV.2.2",
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
                            Id = @"ARV.2.3",
                            Type = @"Component",
                            Position = @"ARV.2.3",
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
                            Id = @"ARV.2.4",
                            Type = @"Component",
                            Position = @"ARV.2.4",
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
                            Id = @"ARV.2.5",
                            Type = @"Component",
                            Position = @"ARV.2.5",
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
                            Id = @"ARV.2.6",
                            Type = @"Component",
                            Position = @"ARV.2.6",
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
                            Id = @"ARV.2.7",
                            Type = @"Component",
                            Position = @"ARV.2.7",
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
                            Id = @"ARV.2.8",
                            Type = @"Component",
                            Position = @"ARV.2.8",
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
                            Id = @"ARV.2.9",
                            Type = @"Component",
                            Position = @"ARV.2.9",
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

        _accessRestrictionActionCode = new HL7V26Field
        {
            field = message[@"ARV"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accessRestrictionActionCode.field.FieldRepetitions != null && _accessRestrictionActionCode.field.FieldRepetitions.Count > 0)
        {
            _accessRestrictionActionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_accessRestrictionActionCode, fieldData);
        }

        return _accessRestrictionActionCode;
    } 
}

internal HL7V26Field _accessRestrictionValue;

public HL7V26Field AccessRestrictionValue
{
    get
    {
        if (_accessRestrictionValue != null)
        {
            return _accessRestrictionValue;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ARV.3",
            Type = @"Field",
            Position = @"ARV.3",
            Name = @"Access Restriction Value",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0717",
            TableName = @"Access Restriction Value",
            Description = @"This field specifies the information to which access is restricted. This access may be restricted at a field level by employing the specific HL7 field identifiers or may be otherwise determined by user-defined coded values. Refer to User-defined Table 0717 - Access Restriction Value for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARV.3.1",
                            Type = @"Component",
                            Position = @"ARV.3.1",
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
                            Id = @"ARV.3.2",
                            Type = @"Component",
                            Position = @"ARV.3.2",
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
                            Id = @"ARV.3.3",
                            Type = @"Component",
                            Position = @"ARV.3.3",
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
                            Id = @"ARV.3.4",
                            Type = @"Component",
                            Position = @"ARV.3.4",
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
                            Id = @"ARV.3.5",
                            Type = @"Component",
                            Position = @"ARV.3.5",
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
                            Id = @"ARV.3.6",
                            Type = @"Component",
                            Position = @"ARV.3.6",
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
                            Id = @"ARV.3.7",
                            Type = @"Component",
                            Position = @"ARV.3.7",
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
                            Id = @"ARV.3.8",
                            Type = @"Component",
                            Position = @"ARV.3.8",
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
                            Id = @"ARV.3.9",
                            Type = @"Component",
                            Position = @"ARV.3.9",
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

        _accessRestrictionValue = new HL7V26Field
        {
            field = message[@"ARV"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accessRestrictionValue.field.FieldRepetitions != null && _accessRestrictionValue.field.FieldRepetitions.Count > 0)
        {
            _accessRestrictionValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_accessRestrictionValue, fieldData);
        }

        return _accessRestrictionValue;
    } 
}

internal HL7V26Field _accessRestrictionReason;

public HL7V26Field AccessRestrictionReason
{
    get
    {
        if (_accessRestrictionReason != null)
        {
            return _accessRestrictionReason;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ARV.4",
            Type = @"Field",
            Position = @"ARV.4",
            Name = @"Access Restriction Reason",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0719",
            TableName = @"Access Restriction Reason Code",
            Description = @"This field is used to convey the reason for the restricted access. Repeat of the Access Restriction Reason is allowed to accommodate communication of multiple reasons for an access restriction. Refer to User-defined Table 0719 - Access Restriction Reason Code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARV.4.1",
                            Type = @"Component",
                            Position = @"ARV.4.1",
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
                            Id = @"ARV.4.2",
                            Type = @"Component",
                            Position = @"ARV.4.2",
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
                            Id = @"ARV.4.3",
                            Type = @"Component",
                            Position = @"ARV.4.3",
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
                            Id = @"ARV.4.4",
                            Type = @"Component",
                            Position = @"ARV.4.4",
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
                            Id = @"ARV.4.5",
                            Type = @"Component",
                            Position = @"ARV.4.5",
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
                            Id = @"ARV.4.6",
                            Type = @"Component",
                            Position = @"ARV.4.6",
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
                            Id = @"ARV.4.7",
                            Type = @"Component",
                            Position = @"ARV.4.7",
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
                            Id = @"ARV.4.8",
                            Type = @"Component",
                            Position = @"ARV.4.8",
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
                            Id = @"ARV.4.9",
                            Type = @"Component",
                            Position = @"ARV.4.9",
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

        _accessRestrictionReason = new HL7V26Field
        {
            field = message[@"ARV"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accessRestrictionReason.field.FieldRepetitions != null && _accessRestrictionReason.field.FieldRepetitions.Count > 0)
        {
            _accessRestrictionReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_accessRestrictionReason, fieldData);
        }

        return _accessRestrictionReason;
    } 
}

internal HL7V26Field _specialAccessRestrictionInstructions;

public HL7V26Field SpecialAccessRestrictionInstructions
{
    get
    {
        if (_specialAccessRestrictionInstructions != null)
        {
            return _specialAccessRestrictionInstructions;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ARV.5",
            Type = @"Field",
            Position = @"ARV.5",
            Name = @"Special Access Restriction Instructions",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Used to convey specific instructions about the protection of the patient's data (e.g., ""Always refer to the patient as Mr. Everyman""). This field may also be used to specify instructions about the release of information to family and friends (e.g., ""Do not release information to patient's brother, Adam Everyman""). These instructions may be in conjunction with other fields (as elected by the system).",
            Sample = @"",
            Fields = null
        }

        _specialAccessRestrictionInstructions = new HL7V26Field
        {
            field = message[@"ARV"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialAccessRestrictionInstructions.field.FieldRepetitions != null && _specialAccessRestrictionInstructions.field.FieldRepetitions.Count > 0)
        {
            _specialAccessRestrictionInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_specialAccessRestrictionInstructions, fieldData);
        }

        return _specialAccessRestrictionInstructions;
    } 
}

internal HL7V26Field _accessRestrictionDateRange;

public HL7V26Field AccessRestrictionDateRange
{
    get
    {
        if (_accessRestrictionDateRange != null)
        {
            return _accessRestrictionDateRange;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ARV.6",
            Type = @"Field",
            Position = @"ARV.6",
            Name = @"Access Restriction Date Range",
            Length = 49,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DR",
            DataTypeName = @"Date/Time Range",
            TableId = null,
            TableName = null,
            Description = @"This element defines the date from which an access restriction commences until the date it is specifically rescinded.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARV.6.1",
                            Type = @"Component",
                            Position = @"ARV.6.1",
                            Name = @"Range Start Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARV.6.2",
                            Type = @"Component",
                            Position = @"ARV.6.2",
                            Name = @"Range End Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the DTM (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _accessRestrictionDateRange = new HL7V26Field
        {
            field = message[@"ARV"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accessRestrictionDateRange.field.FieldRepetitions != null && _accessRestrictionDateRange.field.FieldRepetitions.Count > 0)
        {
            _accessRestrictionDateRange.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_accessRestrictionDateRange, fieldData);
        }

        return _accessRestrictionDateRange;
    } 
}
    }
}
