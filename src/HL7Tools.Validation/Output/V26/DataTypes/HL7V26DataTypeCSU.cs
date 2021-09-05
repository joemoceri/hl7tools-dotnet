using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataTypeCSU
    {
        public string Id { get { return @"CSU"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Channel Sensitivity"; } }

        public string Description { get { return @"This data type defines the channel sensitivity (gain) and the units in which it is measured in a waveform result."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 490; } }

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
                            Id = @"CSU.1",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.1",
                            Name = @"Channel Sensitivity",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component transmits the nominal value that corresponds to one unit in the waveform data, that is, the effective resolution of the least significant bit of the ADC, and the polarity of the channel.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.2",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.2",
                            Name = @"Unit Of Measure Identifier",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The unit designation for the channel sensitivity. This field is required if the unit of measure description is not present.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.3",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.3",
                            Name = @"Unit Of Measure Description",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The full text name of the unit of measure identifier. This field is required if the unit of measure identifier is not present.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.4",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.4",
                            Name = @"Unit Of Measure Coding System",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Specifies the designated system of units. Refer to HL7 Table 0396 - Coding System in section 2.16.4, ""Coding System Table"" for suggested values. This field is required if the unit of measure identifier is present.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.5",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.5",
                            Name = @"Alternate Unit Of Measure Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate units designation for the channel sensitivity.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.6",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.6",
                            Name = @"Alternate Unit Of Measure Description",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The full text name of the alternate unit of measure identifier",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.7",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.7",
                            Name = @"Alternate Unit Of Measure Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Specifies the coding system for the alternate unit of measure. Refer to HL7 Table 0396 - Coding System in section 2.16.4, ""Coding System Table"" for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
