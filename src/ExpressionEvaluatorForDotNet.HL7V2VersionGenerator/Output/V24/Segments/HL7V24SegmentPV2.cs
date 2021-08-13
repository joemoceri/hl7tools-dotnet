using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentPV2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PV2"; } }

        public string SegmentId { get { return @"PV2"; } }
        
        public string LongName { get { return @"Patient visit - additional information"; } }
        
        public string Description { get { return @"The PV2 segment is a continuation of information contained on the PV1 segment."; } }
        
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

        public HL7V24SegmentPV2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _priorPendingLocation;

public HL7V24Field PriorPendingLocation
{
    get
    {
        if (_priorPendingLocation != null)
        {
            return _priorPendingLocation;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field is required for cancel pending transfer (A26) messages. In all other events it is optional.",
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
                            Description = @"Conditional on person location type (e.g., nursing unit or department or clinic). After floor, most general patient location designation. User-defined Table 0302 - Point of care is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"Patient room. After point of care, most general person location designation. User-defined Table 0303 - Room is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"Patient bed. After room, most general person location designation. User-defined Table 0304 - Bed is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"Subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. Most general person location designation.",
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
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
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
                            Description = @"Location (e.g., Bed) status. User-defined Table 0306 - Location status is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"Person location type is the categorization of the persons location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. Usually includes values such as nursing unit, department, clinic, SNF, physicians office . User-defined Table 0305 - Person location type is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"After facility, most general person location designation. User-defined Table 0307 - Building is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"After building, most general person location designation. User-defined Table 0308 - Floor is used as the HL7 identifier for the user-defined table of values for this component.",
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

        _priorPendingLocation = new HL7V24Field
        {
            field = message[@"PV2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorPendingLocation.field.FieldRepetitions != null && _priorPendingLocation.field.FieldRepetitions.Count > 0)
        {
            _priorPendingLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_priorPendingLocation, fieldData);
        }

        return _priorPendingLocation;
    } 
}

internal HL7V24Field _accommodationCode;

public HL7V24Field AccommodationCode
{
    get
    {
        if (_accommodationCode != null)
        {
            return _accommodationCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.2",
            Type = @"Field",
            Position = @"PV2.2",
            Name = @"Accommodation Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0129",
            TableName = @"Accommodation code",
            Description = @"This field indicates the specific patient accommodations for this visit. Refer to User-defined Table 0129 - Accommodation code for suggested values.",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.2.4",
                            Type = @"Component",
                            Position = @"PV2.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _accommodationCode = new HL7V24Field
        {
            field = message[@"PV2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accommodationCode.field.FieldRepetitions != null && _accommodationCode.field.FieldRepetitions.Count > 0)
        {
            _accommodationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_accommodationCode, fieldData);
        }

        return _accommodationCode;
    } 
}

internal HL7V24Field _admitReason;

public HL7V24Field AdmitReason
{
    get
    {
        if (_admitReason != null)
        {
            return _admitReason;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.3",
            Type = @"Field",
            Position = @"PV2.3",
            Name = @"Admit Reason",
            Length = 250,
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.3.4",
                            Type = @"Component",
                            Position = @"PV2.3.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _admitReason = new HL7V24Field
        {
            field = message[@"PV2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admitReason.field.FieldRepetitions != null && _admitReason.field.FieldRepetitions.Count > 0)
        {
            _admitReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_admitReason, fieldData);
        }

        return _admitReason;
    } 
}

internal HL7V24Field _transferReason;

public HL7V24Field TransferReason
{
    get
    {
        if (_transferReason != null)
        {
            return _transferReason;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.4",
            Type = @"Field",
            Position = @"PV2.4",
            Name = @"Transfer Reason",
            Length = 250,
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.4.4",
                            Type = @"Component",
                            Position = @"PV2.4.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _transferReason = new HL7V24Field
        {
            field = message[@"PV2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transferReason.field.FieldRepetitions != null && _transferReason.field.FieldRepetitions.Count > 0)
        {
            _transferReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_transferReason, fieldData);
        }

        return _transferReason;
    } 
}

internal HL7V24Field _patientValuables;

public HL7V24Field PatientValuables
{
    get
    {
        if (_patientValuables != null)
        {
            return _patientValuables;
        }

        var fieldData = new HL7V24FieldData
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

        _patientValuables = new HL7V24Field
        {
            field = message[@"PV2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientValuables.field.FieldRepetitions != null && _patientValuables.field.FieldRepetitions.Count > 0)
        {
            _patientValuables.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_patientValuables, fieldData);
        }

        return _patientValuables;
    } 
}

internal HL7V24Field _patientValuablesLocation;

public HL7V24Field PatientValuablesLocation
{
    get
    {
        if (_patientValuablesLocation != null)
        {
            return _patientValuablesLocation;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field indicates the location of the patients valuables.",
            Sample = @"",
            Fields = null
        }

        _patientValuablesLocation = new HL7V24Field
        {
            field = message[@"PV2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientValuablesLocation.field.FieldRepetitions != null && _patientValuablesLocation.field.FieldRepetitions.Count > 0)
        {
            _patientValuablesLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_patientValuablesLocation, fieldData);
        }

        return _patientValuablesLocation;
    } 
}

internal HL7V24Field _visitUserCode;

public HL7V24Field VisitUserCode
{
    get
    {
        if (_visitUserCode != null)
        {
            return _visitUserCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.7",
            Type = @"Field",
            Position = @"PV2.7",
            Name = @"Visit User Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0130",
            TableName = @"Visit user code",
            Description = @"This field further categorizes a patients visit with respect to an individual institutions needs, and is expected to be site-specific. Refer to User-defined Table 0130 - Visit user code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _visitUserCode = new HL7V24Field
        {
            field = message[@"PV2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitUserCode.field.FieldRepetitions != null && _visitUserCode.field.FieldRepetitions.Count > 0)
        {
            _visitUserCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_visitUserCode, fieldData);
        }

        return _visitUserCode;
    } 
}

internal HL7V24Field _expectedAdmitDateTime;

public HL7V24Field ExpectedAdmitDateTime
{
    get
    {
        if (_expectedAdmitDateTime != null)
        {
            return _expectedAdmitDateTime;
        }

        var fieldData = new HL7V24FieldData
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.8.2",
                            Type = @"Component",
                            Position = @"PV2.8.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _expectedAdmitDateTime = new HL7V24Field
        {
            field = message[@"PV2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedAdmitDateTime.field.FieldRepetitions != null && _expectedAdmitDateTime.field.FieldRepetitions.Count > 0)
        {
            _expectedAdmitDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_expectedAdmitDateTime, fieldData);
        }

        return _expectedAdmitDateTime;
    } 
}

internal HL7V24Field _expectedDischargeDateTime;

public HL7V24Field ExpectedDischargeDateTime
{
    get
    {
        if (_expectedDischargeDateTime != null)
        {
            return _expectedDischargeDateTime;
        }

        var fieldData = new HL7V24FieldData
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.9.2",
                            Type = @"Component",
                            Position = @"PV2.9.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _expectedDischargeDateTime = new HL7V24Field
        {
            field = message[@"PV2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedDischargeDateTime.field.FieldRepetitions != null && _expectedDischargeDateTime.field.FieldRepetitions.Count > 0)
        {
            _expectedDischargeDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_expectedDischargeDateTime, fieldData);
        }

        return _expectedDischargeDateTime;
    } 
}

internal HL7V24Field _estimatedLengthofInpatientStay;

public HL7V24Field EstimatedLengthofInpatientStay
{
    get
    {
        if (_estimatedLengthofInpatientStay != null)
        {
            return _estimatedLengthofInpatientStay;
        }

        var fieldData = new HL7V24FieldData
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

        _estimatedLengthofInpatientStay = new HL7V24Field
        {
            field = message[@"PV2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_estimatedLengthofInpatientStay.field.FieldRepetitions != null && _estimatedLengthofInpatientStay.field.FieldRepetitions.Count > 0)
        {
            _estimatedLengthofInpatientStay.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_estimatedLengthofInpatientStay, fieldData);
        }

        return _estimatedLengthofInpatientStay;
    } 
}

internal HL7V24Field _actualLengthofInpatientStay;

public HL7V24Field ActualLengthofInpatientStay
{
    get
    {
        if (_actualLengthofInpatientStay != null)
        {
            return _actualLengthofInpatientStay;
        }

        var fieldData = new HL7V24FieldData
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

        _actualLengthofInpatientStay = new HL7V24Field
        {
            field = message[@"PV2"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actualLengthofInpatientStay.field.FieldRepetitions != null && _actualLengthofInpatientStay.field.FieldRepetitions.Count > 0)
        {
            _actualLengthofInpatientStay.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_actualLengthofInpatientStay, fieldData);
        }

        return _actualLengthofInpatientStay;
    } 
}

internal HL7V24Field _visitDescription;

public HL7V24Field VisitDescription
{
    get
    {
        if (_visitDescription != null)
        {
            return _visitDescription;
        }

        var fieldData = new HL7V24FieldData
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

        _visitDescription = new HL7V24Field
        {
            field = message[@"PV2"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitDescription.field.FieldRepetitions != null && _visitDescription.field.FieldRepetitions.Count > 0)
        {
            _visitDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_visitDescription, fieldData);
        }

        return _visitDescription;
    } 
}

internal HL7V24Field _referralSourceCode;

public HL7V24Field ReferralSourceCode
{
    get
    {
        if (_referralSourceCode != null)
        {
            return _referralSourceCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.13",
            Type = @"Field",
            Position = @"PV2.13",
            Name = @"Referral Source Code",
            Length = 250,
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
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.9.19,  FN - family name.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PV2.13.2.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.1",
                            Name = @"Surname",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = @"The atomic element of the person's family name. In most Western usage, this is the person's last name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.2.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.2",
                            Name = @"Own Surname Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.2.3",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.3",
                            Name = @"Own Surname",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.2.4",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.4",
                            Name = @"Surname Prefix From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.2.5",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.5",
                            Name = @"Surname From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.",
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
                            Description = @"First name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.4",
                            Type = @"Component",
                            Position = @"PV2.13.4",
                            Name = @"Second And Further Given Names Or Initials Thereof",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Multiple middle names may be included by separating them with spaces.",
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
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to User-defined Table 0360 - Degree for suggested values.",
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
                            Description = @"User-defined Table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
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
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
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
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
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
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name type for valid values (see Section 2.9.54.7, Name type code (ID)).",
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
                            Description = @"Refer to HL7 Table 0061 - Check digit scheme for valid values.",
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
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
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
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
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
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.16",
                            Type = @"Component",
                            Position = @"PV2.13.16",
                            Name = @"Name Context",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448 - Name context for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PV2.13.16.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.1",
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
                            Id = @"PV2.13.16.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.2",
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
                            Id = @"PV2.13.16.3",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.16.4",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.16.5",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.16.6",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.17",
                            Type = @"Component",
                            Position = @"PV2.13.17",
                            Name = @"Name Validity Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the start and end date/times that define the period during which this name was valid. See section 2.9.14, DR - date/time range for description of subcomponents.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PV2.13.17.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.1",
                            Name = @"Range Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PV2.13.17.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.17.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.17.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.2",
                            Name = @"Range End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PV2.13.17.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.17.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.18",
                            Type = @"Component",
                            Position = @"PV2.13.18",
                            Name = @"Name Assembly Order",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0444",
                            TableName = @"Name assembly order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name assembly orde r for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _referralSourceCode = new HL7V24Field
        {
            field = message[@"PV2"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referralSourceCode.field.FieldRepetitions != null && _referralSourceCode.field.FieldRepetitions.Count > 0)
        {
            _referralSourceCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_referralSourceCode, fieldData);
        }

        return _referralSourceCode;
    } 
}

internal HL7V24Field _previousServiceDate;

public HL7V24Field PreviousServiceDate
{
    get
    {
        if (_previousServiceDate != null)
        {
            return _previousServiceDate;
        }

        var fieldData = new HL7V24FieldData
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

        _previousServiceDate = new HL7V24Field
        {
            field = message[@"PV2"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_previousServiceDate.field.FieldRepetitions != null && _previousServiceDate.field.FieldRepetitions.Count > 0)
        {
            _previousServiceDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_previousServiceDate, fieldData);
        }

        return _previousServiceDate;
    } 
}

internal HL7V24Field _employmentIllnessRelatedIndicator;

public HL7V24Field EmploymentIllnessRelatedIndicator
{
    get
    {
        if (_employmentIllnessRelatedIndicator != null)
        {
            return _employmentIllnessRelatedIndicator;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field specifies whether a patients illness was job-related. Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _employmentIllnessRelatedIndicator = new HL7V24Field
        {
            field = message[@"PV2"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employmentIllnessRelatedIndicator.field.FieldRepetitions != null && _employmentIllnessRelatedIndicator.field.FieldRepetitions.Count > 0)
        {
            _employmentIllnessRelatedIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_employmentIllnessRelatedIndicator, fieldData);
        }

        return _employmentIllnessRelatedIndicator;
    } 
}

internal HL7V24Field _purgeStatusCode;

public HL7V24Field PurgeStatusCode
{
    get
    {
        if (_purgeStatusCode != null)
        {
            return _purgeStatusCode;
        }

        var fieldData = new HL7V24FieldData
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
            TableName = @"Purge status code",
            Description = @"This field contains the purge status code for the account. It is used by the application program to determine purge processing. Refer to User-defined Table 0213 - Purge status code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _purgeStatusCode = new HL7V24Field
        {
            field = message[@"PV2"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_purgeStatusCode.field.FieldRepetitions != null && _purgeStatusCode.field.FieldRepetitions.Count > 0)
        {
            _purgeStatusCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_purgeStatusCode, fieldData);
        }

        return _purgeStatusCode;
    } 
}

internal HL7V24Field _purgeStatusDate;

public HL7V24Field PurgeStatusDate
{
    get
    {
        if (_purgeStatusDate != null)
        {
            return _purgeStatusDate;
        }

        var fieldData = new HL7V24FieldData
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

        _purgeStatusDate = new HL7V24Field
        {
            field = message[@"PV2"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_purgeStatusDate.field.FieldRepetitions != null && _purgeStatusDate.field.FieldRepetitions.Count > 0)
        {
            _purgeStatusDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_purgeStatusDate, fieldData);
        }

        return _purgeStatusDate;
    } 
}

internal HL7V24Field _specialProgramCode;

public HL7V24Field SpecialProgramCode
{
    get
    {
        if (_specialProgramCode != null)
        {
            return _specialProgramCode;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field designates the specific health insurance program for a visit required for healthcare reimbursement. Examples include Child Health Assistance, Elective Surgery Program, Family Planning, etc. Refer to User-defined Table 0214 - Special program codes for suggested values.",
            Sample = @"",
            Fields = null
        }

        _specialProgramCode = new HL7V24Field
        {
            field = message[@"PV2"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialProgramCode.field.FieldRepetitions != null && _specialProgramCode.field.FieldRepetitions.Count > 0)
        {
            _specialProgramCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_specialProgramCode, fieldData);
        }

        return _specialProgramCode;
    } 
}

internal HL7V24Field _retentionIndicator;

public HL7V24Field RetentionIndicator
{
    get
    {
        if (_retentionIndicator != null)
        {
            return _retentionIndicator;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field allows the user to control the financial and demographic purge processes at the visit. It is used to preserve demographic and financial data on specific, high priority visits. Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _retentionIndicator = new HL7V24Field
        {
            field = message[@"PV2"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_retentionIndicator.field.FieldRepetitions != null && _retentionIndicator.field.FieldRepetitions.Count > 0)
        {
            _retentionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_retentionIndicator, fieldData);
        }

        return _retentionIndicator;
    } 
}

internal HL7V24Field _expectedNumberofInsurancePlans;

public HL7V24Field ExpectedNumberofInsurancePlans
{
    get
    {
        if (_expectedNumberofInsurancePlans != null)
        {
            return _expectedNumberofInsurancePlans;
        }

        var fieldData = new HL7V24FieldData
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

        _expectedNumberofInsurancePlans = new HL7V24Field
        {
            field = message[@"PV2"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedNumberofInsurancePlans.field.FieldRepetitions != null && _expectedNumberofInsurancePlans.field.FieldRepetitions.Count > 0)
        {
            _expectedNumberofInsurancePlans.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_expectedNumberofInsurancePlans, fieldData);
        }

        return _expectedNumberofInsurancePlans;
    } 
}

internal HL7V24Field _visitPublicityCode;

public HL7V24Field VisitPublicityCode
{
    get
    {
        if (_visitPublicityCode != null)
        {
            return _visitPublicityCode;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field contains a user-defined code indicating what level of publicity is allowed (e.g., No Publicity, Family Only) for a specific visit. Refer to User-defined Table 0215 - Publicity code for suggested values. Refer to PD1-11 - publicity code for the patient level publicity code.",
            Sample = @"",
            Fields = null
        }

        _visitPublicityCode = new HL7V24Field
        {
            field = message[@"PV2"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitPublicityCode.field.FieldRepetitions != null && _visitPublicityCode.field.FieldRepetitions.Count > 0)
        {
            _visitPublicityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_visitPublicityCode, fieldData);
        }

        return _visitPublicityCode;
    } 
}

internal HL7V24Field _visitProtectionIndicator;

public HL7V24Field VisitProtectionIndicator
{
    get
    {
        if (_visitProtectionIndicator != null)
        {
            return _visitProtectionIndicator;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field identifies the persons protection that determines, in turn, whether access to information about this person should be kept from users who do not have adequate authority for a specific visit. Refer to HL7 Table 0136 - Yes/no indicator for valid values. Refer to PD1-12 - protection indicator for the patient level protection indicator.",
            Sample = @"",
            Fields = null
        }

        _visitProtectionIndicator = new HL7V24Field
        {
            field = message[@"PV2"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitProtectionIndicator.field.FieldRepetitions != null && _visitProtectionIndicator.field.FieldRepetitions.Count > 0)
        {
            _visitProtectionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_visitProtectionIndicator, fieldData);
        }

        return _visitProtectionIndicator;
    } 
}

internal HL7V24Field _clinicOrganizationName;

public HL7V24Field ClinicOrganizationName
{
    get
    {
        if (_clinicOrganizationName != null)
        {
            return _clinicOrganizationName;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.23",
            Type = @"Field",
            Position = @"PV2.23",
            Name = @"Clinic Organization Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the organization name or sub-unit and identifier that is associated with the (visit) episode of care. For example, the Allergy or Oncology Clinic within the healthcare facility might be named.",
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
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational name type for suggested values.",
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
                            Description = @"The check digit scheme codes are defined in HL7 Table 0061 - Check digit scheme.",
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
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component <namespace ID>.",
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
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
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
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to HL7 Table 0203 - Identifier typefor suggested values.",
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
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
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
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _clinicOrganizationName = new HL7V24Field
        {
            field = message[@"PV2"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_clinicOrganizationName.field.FieldRepetitions != null && _clinicOrganizationName.field.FieldRepetitions.Count > 0)
        {
            _clinicOrganizationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_clinicOrganizationName, fieldData);
        }

        return _clinicOrganizationName;
    } 
}

internal HL7V24Field _patientStatusCode;

public HL7V24Field PatientStatusCode
{
    get
    {
        if (_patientStatusCode != null)
        {
            return _patientStatusCode;
        }

        var fieldData = new HL7V24FieldData
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
            TableName = @"Patient status",
            Description = @"This field indicates the status of the episode of care: for instance, Active Inpatient, Discharged Inpatient. Refer to User-defined Table 0216 - Patient status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _patientStatusCode = new HL7V24Field
        {
            field = message[@"PV2"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientStatusCode.field.FieldRepetitions != null && _patientStatusCode.field.FieldRepetitions.Count > 0)
        {
            _patientStatusCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_patientStatusCode, fieldData);
        }

        return _patientStatusCode;
    } 
}

internal HL7V24Field _visitPriorityCode;

public HL7V24Field VisitPriorityCode
{
    get
    {
        if (_visitPriorityCode != null)
        {
            return _visitPriorityCode;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field contains the priority of the visit. Refer to User-defined Table 0217 - Visit priority code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _visitPriorityCode = new HL7V24Field
        {
            field = message[@"PV2"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitPriorityCode.field.FieldRepetitions != null && _visitPriorityCode.field.FieldRepetitions.Count > 0)
        {
            _visitPriorityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_visitPriorityCode, fieldData);
        }

        return _visitPriorityCode;
    } 
}

internal HL7V24Field _previousTreatmentDate;

public HL7V24Field PreviousTreatmentDate
{
    get
    {
        if (_previousTreatmentDate != null)
        {
            return _previousTreatmentDate;
        }

        var fieldData = new HL7V24FieldData
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

        _previousTreatmentDate = new HL7V24Field
        {
            field = message[@"PV2"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_previousTreatmentDate.field.FieldRepetitions != null && _previousTreatmentDate.field.FieldRepetitions.Count > 0)
        {
            _previousTreatmentDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_previousTreatmentDate, fieldData);
        }

        return _previousTreatmentDate;
    } 
}

internal HL7V24Field _expectedDischargeDisposition;

public HL7V24Field ExpectedDischargeDisposition
{
    get
    {
        if (_expectedDischargeDisposition != null)
        {
            return _expectedDischargeDisposition;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field describes what the patients disposition is expected to be at the end of the visit. Refer to User-defined Table 0112 - Discharge disposition for suggested values.",
            Sample = @"",
            Fields = null
        }

        _expectedDischargeDisposition = new HL7V24Field
        {
            field = message[@"PV2"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedDischargeDisposition.field.FieldRepetitions != null && _expectedDischargeDisposition.field.FieldRepetitions.Count > 0)
        {
            _expectedDischargeDisposition.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_expectedDischargeDisposition, fieldData);
        }

        return _expectedDischargeDisposition;
    } 
}

internal HL7V24Field _signatureonFileDate;

public HL7V24Field SignatureonFileDate
{
    get
    {
        if (_signatureonFileDate != null)
        {
            return _signatureonFileDate;
        }

        var fieldData = new HL7V24FieldData
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

        _signatureonFileDate = new HL7V24Field
        {
            field = message[@"PV2"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_signatureonFileDate.field.FieldRepetitions != null && _signatureonFileDate.field.FieldRepetitions.Count > 0)
        {
            _signatureonFileDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_signatureonFileDate, fieldData);
        }

        return _signatureonFileDate;
    } 
}

internal HL7V24Field _firstSimilarIllnessDate;

public HL7V24Field FirstSimilarIllnessDate
{
    get
    {
        if (_firstSimilarIllnessDate != null)
        {
            return _firstSimilarIllnessDate;
        }

        var fieldData = new HL7V24FieldData
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

        _firstSimilarIllnessDate = new HL7V24Field
        {
            field = message[@"PV2"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_firstSimilarIllnessDate.field.FieldRepetitions != null && _firstSimilarIllnessDate.field.FieldRepetitions.Count > 0)
        {
            _firstSimilarIllnessDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_firstSimilarIllnessDate, fieldData);
        }

        return _firstSimilarIllnessDate;
    } 
}

internal HL7V24Field _patientChargeAdjustmentCode;

public HL7V24Field PatientChargeAdjustmentCode
{
    get
    {
        if (_patientChargeAdjustmentCode != null)
        {
            return _patientChargeAdjustmentCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.30",
            Type = @"Field",
            Position = @"PV2.30",
            Name = @"Patient Charge Adjustment Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0218",
            TableName = @"Patient charge adjustment",
            Description = @"This field contains a user-defined code that indicates which adjustments should be made to this patients charges. Refer to User-defined Table 0218 - Charge adjustment for suggested values. This field is the same as GT1-26 - guarantor charge adjustment code .",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.30.4",
                            Type = @"Component",
                            Position = @"PV2.30.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _patientChargeAdjustmentCode = new HL7V24Field
        {
            field = message[@"PV2"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientChargeAdjustmentCode.field.FieldRepetitions != null && _patientChargeAdjustmentCode.field.FieldRepetitions.Count > 0)
        {
            _patientChargeAdjustmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_patientChargeAdjustmentCode, fieldData);
        }

        return _patientChargeAdjustmentCode;
    } 
}

internal HL7V24Field _recurringServiceCode;

public HL7V24Field RecurringServiceCode
{
    get
    {
        if (_recurringServiceCode != null)
        {
            return _recurringServiceCode;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field indicates whether the treatment is continuous. Refer to User-defined Table 0219 - Recurring service for suggested values.",
            Sample = @"",
            Fields = null
        }

        _recurringServiceCode = new HL7V24Field
        {
            field = message[@"PV2"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recurringServiceCode.field.FieldRepetitions != null && _recurringServiceCode.field.FieldRepetitions.Count > 0)
        {
            _recurringServiceCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_recurringServiceCode, fieldData);
        }

        return _recurringServiceCode;
    } 
}

internal HL7V24Field _billingMediaCode;

public HL7V24Field BillingMediaCode
{
    get
    {
        if (_billingMediaCode != null)
        {
            return _billingMediaCode;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field indicates if the account is to be rejected from tape billing. Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _billingMediaCode = new HL7V24Field
        {
            field = message[@"PV2"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_billingMediaCode.field.FieldRepetitions != null && _billingMediaCode.field.FieldRepetitions.Count > 0)
        {
            _billingMediaCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_billingMediaCode, fieldData);
        }

        return _billingMediaCode;
    } 
}

internal HL7V24Field _expectedSurgeryDateandTime;

public HL7V24Field ExpectedSurgeryDateandTime
{
    get
    {
        if (_expectedSurgeryDateandTime != null)
        {
            return _expectedSurgeryDateandTime;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.33",
            Type = @"Field",
            Position = @"PV2.33",
            Name = @"Expected Surgery Date and Time",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.33.2",
                            Type = @"Component",
                            Position = @"PV2.33.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _expectedSurgeryDateandTime = new HL7V24Field
        {
            field = message[@"PV2"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedSurgeryDateandTime.field.FieldRepetitions != null && _expectedSurgeryDateandTime.field.FieldRepetitions.Count > 0)
        {
            _expectedSurgeryDateandTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_expectedSurgeryDateandTime, fieldData);
        }

        return _expectedSurgeryDateandTime;
    } 
}

internal HL7V24Field _militaryPartnershipCode;

public HL7V24Field MilitaryPartnershipCode
{
    get
    {
        if (_militaryPartnershipCode != null)
        {
            return _militaryPartnershipCode;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field indicates that a military healthcare facility has contracted with a non-military healthcare facility for the use of its services. Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _militaryPartnershipCode = new HL7V24Field
        {
            field = message[@"PV2"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_militaryPartnershipCode.field.FieldRepetitions != null && _militaryPartnershipCode.field.FieldRepetitions.Count > 0)
        {
            _militaryPartnershipCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_militaryPartnershipCode, fieldData);
        }

        return _militaryPartnershipCode;
    } 
}

internal HL7V24Field _militaryNonAvailabilityCode;

public HL7V24Field MilitaryNonAvailabilityCode
{
    get
    {
        if (_militaryNonAvailabilityCode != null)
        {
            return _militaryNonAvailabilityCode;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field indicates whether a patient has permission to use a non-military healthcare facility for treatment. Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _militaryNonAvailabilityCode = new HL7V24Field
        {
            field = message[@"PV2"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_militaryNonAvailabilityCode.field.FieldRepetitions != null && _militaryNonAvailabilityCode.field.FieldRepetitions.Count > 0)
        {
            _militaryNonAvailabilityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_militaryNonAvailabilityCode, fieldData);
        }

        return _militaryNonAvailabilityCode;
    } 
}

internal HL7V24Field _newbornBabyIndicator;

public HL7V24Field NewbornBabyIndicator
{
    get
    {
        if (_newbornBabyIndicator != null)
        {
            return _newbornBabyIndicator;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field indicates whether the patient is a baby. Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _newbornBabyIndicator = new HL7V24Field
        {
            field = message[@"PV2"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newbornBabyIndicator.field.FieldRepetitions != null && _newbornBabyIndicator.field.FieldRepetitions.Count > 0)
        {
            _newbornBabyIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_newbornBabyIndicator, fieldData);
        }

        return _newbornBabyIndicator;
    } 
}

internal HL7V24Field _babyDetainedIndicator;

public HL7V24Field BabyDetainedIndicator
{
    get
    {
        if (_babyDetainedIndicator != null)
        {
            return _babyDetainedIndicator;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field indicates if the baby is detained after the mothers discharge. Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _babyDetainedIndicator = new HL7V24Field
        {
            field = message[@"PV2"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_babyDetainedIndicator.field.FieldRepetitions != null && _babyDetainedIndicator.field.FieldRepetitions.Count > 0)
        {
            _babyDetainedIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_babyDetainedIndicator, fieldData);
        }

        return _babyDetainedIndicator;
    } 
}

internal HL7V24Field _modeofArrivalCode;

public HL7V24Field ModeofArrivalCode
{
    get
    {
        if (_modeofArrivalCode != null)
        {
            return _modeofArrivalCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.38",
            Type = @"Field",
            Position = @"PV2.38",
            Name = @"Mode of Arrival Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0430",
            TableName = @"Mode of arrival code",
            Description = @"Identifies how the patient was brought to the healthcare facility. Refer to User-defined Table 0430 - Mode of arrival code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.38.1",
                            Type = @"Component",
                            Position = @"PV2.38.1",
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
                            Id = @"PV2.38.2",
                            Type = @"Component",
                            Position = @"PV2.38.2",
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
                            Id = @"PV2.38.3",
                            Type = @"Component",
                            Position = @"PV2.38.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.38.4",
                            Type = @"Component",
                            Position = @"PV2.38.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.38.5",
                            Type = @"Component",
                            Position = @"PV2.38.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.38.6",
                            Type = @"Component",
                            Position = @"PV2.38.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _modeofArrivalCode = new HL7V24Field
        {
            field = message[@"PV2"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_modeofArrivalCode.field.FieldRepetitions != null && _modeofArrivalCode.field.FieldRepetitions.Count > 0)
        {
            _modeofArrivalCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_modeofArrivalCode, fieldData);
        }

        return _modeofArrivalCode;
    } 
}

internal HL7V24Field _recreationalDrugUseCode;

public HL7V24Field RecreationalDrugUseCode
{
    get
    {
        if (_recreationalDrugUseCode != null)
        {
            return _recreationalDrugUseCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.39",
            Type = @"Field",
            Position = @"PV2.39",
            Name = @"Recreational Drug Use Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0431",
            TableName = @"Recreational drug use code",
            Description = @"This field indicates what recreational drugs the patient uses. It is used for the purpose of room assignment. Refer to User-defined Table 0431 - Recreational drug use code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.39.1",
                            Type = @"Component",
                            Position = @"PV2.39.1",
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
                            Id = @"PV2.39.2",
                            Type = @"Component",
                            Position = @"PV2.39.2",
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
                            Id = @"PV2.39.3",
                            Type = @"Component",
                            Position = @"PV2.39.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.39.4",
                            Type = @"Component",
                            Position = @"PV2.39.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.39.5",
                            Type = @"Component",
                            Position = @"PV2.39.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.39.6",
                            Type = @"Component",
                            Position = @"PV2.39.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _recreationalDrugUseCode = new HL7V24Field
        {
            field = message[@"PV2"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recreationalDrugUseCode.field.FieldRepetitions != null && _recreationalDrugUseCode.field.FieldRepetitions.Count > 0)
        {
            _recreationalDrugUseCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_recreationalDrugUseCode, fieldData);
        }

        return _recreationalDrugUseCode;
    } 
}

internal HL7V24Field _admissionLevelofCareCode;

public HL7V24Field AdmissionLevelofCareCode
{
    get
    {
        if (_admissionLevelofCareCode != null)
        {
            return _admissionLevelofCareCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.40",
            Type = @"Field",
            Position = @"PV2.40",
            Name = @"Admission Level of Care Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0432",
            TableName = @"Admission level of care code",
            Description = @"This field indicates the acuity level assigned to the patient at the time of admission. Refer to User-defined Table 0432 - Admission level of care code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.40.1",
                            Type = @"Component",
                            Position = @"PV2.40.1",
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
                            Id = @"PV2.40.2",
                            Type = @"Component",
                            Position = @"PV2.40.2",
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
                            Id = @"PV2.40.3",
                            Type = @"Component",
                            Position = @"PV2.40.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.40.4",
                            Type = @"Component",
                            Position = @"PV2.40.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.40.5",
                            Type = @"Component",
                            Position = @"PV2.40.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.40.6",
                            Type = @"Component",
                            Position = @"PV2.40.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _admissionLevelofCareCode = new HL7V24Field
        {
            field = message[@"PV2"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admissionLevelofCareCode.field.FieldRepetitions != null && _admissionLevelofCareCode.field.FieldRepetitions.Count > 0)
        {
            _admissionLevelofCareCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_admissionLevelofCareCode, fieldData);
        }

        return _admissionLevelofCareCode;
    } 
}

internal HL7V24Field _precautionCode;

public HL7V24Field PrecautionCode
{
    get
    {
        if (_precautionCode != null)
        {
            return _precautionCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.41",
            Type = @"Field",
            Position = @"PV2.41",
            Name = @"Precaution Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0433",
            TableName = @"Precaution code",
            Description = @"This field indicates non-clinical precautions that need to be taken with the patient. Refer to User-defined Table 0433 - Precaution code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.41.1",
                            Type = @"Component",
                            Position = @"PV2.41.1",
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
                            Id = @"PV2.41.2",
                            Type = @"Component",
                            Position = @"PV2.41.2",
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
                            Id = @"PV2.41.3",
                            Type = @"Component",
                            Position = @"PV2.41.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.41.4",
                            Type = @"Component",
                            Position = @"PV2.41.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.41.5",
                            Type = @"Component",
                            Position = @"PV2.41.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.41.6",
                            Type = @"Component",
                            Position = @"PV2.41.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _precautionCode = new HL7V24Field
        {
            field = message[@"PV2"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_precautionCode.field.FieldRepetitions != null && _precautionCode.field.FieldRepetitions.Count > 0)
        {
            _precautionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_precautionCode, fieldData);
        }

        return _precautionCode;
    } 
}

internal HL7V24Field _patientConditionCode;

public HL7V24Field PatientConditionCode
{
    get
    {
        if (_patientConditionCode != null)
        {
            return _patientConditionCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.42",
            Type = @"Field",
            Position = @"PV2.42",
            Name = @"Patient Condition Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0434",
            TableName = @"Patient condition code",
            Description = @"This field indicates the patients current medical condition for the purpose of communicating to non-medical outside parties, e.g. family, employer, religious minister, media, etc,. Refer to User-defined Table 0434 - Patient condition code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.42.1",
                            Type = @"Component",
                            Position = @"PV2.42.1",
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
                            Id = @"PV2.42.2",
                            Type = @"Component",
                            Position = @"PV2.42.2",
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
                            Id = @"PV2.42.3",
                            Type = @"Component",
                            Position = @"PV2.42.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.42.4",
                            Type = @"Component",
                            Position = @"PV2.42.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.42.5",
                            Type = @"Component",
                            Position = @"PV2.42.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.42.6",
                            Type = @"Component",
                            Position = @"PV2.42.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _patientConditionCode = new HL7V24Field
        {
            field = message[@"PV2"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientConditionCode.field.FieldRepetitions != null && _patientConditionCode.field.FieldRepetitions.Count > 0)
        {
            _patientConditionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_patientConditionCode, fieldData);
        }

        return _patientConditionCode;
    } 
}

internal HL7V24Field _livingWillCode;

public HL7V24Field LivingWillCode
{
    get
    {
        if (_livingWillCode != null)
        {
            return _livingWillCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.43",
            Type = @"Field",
            Position = @"PV2.43",
            Name = @"Living Will Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0315",
            TableName = @"Living will code",
            Description = @"This field indicates whether or not the patient has a living will and, if so, whether a copy of the living will is on file at the healthcare facility. If the patient does not have a living will, the value of this field indicates whether the patient was provided information on living wills. Refer to User-defined Table 0315 - Living will code for suggested values. See also PD1-7 - Living will code.",
            Sample = @"",
            Fields = null
        }

        _livingWillCode = new HL7V24Field
        {
            field = message[@"PV2"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_livingWillCode.field.FieldRepetitions != null && _livingWillCode.field.FieldRepetitions.Count > 0)
        {
            _livingWillCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_livingWillCode, fieldData);
        }

        return _livingWillCode;
    } 
}

internal HL7V24Field _organDonorCode;

public HL7V24Field OrganDonorCode
{
    get
    {
        if (_organDonorCode != null)
        {
            return _organDonorCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.44",
            Type = @"Field",
            Position = @"PV2.44",
            Name = @"Organ Donor Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0316",
            TableName = @"Organ donor code",
            Description = @"This field indicate whether the patient wants to donate his/her organs and whether an organ donor card or similar documentation is on file with the healthcare organization. Refer to User-defined Table 0316 - Organ donor code for suggested values. See also PD1-8 - Organ donor.",
            Sample = @"",
            Fields = null
        }

        _organDonorCode = new HL7V24Field
        {
            field = message[@"PV2"][44],
            fieldData = fieldData
        };

        // check for repetitions
        if (_organDonorCode.field.FieldRepetitions != null && _organDonorCode.field.FieldRepetitions.Count > 0)
        {
            _organDonorCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_organDonorCode, fieldData);
        }

        return _organDonorCode;
    } 
}

internal HL7V24Field _advanceDirectiveCode;

public HL7V24Field AdvanceDirectiveCode
{
    get
    {
        if (_advanceDirectiveCode != null)
        {
            return _advanceDirectiveCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.45",
            Type = @"Field",
            Position = @"PV2.45",
            Name = @"Advance Directive Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0435",
            TableName = @"Advance directive code",
            Description = @"This field indicates the patients instructions to the healthcare facility. Refer to User-defined Table 0435 - Advance directive code for suggested values. See also PD1-15 - Advance directive code .",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.45.1",
                            Type = @"Component",
                            Position = @"PV2.45.1",
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
                            Id = @"PV2.45.2",
                            Type = @"Component",
                            Position = @"PV2.45.2",
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
                            Id = @"PV2.45.3",
                            Type = @"Component",
                            Position = @"PV2.45.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.45.4",
                            Type = @"Component",
                            Position = @"PV2.45.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.45.5",
                            Type = @"Component",
                            Position = @"PV2.45.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.45.6",
                            Type = @"Component",
                            Position = @"PV2.45.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _advanceDirectiveCode = new HL7V24Field
        {
            field = message[@"PV2"][45],
            fieldData = fieldData
        };

        // check for repetitions
        if (_advanceDirectiveCode.field.FieldRepetitions != null && _advanceDirectiveCode.field.FieldRepetitions.Count > 0)
        {
            _advanceDirectiveCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_advanceDirectiveCode, fieldData);
        }

        return _advanceDirectiveCode;
    } 
}

internal HL7V24Field _patientStatusEffectiveDate;

public HL7V24Field PatientStatusEffectiveDate
{
    get
    {
        if (_patientStatusEffectiveDate != null)
        {
            return _patientStatusEffectiveDate;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.46",
            Type = @"Field",
            Position = @"PV2.46",
            Name = @"Patient Status Effective Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the effective date for PV2-24 - Patient Status .",
            Sample = @"",
            Fields = null
        }

        _patientStatusEffectiveDate = new HL7V24Field
        {
            field = message[@"PV2"][46],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientStatusEffectiveDate.field.FieldRepetitions != null && _patientStatusEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            _patientStatusEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_patientStatusEffectiveDate, fieldData);
        }

        return _patientStatusEffectiveDate;
    } 
}

internal HL7V24Field _expectedLOAReturnDateTime;

public HL7V24Field ExpectedLOAReturnDateTime
{
    get
    {
        if (_expectedLOAReturnDateTime != null)
        {
            return _expectedLOAReturnDateTime;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"PV2.47",
            Type = @"Field",
            Position = @"PV2.47",
            Name = @"Expected LOA Return Date/Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is conditionally required for A21 - Patient goes on LOA. It may be populated in A22 - Patient returns from LOA as well as in the A53 - Cancel LOA for a patient and the A54 - Cancel patient returns from LOA triggers. This field contains the date/time that the patient is expected to return from LOA.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.47.1",
                            Type = @"Component",
                            Position = @"PV2.47.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.47.2",
                            Type = @"Component",
                            Position = @"PV2.47.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _expectedLOAReturnDateTime = new HL7V24Field
        {
            field = message[@"PV2"][47],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedLOAReturnDateTime.field.FieldRepetitions != null && _expectedLOAReturnDateTime.field.FieldRepetitions.Count > 0)
        {
            _expectedLOAReturnDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_expectedLOAReturnDateTime, fieldData);
        }

        return _expectedLOAReturnDateTime;
    } 
}
    }
}
