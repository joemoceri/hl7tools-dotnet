using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeCF
    {
        public string Id { get { return @"CF"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Coded Element with Formatted Values "; } }

        public string Description { get { return @"This data type transmits codes and the formatted text associated with the code.  This data type can be used to transmit for the first time the formatted text for the canned text portion of a report, for example, a standard radiologic description for a normal chest x-ray.  The receiving system can store this information and in subsequent messages only the identifier need be sent.  Another potential use of this data type is transmitting master file records that contain formatted text.

Example: 
OBX||CF|71020^CXR^CPMC||79989^ \H\Description:\N\\.sp\\ti+4\Heart is not enlarged.  There is no evidence of pneumonia, effusion, pneumothorax or any masses.\.sp+3\\H\Impression: \N\\.sp\\.ti+4\Negative chest.^CPMC "; } }

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
                            Id = @"CF.1",
                            Type = @"DataTypeComponent",
                            Position = @"CF.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.2",
                            Type = @"DataTypeComponent",
                            Position = @"CF.2",
                            Name = @"Formatted Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.3",
                            Type = @"DataTypeComponent",
                            Position = @"CF.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.4",
                            Type = @"DataTypeComponent",
                            Position = @"CF.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.5",
                            Type = @"DataTypeComponent",
                            Position = @"CF.5",
                            Name = @"Alternate Formatted Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.6",
                            Type = @"DataTypeComponent",
                            Position = @"CF.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
