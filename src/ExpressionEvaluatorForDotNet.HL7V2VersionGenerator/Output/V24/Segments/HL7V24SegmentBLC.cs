using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentBLC
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"BLC"; } }

        public string SegmentId { get { return @"BLC"; } }
        
        public string LongName { get { return @"Blood Code"; } }
        
        public string Description { get { return @"The BLC segment contains data necessary to communicate patient abstract blood information used for billing and reimbursement purposes. This segment is repeating to report blood product codes and the associated blood units."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Id = @"BLC.1",
                            Type = @"Field",
                            Position = @"BLC.1",
                            Name = @"Blood Product Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0426",
                            TableName = @"Blood product code",
                            Description = @"This field reports the blood product code. Refer to User-defined Table 0426 - Blood product code for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"BLC.1.1",
                            Type = @"Component",
                            Position = @"BLC.1.1",
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
                            Id = @"BLC.1.2",
                            Type = @"Component",
                            Position = @"BLC.1.2",
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
                            Id = @"BLC.1.3",
                            Type = @"Component",
                            Position = @"BLC.1.3",
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
                            Id = @"BLC.1.4",
                            Type = @"Component",
                            Position = @"BLC.1.4",
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
                            Id = @"BLC.1.5",
                            Type = @"Component",
                            Position = @"BLC.1.5",
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
                            Id = @"BLC.1.6",
                            Type = @"Component",
                            Position = @"BLC.1.6",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLC.2",
                            Type = @"Field",
                            Position = @"BLC.2",
                            Name = @"Blood Amount",
                            Length = 83,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the quantity and units administered for the blood code identified in field 1, for example, 2^pt.  Standard ISO or ANSI units, as defined in Chapter 7 are recommended.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"BLC.2.1",
                            Type = @"Component",
                            Position = @"BLC.2.1",
                            Name = @"Quantity",
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
                            Id = @"BLC.2.2",
                            Type = @"Component",
                            Position = @"BLC.2.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the observation is measured in the default units, the units need not be transmitted. If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component. If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7. If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7. But in these cases the component separator should be replaced by the subcomponent delimiter",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V24SegmentBLC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field bloodProductCode;

public HL7V24Field BloodProductCode
{
    get
    {
        if (bloodProductCode != null)
        {
            return bloodProductCode;
        }

        bloodProductCode = new HL7V24Field
        {
            field = message[@"BLC"][1],
            Id = @"BLC.1",
            Type = @"Field",
            Position = @"BLC.1",
            Name = @"Blood Product Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0426",
            TableName = @"Blood product code",
            Description = @"This field reports the blood product code. Refer to User-defined Table 0426 - Blood product code for suggested values",
            Sample = @"",
        };

        

        

        

        return bloodProductCode;
    } 
}
internal HL7V24Field bloodAmount;

public HL7V24Field BloodAmount
{
    get
    {
        if (bloodAmount != null)
        {
            return bloodAmount;
        }

        bloodAmount = new HL7V24Field
        {
            field = message[@"BLC"][2],
            Id = @"BLC.2",
            Type = @"Field",
            Position = @"BLC.2",
            Name = @"Blood Amount",
            Length = 83,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the quantity and units administered for the blood code identified in field 1, for example, 2^pt.  Standard ISO or ANSI units, as defined in Chapter 7 are recommended.",
            Sample = @"",
        };

        

        

        

        return bloodAmount;
    } 
}

    }
}
