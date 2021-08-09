using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentUB2
    {
        public HL7V2Message message { get; init; }

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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
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

        // check for repetitions
        if (setIdUb92.field.FieldRepetitions != null && setIdUb92.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdUb92.Id));
            setIdUb92.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(setIdUb92, fieldData);
        }

        return setIdUb92;
    } 
}

internal HL7V22Field coinsuranceDays9;

public HL7V22Field CoinsuranceDays9
{
    get
    {
        if (coinsuranceDays9 != null)
        {
            return coinsuranceDays9;
        }

        coinsuranceDays9 = new HL7V22Field
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

        // check for repetitions
        if (coinsuranceDays9.field.FieldRepetitions != null && coinsuranceDays9.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(coinsuranceDays9.Id));
            coinsuranceDays9.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(coinsuranceDays9, fieldData);
        }

        return coinsuranceDays9;
    } 
}

internal HL7V22Field conditionCode2430;

public HL7V22Field ConditionCode2430
{
    get
    {
        if (conditionCode2430 != null)
        {
            return conditionCode2430;
        }

        conditionCode2430 = new HL7V22Field
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

        // check for repetitions
        if (conditionCode2430.field.FieldRepetitions != null && conditionCode2430.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(conditionCode2430.Id));
            conditionCode2430.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(conditionCode2430, fieldData);
        }

        return conditionCode2430;
    } 
}

internal HL7V22Field coveredDays7;

public HL7V22Field CoveredDays7
{
    get
    {
        if (coveredDays7 != null)
        {
            return coveredDays7;
        }

        coveredDays7 = new HL7V22Field
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

        // check for repetitions
        if (coveredDays7.field.FieldRepetitions != null && coveredDays7.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(coveredDays7.Id));
            coveredDays7.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(coveredDays7, fieldData);
        }

        return coveredDays7;
    } 
}

internal HL7V22Field noncoveredDays8;

public HL7V22Field NoncoveredDays8
{
    get
    {
        if (noncoveredDays8 != null)
        {
            return noncoveredDays8;
        }

        noncoveredDays8 = new HL7V22Field
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

        // check for repetitions
        if (noncoveredDays8.field.FieldRepetitions != null && noncoveredDays8.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(noncoveredDays8.Id));
            noncoveredDays8.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(noncoveredDays8, fieldData);
        }

        return noncoveredDays8;
    } 
}

internal HL7V22Field valueAmountAndCode3941;

public HL7V22Field ValueAmountAndCode3941
{
    get
    {
        if (valueAmountAndCode3941 != null)
        {
            return valueAmountAndCode3941;
        }

        valueAmountAndCode3941 = new HL7V22Field
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

        // check for repetitions
        if (valueAmountAndCode3941.field.FieldRepetitions != null && valueAmountAndCode3941.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(valueAmountAndCode3941.Id));
            valueAmountAndCode3941.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(valueAmountAndCode3941, fieldData);
        }

        return valueAmountAndCode3941;
    } 
}

internal HL7V22Field occurrenceCodeAndDate3235;

public HL7V22Field OccurrenceCodeAndDate3235
{
    get
    {
        if (occurrenceCodeAndDate3235 != null)
        {
            return occurrenceCodeAndDate3235;
        }

        occurrenceCodeAndDate3235 = new HL7V22Field
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

        // check for repetitions
        if (occurrenceCodeAndDate3235.field.FieldRepetitions != null && occurrenceCodeAndDate3235.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(occurrenceCodeAndDate3235.Id));
            occurrenceCodeAndDate3235.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(occurrenceCodeAndDate3235, fieldData);
        }

        return occurrenceCodeAndDate3235;
    } 
}

internal HL7V22Field occurrenceSpanCodeDates36;

public HL7V22Field OccurrenceSpanCodeDates36
{
    get
    {
        if (occurrenceSpanCodeDates36 != null)
        {
            return occurrenceSpanCodeDates36;
        }

        occurrenceSpanCodeDates36 = new HL7V22Field
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

        // check for repetitions
        if (occurrenceSpanCodeDates36.field.FieldRepetitions != null && occurrenceSpanCodeDates36.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(occurrenceSpanCodeDates36.Id));
            occurrenceSpanCodeDates36.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(occurrenceSpanCodeDates36, fieldData);
        }

        return occurrenceSpanCodeDates36;
    } 
}

internal HL7V22Field ub92Locator2state;

public HL7V22Field Ub92Locator2state
{
    get
    {
        if (ub92Locator2state != null)
        {
            return ub92Locator2state;
        }

        ub92Locator2state = new HL7V22Field
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

        // check for repetitions
        if (ub92Locator2state.field.FieldRepetitions != null && ub92Locator2state.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ub92Locator2state.Id));
            ub92Locator2state.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(ub92Locator2state, fieldData);
        }

        return ub92Locator2state;
    } 
}

internal HL7V22Field ub92Locator11state;

public HL7V22Field Ub92Locator11state
{
    get
    {
        if (ub92Locator11state != null)
        {
            return ub92Locator11state;
        }

        ub92Locator11state = new HL7V22Field
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

        // check for repetitions
        if (ub92Locator11state.field.FieldRepetitions != null && ub92Locator11state.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ub92Locator11state.Id));
            ub92Locator11state.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(ub92Locator11state, fieldData);
        }

        return ub92Locator11state;
    } 
}

internal HL7V22Field ub92Locator31national;

public HL7V22Field Ub92Locator31national
{
    get
    {
        if (ub92Locator31national != null)
        {
            return ub92Locator31national;
        }

        ub92Locator31national = new HL7V22Field
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

        // check for repetitions
        if (ub92Locator31national.field.FieldRepetitions != null && ub92Locator31national.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ub92Locator31national.Id));
            ub92Locator31national.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(ub92Locator31national, fieldData);
        }

        return ub92Locator31national;
    } 
}

internal HL7V22Field documentControlNumber37;

public HL7V22Field DocumentControlNumber37
{
    get
    {
        if (documentControlNumber37 != null)
        {
            return documentControlNumber37;
        }

        documentControlNumber37 = new HL7V22Field
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

        // check for repetitions
        if (documentControlNumber37.field.FieldRepetitions != null && documentControlNumber37.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(documentControlNumber37.Id));
            documentControlNumber37.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(documentControlNumber37, fieldData);
        }

        return documentControlNumber37;
    } 
}

internal HL7V22Field ub92Locator49national;

public HL7V22Field Ub92Locator49national
{
    get
    {
        if (ub92Locator49national != null)
        {
            return ub92Locator49national;
        }

        ub92Locator49national = new HL7V22Field
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

        // check for repetitions
        if (ub92Locator49national.field.FieldRepetitions != null && ub92Locator49national.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ub92Locator49national.Id));
            ub92Locator49national.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(ub92Locator49national, fieldData);
        }

        return ub92Locator49national;
    } 
}

internal HL7V22Field ub92Locator56state;

public HL7V22Field Ub92Locator56state
{
    get
    {
        if (ub92Locator56state != null)
        {
            return ub92Locator56state;
        }

        ub92Locator56state = new HL7V22Field
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

        // check for repetitions
        if (ub92Locator56state.field.FieldRepetitions != null && ub92Locator56state.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ub92Locator56state.Id));
            ub92Locator56state.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(ub92Locator56state, fieldData);
        }

        return ub92Locator56state;
    } 
}

internal HL7V22Field ub92Locator57national;

public HL7V22Field Ub92Locator57national
{
    get
    {
        if (ub92Locator57national != null)
        {
            return ub92Locator57national;
        }

        ub92Locator57national = new HL7V22Field
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

        // check for repetitions
        if (ub92Locator57national.field.FieldRepetitions != null && ub92Locator57national.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ub92Locator57national.Id));
            ub92Locator57national.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(ub92Locator57national, fieldData);
        }

        return ub92Locator57national;
    } 
}

internal HL7V22Field ub92Locator78state;

public HL7V22Field Ub92Locator78state
{
    get
    {
        if (ub92Locator78state != null)
        {
            return ub92Locator78state;
        }

        ub92Locator78state = new HL7V22Field
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

        // check for repetitions
        if (ub92Locator78state.field.FieldRepetitions != null && ub92Locator78state.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ub92Locator78state.Id));
            ub92Locator78state.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(ub92Locator78state, fieldData);
        }

        return ub92Locator78state;
    } 
}
    }
}
