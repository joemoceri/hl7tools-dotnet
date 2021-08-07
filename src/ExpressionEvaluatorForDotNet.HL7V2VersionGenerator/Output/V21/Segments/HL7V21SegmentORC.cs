using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentORC
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ORC"; } }

        public string SegmentId { get { return @"ORC"; } }
        
        public string LongName { get { return @"Common Order"; } }
        
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
                            Id = @"ORC.1",
                            Type = @"Field",
                            Position = @"ORC.1",
                            Name = @"Order Control",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0119",
                            TableName = @"ORDER CONTROL",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.2",
                            Type = @"Field",
                            Position = @"ORC.2",
                            Name = @"Placer Order #",
                            Length = 75,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.3",
                            Type = @"Field",
                            Position = @"ORC.3",
                            Name = @"Filler Order #",
                            Length = 75,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.4",
                            Type = @"Field",
                            Position = @"ORC.4",
                            Name = @"Placer Group #",
                            Length = 75,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.5",
                            Type = @"Field",
                            Position = @"ORC.5",
                            Name = @"Order Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0038",
                            TableName = @"ORDER STATUS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.6",
                            Type = @"Field",
                            Position = @"ORC.6",
                            Name = @"Response Flag",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0121",
                            TableName = @"RESPONSE FLAG",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.7",
                            Type = @"Field",
                            Position = @"ORC.7",
                            Name = @"Timing/Quantity",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.8",
                            Type = @"Field",
                            Position = @"ORC.8",
                            Name = @"Parent",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.9",
                            Type = @"Field",
                            Position = @"ORC.9",
                            Name = @"Date/Time Of Transaction",
                            Length = 19,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.10",
                            Type = @"Field",
                            Position = @"ORC.10",
                            Name = @"Entered By",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
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
                            Id = @"ORC.11",
                            Type = @"Field",
                            Position = @"ORC.11",
                            Name = @"Verified By",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
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
                            Id = @"ORC.12",
                            Type = @"Field",
                            Position = @"ORC.12",
                            Name = @"Ordering Provider",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
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
                            Id = @"ORC.13",
                            Type = @"Field",
                            Position = @"ORC.13",
                            Name = @"Enterer's Location",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.14",
                            Type = @"Field",
                            Position = @"ORC.14",
                            Name = @"Call Back Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentORC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field orderControl;

public HL7V21Field OrderControl
{
    get
    {
        if (orderControl != null)
        {
            return orderControl;
        }

        orderControl = new HL7V21Field
        {
            field = message[@"ORC"][1],
            Id = @"ORC.1",
            Type = @"Field",
            Position = @"ORC.1",
            Name = @"Order Control",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0119",
            TableName = @"ORDER CONTROL",
            Description = null,
            Sample = @"",
        };

        

        

        

        return orderControl;
    } 
}
internal HL7V21Field placerOrder#;

public HL7V21Field PlacerOrder#
{
    get
    {
        if (placerOrder# != null)
        {
            return placerOrder#;
        }

        placerOrder# = new HL7V21Field
        {
            field = message[@"ORC"][2],
            Id = @"ORC.2",
            Type = @"Field",
            Position = @"ORC.2",
            Name = @"Placer Order #",
            Length = 75,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return placerOrder#;
    } 
}
internal HL7V21Field fillerOrder#;

public HL7V21Field FillerOrder#
{
    get
    {
        if (fillerOrder# != null)
        {
            return fillerOrder#;
        }

        fillerOrder# = new HL7V21Field
        {
            field = message[@"ORC"][3],
            Id = @"ORC.3",
            Type = @"Field",
            Position = @"ORC.3",
            Name = @"Filler Order #",
            Length = 75,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return fillerOrder#;
    } 
}
internal HL7V21Field placerGroup#;

public HL7V21Field PlacerGroup#
{
    get
    {
        if (placerGroup# != null)
        {
            return placerGroup#;
        }

        placerGroup# = new HL7V21Field
        {
            field = message[@"ORC"][4],
            Id = @"ORC.4",
            Type = @"Field",
            Position = @"ORC.4",
            Name = @"Placer Group #",
            Length = 75,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return placerGroup#;
    } 
}
internal HL7V21Field orderStatus;

public HL7V21Field OrderStatus
{
    get
    {
        if (orderStatus != null)
        {
            return orderStatus;
        }

        orderStatus = new HL7V21Field
        {
            field = message[@"ORC"][5],
            Id = @"ORC.5",
            Type = @"Field",
            Position = @"ORC.5",
            Name = @"Order Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0038",
            TableName = @"ORDER STATUS",
            Description = null,
            Sample = @"",
        };

        

        

        

        return orderStatus;
    } 
}
internal HL7V21Field responseFlag;

public HL7V21Field ResponseFlag
{
    get
    {
        if (responseFlag != null)
        {
            return responseFlag;
        }

        responseFlag = new HL7V21Field
        {
            field = message[@"ORC"][6],
            Id = @"ORC.6",
            Type = @"Field",
            Position = @"ORC.6",
            Name = @"Response Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0121",
            TableName = @"RESPONSE FLAG",
            Description = null,
            Sample = @"",
        };

        

        

        

        return responseFlag;
    } 
}
internal HL7V21Field timingQuantity;

public HL7V21Field TimingQuantity
{
    get
    {
        if (timingQuantity != null)
        {
            return timingQuantity;
        }

        timingQuantity = new HL7V21Field
        {
            field = message[@"ORC"][7],
            Id = @"ORC.7",
            Type = @"Field",
            Position = @"ORC.7",
            Name = @"Timing/Quantity",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return timingQuantity;
    } 
}
internal HL7V21Field parent;

public HL7V21Field Parent
{
    get
    {
        if (parent != null)
        {
            return parent;
        }

        parent = new HL7V21Field
        {
            field = message[@"ORC"][8],
            Id = @"ORC.8",
            Type = @"Field",
            Position = @"ORC.8",
            Name = @"Parent",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return parent;
    } 
}
internal HL7V21Field dateTimeOfTransaction;

public HL7V21Field DateTimeOfTransaction
{
    get
    {
        if (dateTimeOfTransaction != null)
        {
            return dateTimeOfTransaction;
        }

        dateTimeOfTransaction = new HL7V21Field
        {
            field = message[@"ORC"][9],
            Id = @"ORC.9",
            Type = @"Field",
            Position = @"ORC.9",
            Name = @"Date/Time Of Transaction",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return dateTimeOfTransaction;
    } 
}
internal HL7V21Field enteredBy;

public HL7V21Field EnteredBy
{
    get
    {
        if (enteredBy != null)
        {
            return enteredBy;
        }

        enteredBy = new HL7V21Field
        {
            field = message[@"ORC"][10],
            Id = @"ORC.10",
            Type = @"Field",
            Position = @"ORC.10",
            Name = @"Entered By",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return enteredBy;
    } 
}
internal HL7V21Field verifiedBy;

public HL7V21Field VerifiedBy
{
    get
    {
        if (verifiedBy != null)
        {
            return verifiedBy;
        }

        verifiedBy = new HL7V21Field
        {
            field = message[@"ORC"][11],
            Id = @"ORC.11",
            Type = @"Field",
            Position = @"ORC.11",
            Name = @"Verified By",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return verifiedBy;
    } 
}
internal HL7V21Field orderingProvider;

public HL7V21Field OrderingProvider
{
    get
    {
        if (orderingProvider != null)
        {
            return orderingProvider;
        }

        orderingProvider = new HL7V21Field
        {
            field = message[@"ORC"][12],
            Id = @"ORC.12",
            Type = @"Field",
            Position = @"ORC.12",
            Name = @"Ordering Provider",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return orderingProvider;
    } 
}
internal HL7V21Field enterer'sLocation;

public HL7V21Field Enterer'sLocation
{
    get
    {
        if (enterer'sLocation != null)
        {
            return enterer'sLocation;
        }

        enterer'sLocation = new HL7V21Field
        {
            field = message[@"ORC"][13],
            Id = @"ORC.13",
            Type = @"Field",
            Position = @"ORC.13",
            Name = @"Enterer's Location",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return enterer'sLocation;
    } 
}
internal HL7V21Field callBackPhoneNumber;

public HL7V21Field CallBackPhoneNumber
{
    get
    {
        if (callBackPhoneNumber != null)
        {
            return callBackPhoneNumber;
        }

        callBackPhoneNumber = new HL7V21Field
        {
            field = message[@"ORC"][14],
            Id = @"ORC.14",
            Type = @"Field",
            Position = @"ORC.14",
            Name = @"Call Back Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return callBackPhoneNumber;
    } 
}

    }
}
