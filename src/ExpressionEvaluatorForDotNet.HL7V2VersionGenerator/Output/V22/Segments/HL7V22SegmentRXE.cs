using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentRXE
    {
        public readonly HL7V2Message message;

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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = new []{
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
                            FieldDatas = new []{
                        new HL7V2FieldData
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
                        },
                        }
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
                            FieldDatas = new []{
                        new HL7V2FieldData
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
                        },
                        }
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
                            FieldDatas = new []{
                        new HL7V2FieldData
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
                        },
                        }
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
                            FieldDatas = new []{
                        new HL7V2FieldData
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
                        },
                        }
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
                            FieldDatas = new []{
                        new HL7V2FieldData
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
                        },
                        }
                        },
                        }
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                            FieldDatas = new []{
                        new HL7V2FieldData
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
                        },
                        }
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
                            FieldDatas = new []{
                        new HL7V2FieldData
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
                        },
                        }
                        },
                        }
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{
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
                        },
                        };
            }
        }

        public HL7V22SegmentRXE(HL7V2Message message)
        {
            this.message = message;
        }

        
internal HL7V22Field quantityTiming;

public HL7V22Field QuantityTiming
{
    get
    {
        if (quantityTiming != null)
        {
            return quantityTiming;
        }

        quantityTiming = new HL7V22Field
        {
            field = message[@"RXE"][1],
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
        };

        // check for repetitions
        if (quantityTiming.field.FieldRepetitions != null && quantityTiming.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityTiming.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < quantityTiming.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = quantityTiming.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < quantityTiming.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = quantityTiming.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < quantityTiming.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = quantityTiming.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            quantityTiming.fieldRepetitions = fieldRepetitions;
        }

        return quantityTiming;
    } 
}

internal HL7V22Field giveCode;

public HL7V22Field GiveCode
{
    get
    {
        if (giveCode != null)
        {
            return giveCode;
        }

        giveCode = new HL7V22Field
        {
            field = message[@"RXE"][2],
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
        };

        // check for repetitions
        if (giveCode.field.FieldRepetitions != null && giveCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(giveCode.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < giveCode.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = giveCode.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < giveCode.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = giveCode.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < giveCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = giveCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            giveCode.fieldRepetitions = fieldRepetitions;
        }

        return giveCode;
    } 
}

internal HL7V22Field giveAmountMinimum;

public HL7V22Field GiveAmountMinimum
{
    get
    {
        if (giveAmountMinimum != null)
        {
            return giveAmountMinimum;
        }

        giveAmountMinimum = new HL7V22Field
        {
            field = message[@"RXE"][3],
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
        };

        // check for repetitions
        if (giveAmountMinimum.field.FieldRepetitions != null && giveAmountMinimum.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(giveAmountMinimum.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < giveAmountMinimum.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = giveAmountMinimum.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < giveAmountMinimum.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = giveAmountMinimum.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < giveAmountMinimum.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = giveAmountMinimum.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            giveAmountMinimum.fieldRepetitions = fieldRepetitions;
        }

        return giveAmountMinimum;
    } 
}

internal HL7V22Field giveAmountMaximum;

public HL7V22Field GiveAmountMaximum
{
    get
    {
        if (giveAmountMaximum != null)
        {
            return giveAmountMaximum;
        }

        giveAmountMaximum = new HL7V22Field
        {
            field = message[@"RXE"][4],
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
        };

        // check for repetitions
        if (giveAmountMaximum.field.FieldRepetitions != null && giveAmountMaximum.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(giveAmountMaximum.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < giveAmountMaximum.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = giveAmountMaximum.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < giveAmountMaximum.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = giveAmountMaximum.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < giveAmountMaximum.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = giveAmountMaximum.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            giveAmountMaximum.fieldRepetitions = fieldRepetitions;
        }

        return giveAmountMaximum;
    } 
}

internal HL7V22Field giveUnits;

public HL7V22Field GiveUnits
{
    get
    {
        if (giveUnits != null)
        {
            return giveUnits;
        }

        giveUnits = new HL7V22Field
        {
            field = message[@"RXE"][5],
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
        };

        // check for repetitions
        if (giveUnits.field.FieldRepetitions != null && giveUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(giveUnits.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < giveUnits.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = giveUnits.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < giveUnits.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = giveUnits.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < giveUnits.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = giveUnits.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            giveUnits.fieldRepetitions = fieldRepetitions;
        }

        return giveUnits;
    } 
}

internal HL7V22Field giveDosageForm;

public HL7V22Field GiveDosageForm
{
    get
    {
        if (giveDosageForm != null)
        {
            return giveDosageForm;
        }

        giveDosageForm = new HL7V22Field
        {
            field = message[@"RXE"][6],
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
        };

        // check for repetitions
        if (giveDosageForm.field.FieldRepetitions != null && giveDosageForm.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(giveDosageForm.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < giveDosageForm.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = giveDosageForm.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < giveDosageForm.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = giveDosageForm.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < giveDosageForm.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = giveDosageForm.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            giveDosageForm.fieldRepetitions = fieldRepetitions;
        }

        return giveDosageForm;
    } 
}

internal HL7V22Field providersAdministrationInstructions;

public HL7V22Field ProvidersAdministrationInstructions
{
    get
    {
        if (providersAdministrationInstructions != null)
        {
            return providersAdministrationInstructions;
        }

        providersAdministrationInstructions = new HL7V22Field
        {
            field = message[@"RXE"][7],
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
        };

        // check for repetitions
        if (providersAdministrationInstructions.field.FieldRepetitions != null && providersAdministrationInstructions.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(providersAdministrationInstructions.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < providersAdministrationInstructions.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = providersAdministrationInstructions.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < providersAdministrationInstructions.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = providersAdministrationInstructions.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < providersAdministrationInstructions.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = providersAdministrationInstructions.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            providersAdministrationInstructions.fieldRepetitions = fieldRepetitions;
        }

        return providersAdministrationInstructions;
    } 
}

internal HL7V22Field delivertoLocation;

public HL7V22Field DelivertoLocation
{
    get
    {
        if (delivertoLocation != null)
        {
            return delivertoLocation;
        }

        delivertoLocation = new HL7V22Field
        {
            field = message[@"RXE"][8],
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
        };

        // check for repetitions
        if (delivertoLocation.field.FieldRepetitions != null && delivertoLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(delivertoLocation.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < delivertoLocation.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = delivertoLocation.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < delivertoLocation.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = delivertoLocation.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < delivertoLocation.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = delivertoLocation.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            delivertoLocation.fieldRepetitions = fieldRepetitions;
        }

        return delivertoLocation;
    } 
}

internal HL7V22Field substitutionStatus;

public HL7V22Field SubstitutionStatus
{
    get
    {
        if (substitutionStatus != null)
        {
            return substitutionStatus;
        }

        substitutionStatus = new HL7V22Field
        {
            field = message[@"RXE"][9],
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
        };

        // check for repetitions
        if (substitutionStatus.field.FieldRepetitions != null && substitutionStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(substitutionStatus.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < substitutionStatus.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = substitutionStatus.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < substitutionStatus.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = substitutionStatus.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < substitutionStatus.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = substitutionStatus.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            substitutionStatus.fieldRepetitions = fieldRepetitions;
        }

        return substitutionStatus;
    } 
}

internal HL7V22Field dispenseAmount;

public HL7V22Field DispenseAmount
{
    get
    {
        if (dispenseAmount != null)
        {
            return dispenseAmount;
        }

        dispenseAmount = new HL7V22Field
        {
            field = message[@"RXE"][10],
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
        };

        // check for repetitions
        if (dispenseAmount.field.FieldRepetitions != null && dispenseAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dispenseAmount.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < dispenseAmount.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = dispenseAmount.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < dispenseAmount.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = dispenseAmount.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < dispenseAmount.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = dispenseAmount.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            dispenseAmount.fieldRepetitions = fieldRepetitions;
        }

        return dispenseAmount;
    } 
}

internal HL7V22Field dispenseUnits;

public HL7V22Field DispenseUnits
{
    get
    {
        if (dispenseUnits != null)
        {
            return dispenseUnits;
        }

        dispenseUnits = new HL7V22Field
        {
            field = message[@"RXE"][11],
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
        };

        // check for repetitions
        if (dispenseUnits.field.FieldRepetitions != null && dispenseUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dispenseUnits.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < dispenseUnits.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = dispenseUnits.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < dispenseUnits.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = dispenseUnits.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < dispenseUnits.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = dispenseUnits.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            dispenseUnits.fieldRepetitions = fieldRepetitions;
        }

        return dispenseUnits;
    } 
}

internal HL7V22Field numberOfRefills;

public HL7V22Field NumberOfRefills
{
    get
    {
        if (numberOfRefills != null)
        {
            return numberOfRefills;
        }

        numberOfRefills = new HL7V22Field
        {
            field = message[@"RXE"][12],
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
        };

        // check for repetitions
        if (numberOfRefills.field.FieldRepetitions != null && numberOfRefills.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberOfRefills.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < numberOfRefills.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = numberOfRefills.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < numberOfRefills.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = numberOfRefills.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < numberOfRefills.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = numberOfRefills.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            numberOfRefills.fieldRepetitions = fieldRepetitions;
        }

        return numberOfRefills;
    } 
}

internal HL7V22Field orderingProvidersDeaNumber;

public HL7V22Field OrderingProvidersDeaNumber
{
    get
    {
        if (orderingProvidersDeaNumber != null)
        {
            return orderingProvidersDeaNumber;
        }

        orderingProvidersDeaNumber = new HL7V22Field
        {
            field = message[@"RXE"][13],
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
        };

        // check for repetitions
        if (orderingProvidersDeaNumber.field.FieldRepetitions != null && orderingProvidersDeaNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(orderingProvidersDeaNumber.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < orderingProvidersDeaNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = orderingProvidersDeaNumber.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < orderingProvidersDeaNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = orderingProvidersDeaNumber.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < orderingProvidersDeaNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = orderingProvidersDeaNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            orderingProvidersDeaNumber.fieldRepetitions = fieldRepetitions;
        }

        return orderingProvidersDeaNumber;
    } 
}

internal HL7V22Field pharmacistVerifierId;

public HL7V22Field PharmacistVerifierId
{
    get
    {
        if (pharmacistVerifierId != null)
        {
            return pharmacistVerifierId;
        }

        pharmacistVerifierId = new HL7V22Field
        {
            field = message[@"RXE"][14],
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
        };

        // check for repetitions
        if (pharmacistVerifierId.field.FieldRepetitions != null && pharmacistVerifierId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pharmacistVerifierId.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < pharmacistVerifierId.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = pharmacistVerifierId.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < pharmacistVerifierId.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = pharmacistVerifierId.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < pharmacistVerifierId.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = pharmacistVerifierId.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            pharmacistVerifierId.fieldRepetitions = fieldRepetitions;
        }

        return pharmacistVerifierId;
    } 
}

internal HL7V22Field prescriptionNumber;

public HL7V22Field PrescriptionNumber
{
    get
    {
        if (prescriptionNumber != null)
        {
            return prescriptionNumber;
        }

        prescriptionNumber = new HL7V22Field
        {
            field = message[@"RXE"][15],
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
        };

        // check for repetitions
        if (prescriptionNumber.field.FieldRepetitions != null && prescriptionNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(prescriptionNumber.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < prescriptionNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = prescriptionNumber.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < prescriptionNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = prescriptionNumber.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < prescriptionNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = prescriptionNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            prescriptionNumber.fieldRepetitions = fieldRepetitions;
        }

        return prescriptionNumber;
    } 
}

internal HL7V22Field numberOfRefillsRemaining;

public HL7V22Field NumberOfRefillsRemaining
{
    get
    {
        if (numberOfRefillsRemaining != null)
        {
            return numberOfRefillsRemaining;
        }

        numberOfRefillsRemaining = new HL7V22Field
        {
            field = message[@"RXE"][16],
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
        };

        // check for repetitions
        if (numberOfRefillsRemaining.field.FieldRepetitions != null && numberOfRefillsRemaining.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberOfRefillsRemaining.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < numberOfRefillsRemaining.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = numberOfRefillsRemaining.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < numberOfRefillsRemaining.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = numberOfRefillsRemaining.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < numberOfRefillsRemaining.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = numberOfRefillsRemaining.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            numberOfRefillsRemaining.fieldRepetitions = fieldRepetitions;
        }

        return numberOfRefillsRemaining;
    } 
}

internal HL7V22Field numberOfRefillsDosesDispensed;

public HL7V22Field NumberOfRefillsDosesDispensed
{
    get
    {
        if (numberOfRefillsDosesDispensed != null)
        {
            return numberOfRefillsDosesDispensed;
        }

        numberOfRefillsDosesDispensed = new HL7V22Field
        {
            field = message[@"RXE"][17],
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
        };

        // check for repetitions
        if (numberOfRefillsDosesDispensed.field.FieldRepetitions != null && numberOfRefillsDosesDispensed.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberOfRefillsDosesDispensed.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < numberOfRefillsDosesDispensed.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = numberOfRefillsDosesDispensed.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < numberOfRefillsDosesDispensed.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = numberOfRefillsDosesDispensed.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < numberOfRefillsDosesDispensed.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = numberOfRefillsDosesDispensed.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            numberOfRefillsDosesDispensed.fieldRepetitions = fieldRepetitions;
        }

        return numberOfRefillsDosesDispensed;
    } 
}

internal HL7V22Field dateTimeOfMostRecentRefillOrDoseDispensed;

public HL7V22Field DateTimeOfMostRecentRefillOrDoseDispensed
{
    get
    {
        if (dateTimeOfMostRecentRefillOrDoseDispensed != null)
        {
            return dateTimeOfMostRecentRefillOrDoseDispensed;
        }

        dateTimeOfMostRecentRefillOrDoseDispensed = new HL7V22Field
        {
            field = message[@"RXE"][18],
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
        };

        // check for repetitions
        if (dateTimeOfMostRecentRefillOrDoseDispensed.field.FieldRepetitions != null && dateTimeOfMostRecentRefillOrDoseDispensed.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateTimeOfMostRecentRefillOrDoseDispensed.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < dateTimeOfMostRecentRefillOrDoseDispensed.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = dateTimeOfMostRecentRefillOrDoseDispensed.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < dateTimeOfMostRecentRefillOrDoseDispensed.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = dateTimeOfMostRecentRefillOrDoseDispensed.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < dateTimeOfMostRecentRefillOrDoseDispensed.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = dateTimeOfMostRecentRefillOrDoseDispensed.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            dateTimeOfMostRecentRefillOrDoseDispensed.fieldRepetitions = fieldRepetitions;
        }

        return dateTimeOfMostRecentRefillOrDoseDispensed;
    } 
}

internal HL7V22Field totalDailyDose;

public HL7V22Field TotalDailyDose
{
    get
    {
        if (totalDailyDose != null)
        {
            return totalDailyDose;
        }

        totalDailyDose = new HL7V22Field
        {
            field = message[@"RXE"][19],
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
        };

        // check for repetitions
        if (totalDailyDose.field.FieldRepetitions != null && totalDailyDose.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(totalDailyDose.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < totalDailyDose.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = totalDailyDose.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < totalDailyDose.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = totalDailyDose.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < totalDailyDose.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = totalDailyDose.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            totalDailyDose.fieldRepetitions = fieldRepetitions;
        }

        return totalDailyDose;
    } 
}

internal HL7V22Field needsHumanReview;

public HL7V22Field NeedsHumanReview
{
    get
    {
        if (needsHumanReview != null)
        {
            return needsHumanReview;
        }

        needsHumanReview = new HL7V22Field
        {
            field = message[@"RXE"][20],
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
        };

        // check for repetitions
        if (needsHumanReview.field.FieldRepetitions != null && needsHumanReview.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(needsHumanReview.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < needsHumanReview.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = needsHumanReview.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < needsHumanReview.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = needsHumanReview.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < needsHumanReview.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = needsHumanReview.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            needsHumanReview.fieldRepetitions = fieldRepetitions;
        }

        return needsHumanReview;
    } 
}

internal HL7V22Field pharmacySpecialDispensingInstructions;

public HL7V22Field PharmacySpecialDispensingInstructions
{
    get
    {
        if (pharmacySpecialDispensingInstructions != null)
        {
            return pharmacySpecialDispensingInstructions;
        }

        pharmacySpecialDispensingInstructions = new HL7V22Field
        {
            field = message[@"RXE"][21],
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
        };

        // check for repetitions
        if (pharmacySpecialDispensingInstructions.field.FieldRepetitions != null && pharmacySpecialDispensingInstructions.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pharmacySpecialDispensingInstructions.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < pharmacySpecialDispensingInstructions.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = pharmacySpecialDispensingInstructions.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < pharmacySpecialDispensingInstructions.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = pharmacySpecialDispensingInstructions.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < pharmacySpecialDispensingInstructions.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = pharmacySpecialDispensingInstructions.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            pharmacySpecialDispensingInstructions.fieldRepetitions = fieldRepetitions;
        }

        return pharmacySpecialDispensingInstructions;
    } 
}

internal HL7V22Field givePertimeUnit;

public HL7V22Field GivePertimeUnit
{
    get
    {
        if (givePertimeUnit != null)
        {
            return givePertimeUnit;
        }

        givePertimeUnit = new HL7V22Field
        {
            field = message[@"RXE"][22],
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
        };

        // check for repetitions
        if (givePertimeUnit.field.FieldRepetitions != null && givePertimeUnit.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(givePertimeUnit.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < givePertimeUnit.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = givePertimeUnit.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < givePertimeUnit.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = givePertimeUnit.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < givePertimeUnit.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = givePertimeUnit.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            givePertimeUnit.fieldRepetitions = fieldRepetitions;
        }

        return givePertimeUnit;
    } 
}

internal HL7V22Field giveRateAmount;

public HL7V22Field GiveRateAmount
{
    get
    {
        if (giveRateAmount != null)
        {
            return giveRateAmount;
        }

        giveRateAmount = new HL7V22Field
        {
            field = message[@"RXE"][23],
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
        };

        // check for repetitions
        if (giveRateAmount.field.FieldRepetitions != null && giveRateAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(giveRateAmount.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < giveRateAmount.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = giveRateAmount.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < giveRateAmount.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = giveRateAmount.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < giveRateAmount.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = giveRateAmount.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            giveRateAmount.fieldRepetitions = fieldRepetitions;
        }

        return giveRateAmount;
    } 
}

internal HL7V22Field giveRateUnits;

public HL7V22Field GiveRateUnits
{
    get
    {
        if (giveRateUnits != null)
        {
            return giveRateUnits;
        }

        giveRateUnits = new HL7V22Field
        {
            field = message[@"RXE"][24],
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
        };

        // check for repetitions
        if (giveRateUnits.field.FieldRepetitions != null && giveRateUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(giveRateUnits.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < giveRateUnits.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = giveRateUnits.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < giveRateUnits.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = giveRateUnits.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < giveRateUnits.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = giveRateUnits.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            giveRateUnits.fieldRepetitions = fieldRepetitions;
        }

        return giveRateUnits;
    } 
}

    }
}
