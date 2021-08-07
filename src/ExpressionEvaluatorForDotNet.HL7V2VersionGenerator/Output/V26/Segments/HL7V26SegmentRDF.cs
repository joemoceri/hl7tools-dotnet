using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentRDF
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"RDF"; } }

        public string SegmentId { get { return @"RDF"; } }
        
        public string LongName { get { return @"Table Row Definition"; } }
        
        public string Description { get { return @"The RDF segment defines the content of the row data segments (RDT) in the tabular response (RTB)."; } }
        
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
                            Description = @"This field specifies the number of data columns (and therefore the number of fields) contained within each row of returned data.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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

The segment field name that identifies the field occupying the column.  The segment field name must agree with the column name as it appears in the Query Profile. Use of the @ sign as prefix to the column name is optional.

The 2 or 3 character HL7 data type, as defined in Chapter 2.  Refer to HL7 Table 0440 - Data types for valid values.

The maximum width of the column, as dictated by the responding system.  (This may vary from the HL7-defined maximum field length.)",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RDF.2.1",
                            Type = @"Component",
                            Position = @"RDF.2.1",
                            Name = @"Segment Field Name",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HL7 segment field name, which identifies the field occupying the column. Refer to Section 2.A.59.1, ""Segment Field Name (ST),"" for segment field name definition conventions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RDF.2.2",
                            Type = @"Component",
                            Position = @"RDF.2.2",
                            Name = @"Hl7 Data Type",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0440",
                            TableName = @"Data types",
                            Description = @"The two or three character HL7 data type. Refer to HL7 Table 0440 - Data Types in section 2.15, ""Data Types"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RDF.2.3",
                            Type = @"Component",
                            Position = @"RDF.2.3",
                            Name = @"Maximum Column Width",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum width of the column, as dictated by the responding system. This may vary from the HL7-defined maximum field length.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V26SegmentRDF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field numberofColumnsperRow;

public HL7V26Field NumberofColumnsperRow
{
    get
    {
        if (numberofColumnsperRow != null)
        {
            return numberofColumnsperRow;
        }

        numberofColumnsperRow = new HL7V26Field
        {
            field = message[@"RDF"][1],
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
            Description = @"This field specifies the number of data columns (and therefore the number of fields) contained within each row of returned data.",
            Sample = @"",
        };

        

        

        

        return numberofColumnsperRow;
    } 
}
internal HL7V26Field columnDescription;

public HL7V26Field ColumnDescription
{
    get
    {
        if (columnDescription != null)
        {
            return columnDescription;
        }

        columnDescription = new HL7V26Field
        {
            field = message[@"RDF"][2],
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

The segment field name that identifies the field occupying the column.  The segment field name must agree with the column name as it appears in the Query Profile. Use of the @ sign as prefix to the column name is optional.

The 2 or 3 character HL7 data type, as defined in Chapter 2.  Refer to HL7 Table 0440 - Data types for valid values.

The maximum width of the column, as dictated by the responding system.  (This may vary from the HL7-defined maximum field length.)",
            Sample = @"",
        };

        

        

        

        return columnDescription;
    } 
}

    }
}
