using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27SegmentUB1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"UB1"; } }

        public string SegmentId { get { return @"UB1"; } }
        
        public string LongName { get { return @"Ub82"; } }
        
        public string Description { get { return @"The UB1 segment contains data specific to the United States. Only billing/claims fields that do not exist in other HL7 defined segments appear in this segment. The codes listed as examples are not an exhaustive or current list.

Attention: UB1-2 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6."; } }
        
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
                            Id = @"UB1.1",
                            Type = @"Field",
                            Position = @"UB1.1",
                            Name = @"Set Id - Ub1",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-1 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.2",
                            Type = @"Field",
                            Position = @"UB1.2",
                            Name = @"Blood Deductible",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-2 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.3",
                            Type = @"Field",
                            Position = @"UB1.3",
                            Name = @"Blood Furnished-pints",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-3 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.4",
                            Type = @"Field",
                            Position = @"UB1.4",
                            Name = @"Blood Replaced-pints",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-4 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.5",
                            Type = @"Field",
                            Position = @"UB1.5",
                            Name = @"Blood Not Replaced-pints",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-5 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.6",
                            Type = @"Field",
                            Position = @"UB1.6",
                            Name = @"Co-insurance Days",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-6 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.7",
                            Type = @"Field",
                            Position = @"UB1.7",
                            Name = @"Condition Code",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"5",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-7 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.8",
                            Type = @"Field",
                            Position = @"UB1.8",
                            Name = @"Covered Days",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-8 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.9",
                            Type = @"Field",
                            Position = @"UB1.9",
                            Name = @"Non Covered Days",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-9 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10",
                            Type = @"Field",
                            Position = @"UB1.10",
                            Name = @"Value Amount & Code",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"8",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-10 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.11",
                            Type = @"Field",
                            Position = @"UB1.11",
                            Name = @"Number Of Grace Days",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-11 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12",
                            Type = @"Field",
                            Position = @"UB1.12",
                            Name = @"Special Program Indicator",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-12 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13",
                            Type = @"Field",
                            Position = @"UB1.13",
                            Name = @"Psro/Ur Approval Indicator",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-13 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.14",
                            Type = @"Field",
                            Position = @"UB1.14",
                            Name = @"Psro/Ur Approved Stay-fm",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-14 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.15",
                            Type = @"Field",
                            Position = @"UB1.15",
                            Name = @"Psro/Ur Approved Stay-to",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-15 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16",
                            Type = @"Field",
                            Position = @"UB1.16",
                            Name = @"Occurrence",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"5",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-16 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17",
                            Type = @"Field",
                            Position = @"UB1.17",
                            Name = @"Occurrence Span",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-17 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.18",
                            Type = @"Field",
                            Position = @"UB1.18",
                            Name = @"Occur Span Start Date",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-18 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.19",
                            Type = @"Field",
                            Position = @"UB1.19",
                            Name = @"Occur Span End Date",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-19 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.20",
                            Type = @"Field",
                            Position = @"UB1.20",
                            Name = @"Ub-82 Locator 2",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-20 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.21",
                            Type = @"Field",
                            Position = @"UB1.21",
                            Name = @"Ub-82 Locator 9",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-21 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.22",
                            Type = @"Field",
                            Position = @"UB1.22",
                            Name = @"Ub-82 Locator 27",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-22 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.23",
                            Type = @"Field",
                            Position = @"UB1.23",
                            Name = @"Ub-82 Locator 45",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: UB1-23 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V27SegmentUB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V27Field setIdUb1;

public HL7V27Field SetIdUb1
{
    get
    {
        if (setIdUb1 != null)
        {
            return setIdUb1;
        }

        setIdUb1 = new HL7V27Field
        {
            field = message[@"UB1"][1],
            Id = @"UB1.1",
            Type = @"Field",
            Position = @"UB1.1",
            Name = @"Set Id - Ub1",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-1 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return setIdUb1;
    } 
}
internal HL7V27Field bloodDeductible;

public HL7V27Field BloodDeductible
{
    get
    {
        if (bloodDeductible != null)
        {
            return bloodDeductible;
        }

        bloodDeductible = new HL7V27Field
        {
            field = message[@"UB1"][2],
            Id = @"UB1.2",
            Type = @"Field",
            Position = @"UB1.2",
            Name = @"Blood Deductible",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-2 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return bloodDeductible;
    } 
}
internal HL7V27Field bloodFurnishedpints;

public HL7V27Field BloodFurnishedpints
{
    get
    {
        if (bloodFurnishedpints != null)
        {
            return bloodFurnishedpints;
        }

        bloodFurnishedpints = new HL7V27Field
        {
            field = message[@"UB1"][3],
            Id = @"UB1.3",
            Type = @"Field",
            Position = @"UB1.3",
            Name = @"Blood Furnished-pints",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-3 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return bloodFurnishedpints;
    } 
}
internal HL7V27Field bloodReplacedpints;

public HL7V27Field BloodReplacedpints
{
    get
    {
        if (bloodReplacedpints != null)
        {
            return bloodReplacedpints;
        }

        bloodReplacedpints = new HL7V27Field
        {
            field = message[@"UB1"][4],
            Id = @"UB1.4",
            Type = @"Field",
            Position = @"UB1.4",
            Name = @"Blood Replaced-pints",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-4 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return bloodReplacedpints;
    } 
}
internal HL7V27Field bloodNotReplacedpints;

public HL7V27Field BloodNotReplacedpints
{
    get
    {
        if (bloodNotReplacedpints != null)
        {
            return bloodNotReplacedpints;
        }

        bloodNotReplacedpints = new HL7V27Field
        {
            field = message[@"UB1"][5],
            Id = @"UB1.5",
            Type = @"Field",
            Position = @"UB1.5",
            Name = @"Blood Not Replaced-pints",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-5 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return bloodNotReplacedpints;
    } 
}
internal HL7V27Field coinsuranceDays;

public HL7V27Field CoinsuranceDays
{
    get
    {
        if (coinsuranceDays != null)
        {
            return coinsuranceDays;
        }

        coinsuranceDays = new HL7V27Field
        {
            field = message[@"UB1"][6],
            Id = @"UB1.6",
            Type = @"Field",
            Position = @"UB1.6",
            Name = @"Co-insurance Days",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-6 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return coinsuranceDays;
    } 
}
internal HL7V27Field conditionCode;

public HL7V27Field ConditionCode
{
    get
    {
        if (conditionCode != null)
        {
            return conditionCode;
        }

        conditionCode = new HL7V27Field
        {
            field = message[@"UB1"][7],
            Id = @"UB1.7",
            Type = @"Field",
            Position = @"UB1.7",
            Name = @"Condition Code",
            Length = 0,
            Usage = @"W",
            Rpt = @"5",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-7 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return conditionCode;
    } 
}
internal HL7V27Field coveredDays;

public HL7V27Field CoveredDays
{
    get
    {
        if (coveredDays != null)
        {
            return coveredDays;
        }

        coveredDays = new HL7V27Field
        {
            field = message[@"UB1"][8],
            Id = @"UB1.8",
            Type = @"Field",
            Position = @"UB1.8",
            Name = @"Covered Days",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-8 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return coveredDays;
    } 
}
internal HL7V27Field nonCoveredDays;

public HL7V27Field NonCoveredDays
{
    get
    {
        if (nonCoveredDays != null)
        {
            return nonCoveredDays;
        }

        nonCoveredDays = new HL7V27Field
        {
            field = message[@"UB1"][9],
            Id = @"UB1.9",
            Type = @"Field",
            Position = @"UB1.9",
            Name = @"Non Covered Days",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-9 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return nonCoveredDays;
    } 
}
internal HL7V27Field valueAmount&Code;

public HL7V27Field ValueAmount&Code
{
    get
    {
        if (valueAmount&Code != null)
        {
            return valueAmount&Code;
        }

        valueAmount&Code = new HL7V27Field
        {
            field = message[@"UB1"][10],
            Id = @"UB1.10",
            Type = @"Field",
            Position = @"UB1.10",
            Name = @"Value Amount & Code",
            Length = 0,
            Usage = @"W",
            Rpt = @"8",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-10 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return valueAmount&Code;
    } 
}
internal HL7V27Field numberOfGraceDays;

public HL7V27Field NumberOfGraceDays
{
    get
    {
        if (numberOfGraceDays != null)
        {
            return numberOfGraceDays;
        }

        numberOfGraceDays = new HL7V27Field
        {
            field = message[@"UB1"][11],
            Id = @"UB1.11",
            Type = @"Field",
            Position = @"UB1.11",
            Name = @"Number Of Grace Days",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-11 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return numberOfGraceDays;
    } 
}
internal HL7V27Field specialProgramIndicator;

public HL7V27Field SpecialProgramIndicator
{
    get
    {
        if (specialProgramIndicator != null)
        {
            return specialProgramIndicator;
        }

        specialProgramIndicator = new HL7V27Field
        {
            field = message[@"UB1"][12],
            Id = @"UB1.12",
            Type = @"Field",
            Position = @"UB1.12",
            Name = @"Special Program Indicator",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-12 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return specialProgramIndicator;
    } 
}
internal HL7V27Field psroUrApprovalIndicator;

public HL7V27Field PsroUrApprovalIndicator
{
    get
    {
        if (psroUrApprovalIndicator != null)
        {
            return psroUrApprovalIndicator;
        }

        psroUrApprovalIndicator = new HL7V27Field
        {
            field = message[@"UB1"][13],
            Id = @"UB1.13",
            Type = @"Field",
            Position = @"UB1.13",
            Name = @"Psro/Ur Approval Indicator",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-13 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return psroUrApprovalIndicator;
    } 
}
internal HL7V27Field psroUrApprovedStayfm;

public HL7V27Field PsroUrApprovedStayfm
{
    get
    {
        if (psroUrApprovedStayfm != null)
        {
            return psroUrApprovedStayfm;
        }

        psroUrApprovedStayfm = new HL7V27Field
        {
            field = message[@"UB1"][14],
            Id = @"UB1.14",
            Type = @"Field",
            Position = @"UB1.14",
            Name = @"Psro/Ur Approved Stay-fm",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-14 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return psroUrApprovedStayfm;
    } 
}
internal HL7V27Field psroUrApprovedStayto;

public HL7V27Field PsroUrApprovedStayto
{
    get
    {
        if (psroUrApprovedStayto != null)
        {
            return psroUrApprovedStayto;
        }

        psroUrApprovedStayto = new HL7V27Field
        {
            field = message[@"UB1"][15],
            Id = @"UB1.15",
            Type = @"Field",
            Position = @"UB1.15",
            Name = @"Psro/Ur Approved Stay-to",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-15 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return psroUrApprovedStayto;
    } 
}
internal HL7V27Field occurrence;

public HL7V27Field Occurrence
{
    get
    {
        if (occurrence != null)
        {
            return occurrence;
        }

        occurrence = new HL7V27Field
        {
            field = message[@"UB1"][16],
            Id = @"UB1.16",
            Type = @"Field",
            Position = @"UB1.16",
            Name = @"Occurrence",
            Length = 0,
            Usage = @"W",
            Rpt = @"5",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-16 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return occurrence;
    } 
}
internal HL7V27Field occurrenceSpan;

public HL7V27Field OccurrenceSpan
{
    get
    {
        if (occurrenceSpan != null)
        {
            return occurrenceSpan;
        }

        occurrenceSpan = new HL7V27Field
        {
            field = message[@"UB1"][17],
            Id = @"UB1.17",
            Type = @"Field",
            Position = @"UB1.17",
            Name = @"Occurrence Span",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-17 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return occurrenceSpan;
    } 
}
internal HL7V27Field occurSpanStartDate;

public HL7V27Field OccurSpanStartDate
{
    get
    {
        if (occurSpanStartDate != null)
        {
            return occurSpanStartDate;
        }

        occurSpanStartDate = new HL7V27Field
        {
            field = message[@"UB1"][18],
            Id = @"UB1.18",
            Type = @"Field",
            Position = @"UB1.18",
            Name = @"Occur Span Start Date",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-18 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return occurSpanStartDate;
    } 
}
internal HL7V27Field occurSpanEndDate;

public HL7V27Field OccurSpanEndDate
{
    get
    {
        if (occurSpanEndDate != null)
        {
            return occurSpanEndDate;
        }

        occurSpanEndDate = new HL7V27Field
        {
            field = message[@"UB1"][19],
            Id = @"UB1.19",
            Type = @"Field",
            Position = @"UB1.19",
            Name = @"Occur Span End Date",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-19 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return occurSpanEndDate;
    } 
}
internal HL7V27Field ub82Locator2;

public HL7V27Field Ub82Locator2
{
    get
    {
        if (ub82Locator2 != null)
        {
            return ub82Locator2;
        }

        ub82Locator2 = new HL7V27Field
        {
            field = message[@"UB1"][20],
            Id = @"UB1.20",
            Type = @"Field",
            Position = @"UB1.20",
            Name = @"Ub-82 Locator 2",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-20 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return ub82Locator2;
    } 
}
internal HL7V27Field ub82Locator9;

public HL7V27Field Ub82Locator9
{
    get
    {
        if (ub82Locator9 != null)
        {
            return ub82Locator9;
        }

        ub82Locator9 = new HL7V27Field
        {
            field = message[@"UB1"][21],
            Id = @"UB1.21",
            Type = @"Field",
            Position = @"UB1.21",
            Name = @"Ub-82 Locator 9",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-21 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return ub82Locator9;
    } 
}
internal HL7V27Field ub82Locator27;

public HL7V27Field Ub82Locator27
{
    get
    {
        if (ub82Locator27 != null)
        {
            return ub82Locator27;
        }

        ub82Locator27 = new HL7V27Field
        {
            field = message[@"UB1"][22],
            Id = @"UB1.22",
            Type = @"Field",
            Position = @"UB1.22",
            Name = @"Ub-82 Locator 27",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-22 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return ub82Locator27;
    } 
}
internal HL7V27Field ub82Locator45;

public HL7V27Field Ub82Locator45
{
    get
    {
        if (ub82Locator45 != null)
        {
            return ub82Locator45;
        }

        ub82Locator45 = new HL7V27Field
        {
            field = message[@"UB1"][23],
            Id = @"UB1.23",
            Type = @"Field",
            Position = @"UB1.23",
            Name = @"Ub-82 Locator 45",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-23 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
        };

        

        

        

        return ub82Locator45;
    } 
}

    }
}
