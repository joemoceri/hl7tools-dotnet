using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentUB2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB2"; } }

        public string SegmentId { get { return @"UB2"; } }
        
        public string LongName { get { return @"UB92 Data"; } }
        
        public string Description { get { return @"The UB2 segment contains data necessary to complete UB92 bills specific to the United States; other realms may choose to implement using regional code sets. Only UB82 and UB92 fields that do not exist in other HL7 defined segments appear in this segment.  Just as with the UB82 billing, Patient Name and Date of Birth are required; they are included in the PID segment and therefore do not appear here. When the field locators are different on the UB92, as compared to the UB82, the element is listed with its new location in parentheses ( ). The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.

The Uniform Billing segments are specific to the US and may not be implemented in non-US systems."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Id = @"UB2.1",
                            Type = @"Field",
                            Position = @"UB2.1",
                            Name = @"Set ID - UB2",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.2",
                            Type = @"Field",
                            Position = @"UB2.2",
                            Name = @"Co-Insurance Days (9)",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of inpatient days exceeding defined benefit coverage. In the US, this corresponds to UB92 form locator 9. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.3",
                            Type = @"Field",
                            Position = @"UB2.3",
                            Name = @"Condition Code (24-30)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"7",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0043",
                            TableName = @"Condition Code",
                            Description = @"This field contains a code reporting conditions that may affect payer processing; for example, the condition is related to employment (Patient covered by insurance not reflected here, treatment of non-terminal condition for hospice patient). The code in this field can repeat up to seven times to correspond to UB92 form locators 24-30. Refer to User-defined Table 0043 - Condition Code for suggested values. Refer to a UB specification for additional information. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.4",
                            Type = @"Field",
                            Position = @"UB2.4",
                            Name = @"Covered Days (7)",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains UB92 field 7. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.5",
                            Type = @"Field",
                            Position = @"UB2.5",
                            Name = @"Non-Covered Days (8)",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains UB92 field 8. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6",
                            Type = @"Field",
                            Position = @"UB2.6",
                            Name = @"Value Amount and Code (39-41)",
                            Length = 41,
                            Usage = @"O",
                            Rpt = @"12",
                            DataType = @"UVC",
                            DataTypeName = @"UB Value Code and Amount",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a monetary amount and an associated billing code. The pair in this field can repeat up to twelve times to represent/contain UB92 form locators 39a, 39b, 39c, 39d, 40a, 40b, 40c, 40d, 41a, 41b, 41c, and 41d. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.6.1",
                            Type = @"Component",
                            Position = @"UB2.6.1",
                            Name = @"Value Code",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0153",
                            TableName = @"Value code",
                            Description = @"Specifies the National Uniform Billing Committee (NUBC) code itself.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.1",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.2",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. Its data type is string (ST). This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.3",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.4",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to Identifier in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.5",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage notes in section introduction for further description.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.6",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 in section 2.17.5 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.7",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.

Usage Note: If the coding system is any system other than an ""HL7 coding system,"" version ID must be valued with an actual version ID. If the coding system is ""HL7 coding system,"" version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.8",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component -6. It belongs conceptually to the group of Alternate components (see note 2.A.6.6) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.9",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.9",
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
                            Id = @"UB2.6.2",
                            Type = @"Component",
                            Position = @"UB2.6.2",
                            Name = @"Value Amount",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the numeric amount when needed to pair with the value.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.6.2.1",
                            Type = @"SubComponent",
                            Position = @"UB2.6.2.1",
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
                            Id = @"UB2.6.2.2",
                            Type = @"SubComponent",
                            Position = @"UB2.6.2.2",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7",
                            Type = @"Field",
                            Position = @"UB2.7",
                            Name = @"Occurrence Code and Date (32-35)",
                            Length = 259,
                            Usage = @"O",
                            Rpt = @"8",
                            DataType = @"OCD",
                            DataTypeName = @"Occurrence Code and Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The set of values in this field can repeat up to eight times. UB92 fields 32a, 32b, 33a, 33b, 34a, 34b, 35a, and 35b. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.7.1",
                            Type = @"Component",
                            Position = @"UB2.7.1",
                            Name = @"Occurrence Code",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0350",
                            TableName = @"Occurrence code",
                            Description = @"The NUBC code for the event or occurrence relating to a bill that may affect payer processing.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.1",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.2",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. Its data type is string (ST). This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.3",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.4",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to Identifier in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.5",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage notes in section introduction for further description.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.6",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 in section 2.17.5 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.7",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.

Usage Note: If the coding system is any system other than an ""HL7 coding system,"" version ID must be valued with an actual version ID. If the coding system is ""HL7 coding system,"" version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.8",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component -6. It belongs conceptually to the group of Alternate components (see note 2.A.6.6) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.9",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.9",
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
                            Id = @"UB2.7.2",
                            Type = @"Component",
                            Position = @"UB2.7.2",
                            Name = @"Occurrence Date",
                            Length = 8,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The date the event, relating to a bill that may affect payer processing, occurred.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8",
                            Type = @"Field",
                            Position = @"UB2.8",
                            Name = @"Occurrence Span Code/Dates (36)",
                            Length = 268,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"OSP",
                            DataTypeName = @"Occurrence Span Code and Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.8.1",
                            Type = @"Component",
                            Position = @"UB2.8.1",
                            Name = @"Occurrence Span Code",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0351",
                            TableName = @"Occurrence span",
                            Description = @"The date an event started that relates to the payment of a claim.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.1",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.2",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. Its data type is string (ST). This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.3",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.4",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to Identifier in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.5",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage notes in section introduction for further description.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.6",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 in section 2.17.5 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.7",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.

Usage Note: If the coding system is any system other than an ""HL7 coding system,"" version ID must be valued with an actual version ID. If the coding system is ""HL7 coding system,"" version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.8",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component -6. It belongs conceptually to the group of Alternate components (see note 2.A.6.6) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.9",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.9",
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
                            Id = @"UB2.8.2",
                            Type = @"Component",
                            Position = @"UB2.8.2",
                            Name = @"Occurrence Span Start Date",
                            Length = 8,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The date an event ended that relates to the payment of a claim.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.3",
                            Type = @"Component",
                            Position = @"UB2.8.3",
                            Name = @"Occurrence Span Stop Date",
                            Length = 8,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.9",
                            Type = @"Field",
                            Position = @"UB2.9",
                            Name = @"UB92 Locator 2 (State)",
                            Length = 29,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an occurrence span code and an associated date. This field can repeat up to two times to represent/contain UB92 form locators 36a and 36b. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.10",
                            Type = @"Field",
                            Position = @"UB2.10",
                            Name = @"UB92 Locator 11 (State)",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The value in this field may repeat up to two times.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.11",
                            Type = @"Field",
                            Position = @"UB2.11",
                            Name = @"UB92 Locator 31 (National)",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.12",
                            Type = @"Field",
                            Position = @"UB2.12",
                            Name = @"Document Control Number",
                            Length = 23,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number assigned by payor that is used for rebilling/adjustment purposes. It may repeat up to three times. Refer UB92 field 37",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.13",
                            Type = @"Field",
                            Position = @"UB2.13",
                            Name = @"UB92 Locator 49 (National)",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"23",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is defined by CMS or other regulatory agencies. This field may repeat up to twenty-three times.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.14",
                            Type = @"Field",
                            Position = @"UB2.14",
                            Name = @"UB92 Locator 56 (State)",
                            Length = 14,
                            Usage = @"O",
                            Rpt = @"5",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may repeat up to five times.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.15",
                            Type = @"Field",
                            Position = @"UB2.15",
                            Name = @"UB92 Locator 57 (National)",
                            Length = 27,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined by UB-92 CMS specification.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.16",
                            Type = @"Field",
                            Position = @"UB2.16",
                            Name = @"UB92 Locator 78 (State)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may repeat up to two times.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.17",
                            Type = @"Field",
                            Position = @"UB2.17",
                            Name = @"Special Visit Count",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the total number of special therapy visits.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V251SegmentUB2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field setIDUB2;

public HL7V251Field SetIDUB2
{
    get
    {
        if (setIDUB2 != null)
        {
            return setIDUB2;
        }

        setIDUB2 = new HL7V251Field
        {
            field = message[@"UB2"][1],
            Id = @"UB2.1",
            Type = @"Field",
            Position = @"UB2.1",
            Name = @"Set ID - UB2",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc.",
            Sample = @"",
        };

        // check for repetitions
        if (setIDUB2.field.FieldRepetitions != null && setIDUB2.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDUB2.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < setIDUB2.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = setIDUB2.field.FieldRepetitions[i],
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
                    for (var j = 0; j < setIDUB2.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = setIDUB2.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < setIDUB2.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = setIDUB2.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            setIDUB2.fieldRepetitions = fieldRepetitions;
        }

        return setIDUB2;
    } 
}

internal HL7V251Field coInsuranceDays9;

public HL7V251Field CoInsuranceDays9
{
    get
    {
        if (coInsuranceDays9 != null)
        {
            return coInsuranceDays9;
        }

        coInsuranceDays9 = new HL7V251Field
        {
            field = message[@"UB2"][2],
            Id = @"UB2.2",
            Type = @"Field",
            Position = @"UB2.2",
            Name = @"Co-Insurance Days (9)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of inpatient days exceeding defined benefit coverage. In the US, this corresponds to UB92 form locator 9. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (coInsuranceDays9.field.FieldRepetitions != null && coInsuranceDays9.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(coInsuranceDays9.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < coInsuranceDays9.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = coInsuranceDays9.field.FieldRepetitions[i],
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
                    for (var j = 0; j < coInsuranceDays9.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = coInsuranceDays9.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < coInsuranceDays9.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = coInsuranceDays9.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            coInsuranceDays9.fieldRepetitions = fieldRepetitions;
        }

        return coInsuranceDays9;
    } 
}

internal HL7V251Field conditionCode2430;

public HL7V251Field ConditionCode2430
{
    get
    {
        if (conditionCode2430 != null)
        {
            return conditionCode2430;
        }

        conditionCode2430 = new HL7V251Field
        {
            field = message[@"UB2"][3],
            Id = @"UB2.3",
            Type = @"Field",
            Position = @"UB2.3",
            Name = @"Condition Code (24-30)",
            Length = 2,
            Usage = @"O",
            Rpt = @"7",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0043",
            TableName = @"Condition Code",
            Description = @"This field contains a code reporting conditions that may affect payer processing; for example, the condition is related to employment (Patient covered by insurance not reflected here, treatment of non-terminal condition for hospice patient). The code in this field can repeat up to seven times to correspond to UB92 form locators 24-30. Refer to User-defined Table 0043 - Condition Code for suggested values. Refer to a UB specification for additional information. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (conditionCode2430.field.FieldRepetitions != null && conditionCode2430.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(conditionCode2430.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < conditionCode2430.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = conditionCode2430.field.FieldRepetitions[i],
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
                    for (var j = 0; j < conditionCode2430.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = conditionCode2430.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < conditionCode2430.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = conditionCode2430.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            conditionCode2430.fieldRepetitions = fieldRepetitions;
        }

        return conditionCode2430;
    } 
}

internal HL7V251Field coveredDays7;

public HL7V251Field CoveredDays7
{
    get
    {
        if (coveredDays7 != null)
        {
            return coveredDays7;
        }

        coveredDays7 = new HL7V251Field
        {
            field = message[@"UB2"][4],
            Id = @"UB2.4",
            Type = @"Field",
            Position = @"UB2.4",
            Name = @"Covered Days (7)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB92 field 7. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (coveredDays7.field.FieldRepetitions != null && coveredDays7.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(coveredDays7.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < coveredDays7.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = coveredDays7.field.FieldRepetitions[i],
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
                    for (var j = 0; j < coveredDays7.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = coveredDays7.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < coveredDays7.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = coveredDays7.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            coveredDays7.fieldRepetitions = fieldRepetitions;
        }

        return coveredDays7;
    } 
}

internal HL7V251Field nonCoveredDays8;

public HL7V251Field NonCoveredDays8
{
    get
    {
        if (nonCoveredDays8 != null)
        {
            return nonCoveredDays8;
        }

        nonCoveredDays8 = new HL7V251Field
        {
            field = message[@"UB2"][5],
            Id = @"UB2.5",
            Type = @"Field",
            Position = @"UB2.5",
            Name = @"Non-Covered Days (8)",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB92 field 8. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (nonCoveredDays8.field.FieldRepetitions != null && nonCoveredDays8.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nonCoveredDays8.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < nonCoveredDays8.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = nonCoveredDays8.field.FieldRepetitions[i],
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
                    for (var j = 0; j < nonCoveredDays8.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = nonCoveredDays8.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < nonCoveredDays8.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = nonCoveredDays8.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            nonCoveredDays8.fieldRepetitions = fieldRepetitions;
        }

        return nonCoveredDays8;
    } 
}

internal HL7V251Field valueAmountandCode3941;

public HL7V251Field ValueAmountandCode3941
{
    get
    {
        if (valueAmountandCode3941 != null)
        {
            return valueAmountandCode3941;
        }

        valueAmountandCode3941 = new HL7V251Field
        {
            field = message[@"UB2"][6],
            Id = @"UB2.6",
            Type = @"Field",
            Position = @"UB2.6",
            Name = @"Value Amount and Code (39-41)",
            Length = 41,
            Usage = @"O",
            Rpt = @"12",
            DataType = @"UVC",
            DataTypeName = @"UB Value Code and Amount",
            TableId = null,
            TableName = null,
            Description = @"This field contains a monetary amount and an associated billing code. The pair in this field can repeat up to twelve times to represent/contain UB92 form locators 39a, 39b, 39c, 39d, 40a, 40b, 40c, 40d, 41a, 41b, 41c, and 41d. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (valueAmountandCode3941.field.FieldRepetitions != null && valueAmountandCode3941.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(valueAmountandCode3941.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < valueAmountandCode3941.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = valueAmountandCode3941.field.FieldRepetitions[i],
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
                    for (var j = 0; j < valueAmountandCode3941.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = valueAmountandCode3941.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < valueAmountandCode3941.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = valueAmountandCode3941.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            valueAmountandCode3941.fieldRepetitions = fieldRepetitions;
        }

        return valueAmountandCode3941;
    } 
}

internal HL7V251Field occurrenceCodeandDate3235;

public HL7V251Field OccurrenceCodeandDate3235
{
    get
    {
        if (occurrenceCodeandDate3235 != null)
        {
            return occurrenceCodeandDate3235;
        }

        occurrenceCodeandDate3235 = new HL7V251Field
        {
            field = message[@"UB2"][7],
            Id = @"UB2.7",
            Type = @"Field",
            Position = @"UB2.7",
            Name = @"Occurrence Code and Date (32-35)",
            Length = 259,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"OCD",
            DataTypeName = @"Occurrence Code and Date",
            TableId = null,
            TableName = null,
            Description = @"The set of values in this field can repeat up to eight times. UB92 fields 32a, 32b, 33a, 33b, 34a, 34b, 35a, and 35b. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (occurrenceCodeandDate3235.field.FieldRepetitions != null && occurrenceCodeandDate3235.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(occurrenceCodeandDate3235.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < occurrenceCodeandDate3235.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = occurrenceCodeandDate3235.field.FieldRepetitions[i],
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
                    for (var j = 0; j < occurrenceCodeandDate3235.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = occurrenceCodeandDate3235.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < occurrenceCodeandDate3235.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = occurrenceCodeandDate3235.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            occurrenceCodeandDate3235.fieldRepetitions = fieldRepetitions;
        }

        return occurrenceCodeandDate3235;
    } 
}

internal HL7V251Field occurrenceSpanCodeDates36;

public HL7V251Field OccurrenceSpanCodeDates36
{
    get
    {
        if (occurrenceSpanCodeDates36 != null)
        {
            return occurrenceSpanCodeDates36;
        }

        occurrenceSpanCodeDates36 = new HL7V251Field
        {
            field = message[@"UB2"][8],
            Id = @"UB2.8",
            Type = @"Field",
            Position = @"UB2.8",
            Name = @"Occurrence Span Code/Dates (36)",
            Length = 268,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"OSP",
            DataTypeName = @"Occurrence Span Code and Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (occurrenceSpanCodeDates36.field.FieldRepetitions != null && occurrenceSpanCodeDates36.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(occurrenceSpanCodeDates36.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < occurrenceSpanCodeDates36.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = occurrenceSpanCodeDates36.field.FieldRepetitions[i],
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
                    for (var j = 0; j < occurrenceSpanCodeDates36.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = occurrenceSpanCodeDates36.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < occurrenceSpanCodeDates36.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = occurrenceSpanCodeDates36.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            occurrenceSpanCodeDates36.fieldRepetitions = fieldRepetitions;
        }

        return occurrenceSpanCodeDates36;
    } 
}

internal HL7V251Field uB92Locator2State;

public HL7V251Field UB92Locator2State
{
    get
    {
        if (uB92Locator2State != null)
        {
            return uB92Locator2State;
        }

        uB92Locator2State = new HL7V251Field
        {
            field = message[@"UB2"][9],
            Id = @"UB2.9",
            Type = @"Field",
            Position = @"UB2.9",
            Name = @"UB92 Locator 2 (State)",
            Length = 29,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains an occurrence span code and an associated date. This field can repeat up to two times to represent/contain UB92 form locators 36a and 36b. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (uB92Locator2State.field.FieldRepetitions != null && uB92Locator2State.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uB92Locator2State.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < uB92Locator2State.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = uB92Locator2State.field.FieldRepetitions[i],
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
                    for (var j = 0; j < uB92Locator2State.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = uB92Locator2State.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < uB92Locator2State.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = uB92Locator2State.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            uB92Locator2State.fieldRepetitions = fieldRepetitions;
        }

        return uB92Locator2State;
    } 
}

internal HL7V251Field uB92Locator11State;

public HL7V251Field UB92Locator11State
{
    get
    {
        if (uB92Locator11State != null)
        {
            return uB92Locator11State;
        }

        uB92Locator11State = new HL7V251Field
        {
            field = message[@"UB2"][10],
            Id = @"UB2.10",
            Type = @"Field",
            Position = @"UB2.10",
            Name = @"UB92 Locator 11 (State)",
            Length = 12,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The value in this field may repeat up to two times.",
            Sample = @"",
        };

        // check for repetitions
        if (uB92Locator11State.field.FieldRepetitions != null && uB92Locator11State.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uB92Locator11State.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < uB92Locator11State.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = uB92Locator11State.field.FieldRepetitions[i],
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
                    for (var j = 0; j < uB92Locator11State.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = uB92Locator11State.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < uB92Locator11State.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = uB92Locator11State.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            uB92Locator11State.fieldRepetitions = fieldRepetitions;
        }

        return uB92Locator11State;
    } 
}

internal HL7V251Field uB92Locator31National;

public HL7V251Field UB92Locator31National
{
    get
    {
        if (uB92Locator31National != null)
        {
            return uB92Locator31National;
        }

        uB92Locator31National = new HL7V251Field
        {
            field = message[@"UB2"][11],
            Id = @"UB2.11",
            Type = @"Field",
            Position = @"UB2.11",
            Name = @"UB92 Locator 31 (National)",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        // check for repetitions
        if (uB92Locator31National.field.FieldRepetitions != null && uB92Locator31National.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uB92Locator31National.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < uB92Locator31National.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = uB92Locator31National.field.FieldRepetitions[i],
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
                    for (var j = 0; j < uB92Locator31National.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = uB92Locator31National.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < uB92Locator31National.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = uB92Locator31National.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            uB92Locator31National.fieldRepetitions = fieldRepetitions;
        }

        return uB92Locator31National;
    } 
}

internal HL7V251Field documentControlNumber;

public HL7V251Field DocumentControlNumber
{
    get
    {
        if (documentControlNumber != null)
        {
            return documentControlNumber;
        }

        documentControlNumber = new HL7V251Field
        {
            field = message[@"UB2"][12],
            Id = @"UB2.12",
            Type = @"Field",
            Position = @"UB2.12",
            Name = @"Document Control Number",
            Length = 23,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number assigned by payor that is used for rebilling/adjustment purposes. It may repeat up to three times. Refer UB92 field 37",
            Sample = @"",
        };

        // check for repetitions
        if (documentControlNumber.field.FieldRepetitions != null && documentControlNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(documentControlNumber.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < documentControlNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = documentControlNumber.field.FieldRepetitions[i],
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
                    for (var j = 0; j < documentControlNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = documentControlNumber.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < documentControlNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = documentControlNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            documentControlNumber.fieldRepetitions = fieldRepetitions;
        }

        return documentControlNumber;
    } 
}

internal HL7V251Field uB92Locator49National;

public HL7V251Field UB92Locator49National
{
    get
    {
        if (uB92Locator49National != null)
        {
            return uB92Locator49National;
        }

        uB92Locator49National = new HL7V251Field
        {
            field = message[@"UB2"][13],
            Id = @"UB2.13",
            Type = @"Field",
            Position = @"UB2.13",
            Name = @"UB92 Locator 49 (National)",
            Length = 4,
            Usage = @"O",
            Rpt = @"23",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by CMS or other regulatory agencies. This field may repeat up to twenty-three times.",
            Sample = @"",
        };

        // check for repetitions
        if (uB92Locator49National.field.FieldRepetitions != null && uB92Locator49National.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uB92Locator49National.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < uB92Locator49National.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = uB92Locator49National.field.FieldRepetitions[i],
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
                    for (var j = 0; j < uB92Locator49National.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = uB92Locator49National.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < uB92Locator49National.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = uB92Locator49National.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            uB92Locator49National.fieldRepetitions = fieldRepetitions;
        }

        return uB92Locator49National;
    } 
}

internal HL7V251Field uB92Locator56State;

public HL7V251Field UB92Locator56State
{
    get
    {
        if (uB92Locator56State != null)
        {
            return uB92Locator56State;
        }

        uB92Locator56State = new HL7V251Field
        {
            field = message[@"UB2"][14],
            Id = @"UB2.14",
            Type = @"Field",
            Position = @"UB2.14",
            Name = @"UB92 Locator 56 (State)",
            Length = 14,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may repeat up to five times.",
            Sample = @"",
        };

        // check for repetitions
        if (uB92Locator56State.field.FieldRepetitions != null && uB92Locator56State.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uB92Locator56State.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < uB92Locator56State.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = uB92Locator56State.field.FieldRepetitions[i],
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
                    for (var j = 0; j < uB92Locator56State.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = uB92Locator56State.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < uB92Locator56State.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = uB92Locator56State.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            uB92Locator56State.fieldRepetitions = fieldRepetitions;
        }

        return uB92Locator56State;
    } 
}

internal HL7V251Field uB92Locator57National;

public HL7V251Field UB92Locator57National
{
    get
    {
        if (uB92Locator57National != null)
        {
            return uB92Locator57National;
        }

        uB92Locator57National = new HL7V251Field
        {
            field = message[@"UB2"][15],
            Id = @"UB2.15",
            Type = @"Field",
            Position = @"UB2.15",
            Name = @"UB92 Locator 57 (National)",
            Length = 27,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-92 CMS specification.",
            Sample = @"",
        };

        // check for repetitions
        if (uB92Locator57National.field.FieldRepetitions != null && uB92Locator57National.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uB92Locator57National.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < uB92Locator57National.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = uB92Locator57National.field.FieldRepetitions[i],
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
                    for (var j = 0; j < uB92Locator57National.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = uB92Locator57National.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < uB92Locator57National.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = uB92Locator57National.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            uB92Locator57National.fieldRepetitions = fieldRepetitions;
        }

        return uB92Locator57National;
    } 
}

internal HL7V251Field uB92Locator78State;

public HL7V251Field UB92Locator78State
{
    get
    {
        if (uB92Locator78State != null)
        {
            return uB92Locator78State;
        }

        uB92Locator78State = new HL7V251Field
        {
            field = message[@"UB2"][16],
            Id = @"UB2.16",
            Type = @"Field",
            Position = @"UB2.16",
            Name = @"UB92 Locator 78 (State)",
            Length = 2,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may repeat up to two times.",
            Sample = @"",
        };

        // check for repetitions
        if (uB92Locator78State.field.FieldRepetitions != null && uB92Locator78State.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(uB92Locator78State.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < uB92Locator78State.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = uB92Locator78State.field.FieldRepetitions[i],
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
                    for (var j = 0; j < uB92Locator78State.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = uB92Locator78State.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < uB92Locator78State.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = uB92Locator78State.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            uB92Locator78State.fieldRepetitions = fieldRepetitions;
        }

        return uB92Locator78State;
    } 
}

internal HL7V251Field specialVisitCount;

public HL7V251Field SpecialVisitCount
{
    get
    {
        if (specialVisitCount != null)
        {
            return specialVisitCount;
        }

        specialVisitCount = new HL7V251Field
        {
            field = message[@"UB2"][17],
            Id = @"UB2.17",
            Type = @"Field",
            Position = @"UB2.17",
            Name = @"Special Visit Count",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the total number of special therapy visits.",
            Sample = @"",
        };

        // check for repetitions
        if (specialVisitCount.field.FieldRepetitions != null && specialVisitCount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specialVisitCount.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < specialVisitCount.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = specialVisitCount.field.FieldRepetitions[i],
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
                    for (var j = 0; j < specialVisitCount.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = specialVisitCount.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < specialVisitCount.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = specialVisitCount.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            specialVisitCount.fieldRepetitions = fieldRepetitions;
        }

        return specialVisitCount;
    } 
}
    }
}
