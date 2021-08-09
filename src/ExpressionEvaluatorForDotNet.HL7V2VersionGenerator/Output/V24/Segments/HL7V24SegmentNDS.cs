using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentNDS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NDS"; } }

        public string SegmentId { get { return @"NDS"; } }
        
        public string LongName { get { return @"Notification Detail"; } }
        
        public string Description { get { return @"The equipment notification detail segment is the data necessary to maintain an adequate audit trail as well as notifications of events, (e.g., alarms that have occurred on a particular piece of equipment."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

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
                            Id = @"NDS.1",
                            Type = @"Field",
                            Position = @"NDS.1",
                            Name = @"Notification Reference Number",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a unique sequential reference number that may be used by various components to refer to this transaction.  This number is generated by the originator of this notification",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.2",
                            Type = @"Field",
                            Position = @"NDS.2",
                            Name = @"Notification Date/Time",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the date/time of the notifications",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NDS.2.1",
                            Type = @"Component",
                            Position = @"NDS.2.1",
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
                            Id = @"NDS.2.2",
                            Type = @"Component",
                            Position = @"NDS.2.2",
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
                            Id = @"NDS.3",
                            Type = @"Field",
                            Position = @"NDS.3",
                            Name = @"Notification Alert Severity",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0367",
                            TableName = @"Alert level",
                            Description = @"The severity of the specific notification.  Refer to HL7 Table 0367 - Alert level for valid entries",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NDS.3.1",
                            Type = @"Component",
                            Position = @"NDS.3.1",
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
                            Id = @"NDS.3.2",
                            Type = @"Component",
                            Position = @"NDS.3.2",
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
                            Id = @"NDS.3.3",
                            Type = @"Component",
                            Position = @"NDS.3.3",
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
                            Id = @"NDS.3.4",
                            Type = @"Component",
                            Position = @"NDS.3.4",
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
                            Id = @"NDS.3.5",
                            Type = @"Component",
                            Position = @"NDS.3.5",
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
                            Id = @"NDS.3.6",
                            Type = @"Component",
                            Position = @"NDS.3.6",
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
                            Id = @"NDS.4",
                            Type = @"Field",
                            Position = @"NDS.4",
                            Name = @"Notification Code",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains information about the type of notification being sent.  These are manufacturer and equipment specific error or status codes, e.g., AQN0123 – aliquoting error – clot detected",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NDS.4.1",
                            Type = @"Component",
                            Position = @"NDS.4.1",
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
                            Id = @"NDS.4.2",
                            Type = @"Component",
                            Position = @"NDS.4.2",
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
                            Id = @"NDS.4.3",
                            Type = @"Component",
                            Position = @"NDS.4.3",
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
                            Id = @"NDS.4.4",
                            Type = @"Component",
                            Position = @"NDS.4.4",
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
                            Id = @"NDS.4.5",
                            Type = @"Component",
                            Position = @"NDS.4.5",
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
                            Id = @"NDS.4.6",
                            Type = @"Component",
                            Position = @"NDS.4.6",
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
                        };
            }
        }

        public HL7V24SegmentNDS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field notificationReferenceNumber;

public HL7V24Field NotificationReferenceNumber
{
    get
    {
        if (notificationReferenceNumber != null)
        {
            return notificationReferenceNumber;
        }

        notificationReferenceNumber = new HL7V24Field
        {
            field = message[@"NDS"][1],
            Id = @"NDS.1",
            Type = @"Field",
            Position = @"NDS.1",
            Name = @"Notification Reference Number",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains a unique sequential reference number that may be used by various components to refer to this transaction.  This number is generated by the originator of this notification",
            Sample = @"",
        };

        // check for repetitions
        if (notificationReferenceNumber.field.FieldRepetitions != null && notificationReferenceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(notificationReferenceNumber.Id));
            notificationReferenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(notificationReferenceNumber, fieldData);
        }

        return notificationReferenceNumber;
    } 
}

internal HL7V24Field notificationDateTime;

public HL7V24Field NotificationDateTime
{
    get
    {
        if (notificationDateTime != null)
        {
            return notificationDateTime;
        }

        notificationDateTime = new HL7V24Field
        {
            field = message[@"NDS"][2],
            Id = @"NDS.2",
            Type = @"Field",
            Position = @"NDS.2",
            Name = @"Notification Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time of the notifications",
            Sample = @"",
        };

        // check for repetitions
        if (notificationDateTime.field.FieldRepetitions != null && notificationDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(notificationDateTime.Id));
            notificationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(notificationDateTime, fieldData);
        }

        return notificationDateTime;
    } 
}

internal HL7V24Field notificationAlertSeverity;

public HL7V24Field NotificationAlertSeverity
{
    get
    {
        if (notificationAlertSeverity != null)
        {
            return notificationAlertSeverity;
        }

        notificationAlertSeverity = new HL7V24Field
        {
            field = message[@"NDS"][3],
            Id = @"NDS.3",
            Type = @"Field",
            Position = @"NDS.3",
            Name = @"Notification Alert Severity",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0367",
            TableName = @"Alert level",
            Description = @"The severity of the specific notification.  Refer to HL7 Table 0367 - Alert level for valid entries",
            Sample = @"",
        };

        // check for repetitions
        if (notificationAlertSeverity.field.FieldRepetitions != null && notificationAlertSeverity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(notificationAlertSeverity.Id));
            notificationAlertSeverity.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(notificationAlertSeverity, fieldData);
        }

        return notificationAlertSeverity;
    } 
}

internal HL7V24Field notificationCode;

public HL7V24Field NotificationCode
{
    get
    {
        if (notificationCode != null)
        {
            return notificationCode;
        }

        notificationCode = new HL7V24Field
        {
            field = message[@"NDS"][4],
            Id = @"NDS.4",
            Type = @"Field",
            Position = @"NDS.4",
            Name = @"Notification Code",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains information about the type of notification being sent.  These are manufacturer and equipment specific error or status codes, e.g., AQN0123 – aliquoting error – clot detected",
            Sample = @"",
        };

        // check for repetitions
        if (notificationCode.field.FieldRepetitions != null && notificationCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(notificationCode.Id));
            notificationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(notificationCode, fieldData);
        }

        return notificationCode;
    } 
}
    }
}
