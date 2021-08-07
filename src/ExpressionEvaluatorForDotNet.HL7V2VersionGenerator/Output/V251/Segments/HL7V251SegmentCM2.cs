using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentCM2
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"CM2"; } }

        public string SegmentId { get { return @"CM2"; } }
        
        public string LongName { get { return @"Clinical Study Schedule Master"; } }
        
        public string Description { get { return @"The Clinical Study Schedule Master (CM2) contains the information about the scheduled time points for study or phase-related treatment or evaluation events.  The fact that a patient has data satisfying a scheduled time point is sent in the CSS segment, sequence 2.  The CM2 segment describes the scheduled time points in general. "; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM2.2",
                            Type = @"Field",
                            Position = @"CM2.2",
                            Name = @"Scheduled Time Point",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field should correspond to the scheduled time point coding system in CSS-2, ""Study scheduled time point.""",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CM2.2.1",
                            Type = @"Component",
                            Position = @"CM2.2.1",
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
                            Id = @"CM2.2.2",
                            Type = @"Component",
                            Position = @"CM2.2.2",
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
                            Id = @"CM2.2.3",
                            Type = @"Component",
                            Position = @"CM2.2.3",
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
                            Id = @"CM2.2.4",
                            Type = @"Component",
                            Position = @"CM2.2.4",
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
                            Id = @"CM2.2.5",
                            Type = @"Component",
                            Position = @"CM2.2.5",
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
                            Id = @"CM2.2.6",
                            Type = @"Component",
                            Position = @"CM2.2.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM2.4",
                            Type = @"Field",
                            Position = @"CM2.4",
                            Name = @"Events Scheduled This Time Point",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"200",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a study-specific event. Coding systems may be developed for this field or applications may use facility-wide or standardized orders and procedures coding systems. This enables integration of procedures or events ordered for clinical trials with medical order entry systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CM2.4.1",
                            Type = @"Component",
                            Position = @"CM2.4.1",
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
                            Id = @"CM2.4.2",
                            Type = @"Component",
                            Position = @"CM2.4.2",
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
                            Id = @"CM2.4.3",
                            Type = @"Component",
                            Position = @"CM2.4.3",
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
                            Id = @"CM2.4.4",
                            Type = @"Component",
                            Position = @"CM2.4.4",
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
                            Id = @"CM2.4.5",
                            Type = @"Component",
                            Position = @"CM2.4.5",
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
                            Id = @"CM2.4.6",
                            Type = @"Component",
                            Position = @"CM2.4.6",
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
                        },
                        
                        },
                        };
            }
        }

        public HL7V251SegmentCM2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field setIDCM2;

public HL7V251Field SetIDCM2
{
    get
    {
        if (setIDCM2 != null)
        {
            return setIDCM2;
        }

        setIDCM2 = new HL7V251Field
        {
            field = message[@"CM2"][1],
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
        };

        

        

        

        return setIDCM2;
    } 
}
internal HL7V251Field scheduledTimePoint;

public HL7V251Field ScheduledTimePoint
{
    get
    {
        if (scheduledTimePoint != null)
        {
            return scheduledTimePoint;
        }

        scheduledTimePoint = new HL7V251Field
        {
            field = message[@"CM2"][2],
            Id = @"CM2.2",
            Type = @"Field",
            Position = @"CM2.2",
            Name = @"Scheduled Time Point",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field should correspond to the scheduled time point coding system in CSS-2, ""Study scheduled time point.""",
            Sample = @"",
        };

        

        

        

        return scheduledTimePoint;
    } 
}
internal HL7V251Field descriptionofTimePoint;

public HL7V251Field DescriptionofTimePoint
{
    get
    {
        if (descriptionofTimePoint != null)
        {
            return descriptionofTimePoint;
        }

        descriptionofTimePoint = new HL7V251Field
        {
            field = message[@"CM2"][3],
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
        };

        

        

        

        return descriptionofTimePoint;
    } 
}
internal HL7V251Field eventsScheduledThisTimePoint;

public HL7V251Field EventsScheduledThisTimePoint
{
    get
    {
        if (eventsScheduledThisTimePoint != null)
        {
            return eventsScheduledThisTimePoint;
        }

        eventsScheduledThisTimePoint = new HL7V251Field
        {
            field = message[@"CM2"][4],
            Id = @"CM2.4",
            Type = @"Field",
            Position = @"CM2.4",
            Name = @"Events Scheduled This Time Point",
            Length = 250,
            Usage = @"R",
            Rpt = @"200",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a study-specific event. Coding systems may be developed for this field or applications may use facility-wide or standardized orders and procedures coding systems. This enables integration of procedures or events ordered for clinical trials with medical order entry systems.",
            Sample = @"",
        };

        

        

        

        return eventsScheduledThisTimePoint;
    } 
}

    }
}
