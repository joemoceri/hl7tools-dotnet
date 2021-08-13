using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentAPR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"APR"; } }

        public string SegmentId { get { return @"APR"; } }
        
        public string LongName { get { return @"Appointment Preferences"; } }
        
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

        public HL7V26SegmentAPR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _timeSelectionCriteria;

public HL7V26Field TimeSelectionCriteria
{
    get
    {
        if (_timeSelectionCriteria != null)
        {
            return _timeSelectionCriteria;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"APR.1.1",
                            Type = @"Component",
                            Position = @"APR.1.1",
                            Name = @"Parameter Class",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application. Refer to User-defined Table 0294 - Time selection criteria parameter class codes for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"APR.1.1.1",
                            Type = @"SubComponent",
                            Position = @"APR.1.1.1",
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
                            Id = @"APR.1.1.2",
                            Type = @"SubComponent",
                            Position = @"APR.1.1.2",
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
                            Id = @"APR.1.1.3",
                            Type = @"SubComponent",
                            Position = @"APR.1.1.3",
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
                            Id = @"APR.1.1.4",
                            Type = @"SubComponent",
                            Position = @"APR.1.1.4",
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
                            Id = @"APR.1.1.5",
                            Type = @"SubComponent",
                            Position = @"APR.1.1.5",
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
                            Id = @"APR.1.1.6",
                            Type = @"SubComponent",
                            Position = @"APR.1.1.6",
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
                            Id = @"APR.1.1.7",
                            Type = @"SubComponent",
                            Position = @"APR.1.1.7",
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
                            Id = @"APR.1.1.8",
                            Type = @"SubComponent",
                            Position = @"APR.1.1.8",
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
                            Id = @"APR.1.1.9",
                            Type = @"SubComponent",
                            Position = @"APR.1.1.9",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.1.2",
                            Type = @"Component",
                            Position = @"APR.1.2",
                            Name = @"Parameter Value",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _timeSelectionCriteria = new HL7V26Field
        {
            field = message[@"APR"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_timeSelectionCriteria.field.FieldRepetitions != null && _timeSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            _timeSelectionCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_timeSelectionCriteria, fieldData);
        }

        return _timeSelectionCriteria;
    } 
}

internal HL7V26Field _resourceSelectionCriteria;

public HL7V26Field ResourceSelectionCriteria
{
    get
    {
        if (_resourceSelectionCriteria != null)
        {
            return _resourceSelectionCriteria;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"APR.2.1",
                            Type = @"Component",
                            Position = @"APR.2.1",
                            Name = @"Parameter Class",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application. Refer to User-defined Table 0294 - Time selection criteria parameter class codes for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"APR.2.1.1",
                            Type = @"SubComponent",
                            Position = @"APR.2.1.1",
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
                            Id = @"APR.2.1.2",
                            Type = @"SubComponent",
                            Position = @"APR.2.1.2",
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
                            Id = @"APR.2.1.3",
                            Type = @"SubComponent",
                            Position = @"APR.2.1.3",
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
                            Id = @"APR.2.1.4",
                            Type = @"SubComponent",
                            Position = @"APR.2.1.4",
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
                            Id = @"APR.2.1.5",
                            Type = @"SubComponent",
                            Position = @"APR.2.1.5",
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
                            Id = @"APR.2.1.6",
                            Type = @"SubComponent",
                            Position = @"APR.2.1.6",
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
                            Id = @"APR.2.1.7",
                            Type = @"SubComponent",
                            Position = @"APR.2.1.7",
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
                            Id = @"APR.2.1.8",
                            Type = @"SubComponent",
                            Position = @"APR.2.1.8",
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
                            Id = @"APR.2.1.9",
                            Type = @"SubComponent",
                            Position = @"APR.2.1.9",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.2.2",
                            Type = @"Component",
                            Position = @"APR.2.2",
                            Name = @"Parameter Value",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _resourceSelectionCriteria = new HL7V26Field
        {
            field = message[@"APR"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resourceSelectionCriteria.field.FieldRepetitions != null && _resourceSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            _resourceSelectionCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_resourceSelectionCriteria, fieldData);
        }

        return _resourceSelectionCriteria;
    } 
}

internal HL7V26Field _locationSelectionCriteria;

public HL7V26Field LocationSelectionCriteria
{
    get
    {
        if (_locationSelectionCriteria != null)
        {
            return _locationSelectionCriteria;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"APR.3.1",
                            Type = @"Component",
                            Position = @"APR.3.1",
                            Name = @"Parameter Class",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application. Refer to User-defined Table 0294 - Time selection criteria parameter class codes for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"APR.3.1.1",
                            Type = @"SubComponent",
                            Position = @"APR.3.1.1",
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
                            Id = @"APR.3.1.2",
                            Type = @"SubComponent",
                            Position = @"APR.3.1.2",
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
                            Id = @"APR.3.1.3",
                            Type = @"SubComponent",
                            Position = @"APR.3.1.3",
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
                            Id = @"APR.3.1.4",
                            Type = @"SubComponent",
                            Position = @"APR.3.1.4",
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
                            Id = @"APR.3.1.5",
                            Type = @"SubComponent",
                            Position = @"APR.3.1.5",
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
                            Id = @"APR.3.1.6",
                            Type = @"SubComponent",
                            Position = @"APR.3.1.6",
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
                            Id = @"APR.3.1.7",
                            Type = @"SubComponent",
                            Position = @"APR.3.1.7",
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
                            Id = @"APR.3.1.8",
                            Type = @"SubComponent",
                            Position = @"APR.3.1.8",
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
                            Id = @"APR.3.1.9",
                            Type = @"SubComponent",
                            Position = @"APR.3.1.9",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.3.2",
                            Type = @"Component",
                            Position = @"APR.3.2",
                            Name = @"Parameter Value",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _locationSelectionCriteria = new HL7V26Field
        {
            field = message[@"APR"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_locationSelectionCriteria.field.FieldRepetitions != null && _locationSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            _locationSelectionCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_locationSelectionCriteria, fieldData);
        }

        return _locationSelectionCriteria;
    } 
}

internal HL7V26Field _slotSpacingCriteria;

public HL7V26Field SlotSpacingCriteria
{
    get
    {
        if (_slotSpacingCriteria != null)
        {
            return _slotSpacingCriteria;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = null
        }

        _slotSpacingCriteria = new HL7V26Field
        {
            field = message[@"APR"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_slotSpacingCriteria.field.FieldRepetitions != null && _slotSpacingCriteria.field.FieldRepetitions.Count > 0)
        {
            _slotSpacingCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_slotSpacingCriteria, fieldData);
        }

        return _slotSpacingCriteria;
    } 
}

internal HL7V26Field _fillerOverrideCriteria;

public HL7V26Field FillerOverrideCriteria
{
    get
    {
        if (_fillerOverrideCriteria != null)
        {
            return _fillerOverrideCriteria;
        }

        var fieldData = new HL7V26FieldData
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
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"APR.5.1",
                            Type = @"Component",
                            Position = @"APR.5.1",
                            Name = @"Parameter Class",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application. Refer to User-defined Table 0294 - Time selection criteria parameter class codes for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"APR.5.1.1",
                            Type = @"SubComponent",
                            Position = @"APR.5.1.1",
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
                            Id = @"APR.5.1.2",
                            Type = @"SubComponent",
                            Position = @"APR.5.1.2",
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
                            Id = @"APR.5.1.3",
                            Type = @"SubComponent",
                            Position = @"APR.5.1.3",
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
                            Id = @"APR.5.1.4",
                            Type = @"SubComponent",
                            Position = @"APR.5.1.4",
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
                            Id = @"APR.5.1.5",
                            Type = @"SubComponent",
                            Position = @"APR.5.1.5",
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
                            Id = @"APR.5.1.6",
                            Type = @"SubComponent",
                            Position = @"APR.5.1.6",
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
                            Id = @"APR.5.1.7",
                            Type = @"SubComponent",
                            Position = @"APR.5.1.7",
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
                            Id = @"APR.5.1.8",
                            Type = @"SubComponent",
                            Position = @"APR.5.1.8",
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
                            Id = @"APR.5.1.9",
                            Type = @"SubComponent",
                            Position = @"APR.5.1.9",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.5.2",
                            Type = @"Component",
                            Position = @"APR.5.2",
                            Name = @"Parameter Value",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fillerOverrideCriteria = new HL7V26Field
        {
            field = message[@"APR"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerOverrideCriteria.field.FieldRepetitions != null && _fillerOverrideCriteria.field.FieldRepetitions.Count > 0)
        {
            _fillerOverrideCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_fillerOverrideCriteria, fieldData);
        }

        return _fillerOverrideCriteria;
    } 
}
    }
}
