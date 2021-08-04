using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataTypeERL
    {
        public string Id { get { return @"ERL"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Error Location"; } }

        public string Description { get { return @"This data type identifies the segment and its constituent where an error has occurred."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 18; } }

        public string Usage { get { return null; } }

        public string Rpt { get { return null; } }

        public string TableId { get { return null; } }

        public string TableName { get { return null; } }

        public string Sample { get { return @""; } }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERL.1",
                            Type = @"DataTypeComponent",
                            Position = @"ERL.1",
                            Name = @"Segment Id",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the 3-letter name for the segment.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERL.2",
                            Type = @"DataTypeComponent",
                            Position = @"ERL.2",
                            Name = @"Segment Sequence",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the segment occurrence within the message.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERL.3",
                            Type = @"DataTypeComponent",
                            Position = @"ERL.3",
                            Name = @"Field Position",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the number of the field within the segment. The first field is assigned a number of 1. Field number should not be specified when referring to the entire segment.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERL.4",
                            Type = @"DataTypeComponent",
                            Position = @"ERL.4",
                            Name = @"Field Repetition",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the repetition number of the field. The first repetition is counted as 1. If a Field Position is specified, but Field Repetition is not, Field Repetition should be assumed to be 1. If Field Position is not specified, Field Repetition should not be specified.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERL.5",
                            Type = @"DataTypeComponent",
                            Position = @"ERL.5",
                            Name = @"Component Number",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the number of the component within the field. The first component is assigned a number of 1. Component number should not be specified when referring to the entire field.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERL.6",
                            Type = @"DataTypeComponent",
                            Position = @"ERL.6",
                            Name = @"Sub-component Number",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the number of the sub-component within the component. The first sub-component is assigned a number of 1. Sub-component number should not be specified when referring to the entire component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
