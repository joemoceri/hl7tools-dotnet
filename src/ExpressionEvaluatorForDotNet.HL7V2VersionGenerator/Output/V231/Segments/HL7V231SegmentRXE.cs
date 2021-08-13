using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentRXE
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RXE"; } }

        public string SegmentId { get { return @"RXE"; } }
        
        public string LongName { get { return @"Pharmacy/treatment encoded order segment"; } }
        
        public string Description { get { return @"The RXE segment details the pharmacy or treatment application's encoding of the order. It also contains several pharmacy-specific order status fields, such as RXE-16-number of refills remaining , RXE-17-number of refills/doses dispensed, RXE-18-D/T of most recent refill or dose dispensed , and RXE-19-total daily dose."; } }
        
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

        public HL7V231SegmentRXE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _quantityTiming;

public HL7V231Field QuantityTiming
{
    get
    {
        if (_quantityTiming != null)
        {
            return _quantityTiming;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.1",
            Type = @"Field",
            Position = @"RXE.1",
            Name = @"Quantity/Timing",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TQ",
            DataTypeName = @"Timing Quantity",
            TableId = null,
            TableName = null,
            Description = @"See Section 4.8.7, 'RXE - pharmacy/treatment encoded order segment,' for necessary modification for this field's definition to cover interorder dependencies needed by pharmacy/treatment orders. This field is used by the pharmacy or non-pharmacy treatment supplier to express the fully-coded version of the drug or treatment timing. It may differ from ORC-7-quantity/timing, which contains the requested quantity/timing of the original order.",
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
                            Description = @"This field specifies the quantity of the service that should be provided at each service interval. For example, if two blood cultures are to be obtained every 4 hours, the quantity would be 2.  If three units of blood are to be typed and cross-matched, the quantity would be 3.  The default value is 1.  When units are required, they can be added, specified by a subcomponent delimiter.

Note: The component delimiter in this CQ is demoted to a subcomponent delimiter.",
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
                            Description = @"The units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the observation is measured in the default units, the units need not be transmitted. If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component. If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7. If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7. But in these cases the component separator should be replaced by the subcomponent delimiter",
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
                            DataType = @"RI",
                            DataTypeName = @"Repeat Interval",
                            TableId = null,
                            TableName = null,
                            Description = @"This field determines the interval between repeated services.
The default is one time only, the first subcomponent is the repeat pattern, and the second subcomponent is the explicit time at which pattern is to be executed.",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The repeating frequency with which the treatment is to be administered.  It is similar to the frequency and SIG code tables used in order entry systems",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.2.2",
                            Type = @"SubComponent",
                            Position = @"RXE.1.2.2",
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
                            Description = @"This field indicates how long the service should continue after it is started.  The default is INDEF (do indefinitely).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.4",
                            Type = @"Component",
                            Position = @"RXE.1.4",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be specified by the orderer, in which case it indicates the earliest date/time at which the services should be started.  In many cases, however, the start date/time will be implied or will be defined by other fields in the order record (e.g., urgency - STAT).  In such a case, this field will be empty.
The filling service will often record a value in this field after receipt of the order, however, and compute an end time on the basis of the start date/time for the filling service’s internal use.",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.5",
                            Type = @"Component",
                            Position = @"RXE.1.5",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"When filled in by the requester of the service, this field should contain the latest date/time that the service should be performed.  If it has not been performed by the specified time, it should not be performed at all.  The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.
Regardless of the value of the end date/time, the service should be stopped at the earliest of the date/times specified by either the duration or the end date/time.",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field describes the urgency of the request. (the default for Priority is R)",
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
                            Description = @"This field is a full text version of the instruction (optional)",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This non-null component indicates that a second timing specification is to follow using the repeat delimiter",
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
                            Description = @"There are many situations, such as the creation of an order for a group of intravenous (IV) solutions, where the sequence of the individual intravenous solutions (each a service in itself) needs to be specified, e.g., hyperalimentation with multi-vitamins in every third bottle.",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"OSD1",
                            TableName = @"Sequence condition",
                            Description = @"S for sequence conditions; C for cyclical; R is reserved for possible future use. The C will be used for indicating a repeating cycle of orders; for example, individual intravenous solutions used in a cyclical sequence (a.k.a. “Alternating IVs”).  This value would be compatible with linking separate orders or with having all cyclical order components in a single order.  Likewise, the value would be compatible with either Parent-Child messages or a single order message to communicate the orders’ sequencin",
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
                            Description = @"Contains the first two components of the placer order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL",
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
                            Description = @"Contains the first two components of the placer order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL",
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
                            Description = @"Contains the first two components of the filler order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7.",
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
                            Description = @"Contains the first two components of the filler order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7.",
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
                            Description = @"The acceptable condition values have the form commonly used in project planning methodologies: <one of “SS”, “EE”, “SE”, or “ES”> +/- <time> 

The first letter stands for start (S) or end (E) of predecessor order, where the predecessor is defined by the placer or filler order number in subcomponents 1,2 or subcomponents 3,4. 

The second letter stands for the start (S) or end (E) of the successor order, where the successor order is the order containing this quantity/timing specification. 

The time specifies the interval between the predecessor and successor starts or ends (see following examples). Where <time> is defined as:  

 - S<integer> do for <integer> seconds  
 - M<integer> do for <integer> minutes  
 - H<integer> do for <integer> hours  
 - D<integer> do for <integer> days  
 - W<integer> do for <integer> weeks  
 - L<integer> do for <integer> months",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.10.8",
                            Type = @"SubComponent",
                            Position = @"RXE.1.10.8",
                            Name = @"Placer Order Number Universal ID",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the placer order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.10.9",
                            Type = @"SubComponent",
                            Position = @"RXE.1.10.9",
                            Name = @"Placer Order Number Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the placer order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.10.10",
                            Type = @"SubComponent",
                            Position = @"RXE.1.10.10",
                            Name = @"Filler Order Number Universal ID",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the filler order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.10.11",
                            Type = @"SubComponent",
                            Position = @"RXE.1.10.11",
                            Name = @"Filler Order Number Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the filler order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.11",
                            Type = @"Component",
                            Position = @"RXE.1.11",
                            Name = @"Occurrence Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the duration for a single performance of a service, e.g., whirlpool twenty minutes three times per day for three days. It is optional within TQ and does not repeat.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.1.11.1",
                            Type = @"SubComponent",
                            Position = @"RXE.1.11.1",
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
                            Id = @"RXE.1.11.2",
                            Type = @"SubComponent",
                            Position = @"RXE.1.11.2",
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
                            Id = @"RXE.1.11.3",
                            Type = @"SubComponent",
                            Position = @"RXE.1.11.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.11.4",
                            Type = @"SubComponent",
                            Position = @"RXE.1.11.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.1.11.5",
                            Type = @"SubComponent",
                            Position = @"RXE.1.11.5",
                            Name = @"Alternate Text",
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
                            Id = @"RXE.1.11.6",
                            Type = @"SubComponent",
                            Position = @"RXE.1.11.6",
                            Name = @"Name Of Alternate Coding System",
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
                            Id = @"RXE.1.12",
                            Type = @"Component",
                            Position = @"RXE.1.12",
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

        _quantityTiming = new HL7V231Field
        {
            field = message[@"RXE"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityTiming.field.FieldRepetitions != null && _quantityTiming.field.FieldRepetitions.Count > 0)
        {
            _quantityTiming.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_quantityTiming, fieldData);
        }

        return _quantityTiming;
    } 
}

internal HL7V231Field _giveCode;

public HL7V231Field GiveCode
{
    get
    {
        if (_giveCode != null)
        {
            return _giveCode;
        }

        var fieldData = new HL7V231FieldData
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
            TableId = @"0292",
            TableName = @"Vaccines administered",
            Description = @"This field identifies the medical substance ordered to be given to the patient, as encoded by the pharmacy or treatment supplier; it is equivalent to OBR-4-universal service ID in function. In the RXE segment, this give code must be fully encoded. The dispense fields, which define the units and amount of what is to be issued to the patient (see RXE-10-dispense amount and RXE-11-dispense units below), do not necessarily correlate with the instructions of what amount is to be 'given' or administered with each dose, and may or may not be specified with the order. For example, the 'give' part of the order may convey the field-representation of give 250 mg of Ampicillin, while the request to dispense part of the order may convey issue 30 tablets of generic equivalent for this outpatient prescription . Refer to HL7 Table 0292 - Vaccines administered for valid values.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.2.4",
                            Type = @"Component",
                            Position = @"RXE.2.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _giveCode = new HL7V231Field
        {
            field = message[@"RXE"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveCode.field.FieldRepetitions != null && _giveCode.field.FieldRepetitions.Count > 0)
        {
            _giveCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_giveCode, fieldData);
        }

        return _giveCode;
    } 
}

internal HL7V231Field _giveAmountMinimum;

public HL7V231Field GiveAmountMinimum
{
    get
    {
        if (_giveAmountMinimum != null)
        {
            return _giveAmountMinimum;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the ordered amount as encoded by the pharmacy or treatment supplier. In a variable dose order, this is the minimum ordered amount. In a nonvarying dose order, this is the exact amount of the order.",
            Sample = @"",
            Fields = null
        }

        _giveAmountMinimum = new HL7V231Field
        {
            field = message[@"RXE"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveAmountMinimum.field.FieldRepetitions != null && _giveAmountMinimum.field.FieldRepetitions.Count > 0)
        {
            _giveAmountMinimum.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_giveAmountMinimum, fieldData);
        }

        return _giveAmountMinimum;
    } 
}

internal HL7V231Field _giveAmountMaximum;

public HL7V231Field GiveAmountMaximum
{
    get
    {
        if (_giveAmountMaximum != null)
        {
            return _giveAmountMaximum;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"In a variable dose order, this is the maximum ordered amount. In a nonvarying dose, this field is not used.",
            Sample = @"",
            Fields = null
        }

        _giveAmountMaximum = new HL7V231Field
        {
            field = message[@"RXE"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveAmountMaximum.field.FieldRepetitions != null && _giveAmountMaximum.field.FieldRepetitions.Count > 0)
        {
            _giveAmountMaximum.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_giveAmountMaximum, fieldData);
        }

        return _giveAmountMaximum;
    } 
}

internal HL7V231Field _giveUnits;

public HL7V231Field GiveUnits
{
    get
    {
        if (_giveUnits != null)
        {
            return _giveUnits;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the units for the give amount as encoded by the pharmacy or treatment (e.g., respiratory therapy) application.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.5.4",
                            Type = @"Component",
                            Position = @"RXE.5.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _giveUnits = new HL7V231Field
        {
            field = message[@"RXE"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveUnits.field.FieldRepetitions != null && _giveUnits.field.FieldRepetitions.Count > 0)
        {
            _giveUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_giveUnits, fieldData);
        }

        return _giveUnits;
    } 
}

internal HL7V231Field _giveDosageForm;

public HL7V231Field GiveDosageForm
{
    get
    {
        if (_giveDosageForm != null)
        {
            return _giveDosageForm;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"The dosage form indicates the manner in which the medication is aggregated for dispensing, e.g., tablets, capsules, suppositories. In some cases, this information is implied by the give code in RXE-2-give code . Use the RXE-6-give dosage form when the give code does not specify the dosage form.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.6.4",
                            Type = @"Component",
                            Position = @"RXE.6.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _giveDosageForm = new HL7V231Field
        {
            field = message[@"RXE"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveDosageForm.field.FieldRepetitions != null && _giveDosageForm.field.FieldRepetitions.Count > 0)
        {
            _giveDosageForm.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_giveDosageForm, fieldData);
        }

        return _giveDosageForm;
    } 
}

internal HL7V231Field _providerAdministrationInstructions;

public HL7V231Field ProviderAdministrationInstructions
{
    get
    {
        if (_providerAdministrationInstructions != null)
        {
            return _providerAdministrationInstructions;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.7",
            Type = @"Field",
            Position = @"RXE.7",
            Name = @"Provider Administration Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the ordering provider's instructions to the patient or the provider administering the drug or treatment. If coded, a user-defined table must be used; if free text (describing a custom IV, mixture, or salve, for example), place the text in the second component, e.g., |^this is a free text administration instruction| .",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.7.4",
                            Type = @"Component",
                            Position = @"RXE.7.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _providerAdministrationInstructions = new HL7V231Field
        {
            field = message[@"RXE"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_providerAdministrationInstructions.field.FieldRepetitions != null && _providerAdministrationInstructions.field.FieldRepetitions.Count > 0)
        {
            _providerAdministrationInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_providerAdministrationInstructions, fieldData);
        }

        return _providerAdministrationInstructions;
    } 
}

internal HL7V231Field _delivertoLocation;

public HL7V231Field DelivertoLocation
{
    get
    {
        if (_delivertoLocation != null)
        {
            return _delivertoLocation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.8",
            Type = @"Field",
            Position = @"RXE.8",
            Name = @"Deliver-to Location",
            Length = 200,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"LA1",
            DataTypeName = @"Location With Address Information (variant 1)",
            TableId = null,
            TableName = null,
            Description = @"The first component contains the inpatient or outpatient location to which the pharmacy or treatment supplier is to deliver the drug or treatment (if applicable). The default (null) value is the current census location for the patient. Site-specific table. The first eight components have the same form as the first eight components of PV1-3-assigned patient location. The final eight components replace the ninth component of PV1-3-assigned patient location and represent the full address specification.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.8.1",
                            Type = @"Component",
                            Position = @"RXE.8.1",
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
                            Id = @"RXE.8.2",
                            Type = @"Component",
                            Position = @"RXE.8.2",
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
                            Id = @"RXE.8.3",
                            Type = @"Component",
                            Position = @"RXE.8.3",
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
                            Id = @"RXE.8.4",
                            Type = @"Component",
                            Position = @"RXE.8.4",
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
                            Id = @"RXE.8.4.1",
                            Type = @"SubComponent",
                            Position = @"RXE.8.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.4.2",
                            Type = @"SubComponent",
                            Position = @"RXE.8.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.4.3",
                            Type = @"SubComponent",
                            Position = @"RXE.8.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.5",
                            Type = @"Component",
                            Position = @"RXE.8.5",
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
                            Id = @"RXE.8.6",
                            Type = @"Component",
                            Position = @"RXE.8.6",
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
                            Id = @"RXE.8.7",
                            Type = @"Component",
                            Position = @"RXE.8.7",
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
                            Id = @"RXE.8.8",
                            Type = @"Component",
                            Position = @"RXE.8.8",
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
                            Id = @"RXE.8.9",
                            Type = @"Component",
                            Position = @"RXE.8.9",
                            Name = @"Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.8.9.1",
                            Type = @"SubComponent",
                            Position = @"RXE.8.9.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.9.2",
                            Type = @"SubComponent",
                            Position = @"RXE.8.9.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In general, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.9.3",
                            Type = @"SubComponent",
                            Position = @"RXE.8.9.3",
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
                            Id = @"RXE.8.9.4",
                            Type = @"SubComponent",
                            Position = @"RXE.8.9.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"State or province should be represented by the official postal service codes for that country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.9.5",
                            Type = @"SubComponent",
                            Position = @"RXE.8.9.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.9.6",
                            Type = @"SubComponent",
                            Position = @"RXE.8.9.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used.[2] This ISO table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.9.7",
                            Type = @"SubComponent",
                            Position = @"RXE.8.9.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Type is optional and defined by HL7 table 0190 - Address type .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.8.9.8",
                            Type = @"SubComponent",
                            Position = @"RXE.8.9.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes county, bioregion, SMSA, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _delivertoLocation = new HL7V231Field
        {
            field = message[@"RXE"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delivertoLocation.field.FieldRepetitions != null && _delivertoLocation.field.FieldRepetitions.Count > 0)
        {
            _delivertoLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_delivertoLocation, fieldData);
        }

        return _delivertoLocation;
    } 
}

internal HL7V231Field _substitutionStatus;

public HL7V231Field SubstitutionStatus
{
    get
    {
        if (_substitutionStatus != null)
        {
            return _substitutionStatus;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.9",
            Type = @"Field",
            Position = @"RXE.9",
            Name = @"Substitution Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0167",
            TableName = @"Substitution status",
            Description = @"Refer to HL7 table 0167 - Substitution status for valid values. If a substitution has been made, and a record of the original requested give code (RXO-1-requested give code) is needed, the optional RXO segment can be included in the RDE message.",
            Sample = @"",
            Fields = null
        }

        _substitutionStatus = new HL7V231Field
        {
            field = message[@"RXE"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substitutionStatus.field.FieldRepetitions != null && _substitutionStatus.field.FieldRepetitions.Count > 0)
        {
            _substitutionStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_substitutionStatus, fieldData);
        }

        return _substitutionStatus;
    } 
}

internal HL7V231Field _dispenseAmount;

public HL7V231Field DispenseAmount
{
    get
    {
        if (_dispenseAmount != null)
        {
            return _dispenseAmount;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the amount dispensed as encoded by the pharmacy or treatment supplier.",
            Sample = @"",
            Fields = null
        }

        _dispenseAmount = new HL7V231Field
        {
            field = message[@"RXE"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dispenseAmount.field.FieldRepetitions != null && _dispenseAmount.field.FieldRepetitions.Count > 0)
        {
            _dispenseAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dispenseAmount, fieldData);
        }

        return _dispenseAmount;
    } 
}

internal HL7V231Field _dispenseUnits;

public HL7V231Field DispenseUnits
{
    get
    {
        if (_dispenseUnits != null)
        {
            return _dispenseUnits;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the units for the dispense amount as encoded by the pharmacy or treatment supplier. This field is required if the units are not implied by the actual dispense code. This must be in simple units that reflect the actual quantity of the substance dispensed. It does not include compound units.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.11.4",
                            Type = @"Component",
                            Position = @"RXE.11.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dispenseUnits = new HL7V231Field
        {
            field = message[@"RXE"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dispenseUnits.field.FieldRepetitions != null && _dispenseUnits.field.FieldRepetitions.Count > 0)
        {
            _dispenseUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dispenseUnits, fieldData);
        }

        return _dispenseUnits;
    } 
}

internal HL7V231Field _numberOfRefills;

public HL7V231Field NumberOfRefills
{
    get
    {
        if (_numberOfRefills != null)
        {
            return _numberOfRefills;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the total original number of refills. Outpatient only.",
            Sample = @"",
            Fields = null
        }

        _numberOfRefills = new HL7V231Field
        {
            field = message[@"RXE"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfRefills.field.FieldRepetitions != null && _numberOfRefills.field.FieldRepetitions.Count > 0)
        {
            _numberOfRefills.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_numberOfRefills, fieldData);
        }

        return _numberOfRefills;
    } 
}

internal HL7V231Field _orderingProvidersDEANumber;

public HL7V231Field OrderingProvidersDEANumber
{
    get
    {
        if (_orderingProvidersDEANumber != null)
        {
            return _orderingProvidersDEANumber;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.13",
            Type = @"Field",
            Position = @"RXE.13",
            Name = @"Ordering Provider s DEA Number",
            Length = 60,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field is defined as conditional because it is required when the substance requested is a controlled substance (e.g., a narcotic).",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This string refers to the coded ID according to a user-defined table, defined by the 9th component. If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.2",
                            Type = @"Component",
                            Position = @"RXE.13.2",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.13.2.1",
                            Type = @"SubComponent",
                            Position = @"RXE.13.2.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.2.2",
                            Type = @"SubComponent",
                            Position = @"RXE.13.2.2",
                            Name = @"Last Name Prefix",
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
                            Id = @"RXE.13.3",
                            Type = @"Component",
                            Position = @"RXE.13.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
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
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.6",
                            Type = @"Component",
                            Position = @"RXE.13.6",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.7",
                            Type = @"Component",
                            Position = @"RXE.13.7",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.8",
                            Type = @"Component",
                            Position = @"RXE.13.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.9",
                            Type = @"Component",
                            Position = @"RXE.13.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.13.9.1",
                            Type = @"SubComponent",
                            Position = @"RXE.13.9.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.9.2",
                            Type = @"SubComponent",
                            Position = @"RXE.13.9.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.9.3",
                            Type = @"SubComponent",
                            Position = @"RXE.13.9.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.10",
                            Type = @"Component",
                            Position = @"RXE.13.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.51, XPN - extended person name).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.11",
                            Type = @"Component",
                            Position = @"RXE.13.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.12",
                            Type = @"Component",
                            Position = @"RXE.13.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.13",
                            Type = @"Component",
                            Position = @"RXE.13.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.14",
                            Type = @"Component",
                            Position = @"RXE.13.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.13.14.1",
                            Type = @"SubComponent",
                            Position = @"RXE.13.14.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.14.2",
                            Type = @"SubComponent",
                            Position = @"RXE.13.14.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.14.3",
                            Type = @"SubComponent",
                            Position = @"RXE.13.14.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.13.15",
                            Type = @"Component",
                            Position = @"RXE.13.15",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _orderingProvidersDEANumber = new HL7V231Field
        {
            field = message[@"RXE"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderingProvidersDEANumber.field.FieldRepetitions != null && _orderingProvidersDEANumber.field.FieldRepetitions.Count > 0)
        {
            _orderingProvidersDEANumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_orderingProvidersDEANumber, fieldData);
        }

        return _orderingProvidersDEANumber;
    } 
}

internal HL7V231Field _pharmacistTreatmentSuppliersVerifierID;

public HL7V231Field PharmacistTreatmentSuppliersVerifierID
{
    get
    {
        if (_pharmacistTreatmentSuppliersVerifierID != null)
        {
            return _pharmacistTreatmentSuppliersVerifierID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.14",
            Type = @"Field",
            Position = @"RXE.14",
            Name = @"Pharmacist/Treatment Supplier s Verifier ID",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field contains the provider ID of Pharmacist/treatment supplier's verifier. Use if required by the pharmacy or treatment application or site on orders (or some subgroup of orders).",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This string refers to the coded ID according to a user-defined table, defined by the 9th component. If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.2",
                            Type = @"Component",
                            Position = @"RXE.14.2",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.14.2.1",
                            Type = @"SubComponent",
                            Position = @"RXE.14.2.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.2.2",
                            Type = @"SubComponent",
                            Position = @"RXE.14.2.2",
                            Name = @"Last Name Prefix",
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
                            Id = @"RXE.14.3",
                            Type = @"Component",
                            Position = @"RXE.14.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
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
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.6",
                            Type = @"Component",
                            Position = @"RXE.14.6",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.7",
                            Type = @"Component",
                            Position = @"RXE.14.7",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.8",
                            Type = @"Component",
                            Position = @"RXE.14.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.9",
                            Type = @"Component",
                            Position = @"RXE.14.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.14.9.1",
                            Type = @"SubComponent",
                            Position = @"RXE.14.9.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.9.2",
                            Type = @"SubComponent",
                            Position = @"RXE.14.9.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.9.3",
                            Type = @"SubComponent",
                            Position = @"RXE.14.9.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.10",
                            Type = @"Component",
                            Position = @"RXE.14.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.51, XPN - extended person name).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.11",
                            Type = @"Component",
                            Position = @"RXE.14.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.12",
                            Type = @"Component",
                            Position = @"RXE.14.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.13",
                            Type = @"Component",
                            Position = @"RXE.14.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.14",
                            Type = @"Component",
                            Position = @"RXE.14.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXE.14.14.1",
                            Type = @"SubComponent",
                            Position = @"RXE.14.14.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.14.2",
                            Type = @"SubComponent",
                            Position = @"RXE.14.14.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.14.3",
                            Type = @"SubComponent",
                            Position = @"RXE.14.14.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.14.15",
                            Type = @"Component",
                            Position = @"RXE.14.15",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _pharmacistTreatmentSuppliersVerifierID = new HL7V231Field
        {
            field = message[@"RXE"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pharmacistTreatmentSuppliersVerifierID.field.FieldRepetitions != null && _pharmacistTreatmentSuppliersVerifierID.field.FieldRepetitions.Count > 0)
        {
            _pharmacistTreatmentSuppliersVerifierID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_pharmacistTreatmentSuppliersVerifierID, fieldData);
        }

        return _pharmacistTreatmentSuppliersVerifierID;
    } 
}

internal HL7V231Field _prescriptionNumber;

public HL7V231Field PrescriptionNumber
{
    get
    {
        if (_prescriptionNumber != null)
        {
            return _prescriptionNumber;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.15",
            Type = @"Field",
            Position = @"RXE.15",
            Name = @"Prescription Number",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the prescription number as assigned by the pharmacy or treatment application. Equivalent in uniqueness to the pharmacy/treatment filler order number. At some sites, this may be the pharmacy or treatment system (internal) sequential form. At other sites, this may be an external form. This is a required field in RXE when used in pharmacy/treatment messages, but it is not required when used in product experience messages (see Chapter 7).",
            Sample = @"",
            Fields = null
        }

        _prescriptionNumber = new HL7V231Field
        {
            field = message[@"RXE"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_prescriptionNumber.field.FieldRepetitions != null && _prescriptionNumber.field.FieldRepetitions.Count > 0)
        {
            _prescriptionNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_prescriptionNumber, fieldData);
        }

        return _prescriptionNumber;
    } 
}

internal HL7V231Field _numberofRefillsRemaining;

public HL7V231Field NumberofRefillsRemaining
{
    get
    {
        if (_numberofRefillsRemaining != null)
        {
            return _numberofRefillsRemaining;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.16",
            Type = @"Field",
            Position = @"RXE.16",
            Name = @"Number of Refills Remaining",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Number of refills remaining. This field is conditional because it is required when a prescription is dispensed to an outpatient. It is not relevant to inpatient treatment orders.",
            Sample = @"",
            Fields = null
        }

        _numberofRefillsRemaining = new HL7V231Field
        {
            field = message[@"RXE"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberofRefillsRemaining.field.FieldRepetitions != null && _numberofRefillsRemaining.field.FieldRepetitions.Count > 0)
        {
            _numberofRefillsRemaining.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_numberofRefillsRemaining, fieldData);
        }

        return _numberofRefillsRemaining;
    } 
}

internal HL7V231Field _numberofRefillsDosesDispensed;

public HL7V231Field NumberofRefillsDosesDispensed
{
    get
    {
        if (_numberofRefillsDosesDispensed != null)
        {
            return _numberofRefillsDosesDispensed;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.17",
            Type = @"Field",
            Position = @"RXE.17",
            Name = @"Number of Refills/Doses Dispensed",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Number of refills dispensed. This field is conditional because it is required when a prescription is dispensed to an outpatient. It is not relevant to inpatient treatment orders.",
            Sample = @"",
            Fields = null
        }

        _numberofRefillsDosesDispensed = new HL7V231Field
        {
            field = message[@"RXE"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberofRefillsDosesDispensed.field.FieldRepetitions != null && _numberofRefillsDosesDispensed.field.FieldRepetitions.Count > 0)
        {
            _numberofRefillsDosesDispensed.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_numberofRefillsDosesDispensed, fieldData);
        }

        return _numberofRefillsDosesDispensed;
    } 
}

internal HL7V231Field _dTofMostRecentRefillorDoseDispensed;

public HL7V231Field DTofMostRecentRefillorDoseDispensed
{
    get
    {
        if (_dTofMostRecentRefillorDoseDispensed != null)
        {
            return _dTofMostRecentRefillorDoseDispensed;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.18",
            Type = @"Field",
            Position = @"RXE.18",
            Name = @"D/T of Most Recent Refill or Dose Dispensed",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"Date/time of the most recent refill or dose dispensed.",
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
                        }
        }

        _dTofMostRecentRefillorDoseDispensed = new HL7V231Field
        {
            field = message[@"RXE"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dTofMostRecentRefillorDoseDispensed.field.FieldRepetitions != null && _dTofMostRecentRefillorDoseDispensed.field.FieldRepetitions.Count > 0)
        {
            _dTofMostRecentRefillorDoseDispensed.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dTofMostRecentRefillorDoseDispensed, fieldData);
        }

        return _dTofMostRecentRefillorDoseDispensed;
    } 
}

internal HL7V231Field _totalDailyDose;

public HL7V231Field TotalDailyDose
{
    get
    {
        if (_totalDailyDose != null)
        {
            return _totalDailyDose;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.19",
            Type = @"Field",
            Position = @"RXE.19",
            Name = @"Total Daily Dose",
            Length = 10,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the total daily dose for this particular pharmaceutical as expressed in terms of actual dispense units.",
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
                            Description = @"The units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the observation is measured in the default units, the units need not be transmitted. If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component. If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7. If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7. But in these cases the component separator should be replaced by the subcomponent delimiter",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _totalDailyDose = new HL7V231Field
        {
            field = message[@"RXE"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_totalDailyDose.field.FieldRepetitions != null && _totalDailyDose.field.FieldRepetitions.Count > 0)
        {
            _totalDailyDose.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_totalDailyDose, fieldData);
        }

        return _totalDailyDose;
    } 
}

internal HL7V231Field _needsHumanReview;

public HL7V231Field NeedsHumanReview
{
    get
    {
        if (_needsHumanReview != null)
        {
            return _needsHumanReview;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.20",
            Type = @"Field",
            Position = @"RXE.20",
            Name = @"Needs Human Review",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field uses HL7 table 0136 - Yes/no indicator . The values have the following meaning for this field:",
            Sample = @"",
            Fields = null
        }

        _needsHumanReview = new HL7V231Field
        {
            field = message[@"RXE"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_needsHumanReview.field.FieldRepetitions != null && _needsHumanReview.field.FieldRepetitions.Count > 0)
        {
            _needsHumanReview.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_needsHumanReview, fieldData);
        }

        return _needsHumanReview;
    } 
}

internal HL7V231Field _pharmacyTreatmentSuppliersSpecialDispensingInstructions;

public HL7V231Field PharmacyTreatmentSuppliersSpecialDispensingInstructions
{
    get
    {
        if (_pharmacyTreatmentSuppliersSpecialDispensingInstructions != null)
        {
            return _pharmacyTreatmentSuppliersSpecialDispensingInstructions;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.21",
            Type = @"Field",
            Position = @"RXE.21",
            Name = @"Pharmacy/Treatment Supplier s Special Dispensing Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the pharmacy or treatment supplier's provider-generated special instructions to the provider dispensing/administering the order.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.21.4",
                            Type = @"Component",
                            Position = @"RXE.21.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _pharmacyTreatmentSuppliersSpecialDispensingInstructions = new HL7V231Field
        {
            field = message[@"RXE"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pharmacyTreatmentSuppliersSpecialDispensingInstructions.field.FieldRepetitions != null && _pharmacyTreatmentSuppliersSpecialDispensingInstructions.field.FieldRepetitions.Count > 0)
        {
            _pharmacyTreatmentSuppliersSpecialDispensingInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_pharmacyTreatmentSuppliersSpecialDispensingInstructions, fieldData);
        }

        return _pharmacyTreatmentSuppliersSpecialDispensingInstructions;
    } 
}

internal HL7V231Field _givePer;

public HL7V231Field GivePer
{
    get
    {
        if (_givePer != null)
        {
            return _givePer;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.22",
            Type = @"Field",
            Position = @"RXE.22",
            Name = @"Give Per",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time unit to use to calculate the rate at which the pharmaceutical is to be administered.",
            Sample = @"",
            Fields = null
        }

        _givePer = new HL7V231Field
        {
            field = message[@"RXE"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_givePer.field.FieldRepetitions != null && _givePer.field.FieldRepetitions.Count > 0)
        {
            _givePer.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_givePer, fieldData);
        }

        return _givePer;
    } 
}

internal HL7V231Field _giveRateAmount;

public HL7V231Field GiveRateAmount
{
    get
    {
        if (_giveRateAmount != null)
        {
            return _giveRateAmount;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.23",
            Type = @"Field",
            Position = @"RXE.23",
            Name = @"Give Rate Amount",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the rate at which the substance should be administered.",
            Sample = @"",
            Fields = null
        }

        _giveRateAmount = new HL7V231Field
        {
            field = message[@"RXE"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveRateAmount.field.FieldRepetitions != null && _giveRateAmount.field.FieldRepetitions.Count > 0)
        {
            _giveRateAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_giveRateAmount, fieldData);
        }

        return _giveRateAmount;
    } 
}

internal HL7V231Field _giveRateUnits;

public HL7V231Field GiveRateUnits
{
    get
    {
        if (_giveRateUnits != null)
        {
            return _giveRateUnits;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the units for RXE-23-give rate amount . May be composite. The ratio of the RXE-23-give rate amount and RXE-24-give rate units defines the actual rate of administration. Thus, if RXE-23-give rate amount = 100 and RXE-24-give rate units = ml/hr, the requested rate of administration is 100 ml/hr. (See ISO+ Figure 7-13 in Chapter 7 for possible compound units codes.)",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.24.4",
                            Type = @"Component",
                            Position = @"RXE.24.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _giveRateUnits = new HL7V231Field
        {
            field = message[@"RXE"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveRateUnits.field.FieldRepetitions != null && _giveRateUnits.field.FieldRepetitions.Count > 0)
        {
            _giveRateUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_giveRateUnits, fieldData);
        }

        return _giveRateUnits;
    } 
}

internal HL7V231Field _giveStrength;

public HL7V231Field GiveStrength
{
    get
    {
        if (_giveStrength != null)
        {
            return _giveStrength;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.25",
            Type = @"Field",
            Position = @"RXE.25",
            Name = @"Give Strength",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Use when RXE-2-give code does not specify the strength. This is the numeric part of the strength, used in combination with RXE-26-give strength units.",
            Sample = @"",
            Fields = null
        }

        _giveStrength = new HL7V231Field
        {
            field = message[@"RXE"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveStrength.field.FieldRepetitions != null && _giveStrength.field.FieldRepetitions.Count > 0)
        {
            _giveStrength.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_giveStrength, fieldData);
        }

        return _giveStrength;
    } 
}

internal HL7V231Field _giveStrengthUnits;

public HL7V231Field GiveStrengthUnits
{
    get
    {
        if (_giveStrengthUnits != null)
        {
            return _giveStrengthUnits;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.26",
            Type = @"Field",
            Position = @"RXE.26",
            Name = @"Give Strength Units",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"Use when RXE-2-give code does not specify the strength. This is the unit of the strength, used in combination with RXE-25-give strength.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.26.1",
                            Type = @"Component",
                            Position = @"RXE.26.1",
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
                            Id = @"RXE.26.2",
                            Type = @"Component",
                            Position = @"RXE.26.2",
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
                            Id = @"RXE.26.3",
                            Type = @"Component",
                            Position = @"RXE.26.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.26.4",
                            Type = @"Component",
                            Position = @"RXE.26.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.26.5",
                            Type = @"Component",
                            Position = @"RXE.26.5",
                            Name = @"Alternate Text",
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
                            Id = @"RXE.26.6",
                            Type = @"Component",
                            Position = @"RXE.26.6",
                            Name = @"Name Of Alternate Coding System",
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

        _giveStrengthUnits = new HL7V231Field
        {
            field = message[@"RXE"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveStrengthUnits.field.FieldRepetitions != null && _giveStrengthUnits.field.FieldRepetitions.Count > 0)
        {
            _giveStrengthUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_giveStrengthUnits, fieldData);
        }

        return _giveStrengthUnits;
    } 
}

internal HL7V231Field _giveIndication;

public HL7V231Field GiveIndication
{
    get
    {
        if (_giveIndication != null)
        {
            return _giveIndication;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.27",
            Type = @"Field",
            Position = @"RXE.27",
            Name = @"Give Indication",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the condition or problem for which the drug/treatment was prescribed. May repeat if multiple indications are relevant.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.27.1",
                            Type = @"Component",
                            Position = @"RXE.27.1",
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
                            Id = @"RXE.27.2",
                            Type = @"Component",
                            Position = @"RXE.27.2",
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
                            Id = @"RXE.27.3",
                            Type = @"Component",
                            Position = @"RXE.27.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.27.4",
                            Type = @"Component",
                            Position = @"RXE.27.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.27.5",
                            Type = @"Component",
                            Position = @"RXE.27.5",
                            Name = @"Alternate Text",
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
                            Id = @"RXE.27.6",
                            Type = @"Component",
                            Position = @"RXE.27.6",
                            Name = @"Name Of Alternate Coding System",
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

        _giveIndication = new HL7V231Field
        {
            field = message[@"RXE"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveIndication.field.FieldRepetitions != null && _giveIndication.field.FieldRepetitions.Count > 0)
        {
            _giveIndication.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_giveIndication, fieldData);
        }

        return _giveIndication;
    } 
}

internal HL7V231Field _dispensePackageSize;

public HL7V231Field DispensePackageSize
{
    get
    {
        if (_dispensePackageSize != null)
        {
            return _dispensePackageSize;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.28",
            Type = @"Field",
            Position = @"RXE.28",
            Name = @"Dispense Package Size",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the size of package to be dispensed. Units are transmitted in RXE-29-dispense package size unit.",
            Sample = @"",
            Fields = null
        }

        _dispensePackageSize = new HL7V231Field
        {
            field = message[@"RXE"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dispensePackageSize.field.FieldRepetitions != null && _dispensePackageSize.field.FieldRepetitions.Count > 0)
        {
            _dispensePackageSize.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dispensePackageSize, fieldData);
        }

        return _dispensePackageSize;
    } 
}

internal HL7V231Field _dispensePackageSizeUnit;

public HL7V231Field DispensePackageSizeUnit
{
    get
    {
        if (_dispensePackageSizeUnit != null)
        {
            return _dispensePackageSizeUnit;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.29",
            Type = @"Field",
            Position = @"RXE.29",
            Name = @"Dispense Package Size Unit",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the units in which RXE-28-dispense package size is denominated.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXE.29.1",
                            Type = @"Component",
                            Position = @"RXE.29.1",
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
                            Id = @"RXE.29.2",
                            Type = @"Component",
                            Position = @"RXE.29.2",
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
                            Id = @"RXE.29.3",
                            Type = @"Component",
                            Position = @"RXE.29.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.29.4",
                            Type = @"Component",
                            Position = @"RXE.29.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXE.29.5",
                            Type = @"Component",
                            Position = @"RXE.29.5",
                            Name = @"Alternate Text",
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
                            Id = @"RXE.29.6",
                            Type = @"Component",
                            Position = @"RXE.29.6",
                            Name = @"Name Of Alternate Coding System",
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

        _dispensePackageSizeUnit = new HL7V231Field
        {
            field = message[@"RXE"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dispensePackageSizeUnit.field.FieldRepetitions != null && _dispensePackageSizeUnit.field.FieldRepetitions.Count > 0)
        {
            _dispensePackageSizeUnit.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dispensePackageSizeUnit, fieldData);
        }

        return _dispensePackageSizeUnit;
    } 
}

internal HL7V231Field _dispensePackageMethod;

public HL7V231Field DispensePackageMethod
{
    get
    {
        if (_dispensePackageMethod != null)
        {
            return _dispensePackageMethod;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RXE.30",
            Type = @"Field",
            Position = @"RXE.30",
            Name = @"Dispense Package Method",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0321",
            TableName = @"Dispense method",
            Description = @"This field contains the method by which treatment is dispensed. Refer to HL7 table 0321 - Dispense method for valid values.",
            Sample = @"",
            Fields = null
        }

        _dispensePackageMethod = new HL7V231Field
        {
            field = message[@"RXE"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dispensePackageMethod.field.FieldRepetitions != null && _dispensePackageMethod.field.FieldRepetitions.Count > 0)
        {
            _dispensePackageMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dispensePackageMethod, fieldData);
        }

        return _dispensePackageMethod;
    } 
}
    }
}
