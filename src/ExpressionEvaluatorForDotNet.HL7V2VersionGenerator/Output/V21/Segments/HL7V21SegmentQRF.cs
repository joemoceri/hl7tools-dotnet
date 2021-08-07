using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentQRF
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"QRF"; } }

        public string SegmentId { get { return @"QRF"; } }
        
        public string LongName { get { return @"Query Filter"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Id = @"QRF.1",
                            Type = @"Field",
                            Position = @"QRF.1",
                            Name = @"Where Subject Filter",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.2",
                            Type = @"Field",
                            Position = @"QRF.2",
                            Name = @"When Data Start Date/Time",
                            Length = 19,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.3",
                            Type = @"Field",
                            Position = @"QRF.3",
                            Name = @"When Data End Date/Time",
                            Length = 19,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.4",
                            Type = @"Field",
                            Position = @"QRF.4",
                            Name = @"What User Qualifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.5",
                            Type = @"Field",
                            Position = @"QRF.5",
                            Name = @"Other Qry Subject Filter",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentQRF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field whereSubjectFilter;

public HL7V21Field WhereSubjectFilter
{
    get
    {
        if (whereSubjectFilter != null)
        {
            return whereSubjectFilter;
        }

        whereSubjectFilter = new HL7V21Field
        {
            field = message[@"QRF"][1],
            Id = @"QRF.1",
            Type = @"Field",
            Position = @"QRF.1",
            Name = @"Where Subject Filter",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return whereSubjectFilter;
    } 
}
internal HL7V21Field whenDataStartDateTime;

public HL7V21Field WhenDataStartDateTime
{
    get
    {
        if (whenDataStartDateTime != null)
        {
            return whenDataStartDateTime;
        }

        whenDataStartDateTime = new HL7V21Field
        {
            field = message[@"QRF"][2],
            Id = @"QRF.2",
            Type = @"Field",
            Position = @"QRF.2",
            Name = @"When Data Start Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return whenDataStartDateTime;
    } 
}
internal HL7V21Field whenDataEndDateTime;

public HL7V21Field WhenDataEndDateTime
{
    get
    {
        if (whenDataEndDateTime != null)
        {
            return whenDataEndDateTime;
        }

        whenDataEndDateTime = new HL7V21Field
        {
            field = message[@"QRF"][3],
            Id = @"QRF.3",
            Type = @"Field",
            Position = @"QRF.3",
            Name = @"When Data End Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return whenDataEndDateTime;
    } 
}
internal HL7V21Field whatUserQualifier;

public HL7V21Field WhatUserQualifier
{
    get
    {
        if (whatUserQualifier != null)
        {
            return whatUserQualifier;
        }

        whatUserQualifier = new HL7V21Field
        {
            field = message[@"QRF"][4],
            Id = @"QRF.4",
            Type = @"Field",
            Position = @"QRF.4",
            Name = @"What User Qualifier",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return whatUserQualifier;
    } 
}
internal HL7V21Field otherQrySubjectFilter;

public HL7V21Field OtherQrySubjectFilter
{
    get
    {
        if (otherQrySubjectFilter != null)
        {
            return otherQrySubjectFilter;
        }

        otherQrySubjectFilter = new HL7V21Field
        {
            field = message[@"QRF"][5],
            Id = @"QRF.5",
            Type = @"Field",
            Position = @"QRF.5",
            Name = @"Other Qry Subject Filter",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return otherQrySubjectFilter;
    } 
}

    }
}
