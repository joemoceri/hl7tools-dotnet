using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentRDF
    {
        public HL7V2Message message { get; init; }

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
                            Description = @"Each repetition of this field consists of three components:",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RDF.2.1",
                            Type = @"Component",
                            Position = @"RDF.2.1",
                            Name = @"Segment Field Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HL7 segment field name, which identifies the field occupying the column. (Refer to Section 2.9.33.1, Segment field name (ST), for segment field name definition conventions.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RDF.2.2",
                            Type = @"Component",
                            Position = @"RDF.2.2",
                            Name = @"Hl7 Data Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0440",
                            TableName = @"Data types",
                            Description = @"The two or three character HL7 data type. Refer to HL7 Table 0440 - Data Types for valid values.",
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
                            Description = @"The maximum width of the column, as dictated by the responding system. (This may vary from the HL7-defined maximum field length.)",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V24SegmentRDF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field numberofColumnsperRow;

public HL7V24Field NumberofColumnsperRow
{
    get
    {
        if (numberofColumnsperRow != null)
        {
            return numberofColumnsperRow;
        }

        numberofColumnsperRow = new HL7V24Field
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

        // check for repetitions
        if (numberofColumnsperRow.field.FieldRepetitions != null && numberofColumnsperRow.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberofColumnsperRow.Id));
            numberofColumnsperRow.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(numberofColumnsperRow, fieldData);
        }

        return numberofColumnsperRow;
    } 
}

internal HL7V24Field columnDescription;

public HL7V24Field ColumnDescription
{
    get
    {
        if (columnDescription != null)
        {
            return columnDescription;
        }

        columnDescription = new HL7V24Field
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
            Description = @"Each repetition of this field consists of three components:",
            Sample = @"",
        };

        // check for repetitions
        if (columnDescription.field.FieldRepetitions != null && columnDescription.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(columnDescription.Id));
            columnDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(columnDescription, fieldData);
        }

        return columnDescription;
    } 
}
    }
}
