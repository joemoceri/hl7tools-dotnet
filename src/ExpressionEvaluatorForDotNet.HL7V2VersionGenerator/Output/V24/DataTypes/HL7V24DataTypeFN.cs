using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataType
    {
        public string Id { get { return @"FN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Family Name"; } }

        public string Description { get { return @"This data type allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root.

Note: Appears ONLY in the PN and other PN-containing data types (PPN, XCN, XPN)."; } }

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
                            Id = @"FN.1",
                            Type = @"DataTypeComponent",
                            Position = @"FN.1",
                            Name = @"Surname",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = @"The atomic element of the person's family name. In most Western usage, this is the person's last name.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FN.2",
                            Type = @"DataTypeComponent",
                            Position = @"FN.2",
                            Name = @"Own Surname Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FN.3",
                            Type = @"DataTypeComponent",
                            Position = @"FN.3",
                            Name = @"Own Surname",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FN.4",
                            Type = @"DataTypeComponent",
                            Position = @"FN.4",
                            Name = @"Surname Prefix From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FN.5",
                            Type = @"DataTypeComponent",
                            Position = @"FN.5",
                            Name = @"Surname From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
