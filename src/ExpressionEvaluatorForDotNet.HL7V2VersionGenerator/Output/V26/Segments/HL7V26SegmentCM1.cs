using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentCM1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CM1"; } }

        public string SegmentId { get { return @"CM1"; } }
        
        public string LongName { get { return @"Clinical Study Phase Master"; } }
        
        public string Description { get { return @"The Technical Steward for the CM1 segment is Orders and Observations.

Each Clinical Study Phase Master (CM1) segment contains the information about one phase of a study identified in the preceding CM0.  This is an optional structure to be used if the study has more than one treatment or evaluation phase within it.  The identification of study phases that the patient enters are sent in the CSP segment: sequence 2.  The CM1 segment describes the phase in general for the receiving system."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V26SegmentCM1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _setIDCM1;

public HL7V26Field SetIDCM1
{
    get
    {
        if (_setIDCM1 != null)
        {
            return _setIDCM1;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CM1.1",
            Type = @"Field",
            Position = @"CM1.1",
            Name = @"Set ID - CM1",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction. For those messages that permit segments to repeat, the Set IF field is used to identify the repetitions.",
            Sample = @"",
            Fields = null
        }

        _setIDCM1 = new HL7V26Field
        {
            field = message[@"CM1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDCM1.field.FieldRepetitions != null && _setIDCM1.field.FieldRepetitions.Count > 0)
        {
            _setIDCM1.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_setIDCM1, fieldData);
        }

        return _setIDCM1;
    } 
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
            Id = @"CM1.2",
            Type = @"Field",
            Position = @"CM1.2",
            Name = @"Study Phase Identifier",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field should correspond to the study phase ID coding system in Chapter 7, section 7.7.2.1, ""Study phase ID.""",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CM1.2.1",
                            Type = @"Component",
                            Position = @"CM1.2.1",
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
                            Id = @"CM1.2.2",
                            Type = @"Component",
                            Position = @"CM1.2.2",
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
                            Id = @"CM1.2.3",
                            Type = @"Component",
                            Position = @"CM1.2.3",
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
                            Id = @"CM1.2.4",
                            Type = @"Component",
                            Position = @"CM1.2.4",
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
                            Id = @"CM1.2.5",
                            Type = @"Component",
                            Position = @"CM1.2.5",
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
                            Id = @"CM1.2.6",
                            Type = @"Component",
                            Position = @"CM1.2.6",
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
                            Id = @"CM1.2.7",
                            Type = @"Component",
                            Position = @"CM1.2.7",
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
                            Id = @"CM1.2.8",
                            Type = @"Component",
                            Position = @"CM1.2.8",
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
                            Id = @"CM1.2.9",
                            Type = @"Component",
                            Position = @"CM1.2.9",
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
            field = message[@"CM1"][2],
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

internal HL7V26Field _descriptionofStudyPhase;

public HL7V26Field DescriptionofStudyPhase
{
    get
    {
        if (_descriptionofStudyPhase != null)
        {
            return _descriptionofStudyPhase;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CM1.3",
            Type = @"Field",
            Position = @"CM1.3",
            Name = @"Description of Study Phase",
            Length = 300,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a brief explanation for recipients to understand what the phase represents.",
            Sample = @"",
            Fields = null
        }

        _descriptionofStudyPhase = new HL7V26Field
        {
            field = message[@"CM1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_descriptionofStudyPhase.field.FieldRepetitions != null && _descriptionofStudyPhase.field.FieldRepetitions.Count > 0)
        {
            _descriptionofStudyPhase.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_descriptionofStudyPhase, fieldData);
        }

        return _descriptionofStudyPhase;
    } 
}
    }
}
