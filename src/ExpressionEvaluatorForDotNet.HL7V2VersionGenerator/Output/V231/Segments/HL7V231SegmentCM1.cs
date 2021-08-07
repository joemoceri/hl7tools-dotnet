using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentCM1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"CM1"; } }

        public string SegmentId { get { return @"CM1"; } }
        
        public string LongName { get { return @"Clinical study phase master segment"; } }
        
        public string Description { get { return @"Each Clinical Study Phase Master (CM1) segment contains the information about one phase of a study identified in the preceding CM0. This is an optional structure to be used if the study has more than one treatment or evaluation phase within it. The identification of study phases that the patient enters are sent in the CSP segment: sequence 2. The CM1 segment describes the phase in general for the receiving system."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CM1.1",
                            Type = @"Field",
                            Position = @"CM1.1",
                            Name = @"Set ID - CM1",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction. For those messages that permit segments to repeat, the Set IF field is used to identify the repetitions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM1.2",
                            Type = @"Field",
                            Position = @"CM1.2",
                            Name = @"Study Phase Identifier",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field should correspond to the study phase ID coding system in Section 7.7.2.1, 'Study phase ID.'",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CM1.2.1",
                            Type = @"Component",
                            Position = @"CM1.2.1",
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
                            Id = @"CM1.2.2",
                            Type = @"Component",
                            Position = @"CM1.2.2",
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
                            Id = @"CM1.2.3",
                            Type = @"Component",
                            Position = @"CM1.2.3",
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
                            Id = @"CM1.2.4",
                            Type = @"Component",
                            Position = @"CM1.2.4",
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
                            Id = @"CM1.2.5",
                            Type = @"Component",
                            Position = @"CM1.2.5",
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
                            Id = @"CM1.2.6",
                            Type = @"Component",
                            Position = @"CM1.2.6",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM1.3",
                            Type = @"Field",
                            Position = @"CM1.3",
                            Name = @"Description of Study Phase",
                            Length = 300,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a brief explanation for recipients to understand what the phase represents.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V231SegmentCM1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field setIDCM1;

public HL7V231Field SetIDCM1
{
    get
    {
        if (setIDCM1 != null)
        {
            return setIDCM1;
        }

        setIDCM1 = new HL7V231Field
        {
            field = message[@"CM1"][1],
            Id = @"CM1.1",
            Type = @"Field",
            Position = @"CM1.1",
            Name = @"Set ID - CM1",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction. For those messages that permit segments to repeat, the Set IF field is used to identify the repetitions.",
            Sample = @"",
        };

        

        

        

        return setIDCM1;
    } 
}
internal HL7V231Field studyPhaseIdentifier;

public HL7V231Field StudyPhaseIdentifier
{
    get
    {
        if (studyPhaseIdentifier != null)
        {
            return studyPhaseIdentifier;
        }

        studyPhaseIdentifier = new HL7V231Field
        {
            field = message[@"CM1"][2],
            Id = @"CM1.2",
            Type = @"Field",
            Position = @"CM1.2",
            Name = @"Study Phase Identifier",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field should correspond to the study phase ID coding system in Section 7.7.2.1, 'Study phase ID.'",
            Sample = @"",
        };

        

        

        

        return studyPhaseIdentifier;
    } 
}
internal HL7V231Field descriptionofStudyPhase;

public HL7V231Field DescriptionofStudyPhase
{
    get
    {
        if (descriptionofStudyPhase != null)
        {
            return descriptionofStudyPhase;
        }

        descriptionofStudyPhase = new HL7V231Field
        {
            field = message[@"CM1"][3],
            Id = @"CM1.3",
            Type = @"Field",
            Position = @"CM1.3",
            Name = @"Description of Study Phase",
            Length = 300,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a brief explanation for recipients to understand what the phase represents.",
            Sample = @"",
        };

        

        

        

        return descriptionofStudyPhase;
    } 
}

    }
}
