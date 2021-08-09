using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentAPR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"APR"; } }

        public string SegmentId { get { return @"APR"; } }
        
        public string LongName { get { return @"Appointment preferences segment"; } }
        
        public string Description { get { return @"The APR segment contains parameters and preference specifications used for requesting appointments in the SRM message. It allows placer applications to provide coded parameters and preference indicators to the filler application, to help determine when a requested appointment should be scheduled. An APR segment can be provided in conjunction with either the ARQ segment or any of the service and resource segments (AIG, AIS, AIP, and AIL). If an APR segment appears in conjunction with an ARQ segment, its parameters and preference indicators pertain to the schedule request as a whole. If the APR segment appears with any of the service and resource segments, then its parameters and preferences apply only to the immediately preceding service or resource."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",

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
                            Id = @"APR.1",
                            Type = @"Field",
                            Position = @"APR.1",
                            Name = @"Time Selection Criteria",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"SCV",
                            DataTypeName = @"Scheduling Class Value Pair",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate time slot for an appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"APR.1.1",
                            Type = @"Component",
                            Position = @"APR.1.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.1.2",
                            Type = @"Component",
                            Position = @"APR.1.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.2",
                            Type = @"Field",
                            Position = @"APR.2",
                            Name = @"Resource Selection Criteria",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"SCV",
                            DataTypeName = @"Scheduling Class Value Pair",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate resource for an appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"APR.2.1",
                            Type = @"Component",
                            Position = @"APR.2.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.2.2",
                            Type = @"Component",
                            Position = @"APR.2.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.3",
                            Type = @"Field",
                            Position = @"APR.3",
                            Name = @"Location Selection Criteria",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"SCV",
                            DataTypeName = @"Scheduling Class Value Pair",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate location for the appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"APR.3.1",
                            Type = @"Component",
                            Position = @"APR.3.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.3.2",
                            Type = @"Component",
                            Position = @"APR.3.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.4",
                            Type = @"Field",
                            Position = @"APR.4",
                            Name = @"Slot Spacing Criteria",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used in queries returning lists of possible appointment slots, or other lists of slots. If the filler application allows it, the querying application may indicate the spacing of the slots returned to the querying application, in relation to the requested start date/time in the ARQ segment. The value in this field should be a positive integer, representing the number of minutes between slot starting times that is returned in the query.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.5",
                            Type = @"Field",
                            Position = @"APR.5",
                            Name = @"Filler Override Criteria",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"SCV",
                            DataTypeName = @"Scheduling Class Value Pair",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to communicate override parameters to the filler application. These override parameters allow placer applications to override specific features of filler applications such as conflict checking. It is assumed that the placer and filler applications will pass enough information to determine whether the requestor is allowed to override such features. This chapter does not provide any security or permission information.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"APR.5.1",
                            Type = @"Component",
                            Position = @"APR.5.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.5.2",
                            Type = @"Component",
                            Position = @"APR.5.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V231SegmentAPR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field timeSelectionCriteria;

public HL7V231Field TimeSelectionCriteria
{
    get
    {
        if (timeSelectionCriteria != null)
        {
            return timeSelectionCriteria;
        }

        timeSelectionCriteria = new HL7V231Field
        {
            field = message[@"APR"][1],
            Id = @"APR.1",
            Type = @"Field",
            Position = @"APR.1",
            Name = @"Time Selection Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = null,
            TableName = null,
            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate time slot for an appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
            Sample = @"",
        };

        // check for repetitions
        if (timeSelectionCriteria.field.FieldRepetitions != null && timeSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(timeSelectionCriteria.Id));
            timeSelectionCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(timeSelectionCriteria, fieldData);
        }

        return timeSelectionCriteria;
    } 
}

internal HL7V231Field resourceSelectionCriteria;

public HL7V231Field ResourceSelectionCriteria
{
    get
    {
        if (resourceSelectionCriteria != null)
        {
            return resourceSelectionCriteria;
        }

        resourceSelectionCriteria = new HL7V231Field
        {
            field = message[@"APR"][2],
            Id = @"APR.2",
            Type = @"Field",
            Position = @"APR.2",
            Name = @"Resource Selection Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = null,
            TableName = null,
            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate resource for an appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
            Sample = @"",
        };

        // check for repetitions
        if (resourceSelectionCriteria.field.FieldRepetitions != null && resourceSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(resourceSelectionCriteria.Id));
            resourceSelectionCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(resourceSelectionCriteria, fieldData);
        }

        return resourceSelectionCriteria;
    } 
}

internal HL7V231Field locationSelectionCriteria;

public HL7V231Field LocationSelectionCriteria
{
    get
    {
        if (locationSelectionCriteria != null)
        {
            return locationSelectionCriteria;
        }

        locationSelectionCriteria = new HL7V231Field
        {
            field = message[@"APR"][3],
            Id = @"APR.3",
            Type = @"Field",
            Position = @"APR.3",
            Name = @"Location Selection Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = null,
            TableName = null,
            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate location for the appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
            Sample = @"",
        };

        // check for repetitions
        if (locationSelectionCriteria.field.FieldRepetitions != null && locationSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(locationSelectionCriteria.Id));
            locationSelectionCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(locationSelectionCriteria, fieldData);
        }

        return locationSelectionCriteria;
    } 
}

internal HL7V231Field slotSpacingCriteria;

public HL7V231Field SlotSpacingCriteria
{
    get
    {
        if (slotSpacingCriteria != null)
        {
            return slotSpacingCriteria;
        }

        slotSpacingCriteria = new HL7V231Field
        {
            field = message[@"APR"][4],
            Id = @"APR.4",
            Type = @"Field",
            Position = @"APR.4",
            Name = @"Slot Spacing Criteria",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is used in queries returning lists of possible appointment slots, or other lists of slots. If the filler application allows it, the querying application may indicate the spacing of the slots returned to the querying application, in relation to the requested start date/time in the ARQ segment. The value in this field should be a positive integer, representing the number of minutes between slot starting times that is returned in the query.",
            Sample = @"",
        };

        // check for repetitions
        if (slotSpacingCriteria.field.FieldRepetitions != null && slotSpacingCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(slotSpacingCriteria.Id));
            slotSpacingCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(slotSpacingCriteria, fieldData);
        }

        return slotSpacingCriteria;
    } 
}

internal HL7V231Field fillerOverrideCriteria;

public HL7V231Field FillerOverrideCriteria
{
    get
    {
        if (fillerOverrideCriteria != null)
        {
            return fillerOverrideCriteria;
        }

        fillerOverrideCriteria = new HL7V231Field
        {
            field = message[@"APR"][5],
            Id = @"APR.5",
            Type = @"Field",
            Position = @"APR.5",
            Name = @"Filler Override Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = null,
            TableName = null,
            Description = @"This field is used to communicate override parameters to the filler application. These override parameters allow placer applications to override specific features of filler applications such as conflict checking. It is assumed that the placer and filler applications will pass enough information to determine whether the requestor is allowed to override such features. This chapter does not provide any security or permission information.",
            Sample = @"",
        };

        // check for repetitions
        if (fillerOverrideCriteria.field.FieldRepetitions != null && fillerOverrideCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fillerOverrideCriteria.Id));
            fillerOverrideCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(fillerOverrideCriteria, fieldData);
        }

        return fillerOverrideCriteria;
    } 
}
    }
}
