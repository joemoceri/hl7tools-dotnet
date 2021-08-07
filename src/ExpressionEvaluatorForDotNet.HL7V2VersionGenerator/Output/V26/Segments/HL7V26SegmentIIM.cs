using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentIIM
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"IIM"; } }

        public string SegmentId { get { return @"IIM"; } }
        
        public string LongName { get { return @"Inventory Item Master"; } }
        
        public string Description { get { return @"The Inventory Item Master segment (IIM) contains information about the stock of product that can be used to fulfill an ordered test/service. All of the fields in this segment describe the test/service and other basic attributes pertaining to Service Item defined within an Other Observation/Service Item master file. This segment is related to centrally stocked or supply management concerns."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",
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
                            Id = @"IIM.1",
                            Type = @"Field",
                            Position = @"IIM.1",
                            Name = @"Primary Key Value - IIM",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the code assigned by the institution for the purpose of uniquely identifying an inventoried item. It is the identifying key value, and must match MFE-4 - Primary Key Value - MFE .",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IIM.1.1",
                            Type = @"Component",
                            Position = @"IIM.1.1",
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
                            Id = @"IIM.1.2",
                            Type = @"Component",
                            Position = @"IIM.1.2",
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
                            Id = @"IIM.1.3",
                            Type = @"Component",
                            Position = @"IIM.1.3",
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
                            Id = @"IIM.1.4",
                            Type = @"Component",
                            Position = @"IIM.1.4",
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
                            Id = @"IIM.1.5",
                            Type = @"Component",
                            Position = @"IIM.1.5",
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
                            Id = @"IIM.1.6",
                            Type = @"Component",
                            Position = @"IIM.1.6",
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
                            Id = @"IIM.1.7",
                            Type = @"Component",
                            Position = @"IIM.1.7",
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
                            Id = @"IIM.1.8",
                            Type = @"Component",
                            Position = @"IIM.1.8",
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
                            Id = @"IIM.1.9",
                            Type = @"Component",
                            Position = @"IIM.1.9",
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
                            Id = @"IIM.2",
                            Type = @"Field",
                            Position = @"IIM.2",
                            Name = @"Service Item Code",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identifier of the service item. It relates the inventory item of this message to an entry in an Other Observation/Service Item master file.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IIM.2.1",
                            Type = @"Component",
                            Position = @"IIM.2.1",
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
                            Id = @"IIM.2.2",
                            Type = @"Component",
                            Position = @"IIM.2.2",
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
                            Id = @"IIM.2.3",
                            Type = @"Component",
                            Position = @"IIM.2.3",
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
                            Id = @"IIM.2.4",
                            Type = @"Component",
                            Position = @"IIM.2.4",
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
                            Id = @"IIM.2.5",
                            Type = @"Component",
                            Position = @"IIM.2.5",
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
                            Id = @"IIM.2.6",
                            Type = @"Component",
                            Position = @"IIM.2.6",
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
                            Id = @"IIM.2.7",
                            Type = @"Component",
                            Position = @"IIM.2.7",
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
                            Id = @"IIM.2.8",
                            Type = @"Component",
                            Position = @"IIM.2.8",
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
                            Id = @"IIM.2.9",
                            Type = @"Component",
                            Position = @"IIM.2.9",
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
                            Id = @"IIM.3",
                            Type = @"Field",
                            Position = @"IIM.3",
                            Name = @"Inventory Lot Number",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the lot number of the service item in inventory.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.4",
                            Type = @"Field",
                            Position = @"IIM.4",
                            Name = @"Inventory Expiration Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the expiration date of the service item in inventory.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.5",
                            Type = @"Field",
                            Position = @"IIM.5",
                            Name = @"Inventory Manufacturer Name",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the manufacturer of the service item in inventory.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IIM.5.1",
                            Type = @"Component",
                            Position = @"IIM.5.1",
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
                            Id = @"IIM.5.2",
                            Type = @"Component",
                            Position = @"IIM.5.2",
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
                            Id = @"IIM.5.3",
                            Type = @"Component",
                            Position = @"IIM.5.3",
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
                            Id = @"IIM.5.4",
                            Type = @"Component",
                            Position = @"IIM.5.4",
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
                            Id = @"IIM.5.5",
                            Type = @"Component",
                            Position = @"IIM.5.5",
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
                            Id = @"IIM.5.6",
                            Type = @"Component",
                            Position = @"IIM.5.6",
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
                            Id = @"IIM.5.7",
                            Type = @"Component",
                            Position = @"IIM.5.7",
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
                            Id = @"IIM.5.8",
                            Type = @"Component",
                            Position = @"IIM.5.8",
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
                            Id = @"IIM.5.9",
                            Type = @"Component",
                            Position = @"IIM.5.9",
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
                            Id = @"IIM.6",
                            Type = @"Field",
                            Position = @"IIM.6",
                            Name = @"Inventory Location",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the location of the inventory. As an implementation consideration, this location can have a range of specificity. The location can be very general, e.g., a facility where the inventory is warehoused, or very specific, e.g., a shelf location.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IIM.6.1",
                            Type = @"Component",
                            Position = @"IIM.6.1",
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
                            Id = @"IIM.6.2",
                            Type = @"Component",
                            Position = @"IIM.6.2",
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
                            Id = @"IIM.6.3",
                            Type = @"Component",
                            Position = @"IIM.6.3",
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
                            Id = @"IIM.6.4",
                            Type = @"Component",
                            Position = @"IIM.6.4",
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
                            Id = @"IIM.6.5",
                            Type = @"Component",
                            Position = @"IIM.6.5",
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
                            Id = @"IIM.6.6",
                            Type = @"Component",
                            Position = @"IIM.6.6",
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
                            Id = @"IIM.6.7",
                            Type = @"Component",
                            Position = @"IIM.6.7",
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
                            Id = @"IIM.6.8",
                            Type = @"Component",
                            Position = @"IIM.6.8",
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
                            Id = @"IIM.6.9",
                            Type = @"Component",
                            Position = @"IIM.6.9",
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
                            Id = @"IIM.7",
                            Type = @"Field",
                            Position = @"IIM.7",
                            Name = @"Inventory Received Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the most recent date that the product in question was received into inventory.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.8",
                            Type = @"Field",
                            Position = @"IIM.8",
                            Name = @"Inventory Received Quantity",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the quantity of this inventory item that was received on the date specific in IIM-7 Inventory Received Date.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.9",
                            Type = @"Field",
                            Position = @"IIM.9",
                            Name = @"Inventory Received Quantity Unit",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the unit for IIM-8 Inventory Received Quantity and IIM-10 Inventory Received Item Cost.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IIM.9.1",
                            Type = @"Component",
                            Position = @"IIM.9.1",
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
                            Id = @"IIM.9.2",
                            Type = @"Component",
                            Position = @"IIM.9.2",
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
                            Id = @"IIM.9.3",
                            Type = @"Component",
                            Position = @"IIM.9.3",
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
                            Id = @"IIM.9.4",
                            Type = @"Component",
                            Position = @"IIM.9.4",
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
                            Id = @"IIM.9.5",
                            Type = @"Component",
                            Position = @"IIM.9.5",
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
                            Id = @"IIM.9.6",
                            Type = @"Component",
                            Position = @"IIM.9.6",
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
                            Id = @"IIM.9.7",
                            Type = @"Component",
                            Position = @"IIM.9.7",
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
                            Id = @"IIM.9.8",
                            Type = @"Component",
                            Position = @"IIM.9.8",
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
                            Id = @"IIM.9.9",
                            Type = @"Component",
                            Position = @"IIM.9.9",
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
                            Id = @"IIM.10",
                            Type = @"Field",
                            Position = @"IIM.10",
                            Name = @"Inventory Received Item Cost",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the per-unit cost of the inventory item at the time of receipt. IIM-9 Inventory Received Quantity Unit specifies the per-unit basis of this field.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IIM.10.1",
                            Type = @"Component",
                            Position = @"IIM.10.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.10.2",
                            Type = @"Component",
                            Position = @"IIM.10.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, ""MSH-17-country code"", in section 2.14.9.17, is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.11",
                            Type = @"Field",
                            Position = @"IIM.11",
                            Name = @"Inventory On Hand Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the most recent date that an inventory count for the inventory item was performed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.12",
                            Type = @"Field",
                            Position = @"IIM.12",
                            Name = @"Inventory On Hand Quantity",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the quantity of this inventory item that was available for issue/use as of the date specified in IIM-11 Inventory on Hand Date. No adjustment has been made for subsequent use.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.13",
                            Type = @"Field",
                            Position = @"IIM.13",
                            Name = @"Inventory On Hand Quantity Unit",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the unit for IIM-12 - Inventory on Hand Quantity.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IIM.13.1",
                            Type = @"Component",
                            Position = @"IIM.13.1",
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
                            Id = @"IIM.13.2",
                            Type = @"Component",
                            Position = @"IIM.13.2",
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
                            Id = @"IIM.13.3",
                            Type = @"Component",
                            Position = @"IIM.13.3",
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
                            Id = @"IIM.13.4",
                            Type = @"Component",
                            Position = @"IIM.13.4",
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
                            Id = @"IIM.13.5",
                            Type = @"Component",
                            Position = @"IIM.13.5",
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
                            Id = @"IIM.13.6",
                            Type = @"Component",
                            Position = @"IIM.13.6",
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
                            Id = @"IIM.13.7",
                            Type = @"Component",
                            Position = @"IIM.13.7",
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
                            Id = @"IIM.13.8",
                            Type = @"Component",
                            Position = @"IIM.13.8",
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
                            Id = @"IIM.13.9",
                            Type = @"Component",
                            Position = @"IIM.13.9",
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
                            Id = @"IIM.14",
                            Type = @"Field",
                            Position = @"IIM.14",
                            Name = @"Procedure Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0088",
                            TableName = @"Procedure Code",
                            Description = @"This field contains a unique identifier assigned to the service item, if any, associated with the charge. In the United States this is often the HCPCS code. Refer to Externally defined Table 0088 - Procedure code for suggested values. This field is a CNE data type for compatibility with clinical and ancillary systems.

As of v2.6, the known applicable external coding systems include those in Table Z003 Procedure Code Coding Systems. If the code set you are using is in this table, then you must use that designation.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IIM.14.1",
                            Type = @"Component",
                            Position = @"IIM.14.1",
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
                            Id = @"IIM.14.2",
                            Type = @"Component",
                            Position = @"IIM.14.2",
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
                            Id = @"IIM.14.3",
                            Type = @"Component",
                            Position = @"IIM.14.3",
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
                            Id = @"IIM.14.4",
                            Type = @"Component",
                            Position = @"IIM.14.4",
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
                            Id = @"IIM.14.5",
                            Type = @"Component",
                            Position = @"IIM.14.5",
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
                            Id = @"IIM.14.6",
                            Type = @"Component",
                            Position = @"IIM.14.6",
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
                            Id = @"IIM.14.7",
                            Type = @"Component",
                            Position = @"IIM.14.7",
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
                            Id = @"IIM.14.8",
                            Type = @"Component",
                            Position = @"IIM.14.8",
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
                            Id = @"IIM.14.9",
                            Type = @"Component",
                            Position = @"IIM.14.9",
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
                            Id = @"IIM.15",
                            Type = @"Field",
                            Position = @"IIM.15",
                            Name = @"Procedure Code Modifier",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0340",
                            TableName = @"Procedure Code Modifier",
                            Description = @"This field contains the procedure code modifier to the procedure code reported in IIM-14 Procedure Code , when applicable. Procedure code modifiers are defined by USA regulatory agencies such as CMS and the AMA. Multiple modifiers may be reported. Refer to Externally defined Table 0340 - Procedure code modifier for suggested values.

As of v2.6, the known applicable external coding systems include those in Table Z004 Procedure Code Modifier Coding Systems. If the code set you are using is in this table, then you must use that designation.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IIM.15.1",
                            Type = @"Component",
                            Position = @"IIM.15.1",
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
                            Id = @"IIM.15.2",
                            Type = @"Component",
                            Position = @"IIM.15.2",
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
                            Id = @"IIM.15.3",
                            Type = @"Component",
                            Position = @"IIM.15.3",
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
                            Id = @"IIM.15.4",
                            Type = @"Component",
                            Position = @"IIM.15.4",
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
                            Id = @"IIM.15.5",
                            Type = @"Component",
                            Position = @"IIM.15.5",
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
                            Id = @"IIM.15.6",
                            Type = @"Component",
                            Position = @"IIM.15.6",
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
                            Id = @"IIM.15.7",
                            Type = @"Component",
                            Position = @"IIM.15.7",
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
                            Id = @"IIM.15.8",
                            Type = @"Component",
                            Position = @"IIM.15.8",
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
                            Id = @"IIM.15.9",
                            Type = @"Component",
                            Position = @"IIM.15.9",
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

        public HL7V26SegmentIIM(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field primaryKeyValueIIM;

public HL7V26Field PrimaryKeyValueIIM
{
    get
    {
        if (primaryKeyValueIIM != null)
        {
            return primaryKeyValueIIM;
        }

        primaryKeyValueIIM = new HL7V26Field
        {
            field = message[@"IIM"][1],
            Id = @"IIM.1",
            Type = @"Field",
            Position = @"IIM.1",
            Name = @"Primary Key Value - IIM",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the code assigned by the institution for the purpose of uniquely identifying an inventoried item. It is the identifying key value, and must match MFE-4 - Primary Key Value - MFE .",
            Sample = @"",
        };

        

        

        

        return primaryKeyValueIIM;
    } 
}
internal HL7V26Field serviceItemCode;

public HL7V26Field ServiceItemCode
{
    get
    {
        if (serviceItemCode != null)
        {
            return serviceItemCode;
        }

        serviceItemCode = new HL7V26Field
        {
            field = message[@"IIM"][2],
            Id = @"IIM.2",
            Type = @"Field",
            Position = @"IIM.2",
            Name = @"Service Item Code",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier of the service item. It relates the inventory item of this message to an entry in an Other Observation/Service Item master file.",
            Sample = @"",
        };

        

        

        

        return serviceItemCode;
    } 
}
internal HL7V26Field inventoryLotNumber;

public HL7V26Field InventoryLotNumber
{
    get
    {
        if (inventoryLotNumber != null)
        {
            return inventoryLotNumber;
        }

        inventoryLotNumber = new HL7V26Field
        {
            field = message[@"IIM"][3],
            Id = @"IIM.3",
            Type = @"Field",
            Position = @"IIM.3",
            Name = @"Inventory Lot Number",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the lot number of the service item in inventory.",
            Sample = @"",
        };

        

        

        

        return inventoryLotNumber;
    } 
}
internal HL7V26Field inventoryExpirationDate;

public HL7V26Field InventoryExpirationDate
{
    get
    {
        if (inventoryExpirationDate != null)
        {
            return inventoryExpirationDate;
        }

        inventoryExpirationDate = new HL7V26Field
        {
            field = message[@"IIM"][4],
            Id = @"IIM.4",
            Type = @"Field",
            Position = @"IIM.4",
            Name = @"Inventory Expiration Date",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date of the service item in inventory.",
            Sample = @"",
        };

        

        

        

        return inventoryExpirationDate;
    } 
}
internal HL7V26Field inventoryManufacturerName;

public HL7V26Field InventoryManufacturerName
{
    get
    {
        if (inventoryManufacturerName != null)
        {
            return inventoryManufacturerName;
        }

        inventoryManufacturerName = new HL7V26Field
        {
            field = message[@"IIM"][5],
            Id = @"IIM.5",
            Type = @"Field",
            Position = @"IIM.5",
            Name = @"Inventory Manufacturer Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the manufacturer of the service item in inventory.",
            Sample = @"",
        };

        

        

        

        return inventoryManufacturerName;
    } 
}
internal HL7V26Field inventoryLocation;

public HL7V26Field InventoryLocation
{
    get
    {
        if (inventoryLocation != null)
        {
            return inventoryLocation;
        }

        inventoryLocation = new HL7V26Field
        {
            field = message[@"IIM"][6],
            Id = @"IIM.6",
            Type = @"Field",
            Position = @"IIM.6",
            Name = @"Inventory Location",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the location of the inventory. As an implementation consideration, this location can have a range of specificity. The location can be very general, e.g., a facility where the inventory is warehoused, or very specific, e.g., a shelf location.",
            Sample = @"",
        };

        

        

        

        return inventoryLocation;
    } 
}
internal HL7V26Field inventoryReceivedDate;

public HL7V26Field InventoryReceivedDate
{
    get
    {
        if (inventoryReceivedDate != null)
        {
            return inventoryReceivedDate;
        }

        inventoryReceivedDate = new HL7V26Field
        {
            field = message[@"IIM"][7],
            Id = @"IIM.7",
            Type = @"Field",
            Position = @"IIM.7",
            Name = @"Inventory Received Date",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the most recent date that the product in question was received into inventory.",
            Sample = @"",
        };

        

        

        

        return inventoryReceivedDate;
    } 
}
internal HL7V26Field inventoryReceivedQuantity;

public HL7V26Field InventoryReceivedQuantity
{
    get
    {
        if (inventoryReceivedQuantity != null)
        {
            return inventoryReceivedQuantity;
        }

        inventoryReceivedQuantity = new HL7V26Field
        {
            field = message[@"IIM"][8],
            Id = @"IIM.8",
            Type = @"Field",
            Position = @"IIM.8",
            Name = @"Inventory Received Quantity",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity of this inventory item that was received on the date specific in IIM-7 Inventory Received Date.",
            Sample = @"",
        };

        

        

        

        return inventoryReceivedQuantity;
    } 
}
internal HL7V26Field inventoryReceivedQuantityUnit;

public HL7V26Field InventoryReceivedQuantityUnit
{
    get
    {
        if (inventoryReceivedQuantityUnit != null)
        {
            return inventoryReceivedQuantityUnit;
        }

        inventoryReceivedQuantityUnit = new HL7V26Field
        {
            field = message[@"IIM"][9],
            Id = @"IIM.9",
            Type = @"Field",
            Position = @"IIM.9",
            Name = @"Inventory Received Quantity Unit",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the unit for IIM-8 Inventory Received Quantity and IIM-10 Inventory Received Item Cost.",
            Sample = @"",
        };

        

        

        

        return inventoryReceivedQuantityUnit;
    } 
}
internal HL7V26Field inventoryReceivedItemCost;

public HL7V26Field InventoryReceivedItemCost
{
    get
    {
        if (inventoryReceivedItemCost != null)
        {
            return inventoryReceivedItemCost;
        }

        inventoryReceivedItemCost = new HL7V26Field
        {
            field = message[@"IIM"][10],
            Id = @"IIM.10",
            Type = @"Field",
            Position = @"IIM.10",
            Name = @"Inventory Received Item Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"MO",
            DataTypeName = @"Money",
            TableId = null,
            TableName = null,
            Description = @"This field contains the per-unit cost of the inventory item at the time of receipt. IIM-9 Inventory Received Quantity Unit specifies the per-unit basis of this field.",
            Sample = @"",
        };

        

        

        

        return inventoryReceivedItemCost;
    } 
}
internal HL7V26Field inventoryOnHandDate;

public HL7V26Field InventoryOnHandDate
{
    get
    {
        if (inventoryOnHandDate != null)
        {
            return inventoryOnHandDate;
        }

        inventoryOnHandDate = new HL7V26Field
        {
            field = message[@"IIM"][11],
            Id = @"IIM.11",
            Type = @"Field",
            Position = @"IIM.11",
            Name = @"Inventory On Hand Date",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the most recent date that an inventory count for the inventory item was performed.",
            Sample = @"",
        };

        

        

        

        return inventoryOnHandDate;
    } 
}
internal HL7V26Field inventoryOnHandQuantity;

public HL7V26Field InventoryOnHandQuantity
{
    get
    {
        if (inventoryOnHandQuantity != null)
        {
            return inventoryOnHandQuantity;
        }

        inventoryOnHandQuantity = new HL7V26Field
        {
            field = message[@"IIM"][12],
            Id = @"IIM.12",
            Type = @"Field",
            Position = @"IIM.12",
            Name = @"Inventory On Hand Quantity",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity of this inventory item that was available for issue/use as of the date specified in IIM-11 Inventory on Hand Date. No adjustment has been made for subsequent use.",
            Sample = @"",
        };

        

        

        

        return inventoryOnHandQuantity;
    } 
}
internal HL7V26Field inventoryOnHandQuantityUnit;

public HL7V26Field InventoryOnHandQuantityUnit
{
    get
    {
        if (inventoryOnHandQuantityUnit != null)
        {
            return inventoryOnHandQuantityUnit;
        }

        inventoryOnHandQuantityUnit = new HL7V26Field
        {
            field = message[@"IIM"][13],
            Id = @"IIM.13",
            Type = @"Field",
            Position = @"IIM.13",
            Name = @"Inventory On Hand Quantity Unit",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the unit for IIM-12 - Inventory on Hand Quantity.",
            Sample = @"",
        };

        

        

        

        return inventoryOnHandQuantityUnit;
    } 
}
internal HL7V26Field procedureCode;

public HL7V26Field ProcedureCode
{
    get
    {
        if (procedureCode != null)
        {
            return procedureCode;
        }

        procedureCode = new HL7V26Field
        {
            field = message[@"IIM"][14],
            Id = @"IIM.14",
            Type = @"Field",
            Position = @"IIM.14",
            Name = @"Procedure Code",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0088",
            TableName = @"Procedure Code",
            Description = @"This field contains a unique identifier assigned to the service item, if any, associated with the charge. In the United States this is often the HCPCS code. Refer to Externally defined Table 0088 - Procedure code for suggested values. This field is a CNE data type for compatibility with clinical and ancillary systems.

As of v2.6, the known applicable external coding systems include those in Table Z003 Procedure Code Coding Systems. If the code set you are using is in this table, then you must use that designation.",
            Sample = @"",
        };

        

        

        

        return procedureCode;
    } 
}
internal HL7V26Field procedureCodeModifier;

public HL7V26Field ProcedureCodeModifier
{
    get
    {
        if (procedureCodeModifier != null)
        {
            return procedureCodeModifier;
        }

        procedureCodeModifier = new HL7V26Field
        {
            field = message[@"IIM"][15],
            Id = @"IIM.15",
            Type = @"Field",
            Position = @"IIM.15",
            Name = @"Procedure Code Modifier",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0340",
            TableName = @"Procedure Code Modifier",
            Description = @"This field contains the procedure code modifier to the procedure code reported in IIM-14 Procedure Code , when applicable. Procedure code modifiers are defined by USA regulatory agencies such as CMS and the AMA. Multiple modifiers may be reported. Refer to Externally defined Table 0340 - Procedure code modifier for suggested values.

As of v2.6, the known applicable external coding systems include those in Table Z004 Procedure Code Modifier Coding Systems. If the code set you are using is in this table, then you must use that designation.",
            Sample = @"",
        };

        

        

        

        return procedureCodeModifier;
    } 
}

    }
}
