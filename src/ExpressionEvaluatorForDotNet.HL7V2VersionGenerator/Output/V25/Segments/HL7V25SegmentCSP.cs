using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentCSP
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CSP"; } }

        public string SegmentId { get { return @"CSP"; } }
        
        public string LongName { get { return @"Clinical Study Phase"; } }
        
        public string Description { get { return @"The CSP segment contains information on a patients status for a particular phase of the study. This segment is optional and is useful when a study has different evaluation intervals within it. (See Section 0, HL7 Attribute Table - CSR - Clinical Study RegistrationPhase of a Clinical Trial. The CSP segment is implemented on a study-specific basis for messaging purposes. The fact that the patient has entered a phase of the study that represents a certain treatment approach may need to be messaged to other systems, like pharmacy, nursing, or order entry. It is also important to sponsors and data management centers for tracking patient progress through the study and monitoring the data schedule defined for each phase. It may subsume OBR and OBX segments that follow it to indicate that these data describe the phase."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CSP.1",
                            Type = @"Field",
                            Position = @"CSP.1",
                            Name = @"Study Phase Identifier",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the phase of the study that a patient has entered. The set of codes will generally be developed for each clinical trial, although there are patterns that trials in particular disease or prevention categories may follow. The phase structure will be based on data collation and reporting needs for the study. It is an operational structure and need not be discussed in the clinical trial protocol documentation or even made known to patient care or data collection personnel. The coding system will usually be developed by the sponsor for multicentered clinical trials to standardize the receipt of automated data. Local codes could be added if an additional local message is desired. Otherwise, local coding conventions will be used. Example: 2^Init Rx, Crs 1^NCI T93-0807 Phases",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CSP.2.1",
                            Type = @"Component",
                            Position = @"CSP.2.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSP.2.2",
                            Type = @"Component",
                            Position = @"CSP.2.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision.

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CSP.3.1",
                            Type = @"Component",
                            Position = @"CSP.3.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSP.3.2",
                            Type = @"Component",
                            Position = @"CSP.3.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision.

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSP.4",
                            Type = @"Field",
                            Position = @"CSP.4",
                            Name = @"Study Phase Evaluability",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the disposition of the patients data for this phase interval for quality control and data analysis purposes. The set of codes will vary across clinical trials. An example answer set: Complete, Adverse Events Only, Outcome Only, None, Unknown.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V25SegmentCSP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field studyPhaseIdentifier;

public HL7V25Field StudyPhaseIdentifier
{
    get
    {
        if (studyPhaseIdentifier != null)
        {
            return studyPhaseIdentifier;
        }

        studyPhaseIdentifier = new HL7V25Field
        {
            field = message[@"CSP"][1],
            Id = @"CSP.1",
            Type = @"Field",
            Position = @"CSP.1",
            Name = @"Study Phase Identifier",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the phase of the study that a patient has entered. The set of codes will generally be developed for each clinical trial, although there are patterns that trials in particular disease or prevention categories may follow. The phase structure will be based on data collation and reporting needs for the study. It is an operational structure and need not be discussed in the clinical trial protocol documentation or even made known to patient care or data collection personnel. The coding system will usually be developed by the sponsor for multicentered clinical trials to standardize the receipt of automated data. Local codes could be added if an additional local message is desired. Otherwise, local coding conventions will be used. Example: 2^Init Rx, Crs 1^NCI T93-0807 Phases",
            Sample = @"",
        };

        // check for repetitions
        if (studyPhaseIdentifier.field.FieldRepetitions != null && studyPhaseIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(studyPhaseIdentifier.Id));
            studyPhaseIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(studyPhaseIdentifier, fieldData);
        }

        return studyPhaseIdentifier;
    } 
}

internal HL7V25Field datetimeStudyPhaseBegan;

public HL7V25Field DatetimeStudyPhaseBegan
{
    get
    {
        if (datetimeStudyPhaseBegan != null)
        {
            return datetimeStudyPhaseBegan;
        }

        datetimeStudyPhaseBegan = new HL7V25Field
        {
            field = message[@"CSP"][2],
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
        };

        // check for repetitions
        if (datetimeStudyPhaseBegan.field.FieldRepetitions != null && datetimeStudyPhaseBegan.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(datetimeStudyPhaseBegan.Id));
            datetimeStudyPhaseBegan.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(datetimeStudyPhaseBegan, fieldData);
        }

        return datetimeStudyPhaseBegan;
    } 
}

internal HL7V25Field datetimeStudyPhaseEnded;

public HL7V25Field DatetimeStudyPhaseEnded
{
    get
    {
        if (datetimeStudyPhaseEnded != null)
        {
            return datetimeStudyPhaseEnded;
        }

        datetimeStudyPhaseEnded = new HL7V25Field
        {
            field = message[@"CSP"][3],
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
        };

        // check for repetitions
        if (datetimeStudyPhaseEnded.field.FieldRepetitions != null && datetimeStudyPhaseEnded.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(datetimeStudyPhaseEnded.Id));
            datetimeStudyPhaseEnded.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(datetimeStudyPhaseEnded, fieldData);
        }

        return datetimeStudyPhaseEnded;
    } 
}

internal HL7V25Field studyPhaseEvaluability;

public HL7V25Field StudyPhaseEvaluability
{
    get
    {
        if (studyPhaseEvaluability != null)
        {
            return studyPhaseEvaluability;
        }

        studyPhaseEvaluability = new HL7V25Field
        {
            field = message[@"CSP"][4],
            Id = @"CSP.4",
            Type = @"Field",
            Position = @"CSP.4",
            Name = @"Study Phase Evaluability",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the disposition of the patients data for this phase interval for quality control and data analysis purposes. The set of codes will vary across clinical trials. An example answer set: Complete, Adverse Events Only, Outcome Only, None, Unknown.",
            Sample = @"",
        };

        // check for repetitions
        if (studyPhaseEvaluability.field.FieldRepetitions != null && studyPhaseEvaluability.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(studyPhaseEvaluability.Id));
            studyPhaseEvaluability.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(studyPhaseEvaluability, fieldData);
        }

        return studyPhaseEvaluability;
    } 
}
    }
}
