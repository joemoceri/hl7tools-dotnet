using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentTQ2
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

        public HL7V25SegmentTQ2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _setIDTQ2;

public HL7V25Field SetIDTQ2
{
    get
    {
        if (_setIDTQ2 != null)
        {
            return _setIDTQ2;
        }

        var fieldData = new HL7V25FieldData
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
            Fields = null
        }

        _setIDTQ2 = new HL7V25Field
        {
            field = message[@"TQ2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDTQ2.field.FieldRepetitions != null && _setIDTQ2.field.FieldRepetitions.Count > 0)
        {
            _setIDTQ2.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_setIDTQ2, fieldData);
        }

        return _setIDTQ2;
    } 
}

internal HL7V25Field _sequenceResultsFlag;

public HL7V25Field SequenceResultsFlag
{
    get
    {
        if (_sequenceResultsFlag != null)
        {
            return _sequenceResultsFlag;
        }

        var fieldData = new HL7V25FieldData
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
            Fields = null
        }

        _sequenceResultsFlag = new HL7V25Field
        {
            field = message[@"TQ2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceResultsFlag.field.FieldRepetitions != null && _sequenceResultsFlag.field.FieldRepetitions.Count > 0)
        {
            _sequenceResultsFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_sequenceResultsFlag, fieldData);
        }

        return _sequenceResultsFlag;
    } 
}

internal HL7V25Field _relatedPlacerNumber;

public HL7V25Field RelatedPlacerNumber
{
    get
    {
        if (_relatedPlacerNumber != null)
        {
            return _relatedPlacerNumber;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"The placer numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Placer number"" from the current service request. For orders, the Placer Order Number from ORC-2 is the appropriate ""Placer number"". Repeats of this field indicate the current service request is related to multiple service requests.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
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
                        },
                        }
        }

        _relatedPlacerNumber = new HL7V25Field
        {
            field = message[@"TQ2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relatedPlacerNumber.field.FieldRepetitions != null && _relatedPlacerNumber.field.FieldRepetitions.Count > 0)
        {
            _relatedPlacerNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_relatedPlacerNumber, fieldData);
        }

        return _relatedPlacerNumber;
    } 
}

internal HL7V25Field _relatedFillerNumber;

public HL7V25Field RelatedFillerNumber
{
    get
    {
        if (_relatedFillerNumber != null)
        {
            return _relatedFillerNumber;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"The filler numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Filler number"" from the current service request. For orders, the Filler Order Number from ORC-3 is the appropriate ""Filler number"". Repeats of this field indicate the current service request is related to multiple service requests.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
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
                        },
                        }
        }

        _relatedFillerNumber = new HL7V25Field
        {
            field = message[@"TQ2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relatedFillerNumber.field.FieldRepetitions != null && _relatedFillerNumber.field.FieldRepetitions.Count > 0)
        {
            _relatedFillerNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_relatedFillerNumber, fieldData);
        }

        return _relatedFillerNumber;
    } 
}

internal HL7V25Field _relatedPlacerGroupNumber;

public HL7V25Field RelatedPlacerGroupNumber
{
    get
    {
        if (_relatedPlacerGroupNumber != null)
        {
            return _relatedPlacerGroupNumber;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"The placer group numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Placer group number"" from the current service request. For orders, the Placer Group Number from ORC-4 is the appropriate ""Placer group number"". Repeats of this field indicate that the current service request is related to multiple groups of service requests.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
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
                        },
                        }
        }

        _relatedPlacerGroupNumber = new HL7V25Field
        {
            field = message[@"TQ2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relatedPlacerGroupNumber.field.FieldRepetitions != null && _relatedPlacerGroupNumber.field.FieldRepetitions.Count > 0)
        {
            _relatedPlacerGroupNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_relatedPlacerGroupNumber, fieldData);
        }

        return _relatedPlacerGroupNumber;
    } 
}

internal HL7V25Field _sequenceConditionCode;

public HL7V25Field SequenceConditionCode
{
    get
    {
        if (_sequenceConditionCode != null)
        {
            return _sequenceConditionCode;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"Defines the relationship between the start/end of the related service request(s) (from TQ2-3, TQ2-4, or TQ2-5) and the current service request from ORC-2,3 or 4. See HL7 Table 0504 - Sequence Condition Code for allowed values.",
            Sample = @"",
            Fields = null
        }

        _sequenceConditionCode = new HL7V25Field
        {
            field = message[@"TQ2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceConditionCode.field.FieldRepetitions != null && _sequenceConditionCode.field.FieldRepetitions.Count > 0)
        {
            _sequenceConditionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_sequenceConditionCode, fieldData);
        }

        return _sequenceConditionCode;
    } 
}

internal HL7V25Field _cyclicEntryExitIndicator;

public HL7V25Field CyclicEntryExitIndicator
{
    get
    {
        if (_cyclicEntryExitIndicator != null)
        {
            return _cyclicEntryExitIndicator;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"Indicates if this service request is the first, last, service request in a cyclic series of service requests. If null or not present, this field indicates that the current service request is neither the first or last service request in a cyclic series of service requests. Refer to HL7 Table 0505 - Cyclic Entry/Exit Indicator for allowed values.",
            Sample = @"",
            Fields = null
        }

        _cyclicEntryExitIndicator = new HL7V25Field
        {
            field = message[@"TQ2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_cyclicEntryExitIndicator.field.FieldRepetitions != null && _cyclicEntryExitIndicator.field.FieldRepetitions.Count > 0)
        {
            _cyclicEntryExitIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_cyclicEntryExitIndicator, fieldData);
        }

        return _cyclicEntryExitIndicator;
    } 
}

internal HL7V25Field _sequenceConditionTimeInterval;

public HL7V25Field SequenceConditionTimeInterval
{
    get
    {
        if (_sequenceConditionTimeInterval != null)
        {
            return _sequenceConditionTimeInterval;
        }

        var fieldData = new HL7V25FieldData
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
            Fields = new[]
                        {
                            new HL7V2FieldData
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
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _sequenceConditionTimeInterval = new HL7V25Field
        {
            field = message[@"TQ2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceConditionTimeInterval.field.FieldRepetitions != null && _sequenceConditionTimeInterval.field.FieldRepetitions.Count > 0)
        {
            _sequenceConditionTimeInterval.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_sequenceConditionTimeInterval, fieldData);
        }

        return _sequenceConditionTimeInterval;
    } 
}

internal HL7V25Field _cyclicGroupMaximumNumberofRepeats;

public HL7V25Field CyclicGroupMaximumNumberofRepeats
{
    get
    {
        if (_cyclicGroupMaximumNumberofRepeats != null)
        {
            return _cyclicGroupMaximumNumberofRepeats;
        }

        var fieldData = new HL7V25FieldData
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
            Fields = null
        }

        _cyclicGroupMaximumNumberofRepeats = new HL7V25Field
        {
            field = message[@"TQ2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_cyclicGroupMaximumNumberofRepeats.field.FieldRepetitions != null && _cyclicGroupMaximumNumberofRepeats.field.FieldRepetitions.Count > 0)
        {
            _cyclicGroupMaximumNumberofRepeats.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_cyclicGroupMaximumNumberofRepeats, fieldData);
        }

        return _cyclicGroupMaximumNumberofRepeats;
    } 
}

internal HL7V25Field _specialServiceRequestRelationship;

public HL7V25Field SpecialServiceRequestRelationship
{
    get
    {
        if (_specialServiceRequestRelationship != null)
        {
            return _specialServiceRequestRelationship;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This defines an additional or alternate relationship between this service request and other service requests. Its primary intended use is for Pharmacy administration service requests, but it may be useful for other domains. See HL7 Table 0506 - Service Request Relationship for allowed values.",
            Sample = @"",
            Fields = null
        }

        _specialServiceRequestRelationship = new HL7V25Field
        {
            field = message[@"TQ2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialServiceRequestRelationship.field.FieldRepetitions != null && _specialServiceRequestRelationship.field.FieldRepetitions.Count > 0)
        {
            _specialServiceRequestRelationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specialServiceRequestRelationship, fieldData);
        }

        return _specialServiceRequestRelationship;
    } 
}
    }
}
