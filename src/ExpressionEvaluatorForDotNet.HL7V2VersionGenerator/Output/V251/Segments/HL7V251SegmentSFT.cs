using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentSFT
    {
        public readonly HL7V2Message message;

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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = 
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
                            FieldDatas = 
                        new HL7V2FieldData
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
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
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
                        },
                        
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
                            FieldDatas = 
                        new HL7V2FieldData
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
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
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
                        },
                        
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
                        
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = 
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
                        
                        },
                        };
            }
        }

        public HL7V251SegmentSFT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field softwareVendorOrganization;

public HL7V251Field SoftwareVendorOrganization
{
    get
    {
        if (softwareVendorOrganization != null)
        {
            return softwareVendorOrganization;
        }

        softwareVendorOrganization = new HL7V251Field
        {
            field = message[@"SFT"][1],
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
        };

        

        

        

        return softwareVendorOrganization;
    } 
}
internal HL7V251Field softwareCertifiedVersionorReleaseNumber;

public HL7V251Field SoftwareCertifiedVersionorReleaseNumber
{
    get
    {
        if (softwareCertifiedVersionorReleaseNumber != null)
        {
            return softwareCertifiedVersionorReleaseNumber;
        }

        softwareCertifiedVersionorReleaseNumber = new HL7V251Field
        {
            field = message[@"SFT"][2],
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
        };

        

        

        

        return softwareCertifiedVersionorReleaseNumber;
    } 
}
internal HL7V251Field softwareProductName;

public HL7V251Field SoftwareProductName
{
    get
    {
        if (softwareProductName != null)
        {
            return softwareProductName;
        }

        softwareProductName = new HL7V251Field
        {
            field = message[@"SFT"][3],
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
        };

        

        

        

        return softwareProductName;
    } 
}
internal HL7V251Field softwareBinaryID;

public HL7V251Field SoftwareBinaryID
{
    get
    {
        if (softwareBinaryID != null)
        {
            return softwareBinaryID;
        }

        softwareBinaryID = new HL7V251Field
        {
            field = message[@"SFT"][4],
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
        };

        

        

        

        return softwareBinaryID;
    } 
}
internal HL7V251Field softwareProductInformation;

public HL7V251Field SoftwareProductInformation
{
    get
    {
        if (softwareProductInformation != null)
        {
            return softwareProductInformation;
        }

        softwareProductInformation = new HL7V251Field
        {
            field = message[@"SFT"][5],
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
        };

        

        

        

        return softwareProductInformation;
    } 
}
internal HL7V251Field softwareInstallDate;

public HL7V251Field SoftwareInstallDate
{
    get
    {
        if (softwareInstallDate != null)
        {
            return softwareInstallDate;
        }

        softwareInstallDate = new HL7V251Field
        {
            field = message[@"SFT"][6],
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
        };

        

        

        

        return softwareInstallDate;
    } 
}

    }
}
