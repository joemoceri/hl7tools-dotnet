using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentQRF
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QRF"; } }

        public string SegmentId { get { return @"QRF"; } }
        
        public string LongName { get { return @"Query Filter"; } }
        
        public string Description { get { return @"The QRF segment is used with the QRD segment to refine the content of a query further"; } }
        
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
                            Id = @"QRF.1",
                            Type = @"Field",
                            Position = @"QRF.1",
                            Name = @"Where Subject Filter",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"identifies the department, system, or subsystem to which the query pertains.  This field may repeat as in LAB~HEMO, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.2",
                            Type = @"Field",
                            Position = @"QRF.2",
                            Name = @"When Data Start Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"data representing dates and times equal or after this value should be included",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.2.1",
                            Type = @"Component",
                            Position = @"QRF.2.1",
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
                            Id = @"QRF.2.2",
                            Type = @"Component",
                            Position = @"QRF.2.2",
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
                            Id = @"QRF.3",
                            Type = @"Field",
                            Position = @"QRF.3",
                            Name = @"When Data End Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"data representing dates and times the same as or before this date should be included",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.3.1",
                            Type = @"Component",
                            Position = @"QRF.3.1",
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
                            Id = @"QRF.3.2",
                            Type = @"Component",
                            Position = @"QRF.3.2",
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
                            Id = @"QRF.4",
                            Type = @"Field",
                            Position = @"QRF.4",
                            Name = @"What User Qualifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"an identifier to further define characteristics of the data of interest",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.5",
                            Type = @"Field",
                            Position = @"QRF.5",
                            Name = @"Other Qry Subject Filter",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"a filter defined locally for use between two systems.  This filter uses codes and field definitions which have specific meaning only to the applications and/or site involved",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.6",
                            Type = @"Field",
                            Position = @"QRF.6",
                            Name = @"Which Date / Time Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0156",
                            TableName = @"DATE/TIME QUALIFIER",
                            Description = @"specifies type of date referred to in QRF-2-when data start date/time and QRF-3-when data end date/time",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.7",
                            Type = @"Field",
                            Position = @"QRF.7",
                            Name = @"Which Date / Time Status Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0157",
                            TableName = @"WHICH DATE/TIME STATUS QUALIFIER",
                            Description = @"specifies status type of objects selected in date range defined by QRF-2-when data start date/time and QRF-3-when data end date/time).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.8",
                            Type = @"Field",
                            Position = @"QRF.8",
                            Name = @"Date / Time Selection Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0158",
                            TableName = @"DATE/TIME SELECTION QUALIFIER",
                            Description = @"allows specification of certain types of values within the date/time range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentQRF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field whereSubjectFilter;

public HL7V22Field WhereSubjectFilter
{
    get
    {
        if (whereSubjectFilter != null)
        {
            return whereSubjectFilter;
        }

        whereSubjectFilter = new HL7V22Field
        {
            field = message[@"QRF"][1],
            Id = @"QRF.1",
            Type = @"Field",
            Position = @"QRF.1",
            Name = @"Where Subject Filter",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"identifies the department, system, or subsystem to which the query pertains.  This field may repeat as in LAB~HEMO, etc",
            Sample = @"",
        };

        // check for repetitions
        if (whereSubjectFilter.field.FieldRepetitions != null && whereSubjectFilter.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whereSubjectFilter.Id));
            whereSubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(whereSubjectFilter, fieldData);
        }

        return whereSubjectFilter;
    } 
}

internal HL7V22Field whenDataStartDateTime;

public HL7V22Field WhenDataStartDateTime
{
    get
    {
        if (whenDataStartDateTime != null)
        {
            return whenDataStartDateTime;
        }

        whenDataStartDateTime = new HL7V22Field
        {
            field = message[@"QRF"][2],
            Id = @"QRF.2",
            Type = @"Field",
            Position = @"QRF.2",
            Name = @"When Data Start Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"data representing dates and times equal or after this value should be included",
            Sample = @"",
        };

        // check for repetitions
        if (whenDataStartDateTime.field.FieldRepetitions != null && whenDataStartDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whenDataStartDateTime.Id));
            whenDataStartDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(whenDataStartDateTime, fieldData);
        }

        return whenDataStartDateTime;
    } 
}

internal HL7V22Field whenDataEndDateTime;

public HL7V22Field WhenDataEndDateTime
{
    get
    {
        if (whenDataEndDateTime != null)
        {
            return whenDataEndDateTime;
        }

        whenDataEndDateTime = new HL7V22Field
        {
            field = message[@"QRF"][3],
            Id = @"QRF.3",
            Type = @"Field",
            Position = @"QRF.3",
            Name = @"When Data End Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"data representing dates and times the same as or before this date should be included",
            Sample = @"",
        };

        // check for repetitions
        if (whenDataEndDateTime.field.FieldRepetitions != null && whenDataEndDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whenDataEndDateTime.Id));
            whenDataEndDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(whenDataEndDateTime, fieldData);
        }

        return whenDataEndDateTime;
    } 
}

internal HL7V22Field whatUserQualifier;

public HL7V22Field WhatUserQualifier
{
    get
    {
        if (whatUserQualifier != null)
        {
            return whatUserQualifier;
        }

        whatUserQualifier = new HL7V22Field
        {
            field = message[@"QRF"][4],
            Id = @"QRF.4",
            Type = @"Field",
            Position = @"QRF.4",
            Name = @"What User Qualifier",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"an identifier to further define characteristics of the data of interest",
            Sample = @"",
        };

        // check for repetitions
        if (whatUserQualifier.field.FieldRepetitions != null && whatUserQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whatUserQualifier.Id));
            whatUserQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(whatUserQualifier, fieldData);
        }

        return whatUserQualifier;
    } 
}

internal HL7V22Field otherQrySubjectFilter;

public HL7V22Field OtherQrySubjectFilter
{
    get
    {
        if (otherQrySubjectFilter != null)
        {
            return otherQrySubjectFilter;
        }

        otherQrySubjectFilter = new HL7V22Field
        {
            field = message[@"QRF"][5],
            Id = @"QRF.5",
            Type = @"Field",
            Position = @"QRF.5",
            Name = @"Other Qry Subject Filter",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"a filter defined locally for use between two systems.  This filter uses codes and field definitions which have specific meaning only to the applications and/or site involved",
            Sample = @"",
        };

        // check for repetitions
        if (otherQrySubjectFilter.field.FieldRepetitions != null && otherQrySubjectFilter.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(otherQrySubjectFilter.Id));
            otherQrySubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(otherQrySubjectFilter, fieldData);
        }

        return otherQrySubjectFilter;
    } 
}

internal HL7V22Field whichDateTimeQualifier;

public HL7V22Field WhichDateTimeQualifier
{
    get
    {
        if (whichDateTimeQualifier != null)
        {
            return whichDateTimeQualifier;
        }

        whichDateTimeQualifier = new HL7V22Field
        {
            field = message[@"QRF"][6],
            Id = @"QRF.6",
            Type = @"Field",
            Position = @"QRF.6",
            Name = @"Which Date / Time Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0156",
            TableName = @"DATE/TIME QUALIFIER",
            Description = @"specifies type of date referred to in QRF-2-when data start date/time and QRF-3-when data end date/time",
            Sample = @"",
        };

        // check for repetitions
        if (whichDateTimeQualifier.field.FieldRepetitions != null && whichDateTimeQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whichDateTimeQualifier.Id));
            whichDateTimeQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(whichDateTimeQualifier, fieldData);
        }

        return whichDateTimeQualifier;
    } 
}

internal HL7V22Field whichDateTimeStatusQualifier;

public HL7V22Field WhichDateTimeStatusQualifier
{
    get
    {
        if (whichDateTimeStatusQualifier != null)
        {
            return whichDateTimeStatusQualifier;
        }

        whichDateTimeStatusQualifier = new HL7V22Field
        {
            field = message[@"QRF"][7],
            Id = @"QRF.7",
            Type = @"Field",
            Position = @"QRF.7",
            Name = @"Which Date / Time Status Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0157",
            TableName = @"WHICH DATE/TIME STATUS QUALIFIER",
            Description = @"specifies status type of objects selected in date range defined by QRF-2-when data start date/time and QRF-3-when data end date/time).",
            Sample = @"",
        };

        // check for repetitions
        if (whichDateTimeStatusQualifier.field.FieldRepetitions != null && whichDateTimeStatusQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whichDateTimeStatusQualifier.Id));
            whichDateTimeStatusQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(whichDateTimeStatusQualifier, fieldData);
        }

        return whichDateTimeStatusQualifier;
    } 
}

internal HL7V22Field dateTimeSelectionQualifier;

public HL7V22Field DateTimeSelectionQualifier
{
    get
    {
        if (dateTimeSelectionQualifier != null)
        {
            return dateTimeSelectionQualifier;
        }

        dateTimeSelectionQualifier = new HL7V22Field
        {
            field = message[@"QRF"][8],
            Id = @"QRF.8",
            Type = @"Field",
            Position = @"QRF.8",
            Name = @"Date / Time Selection Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0158",
            TableName = @"DATE/TIME SELECTION QUALIFIER",
            Description = @"allows specification of certain types of values within the date/time range.",
            Sample = @"",
        };

        // check for repetitions
        if (dateTimeSelectionQualifier.field.FieldRepetitions != null && dateTimeSelectionQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateTimeSelectionQualifier.Id));
            dateTimeSelectionQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dateTimeSelectionQualifier, fieldData);
        }

        return dateTimeSelectionQualifier;
    } 
}
    }
}
