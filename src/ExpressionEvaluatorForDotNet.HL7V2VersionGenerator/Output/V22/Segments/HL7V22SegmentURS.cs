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

        public HL7V22SegmentURS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _rUWhereSubjectDefinition;

public HL7V22Field RUWhereSubjectDefinition
{
    get
    {
        if (_rUWhereSubjectDefinition != null)
        {
            return _rUWhereSubjectDefinition;
        }

        var fieldData = new HL7V22FieldData
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
            Fields = null
        }

        _rUWhereSubjectDefinition = new HL7V22Field
        {
            field = message[@"URS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhereSubjectDefinition.field.FieldRepetitions != null && _rUWhereSubjectDefinition.field.FieldRepetitions.Count > 0)
        {
            _rUWhereSubjectDefinition.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_rUWhereSubjectDefinition, fieldData);
        }

        return _rUWhereSubjectDefinition;
    } 
}

internal HL7V22Field _rUWhenDataStartDateTime;

public HL7V22Field RUWhenDataStartDateTime
{
    get
    {
        if (_rUWhenDataStartDateTime != null)
        {
            return _rUWhenDataStartDateTime;
        }

        var fieldData = new HL7V22FieldData
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
            Fields = new[]
                        {
                            new HL7V2FieldData
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
                        },
                        }
        }

        _rUWhenDataStartDateTime = new HL7V22Field
        {
            field = message[@"URS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhenDataStartDateTime.field.FieldRepetitions != null && _rUWhenDataStartDateTime.field.FieldRepetitions.Count > 0)
        {
            _rUWhenDataStartDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_rUWhenDataStartDateTime, fieldData);
        }

        return _rUWhenDataStartDateTime;
    } 
}

internal HL7V22Field _rUWhenDataEndDateTime;

public HL7V22Field RUWhenDataEndDateTime
{
    get
    {
        if (_rUWhenDataEndDateTime != null)
        {
            return _rUWhenDataEndDateTime;
        }

        var fieldData = new HL7V22FieldData
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
            Fields = new[]
                        {
                            new HL7V2FieldData
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
                        },
                        }
        }

        _rUWhenDataEndDateTime = new HL7V22Field
        {
            field = message[@"URS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhenDataEndDateTime.field.FieldRepetitions != null && _rUWhenDataEndDateTime.field.FieldRepetitions.Count > 0)
        {
            _rUWhenDataEndDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_rUWhenDataEndDateTime, fieldData);
        }

        return _rUWhenDataEndDateTime;
    } 
}

internal HL7V22Field _rUWhatUserQualifier;

public HL7V22Field RUWhatUserQualifier
{
    get
    {
        if (_rUWhatUserQualifier != null)
        {
            return _rUWhatUserQualifier;
        }

        var fieldData = new HL7V22FieldData
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
            Fields = null
        }

        _rUWhatUserQualifier = new HL7V22Field
        {
            field = message[@"URS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhatUserQualifier.field.FieldRepetitions != null && _rUWhatUserQualifier.field.FieldRepetitions.Count > 0)
        {
            _rUWhatUserQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_rUWhatUserQualifier, fieldData);
        }

        return _rUWhatUserQualifier;
    } 
}

internal HL7V22Field _rUOtherResultsSubjectDefinition;

public HL7V22Field RUOtherResultsSubjectDefinition
{
    get
    {
        if (_rUOtherResultsSubjectDefinition != null)
        {
            return _rUOtherResultsSubjectDefinition;
        }

        var fieldData = new HL7V22FieldData
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
            Fields = null
        }

        _rUOtherResultsSubjectDefinition = new HL7V22Field
        {
            field = message[@"URS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUOtherResultsSubjectDefinition.field.FieldRepetitions != null && _rUOtherResultsSubjectDefinition.field.FieldRepetitions.Count > 0)
        {
            _rUOtherResultsSubjectDefinition.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_rUOtherResultsSubjectDefinition, fieldData);
        }

        return _rUOtherResultsSubjectDefinition;
    } 
}

internal HL7V22Field _rUWhichDateTimeQualifier;

public HL7V22Field RUWhichDateTimeQualifier
{
    get
    {
        if (_rUWhichDateTimeQualifier != null)
        {
            return _rUWhichDateTimeQualifier;
        }

        var fieldData = new HL7V22FieldData
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
            Fields = null
        }

        _rUWhichDateTimeQualifier = new HL7V22Field
        {
            field = message[@"URS"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhichDateTimeQualifier.field.FieldRepetitions != null && _rUWhichDateTimeQualifier.field.FieldRepetitions.Count > 0)
        {
            _rUWhichDateTimeQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_rUWhichDateTimeQualifier, fieldData);
        }

        return _rUWhichDateTimeQualifier;
    } 
}

internal HL7V22Field _rUWhichDateTimeStatusQualifier;

public HL7V22Field RUWhichDateTimeStatusQualifier
{
    get
    {
        if (_rUWhichDateTimeStatusQualifier != null)
        {
            return _rUWhichDateTimeStatusQualifier;
        }

        var fieldData = new HL7V22FieldData
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
            Fields = null
        }

        _rUWhichDateTimeStatusQualifier = new HL7V22Field
        {
            field = message[@"URS"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUWhichDateTimeStatusQualifier.field.FieldRepetitions != null && _rUWhichDateTimeStatusQualifier.field.FieldRepetitions.Count > 0)
        {
            _rUWhichDateTimeStatusQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_rUWhichDateTimeStatusQualifier, fieldData);
        }

        return _rUWhichDateTimeStatusQualifier;
    } 
}

internal HL7V22Field _rUDateTimeSelectionQualifier;

public HL7V22Field RUDateTimeSelectionQualifier
{
    get
    {
        if (_rUDateTimeSelectionQualifier != null)
        {
            return _rUDateTimeSelectionQualifier;
        }

        var fieldData = new HL7V22FieldData
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
            Fields = null
        }

        _rUDateTimeSelectionQualifier = new HL7V22Field
        {
            field = message[@"URS"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rUDateTimeSelectionQualifier.field.FieldRepetitions != null && _rUDateTimeSelectionQualifier.field.FieldRepetitions.Count > 0)
        {
            _rUDateTimeSelectionQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_rUDateTimeSelectionQualifier, fieldData);
        }

        return _rUDateTimeSelectionQualifier;
    } 
}
    }
}
