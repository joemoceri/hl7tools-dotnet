using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataType
    {
        public string Id { get { return @"PL"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Person Location"; } }

        public string Description { get { return @"This data type is used to specify a patient location within a healthcare institution. Which components are valued depends on the needs of the site. For example for a patient treated at home, only the person location type is valued. It is most commonly used for specifying patient locations, but may refer to other types of locations within a healthcare setting.

Note: This data type contains several location identifiers that should be thought of in the following order from the most general to the most specific: facility, building, floor, point of care, room, bed.

Additional data about any location defined by these components can be added in the following components: person location type, location description and location status.

Example: Nursing Unit
A nursing unit at Community Hospital: 4 East, room 136, bed B 
4E^136^B^CommunityHospital^^N^^^

Example: Clinic
A clinic at University Hospitals: Internal Medicine Clinic located in the Briones building, 3rd floor.
InternalMedicine^^^UniversityHospitals^^C^Briones^3^"; } }

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
                            Id = @"PL.1",
                            Type = @"DataTypeComponent",
                            Position = @"PL.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0302",
                            TableName = @"Point of Care",
                            Description = @"This component specifies the code for the point where patient care is administered. It is conditional on PL.6 Person Location Type (e.g., nursing unit or department or clinic). After floor, it is the most general patient location designation. Refer to User-defined Table 0302 - Point of Care for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PL.2",
                            Type = @"DataTypeComponent",
                            Position = @"PL.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = @"This component specifies the code for the patient's room. After point of care, it is the most general person location designation. Refer to User-defined Table 0303 - Room for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PL.3",
                            Type = @"DataTypeComponent",
                            Position = @"PL.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = @"This component specifies the code for the patient's bed. After room, it is the most general person location designation. Refer to User-defined Table 0304 - Bed for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PL.4",
                            Type = @"DataTypeComponent",
                            Position = @"PL.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This component is subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. It is the most general person location designation. 

See Section 2.A.33, “HD - hierarchic designator” for discussion of data type.

Note: When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be redefined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PL.5",
                            Type = @"DataTypeComponent",
                            Position = @"PL.5",
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
                            Id = @"PL.6",
                            Type = @"DataTypeComponent",
                            Position = @"PL.6",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0305",
                            TableName = @"Person Location Type",
                            Description = @"Person location type is the categorization of the person’s location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. It usually includes values such as nursing unit, department, clinic, SNF, physician’s office. Refer to User-defined Table 0305 - Person location type for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PL.7",
                            Type = @"DataTypeComponent",
                            Position = @"PL.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = @"This component specifies the code for the building where the person is located. After facility, it is the most general person location designation. Refer to User-defined Table 0307 - Building for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PL.8",
                            Type = @"DataTypeComponent",
                            Position = @"PL.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = @"This component specifies the code for the floor where the person is located. After building, it is the most general person location designation. Refer to User-defined Table 0308 - Floor for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PL.9",
                            Type = @"DataTypeComponent",
                            Position = @"PL.9",
                            Name = @"Location Description",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component describes the location in free text.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PL.10",
                            Type = @"DataTypeComponent",
                            Position = @"PL.10",
                            Name = @"Comprehensive Location Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"The unique identifier that represents the physical location as a whole without regard for the individual components. This accommodates sites that may have a different method of defining physical units or who may code at a less granular level. For example, point of care, room, and bed may be 1 indivisible code.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PL.11",
                            Type = @"DataTypeComponent",
                            Position = @"PL.11",
                            Name = @"Assigning Authority For Location",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"The entity that creates the data for the individual physical location components. If populated, it should be the authority for all components populated. Refer to User-defined Table 0363 – Assigning Authority for suggested values for the first sub-component of the HD component, <namespace ID>.

This component makes it possible for codes to be differentiated when the field in which this data type is used repeats.

Note:When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.

By site agreement, implementors may continue to use User-defined Table 0300 – Namespace ID for the first sub-component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
