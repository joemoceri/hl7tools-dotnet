using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataTypeRP
    {
        public string Id { get { return @"RP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Reference Pointer"; } }

        public string Description { get { return @"This data type transmits information about data stored on another system. It contains a reference pointer that uniquely identifies the data on the other system, the identity of the other system, and the type of data."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 273; } }

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
                            Id = @"RP.1",
                            Type = @"DataTypeComponent",
                            Position = @"RP.1",
                            Name = @"Pointer",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A unique key assigned by the system that stores the data. The key, which is a ST data type, is used to identify and access the data.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RP.2",
                            Type = @"DataTypeComponent",
                            Position = @"RP.2",
                            Name = @"Application Id",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"A unique designator of the system that stores the data. It is a HD data type (See Section 2.A.33, ""HD - hierarchic designator""). Application IDs must be unique across a given HL7 implementation.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RP.3",
                            Type = @"DataTypeComponent",
                            Position = @"RP.3",
                            Name = @"Type Of Data",
                            Length = 9,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0191",
                            TableName = @"Type of referenced data",
                            Description = @"An ID data type that declares the general type of data. Refer to HL7 Table 0191- Type of referenced data for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RP.4",
                            Type = @"DataTypeComponent",
                            Position = @"RP.4",
                            Name = @"Subtype",
                            Length = 19,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0291",
                            TableName = @"Subtype of referenced data",
                            Description = @"An ID data type declaring the format for the data of subcomponent <main type>. Refer to HL7 Table 0291 - Subtype of referenced data for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}