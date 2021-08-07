using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentPSH
    {
        public readonly HL7V2Message message;

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
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PSH.3.1",
                            Type = @"Component",
                            Position = @"PSH.3.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.3.2",
                            Type = @"Component",
                            Position = @"PSH.3.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
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
                            Description = @"This field contains the date that marks the beginning of the time interval covered by the current report.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PSH.4.1",
                            Type = @"Component",
                            Position = @"PSH.4.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.4.2",
                            Type = @"Component",
                            Position = @"PSH.4.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
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
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PSH.5.1",
                            Type = @"Component",
                            Position = @"PSH.5.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PSH.5.2",
                            Type = @"Component",
                            Position = @"PSH.5.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
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
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to send the number of units of the product manufactured during the reporting interval. The second component can be used to specify the units for the quantity.",
                            Sample = @"",
                            FieldDatas = 
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
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
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
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to send the number of units of the product which was distributed during the reporting interval. The second component can be used to specify the units for the quantity.",
                            Sample = @"",
                            FieldDatas = 
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
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
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
                            Description = @"This field is used for measuring the quantity distributed. An explanation of the method used for estimation can be included in PSH-9-quantity distributed comment. Refer to HL7 Table 0329 - Quantity method for valid values.",
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
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to send the number of units of the product which were in use during the reporting interval. The second component can be used to specify the units for the quantity.",
                            Sample = @"",
                            FieldDatas = 
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
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
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
                            Description = @"This field contains the method used for measuring the quantity in use. An explanation of the method used for estimation can be included in PSH-12-quantity in use comment . Refer to HL7 Table 0329 - Quantity method for valid values.",
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

        public HL7V251SegmentPSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field reportType;

public HL7V251Field ReportType
{
    get
    {
        if (reportType != null)
        {
            return reportType;
        }

        reportType = new HL7V251Field
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

        

        

        

        return reportType;
    } 
}
internal HL7V251Field reportFormIdentifier;

public HL7V251Field ReportFormIdentifier
{
    get
    {
        if (reportFormIdentifier != null)
        {
            return reportFormIdentifier;
        }

        reportFormIdentifier = new HL7V251Field
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

        

        

        

        return reportFormIdentifier;
    } 
}
internal HL7V251Field reportDate;

public HL7V251Field ReportDate
{
    get
    {
        if (reportDate != null)
        {
            return reportDate;
        }

        reportDate = new HL7V251Field
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

        

        

        

        return reportDate;
    } 
}
internal HL7V251Field reportIntervalStartDate;

public HL7V251Field ReportIntervalStartDate
{
    get
    {
        if (reportIntervalStartDate != null)
        {
            return reportIntervalStartDate;
        }

        reportIntervalStartDate = new HL7V251Field
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
            Description = @"This field contains the date that marks the beginning of the time interval covered by the current report.",
            Sample = @"",
        };

        

        

        

        return reportIntervalStartDate;
    } 
}
internal HL7V251Field reportIntervalEndDate;

public HL7V251Field ReportIntervalEndDate
{
    get
    {
        if (reportIntervalEndDate != null)
        {
            return reportIntervalEndDate;
        }

        reportIntervalEndDate = new HL7V251Field
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

        

        

        

        return reportIntervalEndDate;
    } 
}
internal HL7V251Field quantityManufactured;

public HL7V251Field QuantityManufactured
{
    get
    {
        if (quantityManufactured != null)
        {
            return quantityManufactured;
        }

        quantityManufactured = new HL7V251Field
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
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field is used to send the number of units of the product manufactured during the reporting interval. The second component can be used to specify the units for the quantity.",
            Sample = @"",
        };

        

        

        

        return quantityManufactured;
    } 
}
internal HL7V251Field quantityDistributed;

public HL7V251Field QuantityDistributed
{
    get
    {
        if (quantityDistributed != null)
        {
            return quantityDistributed;
        }

        quantityDistributed = new HL7V251Field
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
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field is used to send the number of units of the product which was distributed during the reporting interval. The second component can be used to specify the units for the quantity.",
            Sample = @"",
        };

        

        

        

        return quantityDistributed;
    } 
}
internal HL7V251Field quantityDistributedMethod;

public HL7V251Field QuantityDistributedMethod
{
    get
    {
        if (quantityDistributedMethod != null)
        {
            return quantityDistributedMethod;
        }

        quantityDistributedMethod = new HL7V251Field
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
            Description = @"This field is used for measuring the quantity distributed. An explanation of the method used for estimation can be included in PSH-9-quantity distributed comment. Refer to HL7 Table 0329 - Quantity method for valid values.",
            Sample = @"",
        };

        

        

        

        return quantityDistributedMethod;
    } 
}
internal HL7V251Field quantityDistributedComment;

public HL7V251Field QuantityDistributedComment
{
    get
    {
        if (quantityDistributedComment != null)
        {
            return quantityDistributedComment;
        }

        quantityDistributedComment = new HL7V251Field
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

        

        

        

        return quantityDistributedComment;
    } 
}
internal HL7V251Field quantityinUse;

public HL7V251Field QuantityinUse
{
    get
    {
        if (quantityinUse != null)
        {
            return quantityinUse;
        }

        quantityinUse = new HL7V251Field
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
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field is used to send the number of units of the product which were in use during the reporting interval. The second component can be used to specify the units for the quantity.",
            Sample = @"",
        };

        

        

        

        return quantityinUse;
    } 
}
internal HL7V251Field quantityinUseMethod;

public HL7V251Field QuantityinUseMethod
{
    get
    {
        if (quantityinUseMethod != null)
        {
            return quantityinUseMethod;
        }

        quantityinUseMethod = new HL7V251Field
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
            Description = @"This field contains the method used for measuring the quantity in use. An explanation of the method used for estimation can be included in PSH-12-quantity in use comment . Refer to HL7 Table 0329 - Quantity method for valid values.",
            Sample = @"",
        };

        

        

        

        return quantityinUseMethod;
    } 
}
internal HL7V251Field quantityinUseComment;

public HL7V251Field QuantityinUseComment
{
    get
    {
        if (quantityinUseComment != null)
        {
            return quantityinUseComment;
        }

        quantityinUseComment = new HL7V251Field
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

        

        

        

        return quantityinUseComment;
    } 
}
internal HL7V251Field numberofProductExperienceReportsFiledbyFacility;

public HL7V251Field NumberofProductExperienceReportsFiledbyFacility
{
    get
    {
        if (numberofProductExperienceReportsFiledbyFacility != null)
        {
            return numberofProductExperienceReportsFiledbyFacility;
        }

        numberofProductExperienceReportsFiledbyFacility = new HL7V251Field
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

        

        

        

        return numberofProductExperienceReportsFiledbyFacility;
    } 
}
internal HL7V251Field numberofProductExperienceReportsFiledbyDistributor;

public HL7V251Field NumberofProductExperienceReportsFiledbyDistributor
{
    get
    {
        if (numberofProductExperienceReportsFiledbyDistributor != null)
        {
            return numberofProductExperienceReportsFiledbyDistributor;
        }

        numberofProductExperienceReportsFiledbyDistributor = new HL7V251Field
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

        

        

        

        return numberofProductExperienceReportsFiledbyDistributor;
    } 
}

    }
}
