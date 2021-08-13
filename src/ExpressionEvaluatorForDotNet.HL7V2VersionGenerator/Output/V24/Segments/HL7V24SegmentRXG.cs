using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentRXG
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RXG"; } }

        public string SegmentId { get { return @"RXG"; } }
        
        public string LongName { get { return @"Pharmacy/Treatment Give"; } }
        
        public string Description { get { return @""; } }
        
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

        public HL7V24SegmentRXG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _giveSubIDCounter;

public HL7V24Field GiveSubIDCounter
{
    get
    {
        if (_giveSubIDCounter != null)
        {
            return _giveSubIDCounter;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.1",
            Type = @"Field",
            Position = @"RXG.1",
            Name = @"Give Sub-ID Counter",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Use if this RXG segment carries information about a single administration. Starts with 1 for the first scheduled give date/time transmitted by the pharmacy/treatment supplier for this order. Increments by one with each additional scheduled give date/time for this order.",
            Sample = @"",
            Fields = null
        }

        _giveSubIDCounter = new HL7V24Field
        {
            field = message[@"RXG"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveSubIDCounter.field.FieldRepetitions != null && _giveSubIDCounter.field.FieldRepetitions.Count > 0)
        {
            _giveSubIDCounter.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_giveSubIDCounter, fieldData);
        }

        return _giveSubIDCounter;
    } 
}

internal HL7V24Field _dispenseSubIDCounter;

public HL7V24Field DispenseSubIDCounter
{
    get
    {
        if (_dispenseSubIDCounter != null)
        {
            return _dispenseSubIDCounter;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.2",
            Type = @"Field",
            Position = @"RXG.2",
            Name = @"Dispense Sub-ID Counter",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This is the dispense sub-ID to which this give message is related.",
            Sample = @"",
            Fields = null
        }

        _dispenseSubIDCounter = new HL7V24Field
        {
            field = message[@"RXG"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dispenseSubIDCounter.field.FieldRepetitions != null && _dispenseSubIDCounter.field.FieldRepetitions.Count > 0)
        {
            _dispenseSubIDCounter.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_dispenseSubIDCounter, fieldData);
        }

        return _dispenseSubIDCounter;
    } 
}

internal HL7V24Field _quantityTiming;

public HL7V24Field QuantityTiming
{
    get
    {
        if (_quantityTiming != null)
        {
            return _quantityTiming;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.3",
            Type = @"Field",
            Position = @"RXG.3",
            Name = @"Quantity/Timing",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TQ",
            DataTypeName = @"Timing Quantity",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity/timing specification that refers to either a single scheduled give instruction only or to multiple give instructions. In the former case, RXG-1-give sub-ID counter is a positive integer greater than or equal to one (1). In the latter case, RXG-1-give sub-ID counter is zero (0). The quantity will always be 1. This quantity/timing field may differ from the ORC quantity/timing field, which contains the requested quantity/timing of the original order.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.3.1",
                            Type = @"Component",
                            Position = @"RXG.3.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the quantity of the service that should be provided at each service interval. For example, if two blood cultures are to be obtained every 4 hours, the quantity would be 2.  If three units of blood are to be typed and cross-matched, the quantity would be 3.  The default value is 1.  When units are required, they can be added, specified by a subcomponent delimiter.

Note: The component delimiter in this CQ is demoted to a subcomponent delimiter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXG.3.1.1",
                            Type = @"SubComponent",
                            Position = @"RXG.3.1.1",
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
                            Id = @"RXG.3.1.2",
                            Type = @"SubComponent",
                            Position = @"RXG.3.1.2",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.2",
                            Type = @"Component",
                            Position = @"RXG.3.2",
                            Name = @"Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"RI",
                            DataTypeName = @"Repeat Interval",
                            TableId = null,
                            TableName = null,
                            Description = @"This field determines the interval between repeated services.

The default is one time only, the first subcomponent is the repeat pattern, and the second subcomponent is the explicit time at which pattern is to be executed.

Note: The component delimiter in this CQ is demoted to a subcomponent delimiter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXG.3.2.1",
                            Type = @"SubComponent",
                            Position = @"RXG.3.2.1",
                            Name = @"Repeat Pattern",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The repeating frequency with which the treatment is to be administered.  It is similar to the frequency and SIG code tables used in order entry systems. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.2.2",
                            Type = @"SubComponent",
                            Position = @"RXG.3.2.2",
                            Name = @"Explicit Time Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field explicitly lists the actual times referenced by the code in the first subcomponent, in the following format: HHMM,HHMM,HHMM,.…  This second subcomponent will be used to clarify the first subcomponent in cases where the actual administration times vary within an institution.  If the time of the order spans more than a single day, this new subcomponent is only practical if the same times of administration occur for each day of the order.  If the actual start time of the order (as given by the fourth subcomponent of the quantity/timing field) is after the first explicit time, the first administration is taken to be the first explicit time after the start time.  In the case where the patient moves to a location having a different set of explicit times, the existing order may be updated with a new quantity/timing field showing the changed explicit times.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.3",
                            Type = @"Component",
                            Position = @"RXG.3.3",
                            Name = @"Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates how long the service should continue after it is started.  The default is INDEF (do indefinitely). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.4",
                            Type = @"Component",
                            Position = @"RXG.3.4",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be specified by the orderer, in which case it indicates the earliest date/time at which the services should be started.  In many cases, however, the start date/time will be implied or will be defined by other fields in the order record (e.g., urgency - STAT).  In such a case, this field will be empty.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXG.3.4.1",
                            Type = @"SubComponent",
                            Position = @"RXG.3.4.1",
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
                            Id = @"RXG.3.4.2",
                            Type = @"SubComponent",
                            Position = @"RXG.3.4.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.5",
                            Type = @"Component",
                            Position = @"RXG.3.5",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"When filled in by the requester of the service, this field should contain the latest date/time that the service should be performed.  If it has not been performed by the specified time, it should not be performed at all.  The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXG.3.5.1",
                            Type = @"SubComponent",
                            Position = @"RXG.3.5.1",
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
                            Id = @"RXG.3.5.2",
                            Type = @"SubComponent",
                            Position = @"RXG.3.5.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.6",
                            Type = @"Component",
                            Position = @"RXG.3.6",
                            Name = @"Priority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @" This field describes the urgency of the request.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.7",
                            Type = @"Component",
                            Position = @"RXG.3.7",
                            Name = @"Condition",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a free text field that describes the conditions under which the drug is to be given.  For example, PRN pain, or to keep blood pressure below 110.  The presence of text in this field should be taken to mean that human review is needed to determine the how and/or when this drug should be given.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.8",
                            Type = @"Component",
                            Position = @"RXG.3.8",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a full text version of the instruction (optional).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.9",
                            Type = @"Component",
                            Position = @"RXG.3.9",
                            Name = @"Conjunction Component",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0472",
                            TableName = @"TQ Conjunction ID",
                            Description = @"This non-null component indicates that a second timing specification is to follow using the repeat delimiter.  This field can take three values as shown in HL7 table 0472 - TQ Conjunction ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.10",
                            Type = @"Component",
                            Position = @"RXG.3.10",
                            Name = @"Order Sequencing",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"OSD",
                            DataTypeName = @"Order Sequence",
                            TableId = null,
                            TableName = null,
                            Description = @"There are many situations, such as the creation of an order for a group of intravenous (IV) solutions, where the sequence of the individual intravenous solutions (each a service in itself) needs to be specified, e.g., hyperalimentation with multi-vitamins in every third bottle.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXG.3.10.1",
                            Type = @"SubComponent",
                            Position = @"RXG.3.10.1",
                            Name = @"Sequence/results Flag",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"OSD1",
                            TableName = @"Sequence condition",
                            Description = @"S for sequence conditions; C for cyclical; R is reserved for possible future use. The C will be used for indicating a repeating cycle of orders; for example, individual intravenous solutions used in a cyclical sequence (a.k.a. “Alternating IVs”).  This value would be compatible with linking separate orders or with having all cyclical order components in a single order.  Likewise, the value would be compatible with either Parent-Child messages or a single order message to communicate the orders’ sequencing ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.10.2",
                            Type = @"SubComponent",
                            Position = @"RXG.3.10.2",
                            Name = @"Placer Order Number: Entity Identifier",
                            Length = 0,
                            Usage = @"R",
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
                            Id = @"RXG.3.10.3",
                            Type = @"SubComponent",
                            Position = @"RXG.3.10.3",
                            Name = @"Placer Order Number: Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.10.4",
                            Type = @"SubComponent",
                            Position = @"RXG.3.10.4",
                            Name = @"Filler Order Number: Entity Identifier",
                            Length = 0,
                            Usage = @"R",
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
                            Id = @"RXG.3.10.5",
                            Type = @"SubComponent",
                            Position = @"RXG.3.10.5",
                            Name = @"Filler Order Number: Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.10.6",
                            Type = @"SubComponent",
                            Position = @"RXG.3.10.6",
                            Name = @"Sequence Condition Value",
                            Length = 0,
                            Usage = @"R",
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
                            Id = @"RXG.3.10.7",
                            Type = @"SubComponent",
                            Position = @"RXG.3.10.7",
                            Name = @"Maximum Number Of Repeats",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum number of repeats to be used only on cyclic groups.  The total number of repeats is constrained by the end date/time of the last repeat or the end date/time of the parent, whichever is first.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.10.8",
                            Type = @"SubComponent",
                            Position = @"RXG.3.10.8",
                            Name = @"Placer Order Number: Universal ID",
                            Length = 0,
                            Usage = @"R",
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
                            Id = @"RXG.3.10.9",
                            Type = @"SubComponent",
                            Position = @"RXG.3.10.9",
                            Name = @"Placer Order Number; Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.10.10",
                            Type = @"SubComponent",
                            Position = @"RXG.3.10.10",
                            Name = @"Filler Order Number: Universal ID",
                            Length = 0,
                            Usage = @"R",
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
                            Id = @"RXG.3.10.11",
                            Type = @"SubComponent",
                            Position = @"RXG.3.10.11",
                            Name = @"Filler Order Number: Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.11",
                            Type = @"Component",
                            Position = @"RXG.3.11",
                            Name = @"Occurrence Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the duration for a single performance of a service, e.g., whirlpool twenty minutes three times per day for three days. It is optional within TQ and does not repeat.

Note: The component delimiter in this CQ is demoted to a subcomponent delimiter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXG.3.11.1",
                            Type = @"SubComponent",
                            Position = @"RXG.3.11.1",
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
                            Id = @"RXG.3.11.2",
                            Type = @"SubComponent",
                            Position = @"RXG.3.11.2",
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
                            Id = @"RXG.3.11.3",
                            Type = @"SubComponent",
                            Position = @"RXG.3.11.3",
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
                            Id = @"RXG.3.11.4",
                            Type = @"SubComponent",
                            Position = @"RXG.3.11.4",
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
                            Id = @"RXG.3.11.5",
                            Type = @"SubComponent",
                            Position = @"RXG.3.11.5",
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
                            Id = @"RXG.3.11.6",
                            Type = @"SubComponent",
                            Position = @"RXG.3.11.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.3.12",
                            Type = @"Component",
                            Position = @"RXG.3.12",
                            Name = @"Total Occurences",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the total number of occurrences of a service that should result from this order.  It is optional within TQ and does not repeat.  If both the end date/time and the total occurrences are valued and the occurrences would extend beyond the end date/time, then the end date/time takes precedence.  Otherwise the number of occurrences takes precedence.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _quantityTiming = new HL7V24Field
        {
            field = message[@"RXG"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityTiming.field.FieldRepetitions != null && _quantityTiming.field.FieldRepetitions.Count > 0)
        {
            _quantityTiming.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_quantityTiming, fieldData);
        }

        return _quantityTiming;
    } 
}

internal HL7V24Field _giveCode;

public HL7V24Field GiveCode
{
    get
    {
        if (_giveCode != null)
        {
            return _giveCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.4",
            Type = @"Field",
            Position = @"RXG.4",
            Name = @"Give Code",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0292",
            TableName = @"Vaccines administered",
            Description = @"This field is the identifier of the medical substance/treatment ordered to be given to the patient; it is equivalent to OBR-4-Universal service ID in function. See the RXE segment for a complete definition of the RXE-2-Give code. If the substance given is a vaccine, CVX codes may be used to code this field (see HL7 table 0292 - Vaccines administered ).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.4.1",
                            Type = @"Component",
                            Position = @"RXG.4.1",
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
                            Id = @"RXG.4.2",
                            Type = @"Component",
                            Position = @"RXG.4.2",
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
                            Id = @"RXG.4.3",
                            Type = @"Component",
                            Position = @"RXG.4.3",
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
                            Id = @"RXG.4.4",
                            Type = @"Component",
                            Position = @"RXG.4.4",
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
                            Id = @"RXG.4.5",
                            Type = @"Component",
                            Position = @"RXG.4.5",
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
                            Id = @"RXG.4.6",
                            Type = @"Component",
                            Position = @"RXG.4.6",
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
                        }
        }

        _giveCode = new HL7V24Field
        {
            field = message[@"RXG"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveCode.field.FieldRepetitions != null && _giveCode.field.FieldRepetitions.Count > 0)
        {
            _giveCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_giveCode, fieldData);
        }

        return _giveCode;
    } 
}

internal HL7V24Field _giveAmountMinimum;

public HL7V24Field GiveAmountMinimum
{
    get
    {
        if (_giveAmountMinimum != null)
        {
            return _giveAmountMinimum;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.5",
            Type = @"Field",
            Position = @"RXG.5",
            Name = @"Give Amount - Minimum",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the ordered amount as encoded by the pharmacy/treatment supplier. In a variable dose order, this is the minimum ordered amount. In a nonvarying dose order, this is the exact amount of the order.",
            Sample = @"",
            Fields = null
        }

        _giveAmountMinimum = new HL7V24Field
        {
            field = message[@"RXG"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveAmountMinimum.field.FieldRepetitions != null && _giveAmountMinimum.field.FieldRepetitions.Count > 0)
        {
            _giveAmountMinimum.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_giveAmountMinimum, fieldData);
        }

        return _giveAmountMinimum;
    } 
}

internal HL7V24Field _giveAmountMaximum;

public HL7V24Field GiveAmountMaximum
{
    get
    {
        if (_giveAmountMaximum != null)
        {
            return _giveAmountMaximum;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.6",
            Type = @"Field",
            Position = @"RXG.6",
            Name = @"Give Amount - Maximum",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"In a variable dose order, this is the maximum ordered amount. In a nonvarying dose order, this field is not used.",
            Sample = @"",
            Fields = null
        }

        _giveAmountMaximum = new HL7V24Field
        {
            field = message[@"RXG"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveAmountMaximum.field.FieldRepetitions != null && _giveAmountMaximum.field.FieldRepetitions.Count > 0)
        {
            _giveAmountMaximum.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_giveAmountMaximum, fieldData);
        }

        return _giveAmountMaximum;
    } 
}

internal HL7V24Field _giveUnits;

public HL7V24Field GiveUnits
{
    get
    {
        if (_giveUnits != null)
        {
            return _giveUnits;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.7",
            Type = @"Field",
            Position = @"RXG.7",
            Name = @"Give Units",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the units for the give amount.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.7.1",
                            Type = @"Component",
                            Position = @"RXG.7.1",
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
                            Id = @"RXG.7.2",
                            Type = @"Component",
                            Position = @"RXG.7.2",
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
                            Id = @"RXG.7.3",
                            Type = @"Component",
                            Position = @"RXG.7.3",
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
                            Id = @"RXG.7.4",
                            Type = @"Component",
                            Position = @"RXG.7.4",
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
                            Id = @"RXG.7.5",
                            Type = @"Component",
                            Position = @"RXG.7.5",
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
                            Id = @"RXG.7.6",
                            Type = @"Component",
                            Position = @"RXG.7.6",
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
                        }
        }

        _giveUnits = new HL7V24Field
        {
            field = message[@"RXG"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveUnits.field.FieldRepetitions != null && _giveUnits.field.FieldRepetitions.Count > 0)
        {
            _giveUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_giveUnits, fieldData);
        }

        return _giveUnits;
    } 
}

internal HL7V24Field _giveDosageForm;

public HL7V24Field GiveDosageForm
{
    get
    {
        if (_giveDosageForm != null)
        {
            return _giveDosageForm;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.8",
            Type = @"Field",
            Position = @"RXG.8",
            Name = @"Give Dosage Form",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"The dosage form indicates the manner in which the medication/treatment is aggregated for dispensing, e.g., tablets, capsules, suppositories. In some cases, this information is implied by the give code in RXG-4-give code. Use this field when the give code does not specify the dosage form.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.8.1",
                            Type = @"Component",
                            Position = @"RXG.8.1",
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
                            Id = @"RXG.8.2",
                            Type = @"Component",
                            Position = @"RXG.8.2",
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
                            Id = @"RXG.8.3",
                            Type = @"Component",
                            Position = @"RXG.8.3",
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
                            Id = @"RXG.8.4",
                            Type = @"Component",
                            Position = @"RXG.8.4",
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
                            Id = @"RXG.8.5",
                            Type = @"Component",
                            Position = @"RXG.8.5",
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
                            Id = @"RXG.8.6",
                            Type = @"Component",
                            Position = @"RXG.8.6",
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
                        }
        }

        _giveDosageForm = new HL7V24Field
        {
            field = message[@"RXG"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveDosageForm.field.FieldRepetitions != null && _giveDosageForm.field.FieldRepetitions.Count > 0)
        {
            _giveDosageForm.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_giveDosageForm, fieldData);
        }

        return _giveDosageForm;
    } 
}

internal HL7V24Field _administrationNotes;

public HL7V24Field AdministrationNotes
{
    get
    {
        if (_administrationNotes != null)
        {
            return _administrationNotes;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.9",
            Type = @"Field",
            Position = @"RXG.9",
            Name = @"Administration Notes",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains notes to the person administering the medication/treatment (may include the ordering providers original notes, as well as any notes from the formulary or the pharmacy or treatment supplier). If coded, a user-defined table must be used. If free text, place a null in the first component and the text in the second, e.g., |^this is a free text administration note|.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.9.1",
                            Type = @"Component",
                            Position = @"RXG.9.1",
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
                            Id = @"RXG.9.2",
                            Type = @"Component",
                            Position = @"RXG.9.2",
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
                            Id = @"RXG.9.3",
                            Type = @"Component",
                            Position = @"RXG.9.3",
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
                            Id = @"RXG.9.4",
                            Type = @"Component",
                            Position = @"RXG.9.4",
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
                            Id = @"RXG.9.5",
                            Type = @"Component",
                            Position = @"RXG.9.5",
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
                            Id = @"RXG.9.6",
                            Type = @"Component",
                            Position = @"RXG.9.6",
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
                        }
        }

        _administrationNotes = new HL7V24Field
        {
            field = message[@"RXG"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administrationNotes.field.FieldRepetitions != null && _administrationNotes.field.FieldRepetitions.Count > 0)
        {
            _administrationNotes.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administrationNotes, fieldData);
        }

        return _administrationNotes;
    } 
}

internal HL7V24Field _substitutionStatus;

public HL7V24Field SubstitutionStatus
{
    get
    {
        if (_substitutionStatus != null)
        {
            return _substitutionStatus;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.10",
            Type = @"Field",
            Position = @"RXG.10",
            Name = @"Substitution Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0167",
            TableName = @"Substitution status",
            Description = @"Refer to HL7 Table 0167 - Substitution status for valid values.",
            Sample = @"",
            Fields = null
        }

        _substitutionStatus = new HL7V24Field
        {
            field = message[@"RXG"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substitutionStatus.field.FieldRepetitions != null && _substitutionStatus.field.FieldRepetitions.Count > 0)
        {
            _substitutionStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substitutionStatus, fieldData);
        }

        return _substitutionStatus;
    } 
}

internal HL7V24Field _dispenseToLocation;

public HL7V24Field DispenseToLocation
{
    get
    {
        if (_dispenseToLocation != null)
        {
            return _dispenseToLocation;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.11",
            Type = @"Field",
            Position = @"RXG.11",
            Name = @"Dispense-To Location",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"LA2",
            DataTypeName = @"Location With Address Information (variant 2",
            TableId = null,
            TableName = null,
            Description = @"The first component contains the inpatient or outpatient location where the drug or treatment was dispensed (if applicable). The default (null) value is the current census location for the patient. Site-specific table. The first eight components have the same form as the first eight components of PV1-3-assigned patient location. The final eight components replace the ninth component of PV1-3-assigned patient location and represent the full address specification.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.11.1",
                            Type = @"Component",
                            Position = @"RXG.11.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.2",
                            Type = @"Component",
                            Position = @"RXG.11.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.3",
                            Type = @"Component",
                            Position = @"RXG.11.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.4",
                            Type = @"Component",
                            Position = @"RXG.11.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXG.11.4.1",
                            Type = @"SubComponent",
                            Position = @"RXG.11.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.4.2",
                            Type = @"SubComponent",
                            Position = @"RXG.11.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.4.3",
                            Type = @"SubComponent",
                            Position = @"RXG.11.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.5",
                            Type = @"Component",
                            Position = @"RXG.11.5",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.6",
                            Type = @"Component",
                            Position = @"RXG.11.6",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.7",
                            Type = @"Component",
                            Position = @"RXG.11.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.8",
                            Type = @"Component",
                            Position = @"RXG.11.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.9",
                            Type = @"Component",
                            Position = @"RXG.11.9",
                            Name = @"Street Address",
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
                            Id = @"RXG.11.10",
                            Type = @"Component",
                            Position = @"RXG.11.10",
                            Name = @"Other Designation",
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
                            Id = @"RXG.11.11",
                            Type = @"Component",
                            Position = @"RXG.11.11",
                            Name = @"City",
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
                            Id = @"RXG.11.12",
                            Type = @"Component",
                            Position = @"RXG.11.12",
                            Name = @"State Or Province",
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
                            Id = @"RXG.11.13",
                            Type = @"Component",
                            Position = @"RXG.11.13",
                            Name = @"Zip Or Postal Code",
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
                            Id = @"RXG.11.14",
                            Type = @"Component",
                            Position = @"RXG.11.14",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.15",
                            Type = @"Component",
                            Position = @"RXG.11.15",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXG.11.16",
                            Type = @"Component",
                            Position = @"RXG.11.16",
                            Name = @"Other Geographic Designation",
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
                        }
        }

        _dispenseToLocation = new HL7V24Field
        {
            field = message[@"RXG"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dispenseToLocation.field.FieldRepetitions != null && _dispenseToLocation.field.FieldRepetitions.Count > 0)
        {
            _dispenseToLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_dispenseToLocation, fieldData);
        }

        return _dispenseToLocation;
    } 
}

internal HL7V24Field _needsHumanReview;

public HL7V24Field NeedsHumanReview
{
    get
    {
        if (_needsHumanReview != null)
        {
            return _needsHumanReview;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.12",
            Type = @"Field",
            Position = @"RXG.12",
            Name = @"Needs Human Review",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Refer to HL7 table 0136 - Yes/no indicator for valid values. The values have the following meaning for this field:",
            Sample = @"",
            Fields = null
        }

        _needsHumanReview = new HL7V24Field
        {
            field = message[@"RXG"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_needsHumanReview.field.FieldRepetitions != null && _needsHumanReview.field.FieldRepetitions.Count > 0)
        {
            _needsHumanReview.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_needsHumanReview, fieldData);
        }

        return _needsHumanReview;
    } 
}

internal HL7V24Field _pharmacyTreatmentSuppliersSpecialAdministrationInstructions;

public HL7V24Field PharmacyTreatmentSuppliersSpecialAdministrationInstructions
{
    get
    {
        if (_pharmacyTreatmentSuppliersSpecialAdministrationInstructions != null)
        {
            return _pharmacyTreatmentSuppliersSpecialAdministrationInstructions;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.13",
            Type = @"Field",
            Position = @"RXG.13",
            Name = @"Pharmacy/Treatment Supplier's Special Administration Instructions",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains pharmacy/treatment supplier-generated special instructions to the provider administering the order.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.13.1",
                            Type = @"Component",
                            Position = @"RXG.13.1",
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
                            Id = @"RXG.13.2",
                            Type = @"Component",
                            Position = @"RXG.13.2",
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
                            Id = @"RXG.13.3",
                            Type = @"Component",
                            Position = @"RXG.13.3",
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
                            Id = @"RXG.13.4",
                            Type = @"Component",
                            Position = @"RXG.13.4",
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
                            Id = @"RXG.13.5",
                            Type = @"Component",
                            Position = @"RXG.13.5",
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
                            Id = @"RXG.13.6",
                            Type = @"Component",
                            Position = @"RXG.13.6",
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
                        }
        }

        _pharmacyTreatmentSuppliersSpecialAdministrationInstructions = new HL7V24Field
        {
            field = message[@"RXG"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pharmacyTreatmentSuppliersSpecialAdministrationInstructions.field.FieldRepetitions != null && _pharmacyTreatmentSuppliersSpecialAdministrationInstructions.field.FieldRepetitions.Count > 0)
        {
            _pharmacyTreatmentSuppliersSpecialAdministrationInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_pharmacyTreatmentSuppliersSpecialAdministrationInstructions, fieldData);
        }

        return _pharmacyTreatmentSuppliersSpecialAdministrationInstructions;
    } 
}

internal HL7V24Field _givePer;

public HL7V24Field GivePer
{
    get
    {
        if (_givePer != null)
        {
            return _givePer;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.14",
            Type = @"Field",
            Position = @"RXG.14",
            Name = @"Give Per",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time unit to use to calculate the rate at which the pharmaceutical/treatment is to be administered.",
            Sample = @"",
            Fields = null
        }

        _givePer = new HL7V24Field
        {
            field = message[@"RXG"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_givePer.field.FieldRepetitions != null && _givePer.field.FieldRepetitions.Count > 0)
        {
            _givePer.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_givePer, fieldData);
        }

        return _givePer;
    } 
}

internal HL7V24Field _giveRateAmount;

public HL7V24Field GiveRateAmount
{
    get
    {
        if (_giveRateAmount != null)
        {
            return _giveRateAmount;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.15",
            Type = @"Field",
            Position = @"RXG.15",
            Name = @"Give Rate Amount",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount (number) of substance/treatment to be administered.",
            Sample = @"",
            Fields = null
        }

        _giveRateAmount = new HL7V24Field
        {
            field = message[@"RXG"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveRateAmount.field.FieldRepetitions != null && _giveRateAmount.field.FieldRepetitions.Count > 0)
        {
            _giveRateAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_giveRateAmount, fieldData);
        }

        return _giveRateAmount;
    } 
}

internal HL7V24Field _giveRateUnits;

public HL7V24Field GiveRateUnits
{
    get
    {
        if (_giveRateUnits != null)
        {
            return _giveRateUnits;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.16",
            Type = @"Field",
            Position = @"RXG.16",
            Name = @"Give Rate Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the units for RXG-15-give rate amount . May be composite. The ratio of the RXG-15-give rate amount and RXG-16-give rate units fields define the actual rate of administration. Thus, if RXG-15-give rate amount = 100 and RXG-16-give rate units = ml/hr, the requested rate of administration is 100 ml/hr.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.16.1",
                            Type = @"Component",
                            Position = @"RXG.16.1",
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
                            Id = @"RXG.16.2",
                            Type = @"Component",
                            Position = @"RXG.16.2",
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
                            Id = @"RXG.16.3",
                            Type = @"Component",
                            Position = @"RXG.16.3",
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
                            Id = @"RXG.16.4",
                            Type = @"Component",
                            Position = @"RXG.16.4",
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
                            Id = @"RXG.16.5",
                            Type = @"Component",
                            Position = @"RXG.16.5",
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
                            Id = @"RXG.16.6",
                            Type = @"Component",
                            Position = @"RXG.16.6",
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
                        }
        }

        _giveRateUnits = new HL7V24Field
        {
            field = message[@"RXG"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveRateUnits.field.FieldRepetitions != null && _giveRateUnits.field.FieldRepetitions.Count > 0)
        {
            _giveRateUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_giveRateUnits, fieldData);
        }

        return _giveRateUnits;
    } 
}

internal HL7V24Field _giveStrength;

public HL7V24Field GiveStrength
{
    get
    {
        if (_giveStrength != null)
        {
            return _giveStrength;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.17",
            Type = @"Field",
            Position = @"RXG.17",
            Name = @"Give Strength",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Use when RXG-4-Give code does not specify the strength. This is the numeric part of the strength, used in combination with RXG-18-Give strength units.",
            Sample = @"",
            Fields = null
        }

        _giveStrength = new HL7V24Field
        {
            field = message[@"RXG"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveStrength.field.FieldRepetitions != null && _giveStrength.field.FieldRepetitions.Count > 0)
        {
            _giveStrength.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_giveStrength, fieldData);
        }

        return _giveStrength;
    } 
}

internal HL7V24Field _giveStrengthUnits;

public HL7V24Field GiveStrengthUnits
{
    get
    {
        if (_giveStrengthUnits != null)
        {
            return _giveStrengthUnits;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.18",
            Type = @"Field",
            Position = @"RXG.18",
            Name = @"Give Strength Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"Use when RXG-4-Give code does not specify the strength. This is the unit of the strength, used in combination with RXG-17-Give strength.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.18.1",
                            Type = @"Component",
                            Position = @"RXG.18.1",
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
                            Id = @"RXG.18.2",
                            Type = @"Component",
                            Position = @"RXG.18.2",
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
                            Id = @"RXG.18.3",
                            Type = @"Component",
                            Position = @"RXG.18.3",
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
                            Id = @"RXG.18.4",
                            Type = @"Component",
                            Position = @"RXG.18.4",
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
                            Id = @"RXG.18.5",
                            Type = @"Component",
                            Position = @"RXG.18.5",
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
                            Id = @"RXG.18.6",
                            Type = @"Component",
                            Position = @"RXG.18.6",
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
                        }
        }

        _giveStrengthUnits = new HL7V24Field
        {
            field = message[@"RXG"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveStrengthUnits.field.FieldRepetitions != null && _giveStrengthUnits.field.FieldRepetitions.Count > 0)
        {
            _giveStrengthUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_giveStrengthUnits, fieldData);
        }

        return _giveStrengthUnits;
    } 
}

internal HL7V24Field _substanceLotNumber;

public HL7V24Field SubstanceLotNumber
{
    get
    {
        if (_substanceLotNumber != null)
        {
            return _substanceLotNumber;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.19",
            Type = @"Field",
            Position = @"RXG.19",
            Name = @"Substance Lot Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the lot number of the medical substance administered.",
            Sample = @"",
            Fields = null
        }

        _substanceLotNumber = new HL7V24Field
        {
            field = message[@"RXG"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceLotNumber.field.FieldRepetitions != null && _substanceLotNumber.field.FieldRepetitions.Count > 0)
        {
            _substanceLotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substanceLotNumber, fieldData);
        }

        return _substanceLotNumber;
    } 
}

internal HL7V24Field _substanceExpirationDate;

public HL7V24Field SubstanceExpirationDate
{
    get
    {
        if (_substanceExpirationDate != null)
        {
            return _substanceExpirationDate;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.20",
            Type = @"Field",
            Position = @"RXG.20",
            Name = @"Substance Expiration Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date of the medical substance administered.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.20.1",
                            Type = @"Component",
                            Position = @"RXG.20.1",
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
                            Id = @"RXG.20.2",
                            Type = @"Component",
                            Position = @"RXG.20.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _substanceExpirationDate = new HL7V24Field
        {
            field = message[@"RXG"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceExpirationDate.field.FieldRepetitions != null && _substanceExpirationDate.field.FieldRepetitions.Count > 0)
        {
            _substanceExpirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substanceExpirationDate, fieldData);
        }

        return _substanceExpirationDate;
    } 
}

internal HL7V24Field _substanceManufacturerName;

public HL7V24Field SubstanceManufacturerName
{
    get
    {
        if (_substanceManufacturerName != null)
        {
            return _substanceManufacturerName;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.21",
            Type = @"Field",
            Position = @"RXG.21",
            Name = @"Substance Manufacturer Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0227",
            TableName = @"Manufacturers of vaccines",
            Description = @"This field contains the manufacturer of the medical substance administered.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.21.1",
                            Type = @"Component",
                            Position = @"RXG.21.1",
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
                            Id = @"RXG.21.2",
                            Type = @"Component",
                            Position = @"RXG.21.2",
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
                            Id = @"RXG.21.3",
                            Type = @"Component",
                            Position = @"RXG.21.3",
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
                            Id = @"RXG.21.4",
                            Type = @"Component",
                            Position = @"RXG.21.4",
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
                            Id = @"RXG.21.5",
                            Type = @"Component",
                            Position = @"RXG.21.5",
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
                            Id = @"RXG.21.6",
                            Type = @"Component",
                            Position = @"RXG.21.6",
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
                        }
        }

        _substanceManufacturerName = new HL7V24Field
        {
            field = message[@"RXG"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceManufacturerName.field.FieldRepetitions != null && _substanceManufacturerName.field.FieldRepetitions.Count > 0)
        {
            _substanceManufacturerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substanceManufacturerName, fieldData);
        }

        return _substanceManufacturerName;
    } 
}

internal HL7V24Field _indication;

public HL7V24Field Indication
{
    get
    {
        if (_indication != null)
        {
            return _indication;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXG.22",
            Type = @"Field",
            Position = @"RXG.22",
            Name = @"Indication",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier of the condition or problem for which the drug/treatment was prescribed. May repeat if multiple indications are relevant.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXG.22.1",
                            Type = @"Component",
                            Position = @"RXG.22.1",
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
                            Id = @"RXG.22.2",
                            Type = @"Component",
                            Position = @"RXG.22.2",
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
                            Id = @"RXG.22.3",
                            Type = @"Component",
                            Position = @"RXG.22.3",
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
                            Id = @"RXG.22.4",
                            Type = @"Component",
                            Position = @"RXG.22.4",
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
                            Id = @"RXG.22.5",
                            Type = @"Component",
                            Position = @"RXG.22.5",
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
                            Id = @"RXG.22.6",
                            Type = @"Component",
                            Position = @"RXG.22.6",
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
                        }
        }

        _indication = new HL7V24Field
        {
            field = message[@"RXG"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_indication.field.FieldRepetitions != null && _indication.field.FieldRepetitions.Count > 0)
        {
            _indication.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_indication, fieldData);
        }

        return _indication;
    } 
}
    }
}
