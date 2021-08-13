using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentPTH
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PTH"; } }

        public string SegmentId { get { return @"PTH"; } }
        
        public string LongName { get { return @"Pathway"; } }
        
        public string Description { get { return @"The pathway segment contains the data necessary to add, update, correct, and delete from the record pathways that are utilized to address an individual's health care."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",

                    };
            }
        }

        public HL7V26SegmentPTH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _actionCode;

public HL7V26Field ActionCode
{
    get
    {
        if (_actionCode != null)
        {
            return _actionCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PTH.1",
            Type = @"Field",
            Position = @"PTH.1",
            Name = @"Action Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0287",
            TableName = @"Problem/goal action code",
            Description = @"This field reveals the intent of the message. Refer to HL7 table 0287 - Problem/goal action code for valid values.",
            Sample = @"",
            Fields = null
        }

        _actionCode = new HL7V26Field
        {
            field = message[@"PTH"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actionCode.field.FieldRepetitions != null && _actionCode.field.FieldRepetitions.Count > 0)
        {
            _actionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_actionCode, fieldData);
        }

        return _actionCode;
    } 
}

internal HL7V26Field _pathwayID;

public HL7V26Field PathwayID
{
    get
    {
        if (_pathwayID != null)
        {
            return _pathwayID;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PTH.2",
            Type = @"Field",
            Position = @"PTH.2",
            Name = @"Pathway ID",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the pathway master data identifier associated with the referenced problem or goal. Examples: open heart pathway, new diabetic, total hip replace.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PTH.2.1",
                            Type = @"Component",
                            Position = @"PTH.2.1",
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
                            Id = @"PTH.2.2",
                            Type = @"Component",
                            Position = @"PTH.2.2",
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
                            Id = @"PTH.2.3",
                            Type = @"Component",
                            Position = @"PTH.2.3",
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
                            Id = @"PTH.2.4",
                            Type = @"Component",
                            Position = @"PTH.2.4",
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
                            Id = @"PTH.2.5",
                            Type = @"Component",
                            Position = @"PTH.2.5",
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
                            Id = @"PTH.2.6",
                            Type = @"Component",
                            Position = @"PTH.2.6",
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
                            Id = @"PTH.2.7",
                            Type = @"Component",
                            Position = @"PTH.2.7",
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
                            Id = @"PTH.2.8",
                            Type = @"Component",
                            Position = @"PTH.2.8",
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
                            Id = @"PTH.2.9",
                            Type = @"Component",
                            Position = @"PTH.2.9",
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

        _pathwayID = new HL7V26Field
        {
            field = message[@"PTH"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pathwayID.field.FieldRepetitions != null && _pathwayID.field.FieldRepetitions.Count > 0)
        {
            _pathwayID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_pathwayID, fieldData);
        }

        return _pathwayID;
    } 
}

internal HL7V26Field _pathwayInstanceID;

public HL7V26Field PathwayInstanceID
{
    get
    {
        if (_pathwayInstanceID != null)
        {
            return _pathwayInstanceID;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PTH.3",
            Type = @"Field",
            Position = @"PTH.3",
            Name = @"Pathway Instance ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains a value generated by the originating application that represents an associated order placer group number, or other unique identifier assigned to the grouping of pathway directives.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PTH.3.1",
                            Type = @"Component",
                            Position = @"PTH.3.1",
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
                            Id = @"PTH.3.2",
                            Type = @"Component",
                            Position = @"PTH.3.2",
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
                            Id = @"PTH.3.3",
                            Type = @"Component",
                            Position = @"PTH.3.3",
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
                            Id = @"PTH.3.4",
                            Type = @"Component",
                            Position = @"PTH.3.4",
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

        _pathwayInstanceID = new HL7V26Field
        {
            field = message[@"PTH"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pathwayInstanceID.field.FieldRepetitions != null && _pathwayInstanceID.field.FieldRepetitions.Count > 0)
        {
            _pathwayInstanceID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_pathwayInstanceID, fieldData);
        }

        return _pathwayInstanceID;
    } 
}

internal HL7V26Field _pathwayEstablishedDateTime;

public HL7V26Field PathwayEstablishedDateTime
{
    get
    {
        if (_pathwayEstablishedDateTime != null)
        {
            return _pathwayEstablishedDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PTH.4",
            Type = @"Field",
            Position = @"PTH.4",
            Name = @"Pathway Established Date/Time",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identification of the event time for the current pathway record.",
            Sample = @"",
            Fields = null
        }

        _pathwayEstablishedDateTime = new HL7V26Field
        {
            field = message[@"PTH"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pathwayEstablishedDateTime.field.FieldRepetitions != null && _pathwayEstablishedDateTime.field.FieldRepetitions.Count > 0)
        {
            _pathwayEstablishedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_pathwayEstablishedDateTime, fieldData);
        }

        return _pathwayEstablishedDateTime;
    } 
}

internal HL7V26Field _pathwayLifeCycleStatus;

public HL7V26Field PathwayLifeCycleStatus
{
    get
    {
        if (_pathwayLifeCycleStatus != null)
        {
            return _pathwayLifeCycleStatus;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PTH.5",
            Type = @"Field",
            Position = @"PTH.5",
            Name = @"Pathway Life Cycle Status",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains an application-specific set of state identifiers (e.g., Active, Suspended, Complete, Canceled, Delayed, Scheduled).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PTH.5.1",
                            Type = @"Component",
                            Position = @"PTH.5.1",
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
                            Id = @"PTH.5.2",
                            Type = @"Component",
                            Position = @"PTH.5.2",
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
                            Id = @"PTH.5.3",
                            Type = @"Component",
                            Position = @"PTH.5.3",
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
                            Id = @"PTH.5.4",
                            Type = @"Component",
                            Position = @"PTH.5.4",
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
                            Id = @"PTH.5.5",
                            Type = @"Component",
                            Position = @"PTH.5.5",
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
                            Id = @"PTH.5.6",
                            Type = @"Component",
                            Position = @"PTH.5.6",
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
                            Id = @"PTH.5.7",
                            Type = @"Component",
                            Position = @"PTH.5.7",
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
                            Id = @"PTH.5.8",
                            Type = @"Component",
                            Position = @"PTH.5.8",
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
                            Id = @"PTH.5.9",
                            Type = @"Component",
                            Position = @"PTH.5.9",
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

        _pathwayLifeCycleStatus = new HL7V26Field
        {
            field = message[@"PTH"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pathwayLifeCycleStatus.field.FieldRepetitions != null && _pathwayLifeCycleStatus.field.FieldRepetitions.Count > 0)
        {
            _pathwayLifeCycleStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_pathwayLifeCycleStatus, fieldData);
        }

        return _pathwayLifeCycleStatus;
    } 
}

internal HL7V26Field _changePathwayLifeCycleStatusDateTime;

public HL7V26Field ChangePathwayLifeCycleStatusDateTime
{
    get
    {
        if (_changePathwayLifeCycleStatusDateTime != null)
        {
            return _changePathwayLifeCycleStatusDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PTH.6",
            Type = @"Field",
            Position = @"PTH.6",
            Name = @"Change Pathway Life Cycle Status Date/Time",
            Length = 24,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time when pathway has been modified or deactivated. (Marked as conditional - must be filled in if trigger event is update or terminate pathway.)",
            Sample = @"",
            Fields = null
        }

        _changePathwayLifeCycleStatusDateTime = new HL7V26Field
        {
            field = message[@"PTH"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_changePathwayLifeCycleStatusDateTime.field.FieldRepetitions != null && _changePathwayLifeCycleStatusDateTime.field.FieldRepetitions.Count > 0)
        {
            _changePathwayLifeCycleStatusDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_changePathwayLifeCycleStatusDateTime, fieldData);
        }

        return _changePathwayLifeCycleStatusDateTime;
    } 
}

internal HL7V26Field _moodCode;

public HL7V26Field MoodCode
{
    get
    {
        if (_moodCode != null)
        {
            return _moodCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PTH.7",
            Type = @"Field",
            Position = @"PTH.7",
            Name = @"Mood Code",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0725",
            TableName = @"Mood Codes",
            Description = @"This field indicates the Mood of the Pathway. It allows expression of the context of the Pathway.

Note:  As Mood Code changes the meaning of the segment it must only be used in new messages as of v2.6.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PTH.7.1",
                            Type = @"Component",
                            Position = @"PTH.7.1",
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
                            Id = @"PTH.7.2",
                            Type = @"Component",
                            Position = @"PTH.7.2",
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
                            Id = @"PTH.7.3",
                            Type = @"Component",
                            Position = @"PTH.7.3",
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
                            Id = @"PTH.7.4",
                            Type = @"Component",
                            Position = @"PTH.7.4",
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
                            Id = @"PTH.7.5",
                            Type = @"Component",
                            Position = @"PTH.7.5",
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
                            Id = @"PTH.7.6",
                            Type = @"Component",
                            Position = @"PTH.7.6",
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
                            Id = @"PTH.7.7",
                            Type = @"Component",
                            Position = @"PTH.7.7",
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
                            Id = @"PTH.7.8",
                            Type = @"Component",
                            Position = @"PTH.7.8",
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
                            Id = @"PTH.7.9",
                            Type = @"Component",
                            Position = @"PTH.7.9",
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

        _moodCode = new HL7V26Field
        {
            field = message[@"PTH"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_moodCode.field.FieldRepetitions != null && _moodCode.field.FieldRepetitions.Count > 0)
        {
            _moodCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_moodCode, fieldData);
        }

        return _moodCode;
    } 
}
    }
}
