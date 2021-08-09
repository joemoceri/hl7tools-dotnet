using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentURS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"URS"; } }

        public string SegmentId { get { return @"URS"; } }
        
        public string LongName { get { return @"Unsolicited selection segment"; } }
        
        public string Description { get { return @"The URS segment is identical with the QRF segment, except that if the name of any field contains Query (of QRY), this word has been changed to Results (see URS-5-R/U other results subject definition)."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

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
                            Id = @"URS.1",
                            Type = @"Field",
                            Position = @"URS.1",
                            Name = @"R/U Where Subject Definition",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the department, system, or subsystem to which the result pertains.  This field may repeat as in LAB~HEMO, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.2",
                            Type = @"Field",
                            Position = @"URS.2",
                            Name = @"R/U When Data Start Date/Time",
                            Length = 26,
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
                            Id = @"URS.2.1",
                            Type = @"Component",
                            Position = @"URS.2.1",
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
                            Id = @"URS.3",
                            Type = @"Field",
                            Position = @"URS.3",
                            Name = @"R/U When Data End Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time the result ends (if applicable)",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"URS.3.1",
                            Type = @"Component",
                            Position = @"URS.3.1",
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
                            Id = @"URS.4",
                            Type = @"Field",
                            Position = @"URS.4",
                            Name = @"R/U What User Qualifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an identifier to define further the characteristics of the data that are of interest. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.5",
                            Type = @"Field",
                            Position = @"URS.5",
                            Name = @"R/U Other Results Subject Definition",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a further qualifier, defined locally, for use between two systems.  This filter uses codes and field definitions that have specific meaning only to the application and/or site involved",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.6",
                            Type = @"Field",
                            Position = @"URS.6",
                            Name = @"R/U Which Date/Time Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0156",
                            TableName = @"Which date/time qualifier",
                            Description = @"This field specifies the type of date referred to in URS-2-when data start date/time and URS-3when data end date/time.  Refer to HL7 table 0156 - Which date/time qualifier for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.7",
                            Type = @"Field",
                            Position = @"URS.7",
                            Name = @"R/U Which Date/Time Status Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0157",
                            TableName = @"Which date/time status qualifier",
                            Description = @"This field specifies the status type of objects selected in date range defined by URS-2-when data start date/time and URS-3-when data end date/time.  Refer to HL7 table 0157 - Date/time status qualifier for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.8",
                            Type = @"Field",
                            Position = @"URS.8",
                            Name = @"R/U Date/Time Selection Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0158",
                            TableName = @"Date/time selection qualifier",
                            Description = @"This field allows the specification of certain types of values within the date/time range.  Refer to HL7 table 0158 - Date/time selection qualifier for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.9",
                            Type = @"Field",
                            Position = @"URS.9",
                            Name = @"R/U Quantity/Timing Qualifier",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TQ",
                            DataTypeName = @"Timing Quantity",
                            TableId = null,
                            TableName = null,
                            Description = @"This field allows an interval definition to be used for specifying multiple responses to a query. With the addition of this filter, new query specifications should no longer use URS-2-R/U when data start date/time and URS-3-R/U when data end date/time in future implementations ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"URS.9.1",
                            Type = @"Component",
                            Position = @"URS.9.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the quantity of the service that should be provided at each service interval.  For example., if two blood cultures are to be obtained every 4 hours, the quantity would be 2.  If three units of blood are to be typed and cross-matched, the quantity would be 3.  The default value is 1.  When units are required, they can be added, specified by a subcomponent delimiter. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"URS.9.1.1",
                            Type = @"SubComponent",
                            Position = @"URS.9.1.1",
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
                            Id = @"URS.9.1.2",
                            Type = @"SubComponent",
                            Position = @"URS.9.1.2",
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
                            Id = @"URS.9.2",
                            Type = @"Component",
                            Position = @"URS.9.2",
                            Name = @"Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"RI",
                            DataTypeName = @"Repeat Interval",
                            TableId = null,
                            TableName = null,
                            Description = @"This field determines the interval between repeated services.

The default is one time only, the first subcomponent is the repeat pattern, and the second subcomponent is the explicit time at which pattern is to be executed",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"URS.9.2.1",
                            Type = @"SubComponent",
                            Position = @"URS.9.2.1",
                            Name = @"Repeat Pattern",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The first component is defined by user-defined table 0335 - Repeat pattern. See Section  4.4.2.1 “Repeat pattern,”  for further details",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.9.2.2",
                            Type = @"SubComponent",
                            Position = @"URS.9.2.2",
                            Name = @"Explicit Time Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component explicitly lists the actual times referenced by the code in the first subcomponent, in the following format: HHMM,HHMM,HHMM,.…  This second subcomponent will be used to clarify the first subcomponent in cases where the actual administration times vary within an institution. See Section 4.4.2.2, “Explicit time interval subcomponent,” for further details.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.9.3",
                            Type = @"Component",
                            Position = @"URS.9.3",
                            Name = @"Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates how long the service should continue after it is started.  The default is INDEF (do indefinitely)

S<integer> = <integer> seconds 
M<integer> = <integer> minutes 
H<integer> = <integer> hours 
D<integer> = <integer> days 
W<integer> = <integer> weeks 
L<integer> = <integer> months 
X<integer> = <integer> times at interval specified in the order.  A request for 2 blood cultures Q2H X3 would imply obtaining 2 blood cultures 3 different times at 2-hour intervals for a total of 6 blood cultures. 
T<integer> = at the interval and amount stated until a total of <integer> “DOSAGE” is accumulated.  Units would be assumed to be the same as in the QUANTITY field. INDEF = do indefinitely - also the default ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.9.4",
                            Type = @"Component",
                            Position = @"URS.9.4",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be specified by the orderer, in which case it indicates the earliest date/time at which the services should be started.  In many cases, however, the start date/time will be implied or will be defined by other fields in the order record (e.g., urgency - STAT).  In such a case, this field will be empty.  

The filling service will often record a value in this field after receipt of the order, however, and compute an end time on the basis of the start date/time for the filling service’s internal use. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"URS.9.4.1",
                            Type = @"SubComponent",
                            Position = @"URS.9.4.1",
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
                            Id = @"URS.9.5",
                            Type = @"Component",
                            Position = @"URS.9.5",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"When filled in by the requester of the service, this field should be the latest date/time that the service should be performed.  If it has not been performed by the specified time, it should not be performed at all.  The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.  

Regardless of the value of the end date/time, the service should be stopped at the earliest of the date/times specified by either the duration or the end date/time.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"URS.9.5.1",
                            Type = @"SubComponent",
                            Position = @"URS.9.5.1",
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
                            Id = @"URS.9.6",
                            Type = @"Component",
                            Position = @"URS.9.6",
                            Name = @"Priority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field describes the urgency of the request.  The following values are suggested (the default for Priority is R):

S = Stat With highest priority 
A = ASAP Fill after S orders 
R = Routine Default 
P = Preop  
C = Callback  
T = Timing critical A request implying that it is critical to come as close as possible to the requested time, e.g., for a trough antimicrobial level. 
PRN = As needed

If using the value “T” (timing critical), the degree of criticality can be specified thus:
 
Format: 
TS<integer> = timing critical within <integer> seconds 
TM<integer> = timing critical within <integer> minutes 
TH<integer> = timing critical within <integer> hours 
TD<integer> = timing critical within <integer> days 
TW<integer> = timing critical within <integer> weeks 
TL<integer> = timing critical within <integer> months 

For the sequential orders specification, these values specify the time criticality with which the predecessor order must be followed by the given order. 
The priority component may repeat; separate repeating values with the repeat delimiter separated by a space",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.9.7",
                            Type = @"Component",
                            Position = @"URS.9.7",
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
                            Id = @"URS.9.8",
                            Type = @"Component",
                            Position = @"URS.9.8",
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
                            Id = @"URS.9.9",
                            Type = @"Component",
                            Position = @"URS.9.9",
                            Name = @"Conjunction",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This non-null component indicates that a second timing specification is to follow using the repeat delimiter.  This field can take three values:  

S =  Synchronous  
Do the next specification after this one (unless otherwise constrained by the following components: ORC4^4-start date/time and ORC-4^5-end date/time).  
An “S” specification implies that the second timing sequence follows the first, e.g., when an order is written to measure blood pressure Q15 minutes for the 1st hour, then every 2 hours for the next day.  

A =  Asynchronous  
Do the next specification in parallel with this one (unless otherwise constrained by the following components: ORC-4^4-start date/time and ORC-4^5-end date/time).  The conjunction of “A” specifies two parallel instructions, as are sometimes used in medication, e.g., prednisone given at 1 tab on Monday, Wednesday, Friday, and at 1/2 tab on Tuesday, Thursday, Saturday, Sunday.  

C =  This is an actuation time 
It will be followed by a completion time for the service.  This code allows one to distinguish between the time and priority at which a service should be actuated (e.g., blood should be drawn) and the time and priority at which a service should be completed (e.g., results should be reported)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"URS.9.10",
                            Type = @"Component",
                            Position = @"URS.9.10",
                            Name = @"Order Sequencing",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_OSD",
                            DataTypeName = @"Order Sequence",
                            TableId = null,
                            TableName = null,
                            Description = @"There are many situations, such as the creation of an order for a group of intravenous (IV) solutions, where the sequence of the individual intravenous solutions (each a service in itself) needs to be specified, e.g., hyperalimentation with multi-vitamins in every third bottle. 

There are other situations where part of the order’s instructions contains a results condition of some type, such as “PRN pain.”  There is currently a free text “condition” component of ORC-4-quantity/timing which allows any condition to be specified.  However, to support a fully encoded version of order sequencing, or results condition, we have defined in the following paragraphs a 10th component of ORC-4-quantity/timing.  

The sequencing conditions supported by this 10th component are based on the completion of a  predecessor service",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"URS.9.10.1",
                            Type = @"SubComponent",
                            Position = @"URS.9.10.1",
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
                            Id = @"URS.9.10.2",
                            Type = @"SubComponent",
                            Position = @"URS.9.10.2",
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
                            Id = @"URS.9.10.3",
                            Type = @"SubComponent",
                            Position = @"URS.9.10.3",
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
                            Id = @"URS.9.10.4",
                            Type = @"SubComponent",
                            Position = @"URS.9.10.4",
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
                            Id = @"URS.9.10.5",
                            Type = @"SubComponent",
                            Position = @"URS.9.10.5",
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
                            Id = @"URS.9.10.6",
                            Type = @"SubComponent",
                            Position = @"URS.9.10.6",
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
                            Id = @"URS.9.10.7",
                            Type = @"SubComponent",
                            Position = @"URS.9.10.7",
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
                            Id = @"URS.9.10.8",
                            Type = @"SubComponent",
                            Position = @"URS.9.10.8",
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
                            Id = @"URS.9.10.9",
                            Type = @"SubComponent",
                            Position = @"URS.9.10.9",
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
                            Id = @"URS.9.10.10",
                            Type = @"SubComponent",
                            Position = @"URS.9.10.10",
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
                            Id = @"URS.9.10.11",
                            Type = @"SubComponent",
                            Position = @"URS.9.10.11",
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
                        },}
                        },
                        };
            }
        }

        public HL7V23SegmentURS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field rUWhereSubjectDefinition;

public HL7V23Field RUWhereSubjectDefinition
{
    get
    {
        if (rUWhereSubjectDefinition != null)
        {
            return rUWhereSubjectDefinition;
        }

        rUWhereSubjectDefinition = new HL7V23Field
        {
            field = message[@"URS"][1],
            Id = @"URS.1",
            Type = @"Field",
            Position = @"URS.1",
            Name = @"R/U Where Subject Definition",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the department, system, or subsystem to which the result pertains.  This field may repeat as in LAB~HEMO, etc",
            Sample = @"",
        };

        // check for repetitions
        if (rUWhereSubjectDefinition.field.FieldRepetitions != null && rUWhereSubjectDefinition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhereSubjectDefinition.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < rUWhereSubjectDefinition.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = rUWhereSubjectDefinition.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < rUWhereSubjectDefinition.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = rUWhereSubjectDefinition.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < rUWhereSubjectDefinition.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = rUWhereSubjectDefinition.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
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
                     
            rUWhereSubjectDefinition.fieldRepetitions = fieldRepetitions;
        }

        return rUWhereSubjectDefinition;
    } 
}

internal HL7V23Field rUWhenDataStartDateTime;

public HL7V23Field RUWhenDataStartDateTime
{
    get
    {
        if (rUWhenDataStartDateTime != null)
        {
            return rUWhenDataStartDateTime;
        }

        rUWhenDataStartDateTime = new HL7V23Field
        {
            field = message[@"URS"][2],
            Id = @"URS.2",
            Type = @"Field",
            Position = @"URS.2",
            Name = @"R/U When Data Start Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (rUWhenDataStartDateTime.field.FieldRepetitions != null && rUWhenDataStartDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhenDataStartDateTime.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < rUWhenDataStartDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = rUWhenDataStartDateTime.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < rUWhenDataStartDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = rUWhenDataStartDateTime.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < rUWhenDataStartDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = rUWhenDataStartDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
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
                     
            rUWhenDataStartDateTime.fieldRepetitions = fieldRepetitions;
        }

        return rUWhenDataStartDateTime;
    } 
}

internal HL7V23Field rUWhenDataEndDateTime;

public HL7V23Field RUWhenDataEndDateTime
{
    get
    {
        if (rUWhenDataEndDateTime != null)
        {
            return rUWhenDataEndDateTime;
        }

        rUWhenDataEndDateTime = new HL7V23Field
        {
            field = message[@"URS"][3],
            Id = @"URS.3",
            Type = @"Field",
            Position = @"URS.3",
            Name = @"R/U When Data End Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time the result ends (if applicable)",
            Sample = @"",
        };

        // check for repetitions
        if (rUWhenDataEndDateTime.field.FieldRepetitions != null && rUWhenDataEndDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhenDataEndDateTime.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < rUWhenDataEndDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = rUWhenDataEndDateTime.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < rUWhenDataEndDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = rUWhenDataEndDateTime.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < rUWhenDataEndDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = rUWhenDataEndDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
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
                     
            rUWhenDataEndDateTime.fieldRepetitions = fieldRepetitions;
        }

        return rUWhenDataEndDateTime;
    } 
}

internal HL7V23Field rUWhatUserQualifier;

public HL7V23Field RUWhatUserQualifier
{
    get
    {
        if (rUWhatUserQualifier != null)
        {
            return rUWhatUserQualifier;
        }

        rUWhatUserQualifier = new HL7V23Field
        {
            field = message[@"URS"][4],
            Id = @"URS.4",
            Type = @"Field",
            Position = @"URS.4",
            Name = @"R/U What User Qualifier",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifier to define further the characteristics of the data that are of interest. ",
            Sample = @"",
        };

        // check for repetitions
        if (rUWhatUserQualifier.field.FieldRepetitions != null && rUWhatUserQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhatUserQualifier.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < rUWhatUserQualifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = rUWhatUserQualifier.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < rUWhatUserQualifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = rUWhatUserQualifier.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < rUWhatUserQualifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = rUWhatUserQualifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
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
                     
            rUWhatUserQualifier.fieldRepetitions = fieldRepetitions;
        }

        return rUWhatUserQualifier;
    } 
}

internal HL7V23Field rUOtherResultsSubjectDefinition;

public HL7V23Field RUOtherResultsSubjectDefinition
{
    get
    {
        if (rUOtherResultsSubjectDefinition != null)
        {
            return rUOtherResultsSubjectDefinition;
        }

        rUOtherResultsSubjectDefinition = new HL7V23Field
        {
            field = message[@"URS"][5],
            Id = @"URS.5",
            Type = @"Field",
            Position = @"URS.5",
            Name = @"R/U Other Results Subject Definition",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a further qualifier, defined locally, for use between two systems.  This filter uses codes and field definitions that have specific meaning only to the application and/or site involved",
            Sample = @"",
        };

        // check for repetitions
        if (rUOtherResultsSubjectDefinition.field.FieldRepetitions != null && rUOtherResultsSubjectDefinition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUOtherResultsSubjectDefinition.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < rUOtherResultsSubjectDefinition.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = rUOtherResultsSubjectDefinition.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < rUOtherResultsSubjectDefinition.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = rUOtherResultsSubjectDefinition.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < rUOtherResultsSubjectDefinition.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = rUOtherResultsSubjectDefinition.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
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
                     
            rUOtherResultsSubjectDefinition.fieldRepetitions = fieldRepetitions;
        }

        return rUOtherResultsSubjectDefinition;
    } 
}

internal HL7V23Field rUWhichDateTimeQualifier;

public HL7V23Field RUWhichDateTimeQualifier
{
    get
    {
        if (rUWhichDateTimeQualifier != null)
        {
            return rUWhichDateTimeQualifier;
        }

        rUWhichDateTimeQualifier = new HL7V23Field
        {
            field = message[@"URS"][6],
            Id = @"URS.6",
            Type = @"Field",
            Position = @"URS.6",
            Name = @"R/U Which Date/Time Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0156",
            TableName = @"Which date/time qualifier",
            Description = @"This field specifies the type of date referred to in URS-2-when data start date/time and URS-3when data end date/time.  Refer to HL7 table 0156 - Which date/time qualifier for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (rUWhichDateTimeQualifier.field.FieldRepetitions != null && rUWhichDateTimeQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhichDateTimeQualifier.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < rUWhichDateTimeQualifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = rUWhichDateTimeQualifier.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < rUWhichDateTimeQualifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = rUWhichDateTimeQualifier.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < rUWhichDateTimeQualifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = rUWhichDateTimeQualifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
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
                     
            rUWhichDateTimeQualifier.fieldRepetitions = fieldRepetitions;
        }

        return rUWhichDateTimeQualifier;
    } 
}

internal HL7V23Field rUWhichDateTimeStatusQualifier;

public HL7V23Field RUWhichDateTimeStatusQualifier
{
    get
    {
        if (rUWhichDateTimeStatusQualifier != null)
        {
            return rUWhichDateTimeStatusQualifier;
        }

        rUWhichDateTimeStatusQualifier = new HL7V23Field
        {
            field = message[@"URS"][7],
            Id = @"URS.7",
            Type = @"Field",
            Position = @"URS.7",
            Name = @"R/U Which Date/Time Status Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0157",
            TableName = @"Which date/time status qualifier",
            Description = @"This field specifies the status type of objects selected in date range defined by URS-2-when data start date/time and URS-3-when data end date/time.  Refer to HL7 table 0157 - Date/time status qualifier for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (rUWhichDateTimeStatusQualifier.field.FieldRepetitions != null && rUWhichDateTimeStatusQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhichDateTimeStatusQualifier.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < rUWhichDateTimeStatusQualifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = rUWhichDateTimeStatusQualifier.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < rUWhichDateTimeStatusQualifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = rUWhichDateTimeStatusQualifier.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < rUWhichDateTimeStatusQualifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = rUWhichDateTimeStatusQualifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
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
                     
            rUWhichDateTimeStatusQualifier.fieldRepetitions = fieldRepetitions;
        }

        return rUWhichDateTimeStatusQualifier;
    } 
}

internal HL7V23Field rUDateTimeSelectionQualifier;

public HL7V23Field RUDateTimeSelectionQualifier
{
    get
    {
        if (rUDateTimeSelectionQualifier != null)
        {
            return rUDateTimeSelectionQualifier;
        }

        rUDateTimeSelectionQualifier = new HL7V23Field
        {
            field = message[@"URS"][8],
            Id = @"URS.8",
            Type = @"Field",
            Position = @"URS.8",
            Name = @"R/U Date/Time Selection Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0158",
            TableName = @"Date/time selection qualifier",
            Description = @"This field allows the specification of certain types of values within the date/time range.  Refer to HL7 table 0158 - Date/time selection qualifier for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (rUDateTimeSelectionQualifier.field.FieldRepetitions != null && rUDateTimeSelectionQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUDateTimeSelectionQualifier.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < rUDateTimeSelectionQualifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = rUDateTimeSelectionQualifier.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < rUDateTimeSelectionQualifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = rUDateTimeSelectionQualifier.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < rUDateTimeSelectionQualifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = rUDateTimeSelectionQualifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
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
                     
            rUDateTimeSelectionQualifier.fieldRepetitions = fieldRepetitions;
        }

        return rUDateTimeSelectionQualifier;
    } 
}

internal HL7V23Field rUQuantityTimingQualifier;

public HL7V23Field RUQuantityTimingQualifier
{
    get
    {
        if (rUQuantityTimingQualifier != null)
        {
            return rUQuantityTimingQualifier;
        }

        rUQuantityTimingQualifier = new HL7V23Field
        {
            field = message[@"URS"][9],
            Id = @"URS.9",
            Type = @"Field",
            Position = @"URS.9",
            Name = @"R/U Quantity/Timing Qualifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TQ",
            DataTypeName = @"Timing Quantity",
            TableId = null,
            TableName = null,
            Description = @"This field allows an interval definition to be used for specifying multiple responses to a query. With the addition of this filter, new query specifications should no longer use URS-2-R/U when data start date/time and URS-3-R/U when data end date/time in future implementations ",
            Sample = @"",
        };

        // check for repetitions
        if (rUQuantityTimingQualifier.field.FieldRepetitions != null && rUQuantityTimingQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUQuantityTimingQualifier.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < rUQuantityTimingQualifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = rUQuantityTimingQualifier.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < rUQuantityTimingQualifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = rUQuantityTimingQualifier.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < rUQuantityTimingQualifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = rUQuantityTimingQualifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
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
                     
            rUQuantityTimingQualifier.fieldRepetitions = fieldRepetitions;
        }

        return rUQuantityTimingQualifier;
    } 
}
    }
}
