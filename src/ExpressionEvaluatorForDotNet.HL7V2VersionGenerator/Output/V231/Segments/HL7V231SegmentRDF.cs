using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentRDF
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RDF"; } }

        public string SegmentId { get { return @"RDF"; } }
        
        public string LongName { get { return @"Table row definition segment"; } }
        
        public string Description { get { return @"The RDF segment defines the content of the row data segments (RDT) in the Tabular Data Response Message (TBR). It is used in two ways:"; } }
        
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

        public HL7V231SegmentRDF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _numberofColumnsperRow;

public HL7V231Field NumberofColumnsperRow
{
    get
    {
        if (_numberofColumnsperRow != null)
        {
            return _numberofColumnsperRow;
        }

        var fieldData = new HL7V231FieldData
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
            Fields = null
        }

        _numberofColumnsperRow = new HL7V231Field
        {
            field = message[@"RDF"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberofColumnsperRow.field.FieldRepetitions != null && _numberofColumnsperRow.field.FieldRepetitions.Count > 0)
        {
            _numberofColumnsperRow.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_numberofColumnsperRow, fieldData);
        }

        return _numberofColumnsperRow;
    } 
}

internal HL7V231Field _columnDescription;

public HL7V231Field ColumnDescription
{
    get
    {
        if (_columnDescription != null)
        {
            return _columnDescription;
        }

        var fieldData = new HL7V231FieldData
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
            Fields = new[]
                        {
                            new HL7V2FieldData
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
                            Description = @"The HL7 segment field name, which identifies the field occupying the column. (Refer to Section 2.8.32, QIP - query input parameter list, for segment field name definition conventions.)",
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
                            TableId = null,
                            TableName = null,
                            Description = @"The two or three character HL7 data type, as defined in Section 2.8, Data types.",
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
                        },
                        }
        }

        _columnDescription = new HL7V231Field
        {
            field = message[@"RDF"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_columnDescription.field.FieldRepetitions != null && _columnDescription.field.FieldRepetitions.Count > 0)
        {
            _columnDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_columnDescription, fieldData);
        }

        return _columnDescription;
    } 
}
    }
}
