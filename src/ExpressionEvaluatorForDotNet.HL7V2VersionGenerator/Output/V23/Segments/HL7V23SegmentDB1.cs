using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentDB1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DB1"; } }

        public string SegmentId { get { return @"DB1"; } }
        
        public string LongName { get { return @"Disability Segment"; } }
        
        public string Description { get { return @"The disability segment contains information related to the disability of a person.  This segment was created instead of adding disability attributes to each segment that contains a person (to which disability may apply).  This is an optional segment that can be used to send disability information about a person already defined by the Patient Administration Chapter.  The disabled person code and identifier allow for the association of the disability information to the person."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
"CH_06",

                    };
            }
        }

        public HL7V23SegmentDB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDDB1;

public HL7V23Field SetIDDB1
{
    get
    {
        if (_setIDDB1 != null)
        {
            return _setIDDB1;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DB1.1",
            Type = @"Field",
            Position = @"DB1.1",
            Name = @"Set ID - DB1",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc",
            Sample = @"",
            Fields = null
        }

        _setIDDB1 = new HL7V23Field
        {
            field = message[@"DB1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDDB1.field.FieldRepetitions != null && _setIDDB1.field.FieldRepetitions.Count > 0)
        {
            _setIDDB1.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDDB1, fieldData);
        }

        return _setIDDB1;
    } 
}

internal HL7V23Field _disabledpersoncode;

public HL7V23Field Disabledpersoncode
{
    get
    {
        if (_disabledpersoncode != null)
        {
            return _disabledpersoncode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DB1.2",
            Type = @"Field",
            Position = @"DB1.2",
            Name = @"Disabled person code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0334",
            TableName = @"Disabled person",
            Description = @"The value of this field indicates to which person the disability information relates in the message.  For example, if the value is PT, the disability information relates to the patient.  Refer to user defined table 0334 - Disabled person for suggested values",
            Sample = @"",
            Fields = null
        }

        _disabledpersoncode = new HL7V23Field
        {
            field = message[@"DB1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabledpersoncode.field.FieldRepetitions != null && _disabledpersoncode.field.FieldRepetitions.Count > 0)
        {
            _disabledpersoncode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_disabledpersoncode, fieldData);
        }

        return _disabledpersoncode;
    } 
}

internal HL7V23Field _disabledpersonidentifier;

public HL7V23Field Disabledpersonidentifier
{
    get
    {
        if (_disabledpersonidentifier != null)
        {
            return _disabledpersonidentifier;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DB1.3",
            Type = @"Field",
            Position = @"DB1.3",
            Name = @"Disabled person identifier",
            Length = 32,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This is the identifier (or identifiers) for the person whose disability information is sent on the segment",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DB1.3.1",
                            Type = @"Component",
                            Position = @"DB1.3.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.2",
                            Type = @"Component",
                            Position = @"DB1.3.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.3",
                            Type = @"Component",
                            Position = @"DB1.3.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.4",
                            Type = @"Component",
                            Position = @"DB1.3.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DB1.3.4.1",
                            Type = @"SubComponent",
                            Position = @"DB1.3.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.4.2",
                            Type = @"SubComponent",
                            Position = @"DB1.3.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.4.3",
                            Type = @"SubComponent",
                            Position = @"DB1.3.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.5",
                            Type = @"Component",
                            Position = @"DB1.3.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.6",
                            Type = @"Component",
                            Position = @"DB1.3.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DB1.3.6.1",
                            Type = @"SubComponent",
                            Position = @"DB1.3.6.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.6.2",
                            Type = @"SubComponent",
                            Position = @"DB1.3.6.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.6.3",
                            Type = @"SubComponent",
                            Position = @"DB1.3.6.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _disabledpersonidentifier = new HL7V23Field
        {
            field = message[@"DB1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabledpersonidentifier.field.FieldRepetitions != null && _disabledpersonidentifier.field.FieldRepetitions.Count > 0)
        {
            _disabledpersonidentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_disabledpersonidentifier, fieldData);
        }

        return _disabledpersonidentifier;
    } 
}

internal HL7V23Field _disabledIndicator;

public HL7V23Field DisabledIndicator
{
    get
    {
        if (_disabledIndicator != null)
        {
            return _disabledIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DB1.4",
            Type = @"Field",
            Position = @"DB1.4",
            Name = @"Disabled Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the person’s visit is a disability visit.  Refer to HL7 table 0136 - Yes/No indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _disabledIndicator = new HL7V23Field
        {
            field = message[@"DB1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabledIndicator.field.FieldRepetitions != null && _disabledIndicator.field.FieldRepetitions.Count > 0)
        {
            _disabledIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_disabledIndicator, fieldData);
        }

        return _disabledIndicator;
    } 
}

internal HL7V23Field _disabilitystartdate;

public HL7V23Field Disabilitystartdate
{
    get
    {
        if (_disabilitystartdate != null)
        {
            return _disabilitystartdate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DB1.5",
            Type = @"Field",
            Position = @"DB1.5",
            Name = @"Disability start date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the date the person became disabled",
            Sample = @"",
            Fields = null
        }

        _disabilitystartdate = new HL7V23Field
        {
            field = message[@"DB1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabilitystartdate.field.FieldRepetitions != null && _disabilitystartdate.field.FieldRepetitions.Count > 0)
        {
            _disabilitystartdate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_disabilitystartdate, fieldData);
        }

        return _disabilitystartdate;
    } 
}

internal HL7V23Field _disabilityenddate;

public HL7V23Field Disabilityenddate
{
    get
    {
        if (_disabilityenddate != null)
        {
            return _disabilityenddate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DB1.6",
            Type = @"Field",
            Position = @"DB1.6",
            Name = @"Disability end date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the ending date of the person’s disability",
            Sample = @"",
            Fields = null
        }

        _disabilityenddate = new HL7V23Field
        {
            field = message[@"DB1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabilityenddate.field.FieldRepetitions != null && _disabilityenddate.field.FieldRepetitions.Count > 0)
        {
            _disabilityenddate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_disabilityenddate, fieldData);
        }

        return _disabilityenddate;
    } 
}

internal HL7V23Field _disabilityreturntoworkdate;

public HL7V23Field Disabilityreturntoworkdate
{
    get
    {
        if (_disabilityreturntoworkdate != null)
        {
            return _disabilityreturntoworkdate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DB1.7",
            Type = @"Field",
            Position = @"DB1.7",
            Name = @"Disability return to work date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the authorized date on which the patient can return to work for a specified disability case",
            Sample = @"",
            Fields = null
        }

        _disabilityreturntoworkdate = new HL7V23Field
        {
            field = message[@"DB1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabilityreturntoworkdate.field.FieldRepetitions != null && _disabilityreturntoworkdate.field.FieldRepetitions.Count > 0)
        {
            _disabilityreturntoworkdate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_disabilityreturntoworkdate, fieldData);
        }

        return _disabilityreturntoworkdate;
    } 
}

internal HL7V23Field _disabilityunabletoworkdate;

public HL7V23Field Disabilityunabletoworkdate
{
    get
    {
        if (_disabilityunabletoworkdate != null)
        {
            return _disabilityunabletoworkdate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DB1.8",
            Type = @"Field",
            Position = @"DB1.8",
            Name = @"Disability unable to work date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the first date in the date span that the patient is unable to work due to disability",
            Sample = @"",
            Fields = null
        }

        _disabilityunabletoworkdate = new HL7V23Field
        {
            field = message[@"DB1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabilityunabletoworkdate.field.FieldRepetitions != null && _disabilityunabletoworkdate.field.FieldRepetitions.Count > 0)
        {
            _disabilityunabletoworkdate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_disabilityunabletoworkdate, fieldData);
        }

        return _disabilityunabletoworkdate;
    } 
}
    }
}
