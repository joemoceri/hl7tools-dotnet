using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentTQ2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"TQ2"; } }

        public string SegmentId { get { return @"TQ2"; } }
        
        public string LongName { get { return @"Timing/Quantity Relationship"; } }
        
        public string Description { get { return @"The TQ2 segment is used to form a relationship between the service request the TQ1/TQ2 segments are associated with, and other service requests. The TQ2 segment will link the current service request with one or more other service requests."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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
                            Id = @"TQ2.1",
                            Type = @"Field",
                            Position = @"TQ2.1",
                            Name = @"Set ID - TQ2",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"For the first timing specification transmitted, the sequence number shall be 1; for the second timing specification, it shall be 2; and so on.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.2",
                            Type = @"Field",
                            Position = @"TQ2.2",
                            Name = @"Sequence/Results Flag",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0503",
                            TableName = @"Sequence/Results Flag",
                            Description = @"This flag defines the sequencing relationship between the current service request, and the related service request(s) specified in this TQ2 segment. See HL7 Table 0503 - Sequence/Results Flag for values. If not value is present, the S - Sequential is the default value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.3",
                            Type = @"Field",
                            Position = @"TQ2.3",
                            Name = @"Related Placer Number",
                            Length = 22,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"The placer numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Placer number"" from the current service request. For orders, the Placer Order Number from ORC-2 is the appropriate ""Placer number"". Repeats of this field indicate the current service request is related to multiple service requests.

At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ2.3.1",
                            Type = @"Component",
                            Position = @"TQ2.3.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.3.2",
                            Type = @"Component",
                            Position = @"TQ2.3.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.3.3",
                            Type = @"Component",
                            Position = @"TQ2.3.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"TQ2.3.4",
                            Type = @"Component",
                            Position = @"TQ2.3.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.4",
                            Type = @"Field",
                            Position = @"TQ2.4",
                            Name = @"Related Filler Number",
                            Length = 22,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"The filler numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Filler number"" from the current service request. For orders, the Filler Order Number from ORC-3 is the appropriate ""Filler number"". Repeats of this field indicate the current service request is related to multiple service requests.

At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ2.4.1",
                            Type = @"Component",
                            Position = @"TQ2.4.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.4.2",
                            Type = @"Component",
                            Position = @"TQ2.4.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.4.3",
                            Type = @"Component",
                            Position = @"TQ2.4.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"TQ2.4.4",
                            Type = @"Component",
                            Position = @"TQ2.4.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.5",
                            Type = @"Field",
                            Position = @"TQ2.5",
                            Name = @"Related Placer Group Number",
                            Length = 22,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"The placer group numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Placer group number"" from the current service request. For orders, the Placer Group Number from ORC-4 is the appropriate ""Placer group number"". Repeats of this field indicate that the current service request is related to multiple groups of service requests.

At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ2.5.1",
                            Type = @"Component",
                            Position = @"TQ2.5.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.5.2",
                            Type = @"Component",
                            Position = @"TQ2.5.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.5.3",
                            Type = @"Component",
                            Position = @"TQ2.5.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"TQ2.5.4",
                            Type = @"Component",
                            Position = @"TQ2.5.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.6",
                            Type = @"Field",
                            Position = @"TQ2.6",
                            Name = @"Sequence Condition Code",
                            Length = 2,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0504",
                            TableName = @"Sequence Condition Code",
                            Description = @"Defines the relationship between the start/end of the related service request(s) (from TQ2-3, TQ2-4, or TQ2-5) and the current service request from ORC-2, 3 or 4. See HL7 Table 0504 - Sequence Condition Code for allowed values.

Either this field or TQ2-10 must be present.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.7",
                            Type = @"Field",
                            Position = @"TQ2.7",
                            Name = @"Cyclic Entry/Exit Indicator",
                            Length = 1,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0505",
                            TableName = @"Cyclic Entry/Exit Indicator",
                            Description = @"Indicates if this service request is the first, last, service request in a cyclic series of service requests. If null or not present, this field indicates that the current service request is neither the first or last service request in a cyclic series of service requests. Refer to HL7 Table 0505 - Cyclic Entry/Exit Indicator for allowed values.

Should not be populated when TQ2-2 (Sequence/Results Flag) is not equal to a 'C' (cyclic service request).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8",
                            Type = @"Field",
                            Position = @"TQ2.8",
                            Name = @"Sequence Condition Time Interval",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the interval of time between the start/end of the related service request(s) and the start/end of the current service request. The unit's component is constrained to units of time. If this field is not populated, then there should be no interruption between start/ending the current service request, and the related service request(s).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ2.8.1",
                            Type = @"Component",
                            Position = @"TQ2.8.1",
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
                            Id = @"TQ2.8.2",
                            Type = @"Component",
                            Position = @"TQ2.8.2",
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
                            Id = @"TQ2.8.2.1",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.1",
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
                            Id = @"TQ2.8.2.2",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.2",
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
                            Id = @"TQ2.8.2.3",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.3",
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
                            Id = @"TQ2.8.2.4",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.4",
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
                            Id = @"TQ2.8.2.5",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.5",
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
                            Id = @"TQ2.8.2.6",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.6",
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
                            Id = @"TQ2.8.2.7",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.7",
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
                            Id = @"TQ2.8.2.8",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.8",
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
                            Id = @"TQ2.8.2.9",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.9",
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
                            Id = @"TQ2.9",
                            Type = @"Field",
                            Position = @"TQ2.9",
                            Name = @"Cyclic Group Maximum Number of Repeats",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum number of repeats for a cyclic group.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.10",
                            Type = @"Field",
                            Position = @"TQ2.10",
                            Name = @"Special Service Request Relationship",
                            Length = 1,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0506",
                            TableName = @"Service Request Relationship",
                            Description = @"This defines an additional or alternate relationship between this service request and other service requests. Its primary intended use is for Pharmacy administration service requests, but it may be useful for other domains. See HL7 Table 0506 - Service Request Relationship for allowed values.

Either this field or TQ2-6 must be present.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentTQ2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field setIDTQ2;

public HL7V26Field SetIDTQ2
{
    get
    {
        if (setIDTQ2 != null)
        {
            return setIDTQ2;
        }

        setIDTQ2 = new HL7V26Field
        {
            field = message[@"TQ2"][1],
            Id = @"TQ2.1",
            Type = @"Field",
            Position = @"TQ2.1",
            Name = @"Set ID - TQ2",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"For the first timing specification transmitted, the sequence number shall be 1; for the second timing specification, it shall be 2; and so on.",
            Sample = @"",
        };

        // check for repetitions
        if (setIDTQ2.field.FieldRepetitions != null && setIDTQ2.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDTQ2.Id));
            setIDTQ2.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(setIDTQ2, fieldData);
        }

        return setIDTQ2;
    } 
}

internal HL7V26Field sequenceResultsFlag;

public HL7V26Field SequenceResultsFlag
{
    get
    {
        if (sequenceResultsFlag != null)
        {
            return sequenceResultsFlag;
        }

        sequenceResultsFlag = new HL7V26Field
        {
            field = message[@"TQ2"][2],
            Id = @"TQ2.2",
            Type = @"Field",
            Position = @"TQ2.2",
            Name = @"Sequence/Results Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0503",
            TableName = @"Sequence/Results Flag",
            Description = @"This flag defines the sequencing relationship between the current service request, and the related service request(s) specified in this TQ2 segment. See HL7 Table 0503 - Sequence/Results Flag for values. If not value is present, the S - Sequential is the default value.",
            Sample = @"",
        };

        // check for repetitions
        if (sequenceResultsFlag.field.FieldRepetitions != null && sequenceResultsFlag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceResultsFlag.Id));
            sequenceResultsFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(sequenceResultsFlag, fieldData);
        }

        return sequenceResultsFlag;
    } 
}

internal HL7V26Field relatedPlacerNumber;

public HL7V26Field RelatedPlacerNumber
{
    get
    {
        if (relatedPlacerNumber != null)
        {
            return relatedPlacerNumber;
        }

        relatedPlacerNumber = new HL7V26Field
        {
            field = message[@"TQ2"][3],
            Id = @"TQ2.3",
            Type = @"Field",
            Position = @"TQ2.3",
            Name = @"Related Placer Number",
            Length = 22,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The placer numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Placer number"" from the current service request. For orders, the Placer Order Number from ORC-2 is the appropriate ""Placer number"". Repeats of this field indicate the current service request is related to multiple service requests.

At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
            Sample = @"",
        };

        // check for repetitions
        if (relatedPlacerNumber.field.FieldRepetitions != null && relatedPlacerNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(relatedPlacerNumber.Id));
            relatedPlacerNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(relatedPlacerNumber, fieldData);
        }

        return relatedPlacerNumber;
    } 
}

internal HL7V26Field relatedFillerNumber;

public HL7V26Field RelatedFillerNumber
{
    get
    {
        if (relatedFillerNumber != null)
        {
            return relatedFillerNumber;
        }

        relatedFillerNumber = new HL7V26Field
        {
            field = message[@"TQ2"][4],
            Id = @"TQ2.4",
            Type = @"Field",
            Position = @"TQ2.4",
            Name = @"Related Filler Number",
            Length = 22,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The filler numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Filler number"" from the current service request. For orders, the Filler Order Number from ORC-3 is the appropriate ""Filler number"". Repeats of this field indicate the current service request is related to multiple service requests.

At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
            Sample = @"",
        };

        // check for repetitions
        if (relatedFillerNumber.field.FieldRepetitions != null && relatedFillerNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(relatedFillerNumber.Id));
            relatedFillerNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(relatedFillerNumber, fieldData);
        }

        return relatedFillerNumber;
    } 
}

internal HL7V26Field relatedPlacerGroupNumber;

public HL7V26Field RelatedPlacerGroupNumber
{
    get
    {
        if (relatedPlacerGroupNumber != null)
        {
            return relatedPlacerGroupNumber;
        }

        relatedPlacerGroupNumber = new HL7V26Field
        {
            field = message[@"TQ2"][5],
            Id = @"TQ2.5",
            Type = @"Field",
            Position = @"TQ2.5",
            Name = @"Related Placer Group Number",
            Length = 22,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The placer group numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Placer group number"" from the current service request. For orders, the Placer Group Number from ORC-4 is the appropriate ""Placer group number"". Repeats of this field indicate that the current service request is related to multiple groups of service requests.

At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
            Sample = @"",
        };

        // check for repetitions
        if (relatedPlacerGroupNumber.field.FieldRepetitions != null && relatedPlacerGroupNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(relatedPlacerGroupNumber.Id));
            relatedPlacerGroupNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(relatedPlacerGroupNumber, fieldData);
        }

        return relatedPlacerGroupNumber;
    } 
}

internal HL7V26Field sequenceConditionCode;

public HL7V26Field SequenceConditionCode
{
    get
    {
        if (sequenceConditionCode != null)
        {
            return sequenceConditionCode;
        }

        sequenceConditionCode = new HL7V26Field
        {
            field = message[@"TQ2"][6],
            Id = @"TQ2.6",
            Type = @"Field",
            Position = @"TQ2.6",
            Name = @"Sequence Condition Code",
            Length = 2,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0504",
            TableName = @"Sequence Condition Code",
            Description = @"Defines the relationship between the start/end of the related service request(s) (from TQ2-3, TQ2-4, or TQ2-5) and the current service request from ORC-2, 3 or 4. See HL7 Table 0504 - Sequence Condition Code for allowed values.

Either this field or TQ2-10 must be present.",
            Sample = @"",
        };

        // check for repetitions
        if (sequenceConditionCode.field.FieldRepetitions != null && sequenceConditionCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceConditionCode.Id));
            sequenceConditionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(sequenceConditionCode, fieldData);
        }

        return sequenceConditionCode;
    } 
}

internal HL7V26Field cyclicEntryExitIndicator;

public HL7V26Field CyclicEntryExitIndicator
{
    get
    {
        if (cyclicEntryExitIndicator != null)
        {
            return cyclicEntryExitIndicator;
        }

        cyclicEntryExitIndicator = new HL7V26Field
        {
            field = message[@"TQ2"][7],
            Id = @"TQ2.7",
            Type = @"Field",
            Position = @"TQ2.7",
            Name = @"Cyclic Entry/Exit Indicator",
            Length = 1,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0505",
            TableName = @"Cyclic Entry/Exit Indicator",
            Description = @"Indicates if this service request is the first, last, service request in a cyclic series of service requests. If null or not present, this field indicates that the current service request is neither the first or last service request in a cyclic series of service requests. Refer to HL7 Table 0505 - Cyclic Entry/Exit Indicator for allowed values.

Should not be populated when TQ2-2 (Sequence/Results Flag) is not equal to a 'C' (cyclic service request).",
            Sample = @"",
        };

        // check for repetitions
        if (cyclicEntryExitIndicator.field.FieldRepetitions != null && cyclicEntryExitIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(cyclicEntryExitIndicator.Id));
            cyclicEntryExitIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(cyclicEntryExitIndicator, fieldData);
        }

        return cyclicEntryExitIndicator;
    } 
}

internal HL7V26Field sequenceConditionTimeInterval;

public HL7V26Field SequenceConditionTimeInterval
{
    get
    {
        if (sequenceConditionTimeInterval != null)
        {
            return sequenceConditionTimeInterval;
        }

        sequenceConditionTimeInterval = new HL7V26Field
        {
            field = message[@"TQ2"][8],
            Id = @"TQ2.8",
            Type = @"Field",
            Position = @"TQ2.8",
            Name = @"Sequence Condition Time Interval",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"Defines the interval of time between the start/end of the related service request(s) and the start/end of the current service request. The unit's component is constrained to units of time. If this field is not populated, then there should be no interruption between start/ending the current service request, and the related service request(s).",
            Sample = @"",
        };

        // check for repetitions
        if (sequenceConditionTimeInterval.field.FieldRepetitions != null && sequenceConditionTimeInterval.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceConditionTimeInterval.Id));
            sequenceConditionTimeInterval.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(sequenceConditionTimeInterval, fieldData);
        }

        return sequenceConditionTimeInterval;
    } 
}

internal HL7V26Field cyclicGroupMaximumNumberofRepeats;

public HL7V26Field CyclicGroupMaximumNumberofRepeats
{
    get
    {
        if (cyclicGroupMaximumNumberofRepeats != null)
        {
            return cyclicGroupMaximumNumberofRepeats;
        }

        cyclicGroupMaximumNumberofRepeats = new HL7V26Field
        {
            field = message[@"TQ2"][9],
            Id = @"TQ2.9",
            Type = @"Field",
            Position = @"TQ2.9",
            Name = @"Cyclic Group Maximum Number of Repeats",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"The maximum number of repeats for a cyclic group.",
            Sample = @"",
        };

        // check for repetitions
        if (cyclicGroupMaximumNumberofRepeats.field.FieldRepetitions != null && cyclicGroupMaximumNumberofRepeats.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(cyclicGroupMaximumNumberofRepeats.Id));
            cyclicGroupMaximumNumberofRepeats.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(cyclicGroupMaximumNumberofRepeats, fieldData);
        }

        return cyclicGroupMaximumNumberofRepeats;
    } 
}

internal HL7V26Field specialServiceRequestRelationship;

public HL7V26Field SpecialServiceRequestRelationship
{
    get
    {
        if (specialServiceRequestRelationship != null)
        {
            return specialServiceRequestRelationship;
        }

        specialServiceRequestRelationship = new HL7V26Field
        {
            field = message[@"TQ2"][10],
            Id = @"TQ2.10",
            Type = @"Field",
            Position = @"TQ2.10",
            Name = @"Special Service Request Relationship",
            Length = 1,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0506",
            TableName = @"Service Request Relationship",
            Description = @"This defines an additional or alternate relationship between this service request and other service requests. Its primary intended use is for Pharmacy administration service requests, but it may be useful for other domains. See HL7 Table 0506 - Service Request Relationship for allowed values.

Either this field or TQ2-6 must be present.",
            Sample = @"",
        };

        // check for repetitions
        if (specialServiceRequestRelationship.field.FieldRepetitions != null && specialServiceRequestRelationship.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specialServiceRequestRelationship.Id));
            specialServiceRequestRelationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specialServiceRequestRelationship, fieldData);
        }

        return specialServiceRequestRelationship;
    } 
}
    }
}
