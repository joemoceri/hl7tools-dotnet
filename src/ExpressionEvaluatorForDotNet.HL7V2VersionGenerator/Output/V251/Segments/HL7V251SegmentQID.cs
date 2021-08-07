using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentQID
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"QID"; } }

        public string SegmentId { get { return @"QID"; } }
        
        public string LongName { get { return @"Query Identification"; } }
        
        public string Description { get { return @"The QID segment contains the information necessary to uniquely identify a query. Its primary use is in query cancellation or subscription cancellation."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
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
                            Id = @"QID.1",
                            Type = @"Field",
                            Position = @"QID.1",
                            Name = @"Query Tag",
                            Length = 32,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the instance of a query.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QID.2",
                            Type = @"Field",
                            Position = @"QID.2",
                            Name = @"Message Query Name",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0471",
                            TableName = @"Query name",
                            Description = @"This field contains the name of the query. These names are assigned by the function-specific chapters of this specification. Site-specific query names begin with the letter Z. Refer to User defined table 0471 - Query name for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"QID.2.1",
                            Type = @"Component",
                            Position = @"QID.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QID.2.2",
                            Type = @"Component",
                            Position = @"QID.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QID.2.3",
                            Type = @"Component",
                            Position = @"QID.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QID.2.4",
                            Type = @"Component",
                            Position = @"QID.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QID.2.5",
                            Type = @"Component",
                            Position = @"QID.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QID.2.6",
                            Type = @"Component",
                            Position = @"QID.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V251SegmentQID(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field queryTag;

public HL7V251Field QueryTag
{
    get
    {
        if (queryTag != null)
        {
            return queryTag;
        }

        queryTag = new HL7V251Field
        {
            field = message[@"QID"][1],
            Id = @"QID.1",
            Type = @"Field",
            Position = @"QID.1",
            Name = @"Query Tag",
            Length = 32,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the instance of a query.",
            Sample = @"",
        };

        

        

        

        return queryTag;
    } 
}
internal HL7V251Field messageQueryName;

public HL7V251Field MessageQueryName
{
    get
    {
        if (messageQueryName != null)
        {
            return messageQueryName;
        }

        messageQueryName = new HL7V251Field
        {
            field = message[@"QID"][2],
            Id = @"QID.2",
            Type = @"Field",
            Position = @"QID.2",
            Name = @"Message Query Name",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0471",
            TableName = @"Query name",
            Description = @"This field contains the name of the query. These names are assigned by the function-specific chapters of this specification. Site-specific query names begin with the letter Z. Refer to User defined table 0471 - Query name for suggested values.",
            Sample = @"",
        };

        

        

        

        return messageQueryName;
    } 
}

    }
}
