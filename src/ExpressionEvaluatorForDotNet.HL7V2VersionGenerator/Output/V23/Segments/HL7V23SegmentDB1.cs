using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentDB1
    {
        public readonly HL7V2Message message;

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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = 
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
                            FieldDatas = 
                        new HL7V2FieldData
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
                        },
                        
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
                            FieldDatas = 
                        new HL7V2FieldData
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
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentDB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field setIDDB1;

public HL7V23Field SetIDDB1
{
    get
    {
        if (setIDDB1 != null)
        {
            return setIDDB1;
        }

        setIDDB1 = new HL7V23Field
        {
            field = message[@"DB1"][1],
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
        };

        

        

        

        return setIDDB1;
    } 
}
internal HL7V23Field disabledpersoncode;

public HL7V23Field Disabledpersoncode
{
    get
    {
        if (disabledpersoncode != null)
        {
            return disabledpersoncode;
        }

        disabledpersoncode = new HL7V23Field
        {
            field = message[@"DB1"][2],
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
        };

        

        

        

        return disabledpersoncode;
    } 
}
internal HL7V23Field disabledpersonidentifier;

public HL7V23Field Disabledpersonidentifier
{
    get
    {
        if (disabledpersonidentifier != null)
        {
            return disabledpersonidentifier;
        }

        disabledpersonidentifier = new HL7V23Field
        {
            field = message[@"DB1"][3],
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
        };

        

        

        

        return disabledpersonidentifier;
    } 
}
internal HL7V23Field disabledIndicator;

public HL7V23Field DisabledIndicator
{
    get
    {
        if (disabledIndicator != null)
        {
            return disabledIndicator;
        }

        disabledIndicator = new HL7V23Field
        {
            field = message[@"DB1"][4],
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
        };

        

        

        

        return disabledIndicator;
    } 
}
internal HL7V23Field disabilitystartdate;

public HL7V23Field Disabilitystartdate
{
    get
    {
        if (disabilitystartdate != null)
        {
            return disabilitystartdate;
        }

        disabilitystartdate = new HL7V23Field
        {
            field = message[@"DB1"][5],
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
        };

        

        

        

        return disabilitystartdate;
    } 
}
internal HL7V23Field disabilityenddate;

public HL7V23Field Disabilityenddate
{
    get
    {
        if (disabilityenddate != null)
        {
            return disabilityenddate;
        }

        disabilityenddate = new HL7V23Field
        {
            field = message[@"DB1"][6],
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
        };

        

        

        

        return disabilityenddate;
    } 
}
internal HL7V23Field disabilityreturntoworkdate;

public HL7V23Field Disabilityreturntoworkdate
{
    get
    {
        if (disabilityreturntoworkdate != null)
        {
            return disabilityreturntoworkdate;
        }

        disabilityreturntoworkdate = new HL7V23Field
        {
            field = message[@"DB1"][7],
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
        };

        

        

        

        return disabilityreturntoworkdate;
    } 
}
internal HL7V23Field disabilityunabletoworkdate;

public HL7V23Field Disabilityunabletoworkdate
{
    get
    {
        if (disabilityunabletoworkdate != null)
        {
            return disabilityunabletoworkdate;
        }

        disabilityunabletoworkdate = new HL7V23Field
        {
            field = message[@"DB1"][8],
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
        };

        

        

        

        return disabilityunabletoworkdate;
    } 
}

    }
}
