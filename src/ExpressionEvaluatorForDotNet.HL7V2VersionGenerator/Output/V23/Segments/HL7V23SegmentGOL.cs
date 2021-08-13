using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentGOL
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"GOL"; } }

        public string SegmentId { get { return @"GOL"; } }
        
        public string LongName { get { return @"Goal Detail"; } }
        
        public string Description { get { return @"The goal detail segment contains the data necessary to add, update, correct, and delete the goals for an individual

The business and/or application must assume responsibility for maintaining knowledge about data ownership, versioning, and/or audit trail control (for purposes of data integrity).  It is also their responsibility to represent the appropriate version of that data. "; } }
        
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

        public HL7V23SegmentGOL(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _actionCode;

public HL7V23Field ActionCode
{
    get
    {
        if (_actionCode != null)
        {
            return _actionCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.1",
            Type = @"Field",
            Position = @"GOL.1",
            Name = @"Action Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0287",
            TableName = @"Problem/goal action code",
            Description = @"The action code field gives the intent of the message.  Refer to HL7 table 0287 - Action code for valid values. 

*  The UNCHANGED action code is used to signify to the applications programs that this particular segment includes no information to be modified.  It is supplied in order to identify the correct record for which the following modification is intended. ",
            Sample = @"",
            Fields = null
        }

        _actionCode = new HL7V23Field
        {
            field = message[@"GOL"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actionCode.field.FieldRepetitions != null && _actionCode.field.FieldRepetitions.Count > 0)
        {
            _actionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_actionCode, fieldData);
        }

        return _actionCode;
    } 
}

internal HL7V23Field _actionDateTime;

public HL7V23Field ActionDateTime
{
    get
    {
        if (_actionDateTime != null)
        {
            return _actionDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.2",
            Type = @"Field",
            Position = @"GOL.2",
            Name = @"Action Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the operation represented by the action code was performed",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.2.1",
                            Type = @"Component",
                            Position = @"GOL.2.1",
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

        _actionDateTime = new HL7V23Field
        {
            field = message[@"GOL"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actionDateTime.field.FieldRepetitions != null && _actionDateTime.field.FieldRepetitions.Count > 0)
        {
            _actionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_actionDateTime, fieldData);
        }

        return _actionDateTime;
    } 
}

internal HL7V23Field _goalID;

public HL7V23Field GoalID
{
    get
    {
        if (_goalID != null)
        {
            return _goalID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.3",
            Type = @"Field",
            Position = @"GOL.3",
            Name = @"Goal ID",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the goal.  This is the identifier from an institution’s master list of goals",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.3.1",
                            Type = @"Component",
                            Position = @"GOL.3.1",
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
                            Id = @"GOL.3.2",
                            Type = @"Component",
                            Position = @"GOL.3.2",
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
                            Id = @"GOL.3.3",
                            Type = @"Component",
                            Position = @"GOL.3.3",
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
                            Id = @"GOL.3.4",
                            Type = @"Component",
                            Position = @"GOL.3.4",
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
                            Id = @"GOL.3.5",
                            Type = @"Component",
                            Position = @"GOL.3.5",
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
                            Id = @"GOL.3.6",
                            Type = @"Component",
                            Position = @"GOL.3.6",
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

        _goalID = new HL7V23Field
        {
            field = message[@"GOL"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalID.field.FieldRepetitions != null && _goalID.field.FieldRepetitions.Count > 0)
        {
            _goalID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalID, fieldData);
        }

        return _goalID;
    } 
}

internal HL7V23Field _goalInstanceID;

public HL7V23Field GoalInstanceID
{
    get
    {
        if (_goalInstanceID != null)
        {
            return _goalInstanceID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.4",
            Type = @"Field",
            Position = @"GOL.4",
            Name = @"Goal Instance ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unique identifier assigned by an initiating system to this instance of the goal.

Note: It is required that the value in this field be unique over time.  This instance ID identifies a specific instance for a specific patient and is unique across all patients.  See entity ID data type description in Chapter 2.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.4.1",
                            Type = @"Component",
                            Position = @"GOL.4.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.4.2",
                            Type = @"Component",
                            Position = @"GOL.4.2",
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
                            Id = @"GOL.4.3",
                            Type = @"Component",
                            Position = @"GOL.4.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.4.4",
                            Type = @"Component",
                            Position = @"GOL.4.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _goalInstanceID = new HL7V23Field
        {
            field = message[@"GOL"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalInstanceID.field.FieldRepetitions != null && _goalInstanceID.field.FieldRepetitions.Count > 0)
        {
            _goalInstanceID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalInstanceID, fieldData);
        }

        return _goalInstanceID;
    } 
}

internal HL7V23Field _episodeofCareID;

public HL7V23Field EpisodeofCareID
{
    get
    {
        if (_episodeofCareID != null)
        {
            return _episodeofCareID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.5",
            Type = @"Field",
            Position = @"GOL.5",
            Name = @"Episode of Care ID",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the episode of care to which this goal applies.  See note under “Ongoing issues.” 

Note: Based on application use, this field is required to be unique over time. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.5.1",
                            Type = @"Component",
                            Position = @"GOL.5.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.5.2",
                            Type = @"Component",
                            Position = @"GOL.5.2",
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
                            Id = @"GOL.5.3",
                            Type = @"Component",
                            Position = @"GOL.5.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.5.4",
                            Type = @"Component",
                            Position = @"GOL.5.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _episodeofCareID = new HL7V23Field
        {
            field = message[@"GOL"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_episodeofCareID.field.FieldRepetitions != null && _episodeofCareID.field.FieldRepetitions.Count > 0)
        {
            _episodeofCareID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_episodeofCareID, fieldData);
        }

        return _episodeofCareID;
    } 
}

internal HL7V23Field _goalListPriority;

public HL7V23Field GoalListPriority
{
    get
    {
        if (_goalListPriority != null)
        {
            return _goalListPriority;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.6",
            Type = @"Field",
            Position = @"GOL.6",
            Name = @"Goal List Priority",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field prioritizes this goal on a  list that is maintained for an individual",
            Sample = @"",
            Fields = null
        }

        _goalListPriority = new HL7V23Field
        {
            field = message[@"GOL"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalListPriority.field.FieldRepetitions != null && _goalListPriority.field.FieldRepetitions.Count > 0)
        {
            _goalListPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalListPriority, fieldData);
        }

        return _goalListPriority;
    } 
}

internal HL7V23Field _goalEstablishedDateTime;

public HL7V23Field GoalEstablishedDateTime
{
    get
    {
        if (_goalEstablishedDateTime != null)
        {
            return _goalEstablishedDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.7",
            Type = @"Field",
            Position = @"GOL.7",
            Name = @"Goal Established Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the date/time when the stated goal was initially created. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.7.1",
                            Type = @"Component",
                            Position = @"GOL.7.1",
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

        _goalEstablishedDateTime = new HL7V23Field
        {
            field = message[@"GOL"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalEstablishedDateTime.field.FieldRepetitions != null && _goalEstablishedDateTime.field.FieldRepetitions.Count > 0)
        {
            _goalEstablishedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalEstablishedDateTime, fieldData);
        }

        return _goalEstablishedDateTime;
    } 
}

internal HL7V23Field _expectedGoalAchievementDateTime;

public HL7V23Field ExpectedGoalAchievementDateTime
{
    get
    {
        if (_expectedGoalAchievementDateTime != null)
        {
            return _expectedGoalAchievementDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.8",
            Type = @"Field",
            Position = @"GOL.8",
            Name = @"Expected Goal Achievement Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the projected date/time for achieving the stated goal",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.8.1",
                            Type = @"Component",
                            Position = @"GOL.8.1",
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

        _expectedGoalAchievementDateTime = new HL7V23Field
        {
            field = message[@"GOL"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedGoalAchievementDateTime.field.FieldRepetitions != null && _expectedGoalAchievementDateTime.field.FieldRepetitions.Count > 0)
        {
            _expectedGoalAchievementDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_expectedGoalAchievementDateTime, fieldData);
        }

        return _expectedGoalAchievementDateTime;
    } 
}

internal HL7V23Field _goalClassification;

public HL7V23Field GoalClassification
{
    get
    {
        if (_goalClassification != null)
        {
            return _goalClassification;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.9",
            Type = @"Field",
            Position = @"GOL.9",
            Name = @"Goal Classification",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the kind of goal. This field can be used to categorize goals so that they may be managed and viewed independently within different applications (e.g., admission, final, post-operative, pre-operative, outpatient, discharge, etc.). 

Note: This field can be used to differentiate separate goal lists that may be managed independently within applications.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.9.1",
                            Type = @"Component",
                            Position = @"GOL.9.1",
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
                            Id = @"GOL.9.2",
                            Type = @"Component",
                            Position = @"GOL.9.2",
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
                            Id = @"GOL.9.3",
                            Type = @"Component",
                            Position = @"GOL.9.3",
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
                            Id = @"GOL.9.4",
                            Type = @"Component",
                            Position = @"GOL.9.4",
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
                            Id = @"GOL.9.5",
                            Type = @"Component",
                            Position = @"GOL.9.5",
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
                            Id = @"GOL.9.6",
                            Type = @"Component",
                            Position = @"GOL.9.6",
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

        _goalClassification = new HL7V23Field
        {
            field = message[@"GOL"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalClassification.field.FieldRepetitions != null && _goalClassification.field.FieldRepetitions.Count > 0)
        {
            _goalClassification.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalClassification, fieldData);
        }

        return _goalClassification;
    } 
}

internal HL7V23Field _goalManagementDiscipline;

public HL7V23Field GoalManagementDiscipline
{
    get
    {
        if (_goalManagementDiscipline != null)
        {
            return _goalManagementDiscipline;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.10",
            Type = @"Field",
            Position = @"GOL.10",
            Name = @"Goal Management Discipline",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the category of caregiver with responsibility for managing this specific goal (e.g., care team, nursing, medicine, respiratory therapy, occupational therapy, dietary etc.).  This is a repeating field to allow identification of all disciplines who may have the responsibility for this goal. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.10.1",
                            Type = @"Component",
                            Position = @"GOL.10.1",
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
                            Id = @"GOL.10.2",
                            Type = @"Component",
                            Position = @"GOL.10.2",
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
                            Id = @"GOL.10.3",
                            Type = @"Component",
                            Position = @"GOL.10.3",
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
                            Id = @"GOL.10.4",
                            Type = @"Component",
                            Position = @"GOL.10.4",
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
                            Id = @"GOL.10.5",
                            Type = @"Component",
                            Position = @"GOL.10.5",
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
                            Id = @"GOL.10.6",
                            Type = @"Component",
                            Position = @"GOL.10.6",
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

        _goalManagementDiscipline = new HL7V23Field
        {
            field = message[@"GOL"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalManagementDiscipline.field.FieldRepetitions != null && _goalManagementDiscipline.field.FieldRepetitions.Count > 0)
        {
            _goalManagementDiscipline.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalManagementDiscipline, fieldData);
        }

        return _goalManagementDiscipline;
    } 
}

internal HL7V23Field _currentGoalReviewStatus;

public HL7V23Field CurrentGoalReviewStatus
{
    get
    {
        if (_currentGoalReviewStatus != null)
        {
            return _currentGoalReviewStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.11",
            Type = @"Field",
            Position = @"GOL.11",
            Name = @"Current Goal Review Status",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the current point in the continuum of a goal review cycle (e.g., due, initiated, reviewed, overdue, verified, etc.). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.11.1",
                            Type = @"Component",
                            Position = @"GOL.11.1",
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
                            Id = @"GOL.11.2",
                            Type = @"Component",
                            Position = @"GOL.11.2",
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
                            Id = @"GOL.11.3",
                            Type = @"Component",
                            Position = @"GOL.11.3",
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
                            Id = @"GOL.11.4",
                            Type = @"Component",
                            Position = @"GOL.11.4",
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
                            Id = @"GOL.11.5",
                            Type = @"Component",
                            Position = @"GOL.11.5",
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
                            Id = @"GOL.11.6",
                            Type = @"Component",
                            Position = @"GOL.11.6",
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

        _currentGoalReviewStatus = new HL7V23Field
        {
            field = message[@"GOL"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentGoalReviewStatus.field.FieldRepetitions != null && _currentGoalReviewStatus.field.FieldRepetitions.Count > 0)
        {
            _currentGoalReviewStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_currentGoalReviewStatus, fieldData);
        }

        return _currentGoalReviewStatus;
    } 
}

internal HL7V23Field _currentGoalReviewDateTime;

public HL7V23Field CurrentGoalReviewDateTime
{
    get
    {
        if (_currentGoalReviewDateTime != null)
        {
            return _currentGoalReviewDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.12",
            Type = @"Field",
            Position = @"GOL.12",
            Name = @"Current Goal Review Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time of the current review of the  goal. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.12.1",
                            Type = @"Component",
                            Position = @"GOL.12.1",
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

        _currentGoalReviewDateTime = new HL7V23Field
        {
            field = message[@"GOL"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentGoalReviewDateTime.field.FieldRepetitions != null && _currentGoalReviewDateTime.field.FieldRepetitions.Count > 0)
        {
            _currentGoalReviewDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_currentGoalReviewDateTime, fieldData);
        }

        return _currentGoalReviewDateTime;
    } 
}

internal HL7V23Field _nextGoalReviewDateTime;

public HL7V23Field NextGoalReviewDateTime
{
    get
    {
        if (_nextGoalReviewDateTime != null)
        {
            return _nextGoalReviewDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.13",
            Type = @"Field",
            Position = @"GOL.13",
            Name = @"Next Goal Review Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time of the next scheduled goal review",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.13.1",
                            Type = @"Component",
                            Position = @"GOL.13.1",
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

        _nextGoalReviewDateTime = new HL7V23Field
        {
            field = message[@"GOL"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextGoalReviewDateTime.field.FieldRepetitions != null && _nextGoalReviewDateTime.field.FieldRepetitions.Count > 0)
        {
            _nextGoalReviewDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nextGoalReviewDateTime, fieldData);
        }

        return _nextGoalReviewDateTime;
    } 
}

internal HL7V23Field _previousGoalReviewDateTime;

public HL7V23Field PreviousGoalReviewDateTime
{
    get
    {
        if (_previousGoalReviewDateTime != null)
        {
            return _previousGoalReviewDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.14",
            Type = @"Field",
            Position = @"GOL.14",
            Name = @"Previous Goal Review Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the goal was reviewed prior to the current review.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.14.1",
                            Type = @"Component",
                            Position = @"GOL.14.1",
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

        _previousGoalReviewDateTime = new HL7V23Field
        {
            field = message[@"GOL"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_previousGoalReviewDateTime.field.FieldRepetitions != null && _previousGoalReviewDateTime.field.FieldRepetitions.Count > 0)
        {
            _previousGoalReviewDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_previousGoalReviewDateTime, fieldData);
        }

        return _previousGoalReviewDateTime;
    } 
}

internal HL7V23Field _goalReviewInterval;

public HL7V23Field GoalReviewInterval
{
    get
    {
        if (_goalReviewInterval != null)
        {
            return _goalReviewInterval;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.15",
            Type = @"Field",
            Position = @"GOL.15",
            Name = @"Goal Review Interval",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TQ",
            DataTypeName = @"Timing Quantity",
            TableId = null,
            TableName = null,
            Description = @"This field contains the interval used to calculate the next goal review date. (See Chapter 4, Section 4.4.2, “Interval component (CM)”). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.15.1",
                            Type = @"Component",
                            Position = @"GOL.15.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the quantity of the service that should be provided at each service interval.  For example., if two blood cultures are to be obtained every 4 hours, the quantity would be 2.  If three units of blood are to be typed and cross-matched, the quantity would be 3.  The default value is 1.  When units are required, they can be added, specified by a subcomponent delimiter. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GOL.15.1.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.1.2",
                            Type = @"SubComponent",
                            Position = @"GOL.15.1.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed.  Field-by-field, default units may be defined within the specifications.  When the observation is measured in the default units, the units need not be transmitted.  If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component.  If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7.  If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7.  But in these cases the component separator should be replaced by the subcomponent delimiter ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.2",
                            Type = @"Component",
                            Position = @"GOL.15.2",
                            Name = @"Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"RI",
                            DataTypeName = @"Repeat Interval",
                            TableId = null,
                            TableName = null,
                            Description = @"This field determines the interval between repeated services.

The default is one time only, the first subcomponent is the repeat pattern, and the second subcomponent is the explicit time at which pattern is to be executed",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GOL.15.2.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.2.1",
                            Name = @"Repeat Pattern",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The first component is defined by user-defined table 0335 - Repeat pattern. See Section  4.4.2.1 “Repeat pattern,”  for further details",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.2.2",
                            Type = @"SubComponent",
                            Position = @"GOL.15.2.2",
                            Name = @"Explicit Time Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component explicitly lists the actual times referenced by the code in the first subcomponent, in the following format: HHMM,HHMM,HHMM,.…  This second subcomponent will be used to clarify the first subcomponent in cases where the actual administration times vary within an institution. See Section 4.4.2.2, “Explicit time interval subcomponent,” for further details.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.3",
                            Type = @"Component",
                            Position = @"GOL.15.3",
                            Name = @"Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates how long the service should continue after it is started.  The default is INDEF (do indefinitely)

S<integer> = <integer> seconds 
M<integer> = <integer> minutes 
H<integer> = <integer> hours 
D<integer> = <integer> days 
W<integer> = <integer> weeks 
L<integer> = <integer> months 
X<integer> = <integer> times at interval specified in the order.  A request for 2 blood cultures Q2H X3 would imply obtaining 2 blood cultures 3 different times at 2-hour intervals for a total of 6 blood cultures. 
T<integer> = at the interval and amount stated until a total of <integer> “DOSAGE” is accumulated.  Units would be assumed to be the same as in the QUANTITY field. INDEF = do indefinitely - also the default ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.4",
                            Type = @"Component",
                            Position = @"GOL.15.4",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be specified by the orderer, in which case it indicates the earliest date/time at which the services should be started.  In many cases, however, the start date/time will be implied or will be defined by other fields in the order record (e.g., urgency - STAT).  In such a case, this field will be empty.  

The filling service will often record a value in this field after receipt of the order, however, and compute an end time on the basis of the start date/time for the filling service’s internal use. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GOL.15.4.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.4.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.5",
                            Type = @"Component",
                            Position = @"GOL.15.5",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"When filled in by the requester of the service, this field should be the latest date/time that the service should be performed.  If it has not been performed by the specified time, it should not be performed at all.  The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.  

Regardless of the value of the end date/time, the service should be stopped at the earliest of the date/times specified by either the duration or the end date/time.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GOL.15.5.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.5.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.6",
                            Type = @"Component",
                            Position = @"GOL.15.6",
                            Name = @"Priority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field describes the urgency of the request.  The following values are suggested (the default for Priority is R):

S = Stat With highest priority 
A = ASAP Fill after S orders 
R = Routine Default 
P = Preop  
C = Callback  
T = Timing critical A request implying that it is critical to come as close as possible to the requested time, e.g., for a trough antimicrobial level. 
PRN = As needed

If using the value “T” (timing critical), the degree of criticality can be specified thus:
 
Format: 
TS<integer> = timing critical within <integer> seconds 
TM<integer> = timing critical within <integer> minutes 
TH<integer> = timing critical within <integer> hours 
TD<integer> = timing critical within <integer> days 
TW<integer> = timing critical within <integer> weeks 
TL<integer> = timing critical within <integer> months 

For the sequential orders specification, these values specify the time criticality with which the predecessor order must be followed by the given order. 
The priority component may repeat; separate repeating values with the repeat delimiter separated by a space",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.7",
                            Type = @"Component",
                            Position = @"GOL.15.7",
                            Name = @"Condition",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a free text field that describes the conditions under which the drug is to be given.  For example, PRN pain, or to keep blood pressure below 110.  The presence of text in this field should be taken to mean that human review is needed to determine the how and/or when this drug should be given",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.8",
                            Type = @"Component",
                            Position = @"GOL.15.8",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a full text version of the instruction (optional)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.9",
                            Type = @"Component",
                            Position = @"GOL.15.9",
                            Name = @"Conjunction",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This non-null component indicates that a second timing specification is to follow using the repeat delimiter.  This field can take three values:  

S =  Synchronous  
Do the next specification after this one (unless otherwise constrained by the following components: ORC4^4-start date/time and ORC-4^5-end date/time).  
An “S” specification implies that the second timing sequence follows the first, e.g., when an order is written to measure blood pressure Q15 minutes for the 1st hour, then every 2 hours for the next day.  

A =  Asynchronous  
Do the next specification in parallel with this one (unless otherwise constrained by the following components: ORC-4^4-start date/time and ORC-4^5-end date/time).  The conjunction of “A” specifies two parallel instructions, as are sometimes used in medication, e.g., prednisone given at 1 tab on Monday, Wednesday, Friday, and at 1/2 tab on Tuesday, Thursday, Saturday, Sunday.  

C =  This is an actuation time 
It will be followed by a completion time for the service.  This code allows one to distinguish between the time and priority at which a service should be actuated (e.g., blood should be drawn) and the time and priority at which a service should be completed (e.g., results should be reported)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10",
                            Type = @"Component",
                            Position = @"GOL.15.10",
                            Name = @"Order Sequencing",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_OSD",
                            DataTypeName = @"Order Sequence",
                            TableId = null,
                            TableName = null,
                            Description = @"There are many situations, such as the creation of an order for a group of intravenous (IV) solutions, where the sequence of the individual intravenous solutions (each a service in itself) needs to be specified, e.g., hyperalimentation with multi-vitamins in every third bottle. 

There are other situations where part of the order’s instructions contains a results condition of some type, such as “PRN pain.”  There is currently a free text “condition” component of ORC-4-quantity/timing which allows any condition to be specified.  However, to support a fully encoded version of order sequencing, or results condition, we have defined in the following paragraphs a 10th component of ORC-4-quantity/timing.  

The sequencing conditions supported by this 10th component are based on the completion of a  predecessor service",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.1",
                            Name = @"Sequence/results Flag",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"OSD1",
                            TableName = @"Sequence condition",
                            Description = @"S for sequence conditions; C for cyclical; R is reserved for possible future use. The C will be used for indicating a repeating cycle of orders; for example, individual intravenous solutions used in a cyclical sequence (a.k.a. “Alternating IVs”).  This value would be compatible with linking separate orders or with having all cyclical order components in a single order.  Likewise, the value would be compatible with either Parent-Child messages or a single order message to communicate the orders’ sequencin",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.2",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.2",
                            Name = @"Placer Order Number Entity Identifier",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first two components of the placer order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.3",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.3",
                            Name = @"Placer Order Number Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first two components of the placer order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.4",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.4",
                            Name = @"Filler Order Number Entity Identifier",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first two components of the filler order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.5",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.5",
                            Name = @"Filler Order Number Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first two components of the filler order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.6",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.6",
                            Name = @"Sequence Condition Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The acceptable condition values have the form commonly used in project planning methodologies: <one of “SS”, “EE”, “SE”, or “ES”> +/- <time> 

The first letter stands for start (S) or end (E) of predecessor order, where the predecessor is defined by the placer or filler order number in subcomponents 1,2 or subcomponents 3,4. 

The second letter stands for the start (S) or end (E) of the successor order, where the successor order is the order containing this quantity/timing specification. 

The time specifies the interval between the predecessor and successor starts or ends (see following examples). Where <time> is defined as:  

 - S<integer> do for <integer> seconds  
 - M<integer> do for <integer> minutes  
 - H<integer> do for <integer> hours  
 - D<integer> do for <integer> days  
 - W<integer> do for <integer> weeks  
 - L<integer> do for <integer> months",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.7",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.7",
                            Name = @"Maximum Number Of Repeats",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum number of repeats to be used only on cyclic groups.  The total number of repeats is constrained by the end date/time of the last repeat or the end date/time of the parent, whichever is first.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.8",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.8",
                            Name = @"Placer Order Number Universal ID",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the placer order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.9",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.9",
                            Name = @"Placer Order Number Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the placer order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.10",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.10",
                            Name = @"Filler Order Number Universal ID",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the filler order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.11",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.11",
                            Name = @"Filler Order Number Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the filler order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _goalReviewInterval = new HL7V23Field
        {
            field = message[@"GOL"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalReviewInterval.field.FieldRepetitions != null && _goalReviewInterval.field.FieldRepetitions.Count > 0)
        {
            _goalReviewInterval.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalReviewInterval, fieldData);
        }

        return _goalReviewInterval;
    } 
}

internal HL7V23Field _goalEvaluation;

public HL7V23Field GoalEvaluation
{
    get
    {
        if (_goalEvaluation != null)
        {
            return _goalEvaluation;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.16",
            Type = @"Field",
            Position = @"GOL.16",
            Name = @"Goal Evaluation",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field provides an indicator of progress towards achievement of the goal (e.g., achieved, ahead of schedule, delayed, failed to achieve, etc.). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.16.1",
                            Type = @"Component",
                            Position = @"GOL.16.1",
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
                            Id = @"GOL.16.2",
                            Type = @"Component",
                            Position = @"GOL.16.2",
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
                            Id = @"GOL.16.3",
                            Type = @"Component",
                            Position = @"GOL.16.3",
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
                            Id = @"GOL.16.4",
                            Type = @"Component",
                            Position = @"GOL.16.4",
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
                            Id = @"GOL.16.5",
                            Type = @"Component",
                            Position = @"GOL.16.5",
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
                            Id = @"GOL.16.6",
                            Type = @"Component",
                            Position = @"GOL.16.6",
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

        _goalEvaluation = new HL7V23Field
        {
            field = message[@"GOL"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalEvaluation.field.FieldRepetitions != null && _goalEvaluation.field.FieldRepetitions.Count > 0)
        {
            _goalEvaluation.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalEvaluation, fieldData);
        }

        return _goalEvaluation;
    } 
}

internal HL7V23Field _goalEvaluationComment;

public HL7V23Field GoalEvaluationComment
{
    get
    {
        if (_goalEvaluationComment != null)
        {
            return _goalEvaluationComment;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.17",
            Type = @"Field",
            Position = @"GOL.17",
            Name = @"Goal Evaluation Comment",
            Length = 300,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the comments associated with the goal evaluation.  Examples of comments that might be entered in this field include: a reason for delay in achieving goal, or a clinical footnote about progress made towards the goal, etc. ",
            Sample = @"",
            Fields = null
        }

        _goalEvaluationComment = new HL7V23Field
        {
            field = message[@"GOL"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalEvaluationComment.field.FieldRepetitions != null && _goalEvaluationComment.field.FieldRepetitions.Count > 0)
        {
            _goalEvaluationComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalEvaluationComment, fieldData);
        }

        return _goalEvaluationComment;
    } 
}

internal HL7V23Field _goalLifeCycleStatus;

public HL7V23Field GoalLifeCycleStatus
{
    get
    {
        if (_goalLifeCycleStatus != null)
        {
            return _goalLifeCycleStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.18",
            Type = @"Field",
            Position = @"GOL.18",
            Name = @"Goal Life Cycle Status",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an indication of the state of the goal (e.g., Active, Canceled, Inactive, Suspended, etc.). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.18.1",
                            Type = @"Component",
                            Position = @"GOL.18.1",
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
                            Id = @"GOL.18.2",
                            Type = @"Component",
                            Position = @"GOL.18.2",
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
                            Id = @"GOL.18.3",
                            Type = @"Component",
                            Position = @"GOL.18.3",
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
                            Id = @"GOL.18.4",
                            Type = @"Component",
                            Position = @"GOL.18.4",
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
                            Id = @"GOL.18.5",
                            Type = @"Component",
                            Position = @"GOL.18.5",
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
                            Id = @"GOL.18.6",
                            Type = @"Component",
                            Position = @"GOL.18.6",
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

        _goalLifeCycleStatus = new HL7V23Field
        {
            field = message[@"GOL"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalLifeCycleStatus.field.FieldRepetitions != null && _goalLifeCycleStatus.field.FieldRepetitions.Count > 0)
        {
            _goalLifeCycleStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalLifeCycleStatus, fieldData);
        }

        return _goalLifeCycleStatus;
    } 
}

internal HL7V23Field _goalLifeCycleStatusDateTime;

public HL7V23Field GoalLifeCycleStatusDateTime
{
    get
    {
        if (_goalLifeCycleStatusDateTime != null)
        {
            return _goalLifeCycleStatusDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.19",
            Type = @"Field",
            Position = @"GOL.19",
            Name = @"Goal Life Cycle Status Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the effective date/time of the current goal life cycle status",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.19.1",
                            Type = @"Component",
                            Position = @"GOL.19.1",
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

        _goalLifeCycleStatusDateTime = new HL7V23Field
        {
            field = message[@"GOL"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalLifeCycleStatusDateTime.field.FieldRepetitions != null && _goalLifeCycleStatusDateTime.field.FieldRepetitions.Count > 0)
        {
            _goalLifeCycleStatusDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalLifeCycleStatusDateTime, fieldData);
        }

        return _goalLifeCycleStatusDateTime;
    } 
}

internal HL7V23Field _goalTargetType;

public HL7V23Field GoalTargetType
{
    get
    {
        if (_goalTargetType != null)
        {
            return _goalTargetType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.20",
            Type = @"Field",
            Position = @"GOL.20",
            Name = @"Goal Target Type",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the individual/group for whom the goal has been established (e.g., family group, family member, patient, etc.). 

Note: This field is focused on a specific person/group that is directly patient-related",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.20.1",
                            Type = @"Component",
                            Position = @"GOL.20.1",
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
                            Id = @"GOL.20.2",
                            Type = @"Component",
                            Position = @"GOL.20.2",
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
                            Id = @"GOL.20.3",
                            Type = @"Component",
                            Position = @"GOL.20.3",
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
                            Id = @"GOL.20.4",
                            Type = @"Component",
                            Position = @"GOL.20.4",
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
                            Id = @"GOL.20.5",
                            Type = @"Component",
                            Position = @"GOL.20.5",
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
                            Id = @"GOL.20.6",
                            Type = @"Component",
                            Position = @"GOL.20.6",
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

        _goalTargetType = new HL7V23Field
        {
            field = message[@"GOL"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalTargetType.field.FieldRepetitions != null && _goalTargetType.field.FieldRepetitions.Count > 0)
        {
            _goalTargetType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalTargetType, fieldData);
        }

        return _goalTargetType;
    } 
}

internal HL7V23Field _goalTargetName;

public HL7V23Field GoalTargetName
{
    get
    {
        if (_goalTargetName != null)
        {
            return _goalTargetName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GOL.21",
            Type = @"Field",
            Position = @"GOL.21",
            Name = @"Goal Target Name",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identification of the person(s) on whom the goal is focused.  This is a repeating field which allows for the identification of a group of individuals",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.21.1",
                            Type = @"Component",
                            Position = @"GOL.21.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.2",
                            Type = @"Component",
                            Position = @"GOL.21.2",
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
                            Id = @"GOL.21.3",
                            Type = @"Component",
                            Position = @"GOL.21.3",
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
                            Id = @"GOL.21.4",
                            Type = @"Component",
                            Position = @"GOL.21.4",
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
                            Id = @"GOL.21.5",
                            Type = @"Component",
                            Position = @"GOL.21.5",
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
                            Id = @"GOL.21.6",
                            Type = @"Component",
                            Position = @"GOL.21.6",
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
                            Id = @"GOL.21.7",
                            Type = @"Component",
                            Position = @"GOL.21.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.8",
                            Type = @"Component",
                            Position = @"GOL.21.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _goalTargetName = new HL7V23Field
        {
            field = message[@"GOL"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_goalTargetName.field.FieldRepetitions != null && _goalTargetName.field.FieldRepetitions.Count > 0)
        {
            _goalTargetName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_goalTargetName, fieldData);
        }

        return _goalTargetName;
    } 
}
    }
}
