using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataTypePTS
    {
        public string Id { get { return @"PTS"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Authentication person, time stamp "; } }

        public string Description { get { return @"This field contains a set of components describing by whom and when authentication was performed.  Whenever any one of the ID number - Name type code component s is valued, the when authenticated component, which is time stamp, must be valued as non-null.  If the time component of a set is valued as non-null, the person component becomes required. These subcomponents are normally delimited by an ampersand (&).  See Chapter 2."; } }

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
                            Id = @"PTS.1",
                            Type = @"DataTypeComponent",
                            Position = @"PTS.1",
                            Name = @"Authentication person",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component identifies the person who has authenticated the document (either manually or electronically).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTS.2",
                            Type = @"DataTypeComponent",
                            Position = @"PTS.2",
                            Name = @"Authentication time stamp",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the date and time the document was authenticated (either manually or electronically).",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
