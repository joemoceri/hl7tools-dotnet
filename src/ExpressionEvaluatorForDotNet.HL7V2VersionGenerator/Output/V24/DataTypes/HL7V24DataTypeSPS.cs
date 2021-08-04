using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataType
    {
        public string Id { get { return @"SPS"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Specimen Source"; } }

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
                            Id = @"SPS.1",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.1",
                            Name = @"Specimen Source Name Or Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0070",
                            TableName = @"Specimen source codes",
                            Description = @"The first component contains the specimen source name or code (as a CE data type component).  (Even in the case of observations whose name implies the source, a source may be required, e.g., blood culture-heart blood.)  Refer to HL7 Table 0070 - Specimen source codes for valid entries.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.2",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.2",
                            Name = @"Additives",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component should include free text additives to the specimen such as Heparin, EDTA, or Oxlate, when applicable.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.3",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.3",
                            Name = @"Freetext",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The third is a free text component describing the method of collection when that information is a part of the order.  When the method of collection is logically an observation result, it should be included as a result segment.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.4",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.4",
                            Name = @"Body Site",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0163",
                            TableName = @"Body site",
                            Description = @"The fourth component specifies the body site from which the specimen was obtained, and the fifth is the site modifier.  For example, the site could be antecubital fossa, and the site modifier “right.”  The components of the CE fields become subcomponents.  Refer to HL7 Table 0163 - Body site for valid entries.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.5",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.5",
                            Name = @"Site Modifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"The fifth component indicates whether the specimen is frozen as part of the collection method.  Suggested values are F (Frozen); R (Refrigerated).  If the component is blank, the specimen is assumed to be at room temperature.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.6",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.6",
                            Name = @"Collection Modifier Method Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPS.7",
                            Type = @"DataTypeComponent",
                            Position = @"SPS.7",
                            Name = @"Specimen Role",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0369",
                            TableName = @"Specimen role",
                            Description = @"The 7th component indicates the role of the sample.  Refer to User-defined Table 0369 – Specimen Role for suggested values.  Each of these values is normally identifiable by the systems and its components and can influence processing and data management related to the specimen.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
