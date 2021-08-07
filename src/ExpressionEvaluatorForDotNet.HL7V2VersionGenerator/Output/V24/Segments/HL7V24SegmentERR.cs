using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentERR
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ERR"; } }

        public string SegmentId { get { return @"ERR"; } }
        
        public string LongName { get { return @"Error"; } }
        
        public string Description { get { return @"The ERR segment is used to add error comments to acknowledgment messages."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
                    };
            }
        }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERR.1",
                            Type = @"Field",
                            Position = @"ERR.1",
                            Name = @"Error Code and Location",
                            Length = 80,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ELD",
                            DataTypeName = @"Error",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies an erroneous segment in another message. The second component is an index if there is more than one segment of type <segment ID>. For systems that do not use the HL7 Encoding Rules, the data item number may be used for the third component. The fourth component (which references HL7 Table 0357 - Message error condition codes , (as a CE data type)) is restricted from having any subcomponents as the subcomponent separator is now the CEs component separator.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.1",
                            Type = @"Component",
                            Position = @"ERR.1.1",
                            Name = @"Segment ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.2",
                            Type = @"Component",
                            Position = @"ERR.1.2",
                            Name = @"Sequence",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.3",
                            Type = @"Component",
                            Position = @"ERR.1.3",
                            Name = @"Field Position",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4",
                            Type = @"Component",
                            Position = @"ERR.1.4",
                            Name = @"Code Identifying Error",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.1",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.2",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.3",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.4",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.5",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.6",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        },
                        };
            }
        }

        public HL7V24SegmentERR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field errorCodeandLocation;

public HL7V24Field ErrorCodeandLocation
{
    get
    {
        if (errorCodeandLocation != null)
        {
            return errorCodeandLocation;
        }

        errorCodeandLocation = new HL7V24Field
        {
            field = message[@"ERR"][1],
            Id = @"ERR.1",
            Type = @"Field",
            Position = @"ERR.1",
            Name = @"Error Code and Location",
            Length = 80,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ELD",
            DataTypeName = @"Error",
            TableId = null,
            TableName = null,
            Description = @"This field identifies an erroneous segment in another message. The second component is an index if there is more than one segment of type <segment ID>. For systems that do not use the HL7 Encoding Rules, the data item number may be used for the third component. The fourth component (which references HL7 Table 0357 - Message error condition codes , (as a CE data type)) is restricted from having any subcomponents as the subcomponent separator is now the CEs component separator.",
            Sample = @"",
        };

        

        

        

        return errorCodeandLocation;
    } 
}

    }
}
