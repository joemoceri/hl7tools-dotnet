using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentURS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"URS"; } }

        public string SegmentId { get { return @"URS"; } }
        
        public string LongName { get { return @"Unsolicited Selection"; } }
        
        public string Description { get { return @"The URS segment is identical with the QRF segment, except that, if the name of any field contains Query (of QRY), this word has been changed to Results (See URS-5-R/U other results subject definition). "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

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
                            Id = @"URS.1",
                            Type = @"Field",
                            Position = @"URS.1",
                            Name = @"R/U Where Subject Definition",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"dentifies the department, system, or subsystem to which the result pertains.  This field may repeat as in LAB~HEMO, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.2",
                            Type = @"Field",
                            Position = @"URS.2",
                            Name = @"R/U When Data Start Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"date/time the result starts.  (if applicable).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"URS.2.1",
                            Type = @"Component",
                            Position = @"URS.2.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.2.2",
                            Type = @"Component",
                            Position = @"URS.2.2",
                            Name = @"Degree Of Precision",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.3",
                            Type = @"Field",
                            Position = @"URS.3",
                            Name = @"R/U When Data End Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"date/time the result ends. (if applicable).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"URS.3.1",
                            Type = @"Component",
                            Position = @"URS.3.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.3.2",
                            Type = @"Component",
                            Position = @"URS.3.2",
                            Name = @"Degree Of Precision",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.4",
                            Type = @"Field",
                            Position = @"URS.4",
                            Name = @"R/U What User Qualifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"an identifier to define further the characteristics of the data that are of interest",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.5",
                            Type = @"Field",
                            Position = @"URS.5",
                            Name = @"R/U Other Results Subject Definition",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"further qualifier defined locally for use between two systems.  This filter uses codes and field definitions that have specific meaning only to the application and/or site involved",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.6",
                            Type = @"Field",
                            Position = @"URS.6",
                            Name = @"R/U Which Date / Time Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0156",
                            TableName = @"DATE/TIME QUALIFIER",
                            Description = @"specifies type of date referred to in URS-2-when data start date/time and URS-3-when data end date/time.  Refer to table 0156 - which date/time qualifier",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.7",
                            Type = @"Field",
                            Position = @"URS.7",
                            Name = @"R/U Which Date / Time Status Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0157",
                            TableName = @"WHICH DATE/TIME STATUS QUALIFIER",
                            Description = @"specifies status type of objects selected in date range defined by URS-2-when data start date/time and URS-3-when data end date/time.  Refer to table 0157 - date/time status qualifier",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.8",
                            Type = @"Field",
                            Position = @"URS.8",
                            Name = @"R/U Date / Time Selection Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0158",
                            TableName = @"DATE/TIME SELECTION QUALIFIER",
                            Description = @"allows specification of certain types of values within the date/time range.  Refer to table 0158 - date/time selection qualifier",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentURS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field rUWhereSubjectDefinition;

public HL7V22Field RUWhereSubjectDefinition
{
    get
    {
        if (rUWhereSubjectDefinition != null)
        {
            return rUWhereSubjectDefinition;
        }

        rUWhereSubjectDefinition = new HL7V22Field
        {
            field = message[@"URS"][1],
            Id = @"URS.1",
            Type = @"Field",
            Position = @"URS.1",
            Name = @"R/U Where Subject Definition",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"dentifies the department, system, or subsystem to which the result pertains.  This field may repeat as in LAB~HEMO, etc",
            Sample = @"",
        };

        // check for repetitions
        if (rUWhereSubjectDefinition.field.FieldRepetitions != null && rUWhereSubjectDefinition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhereSubjectDefinition.Id));
            rUWhereSubjectDefinition.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(rUWhereSubjectDefinition, fieldData);
        }

        return rUWhereSubjectDefinition;
    } 
}

internal HL7V22Field rUWhenDataStartDateTime;

public HL7V22Field RUWhenDataStartDateTime
{
    get
    {
        if (rUWhenDataStartDateTime != null)
        {
            return rUWhenDataStartDateTime;
        }

        rUWhenDataStartDateTime = new HL7V22Field
        {
            field = message[@"URS"][2],
            Id = @"URS.2",
            Type = @"Field",
            Position = @"URS.2",
            Name = @"R/U When Data Start Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time the result starts.  (if applicable).",
            Sample = @"",
        };

        // check for repetitions
        if (rUWhenDataStartDateTime.field.FieldRepetitions != null && rUWhenDataStartDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhenDataStartDateTime.Id));
            rUWhenDataStartDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(rUWhenDataStartDateTime, fieldData);
        }

        return rUWhenDataStartDateTime;
    } 
}

internal HL7V22Field rUWhenDataEndDateTime;

public HL7V22Field RUWhenDataEndDateTime
{
    get
    {
        if (rUWhenDataEndDateTime != null)
        {
            return rUWhenDataEndDateTime;
        }

        rUWhenDataEndDateTime = new HL7V22Field
        {
            field = message[@"URS"][3],
            Id = @"URS.3",
            Type = @"Field",
            Position = @"URS.3",
            Name = @"R/U When Data End Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time the result ends. (if applicable).",
            Sample = @"",
        };

        // check for repetitions
        if (rUWhenDataEndDateTime.field.FieldRepetitions != null && rUWhenDataEndDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhenDataEndDateTime.Id));
            rUWhenDataEndDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(rUWhenDataEndDateTime, fieldData);
        }

        return rUWhenDataEndDateTime;
    } 
}

internal HL7V22Field rUWhatUserQualifier;

public HL7V22Field RUWhatUserQualifier
{
    get
    {
        if (rUWhatUserQualifier != null)
        {
            return rUWhatUserQualifier;
        }

        rUWhatUserQualifier = new HL7V22Field
        {
            field = message[@"URS"][4],
            Id = @"URS.4",
            Type = @"Field",
            Position = @"URS.4",
            Name = @"R/U What User Qualifier",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"an identifier to define further the characteristics of the data that are of interest",
            Sample = @"",
        };

        // check for repetitions
        if (rUWhatUserQualifier.field.FieldRepetitions != null && rUWhatUserQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhatUserQualifier.Id));
            rUWhatUserQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(rUWhatUserQualifier, fieldData);
        }

        return rUWhatUserQualifier;
    } 
}

internal HL7V22Field rUOtherResultsSubjectDefinition;

public HL7V22Field RUOtherResultsSubjectDefinition
{
    get
    {
        if (rUOtherResultsSubjectDefinition != null)
        {
            return rUOtherResultsSubjectDefinition;
        }

        rUOtherResultsSubjectDefinition = new HL7V22Field
        {
            field = message[@"URS"][5],
            Id = @"URS.5",
            Type = @"Field",
            Position = @"URS.5",
            Name = @"R/U Other Results Subject Definition",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"further qualifier defined locally for use between two systems.  This filter uses codes and field definitions that have specific meaning only to the application and/or site involved",
            Sample = @"",
        };

        // check for repetitions
        if (rUOtherResultsSubjectDefinition.field.FieldRepetitions != null && rUOtherResultsSubjectDefinition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUOtherResultsSubjectDefinition.Id));
            rUOtherResultsSubjectDefinition.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(rUOtherResultsSubjectDefinition, fieldData);
        }

        return rUOtherResultsSubjectDefinition;
    } 
}

internal HL7V22Field rUWhichDateTimeQualifier;

public HL7V22Field RUWhichDateTimeQualifier
{
    get
    {
        if (rUWhichDateTimeQualifier != null)
        {
            return rUWhichDateTimeQualifier;
        }

        rUWhichDateTimeQualifier = new HL7V22Field
        {
            field = message[@"URS"][6],
            Id = @"URS.6",
            Type = @"Field",
            Position = @"URS.6",
            Name = @"R/U Which Date / Time Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0156",
            TableName = @"DATE/TIME QUALIFIER",
            Description = @"specifies type of date referred to in URS-2-when data start date/time and URS-3-when data end date/time.  Refer to table 0156 - which date/time qualifier",
            Sample = @"",
        };

        // check for repetitions
        if (rUWhichDateTimeQualifier.field.FieldRepetitions != null && rUWhichDateTimeQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhichDateTimeQualifier.Id));
            rUWhichDateTimeQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(rUWhichDateTimeQualifier, fieldData);
        }

        return rUWhichDateTimeQualifier;
    } 
}

internal HL7V22Field rUWhichDateTimeStatusQualifier;

public HL7V22Field RUWhichDateTimeStatusQualifier
{
    get
    {
        if (rUWhichDateTimeStatusQualifier != null)
        {
            return rUWhichDateTimeStatusQualifier;
        }

        rUWhichDateTimeStatusQualifier = new HL7V22Field
        {
            field = message[@"URS"][7],
            Id = @"URS.7",
            Type = @"Field",
            Position = @"URS.7",
            Name = @"R/U Which Date / Time Status Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0157",
            TableName = @"WHICH DATE/TIME STATUS QUALIFIER",
            Description = @"specifies status type of objects selected in date range defined by URS-2-when data start date/time and URS-3-when data end date/time.  Refer to table 0157 - date/time status qualifier",
            Sample = @"",
        };

        // check for repetitions
        if (rUWhichDateTimeStatusQualifier.field.FieldRepetitions != null && rUWhichDateTimeStatusQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhichDateTimeStatusQualifier.Id));
            rUWhichDateTimeStatusQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(rUWhichDateTimeStatusQualifier, fieldData);
        }

        return rUWhichDateTimeStatusQualifier;
    } 
}

internal HL7V22Field rUDateTimeSelectionQualifier;

public HL7V22Field RUDateTimeSelectionQualifier
{
    get
    {
        if (rUDateTimeSelectionQualifier != null)
        {
            return rUDateTimeSelectionQualifier;
        }

        rUDateTimeSelectionQualifier = new HL7V22Field
        {
            field = message[@"URS"][8],
            Id = @"URS.8",
            Type = @"Field",
            Position = @"URS.8",
            Name = @"R/U Date / Time Selection Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0158",
            TableName = @"DATE/TIME SELECTION QUALIFIER",
            Description = @"allows specification of certain types of values within the date/time range.  Refer to table 0158 - date/time selection qualifier",
            Sample = @"",
        };

        // check for repetitions
        if (rUDateTimeSelectionQualifier.field.FieldRepetitions != null && rUDateTimeSelectionQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUDateTimeSelectionQualifier.Id));
            rUDateTimeSelectionQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(rUDateTimeSelectionQualifier, fieldData);
        }

        return rUDateTimeSelectionQualifier;
    } 
}
    }
}
