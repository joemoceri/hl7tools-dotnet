using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentCSS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CSS"; } }

        public string SegmentId { get { return @"CSS"; } }
        
        public string LongName { get { return @"Clinical Study Data Schedule Segment"; } }
        
        public string Description { get { return @"The Clinical Study Data Schedule (CSS) segment is optional depending on whether messaging of study data needs to be linked to the scheduled data time points for the study. (See Section 7.6.1.3, "" Data schedule: ."") The CSS segment enables communication of data schedules and adherence that ranges from the basic to the elaborate. Use of the segment must be planned for each implementation. Each CSS segment will subsume observation and drug administration segments that follow, indicating that they satisfy this scheduled time point."; } }
        
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

        public HL7V26SegmentCSS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _studyScheduledTimePoint;

public HL7V26Field StudyScheduledTimePoint
{
    get
    {
        if (_studyScheduledTimePoint != null)
        {
            return _studyScheduledTimePoint;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CSS.1",
            Type = @"Field",
            Position = @"CSS.1",
            Name = @"Study Scheduled Time Point",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time point for which some instance of data for the clinical trial was scheduled. The time point may be expressed in any coded format. Some examples of time point values are: Prestudy, Pretreatment, 4 times/day, Weekly, Every 3 days, Every course, At Relapse, At Off Study.  Alternatively, frequency values from Section 2.A.81.2, ""Interval component (RI),"" (the Interval component of the TQ Timing/Quantity data type could be used; however, note that as of version 2.5, the TQ data type is retained only for backward compatibility). Time point naming conventions and usage must be specified by implementers.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CSS.1.1",
                            Type = @"Component",
                            Position = @"CSS.1.1",
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
                            Id = @"CSS.1.2",
                            Type = @"Component",
                            Position = @"CSS.1.2",
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
                            Id = @"CSS.1.3",
                            Type = @"Component",
                            Position = @"CSS.1.3",
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
                            Id = @"CSS.1.4",
                            Type = @"Component",
                            Position = @"CSS.1.4",
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
                            Id = @"CSS.1.5",
                            Type = @"Component",
                            Position = @"CSS.1.5",
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
                            Id = @"CSS.1.6",
                            Type = @"Component",
                            Position = @"CSS.1.6",
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
                            Id = @"CSS.1.7",
                            Type = @"Component",
                            Position = @"CSS.1.7",
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
                            Id = @"CSS.1.8",
                            Type = @"Component",
                            Position = @"CSS.1.8",
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
                            Id = @"CSS.1.9",
                            Type = @"Component",
                            Position = @"CSS.1.9",
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

        _studyScheduledTimePoint = new HL7V26Field
        {
            field = message[@"CSS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyScheduledTimePoint.field.FieldRepetitions != null && _studyScheduledTimePoint.field.FieldRepetitions.Count > 0)
        {
            _studyScheduledTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_studyScheduledTimePoint, fieldData);
        }

        return _studyScheduledTimePoint;
    } 
}

internal HL7V26Field _studyScheduledPatientTimePoint;

public HL7V26Field StudyScheduledPatientTimePoint
{
    get
    {
        if (_studyScheduledPatientTimePoint != null)
        {
            return _studyScheduledPatientTimePoint;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CSS.2",
            Type = @"Field",
            Position = @"CSS.2",
            Name = @"Study Scheduled Patient Time Point",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the scheduled time point should occur for this patient. The date/time may be used for a reference in reviewing the actual dates on which scheduled items that follow in OBR segments occur for the patient. The time component is optional.",
            Sample = @"",
            Fields = null
        }

        _studyScheduledPatientTimePoint = new HL7V26Field
        {
            field = message[@"CSS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyScheduledPatientTimePoint.field.FieldRepetitions != null && _studyScheduledPatientTimePoint.field.FieldRepetitions.Count > 0)
        {
            _studyScheduledPatientTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_studyScheduledPatientTimePoint, fieldData);
        }

        return _studyScheduledPatientTimePoint;
    } 
}

internal HL7V26Field _studyQualityControlCodes;

public HL7V26Field StudyQualityControlCodes
{
    get
    {
        if (_studyQualityControlCodes != null)
        {
            return _studyQualityControlCodes;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CSS.3",
            Type = @"Field",
            Position = @"CSS.3",
            Name = @"Study Quality Control Codes",
            Length = 705,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"In clinical settings, the actual date of a treatment or procedure may vary considerably from the due date. Various coding systems may be used to evaluate the adherence to the schedule or acceptability of the data. Coding systems will vary among trials.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CSS.3.1",
                            Type = @"Component",
                            Position = @"CSS.3.1",
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
                            Id = @"CSS.3.2",
                            Type = @"Component",
                            Position = @"CSS.3.2",
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
                            Id = @"CSS.3.3",
                            Type = @"Component",
                            Position = @"CSS.3.3",
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
                            Id = @"CSS.3.4",
                            Type = @"Component",
                            Position = @"CSS.3.4",
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
                            Id = @"CSS.3.5",
                            Type = @"Component",
                            Position = @"CSS.3.5",
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
                            Id = @"CSS.3.6",
                            Type = @"Component",
                            Position = @"CSS.3.6",
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
                            Id = @"CSS.3.7",
                            Type = @"Component",
                            Position = @"CSS.3.7",
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
                            Id = @"CSS.3.8",
                            Type = @"Component",
                            Position = @"CSS.3.8",
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
                            Id = @"CSS.3.9",
                            Type = @"Component",
                            Position = @"CSS.3.9",
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

        _studyQualityControlCodes = new HL7V26Field
        {
            field = message[@"CSS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyQualityControlCodes.field.FieldRepetitions != null && _studyQualityControlCodes.field.FieldRepetitions.Count > 0)
        {
            _studyQualityControlCodes.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_studyQualityControlCodes, fieldData);
        }

        return _studyQualityControlCodes;
    } 
}
    }
}
