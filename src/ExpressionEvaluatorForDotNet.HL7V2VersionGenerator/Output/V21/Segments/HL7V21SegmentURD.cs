using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentURD
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"URD"; } }

        public string SegmentId { get { return @"URD"; } }
        
        public string LongName { get { return @"Results/update Definition"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Id = @"URD.1",
                            Type = @"Field",
                            Position = @"URD.1",
                            Name = @"R/U Date/Time",
                            Length = 19,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URD.2",
                            Type = @"Field",
                            Position = @"URD.2",
                            Name = @"Report Priority",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0109",
                            TableName = @"REPORT PRIORITY",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URD.3",
                            Type = @"Field",
                            Position = @"URD.3",
                            Name = @"R/U Who Subject Definition",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"*",
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
                            Id = @"URD.4",
                            Type = @"Field",
                            Position = @"URD.4",
                            Name = @"R/U What Subject Definition",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0048",
                            TableName = @"WHAT SUBJECT FILTER",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URD.5",
                            Type = @"Field",
                            Position = @"URD.5",
                            Name = @"R/U What Department Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
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
                            Id = @"URD.6",
                            Type = @"Field",
                            Position = @"URD.6",
                            Name = @"R/U Display/Print Locations",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
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
                            Id = @"URD.7",
                            Type = @"Field",
                            Position = @"URD.7",
                            Name = @"R/U Results Level",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0108",
                            TableName = @"QUERY RESULTS LEVEL",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentURD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field rUDateTime;

public HL7V21Field RUDateTime
{
    get
    {
        if (rUDateTime != null)
        {
            return rUDateTime;
        }

        rUDateTime = new HL7V21Field
        {
            field = message[@"URD"][1],
            Id = @"URD.1",
            Type = @"Field",
            Position = @"URD.1",
            Name = @"R/U Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return rUDateTime;
    } 
}
internal HL7V21Field reportPriority;

public HL7V21Field ReportPriority
{
    get
    {
        if (reportPriority != null)
        {
            return reportPriority;
        }

        reportPriority = new HL7V21Field
        {
            field = message[@"URD"][2],
            Id = @"URD.2",
            Type = @"Field",
            Position = @"URD.2",
            Name = @"Report Priority",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0109",
            TableName = @"REPORT PRIORITY",
            Description = null,
            Sample = @"",
        };

        

        

        

        return reportPriority;
    } 
}
internal HL7V21Field rUWhoSubjectDefinition;

public HL7V21Field RUWhoSubjectDefinition
{
    get
    {
        if (rUWhoSubjectDefinition != null)
        {
            return rUWhoSubjectDefinition;
        }

        rUWhoSubjectDefinition = new HL7V21Field
        {
            field = message[@"URD"][3],
            Id = @"URD.3",
            Type = @"Field",
            Position = @"URD.3",
            Name = @"R/U Who Subject Definition",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return rUWhoSubjectDefinition;
    } 
}
internal HL7V21Field rUWhatSubjectDefinition;

public HL7V21Field RUWhatSubjectDefinition
{
    get
    {
        if (rUWhatSubjectDefinition != null)
        {
            return rUWhatSubjectDefinition;
        }

        rUWhatSubjectDefinition = new HL7V21Field
        {
            field = message[@"URD"][4],
            Id = @"URD.4",
            Type = @"Field",
            Position = @"URD.4",
            Name = @"R/U What Subject Definition",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0048",
            TableName = @"WHAT SUBJECT FILTER",
            Description = null,
            Sample = @"",
        };

        

        

        

        return rUWhatSubjectDefinition;
    } 
}
internal HL7V21Field rUWhatDepartmentCode;

public HL7V21Field RUWhatDepartmentCode
{
    get
    {
        if (rUWhatDepartmentCode != null)
        {
            return rUWhatDepartmentCode;
        }

        rUWhatDepartmentCode = new HL7V21Field
        {
            field = message[@"URD"][5],
            Id = @"URD.5",
            Type = @"Field",
            Position = @"URD.5",
            Name = @"R/U What Department Code",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return rUWhatDepartmentCode;
    } 
}
internal HL7V21Field rUDisplayPrintLocations;

public HL7V21Field RUDisplayPrintLocations
{
    get
    {
        if (rUDisplayPrintLocations != null)
        {
            return rUDisplayPrintLocations;
        }

        rUDisplayPrintLocations = new HL7V21Field
        {
            field = message[@"URD"][6],
            Id = @"URD.6",
            Type = @"Field",
            Position = @"URD.6",
            Name = @"R/U Display/Print Locations",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return rUDisplayPrintLocations;
    } 
}
internal HL7V21Field rUResultsLevel;

public HL7V21Field RUResultsLevel
{
    get
    {
        if (rUResultsLevel != null)
        {
            return rUResultsLevel;
        }

        rUResultsLevel = new HL7V21Field
        {
            field = message[@"URD"][7],
            Id = @"URD.7",
            Type = @"Field",
            Position = @"URD.7",
            Name = @"R/U Results Level",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0108",
            TableName = @"QUERY RESULTS LEVEL",
            Description = null,
            Sample = @"",
        };

        

        

        

        return rUResultsLevel;
    } 
}

    }
}
