using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentOM3
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM3"; } }

        public string SegmentId { get { return @"OM3"; } }
        
        public string LongName { get { return @"Categorical Test/observation"; } }
        
        public string Description { get { return @"This segment applies to free text and other non-numeric data types"; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM3.1",
                            Type = @"Field",
                            Position = @"OM3.1",
                            Name = @"Segment Type Id",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the string OM3 - identifies a record as a categorical test/observation segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM3.2",
                            Type = @"Field",
                            Position = @"OM3.2",
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM3.3",
                            Type = @"Field",
                            Position = @"OM3.3",
                            Name = @"Preferred Coding System",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"for observations whose categorical responses are taken from a specified table of codes (e.g., CE data types), record the preferred coding system for this observation (e.g., ICD9, SNOMED III).  Take the codes from ASTM Table 3 or 5, or specify a local code",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM3.4",
                            Type = @"Field",
                            Position = @"OM3.4",
                            Name = @"Valid Coded Answers",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"in the case that the list of coded answers is easily enumerated, list the valid coded answers for this observation here using the preferred coding system given in OM3-3-preferred coding system.  If for example, the given observation was VDRL, the valid answers might be non-reactive, 86^ intermediate, and 87^ reactive",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM3.4.1",
                            Type = @"Component",
                            Position = @"OM3.4.1",
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
                            Id = @"OM3.4.2",
                            Type = @"Component",
                            Position = @"OM3.4.2",
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
                            Id = @"OM3.4.3",
                            Type = @"Component",
                            Position = @"OM3.4.3",
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
                            Id = @"OM3.4.4",
                            Type = @"Component",
                            Position = @"OM3.4.4",
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
                            Id = @"OM3.4.5",
                            Type = @"Component",
                            Position = @"OM3.4.5",
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
                            Id = @"OM3.4.6",
                            Type = @"Component",
                            Position = @"OM3.4.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM3.5",
                            Type = @"Field",
                            Position = @"OM3.5",
                            Name = @"Normal Test Codes For Categorical Observations",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"certain observations/tests with a nature code of A or C (see OM1-19-nature of test/observation) have text (alpha) results (e.g., reactive, nonreactive).  Alpha normals for those tests should be entered in this field (e.g., ""nonreactive""). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM3.5.1",
                            Type = @"Component",
                            Position = @"OM3.5.1",
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
                            Id = @"OM3.5.2",
                            Type = @"Component",
                            Position = @"OM3.5.2",
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
                            Id = @"OM3.5.3",
                            Type = @"Component",
                            Position = @"OM3.5.3",
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
                            Id = @"OM3.5.4",
                            Type = @"Component",
                            Position = @"OM3.5.4",
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
                            Id = @"OM3.5.5",
                            Type = @"Component",
                            Position = @"OM3.5.5",
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
                            Id = @"OM3.5.6",
                            Type = @"Component",
                            Position = @"OM3.5.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM3.6",
                            Type = @"Field",
                            Position = @"OM3.6",
                            Name = @"Abnormal Test Codes For Categorical Observations",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"a list of the text answers that are abnormal for the test",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM3.6.1",
                            Type = @"Component",
                            Position = @"OM3.6.1",
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
                            Id = @"OM3.6.2",
                            Type = @"Component",
                            Position = @"OM3.6.2",
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
                            Id = @"OM3.6.3",
                            Type = @"Component",
                            Position = @"OM3.6.3",
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
                            Id = @"OM3.6.4",
                            Type = @"Component",
                            Position = @"OM3.6.4",
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
                            Id = @"OM3.6.5",
                            Type = @"Component",
                            Position = @"OM3.6.5",
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
                            Id = @"OM3.6.6",
                            Type = @"Component",
                            Position = @"OM3.6.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM3.7",
                            Type = @"Field",
                            Position = @"OM3.7",
                            Name = @"Critical Test Codes For Categorical Observations",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"a list of coded results that are critically abnormal for this observation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM3.7.1",
                            Type = @"Component",
                            Position = @"OM3.7.1",
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
                            Id = @"OM3.7.2",
                            Type = @"Component",
                            Position = @"OM3.7.2",
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
                            Id = @"OM3.7.3",
                            Type = @"Component",
                            Position = @"OM3.7.3",
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
                            Id = @"OM3.7.4",
                            Type = @"Component",
                            Position = @"OM3.7.4",
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
                            Id = @"OM3.7.5",
                            Type = @"Component",
                            Position = @"OM3.7.5",
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
                            Id = @"OM3.7.6",
                            Type = @"Component",
                            Position = @"OM3.7.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM3.8",
                            Type = @"Field",
                            Position = @"OM3.8",
                            Name = @"Data Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"the allowed data type for a single categorical observation (code A or C in OM1-19-nature of observation).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentOM3(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field segmentTypeId;

public HL7V22Field SegmentTypeId
{
    get
    {
        if (segmentTypeId != null)
        {
            return segmentTypeId;
        }

        segmentTypeId = new HL7V22Field
        {
            field = message[@"OM3"][1],
            Id = @"OM3.1",
            Type = @"Field",
            Position = @"OM3.1",
            Name = @"Segment Type Id",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"the string OM3 - identifies a record as a categorical test/observation segment",
            Sample = @"",
        };

        // check for repetitions
        if (segmentTypeId.field.FieldRepetitions != null && segmentTypeId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(segmentTypeId.Id));
            segmentTypeId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(segmentTypeId, fieldData);
        }

        return segmentTypeId;
    } 
}

internal HL7V22Field sequenceNumberTestObservationMasterFile;

public HL7V22Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (sequenceNumberTestObservationMasterFile != null)
        {
            return sequenceNumberTestObservationMasterFile;
        }

        sequenceNumberTestObservationMasterFile = new HL7V22Field
        {
            field = message[@"OM3"][2],
            Id = @"OM3.2",
            Type = @"Field",
            Position = @"OM3.2",
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
        };

        // check for repetitions
        if (sequenceNumberTestObservationMasterFile.field.FieldRepetitions != null && sequenceNumberTestObservationMasterFile.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceNumberTestObservationMasterFile.Id));
            sequenceNumberTestObservationMasterFile.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(sequenceNumberTestObservationMasterFile, fieldData);
        }

        return sequenceNumberTestObservationMasterFile;
    } 
}

internal HL7V22Field preferredCodingSystem;

public HL7V22Field PreferredCodingSystem
{
    get
    {
        if (preferredCodingSystem != null)
        {
            return preferredCodingSystem;
        }

        preferredCodingSystem = new HL7V22Field
        {
            field = message[@"OM3"][3],
            Id = @"OM3.3",
            Type = @"Field",
            Position = @"OM3.3",
            Name = @"Preferred Coding System",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"for observations whose categorical responses are taken from a specified table of codes (e.g., CE data types), record the preferred coding system for this observation (e.g., ICD9, SNOMED III).  Take the codes from ASTM Table 3 or 5, or specify a local code",
            Sample = @"",
        };

        // check for repetitions
        if (preferredCodingSystem.field.FieldRepetitions != null && preferredCodingSystem.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(preferredCodingSystem.Id));
            preferredCodingSystem.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(preferredCodingSystem, fieldData);
        }

        return preferredCodingSystem;
    } 
}

internal HL7V22Field validCodedAnswers;

public HL7V22Field ValidCodedAnswers
{
    get
    {
        if (validCodedAnswers != null)
        {
            return validCodedAnswers;
        }

        validCodedAnswers = new HL7V22Field
        {
            field = message[@"OM3"][4],
            Id = @"OM3.4",
            Type = @"Field",
            Position = @"OM3.4",
            Name = @"Valid Coded Answers",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"in the case that the list of coded answers is easily enumerated, list the valid coded answers for this observation here using the preferred coding system given in OM3-3-preferred coding system.  If for example, the given observation was VDRL, the valid answers might be non-reactive, 86^ intermediate, and 87^ reactive",
            Sample = @"",
        };

        // check for repetitions
        if (validCodedAnswers.field.FieldRepetitions != null && validCodedAnswers.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(validCodedAnswers.Id));
            validCodedAnswers.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(validCodedAnswers, fieldData);
        }

        return validCodedAnswers;
    } 
}

internal HL7V22Field normalTestCodesForCategoricalObservations;

public HL7V22Field NormalTestCodesForCategoricalObservations
{
    get
    {
        if (normalTestCodesForCategoricalObservations != null)
        {
            return normalTestCodesForCategoricalObservations;
        }

        normalTestCodesForCategoricalObservations = new HL7V22Field
        {
            field = message[@"OM3"][5],
            Id = @"OM3.5",
            Type = @"Field",
            Position = @"OM3.5",
            Name = @"Normal Test Codes For Categorical Observations",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"certain observations/tests with a nature code of A or C (see OM1-19-nature of test/observation) have text (alpha) results (e.g., reactive, nonreactive).  Alpha normals for those tests should be entered in this field (e.g., ""nonreactive""). ",
            Sample = @"",
        };

        // check for repetitions
        if (normalTestCodesForCategoricalObservations.field.FieldRepetitions != null && normalTestCodesForCategoricalObservations.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(normalTestCodesForCategoricalObservations.Id));
            normalTestCodesForCategoricalObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(normalTestCodesForCategoricalObservations, fieldData);
        }

        return normalTestCodesForCategoricalObservations;
    } 
}

internal HL7V22Field abnormalTestCodesForCategoricalObservations;

public HL7V22Field AbnormalTestCodesForCategoricalObservations
{
    get
    {
        if (abnormalTestCodesForCategoricalObservations != null)
        {
            return abnormalTestCodesForCategoricalObservations;
        }

        abnormalTestCodesForCategoricalObservations = new HL7V22Field
        {
            field = message[@"OM3"][6],
            Id = @"OM3.6",
            Type = @"Field",
            Position = @"OM3.6",
            Name = @"Abnormal Test Codes For Categorical Observations",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"a list of the text answers that are abnormal for the test",
            Sample = @"",
        };

        // check for repetitions
        if (abnormalTestCodesForCategoricalObservations.field.FieldRepetitions != null && abnormalTestCodesForCategoricalObservations.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(abnormalTestCodesForCategoricalObservations.Id));
            abnormalTestCodesForCategoricalObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(abnormalTestCodesForCategoricalObservations, fieldData);
        }

        return abnormalTestCodesForCategoricalObservations;
    } 
}

internal HL7V22Field criticalTestCodesForCategoricalObservations;

public HL7V22Field CriticalTestCodesForCategoricalObservations
{
    get
    {
        if (criticalTestCodesForCategoricalObservations != null)
        {
            return criticalTestCodesForCategoricalObservations;
        }

        criticalTestCodesForCategoricalObservations = new HL7V22Field
        {
            field = message[@"OM3"][7],
            Id = @"OM3.7",
            Type = @"Field",
            Position = @"OM3.7",
            Name = @"Critical Test Codes For Categorical Observations",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"a list of coded results that are critically abnormal for this observation",
            Sample = @"",
        };

        // check for repetitions
        if (criticalTestCodesForCategoricalObservations.field.FieldRepetitions != null && criticalTestCodesForCategoricalObservations.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(criticalTestCodesForCategoricalObservations.Id));
            criticalTestCodesForCategoricalObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(criticalTestCodesForCategoricalObservations, fieldData);
        }

        return criticalTestCodesForCategoricalObservations;
    } 
}

internal HL7V22Field dataType;

public HL7V22Field DataType
{
    get
    {
        if (dataType != null)
        {
            return dataType;
        }

        dataType = new HL7V22Field
        {
            field = message[@"OM3"][8],
            Id = @"OM3.8",
            Type = @"Field",
            Position = @"OM3.8",
            Name = @"Data Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"the allowed data type for a single categorical observation (code A or C in OM1-19-nature of observation).",
            Sample = @"",
        };

        // check for repetitions
        if (dataType.field.FieldRepetitions != null && dataType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dataType.Id));
            dataType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(dataType, fieldData);
        }

        return dataType;
    } 
}
    }
}
