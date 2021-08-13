using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentPID
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PID"; } }

        public string SegmentId { get { return @"PID"; } }
        
        public string LongName { get { return @"Patient Identification"; } }
        
        public string Description { get { return @"The PID segment is used by all applications as the primary means of communicating patient identification information.  This segment contains permanent patient identifying and demographic information that, for the most part, is not likely to change frequently.

Usage notes:  PID patient identification 
The assigning facility ID, the fourth component of the patient identifiers, is a string of up to six characters that is uniquely associated with the facility that originally assigned the number.  A given institution, or group of intercommunicating institutions, should establish a list of facilities that may be potential assignors of patient identification (and other important identification) numbers.  The list will be one of the institution’s master dictionary lists.  Since third parties (other than the assignors of patient identification numbers) may send or receive HL7 messages containing patient identification numbers, the assigning facility ID in the patient identification numbers may not be the same as the sending and receiving systems identified in the MSH.  The assigning facility ID must be unique across applications at a given site.  This field is required in HL7 implementations that have more than a single Patient Administration application assigning such numbers. "; } }
        
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

        public HL7V23SegmentPID(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDPatientID;

public HL7V23Field SetIDPatientID
{
    get
    {
        if (_setIDPatientID != null)
        {
            return _setIDPatientID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.1",
            Type = @"Field",
            Position = @"PID.1",
            Name = @"Set ID - Patient ID",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc",
            Sample = @"",
            Fields = null
        }

        _setIDPatientID = new HL7V23Field
        {
            field = message[@"PID"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDPatientID.field.FieldRepetitions != null && _setIDPatientID.field.FieldRepetitions.Count > 0)
        {
            _setIDPatientID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDPatientID, fieldData);
        }

        return _setIDPatientID;
    } 
}

internal HL7V23Field _patientIDExternalID;

public HL7V23Field PatientIDExternalID
{
    get
    {
        if (_patientIDExternalID != null)
        {
            return _patientIDExternalID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.2",
            Type = @"Field",
            Position = @"PID.2",
            Name = @"Patient ID (External ID)",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"When the patient is from another institution, outside office, etc., the identifier used by that institution can be shown in this field. This may be a number that multiple disparate corporations or facilities share. Refer to HL7 table 0061 - Check digit scheme",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.2.1",
                            Type = @"Component",
                            Position = @"PID.2.1",
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
                            Id = @"PID.2.2",
                            Type = @"Component",
                            Position = @"PID.2.2",
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
                            Id = @"PID.2.3",
                            Type = @"Component",
                            Position = @"PID.2.3",
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
                            Id = @"PID.2.4",
                            Type = @"Component",
                            Position = @"PID.2.4",
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
                            Id = @"PID.2.4.1",
                            Type = @"SubComponent",
                            Position = @"PID.2.4.1",
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
                            Id = @"PID.2.4.2",
                            Type = @"SubComponent",
                            Position = @"PID.2.4.2",
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
                            Id = @"PID.2.4.3",
                            Type = @"SubComponent",
                            Position = @"PID.2.4.3",
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
                            Id = @"PID.2.5",
                            Type = @"Component",
                            Position = @"PID.2.5",
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
                            Id = @"PID.2.6",
                            Type = @"Component",
                            Position = @"PID.2.6",
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
                            Id = @"PID.2.6.1",
                            Type = @"SubComponent",
                            Position = @"PID.2.6.1",
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
                            Id = @"PID.2.6.2",
                            Type = @"SubComponent",
                            Position = @"PID.2.6.2",
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
                            Id = @"PID.2.6.3",
                            Type = @"SubComponent",
                            Position = @"PID.2.6.3",
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

        _patientIDExternalID = new HL7V23Field
        {
            field = message[@"PID"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientIDExternalID.field.FieldRepetitions != null && _patientIDExternalID.field.FieldRepetitions.Count > 0)
        {
            _patientIDExternalID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientIDExternalID, fieldData);
        }

        return _patientIDExternalID;
    } 
}

internal HL7V23Field _patientIDInternalID;

public HL7V23Field PatientIDInternalID
{
    get
    {
        if (_patientIDInternalID != null)
        {
            return _patientIDInternalID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.3",
            Type = @"Field",
            Position = @"PID.3",
            Name = @"Patient ID (Internal ID)",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains the primary identifier, or other identifiers used by the facility to identify a patient uniquely (e.g., medical record number, billing number, birth registry, etc.). Refer to HL7 table 0061 - Check digit scheme for valid values.

When merging patient IDs (A34 (merge patient information-patient ID only) and A36 (merge patient information-patient ID & account number) events), the Patient ID contained in the PID segment cannot repeat",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.3.1",
                            Type = @"Component",
                            Position = @"PID.3.1",
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
                            Id = @"PID.3.2",
                            Type = @"Component",
                            Position = @"PID.3.2",
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
                            Id = @"PID.3.3",
                            Type = @"Component",
                            Position = @"PID.3.3",
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
                            Id = @"PID.3.4",
                            Type = @"Component",
                            Position = @"PID.3.4",
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
                            Id = @"PID.3.4.1",
                            Type = @"SubComponent",
                            Position = @"PID.3.4.1",
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
                            Id = @"PID.3.4.2",
                            Type = @"SubComponent",
                            Position = @"PID.3.4.2",
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
                            Id = @"PID.3.4.3",
                            Type = @"SubComponent",
                            Position = @"PID.3.4.3",
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
                            Id = @"PID.3.5",
                            Type = @"Component",
                            Position = @"PID.3.5",
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
                            Id = @"PID.3.6",
                            Type = @"Component",
                            Position = @"PID.3.6",
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
                            Id = @"PID.3.6.1",
                            Type = @"SubComponent",
                            Position = @"PID.3.6.1",
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
                            Id = @"PID.3.6.2",
                            Type = @"SubComponent",
                            Position = @"PID.3.6.2",
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
                            Id = @"PID.3.6.3",
                            Type = @"SubComponent",
                            Position = @"PID.3.6.3",
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

        _patientIDInternalID = new HL7V23Field
        {
            field = message[@"PID"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientIDInternalID.field.FieldRepetitions != null && _patientIDInternalID.field.FieldRepetitions.Count > 0)
        {
            _patientIDInternalID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientIDInternalID, fieldData);
        }

        return _patientIDInternalID;
    } 
}

internal HL7V23Field _alternatePatientID;

public HL7V23Field AlternatePatientID
{
    get
    {
        if (_alternatePatientID != null)
        {
            return _alternatePatientID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.4",
            Type = @"Field",
            Position = @"PID.4",
            Name = @"Alternate Patient ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains the alternate, temporary, or pending optional patient identifier to be used if needed  - or additional  numbers that may be required to identify a patient.  This field may be used to convey multiple patient IDs when more than one exist for a patient. Possible contents might include a visit number, a visit date, or a Social Security Number",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.4.1",
                            Type = @"Component",
                            Position = @"PID.4.1",
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
                            Id = @"PID.4.2",
                            Type = @"Component",
                            Position = @"PID.4.2",
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
                            Id = @"PID.4.3",
                            Type = @"Component",
                            Position = @"PID.4.3",
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
                            Id = @"PID.4.4",
                            Type = @"Component",
                            Position = @"PID.4.4",
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
                            Id = @"PID.4.4.1",
                            Type = @"SubComponent",
                            Position = @"PID.4.4.1",
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
                            Id = @"PID.4.4.2",
                            Type = @"SubComponent",
                            Position = @"PID.4.4.2",
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
                            Id = @"PID.4.4.3",
                            Type = @"SubComponent",
                            Position = @"PID.4.4.3",
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
                            Id = @"PID.4.5",
                            Type = @"Component",
                            Position = @"PID.4.5",
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
                            Id = @"PID.4.6",
                            Type = @"Component",
                            Position = @"PID.4.6",
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
                            Id = @"PID.4.6.1",
                            Type = @"SubComponent",
                            Position = @"PID.4.6.1",
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
                            Id = @"PID.4.6.2",
                            Type = @"SubComponent",
                            Position = @"PID.4.6.2",
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
                            Id = @"PID.4.6.3",
                            Type = @"SubComponent",
                            Position = @"PID.4.6.3",
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

        _alternatePatientID = new HL7V23Field
        {
            field = message[@"PID"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_alternatePatientID.field.FieldRepetitions != null && _alternatePatientID.field.FieldRepetitions.Count > 0)
        {
            _alternatePatientID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_alternatePatientID, fieldData);
        }

        return _alternatePatientID;
    } 
}

internal HL7V23Field _patientName;

public HL7V23Field PatientName
{
    get
    {
        if (_patientName != null)
        {
            return _patientName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.5",
            Type = @"Field",
            Position = @"PID.5",
            Name = @"Patient Name",
            Length = 48,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the legal name of the patient.  All other names for the patient should be sent in PID-9-patient alias.  Therefore, the name type code in this field should be “L - Legal.” Refer to HL7 table 0200 Name type code for valid values.  Repetition of this field is allowed for representing the same name in different character sets.  Please refer to the PN data type. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.5.1",
                            Type = @"Component",
                            Position = @"PID.5.1",
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
                            Id = @"PID.5.2",
                            Type = @"Component",
                            Position = @"PID.5.2",
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
                            Id = @"PID.5.3",
                            Type = @"Component",
                            Position = @"PID.5.3",
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
                            Id = @"PID.5.4",
                            Type = @"Component",
                            Position = @"PID.5.4",
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
                            Id = @"PID.5.5",
                            Type = @"Component",
                            Position = @"PID.5.5",
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
                            Id = @"PID.5.6",
                            Type = @"Component",
                            Position = @"PID.5.6",
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
                            Id = @"PID.5.7",
                            Type = @"Component",
                            Position = @"PID.5.7",
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
                            Id = @"PID.5.8",
                            Type = @"Component",
                            Position = @"PID.5.8",
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

        _patientName = new HL7V23Field
        {
            field = message[@"PID"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientName.field.FieldRepetitions != null && _patientName.field.FieldRepetitions.Count > 0)
        {
            _patientName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientName, fieldData);
        }

        return _patientName;
    } 
}

internal HL7V23Field _mothersMaidenName;

public HL7V23Field MothersMaidenName
{
    get
    {
        if (_mothersMaidenName != null)
        {
            return _mothersMaidenName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.6",
            Type = @"Field",
            Position = @"PID.6",
            Name = @"Mother's Maiden Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the family name under which the mother was born (i.e., before marriage). It is used to distinguish between patients with the same last name",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.6.1",
                            Type = @"Component",
                            Position = @"PID.6.1",
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
                            Id = @"PID.6.2",
                            Type = @"Component",
                            Position = @"PID.6.2",
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
                            Id = @"PID.6.3",
                            Type = @"Component",
                            Position = @"PID.6.3",
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
                            Id = @"PID.6.4",
                            Type = @"Component",
                            Position = @"PID.6.4",
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
                            Id = @"PID.6.5",
                            Type = @"Component",
                            Position = @"PID.6.5",
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
                            Id = @"PID.6.6",
                            Type = @"Component",
                            Position = @"PID.6.6",
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
                            Id = @"PID.6.7",
                            Type = @"Component",
                            Position = @"PID.6.7",
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
                            Id = @"PID.6.8",
                            Type = @"Component",
                            Position = @"PID.6.8",
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

        _mothersMaidenName = new HL7V23Field
        {
            field = message[@"PID"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mothersMaidenName.field.FieldRepetitions != null && _mothersMaidenName.field.FieldRepetitions.Count > 0)
        {
            _mothersMaidenName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_mothersMaidenName, fieldData);
        }

        return _mothersMaidenName;
    } 
}

internal HL7V23Field _dateofBirth;

public HL7V23Field DateofBirth
{
    get
    {
        if (_dateofBirth != null)
        {
            return _dateofBirth;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.7",
            Type = @"Field",
            Position = @"PID.7",
            Name = @"Date of Birth",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the patient’s date and time of birth",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.7.1",
                            Type = @"Component",
                            Position = @"PID.7.1",
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

        _dateofBirth = new HL7V23Field
        {
            field = message[@"PID"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateofBirth.field.FieldRepetitions != null && _dateofBirth.field.FieldRepetitions.Count > 0)
        {
            _dateofBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_dateofBirth, fieldData);
        }

        return _dateofBirth;
    } 
}

internal HL7V23Field _sex;

public HL7V23Field Sex
{
    get
    {
        if (_sex != null)
        {
            return _sex;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.8",
            Type = @"Field",
            Position = @"PID.8",
            Name = @"Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0001",
            TableName = @"Sex",
            Description = @"This field contains the patient’s sex.  Refer to user-defined table 0001 - Sex for suggested values.",
            Sample = @"",
            Fields = null
        }

        _sex = new HL7V23Field
        {
            field = message[@"PID"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sex.field.FieldRepetitions != null && _sex.field.FieldRepetitions.Count > 0)
        {
            _sex.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_sex, fieldData);
        }

        return _sex;
    } 
}

internal HL7V23Field _patientAlias;

public HL7V23Field PatientAlias
{
    get
    {
        if (_patientAlias != null)
        {
            return _patientAlias;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.9",
            Type = @"Field",
            Position = @"PID.9",
            Name = @"Patient Alias",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name(s) by which the patient has been known at some time.  Refer to HL7 table 0200 - Name type for valid values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.9.1",
                            Type = @"Component",
                            Position = @"PID.9.1",
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
                            Id = @"PID.9.2",
                            Type = @"Component",
                            Position = @"PID.9.2",
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
                            Id = @"PID.9.3",
                            Type = @"Component",
                            Position = @"PID.9.3",
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
                            Id = @"PID.9.4",
                            Type = @"Component",
                            Position = @"PID.9.4",
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
                            Id = @"PID.9.5",
                            Type = @"Component",
                            Position = @"PID.9.5",
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
                            Id = @"PID.9.6",
                            Type = @"Component",
                            Position = @"PID.9.6",
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
                            Id = @"PID.9.7",
                            Type = @"Component",
                            Position = @"PID.9.7",
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
                            Id = @"PID.9.8",
                            Type = @"Component",
                            Position = @"PID.9.8",
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

        _patientAlias = new HL7V23Field
        {
            field = message[@"PID"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientAlias.field.FieldRepetitions != null && _patientAlias.field.FieldRepetitions.Count > 0)
        {
            _patientAlias.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientAlias, fieldData);
        }

        return _patientAlias;
    } 
}

internal HL7V23Field _race;

public HL7V23Field Race
{
    get
    {
        if (_race != null)
        {
            return _race;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.10",
            Type = @"Field",
            Position = @"PID.10",
            Name = @"Race",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0005",
            TableName = @"Race",
            Description = @"This field refers to the patient’s race.  Refer to user-defined table 0005 - Race for suggested values",
            Sample = @"",
            Fields = null
        }

        _race = new HL7V23Field
        {
            field = message[@"PID"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_race.field.FieldRepetitions != null && _race.field.FieldRepetitions.Count > 0)
        {
            _race.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_race, fieldData);
        }

        return _race;
    } 
}

internal HL7V23Field _patientAddress;

public HL7V23Field PatientAddress
{
    get
    {
        if (_patientAddress != null)
        {
            return _patientAddress;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.11",
            Type = @"Field",
            Position = @"PID.11",
            Name = @"Patient Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the mailing address of the patient.  Address type codes are user defined.  Multiple addresses for the same person may be sent in the following sequence:  The primary mailing address must be sent first in the sequence (for backward compatibility); if the mailing address is not sent, then a repeat delimiter must be sent in the first sequence",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.11.1",
                            Type = @"Component",
                            Position = @"PID.11.1",
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
                            Id = @"PID.11.2",
                            Type = @"Component",
                            Position = @"PID.11.2",
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
                            Id = @"PID.11.3",
                            Type = @"Component",
                            Position = @"PID.11.3",
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
                            Id = @"PID.11.4",
                            Type = @"Component",
                            Position = @"PID.11.4",
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
                            Id = @"PID.11.5",
                            Type = @"Component",
                            Position = @"PID.11.5",
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
                            Id = @"PID.11.6",
                            Type = @"Component",
                            Position = @"PID.11.6",
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
                            Id = @"PID.11.7",
                            Type = @"Component",
                            Position = @"PID.11.7",
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
                            Id = @"PID.11.8",
                            Type = @"Component",
                            Position = @"PID.11.8",
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
                            Id = @"PID.11.9",
                            Type = @"Component",
                            Position = @"PID.11.9",
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
                            Id = @"PID.11.10",
                            Type = @"Component",
                            Position = @"PID.11.10",
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

        _patientAddress = new HL7V23Field
        {
            field = message[@"PID"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientAddress.field.FieldRepetitions != null && _patientAddress.field.FieldRepetitions.Count > 0)
        {
            _patientAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientAddress, fieldData);
        }

        return _patientAddress;
    } 
}

internal HL7V23Field _countyCode;

public HL7V23Field CountyCode
{
    get
    {
        if (_countyCode != null)
        {
            return _countyCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.12",
            Type = @"Field",
            Position = @"PID.12",
            Name = @"County Code",
            Length = 4,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0289",
            TableName = @"County/parish",
            Description = @"This field has been retained for backward compatibility.  This field contains the patient’s county code.  The county can now be supported in the county/parish code component of the XAD data type (PID-11-patient address).  Refer to user-defined table 0289 - County/parish for suggested values",
            Sample = @"",
            Fields = null
        }

        _countyCode = new HL7V23Field
        {
            field = message[@"PID"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_countyCode.field.FieldRepetitions != null && _countyCode.field.FieldRepetitions.Count > 0)
        {
            _countyCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_countyCode, fieldData);
        }

        return _countyCode;
    } 
}

internal HL7V23Field _phoneNumberHome;

public HL7V23Field PhoneNumberHome
{
    get
    {
        if (_phoneNumberHome != null)
        {
            return _phoneNumberHome;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.13",
            Type = @"Field",
            Position = @"PID.13",
            Name = @"Phone Number - Home",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the patient’s personal phone numbers.  All personal phone numbers for the patient are sent in the following sequence.  The first sequence is considered the primary number (for backward compatibility).  If the primary number is not sent, then a repeat delimiter is sent in the first sequence.  Refer to HL7 tables 0201 - Telecommunication use code and 0202 - Telecommunication equipment type for valid values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.13.1",
                            Type = @"Component",
                            Position = @"PID.13.1",
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
                            Id = @"PID.13.2",
                            Type = @"Component",
                            Position = @"PID.13.2",
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
                            Id = @"PID.13.3",
                            Type = @"Component",
                            Position = @"PID.13.3",
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
                            Id = @"PID.13.4",
                            Type = @"Component",
                            Position = @"PID.13.4",
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
                            Id = @"PID.13.5",
                            Type = @"Component",
                            Position = @"PID.13.5",
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
                            Id = @"PID.13.6",
                            Type = @"Component",
                            Position = @"PID.13.6",
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
                            Id = @"PID.13.7",
                            Type = @"Component",
                            Position = @"PID.13.7",
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
                            Id = @"PID.13.8",
                            Type = @"Component",
                            Position = @"PID.13.8",
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
                            Id = @"PID.13.9",
                            Type = @"Component",
                            Position = @"PID.13.9",
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

        _phoneNumberHome = new HL7V23Field
        {
            field = message[@"PID"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_phoneNumberHome.field.FieldRepetitions != null && _phoneNumberHome.field.FieldRepetitions.Count > 0)
        {
            _phoneNumberHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_phoneNumberHome, fieldData);
        }

        return _phoneNumberHome;
    } 
}

internal HL7V23Field _phoneNumberBusiness;

public HL7V23Field PhoneNumberBusiness
{
    get
    {
        if (_phoneNumberBusiness != null)
        {
            return _phoneNumberBusiness;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.14",
            Type = @"Field",
            Position = @"PID.14",
            Name = @"Phone Number - Business",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the patient’s business telephone numbers.  All business numbers for the patient are sent in the following sequence.  The first sequence is considered the patient’s primary business phone number (for backward compatibility).  If the primary business phone number is not sent, then a repeat delimiter must be sent in the first sequence.  Refer to HL7 tables 0201 - Telecommunication use code and 0202 - Telecommunication equipment type for valid values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.14.1",
                            Type = @"Component",
                            Position = @"PID.14.1",
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
                            Id = @"PID.14.2",
                            Type = @"Component",
                            Position = @"PID.14.2",
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
                            Id = @"PID.14.3",
                            Type = @"Component",
                            Position = @"PID.14.3",
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
                            Id = @"PID.14.4",
                            Type = @"Component",
                            Position = @"PID.14.4",
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
                            Id = @"PID.14.5",
                            Type = @"Component",
                            Position = @"PID.14.5",
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
                            Id = @"PID.14.6",
                            Type = @"Component",
                            Position = @"PID.14.6",
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
                            Id = @"PID.14.7",
                            Type = @"Component",
                            Position = @"PID.14.7",
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
                            Id = @"PID.14.8",
                            Type = @"Component",
                            Position = @"PID.14.8",
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
                            Id = @"PID.14.9",
                            Type = @"Component",
                            Position = @"PID.14.9",
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

        _phoneNumberBusiness = new HL7V23Field
        {
            field = message[@"PID"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_phoneNumberBusiness.field.FieldRepetitions != null && _phoneNumberBusiness.field.FieldRepetitions.Count > 0)
        {
            _phoneNumberBusiness.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_phoneNumberBusiness, fieldData);
        }

        return _phoneNumberBusiness;
    } 
}

internal HL7V23Field _primaryLanguage;

public HL7V23Field PrimaryLanguage
{
    get
    {
        if (_primaryLanguage != null)
        {
            return _primaryLanguage;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.15",
            Type = @"Field",
            Position = @"PID.15",
            Name = @"Primary Language",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0296",
            TableName = @"Primary language",
            Description = @"This field contains the patient’s primary language.  HL7 recommends using ISO table 639 as the suggested values in user-defined table 0296 - Language",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.15.1",
                            Type = @"Component",
                            Position = @"PID.15.1",
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
                            Id = @"PID.15.2",
                            Type = @"Component",
                            Position = @"PID.15.2",
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
                            Id = @"PID.15.3",
                            Type = @"Component",
                            Position = @"PID.15.3",
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
                            Id = @"PID.15.4",
                            Type = @"Component",
                            Position = @"PID.15.4",
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
                            Id = @"PID.15.5",
                            Type = @"Component",
                            Position = @"PID.15.5",
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
                            Id = @"PID.15.6",
                            Type = @"Component",
                            Position = @"PID.15.6",
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

        _primaryLanguage = new HL7V23Field
        {
            field = message[@"PID"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryLanguage.field.FieldRepetitions != null && _primaryLanguage.field.FieldRepetitions.Count > 0)
        {
            _primaryLanguage.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_primaryLanguage, fieldData);
        }

        return _primaryLanguage;
    } 
}

internal HL7V23Field _maritalStatus;

public HL7V23Field MaritalStatus
{
    get
    {
        if (_maritalStatus != null)
        {
            return _maritalStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.16",
            Type = @"Field",
            Position = @"PID.16",
            Name = @"Marital Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0002",
            TableName = @"Marital status",
            Description = @"This field contains the patient’s marital status.  Refer to user-defined table 0002 - Marital status for suggested values",
            Sample = @"",
            Fields = null
        }

        _maritalStatus = new HL7V23Field
        {
            field = message[@"PID"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_maritalStatus.field.FieldRepetitions != null && _maritalStatus.field.FieldRepetitions.Count > 0)
        {
            _maritalStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_maritalStatus, fieldData);
        }

        return _maritalStatus;
    } 
}

internal HL7V23Field _religion;

public HL7V23Field Religion
{
    get
    {
        if (_religion != null)
        {
            return _religion;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.17",
            Type = @"Field",
            Position = @"PID.17",
            Name = @"Religion",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0006",
            TableName = @"Religion",
            Description = @"This field contains the patient’s religion.  Refer to user-defined table 0006 - Religion for suggested values",
            Sample = @"",
            Fields = null
        }

        _religion = new HL7V23Field
        {
            field = message[@"PID"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_religion.field.FieldRepetitions != null && _religion.field.FieldRepetitions.Count > 0)
        {
            _religion.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_religion, fieldData);
        }

        return _religion;
    } 
}

internal HL7V23Field _patientAccountNumber;

public HL7V23Field PatientAccountNumber
{
    get
    {
        if (_patientAccountNumber != null)
        {
            return _patientAccountNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.18",
            Type = @"Field",
            Position = @"PID.18",
            Name = @"Patient Account Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains the patient account number assigned by accounting to which all charges, payments, etc., are recorded.  It is used to identify the patient’s account.  Refer to HL7 table 0061 - Check digit scheme",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.18.1",
                            Type = @"Component",
                            Position = @"PID.18.1",
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
                            Id = @"PID.18.2",
                            Type = @"Component",
                            Position = @"PID.18.2",
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
                            Id = @"PID.18.3",
                            Type = @"Component",
                            Position = @"PID.18.3",
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
                            Id = @"PID.18.4",
                            Type = @"Component",
                            Position = @"PID.18.4",
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
                            Id = @"PID.18.4.1",
                            Type = @"SubComponent",
                            Position = @"PID.18.4.1",
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
                            Id = @"PID.18.4.2",
                            Type = @"SubComponent",
                            Position = @"PID.18.4.2",
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
                            Id = @"PID.18.4.3",
                            Type = @"SubComponent",
                            Position = @"PID.18.4.3",
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
                            Id = @"PID.18.5",
                            Type = @"Component",
                            Position = @"PID.18.5",
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
                            Id = @"PID.18.6",
                            Type = @"Component",
                            Position = @"PID.18.6",
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
                            Id = @"PID.18.6.1",
                            Type = @"SubComponent",
                            Position = @"PID.18.6.1",
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
                            Id = @"PID.18.6.2",
                            Type = @"SubComponent",
                            Position = @"PID.18.6.2",
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
                            Id = @"PID.18.6.3",
                            Type = @"SubComponent",
                            Position = @"PID.18.6.3",
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

        _patientAccountNumber = new HL7V23Field
        {
            field = message[@"PID"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientAccountNumber.field.FieldRepetitions != null && _patientAccountNumber.field.FieldRepetitions.Count > 0)
        {
            _patientAccountNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientAccountNumber, fieldData);
        }

        return _patientAccountNumber;
    } 
}

internal HL7V23Field _sSNNumberPatient;

public HL7V23Field SSNNumberPatient
{
    get
    {
        if (_sSNNumberPatient != null)
        {
            return _sSNNumberPatient;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.19",
            Type = @"Field",
            Position = @"PID.19",
            Name = @"SSN Number - Patient",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the patient’s social security number.  This number may also be an RR retirement number",
            Sample = @"",
            Fields = null
        }

        _sSNNumberPatient = new HL7V23Field
        {
            field = message[@"PID"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sSNNumberPatient.field.FieldRepetitions != null && _sSNNumberPatient.field.FieldRepetitions.Count > 0)
        {
            _sSNNumberPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_sSNNumberPatient, fieldData);
        }

        return _sSNNumberPatient;
    } 
}

internal HL7V23Field _driversLicenseNumber;

public HL7V23Field DriversLicenseNumber
{
    get
    {
        if (_driversLicenseNumber != null)
        {
            return _driversLicenseNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.20",
            Type = @"Field",
            Position = @"PID.20",
            Name = @"Driver's License Number",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DLN",
            DataTypeName = @"Driver's License Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the patient’s driver’s license number.  Some sites may use this number as a unique identifier of the patient.  The default of the second component is the state in which the patient’s license is registered",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.20.1",
                            Type = @"Component",
                            Position = @"PID.20.1",
                            Name = @"Driver s License Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the driver’s license number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.20.2",
                            Type = @"Component",
                            Position = @"PID.20.2",
                            Name = @"Issuing State, Province, Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Issuing authority for driver’s license.  For state or province refer to official postal codes for that country; for country refer to ISO 3166 for codes.  Refer to user-defined table 0333 - Driver’s license issuing authority",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.20.3",
                            Type = @"Component",
                            Position = @"PID.20.3",
                            Name = @"Expiration Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Expiration date (DT) for driver’s license",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _driversLicenseNumber = new HL7V23Field
        {
            field = message[@"PID"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_driversLicenseNumber.field.FieldRepetitions != null && _driversLicenseNumber.field.FieldRepetitions.Count > 0)
        {
            _driversLicenseNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_driversLicenseNumber, fieldData);
        }

        return _driversLicenseNumber;
    } 
}

internal HL7V23Field _mothersIdentifier;

public HL7V23Field MothersIdentifier
{
    get
    {
        if (_mothersIdentifier != null)
        {
            return _mothersIdentifier;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.21",
            Type = @"Field",
            Position = @"PID.21",
            Name = @"Mother's Identifier",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"his field is used, for example, as a link field for newborns.  Typically a patient ID or account number may be used.  This field can contain multiple identifiers for the same mother.  Refer to HL7 table 0061 - Check digit scheme",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.21.1",
                            Type = @"Component",
                            Position = @"PID.21.1",
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
                            Id = @"PID.21.2",
                            Type = @"Component",
                            Position = @"PID.21.2",
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
                            Id = @"PID.21.3",
                            Type = @"Component",
                            Position = @"PID.21.3",
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
                            Id = @"PID.21.4",
                            Type = @"Component",
                            Position = @"PID.21.4",
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
                            Id = @"PID.21.4.1",
                            Type = @"SubComponent",
                            Position = @"PID.21.4.1",
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
                            Id = @"PID.21.4.2",
                            Type = @"SubComponent",
                            Position = @"PID.21.4.2",
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
                            Id = @"PID.21.4.3",
                            Type = @"SubComponent",
                            Position = @"PID.21.4.3",
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
                            Id = @"PID.21.5",
                            Type = @"Component",
                            Position = @"PID.21.5",
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
                            Id = @"PID.21.6",
                            Type = @"Component",
                            Position = @"PID.21.6",
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
                            Id = @"PID.21.6.1",
                            Type = @"SubComponent",
                            Position = @"PID.21.6.1",
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
                            Id = @"PID.21.6.2",
                            Type = @"SubComponent",
                            Position = @"PID.21.6.2",
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
                            Id = @"PID.21.6.3",
                            Type = @"SubComponent",
                            Position = @"PID.21.6.3",
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

        _mothersIdentifier = new HL7V23Field
        {
            field = message[@"PID"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mothersIdentifier.field.FieldRepetitions != null && _mothersIdentifier.field.FieldRepetitions.Count > 0)
        {
            _mothersIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_mothersIdentifier, fieldData);
        }

        return _mothersIdentifier;
    } 
}

internal HL7V23Field _ethnicGroup;

public HL7V23Field EthnicGroup
{
    get
    {
        if (_ethnicGroup != null)
        {
            return _ethnicGroup;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.22",
            Type = @"Field",
            Position = @"PID.22",
            Name = @"Ethnic Group",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0189",
            TableName = @"Ethnic group",
            Description = @"This field further defines the patient’s ancestry.  Refer to user-defined table 0189 - Ethnic group for suggested values.  ERISA has a published list of ethnic classifications that may be used by local agreement at a site",
            Sample = @"",
            Fields = null
        }

        _ethnicGroup = new HL7V23Field
        {
            field = message[@"PID"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ethnicGroup.field.FieldRepetitions != null && _ethnicGroup.field.FieldRepetitions.Count > 0)
        {
            _ethnicGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_ethnicGroup, fieldData);
        }

        return _ethnicGroup;
    } 
}

internal HL7V23Field _birthPlace;

public HL7V23Field BirthPlace
{
    get
    {
        if (_birthPlace != null)
        {
            return _birthPlace;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.23",
            Type = @"Field",
            Position = @"PID.23",
            Name = @"Birth Place",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the location of the patient’s birth",
            Sample = @"",
            Fields = null
        }

        _birthPlace = new HL7V23Field
        {
            field = message[@"PID"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_birthPlace.field.FieldRepetitions != null && _birthPlace.field.FieldRepetitions.Count > 0)
        {
            _birthPlace.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_birthPlace, fieldData);
        }

        return _birthPlace;
    } 
}

internal HL7V23Field _multipleBirthIndicator;

public HL7V23Field MultipleBirthIndicator
{
    get
    {
        if (_multipleBirthIndicator != null)
        {
            return _multipleBirthIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.24",
            Type = @"Field",
            Position = @"PID.24",
            Name = @"Multiple Birth Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether the patient was part of a multiple birth.  Refer to HL7 table 0136 - Yes/No indicator ",
            Sample = @"",
            Fields = null
        }

        _multipleBirthIndicator = new HL7V23Field
        {
            field = message[@"PID"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_multipleBirthIndicator.field.FieldRepetitions != null && _multipleBirthIndicator.field.FieldRepetitions.Count > 0)
        {
            _multipleBirthIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_multipleBirthIndicator, fieldData);
        }

        return _multipleBirthIndicator;
    } 
}

internal HL7V23Field _birthOrder;

public HL7V23Field BirthOrder
{
    get
    {
        if (_birthOrder != null)
        {
            return _birthOrder;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.25",
            Type = @"Field",
            Position = @"PID.25",
            Name = @"Birth Order",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"When a patient was part of a multiple birth, a value (number) indicating the patient’s birth order is entered in this field",
            Sample = @"",
            Fields = null
        }

        _birthOrder = new HL7V23Field
        {
            field = message[@"PID"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_birthOrder.field.FieldRepetitions != null && _birthOrder.field.FieldRepetitions.Count > 0)
        {
            _birthOrder.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_birthOrder, fieldData);
        }

        return _birthOrder;
    } 
}

internal HL7V23Field _citizenship;

public HL7V23Field Citizenship
{
    get
    {
        if (_citizenship != null)
        {
            return _citizenship;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.26",
            Type = @"Field",
            Position = @"PID.26",
            Name = @"Citizenship",
            Length = 4,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0171",
            TableName = @"Citizenship",
            Description = @"This field contains the patient’s country of citizenship.  HL7 recommends using ISO table 3166 as the suggested values in user-defined table 0171 - Citizenship",
            Sample = @"",
            Fields = null
        }

        _citizenship = new HL7V23Field
        {
            field = message[@"PID"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_citizenship.field.FieldRepetitions != null && _citizenship.field.FieldRepetitions.Count > 0)
        {
            _citizenship.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_citizenship, fieldData);
        }

        return _citizenship;
    } 
}

internal HL7V23Field _veteransMilitaryStatus;

public HL7V23Field VeteransMilitaryStatus
{
    get
    {
        if (_veteransMilitaryStatus != null)
        {
            return _veteransMilitaryStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.27",
            Type = @"Field",
            Position = @"PID.27",
            Name = @"Veterans Military Status",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0172",
            TableName = @"Veterans military status",
            Description = @"This field contains the military status assigned to a veteran.  Refer to user-defined table 0172 - Veterans military status for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.27.1",
                            Type = @"Component",
                            Position = @"PID.27.1",
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
                            Id = @"PID.27.2",
                            Type = @"Component",
                            Position = @"PID.27.2",
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
                            Id = @"PID.27.3",
                            Type = @"Component",
                            Position = @"PID.27.3",
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
                            Id = @"PID.27.4",
                            Type = @"Component",
                            Position = @"PID.27.4",
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
                            Id = @"PID.27.5",
                            Type = @"Component",
                            Position = @"PID.27.5",
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
                            Id = @"PID.27.6",
                            Type = @"Component",
                            Position = @"PID.27.6",
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

        _veteransMilitaryStatus = new HL7V23Field
        {
            field = message[@"PID"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_veteransMilitaryStatus.field.FieldRepetitions != null && _veteransMilitaryStatus.field.FieldRepetitions.Count > 0)
        {
            _veteransMilitaryStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_veteransMilitaryStatus, fieldData);
        }

        return _veteransMilitaryStatus;
    } 
}

internal HL7V23Field _nationalityCode;

public HL7V23Field NationalityCode
{
    get
    {
        if (_nationalityCode != null)
        {
            return _nationalityCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.28",
            Type = @"Field",
            Position = @"PID.28",
            Name = @"Nationality Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0212",
            TableName = @"Nationality",
            Description = @"This field contains a code that identifies the nation or national grouping to which the insured person belongs.  This information may be different from a person’s citizenship in countries in which multiple nationalities are recognized (for example, Spain: Basque, Catalan, etc.).  HL7 recommends using ISO table 3166 as he suggested values in user-defined table 0212 - Nationality",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.28.1",
                            Type = @"Component",
                            Position = @"PID.28.1",
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
                            Id = @"PID.28.2",
                            Type = @"Component",
                            Position = @"PID.28.2",
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
                            Id = @"PID.28.3",
                            Type = @"Component",
                            Position = @"PID.28.3",
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
                            Id = @"PID.28.4",
                            Type = @"Component",
                            Position = @"PID.28.4",
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
                            Id = @"PID.28.5",
                            Type = @"Component",
                            Position = @"PID.28.5",
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
                            Id = @"PID.28.6",
                            Type = @"Component",
                            Position = @"PID.28.6",
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

        _nationalityCode = new HL7V23Field
        {
            field = message[@"PID"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nationalityCode.field.FieldRepetitions != null && _nationalityCode.field.FieldRepetitions.Count > 0)
        {
            _nationalityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nationalityCode, fieldData);
        }

        return _nationalityCode;
    } 
}

internal HL7V23Field _patientDeathDateandTime;

public HL7V23Field PatientDeathDateandTime
{
    get
    {
        if (_patientDeathDateandTime != null)
        {
            return _patientDeathDateandTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.29",
            Type = @"Field",
            Position = @"PID.29",
            Name = @"Patient Death Date and Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @" This field contains the date and time at which the patient death occurred",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.29.1",
                            Type = @"Component",
                            Position = @"PID.29.1",
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

        _patientDeathDateandTime = new HL7V23Field
        {
            field = message[@"PID"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientDeathDateandTime.field.FieldRepetitions != null && _patientDeathDateandTime.field.FieldRepetitions.Count > 0)
        {
            _patientDeathDateandTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientDeathDateandTime, fieldData);
        }

        return _patientDeathDateandTime;
    } 
}

internal HL7V23Field _patientDeathIndicator;

public HL7V23Field PatientDeathIndicator
{
    get
    {
        if (_patientDeathIndicator != null)
        {
            return _patientDeathIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PID.30",
            Type = @"Field",
            Position = @"PID.30",
            Name = @"Patient Death Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether or not the patient is deceased.  Refer to Chapter 2, HL7 table 0136 - Yes/no indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _patientDeathIndicator = new HL7V23Field
        {
            field = message[@"PID"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientDeathIndicator.field.FieldRepetitions != null && _patientDeathIndicator.field.FieldRepetitions.Count > 0)
        {
            _patientDeathIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientDeathIndicator, fieldData);
        }

        return _patientDeathIndicator;
    } 
}
    }
}
