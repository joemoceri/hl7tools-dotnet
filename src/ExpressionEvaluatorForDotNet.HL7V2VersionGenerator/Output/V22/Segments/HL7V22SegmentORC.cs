using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentORC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ORC"; } }

        public string SegmentId { get { return @"ORC"; } }
        
        public string LongName { get { return @"Commom Order"; } }
        
        public string Description { get { return @"The Common Order segment (ORC) is used to transmit data elements that are common to all orders (all types of services that are requested).  The ORC segment is required in both the Order (ORM) and Order Acknowledgement (ORR) messages. "; } }
        
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
                            Id = @"ORC.1",
                            Type = @"Field",
                            Position = @"ORC.1",
                            Name = @"Order Control",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0119",
                            TableName = @"ORDER CONTROL",
                            Description = @"determines the function of the order segment.  Refer to table 0119 - order control for valid entries.  Very detailed explanatory notes are given at the end of this section",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.2",
                            Type = @"Field",
                            Position = @"ORC.2",
                            Name = @"Placer Order Number",
                            Length = 75,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CM_PLACER",
                            DataTypeName = @"Order Number Of The Client / The Contracting Authority",
                            TableId = null,
                            TableName = null,
                            Description = @"placer application's order number",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.2.1",
                            Type = @"Component",
                            Position = @"ORC.2.1",
                            Name = @"Unique Placer Id",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a string of up to 15 characters that identifies an individual order (e.g., OBR).  It is assigned by the placer (ordering application).  It identifies an order uniquely among all orders from a particular ordering application.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.2.2",
                            Type = @"Component",
                            Position = @"ORC.2.2",
                            Name = @"Placer Application",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the application ID of the placing application.  The application ID is a string of up to six (6) characters that will be uniquely associated with an application.  A given institution or group of intercommunicating institutions should establish a unique list of applications that may be potential placers and fillers and assign unique application ID's.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.3",
                            Type = @"Field",
                            Position = @"ORC.3",
                            Name = @"Filler Order Number",
                            Length = 75,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CM_FILLER",
                            DataTypeName = @"Number Of Processing Power Point",
                            TableId = null,
                            TableName = null,
                            Description = @" order number associated with the filling application",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.3.1",
                            Type = @"Component",
                            Position = @"ORC.3.1",
                            Name = @"Unique Filler Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Its first component is a string of up to 15 characters that identifies an order detail segment (e.g., OBR). It is assigned by the order filler (receiving) application. This string must uniquely identify the order (as specified in the order detail segment) from other orders in a particular filling application (e.g., clinical laboratory).  This uniqueness must persist over time. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.3.2",
                            Type = @"Component",
                            Position = @"ORC.3.2",
                            Name = @"Filler Application Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the filler application ID.  The filler application ID is a string of up to six characters that uniquely defines the application from other applications on the network.  The second component of the filler order number always identifies the actual filler of an order. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.4",
                            Type = @"Field",
                            Position = @"ORC.4",
                            Name = @"Placer Group Number",
                            Length = 75,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_GROUP_ID",
                            DataTypeName = @"Order Group Number",
                            TableId = null,
                            TableName = null,
                            Description = @"allows an order placing application to group sets of orders together and subsequently identify them",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.4.1",
                            Type = @"Component",
                            Position = @"ORC.4.1",
                            Name = @"Unique Group Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a string of up to 15 characters that uniquely identifies all order groups from the given placer application.  It is assigned by the placer application and may come from the same series as the placer order number of the ORC, but this is not required. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.4.2",
                            Type = @"Component",
                            Position = @"ORC.4.2",
                            Name = @"Placer Application Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is a placer application ID identical to the second component of ORC-2-placer order number.  Order groups and how to use them are described in detail at the end of the ORC section under ""Use Notes"" and in the Examples.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.5",
                            Type = @"Field",
                            Position = @"ORC.5",
                            Name = @"Order Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0038",
                            TableName = @"ORDER STATUS",
                            Description = @"status of an order.  Refer to table 0038 - order status for valid entries.  The purpose of this field is to report the status of an order either upon request (solicited), or when the status changes (unsolicited).  It does not initiate action.  It is assumed that the order status always reflects the status as it is known to the sending application at the time that the message is sent.  Only the filler can originate the value of this field",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.6",
                            Type = @"Field",
                            Position = @"ORC.6",
                            Name = @"Response Flag",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0121",
                            TableName = @"RESPONSE FLAG",
                            Description = @"allows the placer (sending) application to determine the amount of information to be returned from the filler.  Sometimes the requested level of response may not be possible immediately, but when it is possible, the filler (receiving) application must send the information.  When the field is null, D is the default value of the field.  Refer to table 0121 - response flag for valid entries",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.7",
                            Type = @"Field",
                            Position = @"ORC.7",
                            Name = @"Quantity / Timing",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"TQ",
                            DataTypeName = @"Timing Quantity",
                            TableId = null,
                            TableName = null,
                            Description = @"determines the priority, quantity, frequency, and timing of an atomic service.  Order segments should be thought of as describing an atomic service.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.7.1",
                            Type = @"Component",
                            Position = @"ORC.7.1",
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
                            Id = @"ORC.7.1.1",
                            Type = @"SubComponent",
                            Position = @"ORC.7.1.1",
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
                            Id = @"ORC.7.1.2",
                            Type = @"SubComponent",
                            Position = @"ORC.7.1.2",
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
                            Id = @"ORC.7.2",
                            Type = @"Component",
                            Position = @"ORC.7.2",
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
                            Id = @"ORC.7.2.1",
                            Type = @"SubComponent",
                            Position = @"ORC.7.2.1",
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
                            Id = @"ORC.7.2.2",
                            Type = @"SubComponent",
                            Position = @"ORC.7.2.2",
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
                            Id = @"ORC.7.3",
                            Type = @"Component",
                            Position = @"ORC.7.3",
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
                            Id = @"ORC.7.4",
                            Type = @"Component",
                            Position = @"ORC.7.4",
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
                            Id = @"ORC.7.4.1",
                            Type = @"SubComponent",
                            Position = @"ORC.7.4.1",
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
                            Id = @"ORC.7.4.2",
                            Type = @"SubComponent",
                            Position = @"ORC.7.4.2",
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
                            Id = @"ORC.7.5",
                            Type = @"Component",
                            Position = @"ORC.7.5",
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
                            Id = @"ORC.7.5.1",
                            Type = @"SubComponent",
                            Position = @"ORC.7.5.1",
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
                            Id = @"ORC.7.5.2",
                            Type = @"SubComponent",
                            Position = @"ORC.7.5.2",
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
                            Id = @"ORC.7.6",
                            Type = @"Component",
                            Position = @"ORC.7.6",
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
                            Id = @"ORC.7.7",
                            Type = @"Component",
                            Position = @"ORC.7.7",
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
                            Id = @"ORC.7.8",
                            Type = @"Component",
                            Position = @"ORC.7.8",
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
                            Id = @"ORC.7.9",
                            Type = @"Component",
                            Position = @"ORC.7.9",
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
                            Id = @"ORC.7.10",
                            Type = @"Component",
                            Position = @"ORC.7.10",
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
                            Id = @"ORC.7.10.1",
                            Type = @"SubComponent",
                            Position = @"ORC.7.10.1",
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
                            Id = @"ORC.7.10.2",
                            Type = @"SubComponent",
                            Position = @"ORC.7.10.2",
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
                            Id = @"ORC.7.10.3",
                            Type = @"SubComponent",
                            Position = @"ORC.7.10.3",
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
                            Id = @"ORC.7.10.4",
                            Type = @"SubComponent",
                            Position = @"ORC.7.10.4",
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
                            Id = @"ORC.7.10.5",
                            Type = @"SubComponent",
                            Position = @"ORC.7.10.5",
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
                            Id = @"ORC.7.10.6",
                            Type = @"SubComponent",
                            Position = @"ORC.7.10.6",
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
                            Id = @"ORC.7.10.7",
                            Type = @"SubComponent",
                            Position = @"ORC.7.10.7",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.8",
                            Type = @"Field",
                            Position = @"ORC.8",
                            Name = @"Parent",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_EIP",
                            DataTypeName = @"Parent Order",
                            TableId = null,
                            TableName = null,
                            Description = @"relates a child to its parent when a parent-child relationship exists.  The parent-child mechanism is described under ORC-1-order control notes.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.8.1",
                            Type = @"Component",
                            Position = @"ORC.8.1",
                            Name = @"Parent's Placer Order Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the placer order number of the parent order.  It is required when the order is a child",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.8.2",
                            Type = @"Component",
                            Position = @"ORC.8.2",
                            Name = @"Parent's Filler Order Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the filler order number of the parent order.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.9",
                            Type = @"Field",
                            Position = @"ORC.9",
                            Name = @"Date / Time Of Transaction",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"Date and time the current transaction enters the ordering application.  For messages creating new orders, this is the date and time the order was entered. For other messages, this is the date and time the current transaction (e.g., cancellation) enters the sending application.  This date and time is for the current transaction and is not a ""replacement"" time for a correction to the original order.  Similarly, ORC-10-entered by, ORC-11-verified by, and ORC-13-enterer's location of this segment relate to the current transaction, not the original order",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.9.1",
                            Type = @"Component",
                            Position = @"ORC.9.1",
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
                            Id = @"ORC.9.2",
                            Type = @"Component",
                            Position = @"ORC.9.2",
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
                            Id = @"ORC.10",
                            Type = @"Field",
                            Position = @"ORC.10",
                            Name = @"Entered By",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"identity of the person who actually keyed the request into the application.  It provides an audit trail in case the request is entered incorrectly and the ancillary department needs to clarify the request.  By local agreement, either the ID number or name component may be omitted",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.10.1",
                            Type = @"Component",
                            Position = @"ORC.10.1",
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
                            Id = @"ORC.10.2",
                            Type = @"Component",
                            Position = @"ORC.10.2",
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
                            Id = @"ORC.10.3",
                            Type = @"Component",
                            Position = @"ORC.10.3",
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
                            Id = @"ORC.10.4",
                            Type = @"Component",
                            Position = @"ORC.10.4",
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
                            Id = @"ORC.10.5",
                            Type = @"Component",
                            Position = @"ORC.10.5",
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
                            Id = @"ORC.10.6",
                            Type = @"Component",
                            Position = @"ORC.10.6",
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
                            Id = @"ORC.10.7",
                            Type = @"Component",
                            Position = @"ORC.10.7",
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
                            Id = @"ORC.10.8",
                            Type = @"Component",
                            Position = @"ORC.10.8",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.11",
                            Type = @"Field",
                            Position = @"ORC.11",
                            Name = @"Verified By",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"identity of the person who verified the accuracy of the entered request.  It is used in cases where the request is entered by a technician and needs to be verified by a higher authority (e.g., a nurse).  By local agreement, either the ID number or name component may be omitted",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.11.1",
                            Type = @"Component",
                            Position = @"ORC.11.1",
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
                            Id = @"ORC.11.2",
                            Type = @"Component",
                            Position = @"ORC.11.2",
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
                            Id = @"ORC.11.3",
                            Type = @"Component",
                            Position = @"ORC.11.3",
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
                            Id = @"ORC.11.4",
                            Type = @"Component",
                            Position = @"ORC.11.4",
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
                            Id = @"ORC.11.5",
                            Type = @"Component",
                            Position = @"ORC.11.5",
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
                            Id = @"ORC.11.6",
                            Type = @"Component",
                            Position = @"ORC.11.6",
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
                            Id = @"ORC.11.7",
                            Type = @"Component",
                            Position = @"ORC.11.7",
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
                            Id = @"ORC.11.8",
                            Type = @"Component",
                            Position = @"ORC.11.8",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.12",
                            Type = @"Field",
                            Position = @"ORC.12",
                            Name = @"Ordering Provider",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"identity of the person who is responsible for creating the request (i.e., ordering physician).  ORC-12ordering provider is the same as OBR-16-ordering provider",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.12.1",
                            Type = @"Component",
                            Position = @"ORC.12.1",
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
                            Id = @"ORC.12.2",
                            Type = @"Component",
                            Position = @"ORC.12.2",
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
                            Id = @"ORC.12.3",
                            Type = @"Component",
                            Position = @"ORC.12.3",
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
                            Id = @"ORC.12.4",
                            Type = @"Component",
                            Position = @"ORC.12.4",
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
                            Id = @"ORC.12.5",
                            Type = @"Component",
                            Position = @"ORC.12.5",
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
                            Id = @"ORC.12.6",
                            Type = @"Component",
                            Position = @"ORC.12.6",
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
                            Id = @"ORC.12.7",
                            Type = @"Component",
                            Position = @"ORC.12.7",
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
                            Id = @"ORC.12.8",
                            Type = @"Component",
                            Position = @"ORC.12.8",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.13",
                            Type = @"Field",
                            Position = @"ORC.13",
                            Name = @"Enterer's Location",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"location (e.g., department, floor) of the person who entered the request.  It is a composite field that may be used on a site-specific basis to include some subcategory of department.  For example, ICU4 might be the designation for a fourth-floor ICU location",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.13.1",
                            Type = @"Component",
                            Position = @"ORC.13.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Conditional on person location type (e.g., nursing unit or department or clinic).  After floor, most general patient location designation.  Refer to user-defined table 0302 - Point of care for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.13.2",
                            Type = @"Component",
                            Position = @"ORC.13.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Patient room.  After nursing unit, most general person location designation.  Refer to user-defined table 0303 - Room for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.13.3",
                            Type = @"Component",
                            Position = @"ORC.13.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Patient bed.  After room, most general person location designation.  Refer to user-defined table 0304 - Bed for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.13.4",
                            Type = @"Component",
                            Position = @"ORC.13.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Most general person location designation. (See Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.13.4.1",
                            Type = @"SubComponent",
                            Position = @"ORC.13.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.13.4.2",
                            Type = @"SubComponent",
                            Position = @"ORC.13.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.13.4.3",
                            Type = @"SubComponent",
                            Position = @"ORC.13.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.13.5",
                            Type = @"Component",
                            Position = @"ORC.13.5",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Location (e.g., Bed) status.  Refer to user-defined table 0306 - Location status for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.13.6",
                            Type = @"Component",
                            Position = @"ORC.13.6",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Usually includes values such as nursing unit, department, clinic, SNF, physician’s office.  Refer to userdefined table 0305 - Person location type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.13.7",
                            Type = @"Component",
                            Position = @"ORC.13.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"After facility, most general person location designation.  Refer to user-defined table 0307 - Building for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.13.8",
                            Type = @"Component",
                            Position = @"ORC.13.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"After building, most general person location designation.  Refer to user-defined table 0308 - Floor for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.13.9",
                            Type = @"Component",
                            Position = @"ORC.13.9",
                            Name = @"Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A free text description of the location",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.14",
                            Type = @"Field",
                            Position = @"ORC.14",
                            Name = @"Call Back Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"telephone number to call for clarification of a request or other information regarding the order.  ORC14-call back phone number is the same as OBR-17-order call back phone number",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.15",
                            Type = @"Field",
                            Position = @"ORC.15",
                            Name = @"Order Effective Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"date/time that the changes to the request took effect or are supposed to take effect",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.15.1",
                            Type = @"Component",
                            Position = @"ORC.15.1",
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
                            Id = @"ORC.15.2",
                            Type = @"Component",
                            Position = @"ORC.15.2",
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
                            Id = @"ORC.16",
                            Type = @"Field",
                            Position = @"ORC.16",
                            Name = @"Order Control Code Reason",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0119",
                            TableName = @"ORDER CONTROL",
                            Description = @"explanation (either in coded or text form) of the reason for the order event described by the order control code (table 0119).  Whereas an NTE after the order specific segment (e.g., RXO, ORO, OBR) would provide a comment for that specific segment, the purpose of the order control code reason is only to expand on the reason for the order event",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.16.1",
                            Type = @"Component",
                            Position = @"ORC.16.1",
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
                            Id = @"ORC.16.2",
                            Type = @"Component",
                            Position = @"ORC.16.2",
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
                            Id = @"ORC.16.3",
                            Type = @"Component",
                            Position = @"ORC.16.3",
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
                            Id = @"ORC.16.4",
                            Type = @"Component",
                            Position = @"ORC.16.4",
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
                            Id = @"ORC.16.5",
                            Type = @"Component",
                            Position = @"ORC.16.5",
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
                            Id = @"ORC.16.6",
                            Type = @"Component",
                            Position = @"ORC.16.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.17",
                            Type = @"Field",
                            Position = @"ORC.17",
                            Name = @"Entering Organization",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"organization that the enterer represents at the time he/she enters/maintains the order",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.17.1",
                            Type = @"Component",
                            Position = @"ORC.17.1",
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
                            Id = @"ORC.17.2",
                            Type = @"Component",
                            Position = @"ORC.17.2",
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
                            Id = @"ORC.17.3",
                            Type = @"Component",
                            Position = @"ORC.17.3",
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
                            Id = @"ORC.17.4",
                            Type = @"Component",
                            Position = @"ORC.17.4",
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
                            Id = @"ORC.17.5",
                            Type = @"Component",
                            Position = @"ORC.17.5",
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
                            Id = @"ORC.17.6",
                            Type = @"Component",
                            Position = @"ORC.17.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.18",
                            Type = @"Field",
                            Position = @"ORC.18",
                            Name = @"Entering Device",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"identifier of the physical device (terminal, PC) used to enter the order",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.18.1",
                            Type = @"Component",
                            Position = @"ORC.18.1",
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
                            Id = @"ORC.18.2",
                            Type = @"Component",
                            Position = @"ORC.18.2",
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
                            Id = @"ORC.18.3",
                            Type = @"Component",
                            Position = @"ORC.18.3",
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
                            Id = @"ORC.18.4",
                            Type = @"Component",
                            Position = @"ORC.18.4",
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
                            Id = @"ORC.18.5",
                            Type = @"Component",
                            Position = @"ORC.18.5",
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
                            Id = @"ORC.18.6",
                            Type = @"Component",
                            Position = @"ORC.18.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORC.19",
                            Type = @"Field",
                            Position = @"ORC.19",
                            Name = @"Action By",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"Identity of the person who initiated the event represented by the corresponding order control code.  For example, if the order control code is CA (cancel order request), this field represents the person who requested the order cancellation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORC.19.1",
                            Type = @"Component",
                            Position = @"ORC.19.1",
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
                            Id = @"ORC.19.2",
                            Type = @"Component",
                            Position = @"ORC.19.2",
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
                            Id = @"ORC.19.3",
                            Type = @"Component",
                            Position = @"ORC.19.3",
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
                            Id = @"ORC.19.4",
                            Type = @"Component",
                            Position = @"ORC.19.4",
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
                            Id = @"ORC.19.5",
                            Type = @"Component",
                            Position = @"ORC.19.5",
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
                            Id = @"ORC.19.6",
                            Type = @"Component",
                            Position = @"ORC.19.6",
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
                            Id = @"ORC.19.7",
                            Type = @"Component",
                            Position = @"ORC.19.7",
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
                            Id = @"ORC.19.8",
                            Type = @"Component",
                            Position = @"ORC.19.8",
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
                        },}
                        },
                        };
            }
        }

        public HL7V22SegmentORC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field orderControl;

public HL7V22Field OrderControl
{
    get
    {
        if (orderControl != null)
        {
            return orderControl;
        }

        orderControl = new HL7V22Field
        {
            field = message[@"ORC"][1],
            Id = @"ORC.1",
            Type = @"Field",
            Position = @"ORC.1",
            Name = @"Order Control",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0119",
            TableName = @"ORDER CONTROL",
            Description = @"determines the function of the order segment.  Refer to table 0119 - order control for valid entries.  Very detailed explanatory notes are given at the end of this section",
            Sample = @"",
        };

        // check for repetitions
        if (orderControl.field.FieldRepetitions != null && orderControl.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(orderControl.Id));
            orderControl.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(orderControl, fieldData);
        }

        return orderControl;
    } 
}

internal HL7V22Field placerOrderNumber;

public HL7V22Field PlacerOrderNumber
{
    get
    {
        if (placerOrderNumber != null)
        {
            return placerOrderNumber;
        }

        placerOrderNumber = new HL7V22Field
        {
            field = message[@"ORC"][2],
            Id = @"ORC.2",
            Type = @"Field",
            Position = @"ORC.2",
            Name = @"Placer Order Number",
            Length = 75,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CM_PLACER",
            DataTypeName = @"Order Number Of The Client / The Contracting Authority",
            TableId = null,
            TableName = null,
            Description = @"placer application's order number",
            Sample = @"",
        };

        // check for repetitions
        if (placerOrderNumber.field.FieldRepetitions != null && placerOrderNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(placerOrderNumber.Id));
            placerOrderNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(placerOrderNumber, fieldData);
        }

        return placerOrderNumber;
    } 
}

internal HL7V22Field fillerOrderNumber;

public HL7V22Field FillerOrderNumber
{
    get
    {
        if (fillerOrderNumber != null)
        {
            return fillerOrderNumber;
        }

        fillerOrderNumber = new HL7V22Field
        {
            field = message[@"ORC"][3],
            Id = @"ORC.3",
            Type = @"Field",
            Position = @"ORC.3",
            Name = @"Filler Order Number",
            Length = 75,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CM_FILLER",
            DataTypeName = @"Number Of Processing Power Point",
            TableId = null,
            TableName = null,
            Description = @" order number associated with the filling application",
            Sample = @"",
        };

        // check for repetitions
        if (fillerOrderNumber.field.FieldRepetitions != null && fillerOrderNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fillerOrderNumber.Id));
            fillerOrderNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(fillerOrderNumber, fieldData);
        }

        return fillerOrderNumber;
    } 
}

internal HL7V22Field placerGroupNumber;

public HL7V22Field PlacerGroupNumber
{
    get
    {
        if (placerGroupNumber != null)
        {
            return placerGroupNumber;
        }

        placerGroupNumber = new HL7V22Field
        {
            field = message[@"ORC"][4],
            Id = @"ORC.4",
            Type = @"Field",
            Position = @"ORC.4",
            Name = @"Placer Group Number",
            Length = 75,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_GROUP_ID",
            DataTypeName = @"Order Group Number",
            TableId = null,
            TableName = null,
            Description = @"allows an order placing application to group sets of orders together and subsequently identify them",
            Sample = @"",
        };

        // check for repetitions
        if (placerGroupNumber.field.FieldRepetitions != null && placerGroupNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(placerGroupNumber.Id));
            placerGroupNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(placerGroupNumber, fieldData);
        }

        return placerGroupNumber;
    } 
}

internal HL7V22Field orderStatus;

public HL7V22Field OrderStatus
{
    get
    {
        if (orderStatus != null)
        {
            return orderStatus;
        }

        orderStatus = new HL7V22Field
        {
            field = message[@"ORC"][5],
            Id = @"ORC.5",
            Type = @"Field",
            Position = @"ORC.5",
            Name = @"Order Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0038",
            TableName = @"ORDER STATUS",
            Description = @"status of an order.  Refer to table 0038 - order status for valid entries.  The purpose of this field is to report the status of an order either upon request (solicited), or when the status changes (unsolicited).  It does not initiate action.  It is assumed that the order status always reflects the status as it is known to the sending application at the time that the message is sent.  Only the filler can originate the value of this field",
            Sample = @"",
        };

        // check for repetitions
        if (orderStatus.field.FieldRepetitions != null && orderStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(orderStatus.Id));
            orderStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(orderStatus, fieldData);
        }

        return orderStatus;
    } 
}

internal HL7V22Field responseFlag;

public HL7V22Field ResponseFlag
{
    get
    {
        if (responseFlag != null)
        {
            return responseFlag;
        }

        responseFlag = new HL7V22Field
        {
            field = message[@"ORC"][6],
            Id = @"ORC.6",
            Type = @"Field",
            Position = @"ORC.6",
            Name = @"Response Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0121",
            TableName = @"RESPONSE FLAG",
            Description = @"allows the placer (sending) application to determine the amount of information to be returned from the filler.  Sometimes the requested level of response may not be possible immediately, but when it is possible, the filler (receiving) application must send the information.  When the field is null, D is the default value of the field.  Refer to table 0121 - response flag for valid entries",
            Sample = @"",
        };

        // check for repetitions
        if (responseFlag.field.FieldRepetitions != null && responseFlag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(responseFlag.Id));
            responseFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(responseFlag, fieldData);
        }

        return responseFlag;
    } 
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
            field = message[@"ORC"][7],
            Id = @"ORC.7",
            Type = @"Field",
            Position = @"ORC.7",
            Name = @"Quantity / Timing",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TQ",
            DataTypeName = @"Timing Quantity",
            TableId = null,
            TableName = null,
            Description = @"determines the priority, quantity, frequency, and timing of an atomic service.  Order segments should be thought of as describing an atomic service.",
            Sample = @"",
        };

        // check for repetitions
        if (quantityTiming.field.FieldRepetitions != null && quantityTiming.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityTiming.Id));
            quantityTiming.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(quantityTiming, fieldData);
        }

        return quantityTiming;
    } 
}

internal HL7V22Field parent;

public HL7V22Field Parent
{
    get
    {
        if (parent != null)
        {
            return parent;
        }

        parent = new HL7V22Field
        {
            field = message[@"ORC"][8],
            Id = @"ORC.8",
            Type = @"Field",
            Position = @"ORC.8",
            Name = @"Parent",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_EIP",
            DataTypeName = @"Parent Order",
            TableId = null,
            TableName = null,
            Description = @"relates a child to its parent when a parent-child relationship exists.  The parent-child mechanism is described under ORC-1-order control notes.",
            Sample = @"",
        };

        // check for repetitions
        if (parent.field.FieldRepetitions != null && parent.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(parent.Id));
            parent.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(parent, fieldData);
        }

        return parent;
    } 
}

internal HL7V22Field dateTimeOfTransaction;

public HL7V22Field DateTimeOfTransaction
{
    get
    {
        if (dateTimeOfTransaction != null)
        {
            return dateTimeOfTransaction;
        }

        dateTimeOfTransaction = new HL7V22Field
        {
            field = message[@"ORC"][9],
            Id = @"ORC.9",
            Type = @"Field",
            Position = @"ORC.9",
            Name = @"Date / Time Of Transaction",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"Date and time the current transaction enters the ordering application.  For messages creating new orders, this is the date and time the order was entered. For other messages, this is the date and time the current transaction (e.g., cancellation) enters the sending application.  This date and time is for the current transaction and is not a ""replacement"" time for a correction to the original order.  Similarly, ORC-10-entered by, ORC-11-verified by, and ORC-13-enterer's location of this segment relate to the current transaction, not the original order",
            Sample = @"",
        };

        // check for repetitions
        if (dateTimeOfTransaction.field.FieldRepetitions != null && dateTimeOfTransaction.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateTimeOfTransaction.Id));
            dateTimeOfTransaction.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dateTimeOfTransaction, fieldData);
        }

        return dateTimeOfTransaction;
    } 
}

internal HL7V22Field enteredBy;

public HL7V22Field EnteredBy
{
    get
    {
        if (enteredBy != null)
        {
            return enteredBy;
        }

        enteredBy = new HL7V22Field
        {
            field = message[@"ORC"][10],
            Id = @"ORC.10",
            Type = @"Field",
            Position = @"ORC.10",
            Name = @"Entered By",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"identity of the person who actually keyed the request into the application.  It provides an audit trail in case the request is entered incorrectly and the ancillary department needs to clarify the request.  By local agreement, either the ID number or name component may be omitted",
            Sample = @"",
        };

        // check for repetitions
        if (enteredBy.field.FieldRepetitions != null && enteredBy.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(enteredBy.Id));
            enteredBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(enteredBy, fieldData);
        }

        return enteredBy;
    } 
}

internal HL7V22Field verifiedBy;

public HL7V22Field VerifiedBy
{
    get
    {
        if (verifiedBy != null)
        {
            return verifiedBy;
        }

        verifiedBy = new HL7V22Field
        {
            field = message[@"ORC"][11],
            Id = @"ORC.11",
            Type = @"Field",
            Position = @"ORC.11",
            Name = @"Verified By",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"identity of the person who verified the accuracy of the entered request.  It is used in cases where the request is entered by a technician and needs to be verified by a higher authority (e.g., a nurse).  By local agreement, either the ID number or name component may be omitted",
            Sample = @"",
        };

        // check for repetitions
        if (verifiedBy.field.FieldRepetitions != null && verifiedBy.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(verifiedBy.Id));
            verifiedBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(verifiedBy, fieldData);
        }

        return verifiedBy;
    } 
}

internal HL7V22Field orderingProvider;

public HL7V22Field OrderingProvider
{
    get
    {
        if (orderingProvider != null)
        {
            return orderingProvider;
        }

        orderingProvider = new HL7V22Field
        {
            field = message[@"ORC"][12],
            Id = @"ORC.12",
            Type = @"Field",
            Position = @"ORC.12",
            Name = @"Ordering Provider",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"identity of the person who is responsible for creating the request (i.e., ordering physician).  ORC-12ordering provider is the same as OBR-16-ordering provider",
            Sample = @"",
        };

        // check for repetitions
        if (orderingProvider.field.FieldRepetitions != null && orderingProvider.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(orderingProvider.Id));
            orderingProvider.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(orderingProvider, fieldData);
        }

        return orderingProvider;
    } 
}

internal HL7V22Field enterersLocation;

public HL7V22Field EnterersLocation
{
    get
    {
        if (enterersLocation != null)
        {
            return enterersLocation;
        }

        enterersLocation = new HL7V22Field
        {
            field = message[@"ORC"][13],
            Id = @"ORC.13",
            Type = @"Field",
            Position = @"ORC.13",
            Name = @"Enterer's Location",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"location (e.g., department, floor) of the person who entered the request.  It is a composite field that may be used on a site-specific basis to include some subcategory of department.  For example, ICU4 might be the designation for a fourth-floor ICU location",
            Sample = @"",
        };

        // check for repetitions
        if (enterersLocation.field.FieldRepetitions != null && enterersLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(enterersLocation.Id));
            enterersLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(enterersLocation, fieldData);
        }

        return enterersLocation;
    } 
}

internal HL7V22Field callBackPhoneNumber;

public HL7V22Field CallBackPhoneNumber
{
    get
    {
        if (callBackPhoneNumber != null)
        {
            return callBackPhoneNumber;
        }

        callBackPhoneNumber = new HL7V22Field
        {
            field = message[@"ORC"][14],
            Id = @"ORC.14",
            Type = @"Field",
            Position = @"ORC.14",
            Name = @"Call Back Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"telephone number to call for clarification of a request or other information regarding the order.  ORC14-call back phone number is the same as OBR-17-order call back phone number",
            Sample = @"",
        };

        // check for repetitions
        if (callBackPhoneNumber.field.FieldRepetitions != null && callBackPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(callBackPhoneNumber.Id));
            callBackPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(callBackPhoneNumber, fieldData);
        }

        return callBackPhoneNumber;
    } 
}

internal HL7V22Field orderEffectiveDateTime;

public HL7V22Field OrderEffectiveDateTime
{
    get
    {
        if (orderEffectiveDateTime != null)
        {
            return orderEffectiveDateTime;
        }

        orderEffectiveDateTime = new HL7V22Field
        {
            field = message[@"ORC"][15],
            Id = @"ORC.15",
            Type = @"Field",
            Position = @"ORC.15",
            Name = @"Order Effective Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time that the changes to the request took effect or are supposed to take effect",
            Sample = @"",
        };

        // check for repetitions
        if (orderEffectiveDateTime.field.FieldRepetitions != null && orderEffectiveDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(orderEffectiveDateTime.Id));
            orderEffectiveDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(orderEffectiveDateTime, fieldData);
        }

        return orderEffectiveDateTime;
    } 
}

internal HL7V22Field orderControlCodeReason;

public HL7V22Field OrderControlCodeReason
{
    get
    {
        if (orderControlCodeReason != null)
        {
            return orderControlCodeReason;
        }

        orderControlCodeReason = new HL7V22Field
        {
            field = message[@"ORC"][16],
            Id = @"ORC.16",
            Type = @"Field",
            Position = @"ORC.16",
            Name = @"Order Control Code Reason",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0119",
            TableName = @"ORDER CONTROL",
            Description = @"explanation (either in coded or text form) of the reason for the order event described by the order control code (table 0119).  Whereas an NTE after the order specific segment (e.g., RXO, ORO, OBR) would provide a comment for that specific segment, the purpose of the order control code reason is only to expand on the reason for the order event",
            Sample = @"",
        };

        // check for repetitions
        if (orderControlCodeReason.field.FieldRepetitions != null && orderControlCodeReason.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(orderControlCodeReason.Id));
            orderControlCodeReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(orderControlCodeReason, fieldData);
        }

        return orderControlCodeReason;
    } 
}

internal HL7V22Field enteringOrganization;

public HL7V22Field EnteringOrganization
{
    get
    {
        if (enteringOrganization != null)
        {
            return enteringOrganization;
        }

        enteringOrganization = new HL7V22Field
        {
            field = message[@"ORC"][17],
            Id = @"ORC.17",
            Type = @"Field",
            Position = @"ORC.17",
            Name = @"Entering Organization",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"organization that the enterer represents at the time he/she enters/maintains the order",
            Sample = @"",
        };

        // check for repetitions
        if (enteringOrganization.field.FieldRepetitions != null && enteringOrganization.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(enteringOrganization.Id));
            enteringOrganization.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(enteringOrganization, fieldData);
        }

        return enteringOrganization;
    } 
}

internal HL7V22Field enteringDevice;

public HL7V22Field EnteringDevice
{
    get
    {
        if (enteringDevice != null)
        {
            return enteringDevice;
        }

        enteringDevice = new HL7V22Field
        {
            field = message[@"ORC"][18],
            Id = @"ORC.18",
            Type = @"Field",
            Position = @"ORC.18",
            Name = @"Entering Device",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"identifier of the physical device (terminal, PC) used to enter the order",
            Sample = @"",
        };

        // check for repetitions
        if (enteringDevice.field.FieldRepetitions != null && enteringDevice.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(enteringDevice.Id));
            enteringDevice.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(enteringDevice, fieldData);
        }

        return enteringDevice;
    } 
}

internal HL7V22Field actionBy;

public HL7V22Field ActionBy
{
    get
    {
        if (actionBy != null)
        {
            return actionBy;
        }

        actionBy = new HL7V22Field
        {
            field = message[@"ORC"][19],
            Id = @"ORC.19",
            Type = @"Field",
            Position = @"ORC.19",
            Name = @"Action By",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"Identity of the person who initiated the event represented by the corresponding order control code.  For example, if the order control code is CA (cancel order request), this field represents the person who requested the order cancellation",
            Sample = @"",
        };

        // check for repetitions
        if (actionBy.field.FieldRepetitions != null && actionBy.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(actionBy.Id));
            actionBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(actionBy, fieldData);
        }

        return actionBy;
    } 
}
    }
}
