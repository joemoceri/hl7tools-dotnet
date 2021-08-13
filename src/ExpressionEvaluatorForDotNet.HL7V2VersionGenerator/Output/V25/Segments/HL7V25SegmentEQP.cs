using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentEQP
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

        public HL7V25SegmentEQP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _eventtype;

public HL7V25Field Eventtype
{
    get
    {
        if (_eventtype != null)
        {
            return _eventtype;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field identifies the type of event of the message. Refer to HL7 Table 0450 - Event typ e for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EQP.1.1",
                            Type = @"Component",
                            Position = @"EQP.1.1",
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
                            Id = @"EQP.1.2",
                            Type = @"Component",
                            Position = @"EQP.1.2",
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
                            Id = @"EQP.1.3",
                            Type = @"Component",
                            Position = @"EQP.1.3",
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
                            Id = @"EQP.1.4",
                            Type = @"Component",
                            Position = @"EQP.1.4",
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
                            Id = @"EQP.1.5",
                            Type = @"Component",
                            Position = @"EQP.1.5",
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
                            Id = @"EQP.1.6",
                            Type = @"Component",
                            Position = @"EQP.1.6",
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
                        },
                        }
        }

        _eventtype = new HL7V25Field
        {
            field = message[@"EQP"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventtype.field.FieldRepetitions != null && _eventtype.field.FieldRepetitions.Count > 0)
        {
            _eventtype.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_eventtype, fieldData);
        }

        return _eventtype;
    } 
}

internal HL7V25Field _fileName;

public HL7V25Field FileName
{
    get
    {
        if (_fileName != null)
        {
            return _fileName;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field is the physical file name that is being used to store information about the transmitted log and/or service event.",
            Sample = @"",
            Fields = null
        }

        _fileName = new HL7V25Field
        {
            field = message[@"EQP"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileName.field.FieldRepetitions != null && _fileName.field.FieldRepetitions.Count > 0)
        {
            _fileName.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_fileName, fieldData);
        }

        return _fileName;
    } 
}

internal HL7V25Field _startDateTime;

public HL7V25Field StartDateTime
{
    get
    {
        if (_startDateTime != null)
        {
            return _startDateTime;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field is the date/time that the event started.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EQP.3.1",
                            Type = @"Component",
                            Position = @"EQP.3.1",
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
                            Id = @"EQP.3.2",
                            Type = @"Component",
                            Position = @"EQP.3.2",
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
                        },
                        }
        }

        _startDateTime = new HL7V25Field
        {
            field = message[@"EQP"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startDateTime.field.FieldRepetitions != null && _startDateTime.field.FieldRepetitions.Count > 0)
        {
            _startDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_startDateTime, fieldData);
        }

        return _startDateTime;
    } 
}

internal HL7V25Field _endDateTime;

public HL7V25Field EndDateTime
{
    get
    {
        if (_endDateTime != null)
        {
            return _endDateTime;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field is the date/time that the event was completed.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EQP.4.1",
                            Type = @"Component",
                            Position = @"EQP.4.1",
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
                            Id = @"EQP.4.2",
                            Type = @"Component",
                            Position = @"EQP.4.2",
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
                        },
                        }
        }

        _endDateTime = new HL7V25Field
        {
            field = message[@"EQP"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_endDateTime.field.FieldRepetitions != null && _endDateTime.field.FieldRepetitions.Count > 0)
        {
            _endDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_endDateTime, fieldData);
        }

        return _endDateTime;
    } 
}

internal HL7V25Field _transactionData;

public HL7V25Field TransactionData
{
    get
    {
        if (_transactionData != null)
        {
            return _transactionData;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field is the data that the log and/or service event was about and is to be logged.",
            Sample = @"",
            Fields = null
        }

        _transactionData = new HL7V25Field
        {
            field = message[@"EQP"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionData.field.FieldRepetitions != null && _transactionData.field.FieldRepetitions.Count > 0)
        {
            _transactionData.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_transactionData, fieldData);
        }

        return _transactionData;
    } 
}
    }
}
