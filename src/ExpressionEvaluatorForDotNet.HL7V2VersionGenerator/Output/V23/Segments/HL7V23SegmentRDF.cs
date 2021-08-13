using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentRDF
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RDF"; } }

        public string SegmentId { get { return @"RDF"; } }
        
        public string LongName { get { return @"Table Row Definition"; } }
        
        public string Description { get { return @"The RDF segment defines the content of the row data segments (RDT) in the Tabular Data Response Message (TBR).  It is used in two ways:
 
- As an optional segment in the SPQ message (Stored Procedure Request) or the VQQ (Virtual Table Query) message, this segment can be used to limit the number of columns returned and to specify what column positions the fields occupy (where supported, these features can be used to override the defaults for the particular query).  If omitted, all fields defined for the query are returned in their default column order. 
- As a required segment on the tabular data response message (TBR), this segment defines the contents of the table row data (RDT) segments that follow. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V23SegmentRDF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _numberofColumnsperRow;

public HL7V23Field NumberofColumnsperRow
{
    get
    {
        if (_numberofColumnsperRow != null)
        {
            return _numberofColumnsperRow;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RDF.1",
            Type = @"Field",
            Position = @"RDF.1",
            Name = @"Number of Columns per Row",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the number of data columns (and therefore the number of fields) contained within each row of returned data",
            Sample = @"",
            Fields = null
        }

        _numberofColumnsperRow = new HL7V23Field
        {
            field = message[@"RDF"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberofColumnsperRow.field.FieldRepetitions != null && _numberofColumnsperRow.field.FieldRepetitions.Count > 0)
        {
            _numberofColumnsperRow.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_numberofColumnsperRow, fieldData);
        }

        return _numberofColumnsperRow;
    } 
}

internal HL7V23Field _columnDescription;

public HL7V23Field ColumnDescription
{
    get
    {
        if (_columnDescription != null)
        {
            return _columnDescription;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RDF.2",
            Type = @"Field",
            Position = @"RDF.2",
            Name = @"Column Description",
            Length = 40,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"RCD",
            DataTypeName = @"Row Column Definition",
            TableId = null,
            TableName = null,
            Description = @"Each repetition of this field consists of three components:
 
- The HL7 item number, which identifies the field occupying the column.  (Refer to Section 2.24.16.2, “Query/response format code  (ID)   00697,” for item numbering conventions). 
- The 2 or 3 character HL7 data type, as defined in Section 2.8, “Data types.” 
- The maximum width of the column, as dictated by the responding system.  (This may vary from the HL7defined maximum field length.) ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RDF.2.1",
                            Type = @"Component",
                            Position = @"RDF.2.1",
                            Name = @"HL7 Item Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HL7 item number, which identifies the field occupying the column.  (Refer to Section 2.8.30, “QIP - query input parameter list,” for item numbering conventions.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RDF.2.2",
                            Type = @"Component",
                            Position = @"RDF.2.2",
                            Name = @"HL7 Date Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The two or three character HL7 data type, as defined in Section 2.8, “Data types""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RDF.2.3",
                            Type = @"Component",
                            Position = @"RDF.2.3",
                            Name = @"Maximum Column Width",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum width of the column, as dictated by the responding system.  (This may vary from the HL7defined maximum field length.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _columnDescription = new HL7V23Field
        {
            field = message[@"RDF"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_columnDescription.field.FieldRepetitions != null && _columnDescription.field.FieldRepetitions.Count > 0)
        {
            _columnDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_columnDescription, fieldData);
        }

        return _columnDescription;
    } 
}
    }
}
