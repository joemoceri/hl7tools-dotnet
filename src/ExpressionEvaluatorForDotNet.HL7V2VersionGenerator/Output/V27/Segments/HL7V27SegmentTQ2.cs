using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27SegmentTQ2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"TQ2"; } }

        public string SegmentId { get { return @"TQ2"; } }
        
        public string LongName { get { return @"Timing/quantity Relationship"; } }
        
        public string Description { get { return @"The TQ2 segment is used to form a relationship between the service request the TQ1/TQ2 segments are associated with, and other service requests. The TQ2 segment will link the current service request with one or more other service requests.

There are many situations, such as the creation of a service request for a group of intravenous (IV) solutions, where the sequence of the individual intravenous solutions (each a service in itself) needs to be specified, e.g., hyperalimentation with multi-vitamins in every third bottle.

There are other situations where part of the service request's instructions contains a results condition of some type, such as ""PRN pain."" There is currently a free text ""condition"" field of TQ1-10 - Condition text which allows any condition to be specified. However, to support a fully encoded version of service request sequencing, or results condition, the TQ2, Timing/Quantity Relationship segment has been defined.

TQ2 Usage notes:
a) Cyclic placer service request groups
   To implement a cyclic group of four IV service requests using the parent/child paradigm, the parent specifies a custom group of IVs, and the following occurs:
   - TQ2 of the second child service request specifies that it follow the first child service request.
   - TQ2 of the third child service request specifies that it follow the second child service request.
   - TQ2 of the fourth child service request specifies that it follow the third service request.
   To repeat the group of four child service requests in a cyclic manner, the following occurs:
   - TQ2 of the first child service request specifies that it is to be executed once without any dependence on the completion of other service requests. Its second execution follows the completion of the fourth service request. See example in Section 4A.5.2 RXO segment field examples.
This scheme allows the following to be tracked:
   - The status of the whole group of service requests to be reported back at the level of the parent service request.
   - The status for each individual IV service request by following the status of the corresponding child service request.
Separate Service requests example:
   - The same group of service requests can be sent as a group of four service requests (without a common parent), linked only by the data in their quantity/timing fields. In this case, there is no convenient HL7 method of transmitting the service request status of the group as a whole without transmitting the status of each of the four separate service requests.

b) Inheritance of service request status
   Cancellation/discontinuation/hold service request control events:
   - This logic implies the normal execution of the referenced predecessor service request. Thus a cancel (or discontinuation or hold) of a predecessor service request implies the cancellation (or discontinuation or hold) of all subsequent service requests in the chain.
   - If the referenced service request has been canceled (or discontinued or held), the current service request inherits that same status.
   - In the case of hold, the removal of the hold of the predecessor implies a removal of the hold for the given service request (which can then be executed according to the specification in the TQ2 segment)."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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
                            Id = @"TQ2.1",
                            Type = @"Field",
                            Position = @"TQ2.1",
                            Name = @"Set Id - Tq2",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = @"For the first timing specification transmitted, the sequence number shall be 1; for the second timing specification, it shall be 2; and so on.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.2",
                            Type = @"Field",
                            Position = @"TQ2.2",
                            Name = @"Sequence/Results Flag",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0503",
                            TableName = @"Sequence/Results Flag",
                            Description = @"This flag defines the sequencing relationship between the current service request, and the related service request(s) specified in this TQ2 segment. See HL7 Table 0503 – Sequence/Results Flag for values. If not value is present, the S - Sequential is the default value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.3",
                            Type = @"Field",
                            Position = @"TQ2.3",
                            Name = @"Related Placer Number",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"The placer numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Placer number"" from the current service request. For orders, the Placer Order Number from ORC-2 is the appropriate ""Placer number"". Repeats of this field indicate the current service request is related to multiple service requests.

Conditional Rule: At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ2.3.1",
                            Type = @"Component",
                            Position = @"TQ2.3.1",
                            Name = @"Entity Identifier",
                            Length = 0,
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
                            Id = @"TQ2.3.2",
                            Type = @"Component",
                            Position = @"TQ2.3.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"The component intentionally remains associated with the IS data type in v2.7.

The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 – Assigning Authority for suggested values.

Note: When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. 

By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.3.3",
                            Type = @"Component",
                            Position = @"TQ2.3.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.3.4",
                            Type = @"Component",
                            Position = @"TQ2.3.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.

Refer to HL7 Table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.4",
                            Type = @"Field",
                            Position = @"TQ2.4",
                            Name = @"Related Filler Number",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"The filler numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Filler number"" from the current service request. For orders, the Filler Order Number from ORC-3 is the appropriate ""Filler number"". Repeats of this field indicate the current service request is related to multiple service requests.

Conditional Rule: At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ2.4.1",
                            Type = @"Component",
                            Position = @"TQ2.4.1",
                            Name = @"Entity Identifier",
                            Length = 0,
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
                            Id = @"TQ2.4.2",
                            Type = @"Component",
                            Position = @"TQ2.4.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"The component intentionally remains associated with the IS data type in v2.7.

The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 – Assigning Authority for suggested values.

Note: When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. 

By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.4.3",
                            Type = @"Component",
                            Position = @"TQ2.4.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.4.4",
                            Type = @"Component",
                            Position = @"TQ2.4.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.

Refer to HL7 Table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.5",
                            Type = @"Field",
                            Position = @"TQ2.5",
                            Name = @"Related Placer Group Number",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"The placer group numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Placer group number"" from the current service request. For orders, the Placer Group Number from ORC-4 is the appropriate ""Placer group number"". Repeats of this field indicate that the current service request is related to multiple groups of service requests.

Conditional Rule: At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ2.5.1",
                            Type = @"Component",
                            Position = @"TQ2.5.1",
                            Name = @"Entity Identifier",
                            Length = 0,
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
                            Id = @"TQ2.5.2",
                            Type = @"Component",
                            Position = @"TQ2.5.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"The component intentionally remains associated with the IS data type in v2.7.

The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 – Assigning Authority for suggested values.

Note: When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. 

By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.5.3",
                            Type = @"Component",
                            Position = @"TQ2.5.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.5.4",
                            Type = @"Component",
                            Position = @"TQ2.5.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.

Refer to HL7 Table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.6",
                            Type = @"Field",
                            Position = @"TQ2.6",
                            Name = @"Sequence Condition Code",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0504",
                            TableName = @"Sequence Condition Code",
                            Description = @"Defines the relationship between the start/end of the related service request(s) (from TQ2-3, TQ2-4, or TQ2-5) and the current service request from ORC-2, 3 or 4. See HL7 Table 0504 – Sequence Condition Code for allowed values.

Conditional Rule: Either this field or TQ2-10 must be present.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.7",
                            Type = @"Field",
                            Position = @"TQ2.7",
                            Name = @"Cyclic Entry/Exit Indicator",
                            Length = 1,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0505",
                            TableName = @"Cyclic Entry/Exit Indicator",
                            Description = @"Indicates if this service request is the first, last, service request in a cyclic series of service requests. If null or not present, this field indicates that the current service request is neither the first or last service request in a cyclic series of service requests. Refer to HL7 Table 0505 – Cyclic Entry/Exit Indicator for allowed values.

Conditional Rule: Should not be populated when TQ2-2 (Sequence/Results Flag) is not equal to a 'C' (cyclic service request).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8",
                            Type = @"Field",
                            Position = @"TQ2.8",
                            Name = @"Sequence Condition Time Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the interval of time between the start/end of the related service request(s) and the start/end of the current service request. The unit's component is constrained to units of time. If this field is not populated, then there should be no interruption between start/ending the current service request, and the related service request(s).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ2.8.1",
                            Type = @"Component",
                            Position = @"TQ2.8.1",
                            Name = @"Quantity",
                            Length = 0,
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
                            Id = @"TQ2.8.2",
                            Type = @"Component",
                            Position = @"TQ2.8.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed.  As of v2.7 the externally-defined Unified Code for Units of Measure (UCUM) case sensitive code is the required code for units of measure. Refer to the external table ""Unified Code for Units of Measure"" (UCUM) [http://aurora.rg.iupui.edu/UCUM] for valid values. Local codes may be transmitted in addition to UCUM codes.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.1",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.1",
                            Name = @"Identifier",
                            Length = 0,
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
                            Id = @"TQ2.8.2.2",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., ""myocardial infarction"" or ""X-ray impression"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.3",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.3",
                            Name = @"Name Of Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the ""Coding System"" component or the ""Coding System OID"" for the tuple.

Refer to HL7 Table 0396 – Coding System in Chapter 2C, section ""Coding System Table"" for valid values. 

Refer to section 2.A.8.3, ""Name of Coding System (ID)"" for a discussion of coding system conventions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.4",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. 

Usage Notes: The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.5",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.6",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.

As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the ""Coding System"" component or the ""Coding System OID"", for the tuple.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.7",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.7",
                            Name = @"Coding System Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.8",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.9",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.9",
                            Name = @"Original Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.10",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.10",
                            Name = @"Second Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.11",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.11",
                            Name = @"Second Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.12",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.12",
                            Name = @"Name Of Second Alternate Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.

As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the ""Coding System"" component or the ""Coding System OID"", for the tuple.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.13",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.13",
                            Name = @"Second Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.14",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.14",
                            Name = @"Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.15",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.15",
                            Name = @"Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.16",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.16",
                            Name = @"Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.15 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.17",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.17",
                            Name = @"Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. 

The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.18",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.18",
                            Name = @"Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.19",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.19",
                            Name = @"Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.18 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.20",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.20",
                            Name = @"Second Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. 

The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.21",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.21",
                            Name = @"Second Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.8.2.22",
                            Type = @"SubComponent",
                            Position = @"TQ2.8.2.22",
                            Name = @"Second Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.21 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.9",
                            Type = @"Field",
                            Position = @"TQ2.9",
                            Name = @"Cyclic Group Maximum Number Of Repeats",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum number of repeats for a cyclic group.

The total number of repeats is constrained by the end date/time of the last repeat or the end date/time of the parent, whichever is first. For example, if the total number or repeats is valued at 10 and the group has already repeated 5 times, the current order will not be repeated again if either the current order, or the prior order in the cycle, has reached its end date/time.

This field is meaningful only when TQ2-2 Sequence/Results Flag is valued with 'C'. However, even in this case this field is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ2.10",
                            Type = @"Field",
                            Position = @"TQ2.10",
                            Name = @"Special Service Request Relationship",
                            Length = 1,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0506",
                            TableName = @"Service Request Relationship",
                            Description = @"This defines an additional or alternate relationship between this service request and other service requests. Its primary intended use is for Pharmacy administration service requests, but it may be useful for other domains. See HL7 Table 0506 – Service Request Relationship for allowed values.

Conditional Rule: Either this field or TQ2-6 must be present.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V27SegmentTQ2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V27Field setIdTq2;

public HL7V27Field SetIdTq2
{
    get
    {
        if (setIdTq2 != null)
        {
            return setIdTq2;
        }

        setIdTq2 = new HL7V27Field
        {
            field = message[@"TQ2"][1],
            Id = @"TQ2.1",
            Type = @"Field",
            Position = @"TQ2.1",
            Name = @"Set Id - Tq2",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"For the first timing specification transmitted, the sequence number shall be 1; for the second timing specification, it shall be 2; and so on.",
            Sample = @"",
        };

        // check for repetitions
        if (setIdTq2.field.FieldRepetitions != null && setIdTq2.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdTq2.Id));
            setIdTq2.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(setIdTq2, fieldData);
        }

        return setIdTq2;
    } 
}

internal HL7V27Field sequenceResultsFlag;

public HL7V27Field SequenceResultsFlag
{
    get
    {
        if (sequenceResultsFlag != null)
        {
            return sequenceResultsFlag;
        }

        sequenceResultsFlag = new HL7V27Field
        {
            field = message[@"TQ2"][2],
            Id = @"TQ2.2",
            Type = @"Field",
            Position = @"TQ2.2",
            Name = @"Sequence/Results Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0503",
            TableName = @"Sequence/Results Flag",
            Description = @"This flag defines the sequencing relationship between the current service request, and the related service request(s) specified in this TQ2 segment. See HL7 Table 0503 – Sequence/Results Flag for values. If not value is present, the S - Sequential is the default value.",
            Sample = @"",
        };

        // check for repetitions
        if (sequenceResultsFlag.field.FieldRepetitions != null && sequenceResultsFlag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceResultsFlag.Id));
            sequenceResultsFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(sequenceResultsFlag, fieldData);
        }

        return sequenceResultsFlag;
    } 
}

internal HL7V27Field relatedPlacerNumber;

public HL7V27Field RelatedPlacerNumber
{
    get
    {
        if (relatedPlacerNumber != null)
        {
            return relatedPlacerNumber;
        }

        relatedPlacerNumber = new HL7V27Field
        {
            field = message[@"TQ2"][3],
            Id = @"TQ2.3",
            Type = @"Field",
            Position = @"TQ2.3",
            Name = @"Related Placer Number",
            Length = 0,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The placer numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Placer number"" from the current service request. For orders, the Placer Order Number from ORC-2 is the appropriate ""Placer number"". Repeats of this field indicate the current service request is related to multiple service requests.

Conditional Rule: At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
            Sample = @"",
        };

        // check for repetitions
        if (relatedPlacerNumber.field.FieldRepetitions != null && relatedPlacerNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(relatedPlacerNumber.Id));
            relatedPlacerNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(relatedPlacerNumber, fieldData);
        }

        return relatedPlacerNumber;
    } 
}

internal HL7V27Field relatedFillerNumber;

public HL7V27Field RelatedFillerNumber
{
    get
    {
        if (relatedFillerNumber != null)
        {
            return relatedFillerNumber;
        }

        relatedFillerNumber = new HL7V27Field
        {
            field = message[@"TQ2"][4],
            Id = @"TQ2.4",
            Type = @"Field",
            Position = @"TQ2.4",
            Name = @"Related Filler Number",
            Length = 0,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The filler numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Filler number"" from the current service request. For orders, the Filler Order Number from ORC-3 is the appropriate ""Filler number"". Repeats of this field indicate the current service request is related to multiple service requests.

Conditional Rule: At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
            Sample = @"",
        };

        // check for repetitions
        if (relatedFillerNumber.field.FieldRepetitions != null && relatedFillerNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(relatedFillerNumber.Id));
            relatedFillerNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(relatedFillerNumber, fieldData);
        }

        return relatedFillerNumber;
    } 
}

internal HL7V27Field relatedPlacerGroupNumber;

public HL7V27Field RelatedPlacerGroupNumber
{
    get
    {
        if (relatedPlacerGroupNumber != null)
        {
            return relatedPlacerGroupNumber;
        }

        relatedPlacerGroupNumber = new HL7V27Field
        {
            field = message[@"TQ2"][5],
            Id = @"TQ2.5",
            Type = @"Field",
            Position = @"TQ2.5",
            Name = @"Related Placer Group Number",
            Length = 0,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The placer group numbers of the service request(s) to which this TQ2 segment links the current service request. This field should be populated with the appropriate ""Placer group number"" from the current service request. For orders, the Placer Group Number from ORC-4 is the appropriate ""Placer group number"". Repeats of this field indicate that the current service request is related to multiple groups of service requests.

Conditional Rule: At least one of TQ2-3, TQ2-4, TQ2-5 must contain a value.",
            Sample = @"",
        };

        // check for repetitions
        if (relatedPlacerGroupNumber.field.FieldRepetitions != null && relatedPlacerGroupNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(relatedPlacerGroupNumber.Id));
            relatedPlacerGroupNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(relatedPlacerGroupNumber, fieldData);
        }

        return relatedPlacerGroupNumber;
    } 
}

internal HL7V27Field sequenceConditionCode;

public HL7V27Field SequenceConditionCode
{
    get
    {
        if (sequenceConditionCode != null)
        {
            return sequenceConditionCode;
        }

        sequenceConditionCode = new HL7V27Field
        {
            field = message[@"TQ2"][6],
            Id = @"TQ2.6",
            Type = @"Field",
            Position = @"TQ2.6",
            Name = @"Sequence Condition Code",
            Length = 0,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0504",
            TableName = @"Sequence Condition Code",
            Description = @"Defines the relationship between the start/end of the related service request(s) (from TQ2-3, TQ2-4, or TQ2-5) and the current service request from ORC-2, 3 or 4. See HL7 Table 0504 – Sequence Condition Code for allowed values.

Conditional Rule: Either this field or TQ2-10 must be present.",
            Sample = @"",
        };

        // check for repetitions
        if (sequenceConditionCode.field.FieldRepetitions != null && sequenceConditionCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceConditionCode.Id));
            sequenceConditionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(sequenceConditionCode, fieldData);
        }

        return sequenceConditionCode;
    } 
}

internal HL7V27Field cyclicEntryExitIndicator;

public HL7V27Field CyclicEntryExitIndicator
{
    get
    {
        if (cyclicEntryExitIndicator != null)
        {
            return cyclicEntryExitIndicator;
        }

        cyclicEntryExitIndicator = new HL7V27Field
        {
            field = message[@"TQ2"][7],
            Id = @"TQ2.7",
            Type = @"Field",
            Position = @"TQ2.7",
            Name = @"Cyclic Entry/Exit Indicator",
            Length = 1,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0505",
            TableName = @"Cyclic Entry/Exit Indicator",
            Description = @"Indicates if this service request is the first, last, service request in a cyclic series of service requests. If null or not present, this field indicates that the current service request is neither the first or last service request in a cyclic series of service requests. Refer to HL7 Table 0505 – Cyclic Entry/Exit Indicator for allowed values.

Conditional Rule: Should not be populated when TQ2-2 (Sequence/Results Flag) is not equal to a 'C' (cyclic service request).",
            Sample = @"",
        };

        // check for repetitions
        if (cyclicEntryExitIndicator.field.FieldRepetitions != null && cyclicEntryExitIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(cyclicEntryExitIndicator.Id));
            cyclicEntryExitIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(cyclicEntryExitIndicator, fieldData);
        }

        return cyclicEntryExitIndicator;
    } 
}

internal HL7V27Field sequenceConditionTimeInterval;

public HL7V27Field SequenceConditionTimeInterval
{
    get
    {
        if (sequenceConditionTimeInterval != null)
        {
            return sequenceConditionTimeInterval;
        }

        sequenceConditionTimeInterval = new HL7V27Field
        {
            field = message[@"TQ2"][8],
            Id = @"TQ2.8",
            Type = @"Field",
            Position = @"TQ2.8",
            Name = @"Sequence Condition Time Interval",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"Defines the interval of time between the start/end of the related service request(s) and the start/end of the current service request. The unit's component is constrained to units of time. If this field is not populated, then there should be no interruption between start/ending the current service request, and the related service request(s).",
            Sample = @"",
        };

        // check for repetitions
        if (sequenceConditionTimeInterval.field.FieldRepetitions != null && sequenceConditionTimeInterval.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceConditionTimeInterval.Id));
            sequenceConditionTimeInterval.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(sequenceConditionTimeInterval, fieldData);
        }

        return sequenceConditionTimeInterval;
    } 
}

internal HL7V27Field cyclicGroupMaximumNumberOfRepeats;

public HL7V27Field CyclicGroupMaximumNumberOfRepeats
{
    get
    {
        if (cyclicGroupMaximumNumberOfRepeats != null)
        {
            return cyclicGroupMaximumNumberOfRepeats;
        }

        cyclicGroupMaximumNumberOfRepeats = new HL7V27Field
        {
            field = message[@"TQ2"][9],
            Id = @"TQ2.9",
            Type = @"Field",
            Position = @"TQ2.9",
            Name = @"Cyclic Group Maximum Number Of Repeats",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"The maximum number of repeats for a cyclic group.

The total number of repeats is constrained by the end date/time of the last repeat or the end date/time of the parent, whichever is first. For example, if the total number or repeats is valued at 10 and the group has already repeated 5 times, the current order will not be repeated again if either the current order, or the prior order in the cycle, has reached its end date/time.

This field is meaningful only when TQ2-2 Sequence/Results Flag is valued with 'C'. However, even in this case this field is optional.",
            Sample = @"",
        };

        // check for repetitions
        if (cyclicGroupMaximumNumberOfRepeats.field.FieldRepetitions != null && cyclicGroupMaximumNumberOfRepeats.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(cyclicGroupMaximumNumberOfRepeats.Id));
            cyclicGroupMaximumNumberOfRepeats.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(cyclicGroupMaximumNumberOfRepeats, fieldData);
        }

        return cyclicGroupMaximumNumberOfRepeats;
    } 
}

internal HL7V27Field specialServiceRequestRelationship;

public HL7V27Field SpecialServiceRequestRelationship
{
    get
    {
        if (specialServiceRequestRelationship != null)
        {
            return specialServiceRequestRelationship;
        }

        specialServiceRequestRelationship = new HL7V27Field
        {
            field = message[@"TQ2"][10],
            Id = @"TQ2.10",
            Type = @"Field",
            Position = @"TQ2.10",
            Name = @"Special Service Request Relationship",
            Length = 1,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0506",
            TableName = @"Service Request Relationship",
            Description = @"This defines an additional or alternate relationship between this service request and other service requests. Its primary intended use is for Pharmacy administration service requests, but it may be useful for other domains. See HL7 Table 0506 – Service Request Relationship for allowed values.

Conditional Rule: Either this field or TQ2-6 must be present.",
            Sample = @"",
        };

        // check for repetitions
        if (specialServiceRequestRelationship.field.FieldRepetitions != null && specialServiceRequestRelationship.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specialServiceRequestRelationship.Id));
            specialServiceRequestRelationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV27FieldRepetitions(specialServiceRequestRelationship, fieldData);
        }

        return specialServiceRequestRelationship;
    } 
}
    }
}
