using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentCSS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CSS"; } }

        public string SegmentId { get { return @"CSS"; } }
        
        public string LongName { get { return @"Clinical Study Data Schedule Segment"; } }
        
        public string Description { get { return @"The Clinical Study Data Schedule (CSS) segment is optional depending on whether messaging of study data needs to be linked to the scheduled data time points for the study. (See Section 7.6.1.3, data schedule.) The CSS segment enables communication of data schedules and adherence that ranges from the basic to the elaborate. Use of the segment must be planned for each implementation. Each CSS segment will subsume observation and drug administration segments that follow, indicating that they satisfy this scheduled time point."; } }
        
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
                            Id = @"CSS.1",
                            Type = @"Field",
                            Position = @"CSS.1",
                            Name = @"Study Scheduled Time Point",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the time point for which some instance of data for the clinical trial was scheduled. The time point may be expressed in any coded format. Some examples of time point values are: Prestudy, Pretreatment, 4 times/day, Weekly, Every 3 days, Every course, At Relapse, At Off Study.  Alternatively, frequency values from Section 2.A.81.2, Interval component (RI), (the Interval component of the TQ Timing/Quantity data type could be used; however, note that as of version 2.5, the TQ data type is retained only for backward compatibility). Time point naming conventions and usage must be specified by implementers.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSS.2",
                            Type = @"Field",
                            Position = @"CSS.2",
                            Name = @"Study Scheduled Patient Time Point",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the scheduled time point should occur for this patient. The date/time may be used for a reference in reviewing the actual dates on which scheduled items that follow in OBR segments occur for the patient. The time component is optional.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CSS.2.1",
                            Type = @"Component",
                            Position = @"CSS.2.1",
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
                            Id = @"CSS.2.2",
                            Type = @"Component",
                            Position = @"CSS.2.2",
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
                            Id = @"CSS.3",
                            Type = @"Field",
                            Position = @"CSS.3",
                            Name = @"Study Quality Control Codes",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"In clinical settings, the actual date of a treatment or procedure may vary considerably from the due date. Various coding systems may be used to evaluate the adherence to the schedule or acceptability of the data. Coding systems will vary among trials.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V251SegmentCSS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field studyScheduledTimePoint;

public HL7V251Field StudyScheduledTimePoint
{
    get
    {
        if (studyScheduledTimePoint != null)
        {
            return studyScheduledTimePoint;
        }

        studyScheduledTimePoint = new HL7V251Field
        {
            field = message[@"CSS"][1],
            Id = @"CSS.1",
            Type = @"Field",
            Position = @"CSS.1",
            Name = @"Study Scheduled Time Point",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time point for which some instance of data for the clinical trial was scheduled. The time point may be expressed in any coded format. Some examples of time point values are: Prestudy, Pretreatment, 4 times/day, Weekly, Every 3 days, Every course, At Relapse, At Off Study.  Alternatively, frequency values from Section 2.A.81.2, Interval component (RI), (the Interval component of the TQ Timing/Quantity data type could be used; however, note that as of version 2.5, the TQ data type is retained only for backward compatibility). Time point naming conventions and usage must be specified by implementers.",
            Sample = @"",
        };

        // check for repetitions
        if (studyScheduledTimePoint.field.FieldRepetitions != null && studyScheduledTimePoint.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(studyScheduledTimePoint.Id));
            studyScheduledTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(studyScheduledTimePoint, fieldData);
        }

        return studyScheduledTimePoint;
    } 
}

internal HL7V251Field studyScheduledPatientTimePoint;

public HL7V251Field StudyScheduledPatientTimePoint
{
    get
    {
        if (studyScheduledPatientTimePoint != null)
        {
            return studyScheduledPatientTimePoint;
        }

        studyScheduledPatientTimePoint = new HL7V251Field
        {
            field = message[@"CSS"][2],
            Id = @"CSS.2",
            Type = @"Field",
            Position = @"CSS.2",
            Name = @"Study Scheduled Patient Time Point",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the scheduled time point should occur for this patient. The date/time may be used for a reference in reviewing the actual dates on which scheduled items that follow in OBR segments occur for the patient. The time component is optional.",
            Sample = @"",
        };

        // check for repetitions
        if (studyScheduledPatientTimePoint.field.FieldRepetitions != null && studyScheduledPatientTimePoint.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(studyScheduledPatientTimePoint.Id));
            studyScheduledPatientTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(studyScheduledPatientTimePoint, fieldData);
        }

        return studyScheduledPatientTimePoint;
    } 
}

internal HL7V251Field studyQualityControlCodes;

public HL7V251Field StudyQualityControlCodes
{
    get
    {
        if (studyQualityControlCodes != null)
        {
            return studyQualityControlCodes;
        }

        studyQualityControlCodes = new HL7V251Field
        {
            field = message[@"CSS"][3],
            Id = @"CSS.3",
            Type = @"Field",
            Position = @"CSS.3",
            Name = @"Study Quality Control Codes",
            Length = 250,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"In clinical settings, the actual date of a treatment or procedure may vary considerably from the due date. Various coding systems may be used to evaluate the adherence to the schedule or acceptability of the data. Coding systems will vary among trials.",
            Sample = @"",
        };

        // check for repetitions
        if (studyQualityControlCodes.field.FieldRepetitions != null && studyQualityControlCodes.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(studyQualityControlCodes.Id));
            studyQualityControlCodes.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(studyQualityControlCodes, fieldData);
        }

        return studyQualityControlCodes;
    } 
}
    }
}
