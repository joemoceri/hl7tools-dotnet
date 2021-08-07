using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentFHS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"FHS"; } }

        public string SegmentId { get { return @"FHS"; } }
        
        public string LongName { get { return @"File Header"; } }
        
        public string Description { get { return @"The FHS segment is used to head a file (group of batches) as defined in Section 2.10.3, ""HL7 batch protocol""."; } }
        
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
                            Id = @"FHS.1",
                            Type = @"Field",
                            Position = @"FHS.1",
                            Name = @"File Field Separator",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.2",
                            Type = @"Field",
                            Position = @"FHS.2",
                            Name = @"File Encoding Characters",
                            Length = 5,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.3",
                            Type = @"Field",
                            Position = @"FHS.3",
                            Name = @"File Sending Application",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"FHS.3.1",
                            Type = @"Component",
                            Position = @"FHS.3.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.3.2",
                            Type = @"Component",
                            Position = @"FHS.3.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.3.3",
                            Type = @"Component",
                            Position = @"FHS.3.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.4",
                            Type = @"Field",
                            Position = @"FHS.4",
                            Name = @"File Sending Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"FHS.4.1",
                            Type = @"Component",
                            Position = @"FHS.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.4.2",
                            Type = @"Component",
                            Position = @"FHS.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.4.3",
                            Type = @"Component",
                            Position = @"FHS.4.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.5",
                            Type = @"Field",
                            Position = @"FHS.5",
                            Name = @"File Receiving Application",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"FHS.5.1",
                            Type = @"Component",
                            Position = @"FHS.5.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.5.2",
                            Type = @"Component",
                            Position = @"FHS.5.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.5.3",
                            Type = @"Component",
                            Position = @"FHS.5.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.6",
                            Type = @"Field",
                            Position = @"FHS.6",
                            Name = @"File Receiving Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"FHS.6.1",
                            Type = @"Component",
                            Position = @"FHS.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.6.2",
                            Type = @"Component",
                            Position = @"FHS.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.6.3",
                            Type = @"Component",
                            Position = @"FHS.6.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.7",
                            Type = @"Field",
                            Position = @"FHS.7",
                            Name = @"File Creation Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.8",
                            Type = @"Field",
                            Position = @"FHS.8",
                            Name = @"File Security",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.9",
                            Type = @"Field",
                            Position = @"FHS.9",
                            Name = @"File Name/Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field can be used by the application processing file. Its use is not further specified.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.10",
                            Type = @"Field",
                            Position = @"FHS.10",
                            Name = @"File Header Comment",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the free text field, the use of which is not further specified.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.11",
                            Type = @"Field",
                            Position = @"FHS.11",
                            Name = @"File Control Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to identify a particular file uniquely. It can be echoed back in FHS-12-reference file control ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.12",
                            Type = @"Field",
                            Position = @"FHS.12",
                            Name = @"Reference File Control Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the value of FHS-11-file control ID when this file was originally transmitted. Not present if this file is being transmitted for the first time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.13",
                            Type = @"Field",
                            Position = @"FHS.13",
                            Name = @"File Sending Network Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifier of the network location the message was transmitted from. Identified by an OID or text string (e.g., URI). The reader is referred to the ""Report from the Joint W3C/IETF URI Planning Interest Group: Uniform Resource Identifiers (URIs), URLs, and Uniform Resource Names (URNs): Clarifications and Recommendations"".",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"FHS.13.1",
                            Type = @"Component",
                            Position = @"FHS.13.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.13.2",
                            Type = @"Component",
                            Position = @"FHS.13.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.13.3",
                            Type = @"Component",
                            Position = @"FHS.13.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.14",
                            Type = @"Field",
                            Position = @"FHS.14",
                            Name = @"File Receiving Network Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifier of the network location the message was transmitted to. Identified by an OID or text string. (e.g., URL).

This is analogous with the Sending Network Address, however in the receiving role.

This field should only be populated when the underlying communication protocol does not support identification receiving network locations.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"FHS.14.1",
                            Type = @"Component",
                            Position = @"FHS.14.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.14.2",
                            Type = @"Component",
                            Position = @"FHS.14.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.14.3",
                            Type = @"Component",
                            Position = @"FHS.14.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V271SegmentFHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field fileFieldSeparator;

public HL7V271Field FileFieldSeparator
{
    get
    {
        if (fileFieldSeparator != null)
        {
            return fileFieldSeparator;
        }

        fileFieldSeparator = new HL7V271Field
        {
            field = message[@"FHS"][1],
            Id = @"FHS.1",
            Type = @"Field",
            Position = @"FHS.1",
            Name = @"File Field Separator",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
        };

        

        

        

        return fileFieldSeparator;
    } 
}
internal HL7V271Field fileEncodingCharacters;

public HL7V271Field FileEncodingCharacters
{
    get
    {
        if (fileEncodingCharacters != null)
        {
            return fileEncodingCharacters;
        }

        fileEncodingCharacters = new HL7V271Field
        {
            field = message[@"FHS"][2],
            Id = @"FHS.2",
            Type = @"Field",
            Position = @"FHS.2",
            Name = @"File Encoding Characters",
            Length = 5,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
        };

        

        

        

        return fileEncodingCharacters;
    } 
}
internal HL7V271Field fileSendingApplication;

public HL7V271Field FileSendingApplication
{
    get
    {
        if (fileSendingApplication != null)
        {
            return fileSendingApplication;
        }

        fileSendingApplication = new HL7V271Field
        {
            field = message[@"FHS"][3],
            Id = @"FHS.3",
            Type = @"Field",
            Position = @"FHS.3",
            Name = @"File Sending Application",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
        };

        

        

        

        return fileSendingApplication;
    } 
}
internal HL7V271Field fileSendingFacility;

public HL7V271Field FileSendingFacility
{
    get
    {
        if (fileSendingFacility != null)
        {
            return fileSendingFacility;
        }

        fileSendingFacility = new HL7V271Field
        {
            field = message[@"FHS"][4],
            Id = @"FHS.4",
            Type = @"Field",
            Position = @"FHS.4",
            Name = @"File Sending Facility",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
        };

        

        

        

        return fileSendingFacility;
    } 
}
internal HL7V271Field fileReceivingApplication;

public HL7V271Field FileReceivingApplication
{
    get
    {
        if (fileReceivingApplication != null)
        {
            return fileReceivingApplication;
        }

        fileReceivingApplication = new HL7V271Field
        {
            field = message[@"FHS"][5],
            Id = @"FHS.5",
            Type = @"Field",
            Position = @"FHS.5",
            Name = @"File Receiving Application",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
        };

        

        

        

        return fileReceivingApplication;
    } 
}
internal HL7V271Field fileReceivingFacility;

public HL7V271Field FileReceivingFacility
{
    get
    {
        if (fileReceivingFacility != null)
        {
            return fileReceivingFacility;
        }

        fileReceivingFacility = new HL7V271Field
        {
            field = message[@"FHS"][6],
            Id = @"FHS.6",
            Type = @"Field",
            Position = @"FHS.6",
            Name = @"File Receiving Facility",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
        };

        

        

        

        return fileReceivingFacility;
    } 
}
internal HL7V271Field fileCreationDateTime;

public HL7V271Field FileCreationDateTime
{
    get
    {
        if (fileCreationDateTime != null)
        {
            return fileCreationDateTime;
        }

        fileCreationDateTime = new HL7V271Field
        {
            field = message[@"FHS"][7],
            Id = @"FHS.7",
            Type = @"Field",
            Position = @"FHS.7",
            Name = @"File Creation Date/Time",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
        };

        

        

        

        return fileCreationDateTime;
    } 
}
internal HL7V271Field fileSecurity;

public HL7V271Field FileSecurity
{
    get
    {
        if (fileSecurity != null)
        {
            return fileSecurity;
        }

        fileSecurity = new HL7V271Field
        {
            field = message[@"FHS"][8],
            Id = @"FHS.8",
            Type = @"Field",
            Position = @"FHS.8",
            Name = @"File Security",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
        };

        

        

        

        return fileSecurity;
    } 
}
internal HL7V271Field fileNameId;

public HL7V271Field FileNameId
{
    get
    {
        if (fileNameId != null)
        {
            return fileNameId;
        }

        fileNameId = new HL7V271Field
        {
            field = message[@"FHS"][9],
            Id = @"FHS.9",
            Type = @"Field",
            Position = @"FHS.9",
            Name = @"File Name/Id",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field can be used by the application processing file. Its use is not further specified.",
            Sample = @"",
        };

        

        

        

        return fileNameId;
    } 
}
internal HL7V271Field fileHeaderComment;

public HL7V271Field FileHeaderComment
{
    get
    {
        if (fileHeaderComment != null)
        {
            return fileHeaderComment;
        }

        fileHeaderComment = new HL7V271Field
        {
            field = message[@"FHS"][10],
            Id = @"FHS.10",
            Type = @"Field",
            Position = @"FHS.10",
            Name = @"File Header Comment",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the free text field, the use of which is not further specified.",
            Sample = @"",
        };

        

        

        

        return fileHeaderComment;
    } 
}
internal HL7V271Field fileControlId;

public HL7V271Field FileControlId
{
    get
    {
        if (fileControlId != null)
        {
            return fileControlId;
        }

        fileControlId = new HL7V271Field
        {
            field = message[@"FHS"][11],
            Id = @"FHS.11",
            Type = @"Field",
            Position = @"FHS.11",
            Name = @"File Control Id",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to identify a particular file uniquely. It can be echoed back in FHS-12-reference file control ID.",
            Sample = @"",
        };

        

        

        

        return fileControlId;
    } 
}
internal HL7V271Field referenceFileControlId;

public HL7V271Field ReferenceFileControlId
{
    get
    {
        if (referenceFileControlId != null)
        {
            return referenceFileControlId;
        }

        referenceFileControlId = new HL7V271Field
        {
            field = message[@"FHS"][12],
            Id = @"FHS.12",
            Type = @"Field",
            Position = @"FHS.12",
            Name = @"Reference File Control Id",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the value of FHS-11-file control ID when this file was originally transmitted. Not present if this file is being transmitted for the first time.",
            Sample = @"",
        };

        

        

        

        return referenceFileControlId;
    } 
}
internal HL7V271Field fileSendingNetworkAddress;

public HL7V271Field FileSendingNetworkAddress
{
    get
    {
        if (fileSendingNetworkAddress != null)
        {
            return fileSendingNetworkAddress;
        }

        fileSendingNetworkAddress = new HL7V271Field
        {
            field = message[@"FHS"][13],
            Id = @"FHS.13",
            Type = @"Field",
            Position = @"FHS.13",
            Name = @"File Sending Network Address",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"Identifier of the network location the message was transmitted from. Identified by an OID or text string (e.g., URI). The reader is referred to the ""Report from the Joint W3C/IETF URI Planning Interest Group: Uniform Resource Identifiers (URIs), URLs, and Uniform Resource Names (URNs): Clarifications and Recommendations"".",
            Sample = @"",
        };

        

        

        

        return fileSendingNetworkAddress;
    } 
}
internal HL7V271Field fileReceivingNetworkAddress;

public HL7V271Field FileReceivingNetworkAddress
{
    get
    {
        if (fileReceivingNetworkAddress != null)
        {
            return fileReceivingNetworkAddress;
        }

        fileReceivingNetworkAddress = new HL7V271Field
        {
            field = message[@"FHS"][14],
            Id = @"FHS.14",
            Type = @"Field",
            Position = @"FHS.14",
            Name = @"File Receiving Network Address",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"Identifier of the network location the message was transmitted to. Identified by an OID or text string. (e.g., URL).

This is analogous with the Sending Network Address, however in the receiving role.

This field should only be populated when the underlying communication protocol does not support identification receiving network locations.",
            Sample = @"",
        };

        

        

        

        return fileReceivingNetworkAddress;
    } 
}

    }
}
