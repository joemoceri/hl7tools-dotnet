using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataTypeED
    {
        public string Id { get { return @"ED"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Encapsulated Data"; } }

        public string Description { get { return @"This data type transmits encapsulated data from a source system to a destination system. It contains the identity of the source system, the type of data, the encoding method of the data, and the data itself. This data type is similar to the RP (reference pointer) data type of Section 2.8.36, RP - reference pointer, except that instead of pointing to the data on another system, it contains the data which is to be sent to that system."; } }

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
                            Id = @"ED.1",
                            Type = @"DataTypeComponent",
                            Position = @"ED.1",
                            Name = @"Source Application",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"A unique name that identifies the system which was the source of the data. Identical format and restrictions as in reference pointer (see Section 2.8.36.2, Application ID (HD)).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ED.2",
                            Type = @"DataTypeComponent",
                            Position = @"ED.2",
                            Name = @"Type Of Data",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0191",
                            TableName = @"Type of referenced data",
                            Description = @"Identical to type of data component in the reference pointer (RP) data type. (See Section 2.8.36.4, 2.8.36.4).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ED.3",
                            Type = @"DataTypeComponent",
                            Position = @"ED.3",
                            Name = @"Data Subtype",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0291",
                            TableName = @"Subtype of referenced data",
                            Description = @"Identical to subtype component in the reference pointer (RP) data type. (See Section 2.8.36.4, Subtype (ID)).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ED.4",
                            Type = @"DataTypeComponent",
                            Position = @"ED.4",
                            Name = @"Encoding",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0299",
                            TableName = @" Encoding",
                            Description = @"The type of encoding, if present, used to represent successive octets of binary data as displayable ASCII characters. Refer to HL7 table 0299 - Encoding for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ED.5",
                            Type = @"DataTypeComponent",
                            Position = @"ED.5",
                            Name = @"Data",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Displayable ASCII characters which constitute the data to be sent from source application to destination application. The characters are limited to the legal characters of the ST data type, as defined in Section 2.8.40, ST - string data, and, if encoded binary, are encoded according to the method of Section 2.8.16.2, Type of data.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
