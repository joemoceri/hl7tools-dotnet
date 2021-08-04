using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataType
    {
        public string Id { get { return @"NDL"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Name With Date And Location"; } }

        public string Description { get { return @"Specifies the name of the person performing a service, when the person performed the service and where the person performed the service. Retained for backward compatibility as of v2.6.

Note: Replaces the CM data type used in sections 4.5.3.32 and 7.4.1.32-( OBR-32), 4.5.3.33 and 7.4.1.33  - ( OBR-33) 4.5.3.34 and 7.4.1.34 - ( OBR-34) 4.5.3.35 and 7.4.1.35 - ( OBR-35) as of v 2.5.

Retained for backward compatibility only in v2.6. Fields associated with this data type have been replaced by the ROL segment."; } }

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
                            Id = @"NDL.1",
                            Type = @"DataTypeComponent",
                            Position = @"NDL.1",
                            Name = @"Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CNN",
                            DataTypeName = @"Composite Id Number And Name Simplified",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the name of the person performing a service. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDL.2",
                            Type = @"DataTypeComponent",
                            Position = @"NDL.2",
                            Name = @"Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the starting date and time for when the person is performing the service.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDL.3",
                            Type = @"DataTypeComponent",
                            Position = @"NDL.3",
                            Name = @"End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the ending date and time for when the person is performing the service. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDL.4",
                            Type = @"DataTypeComponent",
                            Position = @"NDL.4",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0302",
                            TableName = @"Point of Care",
                            Description = @"This component specifies the code for the point where patient care is administered. It is conditional on NDL.9 – Patient Location Type (e.g., nursing unit or department or clinic). After floor, it is the most general patient location designation. Refer to User-defined Table 0302 - Point of care for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDL.5",
                            Type = @"DataTypeComponent",
                            Position = @"NDL.5",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = @"Patient room. After point of care, it is the most general location designation. Refer to User-defined Table 0303 - Room for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDL.6",
                            Type = @"DataTypeComponent",
                            Position = @"NDL.6",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = @"This component specifies the code for the patient's bed. After room, it is the most general location designation. Refer to User-defined Table 0304 - Bed for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDL.7",
                            Type = @"DataTypeComponent",
                            Position = @"NDL.7",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This component is subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. It is the most general location designation. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDL.8",
                            Type = @"DataTypeComponent",
                            Position = @"NDL.8",
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
                            Id = @"NDL.9",
                            Type = @"DataTypeComponent",
                            Position = @"NDL.9",
                            Name = @"Patient Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0305",
                            TableName = @"Person Location Type",
                            Description = @"Location type is the categorization of the location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. Usually includes values such as nursing unit, department, clinic, SNF, physician’s office. Refer to User-defined Table 0305 - Person Location Type for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDL.10",
                            Type = @"DataTypeComponent",
                            Position = @"NDL.10",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = @"This component specifies the code for the building where the person is located. After facility, it is the most general location designation. Refer to User-defined Table 0307 - Building for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDL.11",
                            Type = @"DataTypeComponent",
                            Position = @"NDL.11",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = @"This component specifies the code for the floor where the person is located. After building, it is the most general location designation. Refer to User-defined Table 0308 - Floor for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
