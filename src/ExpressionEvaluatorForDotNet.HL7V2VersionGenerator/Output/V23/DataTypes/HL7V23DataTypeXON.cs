using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataType
    {
        public string Id { get { return @"XON"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Extended Composite Name And ID For Organizations"; } }

        public string Description { get { return @"Example: 
|HL7 Health Center^L^6^M11^HCFA| "; } }

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
                            Id = @"XON.1",
                            Type = @"DataTypeComponent",
                            Position = @"XON.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XON.2",
                            Type = @"DataTypeComponent",
                            Position = @"XON.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name.  Refer to user-defined table 0204 - Organizational name type for suggested values. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XON.3",
                            Type = @"DataTypeComponent",
                            Position = @"XON.3",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XON.4",
                            Type = @"DataTypeComponent",
                            Position = @"XON.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XON.5",
                            Type = @"DataTypeComponent",
                            Position = @"XON.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XON.6",
                            Type = @"DataTypeComponent",
                            Position = @"XON.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XON.7",
                            Type = @"DataTypeComponent",
                            Position = @"XON.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XON.8",
                            Type = @"DataTypeComponent",
                            Position = @"XON.8",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility is a unique identifier of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
