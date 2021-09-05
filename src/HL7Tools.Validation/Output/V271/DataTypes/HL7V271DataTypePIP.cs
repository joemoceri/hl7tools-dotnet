using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataTypePIP
    {
        public string Id { get { return @"PIP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Practitioner Institutional Privileges"; } }

        public string Description { get { return @"This data type specifies the institutional privileges with associated detail granted to a provider.

Note: Replaces the CM data type used in 15.4.5.7 PRA-7 as of v 2.5."; } }

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
                            Id = @"PIP.1",
                            Type = @"DataTypeComponent",
                            Position = @"PIP.1",
                            Name = @"Privilege",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0525",
                            TableName = @"Privilege",
                            Description = @"Specifies the institutional privilege itself. Refer to User-defined Table 0525 – Privilege for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PIP.2",
                            Type = @"DataTypeComponent",
                            Position = @"PIP.2",
                            Name = @"Privilege Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0526",
                            TableName = @"Privilege Class",
                            Description = @"Specifies the class category of institutional privilege. Refer to User-defined Table 0526 – Privilege Class for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PIP.3",
                            Type = @"DataTypeComponent",
                            Position = @"PIP.3",
                            Name = @"Expiration Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the date the institutional privilege is/was no longer valid.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PIP.4",
                            Type = @"DataTypeComponent",
                            Position = @"PIP.4",
                            Name = @"Activation Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the date the institutional privilege became/becomes valid.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PIP.5",
                            Type = @"DataTypeComponent",
                            Position = @"PIP.5",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the facility in which the institutional privilege is/was valid.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
