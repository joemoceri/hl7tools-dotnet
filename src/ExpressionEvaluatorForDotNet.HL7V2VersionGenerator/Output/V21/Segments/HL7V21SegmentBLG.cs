using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentBLG
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"BLG"; } }

        public string SegmentId { get { return @"BLG"; } }
        
        public string LongName { get { return @"Billing"; } }
        
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
                            Id = @"BLG.1",
                            Type = @"Field",
                            Position = @"BLG.1",
                            Name = @"When To Charge",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = @"0100",
                            TableName = @"WHEN TO CHARGE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLG.2",
                            Type = @"Field",
                            Position = @"BLG.2",
                            Name = @"Charge Type",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0122",
                            TableName = @"CHARGE TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLG.3",
                            Type = @"Field",
                            Position = @"BLG.3",
                            Name = @"Account Id",
                            Length = 100,
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
                        };
            }
        }

        public HL7V21SegmentBLG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field whenToCharge;

public HL7V21Field WhenToCharge
{
    get
    {
        if (whenToCharge != null)
        {
            return whenToCharge;
        }

        whenToCharge = new HL7V21Field
        {
            field = message[@"BLG"][1],
            Id = @"BLG.1",
            Type = @"Field",
            Position = @"BLG.1",
            Name = @"When To Charge",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = @"0100",
            TableName = @"WHEN TO CHARGE",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (whenToCharge.field.FieldRepetitions != null && whenToCharge.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whenToCharge.Id));
            whenToCharge.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(whenToCharge, fieldData);
        }

        return whenToCharge;
    } 
}

internal HL7V21Field chargeType;

public HL7V21Field ChargeType
{
    get
    {
        if (chargeType != null)
        {
            return chargeType;
        }

        chargeType = new HL7V21Field
        {
            field = message[@"BLG"][2],
            Id = @"BLG.2",
            Type = @"Field",
            Position = @"BLG.2",
            Name = @"Charge Type",
            Length = 50,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0122",
            TableName = @"CHARGE TYPE",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (chargeType.field.FieldRepetitions != null && chargeType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(chargeType.Id));
            chargeType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(chargeType, fieldData);
        }

        return chargeType;
    } 
}

internal HL7V21Field accountId;

public HL7V21Field AccountId
{
    get
    {
        if (accountId != null)
        {
            return accountId;
        }

        accountId = new HL7V21Field
        {
            field = message[@"BLG"][3],
            Id = @"BLG.3",
            Type = @"Field",
            Position = @"BLG.3",
            Name = @"Account Id",
            Length = 100,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (accountId.field.FieldRepetitions != null && accountId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(accountId.Id));
            accountId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(accountId, fieldData);
        }

        return accountId;
    } 
}
    }
}
