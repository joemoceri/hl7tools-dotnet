using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentOM1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM1"; } }

        public string SegmentId { get { return @"OM1"; } }
        
        public string LongName { get { return @"General segment"; } }
        
        public string Description { get { return @"The OM1 segment contains the attributes that apply to the definition of most observations. This segment also contains the field attributes that specify what additional segments might also be defined for this observation."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V231SegmentOM1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _sequenceNumberTestObservationMasterFile;

public HL7V231Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (_sequenceNumberTestObservationMasterFile != null)
        {
            return _sequenceNumberTestObservationMasterFile;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.1",
            Type = @"Field",
            Position = @"OM1.1",
            Name = @"Sequence Number - Test/Observation Master File",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the first OM1 segment in a message and is described as 1, the second as 2, and so on.",
            Sample = @"",
            Fields = null
        }

        _sequenceNumberTestObservationMasterFile = new HL7V231Field
        {
            field = message[@"OM1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumberTestObservationMasterFile.field.FieldRepetitions != null && _sequenceNumberTestObservationMasterFile.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumberTestObservationMasterFile.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_sequenceNumberTestObservationMasterFile, fieldData);
        }

        return _sequenceNumberTestObservationMasterFile;
    } 
}

internal HL7V231Field _producersTestObservationID;

public HL7V231Field ProducersTestObservationID
{
    get
    {
        if (_producersTestObservationID != null)
        {
            return _producersTestObservationID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.2",
            Type = @"Field",
            Position = @"OM1.2",
            Name = @"Producer's Test/Observation ID",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the producer's usual or preferred identification of the test or observation. Only three components should be included: <ID code>^<service text name/description>^<source list of code>. All components should be non-null. The source list may be any of those included in ASTM Tables 3 and 5, or a local code.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.2.1",
                            Type = @"Component",
                            Position = @"OM1.2.1",
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
                            Id = @"OM1.2.2",
                            Type = @"Component",
                            Position = @"OM1.2.2",
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
                            Id = @"OM1.2.3",
                            Type = @"Component",
                            Position = @"OM1.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.2.4",
                            Type = @"Component",
                            Position = @"OM1.2.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.2.5",
                            Type = @"Component",
                            Position = @"OM1.2.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.2.6",
                            Type = @"Component",
                            Position = @"OM1.2.6",
                            Name = @"Name Of Alternate Coding System",
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

        _producersTestObservationID = new HL7V231Field
        {
            field = message[@"OM1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_producersTestObservationID.field.FieldRepetitions != null && _producersTestObservationID.field.FieldRepetitions.Count > 0)
        {
            _producersTestObservationID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_producersTestObservationID, fieldData);
        }

        return _producersTestObservationID;
    } 
}

internal HL7V231Field _permittedDataTypes;

public HL7V231Field PermittedDataTypes
{
    get
    {
        if (_permittedDataTypes != null)
        {
            return _permittedDataTypes;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.3",
            Type = @"Field",
            Position = @"OM1.3",
            Name = @"Permitted Data Types",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0125",
            TableName = @"Value type",
            Description = @"This field contains the allowed data type(s) for this observation. The codes are the same as those listed for OBX (a given observation may, under different circumstances, take on different data types). Indeed, under limited circumstances, an observation can consist of one or more fragments of different data types. When an observation may have more than one data type, e.g., coded (CE) and numeric (NM) the allowable data types should be separated by repeat delimiters. Refer to HL7 table 0125 - Value type for valid values.",
            Sample = @"",
            Fields = null
        }

        _permittedDataTypes = new HL7V231Field
        {
            field = message[@"OM1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_permittedDataTypes.field.FieldRepetitions != null && _permittedDataTypes.field.FieldRepetitions.Count > 0)
        {
            _permittedDataTypes.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_permittedDataTypes, fieldData);
        }

        return _permittedDataTypes;
    } 
}

internal HL7V231Field _specimenRequired;

public HL7V231Field SpecimenRequired
{
    get
    {
        if (_specimenRequired != null)
        {
            return _specimenRequired;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.4",
            Type = @"Field",
            Position = @"OM1.4",
            Name = @"Specimen Required",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains a flag indicating whether or not at least one specimen is required for the test/observation. Refer to HL7 table 0136 - Yes/no indicator as defined in Chapter 2.",
            Sample = @"",
            Fields = null
        }

        _specimenRequired = new HL7V231Field
        {
            field = message[@"OM1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenRequired.field.FieldRepetitions != null && _specimenRequired.field.FieldRepetitions.Count > 0)
        {
            _specimenRequired.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_specimenRequired, fieldData);
        }

        return _specimenRequired;
    } 
}

internal HL7V231Field _producerID;

public HL7V231Field ProducerID
{
    get
    {
        if (_producerID != null)
        {
            return _producerID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.5",
            Type = @"Field",
            Position = @"OM1.5",
            Name = @"Producer ID",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the service producing the observation described in this segment. Three components should be included: an identifying code, the name of the producer, and the identity of the coding system (e.g., 323-5678^Acme Special Lab^MC). The identity of the coding system will usually be MC (Medicare provider number or HIBCC site codes) in the United States. Each country may want to specify its preferred coding system and define a coding system ID to identify it.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.5.1",
                            Type = @"Component",
                            Position = @"OM1.5.1",
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
                            Id = @"OM1.5.2",
                            Type = @"Component",
                            Position = @"OM1.5.2",
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
                            Id = @"OM1.5.3",
                            Type = @"Component",
                            Position = @"OM1.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.5.4",
                            Type = @"Component",
                            Position = @"OM1.5.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.5.5",
                            Type = @"Component",
                            Position = @"OM1.5.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.5.6",
                            Type = @"Component",
                            Position = @"OM1.5.6",
                            Name = @"Name Of Alternate Coding System",
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

        _producerID = new HL7V231Field
        {
            field = message[@"OM1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_producerID.field.FieldRepetitions != null && _producerID.field.FieldRepetitions.Count > 0)
        {
            _producerID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_producerID, fieldData);
        }

        return _producerID;
    } 
}

internal HL7V231Field _observationDescription;

public HL7V231Field ObservationDescription
{
    get
    {
        if (_observationDescription != null)
        {
            return _observationDescription;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.6",
            Type = @"Field",
            Position = @"OM1.6",
            Name = @"Observation Description",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a text description of this observation.",
            Sample = @"",
            Fields = null
        }

        _observationDescription = new HL7V231Field
        {
            field = message[@"OM1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationDescription.field.FieldRepetitions != null && _observationDescription.field.FieldRepetitions.Count > 0)
        {
            _observationDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_observationDescription, fieldData);
        }

        return _observationDescription;
    } 
}

internal HL7V231Field _otherTestObservationIDsfortheObservation;

public HL7V231Field OtherTestObservationIDsfortheObservation
{
    get
    {
        if (_otherTestObservationIDsfortheObservation != null)
        {
            return _otherTestObservationIDsfortheObservation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.7",
            Type = @"Field",
            Position = @"OM1.7",
            Name = @"Other Test/Observation IDs for the Observation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains all alias codes/identifiers for this observation. If more than one alias code needs to be specified, multiple three-component, CE-format entries (<code 1>^<name 1>^<code system 1>) may be given, separated by repeat delimiters. An observation may have as many names/codes as are applicable (e.g., ICD9, ACR-NEMA, SNOMED, and READ). We encourage the inclusion of as many different codes as may apply to assist cross-system mapping of terminology. All components of each triplet should be non-null (that is, names and coding system IDs within the CE data type are required in addition to codes). The source list may be any of those included in ASTM Tables 3 and 5.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.7.1",
                            Type = @"Component",
                            Position = @"OM1.7.1",
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
                            Id = @"OM1.7.2",
                            Type = @"Component",
                            Position = @"OM1.7.2",
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
                            Id = @"OM1.7.3",
                            Type = @"Component",
                            Position = @"OM1.7.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.7.4",
                            Type = @"Component",
                            Position = @"OM1.7.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.7.5",
                            Type = @"Component",
                            Position = @"OM1.7.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.7.6",
                            Type = @"Component",
                            Position = @"OM1.7.6",
                            Name = @"Name Of Alternate Coding System",
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

        _otherTestObservationIDsfortheObservation = new HL7V231Field
        {
            field = message[@"OM1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_otherTestObservationIDsfortheObservation.field.FieldRepetitions != null && _otherTestObservationIDsfortheObservation.field.FieldRepetitions.Count > 0)
        {
            _otherTestObservationIDsfortheObservation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_otherTestObservationIDsfortheObservation, fieldData);
        }

        return _otherTestObservationIDsfortheObservation;
    } 
}

internal HL7V231Field _otherNames;

public HL7V231Field OtherNames
{
    get
    {
        if (_otherNames != null)
        {
            return _otherNames;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.8",
            Type = @"Field",
            Position = @"OM1.8",
            Name = @"Other Names",
            Length = 200,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains any test aliases or synonyms for the name in the context of the ordering service. These are alternative names, not associated with a particular coding system, by which the battery, test, or observation (e.g., measurement, test, diagnostic study, treatment) is known to users of the system. Multiple names in this list are separated by repeat delimiters.",
            Sample = @"",
            Fields = null
        }

        _otherNames = new HL7V231Field
        {
            field = message[@"OM1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_otherNames.field.FieldRepetitions != null && _otherNames.field.FieldRepetitions.Count > 0)
        {
            _otherNames.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_otherNames, fieldData);
        }

        return _otherNames;
    } 
}

internal HL7V231Field _preferredReportNamefortheObservation;

public HL7V231Field PreferredReportNamefortheObservation
{
    get
    {
        if (_preferredReportNamefortheObservation != null)
        {
            return _preferredReportNamefortheObservation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.9",
            Type = @"Field",
            Position = @"OM1.9",
            Name = @"Preferred Report Name for the Observation",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the preferred name for reporting the observation or battery. The name can contain up to 30 characters (including blanks). It is the preferred name for columnar reports that require a maximum name size.",
            Sample = @"",
            Fields = null
        }

        _preferredReportNamefortheObservation = new HL7V231Field
        {
            field = message[@"OM1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preferredReportNamefortheObservation.field.FieldRepetitions != null && _preferredReportNamefortheObservation.field.FieldRepetitions.Count > 0)
        {
            _preferredReportNamefortheObservation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_preferredReportNamefortheObservation, fieldData);
        }

        return _preferredReportNamefortheObservation;
    } 
}

internal HL7V231Field _preferredShortNameorMnemonicforObservation;

public HL7V231Field PreferredShortNameorMnemonicforObservation
{
    get
    {
        if (_preferredShortNameorMnemonicforObservation != null)
        {
            return _preferredShortNameorMnemonicforObservation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.10",
            Type = @"Field",
            Position = @"OM1.10",
            Name = @"Preferred Short Name or Mnemonic for Observation",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name that can be used in space-limited reports (e.g., specimen labels) to identify the observation for the convenience of human readers. The name can contain up to eight characters.",
            Sample = @"",
            Fields = null
        }

        _preferredShortNameorMnemonicforObservation = new HL7V231Field
        {
            field = message[@"OM1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preferredShortNameorMnemonicforObservation.field.FieldRepetitions != null && _preferredShortNameorMnemonicforObservation.field.FieldRepetitions.Count > 0)
        {
            _preferredShortNameorMnemonicforObservation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_preferredShortNameorMnemonicforObservation, fieldData);
        }

        return _preferredShortNameorMnemonicforObservation;
    } 
}

internal HL7V231Field _preferredLongNamefortheObservation;

public HL7V231Field PreferredLongNamefortheObservation
{
    get
    {
        if (_preferredLongNamefortheObservation != null)
        {
            return _preferredLongNamefortheObservation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.11",
            Type = @"Field",
            Position = @"OM1.11",
            Name = @"Preferred Long Name for the Observation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the fully-specified name for the observation or battery. It may include the full (unabbreviated) multiple-word names and contain up to 200 characters. It should be as scientifically precise as possible.",
            Sample = @"",
            Fields = null
        }

        _preferredLongNamefortheObservation = new HL7V231Field
        {
            field = message[@"OM1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preferredLongNamefortheObservation.field.FieldRepetitions != null && _preferredLongNamefortheObservation.field.FieldRepetitions.Count > 0)
        {
            _preferredLongNamefortheObservation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_preferredLongNamefortheObservation, fieldData);
        }

        return _preferredLongNamefortheObservation;
    } 
}

internal HL7V231Field _orderability;

public HL7V231Field Orderability
{
    get
    {
        if (_orderability != null)
        {
            return _orderability;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.12",
            Type = @"Field",
            Position = @"OM1.12",
            Name = @"Orderability",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether or not a test/observation is an orderable code. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _orderability = new HL7V231Field
        {
            field = message[@"OM1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderability.field.FieldRepetitions != null && _orderability.field.FieldRepetitions.Count > 0)
        {
            _orderability.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_orderability, fieldData);
        }

        return _orderability;
    } 
}

internal HL7V231Field _identityofInstrumentUsedtoPerformthisStudy;

public HL7V231Field IdentityofInstrumentUsedtoPerformthisStudy
{
    get
    {
        if (_identityofInstrumentUsedtoPerformthisStudy != null)
        {
            return _identityofInstrumentUsedtoPerformthisStudy;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.13",
            Type = @"Field",
            Position = @"OM1.13",
            Name = @"Identity of Instrument Used to Perform this Study",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"When applicable, this field identifies the instrument or device that is used to generate this observation or battery. Examples are the automated instrument in the laboratory, the imaging device and model number in radiology, and the automatic blood pressure machine on the ward. The instrument is specified as a coded entry in anticipation that these identifiers could be specified as codes. Initially, we expect that most of the information about devices will be transmitted as text in the second component of the CE identifier. If more than one kind of instrument is used, all of them can be listed, separated by repeat delimiters.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.13.1",
                            Type = @"Component",
                            Position = @"OM1.13.1",
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
                            Id = @"OM1.13.2",
                            Type = @"Component",
                            Position = @"OM1.13.2",
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
                            Id = @"OM1.13.3",
                            Type = @"Component",
                            Position = @"OM1.13.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.13.4",
                            Type = @"Component",
                            Position = @"OM1.13.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.13.5",
                            Type = @"Component",
                            Position = @"OM1.13.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.13.6",
                            Type = @"Component",
                            Position = @"OM1.13.6",
                            Name = @"Name Of Alternate Coding System",
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

        _identityofInstrumentUsedtoPerformthisStudy = new HL7V231Field
        {
            field = message[@"OM1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_identityofInstrumentUsedtoPerformthisStudy.field.FieldRepetitions != null && _identityofInstrumentUsedtoPerformthisStudy.field.FieldRepetitions.Count > 0)
        {
            _identityofInstrumentUsedtoPerformthisStudy.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_identityofInstrumentUsedtoPerformthisStudy, fieldData);
        }

        return _identityofInstrumentUsedtoPerformthisStudy;
    } 
}

internal HL7V231Field _codedRepresentationofMethod;

public HL7V231Field CodedRepresentationofMethod
{
    get
    {
        if (_codedRepresentationofMethod != null)
        {
            return _codedRepresentationofMethod;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.14",
            Type = @"Field",
            Position = @"OM1.14",
            Name = @"Coded Representation of Method",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the method(s) used to produce the observation and should be recorded in a computer-understandable (coded) form here. This field should report the same method(s) reported in narrative in the following field. More than one method may be listed, but only if they produce results that are clinically indistinguishable. Multiple methods must be separated by repeat delimiters.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.14.1",
                            Type = @"Component",
                            Position = @"OM1.14.1",
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
                            Id = @"OM1.14.2",
                            Type = @"Component",
                            Position = @"OM1.14.2",
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
                            Id = @"OM1.14.3",
                            Type = @"Component",
                            Position = @"OM1.14.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.14.4",
                            Type = @"Component",
                            Position = @"OM1.14.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.14.5",
                            Type = @"Component",
                            Position = @"OM1.14.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.14.6",
                            Type = @"Component",
                            Position = @"OM1.14.6",
                            Name = @"Name Of Alternate Coding System",
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

        _codedRepresentationofMethod = new HL7V231Field
        {
            field = message[@"OM1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_codedRepresentationofMethod.field.FieldRepetitions != null && _codedRepresentationofMethod.field.FieldRepetitions.Count > 0)
        {
            _codedRepresentationofMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_codedRepresentationofMethod, fieldData);
        }

        return _codedRepresentationofMethod;
    } 
}

internal HL7V231Field _portable;

public HL7V231Field Portable
{
    get
    {
        if (_portable != null)
        {
            return _portable;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.15",
            Type = @"Field",
            Position = @"OM1.15",
            Name = @"Portable",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether or not a portable device may be used for the test/observation. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _portable = new HL7V231Field
        {
            field = message[@"OM1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_portable.field.FieldRepetitions != null && _portable.field.FieldRepetitions.Count > 0)
        {
            _portable.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_portable, fieldData);
        }

        return _portable;
    } 
}

internal HL7V231Field _observationProducingDepartmentSection;

public HL7V231Field ObservationProducingDepartmentSection
{
    get
    {
        if (_observationProducingDepartmentSection != null)
        {
            return _observationProducingDepartmentSection;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.16",
            Type = @"Field",
            Position = @"OM1.16",
            Name = @"Observation Producing Department/Section",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field permits the sorting of observation orders and values by the providing service's department/section. It provides 'source oriented' reporting when required. The codes for this field should be taken from ASTM Table 15 (Diagnostic Service Codes). Free text may be used instead of these codes, but in that case, they should be recorded as the second 'component' of the field to distinguish them from the standard codes. Multiple codes in this field are separated by repeat delimiters.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.16.1",
                            Type = @"Component",
                            Position = @"OM1.16.1",
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
                            Id = @"OM1.16.2",
                            Type = @"Component",
                            Position = @"OM1.16.2",
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
                            Id = @"OM1.16.3",
                            Type = @"Component",
                            Position = @"OM1.16.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.16.4",
                            Type = @"Component",
                            Position = @"OM1.16.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.16.5",
                            Type = @"Component",
                            Position = @"OM1.16.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.16.6",
                            Type = @"Component",
                            Position = @"OM1.16.6",
                            Name = @"Name Of Alternate Coding System",
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

        _observationProducingDepartmentSection = new HL7V231Field
        {
            field = message[@"OM1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationProducingDepartmentSection.field.FieldRepetitions != null && _observationProducingDepartmentSection.field.FieldRepetitions.Count > 0)
        {
            _observationProducingDepartmentSection.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_observationProducingDepartmentSection, fieldData);
        }

        return _observationProducingDepartmentSection;
    } 
}

internal HL7V231Field _telephoneNumberofSection;

public HL7V231Field TelephoneNumberofSection
{
    get
    {
        if (_telephoneNumberofSection != null)
        {
            return _telephoneNumberofSection;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.17",
            Type = @"Field",
            Position = @"OM1.17",
            Name = @"Telephone Number of Section",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number for calling responsible parties in this section to ask results or advice about the use of this test.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.17.1",
                            Type = @"Component",
                            Position = @"OM1.17.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type (see Section 2.8.42, TN - telephone number), except that the length of the country access code has been increased to three.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.2",
                            Type = @"Component",
                            Position = @"OM1.17.2",
                            Name = @"Telecommunication use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.3",
                            Type = @"Component",
                            Position = @"OM1.17.3",
                            Name = @"Telecommunication equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.4",
                            Type = @"Component",
                            Position = @"OM1.17.4",
                            Name = @"Email Address",
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
                            Id = @"OM1.17.5",
                            Type = @"Component",
                            Position = @"OM1.17.5",
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
                            Id = @"OM1.17.6",
                            Type = @"Component",
                            Position = @"OM1.17.6",
                            Name = @"Area/City Code",
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
                            Id = @"OM1.17.7",
                            Type = @"Component",
                            Position = @"OM1.17.7",
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
                            Id = @"OM1.17.8",
                            Type = @"Component",
                            Position = @"OM1.17.8",
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
                            Id = @"OM1.17.9",
                            Type = @"Component",
                            Position = @"OM1.17.9",
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

        _telephoneNumberofSection = new HL7V231Field
        {
            field = message[@"OM1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_telephoneNumberofSection.field.FieldRepetitions != null && _telephoneNumberofSection.field.FieldRepetitions.Count > 0)
        {
            _telephoneNumberofSection.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_telephoneNumberofSection, fieldData);
        }

        return _telephoneNumberofSection;
    } 
}

internal HL7V231Field _natureofTestObservation;

public HL7V231Field NatureofTestObservation
{
    get
    {
        if (_natureofTestObservation != null)
        {
            return _natureofTestObservation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.18",
            Type = @"Field",
            Position = @"OM1.18",
            Name = @"Nature of Test/Observation",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0174",
            TableName = @"Nature of test/observation",
            Description = @"This field indicates whether the definition entry identifies a test battery, an entire functional procedure or study, a single test value (observation), multiple test batteries or functional procedures as an orderable unit (profile), or a single test value (observation) calculated from other independent observations. Refer to user-defined table 0174 - Nature of test/observation for suggested values.",
            Sample = @"",
            Fields = null
        }

        _natureofTestObservation = new HL7V231Field
        {
            field = message[@"OM1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_natureofTestObservation.field.FieldRepetitions != null && _natureofTestObservation.field.FieldRepetitions.Count > 0)
        {
            _natureofTestObservation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_natureofTestObservation, fieldData);
        }

        return _natureofTestObservation;
    } 
}

internal HL7V231Field _reportSubheader;

public HL7V231Field ReportSubheader
{
    get
    {
        if (_reportSubheader != null)
        {
            return _reportSubheader;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.19",
            Type = @"Field",
            Position = @"OM1.19",
            Name = @"Report Subheader",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an optional string that defines the preferred header under which this observation should be listed on a standard display. For example, if the test is hemoglobin, this string might be 'Complete blood count.' It is represented as a coded data type so that a battery can be a header. Only the description part of the string may be included in case the subheader does not have an associated code. When a series of observations is displayed according to the sort order given below, the subheader that groups those observations is presented whenever the subheader changes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.19.1",
                            Type = @"Component",
                            Position = @"OM1.19.1",
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
                            Id = @"OM1.19.2",
                            Type = @"Component",
                            Position = @"OM1.19.2",
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
                            Id = @"OM1.19.3",
                            Type = @"Component",
                            Position = @"OM1.19.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.19.4",
                            Type = @"Component",
                            Position = @"OM1.19.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.19.5",
                            Type = @"Component",
                            Position = @"OM1.19.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.19.6",
                            Type = @"Component",
                            Position = @"OM1.19.6",
                            Name = @"Name Of Alternate Coding System",
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

        _reportSubheader = new HL7V231Field
        {
            field = message[@"OM1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportSubheader.field.FieldRepetitions != null && _reportSubheader.field.FieldRepetitions.Count > 0)
        {
            _reportSubheader.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_reportSubheader, fieldData);
        }

        return _reportSubheader;
    } 
}

internal HL7V231Field _reportDisplayOrder;

public HL7V231Field ReportDisplayOrder
{
    get
    {
        if (_reportDisplayOrder != null)
        {
            return _reportDisplayOrder;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.20",
            Type = @"Field",
            Position = @"OM1.20",
            Name = @"Report Display Order",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains an optional string that defines the sort order in which this observation is presented in a standard report or display that contains the many observations.",
            Sample = @"",
            Fields = null
        }

        _reportDisplayOrder = new HL7V231Field
        {
            field = message[@"OM1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportDisplayOrder.field.FieldRepetitions != null && _reportDisplayOrder.field.FieldRepetitions.Count > 0)
        {
            _reportDisplayOrder.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_reportDisplayOrder, fieldData);
        }

        return _reportDisplayOrder;
    } 
}

internal HL7V231Field _dateTimeStampforanychangeinDefinitionfortheObservation;

public HL7V231Field DateTimeStampforanychangeinDefinitionfortheObservation
{
    get
    {
        if (_dateTimeStampforanychangeinDefinitionfortheObservation != null)
        {
            return _dateTimeStampforanychangeinDefinitionfortheObservation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.21",
            Type = @"Field",
            Position = @"OM1.21",
            Name = @"Date/Time Stamp for any change in Definition for the Observation",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time that the last of any field change was made and in the host's record corresponding to the OM1 segment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.21.1",
                            Type = @"Component",
                            Position = @"OM1.21.1",
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

        _dateTimeStampforanychangeinDefinitionfortheObservation = new HL7V231Field
        {
            field = message[@"OM1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeStampforanychangeinDefinitionfortheObservation.field.FieldRepetitions != null && _dateTimeStampforanychangeinDefinitionfortheObservation.field.FieldRepetitions.Count > 0)
        {
            _dateTimeStampforanychangeinDefinitionfortheObservation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dateTimeStampforanychangeinDefinitionfortheObservation, fieldData);
        }

        return _dateTimeStampforanychangeinDefinitionfortheObservation;
    } 
}

internal HL7V231Field _effectiveDateTimeofChange;

public HL7V231Field EffectiveDateTimeofChange
{
    get
    {
        if (_effectiveDateTimeofChange != null)
        {
            return _effectiveDateTimeofChange;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.22",
            Type = @"Field",
            Position = @"OM1.22",
            Name = @"Effective Date/Time of Change",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time of the last change in the test procedure that would make previous results incompatible with new results, e.g., the last time that normal reference range or units changed for a numeric test/observation.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.22.1",
                            Type = @"Component",
                            Position = @"OM1.22.1",
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

        _effectiveDateTimeofChange = new HL7V231Field
        {
            field = message[@"OM1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_effectiveDateTimeofChange.field.FieldRepetitions != null && _effectiveDateTimeofChange.field.FieldRepetitions.Count > 0)
        {
            _effectiveDateTimeofChange.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_effectiveDateTimeofChange, fieldData);
        }

        return _effectiveDateTimeofChange;
    } 
}

internal HL7V231Field _typicalTurnAroundTime;

public HL7V231Field TypicalTurnAroundTime
{
    get
    {
        if (_typicalTurnAroundTime != null)
        {
            return _typicalTurnAroundTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.23",
            Type = @"Field",
            Position = @"OM1.23",
            Name = @"Typical Turn-Around Time",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the typical processing time for single test/observation. This field indicates the time from the delivery of a specimen or transport of a patient to a diagnostic service and the completion of the study. It includes the usual waiting time. The units are measured in minutes.",
            Sample = @"",
            Fields = null
        }

        _typicalTurnAroundTime = new HL7V231Field
        {
            field = message[@"OM1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_typicalTurnAroundTime.field.FieldRepetitions != null && _typicalTurnAroundTime.field.FieldRepetitions.Count > 0)
        {
            _typicalTurnAroundTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_typicalTurnAroundTime, fieldData);
        }

        return _typicalTurnAroundTime;
    } 
}

internal HL7V231Field _processingTime;

public HL7V231Field ProcessingTime
{
    get
    {
        if (_processingTime != null)
        {
            return _processingTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.24",
            Type = @"Field",
            Position = @"OM1.24",
            Name = @"Processing Time",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the usual length of time (in minutes) between the start of a test process and its completion.",
            Sample = @"",
            Fields = null
        }

        _processingTime = new HL7V231Field
        {
            field = message[@"OM1"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_processingTime.field.FieldRepetitions != null && _processingTime.field.FieldRepetitions.Count > 0)
        {
            _processingTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_processingTime, fieldData);
        }

        return _processingTime;
    } 
}

internal HL7V231Field _processingPriority;

public HL7V231Field ProcessingPriority
{
    get
    {
        if (_processingPriority != null)
        {
            return _processingPriority;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.25",
            Type = @"Field",
            Position = @"OM1.25",
            Name = @"Processing Priority",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0168",
            TableName = @"Processing priority",
            Description = @"This field contains one or more available priorities for performing the observation or test. This is the priority that can be placed in OBR-27-quantity/timing. For tests that require a specimen, this field may contain two components in the format <specimen priority>^<processing priority>. The first component in this case indicates the priority with which the specimen will be collected and is the priority that is specified in an OBR segment when ordering the observation. The second component indicates the corresponding priority with which the producer service will process the specimen, produce the observation, and return results, when this differs from collection priority. Refer to HL7 table 0168 - Processing priority for valid values.",
            Sample = @"",
            Fields = null
        }

        _processingPriority = new HL7V231Field
        {
            field = message[@"OM1"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_processingPriority.field.FieldRepetitions != null && _processingPriority.field.FieldRepetitions.Count > 0)
        {
            _processingPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_processingPriority, fieldData);
        }

        return _processingPriority;
    } 
}

internal HL7V231Field _reportingPriority;

public HL7V231Field ReportingPriority
{
    get
    {
        if (_reportingPriority != null)
        {
            return _reportingPriority;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.26",
            Type = @"Field",
            Position = @"OM1.26",
            Name = @"Reporting Priority",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0169",
            TableName = @"Reporting priority",
            Description = @"This field contains the available priorities reporting the test results when the user is asked to specify the reporting priority independent of the processing priority. Refer to HL7 table 0169 - Reporting priority for valid values.",
            Sample = @"",
            Fields = null
        }

        _reportingPriority = new HL7V231Field
        {
            field = message[@"OM1"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportingPriority.field.FieldRepetitions != null && _reportingPriority.field.FieldRepetitions.Count > 0)
        {
            _reportingPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_reportingPriority, fieldData);
        }

        return _reportingPriority;
    } 
}

internal HL7V231Field _outsideSite;

public HL7V231Field OutsideSite
{
    get
    {
        if (_outsideSite != null)
        {
            return _outsideSite;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.27",
            Type = @"Field",
            Position = @"OM1.27",
            Name = @"Outside Site",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identification(s) of the outside service(s) that produce(s) the observation. The format of this CE field uses the producer ID (as defined in OM1-5-producer ID) and the name of the service separated by component delimiters. An example is 39221^ACME lab^MC. If multiple services are used, they should be separated by repeat delimiter(s).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.27.1",
                            Type = @"Component",
                            Position = @"OM1.27.1",
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
                            Id = @"OM1.27.2",
                            Type = @"Component",
                            Position = @"OM1.27.2",
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
                            Id = @"OM1.27.3",
                            Type = @"Component",
                            Position = @"OM1.27.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.27.4",
                            Type = @"Component",
                            Position = @"OM1.27.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.27.5",
                            Type = @"Component",
                            Position = @"OM1.27.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.27.6",
                            Type = @"Component",
                            Position = @"OM1.27.6",
                            Name = @"Name Of Alternate Coding System",
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

        _outsideSite = new HL7V231Field
        {
            field = message[@"OM1"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outsideSite.field.FieldRepetitions != null && _outsideSite.field.FieldRepetitions.Count > 0)
        {
            _outsideSite.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_outsideSite, fieldData);
        }

        return _outsideSite;
    } 
}

internal HL7V231Field _addressofOutsideSite;

public HL7V231Field AddressofOutsideSite
{
    get
    {
        if (_addressofOutsideSite != null)
        {
            return _addressofOutsideSite;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.28",
            Type = @"Field",
            Position = @"OM1.28",
            Name = @"Address of Outside Site",
            Length = 1000,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of the outside services listed in OM1-28-address of outside site(s) where observation may be performed. If multiple services are recorded in that field, their addresses should be separated by repeat delimiters, and the addresses should appear in the same order in which the services appear in the preceding field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.28.1",
                            Type = @"Component",
                            Position = @"OM1.28.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.2",
                            Type = @"Component",
                            Position = @"OM1.28.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In general, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.3",
                            Type = @"Component",
                            Position = @"OM1.28.3",
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
                            Id = @"OM1.28.4",
                            Type = @"Component",
                            Position = @"OM1.28.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"State or province should be represented by the official postal service codes for that country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.5",
                            Type = @"Component",
                            Position = @"OM1.28.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.6",
                            Type = @"Component",
                            Position = @"OM1.28.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.7",
                            Type = @"Component",
                            Position = @"OM1.28.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.8",
                            Type = @"Component",
                            Position = @"OM1.28.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes county, bioregion, SMSA, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.9",
                            Type = @"Component",
                            Position = @"OM1.28.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County code",
                            Description = @"A code that represents the county in which the specified address resides. User-defined table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.10",
                            Type = @"Component",
                            Position = @"OM1.28.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides. User-defined table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.11",
                            Type = @"Component",
                            Position = @"OM1.28.11",
                            Name = @"Address Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same name/address should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _addressofOutsideSite = new HL7V231Field
        {
            field = message[@"OM1"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_addressofOutsideSite.field.FieldRepetitions != null && _addressofOutsideSite.field.FieldRepetitions.Count > 0)
        {
            _addressofOutsideSite.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_addressofOutsideSite, fieldData);
        }

        return _addressofOutsideSite;
    } 
}

internal HL7V231Field _phoneNumberofOutsideSite;

public HL7V231Field PhoneNumberofOutsideSite
{
    get
    {
        if (_phoneNumberofOutsideSite != null)
        {
            return _phoneNumberofOutsideSite;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.29",
            Type = @"Field",
            Position = @"OM1.29",
            Name = @"Phone Number of Outside Site",
            Length = 400,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number of the outside site.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.29.1",
                            Type = @"Component",
                            Position = @"OM1.29.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type (see Section 2.8.42, TN - telephone number), except that the length of the country access code has been increased to three.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.2",
                            Type = @"Component",
                            Position = @"OM1.29.2",
                            Name = @"Telecommunication use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.3",
                            Type = @"Component",
                            Position = @"OM1.29.3",
                            Name = @"Telecommunication equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.4",
                            Type = @"Component",
                            Position = @"OM1.29.4",
                            Name = @"Email Address",
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
                            Id = @"OM1.29.5",
                            Type = @"Component",
                            Position = @"OM1.29.5",
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
                            Id = @"OM1.29.6",
                            Type = @"Component",
                            Position = @"OM1.29.6",
                            Name = @"Area/City Code",
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
                            Id = @"OM1.29.7",
                            Type = @"Component",
                            Position = @"OM1.29.7",
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
                            Id = @"OM1.29.8",
                            Type = @"Component",
                            Position = @"OM1.29.8",
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
                            Id = @"OM1.29.9",
                            Type = @"Component",
                            Position = @"OM1.29.9",
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

        _phoneNumberofOutsideSite = new HL7V231Field
        {
            field = message[@"OM1"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_phoneNumberofOutsideSite.field.FieldRepetitions != null && _phoneNumberofOutsideSite.field.FieldRepetitions.Count > 0)
        {
            _phoneNumberofOutsideSite.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_phoneNumberofOutsideSite, fieldData);
        }

        return _phoneNumberofOutsideSite;
    } 
}

internal HL7V231Field _confidentialityCode;

public HL7V231Field ConfidentialityCode
{
    get
    {
        if (_confidentialityCode != null)
        {
            return _confidentialityCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.30",
            Type = @"Field",
            Position = @"OM1.30",
            Name = @"Confidentiality Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0177",
            TableName = @"Confidentiality code",
            Description = @"This field contains the degree to which special confidentiality protection should be applied to the observation. For example, a tighter control may be applied to an HIV test than to a CBC. Refer to user-defined table 0177 - Confidentiality code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _confidentialityCode = new HL7V231Field
        {
            field = message[@"OM1"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_confidentialityCode.field.FieldRepetitions != null && _confidentialityCode.field.FieldRepetitions.Count > 0)
        {
            _confidentialityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_confidentialityCode, fieldData);
        }

        return _confidentialityCode;
    } 
}

internal HL7V231Field _observationsRequiredtoInterprettheObs;

public HL7V231Field ObservationsRequiredtoInterprettheObs
{
    get
    {
        if (_observationsRequiredtoInterprettheObs != null)
        {
            return _observationsRequiredtoInterprettheObs;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.31",
            Type = @"Field",
            Position = @"OM1.31",
            Name = @"Observations Required to Interpret the Obs",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the list of variables that the diagnostic service needs to interpret the results of an ordered study. The observations specified here should be sent to the diagnostic service as OBX segments along with the order (OBR) segment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.31.1",
                            Type = @"Component",
                            Position = @"OM1.31.1",
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
                            Id = @"OM1.31.2",
                            Type = @"Component",
                            Position = @"OM1.31.2",
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
                            Id = @"OM1.31.3",
                            Type = @"Component",
                            Position = @"OM1.31.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.31.4",
                            Type = @"Component",
                            Position = @"OM1.31.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.31.5",
                            Type = @"Component",
                            Position = @"OM1.31.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.31.6",
                            Type = @"Component",
                            Position = @"OM1.31.6",
                            Name = @"Name Of Alternate Coding System",
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

        _observationsRequiredtoInterprettheObs = new HL7V231Field
        {
            field = message[@"OM1"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationsRequiredtoInterprettheObs.field.FieldRepetitions != null && _observationsRequiredtoInterprettheObs.field.FieldRepetitions.Count > 0)
        {
            _observationsRequiredtoInterprettheObs.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_observationsRequiredtoInterprettheObs, fieldData);
        }

        return _observationsRequiredtoInterprettheObs;
    } 
}

internal HL7V231Field _interpretationofObservations;

public HL7V231Field InterpretationofObservations
{
    get
    {
        if (_interpretationofObservations != null)
        {
            return _interpretationofObservations;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.32",
            Type = @"Field",
            Position = @"OM1.32",
            Name = @"Interpretation of Observations",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the clinical information about interpreting test results. Examples are the conditions (drugs) that may cause false abnormals, and the information about the sensitivity and specificity of the test for diagnoses.",
            Sample = @"",
            Fields = null
        }

        _interpretationofObservations = new HL7V231Field
        {
            field = message[@"OM1"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_interpretationofObservations.field.FieldRepetitions != null && _interpretationofObservations.field.FieldRepetitions.Count > 0)
        {
            _interpretationofObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_interpretationofObservations, fieldData);
        }

        return _interpretationofObservations;
    } 
}

internal HL7V231Field _contraindicationstoObservations;

public HL7V231Field ContraindicationstoObservations
{
    get
    {
        if (_contraindicationstoObservations != null)
        {
            return _contraindicationstoObservations;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.33",
            Type = @"Field",
            Position = @"OM1.33",
            Name = @"Contraindications to Observations",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the diagnosis or problem for which the test is a contraindication or of possible danger (e.g., pacemaker, pregnancy, diabetes). For example, if the test identified in OM1 was an intravenous pyelogram, this field would include warnings about the use of contrast media in diabetes. The contraindication diagnoses should be separated by repeat delimiters.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.33.1",
                            Type = @"Component",
                            Position = @"OM1.33.1",
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
                            Id = @"OM1.33.2",
                            Type = @"Component",
                            Position = @"OM1.33.2",
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
                            Id = @"OM1.33.3",
                            Type = @"Component",
                            Position = @"OM1.33.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.33.4",
                            Type = @"Component",
                            Position = @"OM1.33.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.33.5",
                            Type = @"Component",
                            Position = @"OM1.33.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.33.6",
                            Type = @"Component",
                            Position = @"OM1.33.6",
                            Name = @"Name Of Alternate Coding System",
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

        _contraindicationstoObservations = new HL7V231Field
        {
            field = message[@"OM1"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contraindicationstoObservations.field.FieldRepetitions != null && _contraindicationstoObservations.field.FieldRepetitions.Count > 0)
        {
            _contraindicationstoObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_contraindicationstoObservations, fieldData);
        }

        return _contraindicationstoObservations;
    } 
}

internal HL7V231Field _reflexTestsObservations;

public HL7V231Field ReflexTestsObservations
{
    get
    {
        if (_reflexTestsObservations != null)
        {
            return _reflexTestsObservations;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.34",
            Type = @"Field",
            Position = @"OM1.34",
            Name = @"Reflex Tests/Observations",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the test names as type CE (i.e., <code>^<text name>^<coding system>) that may be ordered automatically by the diagnostic service, depending on the results obtained from the ordered battery. A screening CBC might trigger a reticulocyte count if the Hgb is less than 12. Multiple reflex tests are separated by repeat delimiters.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.34.1",
                            Type = @"Component",
                            Position = @"OM1.34.1",
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
                            Id = @"OM1.34.2",
                            Type = @"Component",
                            Position = @"OM1.34.2",
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
                            Id = @"OM1.34.3",
                            Type = @"Component",
                            Position = @"OM1.34.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.34.4",
                            Type = @"Component",
                            Position = @"OM1.34.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.34.5",
                            Type = @"Component",
                            Position = @"OM1.34.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.34.6",
                            Type = @"Component",
                            Position = @"OM1.34.6",
                            Name = @"Name Of Alternate Coding System",
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

        _reflexTestsObservations = new HL7V231Field
        {
            field = message[@"OM1"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reflexTestsObservations.field.FieldRepetitions != null && _reflexTestsObservations.field.FieldRepetitions.Count > 0)
        {
            _reflexTestsObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_reflexTestsObservations, fieldData);
        }

        return _reflexTestsObservations;
    } 
}

internal HL7V231Field _rulesthatTriggerReflexTesting;

public HL7V231Field RulesthatTriggerReflexTesting
{
    get
    {
        if (_rulesthatTriggerReflexTesting != null)
        {
            return _rulesthatTriggerReflexTesting;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.35",
            Type = @"Field",
            Position = @"OM1.35",
            Name = @"Rules that Trigger Reflex Testing",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the rules that trigger the reflex tests listed above. If multiple reflex tests are listed in OM1-34-reflex tests/observations separated by repeat delimiters, a set of corresponding rules will be included in this section. The first rule will apply to the first test, the second to the second test, and so on.",
            Sample = @"",
            Fields = null
        }

        _rulesthatTriggerReflexTesting = new HL7V231Field
        {
            field = message[@"OM1"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rulesthatTriggerReflexTesting.field.FieldRepetitions != null && _rulesthatTriggerReflexTesting.field.FieldRepetitions.Count > 0)
        {
            _rulesthatTriggerReflexTesting.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_rulesthatTriggerReflexTesting, fieldData);
        }

        return _rulesthatTriggerReflexTesting;
    } 
}

internal HL7V231Field _fixedCannedMessage;

public HL7V231Field FixedCannedMessage
{
    get
    {
        if (_fixedCannedMessage != null)
        {
            return _fixedCannedMessage;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.36",
            Type = @"Field",
            Position = @"OM1.36",
            Name = @"Fixed Canned Message",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the codes and a fixed text message that is always associated with an abbreviation. The field may include multiple messages separated by repeat delimiters.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.36.1",
                            Type = @"Component",
                            Position = @"OM1.36.1",
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
                            Id = @"OM1.36.2",
                            Type = @"Component",
                            Position = @"OM1.36.2",
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
                            Id = @"OM1.36.3",
                            Type = @"Component",
                            Position = @"OM1.36.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.36.4",
                            Type = @"Component",
                            Position = @"OM1.36.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.36.5",
                            Type = @"Component",
                            Position = @"OM1.36.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.36.6",
                            Type = @"Component",
                            Position = @"OM1.36.6",
                            Name = @"Name Of Alternate Coding System",
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

        _fixedCannedMessage = new HL7V231Field
        {
            field = message[@"OM1"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fixedCannedMessage.field.FieldRepetitions != null && _fixedCannedMessage.field.FieldRepetitions.Count > 0)
        {
            _fixedCannedMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_fixedCannedMessage, fieldData);
        }

        return _fixedCannedMessage;
    } 
}

internal HL7V231Field _patientPreparation;

public HL7V231Field PatientPreparation
{
    get
    {
        if (_patientPreparation != null)
        {
            return _patientPreparation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.37",
            Type = @"Field",
            Position = @"OM1.37",
            Name = @"Patient Preparation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the tests or observations that require special patient preparation, diet, or medications. For GI contrast studies, this field would contain the pretest diet, e.g., low residue for two days, NPO before study, and the preferred purgatives. Each separate med, diet, or preparation should be delimited by a repeat delimiter. Separate each requirement by a repeat delimiter. Example for a sigmoidectomy: clear liquid diet full day before procedure~take 8 oz mag citrate 6pm day before procedure~take 2 ducat tabs (5m) at 4pm day before procedure~NPO past midnight.",
            Sample = @"",
            Fields = null
        }

        _patientPreparation = new HL7V231Field
        {
            field = message[@"OM1"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientPreparation.field.FieldRepetitions != null && _patientPreparation.field.FieldRepetitions.Count > 0)
        {
            _patientPreparation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_patientPreparation, fieldData);
        }

        return _patientPreparation;
    } 
}

internal HL7V231Field _procedureMedication;

public HL7V231Field ProcedureMedication
{
    get
    {
        if (_procedureMedication != null)
        {
            return _procedureMedication;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.38",
            Type = @"Field",
            Position = @"OM1.38",
            Name = @"Procedure Medication",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the treatments that may be needed as part of the procedure. Examples are radioactive iodine for a thyroid screen, and methacholine for a methacholine spirometry challenge. This field should be identified as a CE data type.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.38.1",
                            Type = @"Component",
                            Position = @"OM1.38.1",
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
                            Id = @"OM1.38.2",
                            Type = @"Component",
                            Position = @"OM1.38.2",
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
                            Id = @"OM1.38.3",
                            Type = @"Component",
                            Position = @"OM1.38.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.38.4",
                            Type = @"Component",
                            Position = @"OM1.38.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.38.5",
                            Type = @"Component",
                            Position = @"OM1.38.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.38.6",
                            Type = @"Component",
                            Position = @"OM1.38.6",
                            Name = @"Name Of Alternate Coding System",
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

        _procedureMedication = new HL7V231Field
        {
            field = message[@"OM1"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureMedication.field.FieldRepetitions != null && _procedureMedication.field.FieldRepetitions.Count > 0)
        {
            _procedureMedication.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_procedureMedication, fieldData);
        }

        return _procedureMedication;
    } 
}

internal HL7V231Field _factorsthatmayEffecttheObservation;

public HL7V231Field FactorsthatmayEffecttheObservation
{
    get
    {
        if (_factorsthatmayEffecttheObservation != null)
        {
            return _factorsthatmayEffecttheObservation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.39",
            Type = @"Field",
            Position = @"OM1.39",
            Name = @"Factors that may Effect the Observation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the text description of the foods, diagnoses, drugs, or other conditions that may influence the interpretation of the observation. Information about the direction of the effect, and any recommendation about altering the diet, conditions, or drug before initiating the test observation.",
            Sample = @"",
            Fields = null
        }

        _factorsthatmayEffecttheObservation = new HL7V231Field
        {
            field = message[@"OM1"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_factorsthatmayEffecttheObservation.field.FieldRepetitions != null && _factorsthatmayEffecttheObservation.field.FieldRepetitions.Count > 0)
        {
            _factorsthatmayEffecttheObservation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_factorsthatmayEffecttheObservation, fieldData);
        }

        return _factorsthatmayEffecttheObservation;
    } 
}

internal HL7V231Field _testObservationPerformanceSchedule;

public HL7V231Field TestObservationPerformanceSchedule
{
    get
    {
        if (_testObservationPerformanceSchedule != null)
        {
            return _testObservationPerformanceSchedule;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.40",
            Type = @"Field",
            Position = @"OM1.40",
            Name = @"Test/Observation Performance Schedule",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the diagnostic studies/tests that are performed only at certain times during the course of a work day or work week. This field indicates the maximum interval between successive test performances (the test may actually be performed more frequently). The format given in Chapter 4, Section 4.4.2.1, 'Repeat Pattern,' should be used. If necessary, multiple codes may be given, separated by repeat delimiters. The use of multiple codes indicates that the test is performed at multiple concurrent intervals. For example, Q6H indicates that the test is performed at least once every 6 hours around the clock. QJ1 indicates that the test is performed at least every week on Mondays. QAM~QPM indicates that the test is performed at least once every morning and every evening. QJ1~QJ3~QJ5 indicates that the test is performed at least every week on Mondays, Wednesdays, and Fridays. C indicates that the test is performed continuously, 7 days per week.",
            Sample = @"",
            Fields = null
        }

        _testObservationPerformanceSchedule = new HL7V231Field
        {
            field = message[@"OM1"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_testObservationPerformanceSchedule.field.FieldRepetitions != null && _testObservationPerformanceSchedule.field.FieldRepetitions.Count > 0)
        {
            _testObservationPerformanceSchedule.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_testObservationPerformanceSchedule, fieldData);
        }

        return _testObservationPerformanceSchedule;
    } 
}

internal HL7V231Field _descriptionofTestMethods;

public HL7V231Field DescriptionofTestMethods
{
    get
    {
        if (_descriptionofTestMethods != null)
        {
            return _descriptionofTestMethods;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.41",
            Type = @"Field",
            Position = @"OM1.41",
            Name = @"Description of Test Methods",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the text description of the methods used to perform the text and generate the observations. Bibliographic citations may be included.",
            Sample = @"",
            Fields = null
        }

        _descriptionofTestMethods = new HL7V231Field
        {
            field = message[@"OM1"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_descriptionofTestMethods.field.FieldRepetitions != null && _descriptionofTestMethods.field.FieldRepetitions.Count > 0)
        {
            _descriptionofTestMethods.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_descriptionofTestMethods, fieldData);
        }

        return _descriptionofTestMethods;
    } 
}

internal HL7V231Field _kindofQuantityObserved;

public HL7V231Field KindofQuantityObserved
{
    get
    {
        if (_kindofQuantityObserved != null)
        {
            return _kindofQuantityObserved;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.42",
            Type = @"Field",
            Position = @"OM1.42",
            Name = @"Kind of Quantity Observed",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0254",
            TableName = @"Kind of quantity",
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.42.1",
                            Type = @"Component",
                            Position = @"OM1.42.1",
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
                            Id = @"OM1.42.2",
                            Type = @"Component",
                            Position = @"OM1.42.2",
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
                            Id = @"OM1.42.3",
                            Type = @"Component",
                            Position = @"OM1.42.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.42.4",
                            Type = @"Component",
                            Position = @"OM1.42.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.42.5",
                            Type = @"Component",
                            Position = @"OM1.42.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.42.6",
                            Type = @"Component",
                            Position = @"OM1.42.6",
                            Name = @"Name Of Alternate Coding System",
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

        _kindofQuantityObserved = new HL7V231Field
        {
            field = message[@"OM1"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_kindofQuantityObserved.field.FieldRepetitions != null && _kindofQuantityObserved.field.FieldRepetitions.Count > 0)
        {
            _kindofQuantityObserved.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_kindofQuantityObserved, fieldData);
        }

        return _kindofQuantityObserved;
    } 
}

internal HL7V231Field _pointVersusInterval;

public HL7V231Field PointVersusInterval
{
    get
    {
        if (_pointVersusInterval != null)
        {
            return _pointVersusInterval;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.43",
            Type = @"Field",
            Position = @"OM1.43",
            Name = @"Point Versus Interval",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0255",
            TableName = @"Duration categories",
            Description = @"This optional attribute allows master files to classify observations as measuring the patient's state at a point in time (e.g., spot urines, random urines, serum potassium), or averaged over a interval of time (e.g., concentration, total amount, or clearance over a 24-hour collection). Interval measures most often apply to urine and stool specimens (e.g., 24-hour urines, 3-day stool fats). They also apply to clinical measurements such as urine outputs, which are reported as shift totals and 24-hour totals, and event counts on physiologic monitors such as the number of PVCs on a 24-hour Holter monitor.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.43.1",
                            Type = @"Component",
                            Position = @"OM1.43.1",
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
                            Id = @"OM1.43.2",
                            Type = @"Component",
                            Position = @"OM1.43.2",
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
                            Id = @"OM1.43.3",
                            Type = @"Component",
                            Position = @"OM1.43.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.43.4",
                            Type = @"Component",
                            Position = @"OM1.43.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.43.5",
                            Type = @"Component",
                            Position = @"OM1.43.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.43.6",
                            Type = @"Component",
                            Position = @"OM1.43.6",
                            Name = @"Name Of Alternate Coding System",
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

        _pointVersusInterval = new HL7V231Field
        {
            field = message[@"OM1"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pointVersusInterval.field.FieldRepetitions != null && _pointVersusInterval.field.FieldRepetitions.Count > 0)
        {
            _pointVersusInterval.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_pointVersusInterval, fieldData);
        }

        return _pointVersusInterval;
    } 
}

internal HL7V231Field _challengeInformation;

public HL7V231Field ChallengeInformation
{
    get
    {
        if (_challengeInformation != null)
        {
            return _challengeInformation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.44",
            Type = @"Field",
            Position = @"OM1.44",
            Name = @"Challenge Information",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This optional attribute provides information for classifying observations by the challenge component of the test, if a challenge does speciate the observation. For example, distinguishing tests that have a challenge component in database. There co-ascribes the physiologic or drug challenge that is intrinsic to the measurement. To identify, for example, tests that include a glucose challenge.",
            Sample = @"",
            Fields = null
        }

        _challengeInformation = new HL7V231Field
        {
            field = message[@"OM1"][44],
            fieldData = fieldData
        };

        // check for repetitions
        if (_challengeInformation.field.FieldRepetitions != null && _challengeInformation.field.FieldRepetitions.Count > 0)
        {
            _challengeInformation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_challengeInformation, fieldData);
        }

        return _challengeInformation;
    } 
}

internal HL7V231Field _relationshipModifier;

public HL7V231Field RelationshipModifier
{
    get
    {
        if (_relationshipModifier != null)
        {
            return _relationshipModifier;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.45",
            Type = @"Field",
            Position = @"OM1.45",
            Name = @"Relationship Modifier",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0258",
            TableName = @"Relationship modifier",
            Description = @"This optional attribute provides a mechanism for classifying observations according to the subject, in relation to the patient whose results might be stored with as 'patient' data. It is standard practice, for example, to report values for controls, donors, and blood product units as well as the patient's own values, and store them in the patient's record. (This may not be the best way to model such information, but it is the way it is usually reported.) This should be valued when two values (e.g., one for patient and one for a blood product unit) could otherwise be confused.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.45.1",
                            Type = @"Component",
                            Position = @"OM1.45.1",
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
                            Id = @"OM1.45.2",
                            Type = @"Component",
                            Position = @"OM1.45.2",
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
                            Id = @"OM1.45.3",
                            Type = @"Component",
                            Position = @"OM1.45.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.45.4",
                            Type = @"Component",
                            Position = @"OM1.45.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.45.5",
                            Type = @"Component",
                            Position = @"OM1.45.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.45.6",
                            Type = @"Component",
                            Position = @"OM1.45.6",
                            Name = @"Name Of Alternate Coding System",
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

        _relationshipModifier = new HL7V231Field
        {
            field = message[@"OM1"][45],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relationshipModifier.field.FieldRepetitions != null && _relationshipModifier.field.FieldRepetitions.Count > 0)
        {
            _relationshipModifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_relationshipModifier, fieldData);
        }

        return _relationshipModifier;
    } 
}

internal HL7V231Field _targetAnatomicSiteOfTest;

public HL7V231Field TargetAnatomicSiteOfTest
{
    get
    {
        if (_targetAnatomicSiteOfTest != null)
        {
            return _targetAnatomicSiteOfTest;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.46",
            Type = @"Field",
            Position = @"OM1.46",
            Name = @"Target Anatomic Site Of Test",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This optional attribute formally indicates the site of the observation (to make it easy for a system to find all tests related to one anatomic site). It can be used to classify the observation by target site of the examination. For example, 'heart' might be recorded as the target of the electrocardiogram, cardiac echo, and thallium exercise test. This attribute would be applicable to most imaging and electro-physiologic examinations. The SNOMED topology axis is an example of a coding system for anatomic sites. User-defined tables may also apply here.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.46.1",
                            Type = @"Component",
                            Position = @"OM1.46.1",
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
                            Id = @"OM1.46.2",
                            Type = @"Component",
                            Position = @"OM1.46.2",
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
                            Id = @"OM1.46.3",
                            Type = @"Component",
                            Position = @"OM1.46.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.46.4",
                            Type = @"Component",
                            Position = @"OM1.46.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.46.5",
                            Type = @"Component",
                            Position = @"OM1.46.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.46.6",
                            Type = @"Component",
                            Position = @"OM1.46.6",
                            Name = @"Name Of Alternate Coding System",
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

        _targetAnatomicSiteOfTest = new HL7V231Field
        {
            field = message[@"OM1"][46],
            fieldData = fieldData
        };

        // check for repetitions
        if (_targetAnatomicSiteOfTest.field.FieldRepetitions != null && _targetAnatomicSiteOfTest.field.FieldRepetitions.Count > 0)
        {
            _targetAnatomicSiteOfTest.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_targetAnatomicSiteOfTest, fieldData);
        }

        return _targetAnatomicSiteOfTest;
    } 
}

internal HL7V231Field _modalityOfImagingMeasurement;

public HL7V231Field ModalityOfImagingMeasurement
{
    get
    {
        if (_modalityOfImagingMeasurement != null)
        {
            return _modalityOfImagingMeasurement;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OM1.47",
            Type = @"Field",
            Position = @"OM1.47",
            Name = @"Modality Of Imaging Measurement",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0259",
            TableName = @"Modality",
            Description = @"This optional attribute describes the modality used to classify the observations, e.g., radiograph, ultrasound, CT scan, NMR, etc. This attribute is especially important for imaging studies. Refer to user-defined table 0259 - Modality forsuggested values; it is adopted from DICOM C.7.3.1.1.1 Modality. If these are used, the code source ID would be DCM.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM1.47.1",
                            Type = @"Component",
                            Position = @"OM1.47.1",
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
                            Id = @"OM1.47.2",
                            Type = @"Component",
                            Position = @"OM1.47.2",
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
                            Id = @"OM1.47.3",
                            Type = @"Component",
                            Position = @"OM1.47.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.47.4",
                            Type = @"Component",
                            Position = @"OM1.47.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.47.5",
                            Type = @"Component",
                            Position = @"OM1.47.5",
                            Name = @"Alternate Text",
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
                            Id = @"OM1.47.6",
                            Type = @"Component",
                            Position = @"OM1.47.6",
                            Name = @"Name Of Alternate Coding System",
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

        _modalityOfImagingMeasurement = new HL7V231Field
        {
            field = message[@"OM1"][47],
            fieldData = fieldData
        };

        // check for repetitions
        if (_modalityOfImagingMeasurement.field.FieldRepetitions != null && _modalityOfImagingMeasurement.field.FieldRepetitions.Count > 0)
        {
            _modalityOfImagingMeasurement.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_modalityOfImagingMeasurement, fieldData);
        }

        return _modalityOfImagingMeasurement;
    } 
}
    }
}
