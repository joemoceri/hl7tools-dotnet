using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentPEO
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PEO"; } }

        public string SegmentId { get { return @"PEO"; } }
        
        public string LongName { get { return @"Product Experience Observation"; } }
        
        public string Description { get { return @"Details related to a particular clinical experience or event are embodied in the PEO segment.  This segment can be used to characterize an event which might be attributed to a product to which the patient was exposed.   Products with a possible causal relationship to the observed experience are described in the following PCR (possible causal relationship) segments.  The message format was designed to be robust and includes many optional elements which may not be required for a particular regulatory purpose but allow a complete representation of the drug experience if needed.

A PEX message can contain multiple PEO segments if the patient experienced more than one event but must contain at least one PEO segment. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V23SegmentPEO(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _eventIdentifiersUsed;

public HL7V23Field EventIdentifiersUsed
{
    get
    {
        if (_eventIdentifiersUsed != null)
        {
            return _eventIdentifiersUsed;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.1",
            Type = @"Field",
            Position = @"PEO.1",
            Name = @"Event Identifiers Used",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field may be used to transmit the event identifier used by other entities for this event.   The entry would typically contain a unique alphanumeric identifier assigned by an entity with the text component null or repeating the unique alphanumeric identifier followed by the organization’s identifier.  An event identifier might be GB1234^GB1234^PharmaGiant for example",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.1.1",
                            Type = @"Component",
                            Position = @"PEO.1.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.1.2",
                            Type = @"Component",
                            Position = @"PEO.1.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.1.3",
                            Type = @"Component",
                            Position = @"PEO.1.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.1.4",
                            Type = @"Component",
                            Position = @"PEO.1.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.1.5",
                            Type = @"Component",
                            Position = @"PEO.1.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.1.6",
                            Type = @"Component",
                            Position = @"PEO.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _eventIdentifiersUsed = new HL7V23Field
        {
            field = message[@"PEO"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventIdentifiersUsed.field.FieldRepetitions != null && _eventIdentifiersUsed.field.FieldRepetitions.Count > 0)
        {
            _eventIdentifiersUsed.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventIdentifiersUsed, fieldData);
        }

        return _eventIdentifiersUsed;
    } 
}

internal HL7V23Field _eventSymptomDiagnosisCode;

public HL7V23Field EventSymptomDiagnosisCode
{
    get
    {
        if (_eventSymptomDiagnosisCode != null)
        {
            return _eventSymptomDiagnosisCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.2",
            Type = @"Field",
            Position = @"PEO.2",
            Name = @"Event Symptom/Diagnosis Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the coded diagnosis or problem description which  best describes the event.  A text representation of the coded item should routinely be included.  MEDDRA and WHO-ART are examples of appropriate coding schemes, as are the patient and device codes included in the FDA Center for Devices and Radiologic Health’s coding manual for Form 3500A",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.2.1",
                            Type = @"Component",
                            Position = @"PEO.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2.2",
                            Type = @"Component",
                            Position = @"PEO.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2.3",
                            Type = @"Component",
                            Position = @"PEO.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2.4",
                            Type = @"Component",
                            Position = @"PEO.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2.5",
                            Type = @"Component",
                            Position = @"PEO.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2.6",
                            Type = @"Component",
                            Position = @"PEO.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _eventSymptomDiagnosisCode = new HL7V23Field
        {
            field = message[@"PEO"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventSymptomDiagnosisCode.field.FieldRepetitions != null && _eventSymptomDiagnosisCode.field.FieldRepetitions.Count > 0)
        {
            _eventSymptomDiagnosisCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventSymptomDiagnosisCode, fieldData);
        }

        return _eventSymptomDiagnosisCode;
    } 
}

internal HL7V23Field _eventOnsetDateTime;

public HL7V23Field EventOnsetDateTime
{
    get
    {
        if (_eventOnsetDateTime != null)
        {
            return _eventOnsetDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.3",
            Type = @"Field",
            Position = @"PEO.3",
            Name = @"Event Onset Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains a report or best estimate of the date/time of onset of the event  The date/time can be recorded to any level of precision it is known (hour, day, month, year).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.3.1",
                            Type = @"Component",
                            Position = @"PEO.3.1",
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

        _eventOnsetDateTime = new HL7V23Field
        {
            field = message[@"PEO"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventOnsetDateTime.field.FieldRepetitions != null && _eventOnsetDateTime.field.FieldRepetitions.Count > 0)
        {
            _eventOnsetDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventOnsetDateTime, fieldData);
        }

        return _eventOnsetDateTime;
    } 
}

internal HL7V23Field _eventExacerbationDateTime;

public HL7V23Field EventExacerbationDateTime
{
    get
    {
        if (_eventExacerbationDateTime != null)
        {
            return _eventExacerbationDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.4",
            Type = @"Field",
            Position = @"PEO.4",
            Name = @"Event Exacerbation Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the best estimate of the date/time the event was exacerbated",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.4.1",
                            Type = @"Component",
                            Position = @"PEO.4.1",
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

        _eventExacerbationDateTime = new HL7V23Field
        {
            field = message[@"PEO"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventExacerbationDateTime.field.FieldRepetitions != null && _eventExacerbationDateTime.field.FieldRepetitions.Count > 0)
        {
            _eventExacerbationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventExacerbationDateTime, fieldData);
        }

        return _eventExacerbationDateTime;
    } 
}

internal HL7V23Field _eventImprovedDateTime;

public HL7V23Field EventImprovedDateTime
{
    get
    {
        if (_eventImprovedDateTime != null)
        {
            return _eventImprovedDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.5",
            Type = @"Field",
            Position = @"PEO.5",
            Name = @"Event Improved Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the best estimate of the date/time the event improved",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.5.1",
                            Type = @"Component",
                            Position = @"PEO.5.1",
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

        _eventImprovedDateTime = new HL7V23Field
        {
            field = message[@"PEO"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventImprovedDateTime.field.FieldRepetitions != null && _eventImprovedDateTime.field.FieldRepetitions.Count > 0)
        {
            _eventImprovedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventImprovedDateTime, fieldData);
        }

        return _eventImprovedDateTime;
    } 
}

internal HL7V23Field _eventEndedDataTime;

public HL7V23Field EventEndedDataTime
{
    get
    {
        if (_eventEndedDataTime != null)
        {
            return _eventEndedDataTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.6",
            Type = @"Field",
            Position = @"PEO.6",
            Name = @"Event Ended Data/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the best estimate of the date/time the event resolved",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.6.1",
                            Type = @"Component",
                            Position = @"PEO.6.1",
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

        _eventEndedDataTime = new HL7V23Field
        {
            field = message[@"PEO"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventEndedDataTime.field.FieldRepetitions != null && _eventEndedDataTime.field.FieldRepetitions.Count > 0)
        {
            _eventEndedDataTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventEndedDataTime, fieldData);
        }

        return _eventEndedDataTime;
    } 
}

internal HL7V23Field _eventLocationOccurredAddress;

public HL7V23Field EventLocationOccurredAddress
{
    get
    {
        if (_eventLocationOccurredAddress != null)
        {
            return _eventLocationOccurredAddress;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.7",
            Type = @"Field",
            Position = @"PEO.7",
            Name = @"Event Location Occurred Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the location at which the event started. Often this will specify only the country in which the event started",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.7.1",
                            Type = @"Component",
                            Position = @"PEO.7.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.2",
                            Type = @"Component",
                            Position = @"PEO.7.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address.  In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.3",
                            Type = @"Component",
                            Position = @"PEO.7.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.4",
                            Type = @"Component",
                            Position = @"PEO.7.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"tate or province should be represented by the official postal service codes for that country",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.5",
                            Type = @"Component",
                            Position = @"PEO.7.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.6",
                            Type = @"Component",
                            Position = @"PEO.7.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address.  ISO 3166 provides a list of country codes that may be used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.7",
                            Type = @"Component",
                            Position = @"PEO.7.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.8",
                            Type = @"Component",
                            Position = @"PEO.7.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes country, bioregion, SMSA, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.9",
                            Type = @"Component",
                            Position = @"PEO.7.9",
                            Name = @"County/parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. Refer to user-defined table 0289 - County/parish.  When this component is used to represent the county (or parish), component 8 “other geographic designation” should not duplicate it (i.e., the use of “other geographic designation” to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).

Allowable values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.10",
                            Type = @"Component",
                            Position = @"PEO.7.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census track in which the specified address resides. Refer to user-defined table 0288 - Census tract. 
Allowable Values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _eventLocationOccurredAddress = new HL7V23Field
        {
            field = message[@"PEO"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventLocationOccurredAddress.field.FieldRepetitions != null && _eventLocationOccurredAddress.field.FieldRepetitions.Count > 0)
        {
            _eventLocationOccurredAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventLocationOccurredAddress, fieldData);
        }

        return _eventLocationOccurredAddress;
    } 
}

internal HL7V23Field _eventQualification;

public HL7V23Field EventQualification
{
    get
    {
        if (_eventQualification != null)
        {
            return _eventQualification;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.8",
            Type = @"Field",
            Position = @"PEO.8",
            Name = @"Event Qualification",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0237",
            TableName = @"Event qualification",
            Description = @"This field is contains a classification of the type of product experience this event is considered to represent.  Refer to HL7 table 0237 - Event qualification for valid values",
            Sample = @"",
            Fields = null
        }

        _eventQualification = new HL7V23Field
        {
            field = message[@"PEO"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventQualification.field.FieldRepetitions != null && _eventQualification.field.FieldRepetitions.Count > 0)
        {
            _eventQualification.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventQualification, fieldData);
        }

        return _eventQualification;
    } 
}

internal HL7V23Field _eventSerious;

public HL7V23Field EventSerious
{
    get
    {
        if (_eventSerious != null)
        {
            return _eventSerious;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.9",
            Type = @"Field",
            Position = @"PEO.9",
            Name = @"Event Serious",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0238",
            TableName = @"Event seriousness",
            Description = @"This field indicates whether the event was judged as serious.  If the event did not meet the criteria for seriousness but the sender judges the event significant on other grounds, the event can be identified as significant [but not serious].  Refer to HL7 table 0238 - Event seriousness for valid values",
            Sample = @"",
            Fields = null
        }

        _eventSerious = new HL7V23Field
        {
            field = message[@"PEO"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventSerious.field.FieldRepetitions != null && _eventSerious.field.FieldRepetitions.Count > 0)
        {
            _eventSerious.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventSerious, fieldData);
        }

        return _eventSerious;
    } 
}

internal HL7V23Field _eventExpected;

public HL7V23Field EventExpected
{
    get
    {
        if (_eventExpected != null)
        {
            return _eventExpected;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.10",
            Type = @"Field",
            Position = @"PEO.10",
            Name = @"Event Expected",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0239",
            TableName = @"Event expected",
            Description = @"This field indicates whether the observed event was expected or unexpected as judged.  Refer to HL7 table 0239 - Event expected for valid values",
            Sample = @"",
            Fields = null
        }

        _eventExpected = new HL7V23Field
        {
            field = message[@"PEO"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventExpected.field.FieldRepetitions != null && _eventExpected.field.FieldRepetitions.Count > 0)
        {
            _eventExpected.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventExpected, fieldData);
        }

        return _eventExpected;
    } 
}

internal HL7V23Field _eventOutcome;

public HL7V23Field EventOutcome
{
    get
    {
        if (_eventOutcome != null)
        {
            return _eventOutcome;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.11",
            Type = @"Field",
            Position = @"PEO.11",
            Name = @"Event Outcome",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0240",
            TableName = @"Event consequence",
            Description = @"This field identifies the consequence of the event on the patient.  If the consequence of the event is not understood or not available, the patient outcome element may be used although neither is required.  May be repeated if more than one is appropriate.  Refer to HL7 table 0240 - Event consequences for valid values",
            Sample = @"",
            Fields = null
        }

        _eventOutcome = new HL7V23Field
        {
            field = message[@"PEO"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventOutcome.field.FieldRepetitions != null && _eventOutcome.field.FieldRepetitions.Count > 0)
        {
            _eventOutcome.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventOutcome, fieldData);
        }

        return _eventOutcome;
    } 
}

internal HL7V23Field _patientOutcome;

public HL7V23Field PatientOutcome
{
    get
    {
        if (_patientOutcome != null)
        {
            return _patientOutcome;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.12",
            Type = @"Field",
            Position = @"PEO.12",
            Name = @"Patient Outcome",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0241",
            TableName = @"Patient outcome",
            Description = @"When an event specific outcome is not available, the patient outcome element may be used to represent the patient’s overall outcome if that information is known.  Refer to HL7 table 0241 - Patient outcome for valid values. ",
            Sample = @"",
            Fields = null
        }

        _patientOutcome = new HL7V23Field
        {
            field = message[@"PEO"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientOutcome.field.FieldRepetitions != null && _patientOutcome.field.FieldRepetitions.Count > 0)
        {
            _patientOutcome.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientOutcome, fieldData);
        }

        return _patientOutcome;
    } 
}

internal HL7V23Field _eventDescriptionFromOthers;

public HL7V23Field EventDescriptionFromOthers
{
    get
    {
        if (_eventDescriptionFromOthers != null)
        {
            return _eventDescriptionFromOthers;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.13",
            Type = @"Field",
            Position = @"PEO.13",
            Name = @"Event Description From Others",
            Length = 600,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a summary narrative text description of the event that occurred written by the sender.  Note that laboratory results can be encoded as OBX segments rather then including them in the narrative.  By representing clinical information in OBX segments rather than in the narrative, these data become much more useful and flexible",
            Sample = @"",
            Fields = null
        }

        _eventDescriptionFromOthers = new HL7V23Field
        {
            field = message[@"PEO"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventDescriptionFromOthers.field.FieldRepetitions != null && _eventDescriptionFromOthers.field.FieldRepetitions.Count > 0)
        {
            _eventDescriptionFromOthers.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventDescriptionFromOthers, fieldData);
        }

        return _eventDescriptionFromOthers;
    } 
}

internal HL7V23Field _eventFromOriginalReporter;

public HL7V23Field EventFromOriginalReporter
{
    get
    {
        if (_eventFromOriginalReporter != null)
        {
            return _eventFromOriginalReporter;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.14",
            Type = @"Field",
            Position = @"PEO.14",
            Name = @"Event From Original Reporter",
            Length = 600,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a summary narrative text description of the event provided by the original reporter.  Note that laboratory results can be encoded as OBX segments rather then including them in the narrative",
            Sample = @"",
            Fields = null
        }

        _eventFromOriginalReporter = new HL7V23Field
        {
            field = message[@"PEO"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventFromOriginalReporter.field.FieldRepetitions != null && _eventFromOriginalReporter.field.FieldRepetitions.Count > 0)
        {
            _eventFromOriginalReporter.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventFromOriginalReporter, fieldData);
        }

        return _eventFromOriginalReporter;
    } 
}

internal HL7V23Field _eventDescriptionFromPatient;

public HL7V23Field EventDescriptionFromPatient
{
    get
    {
        if (_eventDescriptionFromPatient != null)
        {
            return _eventDescriptionFromPatient;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.15",
            Type = @"Field",
            Position = @"PEO.15",
            Name = @"Event Description From Patient",
            Length = 600,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a summary narrative text description of the event obtained directly from the patient.  Note that laboratory results can be encoded as OBX segments rather then including them in the narrative, which will allow the data to be more readily represented and manipulated",
            Sample = @"",
            Fields = null
        }

        _eventDescriptionFromPatient = new HL7V23Field
        {
            field = message[@"PEO"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventDescriptionFromPatient.field.FieldRepetitions != null && _eventDescriptionFromPatient.field.FieldRepetitions.Count > 0)
        {
            _eventDescriptionFromPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventDescriptionFromPatient, fieldData);
        }

        return _eventDescriptionFromPatient;
    } 
}

internal HL7V23Field _eventDescriptionFromPractitioner;

public HL7V23Field EventDescriptionFromPractitioner
{
    get
    {
        if (_eventDescriptionFromPractitioner != null)
        {
            return _eventDescriptionFromPractitioner;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.16",
            Type = @"Field",
            Position = @"PEO.16",
            Name = @"Event Description From Practitioner",
            Length = 600,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a summary narrative text description of the event provided by the practitioner most familiar with the event.  Note that laboratory results can be encoded as OBX segments rather then including them in the narrative",
            Sample = @"",
            Fields = null
        }

        _eventDescriptionFromPractitioner = new HL7V23Field
        {
            field = message[@"PEO"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventDescriptionFromPractitioner.field.FieldRepetitions != null && _eventDescriptionFromPractitioner.field.FieldRepetitions.Count > 0)
        {
            _eventDescriptionFromPractitioner.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventDescriptionFromPractitioner, fieldData);
        }

        return _eventDescriptionFromPractitioner;
    } 
}

internal HL7V23Field _eventDescriptionFromAutopsy;

public HL7V23Field EventDescriptionFromAutopsy
{
    get
    {
        if (_eventDescriptionFromAutopsy != null)
        {
            return _eventDescriptionFromAutopsy;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.17",
            Type = @"Field",
            Position = @"PEO.17",
            Name = @"Event Description From Autopsy",
            Length = 600,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a summary narrative text description of the autopsy results.  Note that laboratory results can be encoded as OBX segments rather then including them in the narrative",
            Sample = @"",
            Fields = null
        }

        _eventDescriptionFromAutopsy = new HL7V23Field
        {
            field = message[@"PEO"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventDescriptionFromAutopsy.field.FieldRepetitions != null && _eventDescriptionFromAutopsy.field.FieldRepetitions.Count > 0)
        {
            _eventDescriptionFromAutopsy.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventDescriptionFromAutopsy, fieldData);
        }

        return _eventDescriptionFromAutopsy;
    } 
}

internal HL7V23Field _causeOfDeath;

public HL7V23Field CauseOfDeath
{
    get
    {
        if (_causeOfDeath != null)
        {
            return _causeOfDeath;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.18",
            Type = @"Field",
            Position = @"PEO.18",
            Name = @"Cause Of Death",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the coded cause of death.  May be repeated as necessary to list multiple contributing causes.  A text description can be included by including text but no code or coding system.  For example, if the cause of death is to be determined at autopsy but results are not yet available, the cause of death element could be ^Pending autopsy^.  The date/time of death can be sent in the PID and the autopsy results sent in the event description from autopsy element of the PEO segment",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.18.1",
                            Type = @"Component",
                            Position = @"PEO.18.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18.2",
                            Type = @"Component",
                            Position = @"PEO.18.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18.3",
                            Type = @"Component",
                            Position = @"PEO.18.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18.4",
                            Type = @"Component",
                            Position = @"PEO.18.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18.5",
                            Type = @"Component",
                            Position = @"PEO.18.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18.6",
                            Type = @"Component",
                            Position = @"PEO.18.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _causeOfDeath = new HL7V23Field
        {
            field = message[@"PEO"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_causeOfDeath.field.FieldRepetitions != null && _causeOfDeath.field.FieldRepetitions.Count > 0)
        {
            _causeOfDeath.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_causeOfDeath, fieldData);
        }

        return _causeOfDeath;
    } 
}

internal HL7V23Field _primaryObserverName;

public HL7V23Field PrimaryObserverName
{
    get
    {
        if (_primaryObserverName != null)
        {
            return _primaryObserverName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.19",
            Type = @"Field",
            Position = @"PEO.19",
            Name = @"Primary Observer Name",
            Length = 46,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the name of the person who initially described the event",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.19.1",
                            Type = @"Component",
                            Position = @"PEO.19.1",
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
                            Id = @"PEO.19.2",
                            Type = @"Component",
                            Position = @"PEO.19.2",
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
                            Id = @"PEO.19.3",
                            Type = @"Component",
                            Position = @"PEO.19.3",
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
                            Id = @"PEO.19.4",
                            Type = @"Component",
                            Position = @"PEO.19.4",
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
                            Id = @"PEO.19.5",
                            Type = @"Component",
                            Position = @"PEO.19.5",
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
                            Id = @"PEO.19.6",
                            Type = @"Component",
                            Position = @"PEO.19.6",
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
                            Id = @"PEO.19.7",
                            Type = @"Component",
                            Position = @"PEO.19.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19.8",
                            Type = @"Component",
                            Position = @"PEO.19.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _primaryObserverName = new HL7V23Field
        {
            field = message[@"PEO"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryObserverName.field.FieldRepetitions != null && _primaryObserverName.field.FieldRepetitions.Count > 0)
        {
            _primaryObserverName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_primaryObserverName, fieldData);
        }

        return _primaryObserverName;
    } 
}

internal HL7V23Field _primaryObserverAddress;

public HL7V23Field PrimaryObserverAddress
{
    get
    {
        if (_primaryObserverAddress != null)
        {
            return _primaryObserverAddress;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.20",
            Type = @"Field",
            Position = @"PEO.20",
            Name = @"Primary Observer Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the address of the person who initially described the event",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.20.1",
                            Type = @"Component",
                            Position = @"PEO.20.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.2",
                            Type = @"Component",
                            Position = @"PEO.20.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address.  In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.3",
                            Type = @"Component",
                            Position = @"PEO.20.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.4",
                            Type = @"Component",
                            Position = @"PEO.20.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"tate or province should be represented by the official postal service codes for that country",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.5",
                            Type = @"Component",
                            Position = @"PEO.20.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.6",
                            Type = @"Component",
                            Position = @"PEO.20.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address.  ISO 3166 provides a list of country codes that may be used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.7",
                            Type = @"Component",
                            Position = @"PEO.20.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.8",
                            Type = @"Component",
                            Position = @"PEO.20.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes country, bioregion, SMSA, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.9",
                            Type = @"Component",
                            Position = @"PEO.20.9",
                            Name = @"County/parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. Refer to user-defined table 0289 - County/parish.  When this component is used to represent the county (or parish), component 8 “other geographic designation” should not duplicate it (i.e., the use of “other geographic designation” to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).

Allowable values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.10",
                            Type = @"Component",
                            Position = @"PEO.20.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census track in which the specified address resides. Refer to user-defined table 0288 - Census tract. 
Allowable Values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _primaryObserverAddress = new HL7V23Field
        {
            field = message[@"PEO"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryObserverAddress.field.FieldRepetitions != null && _primaryObserverAddress.field.FieldRepetitions.Count > 0)
        {
            _primaryObserverAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_primaryObserverAddress, fieldData);
        }

        return _primaryObserverAddress;
    } 
}

internal HL7V23Field _primaryObserverTelephone;

public HL7V23Field PrimaryObserverTelephone
{
    get
    {
        if (_primaryObserverTelephone != null)
        {
            return _primaryObserverTelephone;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.21",
            Type = @"Field",
            Position = @"PEO.21",
            Name = @"Primary Observer Telephone",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the telephone number of the person who initially described the event",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.21.1",
                            Type = @"Component",
                            Position = @"PEO.21.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.2",
                            Type = @"Component",
                            Position = @"PEO.21.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.3",
                            Type = @"Component",
                            Position = @"PEO.21.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.4",
                            Type = @"Component",
                            Position = @"PEO.21.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.5",
                            Type = @"Component",
                            Position = @"PEO.21.5",
                            Name = @"Country Code",
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
                            Id = @"PEO.21.6",
                            Type = @"Component",
                            Position = @"PEO.21.6",
                            Name = @"Area/city Code",
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
                            Id = @"PEO.21.7",
                            Type = @"Component",
                            Position = @"PEO.21.7",
                            Name = @"Phone Number",
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
                            Id = @"PEO.21.8",
                            Type = @"Component",
                            Position = @"PEO.21.8",
                            Name = @"Extension",
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
                            Id = @"PEO.21.9",
                            Type = @"Component",
                            Position = @"PEO.21.9",
                            Name = @"Any Text",
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

        _primaryObserverTelephone = new HL7V23Field
        {
            field = message[@"PEO"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryObserverTelephone.field.FieldRepetitions != null && _primaryObserverTelephone.field.FieldRepetitions.Count > 0)
        {
            _primaryObserverTelephone.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_primaryObserverTelephone, fieldData);
        }

        return _primaryObserverTelephone;
    } 
}

internal HL7V23Field _primaryObserversQualification;

public HL7V23Field PrimaryObserversQualification
{
    get
    {
        if (_primaryObserversQualification != null)
        {
            return _primaryObserversQualification;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.22",
            Type = @"Field",
            Position = @"PEO.22",
            Name = @"Primary Observer s Qualification",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0242",
            TableName = @"Primary observer’s qualification",
            Description = @"This field contains the qualification of the primary observer which may assist in assessing the validity of the observations.  Refer to HL7 table 0242 - Primary observer’s qualification for valid values",
            Sample = @"",
            Fields = null
        }

        _primaryObserversQualification = new HL7V23Field
        {
            field = message[@"PEO"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryObserversQualification.field.FieldRepetitions != null && _primaryObserversQualification.field.FieldRepetitions.Count > 0)
        {
            _primaryObserversQualification.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_primaryObserversQualification, fieldData);
        }

        return _primaryObserversQualification;
    } 
}

internal HL7V23Field _confirmationProvidedBy;

public HL7V23Field ConfirmationProvidedBy
{
    get
    {
        if (_confirmationProvidedBy != null)
        {
            return _confirmationProvidedBy;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.23",
            Type = @"Field",
            Position = @"PEO.23",
            Name = @"Confirmation Provided By",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0242",
            TableName = @"Primary observer’s qualification",
            Description = @"This field contains the qualification of the health professional who confirmed the observation if the primary observer was not a health professional.  Refer to HL7 table 0242 - Primary observer’s qualification for valid values",
            Sample = @"",
            Fields = null
        }

        _confirmationProvidedBy = new HL7V23Field
        {
            field = message[@"PEO"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_confirmationProvidedBy.field.FieldRepetitions != null && _confirmationProvidedBy.field.FieldRepetitions.Count > 0)
        {
            _confirmationProvidedBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_confirmationProvidedBy, fieldData);
        }

        return _confirmationProvidedBy;
    } 
}

internal HL7V23Field _primaryObserverAwareDateTime;

public HL7V23Field PrimaryObserverAwareDateTime
{
    get
    {
        if (_primaryObserverAwareDateTime != null)
        {
            return _primaryObserverAwareDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.24",
            Type = @"Field",
            Position = @"PEO.24",
            Name = @"Primary Observer Aware Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the date/time the primary observer became aware of event",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.24.1",
                            Type = @"Component",
                            Position = @"PEO.24.1",
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

        _primaryObserverAwareDateTime = new HL7V23Field
        {
            field = message[@"PEO"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryObserverAwareDateTime.field.FieldRepetitions != null && _primaryObserverAwareDateTime.field.FieldRepetitions.Count > 0)
        {
            _primaryObserverAwareDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_primaryObserverAwareDateTime, fieldData);
        }

        return _primaryObserverAwareDateTime;
    } 
}

internal HL7V23Field _primaryObserversIdentityMayBeDivulged;

public HL7V23Field PrimaryObserversIdentityMayBeDivulged
{
    get
    {
        if (_primaryObserversIdentityMayBeDivulged != null)
        {
            return _primaryObserversIdentityMayBeDivulged;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PEO.25",
            Type = @"Field",
            Position = @"PEO.25",
            Name = @"Primary Observer s Identity May Be Divulged",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0243",
            TableName = @"Identity may be divulged",
            Description = @"Indicates whether or not the primary observer, if known to the sender, grants permission to disclose his or her identity to the product manufacturer for the purpose of further investigating the event.  If the element is absent, the assumption should be made that permission is not granted.  Refer to HL7 table 0243 - Identity may be divulged for valid values",
            Sample = @"",
            Fields = null
        }

        _primaryObserversIdentityMayBeDivulged = new HL7V23Field
        {
            field = message[@"PEO"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryObserversIdentityMayBeDivulged.field.FieldRepetitions != null && _primaryObserversIdentityMayBeDivulged.field.FieldRepetitions.Count > 0)
        {
            _primaryObserversIdentityMayBeDivulged.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_primaryObserversIdentityMayBeDivulged, fieldData);
        }

        return _primaryObserversIdentityMayBeDivulged;
    } 
}
    }
}
