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

        public HL7V21SegmentBLG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _whenToCharge;

public HL7V21Field WhenToCharge
{
    get
    {
        if (_whenToCharge != null)
        {
            return _whenToCharge;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _whenToCharge = new HL7V21Field
        {
            field = message[@"BLG"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whenToCharge.field.FieldRepetitions != null && _whenToCharge.field.FieldRepetitions.Count > 0)
        {
            _whenToCharge.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_whenToCharge, fieldData);
        }

        return _whenToCharge;
    } 
}

internal HL7V21Field _chargeType;

public HL7V21Field ChargeType
{
    get
    {
        if (_chargeType != null)
        {
            return _chargeType;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _chargeType = new HL7V21Field
        {
            field = message[@"BLG"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_chargeType.field.FieldRepetitions != null && _chargeType.field.FieldRepetitions.Count > 0)
        {
            _chargeType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_chargeType, fieldData);
        }

        return _chargeType;
    } 
}

internal HL7V21Field _accountId;

public HL7V21Field AccountId
{
    get
    {
        if (_accountId != null)
        {
            return _accountId;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _accountId = new HL7V21Field
        {
            field = message[@"BLG"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accountId.field.FieldRepetitions != null && _accountId.field.FieldRepetitions.Count > 0)
        {
            _accountId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_accountId, fieldData);
        }

        return _accountId;
    } 
}
    }
}
