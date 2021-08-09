using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentPSH
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PSH"; } }

        public string SegmentId { get { return @"PSH"; } }
        
        public string LongName { get { return @"Product summary header segment"; } }
        
        public string Description { get { return @"Figure 7-23. PSH attributes"; } }
        
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
                            Id = @"PSH.1",
                            Type = @"Field",
                            Position = @"PSH.1",
                            Name = @"Report Type",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name, title, or other description of the report. Typically, the field will include the agency name (e.g., FDA), agency component if applicable (e.g., CDRH) and the report type (e.g., Medical Device Reporting Baseline Report).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.2",
                            Type = @"Field",
                            Position = @"PSH.2",
                            Name = @"Report Form Identifier",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the form descriptor which describes the report. Typically, the field will include the agency name (e.g., FDA), agency component if applicable (e.g., CDRH) and the form number (e.g., 3417).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.3",
                            Type = @"Field",
                            Position = @"PSH.3",
                            Name = @"Report Date",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date as assigned by the sender.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSH.3.1",
                            Type = @"Component",
                            Position = @"PSH.3.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.4",
                            Type = @"Field",
                            Position = @"PSH.4",
                            Name = @"Report Interval Start Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date which marks the beginning of the time interval covered by the current report.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSH.4.1",
                            Type = @"Component",
                            Position = @"PSH.4.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.5",
                            Type = @"Field",
                            Position = @"PSH.5",
                            Name = @"Report Interval End Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date which marks the inclusive end of the time interval covered by the current report.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSH.5.1",
                            Type = @"Component",
                            Position = @"PSH.5.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.6",
                            Type = @"Field",
                            Position = @"PSH.6",
                            Name = @"Quantity Manufactured",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to send the number of units of the product manufactured during the reporting interval. The second component can be used to specify the units for the quantity.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSH.6.1",
                            Type = @"Component",
                            Position = @"PSH.6.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.6.2",
                            Type = @"Component",
                            Position = @"PSH.6.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the observation is measured in the default units, the units need not be transmitted. If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component. If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7. If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7. But in these cases the component separator should be replaced by the subcomponent delimiter",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.7",
                            Type = @"Field",
                            Position = @"PSH.7",
                            Name = @"Quantity Distributed",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to send the number of units of the product which were distributed during the reporting interval. The second component can be used to specify the units for the quantity.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSH.7.1",
                            Type = @"Component",
                            Position = @"PSH.7.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.7.2",
                            Type = @"Component",
                            Position = @"PSH.7.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the observation is measured in the default units, the units need not be transmitted. If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component. If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7. If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7. But in these cases the component separator should be replaced by the subcomponent delimiter",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.8",
                            Type = @"Field",
                            Position = @"PSH.8",
                            Name = @"Quantity Distributed Method",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0329",
                            TableName = @"Quantity method",
                            Description = @"This field is used for measuring the quantity distributed. An explanation of the method used for estimation can be included in PSH-9-quantity distributed comment. Refer to HL7 table 0329 - Quantity method for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.9",
                            Type = @"Field",
                            Position = @"PSH.9",
                            Name = @"Quantity Distributed Comment",
                            Length = 600,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used for any explanatory text needed but in particular should provide a description of the estimation method used. If referring to the description used in a previous report, the comment should include the product identifier and data of that report.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.10",
                            Type = @"Field",
                            Position = @"PSH.10",
                            Name = @"Quantity in Use",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to send the number of units of the product which were in use during the reporting interval. The second component can be used to specify the units for the quantity.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSH.10.1",
                            Type = @"Component",
                            Position = @"PSH.10.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.10.2",
                            Type = @"Component",
                            Position = @"PSH.10.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the observation is measured in the default units, the units need not be transmitted. If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component. If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7. If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7. But in these cases the component separator should be replaced by the subcomponent delimiter",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.11",
                            Type = @"Field",
                            Position = @"PSH.11",
                            Name = @"Quantity in Use Method",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0329",
                            TableName = @"Quantity method",
                            Description = @"This field contains the method used for measuring the quantity in use. An explanation of the method used for estimation can be included in PSH-12-quantity in use comment. Refer to HL7 table 0329 - Quantity method for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.12",
                            Type = @"Field",
                            Position = @"PSH.12",
                            Name = @"Quantity in Use Comment",
                            Length = 600,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field can be used for any explanatory text needed but in particular should provide a description of the estimation method used. If referring to the description used in a previous report, the comment should include the product identifier and data of the report.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.13",
                            Type = @"Field",
                            Position = @"PSH.13",
                            Name = @"Number of Product Experience Reports Filed by Facility",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"8",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The field contains the number of product experience reports filed by facility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.14",
                            Type = @"Field",
                            Position = @"PSH.14",
                            Name = @"Number of Product Experience Reports Filed by Distributor",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"8",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of product experience reports filed by distributor.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V231SegmentPSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field reportType;

public HL7V231Field ReportType
{
    get
    {
        if (reportType != null)
        {
            return reportType;
        }

        reportType = new HL7V231Field
        {
            field = message[@"PSH"][1],
            Id = @"PSH.1",
            Type = @"Field",
            Position = @"PSH.1",
            Name = @"Report Type",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name, title, or other description of the report. Typically, the field will include the agency name (e.g., FDA), agency component if applicable (e.g., CDRH) and the report type (e.g., Medical Device Reporting Baseline Report).",
            Sample = @"",
        };

        // check for repetitions
        if (reportType.field.FieldRepetitions != null && reportType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(reportType.Id));
            reportType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(reportType, fieldData);
        }

        return reportType;
    } 
}

internal HL7V231Field reportFormIdentifier;

public HL7V231Field ReportFormIdentifier
{
    get
    {
        if (reportFormIdentifier != null)
        {
            return reportFormIdentifier;
        }

        reportFormIdentifier = new HL7V231Field
        {
            field = message[@"PSH"][2],
            Id = @"PSH.2",
            Type = @"Field",
            Position = @"PSH.2",
            Name = @"Report Form Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the form descriptor which describes the report. Typically, the field will include the agency name (e.g., FDA), agency component if applicable (e.g., CDRH) and the form number (e.g., 3417).",
            Sample = @"",
        };

        // check for repetitions
        if (reportFormIdentifier.field.FieldRepetitions != null && reportFormIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(reportFormIdentifier.Id));
            reportFormIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(reportFormIdentifier, fieldData);
        }

        return reportFormIdentifier;
    } 
}

internal HL7V231Field reportDate;

public HL7V231Field ReportDate
{
    get
    {
        if (reportDate != null)
        {
            return reportDate;
        }

        reportDate = new HL7V231Field
        {
            field = message[@"PSH"][3],
            Id = @"PSH.3",
            Type = @"Field",
            Position = @"PSH.3",
            Name = @"Report Date",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date as assigned by the sender.",
            Sample = @"",
        };

        // check for repetitions
        if (reportDate.field.FieldRepetitions != null && reportDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(reportDate.Id));
            reportDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(reportDate, fieldData);
        }

        return reportDate;
    } 
}

internal HL7V231Field reportIntervalStartDate;

public HL7V231Field ReportIntervalStartDate
{
    get
    {
        if (reportIntervalStartDate != null)
        {
            return reportIntervalStartDate;
        }

        reportIntervalStartDate = new HL7V231Field
        {
            field = message[@"PSH"][4],
            Id = @"PSH.4",
            Type = @"Field",
            Position = @"PSH.4",
            Name = @"Report Interval Start Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date which marks the beginning of the time interval covered by the current report.",
            Sample = @"",
        };

        // check for repetitions
        if (reportIntervalStartDate.field.FieldRepetitions != null && reportIntervalStartDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(reportIntervalStartDate.Id));
            reportIntervalStartDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(reportIntervalStartDate, fieldData);
        }

        return reportIntervalStartDate;
    } 
}

internal HL7V231Field reportIntervalEndDate;

public HL7V231Field ReportIntervalEndDate
{
    get
    {
        if (reportIntervalEndDate != null)
        {
            return reportIntervalEndDate;
        }

        reportIntervalEndDate = new HL7V231Field
        {
            field = message[@"PSH"][5],
            Id = @"PSH.5",
            Type = @"Field",
            Position = @"PSH.5",
            Name = @"Report Interval End Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date which marks the inclusive end of the time interval covered by the current report.",
            Sample = @"",
        };

        // check for repetitions
        if (reportIntervalEndDate.field.FieldRepetitions != null && reportIntervalEndDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(reportIntervalEndDate.Id));
            reportIntervalEndDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(reportIntervalEndDate, fieldData);
        }

        return reportIntervalEndDate;
    } 
}

internal HL7V231Field quantityManufactured;

public HL7V231Field QuantityManufactured
{
    get
    {
        if (quantityManufactured != null)
        {
            return quantityManufactured;
        }

        quantityManufactured = new HL7V231Field
        {
            field = message[@"PSH"][6],
            Id = @"PSH.6",
            Type = @"Field",
            Position = @"PSH.6",
            Name = @"Quantity Manufactured",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field is used to send the number of units of the product manufactured during the reporting interval. The second component can be used to specify the units for the quantity.",
            Sample = @"",
        };

        // check for repetitions
        if (quantityManufactured.field.FieldRepetitions != null && quantityManufactured.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityManufactured.Id));
            quantityManufactured.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(quantityManufactured, fieldData);
        }

        return quantityManufactured;
    } 
}

internal HL7V231Field quantityDistributed;

public HL7V231Field QuantityDistributed
{
    get
    {
        if (quantityDistributed != null)
        {
            return quantityDistributed;
        }

        quantityDistributed = new HL7V231Field
        {
            field = message[@"PSH"][7],
            Id = @"PSH.7",
            Type = @"Field",
            Position = @"PSH.7",
            Name = @"Quantity Distributed",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field is used to send the number of units of the product which were distributed during the reporting interval. The second component can be used to specify the units for the quantity.",
            Sample = @"",
        };

        // check for repetitions
        if (quantityDistributed.field.FieldRepetitions != null && quantityDistributed.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityDistributed.Id));
            quantityDistributed.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(quantityDistributed, fieldData);
        }

        return quantityDistributed;
    } 
}

internal HL7V231Field quantityDistributedMethod;

public HL7V231Field QuantityDistributedMethod
{
    get
    {
        if (quantityDistributedMethod != null)
        {
            return quantityDistributedMethod;
        }

        quantityDistributedMethod = new HL7V231Field
        {
            field = message[@"PSH"][8],
            Id = @"PSH.8",
            Type = @"Field",
            Position = @"PSH.8",
            Name = @"Quantity Distributed Method",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0329",
            TableName = @"Quantity method",
            Description = @"This field is used for measuring the quantity distributed. An explanation of the method used for estimation can be included in PSH-9-quantity distributed comment. Refer to HL7 table 0329 - Quantity method for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (quantityDistributedMethod.field.FieldRepetitions != null && quantityDistributedMethod.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityDistributedMethod.Id));
            quantityDistributedMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(quantityDistributedMethod, fieldData);
        }

        return quantityDistributedMethod;
    } 
}

internal HL7V231Field quantityDistributedComment;

public HL7V231Field QuantityDistributedComment
{
    get
    {
        if (quantityDistributedComment != null)
        {
            return quantityDistributedComment;
        }

        quantityDistributedComment = new HL7V231Field
        {
            field = message[@"PSH"][9],
            Id = @"PSH.9",
            Type = @"Field",
            Position = @"PSH.9",
            Name = @"Quantity Distributed Comment",
            Length = 600,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used for any explanatory text needed but in particular should provide a description of the estimation method used. If referring to the description used in a previous report, the comment should include the product identifier and data of that report.",
            Sample = @"",
        };

        // check for repetitions
        if (quantityDistributedComment.field.FieldRepetitions != null && quantityDistributedComment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityDistributedComment.Id));
            quantityDistributedComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(quantityDistributedComment, fieldData);
        }

        return quantityDistributedComment;
    } 
}

internal HL7V231Field quantityinUse;

public HL7V231Field QuantityinUse
{
    get
    {
        if (quantityinUse != null)
        {
            return quantityinUse;
        }

        quantityinUse = new HL7V231Field
        {
            field = message[@"PSH"][10],
            Id = @"PSH.10",
            Type = @"Field",
            Position = @"PSH.10",
            Name = @"Quantity in Use",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field is used to send the number of units of the product which were in use during the reporting interval. The second component can be used to specify the units for the quantity.",
            Sample = @"",
        };

        // check for repetitions
        if (quantityinUse.field.FieldRepetitions != null && quantityinUse.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityinUse.Id));
            quantityinUse.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(quantityinUse, fieldData);
        }

        return quantityinUse;
    } 
}

internal HL7V231Field quantityinUseMethod;

public HL7V231Field QuantityinUseMethod
{
    get
    {
        if (quantityinUseMethod != null)
        {
            return quantityinUseMethod;
        }

        quantityinUseMethod = new HL7V231Field
        {
            field = message[@"PSH"][11],
            Id = @"PSH.11",
            Type = @"Field",
            Position = @"PSH.11",
            Name = @"Quantity in Use Method",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0329",
            TableName = @"Quantity method",
            Description = @"This field contains the method used for measuring the quantity in use. An explanation of the method used for estimation can be included in PSH-12-quantity in use comment. Refer to HL7 table 0329 - Quantity method for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (quantityinUseMethod.field.FieldRepetitions != null && quantityinUseMethod.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityinUseMethod.Id));
            quantityinUseMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(quantityinUseMethod, fieldData);
        }

        return quantityinUseMethod;
    } 
}

internal HL7V231Field quantityinUseComment;

public HL7V231Field QuantityinUseComment
{
    get
    {
        if (quantityinUseComment != null)
        {
            return quantityinUseComment;
        }

        quantityinUseComment = new HL7V231Field
        {
            field = message[@"PSH"][12],
            Id = @"PSH.12",
            Type = @"Field",
            Position = @"PSH.12",
            Name = @"Quantity in Use Comment",
            Length = 600,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field can be used for any explanatory text needed but in particular should provide a description of the estimation method used. If referring to the description used in a previous report, the comment should include the product identifier and data of the report.",
            Sample = @"",
        };

        // check for repetitions
        if (quantityinUseComment.field.FieldRepetitions != null && quantityinUseComment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityinUseComment.Id));
            quantityinUseComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(quantityinUseComment, fieldData);
        }

        return quantityinUseComment;
    } 
}

internal HL7V231Field numberofProductExperienceReportsFiledbyFacility;

public HL7V231Field NumberofProductExperienceReportsFiledbyFacility
{
    get
    {
        if (numberofProductExperienceReportsFiledbyFacility != null)
        {
            return numberofProductExperienceReportsFiledbyFacility;
        }

        numberofProductExperienceReportsFiledbyFacility = new HL7V231Field
        {
            field = message[@"PSH"][13],
            Id = @"PSH.13",
            Type = @"Field",
            Position = @"PSH.13",
            Name = @"Number of Product Experience Reports Filed by Facility",
            Length = 2,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"The field contains the number of product experience reports filed by facility.",
            Sample = @"",
        };

        // check for repetitions
        if (numberofProductExperienceReportsFiledbyFacility.field.FieldRepetitions != null && numberofProductExperienceReportsFiledbyFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberofProductExperienceReportsFiledbyFacility.Id));
            numberofProductExperienceReportsFiledbyFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(numberofProductExperienceReportsFiledbyFacility, fieldData);
        }

        return numberofProductExperienceReportsFiledbyFacility;
    } 
}

internal HL7V231Field numberofProductExperienceReportsFiledbyDistributor;

public HL7V231Field NumberofProductExperienceReportsFiledbyDistributor
{
    get
    {
        if (numberofProductExperienceReportsFiledbyDistributor != null)
        {
            return numberofProductExperienceReportsFiledbyDistributor;
        }

        numberofProductExperienceReportsFiledbyDistributor = new HL7V231Field
        {
            field = message[@"PSH"][14],
            Id = @"PSH.14",
            Type = @"Field",
            Position = @"PSH.14",
            Name = @"Number of Product Experience Reports Filed by Distributor",
            Length = 2,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of product experience reports filed by distributor.",
            Sample = @"",
        };

        // check for repetitions
        if (numberofProductExperienceReportsFiledbyDistributor.field.FieldRepetitions != null && numberofProductExperienceReportsFiledbyDistributor.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberofProductExperienceReportsFiledbyDistributor.Id));
            numberofProductExperienceReportsFiledbyDistributor.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(numberofProductExperienceReportsFiledbyDistributor, fieldData);
        }

        return numberofProductExperienceReportsFiledbyDistributor;
    } 
}
    }
}
