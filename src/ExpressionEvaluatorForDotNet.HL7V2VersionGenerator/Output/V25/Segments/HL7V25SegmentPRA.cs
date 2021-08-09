using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentPRA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PRA"; } }

        public string SegmentId { get { return @"PRA"; } }
        
        public string LongName { get { return @"Practitioner Detail"; } }
        
        public string Description { get { return @"The PRA segment adds detailed medical practitioner information to the personnel identified by the STF segment.  A PRA segment may optionally follow an STF segment.  A PRA segment must always have been preceded by a corresponding STF segment.  The PRA segment may also be used for staff who work in healthcare who are not practitioners, but need to be certified, e.g., “medical records staff.”"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

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
                            Id = @"PRA.1",
                            Type = @"Field",
                            Position = @"PRA.1",
                            Name = @"Primary Key Value - PRA",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"For MFN Master File Notification, this field is required and must match MFE-4-primary key value, to identify which entry is being referenced. For all other messages, this field should not be used.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRA.1.1",
                            Type = @"Component",
                            Position = @"PRA.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.1.2",
                            Type = @"Component",
                            Position = @"PRA.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.1.3",
                            Type = @"Component",
                            Position = @"PRA.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.1.4",
                            Type = @"Component",
                            Position = @"PRA.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.1.5",
                            Type = @"Component",
                            Position = @"PRA.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.1.6",
                            Type = @"Component",
                            Position = @"PRA.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2",
                            Type = @"Field",
                            Position = @"PRA.2",
                            Name = @"Practitioner Group",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0358",
                            TableName = @"Practitioner group",
                            Description = @"This field contains the name and/or code of a group of practitioners to which this practitioner belongs. Refer to User-defined Table 0358 Practitioner group for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRA.2.1",
                            Type = @"Component",
                            Position = @"PRA.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2.2",
                            Type = @"Component",
                            Position = @"PRA.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2.3",
                            Type = @"Component",
                            Position = @"PRA.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2.4",
                            Type = @"Component",
                            Position = @"PRA.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2.5",
                            Type = @"Component",
                            Position = @"PRA.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2.6",
                            Type = @"Component",
                            Position = @"PRA.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.3",
                            Type = @"Field",
                            Position = @"PRA.3",
                            Name = @"Practitioner Category",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0186",
                            TableName = @"Practitioner category",
                            Description = @"This field contains the category of practitioner. Refer to User-defined Table 0186 - Practitioner category for suggested values. Values may include codes for staff physician, courtesy physician, resident, physician assistant, physical therapist, psychiatrist, psychologist, pharmacist, registered nurse, licensed practical nurse, licensed vocational nurse, nurse practitioner, etc. If the provider works in different Practitioner Categories in different organization units, then this information should be recorded separately in ORG-6,7,8.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.4",
                            Type = @"Field",
                            Position = @"PRA.4",
                            Name = @"Provider Billing",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0187",
                            TableName = @"Provider billing",
                            Description = @"This field indicates how provider services are billed. Refer to HL7 Table 0187 - Provider billing for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.5",
                            Type = @"Field",
                            Position = @"PRA.5",
                            Name = @"Specialty",
                            Length = 112,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"SPD",
                            DataTypeName = @"Specialty Description",
                            TableId = null,
                            TableName = null,
                            Description = @"This repeating field is made up of multiple components to record the practitioners specialties. The multiple components of each specialty are: (1) specialty name or abbreviation, identifies providers specialty, (2) name of specialty governing board, (3) Certification Status, (4) certified date contains the date of certification, if certified. Refer to HL7 Table 0337 - Certification status for valid values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRA.5.1",
                            Type = @"Component",
                            Position = @"PRA.5.1",
                            Name = @"Specialty Name",
                            Length = 50,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the providers specialty.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.5.2",
                            Type = @"Component",
                            Position = @"PRA.5.2",
                            Name = @"Governing Board",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the governing body providing for the specialty.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.5.3",
                            Type = @"Component",
                            Position = @"PRA.5.3",
                            Name = @"Eligible Or Certified",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0337",
                            TableName = @"Certification status",
                            Description = @"Specifies the certification status. Refer to HL7 Table 0337 - Certification status for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.5.4",
                            Type = @"Component",
                            Position = @"PRA.5.4",
                            Name = @"Date Of Certification",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies when certification occurred.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.6",
                            Type = @"Field",
                            Position = @"PRA.6",
                            Name = @"Practitioner ID Numbers",
                            Length = 99,
                            Usage = @"B",
                            Rpt = @"*",
                            DataType = @"PLN",
                            DataTypeName = @"Practitioner License or Other ID Number",
                            TableId = null,
                            TableName = null,
                            Description = @"As of version 2.5, this field has been retained for backward compatibility.  Practitioner ID numbers should be contained in STF-2 Staff Identifier List. This repeating field contains this practitioners license numbers and other ID numbers. This is a field made up of the following components: (1) the ID number, and (2) the type of number, and optionally (3) the state or province in which it is valid, if relevant, or other qualifying information. It is recommended that state qualifications use the abbreviations from the postal service of the country. The practitioner ID number type (component 2) is a user-defined table (Table 0338).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRA.6.1",
                            Type = @"Component",
                            Position = @"PRA.6.1",
                            Name = @"Id Number",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the license number or other ID number such as UPIN, Medicare and Medicaid number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.6.2",
                            Type = @"Component",
                            Position = @"PRA.6.2",
                            Name = @"Type Of Id Number",
                            Length = 8,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0338",
                            TableName = @"Practitioner ID number type",
                            Description = @"Specifies the type of number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.6.3",
                            Type = @"Component",
                            Position = @"PRA.6.3",
                            Name = @"State/Other Qualifying Information",
                            Length = 62,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the state or province in which the license or ID is valid, if relevant, or other qualifying information. It is recommended that state qualifications use the abbreviations from the postal service of the country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.6.4",
                            Type = @"Component",
                            Position = @"PRA.6.4",
                            Name = @"Expiration Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the date when the license or ID is no longer valid.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7",
                            Type = @"Field",
                            Position = @"PRA.7",
                            Name = @"Privileges",
                            Length = 770,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"PIP",
                            DataTypeName = @"Practitioner Institutional Privileges",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the institutional privileges which this provider may exercise. Depends upon institutional needs. For example, admit, transfer, discharge, place orders, verify orders, review results, etc. Can also be used for privileges other than patient services. This is a repeating field, with each privilege made up of the following components: (1) privilege; (2) privilege class; (3) privilege expiration date, if any; (4) privilege activation date, if any, and (5) facility. Note that the privilege and privilege class components are CE data types, and thus they are encoded with the subcomponent delimiter (&) rather than the component delimiter (^). The facility component is an EI data type specifying the facility to which the privilege applies and is encoded with the subcomponent delimiter (&) rather than the component delimiter (^). The facility component is an EI data type specifying the facility to which the privilege applies and is encoded with the subcomponent delimiter (&) rather than the component delimiter (^).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRA.7.1",
                            Type = @"Component",
                            Position = @"PRA.7.1",
                            Name = @"Privilege",
                            Length = 483,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0525",
                            TableName = @"Privilege",
                            Description = @"Specifies the institutional privilege itself. Refer to user-defined table 0525 - Privilege for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.1",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.2",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.3",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.4",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.5",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.6",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2",
                            Type = @"Component",
                            Position = @"PRA.7.2",
                            Name = @"Privilege Class",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0526",
                            TableName = @"Privilege class",
                            Description = @"Specifies the class category of institutional privilege. Refer to User-Defined Table 0526 - Privilege Class for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.1",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.2",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.3",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.4",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.5",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.6",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.3",
                            Type = @"Component",
                            Position = @"PRA.7.3",
                            Name = @"Expiration Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the date the institutional privilege is/was no longer valid.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.4",
                            Type = @"Component",
                            Position = @"PRA.7.4",
                            Name = @"Activation Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the date the institutional privilege became/becomes valid.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.5",
                            Type = @"Component",
                            Position = @"PRA.7.5",
                            Name = @"Facility",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the facility in which the institutional privilege is/was valid.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRA.7.5.1",
                            Type = @"SubComponent",
                            Position = @"PRA.7.5.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.5.2",
                            Type = @"SubComponent",
                            Position = @"PRA.7.5.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.5.3",
                            Type = @"SubComponent",
                            Position = @"PRA.7.5.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"PRA.7.5.4",
                            Type = @"SubComponent",
                            Position = @"PRA.7.5.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.8",
                            Type = @"Field",
                            Position = @"PRA.8",
                            Name = @"Date Entered Practice",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date the practitioner began practicing at the present institution (e.g., at hospital, at physician organization, at managed care network).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.9",
                            Type = @"Field",
                            Position = @"PRA.9",
                            Name = @"Institution",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0537",
                            TableName = @"Institution",
                            Description = @"This field contains the institution the practitioner began or intends to begin practicing at (e.g., at hospital, at physician organization, at managed care network). Refer to User-defined Table 0537 - Institution for valid values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRA.9.1",
                            Type = @"Component",
                            Position = @"PRA.9.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.9.2",
                            Type = @"Component",
                            Position = @"PRA.9.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.9.3",
                            Type = @"Component",
                            Position = @"PRA.9.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.9.4",
                            Type = @"Component",
                            Position = @"PRA.9.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.9.5",
                            Type = @"Component",
                            Position = @"PRA.9.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.9.6",
                            Type = @"Component",
                            Position = @"PRA.9.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.10",
                            Type = @"Field",
                            Position = @"PRA.10",
                            Name = @"Date Left Practice",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date the practitioner ended or intends to end practicing at the given institution (e.g., at hospital, at physician organization, at managed care network).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.11",
                            Type = @"Field",
                            Position = @"PRA.11",
                            Name = @"Government Reimbursement Billing Eligibility",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0401",
                            TableName = @"Government reimbursement program",
                            Description = @"This field contains a code that indicates the agency that the practitioner is authorized to bill for medical services. Refer to User-defined Table 0401 - Government reimbursement program for valid values. This is a repeating field.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PRA.11.1",
                            Type = @"Component",
                            Position = @"PRA.11.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.11.2",
                            Type = @"Component",
                            Position = @"PRA.11.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.11.3",
                            Type = @"Component",
                            Position = @"PRA.11.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.11.4",
                            Type = @"Component",
                            Position = @"PRA.11.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.11.5",
                            Type = @"Component",
                            Position = @"PRA.11.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.11.6",
                            Type = @"Component",
                            Position = @"PRA.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.12",
                            Type = @"Field",
                            Position = @"PRA.12",
                            Name = @"Set ID - PRA",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"For all messages except the Staff/Practitioner Master File Notification, this field is required and contains the number that identifies this transaction. For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc. For the Staff/Practitioner Master File Notification message, this field should not be used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V25SegmentPRA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field primaryKeyValuePRA;

public HL7V25Field PrimaryKeyValuePRA
{
    get
    {
        if (primaryKeyValuePRA != null)
        {
            return primaryKeyValuePRA;
        }

        primaryKeyValuePRA = new HL7V25Field
        {
            field = message[@"PRA"][1],
            Id = @"PRA.1",
            Type = @"Field",
            Position = @"PRA.1",
            Name = @"Primary Key Value - PRA",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"For MFN Master File Notification, this field is required and must match MFE-4-primary key value, to identify which entry is being referenced. For all other messages, this field should not be used.",
            Sample = @"",
        };

        // check for repetitions
        if (primaryKeyValuePRA.field.FieldRepetitions != null && primaryKeyValuePRA.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryKeyValuePRA.Id));
            primaryKeyValuePRA.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(primaryKeyValuePRA, fieldData);
        }

        return primaryKeyValuePRA;
    } 
}

internal HL7V25Field practitionerGroup;

public HL7V25Field PractitionerGroup
{
    get
    {
        if (practitionerGroup != null)
        {
            return practitionerGroup;
        }

        practitionerGroup = new HL7V25Field
        {
            field = message[@"PRA"][2],
            Id = @"PRA.2",
            Type = @"Field",
            Position = @"PRA.2",
            Name = @"Practitioner Group",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0358",
            TableName = @"Practitioner group",
            Description = @"This field contains the name and/or code of a group of practitioners to which this practitioner belongs. Refer to User-defined Table 0358 Practitioner group for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (practitionerGroup.field.FieldRepetitions != null && practitionerGroup.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(practitionerGroup.Id));
            practitionerGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(practitionerGroup, fieldData);
        }

        return practitionerGroup;
    } 
}

internal HL7V25Field practitionerCategory;

public HL7V25Field PractitionerCategory
{
    get
    {
        if (practitionerCategory != null)
        {
            return practitionerCategory;
        }

        practitionerCategory = new HL7V25Field
        {
            field = message[@"PRA"][3],
            Id = @"PRA.3",
            Type = @"Field",
            Position = @"PRA.3",
            Name = @"Practitioner Category",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0186",
            TableName = @"Practitioner category",
            Description = @"This field contains the category of practitioner. Refer to User-defined Table 0186 - Practitioner category for suggested values. Values may include codes for staff physician, courtesy physician, resident, physician assistant, physical therapist, psychiatrist, psychologist, pharmacist, registered nurse, licensed practical nurse, licensed vocational nurse, nurse practitioner, etc. If the provider works in different Practitioner Categories in different organization units, then this information should be recorded separately in ORG-6,7,8.",
            Sample = @"",
        };

        // check for repetitions
        if (practitionerCategory.field.FieldRepetitions != null && practitionerCategory.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(practitionerCategory.Id));
            practitionerCategory.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(practitionerCategory, fieldData);
        }

        return practitionerCategory;
    } 
}

internal HL7V25Field providerBilling;

public HL7V25Field ProviderBilling
{
    get
    {
        if (providerBilling != null)
        {
            return providerBilling;
        }

        providerBilling = new HL7V25Field
        {
            field = message[@"PRA"][4],
            Id = @"PRA.4",
            Type = @"Field",
            Position = @"PRA.4",
            Name = @"Provider Billing",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0187",
            TableName = @"Provider billing",
            Description = @"This field indicates how provider services are billed. Refer to HL7 Table 0187 - Provider billing for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (providerBilling.field.FieldRepetitions != null && providerBilling.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(providerBilling.Id));
            providerBilling.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(providerBilling, fieldData);
        }

        return providerBilling;
    } 
}

internal HL7V25Field specialty;

public HL7V25Field Specialty
{
    get
    {
        if (specialty != null)
        {
            return specialty;
        }

        specialty = new HL7V25Field
        {
            field = message[@"PRA"][5],
            Id = @"PRA.5",
            Type = @"Field",
            Position = @"PRA.5",
            Name = @"Specialty",
            Length = 112,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SPD",
            DataTypeName = @"Specialty Description",
            TableId = null,
            TableName = null,
            Description = @"This repeating field is made up of multiple components to record the practitioners specialties. The multiple components of each specialty are: (1) specialty name or abbreviation, identifies providers specialty, (2) name of specialty governing board, (3) Certification Status, (4) certified date contains the date of certification, if certified. Refer to HL7 Table 0337 - Certification status for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (specialty.field.FieldRepetitions != null && specialty.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specialty.Id));
            specialty.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(specialty, fieldData);
        }

        return specialty;
    } 
}

internal HL7V25Field practitionerIDNumbers;

public HL7V25Field PractitionerIDNumbers
{
    get
    {
        if (practitionerIDNumbers != null)
        {
            return practitionerIDNumbers;
        }

        practitionerIDNumbers = new HL7V25Field
        {
            field = message[@"PRA"][6],
            Id = @"PRA.6",
            Type = @"Field",
            Position = @"PRA.6",
            Name = @"Practitioner ID Numbers",
            Length = 99,
            Usage = @"B",
            Rpt = @"*",
            DataType = @"PLN",
            DataTypeName = @"Practitioner License or Other ID Number",
            TableId = null,
            TableName = null,
            Description = @"As of version 2.5, this field has been retained for backward compatibility.  Practitioner ID numbers should be contained in STF-2 Staff Identifier List. This repeating field contains this practitioners license numbers and other ID numbers. This is a field made up of the following components: (1) the ID number, and (2) the type of number, and optionally (3) the state or province in which it is valid, if relevant, or other qualifying information. It is recommended that state qualifications use the abbreviations from the postal service of the country. The practitioner ID number type (component 2) is a user-defined table (Table 0338).",
            Sample = @"",
        };

        // check for repetitions
        if (practitionerIDNumbers.field.FieldRepetitions != null && practitionerIDNumbers.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(practitionerIDNumbers.Id));
            practitionerIDNumbers.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(practitionerIDNumbers, fieldData);
        }

        return practitionerIDNumbers;
    } 
}

internal HL7V25Field privileges;

public HL7V25Field Privileges
{
    get
    {
        if (privileges != null)
        {
            return privileges;
        }

        privileges = new HL7V25Field
        {
            field = message[@"PRA"][7],
            Id = @"PRA.7",
            Type = @"Field",
            Position = @"PRA.7",
            Name = @"Privileges",
            Length = 770,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"PIP",
            DataTypeName = @"Practitioner Institutional Privileges",
            TableId = null,
            TableName = null,
            Description = @"This field contains the institutional privileges which this provider may exercise. Depends upon institutional needs. For example, admit, transfer, discharge, place orders, verify orders, review results, etc. Can also be used for privileges other than patient services. This is a repeating field, with each privilege made up of the following components: (1) privilege; (2) privilege class; (3) privilege expiration date, if any; (4) privilege activation date, if any, and (5) facility. Note that the privilege and privilege class components are CE data types, and thus they are encoded with the subcomponent delimiter (&) rather than the component delimiter (^). The facility component is an EI data type specifying the facility to which the privilege applies and is encoded with the subcomponent delimiter (&) rather than the component delimiter (^). The facility component is an EI data type specifying the facility to which the privilege applies and is encoded with the subcomponent delimiter (&) rather than the component delimiter (^).",
            Sample = @"",
        };

        // check for repetitions
        if (privileges.field.FieldRepetitions != null && privileges.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(privileges.Id));
            privileges.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(privileges, fieldData);
        }

        return privileges;
    } 
}

internal HL7V25Field dateEnteredPractice;

public HL7V25Field DateEnteredPractice
{
    get
    {
        if (dateEnteredPractice != null)
        {
            return dateEnteredPractice;
        }

        dateEnteredPractice = new HL7V25Field
        {
            field = message[@"PRA"][8],
            Id = @"PRA.8",
            Type = @"Field",
            Position = @"PRA.8",
            Name = @"Date Entered Practice",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the practitioner began practicing at the present institution (e.g., at hospital, at physician organization, at managed care network).",
            Sample = @"",
        };

        // check for repetitions
        if (dateEnteredPractice.field.FieldRepetitions != null && dateEnteredPractice.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateEnteredPractice.Id));
            dateEnteredPractice.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(dateEnteredPractice, fieldData);
        }

        return dateEnteredPractice;
    } 
}

internal HL7V25Field institution;

public HL7V25Field Institution
{
    get
    {
        if (institution != null)
        {
            return institution;
        }

        institution = new HL7V25Field
        {
            field = message[@"PRA"][9],
            Id = @"PRA.9",
            Type = @"Field",
            Position = @"PRA.9",
            Name = @"Institution",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0537",
            TableName = @"Institution",
            Description = @"This field contains the institution the practitioner began or intends to begin practicing at (e.g., at hospital, at physician organization, at managed care network). Refer to User-defined Table 0537 - Institution for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (institution.field.FieldRepetitions != null && institution.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(institution.Id));
            institution.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(institution, fieldData);
        }

        return institution;
    } 
}

internal HL7V25Field dateLeftPractice;

public HL7V25Field DateLeftPractice
{
    get
    {
        if (dateLeftPractice != null)
        {
            return dateLeftPractice;
        }

        dateLeftPractice = new HL7V25Field
        {
            field = message[@"PRA"][10],
            Id = @"PRA.10",
            Type = @"Field",
            Position = @"PRA.10",
            Name = @"Date Left Practice",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the practitioner ended or intends to end practicing at the given institution (e.g., at hospital, at physician organization, at managed care network).",
            Sample = @"",
        };

        // check for repetitions
        if (dateLeftPractice.field.FieldRepetitions != null && dateLeftPractice.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateLeftPractice.Id));
            dateLeftPractice.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(dateLeftPractice, fieldData);
        }

        return dateLeftPractice;
    } 
}

internal HL7V25Field governmentReimbursementBillingEligibility;

public HL7V25Field GovernmentReimbursementBillingEligibility
{
    get
    {
        if (governmentReimbursementBillingEligibility != null)
        {
            return governmentReimbursementBillingEligibility;
        }

        governmentReimbursementBillingEligibility = new HL7V25Field
        {
            field = message[@"PRA"][11],
            Id = @"PRA.11",
            Type = @"Field",
            Position = @"PRA.11",
            Name = @"Government Reimbursement Billing Eligibility",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0401",
            TableName = @"Government reimbursement program",
            Description = @"This field contains a code that indicates the agency that the practitioner is authorized to bill for medical services. Refer to User-defined Table 0401 - Government reimbursement program for valid values. This is a repeating field.",
            Sample = @"",
        };

        // check for repetitions
        if (governmentReimbursementBillingEligibility.field.FieldRepetitions != null && governmentReimbursementBillingEligibility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(governmentReimbursementBillingEligibility.Id));
            governmentReimbursementBillingEligibility.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(governmentReimbursementBillingEligibility, fieldData);
        }

        return governmentReimbursementBillingEligibility;
    } 
}

internal HL7V25Field setIDPRA;

public HL7V25Field SetIDPRA
{
    get
    {
        if (setIDPRA != null)
        {
            return setIDPRA;
        }

        setIDPRA = new HL7V25Field
        {
            field = message[@"PRA"][12],
            Id = @"PRA.12",
            Type = @"Field",
            Position = @"PRA.12",
            Name = @"Set ID - PRA",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"For all messages except the Staff/Practitioner Master File Notification, this field is required and contains the number that identifies this transaction. For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc. For the Staff/Practitioner Master File Notification message, this field should not be used.",
            Sample = @"",
        };

        // check for repetitions
        if (setIDPRA.field.FieldRepetitions != null && setIDPRA.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDPRA.Id));
            setIDPRA.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(setIDPRA, fieldData);
        }

        return setIDPRA;
    } 
}
    }
}
