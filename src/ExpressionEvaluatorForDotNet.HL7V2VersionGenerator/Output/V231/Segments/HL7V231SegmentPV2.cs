using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentPV2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PV2"; } }

        public string SegmentId { get { return @"PV2"; } }
        
        public string LongName { get { return @"Patient visit - additional information segment"; } }
        
        public string Description { get { return @"The PV2 segment is a continuation of visit-specific information contained on the PV1 segment."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V231SegmentPV2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _priorPendingLocation;

public HL7V231Field PriorPendingLocation
{
    get
    {
        if (_priorPendingLocation != null)
        {
            return _priorPendingLocation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.1",
            Type = @"Field",
            Position = @"PV2.1",
            Name = @"Prior Pending Location",
            Length = 80,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field is required for cancel pending transfer (A27 (cancel pending admit)) messages. In all other events it is optional.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.1.1",
                            Type = @"Component",
                            Position = @"PV2.1.1",
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
                            Id = @"PV2.1.2",
                            Type = @"Component",
                            Position = @"PV2.1.2",
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
                            Id = @"PV2.1.3",
                            Type = @"Component",
                            Position = @"PV2.1.3",
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
                            Id = @"PV2.1.4",
                            Type = @"Component",
                            Position = @"PV2.1.4",
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
                            Id = @"PV2.1.4.1",
                            Type = @"SubComponent",
                            Position = @"PV2.1.4.1",
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
                            Id = @"PV2.1.4.2",
                            Type = @"SubComponent",
                            Position = @"PV2.1.4.2",
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
                            Id = @"PV2.1.4.3",
                            Type = @"SubComponent",
                            Position = @"PV2.1.4.3",
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
                            Id = @"PV2.1.5",
                            Type = @"Component",
                            Position = @"PV2.1.5",
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
                            Id = @"PV2.1.6",
                            Type = @"Component",
                            Position = @"PV2.1.6",
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
                            Id = @"PV2.1.7",
                            Type = @"Component",
                            Position = @"PV2.1.7",
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
                            Id = @"PV2.1.8",
                            Type = @"Component",
                            Position = @"PV2.1.8",
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
                            Id = @"PV2.1.9",
                            Type = @"Component",
                            Position = @"PV2.1.9",
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

        _priorPendingLocation = new HL7V231Field
        {
            field = message[@"PV2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorPendingLocation.field.FieldRepetitions != null && _priorPendingLocation.field.FieldRepetitions.Count > 0)
        {
            _priorPendingLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_priorPendingLocation, fieldData);
        }

        return _priorPendingLocation;
    } 
}

internal HL7V231Field _accommodationCode;

public HL7V231Field AccommodationCode
{
    get
    {
        if (_accommodationCode != null)
        {
            return _accommodationCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.2",
            Type = @"Field",
            Position = @"PV2.2",
            Name = @"Accommodation Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0129",
            TableName = @"Accommodation code",
            Description = @"This field indicates the specific patient accommodations for this visit. User-defined table 0129 - Accommodation code is used as the HL7 identifier for the user-defined table for values for this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.2.1",
                            Type = @"Component",
                            Position = @"PV2.2.1",
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
                            Id = @"PV2.2.2",
                            Type = @"Component",
                            Position = @"PV2.2.2",
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
                            Id = @"PV2.2.3",
                            Type = @"Component",
                            Position = @"PV2.2.3",
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
                            Id = @"PV2.2.4",
                            Type = @"Component",
                            Position = @"PV2.2.4",
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
                            Id = @"PV2.2.5",
                            Type = @"Component",
                            Position = @"PV2.2.5",
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
                            Id = @"PV2.2.6",
                            Type = @"Component",
                            Position = @"PV2.2.6",
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

        _accommodationCode = new HL7V231Field
        {
            field = message[@"PV2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accommodationCode.field.FieldRepetitions != null && _accommodationCode.field.FieldRepetitions.Count > 0)
        {
            _accommodationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_accommodationCode, fieldData);
        }

        return _accommodationCode;
    } 
}

internal HL7V231Field _admitReason;

public HL7V231Field AdmitReason
{
    get
    {
        if (_admitReason != null)
        {
            return _admitReason;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.3",
            Type = @"Field",
            Position = @"PV2.3",
            Name = @"Admit Reason",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the short description of the reason for patient admission.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.3.1",
                            Type = @"Component",
                            Position = @"PV2.3.1",
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
                            Id = @"PV2.3.2",
                            Type = @"Component",
                            Position = @"PV2.3.2",
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
                            Id = @"PV2.3.3",
                            Type = @"Component",
                            Position = @"PV2.3.3",
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
                            Id = @"PV2.3.4",
                            Type = @"Component",
                            Position = @"PV2.3.4",
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
                            Id = @"PV2.3.5",
                            Type = @"Component",
                            Position = @"PV2.3.5",
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
                            Id = @"PV2.3.6",
                            Type = @"Component",
                            Position = @"PV2.3.6",
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

        _admitReason = new HL7V231Field
        {
            field = message[@"PV2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admitReason.field.FieldRepetitions != null && _admitReason.field.FieldRepetitions.Count > 0)
        {
            _admitReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_admitReason, fieldData);
        }

        return _admitReason;
    } 
}

internal HL7V231Field _transferReason;

public HL7V231Field TransferReason
{
    get
    {
        if (_transferReason != null)
        {
            return _transferReason;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.4",
            Type = @"Field",
            Position = @"PV2.4",
            Name = @"Transfer Reason",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the short description of the reason for a patient location change.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.4.1",
                            Type = @"Component",
                            Position = @"PV2.4.1",
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
                            Id = @"PV2.4.2",
                            Type = @"Component",
                            Position = @"PV2.4.2",
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
                            Id = @"PV2.4.3",
                            Type = @"Component",
                            Position = @"PV2.4.3",
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
                            Id = @"PV2.4.4",
                            Type = @"Component",
                            Position = @"PV2.4.4",
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
                            Id = @"PV2.4.5",
                            Type = @"Component",
                            Position = @"PV2.4.5",
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
                            Id = @"PV2.4.6",
                            Type = @"Component",
                            Position = @"PV2.4.6",
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

        _transferReason = new HL7V231Field
        {
            field = message[@"PV2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transferReason.field.FieldRepetitions != null && _transferReason.field.FieldRepetitions.Count > 0)
        {
            _transferReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_transferReason, fieldData);
        }

        return _transferReason;
    } 
}

internal HL7V231Field _patientValuables;

public HL7V231Field PatientValuables
{
    get
    {
        if (_patientValuables != null)
        {
            return _patientValuables;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.5",
            Type = @"Field",
            Position = @"PV2.5",
            Name = @"Patient Valuables",
            Length = 25,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the short description of patient valuables checked in during admission.",
            Sample = @"",
            Fields = null
        }

        _patientValuables = new HL7V231Field
        {
            field = message[@"PV2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientValuables.field.FieldRepetitions != null && _patientValuables.field.FieldRepetitions.Count > 0)
        {
            _patientValuables.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_patientValuables, fieldData);
        }

        return _patientValuables;
    } 
}

internal HL7V231Field _patientValuablesLocation;

public HL7V231Field PatientValuablesLocation
{
    get
    {
        if (_patientValuablesLocation != null)
        {
            return _patientValuablesLocation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.6",
            Type = @"Field",
            Position = @"PV2.6",
            Name = @"Patient Valuables Location",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the location of the patient's valuables.",
            Sample = @"",
            Fields = null
        }

        _patientValuablesLocation = new HL7V231Field
        {
            field = message[@"PV2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientValuablesLocation.field.FieldRepetitions != null && _patientValuablesLocation.field.FieldRepetitions.Count > 0)
        {
            _patientValuablesLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_patientValuablesLocation, fieldData);
        }

        return _patientValuablesLocation;
    } 
}

internal HL7V231Field _visitUserCode;

public HL7V231Field VisitUserCode
{
    get
    {
        if (_visitUserCode != null)
        {
            return _visitUserCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.7",
            Type = @"Field",
            Position = @"PV2.7",
            Name = @"Visit User Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0130",
            TableName = @"Visit user code",
            Description = @"This field further categorizes a patient's visit with respect to an individual institution's needs (e.g., teaching flag = TE, indicating the patient is a teaching case). User-defined table 0130 - Visit user code is used as the HL7 identifier or the user-defined table of values for this field.",
            Sample = @"",
            Fields = null
        }

        _visitUserCode = new HL7V231Field
        {
            field = message[@"PV2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitUserCode.field.FieldRepetitions != null && _visitUserCode.field.FieldRepetitions.Count > 0)
        {
            _visitUserCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_visitUserCode, fieldData);
        }

        return _visitUserCode;
    } 
}

internal HL7V231Field _expectedAdmitDateTime;

public HL7V231Field ExpectedAdmitDateTime
{
    get
    {
        if (_expectedAdmitDateTime != null)
        {
            return _expectedAdmitDateTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.8",
            Type = @"Field",
            Position = @"PV2.8",
            Name = @"Expected Admit Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time that the patient is expected to be admitted. This field is also used to reflect the date/time of an outpatient/emergency patient registration.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.8.1",
                            Type = @"Component",
                            Position = @"PV2.8.1",
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
                        }
        }

        _expectedAdmitDateTime = new HL7V231Field
        {
            field = message[@"PV2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedAdmitDateTime.field.FieldRepetitions != null && _expectedAdmitDateTime.field.FieldRepetitions.Count > 0)
        {
            _expectedAdmitDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_expectedAdmitDateTime, fieldData);
        }

        return _expectedAdmitDateTime;
    } 
}

internal HL7V231Field _expectedDischargeDateTime;

public HL7V231Field ExpectedDischargeDateTime
{
    get
    {
        if (_expectedDischargeDateTime != null)
        {
            return _expectedDischargeDateTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.9",
            Type = @"Field",
            Position = @"PV2.9",
            Name = @"Expected Discharge Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time that the patient is expected to be discharged. This is a non-event related date used by ancillaries to determine more accurately the projected workloads. This field is also used to reflect the anticipated discharge date/time of an outpatient/emergency patient, or an inpatient.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.9.1",
                            Type = @"Component",
                            Position = @"PV2.9.1",
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
                        }
        }

        _expectedDischargeDateTime = new HL7V231Field
        {
            field = message[@"PV2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedDischargeDateTime.field.FieldRepetitions != null && _expectedDischargeDateTime.field.FieldRepetitions.Count > 0)
        {
            _expectedDischargeDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_expectedDischargeDateTime, fieldData);
        }

        return _expectedDischargeDateTime;
    } 
}

internal HL7V231Field _estimatedLengthofInpatientStay;

public HL7V231Field EstimatedLengthofInpatientStay
{
    get
    {
        if (_estimatedLengthofInpatientStay != null)
        {
            return _estimatedLengthofInpatientStay;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.10",
            Type = @"Field",
            Position = @"PV2.10",
            Name = @"Estimated Length of Inpatient Stay",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the estimated days of inpatient stays.",
            Sample = @"",
            Fields = null
        }

        _estimatedLengthofInpatientStay = new HL7V231Field
        {
            field = message[@"PV2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_estimatedLengthofInpatientStay.field.FieldRepetitions != null && _estimatedLengthofInpatientStay.field.FieldRepetitions.Count > 0)
        {
            _estimatedLengthofInpatientStay.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_estimatedLengthofInpatientStay, fieldData);
        }

        return _estimatedLengthofInpatientStay;
    } 
}

internal HL7V231Field _actualLengthofInpatientStay;

public HL7V231Field ActualLengthofInpatientStay
{
    get
    {
        if (_actualLengthofInpatientStay != null)
        {
            return _actualLengthofInpatientStay;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.11",
            Type = @"Field",
            Position = @"PV2.11",
            Name = @"Actual Length of Inpatient Stay",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the actual days of inpatient stays. The actual length of the inpatient stay may not be calculated from the admission and discharge dates because of possible leaves of absence.",
            Sample = @"",
            Fields = null
        }

        _actualLengthofInpatientStay = new HL7V231Field
        {
            field = message[@"PV2"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actualLengthofInpatientStay.field.FieldRepetitions != null && _actualLengthofInpatientStay.field.FieldRepetitions.Count > 0)
        {
            _actualLengthofInpatientStay.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_actualLengthofInpatientStay, fieldData);
        }

        return _actualLengthofInpatientStay;
    } 
}

internal HL7V231Field _visitDescription;

public HL7V231Field VisitDescription
{
    get
    {
        if (_visitDescription != null)
        {
            return _visitDescription;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.12",
            Type = @"Field",
            Position = @"PV2.12",
            Name = @"Visit Description",
            Length = 50,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a brief user-defined description of the visit.",
            Sample = @"",
            Fields = null
        }

        _visitDescription = new HL7V231Field
        {
            field = message[@"PV2"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitDescription.field.FieldRepetitions != null && _visitDescription.field.FieldRepetitions.Count > 0)
        {
            _visitDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_visitDescription, fieldData);
        }

        return _visitDescription;
    } 
}

internal HL7V231Field _referralSourceCode;

public HL7V231Field ReferralSourceCode
{
    get
    {
        if (_referralSourceCode != null)
        {
            return _referralSourceCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.13",
            Type = @"Field",
            Position = @"PV2.13",
            Name = @"Referral Source Code",
            Length = 90,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name and the identification numbers of the person or organization that made the referral. This person/organization is not the same as the referring doctor. For example, Joe Smith referred me to the Clinic (or to Dr. Jones at the Clinic).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.13.1",
                            Type = @"Component",
                            Position = @"PV2.13.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This string refers to the coded ID according to a user-defined table, defined by the 9th component. If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.2",
                            Type = @"Component",
                            Position = @"PV2.13.2",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PV2.13.2.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.2.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.2",
                            Name = @"Last Name Prefix",
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
                            Id = @"PV2.13.3",
                            Type = @"Component",
                            Position = @"PV2.13.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.4",
                            Type = @"Component",
                            Position = @"PV2.13.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"PV2.13.5",
                            Type = @"Component",
                            Position = @"PV2.13.5",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.6",
                            Type = @"Component",
                            Position = @"PV2.13.6",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.7",
                            Type = @"Component",
                            Position = @"PV2.13.7",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.8",
                            Type = @"Component",
                            Position = @"PV2.13.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.9",
                            Type = @"Component",
                            Position = @"PV2.13.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PV2.13.9.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.9.1",
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
                            Id = @"PV2.13.9.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.9.2",
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
                            Id = @"PV2.13.9.3",
                            Type = @"SubComponent",
                            Position = @"PV2.13.9.3",
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
                            Id = @"PV2.13.10",
                            Type = @"Component",
                            Position = @"PV2.13.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.51, XPN - extended person name).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.11",
                            Type = @"Component",
                            Position = @"PV2.13.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.12",
                            Type = @"Component",
                            Position = @"PV2.13.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.13",
                            Type = @"Component",
                            Position = @"PV2.13.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.14",
                            Type = @"Component",
                            Position = @"PV2.13.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PV2.13.14.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.14.1",
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
                            Id = @"PV2.13.14.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.14.2",
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
                            Id = @"PV2.13.14.3",
                            Type = @"SubComponent",
                            Position = @"PV2.13.14.3",
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
                            Id = @"PV2.13.15",
                            Type = @"Component",
                            Position = @"PV2.13.15",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _referralSourceCode = new HL7V231Field
        {
            field = message[@"PV2"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referralSourceCode.field.FieldRepetitions != null && _referralSourceCode.field.FieldRepetitions.Count > 0)
        {
            _referralSourceCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_referralSourceCode, fieldData);
        }

        return _referralSourceCode;
    } 
}

internal HL7V231Field _previousServiceDate;

public HL7V231Field PreviousServiceDate
{
    get
    {
        if (_previousServiceDate != null)
        {
            return _previousServiceDate;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.14",
            Type = @"Field",
            Position = @"PV2.14",
            Name = @"Previous Service Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date of previous service for the same recurring condition. This may be a required field for billing certain illnesses (e.g., accident related) to a third party.",
            Sample = @"",
            Fields = null
        }

        _previousServiceDate = new HL7V231Field
        {
            field = message[@"PV2"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_previousServiceDate.field.FieldRepetitions != null && _previousServiceDate.field.FieldRepetitions.Count > 0)
        {
            _previousServiceDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_previousServiceDate, fieldData);
        }

        return _previousServiceDate;
    } 
}

internal HL7V231Field _employmentIllnessRelatedIndicator;

public HL7V231Field EmploymentIllnessRelatedIndicator
{
    get
    {
        if (_employmentIllnessRelatedIndicator != null)
        {
            return _employmentIllnessRelatedIndicator;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.15",
            Type = @"Field",
            Position = @"PV2.15",
            Name = @"Employment Illness Related Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field specifies whether a patient's illness was job-related. Refer to Chapter 2, HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _employmentIllnessRelatedIndicator = new HL7V231Field
        {
            field = message[@"PV2"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employmentIllnessRelatedIndicator.field.FieldRepetitions != null && _employmentIllnessRelatedIndicator.field.FieldRepetitions.Count > 0)
        {
            _employmentIllnessRelatedIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_employmentIllnessRelatedIndicator, fieldData);
        }

        return _employmentIllnessRelatedIndicator;
    } 
}

internal HL7V231Field _purgeStatusCode;

public HL7V231Field PurgeStatusCode
{
    get
    {
        if (_purgeStatusCode != null)
        {
            return _purgeStatusCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.16",
            Type = @"Field",
            Position = @"PV2.16",
            Name = @"Purge Status Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0213",
            TableName = @"Purge status",
            Description = @"This field contains the purge status code for the account. It is used by the application program to determine purge processing. Refer to user-defined table 0213 - Purge status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _purgeStatusCode = new HL7V231Field
        {
            field = message[@"PV2"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_purgeStatusCode.field.FieldRepetitions != null && _purgeStatusCode.field.FieldRepetitions.Count > 0)
        {
            _purgeStatusCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_purgeStatusCode, fieldData);
        }

        return _purgeStatusCode;
    } 
}

internal HL7V231Field _purgeStatusDate;

public HL7V231Field PurgeStatusDate
{
    get
    {
        if (_purgeStatusDate != null)
        {
            return _purgeStatusDate;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.17",
            Type = @"Field",
            Position = @"PV2.17",
            Name = @"Purge Status Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date on which the data will be purged from the system.",
            Sample = @"",
            Fields = null
        }

        _purgeStatusDate = new HL7V231Field
        {
            field = message[@"PV2"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_purgeStatusDate.field.FieldRepetitions != null && _purgeStatusDate.field.FieldRepetitions.Count > 0)
        {
            _purgeStatusDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_purgeStatusDate, fieldData);
        }

        return _purgeStatusDate;
    } 
}

internal HL7V231Field _specialProgramCode;

public HL7V231Field SpecialProgramCode
{
    get
    {
        if (_specialProgramCode != null)
        {
            return _specialProgramCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.18",
            Type = @"Field",
            Position = @"PV2.18",
            Name = @"Special Program Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0214",
            TableName = @"Special program codes",
            Description = @"This field designates the specific health insurance program for a visit required for healthcare reimbursement. Examples include Child Health Assistance, Elective Surgery Program, Family Planning, etc. User-defined table 0214 - Special program codes is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
            Fields = null
        }

        _specialProgramCode = new HL7V231Field
        {
            field = message[@"PV2"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialProgramCode.field.FieldRepetitions != null && _specialProgramCode.field.FieldRepetitions.Count > 0)
        {
            _specialProgramCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_specialProgramCode, fieldData);
        }

        return _specialProgramCode;
    } 
}

internal HL7V231Field _retentionIndicator;

public HL7V231Field RetentionIndicator
{
    get
    {
        if (_retentionIndicator != null)
        {
            return _retentionIndicator;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.19",
            Type = @"Field",
            Position = @"PV2.19",
            Name = @"Retention Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field allows the user to control the financial and demographic purge processes at the visit. It is used to preserve demographic and financial data on specific, high priority visits. Refer to Chapter 2, HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _retentionIndicator = new HL7V231Field
        {
            field = message[@"PV2"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_retentionIndicator.field.FieldRepetitions != null && _retentionIndicator.field.FieldRepetitions.Count > 0)
        {
            _retentionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_retentionIndicator, fieldData);
        }

        return _retentionIndicator;
    } 
}

internal HL7V231Field _expectedNumberofInsurancePlans;

public HL7V231Field ExpectedNumberofInsurancePlans
{
    get
    {
        if (_expectedNumberofInsurancePlans != null)
        {
            return _expectedNumberofInsurancePlans;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.20",
            Type = @"Field",
            Position = @"PV2.20",
            Name = @"Expected Number of Insurance Plans",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of insurance plans that may provide coverage for this visit.",
            Sample = @"",
            Fields = null
        }

        _expectedNumberofInsurancePlans = new HL7V231Field
        {
            field = message[@"PV2"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedNumberofInsurancePlans.field.FieldRepetitions != null && _expectedNumberofInsurancePlans.field.FieldRepetitions.Count > 0)
        {
            _expectedNumberofInsurancePlans.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_expectedNumberofInsurancePlans, fieldData);
        }

        return _expectedNumberofInsurancePlans;
    } 
}

internal HL7V231Field _visitPublicityCode;

public HL7V231Field VisitPublicityCode
{
    get
    {
        if (_visitPublicityCode != null)
        {
            return _visitPublicityCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.21",
            Type = @"Field",
            Position = @"PV2.21",
            Name = @"Visit Publicity Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0215",
            TableName = @"Publicity code",
            Description = @"This field contains a user-defined code indicating what level of publicity is allowed (e.g., No Publicity, Family Only) for a specific visit. User-defined table 0215 - Publicitycode is used as the HL7 identifier for the user-defined table of values for this field. Refer to PD1-11- publicity code for the patient level publicity code.",
            Sample = @"",
            Fields = null
        }

        _visitPublicityCode = new HL7V231Field
        {
            field = message[@"PV2"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitPublicityCode.field.FieldRepetitions != null && _visitPublicityCode.field.FieldRepetitions.Count > 0)
        {
            _visitPublicityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_visitPublicityCode, fieldData);
        }

        return _visitPublicityCode;
    } 
}

internal HL7V231Field _visitProtectionIndicator;

public HL7V231Field VisitProtectionIndicator
{
    get
    {
        if (_visitProtectionIndicator != null)
        {
            return _visitProtectionIndicator;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.22",
            Type = @"Field",
            Position = @"PV2.22",
            Name = @"Visit Protection Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies the person's protection that determines, in turn, whether access to information about this person should be kept from users who do not have adequate authority for a specific visit. Refer to Chapter 2, HL7 table 0136 - Yes/no indicator for valid values. Refer to PD1-12- protection indicator for the patient level protection indicator.",
            Sample = @"",
            Fields = null
        }

        _visitProtectionIndicator = new HL7V231Field
        {
            field = message[@"PV2"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitProtectionIndicator.field.FieldRepetitions != null && _visitProtectionIndicator.field.FieldRepetitions.Count > 0)
        {
            _visitProtectionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_visitProtectionIndicator, fieldData);
        }

        return _visitProtectionIndicator;
    } 
}

internal HL7V231Field _clinicOrganizationName;

public HL7V231Field ClinicOrganizationName
{
    get
    {
        if (_clinicOrganizationName != null)
        {
            return _clinicOrganizationName;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.23",
            Type = @"Field",
            Position = @"PV2.23",
            Name = @"Clinic Organization Name",
            Length = 90,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the organization name or sub-unit and identifier that is associated with the (visit) episode of care. For example, the Allergy or Oncology Clinic within the facility might be named.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.23.1",
                            Type = @"Component",
                            Position = @"PV2.23.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.2",
                            Type = @"Component",
                            Position = @"PV2.23.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to user-defined table 0204 - Organizational name type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.3",
                            Type = @"Component",
                            Position = @"PV2.23.3",
                            Name = @"Id Number",
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
                            Id = @"PV2.23.4",
                            Type = @"Component",
                            Position = @"PV2.23.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.5",
                            Type = @"Component",
                            Position = @"PV2.23.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.6",
                            Type = @"Component",
                            Position = @"PV2.23.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PV2.23.6.1",
                            Type = @"SubComponent",
                            Position = @"PV2.23.6.1",
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
                            Id = @"PV2.23.6.2",
                            Type = @"SubComponent",
                            Position = @"PV2.23.6.2",
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
                            Id = @"PV2.23.6.3",
                            Type = @"SubComponent",
                            Position = @"PV2.23.6.3",
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
                            Id = @"PV2.23.7",
                            Type = @"Component",
                            Position = @"PV2.23.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.8",
                            Type = @"Component",
                            Position = @"PV2.23.8",
                            Name = @"Assigning Facility Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PV2.23.8.1",
                            Type = @"SubComponent",
                            Position = @"PV2.23.8.1",
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
                            Id = @"PV2.23.8.2",
                            Type = @"SubComponent",
                            Position = @"PV2.23.8.2",
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
                            Id = @"PV2.23.8.3",
                            Type = @"SubComponent",
                            Position = @"PV2.23.8.3",
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
                            Id = @"PV2.23.9",
                            Type = @"Component",
                            Position = @"PV2.23.9",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _clinicOrganizationName = new HL7V231Field
        {
            field = message[@"PV2"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_clinicOrganizationName.field.FieldRepetitions != null && _clinicOrganizationName.field.FieldRepetitions.Count > 0)
        {
            _clinicOrganizationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_clinicOrganizationName, fieldData);
        }

        return _clinicOrganizationName;
    } 
}

internal HL7V231Field _patientStatusCode;

public HL7V231Field PatientStatusCode
{
    get
    {
        if (_patientStatusCode != null)
        {
            return _patientStatusCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.24",
            Type = @"Field",
            Position = @"PV2.24",
            Name = @"Patient Status Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0216",
            TableName = @"Patient status code",
            Description = @"This field indicates the status of the episode of care: for instance, Active Inpatient vs. Discharged Inpatient. Refer to user defined table0216 - Patient status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _patientStatusCode = new HL7V231Field
        {
            field = message[@"PV2"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientStatusCode.field.FieldRepetitions != null && _patientStatusCode.field.FieldRepetitions.Count > 0)
        {
            _patientStatusCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_patientStatusCode, fieldData);
        }

        return _patientStatusCode;
    } 
}

internal HL7V231Field _visitPriorityCode;

public HL7V231Field VisitPriorityCode
{
    get
    {
        if (_visitPriorityCode != null)
        {
            return _visitPriorityCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.25",
            Type = @"Field",
            Position = @"PV2.25",
            Name = @"Visit Priority Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0217",
            TableName = @"Visit priority code",
            Description = @"This field contains the priority of the visit, e.g., whether the admission is an emergency, elective, or urgent. Refer to user defined table 0217 - Visit priority for suggested values.",
            Sample = @"",
            Fields = null
        }

        _visitPriorityCode = new HL7V231Field
        {
            field = message[@"PV2"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitPriorityCode.field.FieldRepetitions != null && _visitPriorityCode.field.FieldRepetitions.Count > 0)
        {
            _visitPriorityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_visitPriorityCode, fieldData);
        }

        return _visitPriorityCode;
    } 
}

internal HL7V231Field _previousTreatmentDate;

public HL7V231Field PreviousTreatmentDate
{
    get
    {
        if (_previousTreatmentDate != null)
        {
            return _previousTreatmentDate;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.26",
            Type = @"Field",
            Position = @"PV2.26",
            Name = @"Previous Treatment Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the patient last had treatment for any condition prior to this visit. In the case of a prior hospital visit, it is likely to be the previous discharge date.",
            Sample = @"",
            Fields = null
        }

        _previousTreatmentDate = new HL7V231Field
        {
            field = message[@"PV2"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_previousTreatmentDate.field.FieldRepetitions != null && _previousTreatmentDate.field.FieldRepetitions.Count > 0)
        {
            _previousTreatmentDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_previousTreatmentDate, fieldData);
        }

        return _previousTreatmentDate;
    } 
}

internal HL7V231Field _expectedDischargeDisposition;

public HL7V231Field ExpectedDischargeDisposition
{
    get
    {
        if (_expectedDischargeDisposition != null)
        {
            return _expectedDischargeDisposition;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.27",
            Type = @"Field",
            Position = @"PV2.27",
            Name = @"Expected Discharge Disposition",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0112",
            TableName = @"Discharge disposition",
            Description = @"This field describes what the patient's disposition is expected to be at the end of the visit. Refer to user-defined table 0112 - Discharged disposition for suggested values.",
            Sample = @"",
            Fields = null
        }

        _expectedDischargeDisposition = new HL7V231Field
        {
            field = message[@"PV2"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedDischargeDisposition.field.FieldRepetitions != null && _expectedDischargeDisposition.field.FieldRepetitions.Count > 0)
        {
            _expectedDischargeDisposition.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_expectedDischargeDisposition, fieldData);
        }

        return _expectedDischargeDisposition;
    } 
}

internal HL7V231Field _signatureonFileDate;

public HL7V231Field SignatureonFileDate
{
    get
    {
        if (_signatureonFileDate != null)
        {
            return _signatureonFileDate;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.28",
            Type = @"Field",
            Position = @"PV2.28",
            Name = @"Signature on File Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date on which a signature was obtained for insurance billing purposes.",
            Sample = @"",
            Fields = null
        }

        _signatureonFileDate = new HL7V231Field
        {
            field = message[@"PV2"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_signatureonFileDate.field.FieldRepetitions != null && _signatureonFileDate.field.FieldRepetitions.Count > 0)
        {
            _signatureonFileDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_signatureonFileDate, fieldData);
        }

        return _signatureonFileDate;
    } 
}

internal HL7V231Field _firstSimilarIllnessDate;

public HL7V231Field FirstSimilarIllnessDate
{
    get
    {
        if (_firstSimilarIllnessDate != null)
        {
            return _firstSimilarIllnessDate;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.29",
            Type = @"Field",
            Position = @"PV2.29",
            Name = @"First Similar Illness Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field is used to determine if the patient has a pre-existing condition.",
            Sample = @"",
            Fields = null
        }

        _firstSimilarIllnessDate = new HL7V231Field
        {
            field = message[@"PV2"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_firstSimilarIllnessDate.field.FieldRepetitions != null && _firstSimilarIllnessDate.field.FieldRepetitions.Count > 0)
        {
            _firstSimilarIllnessDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_firstSimilarIllnessDate, fieldData);
        }

        return _firstSimilarIllnessDate;
    } 
}

internal HL7V231Field _patientChargeAdjustmentCode;

public HL7V231Field PatientChargeAdjustmentCode
{
    get
    {
        if (_patientChargeAdjustmentCode != null)
        {
            return _patientChargeAdjustmentCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.30",
            Type = @"Field",
            Position = @"PV2.30",
            Name = @"Patient Charge Adjustment Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0218",
            TableName = @"Patient charge adjustment",
            Description = @"This field contains a user-defined code that indicates which adjustments should be made to this patient's charges. User-defined table 0218 - Charge adjustment is used as the HL7 identifier for the user-defined table of values for this field. This field is the same as GT1-26-guarantor charge adjustment code .",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.30.1",
                            Type = @"Component",
                            Position = @"PV2.30.1",
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
                            Id = @"PV2.30.2",
                            Type = @"Component",
                            Position = @"PV2.30.2",
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
                            Id = @"PV2.30.3",
                            Type = @"Component",
                            Position = @"PV2.30.3",
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
                            Id = @"PV2.30.4",
                            Type = @"Component",
                            Position = @"PV2.30.4",
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
                            Id = @"PV2.30.5",
                            Type = @"Component",
                            Position = @"PV2.30.5",
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
                            Id = @"PV2.30.6",
                            Type = @"Component",
                            Position = @"PV2.30.6",
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

        _patientChargeAdjustmentCode = new HL7V231Field
        {
            field = message[@"PV2"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientChargeAdjustmentCode.field.FieldRepetitions != null && _patientChargeAdjustmentCode.field.FieldRepetitions.Count > 0)
        {
            _patientChargeAdjustmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_patientChargeAdjustmentCode, fieldData);
        }

        return _patientChargeAdjustmentCode;
    } 
}

internal HL7V231Field _recurringServiceCode;

public HL7V231Field RecurringServiceCode
{
    get
    {
        if (_recurringServiceCode != null)
        {
            return _recurringServiceCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.31",
            Type = @"Field",
            Position = @"PV2.31",
            Name = @"Recurring Service Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0219",
            TableName = @"Recurring service",
            Description = @"This field indicates whether the treatment is continuous. User-defined table 0219 - Recurring service is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
            Fields = null
        }

        _recurringServiceCode = new HL7V231Field
        {
            field = message[@"PV2"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recurringServiceCode.field.FieldRepetitions != null && _recurringServiceCode.field.FieldRepetitions.Count > 0)
        {
            _recurringServiceCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_recurringServiceCode, fieldData);
        }

        return _recurringServiceCode;
    } 
}

internal HL7V231Field _billingMediaCode;

public HL7V231Field BillingMediaCode
{
    get
    {
        if (_billingMediaCode != null)
        {
            return _billingMediaCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.32",
            Type = @"Field",
            Position = @"PV2.32",
            Name = @"Billing Media Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the account is to be rejected from tape billing. Refer to Chapter 2 , HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _billingMediaCode = new HL7V231Field
        {
            field = message[@"PV2"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_billingMediaCode.field.FieldRepetitions != null && _billingMediaCode.field.FieldRepetitions.Count > 0)
        {
            _billingMediaCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_billingMediaCode, fieldData);
        }

        return _billingMediaCode;
    } 
}

internal HL7V231Field _expectedSurgeryDateAndTime;

public HL7V231Field ExpectedSurgeryDateAndTime
{
    get
    {
        if (_expectedSurgeryDateAndTime != null)
        {
            return _expectedSurgeryDateAndTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.33",
            Type = @"Field",
            Position = @"PV2.33",
            Name = @"Expected Surgery Date & Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time on which the surgery is expected to occur.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.33.1",
                            Type = @"Component",
                            Position = @"PV2.33.1",
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
                        }
        }

        _expectedSurgeryDateAndTime = new HL7V231Field
        {
            field = message[@"PV2"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedSurgeryDateAndTime.field.FieldRepetitions != null && _expectedSurgeryDateAndTime.field.FieldRepetitions.Count > 0)
        {
            _expectedSurgeryDateAndTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_expectedSurgeryDateAndTime, fieldData);
        }

        return _expectedSurgeryDateAndTime;
    } 
}

internal HL7V231Field _militaryPartnershipCode;

public HL7V231Field MilitaryPartnershipCode
{
    get
    {
        if (_militaryPartnershipCode != null)
        {
            return _militaryPartnershipCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.34",
            Type = @"Field",
            Position = @"PV2.34",
            Name = @"Military Partnership Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates that a military facility has contracted with a non-military facility for the use of its services. Refer to Chapter 2, HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _militaryPartnershipCode = new HL7V231Field
        {
            field = message[@"PV2"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_militaryPartnershipCode.field.FieldRepetitions != null && _militaryPartnershipCode.field.FieldRepetitions.Count > 0)
        {
            _militaryPartnershipCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_militaryPartnershipCode, fieldData);
        }

        return _militaryPartnershipCode;
    } 
}

internal HL7V231Field _militaryNonAvailabilityCode;

public HL7V231Field MilitaryNonAvailabilityCode
{
    get
    {
        if (_militaryNonAvailabilityCode != null)
        {
            return _militaryNonAvailabilityCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.35",
            Type = @"Field",
            Position = @"PV2.35",
            Name = @"Military Non-Availability Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether a patient has permission to use a non-military facility for treatment. Refer to Chapter 2 , HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _militaryNonAvailabilityCode = new HL7V231Field
        {
            field = message[@"PV2"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_militaryNonAvailabilityCode.field.FieldRepetitions != null && _militaryNonAvailabilityCode.field.FieldRepetitions.Count > 0)
        {
            _militaryNonAvailabilityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_militaryNonAvailabilityCode, fieldData);
        }

        return _militaryNonAvailabilityCode;
    } 
}

internal HL7V231Field _newbornBabyIndicator;

public HL7V231Field NewbornBabyIndicator
{
    get
    {
        if (_newbornBabyIndicator != null)
        {
            return _newbornBabyIndicator;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.36",
            Type = @"Field",
            Position = @"PV2.36",
            Name = @"Newborn Baby Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether the patient is a baby. Refer to Chapter 2, HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _newbornBabyIndicator = new HL7V231Field
        {
            field = message[@"PV2"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newbornBabyIndicator.field.FieldRepetitions != null && _newbornBabyIndicator.field.FieldRepetitions.Count > 0)
        {
            _newbornBabyIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_newbornBabyIndicator, fieldData);
        }

        return _newbornBabyIndicator;
    } 
}

internal HL7V231Field _babyDetainedIndicator;

public HL7V231Field BabyDetainedIndicator
{
    get
    {
        if (_babyDetainedIndicator != null)
        {
            return _babyDetainedIndicator;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PV2.37",
            Type = @"Field",
            Position = @"PV2.37",
            Name = @"Baby Detained Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the baby is detained after the mother's discharge. Refer to Chapter 2, HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _babyDetainedIndicator = new HL7V231Field
        {
            field = message[@"PV2"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_babyDetainedIndicator.field.FieldRepetitions != null && _babyDetainedIndicator.field.FieldRepetitions.Count > 0)
        {
            _babyDetainedIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_babyDetainedIndicator, fieldData);
        }

        return _babyDetainedIndicator;
    } 
}
    }
}
