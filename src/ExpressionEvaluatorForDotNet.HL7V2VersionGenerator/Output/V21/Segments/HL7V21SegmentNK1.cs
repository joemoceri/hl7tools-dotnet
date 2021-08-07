using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentNK1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"NK1"; } }

        public string SegmentId { get { return @"NK1"; } }
        
        public string LongName { get { return @"Next Of Kin"; } }
        
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
                            Id = @"NK1.1",
                            Type = @"Field",
                            Position = @"NK1.1",
                            Name = @"Set Id - Next Of Kin",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Set Id",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.2",
                            Type = @"Field",
                            Position = @"NK1.2",
                            Name = @"Next Of Kin Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.3",
                            Type = @"Field",
                            Position = @"NK1.3",
                            Name = @"Next Of Kin Relationship",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0063",
                            TableName = @"RELATIONSHIP",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4",
                            Type = @"Field",
                            Position = @"NK1.4",
                            Name = @"Next Of Kin - Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.5",
                            Type = @"Field",
                            Position = @"NK1.5",
                            Name = @"Next Of Kin - Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
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

        public HL7V21SegmentNK1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field setIdNextOfKin;

public HL7V21Field SetIdNextOfKin
{
    get
    {
        if (setIdNextOfKin != null)
        {
            return setIdNextOfKin;
        }

        setIdNextOfKin = new HL7V21Field
        {
            field = message[@"NK1"][1],
            Id = @"NK1.1",
            Type = @"Field",
            Position = @"NK1.1",
            Name = @"Set Id - Next Of Kin",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return setIdNextOfKin;
    } 
}
internal HL7V21Field nextOfKinName;

public HL7V21Field NextOfKinName
{
    get
    {
        if (nextOfKinName != null)
        {
            return nextOfKinName;
        }

        nextOfKinName = new HL7V21Field
        {
            field = message[@"NK1"][2],
            Id = @"NK1.2",
            Type = @"Field",
            Position = @"NK1.2",
            Name = @"Next Of Kin Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return nextOfKinName;
    } 
}
internal HL7V21Field nextOfKinRelationship;

public HL7V21Field NextOfKinRelationship
{
    get
    {
        if (nextOfKinRelationship != null)
        {
            return nextOfKinRelationship;
        }

        nextOfKinRelationship = new HL7V21Field
        {
            field = message[@"NK1"][3],
            Id = @"NK1.3",
            Type = @"Field",
            Position = @"NK1.3",
            Name = @"Next Of Kin Relationship",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0063",
            TableName = @"RELATIONSHIP",
            Description = null,
            Sample = @"",
        };

        

        

        

        return nextOfKinRelationship;
    } 
}
internal HL7V21Field nextOfKinAddress;

public HL7V21Field NextOfKinAddress
{
    get
    {
        if (nextOfKinAddress != null)
        {
            return nextOfKinAddress;
        }

        nextOfKinAddress = new HL7V21Field
        {
            field = message[@"NK1"][4],
            Id = @"NK1.4",
            Type = @"Field",
            Position = @"NK1.4",
            Name = @"Next Of Kin - Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return nextOfKinAddress;
    } 
}
internal HL7V21Field nextOfKinPhoneNumber;

public HL7V21Field NextOfKinPhoneNumber
{
    get
    {
        if (nextOfKinPhoneNumber != null)
        {
            return nextOfKinPhoneNumber;
        }

        nextOfKinPhoneNumber = new HL7V21Field
        {
            field = message[@"NK1"][5],
            Id = @"NK1.5",
            Type = @"Field",
            Position = @"NK1.5",
            Name = @"Next Of Kin - Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return nextOfKinPhoneNumber;
    } 
}

    }
}
