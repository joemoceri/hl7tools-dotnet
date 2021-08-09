using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentQAK
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QAK"; } }

        public string SegmentId { get { return @"QAK"; } }
        
        public string LongName { get { return @"Query Acknowledgment"; } }
        
        public string Description { get { return @"The QAK segment contains information sent with responses to a query. Although the QAK segment is required in the responses to the enhanced queries (see section 5.10.4), it may appear as an optional segment placed after the (optional) ERR segment in any query response (message) to any original mode query."; } }
        
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
                            Id = @"QAK.1",
                            Type = @"Field",
                            Position = @"QAK.1",
                            Name = @"Query Tag",
                            Length = 32,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query. If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK). This field differs from MSA-2-message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole. QAK-1-Query tag is not conditional on the presence of the QRD-1-Query ID field in the original mode queries: in the original mode queries QAK-1-Query tag is not used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.2",
                            Type = @"Field",
                            Position = @"QAK.2",
                            Name = @"Query Response Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0208",
                            TableName = @"Query response status",
                            Description = @"This field allows the responding system to return a precise response status. It is especially useful in the case where no data is found that matches the query parameters, but where there is also no error. It is defined with HL7 Table 0208 - Query response status .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.3",
                            Type = @"Field",
                            Position = @"QAK.3",
                            Name = @"Message Query Name",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the query. These names are assigned by the function-specific chapters of this specification. Site-specific event replay query names begin with the letter Z. Refer to User defined table 0471 - Query name for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QAK.3.1",
                            Type = @"Component",
                            Position = @"QAK.3.1",
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
                            Id = @"QAK.3.2",
                            Type = @"Component",
                            Position = @"QAK.3.2",
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
                            Id = @"QAK.3.3",
                            Type = @"Component",
                            Position = @"QAK.3.3",
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
                            Id = @"QAK.3.4",
                            Type = @"Component",
                            Position = @"QAK.3.4",
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
                            Id = @"QAK.3.5",
                            Type = @"Component",
                            Position = @"QAK.3.5",
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
                            Id = @"QAK.3.6",
                            Type = @"Component",
                            Position = @"QAK.3.6",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.4",
                            Type = @"Field",
                            Position = @"QAK.4",
                            Name = @"Hit Count Total",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field, when used, contains the total number of records found by the Server that matched the query. For tabular responses, this is the number of rows found. For other response types, the Conformance Statement defines the meaning of a hit.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.5",
                            Type = @"Field",
                            Position = @"QAK.5",
                            Name = @"This payload",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field, when used, contains the total number of matching records that the Server sent in the current response. Where the continuation protocol is used to transmit the response in partial installments, this number will differ from the value sent in QAK-4-Hit count total .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.6",
                            Type = @"Field",
                            Position = @"QAK.6",
                            Name = @"Hits remaining",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field, when used, contains the number of matching records found by the Server that have yet to be sent. It is only meaningful when the Server uses the continuation protocol to transmit partial responses.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentQAK(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field queryTag;

public HL7V24Field QueryTag
{
    get
    {
        if (queryTag != null)
        {
            return queryTag;
        }

        queryTag = new HL7V24Field
        {
            field = message[@"QAK"][1],
            Id = @"QAK.1",
            Type = @"Field",
            Position = @"QAK.1",
            Name = @"Query Tag",
            Length = 32,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query. If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK). This field differs from MSA-2-message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole. QAK-1-Query tag is not conditional on the presence of the QRD-1-Query ID field in the original mode queries: in the original mode queries QAK-1-Query tag is not used.",
            Sample = @"",
        };

        // check for repetitions
        if (queryTag.field.FieldRepetitions != null && queryTag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(queryTag.Id));
            queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(queryTag, fieldData);
        }

        return queryTag;
    } 
}

internal HL7V24Field queryResponseStatus;

public HL7V24Field QueryResponseStatus
{
    get
    {
        if (queryResponseStatus != null)
        {
            return queryResponseStatus;
        }

        queryResponseStatus = new HL7V24Field
        {
            field = message[@"QAK"][2],
            Id = @"QAK.2",
            Type = @"Field",
            Position = @"QAK.2",
            Name = @"Query Response Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0208",
            TableName = @"Query response status",
            Description = @"This field allows the responding system to return a precise response status. It is especially useful in the case where no data is found that matches the query parameters, but where there is also no error. It is defined with HL7 Table 0208 - Query response status .",
            Sample = @"",
        };

        // check for repetitions
        if (queryResponseStatus.field.FieldRepetitions != null && queryResponseStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(queryResponseStatus.Id));
            queryResponseStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(queryResponseStatus, fieldData);
        }

        return queryResponseStatus;
    } 
}

internal HL7V24Field messageQueryName;

public HL7V24Field MessageQueryName
{
    get
    {
        if (messageQueryName != null)
        {
            return messageQueryName;
        }

        messageQueryName = new HL7V24Field
        {
            field = message[@"QAK"][3],
            Id = @"QAK.3",
            Type = @"Field",
            Position = @"QAK.3",
            Name = @"Message Query Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the query. These names are assigned by the function-specific chapters of this specification. Site-specific event replay query names begin with the letter Z. Refer to User defined table 0471 - Query name for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (messageQueryName.field.FieldRepetitions != null && messageQueryName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageQueryName.Id));
            messageQueryName.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(messageQueryName, fieldData);
        }

        return messageQueryName;
    } 
}

internal HL7V24Field hitCountTotal;

public HL7V24Field HitCountTotal
{
    get
    {
        if (hitCountTotal != null)
        {
            return hitCountTotal;
        }

        hitCountTotal = new HL7V24Field
        {
            field = message[@"QAK"][4],
            Id = @"QAK.4",
            Type = @"Field",
            Position = @"QAK.4",
            Name = @"Hit Count Total",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field, when used, contains the total number of records found by the Server that matched the query. For tabular responses, this is the number of rows found. For other response types, the Conformance Statement defines the meaning of a hit.",
            Sample = @"",
        };

        // check for repetitions
        if (hitCountTotal.field.FieldRepetitions != null && hitCountTotal.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(hitCountTotal.Id));
            hitCountTotal.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(hitCountTotal, fieldData);
        }

        return hitCountTotal;
    } 
}

internal HL7V24Field thispayload;

public HL7V24Field Thispayload
{
    get
    {
        if (thispayload != null)
        {
            return thispayload;
        }

        thispayload = new HL7V24Field
        {
            field = message[@"QAK"][5],
            Id = @"QAK.5",
            Type = @"Field",
            Position = @"QAK.5",
            Name = @"This payload",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field, when used, contains the total number of matching records that the Server sent in the current response. Where the continuation protocol is used to transmit the response in partial installments, this number will differ from the value sent in QAK-4-Hit count total .",
            Sample = @"",
        };

        // check for repetitions
        if (thispayload.field.FieldRepetitions != null && thispayload.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(thispayload.Id));
            thispayload.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(thispayload, fieldData);
        }

        return thispayload;
    } 
}

internal HL7V24Field hitsremaining;

public HL7V24Field Hitsremaining
{
    get
    {
        if (hitsremaining != null)
        {
            return hitsremaining;
        }

        hitsremaining = new HL7V24Field
        {
            field = message[@"QAK"][6],
            Id = @"QAK.6",
            Type = @"Field",
            Position = @"QAK.6",
            Name = @"Hits remaining",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field, when used, contains the number of matching records found by the Server that have yet to be sent. It is only meaningful when the Server uses the continuation protocol to transmit partial responses.",
            Sample = @"",
        };

        // check for repetitions
        if (hitsremaining.field.FieldRepetitions != null && hitsremaining.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(hitsremaining.Id));
            hitsremaining.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(hitsremaining, fieldData);
        }

        return hitsremaining;
    } 
}
    }
}
