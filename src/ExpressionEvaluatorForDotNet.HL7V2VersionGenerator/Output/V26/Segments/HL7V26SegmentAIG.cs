using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentAIG
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"AIG"; } }

        public string SegmentId { get { return @"AIG"; } }
        
        public string LongName { get { return @"Appointment Information - General Resource"; } }
        
        public string Description { get { return @"The AIG segment contains information about various kinds of resources (other than those with specifically defined segments in this chapter) that can be scheduled. Resources included in a transaction using this segment are assumed to be controlled by a schedule on a schedule filler application. Resources not controlled by a schedule are not identified on a schedule request using this segment. Resources described by this segment are general kinds of resources, such as equipment, that are identified with a simple identification code."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",
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
                            Id = @"AIG.1",
                            Type = @"Field",
                            Position = @"AIG.1",
                            Name = @"Set ID - AIG",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a number that uniquely identifies the information represented by this segment in this transaction for the purposes of addition, change or deletion.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.2",
                            Type = @"Field",
                            Position = @"AIG.2",
                            Name = @"Segment Action Code",
                            Length = 3,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0206",
                            TableName = @"Segment action code",
                            Description = @"This field contains the action to be taken when updating or modifying information in this segment from previously sent interface transactions. Refer to HL7 Table 0206 - Segment action code in Chapter 2, section 2.10.4.2, ""Action code/unique identifier mode update definition,"" for valid values.

This field is conditionally required.  It is required for all updating or modifying trigger events.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.3",
                            Type = @"Field",
                            Position = @"AIG.3",
                            Name = @"Resource ID",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the ID number and name of the resource being requested or scheduled for an appointment. This field is used to identify a specific resource being requested, or a specific resource that has been scheduled for an appointment. If the specific resource is not known but the type of resource is, AIG-4-resource type is used to identify the type of resource required or scheduled.

This field is conditionally required for this segment.  In new schedule request messages, it is required if the request asks that a specific resource be scheduled.  For all other request messages, the specific resource should be identified if the information is available (either because a specific resource was initially requested, or because the filler application returned the ID of the specific resource that has been scheduled).

This field is required for all unsolicited transactions from the filler application.

This field is optional for all query transactions.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIG.3.1",
                            Type = @"Component",
                            Position = @"AIG.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.3.2",
                            Type = @"Component",
                            Position = @"AIG.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.3.3",
                            Type = @"Component",
                            Position = @"AIG.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.3.4",
                            Type = @"Component",
                            Position = @"AIG.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.3.5",
                            Type = @"Component",
                            Position = @"AIG.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.3.6",
                            Type = @"Component",
                            Position = @"AIG.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.3.7",
                            Type = @"Component",
                            Position = @"AIG.3.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.3.8",
                            Type = @"Component",
                            Position = @"AIG.3.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.3.9",
                            Type = @"Component",
                            Position = @"AIG.3.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.4",
                            Type = @"Field",
                            Position = @"AIG.4",
                            Name = @"Resource Type",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the role of the resource requested/scheduled for this appointment. For requests, if a specific resource is not identified in AIG-3-Resource ID, then this field identifies the type of resource that should be scheduled by the filler application. At a minimum, the type of the identifier component should be valued.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIG.4.1",
                            Type = @"Component",
                            Position = @"AIG.4.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.4.2",
                            Type = @"Component",
                            Position = @"AIG.4.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.4.3",
                            Type = @"Component",
                            Position = @"AIG.4.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.4.4",
                            Type = @"Component",
                            Position = @"AIG.4.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.4.5",
                            Type = @"Component",
                            Position = @"AIG.4.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.4.6",
                            Type = @"Component",
                            Position = @"AIG.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.4.7",
                            Type = @"Component",
                            Position = @"AIG.4.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.4.8",
                            Type = @"Component",
                            Position = @"AIG.4.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.4.9",
                            Type = @"Component",
                            Position = @"AIG.4.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.5",
                            Type = @"Field",
                            Position = @"AIG.5",
                            Name = @"Resource Group",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the requested resource as a member of the indicated group. If, in a Schedule Request Message (SRM), no specific resource is requested, but a resource type is requested, this field can be used to further qualify the type of resource being requested.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIG.5.1",
                            Type = @"Component",
                            Position = @"AIG.5.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.5.2",
                            Type = @"Component",
                            Position = @"AIG.5.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.5.3",
                            Type = @"Component",
                            Position = @"AIG.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.5.4",
                            Type = @"Component",
                            Position = @"AIG.5.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.5.5",
                            Type = @"Component",
                            Position = @"AIG.5.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.5.6",
                            Type = @"Component",
                            Position = @"AIG.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.5.7",
                            Type = @"Component",
                            Position = @"AIG.5.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.5.8",
                            Type = @"Component",
                            Position = @"AIG.5.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.5.9",
                            Type = @"Component",
                            Position = @"AIG.5.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.6",
                            Type = @"Field",
                            Position = @"AIG.6",
                            Name = @"Resource Quantity",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the quantity of the specified resource or resource type identified in either or both of the preceding two fields. If it is not valued, this field defaults to a value of one (1).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.7",
                            Type = @"Field",
                            Position = @"AIG.7",
                            Name = @"Resource Quantity Units",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the units of the resource requested, whose quantity is given in the preceding field. This field should be valued according to the recommendations in Chapters 2 and 7. If this field is not valued, the unit of each (code ""ea"") will be assumed. Refer to Chapter 7, Figures 7-6 through 7-9, for a list of ISO+ and ANS+ unit codes.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIG.7.1",
                            Type = @"Component",
                            Position = @"AIG.7.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.7.2",
                            Type = @"Component",
                            Position = @"AIG.7.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.7.3",
                            Type = @"Component",
                            Position = @"AIG.7.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.7.4",
                            Type = @"Component",
                            Position = @"AIG.7.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.7.5",
                            Type = @"Component",
                            Position = @"AIG.7.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.7.6",
                            Type = @"Component",
                            Position = @"AIG.7.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.7.7",
                            Type = @"Component",
                            Position = @"AIG.7.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.7.8",
                            Type = @"Component",
                            Position = @"AIG.7.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.7.9",
                            Type = @"Component",
                            Position = @"AIG.7.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.8",
                            Type = @"Field",
                            Position = @"AIG.8",
                            Name = @"Start Date/Time",
                            Length = 24,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time this service needs for the appointment. This field allows the application to identify that the service is required for the appointment at a different time than the appointment's start date/time.

This field is conditionally required.  If a value for AIG-9-Start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment's start date/time and the resource's start date/time either replicate the appointment's start date/time into this field, or specify an offset of zero (0) in AIG-9-Start date/time offset and any valid time unit code in AIG-10-Start date/time offset units.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.9",
                            Type = @"Field",
                            Position = @"AIG.9",
                            Name = @"Start Date/Time Offset",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the offset that this resource needs for the appointment, expressed in units of time relative to the scheduled start date/time. This field indicates to the application that the resource is required for the appointment at a different time than the appointment's start date/time. The first component indicates the offset amount. An offset of zero (0), or an unvalued field, indicates that the resource is required at the start date/time of the appointment.

This field is conditionally required.  If a value for AIG-8-Start date/time is not provided, then a value is required for this field.  To specify that there is no difference between the appointment's start date/time and the resource's start date/time either replicate the appointment's start date/time into this field, or specify an offset of zero (0) in AIG-9-Start date/time offset and any valid time unit code in AIG10-Start date/time offset units.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.10",
                            Type = @"Field",
                            Position = @"AIG.10",
                            Name = @"Start Date/Time Offset Units",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a code describing the units of time used for expressing AIG-9-Start date/time offset . This field should be valued according to the recommendations made in Chapters 2 and 7. If this field is not valued, the ISO base unit of seconds (code ""s"") will be assumed. Refer to Chapter 7, Figures 7-6 through 7-9, for a list of ISO+ and ANS+ unit codes.

This field is conditionally required.  If a value for AIG-9-Start date/time offset is provided, then a value is required for this field.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIG.10.1",
                            Type = @"Component",
                            Position = @"AIG.10.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.10.2",
                            Type = @"Component",
                            Position = @"AIG.10.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.10.3",
                            Type = @"Component",
                            Position = @"AIG.10.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.10.4",
                            Type = @"Component",
                            Position = @"AIG.10.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.10.5",
                            Type = @"Component",
                            Position = @"AIG.10.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.10.6",
                            Type = @"Component",
                            Position = @"AIG.10.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.10.7",
                            Type = @"Component",
                            Position = @"AIG.10.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.10.8",
                            Type = @"Component",
                            Position = @"AIG.10.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.10.9",
                            Type = @"Component",
                            Position = @"AIG.10.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.11",
                            Type = @"Field",
                            Position = @"AIG.11",
                            Name = @"Duration",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the duration for which the resource is requested/scheduled for this appointment, if it is different than the overall duration of the requested/scheduled appointment. This field indicates to the application that a resource is required for a different amount of time than the appointment's overall duration. An unvalued duration indicates that the resource is required from its start date/time offset (specified in the previous two fields) until the end of the appointment. If no start date/time offset is specified, then the resource is required for the full duration of the appointment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.12",
                            Type = @"Field",
                            Position = @"AIG.12",
                            Name = @"Duration Units",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a code describing the units of time used for expressing the AIG-11-Duration field. This field should be valued according to the recommendations in Chapters 2 and 7. If this field is not valued, the ISO base unit of seconds (code ""s"") will be assumed. Refer to Chapter 7, Figures 7-6 through 7-9, for a list of ISO+ and ANS+ unit codes.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIG.12.1",
                            Type = @"Component",
                            Position = @"AIG.12.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.12.2",
                            Type = @"Component",
                            Position = @"AIG.12.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.12.3",
                            Type = @"Component",
                            Position = @"AIG.12.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.12.4",
                            Type = @"Component",
                            Position = @"AIG.12.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.12.5",
                            Type = @"Component",
                            Position = @"AIG.12.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.12.6",
                            Type = @"Component",
                            Position = @"AIG.12.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.12.7",
                            Type = @"Component",
                            Position = @"AIG.12.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.12.8",
                            Type = @"Component",
                            Position = @"AIG.12.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.12.9",
                            Type = @"Component",
                            Position = @"AIG.12.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.13",
                            Type = @"Field",
                            Position = @"AIG.13",
                            Name = @"Allow Substitution Code",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0279",
                            TableName = @"Allow Substitution Codes",
                            Description = @"This field contains a code indicating whether the identified resource can be substituted with an equivalent resource by the filler application. Refer to User-Defined Table 0279 - Allow Substitution Codes for suggested codes.

This field is conditionally required.  It is required for all request messages.  It is optional for all unsolicited transactions, and for all query messages.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.14",
                            Type = @"Field",
                            Position = @"AIG.14",
                            Name = @"Filler Status Code",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0278",
                            TableName = @"Filler status codes",
                            Description = @"This field contains a code that describes the requested/scheduled status of scheduling resource or activity, from the point of view of the filler application. Refer to User-Defined Table 0278 - Filler Status Codes for suggested codes.

This is a conditionally required field.  Because the information contained in this field is only appropriate in transactions originating from a filler application, it is required for those messages.  This includes all unsolicited transactions originating from a filler application, as well as all response messages originating from a filler application.  This field is optional for all transactions originating from placer, querying and auxiliary applications.  It is recommended that this field be left unvalued in transactions originating from applications other than the filler application.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIG.14.1",
                            Type = @"Component",
                            Position = @"AIG.14.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.14.2",
                            Type = @"Component",
                            Position = @"AIG.14.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.14.3",
                            Type = @"Component",
                            Position = @"AIG.14.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.14.4",
                            Type = @"Component",
                            Position = @"AIG.14.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.14.5",
                            Type = @"Component",
                            Position = @"AIG.14.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.14.6",
                            Type = @"Component",
                            Position = @"AIG.14.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.14.7",
                            Type = @"Component",
                            Position = @"AIG.14.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.14.8",
                            Type = @"Component",
                            Position = @"AIG.14.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIG.14.9",
                            Type = @"Component",
                            Position = @"AIG.14.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V26SegmentAIG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field setIDAIG;

public HL7V26Field SetIDAIG
{
    get
    {
        if (setIDAIG != null)
        {
            return setIDAIG;
        }

        setIDAIG = new HL7V26Field
        {
            field = message[@"AIG"][1],
            Id = @"AIG.1",
            Type = @"Field",
            Position = @"AIG.1",
            Name = @"Set ID - AIG",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number that uniquely identifies the information represented by this segment in this transaction for the purposes of addition, change or deletion.",
            Sample = @"",
        };

        

        

        

        return setIDAIG;
    } 
}
internal HL7V26Field segmentActionCode;

public HL7V26Field SegmentActionCode
{
    get
    {
        if (segmentActionCode != null)
        {
            return segmentActionCode;
        }

        segmentActionCode = new HL7V26Field
        {
            field = message[@"AIG"][2],
            Id = @"AIG.2",
            Type = @"Field",
            Position = @"AIG.2",
            Name = @"Segment Action Code",
            Length = 3,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0206",
            TableName = @"Segment action code",
            Description = @"This field contains the action to be taken when updating or modifying information in this segment from previously sent interface transactions. Refer to HL7 Table 0206 - Segment action code in Chapter 2, section 2.10.4.2, ""Action code/unique identifier mode update definition,"" for valid values.

This field is conditionally required.  It is required for all updating or modifying trigger events.",
            Sample = @"",
        };

        

        

        

        return segmentActionCode;
    } 
}
internal HL7V26Field resourceID;

public HL7V26Field ResourceID
{
    get
    {
        if (resourceID != null)
        {
            return resourceID;
        }

        resourceID = new HL7V26Field
        {
            field = message[@"AIG"][3],
            Id = @"AIG.3",
            Type = @"Field",
            Position = @"AIG.3",
            Name = @"Resource ID",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the ID number and name of the resource being requested or scheduled for an appointment. This field is used to identify a specific resource being requested, or a specific resource that has been scheduled for an appointment. If the specific resource is not known but the type of resource is, AIG-4-resource type is used to identify the type of resource required or scheduled.

This field is conditionally required for this segment.  In new schedule request messages, it is required if the request asks that a specific resource be scheduled.  For all other request messages, the specific resource should be identified if the information is available (either because a specific resource was initially requested, or because the filler application returned the ID of the specific resource that has been scheduled).

This field is required for all unsolicited transactions from the filler application.

This field is optional for all query transactions.",
            Sample = @"",
        };

        

        

        

        return resourceID;
    } 
}
internal HL7V26Field resourceType;

public HL7V26Field ResourceType
{
    get
    {
        if (resourceType != null)
        {
            return resourceType;
        }

        resourceType = new HL7V26Field
        {
            field = message[@"AIG"][4],
            Id = @"AIG.4",
            Type = @"Field",
            Position = @"AIG.4",
            Name = @"Resource Type",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the role of the resource requested/scheduled for this appointment. For requests, if a specific resource is not identified in AIG-3-Resource ID, then this field identifies the type of resource that should be scheduled by the filler application. At a minimum, the type of the identifier component should be valued.",
            Sample = @"",
        };

        

        

        

        return resourceType;
    } 
}
internal HL7V26Field resourceGroup;

public HL7V26Field ResourceGroup
{
    get
    {
        if (resourceGroup != null)
        {
            return resourceGroup;
        }

        resourceGroup = new HL7V26Field
        {
            field = message[@"AIG"][5],
            Id = @"AIG.5",
            Type = @"Field",
            Position = @"AIG.5",
            Name = @"Resource Group",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the requested resource as a member of the indicated group. If, in a Schedule Request Message (SRM), no specific resource is requested, but a resource type is requested, this field can be used to further qualify the type of resource being requested.",
            Sample = @"",
        };

        

        

        

        return resourceGroup;
    } 
}
internal HL7V26Field resourceQuantity;

public HL7V26Field ResourceQuantity
{
    get
    {
        if (resourceQuantity != null)
        {
            return resourceQuantity;
        }

        resourceQuantity = new HL7V26Field
        {
            field = message[@"AIG"][6],
            Id = @"AIG.6",
            Type = @"Field",
            Position = @"AIG.6",
            Name = @"Resource Quantity",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity of the specified resource or resource type identified in either or both of the preceding two fields. If it is not valued, this field defaults to a value of one (1).",
            Sample = @"",
        };

        

        

        

        return resourceQuantity;
    } 
}
internal HL7V26Field resourceQuantityUnits;

public HL7V26Field ResourceQuantityUnits
{
    get
    {
        if (resourceQuantityUnits != null)
        {
            return resourceQuantityUnits;
        }

        resourceQuantityUnits = new HL7V26Field
        {
            field = message[@"AIG"][7],
            Id = @"AIG.7",
            Type = @"Field",
            Position = @"AIG.7",
            Name = @"Resource Quantity Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the units of the resource requested, whose quantity is given in the preceding field. This field should be valued according to the recommendations in Chapters 2 and 7. If this field is not valued, the unit of each (code ""ea"") will be assumed. Refer to Chapter 7, Figures 7-6 through 7-9, for a list of ISO+ and ANS+ unit codes.",
            Sample = @"",
        };

        

        

        

        return resourceQuantityUnits;
    } 
}
internal HL7V26Field startDateTime;

public HL7V26Field StartDateTime
{
    get
    {
        if (startDateTime != null)
        {
            return startDateTime;
        }

        startDateTime = new HL7V26Field
        {
            field = message[@"AIG"][8],
            Id = @"AIG.8",
            Type = @"Field",
            Position = @"AIG.8",
            Name = @"Start Date/Time",
            Length = 24,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time this service needs for the appointment. This field allows the application to identify that the service is required for the appointment at a different time than the appointment's start date/time.

This field is conditionally required.  If a value for AIG-9-Start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment's start date/time and the resource's start date/time either replicate the appointment's start date/time into this field, or specify an offset of zero (0) in AIG-9-Start date/time offset and any valid time unit code in AIG-10-Start date/time offset units.",
            Sample = @"",
        };

        

        

        

        return startDateTime;
    } 
}
internal HL7V26Field startDateTimeOffset;

public HL7V26Field StartDateTimeOffset
{
    get
    {
        if (startDateTimeOffset != null)
        {
            return startDateTimeOffset;
        }

        startDateTimeOffset = new HL7V26Field
        {
            field = message[@"AIG"][9],
            Id = @"AIG.9",
            Type = @"Field",
            Position = @"AIG.9",
            Name = @"Start Date/Time Offset",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the offset that this resource needs for the appointment, expressed in units of time relative to the scheduled start date/time. This field indicates to the application that the resource is required for the appointment at a different time than the appointment's start date/time. The first component indicates the offset amount. An offset of zero (0), or an unvalued field, indicates that the resource is required at the start date/time of the appointment.

This field is conditionally required.  If a value for AIG-8-Start date/time is not provided, then a value is required for this field.  To specify that there is no difference between the appointment's start date/time and the resource's start date/time either replicate the appointment's start date/time into this field, or specify an offset of zero (0) in AIG-9-Start date/time offset and any valid time unit code in AIG10-Start date/time offset units.",
            Sample = @"",
        };

        

        

        

        return startDateTimeOffset;
    } 
}
internal HL7V26Field startDateTimeOffsetUnits;

public HL7V26Field StartDateTimeOffsetUnits
{
    get
    {
        if (startDateTimeOffsetUnits != null)
        {
            return startDateTimeOffsetUnits;
        }

        startDateTimeOffsetUnits = new HL7V26Field
        {
            field = message[@"AIG"][10],
            Id = @"AIG.10",
            Type = @"Field",
            Position = @"AIG.10",
            Name = @"Start Date/Time Offset Units",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code describing the units of time used for expressing AIG-9-Start date/time offset . This field should be valued according to the recommendations made in Chapters 2 and 7. If this field is not valued, the ISO base unit of seconds (code ""s"") will be assumed. Refer to Chapter 7, Figures 7-6 through 7-9, for a list of ISO+ and ANS+ unit codes.

This field is conditionally required.  If a value for AIG-9-Start date/time offset is provided, then a value is required for this field.",
            Sample = @"",
        };

        

        

        

        return startDateTimeOffsetUnits;
    } 
}
internal HL7V26Field duration;

public HL7V26Field Duration
{
    get
    {
        if (duration != null)
        {
            return duration;
        }

        duration = new HL7V26Field
        {
            field = message[@"AIG"][11],
            Id = @"AIG.11",
            Type = @"Field",
            Position = @"AIG.11",
            Name = @"Duration",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the duration for which the resource is requested/scheduled for this appointment, if it is different than the overall duration of the requested/scheduled appointment. This field indicates to the application that a resource is required for a different amount of time than the appointment's overall duration. An unvalued duration indicates that the resource is required from its start date/time offset (specified in the previous two fields) until the end of the appointment. If no start date/time offset is specified, then the resource is required for the full duration of the appointment.",
            Sample = @"",
        };

        

        

        

        return duration;
    } 
}
internal HL7V26Field durationUnits;

public HL7V26Field DurationUnits
{
    get
    {
        if (durationUnits != null)
        {
            return durationUnits;
        }

        durationUnits = new HL7V26Field
        {
            field = message[@"AIG"][12],
            Id = @"AIG.12",
            Type = @"Field",
            Position = @"AIG.12",
            Name = @"Duration Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code describing the units of time used for expressing the AIG-11-Duration field. This field should be valued according to the recommendations in Chapters 2 and 7. If this field is not valued, the ISO base unit of seconds (code ""s"") will be assumed. Refer to Chapter 7, Figures 7-6 through 7-9, for a list of ISO+ and ANS+ unit codes.",
            Sample = @"",
        };

        

        

        

        return durationUnits;
    } 
}
internal HL7V26Field allowSubstitutionCode;

public HL7V26Field AllowSubstitutionCode
{
    get
    {
        if (allowSubstitutionCode != null)
        {
            return allowSubstitutionCode;
        }

        allowSubstitutionCode = new HL7V26Field
        {
            field = message[@"AIG"][13],
            Id = @"AIG.13",
            Type = @"Field",
            Position = @"AIG.13",
            Name = @"Allow Substitution Code",
            Length = 10,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0279",
            TableName = @"Allow Substitution Codes",
            Description = @"This field contains a code indicating whether the identified resource can be substituted with an equivalent resource by the filler application. Refer to User-Defined Table 0279 - Allow Substitution Codes for suggested codes.

This field is conditionally required.  It is required for all request messages.  It is optional for all unsolicited transactions, and for all query messages.",
            Sample = @"",
        };

        

        

        

        return allowSubstitutionCode;
    } 
}
internal HL7V26Field fillerStatusCode;

public HL7V26Field FillerStatusCode
{
    get
    {
        if (fillerStatusCode != null)
        {
            return fillerStatusCode;
        }

        fillerStatusCode = new HL7V26Field
        {
            field = message[@"AIG"][14],
            Id = @"AIG.14",
            Type = @"Field",
            Position = @"AIG.14",
            Name = @"Filler Status Code",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0278",
            TableName = @"Filler status codes",
            Description = @"This field contains a code that describes the requested/scheduled status of scheduling resource or activity, from the point of view of the filler application. Refer to User-Defined Table 0278 - Filler Status Codes for suggested codes.

This is a conditionally required field.  Because the information contained in this field is only appropriate in transactions originating from a filler application, it is required for those messages.  This includes all unsolicited transactions originating from a filler application, as well as all response messages originating from a filler application.  This field is optional for all transactions originating from placer, querying and auxiliary applications.  It is recommended that this field be left unvalued in transactions originating from applications other than the filler application.",
            Sample = @"",
        };

        

        

        

        return fillerStatusCode;
    } 
}

    }
}
