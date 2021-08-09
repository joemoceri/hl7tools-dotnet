using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentIIM
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IIM"; } }

        public string SegmentId { get { return @"IIM"; } }
        
        public string LongName { get { return @"Inventory Item Master"; } }
        
        public string Description { get { return @"The Inventory Item Master segment (IIM) contains information about the stock of product that can be used to fulfill an ordered test/service. All of the fields in this segment describe the test/service and other basic attributes pertaining to Service Item defined within an Other Observation/Service Item master file. This segment is related to centrally stocked or supply management concerns.

Note:  We recognize that the M15 Inventory Item Master File trigger event and the IIM inventory item master segment is a limited implementation.  There is a comprehensive Materials Management message in development for inclusion in the next release.  For further information contact the Scheduling and Logistics TC.  This will be coordinated with the Control/Query TC and the Orders and Observations TC. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

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
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component.",
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
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
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
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
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
                        },}
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
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component.",
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
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
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
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
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
                        },}
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
                            Description = @"This field contains the lot number of the service item in inventory.

Note:  The lot number is the number printed on the label attached to the item or container holding the substance.  If the substance is a vaccine, for example, and a diluent is required, a lot number may appear on the vial containing the diluent; however, any such identifier associated with a diluent is not the identifier of interest. The substance lot number should be reported, not that of the diluent. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.4",
                            Type = @"Field",
                            Position = @"IIM.4",
                            Name = @"Inventory Expiration Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the expiration date of the service item in inventory.

Note:  Expiration date does not always have a “day” component; therefore, such a date may be transmitted as YYYYMM. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IIM.4.1",
                            Type = @"Component",
                            Position = @"IIM.4.1",
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
                            Id = @"IIM.4.2",
                            Type = @"Component",
                            Position = @"IIM.4.2",
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
                        },}
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
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component.",
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
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
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
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
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
                        },}
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
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component.",
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
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
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
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.7",
                            Type = @"Field",
                            Position = @"IIM.7",
                            Name = @"Inventory Received Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the most recent date that the product in question was received into inventory.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IIM.7.1",
                            Type = @"Component",
                            Position = @"IIM.7.1",
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
                            Id = @"IIM.7.2",
                            Type = @"Component",
                            Position = @"IIM.7.2",
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
                        },}
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
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component.",
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
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
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
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
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
                        },}
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
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.11",
                            Type = @"Field",
                            Position = @"IIM.11",
                            Name = @"Inventory On Hand Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the most recent date that an inventory count for the inventory item was performed.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IIM.11.1",
                            Type = @"Component",
                            Position = @"IIM.11.1",
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
                            Id = @"IIM.11.2",
                            Type = @"Component",
                            Position = @"IIM.11.2",
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
                        },}
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
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component.",
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
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
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
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.14",
                            Type = @"Field",
                            Position = @"IIM.14",
                            Name = @"Procedure Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0088",
                            TableName = @"Procedure Code",
                            Description = @"This field contains a unique identifier assigned to the service item, if any, associated with the charge. In the United States this is often the HCPCS code. Refer to User-defined Table 0088 - Procedure code for suggested values. This field is a CE data type for compatibility with clinical and ancillary systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IIM.14.1",
                            Type = @"Component",
                            Position = @"IIM.14.1",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.15",
                            Type = @"Field",
                            Position = @"IIM.15",
                            Name = @"Procedure Code Modifier",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0340",
                            TableName = @"Procedure code modifier",
                            Description = @"This field contains the procedure code modifier to the procedure code reported in IIM-14 Procedure Code , when applicable. Procedure code modifiers are defined by USA regulatory agencies such as CMS and the AMA. Multiple modifiers may be reported. Refer to User-defined Table 0340 - Procedure code modifier for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IIM.15.1",
                            Type = @"Component",
                            Position = @"IIM.15.1",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V251SegmentIIM(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field primaryKeyValueIIM;

public HL7V251Field PrimaryKeyValueIIM
{
    get
    {
        if (primaryKeyValueIIM != null)
        {
            return primaryKeyValueIIM;
        }

        primaryKeyValueIIM = new HL7V251Field
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

        // check for repetitions
        if (primaryKeyValueIIM.field.FieldRepetitions != null && primaryKeyValueIIM.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryKeyValueIIM.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < primaryKeyValueIIM.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = primaryKeyValueIIM.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < primaryKeyValueIIM.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = primaryKeyValueIIM.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < primaryKeyValueIIM.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = primaryKeyValueIIM.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            primaryKeyValueIIM.fieldRepetitions = fieldRepetitions;
        }

        return primaryKeyValueIIM;
    } 
}

internal HL7V251Field serviceItemCode;

public HL7V251Field ServiceItemCode
{
    get
    {
        if (serviceItemCode != null)
        {
            return serviceItemCode;
        }

        serviceItemCode = new HL7V251Field
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

        // check for repetitions
        if (serviceItemCode.field.FieldRepetitions != null && serviceItemCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(serviceItemCode.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < serviceItemCode.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = serviceItemCode.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < serviceItemCode.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = serviceItemCode.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < serviceItemCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = serviceItemCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            serviceItemCode.fieldRepetitions = fieldRepetitions;
        }

        return serviceItemCode;
    } 
}

internal HL7V251Field inventoryLotNumber;

public HL7V251Field InventoryLotNumber
{
    get
    {
        if (inventoryLotNumber != null)
        {
            return inventoryLotNumber;
        }

        inventoryLotNumber = new HL7V251Field
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
            Description = @"This field contains the lot number of the service item in inventory.

Note:  The lot number is the number printed on the label attached to the item or container holding the substance.  If the substance is a vaccine, for example, and a diluent is required, a lot number may appear on the vial containing the diluent; however, any such identifier associated with a diluent is not the identifier of interest. The substance lot number should be reported, not that of the diluent. ",
            Sample = @"",
        };

        // check for repetitions
        if (inventoryLotNumber.field.FieldRepetitions != null && inventoryLotNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryLotNumber.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < inventoryLotNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = inventoryLotNumber.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inventoryLotNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = inventoryLotNumber.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < inventoryLotNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = inventoryLotNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            inventoryLotNumber.fieldRepetitions = fieldRepetitions;
        }

        return inventoryLotNumber;
    } 
}

internal HL7V251Field inventoryExpirationDate;

public HL7V251Field InventoryExpirationDate
{
    get
    {
        if (inventoryExpirationDate != null)
        {
            return inventoryExpirationDate;
        }

        inventoryExpirationDate = new HL7V251Field
        {
            field = message[@"IIM"][4],
            Id = @"IIM.4",
            Type = @"Field",
            Position = @"IIM.4",
            Name = @"Inventory Expiration Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date of the service item in inventory.

Note:  Expiration date does not always have a “day” component; therefore, such a date may be transmitted as YYYYMM. ",
            Sample = @"",
        };

        // check for repetitions
        if (inventoryExpirationDate.field.FieldRepetitions != null && inventoryExpirationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryExpirationDate.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < inventoryExpirationDate.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = inventoryExpirationDate.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inventoryExpirationDate.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = inventoryExpirationDate.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < inventoryExpirationDate.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = inventoryExpirationDate.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            inventoryExpirationDate.fieldRepetitions = fieldRepetitions;
        }

        return inventoryExpirationDate;
    } 
}

internal HL7V251Field inventoryManufacturerName;

public HL7V251Field InventoryManufacturerName
{
    get
    {
        if (inventoryManufacturerName != null)
        {
            return inventoryManufacturerName;
        }

        inventoryManufacturerName = new HL7V251Field
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

        // check for repetitions
        if (inventoryManufacturerName.field.FieldRepetitions != null && inventoryManufacturerName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryManufacturerName.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < inventoryManufacturerName.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = inventoryManufacturerName.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inventoryManufacturerName.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = inventoryManufacturerName.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < inventoryManufacturerName.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = inventoryManufacturerName.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            inventoryManufacturerName.fieldRepetitions = fieldRepetitions;
        }

        return inventoryManufacturerName;
    } 
}

internal HL7V251Field inventoryLocation;

public HL7V251Field InventoryLocation
{
    get
    {
        if (inventoryLocation != null)
        {
            return inventoryLocation;
        }

        inventoryLocation = new HL7V251Field
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

        // check for repetitions
        if (inventoryLocation.field.FieldRepetitions != null && inventoryLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryLocation.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < inventoryLocation.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = inventoryLocation.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inventoryLocation.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = inventoryLocation.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < inventoryLocation.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = inventoryLocation.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            inventoryLocation.fieldRepetitions = fieldRepetitions;
        }

        return inventoryLocation;
    } 
}

internal HL7V251Field inventoryReceivedDate;

public HL7V251Field InventoryReceivedDate
{
    get
    {
        if (inventoryReceivedDate != null)
        {
            return inventoryReceivedDate;
        }

        inventoryReceivedDate = new HL7V251Field
        {
            field = message[@"IIM"][7],
            Id = @"IIM.7",
            Type = @"Field",
            Position = @"IIM.7",
            Name = @"Inventory Received Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the most recent date that the product in question was received into inventory.",
            Sample = @"",
        };

        // check for repetitions
        if (inventoryReceivedDate.field.FieldRepetitions != null && inventoryReceivedDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryReceivedDate.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < inventoryReceivedDate.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = inventoryReceivedDate.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inventoryReceivedDate.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = inventoryReceivedDate.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < inventoryReceivedDate.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = inventoryReceivedDate.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            inventoryReceivedDate.fieldRepetitions = fieldRepetitions;
        }

        return inventoryReceivedDate;
    } 
}

internal HL7V251Field inventoryReceivedQuantity;

public HL7V251Field InventoryReceivedQuantity
{
    get
    {
        if (inventoryReceivedQuantity != null)
        {
            return inventoryReceivedQuantity;
        }

        inventoryReceivedQuantity = new HL7V251Field
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

        // check for repetitions
        if (inventoryReceivedQuantity.field.FieldRepetitions != null && inventoryReceivedQuantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryReceivedQuantity.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < inventoryReceivedQuantity.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = inventoryReceivedQuantity.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inventoryReceivedQuantity.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = inventoryReceivedQuantity.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < inventoryReceivedQuantity.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = inventoryReceivedQuantity.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            inventoryReceivedQuantity.fieldRepetitions = fieldRepetitions;
        }

        return inventoryReceivedQuantity;
    } 
}

internal HL7V251Field inventoryReceivedQuantityUnit;

public HL7V251Field InventoryReceivedQuantityUnit
{
    get
    {
        if (inventoryReceivedQuantityUnit != null)
        {
            return inventoryReceivedQuantityUnit;
        }

        inventoryReceivedQuantityUnit = new HL7V251Field
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

        // check for repetitions
        if (inventoryReceivedQuantityUnit.field.FieldRepetitions != null && inventoryReceivedQuantityUnit.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryReceivedQuantityUnit.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < inventoryReceivedQuantityUnit.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = inventoryReceivedQuantityUnit.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inventoryReceivedQuantityUnit.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = inventoryReceivedQuantityUnit.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < inventoryReceivedQuantityUnit.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = inventoryReceivedQuantityUnit.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            inventoryReceivedQuantityUnit.fieldRepetitions = fieldRepetitions;
        }

        return inventoryReceivedQuantityUnit;
    } 
}

internal HL7V251Field inventoryReceivedItemCost;

public HL7V251Field InventoryReceivedItemCost
{
    get
    {
        if (inventoryReceivedItemCost != null)
        {
            return inventoryReceivedItemCost;
        }

        inventoryReceivedItemCost = new HL7V251Field
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

        // check for repetitions
        if (inventoryReceivedItemCost.field.FieldRepetitions != null && inventoryReceivedItemCost.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryReceivedItemCost.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < inventoryReceivedItemCost.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = inventoryReceivedItemCost.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inventoryReceivedItemCost.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = inventoryReceivedItemCost.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < inventoryReceivedItemCost.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = inventoryReceivedItemCost.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            inventoryReceivedItemCost.fieldRepetitions = fieldRepetitions;
        }

        return inventoryReceivedItemCost;
    } 
}

internal HL7V251Field inventoryOnHandDate;

public HL7V251Field InventoryOnHandDate
{
    get
    {
        if (inventoryOnHandDate != null)
        {
            return inventoryOnHandDate;
        }

        inventoryOnHandDate = new HL7V251Field
        {
            field = message[@"IIM"][11],
            Id = @"IIM.11",
            Type = @"Field",
            Position = @"IIM.11",
            Name = @"Inventory On Hand Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the most recent date that an inventory count for the inventory item was performed.",
            Sample = @"",
        };

        // check for repetitions
        if (inventoryOnHandDate.field.FieldRepetitions != null && inventoryOnHandDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryOnHandDate.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < inventoryOnHandDate.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = inventoryOnHandDate.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inventoryOnHandDate.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = inventoryOnHandDate.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < inventoryOnHandDate.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = inventoryOnHandDate.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            inventoryOnHandDate.fieldRepetitions = fieldRepetitions;
        }

        return inventoryOnHandDate;
    } 
}

internal HL7V251Field inventoryOnHandQuantity;

public HL7V251Field InventoryOnHandQuantity
{
    get
    {
        if (inventoryOnHandQuantity != null)
        {
            return inventoryOnHandQuantity;
        }

        inventoryOnHandQuantity = new HL7V251Field
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

        // check for repetitions
        if (inventoryOnHandQuantity.field.FieldRepetitions != null && inventoryOnHandQuantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryOnHandQuantity.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < inventoryOnHandQuantity.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = inventoryOnHandQuantity.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inventoryOnHandQuantity.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = inventoryOnHandQuantity.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < inventoryOnHandQuantity.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = inventoryOnHandQuantity.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            inventoryOnHandQuantity.fieldRepetitions = fieldRepetitions;
        }

        return inventoryOnHandQuantity;
    } 
}

internal HL7V251Field inventoryOnHandQuantityUnit;

public HL7V251Field InventoryOnHandQuantityUnit
{
    get
    {
        if (inventoryOnHandQuantityUnit != null)
        {
            return inventoryOnHandQuantityUnit;
        }

        inventoryOnHandQuantityUnit = new HL7V251Field
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

        // check for repetitions
        if (inventoryOnHandQuantityUnit.field.FieldRepetitions != null && inventoryOnHandQuantityUnit.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inventoryOnHandQuantityUnit.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < inventoryOnHandQuantityUnit.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = inventoryOnHandQuantityUnit.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inventoryOnHandQuantityUnit.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = inventoryOnHandQuantityUnit.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < inventoryOnHandQuantityUnit.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = inventoryOnHandQuantityUnit.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            inventoryOnHandQuantityUnit.fieldRepetitions = fieldRepetitions;
        }

        return inventoryOnHandQuantityUnit;
    } 
}

internal HL7V251Field procedureCode;

public HL7V251Field ProcedureCode
{
    get
    {
        if (procedureCode != null)
        {
            return procedureCode;
        }

        procedureCode = new HL7V251Field
        {
            field = message[@"IIM"][14],
            Id = @"IIM.14",
            Type = @"Field",
            Position = @"IIM.14",
            Name = @"Procedure Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0088",
            TableName = @"Procedure Code",
            Description = @"This field contains a unique identifier assigned to the service item, if any, associated with the charge. In the United States this is often the HCPCS code. Refer to User-defined Table 0088 - Procedure code for suggested values. This field is a CE data type for compatibility with clinical and ancillary systems.",
            Sample = @"",
        };

        // check for repetitions
        if (procedureCode.field.FieldRepetitions != null && procedureCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureCode.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < procedureCode.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = procedureCode.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < procedureCode.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = procedureCode.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < procedureCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = procedureCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            procedureCode.fieldRepetitions = fieldRepetitions;
        }

        return procedureCode;
    } 
}

internal HL7V251Field procedureCodeModifier;

public HL7V251Field ProcedureCodeModifier
{
    get
    {
        if (procedureCodeModifier != null)
        {
            return procedureCodeModifier;
        }

        procedureCodeModifier = new HL7V251Field
        {
            field = message[@"IIM"][15],
            Id = @"IIM.15",
            Type = @"Field",
            Position = @"IIM.15",
            Name = @"Procedure Code Modifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0340",
            TableName = @"Procedure code modifier",
            Description = @"This field contains the procedure code modifier to the procedure code reported in IIM-14 Procedure Code , when applicable. Procedure code modifiers are defined by USA regulatory agencies such as CMS and the AMA. Multiple modifiers may be reported. Refer to User-defined Table 0340 - Procedure code modifier for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (procedureCodeModifier.field.FieldRepetitions != null && procedureCodeModifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureCodeModifier.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < procedureCodeModifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = procedureCodeModifier.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < procedureCodeModifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = procedureCodeModifier.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < procedureCodeModifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = procedureCodeModifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            procedureCodeModifier.fieldRepetitions = fieldRepetitions;
        }

        return procedureCodeModifier;
    } 
}
    }
}
