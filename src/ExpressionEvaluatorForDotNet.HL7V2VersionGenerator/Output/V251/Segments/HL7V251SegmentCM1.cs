using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentCM1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"CM1"; } }

        public string SegmentId { get { return @"CM1"; } }
        
        public string LongName { get { return @"Clinical Study Phase Master"; } }
        
        public string Description { get { return @"Each Clinical Study Phase Master (CM1) segment contains the information about one phase of a study identified in the preceding CM0.  This is an optional structure to be used if the study has more than one treatment or evaluation phase within it.  The identification of study phases that the patient enters are sent in the CSP segment: sequence 2.  The CM1 segment describes the phase in general for the receiving system."; } }
        
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
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field should correspond to the study phase ID coding system in CSP-1 - ""Study phase Identifier.""",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CM1.2.1",
                            Type = @"Component",
                            Position = @"CM1.2.1",
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
                            Id = @"CM1.2.2",
                            Type = @"Component",
                            Position = @"CM1.2.2",
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
                            Id = @"CM1.2.3",
                            Type = @"Component",
                            Position = @"CM1.2.3",
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
                            Id = @"CM1.2.4",
                            Type = @"Component",
                            Position = @"CM1.2.4",
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
                            Id = @"CM1.2.5",
                            Type = @"Component",
                            Position = @"CM1.2.5",
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
                            Id = @"CM1.2.6",
                            Type = @"Component",
                            Position = @"CM1.2.6",
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

        public HL7V251SegmentCM1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field setIDCM1;

public HL7V251Field SetIDCM1
{
    get
    {
        if (setIDCM1 != null)
        {
            return setIDCM1;
        }

        setIDCM1 = new HL7V251Field
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
internal HL7V251Field studyPhaseIdentifier;

public HL7V251Field StudyPhaseIdentifier
{
    get
    {
        if (studyPhaseIdentifier != null)
        {
            return studyPhaseIdentifier;
        }

        studyPhaseIdentifier = new HL7V251Field
        {
            field = message[@"CM1"][2],
            Id = @"CM1.2",
            Type = @"Field",
            Position = @"CM1.2",
            Name = @"Study Phase Identifier",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field should correspond to the study phase ID coding system in CSP-1 - ""Study phase Identifier.""",
            Sample = @"",
        };

        

        

        

        return studyPhaseIdentifier;
    } 
}
internal HL7V251Field descriptionofStudyPhase;

public HL7V251Field DescriptionofStudyPhase
{
    get
    {
        if (descriptionofStudyPhase != null)
        {
            return descriptionofStudyPhase;
        }

        descriptionofStudyPhase = new HL7V251Field
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
