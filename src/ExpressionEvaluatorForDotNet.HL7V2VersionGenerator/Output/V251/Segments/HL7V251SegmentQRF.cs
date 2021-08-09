using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentQRF
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QRF"; } }

        public string SegmentId { get { return @"QRF"; } }
        
        public string LongName { get { return @"Original style query filter"; } }
        
        public string Description { get { return @"This segment is not carried forward to the recommended queries for v 2.4.

The QRF segment is used with the QRD segment to further refine the content of an original style query. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

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
                            Id = @"QRF.1",
                            Type = @"Field",
                            Position = @"QRF.1",
                            Name = @"Where Subject Filter",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the department, system, or subsystem to which the query pertains.  This field may repeat as in LAB~HEMO, etc. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.2",
                            Type = @"Field",
                            Position = @"QRF.2",
                            Name = @"When Data Start Date/Time",
                            Length = 26,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has been retained for backward compatibility only. It is recommended to use QRF-9 – When quantity/timing qualifier.  When used for backward compatibility, this field contains the dates and times equal to or after which this value should be included.  ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.2.1",
                            Type = @"Component",
                            Position = @"QRF.2.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.2.2",
                            Type = @"Component",
                            Position = @"QRF.2.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.3",
                            Type = @"Field",
                            Position = @"QRF.3",
                            Name = @"When Data End Date/Time",
                            Length = 26,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has been retained for backward compatibility only. It is recommended to use QRF-9 – When quantity/timing qualifier.  When used for backward compatibility, this field contains the dates and times equal to or before which this date should be included. This field contains the dates and times equal to or before which this date should be included.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.3.1",
                            Type = @"Component",
                            Position = @"QRF.3.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.3.2",
                            Type = @"Component",
                            Position = @"QRF.3.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.4",
                            Type = @"Field",
                            Position = @"QRF.4",
                            Name = @"What User Qualifier",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an identifier to further define characteristics of the data of interest.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.5",
                            Type = @"Field",
                            Position = @"QRF.5",
                            Name = @"Other QRY Subject Filter",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a filter defined locally for use between two systems.  This filter uses codes and field definitions that have specific meaning only to the applications and/or site involved. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.6",
                            Type = @"Field",
                            Position = @"QRF.6",
                            Name = @"Which Date/Time Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0156",
                            TableName = @"Which date/time qualifier",
                            Description = @"This field specifies the type of date referred to in QRF-2-When data start date/time and QRF-3When data end date/time. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.7",
                            Type = @"Field",
                            Position = @"QRF.7",
                            Name = @"Which Date/Time Status Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0157",
                            TableName = @"Which date/time status qualifier",
                            Description = @"This field specifies the status type of objects selected in date range defined by QRF-2-When data start date/time and QRF-3-When data end date/time. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.8",
                            Type = @"Field",
                            Position = @"QRF.8",
                            Name = @"Date/Time Selection Qualifier",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0158",
                            TableName = @"Date/time selection qualifier",
                            Description = @"This field allows the specification of certain types of values within the date/time range. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9",
                            Type = @"Field",
                            Position = @"QRF.9",
                            Name = @"When Quantity/Timing Qualifier",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TQ",
                            DataTypeName = @"Timing Quantity",
                            TableId = null,
                            TableName = null,
                            Description = @"This field allows an interval definition to be used for specifying multiple responses to a query. With the addition of this filter, new query specifications should no longer use QRF-2-When data start date/time and QRF-3-When data end date/time in future implementations.

Note: This field is of data type TQ, which has been deprecated in Version 2.5.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.1",
                            Type = @"Component",
                            Position = @"QRF.9.1",
                            Name = @"Quantity",
                            Length = 267,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the quantity of the service that should be provided at each service interval. For example, if two blood cultures are to be obtained every 4 hours, the quantity would be 2. If three units of blood are to be typed and cross-matched, the quantity would be 3. The default value is 1. When units are required, they can be added, specified by a subcomponent delimiter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.1.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.1.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.1.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.1.2",
                            Name = @"Units",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.1.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.1.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.1.3",
                            Type = @"SubComponent",
                            Position = @"QRF.9.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.1.4",
                            Type = @"SubComponent",
                            Position = @"QRF.9.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.1.5",
                            Type = @"SubComponent",
                            Position = @"QRF.9.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.1.6",
                            Type = @"SubComponent",
                            Position = @"QRF.9.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = null,
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.2",
                            Type = @"Component",
                            Position = @"QRF.9.2",
                            Name = @"Interval",
                            Length = 206,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"RI",
                            DataTypeName = @"Repeat Interval",
                            TableId = null,
                            TableName = null,
                            Description = @"Determines the interval between repeated services.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.2.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.2.1",
                            Name = @"Repeat Pattern",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The repeating frequency with which the treatment is to be administered. It is similar to the frequency and SIG code tables used in order entry systems.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.2.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.2.2",
                            Name = @"Explicit Time Interval",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component explicitly lists the actual times referenced by the code in the first component, in the following format: HHMM,HHMM,HHMM,. This second component will be used to clarify the first component in cases where the actual times vary within an institution. If the time of the order spans more than a single day, this new component is only practical if the same times of administration occur for each day of the order. If the actual start time of the order (as given by the fourth component of the quantity/timing field) is after the first explicit time, the first administration is taken to be the first explicit time after the start time. In the case where the patient moves to a location having a different set of explicit times, the existing order may be updated with a new quantity/timing field showing the changed explicit times.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.3",
                            Type = @"Component",
                            Position = @"QRF.9.3",
                            Name = @"Duration",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component indicates how long the service should continue after it is started. The default is INDEF (do indefinitely). This component is coded as follows:",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.4",
                            Type = @"Component",
                            Position = @"QRF.9.4",
                            Name = @"Start Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This component may be specified by the orderer, in which case it indicates the earliest date/time at which the services should be started. In many cases, however, the start date/time will be implied or will be defined by other fields in the order record (e.g., urgency - STAT). In such a case, this field will be empty.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.4.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.4.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.4.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.4.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.5",
                            Type = @"Component",
                            Position = @"QRF.9.5",
                            Name = @"End Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"When filled in by the requester of the service, this component should contain the latest date/time that the service should be performed. If it has not been performed by the specified time, it should not be performed at all. The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.5.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.5.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.5.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.5.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.6",
                            Type = @"Component",
                            Position = @"QRF.9.6",
                            Name = @"Priority",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component describes the urgency of the request. The following values are suggested (the default for Priority is R):",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.7",
                            Type = @"Component",
                            Position = @"QRF.9.7",
                            Name = @"Condition",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a free text component that describes the conditions under which the drug is to be given. For example, PRN pain , or to keep blood pressure below 110. The presence of text in this field should be taken to mean that human review is needed to determine the how and/or when this drug should be given.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.8",
                            Type = @"Component",
                            Position = @"QRF.9.8",
                            Name = @"Text",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component is a full text version of the instruction (optional).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.9",
                            Type = @"Component",
                            Position = @"QRF.9.9",
                            Name = @"Conjunction",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0472",
                            TableName = @"TQ conjunction ID",
                            Description = @"This non-null component indicates that a second timing specification is to follow using the repeat delimiter. Refer to HL7 table 0472 - TQ Conjunction ID for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10",
                            Type = @"Component",
                            Position = @"QRF.9.10",
                            Name = @"Order Sequencing",
                            Length = 110,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"OSD",
                            DataTypeName = @"Order Sequence Definition",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.1",
                            Name = @"Sequence/Results Flag",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0524",
                            TableName = @"Sequence condition",
                            Description = @"Identifies whether sequence conditions or a repeating cycle of orders is defined. Refer to HL7-defined Table 0524 - Sequence condition for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.2",
                            Name = @"Placer Order Number: Entity Identifier",
                            Length = 15,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first component of the placer order number, entity identifier .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.3",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.3",
                            Name = @"Placer Order Number: Namespace Id",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"Contains the second component of the placer order number, namespace ID. Refer to user-defined table 0363 - Assigning Authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.4",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.4",
                            Name = @"Filler Order Number: Entity Identifier",
                            Length = 15,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first component of the filler order number, entity identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.5",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.5",
                            Name = @"Filler Order Number: Namespace Id",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"Contains the second component of the filler order number, namespace ID. Refer to user-defined table 0363 - Assigning Authority for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.6",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.6",
                            Name = @"Sequence Condition Value",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the relationship between the start/end of the related predecessor or successor order and the current order from ORC-2, 3 or 4.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.7",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.7",
                            Name = @"Maximum Number Of Repeats",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum number of repeats to be used only on cyclic groups. The total number of repeats is constrained by the end date/time of the last repeat or the end date/time of the parent, whichever is first.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.8",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.8",
                            Name = @"Placer Order Number: Universal Id",
                            Length = 15,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the next to the last component of the placer order number, universal ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.9",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.9",
                            Name = @"Placer Order Number: Universal Id Type",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Contains the last component of the placer order number. Refer to HL7 table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.10",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.10",
                            Name = @"Filler Order Number: Universal Id",
                            Length = 15,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the next to the last component of the filler order number, universal ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.11",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.11",
                            Name = @"Filler Order Number: Universal Id Type",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Contains the last component of the placer order number. Refer to HL7 table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.11",
                            Type = @"Component",
                            Position = @"QRF.9.11",
                            Name = @"Occurrence Duration",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the duration for a single performance of a service, e.g., whirlpool twenty minutes three times per day for three days. It is optional within TQ and does not repeat.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.11.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.11.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.11.3",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.11.4",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.11.5",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.11.6",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.12",
                            Type = @"Component",
                            Position = @"QRF.9.12",
                            Name = @"Total Occurrences",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the total number of occurrences of a service that should result from this order. It is optional within TQ and does not repeat. If both the end date/time and the total occurrences are valued and the occurrences would extend beyond the end date/time, then the end date/time takes precedence. Otherwise the number of occurrences takes precedence.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.10",
                            Type = @"Field",
                            Position = @"QRF.10",
                            Name = @"Search Confidence Threshold",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a numeric value used to establish the minimum threshold match. The value instructs the responding system to return no records for patients whose “match weight” on the look-up was lower than this user-defined value. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V251SegmentQRF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field whereSubjectFilter;

public HL7V251Field WhereSubjectFilter
{
    get
    {
        if (whereSubjectFilter != null)
        {
            return whereSubjectFilter;
        }

        whereSubjectFilter = new HL7V251Field
        {
            field = message[@"QRF"][1],
            Id = @"QRF.1",
            Type = @"Field",
            Position = @"QRF.1",
            Name = @"Where Subject Filter",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the department, system, or subsystem to which the query pertains.  This field may repeat as in LAB~HEMO, etc. ",
            Sample = @"",
        };

        // check for repetitions
        if (whereSubjectFilter.field.FieldRepetitions != null && whereSubjectFilter.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whereSubjectFilter.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < whereSubjectFilter.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = whereSubjectFilter.field.FieldRepetitions[i],
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
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < whereSubjectFilter.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = whereSubjectFilter.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < whereSubjectFilter.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = whereSubjectFilter.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            whereSubjectFilter.fieldRepetitions = fieldRepetitions;
        }

        return whereSubjectFilter;
    } 
}

internal HL7V251Field whenDataStartDateTime;

public HL7V251Field WhenDataStartDateTime
{
    get
    {
        if (whenDataStartDateTime != null)
        {
            return whenDataStartDateTime;
        }

        whenDataStartDateTime = new HL7V251Field
        {
            field = message[@"QRF"][2],
            Id = @"QRF.2",
            Type = @"Field",
            Position = @"QRF.2",
            Name = @"When Data Start Date/Time",
            Length = 26,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only. It is recommended to use QRF-9 – When quantity/timing qualifier.  When used for backward compatibility, this field contains the dates and times equal to or after which this value should be included.  ",
            Sample = @"",
        };

        // check for repetitions
        if (whenDataStartDateTime.field.FieldRepetitions != null && whenDataStartDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whenDataStartDateTime.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < whenDataStartDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = whenDataStartDateTime.field.FieldRepetitions[i],
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
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < whenDataStartDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = whenDataStartDateTime.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < whenDataStartDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = whenDataStartDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            whenDataStartDateTime.fieldRepetitions = fieldRepetitions;
        }

        return whenDataStartDateTime;
    } 
}

internal HL7V251Field whenDataEndDateTime;

public HL7V251Field WhenDataEndDateTime
{
    get
    {
        if (whenDataEndDateTime != null)
        {
            return whenDataEndDateTime;
        }

        whenDataEndDateTime = new HL7V251Field
        {
            field = message[@"QRF"][3],
            Id = @"QRF.3",
            Type = @"Field",
            Position = @"QRF.3",
            Name = @"When Data End Date/Time",
            Length = 26,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only. It is recommended to use QRF-9 – When quantity/timing qualifier.  When used for backward compatibility, this field contains the dates and times equal to or before which this date should be included. This field contains the dates and times equal to or before which this date should be included.",
            Sample = @"",
        };

        // check for repetitions
        if (whenDataEndDateTime.field.FieldRepetitions != null && whenDataEndDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whenDataEndDateTime.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < whenDataEndDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = whenDataEndDateTime.field.FieldRepetitions[i],
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
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < whenDataEndDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = whenDataEndDateTime.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < whenDataEndDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = whenDataEndDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            whenDataEndDateTime.fieldRepetitions = fieldRepetitions;
        }

        return whenDataEndDateTime;
    } 
}

internal HL7V251Field whatUserQualifier;

public HL7V251Field WhatUserQualifier
{
    get
    {
        if (whatUserQualifier != null)
        {
            return whatUserQualifier;
        }

        whatUserQualifier = new HL7V251Field
        {
            field = message[@"QRF"][4],
            Id = @"QRF.4",
            Type = @"Field",
            Position = @"QRF.4",
            Name = @"What User Qualifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifier to further define characteristics of the data of interest.",
            Sample = @"",
        };

        // check for repetitions
        if (whatUserQualifier.field.FieldRepetitions != null && whatUserQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whatUserQualifier.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < whatUserQualifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = whatUserQualifier.field.FieldRepetitions[i],
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
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < whatUserQualifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = whatUserQualifier.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < whatUserQualifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = whatUserQualifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            whatUserQualifier.fieldRepetitions = fieldRepetitions;
        }

        return whatUserQualifier;
    } 
}

internal HL7V251Field otherQRYSubjectFilter;

public HL7V251Field OtherQRYSubjectFilter
{
    get
    {
        if (otherQRYSubjectFilter != null)
        {
            return otherQRYSubjectFilter;
        }

        otherQRYSubjectFilter = new HL7V251Field
        {
            field = message[@"QRF"][5],
            Id = @"QRF.5",
            Type = @"Field",
            Position = @"QRF.5",
            Name = @"Other QRY Subject Filter",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a filter defined locally for use between two systems.  This filter uses codes and field definitions that have specific meaning only to the applications and/or site involved. ",
            Sample = @"",
        };

        // check for repetitions
        if (otherQRYSubjectFilter.field.FieldRepetitions != null && otherQRYSubjectFilter.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(otherQRYSubjectFilter.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < otherQRYSubjectFilter.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = otherQRYSubjectFilter.field.FieldRepetitions[i],
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
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < otherQRYSubjectFilter.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = otherQRYSubjectFilter.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < otherQRYSubjectFilter.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = otherQRYSubjectFilter.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            otherQRYSubjectFilter.fieldRepetitions = fieldRepetitions;
        }

        return otherQRYSubjectFilter;
    } 
}

internal HL7V251Field whichDateTimeQualifier;

public HL7V251Field WhichDateTimeQualifier
{
    get
    {
        if (whichDateTimeQualifier != null)
        {
            return whichDateTimeQualifier;
        }

        whichDateTimeQualifier = new HL7V251Field
        {
            field = message[@"QRF"][6],
            Id = @"QRF.6",
            Type = @"Field",
            Position = @"QRF.6",
            Name = @"Which Date/Time Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0156",
            TableName = @"Which date/time qualifier",
            Description = @"This field specifies the type of date referred to in QRF-2-When data start date/time and QRF-3When data end date/time. ",
            Sample = @"",
        };

        // check for repetitions
        if (whichDateTimeQualifier.field.FieldRepetitions != null && whichDateTimeQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whichDateTimeQualifier.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < whichDateTimeQualifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = whichDateTimeQualifier.field.FieldRepetitions[i],
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
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < whichDateTimeQualifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = whichDateTimeQualifier.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < whichDateTimeQualifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = whichDateTimeQualifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            whichDateTimeQualifier.fieldRepetitions = fieldRepetitions;
        }

        return whichDateTimeQualifier;
    } 
}

internal HL7V251Field whichDateTimeStatusQualifier;

public HL7V251Field WhichDateTimeStatusQualifier
{
    get
    {
        if (whichDateTimeStatusQualifier != null)
        {
            return whichDateTimeStatusQualifier;
        }

        whichDateTimeStatusQualifier = new HL7V251Field
        {
            field = message[@"QRF"][7],
            Id = @"QRF.7",
            Type = @"Field",
            Position = @"QRF.7",
            Name = @"Which Date/Time Status Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0157",
            TableName = @"Which date/time status qualifier",
            Description = @"This field specifies the status type of objects selected in date range defined by QRF-2-When data start date/time and QRF-3-When data end date/time. ",
            Sample = @"",
        };

        // check for repetitions
        if (whichDateTimeStatusQualifier.field.FieldRepetitions != null && whichDateTimeStatusQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whichDateTimeStatusQualifier.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < whichDateTimeStatusQualifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = whichDateTimeStatusQualifier.field.FieldRepetitions[i],
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
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < whichDateTimeStatusQualifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = whichDateTimeStatusQualifier.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < whichDateTimeStatusQualifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = whichDateTimeStatusQualifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            whichDateTimeStatusQualifier.fieldRepetitions = fieldRepetitions;
        }

        return whichDateTimeStatusQualifier;
    } 
}

internal HL7V251Field dateTimeSelectionQualifier;

public HL7V251Field DateTimeSelectionQualifier
{
    get
    {
        if (dateTimeSelectionQualifier != null)
        {
            return dateTimeSelectionQualifier;
        }

        dateTimeSelectionQualifier = new HL7V251Field
        {
            field = message[@"QRF"][8],
            Id = @"QRF.8",
            Type = @"Field",
            Position = @"QRF.8",
            Name = @"Date/Time Selection Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0158",
            TableName = @"Date/time selection qualifier",
            Description = @"This field allows the specification of certain types of values within the date/time range. ",
            Sample = @"",
        };

        // check for repetitions
        if (dateTimeSelectionQualifier.field.FieldRepetitions != null && dateTimeSelectionQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateTimeSelectionQualifier.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < dateTimeSelectionQualifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = dateTimeSelectionQualifier.field.FieldRepetitions[i],
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
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < dateTimeSelectionQualifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = dateTimeSelectionQualifier.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < dateTimeSelectionQualifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = dateTimeSelectionQualifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            dateTimeSelectionQualifier.fieldRepetitions = fieldRepetitions;
        }

        return dateTimeSelectionQualifier;
    } 
}

internal HL7V251Field whenQuantityTimingQualifier;

public HL7V251Field WhenQuantityTimingQualifier
{
    get
    {
        if (whenQuantityTimingQualifier != null)
        {
            return whenQuantityTimingQualifier;
        }

        whenQuantityTimingQualifier = new HL7V251Field
        {
            field = message[@"QRF"][9],
            Id = @"QRF.9",
            Type = @"Field",
            Position = @"QRF.9",
            Name = @"When Quantity/Timing Qualifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TQ",
            DataTypeName = @"Timing Quantity",
            TableId = null,
            TableName = null,
            Description = @"This field allows an interval definition to be used for specifying multiple responses to a query. With the addition of this filter, new query specifications should no longer use QRF-2-When data start date/time and QRF-3-When data end date/time in future implementations.

Note: This field is of data type TQ, which has been deprecated in Version 2.5.",
            Sample = @"",
        };

        // check for repetitions
        if (whenQuantityTimingQualifier.field.FieldRepetitions != null && whenQuantityTimingQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whenQuantityTimingQualifier.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < whenQuantityTimingQualifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = whenQuantityTimingQualifier.field.FieldRepetitions[i],
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
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < whenQuantityTimingQualifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = whenQuantityTimingQualifier.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < whenQuantityTimingQualifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = whenQuantityTimingQualifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            whenQuantityTimingQualifier.fieldRepetitions = fieldRepetitions;
        }

        return whenQuantityTimingQualifier;
    } 
}

internal HL7V251Field searchConfidenceThreshold;

public HL7V251Field SearchConfidenceThreshold
{
    get
    {
        if (searchConfidenceThreshold != null)
        {
            return searchConfidenceThreshold;
        }

        searchConfidenceThreshold = new HL7V251Field
        {
            field = message[@"QRF"][10],
            Id = @"QRF.10",
            Type = @"Field",
            Position = @"QRF.10",
            Name = @"Search Confidence Threshold",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains a numeric value used to establish the minimum threshold match. The value instructs the responding system to return no records for patients whose “match weight” on the look-up was lower than this user-defined value. ",
            Sample = @"",
        };

        // check for repetitions
        if (searchConfidenceThreshold.field.FieldRepetitions != null && searchConfidenceThreshold.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(searchConfidenceThreshold.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < searchConfidenceThreshold.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = searchConfidenceThreshold.field.FieldRepetitions[i],
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
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < searchConfidenceThreshold.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = searchConfidenceThreshold.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < searchConfidenceThreshold.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = searchConfidenceThreshold.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            searchConfidenceThreshold.fieldRepetitions = fieldRepetitions;
        }

        return searchConfidenceThreshold;
    } 
}
    }
}
