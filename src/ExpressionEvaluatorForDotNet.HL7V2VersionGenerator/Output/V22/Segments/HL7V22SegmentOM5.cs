using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentOM5
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM5"; } }

        public string SegmentId { get { return @"OM5"; } }
        
        public string LongName { get { return @"Observation Batteries"; } }
        
        public string Description { get { return @"This segment contains information about batteries and supersets (a nature code of F, P or S, as described in OM119-nature of test/observation)."; } }
        
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

        public HL7V22SegmentOM5(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _segmentTypeId;

public HL7V22Field SegmentTypeId
{
    get
    {
        if (_segmentTypeId != null)
        {
            return _segmentTypeId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM5.1",
            Type = @"Field",
            Position = @"OM5.1",
            Name = @"Segment Type Id",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"the string OM5 - identifies a record as an observation battery (set). ",
            Sample = @"",
            Fields = null
        }

        _segmentTypeId = new HL7V22Field
        {
            field = message[@"OM5"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_segmentTypeId.field.FieldRepetitions != null && _segmentTypeId.field.FieldRepetitions.Count > 0)
        {
            _segmentTypeId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_segmentTypeId, fieldData);
        }

        return _segmentTypeId;
    } 
}

internal HL7V22Field _sequenceNumberTestObservationMasterFile;

public HL7V22Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (_sequenceNumberTestObservationMasterFile != null)
        {
            return _sequenceNumberTestObservationMasterFile;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM5.2",
            Type = @"Field",
            Position = @"OM5.2",
            Name = @"Sequence Number - Test/ Observation Master File",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"the same value as the sequence number of the associated OM1 segment",
            Sample = @"",
            Fields = null
        }

        _sequenceNumberTestObservationMasterFile = new HL7V22Field
        {
            field = message[@"OM5"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumberTestObservationMasterFile.field.FieldRepetitions != null && _sequenceNumberTestObservationMasterFile.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumberTestObservationMasterFile.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_sequenceNumberTestObservationMasterFile, fieldData);
        }

        return _sequenceNumberTestObservationMasterFile;
    } 
}

internal HL7V22Field _testsObservationsIncludedWithinAnOrderedTestBattery;

public HL7V22Field TestsObservationsIncludedWithinAnOrderedTestBattery
{
    get
    {
        if (_testsObservationsIncludedWithinAnOrderedTestBattery != null)
        {
            return _testsObservationsIncludedWithinAnOrderedTestBattery;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM5.3",
            Type = @"Field",
            Position = @"OM5.3",
            Name = @"Tests / Observations Included Within An Ordered Test Battery",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"lists the codes and names of all tests/observations included within a single battery (nature code P, as described in OM1-19-nature of test/observation), a single functional procedure (nature code F), or a given superset (nature code S).  When a segment includes a list of component elements, the sending  system should be sure that the segments defining all of the components are sent before the segment that reference them.  An entry in this list can itself be a battery",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM5.3.1",
                            Type = @"Component",
                            Position = @"OM5.3.1",
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
                            Id = @"OM5.3.2",
                            Type = @"Component",
                            Position = @"OM5.3.2",
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
                            Id = @"OM5.3.3",
                            Type = @"Component",
                            Position = @"OM5.3.3",
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
                            Id = @"OM5.3.4",
                            Type = @"Component",
                            Position = @"OM5.3.4",
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
                            Id = @"OM5.3.5",
                            Type = @"Component",
                            Position = @"OM5.3.5",
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
                            Id = @"OM5.3.6",
                            Type = @"Component",
                            Position = @"OM5.3.6",
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
                        },
                        }
        }

        _testsObservationsIncludedWithinAnOrderedTestBattery = new HL7V22Field
        {
            field = message[@"OM5"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_testsObservationsIncludedWithinAnOrderedTestBattery.field.FieldRepetitions != null && _testsObservationsIncludedWithinAnOrderedTestBattery.field.FieldRepetitions.Count > 0)
        {
            _testsObservationsIncludedWithinAnOrderedTestBattery.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_testsObservationsIncludedWithinAnOrderedTestBattery, fieldData);
        }

        return _testsObservationsIncludedWithinAnOrderedTestBattery;
    } 
}

internal HL7V22Field _observationIdSuffixes;

public HL7V22Field ObservationIdSuffixes
{
    get
    {
        if (_observationIdSuffixes != null)
        {
            return _observationIdSuffixes;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM5.4",
            Type = @"Field",
            Position = @"OM5.4",
            Name = @"Observation Id Suffixes",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"for tests or procedures that produce a type which uses observation ID suffixes following the test/observation ID code, this field lists the possible options.  The applicable three-character mnemonics given in ASTM Table 20 (or others appropriate to the application) are listed, separated by repeat delimiters.  For example, a chest x-ray may use the suffixes IMP, REC, DEV, or others.  Each of the expected suffixes should be listed here",
            Sample = @"",
            Fields = null
        }

        _observationIdSuffixes = new HL7V22Field
        {
            field = message[@"OM5"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationIdSuffixes.field.FieldRepetitions != null && _observationIdSuffixes.field.FieldRepetitions.Count > 0)
        {
            _observationIdSuffixes.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_observationIdSuffixes, fieldData);
        }

        return _observationIdSuffixes;
    } 
}
    }
}
