using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentRDF
    {
        private readonly HL7V2Message message;

        public string Id { get { return @"RDF"; } }

        public string SegmentId { get { return @"RDF"; } }
        
        public string LongName { get { return @"Table Row Definition"; } }
        
        public string Description { get { return @"The RDF segment defines the content of the row data segments (RDT) in the tabular response (RTB).
- As an optional segment in a query either a QBP or QBS, this segment can be used to limit the number of columns returned and to specify what column positions the fields occupy (where supported, these features can be used to override the defaults for the particular query).  If omitted, all fields defined for the query are returned in their default column order.
- As a required segment in a tabular response (RTB) to either a QBP or QBS, this segment defines the contents of the table row data (RDT) segments that follows. It is not necessarily an echo back of the segment as it appeared in the query."; } }
        
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
                            Name = @"Number Of Columns Per Row",
                            Length = 0,
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
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"RCD",
                            DataTypeName = @"Row Column Definition",
                            TableId = null,
                            TableName = null,
                            Description = @"Each repetition of this field consists of three components:

The segment field name that identifies the field occupying the column.  The segment field name SHALL agree with the column name as it appears in the Query Profile. Use of the @ sign as prefix to the column name is optional.
- The 2 or 3 character HL7 data type, as defined in Chapter 2.  Refer to HL7 Table 0440 - Data types for valid values.
- The maximum width of the column, as dictated by the responding system.  (This may vary from the HL7-defined maximum field length.)",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"This component contains the segment field name.

Naming conventions:
Segment field names are designated by the “@” symbol concatenated with the HL7 segment ID followed by the sequence number for the field separated by a period. See sections 2.5.2, ""Segments and segment groups"" and 2.5.3.1, ""Position (sequence within the segment)"" for a definition of segment ID and sequence number. If the field is divided into components, the designation may be suffixed with "".nn"", to identify a particular component (a suffix of “.3” indicates the third component of the field); otherwise, the whole field is assumed. If the field is further divided into subcomponents, the designation is suffixed with “.nn.mm"", which identifies the component and subcomponent requested by relative position.

Site-specific segment field names may be used. In this case, the site-specific segment ID (if the field is not being added to an existing HL7 segment) and the sequence number must be defined so that they do not conflict with existing HL7 segment IDs and field sequence numbers.
Values for this field are defined in the function-specific chapters of this specification.

Note: If the “@” is being used as one of the delimiter characters defined in MSH-2-encoding characters, it must be “escaped.”  See Section 2.7.1, ""Formatting Codes"".",
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
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0440",
                            TableName = @"Data Types",
                            Description = @"The two or three character HL7 data type. Refer to HL7 Table 0440 – Data Types for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RDF.2.3",
                            Type = @"Component",
                            Position = @"RDF.2.3",
                            Name = @"Maximum Column Width",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum width of the column, as dictated by the responding system. This may vary from the HL7-defined maximum field length.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V271SegmentRDF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field numberOfColumnsPerRow;

public HL7V271Field NumberOfColumnsPerRow
{
    get
    {
        if (numberOfColumnsPerRow != null)
        {
            return numberOfColumnsPerRow;
        }

        numberOfColumnsPerRow = new HL7V271Field
        {
            field = message[@"RDF"][1],
            Id = @"RDF.1",
            Type = @"Field",
            Position = @"RDF.1",
            Name = @"Number Of Columns Per Row",
            Length = 0,
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
        if (numberOfColumnsPerRow.field.FieldRepetitions != null && numberOfColumnsPerRow.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberOfColumnsPerRow.Id));
            var fieldRepetitions = new List<HL7V271FieldRepetition>();

            for (var i = 0; i < numberOfColumnsPerRow.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V271FieldRepetition
                {
                    fieldRepetition = numberOfColumnsPerRow.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V271Component>();

                    // there should be components per repetition
                    for (var j = 0; j < numberOfColumnsPerRow.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V271Component
                        {
                            component = numberOfColumnsPerRow.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V271SubComponent>();

                            for (var k = 0; k < numberOfColumnsPerRow.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V271SubComponent
                                {
                                    subComponent = numberOfColumnsPerRow.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            numberOfColumnsPerRow.fieldRepetitions = fieldRepetitions;
        }

        return numberOfColumnsPerRow;
    } 
}

internal HL7V271Field columnDescription;

public HL7V271Field ColumnDescription
{
    get
    {
        if (columnDescription != null)
        {
            return columnDescription;
        }

        columnDescription = new HL7V271Field
        {
            field = message[@"RDF"][2],
            Id = @"RDF.2",
            Type = @"Field",
            Position = @"RDF.2",
            Name = @"Column Description",
            Length = 0,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"RCD",
            DataTypeName = @"Row Column Definition",
            TableId = null,
            TableName = null,
            Description = @"Each repetition of this field consists of three components:

The segment field name that identifies the field occupying the column.  The segment field name SHALL agree with the column name as it appears in the Query Profile. Use of the @ sign as prefix to the column name is optional.
- The 2 or 3 character HL7 data type, as defined in Chapter 2.  Refer to HL7 Table 0440 - Data types for valid values.
- The maximum width of the column, as dictated by the responding system.  (This may vary from the HL7-defined maximum field length.)",
            Sample = @"",
        };

        // check for repetitions
        if (columnDescription.field.FieldRepetitions != null && columnDescription.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(columnDescription.Id));
            var fieldRepetitions = new List<HL7V271FieldRepetition>();

            for (var i = 0; i < columnDescription.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V271FieldRepetition
                {
                    fieldRepetition = columnDescription.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V271Component>();

                    // there should be components per repetition
                    for (var j = 0; j < columnDescription.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V271Component
                        {
                            component = columnDescription.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V271SubComponent>();

                            for (var k = 0; k < columnDescription.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V271SubComponent
                                {
                                    subComponent = columnDescription.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            columnDescription.fieldRepetitions = fieldRepetitions;
        }

        return columnDescription;
    } 
}
    }
}
