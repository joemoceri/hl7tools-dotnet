using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataTypeCSU
    {
        public string Id { get { return @"CSU"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Channel Sensitivity/units"; } }

        public string Description { get { return null; } }

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
                            Id = @"CSU.1",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.1",
                            Name = @"Channel Sensitivity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the nominal value (maximum 20 characters, data type NM) that corresponds to one unit in the waveform data, that is, the effective resolution of the least significant bit of the ADC, and the polarity of the channel.  The sensitivity incorporates both the amplifier gain and the actual ADC resolution.  It does not, however, relate to the vertical scaling of a waveform display (it is, for example, a measure of voltage, not voltage per unit distance).  For channels recording potential differences between two electrodes using a differential amplifier, a positive sensitivity indicates that a number in the waveform data which is greater than the channel baseline represents a potential at the first electrode which is more positive than that at the second electrode.  A negative sensitivity indicates that a number in the waveform data which is greater than the channel baseline corresponds to a potential at the first electrode which is more negative than that at the second electrode.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.2",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.2",
                            Name = @"Unit Of Measure Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A units designation (for example, uv = microvolt, mv = millivolt, v = volt, pal = pascal, or mm(hg) = millimeters of mercury) from a designated system of units, such as the ISO+ extension of the standard SI single case unit abbreviations presented as Figure 7-13 in Section  7.3.2.6.1, “Identifying reporting units,” or the ANSI+ U.S. customary unit abbreviations, a superset of the ANSI standard which appears in Figure 710. Other unit systems can be used as well.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.3",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.3",
                            Name = @"Unit Of Measure Description",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.4",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.4",
                            Name = @"Unit Of Measure Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.5",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.5",
                            Name = @"Alternate Unit Of Measure Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.6",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.6",
                            Name = @"Alternate Unit Of Measure Description",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.7",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.7",
                            Name = @"Alternate Unit Of Measure Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}