using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentUB2
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"UB2"; } }

        public string SegmentId { get { return @"UB2"; } }
        
        public string LongName { get { return @"Ub92 Data"; } }
        
        public string Description { get { return @"The UB2 segment contains data necessary to complete UB92 bills.  Only UB92 data elements that do not exist in other HL7 defined segments will appear in this segment.  Just as with the UB82 billing, Patient Name and Date of Birth are required, they are included in the PID segment and therefore do not appear here.  Where the field locators are different on the UB92, when compared to the UB82, the element is listed with its new location in parentheses ()."; } }
        
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
                            Id = @"UB2.1",
                            Type = @"Field",
                            Position = @"UB2.1",
                            Name = @"Set Id - Ub92",
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
                            Id = @"UB2.2",
                            Type = @"Field",
                            Position = @"UB2.2",
                            Name = @"Co-insurance Days (9)",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @" UB92 data element 9. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.3",
                            Type = @"Field",
                            Position = @"UB2.3",
                            Name = @"Condition Code (24-30)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"7",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0043",
                            TableName = @"CONDITION CODE",
                            Description = @"repeats up to seven times.  UB92 data elements 24-30.  Refer to user-defined table 0043 - condition code. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.4",
                            Type = @"Field",
                            Position = @"UB2.4",
                            Name = @"Covered Days (7)",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"UB92 data element 7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.5",
                            Type = @"Field",
                            Position = @"UB2.5",
                            Name = @"Non-covered Days (8)",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"UB92 data element 8. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6",
                            Type = @"Field",
                            Position = @"UB2.6",
                            Name = @"Value Amount And Code (39-41)",
                            Length = 11,
                            Usage = @"O",
                            Rpt = @"12",
                            DataType = @"CM_UVC",
                            DataTypeName = @"Value Code And Amount",
                            TableId = null,
                            TableName = null,
                            Description = @"pair can repeat up to 12 times.  UB92 data elements 39a, 39b, 39c, 39d, 40a, 40b, 40c, 40d, 41a, 41b, 41c, 41d. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1",
                            Type = @"Component",
                            Position = @"UB2.6.1",
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
                            Id = @"UB2.6.2",
                            Type = @"Component",
                            Position = @"UB2.6.2",
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
                            Id = @"UB2.7",
                            Type = @"Field",
                            Position = @"UB2.7",
                            Name = @"Occurrence Code And Date (32-35)",
                            Length = 11,
                            Usage = @"O",
                            Rpt = @"8",
                            DataType = @"CM_OCD",
                            DataTypeName = @"Occurence",
                            TableId = null,
                            TableName = null,
                            Description = @"set of values can repeat up to eight times.  UB92 data elements 32a, 32b, 33a, 33b, 34a, 34b, 35a, 35b",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1",
                            Type = @"Component",
                            Position = @"UB2.7.1",
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
                            Id = @"UB2.7.2",
                            Type = @"Component",
                            Position = @"UB2.7.2",
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
                            Id = @"UB2.8",
                            Type = @"Field",
                            Position = @"UB2.8",
                            Name = @"Occurrence Span Code / Dates (36)",
                            Length = 28,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"CM_OSP",
                            DataTypeName = @"Occurence Span",
                            TableId = null,
                            TableName = null,
                            Description = @"can repeat up to two times.  UB92 data element 36a, 36b. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1",
                            Type = @"Component",
                            Position = @"UB2.8.1",
                            Name = @"Occurrence Span Code",
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
                            Id = @"UB2.8.2",
                            Type = @"Component",
                            Position = @"UB2.8.2",
                            Name = @"Occurrence Span Start Date",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.3",
                            Type = @"Component",
                            Position = @"UB2.8.3",
                            Name = @"Occurrence Span Stop Date",
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
                            Id = @"UB2.9",
                            Type = @"Field",
                            Position = @"UB2.9",
                            Name = @"Ub92 Locator 2 (state)",
                            Length = 29,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"may repeat up to two times",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.10",
                            Type = @"Field",
                            Position = @"UB2.10",
                            Name = @"Ub92 Locator 11 (state)",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"may repeat up to two times",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.11",
                            Type = @"Field",
                            Position = @"UB2.11",
                            Name = @"Ub92 Locator 31 (national)",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"defined by HICFA or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.12",
                            Type = @"Field",
                            Position = @"UB2.12",
                            Name = @"Document Control Number (37)",
                            Length = 23,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"number assigned by payor.  Used for rebilling/adjustment purposes.  May repeat up to 3 times.  UB92 data element 37",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.13",
                            Type = @"Field",
                            Position = @"UB2.13",
                            Name = @"Ub92 Locator 49 (national)",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"23",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"may repeat up to 23 times",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.14",
                            Type = @"Field",
                            Position = @"UB2.14",
                            Name = @"Ub92 Locator 56 (state)",
                            Length = 14,
                            Usage = @"O",
                            Rpt = @"5",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"may repeat up to five times",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.15",
                            Type = @"Field",
                            Position = @"UB2.15",
                            Name = @"Ub92 Locator 57 (national)",
                            Length = 27,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"defined by UB-92 HICFA specification",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.16",
                            Type = @"Field",
                            Position = @"UB2.16",
                            Name = @"Ub92 Locator 78 (state)",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"may repeat up to two times",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentUB2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field setIdUb92;

public HL7V22Field SetIdUb92
{
    get
    {
        if (setIdUb92 != null)
        {
            return setIdUb92;
        }

        setIdUb92 = new HL7V22Field
        {
            field = message[@"UB2"][1],
            Id = @"UB2.1",
            Type = @"Field",
            Position = @"UB2.1",
            Name = @"Set Id - Ub92",
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

        

        

        

        return setIdUb92;
    } 
}
internal HL7V22Field coinsuranceDays(9);

public HL7V22Field CoinsuranceDays(9)
{
    get
    {
        if (coinsuranceDays(9) != null)
        {
            return coinsuranceDays(9);
        }

        coinsuranceDays(9) = new HL7V22Field
        {
            field = message[@"UB2"][2],
            Id = @"UB2.2",
            Type = @"Field",
            Position = @"UB2.2",
            Name = @"Co-insurance Days (9)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @" UB92 data element 9. ",
            Sample = @"",
        };

        

        

        

        return coinsuranceDays(9);
    } 
}
internal HL7V22Field conditionCode(2430);

public HL7V22Field ConditionCode(2430)
{
    get
    {
        if (conditionCode(2430) != null)
        {
            return conditionCode(2430);
        }

        conditionCode(2430) = new HL7V22Field
        {
            field = message[@"UB2"][3],
            Id = @"UB2.3",
            Type = @"Field",
            Position = @"UB2.3",
            Name = @"Condition Code (24-30)",
            Length = 2,
            Usage = @"O",
            Rpt = @"7",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0043",
            TableName = @"CONDITION CODE",
            Description = @"repeats up to seven times.  UB92 data elements 24-30.  Refer to user-defined table 0043 - condition code. ",
            Sample = @"",
        };

        

        

        

        return conditionCode(2430);
    } 
}
internal HL7V22Field coveredDays(7);

public HL7V22Field CoveredDays(7)
{
    get
    {
        if (coveredDays(7) != null)
        {
            return coveredDays(7);
        }

        coveredDays(7) = new HL7V22Field
        {
            field = message[@"UB2"][4],
            Id = @"UB2.4",
            Type = @"Field",
            Position = @"UB2.4",
            Name = @"Covered Days (7)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"UB92 data element 7.",
            Sample = @"",
        };

        

        

        

        return coveredDays(7);
    } 
}
internal HL7V22Field noncoveredDays(8);

public HL7V22Field NoncoveredDays(8)
{
    get
    {
        if (noncoveredDays(8) != null)
        {
            return noncoveredDays(8);
        }

        noncoveredDays(8) = new HL7V22Field
        {
            field = message[@"UB2"][5],
            Id = @"UB2.5",
            Type = @"Field",
            Position = @"UB2.5",
            Name = @"Non-covered Days (8)",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"UB92 data element 8. ",
            Sample = @"",
        };

        

        

        

        return noncoveredDays(8);
    } 
}
internal HL7V22Field valueAmountAndCode(3941);

public HL7V22Field ValueAmountAndCode(3941)
{
    get
    {
        if (valueAmountAndCode(3941) != null)
        {
            return valueAmountAndCode(3941);
        }

        valueAmountAndCode(3941) = new HL7V22Field
        {
            field = message[@"UB2"][6],
            Id = @"UB2.6",
            Type = @"Field",
            Position = @"UB2.6",
            Name = @"Value Amount And Code (39-41)",
            Length = 11,
            Usage = @"O",
            Rpt = @"12",
            DataType = @"CM_UVC",
            DataTypeName = @"Value Code And Amount",
            TableId = null,
            TableName = null,
            Description = @"pair can repeat up to 12 times.  UB92 data elements 39a, 39b, 39c, 39d, 40a, 40b, 40c, 40d, 41a, 41b, 41c, 41d. ",
            Sample = @"",
        };

        

        

        

        return valueAmountAndCode(3941);
    } 
}
internal HL7V22Field occurrenceCodeAndDate(3235);

public HL7V22Field OccurrenceCodeAndDate(3235)
{
    get
    {
        if (occurrenceCodeAndDate(3235) != null)
        {
            return occurrenceCodeAndDate(3235);
        }

        occurrenceCodeAndDate(3235) = new HL7V22Field
        {
            field = message[@"UB2"][7],
            Id = @"UB2.7",
            Type = @"Field",
            Position = @"UB2.7",
            Name = @"Occurrence Code And Date (32-35)",
            Length = 11,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"CM_OCD",
            DataTypeName = @"Occurence",
            TableId = null,
            TableName = null,
            Description = @"set of values can repeat up to eight times.  UB92 data elements 32a, 32b, 33a, 33b, 34a, 34b, 35a, 35b",
            Sample = @"",
        };

        

        

        

        return occurrenceCodeAndDate(3235);
    } 
}
internal HL7V22Field occurrenceSpanCodeDates(36);

public HL7V22Field OccurrenceSpanCodeDates(36)
{
    get
    {
        if (occurrenceSpanCodeDates(36) != null)
        {
            return occurrenceSpanCodeDates(36);
        }

        occurrenceSpanCodeDates(36) = new HL7V22Field
        {
            field = message[@"UB2"][8],
            Id = @"UB2.8",
            Type = @"Field",
            Position = @"UB2.8",
            Name = @"Occurrence Span Code / Dates (36)",
            Length = 28,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"CM_OSP",
            DataTypeName = @"Occurence Span",
            TableId = null,
            TableName = null,
            Description = @"can repeat up to two times.  UB92 data element 36a, 36b. ",
            Sample = @"",
        };

        

        

        

        return occurrenceSpanCodeDates(36);
    } 
}
internal HL7V22Field ub92Locator2(state);

public HL7V22Field Ub92Locator2(state)
{
    get
    {
        if (ub92Locator2(state) != null)
        {
            return ub92Locator2(state);
        }

        ub92Locator2(state) = new HL7V22Field
        {
            field = message[@"UB2"][9],
            Id = @"UB2.9",
            Type = @"Field",
            Position = @"UB2.9",
            Name = @"Ub92 Locator 2 (state)",
            Length = 29,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"may repeat up to two times",
            Sample = @"",
        };

        

        

        

        return ub92Locator2(state);
    } 
}
internal HL7V22Field ub92Locator11(state);

public HL7V22Field Ub92Locator11(state)
{
    get
    {
        if (ub92Locator11(state) != null)
        {
            return ub92Locator11(state);
        }

        ub92Locator11(state) = new HL7V22Field
        {
            field = message[@"UB2"][10],
            Id = @"UB2.10",
            Type = @"Field",
            Position = @"UB2.10",
            Name = @"Ub92 Locator 11 (state)",
            Length = 12,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"may repeat up to two times",
            Sample = @"",
        };

        

        

        

        return ub92Locator11(state);
    } 
}
internal HL7V22Field ub92Locator31(national);

public HL7V22Field Ub92Locator31(national)
{
    get
    {
        if (ub92Locator31(national) != null)
        {
            return ub92Locator31(national);
        }

        ub92Locator31(national) = new HL7V22Field
        {
            field = message[@"UB2"][11],
            Id = @"UB2.11",
            Type = @"Field",
            Position = @"UB2.11",
            Name = @"Ub92 Locator 31 (national)",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by HICFA or other regulatory agencies",
            Sample = @"",
        };

        

        

        

        return ub92Locator31(national);
    } 
}
internal HL7V22Field documentControlNumber(37);

public HL7V22Field DocumentControlNumber(37)
{
    get
    {
        if (documentControlNumber(37) != null)
        {
            return documentControlNumber(37);
        }

        documentControlNumber(37) = new HL7V22Field
        {
            field = message[@"UB2"][12],
            Id = @"UB2.12",
            Type = @"Field",
            Position = @"UB2.12",
            Name = @"Document Control Number (37)",
            Length = 23,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"number assigned by payor.  Used for rebilling/adjustment purposes.  May repeat up to 3 times.  UB92 data element 37",
            Sample = @"",
        };

        

        

        

        return documentControlNumber(37);
    } 
}
internal HL7V22Field ub92Locator49(national);

public HL7V22Field Ub92Locator49(national)
{
    get
    {
        if (ub92Locator49(national) != null)
        {
            return ub92Locator49(national);
        }

        ub92Locator49(national) = new HL7V22Field
        {
            field = message[@"UB2"][13],
            Id = @"UB2.13",
            Type = @"Field",
            Position = @"UB2.13",
            Name = @"Ub92 Locator 49 (national)",
            Length = 4,
            Usage = @"O",
            Rpt = @"23",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"may repeat up to 23 times",
            Sample = @"",
        };

        

        

        

        return ub92Locator49(national);
    } 
}
internal HL7V22Field ub92Locator56(state);

public HL7V22Field Ub92Locator56(state)
{
    get
    {
        if (ub92Locator56(state) != null)
        {
            return ub92Locator56(state);
        }

        ub92Locator56(state) = new HL7V22Field
        {
            field = message[@"UB2"][14],
            Id = @"UB2.14",
            Type = @"Field",
            Position = @"UB2.14",
            Name = @"Ub92 Locator 56 (state)",
            Length = 14,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"may repeat up to five times",
            Sample = @"",
        };

        

        

        

        return ub92Locator56(state);
    } 
}
internal HL7V22Field ub92Locator57(national);

public HL7V22Field Ub92Locator57(national)
{
    get
    {
        if (ub92Locator57(national) != null)
        {
            return ub92Locator57(national);
        }

        ub92Locator57(national) = new HL7V22Field
        {
            field = message[@"UB2"][15],
            Id = @"UB2.15",
            Type = @"Field",
            Position = @"UB2.15",
            Name = @"Ub92 Locator 57 (national)",
            Length = 27,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by UB-92 HICFA specification",
            Sample = @"",
        };

        

        

        

        return ub92Locator57(national);
    } 
}
internal HL7V22Field ub92Locator78(state);

public HL7V22Field Ub92Locator78(state)
{
    get
    {
        if (ub92Locator78(state) != null)
        {
            return ub92Locator78(state);
        }

        ub92Locator78(state) = new HL7V22Field
        {
            field = message[@"UB2"][16],
            Id = @"UB2.16",
            Type = @"Field",
            Position = @"UB2.16",
            Name = @"Ub92 Locator 78 (state)",
            Length = 2,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"may repeat up to two times",
            Sample = @"",
        };

        

        

        

        return ub92Locator78(state);
    } 
}

    }
}
