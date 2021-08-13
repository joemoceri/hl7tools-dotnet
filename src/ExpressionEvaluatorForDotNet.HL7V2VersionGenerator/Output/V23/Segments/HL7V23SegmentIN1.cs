using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentIN1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IN1"; } }

        public string SegmentId { get { return @"IN1"; } }
        
        public string LongName { get { return @"Insurance"; } }
        
        public string Description { get { return @"The IN1 segment contains insurance policy coverage information necessary to produce properly pro-rated and patient and insurance bills."; } }
        
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

        public HL7V23SegmentIN1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDInsurance;

public HL7V23Field SetIDInsurance
{
    get
    {
        if (_setIDInsurance != null)
        {
            return _setIDInsurance;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.1",
            Type = @"Field",
            Position = @"IN1.1",
            Name = @"Set ID - Insurance",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"IN1-1-set ID contains the  number that identifies this transaction.  For the first occurrence the sequence number shall be 1, for the second occurrence it shall be 2, etc",
            Sample = @"",
            Fields = null
        }

        _setIDInsurance = new HL7V23Field
        {
            field = message[@"IN1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDInsurance.field.FieldRepetitions != null && _setIDInsurance.field.FieldRepetitions.Count > 0)
        {
            _setIDInsurance.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDInsurance, fieldData);
        }

        return _setIDInsurance;
    } 
}

internal HL7V23Field _insurancePlanID;

public HL7V23Field InsurancePlanID
{
    get
    {
        if (_insurancePlanID != null)
        {
            return _insurancePlanID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.2",
            Type = @"Field",
            Position = @"IN1.2",
            Name = @"Insurance Plan ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0072",
            TableName = @"Insurance plan ID",
            Description = @"This field contains a unique identifier for the insurance plan.  Refer to user-defined table 0072 - Insurance plan ID.  To eliminate a plan, the plan could be sent with null values in each subsequent element.  If the respective systems can support it, a null value can be sent in the plan field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.2.1",
                            Type = @"Component",
                            Position = @"IN1.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.2.2",
                            Type = @"Component",
                            Position = @"IN1.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.2.3",
                            Type = @"Component",
                            Position = @"IN1.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.2.4",
                            Type = @"Component",
                            Position = @"IN1.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.2.5",
                            Type = @"Component",
                            Position = @"IN1.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.2.6",
                            Type = @"Component",
                            Position = @"IN1.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _insurancePlanID = new HL7V23Field
        {
            field = message[@"IN1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insurancePlanID.field.FieldRepetitions != null && _insurancePlanID.field.FieldRepetitions.Count > 0)
        {
            _insurancePlanID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insurancePlanID, fieldData);
        }

        return _insurancePlanID;
    } 
}

internal HL7V23Field _insuranceCompanyID;

public HL7V23Field InsuranceCompanyID
{
    get
    {
        if (_insuranceCompanyID != null)
        {
            return _insuranceCompanyID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.3",
            Type = @"Field",
            Position = @"IN1.3",
            Name = @"Insurance Company ID",
            Length = 59,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains a unique identifier the insurance company.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.3.1",
                            Type = @"Component",
                            Position = @"IN1.3.1",
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
                            Id = @"IN1.3.2",
                            Type = @"Component",
                            Position = @"IN1.3.2",
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
                            Id = @"IN1.3.3",
                            Type = @"Component",
                            Position = @"IN1.3.3",
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
                            Id = @"IN1.3.4",
                            Type = @"Component",
                            Position = @"IN1.3.4",
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
                            Id = @"IN1.3.4.1",
                            Type = @"SubComponent",
                            Position = @"IN1.3.4.1",
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
                            Id = @"IN1.3.4.2",
                            Type = @"SubComponent",
                            Position = @"IN1.3.4.2",
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
                            Id = @"IN1.3.4.3",
                            Type = @"SubComponent",
                            Position = @"IN1.3.4.3",
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
                            Id = @"IN1.3.5",
                            Type = @"Component",
                            Position = @"IN1.3.5",
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
                            Id = @"IN1.3.6",
                            Type = @"Component",
                            Position = @"IN1.3.6",
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
                            Id = @"IN1.3.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.3.6.1",
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
                            Id = @"IN1.3.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.3.6.2",
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
                            Id = @"IN1.3.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.3.6.3",
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

        _insuranceCompanyID = new HL7V23Field
        {
            field = message[@"IN1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyID.field.FieldRepetitions != null && _insuranceCompanyID.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuranceCompanyID, fieldData);
        }

        return _insuranceCompanyID;
    } 
}

internal HL7V23Field _insuranceCompanyName;

public HL7V23Field InsuranceCompanyName
{
    get
    {
        if (_insuranceCompanyName != null)
        {
            return _insuranceCompanyName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.4",
            Type = @"Field",
            Position = @"IN1.4",
            Name = @"Insurance Company Name",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the insurance company.  Multiple names for the same insurance company may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.4.1",
                            Type = @"Component",
                            Position = @"IN1.4.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.2",
                            Type = @"Component",
                            Position = @"IN1.4.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name.  Refer to user-defined table 0204 - Organizational name type for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.3",
                            Type = @"Component",
                            Position = @"IN1.4.3",
                            Name = @"ID Number",
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
                            Id = @"IN1.4.4",
                            Type = @"Component",
                            Position = @"IN1.4.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.5",
                            Type = @"Component",
                            Position = @"IN1.4.5",
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
                            Id = @"IN1.4.6",
                            Type = @"Component",
                            Position = @"IN1.4.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.4.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.4.6.1",
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
                            Id = @"IN1.4.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.4.6.2",
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
                            Id = @"IN1.4.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.4.6.3",
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
                            Id = @"IN1.4.7",
                            Type = @"Component",
                            Position = @"IN1.4.7",
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
                            Id = @"IN1.4.8",
                            Type = @"Component",
                            Position = @"IN1.4.8",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility is a unique identifier of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.4.8.1",
                            Type = @"SubComponent",
                            Position = @"IN1.4.8.1",
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
                            Id = @"IN1.4.8.2",
                            Type = @"SubComponent",
                            Position = @"IN1.4.8.2",
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
                            Id = @"IN1.4.8.3",
                            Type = @"SubComponent",
                            Position = @"IN1.4.8.3",
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

        _insuranceCompanyName = new HL7V23Field
        {
            field = message[@"IN1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyName.field.FieldRepetitions != null && _insuranceCompanyName.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuranceCompanyName, fieldData);
        }

        return _insuranceCompanyName;
    } 
}

internal HL7V23Field _insuranceCompanyAddress;

public HL7V23Field InsuranceCompanyAddress
{
    get
    {
        if (_insuranceCompanyAddress != null)
        {
            return _insuranceCompanyAddress;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.5",
            Type = @"Field",
            Position = @"IN1.5",
            Name = @"Insurance Company Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of the insurance company.  Multiple addresses for the same insurance company may be sent in this field.  The mailing address is assumed to be in the first repetition.  When the mailing address is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.5.1",
                            Type = @"Component",
                            Position = @"IN1.5.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.2",
                            Type = @"Component",
                            Position = @"IN1.5.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address.  In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.3",
                            Type = @"Component",
                            Position = @"IN1.5.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.4",
                            Type = @"Component",
                            Position = @"IN1.5.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"tate or province should be represented by the official postal service codes for that country",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.5",
                            Type = @"Component",
                            Position = @"IN1.5.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.6",
                            Type = @"Component",
                            Position = @"IN1.5.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address.  ISO 3166 provides a list of country codes that may be used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.7",
                            Type = @"Component",
                            Position = @"IN1.5.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.8",
                            Type = @"Component",
                            Position = @"IN1.5.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes country, bioregion, SMSA, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.9",
                            Type = @"Component",
                            Position = @"IN1.5.9",
                            Name = @"County/parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. Refer to user-defined table 0289 - County/parish.  When this component is used to represent the county (or parish), component 8 “other geographic designation” should not duplicate it (i.e., the use of “other geographic designation” to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).

Allowable values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.10",
                            Type = @"Component",
                            Position = @"IN1.5.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census track in which the specified address resides. Refer to user-defined table 0288 - Census tract. 
Allowable Values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _insuranceCompanyAddress = new HL7V23Field
        {
            field = message[@"IN1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyAddress.field.FieldRepetitions != null && _insuranceCompanyAddress.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuranceCompanyAddress, fieldData);
        }

        return _insuranceCompanyAddress;
    } 
}

internal HL7V23Field _insuranceCoContactPerson;

public HL7V23Field InsuranceCoContactPerson
{
    get
    {
        if (_insuranceCoContactPerson != null)
        {
            return _insuranceCoContactPerson;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.6",
            Type = @"Field",
            Position = @"IN1.6",
            Name = @"Insurance Co. Contact Person",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the person who should be contacted at the insurance company.  Multiple names for the same contact person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.6.1",
                            Type = @"Component",
                            Position = @"IN1.6.1",
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
                            Id = @"IN1.6.2",
                            Type = @"Component",
                            Position = @"IN1.6.2",
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
                            Id = @"IN1.6.3",
                            Type = @"Component",
                            Position = @"IN1.6.3",
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
                            Id = @"IN1.6.4",
                            Type = @"Component",
                            Position = @"IN1.6.4",
                            Name = @"Suffix",
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
                            Id = @"IN1.6.5",
                            Type = @"Component",
                            Position = @"IN1.6.5",
                            Name = @"Prefix",
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
                            Id = @"IN1.6.6",
                            Type = @"Component",
                            Position = @"IN1.6.6",
                            Name = @"Degree",
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
                            Id = @"IN1.6.7",
                            Type = @"Component",
                            Position = @"IN1.6.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.8",
                            Type = @"Component",
                            Position = @"IN1.6.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _insuranceCoContactPerson = new HL7V23Field
        {
            field = message[@"IN1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCoContactPerson.field.FieldRepetitions != null && _insuranceCoContactPerson.field.FieldRepetitions.Count > 0)
        {
            _insuranceCoContactPerson.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuranceCoContactPerson, fieldData);
        }

        return _insuranceCoContactPerson;
    } 
}

internal HL7V23Field _insuranceCoPhoneNumber;

public HL7V23Field InsuranceCoPhoneNumber
{
    get
    {
        if (_insuranceCoPhoneNumber != null)
        {
            return _insuranceCoPhoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.7",
            Type = @"Field",
            Position = @"IN1.7",
            Name = @"Insurance Co Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the phone number of the insurance company.  Multiple phone numbers for the same insurance company may be sent in this field.  The primary phone number is assumed to be in the first repetition.  When the primary phone number is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.7.1",
                            Type = @"Component",
                            Position = @"IN1.7.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.7.2",
                            Type = @"Component",
                            Position = @"IN1.7.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.7.3",
                            Type = @"Component",
                            Position = @"IN1.7.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.7.4",
                            Type = @"Component",
                            Position = @"IN1.7.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.7.5",
                            Type = @"Component",
                            Position = @"IN1.7.5",
                            Name = @"Country Code",
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
                            Id = @"IN1.7.6",
                            Type = @"Component",
                            Position = @"IN1.7.6",
                            Name = @"Area/city Code",
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
                            Id = @"IN1.7.7",
                            Type = @"Component",
                            Position = @"IN1.7.7",
                            Name = @"Phone Number",
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
                            Id = @"IN1.7.8",
                            Type = @"Component",
                            Position = @"IN1.7.8",
                            Name = @"Extension",
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
                            Id = @"IN1.7.9",
                            Type = @"Component",
                            Position = @"IN1.7.9",
                            Name = @"Any Text",
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

        _insuranceCoPhoneNumber = new HL7V23Field
        {
            field = message[@"IN1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCoPhoneNumber.field.FieldRepetitions != null && _insuranceCoPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _insuranceCoPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuranceCoPhoneNumber, fieldData);
        }

        return _insuranceCoPhoneNumber;
    } 
}

internal HL7V23Field _groupNumber;

public HL7V23Field GroupNumber
{
    get
    {
        if (_groupNumber != null)
        {
            return _groupNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.8",
            Type = @"Field",
            Position = @"IN1.8",
            Name = @"Group Number",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @" This field contains the group number of the insured’s insurance",
            Sample = @"",
            Fields = null
        }

        _groupNumber = new HL7V23Field
        {
            field = message[@"IN1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_groupNumber.field.FieldRepetitions != null && _groupNumber.field.FieldRepetitions.Count > 0)
        {
            _groupNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_groupNumber, fieldData);
        }

        return _groupNumber;
    } 
}

internal HL7V23Field _groupName;

public HL7V23Field GroupName
{
    get
    {
        if (_groupName != null)
        {
            return _groupName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.9",
            Type = @"Field",
            Position = @"IN1.9",
            Name = @"Group Name",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the group name of the insured’s insurance.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.9.1",
                            Type = @"Component",
                            Position = @"IN1.9.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.2",
                            Type = @"Component",
                            Position = @"IN1.9.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name.  Refer to user-defined table 0204 - Organizational name type for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.3",
                            Type = @"Component",
                            Position = @"IN1.9.3",
                            Name = @"ID Number",
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
                            Id = @"IN1.9.4",
                            Type = @"Component",
                            Position = @"IN1.9.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.5",
                            Type = @"Component",
                            Position = @"IN1.9.5",
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
                            Id = @"IN1.9.6",
                            Type = @"Component",
                            Position = @"IN1.9.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.9.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.9.6.1",
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
                            Id = @"IN1.9.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.9.6.2",
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
                            Id = @"IN1.9.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.9.6.3",
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
                            Id = @"IN1.9.7",
                            Type = @"Component",
                            Position = @"IN1.9.7",
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
                            Id = @"IN1.9.8",
                            Type = @"Component",
                            Position = @"IN1.9.8",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility is a unique identifier of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.9.8.1",
                            Type = @"SubComponent",
                            Position = @"IN1.9.8.1",
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
                            Id = @"IN1.9.8.2",
                            Type = @"SubComponent",
                            Position = @"IN1.9.8.2",
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
                            Id = @"IN1.9.8.3",
                            Type = @"SubComponent",
                            Position = @"IN1.9.8.3",
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

        _groupName = new HL7V23Field
        {
            field = message[@"IN1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_groupName.field.FieldRepetitions != null && _groupName.field.FieldRepetitions.Count > 0)
        {
            _groupName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_groupName, fieldData);
        }

        return _groupName;
    } 
}

internal HL7V23Field _insuredsgroupemployerID;

public HL7V23Field InsuredsgroupemployerID
{
    get
    {
        if (_insuredsgroupemployerID != null)
        {
            return _insuredsgroupemployerID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.10",
            Type = @"Field",
            Position = @"IN1.10",
            Name = @"Insured's group employer ID",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field holds the group employer ID for the insured’s insurance",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.10.1",
                            Type = @"Component",
                            Position = @"IN1.10.1",
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
                            Id = @"IN1.10.2",
                            Type = @"Component",
                            Position = @"IN1.10.2",
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
                            Id = @"IN1.10.3",
                            Type = @"Component",
                            Position = @"IN1.10.3",
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
                            Id = @"IN1.10.4",
                            Type = @"Component",
                            Position = @"IN1.10.4",
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
                            Id = @"IN1.10.4.1",
                            Type = @"SubComponent",
                            Position = @"IN1.10.4.1",
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
                            Id = @"IN1.10.4.2",
                            Type = @"SubComponent",
                            Position = @"IN1.10.4.2",
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
                            Id = @"IN1.10.4.3",
                            Type = @"SubComponent",
                            Position = @"IN1.10.4.3",
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
                            Id = @"IN1.10.5",
                            Type = @"Component",
                            Position = @"IN1.10.5",
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
                            Id = @"IN1.10.6",
                            Type = @"Component",
                            Position = @"IN1.10.6",
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
                            Id = @"IN1.10.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.10.6.1",
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
                            Id = @"IN1.10.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.10.6.2",
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
                            Id = @"IN1.10.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.10.6.3",
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

        _insuredsgroupemployerID = new HL7V23Field
        {
            field = message[@"IN1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsgroupemployerID.field.FieldRepetitions != null && _insuredsgroupemployerID.field.FieldRepetitions.Count > 0)
        {
            _insuredsgroupemployerID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsgroupemployerID, fieldData);
        }

        return _insuredsgroupemployerID;
    } 
}

internal HL7V23Field _insuredsGroupEmpName;

public HL7V23Field InsuredsGroupEmpName
{
    get
    {
        if (_insuredsGroupEmpName != null)
        {
            return _insuredsGroupEmpName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.11",
            Type = @"Field",
            Position = @"IN1.11",
            Name = @"Insured's Group Emp Name",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the employer that provides the employee’s insurance.  Multiple names for the same employer may be sent in this sequence.  The legal name must be sent first.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.11.1",
                            Type = @"Component",
                            Position = @"IN1.11.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.2",
                            Type = @"Component",
                            Position = @"IN1.11.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name.  Refer to user-defined table 0204 - Organizational name type for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.3",
                            Type = @"Component",
                            Position = @"IN1.11.3",
                            Name = @"ID Number",
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
                            Id = @"IN1.11.4",
                            Type = @"Component",
                            Position = @"IN1.11.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.5",
                            Type = @"Component",
                            Position = @"IN1.11.5",
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
                            Id = @"IN1.11.6",
                            Type = @"Component",
                            Position = @"IN1.11.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.11.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.11.6.1",
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
                            Id = @"IN1.11.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.11.6.2",
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
                            Id = @"IN1.11.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.11.6.3",
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
                            Id = @"IN1.11.7",
                            Type = @"Component",
                            Position = @"IN1.11.7",
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
                            Id = @"IN1.11.8",
                            Type = @"Component",
                            Position = @"IN1.11.8",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility is a unique identifier of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.11.8.1",
                            Type = @"SubComponent",
                            Position = @"IN1.11.8.1",
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
                            Id = @"IN1.11.8.2",
                            Type = @"SubComponent",
                            Position = @"IN1.11.8.2",
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
                            Id = @"IN1.11.8.3",
                            Type = @"SubComponent",
                            Position = @"IN1.11.8.3",
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

        _insuredsGroupEmpName = new HL7V23Field
        {
            field = message[@"IN1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsGroupEmpName.field.FieldRepetitions != null && _insuredsGroupEmpName.field.FieldRepetitions.Count > 0)
        {
            _insuredsGroupEmpName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsGroupEmpName, fieldData);
        }

        return _insuredsGroupEmpName;
    } 
}

internal HL7V23Field _planEffectiveDate;

public HL7V23Field PlanEffectiveDate
{
    get
    {
        if (_planEffectiveDate != null)
        {
            return _planEffectiveDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.12",
            Type = @"Field",
            Position = @"IN1.12",
            Name = @"Plan Effective Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the insurance goes into effect",
            Sample = @"",
            Fields = null
        }

        _planEffectiveDate = new HL7V23Field
        {
            field = message[@"IN1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_planEffectiveDate.field.FieldRepetitions != null && _planEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            _planEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_planEffectiveDate, fieldData);
        }

        return _planEffectiveDate;
    } 
}

internal HL7V23Field _planExpirationDate;

public HL7V23Field PlanExpirationDate
{
    get
    {
        if (_planExpirationDate != null)
        {
            return _planExpirationDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.13",
            Type = @"Field",
            Position = @"IN1.13",
            Name = @"Plan Expiration Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the last date of service that the insurance will cover or be responsible for.",
            Sample = @"",
            Fields = null
        }

        _planExpirationDate = new HL7V23Field
        {
            field = message[@"IN1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_planExpirationDate.field.FieldRepetitions != null && _planExpirationDate.field.FieldRepetitions.Count > 0)
        {
            _planExpirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_planExpirationDate, fieldData);
        }

        return _planExpirationDate;
    } 
}

internal HL7V23Field _authorizationInformation;

public HL7V23Field AuthorizationInformation
{
    get
    {
        if (_authorizationInformation != null)
        {
            return _authorizationInformation;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.14",
            Type = @"Field",
            Position = @"IN1.14",
            Name = @"Authorization Information",
            Length = 55,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_AUI",
            DataTypeName = @"Authorization Information",
            TableId = null,
            TableName = null,
            Description = @"Based on the type of insurance, some coverage plans require that an authorization number or code be obtained prior to all non-emergency admissions, and within 48 hours of an emergency admission.  Insurance billing would not be permitted without this number.  The date and source of authorization are the components of this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.14.1",
                            Type = @"Component",
                            Position = @"IN1.14.1",
                            Name = @"Authorization Number",
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
                            Id = @"IN1.14.2",
                            Type = @"Component",
                            Position = @"IN1.14.2",
                            Name = @"Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.14.3",
                            Type = @"Component",
                            Position = @"IN1.14.3",
                            Name = @"Source",
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

        _authorizationInformation = new HL7V23Field
        {
            field = message[@"IN1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_authorizationInformation.field.FieldRepetitions != null && _authorizationInformation.field.FieldRepetitions.Count > 0)
        {
            _authorizationInformation.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_authorizationInformation, fieldData);
        }

        return _authorizationInformation;
    } 
}

internal HL7V23Field _planType;

public HL7V23Field PlanType
{
    get
    {
        if (_planType != null)
        {
            return _planType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.15",
            Type = @"Field",
            Position = @"IN1.15",
            Name = @"Plan Type",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0086",
            TableName = @"Plan ID",
            Description = @"This field contains the coding structure that identifies the various plan types, for example, Medicare, Medicaid, Blue Cross, HMO, etc.  Refer to user-defined table 0086 - Plan ID for suggested values.",
            Sample = @"",
            Fields = null
        }

        _planType = new HL7V23Field
        {
            field = message[@"IN1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_planType.field.FieldRepetitions != null && _planType.field.FieldRepetitions.Count > 0)
        {
            _planType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_planType, fieldData);
        }

        return _planType;
    } 
}

internal HL7V23Field _nameofInsured;

public HL7V23Field NameofInsured
{
    get
    {
        if (_nameofInsured != null)
        {
            return _nameofInsured;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.16",
            Type = @"Field",
            Position = @"IN1.16",
            Name = @"Name of Insured",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the insured person.   The insured is the person who has an agreement with the insurance company to provide healthcare services to persons covered by the insurance policy.  Multiple names for the same insured person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.16.1",
                            Type = @"Component",
                            Position = @"IN1.16.1",
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
                            Id = @"IN1.16.2",
                            Type = @"Component",
                            Position = @"IN1.16.2",
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
                            Id = @"IN1.16.3",
                            Type = @"Component",
                            Position = @"IN1.16.3",
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
                            Id = @"IN1.16.4",
                            Type = @"Component",
                            Position = @"IN1.16.4",
                            Name = @"Suffix",
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
                            Id = @"IN1.16.5",
                            Type = @"Component",
                            Position = @"IN1.16.5",
                            Name = @"Prefix",
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
                            Id = @"IN1.16.6",
                            Type = @"Component",
                            Position = @"IN1.16.6",
                            Name = @"Degree",
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
                            Id = @"IN1.16.7",
                            Type = @"Component",
                            Position = @"IN1.16.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.8",
                            Type = @"Component",
                            Position = @"IN1.16.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _nameofInsured = new HL7V23Field
        {
            field = message[@"IN1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nameofInsured.field.FieldRepetitions != null && _nameofInsured.field.FieldRepetitions.Count > 0)
        {
            _nameofInsured.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nameofInsured, fieldData);
        }

        return _nameofInsured;
    } 
}

internal HL7V23Field _insuredsRelationshiptoPatient;

public HL7V23Field InsuredsRelationshiptoPatient
{
    get
    {
        if (_insuredsRelationshiptoPatient != null)
        {
            return _insuredsRelationshiptoPatient;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.17",
            Type = @"Field",
            Position = @"IN1.17",
            Name = @"Insured's Relationship to Patient",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0063",
            TableName = @"Relationship",
            Description = @"This field indicates the insured’s relationship to the patient.  Refer to user-defined table 0063 - Relationship for suggested values",
            Sample = @"",
            Fields = null
        }

        _insuredsRelationshiptoPatient = new HL7V23Field
        {
            field = message[@"IN1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsRelationshiptoPatient.field.FieldRepetitions != null && _insuredsRelationshiptoPatient.field.FieldRepetitions.Count > 0)
        {
            _insuredsRelationshiptoPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsRelationshiptoPatient, fieldData);
        }

        return _insuredsRelationshiptoPatient;
    } 
}

internal HL7V23Field _insuredsDateofBirth;

public HL7V23Field InsuredsDateofBirth
{
    get
    {
        if (_insuredsDateofBirth != null)
        {
            return _insuredsDateofBirth;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.18",
            Type = @"Field",
            Position = @"IN1.18",
            Name = @"Insured's Date of Birth",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date of birth of the insured.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.18.1",
                            Type = @"Component",
                            Position = @"IN1.18.1",
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

        _insuredsDateofBirth = new HL7V23Field
        {
            field = message[@"IN1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsDateofBirth.field.FieldRepetitions != null && _insuredsDateofBirth.field.FieldRepetitions.Count > 0)
        {
            _insuredsDateofBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsDateofBirth, fieldData);
        }

        return _insuredsDateofBirth;
    } 
}

internal HL7V23Field _insuredsAddress;

public HL7V23Field InsuredsAddress
{
    get
    {
        if (_insuredsAddress != null)
        {
            return _insuredsAddress;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.19",
            Type = @"Field",
            Position = @"IN1.19",
            Name = @"Insured's Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of the insured person.  The insured is the person who has an agreement with the insurance company to provide healthcare services to persons covered by an insurance policy.  Multiple addresses for the same insured person may be in this field.  The mailing address must be sent in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.19.1",
                            Type = @"Component",
                            Position = @"IN1.19.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.2",
                            Type = @"Component",
                            Position = @"IN1.19.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address.  In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.3",
                            Type = @"Component",
                            Position = @"IN1.19.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.4",
                            Type = @"Component",
                            Position = @"IN1.19.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"tate or province should be represented by the official postal service codes for that country",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.5",
                            Type = @"Component",
                            Position = @"IN1.19.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.6",
                            Type = @"Component",
                            Position = @"IN1.19.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address.  ISO 3166 provides a list of country codes that may be used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.7",
                            Type = @"Component",
                            Position = @"IN1.19.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.8",
                            Type = @"Component",
                            Position = @"IN1.19.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes country, bioregion, SMSA, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.9",
                            Type = @"Component",
                            Position = @"IN1.19.9",
                            Name = @"County/parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. Refer to user-defined table 0289 - County/parish.  When this component is used to represent the county (or parish), component 8 “other geographic designation” should not duplicate it (i.e., the use of “other geographic designation” to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).

Allowable values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.10",
                            Type = @"Component",
                            Position = @"IN1.19.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census track in which the specified address resides. Refer to user-defined table 0288 - Census tract. 
Allowable Values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _insuredsAddress = new HL7V23Field
        {
            field = message[@"IN1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsAddress.field.FieldRepetitions != null && _insuredsAddress.field.FieldRepetitions.Count > 0)
        {
            _insuredsAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsAddress, fieldData);
        }

        return _insuredsAddress;
    } 
}

internal HL7V23Field _assignmentofBenefits;

public HL7V23Field AssignmentofBenefits
{
    get
    {
        if (_assignmentofBenefits != null)
        {
            return _assignmentofBenefits;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.20",
            Type = @"Field",
            Position = @"IN1.20",
            Name = @"Assignment of Benefits",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0135",
            TableName = @"Assignment of benefits",
            Description = @"This field indicates whether the insured agreed to assign the insurance benefits to the healthcare provider.  If so, the insurance will pay the provider directly.  Refer to user-defined table 0135 - Assignment of benefits for suggested values.",
            Sample = @"",
            Fields = null
        }

        _assignmentofBenefits = new HL7V23Field
        {
            field = message[@"IN1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_assignmentofBenefits.field.FieldRepetitions != null && _assignmentofBenefits.field.FieldRepetitions.Count > 0)
        {
            _assignmentofBenefits.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_assignmentofBenefits, fieldData);
        }

        return _assignmentofBenefits;
    } 
}

internal HL7V23Field _coordinationofBenefits;

public HL7V23Field CoordinationofBenefits
{
    get
    {
        if (_coordinationofBenefits != null)
        {
            return _coordinationofBenefits;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.21",
            Type = @"Field",
            Position = @"IN1.21",
            Name = @"Coordination of Benefits",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0173",
            TableName = @"Coordination of benefits",
            Description = @"This field indicates whether this insurance works in conjunction with other insurance plans, or if it provides independent coverage and payment of benefits regardless of other insurance that might be available to the patient.  Refer to user-defined table 0173 - Coordination of benefits for suggested values.",
            Sample = @"",
            Fields = null
        }

        _coordinationofBenefits = new HL7V23Field
        {
            field = message[@"IN1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coordinationofBenefits.field.FieldRepetitions != null && _coordinationofBenefits.field.FieldRepetitions.Count > 0)
        {
            _coordinationofBenefits.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_coordinationofBenefits, fieldData);
        }

        return _coordinationofBenefits;
    } 
}

internal HL7V23Field _coordofBenPriority;

public HL7V23Field CoordofBenPriority
{
    get
    {
        if (_coordofBenPriority != null)
        {
            return _coordofBenPriority;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.22",
            Type = @"Field",
            Position = @"IN1.22",
            Name = @"Coord of Ben. Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"If the insurance works in conjunction with other insurance plans,  this field contains priority sequence.  Values are: 1, 2, 3, etc.",
            Sample = @"",
            Fields = null
        }

        _coordofBenPriority = new HL7V23Field
        {
            field = message[@"IN1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coordofBenPriority.field.FieldRepetitions != null && _coordofBenPriority.field.FieldRepetitions.Count > 0)
        {
            _coordofBenPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_coordofBenPriority, fieldData);
        }

        return _coordofBenPriority;
    } 
}

internal HL7V23Field _noticeofAdmissionCode;

public HL7V23Field NoticeofAdmissionCode
{
    get
    {
        if (_noticeofAdmissionCode != null)
        {
            return _noticeofAdmissionCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.23",
            Type = @"Field",
            Position = @"IN1.23",
            Name = @"Notice of Admission Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether the insurance company requires a written notice of admission from the healthcare provider.  Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _noticeofAdmissionCode = new HL7V23Field
        {
            field = message[@"IN1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_noticeofAdmissionCode.field.FieldRepetitions != null && _noticeofAdmissionCode.field.FieldRepetitions.Count > 0)
        {
            _noticeofAdmissionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_noticeofAdmissionCode, fieldData);
        }

        return _noticeofAdmissionCode;
    } 
}

internal HL7V23Field _noticeofAdmissionDate;

public HL7V23Field NoticeofAdmissionDate
{
    get
    {
        if (_noticeofAdmissionDate != null)
        {
            return _noticeofAdmissionDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.24",
            Type = @"Field",
            Position = @"IN1.24",
            Name = @"Notice of Admission Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"If a notice is required, this field indicates the date that it was sent",
            Sample = @"",
            Fields = null
        }

        _noticeofAdmissionDate = new HL7V23Field
        {
            field = message[@"IN1"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_noticeofAdmissionDate.field.FieldRepetitions != null && _noticeofAdmissionDate.field.FieldRepetitions.Count > 0)
        {
            _noticeofAdmissionDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_noticeofAdmissionDate, fieldData);
        }

        return _noticeofAdmissionDate;
    } 
}

internal HL7V23Field _reportofEigibilityCode;

public HL7V23Field ReportofEigibilityCode
{
    get
    {
        if (_reportofEigibilityCode != null)
        {
            return _reportofEigibilityCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.25",
            Type = @"Field",
            Position = @"IN1.25",
            Name = @"Report of Eigibility Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether this insurance carrier sends a report that indicates that the patient is eligible for benefits and whether it identifies those benefits.  Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _reportofEigibilityCode = new HL7V23Field
        {
            field = message[@"IN1"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportofEigibilityCode.field.FieldRepetitions != null && _reportofEigibilityCode.field.FieldRepetitions.Count > 0)
        {
            _reportofEigibilityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_reportofEigibilityCode, fieldData);
        }

        return _reportofEigibilityCode;
    } 
}

internal HL7V23Field _reportofEligibilityDate;

public HL7V23Field ReportofEligibilityDate
{
    get
    {
        if (_reportofEligibilityDate != null)
        {
            return _reportofEligibilityDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.26",
            Type = @"Field",
            Position = @"IN1.26",
            Name = @"Report of Eligibility Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates whether a report of eligibility (ROE) was received, and also indicates the date that it was received",
            Sample = @"",
            Fields = null
        }

        _reportofEligibilityDate = new HL7V23Field
        {
            field = message[@"IN1"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportofEligibilityDate.field.FieldRepetitions != null && _reportofEligibilityDate.field.FieldRepetitions.Count > 0)
        {
            _reportofEligibilityDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_reportofEligibilityDate, fieldData);
        }

        return _reportofEligibilityDate;
    } 
}

internal HL7V23Field _releaseInformationCode;

public HL7V23Field ReleaseInformationCode
{
    get
    {
        if (_releaseInformationCode != null)
        {
            return _releaseInformationCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.27",
            Type = @"Field",
            Position = @"IN1.27",
            Name = @"Release Information Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0093",
            TableName = @"Release information",
            Description = @"This field indicates whether the healthcare provider can release information about the patient, and what information can be released.  Refer to user-defined table 0093 - Release information code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _releaseInformationCode = new HL7V23Field
        {
            field = message[@"IN1"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_releaseInformationCode.field.FieldRepetitions != null && _releaseInformationCode.field.FieldRepetitions.Count > 0)
        {
            _releaseInformationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_releaseInformationCode, fieldData);
        }

        return _releaseInformationCode;
    } 
}

internal HL7V23Field _preAdmitCert;

public HL7V23Field PreAdmitCert
{
    get
    {
        if (_preAdmitCert != null)
        {
            return _preAdmitCert;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.28",
            Type = @"Field",
            Position = @"IN1.28",
            Name = @"Pre-Admit Cert",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the pre-admission certification code.  If the admission must be certified before the admission, this is the code associated with the admission.",
            Sample = @"",
            Fields = null
        }

        _preAdmitCert = new HL7V23Field
        {
            field = message[@"IN1"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preAdmitCert.field.FieldRepetitions != null && _preAdmitCert.field.FieldRepetitions.Count > 0)
        {
            _preAdmitCert.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_preAdmitCert, fieldData);
        }

        return _preAdmitCert;
    } 
}

internal HL7V23Field _verificationDateTime;

public HL7V23Field VerificationDateTime
{
    get
    {
        if (_verificationDateTime != null)
        {
            return _verificationDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.29",
            Type = @"Field",
            Position = @"IN1.29",
            Name = @"Verification Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the healthcare provider verified that the patient has the indicated benefits.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.29.1",
                            Type = @"Component",
                            Position = @"IN1.29.1",
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

        _verificationDateTime = new HL7V23Field
        {
            field = message[@"IN1"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_verificationDateTime.field.FieldRepetitions != null && _verificationDateTime.field.FieldRepetitions.Count > 0)
        {
            _verificationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_verificationDateTime, fieldData);
        }

        return _verificationDateTime;
    } 
}

internal HL7V23Field _verificationBy;

public HL7V23Field VerificationBy
{
    get
    {
        if (_verificationBy != null)
        {
            return _verificationBy;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.30",
            Type = @"Field",
            Position = @"IN1.30",
            Name = @"Verification By",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"Refers to the person who verified the benefits.  Multiple names for the same insured person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.30.1",
                            Type = @"Component",
                            Position = @"IN1.30.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.2",
                            Type = @"Component",
                            Position = @"IN1.30.2",
                            Name = @"Family Name",
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
                            Id = @"IN1.30.3",
                            Type = @"Component",
                            Position = @"IN1.30.3",
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
                            Id = @"IN1.30.4",
                            Type = @"Component",
                            Position = @"IN1.30.4",
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
                            Id = @"IN1.30.5",
                            Type = @"Component",
                            Position = @"IN1.30.5",
                            Name = @"Suffix",
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
                            Id = @"IN1.30.6",
                            Type = @"Component",
                            Position = @"IN1.30.6",
                            Name = @"Prefix",
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
                            Id = @"IN1.30.7",
                            Type = @"Component",
                            Position = @"IN1.30.7",
                            Name = @"Degree",
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
                            Id = @"IN1.30.8",
                            Type = @"Component",
                            Position = @"IN1.30.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.9",
                            Type = @"Component",
                            Position = @"IN1.30.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.30.9.1",
                            Type = @"SubComponent",
                            Position = @"IN1.30.9.1",
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
                            Id = @"IN1.30.9.2",
                            Type = @"SubComponent",
                            Position = @"IN1.30.9.2",
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
                            Id = @"IN1.30.9.3",
                            Type = @"SubComponent",
                            Position = @"IN1.30.9.3",
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
                            Id = @"IN1.30.10",
                            Type = @"Component",
                            Position = @"IN1.30.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.11",
                            Type = @"Component",
                            Position = @"IN1.30.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.12",
                            Type = @"Component",
                            Position = @"IN1.30.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.13",
                            Type = @"Component",
                            Position = @"IN1.30.13",
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
                            Id = @"IN1.30.14",
                            Type = @"Component",
                            Position = @"IN1.30.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.30.14.1",
                            Type = @"SubComponent",
                            Position = @"IN1.30.14.1",
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
                            Id = @"IN1.30.14.2",
                            Type = @"SubComponent",
                            Position = @"IN1.30.14.2",
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
                            Id = @"IN1.30.14.3",
                            Type = @"SubComponent",
                            Position = @"IN1.30.14.3",
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

        _verificationBy = new HL7V23Field
        {
            field = message[@"IN1"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_verificationBy.field.FieldRepetitions != null && _verificationBy.field.FieldRepetitions.Count > 0)
        {
            _verificationBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_verificationBy, fieldData);
        }

        return _verificationBy;
    } 
}

internal HL7V23Field _typeofAgreementCode;

public HL7V23Field TypeofAgreementCode
{
    get
    {
        if (_typeofAgreementCode != null)
        {
            return _typeofAgreementCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.31",
            Type = @"Field",
            Position = @"IN1.31",
            Name = @"Type of Agreement Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0098",
            TableName = @"Type of agreement",
            Description = @"This field is used to further identify an insurance plan.  Refer to user-defined table 0098 - Type of agreement for suggested values. Refer to user-defined table 0098 - Type of agreement for suggested values.",
            Sample = @"",
            Fields = null
        }

        _typeofAgreementCode = new HL7V23Field
        {
            field = message[@"IN1"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_typeofAgreementCode.field.FieldRepetitions != null && _typeofAgreementCode.field.FieldRepetitions.Count > 0)
        {
            _typeofAgreementCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_typeofAgreementCode, fieldData);
        }

        return _typeofAgreementCode;
    } 
}

internal HL7V23Field _billingStatus;

public HL7V23Field BillingStatus
{
    get
    {
        if (_billingStatus != null)
        {
            return _billingStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.32",
            Type = @"Field",
            Position = @"IN1.32",
            Name = @"Billing Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0022",
            TableName = @"Billing status",
            Description = @"This field indicates whether the particular insurance has been billed and, if so, the type of bill.  Refer to user-defined table 0022 - Billing status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _billingStatus = new HL7V23Field
        {
            field = message[@"IN1"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_billingStatus.field.FieldRepetitions != null && _billingStatus.field.FieldRepetitions.Count > 0)
        {
            _billingStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_billingStatus, fieldData);
        }

        return _billingStatus;
    } 
}

internal HL7V23Field _lifetimeReserveDays;

public HL7V23Field LifetimeReserveDays
{
    get
    {
        if (_lifetimeReserveDays != null)
        {
            return _lifetimeReserveDays;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.33",
            Type = @"Field",
            Position = @"IN1.33",
            Name = @"Lifetime Reserve Days",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of days left for a certain service to be provided or covered under an insurance policy.",
            Sample = @"",
            Fields = null
        }

        _lifetimeReserveDays = new HL7V23Field
        {
            field = message[@"IN1"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_lifetimeReserveDays.field.FieldRepetitions != null && _lifetimeReserveDays.field.FieldRepetitions.Count > 0)
        {
            _lifetimeReserveDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_lifetimeReserveDays, fieldData);
        }

        return _lifetimeReserveDays;
    } 
}

internal HL7V23Field _delaybeforelifetimereservedays;

public HL7V23Field Delaybeforelifetimereservedays
{
    get
    {
        if (_delaybeforelifetimereservedays != null)
        {
            return _delaybeforelifetimereservedays;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.34",
            Type = @"Field",
            Position = @"IN1.34",
            Name = @"Delay before lifetime reserve days",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the delay before lifetime reserve days.",
            Sample = @"",
            Fields = null
        }

        _delaybeforelifetimereservedays = new HL7V23Field
        {
            field = message[@"IN1"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delaybeforelifetimereservedays.field.FieldRepetitions != null && _delaybeforelifetimereservedays.field.FieldRepetitions.Count > 0)
        {
            _delaybeforelifetimereservedays.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_delaybeforelifetimereservedays, fieldData);
        }

        return _delaybeforelifetimereservedays;
    } 
}

internal HL7V23Field _companyPlanCode;

public HL7V23Field CompanyPlanCode
{
    get
    {
        if (_companyPlanCode != null)
        {
            return _companyPlanCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.35",
            Type = @"Field",
            Position = @"IN1.35",
            Name = @"Company Plan Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0042",
            TableName = @"Company plan code",
            Description = @"This field contains optional information to further define the data in IN1-3-insurance company ID.   Refer to user-defined table 0042 - Company plan code.  This table contains codes used to identify an insurance plan uniquely.",
            Sample = @"",
            Fields = null
        }

        _companyPlanCode = new HL7V23Field
        {
            field = message[@"IN1"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_companyPlanCode.field.FieldRepetitions != null && _companyPlanCode.field.FieldRepetitions.Count > 0)
        {
            _companyPlanCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_companyPlanCode, fieldData);
        }

        return _companyPlanCode;
    } 
}

internal HL7V23Field _policyNumber;

public HL7V23Field PolicyNumber
{
    get
    {
        if (_policyNumber != null)
        {
            return _policyNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.36",
            Type = @"Field",
            Position = @"IN1.36",
            Name = @"Policy Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the individual policy number of the insured to uniquely identify this patient’s plan.  For special types of insurance numbers, there are also special fields in the IN2 segment for Medicaid, Medicare, Champus (i.e., IN2-8-Medicaid case number, IN2-6-Medicare health ins card number, IN2-10Champus ID number).  But we recommend that this field (IN1-36-policy number) be filled even when the patient’s insurance number is also passed in one of these other fields.",
            Sample = @"",
            Fields = null
        }

        _policyNumber = new HL7V23Field
        {
            field = message[@"IN1"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyNumber.field.FieldRepetitions != null && _policyNumber.field.FieldRepetitions.Count > 0)
        {
            _policyNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_policyNumber, fieldData);
        }

        return _policyNumber;
    } 
}

internal HL7V23Field _policyDeductible;

public HL7V23Field PolicyDeductible
{
    get
    {
        if (_policyDeductible != null)
        {
            return _policyDeductible;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.37",
            Type = @"Field",
            Position = @"IN1.37",
            Name = @"Policy Deductible",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount specified by the insurance plan that is the responsibility of the guarantor.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.37.1",
                            Type = @"Component",
                            Position = @"IN1.37.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.37.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.37.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.37.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed.  The values for the denomination component are those specified in ISO-4217.  If the denomination is not specified, MSH-17country code is used to determine the default. 

Example: 
|99.50^USD| 
where USD is the ISO 4217 code for the U.S. American dollar. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.2",
                            Type = @"Component",
                            Position = @"IN1.37.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID.  Refer to HL7 table 0205 - Price type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.3",
                            Type = @"Component",
                            Position = @"IN1.37.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is an NM data type; together they specify the “range.”  The range can be defined as either time or quantity.  For example, the range can indicate that the first 10 minutes of the procedure has one price.  Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.4",
                            Type = @"Component",
                            Position = @"IN1.37.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See From value",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.5",
                            Type = @"Component",
                            Position = @"IN1.37.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (e.g., count); it is required if <from value> and  <to value> are present",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.37.5.1",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.5.2",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.5.3",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.5.4",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.5.5",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.5.6",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.6",
                            Type = @"Component",
                            Position = @"IN1.37.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _policyDeductible = new HL7V23Field
        {
            field = message[@"IN1"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyDeductible.field.FieldRepetitions != null && _policyDeductible.field.FieldRepetitions.Count > 0)
        {
            _policyDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_policyDeductible, fieldData);
        }

        return _policyDeductible;
    } 
}

internal HL7V23Field _policyLimitAmount;

public HL7V23Field PolicyLimitAmount
{
    get
    {
        if (_policyLimitAmount != null)
        {
            return _policyLimitAmount;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.38",
            Type = @"Field",
            Position = @"IN1.38",
            Name = @"Policy Limit - Amount",
            Length = 12,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  Use IN2-policy type/amount instead of this field.  This field contains the maximum amount that the insurance policy will pay.  In some cases, the limit may be for a single encounter",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.38.1",
                            Type = @"Component",
                            Position = @"IN1.38.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.38.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.38.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.38.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed.  The values for the denomination component are those specified in ISO-4217.  If the denomination is not specified, MSH-17country code is used to determine the default. 

Example: 
|99.50^USD| 
where USD is the ISO 4217 code for the U.S. American dollar. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.2",
                            Type = @"Component",
                            Position = @"IN1.38.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID.  Refer to HL7 table 0205 - Price type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.3",
                            Type = @"Component",
                            Position = @"IN1.38.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is an NM data type; together they specify the “range.”  The range can be defined as either time or quantity.  For example, the range can indicate that the first 10 minutes of the procedure has one price.  Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.4",
                            Type = @"Component",
                            Position = @"IN1.38.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See From value",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.5",
                            Type = @"Component",
                            Position = @"IN1.38.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (e.g., count); it is required if <from value> and  <to value> are present",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.38.5.1",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.5.2",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.5.3",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.5.4",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.5.5",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.5.6",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.6",
                            Type = @"Component",
                            Position = @"IN1.38.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _policyLimitAmount = new HL7V23Field
        {
            field = message[@"IN1"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyLimitAmount.field.FieldRepetitions != null && _policyLimitAmount.field.FieldRepetitions.Count > 0)
        {
            _policyLimitAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_policyLimitAmount, fieldData);
        }

        return _policyLimitAmount;
    } 
}

internal HL7V23Field _policyLimitDays;

public HL7V23Field PolicyLimitDays
{
    get
    {
        if (_policyLimitDays != null)
        {
            return _policyLimitDays;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.39",
            Type = @"Field",
            Position = @"IN1.39",
            Name = @"Policy Limit - Days",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the maximum number of days that the insurance policy will cover",
            Sample = @"",
            Fields = null
        }

        _policyLimitDays = new HL7V23Field
        {
            field = message[@"IN1"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyLimitDays.field.FieldRepetitions != null && _policyLimitDays.field.FieldRepetitions.Count > 0)
        {
            _policyLimitDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_policyLimitDays, fieldData);
        }

        return _policyLimitDays;
    } 
}

internal HL7V23Field _roomRateSemiPrivate;

public HL7V23Field RoomRateSemiPrivate
{
    get
    {
        if (_roomRateSemiPrivate != null)
        {
            return _roomRateSemiPrivate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.40",
            Type = @"Field",
            Position = @"IN1.40",
            Name = @"Room Rate - Semi-Private",
            Length = 12,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  Use IN2-28-room coverage type/amount instead of this field. When used for backward compatibility, IN2-40-room rate-semi-primate contains the average room rate that the policy covers",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.40.1",
                            Type = @"Component",
                            Position = @"IN1.40.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.40.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.40.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.40.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed.  The values for the denomination component are those specified in ISO-4217.  If the denomination is not specified, MSH-17country code is used to determine the default. 

Example: 
|99.50^USD| 
where USD is the ISO 4217 code for the U.S. American dollar. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.2",
                            Type = @"Component",
                            Position = @"IN1.40.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID.  Refer to HL7 table 0205 - Price type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.3",
                            Type = @"Component",
                            Position = @"IN1.40.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is an NM data type; together they specify the “range.”  The range can be defined as either time or quantity.  For example, the range can indicate that the first 10 minutes of the procedure has one price.  Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.4",
                            Type = @"Component",
                            Position = @"IN1.40.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See From value",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.5",
                            Type = @"Component",
                            Position = @"IN1.40.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (e.g., count); it is required if <from value> and  <to value> are present",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.40.5.1",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.5.2",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.5.3",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.5.4",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.5.5",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.5.6",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.6",
                            Type = @"Component",
                            Position = @"IN1.40.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _roomRateSemiPrivate = new HL7V23Field
        {
            field = message[@"IN1"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_roomRateSemiPrivate.field.FieldRepetitions != null && _roomRateSemiPrivate.field.FieldRepetitions.Count > 0)
        {
            _roomRateSemiPrivate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_roomRateSemiPrivate, fieldData);
        }

        return _roomRateSemiPrivate;
    } 
}

internal HL7V23Field _roomRatePrivate;

public HL7V23Field RoomRatePrivate
{
    get
    {
        if (_roomRatePrivate != null)
        {
            return _roomRatePrivate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.41",
            Type = @"Field",
            Position = @"IN1.41",
            Name = @"Room Rate - Private",
            Length = 12,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  Use IN2-28-room coverage type/amount instead of this field.  When used for backward compatibility IN2-29-room rate-private contains the maximum private room rate that the policy covers",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.41.1",
                            Type = @"Component",
                            Position = @"IN1.41.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.41.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.41.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.41.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed.  The values for the denomination component are those specified in ISO-4217.  If the denomination is not specified, MSH-17country code is used to determine the default. 

Example: 
|99.50^USD| 
where USD is the ISO 4217 code for the U.S. American dollar. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.2",
                            Type = @"Component",
                            Position = @"IN1.41.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID.  Refer to HL7 table 0205 - Price type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.3",
                            Type = @"Component",
                            Position = @"IN1.41.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is an NM data type; together they specify the “range.”  The range can be defined as either time or quantity.  For example, the range can indicate that the first 10 minutes of the procedure has one price.  Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.4",
                            Type = @"Component",
                            Position = @"IN1.41.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See From value",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.5",
                            Type = @"Component",
                            Position = @"IN1.41.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (e.g., count); it is required if <from value> and  <to value> are present",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN1.41.5.1",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.5.2",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.5.3",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.5.4",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.5.5",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.5.6",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.6",
                            Type = @"Component",
                            Position = @"IN1.41.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _roomRatePrivate = new HL7V23Field
        {
            field = message[@"IN1"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_roomRatePrivate.field.FieldRepetitions != null && _roomRatePrivate.field.FieldRepetitions.Count > 0)
        {
            _roomRatePrivate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_roomRatePrivate, fieldData);
        }

        return _roomRatePrivate;
    } 
}

internal HL7V23Field _insuredsEmploymentStatus;

public HL7V23Field InsuredsEmploymentStatus
{
    get
    {
        if (_insuredsEmploymentStatus != null)
        {
            return _insuredsEmploymentStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.42",
            Type = @"Field",
            Position = @"IN1.42",
            Name = @"Insured's Employment Status",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0066",
            TableName = @"Employment status",
            Description = @"Refer to user-defined table 0066 - Employment status for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.42.1",
                            Type = @"Component",
                            Position = @"IN1.42.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.42.2",
                            Type = @"Component",
                            Position = @"IN1.42.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.42.3",
                            Type = @"Component",
                            Position = @"IN1.42.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.42.4",
                            Type = @"Component",
                            Position = @"IN1.42.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.42.5",
                            Type = @"Component",
                            Position = @"IN1.42.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.42.6",
                            Type = @"Component",
                            Position = @"IN1.42.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _insuredsEmploymentStatus = new HL7V23Field
        {
            field = message[@"IN1"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsEmploymentStatus.field.FieldRepetitions != null && _insuredsEmploymentStatus.field.FieldRepetitions.Count > 0)
        {
            _insuredsEmploymentStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsEmploymentStatus, fieldData);
        }

        return _insuredsEmploymentStatus;
    } 
}

internal HL7V23Field _insuredsSex;

public HL7V23Field InsuredsSex
{
    get
    {
        if (_insuredsSex != null)
        {
            return _insuredsSex;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.43",
            Type = @"Field",
            Position = @"IN1.43",
            Name = @"Insured's Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0001",
            TableName = @"Sex",
            Description = @"his field contains the gender of the insured.  Refer to user-defined table 0001 - Sex for valid values",
            Sample = @"",
            Fields = null
        }

        _insuredsSex = new HL7V23Field
        {
            field = message[@"IN1"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsSex.field.FieldRepetitions != null && _insuredsSex.field.FieldRepetitions.Count > 0)
        {
            _insuredsSex.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsSex, fieldData);
        }

        return _insuredsSex;
    } 
}

internal HL7V23Field _insuredsEmployerAddress;

public HL7V23Field InsuredsEmployerAddress
{
    get
    {
        if (_insuredsEmployerAddress != null)
        {
            return _insuredsEmployerAddress;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.44",
            Type = @"Field",
            Position = @"IN1.44",
            Name = @"Insured's Employer Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of the insured employee’s employer.  Multiple addresses for the same employer may be sent in this field.  The mailing address must be sent first.  When the mailing address is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.44.1",
                            Type = @"Component",
                            Position = @"IN1.44.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.2",
                            Type = @"Component",
                            Position = @"IN1.44.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address.  In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.3",
                            Type = @"Component",
                            Position = @"IN1.44.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.4",
                            Type = @"Component",
                            Position = @"IN1.44.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"tate or province should be represented by the official postal service codes for that country",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.5",
                            Type = @"Component",
                            Position = @"IN1.44.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.6",
                            Type = @"Component",
                            Position = @"IN1.44.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address.  ISO 3166 provides a list of country codes that may be used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.7",
                            Type = @"Component",
                            Position = @"IN1.44.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.8",
                            Type = @"Component",
                            Position = @"IN1.44.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes country, bioregion, SMSA, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.9",
                            Type = @"Component",
                            Position = @"IN1.44.9",
                            Name = @"County/parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. Refer to user-defined table 0289 - County/parish.  When this component is used to represent the county (or parish), component 8 “other geographic designation” should not duplicate it (i.e., the use of “other geographic designation” to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).

Allowable values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.10",
                            Type = @"Component",
                            Position = @"IN1.44.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census track in which the specified address resides. Refer to user-defined table 0288 - Census tract. 
Allowable Values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _insuredsEmployerAddress = new HL7V23Field
        {
            field = message[@"IN1"][44],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsEmployerAddress.field.FieldRepetitions != null && _insuredsEmployerAddress.field.FieldRepetitions.Count > 0)
        {
            _insuredsEmployerAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsEmployerAddress, fieldData);
        }

        return _insuredsEmployerAddress;
    } 
}

internal HL7V23Field _verificationStatus;

public HL7V23Field VerificationStatus
{
    get
    {
        if (_verificationStatus != null)
        {
            return _verificationStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.45",
            Type = @"Field",
            Position = @"IN1.45",
            Name = @"Verification Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the status of this patient’s relationship with this insurance carrier",
            Sample = @"",
            Fields = null
        }

        _verificationStatus = new HL7V23Field
        {
            field = message[@"IN1"][45],
            fieldData = fieldData
        };

        // check for repetitions
        if (_verificationStatus.field.FieldRepetitions != null && _verificationStatus.field.FieldRepetitions.Count > 0)
        {
            _verificationStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_verificationStatus, fieldData);
        }

        return _verificationStatus;
    } 
}

internal HL7V23Field _priorInsurancePlanID;

public HL7V23Field PriorInsurancePlanID
{
    get
    {
        if (_priorInsurancePlanID != null)
        {
            return _priorInsurancePlanID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.46",
            Type = @"Field",
            Position = @"IN1.46",
            Name = @"Prior Insurance Plan ID",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0072",
            TableName = @"Insurance plan ID",
            Description = @"This field uniquely identifies the prior insurance plan when the plan ID changes.  Refer to userdefined table 0072 - Insurance plan ID for suggested values",
            Sample = @"",
            Fields = null
        }

        _priorInsurancePlanID = new HL7V23Field
        {
            field = message[@"IN1"][46],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorInsurancePlanID.field.FieldRepetitions != null && _priorInsurancePlanID.field.FieldRepetitions.Count > 0)
        {
            _priorInsurancePlanID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_priorInsurancePlanID, fieldData);
        }

        return _priorInsurancePlanID;
    } 
}

internal HL7V23Field _coverageType;

public HL7V23Field CoverageType
{
    get
    {
        if (_coverageType != null)
        {
            return _coverageType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.47",
            Type = @"Field",
            Position = @"IN1.47",
            Name = @"Coverage Type",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0309",
            TableName = @"Coverage type",
            Description = @"This field contains the coding structure that identifies the type of insurance coverage, or what type of services are covered for the purposes of a billing system.  For example, a physician billing system will only want to receive insurance information for plans which cover physician/professional charges.  Refer to user-defined table 0309 - Coverage type for suggested values",
            Sample = @"",
            Fields = null
        }

        _coverageType = new HL7V23Field
        {
            field = message[@"IN1"][47],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coverageType.field.FieldRepetitions != null && _coverageType.field.FieldRepetitions.Count > 0)
        {
            _coverageType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_coverageType, fieldData);
        }

        return _coverageType;
    } 
}

internal HL7V23Field _handicap;

public HL7V23Field Handicap
{
    get
    {
        if (_handicap != null)
        {
            return _handicap;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.48",
            Type = @"Field",
            Position = @"IN1.48",
            Name = @"Handicap",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0310",
            TableName = @"Handicap",
            Description = @"This field contains a code to describe the insured’s disability.  Refer to user-defined table 0310 - Handicap for suggested values",
            Sample = @"",
            Fields = null
        }

        _handicap = new HL7V23Field
        {
            field = message[@"IN1"][48],
            fieldData = fieldData
        };

        // check for repetitions
        if (_handicap.field.FieldRepetitions != null && _handicap.field.FieldRepetitions.Count > 0)
        {
            _handicap.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_handicap, fieldData);
        }

        return _handicap;
    } 
}

internal HL7V23Field _insuredsIDNumber;

public HL7V23Field InsuredsIDNumber
{
    get
    {
        if (_insuredsIDNumber != null)
        {
            return _insuredsIDNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN1.49",
            Type = @"Field",
            Position = @"IN1.49",
            Name = @"Insured's ID Number",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This data element contains a healthcare institution’s identifiers for the insured",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.49.1",
                            Type = @"Component",
                            Position = @"IN1.49.1",
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
                            Id = @"IN1.49.2",
                            Type = @"Component",
                            Position = @"IN1.49.2",
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
                            Id = @"IN1.49.3",
                            Type = @"Component",
                            Position = @"IN1.49.3",
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
                            Id = @"IN1.49.4",
                            Type = @"Component",
                            Position = @"IN1.49.4",
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
                            Id = @"IN1.49.4.1",
                            Type = @"SubComponent",
                            Position = @"IN1.49.4.1",
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
                            Id = @"IN1.49.4.2",
                            Type = @"SubComponent",
                            Position = @"IN1.49.4.2",
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
                            Id = @"IN1.49.4.3",
                            Type = @"SubComponent",
                            Position = @"IN1.49.4.3",
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
                            Id = @"IN1.49.5",
                            Type = @"Component",
                            Position = @"IN1.49.5",
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
                            Id = @"IN1.49.6",
                            Type = @"Component",
                            Position = @"IN1.49.6",
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
                            Id = @"IN1.49.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.49.6.1",
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
                            Id = @"IN1.49.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.49.6.2",
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
                            Id = @"IN1.49.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.49.6.3",
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

        _insuredsIDNumber = new HL7V23Field
        {
            field = message[@"IN1"][49],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsIDNumber.field.FieldRepetitions != null && _insuredsIDNumber.field.FieldRepetitions.Count > 0)
        {
            _insuredsIDNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsIDNumber, fieldData);
        }

        return _insuredsIDNumber;
    } 
}
    }
}
