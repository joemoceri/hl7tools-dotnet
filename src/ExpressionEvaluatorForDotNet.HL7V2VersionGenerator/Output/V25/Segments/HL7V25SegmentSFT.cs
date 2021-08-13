using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentSFT
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SFT"; } }

        public string SegmentId { get { return @"SFT"; } }
        
        public string LongName { get { return @"Software Segment"; } }
        
        public string Description { get { return @"This segment provides additional information about the software product(s) used as a Sending Application. The primary purpose of this segment is for diagnostic use. There may be additional uses per site-specific agreements.

Example: MSH [{ SFT }] ….. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V25SegmentSFT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _softwareVendorOrganization;

public HL7V25Field SoftwareVendorOrganization
{
    get
    {
        if (_softwareVendorOrganization != null)
        {
            return _softwareVendorOrganization;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SFT.1",
            Type = @"Field",
            Position = @"SFT.1",
            Name = @"Software Vendor Organization",
            Length = 567,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
            TableId = null,
            TableName = null,
            Description = @"Organization identification information for the software vendor that created this transaction. The purpose of this field, along with the remaining fields in this segment, is to provide a more complete picture of applications that are sending HL7 messages. The Software Vendor Organization field would allow the identification of the vendor who is responsible for maintaining the application.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SFT.1.1",
                            Type = @"Component",
                            Position = @"SFT.1.1",
                            Name = @"Organization Name",
                            Length = 50,
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
                            Id = @"SFT.1.2",
                            Type = @"Component",
                            Position = @"SFT.1.2",
                            Name = @"Organization Name Type Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.3",
                            Type = @"Component",
                            Position = @"SFT.1.3",
                            Name = @"Id Number",
                            Length = 4,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component has been retained for backward compatibility only as of v 2.5. It is recommended to use component 10 Organization identifier that accommodates alphanumeric identifiers.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.4",
                            Type = @"Component",
                            Position = @"SFT.1.4",
                            Name = @"Check Digit",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.5",
                            Type = @"Component",
                            Position = @"SFT.1.5",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.6",
                            Type = @"Component",
                            Position = @"SFT.1.6",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SFT.1.6.1",
                            Type = @"SubComponent",
                            Position = @"SFT.1.6.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.6.2",
                            Type = @"SubComponent",
                            Position = @"SFT.1.6.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SFT.1.6.3",
                            Type = @"SubComponent",
                            Position = @"SFT.1.6.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
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
                            Id = @"SFT.1.7",
                            Type = @"Component",
                            Position = @"SFT.1.7",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the ""Assigning authority"" component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.8",
                            Type = @"Component",
                            Position = @"SFT.1.8",
                            Name = @"Assigning Facility",
                            Length = 227,
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
                            Id = @"SFT.1.8.1",
                            Type = @"SubComponent",
                            Position = @"SFT.1.8.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.8.2",
                            Type = @"SubComponent",
                            Position = @"SFT.1.8.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SFT.1.8.3",
                            Type = @"SubComponent",
                            Position = @"SFT.1.8.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
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
                            Id = @"SFT.1.9",
                            Type = @"Component",
                            Position = @"SFT.1.9",
                            Name = @"Name Representation Code",
                            Length = 1,
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
                            Id = @"SFT.1.10",
                            Type = @"Component",
                            Position = @"SFT.1.10",
                            Name = @"Organization Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _softwareVendorOrganization = new HL7V25Field
        {
            field = message[@"SFT"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_softwareVendorOrganization.field.FieldRepetitions != null && _softwareVendorOrganization.field.FieldRepetitions.Count > 0)
        {
            _softwareVendorOrganization.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_softwareVendorOrganization, fieldData);
        }

        return _softwareVendorOrganization;
    } 
}

internal HL7V25Field _softwareCertifiedVersionorReleaseNumber;

public HL7V25Field SoftwareCertifiedVersionorReleaseNumber
{
    get
    {
        if (_softwareCertifiedVersionorReleaseNumber != null)
        {
            return _softwareCertifiedVersionorReleaseNumber;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SFT.2",
            Type = @"Field",
            Position = @"SFT.2",
            Name = @"Software Certified Version or Release Number",
            Length = 15,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Latest software version number of the sending system that has been compliance tested and accepted. Software Certified Version or Release Number helps to provide a complete picture of the application that is sending/receiving HL7 messages. Versions are important in identifying a specific release of an application. In some situations, the receiving application validates the Software Certified Version or Release Number against a list of ""certified"" versions/releases of the particular software to determine if the sending application adheres to specific business rules required by the receiving application.",
            Sample = @"",
            Fields = null
        }

        _softwareCertifiedVersionorReleaseNumber = new HL7V25Field
        {
            field = message[@"SFT"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_softwareCertifiedVersionorReleaseNumber.field.FieldRepetitions != null && _softwareCertifiedVersionorReleaseNumber.field.FieldRepetitions.Count > 0)
        {
            _softwareCertifiedVersionorReleaseNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_softwareCertifiedVersionorReleaseNumber, fieldData);
        }

        return _softwareCertifiedVersionorReleaseNumber;
    } 
}

internal HL7V25Field _softwareProductName;

public HL7V25Field SoftwareProductName
{
    get
    {
        if (_softwareProductName != null)
        {
            return _softwareProductName;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SFT.3",
            Type = @"Field",
            Position = @"SFT.3",
            Name = @"Software Product Name",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The name of the software product that submitted the transaction. A key component in the identification of an application is its Software Product Name. This is a key piece of information in identifying an application.",
            Sample = @"",
            Fields = null
        }

        _softwareProductName = new HL7V25Field
        {
            field = message[@"SFT"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_softwareProductName.field.FieldRepetitions != null && _softwareProductName.field.FieldRepetitions.Count > 0)
        {
            _softwareProductName.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_softwareProductName, fieldData);
        }

        return _softwareProductName;
    } 
}

internal HL7V25Field _softwareBinaryID;

public HL7V25Field SoftwareBinaryID
{
    get
    {
        if (_softwareBinaryID != null)
        {
            return _softwareBinaryID;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SFT.4",
            Type = @"Field",
            Position = @"SFT.4",
            Name = @"Software Binary ID",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Issued by a vendor for each unique software version instance to distinguish between like versions of the same software e.g., a checksum.",
            Sample = @"",
            Fields = null
        }

        _softwareBinaryID = new HL7V25Field
        {
            field = message[@"SFT"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_softwareBinaryID.field.FieldRepetitions != null && _softwareBinaryID.field.FieldRepetitions.Count > 0)
        {
            _softwareBinaryID.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_softwareBinaryID, fieldData);
        }

        return _softwareBinaryID;
    } 
}

internal HL7V25Field _softwareProductInformation;

public HL7V25Field SoftwareProductInformation
{
    get
    {
        if (_softwareProductInformation != null)
        {
            return _softwareProductInformation;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SFT.5",
            Type = @"Field",
            Position = @"SFT.5",
            Name = @"Software Product Information",
            Length = 1024,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"Software identification information that can be supplied by a software vendor with their transaction. Might include configuration settings, etc.",
            Sample = @"",
            Fields = null
        }

        _softwareProductInformation = new HL7V25Field
        {
            field = message[@"SFT"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_softwareProductInformation.field.FieldRepetitions != null && _softwareProductInformation.field.FieldRepetitions.Count > 0)
        {
            _softwareProductInformation.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_softwareProductInformation, fieldData);
        }

        return _softwareProductInformation;
    } 
}

internal HL7V25Field _softwareInstallDate;

public HL7V25Field SoftwareInstallDate
{
    get
    {
        if (_softwareInstallDate != null)
        {
            return _softwareInstallDate;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SFT.6",
            Type = @"Field",
            Position = @"SFT.6",
            Name = @"Software Install Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"Date the submitting software was installed at the sending site.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SFT.6.1",
                            Type = @"Component",
                            Position = @"SFT.6.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.6.2",
                            Type = @"Component",
                            Position = @"SFT.6.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision.

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _softwareInstallDate = new HL7V25Field
        {
            field = message[@"SFT"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_softwareInstallDate.field.FieldRepetitions != null && _softwareInstallDate.field.FieldRepetitions.Count > 0)
        {
            _softwareInstallDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_softwareInstallDate, fieldData);
        }

        return _softwareInstallDate;
    } 
}
    }
}
