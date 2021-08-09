using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentVTQ
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"VTQ"; } }

        public string SegmentId { get { return @"VTQ"; } }
        
        public string LongName { get { return @"Virtual Table Query Request"; } }
        
        public string Description { get { return @"This segment is not carried forward to the recommended queries for v 2.4.

The VTQ segment is used to define queries that are responded to with the Tabular Data Message (TBR).  The VTQ query message is an alternate method to the EQQ query message that some systems may find easier to implement, due to its use of HL7 delimiters that separate components of the selection definition, and its limited selection criteria.  Queries involving complex selection criteria (nested operators, etc.) may need to be formatted as an EQL segment. "; } }
        
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
                            Id = @"VTQ.1",
                            Type = @"Field",
                            Position = @"VTQ.1",
                            Name = @"Query Tag",
                            Length = 32,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2Message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VTQ.2",
                            Type = @"Field",
                            Position = @"VTQ.2",
                            Name = @"Query/Response Format Code",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0106",
                            TableName = @"Query/response format code",
                            Description = @"This field refers to HL7 Table 0106 - Query/response format code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VTQ.3",
                            Type = @"Field",
                            Position = @"VTQ.3",
                            Name = @"VT Query Name",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the Virtual Table query.  These names are assigned by the function-specific chapters of this specification.  Site-specific VT query names begin with the letter “Z.”",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"VTQ.3.1",
                            Type = @"Component",
                            Position = @"VTQ.3.1",
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
                            Id = @"VTQ.3.2",
                            Type = @"Component",
                            Position = @"VTQ.3.2",
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
                            Id = @"VTQ.3.3",
                            Type = @"Component",
                            Position = @"VTQ.3.3",
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
                            Id = @"VTQ.3.4",
                            Type = @"Component",
                            Position = @"VTQ.3.4",
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
                            Id = @"VTQ.3.5",
                            Type = @"Component",
                            Position = @"VTQ.3.5",
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
                            Id = @"VTQ.3.6",
                            Type = @"Component",
                            Position = @"VTQ.3.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VTQ.4",
                            Type = @"Field",
                            Position = @"VTQ.4",
                            Name = @"Virtual Table Name",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the Virtual Table being referenced.  This table name may refer to an HL7-defined segment, an HL7 Virtual Table (refer to the functional chapters), or a site-specific “Z table.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"VTQ.4.1",
                            Type = @"Component",
                            Position = @"VTQ.4.1",
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
                            Id = @"VTQ.4.2",
                            Type = @"Component",
                            Position = @"VTQ.4.2",
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
                            Id = @"VTQ.4.3",
                            Type = @"Component",
                            Position = @"VTQ.4.3",
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
                            Id = @"VTQ.4.4",
                            Type = @"Component",
                            Position = @"VTQ.4.4",
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
                            Id = @"VTQ.4.5",
                            Type = @"Component",
                            Position = @"VTQ.4.5",
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
                            Id = @"VTQ.4.6",
                            Type = @"Component",
                            Position = @"VTQ.4.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VTQ.5",
                            Type = @"Field",
                            Position = @"VTQ.5",
                            Name = @"Selection Criteria",
                            Length = 256,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"QSC",
                            DataTypeName = @"Query Selection Criteria",
                            TableId = null,
                            TableName = null,
                            Description = @"Each repetition of this field defines a column in the RDT segment: the first repetition defines the first column of the RDT segment; the second repetition defines the second column of the RDT segments, etc.

This field indicates the conditions that qualify the rows to be returned in the query response.  (This field conveys the same information as the “WHERE” clause in the corresponding SQL expression of the query, but is formatted differently.)   It is comprised of the following components: 

  The segment field name that is participating as a qualifier (usually the “key”).

  A relational operator, refer to HL7 Table 0209 - Relational operator for valid values.

  The value to which the field will be compared.

If more than one comparison is to be made to select qualifying rows, a conjunction (defined by HL7 Table 0210 - Relational conjunction) relating this repetition of the field to the next: ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"VTQ.5.1",
                            Type = @"Component",
                            Position = @"VTQ.5.1",
                            Name = @"Segment Field Name",
                            Length = 12,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the field that is participating as a qualifier (usually the ""key""). Refer to Section 2.A.59.1,  Segment Field Name (ST) , for segment field name conventions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VTQ.5.2",
                            Type = @"Component",
                            Position = @"VTQ.5.2",
                            Name = @"Relational Operator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0209",
                            TableName = @"Relational operator",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VTQ.5.3",
                            Type = @"Component",
                            Position = @"VTQ.5.3",
                            Name = @"Value",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The value to which the field will be compared.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VTQ.5.4",
                            Type = @"Component",
                            Position = @"VTQ.5.4",
                            Name = @"Relational Conjunction",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0210",
                            TableName = @"Relational conjunction",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V25SegmentVTQ(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field queryTag;

public HL7V25Field QueryTag
{
    get
    {
        if (queryTag != null)
        {
            return queryTag;
        }

        queryTag = new HL7V25Field
        {
            field = message[@"VTQ"][1],
            Id = @"VTQ.1",
            Type = @"Field",
            Position = @"VTQ.1",
            Name = @"Query Tag",
            Length = 32,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2Message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole. ",
            Sample = @"",
        };

        // check for repetitions
        if (queryTag.field.FieldRepetitions != null && queryTag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(queryTag.Id));
            queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(queryTag, fieldData);
        }

        return queryTag;
    } 
}

internal HL7V25Field queryResponseFormatCode;

public HL7V25Field QueryResponseFormatCode
{
    get
    {
        if (queryResponseFormatCode != null)
        {
            return queryResponseFormatCode;
        }

        queryResponseFormatCode = new HL7V25Field
        {
            field = message[@"VTQ"][2],
            Id = @"VTQ.2",
            Type = @"Field",
            Position = @"VTQ.2",
            Name = @"Query/Response Format Code",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0106",
            TableName = @"Query/response format code",
            Description = @"This field refers to HL7 Table 0106 - Query/response format code for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (queryResponseFormatCode.field.FieldRepetitions != null && queryResponseFormatCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(queryResponseFormatCode.Id));
            queryResponseFormatCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(queryResponseFormatCode, fieldData);
        }

        return queryResponseFormatCode;
    } 
}

internal HL7V25Field vTQueryName;

public HL7V25Field VTQueryName
{
    get
    {
        if (vTQueryName != null)
        {
            return vTQueryName;
        }

        vTQueryName = new HL7V25Field
        {
            field = message[@"VTQ"][3],
            Id = @"VTQ.3",
            Type = @"Field",
            Position = @"VTQ.3",
            Name = @"VT Query Name",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the Virtual Table query.  These names are assigned by the function-specific chapters of this specification.  Site-specific VT query names begin with the letter “Z.”",
            Sample = @"",
        };

        // check for repetitions
        if (vTQueryName.field.FieldRepetitions != null && vTQueryName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(vTQueryName.Id));
            vTQueryName.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(vTQueryName, fieldData);
        }

        return vTQueryName;
    } 
}

internal HL7V25Field virtualTableName;

public HL7V25Field VirtualTableName
{
    get
    {
        if (virtualTableName != null)
        {
            return virtualTableName;
        }

        virtualTableName = new HL7V25Field
        {
            field = message[@"VTQ"][4],
            Id = @"VTQ.4",
            Type = @"Field",
            Position = @"VTQ.4",
            Name = @"Virtual Table Name",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the Virtual Table being referenced.  This table name may refer to an HL7-defined segment, an HL7 Virtual Table (refer to the functional chapters), or a site-specific “Z table.",
            Sample = @"",
        };

        // check for repetitions
        if (virtualTableName.field.FieldRepetitions != null && virtualTableName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(virtualTableName.Id));
            virtualTableName.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(virtualTableName, fieldData);
        }

        return virtualTableName;
    } 
}

internal HL7V25Field selectionCriteria;

public HL7V25Field SelectionCriteria
{
    get
    {
        if (selectionCriteria != null)
        {
            return selectionCriteria;
        }

        selectionCriteria = new HL7V25Field
        {
            field = message[@"VTQ"][5],
            Id = @"VTQ.5",
            Type = @"Field",
            Position = @"VTQ.5",
            Name = @"Selection Criteria",
            Length = 256,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"QSC",
            DataTypeName = @"Query Selection Criteria",
            TableId = null,
            TableName = null,
            Description = @"Each repetition of this field defines a column in the RDT segment: the first repetition defines the first column of the RDT segment; the second repetition defines the second column of the RDT segments, etc.

This field indicates the conditions that qualify the rows to be returned in the query response.  (This field conveys the same information as the “WHERE” clause in the corresponding SQL expression of the query, but is formatted differently.)   It is comprised of the following components: 

  The segment field name that is participating as a qualifier (usually the “key”).

  A relational operator, refer to HL7 Table 0209 - Relational operator for valid values.

  The value to which the field will be compared.

If more than one comparison is to be made to select qualifying rows, a conjunction (defined by HL7 Table 0210 - Relational conjunction) relating this repetition of the field to the next: ",
            Sample = @"",
        };

        // check for repetitions
        if (selectionCriteria.field.FieldRepetitions != null && selectionCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(selectionCriteria.Id));
            selectionCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(selectionCriteria, fieldData);
        }

        return selectionCriteria;
    } 
}
    }
}
