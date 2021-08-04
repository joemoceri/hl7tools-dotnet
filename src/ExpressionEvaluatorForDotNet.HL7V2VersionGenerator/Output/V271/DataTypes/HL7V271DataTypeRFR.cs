using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataType
    {
        public string Id { get { return @"RFR"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Reference Range"; } }

        public string Description { get { return @"Describes a reference range and its supporting detail.

Note: Replaces the CM data type used in sections 8.8.4.6 - OM2-6, 8.8.4.7 - OM2-7 and 8.8.4.8 - OM2-8 as of v 2.5.

Examples:
A range that applies unconditionally, such as albumin, is transmitted as:
|3.0&5.5|

A normal range that depends on sex, such as Hgb, is transmitted as:
|13.5&18^M~12.0 & 16^F|

A normal range that depends on age, sex, and race (a concocted example) is:
|10&13^M^0&2^^^B11&13.5^M^2&20^^^B~12&14.5^M^20&70^^^B~13&16.0^M^70&^^^B|

When no value is specified for a particular component, the range given applies to all categories of that component. For example, when nothing is specified for race/species, the range should be taken as the human range without regard to race. If no age range is specified, the normal range given is assumed to apply to all ages. "; } }

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
                            Id = @"RFR.1",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.1",
                            Name = @"Numeric Range",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric interval of the reference data. Range is taken to be inclusive (i.e., the range includes the end points). Units are context sensitive and are defined in the usage note for the field where this data type is used.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFR.2",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.2",
                            Name = @"Administrative Sex",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0001",
                            TableName = @"Administrative Sex",
                            Description = @"This component specifies which gender for which the reference range is valid. Refer to User-defined Table 0001 – Administrative Sex in Chapter 2C, section 3.4.2.8, ""Administrative Sex"" for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFR.3",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.3",
                            Name = @"Age Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the age range for which the reference range is valid. Ages of less than one year should be specified as a fraction (e.g., 1 month = 0.0830, 1 week = 0.01920, 1 day = 0.0027300). However, for most purposes involving infants, the gestational age (measured in weeks) is preferred. The lower end of the range is not indicated; the upper end is, assuring that series of ranges do not overlap.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFR.4",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.4",
                            Name = @"Gestational Age Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the gestational age range for which the reference range is valid. Gestational age is relevant only when the reference range is influenced by the stage of pregnancy. The gestational age is measured in weeks from conception. For example, |1&4| implies that the normals apply to gestational ages from 1 week to 4 weeks inclusive. The lower end of the range is not included; the upper end is, assuring that series of age ranges do not overlap.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFR.5",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.5",
                            Name = @"Species",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the species for which the reference range is valid. Species is assumed to be human unless otherwise stated. Example values are rabbit, mouse, and rat.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFR.6",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.6",
                            Name = @"Race/Subspecies",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the race or subspecies for which the reference range is valid. In the case of humans (the default species), the race is specified when race influences the reference range. When normal ranges for animals are being described, this component can be used to describe subspecies or special breeds of animals.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFR.7",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.7",
                            Name = @"Conditions",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies any arbitrary condition for which the reference range is valid. This may include such conditions as phase of menstrual cycle or dose of a particular drug. It is provided as a way to communicate the normal ranges for special conditions. It does not allow automatic checking of these text conditions.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
