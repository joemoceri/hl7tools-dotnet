using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentPRB
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PRB"; } }

        public string SegmentId { get { return @"PRB"; } }
        
        public string LongName { get { return @"Problem Details"; } }
        
        public string Description { get { return @"The problem detail segment contains the data necessary to add, update, correct, and delete the problems of a given individual."; } }
        
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

        public HL7V26SegmentPRB(HL7V2Message message)
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
            Id = @"PRB.1",
            Type = @"Field",
            Position = @"PRB.1",
            Name = @"Action Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0287",
            TableName = @"Problem/goal action code",
            Description = @"This field contains the intent of the message. Refer to HL7 table 0287 - Problem/goal action code for valid values.",
            Sample = @"",
            Fields = null
        }

        _actionCode = new HL7V26Field
        {
            field = message[@"PRB"][1],
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

internal HL7V26Field _actionDateTime;

public HL7V26Field ActionDateTime
{
    get
    {
        if (_actionDateTime != null)
        {
            return _actionDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.2",
            Type = @"Field",
            Position = @"PRB.2",
            Name = @"Action Date/Time",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the operation represented by the action code was performed.",
            Sample = @"",
            Fields = null
        }

        _actionDateTime = new HL7V26Field
        {
            field = message[@"PRB"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actionDateTime.field.FieldRepetitions != null && _actionDateTime.field.FieldRepetitions.Count > 0)
        {
            _actionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_actionDateTime, fieldData);
        }

        return _actionDateTime;
    } 
}

internal HL7V26Field _problemID;

public HL7V26Field ProblemID
{
    get
    {
        if (_problemID != null)
        {
            return _problemID;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.3",
            Type = @"Field",
            Position = @"PRB.3",
            Name = @"Problem ID",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the problem. This is the identifier from an institution's master list of problems.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.3.1",
                            Type = @"Component",
                            Position = @"PRB.3.1",
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
                            Id = @"PRB.3.2",
                            Type = @"Component",
                            Position = @"PRB.3.2",
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
                            Id = @"PRB.3.3",
                            Type = @"Component",
                            Position = @"PRB.3.3",
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
                            Id = @"PRB.3.4",
                            Type = @"Component",
                            Position = @"PRB.3.4",
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
                            Id = @"PRB.3.5",
                            Type = @"Component",
                            Position = @"PRB.3.5",
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
                            Id = @"PRB.3.6",
                            Type = @"Component",
                            Position = @"PRB.3.6",
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
                            Id = @"PRB.3.7",
                            Type = @"Component",
                            Position = @"PRB.3.7",
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
                            Id = @"PRB.3.8",
                            Type = @"Component",
                            Position = @"PRB.3.8",
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
                            Id = @"PRB.3.9",
                            Type = @"Component",
                            Position = @"PRB.3.9",
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

        _problemID = new HL7V26Field
        {
            field = message[@"PRB"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemID.field.FieldRepetitions != null && _problemID.field.FieldRepetitions.Count > 0)
        {
            _problemID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemID, fieldData);
        }

        return _problemID;
    } 
}

internal HL7V26Field _problemInstanceID;

public HL7V26Field ProblemInstanceID
{
    get
    {
        if (_problemInstanceID != null)
        {
            return _problemInstanceID;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.4",
            Type = @"Field",
            Position = @"PRB.4",
            Name = @"Problem Instance ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier assigned by an initiating system to an instance of a problem.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.4.1",
                            Type = @"Component",
                            Position = @"PRB.4.1",
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
                            Id = @"PRB.4.2",
                            Type = @"Component",
                            Position = @"PRB.4.2",
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
                            Id = @"PRB.4.3",
                            Type = @"Component",
                            Position = @"PRB.4.3",
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
                            Id = @"PRB.4.4",
                            Type = @"Component",
                            Position = @"PRB.4.4",
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

        _problemInstanceID = new HL7V26Field
        {
            field = message[@"PRB"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemInstanceID.field.FieldRepetitions != null && _problemInstanceID.field.FieldRepetitions.Count > 0)
        {
            _problemInstanceID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemInstanceID, fieldData);
        }

        return _problemInstanceID;
    } 
}

internal HL7V26Field _episodeofCareID;

public HL7V26Field EpisodeofCareID
{
    get
    {
        if (_episodeofCareID != null)
        {
            return _episodeofCareID;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.5",
            Type = @"Field",
            Position = @"PRB.5",
            Name = @"Episode of Care ID",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the episode of care to which this problem applies. (See note under ""Ongoing issues."")",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.5.1",
                            Type = @"Component",
                            Position = @"PRB.5.1",
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
                            Id = @"PRB.5.2",
                            Type = @"Component",
                            Position = @"PRB.5.2",
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
                            Id = @"PRB.5.3",
                            Type = @"Component",
                            Position = @"PRB.5.3",
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
                            Id = @"PRB.5.4",
                            Type = @"Component",
                            Position = @"PRB.5.4",
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

        _episodeofCareID = new HL7V26Field
        {
            field = message[@"PRB"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_episodeofCareID.field.FieldRepetitions != null && _episodeofCareID.field.FieldRepetitions.Count > 0)
        {
            _episodeofCareID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_episodeofCareID, fieldData);
        }

        return _episodeofCareID;
    } 
}

internal HL7V26Field _problemListPriority;

public HL7V26Field ProblemListPriority
{
    get
    {
        if (_problemListPriority != null)
        {
            return _problemListPriority;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.6",
            Type = @"Field",
            Position = @"PRB.6",
            Name = @"Problem List Priority",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field prioritizes this problem on a list that is maintained for the individual.",
            Sample = @"",
            Fields = null
        }

        _problemListPriority = new HL7V26Field
        {
            field = message[@"PRB"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemListPriority.field.FieldRepetitions != null && _problemListPriority.field.FieldRepetitions.Count > 0)
        {
            _problemListPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemListPriority, fieldData);
        }

        return _problemListPriority;
    } 
}

internal HL7V26Field _problemEstablishedDateTime;

public HL7V26Field ProblemEstablishedDateTime
{
    get
    {
        if (_problemEstablishedDateTime != null)
        {
            return _problemEstablishedDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.7",
            Type = @"Field",
            Position = @"PRB.7",
            Name = @"Problem Established Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time when the corresponding problem was initially identified by the caregiver.",
            Sample = @"",
            Fields = null
        }

        _problemEstablishedDateTime = new HL7V26Field
        {
            field = message[@"PRB"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemEstablishedDateTime.field.FieldRepetitions != null && _problemEstablishedDateTime.field.FieldRepetitions.Count > 0)
        {
            _problemEstablishedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemEstablishedDateTime, fieldData);
        }

        return _problemEstablishedDateTime;
    } 
}

internal HL7V26Field _anticipatedProblemResolutionDateTime;

public HL7V26Field AnticipatedProblemResolutionDateTime
{
    get
    {
        if (_anticipatedProblemResolutionDateTime != null)
        {
            return _anticipatedProblemResolutionDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.8",
            Type = @"Field",
            Position = @"PRB.8",
            Name = @"Anticipated Problem Resolution Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the estimated date/time for resolving the stated problem.",
            Sample = @"",
            Fields = null
        }

        _anticipatedProblemResolutionDateTime = new HL7V26Field
        {
            field = message[@"PRB"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anticipatedProblemResolutionDateTime.field.FieldRepetitions != null && _anticipatedProblemResolutionDateTime.field.FieldRepetitions.Count > 0)
        {
            _anticipatedProblemResolutionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_anticipatedProblemResolutionDateTime, fieldData);
        }

        return _anticipatedProblemResolutionDateTime;
    } 
}

internal HL7V26Field _actualProblemResolutionDateTime;

public HL7V26Field ActualProblemResolutionDateTime
{
    get
    {
        if (_actualProblemResolutionDateTime != null)
        {
            return _actualProblemResolutionDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.9",
            Type = @"Field",
            Position = @"PRB.9",
            Name = @"Actual Problem Resolution Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the problem was actually resolved.",
            Sample = @"",
            Fields = null
        }

        _actualProblemResolutionDateTime = new HL7V26Field
        {
            field = message[@"PRB"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actualProblemResolutionDateTime.field.FieldRepetitions != null && _actualProblemResolutionDateTime.field.FieldRepetitions.Count > 0)
        {
            _actualProblemResolutionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_actualProblemResolutionDateTime, fieldData);
        }

        return _actualProblemResolutionDateTime;
    } 
}

internal HL7V26Field _problemClassification;

public HL7V26Field ProblemClassification
{
    get
    {
        if (_problemClassification != null)
        {
            return _problemClassification;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.10",
            Type = @"Field",
            Position = @"PRB.10",
            Name = @"Problem Classification",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the kind of problem. This field can be used to categorize problems so that they may be managed and viewed independently within different applications (e.g., admission, final, post-operative, pre-operative, outpatient, discharge, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.10.1",
                            Type = @"Component",
                            Position = @"PRB.10.1",
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
                            Id = @"PRB.10.2",
                            Type = @"Component",
                            Position = @"PRB.10.2",
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
                            Id = @"PRB.10.3",
                            Type = @"Component",
                            Position = @"PRB.10.3",
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
                            Id = @"PRB.10.4",
                            Type = @"Component",
                            Position = @"PRB.10.4",
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
                            Id = @"PRB.10.5",
                            Type = @"Component",
                            Position = @"PRB.10.5",
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
                            Id = @"PRB.10.6",
                            Type = @"Component",
                            Position = @"PRB.10.6",
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
                            Id = @"PRB.10.7",
                            Type = @"Component",
                            Position = @"PRB.10.7",
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
                            Id = @"PRB.10.8",
                            Type = @"Component",
                            Position = @"PRB.10.8",
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
                            Id = @"PRB.10.9",
                            Type = @"Component",
                            Position = @"PRB.10.9",
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

        _problemClassification = new HL7V26Field
        {
            field = message[@"PRB"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemClassification.field.FieldRepetitions != null && _problemClassification.field.FieldRepetitions.Count > 0)
        {
            _problemClassification.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemClassification, fieldData);
        }

        return _problemClassification;
    } 
}

internal HL7V26Field _problemManagementDiscipline;

public HL7V26Field ProblemManagementDiscipline
{
    get
    {
        if (_problemManagementDiscipline != null)
        {
            return _problemManagementDiscipline;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.11",
            Type = @"Field",
            Position = @"PRB.11",
            Name = @"Problem Management Discipline",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the category of caregiver with responsibility for managing this specific problem (e.g., care team, nursing, medicine, respiratory therapy, occupational therapy, dietary, etc.). This is a repeating field to allow identification of all disciplines that may have the responsibility for this problem.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.11.1",
                            Type = @"Component",
                            Position = @"PRB.11.1",
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
                            Id = @"PRB.11.2",
                            Type = @"Component",
                            Position = @"PRB.11.2",
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
                            Id = @"PRB.11.3",
                            Type = @"Component",
                            Position = @"PRB.11.3",
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
                            Id = @"PRB.11.4",
                            Type = @"Component",
                            Position = @"PRB.11.4",
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
                            Id = @"PRB.11.5",
                            Type = @"Component",
                            Position = @"PRB.11.5",
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
                            Id = @"PRB.11.6",
                            Type = @"Component",
                            Position = @"PRB.11.6",
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
                            Id = @"PRB.11.7",
                            Type = @"Component",
                            Position = @"PRB.11.7",
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
                            Id = @"PRB.11.8",
                            Type = @"Component",
                            Position = @"PRB.11.8",
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
                            Id = @"PRB.11.9",
                            Type = @"Component",
                            Position = @"PRB.11.9",
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

        _problemManagementDiscipline = new HL7V26Field
        {
            field = message[@"PRB"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemManagementDiscipline.field.FieldRepetitions != null && _problemManagementDiscipline.field.FieldRepetitions.Count > 0)
        {
            _problemManagementDiscipline.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemManagementDiscipline, fieldData);
        }

        return _problemManagementDiscipline;
    } 
}

internal HL7V26Field _problemPersistence;

public HL7V26Field ProblemPersistence
{
    get
    {
        if (_problemPersistence != null)
        {
            return _problemPersistence;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.12",
            Type = @"Field",
            Position = @"PRB.12",
            Name = @"Problem Persistence",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the perseverance of a problem (e.g., acute, chronic, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.12.1",
                            Type = @"Component",
                            Position = @"PRB.12.1",
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
                            Id = @"PRB.12.2",
                            Type = @"Component",
                            Position = @"PRB.12.2",
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
                            Id = @"PRB.12.3",
                            Type = @"Component",
                            Position = @"PRB.12.3",
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
                            Id = @"PRB.12.4",
                            Type = @"Component",
                            Position = @"PRB.12.4",
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
                            Id = @"PRB.12.5",
                            Type = @"Component",
                            Position = @"PRB.12.5",
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
                            Id = @"PRB.12.6",
                            Type = @"Component",
                            Position = @"PRB.12.6",
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
                            Id = @"PRB.12.7",
                            Type = @"Component",
                            Position = @"PRB.12.7",
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
                            Id = @"PRB.12.8",
                            Type = @"Component",
                            Position = @"PRB.12.8",
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
                            Id = @"PRB.12.9",
                            Type = @"Component",
                            Position = @"PRB.12.9",
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

        _problemPersistence = new HL7V26Field
        {
            field = message[@"PRB"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemPersistence.field.FieldRepetitions != null && _problemPersistence.field.FieldRepetitions.Count > 0)
        {
            _problemPersistence.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemPersistence, fieldData);
        }

        return _problemPersistence;
    } 
}

internal HL7V26Field _problemConfirmationStatus;

public HL7V26Field ProblemConfirmationStatus
{
    get
    {
        if (_problemConfirmationStatus != null)
        {
            return _problemConfirmationStatus;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.13",
            Type = @"Field",
            Position = @"PRB.13",
            Name = @"Problem Confirmation Status",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the verification status of a problem (e.g., confirmed, differential, provisional, rule-out, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.13.1",
                            Type = @"Component",
                            Position = @"PRB.13.1",
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
                            Id = @"PRB.13.2",
                            Type = @"Component",
                            Position = @"PRB.13.2",
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
                            Id = @"PRB.13.3",
                            Type = @"Component",
                            Position = @"PRB.13.3",
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
                            Id = @"PRB.13.4",
                            Type = @"Component",
                            Position = @"PRB.13.4",
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
                            Id = @"PRB.13.5",
                            Type = @"Component",
                            Position = @"PRB.13.5",
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
                            Id = @"PRB.13.6",
                            Type = @"Component",
                            Position = @"PRB.13.6",
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
                            Id = @"PRB.13.7",
                            Type = @"Component",
                            Position = @"PRB.13.7",
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
                            Id = @"PRB.13.8",
                            Type = @"Component",
                            Position = @"PRB.13.8",
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
                            Id = @"PRB.13.9",
                            Type = @"Component",
                            Position = @"PRB.13.9",
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

        _problemConfirmationStatus = new HL7V26Field
        {
            field = message[@"PRB"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemConfirmationStatus.field.FieldRepetitions != null && _problemConfirmationStatus.field.FieldRepetitions.Count > 0)
        {
            _problemConfirmationStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemConfirmationStatus, fieldData);
        }

        return _problemConfirmationStatus;
    } 
}

internal HL7V26Field _problemLifeCycleStatus;

public HL7V26Field ProblemLifeCycleStatus
{
    get
    {
        if (_problemLifeCycleStatus != null)
        {
            return _problemLifeCycleStatus;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.14",
            Type = @"Field",
            Position = @"PRB.14",
            Name = @"Problem Life Cycle Status",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the current status of the problem at this particular date/time (e.g., active, active-improving, active-stable, active-worsening, inactive, resolved, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.14.1",
                            Type = @"Component",
                            Position = @"PRB.14.1",
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
                            Id = @"PRB.14.2",
                            Type = @"Component",
                            Position = @"PRB.14.2",
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
                            Id = @"PRB.14.3",
                            Type = @"Component",
                            Position = @"PRB.14.3",
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
                            Id = @"PRB.14.4",
                            Type = @"Component",
                            Position = @"PRB.14.4",
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
                            Id = @"PRB.14.5",
                            Type = @"Component",
                            Position = @"PRB.14.5",
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
                            Id = @"PRB.14.6",
                            Type = @"Component",
                            Position = @"PRB.14.6",
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
                            Id = @"PRB.14.7",
                            Type = @"Component",
                            Position = @"PRB.14.7",
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
                            Id = @"PRB.14.8",
                            Type = @"Component",
                            Position = @"PRB.14.8",
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
                            Id = @"PRB.14.9",
                            Type = @"Component",
                            Position = @"PRB.14.9",
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

        _problemLifeCycleStatus = new HL7V26Field
        {
            field = message[@"PRB"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemLifeCycleStatus.field.FieldRepetitions != null && _problemLifeCycleStatus.field.FieldRepetitions.Count > 0)
        {
            _problemLifeCycleStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemLifeCycleStatus, fieldData);
        }

        return _problemLifeCycleStatus;
    } 
}

internal HL7V26Field _problemLifeCycleStatusDateTime;

public HL7V26Field ProblemLifeCycleStatusDateTime
{
    get
    {
        if (_problemLifeCycleStatusDateTime != null)
        {
            return _problemLifeCycleStatusDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.15",
            Type = @"Field",
            Position = @"PRB.15",
            Name = @"Problem Life Cycle Status Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the effective date/time of the current problem life cycle status.",
            Sample = @"",
            Fields = null
        }

        _problemLifeCycleStatusDateTime = new HL7V26Field
        {
            field = message[@"PRB"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemLifeCycleStatusDateTime.field.FieldRepetitions != null && _problemLifeCycleStatusDateTime.field.FieldRepetitions.Count > 0)
        {
            _problemLifeCycleStatusDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemLifeCycleStatusDateTime, fieldData);
        }

        return _problemLifeCycleStatusDateTime;
    } 
}

internal HL7V26Field _problemDateofOnset;

public HL7V26Field ProblemDateofOnset
{
    get
    {
        if (_problemDateofOnset != null)
        {
            return _problemDateofOnset;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.16",
            Type = @"Field",
            Position = @"PRB.16",
            Name = @"Problem Date of Onset",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time when the problem began.",
            Sample = @"",
            Fields = null
        }

        _problemDateofOnset = new HL7V26Field
        {
            field = message[@"PRB"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemDateofOnset.field.FieldRepetitions != null && _problemDateofOnset.field.FieldRepetitions.Count > 0)
        {
            _problemDateofOnset.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemDateofOnset, fieldData);
        }

        return _problemDateofOnset;
    } 
}

internal HL7V26Field _problemOnsetText;

public HL7V26Field ProblemOnsetText
{
    get
    {
        if (_problemOnsetText != null)
        {
            return _problemOnsetText;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.17",
            Type = @"Field",
            Position = @"PRB.17",
            Name = @"Problem Onset Text",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field allows for a textual representation of the time when the problem began.",
            Sample = @"",
            Fields = null
        }

        _problemOnsetText = new HL7V26Field
        {
            field = message[@"PRB"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemOnsetText.field.FieldRepetitions != null && _problemOnsetText.field.FieldRepetitions.Count > 0)
        {
            _problemOnsetText.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemOnsetText, fieldData);
        }

        return _problemOnsetText;
    } 
}

internal HL7V26Field _problemRanking;

public HL7V26Field ProblemRanking
{
    get
    {
        if (_problemRanking != null)
        {
            return _problemRanking;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.18",
            Type = @"Field",
            Position = @"PRB.18",
            Name = @"Problem Ranking",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains a user-defined prioritization of a problem (e.g., numeric ranking, or the use of words such as ""primary,"" ""secondary,"" etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.18.1",
                            Type = @"Component",
                            Position = @"PRB.18.1",
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
                            Id = @"PRB.18.2",
                            Type = @"Component",
                            Position = @"PRB.18.2",
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
                            Id = @"PRB.18.3",
                            Type = @"Component",
                            Position = @"PRB.18.3",
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
                            Id = @"PRB.18.4",
                            Type = @"Component",
                            Position = @"PRB.18.4",
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
                            Id = @"PRB.18.5",
                            Type = @"Component",
                            Position = @"PRB.18.5",
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
                            Id = @"PRB.18.6",
                            Type = @"Component",
                            Position = @"PRB.18.6",
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
                            Id = @"PRB.18.7",
                            Type = @"Component",
                            Position = @"PRB.18.7",
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
                            Id = @"PRB.18.8",
                            Type = @"Component",
                            Position = @"PRB.18.8",
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
                            Id = @"PRB.18.9",
                            Type = @"Component",
                            Position = @"PRB.18.9",
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

        _problemRanking = new HL7V26Field
        {
            field = message[@"PRB"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemRanking.field.FieldRepetitions != null && _problemRanking.field.FieldRepetitions.Count > 0)
        {
            _problemRanking.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemRanking, fieldData);
        }

        return _problemRanking;
    } 
}

internal HL7V26Field _certaintyofProblem;

public HL7V26Field CertaintyofProblem
{
    get
    {
        if (_certaintyofProblem != null)
        {
            return _certaintyofProblem;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.19",
            Type = @"Field",
            Position = @"PRB.19",
            Name = @"Certainty of Problem",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains a qualitative representation of the certainty of a problem (e.g., HI - high, LO - low, ME - medium, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.19.1",
                            Type = @"Component",
                            Position = @"PRB.19.1",
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
                            Id = @"PRB.19.2",
                            Type = @"Component",
                            Position = @"PRB.19.2",
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
                            Id = @"PRB.19.3",
                            Type = @"Component",
                            Position = @"PRB.19.3",
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
                            Id = @"PRB.19.4",
                            Type = @"Component",
                            Position = @"PRB.19.4",
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
                            Id = @"PRB.19.5",
                            Type = @"Component",
                            Position = @"PRB.19.5",
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
                            Id = @"PRB.19.6",
                            Type = @"Component",
                            Position = @"PRB.19.6",
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
                            Id = @"PRB.19.7",
                            Type = @"Component",
                            Position = @"PRB.19.7",
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
                            Id = @"PRB.19.8",
                            Type = @"Component",
                            Position = @"PRB.19.8",
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
                            Id = @"PRB.19.9",
                            Type = @"Component",
                            Position = @"PRB.19.9",
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

        _certaintyofProblem = new HL7V26Field
        {
            field = message[@"PRB"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certaintyofProblem.field.FieldRepetitions != null && _certaintyofProblem.field.FieldRepetitions.Count > 0)
        {
            _certaintyofProblem.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_certaintyofProblem, fieldData);
        }

        return _certaintyofProblem;
    } 
}

internal HL7V26Field _probabilityofProblem;

public HL7V26Field ProbabilityofProblem
{
    get
    {
        if (_probabilityofProblem != null)
        {
            return _probabilityofProblem;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.20",
            Type = @"Field",
            Position = @"PRB.20",
            Name = @"Probability of Problem",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains a quantitative or numeric representation of the certainty that the problem exists for this patient. This field has a valid range of 0 to 1. For example, a healthcare provider may be 75% (.75) sure that the problem has been correctly identified.",
            Sample = @"",
            Fields = null
        }

        _probabilityofProblem = new HL7V26Field
        {
            field = message[@"PRB"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_probabilityofProblem.field.FieldRepetitions != null && _probabilityofProblem.field.FieldRepetitions.Count > 0)
        {
            _probabilityofProblem.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_probabilityofProblem, fieldData);
        }

        return _probabilityofProblem;
    } 
}

internal HL7V26Field _individualAwarenessofProblem;

public HL7V26Field IndividualAwarenessofProblem
{
    get
    {
        if (_individualAwarenessofProblem != null)
        {
            return _individualAwarenessofProblem;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.21",
            Type = @"Field",
            Position = @"PRB.21",
            Name = @"Individual Awareness of Problem",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the individual's comprehension of the problem (e.g., full, marginal, partial, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.21.1",
                            Type = @"Component",
                            Position = @"PRB.21.1",
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
                            Id = @"PRB.21.2",
                            Type = @"Component",
                            Position = @"PRB.21.2",
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
                            Id = @"PRB.21.3",
                            Type = @"Component",
                            Position = @"PRB.21.3",
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
                            Id = @"PRB.21.4",
                            Type = @"Component",
                            Position = @"PRB.21.4",
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
                            Id = @"PRB.21.5",
                            Type = @"Component",
                            Position = @"PRB.21.5",
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
                            Id = @"PRB.21.6",
                            Type = @"Component",
                            Position = @"PRB.21.6",
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
                            Id = @"PRB.21.7",
                            Type = @"Component",
                            Position = @"PRB.21.7",
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
                            Id = @"PRB.21.8",
                            Type = @"Component",
                            Position = @"PRB.21.8",
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
                            Id = @"PRB.21.9",
                            Type = @"Component",
                            Position = @"PRB.21.9",
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

        _individualAwarenessofProblem = new HL7V26Field
        {
            field = message[@"PRB"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_individualAwarenessofProblem.field.FieldRepetitions != null && _individualAwarenessofProblem.field.FieldRepetitions.Count > 0)
        {
            _individualAwarenessofProblem.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_individualAwarenessofProblem, fieldData);
        }

        return _individualAwarenessofProblem;
    } 
}

internal HL7V26Field _problemPrognosis;

public HL7V26Field ProblemPrognosis
{
    get
    {
        if (_problemPrognosis != null)
        {
            return _problemPrognosis;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.22",
            Type = @"Field",
            Position = @"PRB.22",
            Name = @"Problem Prognosis",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the prognosis for the individual's problem (e.g., good, poor, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.22.1",
                            Type = @"Component",
                            Position = @"PRB.22.1",
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
                            Id = @"PRB.22.2",
                            Type = @"Component",
                            Position = @"PRB.22.2",
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
                            Id = @"PRB.22.3",
                            Type = @"Component",
                            Position = @"PRB.22.3",
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
                            Id = @"PRB.22.4",
                            Type = @"Component",
                            Position = @"PRB.22.4",
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
                            Id = @"PRB.22.5",
                            Type = @"Component",
                            Position = @"PRB.22.5",
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
                            Id = @"PRB.22.6",
                            Type = @"Component",
                            Position = @"PRB.22.6",
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
                            Id = @"PRB.22.7",
                            Type = @"Component",
                            Position = @"PRB.22.7",
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
                            Id = @"PRB.22.8",
                            Type = @"Component",
                            Position = @"PRB.22.8",
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
                            Id = @"PRB.22.9",
                            Type = @"Component",
                            Position = @"PRB.22.9",
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

        _problemPrognosis = new HL7V26Field
        {
            field = message[@"PRB"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemPrognosis.field.FieldRepetitions != null && _problemPrognosis.field.FieldRepetitions.Count > 0)
        {
            _problemPrognosis.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemPrognosis, fieldData);
        }

        return _problemPrognosis;
    } 
}

internal HL7V26Field _individualAwarenessofPrognosis;

public HL7V26Field IndividualAwarenessofPrognosis
{
    get
    {
        if (_individualAwarenessofPrognosis != null)
        {
            return _individualAwarenessofPrognosis;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.23",
            Type = @"Field",
            Position = @"PRB.23",
            Name = @"Individual Awareness of Prognosis",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the individual's comprehension of the prognosis for the problem (e.g., full, marginal, partial, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.23.1",
                            Type = @"Component",
                            Position = @"PRB.23.1",
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
                            Id = @"PRB.23.2",
                            Type = @"Component",
                            Position = @"PRB.23.2",
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
                            Id = @"PRB.23.3",
                            Type = @"Component",
                            Position = @"PRB.23.3",
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
                            Id = @"PRB.23.4",
                            Type = @"Component",
                            Position = @"PRB.23.4",
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
                            Id = @"PRB.23.5",
                            Type = @"Component",
                            Position = @"PRB.23.5",
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
                            Id = @"PRB.23.6",
                            Type = @"Component",
                            Position = @"PRB.23.6",
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
                            Id = @"PRB.23.7",
                            Type = @"Component",
                            Position = @"PRB.23.7",
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
                            Id = @"PRB.23.8",
                            Type = @"Component",
                            Position = @"PRB.23.8",
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
                            Id = @"PRB.23.9",
                            Type = @"Component",
                            Position = @"PRB.23.9",
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

        _individualAwarenessofPrognosis = new HL7V26Field
        {
            field = message[@"PRB"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_individualAwarenessofPrognosis.field.FieldRepetitions != null && _individualAwarenessofPrognosis.field.FieldRepetitions.Count > 0)
        {
            _individualAwarenessofPrognosis.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_individualAwarenessofPrognosis, fieldData);
        }

        return _individualAwarenessofPrognosis;
    } 
}

internal HL7V26Field _familySignificantOtherAwarenessofProblemPrognosis;

public HL7V26Field FamilySignificantOtherAwarenessofProblemPrognosis
{
    get
    {
        if (_familySignificantOtherAwarenessofProblemPrognosis != null)
        {
            return _familySignificantOtherAwarenessofProblemPrognosis;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.24",
            Type = @"Field",
            Position = @"PRB.24",
            Name = @"Family/Significant Other Awareness of Problem/Prognosis",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the individual's family or significant other's comprehension of the actual problem/prognosis.",
            Sample = @"",
            Fields = null
        }

        _familySignificantOtherAwarenessofProblemPrognosis = new HL7V26Field
        {
            field = message[@"PRB"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_familySignificantOtherAwarenessofProblemPrognosis.field.FieldRepetitions != null && _familySignificantOtherAwarenessofProblemPrognosis.field.FieldRepetitions.Count > 0)
        {
            _familySignificantOtherAwarenessofProblemPrognosis.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_familySignificantOtherAwarenessofProblemPrognosis, fieldData);
        }

        return _familySignificantOtherAwarenessofProblemPrognosis;
    } 
}

internal HL7V26Field _securitySensitivity;

public HL7V26Field SecuritySensitivity
{
    get
    {
        if (_securitySensitivity != null)
        {
            return _securitySensitivity;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.25",
            Type = @"Field",
            Position = @"PRB.25",
            Name = @"Security/Sensitivity",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains information about the level of security and/or sensitivity surrounding the problem (e.g., highly sensitive, not sensitive, sensitive, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.25.1",
                            Type = @"Component",
                            Position = @"PRB.25.1",
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
                            Id = @"PRB.25.2",
                            Type = @"Component",
                            Position = @"PRB.25.2",
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
                            Id = @"PRB.25.3",
                            Type = @"Component",
                            Position = @"PRB.25.3",
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
                            Id = @"PRB.25.4",
                            Type = @"Component",
                            Position = @"PRB.25.4",
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
                            Id = @"PRB.25.5",
                            Type = @"Component",
                            Position = @"PRB.25.5",
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
                            Id = @"PRB.25.6",
                            Type = @"Component",
                            Position = @"PRB.25.6",
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
                            Id = @"PRB.25.7",
                            Type = @"Component",
                            Position = @"PRB.25.7",
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
                            Id = @"PRB.25.8",
                            Type = @"Component",
                            Position = @"PRB.25.8",
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
                            Id = @"PRB.25.9",
                            Type = @"Component",
                            Position = @"PRB.25.9",
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

        _securitySensitivity = new HL7V26Field
        {
            field = message[@"PRB"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_securitySensitivity.field.FieldRepetitions != null && _securitySensitivity.field.FieldRepetitions.Count > 0)
        {
            _securitySensitivity.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_securitySensitivity, fieldData);
        }

        return _securitySensitivity;
    } 
}

internal HL7V26Field _problemSeverity;

public HL7V26Field ProblemSeverity
{
    get
    {
        if (_problemSeverity != null)
        {
            return _problemSeverity;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.26",
            Type = @"Field",
            Position = @"PRB.26",
            Name = @"Problem Severity",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0836",
            TableName = @"Problem Severity",
            Description = @"This field indicates the severity of the Problem. Refer to User-defined Table 0836- Problem Severity for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.26.1",
                            Type = @"Component",
                            Position = @"PRB.26.1",
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
                            Id = @"PRB.26.2",
                            Type = @"Component",
                            Position = @"PRB.26.2",
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
                            Id = @"PRB.26.3",
                            Type = @"Component",
                            Position = @"PRB.26.3",
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
                            Id = @"PRB.26.4",
                            Type = @"Component",
                            Position = @"PRB.26.4",
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
                            Id = @"PRB.26.5",
                            Type = @"Component",
                            Position = @"PRB.26.5",
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
                            Id = @"PRB.26.6",
                            Type = @"Component",
                            Position = @"PRB.26.6",
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
                            Id = @"PRB.26.7",
                            Type = @"Component",
                            Position = @"PRB.26.7",
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
                            Id = @"PRB.26.8",
                            Type = @"Component",
                            Position = @"PRB.26.8",
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
                            Id = @"PRB.26.9",
                            Type = @"Component",
                            Position = @"PRB.26.9",
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

        _problemSeverity = new HL7V26Field
        {
            field = message[@"PRB"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemSeverity.field.FieldRepetitions != null && _problemSeverity.field.FieldRepetitions.Count > 0)
        {
            _problemSeverity.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemSeverity, fieldData);
        }

        return _problemSeverity;
    } 
}

internal HL7V26Field _problemPerspective;

public HL7V26Field ProblemPerspective
{
    get
    {
        if (_problemPerspective != null)
        {
            return _problemPerspective;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PRB.27",
            Type = @"Field",
            Position = @"PRB.27",
            Name = @"Problem Perspective",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0838",
            TableName = @"Problem Perspective",
            Description = @"This field indicates from whose perspective this problem was identified. Refer to User-defined Table 0838 - Problem Perspective for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.27.1",
                            Type = @"Component",
                            Position = @"PRB.27.1",
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
                            Id = @"PRB.27.2",
                            Type = @"Component",
                            Position = @"PRB.27.2",
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
                            Id = @"PRB.27.3",
                            Type = @"Component",
                            Position = @"PRB.27.3",
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
                            Id = @"PRB.27.4",
                            Type = @"Component",
                            Position = @"PRB.27.4",
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
                            Id = @"PRB.27.5",
                            Type = @"Component",
                            Position = @"PRB.27.5",
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
                            Id = @"PRB.27.6",
                            Type = @"Component",
                            Position = @"PRB.27.6",
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
                            Id = @"PRB.27.7",
                            Type = @"Component",
                            Position = @"PRB.27.7",
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
                            Id = @"PRB.27.8",
                            Type = @"Component",
                            Position = @"PRB.27.8",
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
                            Id = @"PRB.27.9",
                            Type = @"Component",
                            Position = @"PRB.27.9",
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

        _problemPerspective = new HL7V26Field
        {
            field = message[@"PRB"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemPerspective.field.FieldRepetitions != null && _problemPerspective.field.FieldRepetitions.Count > 0)
        {
            _problemPerspective.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_problemPerspective, fieldData);
        }

        return _problemPerspective;
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
            Id = @"PRB.28",
            Type = @"Field",
            Position = @"PRB.28",
            Name = @"Mood Code",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0725",
            TableName = @"Mood Codes",
            Description = @"This field indicates the Mood of the Problem. It allows expression of the context of the problem.

Note:  As Mood Code changes the meaning of the segment it must only be used in new messages as of v2.6.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.28.1",
                            Type = @"Component",
                            Position = @"PRB.28.1",
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
                            Id = @"PRB.28.2",
                            Type = @"Component",
                            Position = @"PRB.28.2",
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
                            Id = @"PRB.28.3",
                            Type = @"Component",
                            Position = @"PRB.28.3",
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
                            Id = @"PRB.28.4",
                            Type = @"Component",
                            Position = @"PRB.28.4",
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
                            Id = @"PRB.28.5",
                            Type = @"Component",
                            Position = @"PRB.28.5",
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
                            Id = @"PRB.28.6",
                            Type = @"Component",
                            Position = @"PRB.28.6",
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
                            Id = @"PRB.28.7",
                            Type = @"Component",
                            Position = @"PRB.28.7",
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
                            Id = @"PRB.28.8",
                            Type = @"Component",
                            Position = @"PRB.28.8",
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
                            Id = @"PRB.28.9",
                            Type = @"Component",
                            Position = @"PRB.28.9",
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
            field = message[@"PRB"][28],
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
