using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentOM6
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM6"; } }

        public string SegmentId { get { return @"OM6"; } }
        
        public string LongName { get { return @"Observations that are calculated from other observations"; } }
        
        public string Description { get { return @"This segment contains the information about quantities that are derived from one or more other quantities or direct observations by mathematical or logical means"; } }
        
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
                            Id = @"OM6.1",
                            Type = @"Field",
                            Position = @"OM6.1",
                            Name = @"Sequence Number",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the same value as the sequence number of the associated OM1 segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM6.2",
                            Type = @"Field",
                            Position = @"OM6.2",
                            Name = @"Derivation Rule",
                            Length = 10240,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used when there are patient variables that are derived from one or more other patient variables (e.g., creatinine clearance, ideal weight, maximum daily temperature, average glucose, framingham risk).  This field contains the rules for deriving the value of this variable (i.e., nature code C, as given in OM1-18-nature of test/observation).  These can be described in terms of humanly understandable formulas or descriptions. 

When possible, however, they should be defined in terms of the Arden Syntax for specifying selection and transcendative functions and algebraic operations, ASTM E1460-92.  Derivation rules that are represented in Arden Syntax should begin and end with an Arden slot delimiter (;;).  Within this syntax, variables should be identified by OM1-3-producer's test/observation ID.  We recommend the use of the Arden Syntax because it permits the unambiguous specification of most such derived values and is a published standard for medical logic modules",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentOM6(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field sequenceNumber;

public HL7V23Field SequenceNumber
{
    get
    {
        if (sequenceNumber != null)
        {
            return sequenceNumber;
        }

        sequenceNumber = new HL7V23Field
        {
            field = message[@"OM6"][1],
            Id = @"OM6.1",
            Type = @"Field",
            Position = @"OM6.1",
            Name = @"Sequence Number",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the same value as the sequence number of the associated OM1 segment",
            Sample = @"",
        };

        // check for repetitions
        if (sequenceNumber.field.FieldRepetitions != null && sequenceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceNumber.Id));
            sequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(sequenceNumber, fieldData);
        }

        return sequenceNumber;
    } 
}

internal HL7V23Field derivationRule;

public HL7V23Field DerivationRule
{
    get
    {
        if (derivationRule != null)
        {
            return derivationRule;
        }

        derivationRule = new HL7V23Field
        {
            field = message[@"OM6"][2],
            Id = @"OM6.2",
            Type = @"Field",
            Position = @"OM6.2",
            Name = @"Derivation Rule",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used when there are patient variables that are derived from one or more other patient variables (e.g., creatinine clearance, ideal weight, maximum daily temperature, average glucose, framingham risk).  This field contains the rules for deriving the value of this variable (i.e., nature code C, as given in OM1-18-nature of test/observation).  These can be described in terms of humanly understandable formulas or descriptions. 

When possible, however, they should be defined in terms of the Arden Syntax for specifying selection and transcendative functions and algebraic operations, ASTM E1460-92.  Derivation rules that are represented in Arden Syntax should begin and end with an Arden slot delimiter (;;).  Within this syntax, variables should be identified by OM1-3-producer's test/observation ID.  We recommend the use of the Arden Syntax because it permits the unambiguous specification of most such derived values and is a published standard for medical logic modules",
            Sample = @"",
        };

        // check for repetitions
        if (derivationRule.field.FieldRepetitions != null && derivationRule.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(derivationRule.Id));
            derivationRule.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(derivationRule, fieldData);
        }

        return derivationRule;
    } 
}
    }
}
