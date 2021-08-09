using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentCM2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CM2"; } }

        public string SegmentId { get { return @"CM2"; } }
        
        public string LongName { get { return @"Clinical Study Schedule Master"; } }
        
        public string Description { get { return @"The Clinical Study Schedule Master (CM2) contains the  information about the scheduled time points for study or phase-related treatment or evaluation events.  The fact that a patient has data satisfying a scheduled time point is sent in the CSS segment, sequence 2.  The CM2 segment describes the scheduled time points in general."; } }
        
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
                            Name = @"CM2 - Set ID",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction.  For those messages that permit segments to repeat, the  Set ID field is used to identify the repetitions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field should correspond to the scheduled time point coding system in Section 7.7.3.1, “Study scheduled time point.” ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM2.2.4",
                            Type = @"Component",
                            Position = @"CM2.2.4",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
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
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"200",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a study-specific event.  Coding systems may be developed for this field or applications may use facility-wide or standardized orders and procedures coding systems.  This enables integration of procedures or events ordered for clinical trials with medical order entry systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM2.4.4",
                            Type = @"Component",
                            Position = @"CM2.4.4",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V23SegmentCM2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field cM2SetID;

public HL7V23Field CM2SetID
{
    get
    {
        if (cM2SetID != null)
        {
            return cM2SetID;
        }

        cM2SetID = new HL7V23Field
        {
            field = message[@"CM2"][1],
            Id = @"CM2.1",
            Type = @"Field",
            Position = @"CM2.1",
            Name = @"CM2 - Set ID",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction.  For those messages that permit segments to repeat, the  Set ID field is used to identify the repetitions.",
            Sample = @"",
        };

        // check for repetitions
        if (cM2SetID.field.FieldRepetitions != null && cM2SetID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(cM2SetID.Id));
            cM2SetID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(cM2SetID, fieldData);
        }

        return cM2SetID;
    } 
}

internal HL7V23Field scheduledTimePoint;

public HL7V23Field ScheduledTimePoint
{
    get
    {
        if (scheduledTimePoint != null)
        {
            return scheduledTimePoint;
        }

        scheduledTimePoint = new HL7V23Field
        {
            field = message[@"CM2"][2],
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
            Description = @"This field should correspond to the scheduled time point coding system in Section 7.7.3.1, “Study scheduled time point.” ",
            Sample = @"",
        };

        // check for repetitions
        if (scheduledTimePoint.field.FieldRepetitions != null && scheduledTimePoint.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(scheduledTimePoint.Id));
            scheduledTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(scheduledTimePoint, fieldData);
        }

        return scheduledTimePoint;
    } 
}

internal HL7V23Field descriptionofTimePoint;

public HL7V23Field DescriptionofTimePoint
{
    get
    {
        if (descriptionofTimePoint != null)
        {
            return descriptionofTimePoint;
        }

        descriptionofTimePoint = new HL7V23Field
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

        // check for repetitions
        if (descriptionofTimePoint.field.FieldRepetitions != null && descriptionofTimePoint.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(descriptionofTimePoint.Id));
            descriptionofTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(descriptionofTimePoint, fieldData);
        }

        return descriptionofTimePoint;
    } 
}

internal HL7V23Field eventsScheduledThisTimePoint;

public HL7V23Field EventsScheduledThisTimePoint
{
    get
    {
        if (eventsScheduledThisTimePoint != null)
        {
            return eventsScheduledThisTimePoint;
        }

        eventsScheduledThisTimePoint = new HL7V23Field
        {
            field = message[@"CM2"][4],
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
            Description = @"This field contains a study-specific event.  Coding systems may be developed for this field or applications may use facility-wide or standardized orders and procedures coding systems.  This enables integration of procedures or events ordered for clinical trials with medical order entry systems.",
            Sample = @"",
        };

        // check for repetitions
        if (eventsScheduledThisTimePoint.field.FieldRepetitions != null && eventsScheduledThisTimePoint.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventsScheduledThisTimePoint.Id));
            eventsScheduledThisTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(eventsScheduledThisTimePoint, fieldData);
        }

        return eventsScheduledThisTimePoint;
    } 
}
    }
}
