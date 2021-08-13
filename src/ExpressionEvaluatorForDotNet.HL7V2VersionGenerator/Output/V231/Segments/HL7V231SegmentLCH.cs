using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentLCH
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"LCH"; } }

        public string SegmentId { get { return @"LCH"; } }
        
        public string LongName { get { return @"Location characteristic segment"; } }
        
        public string Description { get { return @"The LCH segment is used to identify location characteristics which determine which patients will be assigned to the room or bed. It contains the location characteristics of the room or bed identified in the preceding LOC segment. There should be one LCH segment for each attribute."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V231SegmentLCH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _primaryKeyValueLCH;

public HL7V231Field PrimaryKeyValueLCH
{
    get
    {
        if (_primaryKeyValueLCH != null)
        {
            return _primaryKeyValueLCH;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"LCH.1",
            Type = @"Field",
            Position = @"LCH.1",
            Name = @"Primary Key Value - LCH",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains the institution's identification code for the location. The identifying key value. This field has the same components as the patient location fields in the PV1 segment (except that bed status is not included here). At least the first component of this field is required. The contents of this field must exactly match the content of its preceding MFE (MFE-4-primary key value-MFE), its preceding LOC (LOC-1- primary key value-LOC), and its preceding LDP ( LDP-1- primary key value-LDP ).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"LCH.1.1",
                            Type = @"Component",
                            Position = @"LCH.1.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = @"Conditional on person location type (e.g., nursing unit or department or clinic). After floor, most general patient location designation. User-defined table 0302 - Point of care is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.1.2",
                            Type = @"Component",
                            Position = @"LCH.1.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = @"Patient room. After nursing unit, most general person location designation. User-defined table 0303 - Room is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.1.3",
                            Type = @"Component",
                            Position = @"LCH.1.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = @"Patient bed. After room, most general person location designation. User-defined table 0304 - Bed is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.1.4",
                            Type = @"Component",
                            Position = @"LCH.1.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Most general person location designation. (See Section 2.8.20, HD - hierarchic designator).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LCH.1.4.1",
                            Type = @"SubComponent",
                            Position = @"LCH.1.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.1.4.2",
                            Type = @"SubComponent",
                            Position = @"LCH.1.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.1.4.3",
                            Type = @"SubComponent",
                            Position = @"LCH.1.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.1.5",
                            Type = @"Component",
                            Position = @"LCH.1.5",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = @"Location (e.g., Bed) status. User-defined table 0306 - Location status is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.1.6",
                            Type = @"Component",
                            Position = @"LCH.1.6",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = @"Usually includes values such as nursing unit, department, clinic, SNF, physicians office. User-defined table 0305 - Person location type is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.1.7",
                            Type = @"Component",
                            Position = @"LCH.1.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = @"After facility, most general person location designation. User-defined table 0307 - Building is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.1.8",
                            Type = @"Component",
                            Position = @"LCH.1.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = @"After building, most general person location designation. User-defined table 0308 - Floor is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.1.9",
                            Type = @"Component",
                            Position = @"LCH.1.9",
                            Name = @"Location Description",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A free text description of the location.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _primaryKeyValueLCH = new HL7V231Field
        {
            field = message[@"LCH"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryKeyValueLCH.field.FieldRepetitions != null && _primaryKeyValueLCH.field.FieldRepetitions.Count > 0)
        {
            _primaryKeyValueLCH.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_primaryKeyValueLCH, fieldData);
        }

        return _primaryKeyValueLCH;
    } 
}

internal HL7V231Field _segmentActionCode;

public HL7V231Field SegmentActionCode
{
    get
    {
        if (_segmentActionCode != null)
        {
            return _segmentActionCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"LCH.2",
            Type = @"Field",
            Position = @"LCH.2",
            Name = @"Segment Action Code",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0206",
            TableName = @"Segment action code",
            Description = @"This field indicates whether this repetition of the segment is being added, changed or deleted. This repetition of the repeating segment must be identified using FT1-25-segment unique key. The action code adds a validation check to indicate, from the point of view of the sending system, whether this repetition of a segment is being added, changed or deleted. This and the following field are used to implement the 'unique key' mode of updating repeating segments. (See Chapter 2, Section 2.23.4.2, 'Action code/unique identifier mode update definition.') Refer to HL7 table 0206 - Segment action code for valid values.",
            Sample = @"",
            Fields = null
        }

        _segmentActionCode = new HL7V231Field
        {
            field = message[@"LCH"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_segmentActionCode.field.FieldRepetitions != null && _segmentActionCode.field.FieldRepetitions.Count > 0)
        {
            _segmentActionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_segmentActionCode, fieldData);
        }

        return _segmentActionCode;
    } 
}

internal HL7V231Field _segmentUniqueKey;

public HL7V231Field SegmentUniqueKey
{
    get
    {
        if (_segmentUniqueKey != null)
        {
            return _segmentUniqueKey;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"LCH.3",
            Type = @"Field",
            Position = @"LCH.3",
            Name = @"Segment Unique Key",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains a unique identifier for one of the multiple repetitions of this segment, to be used in conjunction with the preceding field. Each of the repetitions of the segment will be uniquely identified by this unique key field for the purposes of updates.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"LCH.3.1",
                            Type = @"Component",
                            Position = @"LCH.3.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.3.2",
                            Type = @"Component",
                            Position = @"LCH.3.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.3.3",
                            Type = @"Component",
                            Position = @"LCH.3.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.3.4",
                            Type = @"Component",
                            Position = @"LCH.3.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _segmentUniqueKey = new HL7V231Field
        {
            field = message[@"LCH"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_segmentUniqueKey.field.FieldRepetitions != null && _segmentUniqueKey.field.FieldRepetitions.Count > 0)
        {
            _segmentUniqueKey.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_segmentUniqueKey, fieldData);
        }

        return _segmentUniqueKey;
    } 
}

internal HL7V231Field _locationCharacteristicID;

public HL7V231Field LocationCharacteristicID
{
    get
    {
        if (_locationCharacteristicID != null)
        {
            return _locationCharacteristicID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"LCH.4",
            Type = @"Field",
            Position = @"LCH.4",
            Name = @"Location Characteristic ID",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0324",
            TableName = @"Location characteristic ID",
            Description = @"This field contains an identifier code to show WHICH characteristic is being communicated with this segment. Refer to user-defined table 0324 - Location characteristic ID for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"LCH.4.1",
                            Type = @"Component",
                            Position = @"LCH.4.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.4.2",
                            Type = @"Component",
                            Position = @"LCH.4.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.4.3",
                            Type = @"Component",
                            Position = @"LCH.4.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.4.4",
                            Type = @"Component",
                            Position = @"LCH.4.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.4.5",
                            Type = @"Component",
                            Position = @"LCH.4.5",
                            Name = @"Alternate Text",
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
                            Id = @"LCH.4.6",
                            Type = @"Component",
                            Position = @"LCH.4.6",
                            Name = @"Name Of Alternate Coding System",
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

        _locationCharacteristicID = new HL7V231Field
        {
            field = message[@"LCH"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_locationCharacteristicID.field.FieldRepetitions != null && _locationCharacteristicID.field.FieldRepetitions.Count > 0)
        {
            _locationCharacteristicID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_locationCharacteristicID, fieldData);
        }

        return _locationCharacteristicID;
    } 
}

internal HL7V231Field _locationCharacteristicValue;

public HL7V231Field LocationCharacteristicValue
{
    get
    {
        if (_locationCharacteristicValue != null)
        {
            return _locationCharacteristicValue;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"LCH.5",
            Type = @"Field",
            Position = @"LCH.5",
            Name = @"Location Characteristic Value",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the value of the above field's characteristic. The expected coded values for this field will depend upon the previous field. For example, if the previous field is SMK, IMP, INF, the values would be 'Y' or 'N'.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"LCH.5.1",
                            Type = @"Component",
                            Position = @"LCH.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.5.2",
                            Type = @"Component",
                            Position = @"LCH.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.5.3",
                            Type = @"Component",
                            Position = @"LCH.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.5.4",
                            Type = @"Component",
                            Position = @"LCH.5.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LCH.5.5",
                            Type = @"Component",
                            Position = @"LCH.5.5",
                            Name = @"Alternate Text",
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
                            Id = @"LCH.5.6",
                            Type = @"Component",
                            Position = @"LCH.5.6",
                            Name = @"Name Of Alternate Coding System",
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

        _locationCharacteristicValue = new HL7V231Field
        {
            field = message[@"LCH"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_locationCharacteristicValue.field.FieldRepetitions != null && _locationCharacteristicValue.field.FieldRepetitions.Count > 0)
        {
            _locationCharacteristicValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_locationCharacteristicValue, fieldData);
        }

        return _locationCharacteristicValue;
    } 
}
    }
}
