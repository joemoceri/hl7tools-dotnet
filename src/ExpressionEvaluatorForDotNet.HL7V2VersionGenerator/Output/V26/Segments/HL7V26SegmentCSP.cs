using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentCSP
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CSP"; } }

        public string SegmentId { get { return @"CSP"; } }
        
        public string LongName { get { return @"Clinical Study Phase"; } }
        
        public string Description { get { return @"The CSP segment contains information on a patients status for a particular phase of the study. This segment is optional and is useful when a study has different evaluation intervals within it. (See section 7.8.1, ""HL7 Attribute Table - CSR - Clinical Study Registration,"" and section 7.6.1.2, ""Phase of a clinical trial:."") The CSP segment is implemented on a study-specific basis for messaging purposes. The fact that the patient has entered a phase of the study that represents a certain treatment approach may need to be messaged to other systems, like pharmacy, nursing, or order entry. It is also important to sponsors and data management centers for tracking patient progress through the study and monitoring the data schedule defined for each phase. It may subsume OBR and OBX segments that follow it to indicate that these data describe the phase."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V26SegmentCSP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _studyPhaseIdentifier;

public HL7V26Field StudyPhaseIdentifier
{
    get
    {
        if (_studyPhaseIdentifier != null)
        {
            return _studyPhaseIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CSP.1",
            Type = @"Field",
            Position = @"CSP.1",
            Name = @"Study Phase Identifier",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the phase of the study that a patient has entered. The set of codes will generally be developed for each clinical trial, although there are patterns that trials in particular disease or prevention categories may follow. The phase structure will be based on data collation and reporting needs for the study. It is an operational structure and need not be discussed in the clinical trial protocol documentation or even made known to patient care or data collection personnel. The coding system will usually be developed by the sponsor for multicentered clinical trials to standardize the receipt of automated data. Local codes could be added if an additional local message is desired. Otherwise, local coding conventions will be used. Example: 2^Init Rx, Crs 1^NCI T93-0807 Phases",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CSP.1.1",
                            Type = @"Component",
                            Position = @"CSP.1.1",
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
                            Id = @"CSP.1.2",
                            Type = @"Component",
                            Position = @"CSP.1.2",
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
                            Id = @"CSP.1.3",
                            Type = @"Component",
                            Position = @"CSP.1.3",
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
                            Id = @"CSP.1.4",
                            Type = @"Component",
                            Position = @"CSP.1.4",
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
                            Id = @"CSP.1.5",
                            Type = @"Component",
                            Position = @"CSP.1.5",
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
                            Id = @"CSP.1.6",
                            Type = @"Component",
                            Position = @"CSP.1.6",
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
                            Id = @"CSP.1.7",
                            Type = @"Component",
                            Position = @"CSP.1.7",
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
                            Id = @"CSP.1.8",
                            Type = @"Component",
                            Position = @"CSP.1.8",
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
                            Id = @"CSP.1.9",
                            Type = @"Component",
                            Position = @"CSP.1.9",
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

        _studyPhaseIdentifier = new HL7V26Field
        {
            field = message[@"CSP"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyPhaseIdentifier.field.FieldRepetitions != null && _studyPhaseIdentifier.field.FieldRepetitions.Count > 0)
        {
            _studyPhaseIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_studyPhaseIdentifier, fieldData);
        }

        return _studyPhaseIdentifier;
    } 
}

internal HL7V26Field _datetimeStudyPhaseBegan;

public HL7V26Field DatetimeStudyPhaseBegan
{
    get
    {
        if (_datetimeStudyPhaseBegan != null)
        {
            return _datetimeStudyPhaseBegan;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CSP.2",
            Type = @"Field",
            Position = @"CSP.2",
            Name = @"Date/time Study Phase Began",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the patient began this phase interval. The time is optional.",
            Sample = @"",
            Fields = null
        }

        _datetimeStudyPhaseBegan = new HL7V26Field
        {
            field = message[@"CSP"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_datetimeStudyPhaseBegan.field.FieldRepetitions != null && _datetimeStudyPhaseBegan.field.FieldRepetitions.Count > 0)
        {
            _datetimeStudyPhaseBegan.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_datetimeStudyPhaseBegan, fieldData);
        }

        return _datetimeStudyPhaseBegan;
    } 
}

internal HL7V26Field _datetimeStudyPhaseEnded;

public HL7V26Field DatetimeStudyPhaseEnded
{
    get
    {
        if (_datetimeStudyPhaseEnded != null)
        {
            return _datetimeStudyPhaseEnded;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CSP.3",
            Type = @"Field",
            Position = @"CSP.3",
            Name = @"Date/time Study Phase Ended",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the patient ended this phase interval.",
            Sample = @"",
            Fields = null
        }

        _datetimeStudyPhaseEnded = new HL7V26Field
        {
            field = message[@"CSP"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_datetimeStudyPhaseEnded.field.FieldRepetitions != null && _datetimeStudyPhaseEnded.field.FieldRepetitions.Count > 0)
        {
            _datetimeStudyPhaseEnded.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_datetimeStudyPhaseEnded, fieldData);
        }

        return _datetimeStudyPhaseEnded;
    } 
}

internal HL7V26Field _studyPhaseEvaluability;

public HL7V26Field StudyPhaseEvaluability
{
    get
    {
        if (_studyPhaseEvaluability != null)
        {
            return _studyPhaseEvaluability;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CSP.4",
            Type = @"Field",
            Position = @"CSP.4",
            Name = @"Study Phase Evaluability",
            Length = 705,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the disposition of the patients data for this phase interval for quality control and data analysis purposes. The set of codes will vary across clinical trials. An example answer set: Complete, Adverse Events Only, Outcome Only, None, Unknown.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CSP.4.1",
                            Type = @"Component",
                            Position = @"CSP.4.1",
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
                            Id = @"CSP.4.2",
                            Type = @"Component",
                            Position = @"CSP.4.2",
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
                            Id = @"CSP.4.3",
                            Type = @"Component",
                            Position = @"CSP.4.3",
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
                            Id = @"CSP.4.4",
                            Type = @"Component",
                            Position = @"CSP.4.4",
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
                            Id = @"CSP.4.5",
                            Type = @"Component",
                            Position = @"CSP.4.5",
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
                            Id = @"CSP.4.6",
                            Type = @"Component",
                            Position = @"CSP.4.6",
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
                            Id = @"CSP.4.7",
                            Type = @"Component",
                            Position = @"CSP.4.7",
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
                            Id = @"CSP.4.8",
                            Type = @"Component",
                            Position = @"CSP.4.8",
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
                            Id = @"CSP.4.9",
                            Type = @"Component",
                            Position = @"CSP.4.9",
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

        _studyPhaseEvaluability = new HL7V26Field
        {
            field = message[@"CSP"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyPhaseEvaluability.field.FieldRepetitions != null && _studyPhaseEvaluability.field.FieldRepetitions.Count > 0)
        {
            _studyPhaseEvaluability.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_studyPhaseEvaluability, fieldData);
        }

        return _studyPhaseEvaluability;
    } 
}
    }
}
