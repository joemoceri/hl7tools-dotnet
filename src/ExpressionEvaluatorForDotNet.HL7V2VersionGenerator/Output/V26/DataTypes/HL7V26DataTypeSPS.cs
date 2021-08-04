using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"SPS"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Specimen Source"; } }

        public string Description { get { return @"This data type identifies the site where the specimen should be obtained or where the service should be performed."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 4436; } }

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
                            Id = @"SPS.1",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.1",
                            Name = @"Specimen Source Name Or Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"contains the specimen source name or code (as a CWE data type component). (Even in the case of observations whose name implies the source, a source may be required, e.g., blood culture-heart blood.)",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.2",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.2",
                            Name = @"Additives",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0371",
                            TableName = @"Additive/Preservative",
                            Description = @"identifies an additive introduced to the specimen before or at the time of collection. Refer to HL7 Table0371 - Additive in chapter 7 for valid values. The tables values are taken from NCCLS AUTO4. The value set can be extended with user specific values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.3",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.3",
                            Name = @"Specimen Collection Method",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"describes the method of collection when that information is a part of the order. When the method of collection is logically an observation result, it should be included as a result segment (i.e., OBX segment).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.4",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.4",
                            Name = @"Body Site",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0163",
                            TableName = @"Body site",
                            Description = @"This component specifies the body site from which the specimen was obtained. A nationally recognized coding system is to be used for this field. Valid coding sources for this field include:",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.5",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.5",
                            Name = @"Site Modifier",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0495",
                            TableName = @"Body Site Modifier",
                            Description = @"modifies body site. For example, the site could be antecubital fossa, and the site modifier right. Refer to HL7 Table 0495 - Body Site Modifier for allowed values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.6",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.6",
                            Name = @"Collection Method Modifier Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"Indicates whether the specimen is frozen as part of the collection method. Suggested values are F (Frozen); R (Refrigerated). If the component is blank, the specimen is assumed to be at room temperature.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.7",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.7",
                            Name = @"Specimen Role",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0369",
                            TableName = @"Specimen Role",
                            Description = @"indicates the role of the sample. Refer to User-defined Table 0369 - Specimen role for suggested values. Each of these values is normally identifiable by the systems and its components and can influence processing and data management related to the specimen.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
