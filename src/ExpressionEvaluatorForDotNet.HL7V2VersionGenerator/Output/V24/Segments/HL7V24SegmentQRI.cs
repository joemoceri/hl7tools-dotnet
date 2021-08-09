using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentQRI
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QRI"; } }

        public string SegmentId { get { return @"QRI"; } }
        
        public string LongName { get { return @"Query Response Instance"; } }
        
        public string Description { get { return @"The QRI segment is used to indicate the weight match for a returned record (where the responding system employs a numeric algorithm) and/or the match reason code (where the responding system uses rules or other match options)."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

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
                            Id = @"QRI.1",
                            Type = @"Field",
                            Position = @"QRI.1",
                            Name = @"Candidate Confidence",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a numeric value indicating the match weight or confidence level associated with the record",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.2",
                            Type = @"Field",
                            Position = @"QRI.2",
                            Name = @"Match Reason Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0392",
                            TableName = @"Match reason",
                            Description = @"This field contains a coded value indicating what search components (e.g., name, birth date, social security number) of the record returned matched the original query where the responding system does not assign numeric match weights or confidence levels. In short, it provides a method for passing a descriptive indication of why a particular record was found",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3",
                            Type = @"Field",
                            Position = @"QRI.3",
                            Name = @"Algorithm Descriptor",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0393",
                            TableName = @"Match algorithms",
                            Description = @"This field contains a text value indicating the name or identity of the specific search algorithm to which the RCP-5 Search confidence threshold and the QRI-1 Candidate confidence refer. Note that there are sometimes significant differences among the algorithms in their numeric scales (e.g., one is 0100, another might be 10 – 20) as well as their meanings of the same value (two algorithms with an 80% match might not return the same records). Refer to User-defined Table 0393  - Match algorithms for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRI.3.1",
                            Type = @"Component",
                            Position = @"QRI.3.1",
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
                            Id = @"QRI.3.2",
                            Type = @"Component",
                            Position = @"QRI.3.2",
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
                            Id = @"QRI.3.3",
                            Type = @"Component",
                            Position = @"QRI.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.4",
                            Type = @"Component",
                            Position = @"QRI.3.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.5",
                            Type = @"Component",
                            Position = @"QRI.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.6",
                            Type = @"Component",
                            Position = @"QRI.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V24SegmentQRI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field candidateConfidence;

public HL7V24Field CandidateConfidence
{
    get
    {
        if (candidateConfidence != null)
        {
            return candidateConfidence;
        }

        candidateConfidence = new HL7V24Field
        {
            field = message[@"QRI"][1],
            Id = @"QRI.1",
            Type = @"Field",
            Position = @"QRI.1",
            Name = @"Candidate Confidence",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains a numeric value indicating the match weight or confidence level associated with the record",
            Sample = @"",
        };

        // check for repetitions
        if (candidateConfidence.field.FieldRepetitions != null && candidateConfidence.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(candidateConfidence.Id));
            candidateConfidence.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(candidateConfidence, fieldData);
        }

        return candidateConfidence;
    } 
}

internal HL7V24Field matchReasonCode;

public HL7V24Field MatchReasonCode
{
    get
    {
        if (matchReasonCode != null)
        {
            return matchReasonCode;
        }

        matchReasonCode = new HL7V24Field
        {
            field = message[@"QRI"][2],
            Id = @"QRI.2",
            Type = @"Field",
            Position = @"QRI.2",
            Name = @"Match Reason Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0392",
            TableName = @"Match reason",
            Description = @"This field contains a coded value indicating what search components (e.g., name, birth date, social security number) of the record returned matched the original query where the responding system does not assign numeric match weights or confidence levels. In short, it provides a method for passing a descriptive indication of why a particular record was found",
            Sample = @"",
        };

        // check for repetitions
        if (matchReasonCode.field.FieldRepetitions != null && matchReasonCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(matchReasonCode.Id));
            matchReasonCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(matchReasonCode, fieldData);
        }

        return matchReasonCode;
    } 
}

internal HL7V24Field algorithmDescriptor;

public HL7V24Field AlgorithmDescriptor
{
    get
    {
        if (algorithmDescriptor != null)
        {
            return algorithmDescriptor;
        }

        algorithmDescriptor = new HL7V24Field
        {
            field = message[@"QRI"][3],
            Id = @"QRI.3",
            Type = @"Field",
            Position = @"QRI.3",
            Name = @"Algorithm Descriptor",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0393",
            TableName = @"Match algorithms",
            Description = @"This field contains a text value indicating the name or identity of the specific search algorithm to which the RCP-5 Search confidence threshold and the QRI-1 Candidate confidence refer. Note that there are sometimes significant differences among the algorithms in their numeric scales (e.g., one is 0100, another might be 10 – 20) as well as their meanings of the same value (two algorithms with an 80% match might not return the same records). Refer to User-defined Table 0393  - Match algorithms for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (algorithmDescriptor.field.FieldRepetitions != null && algorithmDescriptor.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(algorithmDescriptor.Id));
            algorithmDescriptor.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(algorithmDescriptor, fieldData);
        }

        return algorithmDescriptor;
    } 
}
    }
}
