using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataType
    {
        public string Id { get { return @"TQ"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Timing Quantity"; } }

        public string Description { get { return @"Quantity/timing (ORC-7, OBR-27) provides a means of specifying when the service described by the order segment is to be performed and how frequently.  It is a complex multicomponent field that can have repeats; i.e., more than one quantity/timing specification, separated by repeat delimiters, may appear. It is a distinct data type (see Section 2.8.41, “TQ - timing quantity”).  The components of a single quantity/timing specification are described in Sections 4.3.1, “Quantity component  (CQ),” through 4.3.12, “Total occurrences component (NM).”"; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 0; } }

        public string Usage { get { return null; } }

        public string Rpt { get { return null; } }

        public string TableId { get { return null; } }

        public string TableName { get { return null; } }

        public string Sample { get { return @""; } }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TQ.1",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.1",
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
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ.2",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.2",
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
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ.3",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.3",
                            Name = @"Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates how long the service should continue after it is started.  The default is INDEF (do indefinitely). ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ.4",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.4",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be specified by the orderer, in which case it indicates the earliest date/time at which the services should be started.  In many cases, however, the start date/time will be implied or will be defined by other fields in the order record (e.g., urgency - STAT).  In such a case, this field will be empty.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ.5",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.5",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"When filled in by the requester of the service, this field should contain the latest date/time that the service should be performed.  If it has not been performed by the specified time, it should not be performed at all.  The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ.6",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.6",
                            Name = @"Priority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @" This field describes the urgency of the request.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ.7",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.7",
                            Name = @"Condition",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a free text field that describes the conditions under which the drug is to be given.  For example, PRN pain, or to keep blood pressure below 110.  The presence of text in this field should be taken to mean that human review is needed to determine the how and/or when this drug should be given.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ.8",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.8",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a full text version of the instruction (optional).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ.9",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.9",
                            Name = @"Conjunction Component",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0472",
                            TableName = @"TQ Conjunction ID",
                            Description = @"This non-null component indicates that a second timing specification is to follow using the repeat delimiter.  This field can take three values as shown in HL7 table 0472 - TQ Conjunction ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ.10",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.10",
                            Name = @"Order Sequencing",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"OSD",
                            DataTypeName = @"Order Sequence",
                            TableId = null,
                            TableName = null,
                            Description = @"There are many situations, such as the creation of an order for a group of intravenous (IV) solutions, where the sequence of the individual intravenous solutions (each a service in itself) needs to be specified, e.g., hyperalimentation with multi-vitamins in every third bottle.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ.11",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.11",
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
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ.12",
                            Type = @"DataTypeComponent",
                            Position = @"TQ.12",
                            Name = @"Total Occurences",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the total number of occurrences of a service that should result from this order.  It is optional within TQ and does not repeat.  If both the end date/time and the total occurrences are valued and the occurrences would extend beyond the end date/time, then the end date/time takes precedence.  Otherwise the number of occurrences takes precedence.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
