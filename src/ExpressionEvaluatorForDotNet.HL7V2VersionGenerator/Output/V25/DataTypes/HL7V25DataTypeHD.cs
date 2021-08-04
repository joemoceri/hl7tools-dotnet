using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataType
    {
        public string Id { get { return @"HD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Hierarchic Designator"; } }

        public string Description { get { return @"The basic definition of the HD is that it identifies an (administrative or system or application or other) entity that has responsibility for managing or assigning a defined set of instance identifiers (such as placer or filler number, patient identifiers, provider identifiers, etc.). This entity could be a particular health care application such as a registration system that assigns patient identifiers, a governmental entity such as a licensing authority that assigns professional identifiers or drivers license numbers, or a facility where such identifiers are assigned."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 227; } }

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
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"HD.2",
                            Type = @"DataTypeComponent",
                            Position = @"HD.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
