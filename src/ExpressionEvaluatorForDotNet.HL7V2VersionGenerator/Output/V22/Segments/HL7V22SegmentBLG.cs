using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentBLG
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"BLG"; } }

        public string SegmentId { get { return @"BLG"; } }
        
        public string LongName { get { return @"Billing"; } }
        
        public string Description { get { return @"The BLG segment is used to provide billing information, on the ordered service, to the filling application"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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
                            Id = @"BLG.1",
                            Type = @"Field",
                            Position = @"BLG.1",
                            Name = @"When To Charge",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_CCD",
                            DataTypeName = @"Charge Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field determines when to charge for the ordered service.  The first component contains a value defined in table 0100 - when to charge.  The second component is used to express the exact time to charge for the ordered service; it is used only when the when to charge value is T.  When used, it is expressed as a TS data type",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"BLG.1.1",
                            Type = @"Component",
                            Position = @"BLG.1.1",
                            Name = @"When To Charge",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0100",
                            TableName = @"WHEN TO CHARGE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLG.1.2",
                            Type = @"Component",
                            Position = @"BLG.1.2",
                            Name = @"Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"BLG.1.2.1",
                            Type = @"SubComponent",
                            Position = @"BLG.1.2.1",
                            Name = @"Time Of An Event",
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
                            Id = @"BLG.1.2.2",
                            Type = @"SubComponent",
                            Position = @"BLG.1.2.2",
                            Name = @"Degree Of Precision",
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
                        },}
                        },}
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
                            Description = @"identifies someone or something other than the patient to be billed for this service.  It is used in conjunction with BLG-3-account ID",
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
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the account to be billed.  It is used in conjunction with BLG-2-charge type.  Refer to table 0061 - check digit scheme in Chapter 2. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"BLG.3.1",
                            Type = @"Component",
                            Position = @"BLG.3.1",
                            Name = @"ID Number",
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
                            Id = @"BLG.3.2",
                            Type = @"Component",
                            Position = @"BLG.3.2",
                            Name = @"Check Digit",
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
                            Id = @"BLG.3.3",
                            Type = @"Component",
                            Position = @"BLG.3.3",
                            Name = @"Code Identifying the Check Digit Scheme Employed ",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = @"The check digit scheme codes are defined in table 0061 - check digit scheme. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLG.3.4",
                            Type = @"Component",
                            Position = @"BLG.3.4",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility ID is a unique name (up to six characters in length) of the system that stores the data.  It is an ST data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning facility ID's are unique across a given HL7 implementation.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V22SegmentBLG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field whenToCharge;

public HL7V22Field WhenToCharge
{
    get
    {
        if (whenToCharge != null)
        {
            return whenToCharge;
        }

        whenToCharge = new HL7V22Field
        {
            field = message[@"BLG"][1],
            Id = @"BLG.1",
            Type = @"Field",
            Position = @"BLG.1",
            Name = @"When To Charge",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_CCD",
            DataTypeName = @"Charge Time",
            TableId = null,
            TableName = null,
            Description = @"This field determines when to charge for the ordered service.  The first component contains a value defined in table 0100 - when to charge.  The second component is used to express the exact time to charge for the ordered service; it is used only when the when to charge value is T.  When used, it is expressed as a TS data type",
            Sample = @"",
        };

        // check for repetitions
        if (whenToCharge.field.FieldRepetitions != null && whenToCharge.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whenToCharge.Id));
            whenToCharge.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(whenToCharge, fieldData);
        }

        return whenToCharge;
    } 
}

internal HL7V22Field chargeType;

public HL7V22Field ChargeType
{
    get
    {
        if (chargeType != null)
        {
            return chargeType;
        }

        chargeType = new HL7V22Field
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
            Description = @"identifies someone or something other than the patient to be billed for this service.  It is used in conjunction with BLG-3-account ID",
            Sample = @"",
        };

        // check for repetitions
        if (chargeType.field.FieldRepetitions != null && chargeType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(chargeType.Id));
            chargeType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(chargeType, fieldData);
        }

        return chargeType;
    } 
}

internal HL7V22Field accountId;

public HL7V22Field AccountId
{
    get
    {
        if (accountId != null)
        {
            return accountId;
        }

        accountId = new HL7V22Field
        {
            field = message[@"BLG"][3],
            Id = @"BLG.3",
            Type = @"Field",
            Position = @"BLG.3",
            Name = @"Account Id",
            Length = 100,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"Identifies the account to be billed.  It is used in conjunction with BLG-2-charge type.  Refer to table 0061 - check digit scheme in Chapter 2. ",
            Sample = @"",
        };

        // check for repetitions
        if (accountId.field.FieldRepetitions != null && accountId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(accountId.Id));
            accountId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(accountId, fieldData);
        }

        return accountId;
    } 
}
    }
}
