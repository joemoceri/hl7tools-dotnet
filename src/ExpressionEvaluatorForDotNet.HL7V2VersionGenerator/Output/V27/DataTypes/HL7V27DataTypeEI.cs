using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"EI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Entity Identifier"; } }

        public string Description { get { return @"The entity identifier defines a given entity within a specified series of identifiers.

The EI is appropriate for, but not limited to, machine or software generated identifiers. The generated identifier goes in the first component. The remaining components, 2 through 4, are known as the assigning authority; they identify the machine/system responsible for generating the identifier in component 1.

The specified series, the assigning authority, is defined by components 2 through 4. The assigning authority is of the hierarchic designator (HD) data type, but it is defined as three separate components in the EI data type, rather than as a single component as would normally be the case. This is in order to maintain backward compatibility with the EI’s use as a component in several existing data fields. Otherwise, the components 2 through 4 are as defined in Section 2.A.33, ""HD - hierarchic designator"". Hierarchic designators (HD) are unique across a given HL7 implementation."; } }

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
                            Id = @"EI.1",
                            Type = @"DataTypeComponent",
                            Position = @"EI.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EI.2",
                            Type = @"DataTypeComponent",
                            Position = @"EI.2",
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
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EI.3",
                            Type = @"DataTypeComponent",
                            Position = @"EI.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EI.4",
                            Type = @"DataTypeComponent",
                            Position = @"EI.4",
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
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
