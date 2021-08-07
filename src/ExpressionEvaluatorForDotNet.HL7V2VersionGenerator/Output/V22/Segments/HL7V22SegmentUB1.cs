using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentUB1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"UB1"; } }

        public string SegmentId { get { return @"UB1"; } }
        
        public string LongName { get { return @"Ub82 Data"; } }
        
        public string Description { get { return @"The UB1 segment contains data necessary to complete UB82 bills.  Only UB82 data elements that do not exist in other HL7 defined segments will appear in this segment.  Patient name and Date of Birth are required for UB82 billing, however, they are included in the PID segment and therefore do not appear here"; } }
        
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
                            Name = @"Set Id - Ub82",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = @"number used to uniquely identify the transaction for the purpose of adding, changing, or deleting the entry",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.2",
                            Type = @"Field",
                            Position = @"UB1.2",
                            Name = @"Blood Deductible (43)",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"It is recommended that IN2-21-blood deductible be used instead of this field as the blood deductible can be associated with the specific insurance plan via that segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.3",
                            Type = @"Field",
                            Position = @"UB1.3",
                            Name = @"Blood Furnished Pints Of (40)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"amount of blood furnished the patient for this visit.  The (40) indicates the corresponding UB82 Data Element number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.4",
                            Type = @"Field",
                            Position = @"UB1.4",
                            Name = @"Blood Replaced Pints (41)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"UB82 Data Element 41.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.5",
                            Type = @"Field",
                            Position = @"UB1.5",
                            Name = @"Blood Not Replaced Pints (42)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Blood not replaced.  Measured in pints.  UB82 Data Element 42 ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.6",
                            Type = @"Field",
                            Position = @"UB1.6",
                            Name = @"Co-insurance Days (25)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"UB82 Data Element 25.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.7",
                            Type = @"Field",
                            Position = @"UB1.7",
                            Name = @"Condition Code (35-39)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"5",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0043",
                            TableName = @"CONDITION CODE",
                            Description = @"repeats 5 times.  UB82 Data Elements (35), (36), (37), (38),and (39).   Refer to user-defined table 0043 - condition code for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.8",
                            Type = @"Field",
                            Position = @"UB1.8",
                            Name = @"Covered Days (23)",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"UB82 Data Element 23",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.9",
                            Type = @"Field",
                            Position = @"UB1.9",
                            Name = @"Non-covered Days (24)",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"UB82 Data Element 24",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10",
                            Type = @"Field",
                            Position = @"UB1.10",
                            Name = @"Value Amount And Code (46-49)",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"8",
                            DataType = @"CM_UVC",
                            DataTypeName = @"Value Code And Amount",
                            TableId = null,
                            TableName = null,
                            Description = @"pair can repeat up to eight times.  (46A, 47A, 48A, 49A, 46B, 47B, 48B, and 49B).  Refer to userdefined table 0153 - value code for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.1",
                            Type = @"Component",
                            Position = @"UB1.10.1",
                            Name = @"Value Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0153",
                            TableName = @"VALUE CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.2",
                            Type = @"Component",
                            Position = @"UB1.10.2",
                            Name = @"Value Amount",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.11",
                            Type = @"Field",
                            Position = @"UB1.11",
                            Name = @"Number Of Grace Days (90)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"UB82 Data Element 90",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12",
                            Type = @"Field",
                            Position = @"UB1.12",
                            Name = @"Special Program Indicator (44)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"special program indicator.  UB82 Data Element 44.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13",
                            Type = @"Field",
                            Position = @"UB1.13",
                            Name = @"Psro / Ur Approval Indicator (87)",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"PSRO/UR approval indicator.  UB82 data element 87",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.14",
                            Type = @"Field",
                            Position = @"UB1.14",
                            Name = @"Psro / Ur Approved Stay - From (88)",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"PSRO/UR approved stay date (from).  UB82 Data Element 88.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.15",
                            Type = @"Field",
                            Position = @"UB1.15",
                            Name = @"Psro / Ur Approved Stay - To (89)",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"PSRO/UR approved stay date (to).  UB82 Data Element 89",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16",
                            Type = @"Field",
                            Position = @"UB1.16",
                            Name = @"Occurrence (28-32)",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"5",
                            DataType = @"CM_OCD",
                            DataTypeName = @"Occurence",
                            TableId = null,
                            TableName = null,
                            Description = @"set of values can repeat up to five times.  UB82 Data Elements 28-32",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1",
                            Type = @"Component",
                            Position = @"UB1.16.1",
                            Name = @"Occurrence Code",
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
                            Id = @"UB1.16.2",
                            Type = @"Component",
                            Position = @"UB1.16.2",
                            Name = @"Occurrence Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17",
                            Type = @"Field",
                            Position = @"UB1.17",
                            Name = @"Occurrence Span (33)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"UB82 Data Element 33.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.18",
                            Type = @"Field",
                            Position = @"UB1.18",
                            Name = @"Occurrence Span Start Date (33)",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"occurrence span start date.  UB82 Data Element 33",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.19",
                            Type = @"Field",
                            Position = @"UB1.19",
                            Name = @"Occurrence Span End Date (33)",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"occurrence span end date.  UB82 Data Element 33.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.20",
                            Type = @"Field",
                            Position = @"UB1.20",
                            Name = @"Ub-82 Locator 2",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"defined by UB-82 HICFA specification",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.21",
                            Type = @"Field",
                            Position = @"UB1.21",
                            Name = @"Ub-82 Locator 9",
                            Length = 7,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"defined by UB-82 HICFA specification",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.22",
                            Type = @"Field",
                            Position = @"UB1.22",
                            Name = @"Ub-82 Locator 27",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"defined by UB-82 HICFA specification",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.23",
                            Type = @"Field",
                            Position = @"UB1.23",
                            Name = @"Ub-82 Locator 45",
                            Length = 17,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"defined by UB-82 HICFA specification",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentUB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field setIdUb82;

public HL7V22Field SetIdUb82
{
    get
    {
        if (setIdUb82 != null)
        {
            return setIdUb82;
        }

        setIdUb82 = new HL7V22Field
        {
            field = message[@"UB1"][1],
            Id = @"UB1.1",
            Type = @"Field",
            Position = @"UB1.1",
            Name = @"Set Id - Ub82",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"number used to uniquely identify the transaction for the purpose of adding, changing, or deleting the entry",
            Sample = @"",
        };

        

        

        

        return setIdUb82;
    } 
}
internal HL7V22Field bloodDeductible(43);

public HL7V22Field BloodDeductible(43)
{
    get
    {
        if (bloodDeductible(43) != null)
        {
            return bloodDeductible(43);
        }

        bloodDeductible(43) = new HL7V22Field
        {
            field = message[@"UB1"][2],
            Id = @"UB1.2",
            Type = @"Field",
            Position = @"UB1.2",
            Name = @"Blood Deductible (43)",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"It is recommended that IN2-21-blood deductible be used instead of this field as the blood deductible can be associated with the specific insurance plan via that segment",
            Sample = @"",
        };

        

        

        

        return bloodDeductible(43);
    } 
}
internal HL7V22Field bloodFurnishedPintsOf(40);

public HL7V22Field BloodFurnishedPintsOf(40)
{
    get
    {
        if (bloodFurnishedPintsOf(40) != null)
        {
            return bloodFurnishedPintsOf(40);
        }

        bloodFurnishedPintsOf(40) = new HL7V22Field
        {
            field = message[@"UB1"][3],
            Id = @"UB1.3",
            Type = @"Field",
            Position = @"UB1.3",
            Name = @"Blood Furnished Pints Of (40)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount of blood furnished the patient for this visit.  The (40) indicates the corresponding UB82 Data Element number",
            Sample = @"",
        };

        

        

        

        return bloodFurnishedPintsOf(40);
    } 
}
internal HL7V22Field bloodReplacedPints(41);

public HL7V22Field BloodReplacedPints(41)
{
    get
    {
        if (bloodReplacedPints(41) != null)
        {
            return bloodReplacedPints(41);
        }

        bloodReplacedPints(41) = new HL7V22Field
        {
            field = message[@"UB1"][4],
            Id = @"UB1.4",
            Type = @"Field",
            Position = @"UB1.4",
            Name = @"Blood Replaced Pints (41)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"UB82 Data Element 41.",
            Sample = @"",
        };

        

        

        

        return bloodReplacedPints(41);
    } 
}
internal HL7V22Field bloodNotReplacedPints(42);

public HL7V22Field BloodNotReplacedPints(42)
{
    get
    {
        if (bloodNotReplacedPints(42) != null)
        {
            return bloodNotReplacedPints(42);
        }

        bloodNotReplacedPints(42) = new HL7V22Field
        {
            field = message[@"UB1"][5],
            Id = @"UB1.5",
            Type = @"Field",
            Position = @"UB1.5",
            Name = @"Blood Not Replaced Pints (42)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Blood not replaced.  Measured in pints.  UB82 Data Element 42 ",
            Sample = @"",
        };

        

        

        

        return bloodNotReplacedPints(42);
    } 
}
internal HL7V22Field coinsuranceDays(25);

public HL7V22Field CoinsuranceDays(25)
{
    get
    {
        if (coinsuranceDays(25) != null)
        {
            return coinsuranceDays(25);
        }

        coinsuranceDays(25) = new HL7V22Field
        {
            field = message[@"UB1"][6],
            Id = @"UB1.6",
            Type = @"Field",
            Position = @"UB1.6",
            Name = @"Co-insurance Days (25)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"UB82 Data Element 25.",
            Sample = @"",
        };

        

        

        

        return coinsuranceDays(25);
    } 
}
internal HL7V22Field conditionCode(3539);

public HL7V22Field ConditionCode(3539)
{
    get
    {
        if (conditionCode(3539) != null)
        {
            return conditionCode(3539);
        }

        conditionCode(3539) = new HL7V22Field
        {
            field = message[@"UB1"][7],
            Id = @"UB1.7",
            Type = @"Field",
            Position = @"UB1.7",
            Name = @"Condition Code (35-39)",
            Length = 2,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0043",
            TableName = @"CONDITION CODE",
            Description = @"repeats 5 times.  UB82 Data Elements (35), (36), (37), (38),and (39).   Refer to user-defined table 0043 - condition code for suggested values",
            Sample = @"",
        };

        

        

        

        return conditionCode(3539);
    } 
}
internal HL7V22Field coveredDays(23);

public HL7V22Field CoveredDays(23)
{
    get
    {
        if (coveredDays(23) != null)
        {
            return coveredDays(23);
        }

        coveredDays(23) = new HL7V22Field
        {
            field = message[@"UB1"][8],
            Id = @"UB1.8",
            Type = @"Field",
            Position = @"UB1.8",
            Name = @"Covered Days (23)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"UB82 Data Element 23",
            Sample = @"",
        };

        

        

        

        return coveredDays(23);
    } 
}
internal HL7V22Field noncoveredDays(24);

public HL7V22Field NoncoveredDays(24)
{
    get
    {
        if (noncoveredDays(24) != null)
        {
            return noncoveredDays(24);
        }

        noncoveredDays(24) = new HL7V22Field
        {
            field = message[@"UB1"][9],
            Id = @"UB1.9",
            Type = @"Field",
            Position = @"UB1.9",
            Name = @"Non-covered Days (24)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"UB82 Data Element 24",
            Sample = @"",
        };

        

        

        

        return noncoveredDays(24);
    } 
}
internal HL7V22Field valueAmountAndCode(4649);

public HL7V22Field ValueAmountAndCode(4649)
{
    get
    {
        if (valueAmountAndCode(4649) != null)
        {
            return valueAmountAndCode(4649);
        }

        valueAmountAndCode(4649) = new HL7V22Field
        {
            field = message[@"UB1"][10],
            Id = @"UB1.10",
            Type = @"Field",
            Position = @"UB1.10",
            Name = @"Value Amount And Code (46-49)",
            Length = 12,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"CM_UVC",
            DataTypeName = @"Value Code And Amount",
            TableId = null,
            TableName = null,
            Description = @"pair can repeat up to eight times.  (46A, 47A, 48A, 49A, 46B, 47B, 48B, and 49B).  Refer to userdefined table 0153 - value code for suggested values",
            Sample = @"",
        };

        

        

        

        return valueAmountAndCode(4649);
    } 
}
internal HL7V22Field numberOfGraceDays(90);

public HL7V22Field NumberOfGraceDays(90)
{
    get
    {
        if (numberOfGraceDays(90) != null)
        {
            return numberOfGraceDays(90);
        }

        numberOfGraceDays(90) = new HL7V22Field
        {
            field = message[@"UB1"][11],
            Id = @"UB1.11",
            Type = @"Field",
            Position = @"UB1.11",
            Name = @"Number Of Grace Days (90)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"UB82 Data Element 90",
            Sample = @"",
        };

        

        

        

        return numberOfGraceDays(90);
    } 
}
internal HL7V22Field specialProgramIndicator(44);

public HL7V22Field SpecialProgramIndicator(44)
{
    get
    {
        if (specialProgramIndicator(44) != null)
        {
            return specialProgramIndicator(44);
        }

        specialProgramIndicator(44) = new HL7V22Field
        {
            field = message[@"UB1"][12],
            Id = @"UB1.12",
            Type = @"Field",
            Position = @"UB1.12",
            Name = @"Special Program Indicator (44)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"special program indicator.  UB82 Data Element 44.",
            Sample = @"",
        };

        

        

        

        return specialProgramIndicator(44);
    } 
}
internal HL7V22Field psroUrApprovalIndicator(87);

public HL7V22Field PsroUrApprovalIndicator(87)
{
    get
    {
        if (psroUrApprovalIndicator(87) != null)
        {
            return psroUrApprovalIndicator(87);
        }

        psroUrApprovalIndicator(87) = new HL7V22Field
        {
            field = message[@"UB1"][13],
            Id = @"UB1.13",
            Type = @"Field",
            Position = @"UB1.13",
            Name = @"Psro / Ur Approval Indicator (87)",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"PSRO/UR approval indicator.  UB82 data element 87",
            Sample = @"",
        };

        

        

        

        return psroUrApprovalIndicator(87);
    } 
}
internal HL7V22Field psroUrApprovedStayFrom(88);

public HL7V22Field PsroUrApprovedStayFrom(88)
{
    get
    {
        if (psroUrApprovedStayFrom(88) != null)
        {
            return psroUrApprovedStayFrom(88);
        }

        psroUrApprovedStayFrom(88) = new HL7V22Field
        {
            field = message[@"UB1"][14],
            Id = @"UB1.14",
            Type = @"Field",
            Position = @"UB1.14",
            Name = @"Psro / Ur Approved Stay - From (88)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"PSRO/UR approved stay date (from).  UB82 Data Element 88.",
            Sample = @"",
        };

        

        

        

        return psroUrApprovedStayFrom(88);
    } 
}
internal HL7V22Field psroUrApprovedStayTo(89);

public HL7V22Field PsroUrApprovedStayTo(89)
{
    get
    {
        if (psroUrApprovedStayTo(89) != null)
        {
            return psroUrApprovedStayTo(89);
        }

        psroUrApprovedStayTo(89) = new HL7V22Field
        {
            field = message[@"UB1"][15],
            Id = @"UB1.15",
            Type = @"Field",
            Position = @"UB1.15",
            Name = @"Psro / Ur Approved Stay - To (89)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"PSRO/UR approved stay date (to).  UB82 Data Element 89",
            Sample = @"",
        };

        

        

        

        return psroUrApprovedStayTo(89);
    } 
}
internal HL7V22Field occurrence(2832);

public HL7V22Field Occurrence(2832)
{
    get
    {
        if (occurrence(2832) != null)
        {
            return occurrence(2832);
        }

        occurrence(2832) = new HL7V22Field
        {
            field = message[@"UB1"][16],
            Id = @"UB1.16",
            Type = @"Field",
            Position = @"UB1.16",
            Name = @"Occurrence (28-32)",
            Length = 20,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"CM_OCD",
            DataTypeName = @"Occurence",
            TableId = null,
            TableName = null,
            Description = @"set of values can repeat up to five times.  UB82 Data Elements 28-32",
            Sample = @"",
        };

        

        

        

        return occurrence(2832);
    } 
}
internal HL7V22Field occurrenceSpan(33);

public HL7V22Field OccurrenceSpan(33)
{
    get
    {
        if (occurrenceSpan(33) != null)
        {
            return occurrenceSpan(33);
        }

        occurrenceSpan(33) = new HL7V22Field
        {
            field = message[@"UB1"][17],
            Id = @"UB1.17",
            Type = @"Field",
            Position = @"UB1.17",
            Name = @"Occurrence Span (33)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"UB82 Data Element 33.",
            Sample = @"",
        };

        

        

        

        return occurrenceSpan(33);
    } 
}
internal HL7V22Field occurrenceSpanStartDate(33);

public HL7V22Field OccurrenceSpanStartDate(33)
{
    get
    {
        if (occurrenceSpanStartDate(33) != null)
        {
            return occurrenceSpanStartDate(33);
        }

        occurrenceSpanStartDate(33) = new HL7V22Field
        {
            field = message[@"UB1"][18],
            Id = @"UB1.18",
            Type = @"Field",
            Position = @"UB1.18",
            Name = @"Occurrence Span Start Date (33)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"occurrence span start date.  UB82 Data Element 33",
            Sample = @"",
        };

        

        

        

        return occurrenceSpanStartDate(33);
    } 
}
internal HL7V22Field occurrenceSpanEndDate(33);

public HL7V22Field OccurrenceSpanEndDate(33)
{
    get
    {
        if (occurrenceSpanEndDate(33) != null)
        {
            return occurrenceSpanEndDate(33);
        }

        occurrenceSpanEndDate(33) = new HL7V22Field
        {
            field = message[@"UB1"][19],
            Id = @"UB1.19",
            Type = @"Field",
            Position = @"UB1.19",
            Name = @"Occurrence Span End Date (33)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"occurrence span end date.  UB82 Data Element 33.",
            Sample = @"",
        };

        

        

        

        return occurrenceSpanEndDate(33);
    } 
}
internal HL7V22Field ub82Locator2;

public HL7V22Field Ub82Locator2
{
    get
    {
        if (ub82Locator2 != null)
        {
            return ub82Locator2;
        }

        ub82Locator2 = new HL7V22Field
        {
            field = message[@"UB1"][20],
            Id = @"UB1.20",
            Type = @"Field",
            Position = @"UB1.20",
            Name = @"Ub-82 Locator 2",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by UB-82 HICFA specification",
            Sample = @"",
        };

        

        

        

        return ub82Locator2;
    } 
}
internal HL7V22Field ub82Locator9;

public HL7V22Field Ub82Locator9
{
    get
    {
        if (ub82Locator9 != null)
        {
            return ub82Locator9;
        }

        ub82Locator9 = new HL7V22Field
        {
            field = message[@"UB1"][21],
            Id = @"UB1.21",
            Type = @"Field",
            Position = @"UB1.21",
            Name = @"Ub-82 Locator 9",
            Length = 7,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by UB-82 HICFA specification",
            Sample = @"",
        };

        

        

        

        return ub82Locator9;
    } 
}
internal HL7V22Field ub82Locator27;

public HL7V22Field Ub82Locator27
{
    get
    {
        if (ub82Locator27 != null)
        {
            return ub82Locator27;
        }

        ub82Locator27 = new HL7V22Field
        {
            field = message[@"UB1"][22],
            Id = @"UB1.22",
            Type = @"Field",
            Position = @"UB1.22",
            Name = @"Ub-82 Locator 27",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by UB-82 HICFA specification",
            Sample = @"",
        };

        

        

        

        return ub82Locator27;
    } 
}
internal HL7V22Field ub82Locator45;

public HL7V22Field Ub82Locator45
{
    get
    {
        if (ub82Locator45 != null)
        {
            return ub82Locator45;
        }

        ub82Locator45 = new HL7V22Field
        {
            field = message[@"UB1"][23],
            Id = @"UB1.23",
            Type = @"Field",
            Position = @"UB1.23",
            Name = @"Ub-82 Locator 45",
            Length = 17,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by UB-82 HICFA specification",
            Sample = @"",
        };

        

        

        

        return ub82Locator45;
    } 
}

    }
}
