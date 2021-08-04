using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeHD
    {
        public string Id { get { return @"HD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Hierarchic Designator"; } }

        public string Description { get { return @"The HD is designed to be a more powerful application identifier.  It is also designed to be used either as a local version of a site-defined application identifier or a publicly-assigned UID.  Syntactically, the HD is a group of two application identifiers: one defined by the first component, and one defined by the second and third components.

The HD allows any site to act as an assigning authority (on a local or user-defined basis), even if it technically does not have the right to issue new IDs within an identification scheme.  HDs which have defined third components (defined UID types) must be unique within the series of ID’s defined by that component."; } }

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
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"HD.2",
                            Type = @"DataTypeComponent",
                            Position = @"HD.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"HD.3",
                            Type = @"DataTypeComponent",
                            Position = @"HD.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
