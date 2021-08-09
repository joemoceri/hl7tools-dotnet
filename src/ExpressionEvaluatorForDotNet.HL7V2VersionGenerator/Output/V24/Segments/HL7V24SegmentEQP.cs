using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentEQP
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"EQP"; } }

        public string SegmentId { get { return @"EQP"; } }
        
        public string LongName { get { return @"Equipment/log Service"; } }
        
        public string Description { get { return @"The equipment log/service segment is the data necessary to maintain an adequate audit trail of events that have occurred on a particular piece of equipment."; } }
        
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
                            Id = @"EQP.1",
                            Type = @"Field",
                            Position = @"EQP.1",
                            Name = @"Event type",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0450",
                            TableName = @"Event type",
                            Description = @"This field identifies the type of event of the message.  Refer to HL7 Table 0450 – Event type for valid values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EQP.1.1",
                            Type = @"Component",
                            Position = @"EQP.1.1",
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
                            Id = @"EQP.1.2",
                            Type = @"Component",
                            Position = @"EQP.1.2",
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
                            Id = @"EQP.1.3",
                            Type = @"Component",
                            Position = @"EQP.1.3",
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
                            Id = @"EQP.1.4",
                            Type = @"Component",
                            Position = @"EQP.1.4",
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
                            Id = @"EQP.1.5",
                            Type = @"Component",
                            Position = @"EQP.1.5",
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
                            Id = @"EQP.1.6",
                            Type = @"Component",
                            Position = @"EQP.1.6",
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
                            Id = @"EQP.2",
                            Type = @"Field",
                            Position = @"EQP.2",
                            Name = @"File Name",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the physical file name that is being used to store information about the transmitted log and/or service event",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.3",
                            Type = @"Field",
                            Position = @"EQP.3",
                            Name = @"Start Date/Time",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the date/time that the event started",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EQP.3.1",
                            Type = @"Component",
                            Position = @"EQP.3.1",
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
                            Id = @"EQP.3.2",
                            Type = @"Component",
                            Position = @"EQP.3.2",
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
                            Id = @"EQP.4",
                            Type = @"Field",
                            Position = @"EQP.4",
                            Name = @"End Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the date/time that the event was completed",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EQP.4.1",
                            Type = @"Component",
                            Position = @"EQP.4.1",
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
                            Id = @"EQP.4.2",
                            Type = @"Component",
                            Position = @"EQP.4.2",
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
                            Id = @"EQP.5",
                            Type = @"Field",
                            Position = @"EQP.5",
                            Name = @"Transaction Data",
                            Length = 65536,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the data that the log and/or service event was about and is to be logged",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentEQP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field eventtype;

public HL7V24Field Eventtype
{
    get
    {
        if (eventtype != null)
        {
            return eventtype;
        }

        eventtype = new HL7V24Field
        {
            field = message[@"EQP"][1],
            Id = @"EQP.1",
            Type = @"Field",
            Position = @"EQP.1",
            Name = @"Event type",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0450",
            TableName = @"Event type",
            Description = @"This field identifies the type of event of the message.  Refer to HL7 Table 0450 – Event type for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (eventtype.field.FieldRepetitions != null && eventtype.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventtype.Id));
            eventtype.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(eventtype, fieldData);
        }

        return eventtype;
    } 
}

internal HL7V24Field fileName;

public HL7V24Field FileName
{
    get
    {
        if (fileName != null)
        {
            return fileName;
        }

        fileName = new HL7V24Field
        {
            field = message[@"EQP"][2],
            Id = @"EQP.2",
            Type = @"Field",
            Position = @"EQP.2",
            Name = @"File Name",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is the physical file name that is being used to store information about the transmitted log and/or service event",
            Sample = @"",
        };

        // check for repetitions
        if (fileName.field.FieldRepetitions != null && fileName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileName.Id));
            fileName.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileName, fieldData);
        }

        return fileName;
    } 
}

internal HL7V24Field startDateTime;

public HL7V24Field StartDateTime
{
    get
    {
        if (startDateTime != null)
        {
            return startDateTime;
        }

        startDateTime = new HL7V24Field
        {
            field = message[@"EQP"][3],
            Id = @"EQP.3",
            Type = @"Field",
            Position = @"EQP.3",
            Name = @"Start Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time that the event started",
            Sample = @"",
        };

        // check for repetitions
        if (startDateTime.field.FieldRepetitions != null && startDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(startDateTime.Id));
            startDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(startDateTime, fieldData);
        }

        return startDateTime;
    } 
}

internal HL7V24Field endDateTime;

public HL7V24Field EndDateTime
{
    get
    {
        if (endDateTime != null)
        {
            return endDateTime;
        }

        endDateTime = new HL7V24Field
        {
            field = message[@"EQP"][4],
            Id = @"EQP.4",
            Type = @"Field",
            Position = @"EQP.4",
            Name = @"End Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time that the event was completed",
            Sample = @"",
        };

        // check for repetitions
        if (endDateTime.field.FieldRepetitions != null && endDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(endDateTime.Id));
            endDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(endDateTime, fieldData);
        }

        return endDateTime;
    } 
}

internal HL7V24Field transactionData;

public HL7V24Field TransactionData
{
    get
    {
        if (transactionData != null)
        {
            return transactionData;
        }

        transactionData = new HL7V24Field
        {
            field = message[@"EQP"][5],
            Id = @"EQP.5",
            Type = @"Field",
            Position = @"EQP.5",
            Name = @"Transaction Data",
            Length = 65536,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field is the data that the log and/or service event was about and is to be logged",
            Sample = @"",
        };

        // check for repetitions
        if (transactionData.field.FieldRepetitions != null && transactionData.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionData.Id));
            transactionData.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(transactionData, fieldData);
        }

        return transactionData;
    } 
}
    }
}
