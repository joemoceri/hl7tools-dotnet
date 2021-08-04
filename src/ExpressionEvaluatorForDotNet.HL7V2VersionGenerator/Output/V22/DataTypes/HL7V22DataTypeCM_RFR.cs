using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataType
    {
        public string Id { get { return @"CM_RFR"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Reference Range"; } }

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
                            Id = @"CM_RFR.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_RFR.1",
                            Name = @"Reference Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Range Of Values",
                            TableId = null,
                            TableName = null,
                            Description = @"The format of this component is <low value & high value>, where the range is taken to be inclusive (i.e., the range includes the end points).  In this specification, the units are assumed to be identical to the reporting units given in OM2-3-units of measure). ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_RFR.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_RFR.2",
                            Name = @"Sex",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The sex of the patient",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_RFR.3",
                            Type = @"DataTypeComponent",
                            Position = @"CM_RFR.3",
                            Name = @"Age Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Range Of Values",
                            TableId = null,
                            TableName = null,
                            Description = @"The age range (in years or fractions thereof) is specified as two values separated by a subcomponent delimiter (i.e., <low value & high value>) in order to allow a simple and consistent machine interpretation of this component.  Ages of less than one year should be specified as a fraction (e.g., 1 month = 0.0830, 1 week = 0.01920, 1 day = 0.0027300).  However, for most purposes involving infants, the gestational age (measured in weeks) is preferred.  The lower end of the range is not indicated; the upper end is, assuring that series of ranges do not overlap",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_RFR.4",
                            Type = @"DataTypeComponent",
                            Position = @"CM_RFR.4",
                            Name = @"Gestational Age Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Range Of Values",
                            TableId = null,
                            TableName = null,
                            Description = @"The gestational age is relevant only when the reference range is influenced by the stage of pregnancy.  A range of values separated by a component delimiter is required, i.e., <low value & high value>.  The gestational age is measured in weeks from conception.  For example, <1&10> implies that the normals apply to gestational ages from 1 week to 4 weeks inclusive (1&4).  The lower end of the range is not included; the upper end is, assuring  that series of age ranges do not overlap",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_RFR.5",
                            Type = @"DataTypeComponent",
                            Position = @"CM_RFR.5",
                            Name = @"Species",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is assumed to be human unless otherwise stated.  The species should be represented as text (e.g., rabbit, mouse, rat",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_RFR.6",
                            Type = @"DataTypeComponent",
                            Position = @"CM_RFR.6",
                            Name = @"Race / Subspecies",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"In the case of humans (the default), the race is specified when race influences the reference range.  When normal ranges for animals are being described, this component can be used to describe subspecies or special breeds of animals",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_RFR.7",
                            Type = @"DataTypeComponent",
                            Position = @"CM_RFR.7",
                            Name = @"Text Condition",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The condition is simply free text.  This component allows for definition of normal ranges based on any arbitrary condition, e.g., phase of menstrual cycle or dose of a particular drug.  It is provided as a way to communicate the normal ranges for special conditions.  It does not allow automatic checking of these text conditions",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
