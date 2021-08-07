using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentACC
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ACC"; } }

        public string SegmentId { get { return @"ACC"; } }
        
        public string LongName { get { return @"Accident"; } }
        
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
                            Id = @"ACC.1",
                            Type = @"Field",
                            Position = @"ACC.1",
                            Name = @"Accident Date/Time",
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
                            Id = @"ACC.2",
                            Type = @"Field",
                            Position = @"ACC.2",
                            Name = @"Accident Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0050",
                            TableName = @"ACCIDENT CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ACC.3",
                            Type = @"Field",
                            Position = @"ACC.3",
                            Name = @"Accident Location",
                            Length = 25,
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
                        };
            }
        }

        public HL7V21SegmentACC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field accidentDateTime;

public HL7V21Field AccidentDateTime
{
    get
    {
        if (accidentDateTime != null)
        {
            return accidentDateTime;
        }

        accidentDateTime = new HL7V21Field
        {
            field = message[@"ACC"][1],
            Id = @"ACC.1",
            Type = @"Field",
            Position = @"ACC.1",
            Name = @"Accident Date/Time",
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

        

        

        

        return accidentDateTime;
    } 
}
internal HL7V21Field accidentCode;

public HL7V21Field AccidentCode
{
    get
    {
        if (accidentCode != null)
        {
            return accidentCode;
        }

        accidentCode = new HL7V21Field
        {
            field = message[@"ACC"][2],
            Id = @"ACC.2",
            Type = @"Field",
            Position = @"ACC.2",
            Name = @"Accident Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0050",
            TableName = @"ACCIDENT CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return accidentCode;
    } 
}
internal HL7V21Field accidentLocation;

public HL7V21Field AccidentLocation
{
    get
    {
        if (accidentLocation != null)
        {
            return accidentLocation;
        }

        accidentLocation = new HL7V21Field
        {
            field = message[@"ACC"][3],
            Id = @"ACC.3",
            Type = @"Field",
            Position = @"ACC.3",
            Name = @"Accident Location",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return accidentLocation;
    } 
}

    }
}
