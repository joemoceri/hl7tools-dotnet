using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentTXA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"TXA"; } }

        public string SegmentId { get { return @"TXA"; } }
        
        public string LongName { get { return @"Document notification segment"; } }
        
        public string Description { get { return @"The TXA segment contains information specific to a transcribed document but does not include the text of the document.  The message is created as a result of a document status change.  This information is used to update other healthcare systems to identify reports that are available in the transcription system.  By maintaining the TXA message information in these systems, the information is available when constructing queries to the transcription system requesting the full document text."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

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
                            Id = @"TXA.1",
                            Type = @"Field",
                            Position = @"TXA.1",
                            Name = @"Set ID- TXA",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.2",
                            Type = @"Field",
                            Position = @"TXA.2",
                            Name = @"Document Type",
                            Length = 30,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0270",
                            TableName = @"Document type",
                            Description = @"This field identifies the type of document (as defined in the transcription system).  Refer to userdefined table 0270 - Document type for suggested values.  The organization is free to add more entries",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.3",
                            Type = @"Field",
                            Position = @"TXA.3",
                            Name = @"Document Content Presentation",
                            Length = 2,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0191",
                            TableName = @"Type of referenced data",
                            Description = @"This is a conditional field which is required whenever the message contains content as presented in one or more OBX segments.  This field identifies the method by which this document was obtained or originated.  Refer to HL7 table 0191 - Main type of referenced data for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.4",
                            Type = @"Field",
                            Position = @"TXA.4",
                            Name = @"Activity Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time identified in the document as the date a procedure or activity was performed.  This date can identify date of surgery, non-invasive procedure, consultation, examination, etc",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.4.1",
                            Type = @"Component",
                            Position = @"TXA.4.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.5",
                            Type = @"Field",
                            Position = @"TXA.5",
                            Name = @"Primary Activity Provider Code/Name",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the person identified in the document as being responsible for performing the procedure or activity.  This field includes the code and name (if available) of the caregiver. This field is conditional based upon the presence of a value in TXA-4-activity date",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.5.1",
                            Type = @"Component",
                            Position = @"TXA.5.1",
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
                            Id = @"TXA.5.2",
                            Type = @"Component",
                            Position = @"TXA.5.2",
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
                            Id = @"TXA.5.3",
                            Type = @"Component",
                            Position = @"TXA.5.3",
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
                            Id = @"TXA.5.4",
                            Type = @"Component",
                            Position = @"TXA.5.4",
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
                            Id = @"TXA.5.5",
                            Type = @"Component",
                            Position = @"TXA.5.5",
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
                            Id = @"TXA.5.6",
                            Type = @"Component",
                            Position = @"TXA.5.6",
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
                            Id = @"TXA.5.7",
                            Type = @"Component",
                            Position = @"TXA.5.7",
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
                            Id = @"TXA.5.8",
                            Type = @"Component",
                            Position = @"TXA.5.8",
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
                            Id = @"TXA.5.9",
                            Type = @"Component",
                            Position = @"TXA.5.9",
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
                            Id = @"TXA.5.9.1",
                            Type = @"SubComponent",
                            Position = @"TXA.5.9.1",
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
                            Id = @"TXA.5.9.2",
                            Type = @"SubComponent",
                            Position = @"TXA.5.9.2",
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
                            Id = @"TXA.5.9.3",
                            Type = @"SubComponent",
                            Position = @"TXA.5.9.3",
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
                            Id = @"TXA.5.10",
                            Type = @"Component",
                            Position = @"TXA.5.10",
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
                            Id = @"TXA.5.11",
                            Type = @"Component",
                            Position = @"TXA.5.11",
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
                            Id = @"TXA.5.12",
                            Type = @"Component",
                            Position = @"TXA.5.12",
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
                            Id = @"TXA.5.13",
                            Type = @"Component",
                            Position = @"TXA.5.13",
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
                            Id = @"TXA.5.14",
                            Type = @"Component",
                            Position = @"TXA.5.14",
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
                            Id = @"TXA.5.14.1",
                            Type = @"SubComponent",
                            Position = @"TXA.5.14.1",
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
                            Id = @"TXA.5.14.2",
                            Type = @"SubComponent",
                            Position = @"TXA.5.14.2",
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
                            Id = @"TXA.5.14.3",
                            Type = @"SubComponent",
                            Position = @"TXA.5.14.3",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.6",
                            Type = @"Field",
                            Position = @"TXA.6",
                            Name = @"Origination Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time the document was created (i.e., dictated, recorded, etc.). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.6.1",
                            Type = @"Component",
                            Position = @"TXA.6.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.7",
                            Type = @"Field",
                            Position = @"TXA.7",
                            Name = @"Transcription Date/Time",
                            Length = 26,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time the input was actually transcribed.  This field is conditional based upon the presence of a value in TXA-17-document status of anything except “dictated.” ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.7.1",
                            Type = @"Component",
                            Position = @"TXA.7.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.8",
                            Type = @"Field",
                            Position = @"TXA.8",
                            Name = @"Edit Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time the document was edited",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.8.1",
                            Type = @"Component",
                            Position = @"TXA.8.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.9",
                            Type = @"Field",
                            Position = @"TXA.9",
                            Name = @"Originator Code/Name",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the person who originated (i.e., dictated) the document.  The document originator may differ from the person responsible for authenticating the document",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.9.1",
                            Type = @"Component",
                            Position = @"TXA.9.1",
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
                            Id = @"TXA.9.2",
                            Type = @"Component",
                            Position = @"TXA.9.2",
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
                            Id = @"TXA.9.3",
                            Type = @"Component",
                            Position = @"TXA.9.3",
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
                            Id = @"TXA.9.4",
                            Type = @"Component",
                            Position = @"TXA.9.4",
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
                            Id = @"TXA.9.5",
                            Type = @"Component",
                            Position = @"TXA.9.5",
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
                            Id = @"TXA.9.6",
                            Type = @"Component",
                            Position = @"TXA.9.6",
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
                            Id = @"TXA.9.7",
                            Type = @"Component",
                            Position = @"TXA.9.7",
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
                            Id = @"TXA.9.8",
                            Type = @"Component",
                            Position = @"TXA.9.8",
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
                            Id = @"TXA.9.9",
                            Type = @"Component",
                            Position = @"TXA.9.9",
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
                            Id = @"TXA.9.9.1",
                            Type = @"SubComponent",
                            Position = @"TXA.9.9.1",
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
                            Id = @"TXA.9.9.2",
                            Type = @"SubComponent",
                            Position = @"TXA.9.9.2",
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
                            Id = @"TXA.9.9.3",
                            Type = @"SubComponent",
                            Position = @"TXA.9.9.3",
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
                            Id = @"TXA.9.10",
                            Type = @"Component",
                            Position = @"TXA.9.10",
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
                            Id = @"TXA.9.11",
                            Type = @"Component",
                            Position = @"TXA.9.11",
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
                            Id = @"TXA.9.12",
                            Type = @"Component",
                            Position = @"TXA.9.12",
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
                            Id = @"TXA.9.13",
                            Type = @"Component",
                            Position = @"TXA.9.13",
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
                            Id = @"TXA.9.14",
                            Type = @"Component",
                            Position = @"TXA.9.14",
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
                            Id = @"TXA.9.14.1",
                            Type = @"SubComponent",
                            Position = @"TXA.9.14.1",
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
                            Id = @"TXA.9.14.2",
                            Type = @"SubComponent",
                            Position = @"TXA.9.14.2",
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
                            Id = @"TXA.9.14.3",
                            Type = @"SubComponent",
                            Position = @"TXA.9.14.3",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.10",
                            Type = @"Field",
                            Position = @"TXA.10",
                            Name = @"Assigned Document Authenticator",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the person(s) responsible for authenticating the document, who may differ from the originator.  Multiple persons may be responsible for authentication, especially in teaching facilities.  This field is allowed to repeat an undefined number of times",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.10.1",
                            Type = @"Component",
                            Position = @"TXA.10.1",
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
                            Id = @"TXA.10.2",
                            Type = @"Component",
                            Position = @"TXA.10.2",
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
                            Id = @"TXA.10.3",
                            Type = @"Component",
                            Position = @"TXA.10.3",
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
                            Id = @"TXA.10.4",
                            Type = @"Component",
                            Position = @"TXA.10.4",
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
                            Id = @"TXA.10.5",
                            Type = @"Component",
                            Position = @"TXA.10.5",
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
                            Id = @"TXA.10.6",
                            Type = @"Component",
                            Position = @"TXA.10.6",
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
                            Id = @"TXA.10.7",
                            Type = @"Component",
                            Position = @"TXA.10.7",
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
                            Id = @"TXA.10.8",
                            Type = @"Component",
                            Position = @"TXA.10.8",
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
                            Id = @"TXA.10.9",
                            Type = @"Component",
                            Position = @"TXA.10.9",
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
                            Id = @"TXA.10.9.1",
                            Type = @"SubComponent",
                            Position = @"TXA.10.9.1",
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
                            Id = @"TXA.10.9.2",
                            Type = @"SubComponent",
                            Position = @"TXA.10.9.2",
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
                            Id = @"TXA.10.9.3",
                            Type = @"SubComponent",
                            Position = @"TXA.10.9.3",
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
                            Id = @"TXA.10.10",
                            Type = @"Component",
                            Position = @"TXA.10.10",
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
                            Id = @"TXA.10.11",
                            Type = @"Component",
                            Position = @"TXA.10.11",
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
                            Id = @"TXA.10.12",
                            Type = @"Component",
                            Position = @"TXA.10.12",
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
                            Id = @"TXA.10.13",
                            Type = @"Component",
                            Position = @"TXA.10.13",
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
                            Id = @"TXA.10.14",
                            Type = @"Component",
                            Position = @"TXA.10.14",
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
                            Id = @"TXA.10.14.1",
                            Type = @"SubComponent",
                            Position = @"TXA.10.14.1",
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
                            Id = @"TXA.10.14.2",
                            Type = @"SubComponent",
                            Position = @"TXA.10.14.2",
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
                            Id = @"TXA.10.14.3",
                            Type = @"SubComponent",
                            Position = @"TXA.10.14.3",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.11",
                            Type = @"Field",
                            Position = @"TXA.11",
                            Name = @"Transcriptionist Code/Name",
                            Length = 48,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the person transcribing the document. This is a conditional value; it is required on all transcribed documents",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.11.1",
                            Type = @"Component",
                            Position = @"TXA.11.1",
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
                            Id = @"TXA.11.2",
                            Type = @"Component",
                            Position = @"TXA.11.2",
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
                            Id = @"TXA.11.3",
                            Type = @"Component",
                            Position = @"TXA.11.3",
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
                            Id = @"TXA.11.4",
                            Type = @"Component",
                            Position = @"TXA.11.4",
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
                            Id = @"TXA.11.5",
                            Type = @"Component",
                            Position = @"TXA.11.5",
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
                            Id = @"TXA.11.6",
                            Type = @"Component",
                            Position = @"TXA.11.6",
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
                            Id = @"TXA.11.7",
                            Type = @"Component",
                            Position = @"TXA.11.7",
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
                            Id = @"TXA.11.8",
                            Type = @"Component",
                            Position = @"TXA.11.8",
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
                            Id = @"TXA.11.9",
                            Type = @"Component",
                            Position = @"TXA.11.9",
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
                            Id = @"TXA.11.9.1",
                            Type = @"SubComponent",
                            Position = @"TXA.11.9.1",
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
                            Id = @"TXA.11.9.2",
                            Type = @"SubComponent",
                            Position = @"TXA.11.9.2",
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
                            Id = @"TXA.11.9.3",
                            Type = @"SubComponent",
                            Position = @"TXA.11.9.3",
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
                            Id = @"TXA.11.10",
                            Type = @"Component",
                            Position = @"TXA.11.10",
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
                            Id = @"TXA.11.11",
                            Type = @"Component",
                            Position = @"TXA.11.11",
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
                            Id = @"TXA.11.12",
                            Type = @"Component",
                            Position = @"TXA.11.12",
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
                            Id = @"TXA.11.13",
                            Type = @"Component",
                            Position = @"TXA.11.13",
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
                            Id = @"TXA.11.14",
                            Type = @"Component",
                            Position = @"TXA.11.14",
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
                            Id = @"TXA.11.14.1",
                            Type = @"SubComponent",
                            Position = @"TXA.11.14.1",
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
                            Id = @"TXA.11.14.2",
                            Type = @"SubComponent",
                            Position = @"TXA.11.14.2",
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
                            Id = @"TXA.11.14.3",
                            Type = @"SubComponent",
                            Position = @"TXA.11.14.3",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.12",
                            Type = @"Field",
                            Position = @"TXA.12",
                            Name = @"Unique Document Number",
                            Length = 30,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a unique document identification number assigned by the sending system. This document number is used to assist the receiving system in matching future updates to the document, as well as to identify the document in a query.  When the vendor does not provide a unique document ID number, some type of document identifier should be entered here, or the Unique Document File name should be utilized.  See Chapter 2,  Section 2.8.49, “XTN - extended telecommunication number.”   Where the system does not customarily have a document filler number, this number could serve as that value, as well",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.12.1",
                            Type = @"Component",
                            Position = @"TXA.12.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.12.2",
                            Type = @"Component",
                            Position = @"TXA.12.2",
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
                            Id = @"TXA.12.3",
                            Type = @"Component",
                            Position = @"TXA.12.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.12.4",
                            Type = @"Component",
                            Position = @"TXA.12.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.13",
                            Type = @"Field",
                            Position = @"TXA.13",
                            Name = @"Parent Document Number",
                            Length = 30,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a document number that identifies the parent document to which this document belongs.  The parent document number can be used to assist the receiving system in matching future updates to this document.  This is a conditional field that is always required on T05 (document addendum notification), T06 (document addendum notification and content), T09 (document replacement notification), and T10 (document replacement notification and content) events",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.13.1",
                            Type = @"Component",
                            Position = @"TXA.13.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.13.2",
                            Type = @"Component",
                            Position = @"TXA.13.2",
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
                            Id = @"TXA.13.3",
                            Type = @"Component",
                            Position = @"TXA.13.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.13.4",
                            Type = @"Component",
                            Position = @"TXA.13.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.14",
                            Type = @"Field",
                            Position = @"TXA.14",
                            Name = @"Placer Order Number",
                            Length = 22,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the placer application’s order number

This is a composite field.  The first component is a string of characters that identifies an individual order (e.g., OBR).  It is assigned by the placer (ordering application).  It identifies an order uniquely among all orders from a particular ordering application.  The second through fourth components contain the (filler) assigning authority of the placing application.  The (filler) assigning authority is a string of characters that will be uniquely associated with an application.  A given institution or group of intercommunicating institutions should establish a unique list of applications that may be potential placers and fillers and assign unique entity identifiers.  The components are separated by component delimiters. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.14.1",
                            Type = @"Component",
                            Position = @"TXA.14.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.14.2",
                            Type = @"Component",
                            Position = @"TXA.14.2",
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
                            Id = @"TXA.14.3",
                            Type = @"Component",
                            Position = @"TXA.14.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.14.4",
                            Type = @"Component",
                            Position = @"TXA.14.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.15",
                            Type = @"Field",
                            Position = @"TXA.15",
                            Name = @"Filler Order Number",
                            Length = 22,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the order number associated with the filling application.  Where a transcription service or similar organization creates the document and uses an internally unique identifier, that number should be inserted in this field.  Its first component is a string of characters that identifies an order detail segment (e.g., OBR).  This string must uniquely identify the order (as specified in the order detail segment) from other orders in a particular filling application (e.g., transcription service).  This uniqueness must persist over time.  Where a number is reused over time, a date can be affixed to the non-unique number to make it unique.

The second through fourth components contains the (filler) assigning authority.  The (filler) assigning authority is a string of characters that uniquely defines the application from other applications on the network.  The second through fourth components of the filler order number always identify the actual filler of an order. 

For further details, please see the definitions provided in Chapter 4. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.15.1",
                            Type = @"Component",
                            Position = @"TXA.15.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.15.2",
                            Type = @"Component",
                            Position = @"TXA.15.2",
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
                            Id = @"TXA.15.3",
                            Type = @"Component",
                            Position = @"TXA.15.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.15.4",
                            Type = @"Component",
                            Position = @"TXA.15.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.16",
                            Type = @"Field",
                            Position = @"TXA.16",
                            Name = @"Unique Document File Name",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a unique name assigned to a document by the sending system.  The file name is used to assist the receiving system in matching future updates to the document",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.17",
                            Type = @"Field",
                            Position = @"TXA.17",
                            Name = @"Document Completion Status",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0271",
                            TableName = @"Document completion status",
                            Description = @"This field identifies the current completion state of the document.  This is a required, tabledriven field.  Refer to HL7 table 0271 - Document completion status for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.18",
                            Type = @"Field",
                            Position = @"TXA.18",
                            Name = @"Document Confidentiality Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0272",
                            TableName = @"Document confidentiality status",
                            Description = @"This is an optional field which identifies the degree to which special confidentiality protection should be applied to this information.  The assignment of data elements to these categories is left to the discretion of the healthcare organization.  Refer to HL7 table 0272 - Document confidentiality status for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.19",
                            Type = @"Field",
                            Position = @"TXA.19",
                            Name = @"Document Availability Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0273",
                            TableName = @"Document availability status",
                            Description = @"This is an optional field which identifies a document’s availability for use in patient care.  If an organization’s business rules allow a document to be used for patient care before it is authenticated,  the value of this field should be set to “AV.”  If a document has been made available for patient care, it cannot be changed or deleted.  If an erroneous document has been made available at any point in time and a replacement is not appropriate, then it may be marked as “Canceled” and removed, as in the case of a document being assigned to the wrong patient.  Additional information must be provided via an addendum, which is separately authenticated and date/time stamped.  If the content of a document whose status is “Available” must be revised, this is done by issuing a replacement, which is separately authenticated and date/time stamped.  Refer to HL7 table 0273 - Document availability status for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.20",
                            Type = @"Field",
                            Position = @"TXA.20",
                            Name = @"Document Storage Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0275",
                            TableName = @"Document storage status",
                            Description = @"This optional field identifies the storage status of the document.  Refer to HL7 table 0275 - Document storage status for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.21",
                            Type = @"Field",
                            Position = @"TXA.21",
                            Name = @"Document Change Reason",
                            Length = 30,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This free text field (limited to 30 characters) contains the reason for document status change",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.22",
                            Type = @"Field",
                            Position = @"TXA.22",
                            Name = @"Authentication Person, Time Stamp",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"PPN",
                            DataTypeName = @"Performing Person Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a conditional field.  When the status of TXA-17-document completion status is equal to AU (authenticated) or LA (legally authenticated), all components are required.  This field contains a set of components describing by whom and when authentication was performed.  Whenever any one of the ID number - Name type code component s is valued, the when authenticated component, which is time stamp, must be valued as non-null.  If the time component of a set is valued as non-null, the person component becomes required. These subcomponents are normally delimited by an ampersand (&).  See Chapter 2.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.22.1",
                            Type = @"Component",
                            Position = @"TXA.22.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.22.2",
                            Type = @"Component",
                            Position = @"TXA.22.2",
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
                            Id = @"TXA.22.3",
                            Type = @"Component",
                            Position = @"TXA.22.3",
                            Name = @"Given Name",
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
                            Id = @"TXA.22.4",
                            Type = @"Component",
                            Position = @"TXA.22.4",
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
                            Id = @"TXA.22.5",
                            Type = @"Component",
                            Position = @"TXA.22.5",
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
                            Id = @"TXA.22.6",
                            Type = @"Component",
                            Position = @"TXA.22.6",
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
                            Id = @"TXA.22.7",
                            Type = @"Component",
                            Position = @"TXA.22.7",
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
                            Id = @"TXA.22.8",
                            Type = @"Component",
                            Position = @"TXA.22.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.22.9",
                            Type = @"Component",
                            Position = @"TXA.22.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"In this version, an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”)",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.22.9.1",
                            Type = @"SubComponent",
                            Position = @"TXA.22.9.1",
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
                            Id = @"TXA.22.9.2",
                            Type = @"SubComponent",
                            Position = @"TXA.22.9.2",
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
                            Id = @"TXA.22.9.3",
                            Type = @"SubComponent",
                            Position = @"TXA.22.9.3",
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
                            Id = @"TXA.22.10",
                            Type = @"Component",
                            Position = @"TXA.22.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.22.11",
                            Type = @"Component",
                            Position = @"TXA.22.11",
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
                            Id = @"TXA.22.12",
                            Type = @"Component",
                            Position = @"TXA.22.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.22.13",
                            Type = @"Component",
                            Position = @"TXA.22.13",
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
                            Id = @"TXA.22.14",
                            Type = @"Component",
                            Position = @"TXA.22.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.22.14.1",
                            Type = @"SubComponent",
                            Position = @"TXA.22.14.1",
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
                            Id = @"TXA.22.14.2",
                            Type = @"SubComponent",
                            Position = @"TXA.22.14.2",
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
                            Id = @"TXA.22.14.3",
                            Type = @"SubComponent",
                            Position = @"TXA.22.14.3",
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
                            Id = @"TXA.22.15",
                            Type = @"Component",
                            Position = @"TXA.22.15",
                            Name = @"Date/Time Action Performed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This component describes when the activity was performed

Note: If this field is not null, both the performing person and the time stamp must be valued.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.22.15.1",
                            Type = @"SubComponent",
                            Position = @"TXA.22.15.1",
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
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TXA.23",
                            Type = @"Field",
                            Position = @"TXA.23",
                            Name = @"Distributed Copies",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the persons who received a copy of this document",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TXA.23.1",
                            Type = @"Component",
                            Position = @"TXA.23.1",
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
                            Id = @"TXA.23.2",
                            Type = @"Component",
                            Position = @"TXA.23.2",
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
                            Id = @"TXA.23.3",
                            Type = @"Component",
                            Position = @"TXA.23.3",
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
                            Id = @"TXA.23.4",
                            Type = @"Component",
                            Position = @"TXA.23.4",
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
                            Id = @"TXA.23.5",
                            Type = @"Component",
                            Position = @"TXA.23.5",
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
                            Id = @"TXA.23.6",
                            Type = @"Component",
                            Position = @"TXA.23.6",
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
                            Id = @"TXA.23.7",
                            Type = @"Component",
                            Position = @"TXA.23.7",
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
                            Id = @"TXA.23.8",
                            Type = @"Component",
                            Position = @"TXA.23.8",
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
                            Id = @"TXA.23.9",
                            Type = @"Component",
                            Position = @"TXA.23.9",
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
                            Id = @"TXA.23.9.1",
                            Type = @"SubComponent",
                            Position = @"TXA.23.9.1",
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
                            Id = @"TXA.23.9.2",
                            Type = @"SubComponent",
                            Position = @"TXA.23.9.2",
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
                            Id = @"TXA.23.9.3",
                            Type = @"SubComponent",
                            Position = @"TXA.23.9.3",
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
                            Id = @"TXA.23.10",
                            Type = @"Component",
                            Position = @"TXA.23.10",
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
                            Id = @"TXA.23.11",
                            Type = @"Component",
                            Position = @"TXA.23.11",
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
                            Id = @"TXA.23.12",
                            Type = @"Component",
                            Position = @"TXA.23.12",
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
                            Id = @"TXA.23.13",
                            Type = @"Component",
                            Position = @"TXA.23.13",
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
                            Id = @"TXA.23.14",
                            Type = @"Component",
                            Position = @"TXA.23.14",
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
                            Id = @"TXA.23.14.1",
                            Type = @"SubComponent",
                            Position = @"TXA.23.14.1",
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
                            Id = @"TXA.23.14.2",
                            Type = @"SubComponent",
                            Position = @"TXA.23.14.2",
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
                            Id = @"TXA.23.14.3",
                            Type = @"SubComponent",
                            Position = @"TXA.23.14.3",
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
                        },}
                        },
                        };
            }
        }

        public HL7V23SegmentTXA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field setIDTXA;

public HL7V23Field SetIDTXA
{
    get
    {
        if (setIDTXA != null)
        {
            return setIDTXA;
        }

        setIDTXA = new HL7V23Field
        {
            field = message[@"TXA"][1],
            Id = @"TXA.1",
            Type = @"Field",
            Position = @"TXA.1",
            Name = @"Set ID- TXA",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction",
            Sample = @"",
        };

        // check for repetitions
        if (setIDTXA.field.FieldRepetitions != null && setIDTXA.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDTXA.Id));
            setIDTXA.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(setIDTXA, fieldData);
        }

        return setIDTXA;
    } 
}

internal HL7V23Field documentType;

public HL7V23Field DocumentType
{
    get
    {
        if (documentType != null)
        {
            return documentType;
        }

        documentType = new HL7V23Field
        {
            field = message[@"TXA"][2],
            Id = @"TXA.2",
            Type = @"Field",
            Position = @"TXA.2",
            Name = @"Document Type",
            Length = 30,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0270",
            TableName = @"Document type",
            Description = @"This field identifies the type of document (as defined in the transcription system).  Refer to userdefined table 0270 - Document type for suggested values.  The organization is free to add more entries",
            Sample = @"",
        };

        // check for repetitions
        if (documentType.field.FieldRepetitions != null && documentType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(documentType.Id));
            documentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(documentType, fieldData);
        }

        return documentType;
    } 
}

internal HL7V23Field documentContentPresentation;

public HL7V23Field DocumentContentPresentation
{
    get
    {
        if (documentContentPresentation != null)
        {
            return documentContentPresentation;
        }

        documentContentPresentation = new HL7V23Field
        {
            field = message[@"TXA"][3],
            Id = @"TXA.3",
            Type = @"Field",
            Position = @"TXA.3",
            Name = @"Document Content Presentation",
            Length = 2,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0191",
            TableName = @"Type of referenced data",
            Description = @"This is a conditional field which is required whenever the message contains content as presented in one or more OBX segments.  This field identifies the method by which this document was obtained or originated.  Refer to HL7 table 0191 - Main type of referenced data for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (documentContentPresentation.field.FieldRepetitions != null && documentContentPresentation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(documentContentPresentation.Id));
            documentContentPresentation.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(documentContentPresentation, fieldData);
        }

        return documentContentPresentation;
    } 
}

internal HL7V23Field activityDateTime;

public HL7V23Field ActivityDateTime
{
    get
    {
        if (activityDateTime != null)
        {
            return activityDateTime;
        }

        activityDateTime = new HL7V23Field
        {
            field = message[@"TXA"][4],
            Id = @"TXA.4",
            Type = @"Field",
            Position = @"TXA.4",
            Name = @"Activity Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time identified in the document as the date a procedure or activity was performed.  This date can identify date of surgery, non-invasive procedure, consultation, examination, etc",
            Sample = @"",
        };

        // check for repetitions
        if (activityDateTime.field.FieldRepetitions != null && activityDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(activityDateTime.Id));
            activityDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(activityDateTime, fieldData);
        }

        return activityDateTime;
    } 
}

internal HL7V23Field primaryActivityProviderCodeName;

public HL7V23Field PrimaryActivityProviderCodeName
{
    get
    {
        if (primaryActivityProviderCodeName != null)
        {
            return primaryActivityProviderCodeName;
        }

        primaryActivityProviderCodeName = new HL7V23Field
        {
            field = message[@"TXA"][5],
            Id = @"TXA.5",
            Type = @"Field",
            Position = @"TXA.5",
            Name = @"Primary Activity Provider Code/Name",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the person identified in the document as being responsible for performing the procedure or activity.  This field includes the code and name (if available) of the caregiver. This field is conditional based upon the presence of a value in TXA-4-activity date",
            Sample = @"",
        };

        // check for repetitions
        if (primaryActivityProviderCodeName.field.FieldRepetitions != null && primaryActivityProviderCodeName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryActivityProviderCodeName.Id));
            primaryActivityProviderCodeName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(primaryActivityProviderCodeName, fieldData);
        }

        return primaryActivityProviderCodeName;
    } 
}

internal HL7V23Field originationDateTime;

public HL7V23Field OriginationDateTime
{
    get
    {
        if (originationDateTime != null)
        {
            return originationDateTime;
        }

        originationDateTime = new HL7V23Field
        {
            field = message[@"TXA"][6],
            Id = @"TXA.6",
            Type = @"Field",
            Position = @"TXA.6",
            Name = @"Origination Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time the document was created (i.e., dictated, recorded, etc.). ",
            Sample = @"",
        };

        // check for repetitions
        if (originationDateTime.field.FieldRepetitions != null && originationDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(originationDateTime.Id));
            originationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(originationDateTime, fieldData);
        }

        return originationDateTime;
    } 
}

internal HL7V23Field transcriptionDateTime;

public HL7V23Field TranscriptionDateTime
{
    get
    {
        if (transcriptionDateTime != null)
        {
            return transcriptionDateTime;
        }

        transcriptionDateTime = new HL7V23Field
        {
            field = message[@"TXA"][7],
            Id = @"TXA.7",
            Type = @"Field",
            Position = @"TXA.7",
            Name = @"Transcription Date/Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time the input was actually transcribed.  This field is conditional based upon the presence of a value in TXA-17-document status of anything except “dictated.” ",
            Sample = @"",
        };

        // check for repetitions
        if (transcriptionDateTime.field.FieldRepetitions != null && transcriptionDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transcriptionDateTime.Id));
            transcriptionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(transcriptionDateTime, fieldData);
        }

        return transcriptionDateTime;
    } 
}

internal HL7V23Field editDateTime;

public HL7V23Field EditDateTime
{
    get
    {
        if (editDateTime != null)
        {
            return editDateTime;
        }

        editDateTime = new HL7V23Field
        {
            field = message[@"TXA"][8],
            Id = @"TXA.8",
            Type = @"Field",
            Position = @"TXA.8",
            Name = @"Edit Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time the document was edited",
            Sample = @"",
        };

        // check for repetitions
        if (editDateTime.field.FieldRepetitions != null && editDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(editDateTime.Id));
            editDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(editDateTime, fieldData);
        }

        return editDateTime;
    } 
}

internal HL7V23Field originatorCodeName;

public HL7V23Field OriginatorCodeName
{
    get
    {
        if (originatorCodeName != null)
        {
            return originatorCodeName;
        }

        originatorCodeName = new HL7V23Field
        {
            field = message[@"TXA"][9],
            Id = @"TXA.9",
            Type = @"Field",
            Position = @"TXA.9",
            Name = @"Originator Code/Name",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the person who originated (i.e., dictated) the document.  The document originator may differ from the person responsible for authenticating the document",
            Sample = @"",
        };

        // check for repetitions
        if (originatorCodeName.field.FieldRepetitions != null && originatorCodeName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(originatorCodeName.Id));
            originatorCodeName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(originatorCodeName, fieldData);
        }

        return originatorCodeName;
    } 
}

internal HL7V23Field assignedDocumentAuthenticator;

public HL7V23Field AssignedDocumentAuthenticator
{
    get
    {
        if (assignedDocumentAuthenticator != null)
        {
            return assignedDocumentAuthenticator;
        }

        assignedDocumentAuthenticator = new HL7V23Field
        {
            field = message[@"TXA"][10],
            Id = @"TXA.10",
            Type = @"Field",
            Position = @"TXA.10",
            Name = @"Assigned Document Authenticator",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the person(s) responsible for authenticating the document, who may differ from the originator.  Multiple persons may be responsible for authentication, especially in teaching facilities.  This field is allowed to repeat an undefined number of times",
            Sample = @"",
        };

        // check for repetitions
        if (assignedDocumentAuthenticator.field.FieldRepetitions != null && assignedDocumentAuthenticator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(assignedDocumentAuthenticator.Id));
            assignedDocumentAuthenticator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(assignedDocumentAuthenticator, fieldData);
        }

        return assignedDocumentAuthenticator;
    } 
}

internal HL7V23Field transcriptionistCodeName;

public HL7V23Field TranscriptionistCodeName
{
    get
    {
        if (transcriptionistCodeName != null)
        {
            return transcriptionistCodeName;
        }

        transcriptionistCodeName = new HL7V23Field
        {
            field = message[@"TXA"][11],
            Id = @"TXA.11",
            Type = @"Field",
            Position = @"TXA.11",
            Name = @"Transcriptionist Code/Name",
            Length = 48,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the person transcribing the document. This is a conditional value; it is required on all transcribed documents",
            Sample = @"",
        };

        // check for repetitions
        if (transcriptionistCodeName.field.FieldRepetitions != null && transcriptionistCodeName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transcriptionistCodeName.Id));
            transcriptionistCodeName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(transcriptionistCodeName, fieldData);
        }

        return transcriptionistCodeName;
    } 
}

internal HL7V23Field uniqueDocumentNumber;

public HL7V23Field UniqueDocumentNumber
{
    get
    {
        if (uniqueDocumentNumber != null)
        {
            return uniqueDocumentNumber;
        }

        uniqueDocumentNumber = new HL7V23Field
        {
            field = message[@"TXA"][12],
            Id = @"TXA.12",
            Type = @"Field",
            Position = @"TXA.12",
            Name = @"Unique Document Number",
            Length = 30,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains a unique document identification number assigned by the sending system. This document number is used to assist the receiving system in matching future updates to the document, as well as to identify the document in a query.  When the vendor does not provide a unique document ID number, some type of document identifier should be entered here, or the Unique Document File name should be utilized.  See Chapter 2,  Section 2.8.49, “XTN - extended telecommunication number.”   Where the system does not customarily have a document filler number, this number could serve as that value, as well",
            Sample = @"",
        };

        // check for repetitions
        if (uniqueDocumentNumber.field.FieldRepetitions != null && uniqueDocumentNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uniqueDocumentNumber.Id));
            uniqueDocumentNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(uniqueDocumentNumber, fieldData);
        }

        return uniqueDocumentNumber;
    } 
}

internal HL7V23Field parentDocumentNumber;

public HL7V23Field ParentDocumentNumber
{
    get
    {
        if (parentDocumentNumber != null)
        {
            return parentDocumentNumber;
        }

        parentDocumentNumber = new HL7V23Field
        {
            field = message[@"TXA"][13],
            Id = @"TXA.13",
            Type = @"Field",
            Position = @"TXA.13",
            Name = @"Parent Document Number",
            Length = 30,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains a document number that identifies the parent document to which this document belongs.  The parent document number can be used to assist the receiving system in matching future updates to this document.  This is a conditional field that is always required on T05 (document addendum notification), T06 (document addendum notification and content), T09 (document replacement notification), and T10 (document replacement notification and content) events",
            Sample = @"",
        };

        // check for repetitions
        if (parentDocumentNumber.field.FieldRepetitions != null && parentDocumentNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(parentDocumentNumber.Id));
            parentDocumentNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(parentDocumentNumber, fieldData);
        }

        return parentDocumentNumber;
    } 
}

internal HL7V23Field placerOrderNumber;

public HL7V23Field PlacerOrderNumber
{
    get
    {
        if (placerOrderNumber != null)
        {
            return placerOrderNumber;
        }

        placerOrderNumber = new HL7V23Field
        {
            field = message[@"TXA"][14],
            Id = @"TXA.14",
            Type = @"Field",
            Position = @"TXA.14",
            Name = @"Placer Order Number",
            Length = 22,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field is the placer application’s order number

This is a composite field.  The first component is a string of characters that identifies an individual order (e.g., OBR).  It is assigned by the placer (ordering application).  It identifies an order uniquely among all orders from a particular ordering application.  The second through fourth components contain the (filler) assigning authority of the placing application.  The (filler) assigning authority is a string of characters that will be uniquely associated with an application.  A given institution or group of intercommunicating institutions should establish a unique list of applications that may be potential placers and fillers and assign unique entity identifiers.  The components are separated by component delimiters. ",
            Sample = @"",
        };

        // check for repetitions
        if (placerOrderNumber.field.FieldRepetitions != null && placerOrderNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(placerOrderNumber.Id));
            placerOrderNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(placerOrderNumber, fieldData);
        }

        return placerOrderNumber;
    } 
}

internal HL7V23Field fillerOrderNumber;

public HL7V23Field FillerOrderNumber
{
    get
    {
        if (fillerOrderNumber != null)
        {
            return fillerOrderNumber;
        }

        fillerOrderNumber = new HL7V23Field
        {
            field = message[@"TXA"][15],
            Id = @"TXA.15",
            Type = @"Field",
            Position = @"TXA.15",
            Name = @"Filler Order Number",
            Length = 22,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field is the order number associated with the filling application.  Where a transcription service or similar organization creates the document and uses an internally unique identifier, that number should be inserted in this field.  Its first component is a string of characters that identifies an order detail segment (e.g., OBR).  This string must uniquely identify the order (as specified in the order detail segment) from other orders in a particular filling application (e.g., transcription service).  This uniqueness must persist over time.  Where a number is reused over time, a date can be affixed to the non-unique number to make it unique.

The second through fourth components contains the (filler) assigning authority.  The (filler) assigning authority is a string of characters that uniquely defines the application from other applications on the network.  The second through fourth components of the filler order number always identify the actual filler of an order. 

For further details, please see the definitions provided in Chapter 4. ",
            Sample = @"",
        };

        // check for repetitions
        if (fillerOrderNumber.field.FieldRepetitions != null && fillerOrderNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fillerOrderNumber.Id));
            fillerOrderNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(fillerOrderNumber, fieldData);
        }

        return fillerOrderNumber;
    } 
}

internal HL7V23Field uniqueDocumentFileName;

public HL7V23Field UniqueDocumentFileName
{
    get
    {
        if (uniqueDocumentFileName != null)
        {
            return uniqueDocumentFileName;
        }

        uniqueDocumentFileName = new HL7V23Field
        {
            field = message[@"TXA"][16],
            Id = @"TXA.16",
            Type = @"Field",
            Position = @"TXA.16",
            Name = @"Unique Document File Name",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a unique name assigned to a document by the sending system.  The file name is used to assist the receiving system in matching future updates to the document",
            Sample = @"",
        };

        // check for repetitions
        if (uniqueDocumentFileName.field.FieldRepetitions != null && uniqueDocumentFileName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uniqueDocumentFileName.Id));
            uniqueDocumentFileName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(uniqueDocumentFileName, fieldData);
        }

        return uniqueDocumentFileName;
    } 
}

internal HL7V23Field documentCompletionStatus;

public HL7V23Field DocumentCompletionStatus
{
    get
    {
        if (documentCompletionStatus != null)
        {
            return documentCompletionStatus;
        }

        documentCompletionStatus = new HL7V23Field
        {
            field = message[@"TXA"][17],
            Id = @"TXA.17",
            Type = @"Field",
            Position = @"TXA.17",
            Name = @"Document Completion Status",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0271",
            TableName = @"Document completion status",
            Description = @"This field identifies the current completion state of the document.  This is a required, tabledriven field.  Refer to HL7 table 0271 - Document completion status for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (documentCompletionStatus.field.FieldRepetitions != null && documentCompletionStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(documentCompletionStatus.Id));
            documentCompletionStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(documentCompletionStatus, fieldData);
        }

        return documentCompletionStatus;
    } 
}

internal HL7V23Field documentConfidentialityStatus;

public HL7V23Field DocumentConfidentialityStatus
{
    get
    {
        if (documentConfidentialityStatus != null)
        {
            return documentConfidentialityStatus;
        }

        documentConfidentialityStatus = new HL7V23Field
        {
            field = message[@"TXA"][18],
            Id = @"TXA.18",
            Type = @"Field",
            Position = @"TXA.18",
            Name = @"Document Confidentiality Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0272",
            TableName = @"Document confidentiality status",
            Description = @"This is an optional field which identifies the degree to which special confidentiality protection should be applied to this information.  The assignment of data elements to these categories is left to the discretion of the healthcare organization.  Refer to HL7 table 0272 - Document confidentiality status for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (documentConfidentialityStatus.field.FieldRepetitions != null && documentConfidentialityStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(documentConfidentialityStatus.Id));
            documentConfidentialityStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(documentConfidentialityStatus, fieldData);
        }

        return documentConfidentialityStatus;
    } 
}

internal HL7V23Field documentAvailabilityStatus;

public HL7V23Field DocumentAvailabilityStatus
{
    get
    {
        if (documentAvailabilityStatus != null)
        {
            return documentAvailabilityStatus;
        }

        documentAvailabilityStatus = new HL7V23Field
        {
            field = message[@"TXA"][19],
            Id = @"TXA.19",
            Type = @"Field",
            Position = @"TXA.19",
            Name = @"Document Availability Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0273",
            TableName = @"Document availability status",
            Description = @"This is an optional field which identifies a document’s availability for use in patient care.  If an organization’s business rules allow a document to be used for patient care before it is authenticated,  the value of this field should be set to “AV.”  If a document has been made available for patient care, it cannot be changed or deleted.  If an erroneous document has been made available at any point in time and a replacement is not appropriate, then it may be marked as “Canceled” and removed, as in the case of a document being assigned to the wrong patient.  Additional information must be provided via an addendum, which is separately authenticated and date/time stamped.  If the content of a document whose status is “Available” must be revised, this is done by issuing a replacement, which is separately authenticated and date/time stamped.  Refer to HL7 table 0273 - Document availability status for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (documentAvailabilityStatus.field.FieldRepetitions != null && documentAvailabilityStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(documentAvailabilityStatus.Id));
            documentAvailabilityStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(documentAvailabilityStatus, fieldData);
        }

        return documentAvailabilityStatus;
    } 
}

internal HL7V23Field documentStorageStatus;

public HL7V23Field DocumentStorageStatus
{
    get
    {
        if (documentStorageStatus != null)
        {
            return documentStorageStatus;
        }

        documentStorageStatus = new HL7V23Field
        {
            field = message[@"TXA"][20],
            Id = @"TXA.20",
            Type = @"Field",
            Position = @"TXA.20",
            Name = @"Document Storage Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0275",
            TableName = @"Document storage status",
            Description = @"This optional field identifies the storage status of the document.  Refer to HL7 table 0275 - Document storage status for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (documentStorageStatus.field.FieldRepetitions != null && documentStorageStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(documentStorageStatus.Id));
            documentStorageStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(documentStorageStatus, fieldData);
        }

        return documentStorageStatus;
    } 
}

internal HL7V23Field documentChangeReason;

public HL7V23Field DocumentChangeReason
{
    get
    {
        if (documentChangeReason != null)
        {
            return documentChangeReason;
        }

        documentChangeReason = new HL7V23Field
        {
            field = message[@"TXA"][21],
            Id = @"TXA.21",
            Type = @"Field",
            Position = @"TXA.21",
            Name = @"Document Change Reason",
            Length = 30,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This free text field (limited to 30 characters) contains the reason for document status change",
            Sample = @"",
        };

        // check for repetitions
        if (documentChangeReason.field.FieldRepetitions != null && documentChangeReason.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(documentChangeReason.Id));
            documentChangeReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(documentChangeReason, fieldData);
        }

        return documentChangeReason;
    } 
}

internal HL7V23Field authenticationPersonTimeStamp;

public HL7V23Field AuthenticationPersonTimeStamp
{
    get
    {
        if (authenticationPersonTimeStamp != null)
        {
            return authenticationPersonTimeStamp;
        }

        authenticationPersonTimeStamp = new HL7V23Field
        {
            field = message[@"TXA"][22],
            Id = @"TXA.22",
            Type = @"Field",
            Position = @"TXA.22",
            Name = @"Authentication Person, Time Stamp",
            Length = 60,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"PPN",
            DataTypeName = @"Performing Person Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This is a conditional field.  When the status of TXA-17-document completion status is equal to AU (authenticated) or LA (legally authenticated), all components are required.  This field contains a set of components describing by whom and when authentication was performed.  Whenever any one of the ID number - Name type code component s is valued, the when authenticated component, which is time stamp, must be valued as non-null.  If the time component of a set is valued as non-null, the person component becomes required. These subcomponents are normally delimited by an ampersand (&).  See Chapter 2.",
            Sample = @"",
        };

        // check for repetitions
        if (authenticationPersonTimeStamp.field.FieldRepetitions != null && authenticationPersonTimeStamp.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(authenticationPersonTimeStamp.Id));
            authenticationPersonTimeStamp.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(authenticationPersonTimeStamp, fieldData);
        }

        return authenticationPersonTimeStamp;
    } 
}

internal HL7V23Field distributedCopies;

public HL7V23Field DistributedCopies
{
    get
    {
        if (distributedCopies != null)
        {
            return distributedCopies;
        }

        distributedCopies = new HL7V23Field
        {
            field = message[@"TXA"][23],
            Id = @"TXA.23",
            Type = @"Field",
            Position = @"TXA.23",
            Name = @"Distributed Copies",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the persons who received a copy of this document",
            Sample = @"",
        };

        // check for repetitions
        if (distributedCopies.field.FieldRepetitions != null && distributedCopies.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(distributedCopies.Id));
            distributedCopies.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(distributedCopies, fieldData);
        }

        return distributedCopies;
    } 
}
    }
}
