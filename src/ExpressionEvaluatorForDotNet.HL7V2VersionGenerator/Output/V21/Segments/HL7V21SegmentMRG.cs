using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentMRG
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"MRG"; } }

        public string SegmentId { get { return @"MRG"; } }
        
        public string LongName { get { return @"Merge Patient Information"; } }
        
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
                            Id = @"MRG.1",
                            Type = @"Field",
                            Position = @"MRG.1",
                            Name = @"Prior Patient Id - Internal",
                            Length = 16,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.2",
                            Type = @"Field",
                            Position = @"MRG.2",
                            Name = @"Prior Alternate Patient Id",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.3",
                            Type = @"Field",
                            Position = @"MRG.3",
                            Name = @"Prior Patient Account Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentMRG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field priorPatientIdInternal;

public HL7V21Field PriorPatientIdInternal
{
    get
    {
        if (priorPatientIdInternal != null)
        {
            return priorPatientIdInternal;
        }

        priorPatientIdInternal = new HL7V21Field
        {
            field = message[@"MRG"][1],
            Id = @"MRG.1",
            Type = @"Field",
            Position = @"MRG.1",
            Name = @"Prior Patient Id - Internal",
            Length = 16,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return priorPatientIdInternal;
    } 
}
internal HL7V21Field priorAlternatePatientId;

public HL7V21Field PriorAlternatePatientId
{
    get
    {
        if (priorAlternatePatientId != null)
        {
            return priorAlternatePatientId;
        }

        priorAlternatePatientId = new HL7V21Field
        {
            field = message[@"MRG"][2],
            Id = @"MRG.2",
            Type = @"Field",
            Position = @"MRG.2",
            Name = @"Prior Alternate Patient Id",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return priorAlternatePatientId;
    } 
}
internal HL7V21Field priorPatientAccountNumber;

public HL7V21Field PriorPatientAccountNumber
{
    get
    {
        if (priorPatientAccountNumber != null)
        {
            return priorPatientAccountNumber;
        }

        priorPatientAccountNumber = new HL7V21Field
        {
            field = message[@"MRG"][3],
            Id = @"MRG.3",
            Type = @"Field",
            Position = @"MRG.3",
            Name = @"Prior Patient Account Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return priorPatientAccountNumber;
    } 
}

    }
}
