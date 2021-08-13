using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentCSS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CSS"; } }

        public string SegmentId { get { return @"CSS"; } }
        
        public string LongName { get { return @"Clinical Study Data Schedule"; } }
        
        public string Description { get { return @"The Clinical Study Data Schedule (CSS) segment is optional depending on whether messaging of study data needs to be linked to the scheduled data time points for the study.  (See Section 7.5.1.3, “data schedule.”)  The CSS segment enables communication of data schedules and adherence that ranges from the basic to the elaborate.  Use of the segment must be planned for each implementation.  Each CSS segment will subsume observation and drug administration segments that follow, indicating that they satisfy this scheduled time point"; } }
        
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

        public HL7V23SegmentCSS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _studyScheduledTimePoint;

public HL7V23Field StudyScheduledTimePoint
{
    get
    {
        if (_studyScheduledTimePoint != null)
        {
            return _studyScheduledTimePoint;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"CSS.1",
            Type = @"Field",
            Position = @"CSS.1",
            Name = @"Study Scheduled Time Point",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time point for which some instance of data for the clinical trial was scheduled.  The time point may be expressed in any coded format.  Some examples of time point values are: Prestudy, Pretreatment, 4 times/day, Weekly, Every 3 days, Every course, At Relapse, At Off Study,  Alternatively, frequency values from Section 4.4.2, “Interval component (CM),” (the Interval component of the TQ Timing/Quantity data type could be used.)  Time point naming conventions and usage must be specified by implementors. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CSS.1.1",
                            Type = @"Component",
                            Position = @"CSS.1.1",
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
                            Id = @"CSS.1.2",
                            Type = @"Component",
                            Position = @"CSS.1.2",
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
                            Id = @"CSS.1.3",
                            Type = @"Component",
                            Position = @"CSS.1.3",
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
                            Id = @"CSS.1.4",
                            Type = @"Component",
                            Position = @"CSS.1.4",
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
                            Id = @"CSS.1.5",
                            Type = @"Component",
                            Position = @"CSS.1.5",
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
                            Id = @"CSS.1.6",
                            Type = @"Component",
                            Position = @"CSS.1.6",
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

        _studyScheduledTimePoint = new HL7V23Field
        {
            field = message[@"CSS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyScheduledTimePoint.field.FieldRepetitions != null && _studyScheduledTimePoint.field.FieldRepetitions.Count > 0)
        {
            _studyScheduledTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_studyScheduledTimePoint, fieldData);
        }

        return _studyScheduledTimePoint;
    } 
}

internal HL7V23Field _studyScheduledPatientTimePoint;

public HL7V23Field StudyScheduledPatientTimePoint
{
    get
    {
        if (_studyScheduledPatientTimePoint != null)
        {
            return _studyScheduledPatientTimePoint;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the date/time that the scheduled time point should occur for this patient.  The date/time may be used for a reference in reviewing the actual dates on which scheduled items that follow in OBR segments occur for the patient.  The time component is optional",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CSS.2.1",
                            Type = @"Component",
                            Position = @"CSS.2.1",
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

        _studyScheduledPatientTimePoint = new HL7V23Field
        {
            field = message[@"CSS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyScheduledPatientTimePoint.field.FieldRepetitions != null && _studyScheduledPatientTimePoint.field.FieldRepetitions.Count > 0)
        {
            _studyScheduledPatientTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_studyScheduledPatientTimePoint, fieldData);
        }

        return _studyScheduledPatientTimePoint;
    } 
}

internal HL7V23Field _studyQualityControlCodes;

public HL7V23Field StudyQualityControlCodes
{
    get
    {
        if (_studyQualityControlCodes != null)
        {
            return _studyQualityControlCodes;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"CSS.3",
            Type = @"Field",
            Position = @"CSS.3",
            Name = @"Study Quality Control Codes",
            Length = 60,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"In clinical settings, the actual date of a treatment or procedure may vary considerably from the due date.  Various coding systems may be used to evaluate the adherence to the schedule or acceptability of the data.  Coding systems will vary among trials",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CSS.3.1",
                            Type = @"Component",
                            Position = @"CSS.3.1",
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
                            Id = @"CSS.3.2",
                            Type = @"Component",
                            Position = @"CSS.3.2",
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
                            Id = @"CSS.3.3",
                            Type = @"Component",
                            Position = @"CSS.3.3",
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
                            Id = @"CSS.3.4",
                            Type = @"Component",
                            Position = @"CSS.3.4",
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
                            Id = @"CSS.3.5",
                            Type = @"Component",
                            Position = @"CSS.3.5",
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
                            Id = @"CSS.3.6",
                            Type = @"Component",
                            Position = @"CSS.3.6",
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

        _studyQualityControlCodes = new HL7V23Field
        {
            field = message[@"CSS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyQualityControlCodes.field.FieldRepetitions != null && _studyQualityControlCodes.field.FieldRepetitions.Count > 0)
        {
            _studyQualityControlCodes.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_studyQualityControlCodes, fieldData);
        }

        return _studyQualityControlCodes;
    } 
}
    }
}
