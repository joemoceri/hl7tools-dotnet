using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentCNS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CNS"; } }

        public string SegmentId { get { return @"CNS"; } }
        
        public string LongName { get { return @"Clear Notification"; } }
        
        public string Description { get { return @"The clear equipment notification segment contains the data necessary to allow the receiving equipment to clear any associated notifications."; } }
        
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

        public HL7V26SegmentCNS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _startingNotificationReferenceNumber;

public HL7V26Field StartingNotificationReferenceNumber
{
    get
    {
        if (_startingNotificationReferenceNumber != null)
        {
            return _startingNotificationReferenceNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CNS.1",
            Type = @"Field",
            Position = @"CNS.1",
            Name = @"Starting Notification Reference Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the starting notification reference number that is to be cleared.",
            Sample = @"",
            Fields = null
        }

        _startingNotificationReferenceNumber = new HL7V26Field
        {
            field = message[@"CNS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startingNotificationReferenceNumber.field.FieldRepetitions != null && _startingNotificationReferenceNumber.field.FieldRepetitions.Count > 0)
        {
            _startingNotificationReferenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_startingNotificationReferenceNumber, fieldData);
        }

        return _startingNotificationReferenceNumber;
    } 
}

internal HL7V26Field _endingNotificationReferenceNumber;

public HL7V26Field EndingNotificationReferenceNumber
{
    get
    {
        if (_endingNotificationReferenceNumber != null)
        {
            return _endingNotificationReferenceNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CNS.2",
            Type = @"Field",
            Position = @"CNS.2",
            Name = @"Ending Notification Reference Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the ending notification reference number that is to be cleared. If empty, then only notification with Starting Notification Reference Number will be cleared.",
            Sample = @"",
            Fields = null
        }

        _endingNotificationReferenceNumber = new HL7V26Field
        {
            field = message[@"CNS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_endingNotificationReferenceNumber.field.FieldRepetitions != null && _endingNotificationReferenceNumber.field.FieldRepetitions.Count > 0)
        {
            _endingNotificationReferenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_endingNotificationReferenceNumber, fieldData);
        }

        return _endingNotificationReferenceNumber;
    } 
}

internal HL7V26Field _startingNotificationDateTime;

public HL7V26Field StartingNotificationDateTime
{
    get
    {
        if (_startingNotificationDateTime != null)
        {
            return _startingNotificationDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CNS.3",
            Type = @"Field",
            Position = @"CNS.3",
            Name = @"Starting Notification Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field is the starting date/time of the notifications to be cleared. If this field is empty but Ending Notification Date/Time is filled, then all notifications before Ending Notification Date/Time will be cleared.",
            Sample = @"",
            Fields = null
        }

        _startingNotificationDateTime = new HL7V26Field
        {
            field = message[@"CNS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startingNotificationDateTime.field.FieldRepetitions != null && _startingNotificationDateTime.field.FieldRepetitions.Count > 0)
        {
            _startingNotificationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_startingNotificationDateTime, fieldData);
        }

        return _startingNotificationDateTime;
    } 
}

internal HL7V26Field _endingNotificationDateTime;

public HL7V26Field EndingNotificationDateTime
{
    get
    {
        if (_endingNotificationDateTime != null)
        {
            return _endingNotificationDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CNS.4",
            Type = @"Field",
            Position = @"CNS.4",
            Name = @"Ending Notification Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field is the ending date/time of the notifications to be cleared. If this field is empty but Starting Notification Date/Time is filled, then all notifications after Starting Notification Date/Time will be cleared.",
            Sample = @"",
            Fields = null
        }

        _endingNotificationDateTime = new HL7V26Field
        {
            field = message[@"CNS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_endingNotificationDateTime.field.FieldRepetitions != null && _endingNotificationDateTime.field.FieldRepetitions.Count > 0)
        {
            _endingNotificationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_endingNotificationDateTime, fieldData);
        }

        return _endingNotificationDateTime;
    } 
}

internal HL7V26Field _startingNotificationCode;

public HL7V26Field StartingNotificationCode
{
    get
    {
        if (_startingNotificationCode != null)
        {
            return _startingNotificationCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CNS.5",
            Type = @"Field",
            Position = @"CNS.5",
            Name = @"Starting Notification Code",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the starting notification code that is to be cleared (see 13.4.7.4, ""NDS-4 Notification Code(CWE) 01401"").",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CNS.5.1",
                            Type = @"Component",
                            Position = @"CNS.5.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.2",
                            Type = @"Component",
                            Position = @"CNS.5.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.3",
                            Type = @"Component",
                            Position = @"CNS.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.4",
                            Type = @"Component",
                            Position = @"CNS.5.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.5",
                            Type = @"Component",
                            Position = @"CNS.5.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.6",
                            Type = @"Component",
                            Position = @"CNS.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.7",
                            Type = @"Component",
                            Position = @"CNS.5.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.8",
                            Type = @"Component",
                            Position = @"CNS.5.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.9",
                            Type = @"Component",
                            Position = @"CNS.5.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _startingNotificationCode = new HL7V26Field
        {
            field = message[@"CNS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startingNotificationCode.field.FieldRepetitions != null && _startingNotificationCode.field.FieldRepetitions.Count > 0)
        {
            _startingNotificationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_startingNotificationCode, fieldData);
        }

        return _startingNotificationCode;
    } 
}

internal HL7V26Field _endingNotificationCode;

public HL7V26Field EndingNotificationCode
{
    get
    {
        if (_endingNotificationCode != null)
        {
            return _endingNotificationCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"CNS.6",
            Type = @"Field",
            Position = @"CNS.6",
            Name = @"Ending Notification Code",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the ending notification code that is to be cleared (see 13.4.7.4, ""NDS-4 Notification Code(CWE) 01401""). If empty, then only notification with Starting Notification Code will be cleared.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CNS.6.1",
                            Type = @"Component",
                            Position = @"CNS.6.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.2",
                            Type = @"Component",
                            Position = @"CNS.6.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.3",
                            Type = @"Component",
                            Position = @"CNS.6.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.4",
                            Type = @"Component",
                            Position = @"CNS.6.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.5",
                            Type = @"Component",
                            Position = @"CNS.6.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.6",
                            Type = @"Component",
                            Position = @"CNS.6.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.7",
                            Type = @"Component",
                            Position = @"CNS.6.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.8",
                            Type = @"Component",
                            Position = @"CNS.6.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.9",
                            Type = @"Component",
                            Position = @"CNS.6.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _endingNotificationCode = new HL7V26Field
        {
            field = message[@"CNS"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_endingNotificationCode.field.FieldRepetitions != null && _endingNotificationCode.field.FieldRepetitions.Count > 0)
        {
            _endingNotificationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_endingNotificationCode, fieldData);
        }

        return _endingNotificationCode;
    } 
}
    }
}
