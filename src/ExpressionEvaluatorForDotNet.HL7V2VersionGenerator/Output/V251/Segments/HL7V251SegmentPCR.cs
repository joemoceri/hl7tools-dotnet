using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentPCR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PCR"; } }

        public string SegmentId { get { return @"PCR"; } }
        
        public string LongName { get { return @"Possible Causal Relationship"; } }
        
        public string Description { get { return @"The PCR segment is used to communicate a potential or suspected relationship between a product (drug or device) or test and an event with detrimental effect on a patient. This segment identifies a potential causal relationship between the product identified in this segment and the event identified in the PEO segment."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

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
                            Id = @"PCR.1",
                            Type = @"Field",
                            Position = @"PCR.1",
                            Name = @"Implicated Product",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the coded identity of the product (drug, device, etc.) which is possibly causally related to the event. Includes the product identity number such as NDC, model or catalogue numbers. If a coded value is not available for the product a text description can be included as the second component of the CE data.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.1.1",
                            Type = @"Component",
                            Position = @"PCR.1.1",
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
                            Id = @"PCR.1.2",
                            Type = @"Component",
                            Position = @"PCR.1.2",
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
                            Id = @"PCR.1.3",
                            Type = @"Component",
                            Position = @"PCR.1.3",
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
                            Id = @"PCR.1.4",
                            Type = @"Component",
                            Position = @"PCR.1.4",
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
                            Id = @"PCR.1.5",
                            Type = @"Component",
                            Position = @"PCR.1.5",
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
                            Id = @"PCR.1.6",
                            Type = @"Component",
                            Position = @"PCR.1.6",
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
                            Id = @"PCR.2",
                            Type = @"Field",
                            Position = @"PCR.2",
                            Name = @"Generic Product",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0249",
                            TableName = @"Generic Product",
                            Description = @"This field indicates whether the product used was a generic or a branded product. Refer to User-defined Table 0249 - Generic product for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.3",
                            Type = @"Field",
                            Position = @"PCR.3",
                            Name = @"Product Class",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the coded classification of the implicated product. For drugs, this would usually be the drug class - calcium channel blocking agents for nifedipine for example. For other products it would be the generic type of device, e.g., urinary catheter, cardiac pacemaker. If a coded value is not available for the class, a text description can be included.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.3.1",
                            Type = @"Component",
                            Position = @"PCR.3.1",
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
                            Id = @"PCR.3.2",
                            Type = @"Component",
                            Position = @"PCR.3.2",
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
                            Id = @"PCR.3.3",
                            Type = @"Component",
                            Position = @"PCR.3.3",
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
                            Id = @"PCR.3.4",
                            Type = @"Component",
                            Position = @"PCR.3.4",
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
                            Id = @"PCR.3.5",
                            Type = @"Component",
                            Position = @"PCR.3.5",
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
                            Id = @"PCR.3.6",
                            Type = @"Component",
                            Position = @"PCR.3.6",
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
                            Id = @"PCR.4",
                            Type = @"Field",
                            Position = @"PCR.4",
                            Name = @"Total Duration Of Therapy",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field represents the total duration of therapy with product listed. The treatment at the current dose and schedule are indicted in the quantity timing attribute of the RXE segment but the patient may have been treated for some time previously at a different dose or on a different schedule. The quantity in the second component of the CQ should be a time quantity.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.4.1",
                            Type = @"Component",
                            Position = @"PCR.4.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.4.2",
                            Type = @"Component",
                            Position = @"PCR.4.2",
                            Name = @"Units",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.4.2.1",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.1",
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
                            Id = @"PCR.4.2.2",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.2",
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
                            Id = @"PCR.4.2.3",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.3",
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
                            Id = @"PCR.4.2.4",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.4",
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
                            Id = @"PCR.4.2.5",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.5",
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
                            Id = @"PCR.4.2.6",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.5",
                            Type = @"Field",
                            Position = @"PCR.5",
                            Name = @"Product Manufacture Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the date the product was manufactured.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.5.1",
                            Type = @"Component",
                            Position = @"PCR.5.1",
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
                            Id = @"PCR.5.2",
                            Type = @"Component",
                            Position = @"PCR.5.2",
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
                            Id = @"PCR.6",
                            Type = @"Field",
                            Position = @"PCR.6",
                            Name = @"Product Expiration Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the expiration date indicated on the product packaging.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.6.1",
                            Type = @"Component",
                            Position = @"PCR.6.1",
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
                            Id = @"PCR.6.2",
                            Type = @"Component",
                            Position = @"PCR.6.2",
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
                            Id = @"PCR.7",
                            Type = @"Field",
                            Position = @"PCR.7",
                            Name = @"Product Implantation Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"If an implantable medical device, this field identifies the date device was implanted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.7.1",
                            Type = @"Component",
                            Position = @"PCR.7.1",
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
                            Id = @"PCR.7.2",
                            Type = @"Component",
                            Position = @"PCR.7.2",
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
                            Id = @"PCR.8",
                            Type = @"Field",
                            Position = @"PCR.8",
                            Name = @"Product Explantation Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"If an implantable medical device and it was removed, the field identifies the date it was removed.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.8.1",
                            Type = @"Component",
                            Position = @"PCR.8.1",
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
                            Id = @"PCR.8.2",
                            Type = @"Component",
                            Position = @"PCR.8.2",
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
                            Id = @"PCR.9",
                            Type = @"Field",
                            Position = @"PCR.9",
                            Name = @"Single Use Device",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0244",
                            TableName = @"Single Use Device",
                            Description = @"This field indicates whether the product was designed for a single use. Refer to User-defined Table 0244 - Single use device for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.10",
                            Type = @"Field",
                            Position = @"PCR.10",
                            Name = @"Indication For Product Use",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains coded representation of the problem or diagnosis for which the product was used.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.10.1",
                            Type = @"Component",
                            Position = @"PCR.10.1",
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
                            Id = @"PCR.10.2",
                            Type = @"Component",
                            Position = @"PCR.10.2",
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
                            Id = @"PCR.10.3",
                            Type = @"Component",
                            Position = @"PCR.10.3",
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
                            Id = @"PCR.10.4",
                            Type = @"Component",
                            Position = @"PCR.10.4",
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
                            Id = @"PCR.10.5",
                            Type = @"Component",
                            Position = @"PCR.10.5",
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
                            Id = @"PCR.10.6",
                            Type = @"Component",
                            Position = @"PCR.10.6",
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
                            Id = @"PCR.11",
                            Type = @"Field",
                            Position = @"PCR.11",
                            Name = @"Product Problem",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0245",
                            TableName = @"Product Problem",
                            Description = @"A product problem would exist if a product malfunction could lead to death or serious injury. Refer to User-defined Table 0245 - Product problem for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.12",
                            Type = @"Field",
                            Position = @"PCR.12",
                            Name = @"Product Serial/Lot Number",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is an alphanumeric descriptor which identifies the specific item or lot of drug. This descriptor would normally be obtained from the package labeling or item itself.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.13",
                            Type = @"Field",
                            Position = @"PCR.13",
                            Name = @"Product Available For Inspection",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0246",
                            TableName = @"Product Available for Inspection",
                            Description = @"This field indicates that the product is available for analysis. User-defined Table 0246 -Product available for inspection is used as the HL7 identifier for the user-defined table of values for this field . If the product was returned to the manufacturer, this would be indicated by including the date it was returned in the date product returned to manufacturer element.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.14",
                            Type = @"Field",
                            Position = @"PCR.14",
                            Name = @"Product Evaluation Performed",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the type of product evaluation performed. The evaluation codes listed in SubPart B of the Coding Manual for FDA Form 3500A, Type of Evaluation Performed may be used. If no codes are available, text may be sent in the second component of the field.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.14.1",
                            Type = @"Component",
                            Position = @"PCR.14.1",
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
                            Id = @"PCR.14.2",
                            Type = @"Component",
                            Position = @"PCR.14.2",
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
                            Id = @"PCR.14.3",
                            Type = @"Component",
                            Position = @"PCR.14.3",
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
                            Id = @"PCR.14.4",
                            Type = @"Component",
                            Position = @"PCR.14.4",
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
                            Id = @"PCR.14.5",
                            Type = @"Component",
                            Position = @"PCR.14.5",
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
                            Id = @"PCR.14.6",
                            Type = @"Component",
                            Position = @"PCR.14.6",
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
                            Id = @"PCR.15",
                            Type = @"Field",
                            Position = @"PCR.15",
                            Name = @"Product Evaluation Status",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0247",
                            TableName = @"Status of Evaluation",
                            Description = @"This field identifies the status of product evaluation. Subpart A Item H.3 of the Coding Manual for FDA Form 3500A may also be used. If no codes are available, text may be sent in the second component of the field. Refer to HL7 Table 0247 - Status of evaluation for valid values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.15.1",
                            Type = @"Component",
                            Position = @"PCR.15.1",
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
                            Id = @"PCR.15.2",
                            Type = @"Component",
                            Position = @"PCR.15.2",
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
                            Id = @"PCR.15.3",
                            Type = @"Component",
                            Position = @"PCR.15.3",
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
                            Id = @"PCR.15.4",
                            Type = @"Component",
                            Position = @"PCR.15.4",
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
                            Id = @"PCR.15.5",
                            Type = @"Component",
                            Position = @"PCR.15.5",
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
                            Id = @"PCR.15.6",
                            Type = @"Component",
                            Position = @"PCR.15.6",
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
                            Id = @"PCR.16",
                            Type = @"Field",
                            Position = @"PCR.16",
                            Name = @"Product Evaluation Results",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the results of the product evaluation.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.16.1",
                            Type = @"Component",
                            Position = @"PCR.16.1",
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
                            Id = @"PCR.16.2",
                            Type = @"Component",
                            Position = @"PCR.16.2",
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
                            Id = @"PCR.16.3",
                            Type = @"Component",
                            Position = @"PCR.16.3",
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
                            Id = @"PCR.16.4",
                            Type = @"Component",
                            Position = @"PCR.16.4",
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
                            Id = @"PCR.16.5",
                            Type = @"Component",
                            Position = @"PCR.16.5",
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
                            Id = @"PCR.16.6",
                            Type = @"Component",
                            Position = @"PCR.16.6",
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
                            Id = @"PCR.17",
                            Type = @"Field",
                            Position = @"PCR.17",
                            Name = @"Evaluated Product Source",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0248",
                            TableName = @"Product source",
                            Description = @"This field contains the source of the product evaluated. Refer to HL7 Table 0248 - Product source for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.18",
                            Type = @"Field",
                            Position = @"PCR.18",
                            Name = @"Date Product Returned To Manufacturer",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"If the product was returned to the manufacturer, this field contains the date it was returned may be reported.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.18.1",
                            Type = @"Component",
                            Position = @"PCR.18.1",
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
                            Id = @"PCR.18.2",
                            Type = @"Component",
                            Position = @"PCR.18.2",
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
                            Id = @"PCR.19",
                            Type = @"Field",
                            Position = @"PCR.19",
                            Name = @"Device Operator Qualifications",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0242",
                            TableName = @"Primary Observer's Qualification",
                            Description = @"This field identifies the qualification of the person operating the device when the event occurred. Refer to HL7 Table 0242 - Primary observers qualification for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.20",
                            Type = @"Field",
                            Position = @"PCR.20",
                            Name = @"Relatedness Assessment",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0250",
                            TableName = @"Relatedness Assessment",
                            Description = @"This field represents the assessment of relatedness of the product to the event. Refer to HL7 Table 0250 - Relatedness assessment for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.21",
                            Type = @"Field",
                            Position = @"PCR.21",
                            Name = @"Action Taken In Response To The Event",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"6",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0251",
                            TableName = @"Action Taken in Response to the Event",
                            Description = @"This field indicates the action taken as a result of the event. Segment may repeat if multiple categories of evidence are relevant. Refer to HL7 Table 0251 - Action taken in response to the event for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.22",
                            Type = @"Field",
                            Position = @"PCR.22",
                            Name = @"Event Causality Observations",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"6",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0252",
                            TableName = @"Causality Observations",
                            Description = @"This field contains observations made about the event which may bear on causality. Refer to HL7 Table 0252 - Causality observations for valid values. Segment may repeat if multiple categories of evidence are relevant.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.23",
                            Type = @"Field",
                            Position = @"PCR.23",
                            Name = @"Indirect Exposure Mechanism",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0253",
                            TableName = @"Indirect exposure mechanism",
                            Description = @"The patient identified in the PID segment, who experienced the event, might have been exposed to the potential causal product via an intermediary, e.g., a child might be exposed to a product through the placenta or in breast milk, or a transfusion recipient might be exposed via a blood product. If this is the case, the mechanism of product transmission is identified in this field, using the valid values in HL7 Table 0253 - Indirect exposure mechanism . If this field is populated, the identity of the person through whom the product was transmitted is contained in NK1 and RXE segments which follow.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V251SegmentPCR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field implicatedProduct;

public HL7V251Field ImplicatedProduct
{
    get
    {
        if (implicatedProduct != null)
        {
            return implicatedProduct;
        }

        implicatedProduct = new HL7V251Field
        {
            field = message[@"PCR"][1],
            Id = @"PCR.1",
            Type = @"Field",
            Position = @"PCR.1",
            Name = @"Implicated Product",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the coded identity of the product (drug, device, etc.) which is possibly causally related to the event. Includes the product identity number such as NDC, model or catalogue numbers. If a coded value is not available for the product a text description can be included as the second component of the CE data.",
            Sample = @"",
        };

        // check for repetitions
        if (implicatedProduct.field.FieldRepetitions != null && implicatedProduct.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(implicatedProduct.Id));
            implicatedProduct.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(implicatedProduct, fieldData);
        }

        return implicatedProduct;
    } 
}

internal HL7V251Field genericProduct;

public HL7V251Field GenericProduct
{
    get
    {
        if (genericProduct != null)
        {
            return genericProduct;
        }

        genericProduct = new HL7V251Field
        {
            field = message[@"PCR"][2],
            Id = @"PCR.2",
            Type = @"Field",
            Position = @"PCR.2",
            Name = @"Generic Product",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0249",
            TableName = @"Generic Product",
            Description = @"This field indicates whether the product used was a generic or a branded product. Refer to User-defined Table 0249 - Generic product for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (genericProduct.field.FieldRepetitions != null && genericProduct.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(genericProduct.Id));
            genericProduct.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(genericProduct, fieldData);
        }

        return genericProduct;
    } 
}

internal HL7V251Field productClass;

public HL7V251Field ProductClass
{
    get
    {
        if (productClass != null)
        {
            return productClass;
        }

        productClass = new HL7V251Field
        {
            field = message[@"PCR"][3],
            Id = @"PCR.3",
            Type = @"Field",
            Position = @"PCR.3",
            Name = @"Product Class",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the coded classification of the implicated product. For drugs, this would usually be the drug class - calcium channel blocking agents for nifedipine for example. For other products it would be the generic type of device, e.g., urinary catheter, cardiac pacemaker. If a coded value is not available for the class, a text description can be included.",
            Sample = @"",
        };

        // check for repetitions
        if (productClass.field.FieldRepetitions != null && productClass.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productClass.Id));
            productClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(productClass, fieldData);
        }

        return productClass;
    } 
}

internal HL7V251Field totalDurationOfTherapy;

public HL7V251Field TotalDurationOfTherapy
{
    get
    {
        if (totalDurationOfTherapy != null)
        {
            return totalDurationOfTherapy;
        }

        totalDurationOfTherapy = new HL7V251Field
        {
            field = message[@"PCR"][4],
            Id = @"PCR.4",
            Type = @"Field",
            Position = @"PCR.4",
            Name = @"Total Duration Of Therapy",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field represents the total duration of therapy with product listed. The treatment at the current dose and schedule are indicted in the quantity timing attribute of the RXE segment but the patient may have been treated for some time previously at a different dose or on a different schedule. The quantity in the second component of the CQ should be a time quantity.",
            Sample = @"",
        };

        // check for repetitions
        if (totalDurationOfTherapy.field.FieldRepetitions != null && totalDurationOfTherapy.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(totalDurationOfTherapy.Id));
            totalDurationOfTherapy.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(totalDurationOfTherapy, fieldData);
        }

        return totalDurationOfTherapy;
    } 
}

internal HL7V251Field productManufactureDate;

public HL7V251Field ProductManufactureDate
{
    get
    {
        if (productManufactureDate != null)
        {
            return productManufactureDate;
        }

        productManufactureDate = new HL7V251Field
        {
            field = message[@"PCR"][5],
            Id = @"PCR.5",
            Type = @"Field",
            Position = @"PCR.5",
            Name = @"Product Manufacture Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the date the product was manufactured.",
            Sample = @"",
        };

        // check for repetitions
        if (productManufactureDate.field.FieldRepetitions != null && productManufactureDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productManufactureDate.Id));
            productManufactureDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(productManufactureDate, fieldData);
        }

        return productManufactureDate;
    } 
}

internal HL7V251Field productExpirationDate;

public HL7V251Field ProductExpirationDate
{
    get
    {
        if (productExpirationDate != null)
        {
            return productExpirationDate;
        }

        productExpirationDate = new HL7V251Field
        {
            field = message[@"PCR"][6],
            Id = @"PCR.6",
            Type = @"Field",
            Position = @"PCR.6",
            Name = @"Product Expiration Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date indicated on the product packaging.",
            Sample = @"",
        };

        // check for repetitions
        if (productExpirationDate.field.FieldRepetitions != null && productExpirationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productExpirationDate.Id));
            productExpirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(productExpirationDate, fieldData);
        }

        return productExpirationDate;
    } 
}

internal HL7V251Field productImplantationDate;

public HL7V251Field ProductImplantationDate
{
    get
    {
        if (productImplantationDate != null)
        {
            return productImplantationDate;
        }

        productImplantationDate = new HL7V251Field
        {
            field = message[@"PCR"][7],
            Id = @"PCR.7",
            Type = @"Field",
            Position = @"PCR.7",
            Name = @"Product Implantation Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If an implantable medical device, this field identifies the date device was implanted.",
            Sample = @"",
        };

        // check for repetitions
        if (productImplantationDate.field.FieldRepetitions != null && productImplantationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productImplantationDate.Id));
            productImplantationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(productImplantationDate, fieldData);
        }

        return productImplantationDate;
    } 
}

internal HL7V251Field productExplantationDate;

public HL7V251Field ProductExplantationDate
{
    get
    {
        if (productExplantationDate != null)
        {
            return productExplantationDate;
        }

        productExplantationDate = new HL7V251Field
        {
            field = message[@"PCR"][8],
            Id = @"PCR.8",
            Type = @"Field",
            Position = @"PCR.8",
            Name = @"Product Explantation Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If an implantable medical device and it was removed, the field identifies the date it was removed.",
            Sample = @"",
        };

        // check for repetitions
        if (productExplantationDate.field.FieldRepetitions != null && productExplantationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productExplantationDate.Id));
            productExplantationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(productExplantationDate, fieldData);
        }

        return productExplantationDate;
    } 
}

internal HL7V251Field singleUseDevice;

public HL7V251Field SingleUseDevice
{
    get
    {
        if (singleUseDevice != null)
        {
            return singleUseDevice;
        }

        singleUseDevice = new HL7V251Field
        {
            field = message[@"PCR"][9],
            Id = @"PCR.9",
            Type = @"Field",
            Position = @"PCR.9",
            Name = @"Single Use Device",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0244",
            TableName = @"Single Use Device",
            Description = @"This field indicates whether the product was designed for a single use. Refer to User-defined Table 0244 - Single use device for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (singleUseDevice.field.FieldRepetitions != null && singleUseDevice.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(singleUseDevice.Id));
            singleUseDevice.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(singleUseDevice, fieldData);
        }

        return singleUseDevice;
    } 
}

internal HL7V251Field indicationForProductUse;

public HL7V251Field IndicationForProductUse
{
    get
    {
        if (indicationForProductUse != null)
        {
            return indicationForProductUse;
        }

        indicationForProductUse = new HL7V251Field
        {
            field = message[@"PCR"][10],
            Id = @"PCR.10",
            Type = @"Field",
            Position = @"PCR.10",
            Name = @"Indication For Product Use",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains coded representation of the problem or diagnosis for which the product was used.",
            Sample = @"",
        };

        // check for repetitions
        if (indicationForProductUse.field.FieldRepetitions != null && indicationForProductUse.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(indicationForProductUse.Id));
            indicationForProductUse.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(indicationForProductUse, fieldData);
        }

        return indicationForProductUse;
    } 
}

internal HL7V251Field productProblem;

public HL7V251Field ProductProblem
{
    get
    {
        if (productProblem != null)
        {
            return productProblem;
        }

        productProblem = new HL7V251Field
        {
            field = message[@"PCR"][11],
            Id = @"PCR.11",
            Type = @"Field",
            Position = @"PCR.11",
            Name = @"Product Problem",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0245",
            TableName = @"Product Problem",
            Description = @"A product problem would exist if a product malfunction could lead to death or serious injury. Refer to User-defined Table 0245 - Product problem for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (productProblem.field.FieldRepetitions != null && productProblem.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productProblem.Id));
            productProblem.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(productProblem, fieldData);
        }

        return productProblem;
    } 
}

internal HL7V251Field productSerialLotNumber;

public HL7V251Field ProductSerialLotNumber
{
    get
    {
        if (productSerialLotNumber != null)
        {
            return productSerialLotNumber;
        }

        productSerialLotNumber = new HL7V251Field
        {
            field = message[@"PCR"][12],
            Id = @"PCR.12",
            Type = @"Field",
            Position = @"PCR.12",
            Name = @"Product Serial/Lot Number",
            Length = 30,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is an alphanumeric descriptor which identifies the specific item or lot of drug. This descriptor would normally be obtained from the package labeling or item itself.",
            Sample = @"",
        };

        // check for repetitions
        if (productSerialLotNumber.field.FieldRepetitions != null && productSerialLotNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productSerialLotNumber.Id));
            productSerialLotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(productSerialLotNumber, fieldData);
        }

        return productSerialLotNumber;
    } 
}

internal HL7V251Field productAvailableForInspection;

public HL7V251Field ProductAvailableForInspection
{
    get
    {
        if (productAvailableForInspection != null)
        {
            return productAvailableForInspection;
        }

        productAvailableForInspection = new HL7V251Field
        {
            field = message[@"PCR"][13],
            Id = @"PCR.13",
            Type = @"Field",
            Position = @"PCR.13",
            Name = @"Product Available For Inspection",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0246",
            TableName = @"Product Available for Inspection",
            Description = @"This field indicates that the product is available for analysis. User-defined Table 0246 -Product available for inspection is used as the HL7 identifier for the user-defined table of values for this field . If the product was returned to the manufacturer, this would be indicated by including the date it was returned in the date product returned to manufacturer element.",
            Sample = @"",
        };

        // check for repetitions
        if (productAvailableForInspection.field.FieldRepetitions != null && productAvailableForInspection.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productAvailableForInspection.Id));
            productAvailableForInspection.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(productAvailableForInspection, fieldData);
        }

        return productAvailableForInspection;
    } 
}

internal HL7V251Field productEvaluationPerformed;

public HL7V251Field ProductEvaluationPerformed
{
    get
    {
        if (productEvaluationPerformed != null)
        {
            return productEvaluationPerformed;
        }

        productEvaluationPerformed = new HL7V251Field
        {
            field = message[@"PCR"][14],
            Id = @"PCR.14",
            Type = @"Field",
            Position = @"PCR.14",
            Name = @"Product Evaluation Performed",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the type of product evaluation performed. The evaluation codes listed in SubPart B of the Coding Manual for FDA Form 3500A, Type of Evaluation Performed may be used. If no codes are available, text may be sent in the second component of the field.",
            Sample = @"",
        };

        // check for repetitions
        if (productEvaluationPerformed.field.FieldRepetitions != null && productEvaluationPerformed.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productEvaluationPerformed.Id));
            productEvaluationPerformed.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(productEvaluationPerformed, fieldData);
        }

        return productEvaluationPerformed;
    } 
}

internal HL7V251Field productEvaluationStatus;

public HL7V251Field ProductEvaluationStatus
{
    get
    {
        if (productEvaluationStatus != null)
        {
            return productEvaluationStatus;
        }

        productEvaluationStatus = new HL7V251Field
        {
            field = message[@"PCR"][15],
            Id = @"PCR.15",
            Type = @"Field",
            Position = @"PCR.15",
            Name = @"Product Evaluation Status",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0247",
            TableName = @"Status of Evaluation",
            Description = @"This field identifies the status of product evaluation. Subpart A Item H.3 of the Coding Manual for FDA Form 3500A may also be used. If no codes are available, text may be sent in the second component of the field. Refer to HL7 Table 0247 - Status of evaluation for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (productEvaluationStatus.field.FieldRepetitions != null && productEvaluationStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productEvaluationStatus.Id));
            productEvaluationStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(productEvaluationStatus, fieldData);
        }

        return productEvaluationStatus;
    } 
}

internal HL7V251Field productEvaluationResults;

public HL7V251Field ProductEvaluationResults
{
    get
    {
        if (productEvaluationResults != null)
        {
            return productEvaluationResults;
        }

        productEvaluationResults = new HL7V251Field
        {
            field = message[@"PCR"][16],
            Id = @"PCR.16",
            Type = @"Field",
            Position = @"PCR.16",
            Name = @"Product Evaluation Results",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the results of the product evaluation.",
            Sample = @"",
        };

        // check for repetitions
        if (productEvaluationResults.field.FieldRepetitions != null && productEvaluationResults.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productEvaluationResults.Id));
            productEvaluationResults.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(productEvaluationResults, fieldData);
        }

        return productEvaluationResults;
    } 
}

internal HL7V251Field evaluatedProductSource;

public HL7V251Field EvaluatedProductSource
{
    get
    {
        if (evaluatedProductSource != null)
        {
            return evaluatedProductSource;
        }

        evaluatedProductSource = new HL7V251Field
        {
            field = message[@"PCR"][17],
            Id = @"PCR.17",
            Type = @"Field",
            Position = @"PCR.17",
            Name = @"Evaluated Product Source",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0248",
            TableName = @"Product source",
            Description = @"This field contains the source of the product evaluated. Refer to HL7 Table 0248 - Product source for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (evaluatedProductSource.field.FieldRepetitions != null && evaluatedProductSource.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(evaluatedProductSource.Id));
            evaluatedProductSource.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(evaluatedProductSource, fieldData);
        }

        return evaluatedProductSource;
    } 
}

internal HL7V251Field dateProductReturnedToManufacturer;

public HL7V251Field DateProductReturnedToManufacturer
{
    get
    {
        if (dateProductReturnedToManufacturer != null)
        {
            return dateProductReturnedToManufacturer;
        }

        dateProductReturnedToManufacturer = new HL7V251Field
        {
            field = message[@"PCR"][18],
            Id = @"PCR.18",
            Type = @"Field",
            Position = @"PCR.18",
            Name = @"Date Product Returned To Manufacturer",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If the product was returned to the manufacturer, this field contains the date it was returned may be reported.",
            Sample = @"",
        };

        // check for repetitions
        if (dateProductReturnedToManufacturer.field.FieldRepetitions != null && dateProductReturnedToManufacturer.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateProductReturnedToManufacturer.Id));
            dateProductReturnedToManufacturer.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(dateProductReturnedToManufacturer, fieldData);
        }

        return dateProductReturnedToManufacturer;
    } 
}

internal HL7V251Field deviceOperatorQualifications;

public HL7V251Field DeviceOperatorQualifications
{
    get
    {
        if (deviceOperatorQualifications != null)
        {
            return deviceOperatorQualifications;
        }

        deviceOperatorQualifications = new HL7V251Field
        {
            field = message[@"PCR"][19],
            Id = @"PCR.19",
            Type = @"Field",
            Position = @"PCR.19",
            Name = @"Device Operator Qualifications",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0242",
            TableName = @"Primary Observer's Qualification",
            Description = @"This field identifies the qualification of the person operating the device when the event occurred. Refer to HL7 Table 0242 - Primary observers qualification for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (deviceOperatorQualifications.field.FieldRepetitions != null && deviceOperatorQualifications.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(deviceOperatorQualifications.Id));
            deviceOperatorQualifications.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(deviceOperatorQualifications, fieldData);
        }

        return deviceOperatorQualifications;
    } 
}

internal HL7V251Field relatednessAssessment;

public HL7V251Field RelatednessAssessment
{
    get
    {
        if (relatednessAssessment != null)
        {
            return relatednessAssessment;
        }

        relatednessAssessment = new HL7V251Field
        {
            field = message[@"PCR"][20],
            Id = @"PCR.20",
            Type = @"Field",
            Position = @"PCR.20",
            Name = @"Relatedness Assessment",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0250",
            TableName = @"Relatedness Assessment",
            Description = @"This field represents the assessment of relatedness of the product to the event. Refer to HL7 Table 0250 - Relatedness assessment for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (relatednessAssessment.field.FieldRepetitions != null && relatednessAssessment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(relatednessAssessment.Id));
            relatednessAssessment.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(relatednessAssessment, fieldData);
        }

        return relatednessAssessment;
    } 
}

internal HL7V251Field actionTakenInResponseToTheEvent;

public HL7V251Field ActionTakenInResponseToTheEvent
{
    get
    {
        if (actionTakenInResponseToTheEvent != null)
        {
            return actionTakenInResponseToTheEvent;
        }

        actionTakenInResponseToTheEvent = new HL7V251Field
        {
            field = message[@"PCR"][21],
            Id = @"PCR.21",
            Type = @"Field",
            Position = @"PCR.21",
            Name = @"Action Taken In Response To The Event",
            Length = 2,
            Usage = @"O",
            Rpt = @"6",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0251",
            TableName = @"Action Taken in Response to the Event",
            Description = @"This field indicates the action taken as a result of the event. Segment may repeat if multiple categories of evidence are relevant. Refer to HL7 Table 0251 - Action taken in response to the event for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (actionTakenInResponseToTheEvent.field.FieldRepetitions != null && actionTakenInResponseToTheEvent.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(actionTakenInResponseToTheEvent.Id));
            actionTakenInResponseToTheEvent.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(actionTakenInResponseToTheEvent, fieldData);
        }

        return actionTakenInResponseToTheEvent;
    } 
}

internal HL7V251Field eventCausalityObservations;

public HL7V251Field EventCausalityObservations
{
    get
    {
        if (eventCausalityObservations != null)
        {
            return eventCausalityObservations;
        }

        eventCausalityObservations = new HL7V251Field
        {
            field = message[@"PCR"][22],
            Id = @"PCR.22",
            Type = @"Field",
            Position = @"PCR.22",
            Name = @"Event Causality Observations",
            Length = 2,
            Usage = @"O",
            Rpt = @"6",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0252",
            TableName = @"Causality Observations",
            Description = @"This field contains observations made about the event which may bear on causality. Refer to HL7 Table 0252 - Causality observations for valid values. Segment may repeat if multiple categories of evidence are relevant.",
            Sample = @"",
        };

        // check for repetitions
        if (eventCausalityObservations.field.FieldRepetitions != null && eventCausalityObservations.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventCausalityObservations.Id));
            eventCausalityObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(eventCausalityObservations, fieldData);
        }

        return eventCausalityObservations;
    } 
}

internal HL7V251Field indirectExposureMechanism;

public HL7V251Field IndirectExposureMechanism
{
    get
    {
        if (indirectExposureMechanism != null)
        {
            return indirectExposureMechanism;
        }

        indirectExposureMechanism = new HL7V251Field
        {
            field = message[@"PCR"][23],
            Id = @"PCR.23",
            Type = @"Field",
            Position = @"PCR.23",
            Name = @"Indirect Exposure Mechanism",
            Length = 1,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0253",
            TableName = @"Indirect exposure mechanism",
            Description = @"The patient identified in the PID segment, who experienced the event, might have been exposed to the potential causal product via an intermediary, e.g., a child might be exposed to a product through the placenta or in breast milk, or a transfusion recipient might be exposed via a blood product. If this is the case, the mechanism of product transmission is identified in this field, using the valid values in HL7 Table 0253 - Indirect exposure mechanism . If this field is populated, the identity of the person through whom the product was transmitted is contained in NK1 and RXE segments which follow.",
            Sample = @"",
        };

        // check for repetitions
        if (indirectExposureMechanism.field.FieldRepetitions != null && indirectExposureMechanism.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(indirectExposureMechanism.Id));
            indirectExposureMechanism.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(indirectExposureMechanism, fieldData);
        }

        return indirectExposureMechanism;
    } 
}
    }
}
