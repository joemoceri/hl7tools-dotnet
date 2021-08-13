using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentRMI
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RMI"; } }

        public string SegmentId { get { return @"RMI"; } }
        
        public string LongName { get { return @"Risk Management Incident"; } }
        
        public string Description { get { return @"The RMI segment is used to report an occurrence of an incident event pertaining or attaching to a patient encounter."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V24SegmentRMI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _riskManagementIncidentCode;

public HL7V24Field RiskManagementIncidentCode
{
    get
    {
        if (_riskManagementIncidentCode != null)
        {
            return _riskManagementIncidentCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RMI.1",
            Type = @"Field",
            Position = @"RMI.1",
            Name = @"Risk Management Incident Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0427",
            TableName = @"Risk management incident code",
            Description = @"A code depicting the incident that occurred during a patients stay. Refer to User-defined Table 0427 - Risk management incident code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RMI.1.1",
                            Type = @"Component",
                            Position = @"RMI.1.1",
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
                            Id = @"RMI.1.2",
                            Type = @"Component",
                            Position = @"RMI.1.2",
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
                            Id = @"RMI.1.3",
                            Type = @"Component",
                            Position = @"RMI.1.3",
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
                            Id = @"RMI.1.4",
                            Type = @"Component",
                            Position = @"RMI.1.4",
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
                            Id = @"RMI.1.5",
                            Type = @"Component",
                            Position = @"RMI.1.5",
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
                            Id = @"RMI.1.6",
                            Type = @"Component",
                            Position = @"RMI.1.6",
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

        _riskManagementIncidentCode = new HL7V24Field
        {
            field = message[@"RMI"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_riskManagementIncidentCode.field.FieldRepetitions != null && _riskManagementIncidentCode.field.FieldRepetitions.Count > 0)
        {
            _riskManagementIncidentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_riskManagementIncidentCode, fieldData);
        }

        return _riskManagementIncidentCode;
    } 
}

internal HL7V24Field _dateTimeIncident;

public HL7V24Field DateTimeIncident
{
    get
    {
        if (_dateTimeIncident != null)
        {
            return _dateTimeIncident;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RMI.2",
            Type = @"Field",
            Position = @"RMI.2",
            Name = @"Date/Time Incident",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time the Risk Management Incident identified in RMI-1 - Risk management incident code occurred.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RMI.2.1",
                            Type = @"Component",
                            Position = @"RMI.2.1",
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
                            Id = @"RMI.2.2",
                            Type = @"Component",
                            Position = @"RMI.2.2",
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

        _dateTimeIncident = new HL7V24Field
        {
            field = message[@"RMI"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeIncident.field.FieldRepetitions != null && _dateTimeIncident.field.FieldRepetitions.Count > 0)
        {
            _dateTimeIncident.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_dateTimeIncident, fieldData);
        }

        return _dateTimeIncident;
    } 
}

internal HL7V24Field _incidentTypeCode;

public HL7V24Field IncidentTypeCode
{
    get
    {
        if (_incidentTypeCode != null)
        {
            return _incidentTypeCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RMI.3",
            Type = @"Field",
            Position = @"RMI.3",
            Name = @"Incident Type Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0428",
            TableName = @"Incident type code",
            Description = @"A code depicting a classification of the incident type. Refer to User-defined Table 0428 - Incident type code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RMI.3.1",
                            Type = @"Component",
                            Position = @"RMI.3.1",
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
                            Id = @"RMI.3.2",
                            Type = @"Component",
                            Position = @"RMI.3.2",
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
                            Id = @"RMI.3.3",
                            Type = @"Component",
                            Position = @"RMI.3.3",
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
                            Id = @"RMI.3.4",
                            Type = @"Component",
                            Position = @"RMI.3.4",
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
                            Id = @"RMI.3.5",
                            Type = @"Component",
                            Position = @"RMI.3.5",
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
                            Id = @"RMI.3.6",
                            Type = @"Component",
                            Position = @"RMI.3.6",
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

        _incidentTypeCode = new HL7V24Field
        {
            field = message[@"RMI"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_incidentTypeCode.field.FieldRepetitions != null && _incidentTypeCode.field.FieldRepetitions.Count > 0)
        {
            _incidentTypeCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_incidentTypeCode, fieldData);
        }

        return _incidentTypeCode;
    } 
}
    }
}
