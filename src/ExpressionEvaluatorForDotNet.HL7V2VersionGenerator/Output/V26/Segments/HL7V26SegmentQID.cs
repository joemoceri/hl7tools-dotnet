using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentQID
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QID"; } }

        public string SegmentId { get { return @"QID"; } }
        
        public string LongName { get { return @"Query Identification"; } }
        
        public string Description { get { return @"The QID segment contains the information necessary to uniquely identify a query. Its primary use is in query cancellation or subscription cancellation."; } }
        
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
                            Id = @"QID.1",
                            Type = @"Field",
                            Position = @"QID.1",
                            Name = @"Query Tag",
                            Length = 32,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the instance of a query.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QID.2",
                            Type = @"Field",
                            Position = @"QID.2",
                            Name = @"Message Query Name",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0471",
                            TableName = @"Query name",
                            Description = @"This field contains the name of the query. These names are assigned by the function-specific chapters of this specification. Site-specific query names begin with the letter ""Z."" Refer to User defined table 0471 - Query name for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QID.2.1",
                            Type = @"Component",
                            Position = @"QID.2.1",
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
                            Id = @"QID.2.2",
                            Type = @"Component",
                            Position = @"QID.2.2",
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
                            Id = @"QID.2.3",
                            Type = @"Component",
                            Position = @"QID.2.3",
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
                            Id = @"QID.2.4",
                            Type = @"Component",
                            Position = @"QID.2.4",
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
                            Id = @"QID.2.5",
                            Type = @"Component",
                            Position = @"QID.2.5",
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
                            Id = @"QID.2.6",
                            Type = @"Component",
                            Position = @"QID.2.6",
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
                            Id = @"QID.2.7",
                            Type = @"Component",
                            Position = @"QID.2.7",
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
                            Id = @"QID.2.8",
                            Type = @"Component",
                            Position = @"QID.2.8",
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
                            Id = @"QID.2.9",
                            Type = @"Component",
                            Position = @"QID.2.9",
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
                        },}
                        },
                        };
            }
        }

        public HL7V26SegmentQID(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field queryTag;

public HL7V26Field QueryTag
{
    get
    {
        if (queryTag != null)
        {
            return queryTag;
        }

        queryTag = new HL7V26Field
        {
            field = message[@"QID"][1],
            Id = @"QID.1",
            Type = @"Field",
            Position = @"QID.1",
            Name = @"Query Tag",
            Length = 32,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the instance of a query.",
            Sample = @"",
        };

        // check for repetitions
        if (queryTag.field.FieldRepetitions != null && queryTag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(queryTag.Id));
            queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(queryTag, fieldData);
        }

        return queryTag;
    } 
}

internal HL7V26Field messageQueryName;

public HL7V26Field MessageQueryName
{
    get
    {
        if (messageQueryName != null)
        {
            return messageQueryName;
        }

        messageQueryName = new HL7V26Field
        {
            field = message[@"QID"][2],
            Id = @"QID.2",
            Type = @"Field",
            Position = @"QID.2",
            Name = @"Message Query Name",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0471",
            TableName = @"Query name",
            Description = @"This field contains the name of the query. These names are assigned by the function-specific chapters of this specification. Site-specific query names begin with the letter ""Z."" Refer to User defined table 0471 - Query name for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (messageQueryName.field.FieldRepetitions != null && messageQueryName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageQueryName.Id));
            messageQueryName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(messageQueryName, fieldData);
        }

        return messageQueryName;
    } 
}
    }
}
