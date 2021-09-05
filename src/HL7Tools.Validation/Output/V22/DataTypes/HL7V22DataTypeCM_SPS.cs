using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeCM_SPS
    {
        public string Id { get { return @"CM_SPS"; } }

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
                            Id = @"CM_SPS.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_SPS.1",
                            Name = @"Specimen Source Name Or Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the specimen source name or code (as a CE data type component).  (Even in the case of observations whose name implies the source, a source may be required, e.g., blood culture-heart blood.) ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_SPS.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_SPS.2",
                            Name = @"Additives",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component should include additives to the specimen such as Heparin, EDTA, or Oxlate, when applicable.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_SPS.3",
                            Type = @"DataTypeComponent",
                            Position = @"CM_SPS.3",
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
                            Id = @"CM_SPS.4",
                            Type = @"DataTypeComponent",
                            Position = @"CM_SPS.4",
                            Name = @"Body Site",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0070",
                            TableName = @"SOURCE OF SPECIMEN",
                            Description = @"The fourth component specifies the body site from which the specimen was obtained, and the fifth is the site modifier.  For example, the site could be anticubital foss, and the site modifier ""right.""   The components of the CE data elements become subcomponents.  Refer to table 0070 - source of specimen for valid entries",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_SPS.5",
                            Type = @"DataTypeComponent",
                            Position = @"CM_SPS.5",
                            Name = @"Site Modifier",
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
                        };
            }
        }
    }
}
