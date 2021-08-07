using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentORO
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ORO"; } }

        public string SegmentId { get { return @"ORO"; } }
        
        public string LongName { get { return @"Order Other"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Id = @"ORO.1",
                            Type = @"Field",
                            Position = @"ORO.1",
                            Name = @"Order Item Id",
                            Length = 200,
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
                            Id = @"ORO.1.1",
                            Type = @"Component",
                            Position = @"ORO.1.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORO.1.2",
                            Type = @"Component",
                            Position = @"ORO.1.2",
                            Name = @"Text",
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
                            Id = @"ORO.1.3",
                            Type = @"Component",
                            Position = @"ORO.1.3",
                            Name = @"Name Of Coding System",
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
                            Id = @"ORO.1.4",
                            Type = @"Component",
                            Position = @"ORO.1.4",
                            Name = @"Alternate Identifier",
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
                            Id = @"ORO.1.5",
                            Type = @"Component",
                            Position = @"ORO.1.5",
                            Name = @"Alternate Text",
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
                            Id = @"ORO.1.6",
                            Type = @"Component",
                            Position = @"ORO.1.6",
                            Name = @"Name Of Alternate Coding System",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORO.2",
                            Type = @"Field",
                            Position = @"ORO.2",
                            Name = @"Substitute Allowed",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORO.3",
                            Type = @"Field",
                            Position = @"ORO.3",
                            Name = @"Results Copies To",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORO.4",
                            Type = @"Field",
                            Position = @"ORO.4",
                            Name = @"Stock Location",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0012",
                            TableName = @"STOCK LOCATION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentORO(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field orderItemId;

public HL7V21Field OrderItemId
{
    get
    {
        if (orderItemId != null)
        {
            return orderItemId;
        }

        orderItemId = new HL7V21Field
        {
            field = message[@"ORO"][1],
            Id = @"ORO.1",
            Type = @"Field",
            Position = @"ORO.1",
            Name = @"Order Item Id",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return orderItemId;
    } 
}
internal HL7V21Field substituteAllowed;

public HL7V21Field SubstituteAllowed
{
    get
    {
        if (substituteAllowed != null)
        {
            return substituteAllowed;
        }

        substituteAllowed = new HL7V21Field
        {
            field = message[@"ORO"][2],
            Id = @"ORO.2",
            Type = @"Field",
            Position = @"ORO.2",
            Name = @"Substitute Allowed",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return substituteAllowed;
    } 
}
internal HL7V21Field resultsCopiesTo;

public HL7V21Field ResultsCopiesTo
{
    get
    {
        if (resultsCopiesTo != null)
        {
            return resultsCopiesTo;
        }

        resultsCopiesTo = new HL7V21Field
        {
            field = message[@"ORO"][3],
            Id = @"ORO.3",
            Type = @"Field",
            Position = @"ORO.3",
            Name = @"Results Copies To",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return resultsCopiesTo;
    } 
}
internal HL7V21Field stockLocation;

public HL7V21Field StockLocation
{
    get
    {
        if (stockLocation != null)
        {
            return stockLocation;
        }

        stockLocation = new HL7V21Field
        {
            field = message[@"ORO"][4],
            Id = @"ORO.4",
            Type = @"Field",
            Position = @"ORO.4",
            Name = @"Stock Location",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0012",
            TableName = @"STOCK LOCATION",
            Description = null,
            Sample = @"",
        };

        

        

        

        return stockLocation;
    } 
}

    }
}
