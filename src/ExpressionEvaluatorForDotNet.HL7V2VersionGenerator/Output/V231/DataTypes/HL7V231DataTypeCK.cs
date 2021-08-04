using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataTypeCK
    {
        public string Id { get { return @"CK"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Composite ID With Check Digit"; } }

        public string Description { get { return @"This data type is used for certain fields that commonly contain check digits, e.g., BLG-3-account ID.  If a site is not using check digits for a particular CK field, the second and third components are not valued.

Example:
|128952^6^M11^ADT01|"; } }

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
                            Id = @"CK.1",
                            Type = @"DataTypeComponent",
                            Position = @"CK.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CK.2",
                            Type = @"DataTypeComponent",
                            Position = @"CK.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CK.3",
                            Type = @"DataTypeComponent",
                            Position = @"CK.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme .",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CK.4",
                            Type = @"DataTypeComponent",
                            Position = @"CK.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component, namespace ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
