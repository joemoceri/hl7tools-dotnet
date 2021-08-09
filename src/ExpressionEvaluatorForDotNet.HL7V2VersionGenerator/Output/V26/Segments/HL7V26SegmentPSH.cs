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
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date as assigned by the sender.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                            Length = 722,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
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
                            Length = 16,
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
                            Length = 16,
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

        public HL7V26SegmentPSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field reportType;

public HL7V26Field ReportType
{
    get
    {
        if (reportType != null)
        {
            return reportType;
        }

        reportType = new HL7V26Field
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
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < reportType.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = reportType.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < reportType.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = reportType.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < reportType.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = reportType.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            reportType.fieldRepetitions = fieldRepetitions;
        }

        return reportType;
    } 
}

internal HL7V26Field reportFormIdentifier;

public HL7V26Field ReportFormIdentifier
{
    get
    {
        if (reportFormIdentifier != null)
        {
            return reportFormIdentifier;
        }

        reportFormIdentifier = new HL7V26Field
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
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < reportFormIdentifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = reportFormIdentifier.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < reportFormIdentifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = reportFormIdentifier.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < reportFormIdentifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = reportFormIdentifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            reportFormIdentifier.fieldRepetitions = fieldRepetitions;
        }

        return reportFormIdentifier;
    } 
}

internal HL7V26Field reportDate;

public HL7V26Field ReportDate
{
    get
    {
        if (reportDate != null)
        {
            return reportDate;
        }

        reportDate = new HL7V26Field
        {
            field = message[@"PSH"][3],
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
        };

        // check for repetitions
        if (reportDate.field.FieldRepetitions != null && reportDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(reportDate.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < reportDate.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = reportDate.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < reportDate.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = reportDate.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < reportDate.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = reportDate.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            reportDate.fieldRepetitions = fieldRepetitions;
        }

        return reportDate;
    } 
}

internal HL7V26Field reportIntervalStartDate;

public HL7V26Field ReportIntervalStartDate
{
    get
    {
        if (reportIntervalStartDate != null)
        {
            return reportIntervalStartDate;
        }

        reportIntervalStartDate = new HL7V26Field
        {
            field = message[@"PSH"][4],
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
        };

        // check for repetitions
        if (reportIntervalStartDate.field.FieldRepetitions != null && reportIntervalStartDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(reportIntervalStartDate.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < reportIntervalStartDate.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = reportIntervalStartDate.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < reportIntervalStartDate.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = reportIntervalStartDate.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < reportIntervalStartDate.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = reportIntervalStartDate.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            reportIntervalStartDate.fieldRepetitions = fieldRepetitions;
        }

        return reportIntervalStartDate;
    } 
}

internal HL7V26Field reportIntervalEndDate;

public HL7V26Field ReportIntervalEndDate
{
    get
    {
        if (reportIntervalEndDate != null)
        {
            return reportIntervalEndDate;
        }

        reportIntervalEndDate = new HL7V26Field
        {
            field = message[@"PSH"][5],
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
        };

        // check for repetitions
        if (reportIntervalEndDate.field.FieldRepetitions != null && reportIntervalEndDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(reportIntervalEndDate.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < reportIntervalEndDate.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = reportIntervalEndDate.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < reportIntervalEndDate.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = reportIntervalEndDate.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < reportIntervalEndDate.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = reportIntervalEndDate.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            reportIntervalEndDate.fieldRepetitions = fieldRepetitions;
        }

        return reportIntervalEndDate;
    } 
}

internal HL7V26Field quantityManufactured;

public HL7V26Field QuantityManufactured
{
    get
    {
        if (quantityManufactured != null)
        {
            return quantityManufactured;
        }

        quantityManufactured = new HL7V26Field
        {
            field = message[@"PSH"][6],
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
        };

        // check for repetitions
        if (quantityManufactured.field.FieldRepetitions != null && quantityManufactured.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityManufactured.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < quantityManufactured.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = quantityManufactured.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < quantityManufactured.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = quantityManufactured.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < quantityManufactured.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = quantityManufactured.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            quantityManufactured.fieldRepetitions = fieldRepetitions;
        }

        return quantityManufactured;
    } 
}

internal HL7V26Field quantityDistributed;

public HL7V26Field QuantityDistributed
{
    get
    {
        if (quantityDistributed != null)
        {
            return quantityDistributed;
        }

        quantityDistributed = new HL7V26Field
        {
            field = message[@"PSH"][7],
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
        };

        // check for repetitions
        if (quantityDistributed.field.FieldRepetitions != null && quantityDistributed.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityDistributed.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < quantityDistributed.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = quantityDistributed.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < quantityDistributed.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = quantityDistributed.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < quantityDistributed.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = quantityDistributed.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            quantityDistributed.fieldRepetitions = fieldRepetitions;
        }

        return quantityDistributed;
    } 
}

internal HL7V26Field quantityDistributedMethod;

public HL7V26Field QuantityDistributedMethod
{
    get
    {
        if (quantityDistributedMethod != null)
        {
            return quantityDistributedMethod;
        }

        quantityDistributedMethod = new HL7V26Field
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

        // check for repetitions
        if (quantityDistributedMethod.field.FieldRepetitions != null && quantityDistributedMethod.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityDistributedMethod.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < quantityDistributedMethod.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = quantityDistributedMethod.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < quantityDistributedMethod.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = quantityDistributedMethod.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < quantityDistributedMethod.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = quantityDistributedMethod.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            quantityDistributedMethod.fieldRepetitions = fieldRepetitions;
        }

        return quantityDistributedMethod;
    } 
}

internal HL7V26Field quantityDistributedComment;

public HL7V26Field QuantityDistributedComment
{
    get
    {
        if (quantityDistributedComment != null)
        {
            return quantityDistributedComment;
        }

        quantityDistributedComment = new HL7V26Field
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
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < quantityDistributedComment.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = quantityDistributedComment.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < quantityDistributedComment.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = quantityDistributedComment.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < quantityDistributedComment.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = quantityDistributedComment.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            quantityDistributedComment.fieldRepetitions = fieldRepetitions;
        }

        return quantityDistributedComment;
    } 
}

internal HL7V26Field quantityinUse;

public HL7V26Field QuantityinUse
{
    get
    {
        if (quantityinUse != null)
        {
            return quantityinUse;
        }

        quantityinUse = new HL7V26Field
        {
            field = message[@"PSH"][10],
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
        };

        // check for repetitions
        if (quantityinUse.field.FieldRepetitions != null && quantityinUse.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityinUse.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < quantityinUse.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = quantityinUse.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < quantityinUse.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = quantityinUse.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < quantityinUse.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = quantityinUse.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            quantityinUse.fieldRepetitions = fieldRepetitions;
        }

        return quantityinUse;
    } 
}

internal HL7V26Field quantityinUseMethod;

public HL7V26Field QuantityinUseMethod
{
    get
    {
        if (quantityinUseMethod != null)
        {
            return quantityinUseMethod;
        }

        quantityinUseMethod = new HL7V26Field
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

        // check for repetitions
        if (quantityinUseMethod.field.FieldRepetitions != null && quantityinUseMethod.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityinUseMethod.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < quantityinUseMethod.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = quantityinUseMethod.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < quantityinUseMethod.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = quantityinUseMethod.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < quantityinUseMethod.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = quantityinUseMethod.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            quantityinUseMethod.fieldRepetitions = fieldRepetitions;
        }

        return quantityinUseMethod;
    } 
}

internal HL7V26Field quantityinUseComment;

public HL7V26Field QuantityinUseComment
{
    get
    {
        if (quantityinUseComment != null)
        {
            return quantityinUseComment;
        }

        quantityinUseComment = new HL7V26Field
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
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < quantityinUseComment.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = quantityinUseComment.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < quantityinUseComment.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = quantityinUseComment.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < quantityinUseComment.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = quantityinUseComment.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            quantityinUseComment.fieldRepetitions = fieldRepetitions;
        }

        return quantityinUseComment;
    } 
}

internal HL7V26Field numberofProductExperienceReportsFiledbyFacility;

public HL7V26Field NumberofProductExperienceReportsFiledbyFacility
{
    get
    {
        if (numberofProductExperienceReportsFiledbyFacility != null)
        {
            return numberofProductExperienceReportsFiledbyFacility;
        }

        numberofProductExperienceReportsFiledbyFacility = new HL7V26Field
        {
            field = message[@"PSH"][13],
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
        };

        // check for repetitions
        if (numberofProductExperienceReportsFiledbyFacility.field.FieldRepetitions != null && numberofProductExperienceReportsFiledbyFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberofProductExperienceReportsFiledbyFacility.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < numberofProductExperienceReportsFiledbyFacility.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = numberofProductExperienceReportsFiledbyFacility.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < numberofProductExperienceReportsFiledbyFacility.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = numberofProductExperienceReportsFiledbyFacility.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < numberofProductExperienceReportsFiledbyFacility.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = numberofProductExperienceReportsFiledbyFacility.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            numberofProductExperienceReportsFiledbyFacility.fieldRepetitions = fieldRepetitions;
        }

        return numberofProductExperienceReportsFiledbyFacility;
    } 
}

internal HL7V26Field numberofProductExperienceReportsFiledbyDistributor;

public HL7V26Field NumberofProductExperienceReportsFiledbyDistributor
{
    get
    {
        if (numberofProductExperienceReportsFiledbyDistributor != null)
        {
            return numberofProductExperienceReportsFiledbyDistributor;
        }

        numberofProductExperienceReportsFiledbyDistributor = new HL7V26Field
        {
            field = message[@"PSH"][14],
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
        };

        // check for repetitions
        if (numberofProductExperienceReportsFiledbyDistributor.field.FieldRepetitions != null && numberofProductExperienceReportsFiledbyDistributor.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberofProductExperienceReportsFiledbyDistributor.Id));
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < numberofProductExperienceReportsFiledbyDistributor.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = numberofProductExperienceReportsFiledbyDistributor.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < numberofProductExperienceReportsFiledbyDistributor.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V26Component
                        {
                            component = numberofProductExperienceReportsFiledbyDistributor.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < numberofProductExperienceReportsFiledbyDistributor.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = numberofProductExperienceReportsFiledbyDistributor.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            numberofProductExperienceReportsFiledbyDistributor.fieldRepetitions = fieldRepetitions;
        }

        return numberofProductExperienceReportsFiledbyDistributor;
    } 
}
    }
}
