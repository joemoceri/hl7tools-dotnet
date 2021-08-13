using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentCM2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CM2"; } }

        public string SegmentId { get { return @"CM2"; } }
        
        public string LongName { get { return @"Clinical study schedule master segment"; } }
        
        public string Description { get { return @"The Clinical Study Schedule Master (CM2) contains the information about the scheduled time points for study or phase-related treatment or evaluation events. The fact that a patient has data satisfying a scheduled time point is sent in the CSS segment, sequence 2. The CM2 segment describes the scheduled time points in general."; } }
        
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

        public HL7V231SegmentCM2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _setIDCM2;

public HL7V231Field SetIDCM2
{
    get
    {
        if (_setIDCM2 != null)
        {
            return _setIDCM2;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"CM2.1",
            Type = @"Field",
            Position = @"CM2.1",
            Name = @"Set ID - CM2",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction. For those messages that permit segments to repeat, the Set ID field is used to identify the repetitions.",
            Sample = @"",
            Fields = null
        }

        _setIDCM2 = new HL7V231Field
        {
            field = message[@"CM2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDCM2.field.FieldRepetitions != null && _setIDCM2.field.FieldRepetitions.Count > 0)
        {
            _setIDCM2.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_setIDCM2, fieldData);
        }

        return _setIDCM2;
    } 
}

internal HL7V231Field _scheduledTimePoint;

public HL7V231Field ScheduledTimePoint
{
    get
    {
        if (_scheduledTimePoint != null)
        {
            return _scheduledTimePoint;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"CM2.2",
            Type = @"Field",
            Position = @"CM2.2",
            Name = @"Scheduled Time Point",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field should correspond to the scheduled time point coding system in Section 7.7.3.1, 'Study scheduled time point.'",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CM2.2.1",
                            Type = @"Component",
                            Position = @"CM2.2.1",
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
                            Id = @"CM2.2.2",
                            Type = @"Component",
                            Position = @"CM2.2.2",
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
                            Id = @"CM2.2.3",
                            Type = @"Component",
                            Position = @"CM2.2.3",
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
                            Id = @"CM2.2.4",
                            Type = @"Component",
                            Position = @"CM2.2.4",
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
                            Id = @"CM2.2.5",
                            Type = @"Component",
                            Position = @"CM2.2.5",
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
                            Id = @"CM2.2.6",
                            Type = @"Component",
                            Position = @"CM2.2.6",
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

        _scheduledTimePoint = new HL7V231Field
        {
            field = message[@"CM2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_scheduledTimePoint.field.FieldRepetitions != null && _scheduledTimePoint.field.FieldRepetitions.Count > 0)
        {
            _scheduledTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_scheduledTimePoint, fieldData);
        }

        return _scheduledTimePoint;
    } 
}

internal HL7V231Field _descriptionofTimePoint;

public HL7V231Field DescriptionofTimePoint
{
    get
    {
        if (_descriptionofTimePoint != null)
        {
            return _descriptionofTimePoint;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"CM2.3",
            Type = @"Field",
            Position = @"CM2.3",
            Name = @"Description of Time Point",
            Length = 300,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a brief explanation so recipients will understand what the time point represents.",
            Sample = @"",
            Fields = null
        }

        _descriptionofTimePoint = new HL7V231Field
        {
            field = message[@"CM2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_descriptionofTimePoint.field.FieldRepetitions != null && _descriptionofTimePoint.field.FieldRepetitions.Count > 0)
        {
            _descriptionofTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_descriptionofTimePoint, fieldData);
        }

        return _descriptionofTimePoint;
    } 
}

internal HL7V231Field _eventsScheduledThisTimePoint;

public HL7V231Field EventsScheduledThisTimePoint
{
    get
    {
        if (_eventsScheduledThisTimePoint != null)
        {
            return _eventsScheduledThisTimePoint;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"CM2.4",
            Type = @"Field",
            Position = @"CM2.4",
            Name = @"Events Scheduled This Time Point",
            Length = 60,
            Usage = @"R",
            Rpt = @"200",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a study-specific event. Coding systems may be developed for this field or applications may use facility-wide or standardized orders and procedures coding systems. This enables integration of procedures or events ordered for clinical trials with medical order entry systems.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CM2.4.1",
                            Type = @"Component",
                            Position = @"CM2.4.1",
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
                            Id = @"CM2.4.2",
                            Type = @"Component",
                            Position = @"CM2.4.2",
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
                            Id = @"CM2.4.3",
                            Type = @"Component",
                            Position = @"CM2.4.3",
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
                            Id = @"CM2.4.4",
                            Type = @"Component",
                            Position = @"CM2.4.4",
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
                            Id = @"CM2.4.5",
                            Type = @"Component",
                            Position = @"CM2.4.5",
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
                            Id = @"CM2.4.6",
                            Type = @"Component",
                            Position = @"CM2.4.6",
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

        _eventsScheduledThisTimePoint = new HL7V231Field
        {
            field = message[@"CM2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventsScheduledThisTimePoint.field.FieldRepetitions != null && _eventsScheduledThisTimePoint.field.FieldRepetitions.Count > 0)
        {
            _eventsScheduledThisTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_eventsScheduledThisTimePoint, fieldData);
        }

        return _eventsScheduledThisTimePoint;
    } 
}
    }
}
