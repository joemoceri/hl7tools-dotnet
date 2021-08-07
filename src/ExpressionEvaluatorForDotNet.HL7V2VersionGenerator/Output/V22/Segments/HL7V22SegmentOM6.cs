using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentOM6
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"OM6"; } }

        public string SegmentId { get { return @"OM6"; } }
        
        public string LongName { get { return @"Observations That Are Calculated From Other Obersvations"; } }
        
        public string Description { get { return @"This segment contains information about quantities that are derived from one or more other quantities or direct observations by mathematical or logical means"; } }
        
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
                            Id = @"OM6.1",
                            Type = @"Field",
                            Position = @"OM6.1",
                            Name = @"Segment Type Id",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the string OM6 - identifies a record as an observation that is derived or calculated from one or more other observations",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM6.2",
                            Type = @"Field",
                            Position = @"OM6.2",
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
                            Id = @"OM6.3",
                            Type = @"Field",
                            Position = @"OM6.3",
                            Name = @"Derivation Rule",
                            Length = 10240,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"in the case of patient variables that are derived from one or more other patient variables (e.g., creatinine clearance, ideal weight, maximum daily temperature, average glucose, framingham risk), this field contains the rules for deriving the value of this variable (i.e., nature code C, as given in OM1-19-nature of test/observation).  These can be described in terms of humanly understandable formulas or descriptions",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentOM6(HL7V2Message message)
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
            field = message[@"OM6"][1],
            Id = @"OM6.1",
            Type = @"Field",
            Position = @"OM6.1",
            Name = @"Segment Type Id",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"the string OM6 - identifies a record as an observation that is derived or calculated from one or more other observations",
            Sample = @"",
        };

        

        

        

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
            field = message[@"OM6"][2],
            Id = @"OM6.2",
            Type = @"Field",
            Position = @"OM6.2",
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

        

        

        

        return sequenceNumberTestObservationMasterFile;
    } 
}
internal HL7V22Field derivationRule;

public HL7V22Field DerivationRule
{
    get
    {
        if (derivationRule != null)
        {
            return derivationRule;
        }

        derivationRule = new HL7V22Field
        {
            field = message[@"OM6"][3],
            Id = @"OM6.3",
            Type = @"Field",
            Position = @"OM6.3",
            Name = @"Derivation Rule",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"in the case of patient variables that are derived from one or more other patient variables (e.g., creatinine clearance, ideal weight, maximum daily temperature, average glucose, framingham risk), this field contains the rules for deriving the value of this variable (i.e., nature code C, as given in OM1-19-nature of test/observation).  These can be described in terms of humanly understandable formulas or descriptions",
            Sample = @"",
        };

        

        

        

        return derivationRule;
    } 
}

    }
}
