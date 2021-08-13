using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentPSH
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PSH"; } }

        public string SegmentId { get { return @"PSH"; } }
        
        public string LongName { get { return @"Product Summary Header"; } }
        
        public string Description { get { return @""; } }
        
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

        public HL7V26SegmentPSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _reportType;

public HL7V26Field ReportType
{
    get
    {
        if (_reportType != null)
        {
            return _reportType;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _reportType = new HL7V26Field
        {
            field = message[@"PSH"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportType.field.FieldRepetitions != null && _reportType.field.FieldRepetitions.Count > 0)
        {
            _reportType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_reportType, fieldData);
        }

        return _reportType;
    } 
}

internal HL7V26Field _reportFormIdentifier;

public HL7V26Field ReportFormIdentifier
{
    get
    {
        if (_reportFormIdentifier != null)
        {
            return _reportFormIdentifier;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _reportFormIdentifier = new HL7V26Field
        {
            field = message[@"PSH"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportFormIdentifier.field.FieldRepetitions != null && _reportFormIdentifier.field.FieldRepetitions.Count > 0)
        {
            _reportFormIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_reportFormIdentifier, fieldData);
        }

        return _reportFormIdentifier;
    } 
}

internal HL7V26Field _reportDate;

public HL7V26Field ReportDate
{
    get
    {
        if (_reportDate != null)
        {
            return _reportDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSH.3",
            Type = @"Field",
            Position = @"PSH.3",
            Name = @"Report Date",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date as assigned by the sender.",
            Sample = @"",
            Fields = null
        }

        _reportDate = new HL7V26Field
        {
            field = message[@"PSH"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportDate.field.FieldRepetitions != null && _reportDate.field.FieldRepetitions.Count > 0)
        {
            _reportDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_reportDate, fieldData);
        }

        return _reportDate;
    } 
}

internal HL7V26Field _reportIntervalStartDate;

public HL7V26Field ReportIntervalStartDate
{
    get
    {
        if (_reportIntervalStartDate != null)
        {
            return _reportIntervalStartDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSH.4",
            Type = @"Field",
            Position = @"PSH.4",
            Name = @"Report Interval Start Date",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that marks the beginning of the time interval covered by the current report.",
            Sample = @"",
            Fields = null
        }

        _reportIntervalStartDate = new HL7V26Field
        {
            field = message[@"PSH"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportIntervalStartDate.field.FieldRepetitions != null && _reportIntervalStartDate.field.FieldRepetitions.Count > 0)
        {
            _reportIntervalStartDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_reportIntervalStartDate, fieldData);
        }

        return _reportIntervalStartDate;
    } 
}

internal HL7V26Field _reportIntervalEndDate;

public HL7V26Field ReportIntervalEndDate
{
    get
    {
        if (_reportIntervalEndDate != null)
        {
            return _reportIntervalEndDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSH.5",
            Type = @"Field",
            Position = @"PSH.5",
            Name = @"Report Interval End Date",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date which marks the inclusive end of the time interval covered by the current report.",
            Sample = @"",
            Fields = null
        }

        _reportIntervalEndDate = new HL7V26Field
        {
            field = message[@"PSH"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportIntervalEndDate.field.FieldRepetitions != null && _reportIntervalEndDate.field.FieldRepetitions.Count > 0)
        {
            _reportIntervalEndDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_reportIntervalEndDate, fieldData);
        }

        return _reportIntervalEndDate;
    } 
}

internal HL7V26Field _quantityManufactured;

public HL7V26Field QuantityManufactured
{
    get
    {
        if (_quantityManufactured != null)
        {
            return _quantityManufactured;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSH.6",
            Type = @"Field",
            Position = @"PSH.6",
            Name = @"Quantity Manufactured",
            Length = 722,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field is used to send the number of units of the product manufactured during the reporting interval. The second component can be used to specify the units for the quantity.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PSH.6.1",
                            Type = @"Component",
                            Position = @"PSH.6.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.6.2",
                            Type = @"Component",
                            Position = @"PSH.6.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSH.6.2.1",
                            Type = @"SubComponent",
                            Position = @"PSH.6.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.6.2.2",
                            Type = @"SubComponent",
                            Position = @"PSH.6.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.6.2.3",
                            Type = @"SubComponent",
                            Position = @"PSH.6.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.6.2.4",
                            Type = @"SubComponent",
                            Position = @"PSH.6.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.6.2.5",
                            Type = @"SubComponent",
                            Position = @"PSH.6.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.6.2.6",
                            Type = @"SubComponent",
                            Position = @"PSH.6.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.6.2.7",
                            Type = @"SubComponent",
                            Position = @"PSH.6.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.6.2.8",
                            Type = @"SubComponent",
                            Position = @"PSH.6.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.6.2.9",
                            Type = @"SubComponent",
                            Position = @"PSH.6.2.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _quantityManufactured = new HL7V26Field
        {
            field = message[@"PSH"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityManufactured.field.FieldRepetitions != null && _quantityManufactured.field.FieldRepetitions.Count > 0)
        {
            _quantityManufactured.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_quantityManufactured, fieldData);
        }

        return _quantityManufactured;
    } 
}

internal HL7V26Field _quantityDistributed;

public HL7V26Field QuantityDistributed
{
    get
    {
        if (_quantityDistributed != null)
        {
            return _quantityDistributed;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSH.7",
            Type = @"Field",
            Position = @"PSH.7",
            Name = @"Quantity Distributed",
            Length = 722,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field is used to send the number of units of the product which was distributed during the reporting interval. The second component can be used to specify the units for the quantity.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PSH.7.1",
                            Type = @"Component",
                            Position = @"PSH.7.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.7.2",
                            Type = @"Component",
                            Position = @"PSH.7.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSH.7.2.1",
                            Type = @"SubComponent",
                            Position = @"PSH.7.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.7.2.2",
                            Type = @"SubComponent",
                            Position = @"PSH.7.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.7.2.3",
                            Type = @"SubComponent",
                            Position = @"PSH.7.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.7.2.4",
                            Type = @"SubComponent",
                            Position = @"PSH.7.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.7.2.5",
                            Type = @"SubComponent",
                            Position = @"PSH.7.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.7.2.6",
                            Type = @"SubComponent",
                            Position = @"PSH.7.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.7.2.7",
                            Type = @"SubComponent",
                            Position = @"PSH.7.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.7.2.8",
                            Type = @"SubComponent",
                            Position = @"PSH.7.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.7.2.9",
                            Type = @"SubComponent",
                            Position = @"PSH.7.2.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _quantityDistributed = new HL7V26Field
        {
            field = message[@"PSH"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityDistributed.field.FieldRepetitions != null && _quantityDistributed.field.FieldRepetitions.Count > 0)
        {
            _quantityDistributed.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_quantityDistributed, fieldData);
        }

        return _quantityDistributed;
    } 
}

internal HL7V26Field _quantityDistributedMethod;

public HL7V26Field QuantityDistributedMethod
{
    get
    {
        if (_quantityDistributedMethod != null)
        {
            return _quantityDistributedMethod;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"This field is used for measuring the quantity distributed. An explanation of the method used for estimation can be included in PSH-9-quantity distributed comment. Refer to HL7 Table 0329 - Quantity method for valid values.",
            Sample = @"",
            Fields = null
        }

        _quantityDistributedMethod = new HL7V26Field
        {
            field = message[@"PSH"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityDistributedMethod.field.FieldRepetitions != null && _quantityDistributedMethod.field.FieldRepetitions.Count > 0)
        {
            _quantityDistributedMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_quantityDistributedMethod, fieldData);
        }

        return _quantityDistributedMethod;
    } 
}

internal HL7V26Field _quantityDistributedComment;

public HL7V26Field QuantityDistributedComment
{
    get
    {
        if (_quantityDistributedComment != null)
        {
            return _quantityDistributedComment;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _quantityDistributedComment = new HL7V26Field
        {
            field = message[@"PSH"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityDistributedComment.field.FieldRepetitions != null && _quantityDistributedComment.field.FieldRepetitions.Count > 0)
        {
            _quantityDistributedComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_quantityDistributedComment, fieldData);
        }

        return _quantityDistributedComment;
    } 
}

internal HL7V26Field _quantityinUse;

public HL7V26Field QuantityinUse
{
    get
    {
        if (_quantityinUse != null)
        {
            return _quantityinUse;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSH.10",
            Type = @"Field",
            Position = @"PSH.10",
            Name = @"Quantity in Use",
            Length = 722,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field is used to send the number of units of the product which were in use during the reporting interval. The second component can be used to specify the units for the quantity.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PSH.10.1",
                            Type = @"Component",
                            Position = @"PSH.10.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.10.2",
                            Type = @"Component",
                            Position = @"PSH.10.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PSH.10.2.1",
                            Type = @"SubComponent",
                            Position = @"PSH.10.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.10.2.2",
                            Type = @"SubComponent",
                            Position = @"PSH.10.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.10.2.3",
                            Type = @"SubComponent",
                            Position = @"PSH.10.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.10.2.4",
                            Type = @"SubComponent",
                            Position = @"PSH.10.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.10.2.5",
                            Type = @"SubComponent",
                            Position = @"PSH.10.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.10.2.6",
                            Type = @"SubComponent",
                            Position = @"PSH.10.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.10.2.7",
                            Type = @"SubComponent",
                            Position = @"PSH.10.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.10.2.8",
                            Type = @"SubComponent",
                            Position = @"PSH.10.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.10.2.9",
                            Type = @"SubComponent",
                            Position = @"PSH.10.2.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _quantityinUse = new HL7V26Field
        {
            field = message[@"PSH"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityinUse.field.FieldRepetitions != null && _quantityinUse.field.FieldRepetitions.Count > 0)
        {
            _quantityinUse.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_quantityinUse, fieldData);
        }

        return _quantityinUse;
    } 
}

internal HL7V26Field _quantityinUseMethod;

public HL7V26Field QuantityinUseMethod
{
    get
    {
        if (_quantityinUseMethod != null)
        {
            return _quantityinUseMethod;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"This field contains the method used for measuring the quantity in use. An explanation of the method used for estimation can be included in PSH-12-quantity in use comment . Refer to HL7 Table 0329 - Quantity method for valid values.",
            Sample = @"",
            Fields = null
        }

        _quantityinUseMethod = new HL7V26Field
        {
            field = message[@"PSH"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityinUseMethod.field.FieldRepetitions != null && _quantityinUseMethod.field.FieldRepetitions.Count > 0)
        {
            _quantityinUseMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_quantityinUseMethod, fieldData);
        }

        return _quantityinUseMethod;
    } 
}

internal HL7V26Field _quantityinUseComment;

public HL7V26Field QuantityinUseComment
{
    get
    {
        if (_quantityinUseComment != null)
        {
            return _quantityinUseComment;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _quantityinUseComment = new HL7V26Field
        {
            field = message[@"PSH"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityinUseComment.field.FieldRepetitions != null && _quantityinUseComment.field.FieldRepetitions.Count > 0)
        {
            _quantityinUseComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_quantityinUseComment, fieldData);
        }

        return _quantityinUseComment;
    } 
}

internal HL7V26Field _numberofProductExperienceReportsFiledbyFacility;

public HL7V26Field NumberofProductExperienceReportsFiledbyFacility
{
    get
    {
        if (_numberofProductExperienceReportsFiledbyFacility != null)
        {
            return _numberofProductExperienceReportsFiledbyFacility;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSH.13",
            Type = @"Field",
            Position = @"PSH.13",
            Name = @"Number of Product Experience Reports Filed by Facility",
            Length = 16,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"The field contains the number of product experience reports filed by facility.",
            Sample = @"",
            Fields = null
        }

        _numberofProductExperienceReportsFiledbyFacility = new HL7V26Field
        {
            field = message[@"PSH"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberofProductExperienceReportsFiledbyFacility.field.FieldRepetitions != null && _numberofProductExperienceReportsFiledbyFacility.field.FieldRepetitions.Count > 0)
        {
            _numberofProductExperienceReportsFiledbyFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_numberofProductExperienceReportsFiledbyFacility, fieldData);
        }

        return _numberofProductExperienceReportsFiledbyFacility;
    } 
}

internal HL7V26Field _numberofProductExperienceReportsFiledbyDistributor;

public HL7V26Field NumberofProductExperienceReportsFiledbyDistributor
{
    get
    {
        if (_numberofProductExperienceReportsFiledbyDistributor != null)
        {
            return _numberofProductExperienceReportsFiledbyDistributor;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"PSH.14",
            Type = @"Field",
            Position = @"PSH.14",
            Name = @"Number of Product Experience Reports Filed by Distributor",
            Length = 16,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of product experience reports filed by distributor.",
            Sample = @"",
            Fields = null
        }

        _numberofProductExperienceReportsFiledbyDistributor = new HL7V26Field
        {
            field = message[@"PSH"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberofProductExperienceReportsFiledbyDistributor.field.FieldRepetitions != null && _numberofProductExperienceReportsFiledbyDistributor.field.FieldRepetitions.Count > 0)
        {
            _numberofProductExperienceReportsFiledbyDistributor.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_numberofProductExperienceReportsFiledbyDistributor, fieldData);
        }

        return _numberofProductExperienceReportsFiledbyDistributor;
    } 
}
    }
}
