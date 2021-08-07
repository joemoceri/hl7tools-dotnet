using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentQRI
    {
        public readonly HL7V2Message message;

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
                            Description = @"This field contains a numeric value indicating the match weight or confidence level associated with the record.",
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
                            Description = @"This field contains a coded value indicating what search components (e.g., name, birth date, social security number) of the record returned matched the original query where the responding system does not assign numeric match weights or confidence levels. In short, it provides a method for passing a descriptive indication of why a particular record was found.",
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
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0393",
                            TableName = @"Match algorithms",
                            Description = @"This field contains a text value indicating the name or identity of the specific search algorithm to which the RCP-5 Search confidence threshold and the QRI-1 Candidate confidence refer. Note that there are sometimes significant differences among the algorithms in their numeric scales (e.g., one is 0-100, another might be 10 - 20) as well as their meanings of the same value (two algorithms with an 80% match might not return the same records). Refer to User-defined Table 0393 - Match algorithms for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.1",
                            Type = @"Component",
                            Position = @"QRI.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.2",
                            Type = @"Component",
                            Position = @"QRI.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.3",
                            Type = @"Component",
                            Position = @"QRI.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.4",
                            Type = @"Component",
                            Position = @"QRI.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.5",
                            Type = @"Component",
                            Position = @"QRI.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.6",
                            Type = @"Component",
                            Position = @"QRI.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.7",
                            Type = @"Component",
                            Position = @"QRI.3.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.8",
                            Type = @"Component",
                            Position = @"QRI.3.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRI.3.9",
                            Type = @"Component",
                            Position = @"QRI.3.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V26SegmentQRI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field candidateConfidence;

public HL7V26Field CandidateConfidence
{
    get
    {
        if (candidateConfidence != null)
        {
            return candidateConfidence;
        }

        candidateConfidence = new HL7V26Field
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
            Description = @"This field contains a numeric value indicating the match weight or confidence level associated with the record.",
            Sample = @"",
        };

        

        

        

        return candidateConfidence;
    } 
}
internal HL7V26Field matchReasonCode;

public HL7V26Field MatchReasonCode
{
    get
    {
        if (matchReasonCode != null)
        {
            return matchReasonCode;
        }

        matchReasonCode = new HL7V26Field
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
            Description = @"This field contains a coded value indicating what search components (e.g., name, birth date, social security number) of the record returned matched the original query where the responding system does not assign numeric match weights or confidence levels. In short, it provides a method for passing a descriptive indication of why a particular record was found.",
            Sample = @"",
        };

        

        

        

        return matchReasonCode;
    } 
}
internal HL7V26Field algorithmDescriptor;

public HL7V26Field AlgorithmDescriptor
{
    get
    {
        if (algorithmDescriptor != null)
        {
            return algorithmDescriptor;
        }

        algorithmDescriptor = new HL7V26Field
        {
            field = message[@"QRI"][3],
            Id = @"QRI.3",
            Type = @"Field",
            Position = @"QRI.3",
            Name = @"Algorithm Descriptor",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0393",
            TableName = @"Match algorithms",
            Description = @"This field contains a text value indicating the name or identity of the specific search algorithm to which the RCP-5 Search confidence threshold and the QRI-1 Candidate confidence refer. Note that there are sometimes significant differences among the algorithms in their numeric scales (e.g., one is 0-100, another might be 10 - 20) as well as their meanings of the same value (two algorithms with an 80% match might not return the same records). Refer to User-defined Table 0393 - Match algorithms for suggested values.",
            Sample = @"",
        };

        

        

        

        return algorithmDescriptor;
    } 
}

    }
}
