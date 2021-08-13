using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentRXE
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RXE"; } }

        public string SegmentId { get { return @"RXE"; } }
        
        public string LongName { get { return @"Pharmacy Encoded Order"; } }
        
        public string Description { get { return @"The RXE segment details the pharmacy application's encoding of the order.  It also contains several pharmacyspecific order status fields, such as RXE-16-number of refills remaining, RXE-17-number of refills/doses dispensed, RXE-18-date/time of most recent refill/dose, and RXE-19-total daily dose. "; } }
        
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

        public HL7V22SegmentRXE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _quantityTiming;

public HL7V22Field QuantityTiming
{
    get
    {
        if (_quantityTiming != null)
        {
            return _quantityTiming;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.1",
            Type = @"Field",
            Position = @"RXE.1",
            Name = @"Quantity / Timing",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TQ",
            DataTypeName = @"Timing Quantity",
            TableId = null,
            TableName = null,
            Description = @"see Section 4.8.7 for necessary modification for this field's definition to cover interorder dependencies needed by pharmacy orders.  This field is used by the Pharmacy to express the fully coded version of the drug timing.  It may differ from ORC-7-quantity/timing, which contains the requested quantity/timing of the original order",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.1.1",
                            Type = @"Component",
                            Position = @"RXE.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"quantity of the service that should be provided at each service interval.  E.g, if two blood cultures to be obtained every 4 hours, the quantity would be 2.  If three units of blood are to be typed and cross-matched, the quantity would be 3.  The default value is 1.  When units are required, they can be added, specified by a subcomponent delimiter",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.1.1.1",
                            Type = @"SubComponent",
                            Position = @"RXE.1.1.1",
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
                            Id = @"RXE.1.1.2",
                            Type = @"SubComponent",
                            Position = @"RXE.1.1.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed.  Field-by-field, default units may be defined within the specifications.  When the observation is measured in the default units, the units need not be transmitted.  If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component.  If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7.  If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7.  But in these cases the component separator should be replaced by the subcomponent delimiter ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.2",
                            Type = @"Component",
                            Position = @"RXE.1.2",
                            Name = @"Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RI",
                            DataTypeName = @"Interval",
                            TableId = null,
                            TableName = null,
                            Description = @"determines the interval between repeated services.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.1.2.1",
                            Type = @"SubComponent",
                            Position = @"RXE.1.2.1",
                            Name = @"Repeat Pattern",
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
                            Id = @"RXE.1.2.2",
                            Type = @"SubComponent",
                            Position = @"RXE.1.2.2",
                            Name = @"Explicit Time Intevall",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"explicitly lists the actual times referenced by the code in the first subcomponent, in the following format: HHMM,HHMM,HHMM,...  This second subcomponent will be used to clarify the first subcomponent in cases where the actual administration times vary within an institution.  If the time of the order spans more than a single day, this new subcomponent is only practical if the same times of administration occur for each day of the order.  If the actual start time of the order (as given by the fourth subcomponent of the quantity/timing field) is after the first explicit time, the first administration is taken to be the first explicit time after the start time.  In the case where the patient moves to a location having a different set of explicit times, the existing order may be updated with a new quantity/timing field showing the changed explicit times",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.3",
                            Type = @"Component",
                            Position = @"RXE.1.3",
                            Name = @"Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Indicates how long the service should continue after it is started.  The default is INDEF (do indefinitely).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.4",
                            Type = @"Component",
                            Position = @"RXE.1.4",
                            Name = @"Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"May be specified by the orderer, in which case it indicates the earliest date/time at which the services should be started.  In many cases, however, the start date time will be implied or will be defined by other fields in the order record (e.g., urgency - STAT).  In such a case, this field will be empty",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.1.4.1",
                            Type = @"SubComponent",
                            Position = @"RXE.1.4.1",
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
                            Id = @"RXE.1.4.2",
                            Type = @"SubComponent",
                            Position = @"RXE.1.4.2",
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
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.5",
                            Type = @"Component",
                            Position = @"RXE.1.5",
                            Name = @"End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"when filled in by the requester of the service, this field should be the latest date-time that the service should be performed.  If it has not been performed by the specified time, it should not be performed at all.  The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.1.5.1",
                            Type = @"SubComponent",
                            Position = @"RXE.1.5.1",
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
                            Id = @"RXE.1.5.2",
                            Type = @"SubComponent",
                            Position = @"RXE.1.5.2",
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
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.6",
                            Type = @"Component",
                            Position = @"RXE.1.6",
                            Name = @"Priority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"describes the urgency of the request.  The following values are suggested (the default for Priority is R)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.7",
                            Type = @"Component",
                            Position = @"RXE.1.7",
                            Name = @"Condition",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a free text field that describes the conditions under which the drug is to be given.  For example, PRN pain, or to keep blood pressure below 110.  The presence of text in this field should be taken to mean that human review is needed to determine the how and/or when this drug should be given",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.8",
                            Type = @"Component",
                            Position = @"RXE.1.8",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"full text version of the instruction (optional).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.9",
                            Type = @"Component",
                            Position = @"RXE.1.9",
                            Name = @"Conjunction",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @" non-null component indicates that a second timing specification is to follow using the repeat delimiter.  This field can take three values: 

S =  Synchronous 
A =  Asynchronous 
C =  This is an actuation time ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.10",
                            Type = @"Component",
                            Position = @"RXE.1.10",
                            Name = @"Order Sequencing",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_OSD",
                            DataTypeName = @"Order Sequence",
                            TableId = null,
                            TableName = null,
                            Description = @"there are many situations, such as the creation of an order for a group of intervenous (IV) solutions, where the sequence of the individual intervenous solutions (each an order in itself) needs to be specified.  There are other situations, where part of the order's instructions contains a results condition of some type, such as ""PRN pain.""  There is currently a free text ""condition"" component of ORC-4-quantity/timing which allows any condition to be specified.  However, to support a fully encoded version of order sequencing, or results condition, we have defined in the following paragraphs a 10th component of ORC-4quantity/timing",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.1.10.1",
                            Type = @"SubComponent",
                            Position = @"RXE.1.10.1",
                            Name = @"Sequence/results Flag",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"S for sequence conditions; R is reserved for possible future use. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.10.2",
                            Type = @"SubComponent",
                            Position = @"RXE.1.10.2",
                            Name = @"Placer Order Number Entity Identifier",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Uses two subcomponents since the placer order number has two components",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.10.3",
                            Type = @"SubComponent",
                            Position = @"RXE.1.10.3",
                            Name = @"Placer Order Number Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Uses two subcomponents since the placer order number has two components",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.10.4",
                            Type = @"SubComponent",
                            Position = @"RXE.1.10.4",
                            Name = @"Filler Order Number Entity Identifier",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Uses two subcomponents since the filler order number has two components",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.10.5",
                            Type = @"SubComponent",
                            Position = @"RXE.1.10.5",
                            Name = @"Filler Order Number Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Uses two subcomponents since the filler order number has two components",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.10.6",
                            Type = @"SubComponent",
                            Position = @"RXE.1.10.6",
                            Name = @"Sequence Condition Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The acceptable condition values have the form commonly used in project planning methodologies

<one of ""SS"", ""EE"", ""SE"", or ""ES""> +/- <time>

The first letter stands for start (S) or end (E) of predecessor order, where the predecessor is defined by the placer or filler order number in subcomponents 1,2 or subcomponents 3,4. 
 
The second letter stands for the start (S) or end (E) of the successor order, where the successor order is the order containing this quantity/timing specification. 
 
The time specifies the interval between the predecessor and successor starts or ends ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.10.7",
                            Type = @"SubComponent",
                            Position = @"RXE.1.10.7",
                            Name = @"Maximum Number Of Repeats",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum number of repeats to be used only on cyclic groups.  The total number of repeats is constrained by the end date/time of the last repeat or the end date/time of the parent, whichever is first.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _quantityTiming = new HL7V22Field
        {
            field = message[@"RXE"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityTiming.field.FieldRepetitions != null && _quantityTiming.field.FieldRepetitions.Count > 0)
        {
            _quantityTiming.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_quantityTiming, fieldData);
        }

        return _quantityTiming;
    } 
}

internal HL7V22Field _giveCode;

public HL7V22Field GiveCode
{
    get
    {
        if (_giveCode != null)
        {
            return _giveCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.2",
            Type = @"Field",
            Position = @"RXE.2",
            Name = @"Give Code",
            Length = 100,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"identifier of the medical substance ordered to be given to the patient, as encoded by the Pharmacy;  it is equivalent to OBR-4-universal service ID in function.  In the RXE segment, this give code must be fully encoded.  The dispense fields, which define the units and amount of what is to be issued to the patient (see RXE-10-dispense amount and RXE-11-dispense units below) do not necessarily correlate with the instructions of what amount is to be ""given"" or administered with each dose, and may or may not be specified with the order.  For example, the ""give"" part of the order may convey the field-representation of give 250 mg of ampicillin, while the request to dispense part of the order may convey issue 30 tablets of generic equivalent for this outpatient prescription",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.2.1",
                            Type = @"Component",
                            Position = @"RXE.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.2.2",
                            Type = @"Component",
                            Position = @"RXE.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.2.3",
                            Type = @"Component",
                            Position = @"RXE.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.2.4",
                            Type = @"Component",
                            Position = @"RXE.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.2.5",
                            Type = @"Component",
                            Position = @"RXE.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.2.6",
                            Type = @"Component",
                            Position = @"RXE.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _giveCode = new HL7V22Field
        {
            field = message[@"RXE"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveCode.field.FieldRepetitions != null && _giveCode.field.FieldRepetitions.Count > 0)
        {
            _giveCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_giveCode, fieldData);
        }

        return _giveCode;
    } 
}

internal HL7V22Field _giveAmountMinimum;

public HL7V22Field GiveAmountMinimum
{
    get
    {
        if (_giveAmountMinimum != null)
        {
            return _giveAmountMinimum;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.3",
            Type = @"Field",
            Position = @"RXE.3",
            Name = @"Give Amount - Minimum",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"ordered amount as encoded by the Pharmacy.  In a variable dose order, this is the minimum ordered amount.  In a nonvarying dose order, this is the exact amount of the order

Note:This field is not a duplication of the first component of the quantity/timing field, since in non-Pharmacy orders, that component can be used to specify multiples of an ordered amount.  
 
Another way to say this is that, for pharmacy orders, the quantity component of the quantity/timing field refers to what is to be given out at each service interval; thus, in terms of the RX order, that first component always defaults to 1.  Hence, in the actual execution of the order, the value of 1 in the first component of the quantity/timing field always refers to one administration of the amount specified in this field (the requested Give Amount field)",
            Sample = @"",
            Fields = null
        }

        _giveAmountMinimum = new HL7V22Field
        {
            field = message[@"RXE"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveAmountMinimum.field.FieldRepetitions != null && _giveAmountMinimum.field.FieldRepetitions.Count > 0)
        {
            _giveAmountMinimum.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_giveAmountMinimum, fieldData);
        }

        return _giveAmountMinimum;
    } 
}

internal HL7V22Field _giveAmountMaximum;

public HL7V22Field GiveAmountMaximum
{
    get
    {
        if (_giveAmountMaximum != null)
        {
            return _giveAmountMaximum;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.4",
            Type = @"Field",
            Position = @"RXE.4",
            Name = @"Give Amount - Maximum",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"in a variable dose order, this is the maximum ordered amount.  In a nonvarying dose, this field is not used. ",
            Sample = @"",
            Fields = null
        }

        _giveAmountMaximum = new HL7V22Field
        {
            field = message[@"RXE"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveAmountMaximum.field.FieldRepetitions != null && _giveAmountMaximum.field.FieldRepetitions.Count > 0)
        {
            _giveAmountMaximum.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_giveAmountMaximum, fieldData);
        }

        return _giveAmountMaximum;
    } 
}

internal HL7V22Field _giveUnits;

public HL7V22Field GiveUnits
{
    get
    {
        if (_giveUnits != null)
        {
            return _giveUnits;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.5",
            Type = @"Field",
            Position = @"RXE.5",
            Name = @"Give Units",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"units for the give amount as encoded by the pharmacy application

Note:These units can be a ""compound quantity""; i.e., the units may contain the word ""per.""  For example, micrograms per KG (micg/kg) is an acceptable value, which means that the units are micrograms per KG (of body weight). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.5.1",
                            Type = @"Component",
                            Position = @"RXE.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.5.2",
                            Type = @"Component",
                            Position = @"RXE.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.5.3",
                            Type = @"Component",
                            Position = @"RXE.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.5.4",
                            Type = @"Component",
                            Position = @"RXE.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.5.5",
                            Type = @"Component",
                            Position = @"RXE.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.5.6",
                            Type = @"Component",
                            Position = @"RXE.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _giveUnits = new HL7V22Field
        {
            field = message[@"RXE"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveUnits.field.FieldRepetitions != null && _giveUnits.field.FieldRepetitions.Count > 0)
        {
            _giveUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_giveUnits, fieldData);
        }

        return _giveUnits;
    } 
}

internal HL7V22Field _giveDosageForm;

public HL7V22Field GiveDosageForm
{
    get
    {
        if (_giveDosageForm != null)
        {
            return _giveDosageForm;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.6",
            Type = @"Field",
            Position = @"RXE.6",
            Name = @"Give Dosage Form",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"use the Give Dosage Form field when the give code does not specifiy the dosage form",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.6.1",
                            Type = @"Component",
                            Position = @"RXE.6.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.6.2",
                            Type = @"Component",
                            Position = @"RXE.6.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.6.3",
                            Type = @"Component",
                            Position = @"RXE.6.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.6.4",
                            Type = @"Component",
                            Position = @"RXE.6.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.6.5",
                            Type = @"Component",
                            Position = @"RXE.6.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.6.6",
                            Type = @"Component",
                            Position = @"RXE.6.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _giveDosageForm = new HL7V22Field
        {
            field = message[@"RXE"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveDosageForm.field.FieldRepetitions != null && _giveDosageForm.field.FieldRepetitions.Count > 0)
        {
            _giveDosageForm.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_giveDosageForm, fieldData);
        }

        return _giveDosageForm;
    } 
}

internal HL7V22Field _providersAdministrationInstructions;

public HL7V22Field ProvidersAdministrationInstructions
{
    get
    {
        if (_providersAdministrationInstructions != null)
        {
            return _providersAdministrationInstructions;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.7",
            Type = @"Field",
            Position = @"RXE.7",
            Name = @"Provider's Administration Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"ordering provider's instructions to the patient or the provider administering the drug. This is a free text field; it may contain free text describing a custom IV, mixture, or salve",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.7.1",
                            Type = @"Component",
                            Position = @"RXE.7.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.7.2",
                            Type = @"Component",
                            Position = @"RXE.7.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.7.3",
                            Type = @"Component",
                            Position = @"RXE.7.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.7.4",
                            Type = @"Component",
                            Position = @"RXE.7.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.7.5",
                            Type = @"Component",
                            Position = @"RXE.7.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.7.6",
                            Type = @"Component",
                            Position = @"RXE.7.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _providersAdministrationInstructions = new HL7V22Field
        {
            field = message[@"RXE"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_providersAdministrationInstructions.field.FieldRepetitions != null && _providersAdministrationInstructions.field.FieldRepetitions.Count > 0)
        {
            _providersAdministrationInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_providersAdministrationInstructions, fieldData);
        }

        return _providersAdministrationInstructions;
    } 
}

internal HL7V22Field _delivertoLocation;

public HL7V22Field DelivertoLocation
{
    get
    {
        if (_delivertoLocation != null)
        {
            return _delivertoLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.8",
            Type = @"Field",
            Position = @"RXE.8",
            Name = @"Deliver-to Location",
            Length = 12,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CM_LA1",
            DataTypeName = @"Location With Address Information",
            TableId = null,
            TableName = null,
            Description = @"the first component contains the inpatient or outpatient location to which the pharmacy is to deliver the drug (if applicable).  The default (null) value is the current census location for the patient.  Site specific table.  This component has the same form as PV1-3-assigned patient location",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.8.1",
                            Type = @"Component",
                            Position = @"RXE.8.1",
                            Name = @"Dispense / Deliver To Location",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_INTERNAL_LOCATION",
                            DataTypeName = @"Cm For Location Information In Hospital",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.8.1.1",
                            Type = @"SubComponent",
                            Position = @"RXE.8.1.1",
                            Name = @"Nurse Unit (station)",
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
                            Id = @"RXE.8.1.2",
                            Type = @"SubComponent",
                            Position = @"RXE.8.1.2",
                            Name = @"Room",
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
                            Id = @"RXE.8.1.3",
                            Type = @"SubComponent",
                            Position = @"RXE.8.1.3",
                            Name = @"Bed",
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
                            Id = @"RXE.8.1.4",
                            Type = @"SubComponent",
                            Position = @"RXE.8.1.4",
                            Name = @"Facility Id",
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
                            Id = @"RXE.8.1.5",
                            Type = @"SubComponent",
                            Position = @"RXE.8.1.5",
                            Name = @"Bed Status",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.2",
                            Type = @"Component",
                            Position = @"RXE.8.2",
                            Name = @"Location",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component can be used to specify an address.  This could be used to fill mail orders to a patient or provider, or to account for home health care. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.8.2.1",
                            Type = @"SubComponent",
                            Position = @"RXE.8.2.1",
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
                            Id = @"RXE.8.2.2",
                            Type = @"SubComponent",
                            Position = @"RXE.8.2.2",
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
                            Id = @"RXE.8.2.3",
                            Type = @"SubComponent",
                            Position = @"RXE.8.2.3",
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
                            Id = @"RXE.8.2.4",
                            Type = @"SubComponent",
                            Position = @"RXE.8.2.4",
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
                            Id = @"RXE.8.2.5",
                            Type = @"SubComponent",
                            Position = @"RXE.8.2.5",
                            Name = @"Zip Or Postal Code",
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
                            Id = @"RXE.8.2.6",
                            Type = @"SubComponent",
                            Position = @"RXE.8.2.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.2.7",
                            Type = @"SubComponent",
                            Position = @"RXE.8.2.7",
                            Name = @"Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0190",
                            TableName = @"ADDRESS TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.2.8",
                            Type = @"SubComponent",
                            Position = @"RXE.8.2.8",
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
                        },}
                        },
                        }
        }

        _delivertoLocation = new HL7V22Field
        {
            field = message[@"RXE"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delivertoLocation.field.FieldRepetitions != null && _delivertoLocation.field.FieldRepetitions.Count > 0)
        {
            _delivertoLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_delivertoLocation, fieldData);
        }

        return _delivertoLocation;
    } 
}

internal HL7V22Field _substitutionStatus;

public HL7V22Field SubstitutionStatus
{
    get
    {
        if (_substitutionStatus != null)
        {
            return _substitutionStatus;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.9",
            Type = @"Field",
            Position = @"RXE.9",
            Name = @"Substitution Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0167",
            TableName = @"SUBSTITUTION STATUS",
            Description = @"refer to table 0167 - substitution status for valid values.  If a substitution has been made, and a record of the original requested give code (RXO-1) is needed, the optional RXO segment can be included in the RDE message",
            Sample = @"",
            Fields = null
        }

        _substitutionStatus = new HL7V22Field
        {
            field = message[@"RXE"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substitutionStatus.field.FieldRepetitions != null && _substitutionStatus.field.FieldRepetitions.Count > 0)
        {
            _substitutionStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_substitutionStatus, fieldData);
        }

        return _substitutionStatus;
    } 
}

internal HL7V22Field _dispenseAmount;

public HL7V22Field DispenseAmount
{
    get
    {
        if (_dispenseAmount != null)
        {
            return _dispenseAmount;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.10",
            Type = @"Field",
            Position = @"RXE.10",
            Name = @"Dispense Amount",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount dispensed as encoded by the pharmacy",
            Sample = @"",
            Fields = null
        }

        _dispenseAmount = new HL7V22Field
        {
            field = message[@"RXE"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dispenseAmount.field.FieldRepetitions != null && _dispenseAmount.field.FieldRepetitions.Count > 0)
        {
            _dispenseAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dispenseAmount, fieldData);
        }

        return _dispenseAmount;
    } 
}

internal HL7V22Field _dispenseUnits;

public HL7V22Field DispenseUnits
{
    get
    {
        if (_dispenseUnits != null)
        {
            return _dispenseUnits;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.11",
            Type = @"Field",
            Position = @"RXE.11",
            Name = @"Dispense Units",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"units for the dispense amount as encoded by the pharmacy.  This must be in simple units that reflect the actual quantity of the substance dispensed.  It does not include compound units",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.11.1",
                            Type = @"Component",
                            Position = @"RXE.11.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.11.2",
                            Type = @"Component",
                            Position = @"RXE.11.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.11.3",
                            Type = @"Component",
                            Position = @"RXE.11.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.11.4",
                            Type = @"Component",
                            Position = @"RXE.11.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.11.5",
                            Type = @"Component",
                            Position = @"RXE.11.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.11.6",
                            Type = @"Component",
                            Position = @"RXE.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dispenseUnits = new HL7V22Field
        {
            field = message[@"RXE"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dispenseUnits.field.FieldRepetitions != null && _dispenseUnits.field.FieldRepetitions.Count > 0)
        {
            _dispenseUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dispenseUnits, fieldData);
        }

        return _dispenseUnits;
    } 
}

internal HL7V22Field _numberOfRefills;

public HL7V22Field NumberOfRefills
{
    get
    {
        if (_numberOfRefills != null)
        {
            return _numberOfRefills;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.12",
            Type = @"Field",
            Position = @"RXE.12",
            Name = @"Number Of Refills",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"total original number of refills.  Outpatient only",
            Sample = @"",
            Fields = null
        }

        _numberOfRefills = new HL7V22Field
        {
            field = message[@"RXE"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfRefills.field.FieldRepetitions != null && _numberOfRefills.field.FieldRepetitions.Count > 0)
        {
            _numberOfRefills.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_numberOfRefills, fieldData);
        }

        return _numberOfRefills;
    } 
}

internal HL7V22Field _orderingProvidersDeaNumber;

public HL7V22Field OrderingProvidersDeaNumber
{
    get
    {
        if (_orderingProvidersDeaNumber != null)
        {
            return _orderingProvidersDeaNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.13",
            Type = @"Field",
            Position = @"RXE.13",
            Name = @"Ordering Provider's Dea Number",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"if required by the site",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.13.1",
                            Type = @"Component",
                            Position = @"RXE.13.1",
                            Name = @"Id Number",
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
                            Id = @"RXE.13.2",
                            Type = @"Component",
                            Position = @"RXE.13.2",
                            Name = @"Familiy Name",
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
                            Id = @"RXE.13.3",
                            Type = @"Component",
                            Position = @"RXE.13.3",
                            Name = @"Given Name",
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
                            Id = @"RXE.13.4",
                            Type = @"Component",
                            Position = @"RXE.13.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"RXE.13.5",
                            Type = @"Component",
                            Position = @"RXE.13.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"RXE.13.6",
                            Type = @"Component",
                            Position = @"RXE.13.6",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"RXE.13.7",
                            Type = @"Component",
                            Position = @"RXE.13.7",
                            Name = @"Degree (e.g. Md)",
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
                            Id = @"RXE.13.8",
                            Type = @"Component",
                            Position = @"RXE.13.8",
                            Name = @"Source Table Id",
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
                        }
        }

        _orderingProvidersDeaNumber = new HL7V22Field
        {
            field = message[@"RXE"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderingProvidersDeaNumber.field.FieldRepetitions != null && _orderingProvidersDeaNumber.field.FieldRepetitions.Count > 0)
        {
            _orderingProvidersDeaNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_orderingProvidersDeaNumber, fieldData);
        }

        return _orderingProvidersDeaNumber;
    } 
}

internal HL7V22Field _pharmacistVerifierId;

public HL7V22Field PharmacistVerifierId
{
    get
    {
        if (_pharmacistVerifierId != null)
        {
            return _pharmacistVerifierId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.14",
            Type = @"Field",
            Position = @"RXE.14",
            Name = @"Pharmacist Verifier Id",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"provider ID of pharmacist verifier.  Use if required by the Pharmacy application or site on orders (or some subgroup of orders). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.14.1",
                            Type = @"Component",
                            Position = @"RXE.14.1",
                            Name = @"Id Number",
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
                            Id = @"RXE.14.2",
                            Type = @"Component",
                            Position = @"RXE.14.2",
                            Name = @"Familiy Name",
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
                            Id = @"RXE.14.3",
                            Type = @"Component",
                            Position = @"RXE.14.3",
                            Name = @"Given Name",
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
                            Id = @"RXE.14.4",
                            Type = @"Component",
                            Position = @"RXE.14.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"RXE.14.5",
                            Type = @"Component",
                            Position = @"RXE.14.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"RXE.14.6",
                            Type = @"Component",
                            Position = @"RXE.14.6",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"RXE.14.7",
                            Type = @"Component",
                            Position = @"RXE.14.7",
                            Name = @"Degree (e.g. Md)",
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
                            Id = @"RXE.14.8",
                            Type = @"Component",
                            Position = @"RXE.14.8",
                            Name = @"Source Table Id",
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
                        }
        }

        _pharmacistVerifierId = new HL7V22Field
        {
            field = message[@"RXE"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pharmacistVerifierId.field.FieldRepetitions != null && _pharmacistVerifierId.field.FieldRepetitions.Count > 0)
        {
            _pharmacistVerifierId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_pharmacistVerifierId, fieldData);
        }

        return _pharmacistVerifierId;
    } 
}

internal HL7V22Field _prescriptionNumber;

public HL7V22Field PrescriptionNumber
{
    get
    {
        if (_prescriptionNumber != null)
        {
            return _prescriptionNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.15",
            Type = @"Field",
            Position = @"RXE.15",
            Name = @"Prescription Number",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"as assigned by the pharmacy application.  Equivalent in uniqueness to the Pharmacy filler order number.  At some sites, this may be the Pharmacy (internal) sequential form.  At other sites, this may be an external form",
            Sample = @"",
            Fields = null
        }

        _prescriptionNumber = new HL7V22Field
        {
            field = message[@"RXE"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_prescriptionNumber.field.FieldRepetitions != null && _prescriptionNumber.field.FieldRepetitions.Count > 0)
        {
            _prescriptionNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_prescriptionNumber, fieldData);
        }

        return _prescriptionNumber;
    } 
}

internal HL7V22Field _numberOfRefillsRemaining;

public HL7V22Field NumberOfRefillsRemaining
{
    get
    {
        if (_numberOfRefillsRemaining != null)
        {
            return _numberOfRefillsRemaining;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.16",
            Type = @"Field",
            Position = @"RXE.16",
            Name = @"Number Of Refills Remaining",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"outpatient only",
            Sample = @"",
            Fields = null
        }

        _numberOfRefillsRemaining = new HL7V22Field
        {
            field = message[@"RXE"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfRefillsRemaining.field.FieldRepetitions != null && _numberOfRefillsRemaining.field.FieldRepetitions.Count > 0)
        {
            _numberOfRefillsRemaining.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_numberOfRefillsRemaining, fieldData);
        }

        return _numberOfRefillsRemaining;
    } 
}

internal HL7V22Field _numberOfRefillsDosesDispensed;

public HL7V22Field NumberOfRefillsDosesDispensed
{
    get
    {
        if (_numberOfRefillsDosesDispensed != null)
        {
            return _numberOfRefillsDosesDispensed;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.17",
            Type = @"Field",
            Position = @"RXE.17",
            Name = @"Number Of Refills / Doses Dispensed",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"outpatient only. ",
            Sample = @"",
            Fields = null
        }

        _numberOfRefillsDosesDispensed = new HL7V22Field
        {
            field = message[@"RXE"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfRefillsDosesDispensed.field.FieldRepetitions != null && _numberOfRefillsDosesDispensed.field.FieldRepetitions.Count > 0)
        {
            _numberOfRefillsDosesDispensed.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_numberOfRefillsDosesDispensed, fieldData);
        }

        return _numberOfRefillsDosesDispensed;
    } 
}

internal HL7V22Field _dateTimeOfMostRecentRefillOrDoseDispensed;

public HL7V22Field DateTimeOfMostRecentRefillOrDoseDispensed
{
    get
    {
        if (_dateTimeOfMostRecentRefillOrDoseDispensed != null)
        {
            return _dateTimeOfMostRecentRefillOrDoseDispensed;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.18",
            Type = @"Field",
            Position = @"RXE.18",
            Name = @"Date / Time Of Most Recent Refill Or Dose Dispensed",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time of the most recent refill or dose dispensed, use Time Stamp format",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.18.1",
                            Type = @"Component",
                            Position = @"RXE.18.1",
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
                            Id = @"RXE.18.2",
                            Type = @"Component",
                            Position = @"RXE.18.2",
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
                        },
                        }
        }

        _dateTimeOfMostRecentRefillOrDoseDispensed = new HL7V22Field
        {
            field = message[@"RXE"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeOfMostRecentRefillOrDoseDispensed.field.FieldRepetitions != null && _dateTimeOfMostRecentRefillOrDoseDispensed.field.FieldRepetitions.Count > 0)
        {
            _dateTimeOfMostRecentRefillOrDoseDispensed.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dateTimeOfMostRecentRefillOrDoseDispensed, fieldData);
        }

        return _dateTimeOfMostRecentRefillOrDoseDispensed;
    } 
}

internal HL7V22Field _totalDailyDose;

public HL7V22Field TotalDailyDose
{
    get
    {
        if (_totalDailyDose != null)
        {
            return _totalDailyDose;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.19",
            Type = @"Field",
            Position = @"RXE.19",
            Name = @"Total Daily Dose",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"total daily dose for this particular pharmaceutical as expressed in terms of actual dispense units",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.19.1",
                            Type = @"Component",
                            Position = @"RXE.19.1",
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
                            Id = @"RXE.19.2",
                            Type = @"Component",
                            Position = @"RXE.19.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed.  Field-by-field, default units may be defined within the specifications.  When the observation is measured in the default units, the units need not be transmitted.  If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component.  If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7.  If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7.  But in these cases the component separator should be replaced by the subcomponent delimiter ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _totalDailyDose = new HL7V22Field
        {
            field = message[@"RXE"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_totalDailyDose.field.FieldRepetitions != null && _totalDailyDose.field.FieldRepetitions.Count > 0)
        {
            _totalDailyDose.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_totalDailyDose, fieldData);
        }

        return _totalDailyDose;
    } 
}

internal HL7V22Field _needsHumanReview;

public HL7V22Field NeedsHumanReview
{
    get
    {
        if (_needsHumanReview != null)
        {
            return _needsHumanReview;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.20",
            Type = @"Field",
            Position = @"RXE.20",
            Name = @"Needs Human Review",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"uses table 0136 - Y/N indicator. ",
            Sample = @"",
            Fields = null
        }

        _needsHumanReview = new HL7V22Field
        {
            field = message[@"RXE"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_needsHumanReview.field.FieldRepetitions != null && _needsHumanReview.field.FieldRepetitions.Count > 0)
        {
            _needsHumanReview.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_needsHumanReview, fieldData);
        }

        return _needsHumanReview;
    } 
}

internal HL7V22Field _pharmacySpecialDispensingInstructions;

public HL7V22Field PharmacySpecialDispensingInstructions
{
    get
    {
        if (_pharmacySpecialDispensingInstructions != null)
        {
            return _pharmacySpecialDispensingInstructions;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.21",
            Type = @"Field",
            Position = @"RXE.21",
            Name = @"Pharmacy Special Dispensing Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"pharmacy-generated special instructions to the provider dispensing/administering the order",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.21.1",
                            Type = @"Component",
                            Position = @"RXE.21.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.21.2",
                            Type = @"Component",
                            Position = @"RXE.21.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.21.3",
                            Type = @"Component",
                            Position = @"RXE.21.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.21.4",
                            Type = @"Component",
                            Position = @"RXE.21.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.21.5",
                            Type = @"Component",
                            Position = @"RXE.21.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.21.6",
                            Type = @"Component",
                            Position = @"RXE.21.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _pharmacySpecialDispensingInstructions = new HL7V22Field
        {
            field = message[@"RXE"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pharmacySpecialDispensingInstructions.field.FieldRepetitions != null && _pharmacySpecialDispensingInstructions.field.FieldRepetitions.Count > 0)
        {
            _pharmacySpecialDispensingInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_pharmacySpecialDispensingInstructions, fieldData);
        }

        return _pharmacySpecialDispensingInstructions;
    } 
}

internal HL7V22Field _givePertimeUnit;

public HL7V22Field GivePertimeUnit
{
    get
    {
        if (_givePertimeUnit != null)
        {
            return _givePertimeUnit;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.22",
            Type = @"Field",
            Position = @"RXE.22",
            Name = @"Give Per (time Unit)",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"time unit to use to calculate the rate at which the pharmaceutical is to be administered",
            Sample = @"",
            Fields = null
        }

        _givePertimeUnit = new HL7V22Field
        {
            field = message[@"RXE"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_givePertimeUnit.field.FieldRepetitions != null && _givePertimeUnit.field.FieldRepetitions.Count > 0)
        {
            _givePertimeUnit.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_givePertimeUnit, fieldData);
        }

        return _givePertimeUnit;
    } 
}

internal HL7V22Field _giveRateAmount;

public HL7V22Field GiveRateAmount
{
    get
    {
        if (_giveRateAmount != null)
        {
            return _giveRateAmount;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.23",
            Type = @"Field",
            Position = @"RXE.23",
            Name = @"Give Rate Amount",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"amount (number) of substance to be administered",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.23.1",
                            Type = @"Component",
                            Position = @"RXE.23.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.23.2",
                            Type = @"Component",
                            Position = @"RXE.23.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.23.3",
                            Type = @"Component",
                            Position = @"RXE.23.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.23.4",
                            Type = @"Component",
                            Position = @"RXE.23.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.23.5",
                            Type = @"Component",
                            Position = @"RXE.23.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.23.6",
                            Type = @"Component",
                            Position = @"RXE.23.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _giveRateAmount = new HL7V22Field
        {
            field = message[@"RXE"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveRateAmount.field.FieldRepetitions != null && _giveRateAmount.field.FieldRepetitions.Count > 0)
        {
            _giveRateAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_giveRateAmount, fieldData);
        }

        return _giveRateAmount;
    } 
}

internal HL7V22Field _giveRateUnits;

public HL7V22Field GiveRateUnits
{
    get
    {
        if (_giveRateUnits != null)
        {
            return _giveRateUnits;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXE.24",
            Type = @"Field",
            Position = @"RXE.24",
            Name = @"Give Rate Units",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"units for Give Rate Amount.  May be composite.  The ratio of the Give Rate Amount and Give Rate Units fields define the actual rate of administration.  Thus, if Give Rate Amount = 100 and Give Rate Units = ml/hr, the requested rate of administration is 100 ml/hr. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.24.1",
                            Type = @"Component",
                            Position = @"RXE.24.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.24.2",
                            Type = @"Component",
                            Position = @"RXE.24.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.24.3",
                            Type = @"Component",
                            Position = @"RXE.24.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.24.4",
                            Type = @"Component",
                            Position = @"RXE.24.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.24.5",
                            Type = @"Component",
                            Position = @"RXE.24.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.24.6",
                            Type = @"Component",
                            Position = @"RXE.24.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _giveRateUnits = new HL7V22Field
        {
            field = message[@"RXE"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveRateUnits.field.FieldRepetitions != null && _giveRateUnits.field.FieldRepetitions.Count > 0)
        {
            _giveRateUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_giveRateUnits, fieldData);
        }

        return _giveRateUnits;
    } 
}
    }
}
