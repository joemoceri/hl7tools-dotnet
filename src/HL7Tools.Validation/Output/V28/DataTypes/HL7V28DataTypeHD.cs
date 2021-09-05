using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataTypeHD
    {
        public string Id { get { return @"HD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Hierarchic Designator"; } }

        public string Description { get { return @"The basic definition of the HD is that it identifies an (administrative or system or application or other) entity that has responsibility for managing or assigning a defined set of instance identifiers (such as placer or filler number, patient identifiers, provider identifiers, etc.). This entity could be a particular health care application such as a registration system that assigns patient identifiers, a governmental entity such as a licensing authority that assigns professional identifiers or drivers’ license numbers, or a facility where such identifiers are assigned.

The HD is designed to be a more powerful and more general replacement for the application identifier of HL7 versions 2.1 and 2.2. It adds two additional components, the <universal ID> and the <universal ID type> to the former application ID (which is renamed more generically to be the namespace ID).

In the case where an HD identifies an entity that assigns/creates instance identifiers such as a particular patient registration system, it defines an ""assigning authority"". In the case where an HD identifies a location where instance identifiers are given out (although they may be created by another entity at another location) such as a particular ""department of motor vehicles office location,"" it defines an ""assigning facility"". These two different uses of the HD appear in many of the extended data types.

The ""assigning authority"" defined by the HD is similar in its role to the coding system (and version) part of the coded element data types: both identify a set of more discrete instance identifiers. The difference is that the set of HD-defined discrete instances contain identifiers of ""real-world"" things such as patient or clinical orders, while the coded element-defined set of discrete instances contains concept identifiers (codes).

The HD is designed to be used either as a local identifier (with only the <namespace ID> valued) or a publicly-assigned identifier, a UID (<universal ID> and <universal ID type> both valued). Syntactically, the HD is a group of two identifiers: a local identifier defined by the first component and a universal identifier defined by the second and third components. HDs that have defined third components (defined UID types) must have a second component that is unique within the series of IDs defined by that component.

Note: The HD is used in fields that in earlier versions of HL7 used the IS data type. Thus, a single component HD (only the first component valued) will look like a simple IS data type for older systems expecting a single component in the place of the HD data type.

If the first component for the HD data type is present, the second and third components are optional. If the third component is present, then the second must also be present (although in this case the first is optional). The second and third components must either both be valued (both non-null), or both be not valued (both null). 
This means that if all three components of the HD are valued, the entity identified by the first component is the same as the entity identified by components two and three taken together. However, implementers may choose, by site agreement, to specify that if all three components of the HD are valued, the first component defines a member in the set defined by the second and third components.

Examples:
Example 1: ISO example with only the 2nd and 3rd components valued:
|^2.16.840.1.113883.19^ISO|
The syntax of the second component is defined by the ISO standard for object identifiers, not by HL7 (for which the second component is of the ST data type). Thus the periods (""."") in the second component are part of the ISO syntax, and are legal by the definition of the HL7 ST data type. 

Example 2: A UUID example
|^478A0114-EBF0-7701-A023-6841FF05731A^UUID|

Example 3: A DNS example
|^falcon.iupui.edu^DNS|"; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 0; } }

        public string Usage { get { return null; } }

        public string Rpt { get { return null; } }

        public string TableId { get { return null; } }

        public string TableName { get { return null; } }

        public string Sample { get { return @""; } }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"HD.1",
                            Type = @"DataTypeComponent",
                            Position = @"HD.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"HD.2",
                            Type = @"DataTypeComponent",
                            Position = @"HD.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"HD.3",
                            Type = @"DataTypeComponent",
                            Position = @"HD.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
