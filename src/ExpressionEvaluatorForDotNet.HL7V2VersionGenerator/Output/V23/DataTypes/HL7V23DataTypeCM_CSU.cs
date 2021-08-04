using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataTypeCM_CSU
    {
        public string Id { get { return @"CM_CSU"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Channel Sensitivity/units"; } }

        public string Description { get { return @"This CM data type defines the channel sensitivity (gain) and the units in which it is measured.  This component consists of up to seven subcomponents, separated from each other by subcomponent delimiters (&).  The first subcomponent specifies the sensitivity, while the remaining six subcomponents are used to specify the units of the sensitivity, using a format similar to the components of the coded entry (CE) data type."; } }

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
                            Id = @"CM_CSU.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_CSU.1",
                            Name = @"Sensitivity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the nominal value (maximum 20 characters, data type NM) that corresponds to one unit in the waveform data, that is, the effective resolution of the least significant bit of the ADC, and the polarity of the channel.  The sensitivity incorporates both the amplifier gain and the actual ADC resolution.  It does not, however, relate to the vertical scaling of a waveform display (it is, for example, a measure of voltage, not voltage per unit distance).  For channels recording potential differences between two electrodes using a differential amplifier, a positive sensitivity indicates that a number in the waveform data which is greater than the channel baseline represents a potential at the first electrode which is more positive than that at the second electrode.  A negative sensitivity indicates that a number in the waveform data which is greater than the channel baseline corresponds to a potential at the first electrode which is more negative than that at the second electrode",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_CSU.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_CSU.2",
                            Name = @"Unit Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = null,
                            TableName = null,
                            Description = @"A units designation (for example, uv = microvolt, mv = millivolt, v = volt, pal = pascal, or mm(hg) = millimeters of mercury) from a designated system of units, such as the ISO+ extension of the standard SI single case unit abbreviations presented as Figure 7-13 in Section  7.3.2.6.1, “Identifying reporting units,” or the ANSI+ U.S. customary unit abbreviations, a superset of the ANSI standard which appears in Figure 7-10. Other unit systems can be used as well",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_CSU.3",
                            Type = @"DataTypeComponent",
                            Position = @"CM_CSU.3",
                            Name = @"Unit Text",
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
                            Id = @"CM_CSU.4",
                            Type = @"DataTypeComponent",
                            Position = @"CM_CSU.4",
                            Name = @"Units Name Of Coding System",
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
                            Id = @"CM_CSU.5",
                            Type = @"DataTypeComponent",
                            Position = @"CM_CSU.5",
                            Name = @"Units Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_CSU.6",
                            Type = @"DataTypeComponent",
                            Position = @"CM_CSU.6",
                            Name = @"Units Alternate Text",
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
                            Id = @"CM_CSU.7",
                            Type = @"DataTypeComponent",
                            Position = @"CM_CSU.7",
                            Name = @"Units Name Of Alternate Coding System",
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
                        };
            }
        }
    }
}
