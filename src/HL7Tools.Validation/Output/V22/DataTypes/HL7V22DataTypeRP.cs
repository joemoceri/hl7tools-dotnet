using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeRP
    {
        public string Id { get { return @"RP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Reference Pointer"; } }

        public string Description { get { return @"This data type transmits information about data stored on another system.  It contains a reference pointer that uniquely identifies the data on the other system, the identity of the other system, and the type of data.

Example: 
|1234A321634BC^EFC^SD|"; } }

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
                            Id = @"RP.1",
                            Type = @"DataTypeComponent",
                            Position = @"RP.1",
                            Name = @"Pointer",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A unique key assigned by the system that stores the data.  The key, which is an ST data type, is used to identify and access the data.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RP.2",
                            Type = @"DataTypeComponent",
                            Position = @"RP.2",
                            Name = @"Application ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A unique name (up to 6 characters in length) of the system that stores the data.  It is an ST data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Application ID's must be unique across a given HL7 implementation.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RP.3",
                            Type = @"DataTypeComponent",
                            Position = @"RP.3",
                            Name = @"Type of Data",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0191",
                            TableName = @"TYPE OF DATA",
                            Description = @"A code that represents the type of data being stored.  It is an ID data type.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
