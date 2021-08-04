using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataTypeEI
    {
        public string Id { get { return @"EI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Entity Identifier"; } }

        public string Description { get { return @"The entity identifier defines a given entity within a specified series of identifiers.

The specified series, the assigning authority, is defined by components 2 through 4.  The assigning authority is of the hierarchic designator data type, but it is defined as three separate components in the EI data type, rather than as a single component as would normally be the case.  This is in order to maintain backward compatibility with the EI’s use as a component in several existing data fields. Otherwise, the components 2 through 4 are as defined in Section 2.8.18, “HD - hierarchic designator.”  Hierarchic designators are unique across a given HL7 implementation"; } }

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
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EI.2",
                            Type = @"DataTypeComponent",
                            Position = @"EI.2",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EI.3",
                            Type = @"DataTypeComponent",
                            Position = @"EI.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EI.4",
                            Type = @"DataTypeComponent",
                            Position = @"EI.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
