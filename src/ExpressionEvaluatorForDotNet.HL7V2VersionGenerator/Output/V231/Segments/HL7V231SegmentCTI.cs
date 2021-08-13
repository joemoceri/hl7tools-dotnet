using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentCTI
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CTI"; } }

        public string SegmentId { get { return @"CTI"; } }
        
        public string LongName { get { return @"Clinical trial identification segment"; } }
        
        public string Description { get { return @"The CTI segment is an optional segment that contains information to identify the clinical trial, phase and time point with which an order or result is associated."; } }
        
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

        public HL7V231SegmentCTI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _sponsorStudyID;

public HL7V231Field SponsorStudyID
{
    get
    {
        if (_sponsorStudyID != null)
        {
            return _sponsorStudyID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"CTI.1",
            Type = @"Field",
            Position = @"CTI.1",
            Name = @"Sponsor Study ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the universal identifier for the clinical trial. The coding system is as described in CSR-1-sponsor study ID .",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CTI.1.1",
                            Type = @"Component",
                            Position = @"CTI.1.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTI.1.2",
                            Type = @"Component",
                            Position = @"CTI.1.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTI.1.3",
                            Type = @"Component",
                            Position = @"CTI.1.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTI.1.4",
                            Type = @"Component",
                            Position = @"CTI.1.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _sponsorStudyID = new HL7V231Field
        {
            field = message[@"CTI"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sponsorStudyID.field.FieldRepetitions != null && _sponsorStudyID.field.FieldRepetitions.Count > 0)
        {
            _sponsorStudyID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_sponsorStudyID, fieldData);
        }

        return _sponsorStudyID;
    } 
}

internal HL7V231Field _studyPhaseIdentifier;

public HL7V231Field StudyPhaseIdentifier
{
    get
    {
        if (_studyPhaseIdentifier != null)
        {
            return _studyPhaseIdentifier;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"CTI.2",
            Type = @"Field",
            Position = @"CTI.2",
            Name = @"Study Phase Identifier",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the phase of the study that a patient has entered. See CSP-1-study phase identifier for details of coding systems.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CTI.2.1",
                            Type = @"Component",
                            Position = @"CTI.2.1",
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
                            Id = @"CTI.2.2",
                            Type = @"Component",
                            Position = @"CTI.2.2",
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
                            Id = @"CTI.2.3",
                            Type = @"Component",
                            Position = @"CTI.2.3",
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
                            Id = @"CTI.2.4",
                            Type = @"Component",
                            Position = @"CTI.2.4",
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
                            Id = @"CTI.2.5",
                            Type = @"Component",
                            Position = @"CTI.2.5",
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
                            Id = @"CTI.2.6",
                            Type = @"Component",
                            Position = @"CTI.2.6",
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

        _studyPhaseIdentifier = new HL7V231Field
        {
            field = message[@"CTI"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyPhaseIdentifier.field.FieldRepetitions != null && _studyPhaseIdentifier.field.FieldRepetitions.Count > 0)
        {
            _studyPhaseIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_studyPhaseIdentifier, fieldData);
        }

        return _studyPhaseIdentifier;
    } 
}

internal HL7V231Field _studyScheduledTimePoint;

public HL7V231Field StudyScheduledTimePoint
{
    get
    {
        if (_studyScheduledTimePoint != null)
        {
            return _studyScheduledTimePoint;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"CTI.3",
            Type = @"Field",
            Position = @"CTI.3",
            Name = @"Study Scheduled Time Point",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies a time point in the clinical trial phase. CTI-2-study phase identifier must be valued if CTI-3-study scheduled time point is valued. Should correspond to CSS-1-study scheduled time point .",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CTI.3.1",
                            Type = @"Component",
                            Position = @"CTI.3.1",
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
                            Id = @"CTI.3.2",
                            Type = @"Component",
                            Position = @"CTI.3.2",
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
                            Id = @"CTI.3.3",
                            Type = @"Component",
                            Position = @"CTI.3.3",
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
                            Id = @"CTI.3.4",
                            Type = @"Component",
                            Position = @"CTI.3.4",
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
                            Id = @"CTI.3.5",
                            Type = @"Component",
                            Position = @"CTI.3.5",
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
                            Id = @"CTI.3.6",
                            Type = @"Component",
                            Position = @"CTI.3.6",
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

        _studyScheduledTimePoint = new HL7V231Field
        {
            field = message[@"CTI"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyScheduledTimePoint.field.FieldRepetitions != null && _studyScheduledTimePoint.field.FieldRepetitions.Count > 0)
        {
            _studyScheduledTimePoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_studyScheduledTimePoint, fieldData);
        }

        return _studyScheduledTimePoint;
    } 
}
    }
}
