using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"LA1"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Location With Address Variation 1"; } }

        public string Description { get { return @"Specifies a location and its address.

Note: Replaces the CM data type used in 4.14.1.8 RXO-8 and 4.14.4.8 RXE-8 as of v 2.5. Retained for backward compatibility only as of v 2.5.

Attention: Retained for backward compatibility only in v2.6. Fields associated with this data type have been replaced by 4 new fields in the RXO and RXE segments."; } }

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
                            Id = @"LA1.1",
                            Type = @"DataTypeComponent",
                            Position = @"LA1.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0302",
                            TableName = @"Point of Care",
                            Description = @"This component specifies the code for the point where patient care is administered. It is conditional on person location type (e.g., nursing unit or department or clinic). After floor, it is the most general patient location designation. Refer to User-defined Table 0302 - Point of Care for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA1.2",
                            Type = @"DataTypeComponent",
                            Position = @"LA1.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = @"This component specifies the code for the patient room. After point of care, it is the most general person location designation. Refer to User-defined Table 0303 - Room for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA1.3",
                            Type = @"DataTypeComponent",
                            Position = @"LA1.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = @"This component specifies the code for the patient bed. After room, it is the most general person location designation. Refer to User-defined Table 0304 - Bed for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA1.4",
                            Type = @"DataTypeComponent",
                            Position = @"LA1.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This component is subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. It is the most general person location designation.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA1.5",
                            Type = @"DataTypeComponent",
                            Position = @"LA1.5",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0306",
                            TableName = @"Location Status",
                            Description = @"This component specifies the code for the status or availability of the location. For example, it may convey bed status. Refer to User-defined Table 0306 - Location Status for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA1.6",
                            Type = @"DataTypeComponent",
                            Position = @"LA1.6",
                            Name = @"Patient Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0305",
                            TableName = @"Person Location Type",
                            Description = @"Person location type is the categorization of the person’s location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. It usually includes values such as nursing unit, department, clinic, SNF, physician’s office. Refer to User-defined Table 0305 - Person Location Type for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA1.7",
                            Type = @"DataTypeComponent",
                            Position = @"LA1.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = @"This component specifies the code for the building where the person is located. After facility, it is the most general person location designation. Refer to User-defined Table 0307 - Building for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA1.8",
                            Type = @"DataTypeComponent",
                            Position = @"LA1.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = @"This component specifies the code for the floor where the person is located. After building, it is the most general person location designation. Refer to User-defined Table 0308 - Floor for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA1.9",
                            Type = @"DataTypeComponent",
                            Position = @"LA1.9",
                            Name = @"Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the address of a location.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
