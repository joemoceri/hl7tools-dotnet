using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeCM_OSD
    {
        public string Id { get { return @"CM_OSD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Order Sequence"; } }

        public string Description { get { return null; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 0; } }

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
                            Id = @"CM_OSD.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_OSD.1",
                            Name = @"Sequence/results Flag",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"S for sequence conditions; R is reserved for possible future use. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_OSD.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_OSD.2",
                            Name = @"Placer Order Number Entity Identifier",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Uses two subcomponents since the placer order number has two components",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_OSD.3",
                            Type = @"DataTypeComponent",
                            Position = @"CM_OSD.3",
                            Name = @"Placer Order Number Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Uses two subcomponents since the placer order number has two components",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_OSD.4",
                            Type = @"DataTypeComponent",
                            Position = @"CM_OSD.4",
                            Name = @"Filler Order Number Entity Identifier",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Uses two subcomponents since the filler order number has two components",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_OSD.5",
                            Type = @"DataTypeComponent",
                            Position = @"CM_OSD.5",
                            Name = @"Filler Order Number Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Uses two subcomponents since the filler order number has two components",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_OSD.6",
                            Type = @"DataTypeComponent",
                            Position = @"CM_OSD.6",
                            Name = @"Sequence Condition Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The acceptable condition values have the form commonly used in project planning methodologies

<one of ""SS"", ""EE"", ""SE"", or ""ES""> +/- <time>

The first letter stands for start (S) or end (E) of predecessor order, where the predecessor is defined by the placer or filler order number in subcomponents 1,2 or subcomponents 3,4. 
 
The second letter stands for the start (S) or end (E) of the successor order, where the successor order is the order containing this quantity/timing specification. 
 
The time specifies the interval between the predecessor and successor starts or ends ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_OSD.7",
                            Type = @"DataTypeComponent",
                            Position = @"CM_OSD.7",
                            Name = @"Maximum Number Of Repeats",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum number of repeats to be used only on cyclic groups.  The total number of repeats is constrained by the end date/time of the last repeat or the end date/time of the parent, whichever is first.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
