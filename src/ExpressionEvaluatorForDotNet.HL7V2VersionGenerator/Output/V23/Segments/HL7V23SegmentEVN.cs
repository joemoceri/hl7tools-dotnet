using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentEVN
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"EVN"; } }

        public string SegmentId { get { return @"EVN"; } }
        
        public string LongName { get { return @"Event type"; } }
        
        public string Description { get { return @"The EVN segment is used to communicate necessary trigger event information to receiving applications.  Valid event types for all chapters are contained in HL7 table 0003 - Event type."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

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
                            Id = @"EVN.1",
                            Type = @"Field",
                            Position = @"EVN.1",
                            Name = @"Event Type Code",
                            Length = 3,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0003",
                            TableName = @"Event type",
                            Description = @"This field has been retained for backward compatibility only.  We recommend using the second component (trigger event) of MSH-9-message type to transmit event type code information.  This field contains the events corresponding to the trigger events described in this section, e.g., admission, transfer, or registration.  Refer to Chapter 2, HL7 table 0003 - Event type for valid values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.2",
                            Type = @"Field",
                            Position = @"EVN.2",
                            Name = @"Recorded Date/Time",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"  Most systems will default to the system date/time when the transaction was entered, but they should also permit an override. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EVN.2.1",
                            Type = @"Component",
                            Position = @"EVN.2.1",
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
                            Id = @"EVN.3",
                            Type = @"Field",
                            Position = @"EVN.3",
                            Name = @"Date/Time Planned Event",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the event is planned.  We recommend that the PV2expected admit date and PV2-9-expected discharge date be used whenever possible. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EVN.3.1",
                            Type = @"Component",
                            Position = @"EVN.3.1",
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
                            Id = @"EVN.4",
                            Type = @"Field",
                            Position = @"EVN.4",
                            Name = @"Event Reason Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0062",
                            TableName = @"Event reason",
                            Description = @"This field contains the reason for this event (e.g., patient request, physician order, census management, etc.).  Refer to user-defined table 0062 - Event reason for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.5",
                            Type = @"Field",
                            Position = @"EVN.5",
                            Name = @"Operator ID",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = @"0188",
                            TableName = @"Operator ID",
                            Description = @"This field identifies the individual responsible for triggering the event.  Refer to user-defined table 0188 - Operator ID for suggested values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EVN.5.1",
                            Type = @"Component",
                            Position = @"EVN.5.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.5.2",
                            Type = @"Component",
                            Position = @"EVN.5.2",
                            Name = @"Family Name",
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
                            Id = @"EVN.5.3",
                            Type = @"Component",
                            Position = @"EVN.5.3",
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
                            Id = @"EVN.5.4",
                            Type = @"Component",
                            Position = @"EVN.5.4",
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
                            Id = @"EVN.5.5",
                            Type = @"Component",
                            Position = @"EVN.5.5",
                            Name = @"Suffix",
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
                            Id = @"EVN.5.6",
                            Type = @"Component",
                            Position = @"EVN.5.6",
                            Name = @"Prefix",
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
                            Id = @"EVN.5.7",
                            Type = @"Component",
                            Position = @"EVN.5.7",
                            Name = @"Degree",
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
                            Id = @"EVN.5.8",
                            Type = @"Component",
                            Position = @"EVN.5.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.5.9",
                            Type = @"Component",
                            Position = @"EVN.5.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EVN.5.9.1",
                            Type = @"SubComponent",
                            Position = @"EVN.5.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.5.9.2",
                            Type = @"SubComponent",
                            Position = @"EVN.5.9.2",
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
                            Id = @"EVN.5.9.3",
                            Type = @"SubComponent",
                            Position = @"EVN.5.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.5.10",
                            Type = @"Component",
                            Position = @"EVN.5.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.5.11",
                            Type = @"Component",
                            Position = @"EVN.5.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.5.12",
                            Type = @"Component",
                            Position = @"EVN.5.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.5.13",
                            Type = @"Component",
                            Position = @"EVN.5.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.5.14",
                            Type = @"Component",
                            Position = @"EVN.5.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EVN.5.14.1",
                            Type = @"SubComponent",
                            Position = @"EVN.5.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.5.14.2",
                            Type = @"SubComponent",
                            Position = @"EVN.5.14.2",
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
                            Id = @"EVN.5.14.3",
                            Type = @"SubComponent",
                            Position = @"EVN.5.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EVN.6",
                            Type = @"Field",
                            Position = @"EVN.6",
                            Name = @"Event Occurred",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the event actually occurred.  For example, on a transfer (A02 (transfer a patient)), this field would contain the date/time the patient was actually transferred.  On a cancellation event, this field should contain the date/time that the event being canceled occurred.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EVN.6.1",
                            Type = @"Component",
                            Position = @"EVN.6.1",
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
                        };
            }
        }

        public HL7V23SegmentEVN(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field eventTypeCode;

public HL7V23Field EventTypeCode
{
    get
    {
        if (eventTypeCode != null)
        {
            return eventTypeCode;
        }

        eventTypeCode = new HL7V23Field
        {
            field = message[@"EVN"][1],
            Id = @"EVN.1",
            Type = @"Field",
            Position = @"EVN.1",
            Name = @"Event Type Code",
            Length = 3,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0003",
            TableName = @"Event type",
            Description = @"This field has been retained for backward compatibility only.  We recommend using the second component (trigger event) of MSH-9-message type to transmit event type code information.  This field contains the events corresponding to the trigger events described in this section, e.g., admission, transfer, or registration.  Refer to Chapter 2, HL7 table 0003 - Event type for valid values. ",
            Sample = @"",
        };

        // check for repetitions
        if (eventTypeCode.field.FieldRepetitions != null && eventTypeCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventTypeCode.Id));
            eventTypeCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(eventTypeCode, fieldData);
        }

        return eventTypeCode;
    } 
}

internal HL7V23Field recordedDateTime;

public HL7V23Field RecordedDateTime
{
    get
    {
        if (recordedDateTime != null)
        {
            return recordedDateTime;
        }

        recordedDateTime = new HL7V23Field
        {
            field = message[@"EVN"][2],
            Id = @"EVN.2",
            Type = @"Field",
            Position = @"EVN.2",
            Name = @"Recorded Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"  Most systems will default to the system date/time when the transaction was entered, but they should also permit an override. ",
            Sample = @"",
        };

        // check for repetitions
        if (recordedDateTime.field.FieldRepetitions != null && recordedDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(recordedDateTime.Id));
            recordedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(recordedDateTime, fieldData);
        }

        return recordedDateTime;
    } 
}

internal HL7V23Field dateTimePlannedEvent;

public HL7V23Field DateTimePlannedEvent
{
    get
    {
        if (dateTimePlannedEvent != null)
        {
            return dateTimePlannedEvent;
        }

        dateTimePlannedEvent = new HL7V23Field
        {
            field = message[@"EVN"][3],
            Id = @"EVN.3",
            Type = @"Field",
            Position = @"EVN.3",
            Name = @"Date/Time Planned Event",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the event is planned.  We recommend that the PV2expected admit date and PV2-9-expected discharge date be used whenever possible. ",
            Sample = @"",
        };

        // check for repetitions
        if (dateTimePlannedEvent.field.FieldRepetitions != null && dateTimePlannedEvent.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateTimePlannedEvent.Id));
            dateTimePlannedEvent.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(dateTimePlannedEvent, fieldData);
        }

        return dateTimePlannedEvent;
    } 
}

internal HL7V23Field eventReasonCode;

public HL7V23Field EventReasonCode
{
    get
    {
        if (eventReasonCode != null)
        {
            return eventReasonCode;
        }

        eventReasonCode = new HL7V23Field
        {
            field = message[@"EVN"][4],
            Id = @"EVN.4",
            Type = @"Field",
            Position = @"EVN.4",
            Name = @"Event Reason Code",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0062",
            TableName = @"Event reason",
            Description = @"This field contains the reason for this event (e.g., patient request, physician order, census management, etc.).  Refer to user-defined table 0062 - Event reason for suggested values. ",
            Sample = @"",
        };

        // check for repetitions
        if (eventReasonCode.field.FieldRepetitions != null && eventReasonCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventReasonCode.Id));
            eventReasonCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(eventReasonCode, fieldData);
        }

        return eventReasonCode;
    } 
}

internal HL7V23Field operatorID;

public HL7V23Field OperatorID
{
    get
    {
        if (operatorID != null)
        {
            return operatorID;
        }

        operatorID = new HL7V23Field
        {
            field = message[@"EVN"][5],
            Id = @"EVN.5",
            Type = @"Field",
            Position = @"EVN.5",
            Name = @"Operator ID",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = @"0188",
            TableName = @"Operator ID",
            Description = @"This field identifies the individual responsible for triggering the event.  Refer to user-defined table 0188 - Operator ID for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (operatorID.field.FieldRepetitions != null && operatorID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(operatorID.Id));
            operatorID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(operatorID, fieldData);
        }

        return operatorID;
    } 
}

internal HL7V23Field eventOccurred;

public HL7V23Field EventOccurred
{
    get
    {
        if (eventOccurred != null)
        {
            return eventOccurred;
        }

        eventOccurred = new HL7V23Field
        {
            field = message[@"EVN"][6],
            Id = @"EVN.6",
            Type = @"Field",
            Position = @"EVN.6",
            Name = @"Event Occurred",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the event actually occurred.  For example, on a transfer (A02 (transfer a patient)), this field would contain the date/time the patient was actually transferred.  On a cancellation event, this field should contain the date/time that the event being canceled occurred.",
            Sample = @"",
        };

        // check for repetitions
        if (eventOccurred.field.FieldRepetitions != null && eventOccurred.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventOccurred.Id));
            eventOccurred.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(eventOccurred, fieldData);
        }

        return eventOccurred;
    } 
}
    }
}
