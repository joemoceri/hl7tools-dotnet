using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentCSP
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CSP"; } }

        public string SegmentId { get { return @"CSP"; } }
        
        public string LongName { get { return @"Clinical study phase segment"; } }
        
        public string Description { get { return @"The CSP segment contains information on a patient's status for a particular phase of the study. This segment is optional and is useful when a study has different evaluation intervals within it. (See Section 7.5.1.2, 'Phase of a clinical trial.' The CSP segment is implemented on a study-specific basis for messaging purposes. The fact that the patient has entered a phase of the study that represents a certain treatment approach may need to be messaged to other systems, like pharmacy, nursing, or order entry. It is also important to sponsors and data management centers for tracking patient progress through the study and monitoring the data schedule defined for each phase. It may subsume OBR and OBX segments that follow it to indicate that these data describe the phase."; } }
        
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

        public HL7V231SegmentCSP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _studyPhaseIdentifier;

public HL7V231Field StudyPhaseIdentifier
{
    get
    {
        if (_studyPhaseIdentifier != null)
        {
            return _studyPhaseIdentifier;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"CSP.1",
            Type = @"Field",
            Position = @"CSP.1",
            Name = @"Study Phase Identifier",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
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
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSP.1.2",
                            Type = @"Component",
                            Position = @"CSP.1.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSP.1.3",
                            Type = @"Component",
                            Position = @"CSP.1.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSP.1.4",
                            Type = @"Component",
                            Position = @"CSP.1.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSP.1.5",
                            Type = @"Component",
                            Position = @"CSP.1.5",
                            Name = @"Alternate Text",
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
                            Id = @"CSP.1.6",
                            Type = @"Component",
                            Position = @"CSP.1.6",
                            Name = @"Name Of Alternate Coding System",
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

        _studyPhaseIdentifier = new HL7V231Field
        {
            field = message[@"CSP"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyPhaseIdentifier.field.FieldRepetitions != null && _studyPhaseIdentifier.field.FieldRepetitions.Count > 0)
        {
            _studyPhaseIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_studyPhaseIdentifier, fieldData);
        }

        return _studyPhaseIdentifier;
    } 
}

internal HL7V231Field _datetimeStudyPhaseBegan;

public HL7V231Field DatetimeStudyPhaseBegan
{
    get
    {
        if (_datetimeStudyPhaseBegan != null)
        {
            return _datetimeStudyPhaseBegan;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"CSP.2",
            Type = @"Field",
            Position = @"CSP.2",
            Name = @"Date/time Study Phase Began",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the patient began this phase interval. The time is optional.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CSP.2.1",
                            Type = @"Component",
                            Position = @"CSP.2.1",
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

        _datetimeStudyPhaseBegan = new HL7V231Field
        {
            field = message[@"CSP"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_datetimeStudyPhaseBegan.field.FieldRepetitions != null && _datetimeStudyPhaseBegan.field.FieldRepetitions.Count > 0)
        {
            _datetimeStudyPhaseBegan.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_datetimeStudyPhaseBegan, fieldData);
        }

        return _datetimeStudyPhaseBegan;
    } 
}

internal HL7V231Field _datetimeStudyPhaseEnded;

public HL7V231Field DatetimeStudyPhaseEnded
{
    get
    {
        if (_datetimeStudyPhaseEnded != null)
        {
            return _datetimeStudyPhaseEnded;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"CSP.3",
            Type = @"Field",
            Position = @"CSP.3",
            Name = @"Date/time Study Phase Ended",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the patient ended this phase interval.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CSP.3.1",
                            Type = @"Component",
                            Position = @"CSP.3.1",
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

        _datetimeStudyPhaseEnded = new HL7V231Field
        {
            field = message[@"CSP"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_datetimeStudyPhaseEnded.field.FieldRepetitions != null && _datetimeStudyPhaseEnded.field.FieldRepetitions.Count > 0)
        {
            _datetimeStudyPhaseEnded.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_datetimeStudyPhaseEnded, fieldData);
        }

        return _datetimeStudyPhaseEnded;
    } 
}

internal HL7V231Field _studyPhaseEvaluability;

public HL7V231Field StudyPhaseEvaluability
{
    get
    {
        if (_studyPhaseEvaluability != null)
        {
            return _studyPhaseEvaluability;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"CSP.4",
            Type = @"Field",
            Position = @"CSP.4",
            Name = @"Study Phase Evaluability",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the disposition of the patient's data for this phase interval for quality control and data analysis purposes. The set of codes will vary across clinical trials. An example answer set: Complete, Adverse Events Only, Outcome Only, None, Unknown.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CSP.4.1",
                            Type = @"Component",
                            Position = @"CSP.4.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSP.4.2",
                            Type = @"Component",
                            Position = @"CSP.4.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSP.4.3",
                            Type = @"Component",
                            Position = @"CSP.4.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSP.4.4",
                            Type = @"Component",
                            Position = @"CSP.4.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSP.4.5",
                            Type = @"Component",
                            Position = @"CSP.4.5",
                            Name = @"Alternate Text",
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
                            Id = @"CSP.4.6",
                            Type = @"Component",
                            Position = @"CSP.4.6",
                            Name = @"Name Of Alternate Coding System",
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

        _studyPhaseEvaluability = new HL7V231Field
        {
            field = message[@"CSP"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyPhaseEvaluability.field.FieldRepetitions != null && _studyPhaseEvaluability.field.FieldRepetitions.Count > 0)
        {
            _studyPhaseEvaluability.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_studyPhaseEvaluability, fieldData);
        }

        return _studyPhaseEvaluability;
    } 
}
    }
}
